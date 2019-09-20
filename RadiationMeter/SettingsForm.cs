using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Resources;
using System.Windows.Forms;

namespace RadiationMeter
{
    public partial class SettingsForm : Form
    {
        // Инициализация окна настроек
        public SettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        // Окно настроек загружено
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            int selected_index;
            this.Text = MainForm.Translate.GetString("settings", MainForm.Culture);
            OkButton.Text = MainForm.Translate.GetString("ok", MainForm.Culture);
            CancelButton.Text = MainForm.Translate.GetString("cancel", MainForm.Culture);

            // [Общее]
            tabGeneral.Text = MainForm.Translate.GetString("general", MainForm.Culture);
            // Общее: язык интерфейса
            LanguageLabel.Text = MainForm.Translate.GetString("language", MainForm.Culture);
            LanguageComboBox.Left = LanguageLabel.Left + LanguageLabel.Width + 6;
            selected_index = 0;
            LanguageComboBox.Items.Clear();
            LanguageComboBox.Items.Add(MainForm.Translate.GetString("autodetect", MainForm.Culture));
            CultureInfo[] CulturesList = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            foreach (CultureInfo CultureItem in CulturesList)
            {
                try
                {
                    ResourceSet CultureResource = MainForm.Translate.GetResourceSet(CultureItem, true, false);
                    if (CultureResource != null)
                    {
                        int index = LanguageComboBox.Items.Add(CultureItem.NativeName[0].ToString().ToUpper() + CultureItem.NativeName.Substring(1));
                        if (Properties.Settings.Default.language == CultureItem.ToString())
                        {
                            selected_index = index;
                        }
                    }
                }
                catch
                {
                }
            }
            LanguageComboBox.SelectedIndex = selected_index;
            // Общее: источник данных
            DataSourceLabel.Text = MainForm.Translate.GetString("data_source", MainForm.Culture);
            DataSourceComboBox.Left = DataSourceLabel.Left + DataSourceLabel.Width + 6;
            DataSourceComboBox.Items.Clear();
            DataSourceComboBox.Items.Add(MainForm.Translate.GetString("com_port", MainForm.Culture));
            DataSourceComboBox.Items.Add(MainForm.Translate.GetString("http_request", MainForm.Culture));
            DataSourceComboBox.SelectedIndex = Properties.Settings.Default.data_source;
            // Общее: минимальная точность
            MinAccuracyLabel.Text = MainForm.Translate.GetString("min_accuracy", MainForm.Culture);
            MinAccuracyNumericUpDown.Left = MinAccuracyLabel.Left + MinAccuracyLabel.Width + 6;
            MinAccuracyNumericUpDown.Value = Properties.Settings.Default.min_accuracy;
            // Общее: размер буфера
            MaxDataLabel.Text = MainForm.Translate.GetString("max_data", MainForm.Culture);
            MaxDataNumericUpDown.Left = MaxDataLabel.Left + MaxDataLabel.Width + 6;
            MaxDataNumericUpDown.Value = Properties.Settings.Default.max_data;
            // Общее: сворачивать в системный трей
            SysTrayCheckBox.Text = MainForm.Translate.GetString("tray_minimize", MainForm.Culture);
            SysTrayCheckBox.Checked = Properties.Settings.Default.tray_minimize;
            // Общее: отключить кнопку выхода
            DisableExitCheckBox.Text = MainForm.Translate.GetString("disable_exit", MainForm.Culture);
            DisableExitCheckBox.Checked = Properties.Settings.Default.disable_exit;

