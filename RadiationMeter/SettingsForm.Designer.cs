/*
 Radiation Meter Software
 Author: Sergey Avdeev
 E-Mail: avdeevsv91@gmail.com
 URL: https://github.com/kasitoru/radiation_meter_software
*/

namespace RadiationMeter
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tabSettingsControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.DataSourceComboBox = new System.Windows.Forms.ComboBox();
            this.DataSourceLabel = new System.Windows.Forms.Label();
            this.MaxDataNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxDataLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.MinAccuracyLabel = new System.Windows.Forms.Label();
            this.MinAccuracyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SysTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.tabCOMport = new System.Windows.Forms.TabPage();
            this.BaudRatePanel = new System.Windows.Forms.Panel();
            this.BaudRateRadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateTextBox = new System.Windows.Forms.TextBox();
            this.BaudRateCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.ComPortPanel = new System.Windows.Forms.Panel();
            this.SelectPortRadioButton = new System.Windows.Forms.RadioButton();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.ComPortTextBox = new System.Windows.Forms.TextBox();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.tabHTTP = new System.Windows.Forms.TabPage();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.HttpResponseGroupBox = new System.Windows.Forms.GroupBox();
            this.HttpHelpButton = new System.Windows.Forms.Button();
            this.HttpExpressionsGroupBox = new System.Windows.Forms.GroupBox();
            this.HttpUnitTextBox = new System.Windows.Forms.TextBox();
            this.HttpUnitLabel = new System.Windows.Forms.Label();
            this.HttpRadiationTextBox = new System.Windows.Forms.TextBox();
            this.HttpAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.HttpAccuracyCheckBox = new System.Windows.Forms.CheckBox();
            this.HttpRadiationCheckBox = new System.Windows.Forms.CheckBox();
            this.HttpResponseMethodLabel = new System.Windows.Forms.Label();
            this.HttpResponseMethodComboBox = new System.Windows.Forms.ComboBox();
            this.HttpUserAgentLabel = new System.Windows.Forms.Label();
            this.HttpUserAgentTextBox = new System.Windows.Forms.TextBox();
            this.HttpDataTextBox = new System.Windows.Forms.TextBox();
            this.HttpDataLabel = new System.Windows.Forms.Label();
            this.HttpUrlLabel = new System.Windows.Forms.Label();
            this.HttpUrlTextBox = new System.Windows.Forms.TextBox();
            this.HttpMethodPanel = new System.Windows.Forms.Panel();
            this.HttpPostRadioButton = new System.Windows.Forms.RadioButton();
            this.HttpGetRadioButton = new System.Windows.Forms.RadioButton();
            this.tabAutostart = new System.Windows.Forms.TabPage();
            this.MinimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoconnectCheckBox = new System.Windows.Forms.CheckBox();
            this.MaximizeCheckBox = new System.Windows.Forms.CheckBox();
            this.AutostartCheckBox = new System.Windows.Forms.CheckBox();
            this.tabLevels = new System.Windows.Forms.TabPage();
            this.DangerLvlNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WarningLvlNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DangerLvlLabel = new System.Windows.Forms.Label();
            this.WarningLvlLabel = new System.Windows.Forms.Label();
            this.tabNotify = new System.Windows.Forms.TabPage();
            this.TrayNotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.VoiceNotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.DisableExitCheckBox = new System.Windows.Forms.CheckBox();
            this.tabSettingsControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDataNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAccuracyNumericUpDown)).BeginInit();
            this.tabCOMport.SuspendLayout();
            this.BaudRatePanel.SuspendLayout();
            this.ComPortPanel.SuspendLayout();
            this.tabHTTP.SuspendLayout();
            this.HttpResponseGroupBox.SuspendLayout();
            this.HttpExpressionsGroupBox.SuspendLayout();
            this.HttpMethodPanel.SuspendLayout();
            this.tabAutostart.SuspendLayout();
            this.tabLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangerLvlNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningLvlNumericUpDown)).BeginInit();
            this.tabNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(316, 260);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(397, 260);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tabSettingsControl
            // 
            this.tabSettingsControl.Controls.Add(this.tabGeneral);
            this.tabSettingsControl.Controls.Add(this.tabCOMport);
            this.tabSettingsControl.Controls.Add(this.tabHTTP);
            this.tabSettingsControl.Controls.Add(this.tabAutostart);
            this.tabSettingsControl.Controls.Add(this.tabLevels);
            this.tabSettingsControl.Controls.Add(this.tabNotify);
            this.tabSettingsControl.Location = new System.Drawing.Point(12, 12);
            this.tabSettingsControl.Name = "tabSettingsControl";
            this.tabSettingsControl.SelectedIndex = 0;
            this.tabSettingsControl.Size = new System.Drawing.Size(460, 242);
            this.tabSettingsControl.TabIndex = 2;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.DisableExitCheckBox);
            this.tabGeneral.Controls.Add(this.DataSourceComboBox);
            this.tabGeneral.Controls.Add(this.DataSourceLabel);
            this.tabGeneral.Controls.Add(this.MaxDataNumericUpDown);
            this.tabGeneral.Controls.Add(this.MaxDataLabel);
            this.tabGeneral.Controls.Add(this.LanguageLabel);
            this.tabGeneral.Controls.Add(this.LanguageComboBox);
            this.tabGeneral.Controls.Add(this.MinAccuracyLabel);
            this.tabGeneral.Controls.Add(this.MinAccuracyNumericUpDown);
            this.tabGeneral.Controls.Add(this.SysTrayCheckBox);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(452, 216);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // DataSourceComboBox
            // 
            this.DataSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataSourceComboBox.FormattingEnabled = true;
            this.DataSourceComboBox.Location = new System.Drawing.Point(77, 33);
            this.DataSourceComboBox.Name = "DataSourceComboBox";
            this.DataSourceComboBox.Size = new System.Drawing.Size(100, 21);
            this.DataSourceComboBox.TabIndex = 8;
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.AutoSize = true;
            this.DataSourceLabel.Location = new System.Drawing.Point(3, 36);
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Size = new System.Drawing.Size(68, 13);
            this.DataSourceLabel.TabIndex = 7;
            this.DataSourceLabel.Text = "Data source:";
            // 
            // MaxDataNumericUpDown
            // 
            this.MaxDataNumericUpDown.Location = new System.Drawing.Point(93, 86);
            this.MaxDataNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MaxDataNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxDataNumericUpDown.Name = "MaxDataNumericUpDown";
            this.MaxDataNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.MaxDataNumericUpDown.TabIndex = 6;
            this.MaxDataNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxDataLabel
            // 
            this.MaxDataLabel.AutoSize = true;
            this.MaxDataLabel.Location = new System.Drawing.Point(3, 88);
            this.MaxDataLabel.Name = "MaxDataLabel";
            this.MaxDataLabel.Size = new System.Drawing.Size(84, 13);
            this.MaxDataLabel.TabIndex = 5;
            this.MaxDataLabel.Text = "Data buffer size:";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(3, 9);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(99, 13);
            this.LanguageLabel.TabIndex = 4;
            this.LanguageLabel.Text = "Interface language:";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(108, 6);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(115, 21);
            this.LanguageComboBox.TabIndex = 3;
            // 
            // MinAccuracyLabel
            // 
            this.MinAccuracyLabel.AutoSize = true;
            this.MinAccuracyLabel.Location = new System.Drawing.Point(3, 62);
            this.MinAccuracyLabel.Name = "MinAccuracyLabel";
            this.MinAccuracyLabel.Size = new System.Drawing.Size(122, 13);
            this.MinAccuracyLabel.TabIndex = 2;
            this.MinAccuracyLabel.Text = "Minimum data accuracy:";
            // 
            // MinAccuracyNumericUpDown
            // 
            this.MinAccuracyNumericUpDown.Location = new System.Drawing.Point(131, 60);
            this.MinAccuracyNumericUpDown.Name = "MinAccuracyNumericUpDown";
            this.MinAccuracyNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.MinAccuracyNumericUpDown.TabIndex = 1;
            // 
            // SysTrayCheckBox
            // 
            this.SysTrayCheckBox.AutoSize = true;
            this.SysTrayCheckBox.Location = new System.Drawing.Point(6, 112);
            this.SysTrayCheckBox.Name = "SysTrayCheckBox";
            this.SysTrayCheckBox.Size = new System.Drawing.Size(133, 17);
            this.SysTrayCheckBox.TabIndex = 0;
            this.SysTrayCheckBox.Text = "Minimize to system tray";
            this.SysTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabCOMport
            // 
            this.tabCOMport.Controls.Add(this.BaudRatePanel);
            this.tabCOMport.Controls.Add(this.ComPortPanel);
            this.tabCOMport.Controls.Add(this.ParityComboBox);
            this.tabCOMport.Controls.Add(this.StopBitsComboBox);
            this.tabCOMport.Controls.Add(this.DataBitsComboBox);
            this.tabCOMport.Controls.Add(this.StopBitsLabel);
            this.tabCOMport.Controls.Add(this.DataBitsLabel);
            this.tabCOMport.Controls.Add(this.ParityLabel);
            this.tabCOMport.Location = new System.Drawing.Point(4, 22);
            this.tabCOMport.Name = "tabCOMport";
            this.tabCOMport.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOMport.Size = new System.Drawing.Size(452, 216);
            this.tabCOMport.TabIndex = 4;
            this.tabCOMport.Text = "COM port";
            this.tabCOMport.UseVisualStyleBackColor = true;
            // 
            // BaudRatePanel
            // 
            this.BaudRatePanel.Controls.Add(this.BaudRateRadioButton);
            this.BaudRatePanel.Controls.Add(this.BaudRateComboBox);
            this.BaudRatePanel.Controls.Add(this.BaudRateTextBox);
            this.BaudRatePanel.Controls.Add(this.BaudRateCustomRadioButton);
            this.BaudRatePanel.Location = new System.Drawing.Point(6, 30);
            this.BaudRatePanel.Name = "BaudRatePanel";
            this.BaudRatePanel.Size = new System.Drawing.Size(440, 21);
            this.BaudRatePanel.TabIndex = 16;
            // 
            // BaudRateRadioButton
            // 
            this.BaudRateRadioButton.AutoSize = true;
            this.BaudRateRadioButton.Location = new System.Drawing.Point(0, 1);
            this.BaudRateRadioButton.Name = "BaudRateRadioButton";
            this.BaudRateRadioButton.Size = new System.Drawing.Size(74, 17);
            this.BaudRateRadioButton.TabIndex = 12;
            this.BaudRateRadioButton.TabStop = true;
            this.BaudRateRadioButton.Text = "Baud rate:";
            this.BaudRateRadioButton.UseVisualStyleBackColor = true;
            this.BaudRateRadioButton.CheckedChanged += new System.EventHandler(this.BaudRateRadioButton_CheckedChanged);
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Location = new System.Drawing.Point(80, 0);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(60, 21);
            this.BaudRateComboBox.TabIndex = 8;
            // 
            // BaudRateTextBox
            // 
            this.BaudRateTextBox.Location = new System.Drawing.Point(215, 0);
            this.BaudRateTextBox.MaxLength = 8;
            this.BaudRateTextBox.Name = "BaudRateTextBox";
            this.BaudRateTextBox.Size = new System.Drawing.Size(60, 20);
            this.BaudRateTextBox.TabIndex = 14;
            this.BaudRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaudRateTextBox_KeyPress);
            // 
            // BaudRateCustomRadioButton
            // 
            this.BaudRateCustomRadioButton.AutoSize = true;
            this.BaudRateCustomRadioButton.Location = new System.Drawing.Point(146, 1);
            this.BaudRateCustomRadioButton.Name = "BaudRateCustomRadioButton";
            this.BaudRateCustomRadioButton.Size = new System.Drawing.Size(63, 17);
            this.BaudRateCustomRadioButton.TabIndex = 13;
            this.BaudRateCustomRadioButton.TabStop = true;
            this.BaudRateCustomRadioButton.Text = "Custom:";
            this.BaudRateCustomRadioButton.UseVisualStyleBackColor = true;
            this.BaudRateCustomRadioButton.CheckedChanged += new System.EventHandler(this.BaudRateCustomRadioButton_CheckedChanged);
            // 
            // ComPortPanel
            // 
            this.ComPortPanel.Controls.Add(this.SelectPortRadioButton);
            this.ComPortPanel.Controls.Add(this.ComPortComboBox);
            this.ComPortPanel.Controls.Add(this.ComPortCustomRadioButton);
            this.ComPortPanel.Controls.Add(this.ComPortTextBox);
            this.ComPortPanel.Location = new System.Drawing.Point(6, 6);
            this.ComPortPanel.Name = "ComPortPanel";
            this.ComPortPanel.Size = new System.Drawing.Size(440, 21);
            this.ComPortPanel.TabIndex = 15;
            // 
            // SelectPortRadioButton
            // 
            this.SelectPortRadioButton.AutoSize = true;
            this.SelectPortRadioButton.Checked = true;
            this.SelectPortRadioButton.Location = new System.Drawing.Point(0, 1);
            this.SelectPortRadioButton.Name = "SelectPortRadioButton";
            this.SelectPortRadioButton.Size = new System.Drawing.Size(79, 17);
            this.SelectPortRadioButton.TabIndex = 0;
            this.SelectPortRadioButton.TabStop = true;
            this.SelectPortRadioButton.Text = "Select port:";
            this.SelectPortRadioButton.UseVisualStyleBackColor = true;
            this.SelectPortRadioButton.CheckedChanged += new System.EventHandler(this.SelectPortRadioButton_CheckedChanged);
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(85, 0);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(60, 21);
            this.ComPortComboBox.TabIndex = 1;
            // 
            // ComPortCustomRadioButton
            // 
            this.ComPortCustomRadioButton.AutoSize = true;
            this.ComPortCustomRadioButton.Location = new System.Drawing.Point(151, 1);
            this.ComPortCustomRadioButton.Name = "ComPortCustomRadioButton";
            this.ComPortCustomRadioButton.Size = new System.Drawing.Size(63, 17);
            this.ComPortCustomRadioButton.TabIndex = 2;
            this.ComPortCustomRadioButton.Text = "Custom:";
            this.ComPortCustomRadioButton.UseVisualStyleBackColor = true;
            this.ComPortCustomRadioButton.CheckedChanged += new System.EventHandler(this.ComPortCustomRadioButton_CheckedChanged);
            // 
            // ComPortTextBox
            // 
            this.ComPortTextBox.Location = new System.Drawing.Point(220, 0);
            this.ComPortTextBox.MaxLength = 8;
            this.ComPortTextBox.Name = "ComPortTextBox";
            this.ComPortTextBox.Size = new System.Drawing.Size(60, 20);
            this.ComPortTextBox.TabIndex = 3;
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Location = new System.Drawing.Point(45, 114);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(75, 21);
            this.ParityComboBox.TabIndex = 11;
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Location = new System.Drawing.Point(60, 87);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(40, 21);
            this.StopBitsComboBox.TabIndex = 10;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Location = new System.Drawing.Point(61, 60);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(30, 21);
            this.DataBitsComboBox.TabIndex = 9;
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(3, 90);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(51, 13);
            this.StopBitsLabel.TabIndex = 7;
            this.StopBitsLabel.Text = "Stop bits:";
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(3, 63);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.DataBitsLabel.TabIndex = 6;
            this.DataBitsLabel.Text = "Data bits:";
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(3, 117);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(36, 13);
            this.ParityLabel.TabIndex = 5;
            this.ParityLabel.Text = "Parity:";
            // 
            // tabHTTP
            // 
            this.tabHTTP.Controls.Add(this.IntervalTextBox);
            this.tabHTTP.Controls.Add(this.IntervalLabel);
            this.tabHTTP.Controls.Add(this.HttpResponseGroupBox);
            this.tabHTTP.Controls.Add(this.HttpUserAgentLabel);
            this.tabHTTP.Controls.Add(this.HttpUserAgentTextBox);
            this.tabHTTP.Controls.Add(this.HttpDataTextBox);
            this.tabHTTP.Controls.Add(this.HttpDataLabel);
            this.tabHTTP.Controls.Add(this.HttpUrlLabel);
            this.tabHTTP.Controls.Add(this.HttpUrlTextBox);
            this.tabHTTP.Controls.Add(this.HttpMethodPanel);
            this.tabHTTP.Location = new System.Drawing.Point(4, 22);
            this.tabHTTP.Name = "tabHTTP";
            this.tabHTTP.Size = new System.Drawing.Size(452, 216);
            this.tabHTTP.TabIndex = 5;
            this.tabHTTP.Text = "HTTP request";
            this.tabHTTP.UseVisualStyleBackColor = true;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(279, 58);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(40, 20);
            this.IntervalTextBox.TabIndex = 10;
            this.IntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntervalTextBox_KeyPress);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(228, 61);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(45, 13);
            this.IntervalLabel.TabIndex = 9;
            this.IntervalLabel.Text = "Interval:";
            // 
            // HttpResponseGroupBox
            // 
            this.HttpResponseGroupBox.Controls.Add(this.HttpHelpButton);
            this.HttpResponseGroupBox.Controls.Add(this.HttpExpressionsGroupBox);
            this.HttpResponseGroupBox.Controls.Add(this.HttpResponseMethodLabel);
            this.HttpResponseGroupBox.Controls.Add(this.HttpResponseMethodComboBox);
            this.HttpResponseGroupBox.Location = new System.Drawing.Point(6, 89);
            this.HttpResponseGroupBox.Name = "HttpResponseGroupBox";
            this.HttpResponseGroupBox.Size = new System.Drawing.Size(440, 122);
            this.HttpResponseGroupBox.TabIndex = 8;
            this.HttpResponseGroupBox.TabStop = false;
            this.HttpResponseGroupBox.Text = "Response processing:";
            // 
            // HttpHelpButton
            // 
            this.HttpHelpButton.Location = new System.Drawing.Point(134, 18);
            this.HttpHelpButton.Name = "HttpHelpButton";
            this.HttpHelpButton.Size = new System.Drawing.Size(23, 23);
            this.HttpHelpButton.TabIndex = 7;
            this.HttpHelpButton.Text = "?";
            this.HttpHelpButton.UseVisualStyleBackColor = true;
            this.HttpHelpButton.Click += new System.EventHandler(this.HttpHelpButton_Click);
            // 
            // HttpExpressionsGroupBox
            // 
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpUnitTextBox);
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpUnitLabel);
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpRadiationTextBox);
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpAccuracyTextBox);
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpAccuracyCheckBox);
            this.HttpExpressionsGroupBox.Controls.Add(this.HttpRadiationCheckBox);
            this.HttpExpressionsGroupBox.Location = new System.Drawing.Point(9, 46);
            this.HttpExpressionsGroupBox.Name = "HttpExpressionsGroupBox";
            this.HttpExpressionsGroupBox.Size = new System.Drawing.Size(425, 70);
            this.HttpExpressionsGroupBox.TabIndex = 6;
            this.HttpExpressionsGroupBox.TabStop = false;
            this.HttpExpressionsGroupBox.Text = "Expressions:";
            // 
            // HttpUnitTextBox
            // 
            this.HttpUnitTextBox.Location = new System.Drawing.Point(302, 43);
            this.HttpUnitTextBox.MaxLength = 8;
            this.HttpUnitTextBox.Name = "HttpUnitTextBox";
            this.HttpUnitTextBox.Size = new System.Drawing.Size(55, 20);
            this.HttpUnitTextBox.TabIndex = 8;
            // 
            // HttpUnitLabel
            // 
            this.HttpUnitLabel.AutoSize = true;
            this.HttpUnitLabel.Location = new System.Drawing.Point(267, 46);
            this.HttpUnitLabel.Name = "HttpUnitLabel";
            this.HttpUnitLabel.Size = new System.Drawing.Size(29, 13);
            this.HttpUnitLabel.TabIndex = 7;
            this.HttpUnitLabel.Text = "Unit:";
            // 
            // HttpRadiationTextBox
            // 
            this.HttpRadiationTextBox.Location = new System.Drawing.Point(86, 43);
            this.HttpRadiationTextBox.Name = "HttpRadiationTextBox";
            this.HttpRadiationTextBox.Size = new System.Drawing.Size(175, 20);
            this.HttpRadiationTextBox.TabIndex = 6;
            // 
            // HttpAccuracyTextBox
            // 
            this.HttpAccuracyTextBox.Location = new System.Drawing.Point(86, 17);
            this.HttpAccuracyTextBox.Name = "HttpAccuracyTextBox";
            this.HttpAccuracyTextBox.Size = new System.Drawing.Size(175, 20);
            this.HttpAccuracyTextBox.TabIndex = 5;
            // 
            // HttpAccuracyCheckBox
            // 
            this.HttpAccuracyCheckBox.AutoSize = true;
            this.HttpAccuracyCheckBox.Location = new System.Drawing.Point(6, 19);
            this.HttpAccuracyCheckBox.Name = "HttpAccuracyCheckBox";
            this.HttpAccuracyCheckBox.Size = new System.Drawing.Size(74, 17);
            this.HttpAccuracyCheckBox.TabIndex = 2;
            this.HttpAccuracyCheckBox.Text = "Accuracy:";
            this.HttpAccuracyCheckBox.UseVisualStyleBackColor = true;
            this.HttpAccuracyCheckBox.CheckedChanged += new System.EventHandler(this.HttpAccuracyCheckBox_CheckedChanged);
            // 
            // HttpRadiationCheckBox
            // 
            this.HttpRadiationCheckBox.AutoSize = true;
            this.HttpRadiationCheckBox.Location = new System.Drawing.Point(6, 45);
            this.HttpRadiationCheckBox.Name = "HttpRadiationCheckBox";
            this.HttpRadiationCheckBox.Size = new System.Drawing.Size(74, 17);
            this.HttpRadiationCheckBox.TabIndex = 3;
            this.HttpRadiationCheckBox.Text = "Radiation:";
            this.HttpRadiationCheckBox.UseVisualStyleBackColor = true;
            this.HttpRadiationCheckBox.CheckedChanged += new System.EventHandler(this.HttpRadiationCheckBox_CheckedChanged);
            // 
            // HttpResponseMethodLabel
            // 
            this.HttpResponseMethodLabel.AutoSize = true;
            this.HttpResponseMethodLabel.Location = new System.Drawing.Point(6, 22);
            this.HttpResponseMethodLabel.Name = "HttpResponseMethodLabel";
            this.HttpResponseMethodLabel.Size = new System.Drawing.Size(46, 13);
            this.HttpResponseMethodLabel.TabIndex = 5;
            this.HttpResponseMethodLabel.Text = "Method:";
            // 
            // HttpResponseMethodComboBox
            // 
            this.HttpResponseMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HttpResponseMethodComboBox.FormattingEnabled = true;
            this.HttpResponseMethodComboBox.Location = new System.Drawing.Point(58, 19);
            this.HttpResponseMethodComboBox.Name = "HttpResponseMethodComboBox";
            this.HttpResponseMethodComboBox.Size = new System.Drawing.Size(70, 21);
            this.HttpResponseMethodComboBox.TabIndex = 4;
            // 
            // HttpUserAgentLabel
            // 
            this.HttpUserAgentLabel.AutoSize = true;
            this.HttpUserAgentLabel.Location = new System.Drawing.Point(3, 61);
            this.HttpUserAgentLabel.Name = "HttpUserAgentLabel";
            this.HttpUserAgentLabel.Size = new System.Drawing.Size(63, 13);
            this.HttpUserAgentLabel.TabIndex = 7;
            this.HttpUserAgentLabel.Text = "User-Agent:";
            // 
            // HttpUserAgentTextBox
            // 
            this.HttpUserAgentTextBox.Location = new System.Drawing.Point(72, 58);
            this.HttpUserAgentTextBox.Name = "HttpUserAgentTextBox";
            this.HttpUserAgentTextBox.Size = new System.Drawing.Size(150, 20);
            this.HttpUserAgentTextBox.TabIndex = 6;
            // 
            // HttpDataTextBox
            // 
            this.HttpDataTextBox.Location = new System.Drawing.Point(72, 32);
            this.HttpDataTextBox.Name = "HttpDataTextBox";
            this.HttpDataTextBox.Size = new System.Drawing.Size(250, 20);
            this.HttpDataTextBox.TabIndex = 4;
            // 
            // HttpDataLabel
            // 
            this.HttpDataLabel.AutoSize = true;
            this.HttpDataLabel.Location = new System.Drawing.Point(3, 35);
            this.HttpDataLabel.Name = "HttpDataLabel";
            this.HttpDataLabel.Size = new System.Drawing.Size(63, 13);
            this.HttpDataLabel.TabIndex = 3;
            this.HttpDataLabel.Text = "POST data:";
            // 
            // HttpUrlLabel
            // 
            this.HttpUrlLabel.AutoSize = true;
            this.HttpUrlLabel.Location = new System.Drawing.Point(3, 9);
            this.HttpUrlLabel.Name = "HttpUrlLabel";
            this.HttpUrlLabel.Size = new System.Drawing.Size(32, 13);
            this.HttpUrlLabel.TabIndex = 2;
            this.HttpUrlLabel.Text = "URL:";
            // 
            // HttpUrlTextBox
            // 
            this.HttpUrlTextBox.Location = new System.Drawing.Point(41, 6);
            this.HttpUrlTextBox.Name = "HttpUrlTextBox";
            this.HttpUrlTextBox.Size = new System.Drawing.Size(190, 20);
            this.HttpUrlTextBox.TabIndex = 1;
            // 
            // HttpMethodPanel
            // 
            this.HttpMethodPanel.Controls.Add(this.HttpPostRadioButton);
            this.HttpMethodPanel.Controls.Add(this.HttpGetRadioButton);
            this.HttpMethodPanel.Location = new System.Drawing.Point(237, 7);
            this.HttpMethodPanel.Name = "HttpMethodPanel";
            this.HttpMethodPanel.Size = new System.Drawing.Size(209, 17);
            this.HttpMethodPanel.TabIndex = 0;
            // 
            // HttpPostRadioButton
            // 
            this.HttpPostRadioButton.AutoSize = true;
            this.HttpPostRadioButton.Location = new System.Drawing.Point(53, 0);
            this.HttpPostRadioButton.Name = "HttpPostRadioButton";
            this.HttpPostRadioButton.Size = new System.Drawing.Size(54, 17);
            this.HttpPostRadioButton.TabIndex = 2;
            this.HttpPostRadioButton.TabStop = true;
            this.HttpPostRadioButton.Text = "POST";
            this.HttpPostRadioButton.UseVisualStyleBackColor = true;
            this.HttpPostRadioButton.CheckedChanged += new System.EventHandler(this.HttpPostRadioButton_CheckedChanged);
            // 
            // HttpGetRadioButton
            // 
            this.HttpGetRadioButton.AutoSize = true;
            this.HttpGetRadioButton.Location = new System.Drawing.Point(0, 0);
            this.HttpGetRadioButton.Name = "HttpGetRadioButton";
            this.HttpGetRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HttpGetRadioButton.TabIndex = 1;
            this.HttpGetRadioButton.TabStop = true;
            this.HttpGetRadioButton.Text = "GET";
            this.HttpGetRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabAutostart
            // 
            this.tabAutostart.Controls.Add(this.MinimizeCheckBox);
            this.tabAutostart.Controls.Add(this.AutoconnectCheckBox);
            this.tabAutostart.Controls.Add(this.MaximizeCheckBox);
            this.tabAutostart.Controls.Add(this.AutostartCheckBox);
            this.tabAutostart.Location = new System.Drawing.Point(4, 22);
            this.tabAutostart.Name = "tabAutostart";
            this.tabAutostart.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutostart.Size = new System.Drawing.Size(452, 216);
            this.tabAutostart.TabIndex = 1;
            this.tabAutostart.Text = "Autostart";
            this.tabAutostart.UseVisualStyleBackColor = true;
            // 
            // MinimizeCheckBox
            // 
            this.MinimizeCheckBox.AutoSize = true;
            this.MinimizeCheckBox.Location = new System.Drawing.Point(6, 29);
            this.MinimizeCheckBox.Name = "MinimizeCheckBox";
            this.MinimizeCheckBox.Size = new System.Drawing.Size(72, 17);
            this.MinimizeCheckBox.TabIndex = 3;
            this.MinimizeCheckBox.Text = "Minimized";
            this.MinimizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoconnectCheckBox
            // 
            this.AutoconnectCheckBox.AutoSize = true;
            this.AutoconnectCheckBox.Location = new System.Drawing.Point(6, 75);
            this.AutoconnectCheckBox.Name = "AutoconnectCheckBox";
            this.AutoconnectCheckBox.Size = new System.Drawing.Size(130, 17);
            this.AutoconnectCheckBox.TabIndex = 2;
            this.AutoconnectCheckBox.Text = "Connect automatically";
            this.AutoconnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaximizeCheckBox
            // 
            this.MaximizeCheckBox.AutoSize = true;
            this.MaximizeCheckBox.Location = new System.Drawing.Point(6, 52);
            this.MaximizeCheckBox.Name = "MaximizeCheckBox";
            this.MaximizeCheckBox.Size = new System.Drawing.Size(75, 17);
            this.MaximizeCheckBox.TabIndex = 1;
            this.MaximizeCheckBox.Text = "Maximized";
            this.MaximizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutostartCheckBox
            // 
            this.AutostartCheckBox.AutoSize = true;
            this.AutostartCheckBox.Location = new System.Drawing.Point(6, 6);
            this.AutostartCheckBox.Name = "AutostartCheckBox";
            this.AutostartCheckBox.Size = new System.Drawing.Size(115, 17);
            this.AutostartCheckBox.TabIndex = 0;
            this.AutostartCheckBox.Text = "Run with Windows";
            this.AutostartCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabLevels
            // 
            this.tabLevels.Controls.Add(this.DangerLvlNumericUpDown);
            this.tabLevels.Controls.Add(this.WarningLvlNumericUpDown);
            this.tabLevels.Controls.Add(this.DangerLvlLabel);
            this.tabLevels.Controls.Add(this.WarningLvlLabel);
            this.tabLevels.Location = new System.Drawing.Point(4, 22);
            this.tabLevels.Name = "tabLevels";
            this.tabLevels.Size = new System.Drawing.Size(452, 216);
            this.tabLevels.TabIndex = 2;
            this.tabLevels.Text = "Levels";
            this.tabLevels.UseVisualStyleBackColor = true;
            // 
            // DangerLvlNumericUpDown
            // 
            this.DangerLvlNumericUpDown.DecimalPlaces = 2;
            this.DangerLvlNumericUpDown.Location = new System.Drawing.Point(79, 32);
            this.DangerLvlNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.DangerLvlNumericUpDown.Name = "DangerLvlNumericUpDown";
            this.DangerLvlNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.DangerLvlNumericUpDown.TabIndex = 3;
            // 
            // WarningLvlNumericUpDown
            // 
            this.WarningLvlNumericUpDown.DecimalPlaces = 2;
            this.WarningLvlNumericUpDown.Location = new System.Drawing.Point(84, 6);
            this.WarningLvlNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.WarningLvlNumericUpDown.Name = "WarningLvlNumericUpDown";
            this.WarningLvlNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.WarningLvlNumericUpDown.TabIndex = 2;
            // 
            // DangerLvlLabel
            // 
            this.DangerLvlLabel.AutoSize = true;
            this.DangerLvlLabel.Location = new System.Drawing.Point(3, 34);
            this.DangerLvlLabel.Name = "DangerLvlLabel";
            this.DangerLvlLabel.Size = new System.Drawing.Size(70, 13);
            this.DangerLvlLabel.TabIndex = 1;
            this.DangerLvlLabel.Text = "Danger level:";
            // 
            // WarningLvlLabel
            // 
            this.WarningLvlLabel.AutoSize = true;
            this.WarningLvlLabel.Location = new System.Drawing.Point(3, 8);
            this.WarningLvlLabel.Name = "WarningLvlLabel";
            this.WarningLvlLabel.Size = new System.Drawing.Size(75, 13);
            this.WarningLvlLabel.TabIndex = 0;
            this.WarningLvlLabel.Text = "Warning level:";
            // 
            // tabNotify
            // 
            this.tabNotify.Controls.Add(this.TrayNotifyCheckBox);
            this.tabNotify.Controls.Add(this.VoiceNotifyCheckBox);
            this.tabNotify.Location = new System.Drawing.Point(4, 22);
            this.tabNotify.Name = "tabNotify";
            this.tabNotify.Size = new System.Drawing.Size(452, 216);
            this.tabNotify.TabIndex = 3;
            this.tabNotify.Text = "Notifications";
            this.tabNotify.UseVisualStyleBackColor = true;
            // 
            // TrayNotifyCheckBox
            // 
            this.TrayNotifyCheckBox.AutoSize = true;
            this.TrayNotifyCheckBox.Location = new System.Drawing.Point(6, 29);
            this.TrayNotifyCheckBox.Name = "TrayNotifyCheckBox";
            this.TrayNotifyCheckBox.Size = new System.Drawing.Size(110, 17);
            this.TrayNotifyCheckBox.TabIndex = 1;
            this.TrayNotifyCheckBox.Text = "Pop-up messages";
            this.TrayNotifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // VoiceNotifyCheckBox
            // 
            this.VoiceNotifyCheckBox.AutoSize = true;
            this.VoiceNotifyCheckBox.Location = new System.Drawing.Point(6, 6);
            this.VoiceNotifyCheckBox.Name = "VoiceNotifyCheckBox";
            this.VoiceNotifyCheckBox.Size = new System.Drawing.Size(81, 17);
            this.VoiceNotifyCheckBox.TabIndex = 0;
            this.VoiceNotifyCheckBox.Text = "Voice alerts";
            this.VoiceNotifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisableExitCheckBox
            // 
            this.DisableExitCheckBox.AutoSize = true;
            this.DisableExitCheckBox.Location = new System.Drawing.Point(6, 135);
            this.DisableExitCheckBox.Name = "DisableExitCheckBox";
            this.DisableExitCheckBox.Size = new System.Drawing.Size(113, 17);
            this.DisableExitCheckBox.TabIndex = 9;
            this.DisableExitCheckBox.Text = "Disable exit button";
            this.DisableExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.ControlBox = false;
            this.Controls.Add(this.tabSettingsControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabSettingsControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDataNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAccuracyNumericUpDown)).EndInit();
            this.tabCOMport.ResumeLayout(false);
            this.tabCOMport.PerformLayout();
            this.BaudRatePanel.ResumeLayout(false);
            this.BaudRatePanel.PerformLayout();
            this.ComPortPanel.ResumeLayout(false);
            this.ComPortPanel.PerformLayout();
            this.tabHTTP.ResumeLayout(false);
            this.tabHTTP.PerformLayout();
            this.HttpResponseGroupBox.ResumeLayout(false);
            this.HttpResponseGroupBox.PerformLayout();
            this.HttpExpressionsGroupBox.ResumeLayout(false);
            this.HttpExpressionsGroupBox.PerformLayout();
            this.HttpMethodPanel.ResumeLayout(false);
            this.HttpMethodPanel.PerformLayout();
            this.tabAutostart.ResumeLayout(false);
            this.tabAutostart.PerformLayout();
            this.tabLevels.ResumeLayout(false);
            this.tabLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangerLvlNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningLvlNumericUpDown)).EndInit();
            this.tabNotify.ResumeLayout(false);
            this.tabNotify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        new private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl tabSettingsControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAutostart;
        private System.Windows.Forms.TabPage tabLevels;
        private System.Windows.Forms.TabPage tabNotify;
        private System.Windows.Forms.Label MinAccuracyLabel;
        private System.Windows.Forms.NumericUpDown MinAccuracyNumericUpDown;
        private System.Windows.Forms.CheckBox SysTrayCheckBox;
        private System.Windows.Forms.CheckBox MinimizeCheckBox;
        private System.Windows.Forms.CheckBox AutoconnectCheckBox;
        private System.Windows.Forms.CheckBox MaximizeCheckBox;
        private System.Windows.Forms.CheckBox AutostartCheckBox;
        private System.Windows.Forms.CheckBox TrayNotifyCheckBox;
        private System.Windows.Forms.CheckBox VoiceNotifyCheckBox;
        private System.Windows.Forms.NumericUpDown WarningLvlNumericUpDown;
        private System.Windows.Forms.Label DangerLvlLabel;
        private System.Windows.Forms.Label WarningLvlLabel;
        private System.Windows.Forms.NumericUpDown DangerLvlNumericUpDown;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.NumericUpDown MaxDataNumericUpDown;
        private System.Windows.Forms.Label MaxDataLabel;
        private System.Windows.Forms.ComboBox DataSourceComboBox;
        private System.Windows.Forms.Label DataSourceLabel;
        private System.Windows.Forms.TabPage tabCOMport;
        private System.Windows.Forms.TextBox ComPortTextBox;
        private System.Windows.Forms.RadioButton ComPortCustomRadioButton;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.RadioButton SelectPortRadioButton;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.RadioButton BaudRateRadioButton;
        private System.Windows.Forms.RadioButton BaudRateCustomRadioButton;
        private System.Windows.Forms.TextBox BaudRateTextBox;
        private System.Windows.Forms.Panel ComPortPanel;
        private System.Windows.Forms.Panel BaudRatePanel;
        private System.Windows.Forms.TabPage tabHTTP;
        private System.Windows.Forms.Panel HttpMethodPanel;
        private System.Windows.Forms.Label HttpUrlLabel;
        private System.Windows.Forms.TextBox HttpUrlTextBox;
        private System.Windows.Forms.RadioButton HttpPostRadioButton;
        private System.Windows.Forms.RadioButton HttpGetRadioButton;
        private System.Windows.Forms.TextBox HttpDataTextBox;
        private System.Windows.Forms.Label HttpDataLabel;
        private System.Windows.Forms.TextBox HttpUserAgentTextBox;
        private System.Windows.Forms.Label HttpUserAgentLabel;
        private System.Windows.Forms.GroupBox HttpResponseGroupBox;
        private System.Windows.Forms.CheckBox HttpRadiationCheckBox;
        private System.Windows.Forms.CheckBox HttpAccuracyCheckBox;
        private System.Windows.Forms.Label HttpResponseMethodLabel;
        private System.Windows.Forms.ComboBox HttpResponseMethodComboBox;
        private System.Windows.Forms.GroupBox HttpExpressionsGroupBox;
        private System.Windows.Forms.TextBox HttpRadiationTextBox;
        private System.Windows.Forms.TextBox HttpAccuracyTextBox;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Button HttpHelpButton;
        private System.Windows.Forms.TextBox HttpUnitTextBox;
        private System.Windows.Forms.Label HttpUnitLabel;
        private System.Windows.Forms.CheckBox DisableExitCheckBox;
    }
}