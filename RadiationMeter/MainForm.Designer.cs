/*
 Radiation Meter Software
 Author: Sergey Avdeev
 E-Mail: avdeevsv91@gmail.com
 URL: https://github.com/kasitoru/radiation_meter_software
*/

namespace RadiationMeter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RadiationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.RadiationLabel = new System.Windows.Forms.Label();
            this.RadiationGroupBox = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RadiationChart)).BeginInit();
            this.RadiationGroupBox.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadiationChart
            // 
            textAnnotation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            textAnnotation1.Height = 100D;
            textAnnotation1.Name = "NoDataAnnotation";
            textAnnotation1.Text = "Not enough data";
            textAnnotation1.Width = 100D;
            textAnnotation1.X = 0D;
            textAnnotation1.Y = 0D;
            this.RadiationChart.Annotations.Add(textAnnotation1);
            this.RadiationChart.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.RadiationChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.Name = "RadiationChartArea";
            this.RadiationChart.ChartAreas.Add(chartArea1);
            this.RadiationChart.Location = new System.Drawing.Point(12, 12);
            this.RadiationChart.Name = "RadiationChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "RadiationChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "RadiationSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValuesPerPoint = 2;
            this.RadiationChart.Series.Add(series1);
            this.RadiationChart.Size = new System.Drawing.Size(398, 238);
            this.RadiationChart.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(3, 3);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(154, 32);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // RadiationLabel
            // 
            this.RadiationLabel.Font = new System.Drawing.Font("Arial Black", 15F);
            this.RadiationLabel.Location = new System.Drawing.Point(6, 19);
            this.RadiationLabel.Name = "RadiationLabel";
            this.RadiationLabel.Size = new System.Drawing.Size(144, 42);
            this.RadiationLabel.TabIndex = 3;
            this.RadiationLabel.Text = "N/A";
            this.RadiationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadiationGroupBox
            // 
            this.RadiationGroupBox.Controls.Add(this.RadiationLabel);
            this.RadiationGroupBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiationGroupBox.Location = new System.Drawing.Point(3, 41);
            this.RadiationGroupBox.Name = "RadiationGroupBox";
            this.RadiationGroupBox.Size = new System.Drawing.Size(156, 72);
            this.RadiationGroupBox.TabIndex = 5;
            this.RadiationGroupBox.TabStop = false;
            this.RadiationGroupBox.Text = "Radiation level:";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(3, 219);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(156, 23);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(3, 190);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(156, 23);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Location = new System.Drawing.Point(3, 116);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(155, 13);
            this.AccuracyLabel.TabIndex = 10;
            this.AccuracyLabel.Text = "Accuracy of measurements: {0}";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.ButtonConnect);
            this.ControlPanel.Controls.Add(this.AccuracyLabel);
            this.ControlPanel.Controls.Add(this.RadiationGroupBox);
            this.ControlPanel.Controls.Add(this.SettingsButton);
            this.ControlPanel.Controls.Add(this.AboutButton);
            this.ControlPanel.Location = new System.Drawing.Point(416, 9);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(160, 245);
            this.ControlPanel.TabIndex = 12;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.RadiationChart);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.RadiationChart)).EndInit();
            this.RadiationGroupBox.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RadiationChart;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label RadiationLabel;
        private System.Windows.Forms.GroupBox RadiationGroupBox;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

