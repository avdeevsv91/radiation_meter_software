using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Xml;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RadiationMeter
{
    public partial class MainForm : Form
    {
        public static CultureInfo Culture;
        public static ResourceManager Translate;
        private string[] RunArguments;
        private int LastNotify = 0;
        // Подключение
        private int ConnectionType = -1;
        private SerialPort ComPort;
        private System.Threading.Timer HttpTimer;
        // Данные с датчика
        private struct radiationData
        {
            public DateTime time;
            public int accuracy;
            public float value;
        }
        private struct sensorData
        {
            public string unit;
            public List<radiationData> radiation;
            public sensorData(string _unit, List<radiationData> _radiation) : this()
            {
                this.unit = _unit;
                this.radiation = _radiation;
            }
        }
        private sensorData DATA = new sensorData(string.Empty, new List<radiationData>());

        // Приняты данные с COM порта
        private void ComPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = string.Empty;
            try
            {
                line = ComPort.ReadLine();
            }
            catch
            {
            }
            finally
            {
                if(line.Length > 0)
                {
                    this.BeginInvoke(new LineReceivedEvent(Data_LineReceived), line.Trim());
                }
            }
        }

        // Получение данных по HTTP
        private void HttpTimer_GetData(object obj)
        {
            string radiation_line = string.Empty;
            string accuracy_line = "100%";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.http_url);
                request.UserAgent = Properties.Settings.Default.http_useragent;
                if (Properties.Settings.Default.http_method == 0)
                {
                    request.Method = WebRequestMethods.Http.Get;
                } else
                {
                    request.Method = WebRequestMethods.Http.Post;
                    request.ContentType = "application/x-www-form-urlencoded";
                    byte[] dataBytes = Encoding.UTF8.GetBytes(Properties.Settings.Default.http_data);
                    request.ContentLength = dataBytes.Length;
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(dataBytes, 0, dataBytes.Length);
                    requestStream.Close();
                }
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string http_line = string.Empty;
                        string http_data = string.Empty;
                        while ((http_line = reader.ReadLine()) != null)
                        {
                            http_data = http_data + http_line + Environment.NewLine;
                        }
                        switch(Properties.Settings.Default.http_response)
                        {
                            case 0: // JSON
                                var JSON = XElement.Load(JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(http_data), new System.Xml.XmlDictionaryReaderQuotas()));
                                // Точность
                                if (Properties.Settings.Default.http_accuracy)
                                {
                                    string JsonValue = JSON.XPathSelectElement(Properties.Settings.Default.http_accuracy_exp).Value;
                                    if (JsonValue.IndexOf(".") > -1 || JsonValue.IndexOf(",") > -1)
                                    {
                                        accuracy_line = Math.Round((decimal)float.Parse(Regex.Match(JsonValue.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture)).ToString() + "%";
                                    }
                                    else
                                    {
                                        accuracy_line = Int32.Parse(Regex.Match(JsonValue, @"\d+").Value).ToString() + "%";
                                    }
                                }
                                // Радиация
                                if (Properties.Settings.Default.http_radiation)
                                {
                                    string JsonValue = JSON.XPathSelectElement(Properties.Settings.Default.http_radiation_exp).Value;
                                    if (JsonValue.IndexOf(".") > -1 || JsonValue.IndexOf(",") > -1)
                                    {
                                        radiation_line = Math.Round((decimal)float.Parse(Regex.Match(JsonValue.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture), 2).ToString() + " " + Properties.Settings.Default.http_unit;
                                    }
                                    else
                                    {
                                        radiation_line = Int32.Parse(Regex.Match(JsonValue, @"\d+").Value).ToString() + " " + Properties.Settings.Default.http_unit;
                                    }
                                }
                                break;
                            case 1: // XML
                                XmlDocument XML = new XmlDocument();
                                XML.LoadXml(http_data);
                                // Точность
                                if (Properties.Settings.Default.http_accuracy)
                                {
                                    XmlNode node = XML.DocumentElement.SelectSingleNode(Properties.Settings.Default.http_accuracy_exp);
                                    if (node.InnerText.IndexOf(".") > -1 || node.InnerText.IndexOf(",") > -1)
                                    {
                                        accuracy_line = Math.Round((decimal)float.Parse(Regex.Match(node.InnerText.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture)).ToString() + "%";
                                    }
                                    else
                                    {
                                        accuracy_line = Int32.Parse(Regex.Match(node.InnerText, @"\d+").Value).ToString() + "%";
                                    }
                                }
                                // Радиация
                                if (Properties.Settings.Default.http_radiation)
                                {
                                    XmlNode node = XML.DocumentElement.SelectSingleNode(Properties.Settings.Default.http_radiation_exp);
                                    if (node.InnerText.IndexOf(".") > -1 || node.InnerText.IndexOf(",") > -1)
                                    {
                                        radiation_line = Math.Round((decimal)float.Parse(Regex.Match(node.InnerText.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture), 2).ToString() + " " + Properties.Settings.Default.http_unit;
                                    }
                                    else
                                    {
                                        radiation_line = Int32.Parse(Regex.Match(node.InnerText, @"\d+").Value).ToString() + " " + Properties.Settings.Default.http_unit;
                                    }
                                }
                                break;
                            case 2: // RegExp
                                // Точность
                                if (Properties.Settings.Default.http_accuracy)
                                {
                                    Regex regex = new Regex(Properties.Settings.Default.http_accuracy_exp);
                                    MatchCollection matches = regex.Matches(http_data);
                                    if (matches.Count > 0)
                                    {
                                        string RegexValue = matches[0].Groups[1].Value;
                                        if (RegexValue.IndexOf(".") > -1 || RegexValue.IndexOf(",") > -1)
                                        {
                                            accuracy_line = Math.Round((decimal)float.Parse(Regex.Match(RegexValue.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture)).ToString() + "%";
                                        }
                                        else
                                        {
                                            accuracy_line = Int32.Parse(Regex.Match(RegexValue, @"\d+").Value).ToString() + "%";
                                        }
                                    }
                                }
                                // Радиация
                                if (Properties.Settings.Default.http_radiation)
                                {
                                    Regex regex = new Regex(Properties.Settings.Default.http_radiation_exp);
                                    MatchCollection matches = regex.Matches(http_data);
                                    if (matches.Count > 0)
                                    {
                                        string RegexValue = matches[0].Groups[1].Value;
                                        if (RegexValue.IndexOf(".") > -1 || RegexValue.IndexOf(",") > -1)
                                        {
                                            radiation_line = Math.Round((decimal)float.Parse(Regex.Match(RegexValue.Replace(",", "."), @"[\d.]+").Value, CultureInfo.InvariantCulture), 2).ToString() + " " + Properties.Settings.Default.http_unit;
                                        }
                                        else
                                        {
                                            radiation_line = Int32.Parse(Regex.Match(RegexValue, @"\d+").Value).ToString() + " " + Properties.Settings.Default.http_unit;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                }
                response.Close();
            }
            catch
            {
            }
            finally
            {
                this.BeginInvoke(new LineReceivedEvent(Data_LineReceived), radiation_line.Trim() + ":" + accuracy_line.Trim());
            }
        }

        // Принята строка с данными
        private delegate void LineReceivedEvent(string line);
        private void Data_LineReceived(string line)
        {
            if (line.Length > 0)
            {
                string[] data = line.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                if(data.Length == 2)
                {
                    string[] rdata = data[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(rdata.Length == 2)
                    {
                        // Удаляем старые данные
                        while (DATA.radiation.FindAll(item => item.accuracy >= Properties.Settings.Default.min_accuracy).Count() > Properties.Settings.Default.max_data)
                        {
                            DATA.radiation.RemoveAt(0);
                        }
                        // Добавляем новые данные
                        var rd = new radiationData();
                        rd.time = DateTime.Now;
                        rd.accuracy = Int32.Parse(Regex.Match(data[1].Trim(), @"\d+").Value);
                        rd.value = float.Parse(Regex.Match(rdata[0].Trim(), @"[\d.]+").Value, CultureInfo.InvariantCulture);
                        DATA.radiation.Add(rd);
                        DATA.unit = rdata[1].Trim();
                        // Обновляем отображаемую информацию
                        RadiationLabel.Text = DATA.radiation.Last().value.ToString() + " " + DATA.unit;
                        AccuracyLabel.Text = String.Format(Translate.GetString("accuracy", Culture), DATA.radiation.Last().accuracy.ToString() + "%");
                        List<radiationData> all_items = DATA.radiation.FindAll(item => item.accuracy >= Properties.Settings.Default.min_accuracy);
                        if (all_items.Count() > 0)
                        {
                            radiationData last_item = DATA.radiation.FindLast(item => item.accuracy >= Properties.Settings.Default.min_accuracy);
                            // Интерфейс
                            RadiationChart.ChartAreas.FindByName("RadiationChartArea").AxisY.Title = DATA.unit;
                            notifyIcon.Text = Application.ProductName + " [" + last_item.value.ToString() + " " + DATA.unit + "]";
                            // График
                            if (all_items.Count() > 1) {
                                RadiationChart.Annotations.FindByName("NoDataAnnotation").Visible = false;
                                RadiationChart.Series.FindByName("RadiationSeries").Points.Clear();
                                foreach (var item in all_items)
                                {
                                    RadiationChart.Series.FindByName("RadiationSeries").Points.AddXY(item.time, item.value);
                                }
                            }
                            // Уровни радиации и оповещения
                            if (last_item.value < Properties.Settings.Default.warning_level) // Нормальный уровень
                            {
                                RadiationLabel.ForeColor = System.Drawing.Color.Green;
                                if (LastNotify != 1)
                                {
                                    if (Properties.Settings.Default.voice_notify) // Голосовые уведомления
                                    {
                                        System.IO.UnmanagedMemoryStream player_file = Properties.Resources.ResourceManager.GetStream("normal_" + Culture.TwoLetterISOLanguageName);
                                        player_file = (player_file == null ? Properties.Resources.normal_en : player_file);
                                        System.Media.SoundPlayer sound_player = new System.Media.SoundPlayer(player_file);
                                        sound_player.Play();
                                    }
                                    if (notifyIcon.Visible && Properties.Settings.Default.tray_notify) // Уведомления в системном трее
                                    {
                                        notifyIcon.ShowBalloonTip(5000, Translate.GetString("tray_normal", Culture), String.Format(Translate.GetString("current_value", Culture), RadiationLabel.Text), ToolTipIcon.Info);
                                    }
                                    LastNotify = 1;
                                }
                            }
                            else if (last_item.value >= Properties.Settings.Default.warning_level && last_item.value < Properties.Settings.Default.danger_level) // Повышенный уровень
                            {
                                RadiationLabel.ForeColor = System.Drawing.Color.Orange;
                                if (LastNotify != 2)
                                {
                                    if (Properties.Settings.Default.voice_notify) // Голосовые уведомления
                                    {
                                        System.IO.UnmanagedMemoryStream player_file = Properties.Resources.ResourceManager.GetStream("warning_" + Culture.TwoLetterISOLanguageName);
                                        player_file = (player_file == null ? Properties.Resources.warning_en : player_file);
                                        System.Media.SoundPlayer sound_player = new System.Media.SoundPlayer(player_file);
                                        sound_player.Play();
                                    }
                                    if (notifyIcon.Visible && Properties.Settings.Default.tray_notify) // Уведомления в системном трее
                                    {
                                        notifyIcon.ShowBalloonTip(5000, Translate.GetString("tray_warning", Culture), String.Format(Translate.GetString("current_value", Culture), RadiationLabel.Text), ToolTipIcon.Warning);
                                    }
                                    LastNotify = 2;
                                }
                            }
                            else // Опасный уровень
                            {
                                RadiationLabel.ForeColor = System.Drawing.Color.Red;
                                if (LastNotify != 3)
                                {
                                    if (Properties.Settings.Default.voice_notify) // Голосовые уведомления
                                    {
                                        System.IO.UnmanagedMemoryStream player_file = Properties.Resources.ResourceManager.GetStream("danger_" + Culture.TwoLetterISOLanguageName);
                                        player_file = (player_file == null ? Properties.Resources.danger_en : player_file);
                                        System.Media.SoundPlayer sound_player = new System.Media.SoundPlayer(player_file);
                                        sound_player.Play();
                                    }
                                    if (notifyIcon.Visible && Properties.Settings.Default.tray_notify) // Уведомления в системном трее
                                    {
                                        notifyIcon.ShowBalloonTip(5000, Translate.GetString("tray_danger", Culture), String.Format(Translate.GetString("current_value", Culture), RadiationLabel.Text), ToolTipIcon.Error);
                                    }
                                    LastNotify = 3;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Инициализация главного окна
        public MainForm(string[] args)
        {
            InitializeComponent();
            RunArguments = args.Select(item => item.ToLowerInvariant()).ToArray();
            ComPort = new SerialPort();
            // Параметры окна
            this.Icon = Properties.Resources.icon;
            this.Text = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;
            // Параметры иконки в системном трее
            notifyIcon.Icon = Properties.Resources.icon;
            notifyIcon.Text = this.Text;
            // Перевод
            Translate = new ResourceManager("RadiationMeter.Languages.Translate", typeof(MainForm).Assembly);
            Culture = (Properties.Settings.Default.language.Length > 0) ? CultureInfo.CreateSpecificCulture(Properties.Settings.Default.language) : CultureInfo.CurrentCulture;
        }

        // Перезагрузка формы (при смене языка)
        public void reloadForm()
        {
            MainForm_Load(this, null);
        }

        // Главное окно загружено
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Перевод интерфейса
            ((TextAnnotation)RadiationChart.Annotations.FindByName("NoDataAnnotation")).Text = Translate.GetString("no_data", Culture);
            if (DATA.radiation.Count() == 0)
            {
                RadiationLabel.Text = Translate.GetString("not_available", Culture);
            }
            ButtonConnect.Text = Translate.GetString((ComPort.IsOpen ? "disconnect" : "connect"), Culture);
            RadiationGroupBox.Text = Translate.GetString("radiation_level", Culture);
            AccuracyLabel.Text = String.Format(Translate.GetString("accuracy", Culture), (DATA.radiation.Count() == 0 ? Translate.GetString("not_available", Culture) : DATA.radiation.Last().accuracy.ToString() + "%"));
            SettingsButton.Text = Translate.GetString("settings", Culture);
            AboutButton.Text = Translate.GetString("about", Culture);
            // Выполняется только при запуске
            if(e != null)
            {
                // Автоподключение
                if (RunArguments.Contains("/connect"))
                {
                    ButtonConnect.PerformClick();
                }
                // Минимизировать
                if (RunArguments.Contains("/minimize"))
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                // Максимизировать
                if (RunArguments.Contains("/maximize"))
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        // Изменение размера главного окна
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized) // Свернули окно
            {
                if(Properties.Settings.Default.tray_minimize)
                {
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        this.Hide();
                        notifyIcon.Visible = true;
                    }));
                }
            }
            else
            {
                Control control = (Control)sender;
                ControlPanel.Left = control.Size.Width - ControlPanel.Size.Width - 24;
                RadiationChart.Width = control.Size.Width - ControlPanel.Size.Width - 42;
                RadiationChart.Height = control.Size.Height - 62;
            }
        }

        // Кнопка "Подключиться"/"Отключиться"
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            LastNotify = 0;
            DATA.radiation.Clear();
            RadiationChart.Series.FindByName("RadiationSeries").Points.Clear();
            RadiationChart.Annotations.FindByName("NoDataAnnotation").Visible = true;
            if (ConnectionType < 0) // Подключаемся
            {
                Boolean ConnectionResult = false;
                try
                {
                    switch (Properties.Settings.Default.data_source)
                    {
                        case 0: // COM порт
                            ComPort.PortName = Properties.Settings.Default.com_port;
                            ComPort.BaudRate = Properties.Settings.Default.baud_rate;
                            switch(Properties.Settings.Default.parity)
                            {
                                case 0: ComPort.Parity = Parity.Even; break;
                                case 1: ComPort.Parity = Parity.Odd; break;
                                case 2: ComPort.Parity = Parity.None; break;
                                case 3: ComPort.Parity = Parity.Mark; break;
                                case 4: ComPort.Parity = Parity.Space; break;
                            }
                            ComPort.DataBits = Properties.Settings.Default.data_bits;
                            switch (Properties.Settings.Default.stop_bits)
                            {
                                case 0: ComPort.StopBits = StopBits.One; break;
                                case 1: ComPort.StopBits = StopBits.OnePointFive; break;
                                case 2: ComPort.StopBits = StopBits.Two; break;
                            }
                            ComPort.Open();
                            ComPort.DataReceived += ComPort_DataReceived;
                            break;
                        case 1: // HTTP запрос
                            TimerCallback timer_callback = new TimerCallback(HttpTimer_GetData);
                            HttpTimer = new System.Threading.Timer(timer_callback, null, 0, 1000 * Properties.Settings.Default.http_interval);
                            break;
                    }
                    ConnectionResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Translate.GetString("error", Culture), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (ConnectionResult)
                    {
                        ButtonConnect.Text = Translate.GetString("disconnect", Culture);
                        ConnectionType = Properties.Settings.Default.data_source;
                    }
                }
            } else // Отключаемся
            {
                switch(ConnectionType)
                {
                    case 0: // COM порт
                        ComPort.Close();
                        break;
                    case 1: // HTTP запрос
                        HttpTimer.Dispose();
                        break;
                }
                ButtonConnect.Text = Translate.GetString("connect", Culture);
                RadiationLabel.Text = Translate.GetString("not_available", Culture);
                RadiationLabel.ForeColor = System.Drawing.Color.Black;
                AccuracyLabel.Text = String.Format(Translate.GetString("accuracy", Culture), (DATA.radiation.Count() == 0 ? Translate.GetString("not_available", Culture) : DATA.radiation.Last().accuracy.ToString() + "%"));
                ConnectionType = -1;
            }
        }

        // Кнопка "Настройки"
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.ShowDialog(this);
        }

        // Кнопка "О программе"
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();
            AboutBox.ShowDialog(this);
        }

        // Двойное нажатие на иконку в трее
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);
        private const uint SW_RESTORE = 0x09;
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
            ShowWindow(this.Handle, SW_RESTORE);
        }
        // Закрытие программы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Properties.Settings.Default.disable_exit)
                {
                    this.WindowState = FormWindowState.Minimized;
                    e.Cancel = true;
                }
            }
        }
    }
}