            // [COM порт]
            tabCOMport.Text = MainForm.Translate.GetString("com_port", MainForm.Culture);
            // COM порт: выбор порта (combo box)
            SelectPortRadioButton.Text = MainForm.Translate.GetString("select_com_port", MainForm.Culture);
            ComPortComboBox.Left = SelectPortRadioButton.Left + SelectPortRadioButton.Width + 6;
            selected_index = -1;
            string[] ports = SerialPort.GetPortNames();
            ComPortComboBox.Items.Clear();
            foreach (var port in ports)
            {
                int index = ComPortComboBox.Items.Add(port);
                if (port == Properties.Settings.Default.com_port)
                {
                    selected_index = index;
                    SelectPortRadioButton.Checked = true;
                }
            }
            ComPortComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);
            SelectPortRadioButton_CheckedChanged(this, null);
            // COM порт: выбор порта (text box)
            ComPortCustomRadioButton.Left = ComPortComboBox.Left + ComPortComboBox.Width + 6;
            ComPortCustomRadioButton.Text = MainForm.Translate.GetString("com_port_custom", MainForm.Culture);
            ComPortTextBox.Left = ComPortCustomRadioButton.Left + ComPortCustomRadioButton.Width + 6;
            ComPortTextBox.Text = (selected_index < 0 ? Properties.Settings.Default.com_port : string.Empty);
            ComPortCustomRadioButton.Checked = (selected_index < 0);
            ComPortCustomRadioButton_CheckedChanged(this, null);
            // COM порт: скорость (combo box)
            BaudRateRadioButton.Text = MainForm.Translate.GetString("baud_rate", MainForm.Culture);
            BaudRateComboBox.Left = BaudRateRadioButton.Left + BaudRateRadioButton.Width + 6;
            selected_index = -1;
            string[] baud_rates = { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "57600", "115200", "128000", "256000" };
            BaudRateComboBox.Items.Clear();
            foreach (var baud_rate in baud_rates)
            {
                int index = BaudRateComboBox.Items.Add(baud_rate);
                if (baud_rate == Properties.Settings.Default.baud_rate.ToString())
                {
                    selected_index = index;
                    BaudRateRadioButton.Checked = true;
                }
            }
            BaudRateComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);
            BaudRateRadioButton_CheckedChanged(this, null);
            // COM порт: скорость (text box)
            BaudRateCustomRadioButton.Left = BaudRateComboBox.Left + BaudRateComboBox.Width + 6;
            BaudRateCustomRadioButton.Text = MainForm.Translate.GetString("baud_rate_custom", MainForm.Culture);
            BaudRateTextBox.Left = BaudRateCustomRadioButton.Left + BaudRateCustomRadioButton.Width + 6;
            BaudRateTextBox.Text = (selected_index < 0 ? Properties.Settings.Default.baud_rate.ToString() : string.Empty);
            BaudRateCustomRadioButton.Checked = (selected_index < 0);
            BaudRateCustomRadioButton_CheckedChanged(this, null);
            // COM порт: биты данных
            DataBitsLabel.Text = MainForm.Translate.GetString("data_bits", MainForm.Culture);
            DataBitsComboBox.Left = DataBitsLabel.Left + DataBitsLabel.Width + 6;
            selected_index = -1;
            string[] data_bits = { "4", "5", "6", "7", "8" };
            DataBitsComboBox.Items.Clear();
            foreach (var data_bit in data_bits)
            {
                int index = DataBitsComboBox.Items.Add(data_bit);
                if (data_bit == Properties.Settings.Default.data_bits.ToString())
                {
                    selected_index = index;
                }
            }
            DataBitsComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);
            // COM порт: стоповые биты
            StopBitsLabel.Text = MainForm.Translate.GetString("stop_bits", MainForm.Culture);
            StopBitsComboBox.Left = StopBitsLabel.Left + StopBitsLabel.Width + 6;
            selected_index = -1;
            string[] stop_bits = { "1", "1.5", "2" };
            StopBitsComboBox.Items.Clear();
            foreach (var stop_bit in stop_bits)
            {
                int index = StopBitsComboBox.Items.Add(stop_bit);
                if (index == Properties.Settings.Default.stop_bits)
                {
                    selected_index = index;
                }
            }
            StopBitsComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);
            // COM порт: четность
            ParityLabel.Text = MainForm.Translate.GetString("parity", MainForm.Culture);
            ParityComboBox.Left = ParityLabel.Left + ParityLabel.Width + 6;
            selected_index = -1;
            string[] paritys = {
                MainForm.Translate.GetString("parity_even", MainForm.Culture),
                MainForm.Translate.GetString("parity_odd", MainForm.Culture),
                MainForm.Translate.GetString("parity_none", MainForm.Culture),
                MainForm.Translate.GetString("parity_mark", MainForm.Culture),
                MainForm.Translate.GetString("parity_space", MainForm.Culture)
            };
            ParityComboBox.Items.Clear();
            foreach (var parity in paritys)
            {
                int index = ParityComboBox.Items.Add(parity);
                if (index == Properties.Settings.Default.parity)
                {
                    selected_index = index;
                }
            }
            ParityComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);

            // [HTTP запрос]
            tabHTTP.Text = MainForm.Translate.GetString("http_request", MainForm.Culture);
            // HTTP запрос: параметры запроса
            HttpUrlLabel.Text = MainForm.Translate.GetString("http_url", MainForm.Culture);
            HttpUrlTextBox.Left = HttpUrlLabel.Left + HttpUrlLabel.Width + 6;
            HttpUrlTextBox.Text = Properties.Settings.Default.http_url;
            HttpMethodPanel.Left = HttpUrlTextBox.Left + HttpUrlTextBox.Width + 6;
            HttpMethodPanel.Width = tabHTTP.Width - HttpMethodPanel.Left - 6;
            HttpGetRadioButton.Text = MainForm.Translate.GetString("http_get", MainForm.Culture);
            HttpGetRadioButton.Checked = (Properties.Settings.Default.http_method == 0);
            HttpPostRadioButton.Left = HttpGetRadioButton.Left + HttpGetRadioButton.Width + 6;
            HttpPostRadioButton.Text = MainForm.Translate.GetString("http_post", MainForm.Culture);
            HttpPostRadioButton.Checked = (Properties.Settings.Default.http_method == 1);
            HttpPostRadioButton_CheckedChanged(this, null);
            HttpDataLabel.Text = MainForm.Translate.GetString("http_data", MainForm.Culture);
            HttpDataTextBox.Left = HttpDataLabel.Left + HttpDataLabel.Width + 6;
            HttpDataTextBox.Text = Properties.Settings.Default.http_data;
            HttpUserAgentLabel.Text = MainForm.Translate.GetString("http_useragent", MainForm.Culture);
            HttpUserAgentTextBox.Left = HttpUserAgentLabel.Left + HttpUserAgentLabel.Width + 6;
            HttpUserAgentTextBox.Text = Properties.Settings.Default.http_useragent;
            IntervalLabel.Left = HttpUserAgentTextBox.Left + HttpUserAgentTextBox.Width + 6;
            IntervalLabel.Text = MainForm.Translate.GetString("http_interval", MainForm.Culture);
            IntervalTextBox.Left = IntervalLabel.Left + IntervalLabel.Width + 6;
            IntervalTextBox.Text = Properties.Settings.Default.http_interval.ToString();
            // HTTP запрос: обработка ответа
            HttpResponseGroupBox.Text = MainForm.Translate.GetString("http_response", MainForm.Culture);
            HttpResponseMethodLabel.Text = MainForm.Translate.GetString("http_method", MainForm.Culture);
            HttpResponseMethodComboBox.Left = HttpResponseMethodLabel.Left + HttpResponseMethodLabel.Width + 6;
            selected_index = -1;
            string[] methods = { "JSON", "XML", "RegExp" };
            HttpResponseMethodComboBox.Items.Clear();
            foreach (var method in methods)
            {
                int index = HttpResponseMethodComboBox.Items.Add(method);
                if (index == Properties.Settings.Default.http_response)
                {
                    selected_index = index;
                }
            }
            HttpResponseMethodComboBox.SelectedIndex = (selected_index < 0 ? 0 : selected_index);
            HttpExpressionsGroupBox.Text = MainForm.Translate.GetString("http_expressions", MainForm.Culture);
            HttpAccuracyCheckBox.Text = MainForm.Translate.GetString("http_accuracy", MainForm.Culture);
            HttpAccuracyCheckBox.Checked = Properties.Settings.Default.http_accuracy;
            HttpAccuracyCheckBox_CheckedChanged(this, null);
            HttpAccuracyTextBox.Left = HttpAccuracyCheckBox.Left + HttpAccuracyCheckBox.Width + 6;
            HttpAccuracyTextBox.Text = Properties.Settings.Default.http_accuracy_exp;
            HttpRadiationCheckBox.Text = MainForm.Translate.GetString("http_radiation", MainForm.Culture);
            HttpRadiationCheckBox.Checked = Properties.Settings.Default.http_radiation;
            HttpRadiationCheckBox_CheckedChanged(this, null);
            HttpRadiationTextBox.Left = HttpRadiationCheckBox.Left + HttpRadiationCheckBox.Width + 6;
            HttpRadiationTextBox.Text = Properties.Settings.Default.http_radiation_exp;
            HttpUnitLabel.Left = HttpRadiationTextBox.Left + HttpRadiationTextBox.Width + 6;
            HttpUnitLabel.Text = MainForm.Translate.GetString("http_unit", MainForm.Culture);
            HttpUnitTextBox.Left = HttpUnitLabel.Left + HttpUnitLabel.Width + 6;
            HttpUnitTextBox.Text = Properties.Settings.Default.http_unit;

            // [Автозагрузка]
            tabAutostart.Text = MainForm.Translate.GetString("autostart", MainForm.Culture);
            // Автозагрузка: чекбоксы
            AutostartCheckBox.Text = MainForm.Translate.GetString("run_windows", MainForm.Culture);
            MinimizeCheckBox.Text = MainForm.Translate.GetString("run_minimized", MainForm.Culture);
            MaximizeCheckBox.Text = MainForm.Translate.GetString("run_maximized", MainForm.Culture);
            AutoconnectCheckBox.Text = MainForm.Translate.GetString("run_connected", MainForm.Culture);
            // Автозагрузка: устанавливаем значения
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            object reg_value = reg_key.GetValue(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
            if (reg_value != null)
            {
                AutostartCheckBox.Checked = true;
                MinimizeCheckBox.Checked = (reg_value.ToString().IndexOf("/minimize") > -1) ? true : false;
                MaximizeCheckBox.Checked = (reg_value.ToString().IndexOf("/maximize") > -1) ? true : false;
                AutoconnectCheckBox.Checked = (reg_value.ToString().IndexOf("/connect") > -1) ? true : false;
            } else
            {
                AutostartCheckBox.Checked = false;
                MinimizeCheckBox.Checked = false;
                MaximizeCheckBox.Checked = false;
                AutoconnectCheckBox.Checked = false;
            }

            // [Допуски]
            tabLevels.Text = MainForm.Translate.GetString("levels", MainForm.Culture);
            // Допуски: повышеный уровень
            WarningLvlLabel.Text = MainForm.Translate.GetString("lvl_warning", MainForm.Culture);
            WarningLvlNumericUpDown.Left = WarningLvlLabel.Left + WarningLvlLabel.Width + 6;
            WarningLvlNumericUpDown.Value = Convert.ToDecimal(Properties.Settings.Default.warning_level);
            // Допуски: опасный уровень
            DangerLvlLabel.Text = MainForm.Translate.GetString("lvl_danger", MainForm.Culture);
            DangerLvlNumericUpDown.Left = DangerLvlLabel.Left + DangerLvlLabel.Width + 6;
            DangerLvlNumericUpDown.Value = Convert.ToDecimal(Properties.Settings.Default.danger_level);

            // [Уведомления]
            tabNotify.Text = MainForm.Translate.GetString("notifications", MainForm.Culture);
            // Уведомления: чекбоксы
            VoiceNotifyCheckBox.Text = MainForm.Translate.GetString("notify_voice", MainForm.Culture);
            TrayNotifyCheckBox.Text = MainForm.Translate.GetString("nitify_tray", MainForm.Culture);
            VoiceNotifyCheckBox.Checked = Properties.Settings.Default.voice_notify;
            TrayNotifyCheckBox.Checked = Properties.Settings.Default.tray_notify;
        }

        // Кнопка "Ок"
        private void OkButton_Click(object sender, EventArgs e)
        {
            // [Общие]
            Properties.Settings.Default.data_source = DataSourceComboBox.SelectedIndex;
            Properties.Settings.Default.min_accuracy = Convert.ToInt32(MinAccuracyNumericUpDown.Value);
            Properties.Settings.Default.max_data = Convert.ToInt32(MaxDataNumericUpDown.Value);
            Properties.Settings.Default.tray_minimize = SysTrayCheckBox.Checked;
            Properties.Settings.Default.disable_exit = DisableExitCheckBox.Checked;
            // Общие: язык интерфейса
            int culture_index = 0;
            string selected_language = string.Empty;
            CultureInfo[] CulturesList = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            foreach (CultureInfo CultureItem in CulturesList)
            {
                try
                {
                    ResourceSet CultureResource = MainForm.Translate.GetResourceSet(CultureItem, true, false);
                    if (CultureResource != null)
                    {
                        culture_index = culture_index + 1;
                        if (LanguageComboBox.SelectedIndex == culture_index)
                        {
                            selected_language = CultureItem.ToString();
                        }
                    }
                }
                catch
                {
                }
            }
            if(Properties.Settings.Default.language != selected_language)
            {
                Properties.Settings.Default.language = selected_language;
                MainForm.Culture = (selected_language.Length > 0) ? CultureInfo.CreateSpecificCulture(selected_language) : CultureInfo.CurrentCulture;
                MainForm Parent = (MainForm)Owner;
                Parent.reloadForm();
            }

            // [COM порт]
            Properties.Settings.Default.com_port = (SelectPortRadioButton.Checked ? ComPortComboBox.SelectedItem.ToString() : ComPortTextBox.Text );
            Properties.Settings.Default.baud_rate = (BaudRateRadioButton.Checked ? Int32.Parse(BaudRateComboBox.SelectedItem.ToString()) : Int32.Parse(BaudRateTextBox.Text));
            Properties.Settings.Default.data_bits = Int32.Parse(DataBitsComboBox.SelectedItem.ToString());
            Properties.Settings.Default.stop_bits = StopBitsComboBox.SelectedIndex;
            Properties.Settings.Default.parity = ParityComboBox.SelectedIndex;

            // [HTTP запрос]
            Properties.Settings.Default.http_url = HttpUrlTextBox.Text;
            Properties.Settings.Default.http_method = (HttpGetRadioButton.Checked ? 0 : 1);
            Properties.Settings.Default.http_data = HttpDataTextBox.Text;
            Properties.Settings.Default.http_useragent = HttpUserAgentTextBox.Text;
            Properties.Settings.Default.http_interval = Int32.Parse(IntervalTextBox.Text);
            Properties.Settings.Default.http_response = HttpResponseMethodComboBox.SelectedIndex;
            Properties.Settings.Default.http_accuracy = HttpAccuracyCheckBox.Checked;
            Properties.Settings.Default.http_accuracy_exp = HttpAccuracyTextBox.Text;
            Properties.Settings.Default.http_radiation = HttpRadiationCheckBox.Checked;
            Properties.Settings.Default.http_radiation_exp = HttpRadiationTextBox.Text;
            Properties.Settings.Default.http_unit = HttpUnitTextBox.Text;

            // [Автозагрузка]
            RegistryKey reg_key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (AutostartCheckBox.Checked)
            {
                string reg_value = "\"" + Application.ExecutablePath + "\"";
                reg_value += (MinimizeCheckBox.Checked) ? " /minimize" : "";
                reg_value += (MaximizeCheckBox.Checked) ? " /maximize" : "";
                reg_value += (AutoconnectCheckBox.Checked) ? " /connect" : "";
                reg_key.SetValue(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, reg_value);
            } else
            {
                if (reg_key.GetValue(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name) != null)
                {
                    reg_key.DeleteValue(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
                }
            }

            // [Допуски]
            Properties.Settings.Default.warning_level = Convert.ToSingle(WarningLvlNumericUpDown.Value);
            Properties.Settings.Default.danger_level = Convert.ToSingle(DangerLvlNumericUpDown.Value);

            // [Уведомления]
            Properties.Settings.Default.voice_notify = VoiceNotifyCheckBox.Checked;
            Properties.Settings.Default.tray_notify = TrayNotifyCheckBox.Checked;

            // Сохраняем
            Properties.Settings.Default.Save();
            this.Close();
        }

        // Кнопка "Отмена"
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectPortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ComPortComboBox.Enabled = SelectPortRadioButton.Checked;
        }

        private void ComPortCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ComPortTextBox.Enabled = ComPortCustomRadioButton.Checked;
        }

        private void BaudRateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BaudRateComboBox.Enabled = BaudRateRadioButton.Checked;
        }

        private void BaudRateCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BaudRateTextBox.Enabled = BaudRateCustomRadioButton.Checked;
        }

        // Запрещаем ввод всего кроме цифр (и backspace)
        private void BaudRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void HttpPostRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HttpDataLabel.Enabled = HttpPostRadioButton.Checked;
            HttpDataTextBox.Enabled = HttpPostRadioButton.Checked;
        }

        // Кнопка помощи в HTTP запросах
        private void HttpHelpButton_Click(object sender, EventArgs e)
        {
            string Message = string.Empty;
            switch(HttpResponseMethodComboBox.SelectedIndex)
            {
                case 0: // JSON
                    Message = MainForm.Translate.GetString("http_json_help", MainForm.Culture);
                    break;
                case 1: // XML
                    Message = MainForm.Translate.GetString("http_xml_help", MainForm.Culture);
                    break;
                case 2: // RegExp
                    Message = MainForm.Translate.GetString("http_regexp_help", MainForm.Culture);
                    break;
            }
            MessageBox.Show(Message, MainForm.Translate.GetString("information", MainForm.Culture), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Запрещаем ввод всего кроме цифр (и backspace)
        private void IntervalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void HttpAccuracyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HttpAccuracyTextBox.Enabled = HttpAccuracyCheckBox.Checked;
        }

        private void HttpRadiationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HttpRadiationTextBox.Enabled = HttpRadiationCheckBox.Checked;
            HttpUnitLabel.Enabled = HttpRadiationCheckBox.Checked;
            HttpUnitTextBox.Enabled = HttpRadiationCheckBox.Checked;
        }
    }
}
