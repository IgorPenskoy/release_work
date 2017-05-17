namespace quadcopter_research
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.main_time_label_text = new System.Windows.Forms.Label();
            this.main_time_label = new System.Windows.Forms.Label();
            this.reference_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.z_reference_label = new System.Windows.Forms.Label();
            this.y_reference_label = new System.Windows.Forms.Label();
            this.x_reference_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.y_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.z_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.z_state_edit = new System.Windows.Forms.NumericUpDown();
            this.y_state_edit = new System.Windows.Forms.NumericUpDown();
            this.x_state_edit = new System.Windows.Forms.NumericUpDown();
            this.control_process_tabs = new System.Windows.Forms.TabControl();
            this.x_tab = new System.Windows.Forms.TabPage();
            this.y_tab = new System.Windows.Forms.TabPage();
            this.x_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.z_tab = new System.Windows.Forms.TabPage();
            this.y_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.z_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.x_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_state_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_state_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_state_edit)).BeginInit();
            this.control_process_tabs.SuspendLayout();
            this.x_tab.SuspendLayout();
            this.y_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_chart)).BeginInit();
            this.z_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(15, 238);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(120, 30);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Enabled = false;
            this.stop_button.Location = new System.Drawing.Point(141, 238);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(120, 30);
            this.stop_button.TabIndex = 1;
            this.stop_button.Text = "Стоп";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Enabled = false;
            this.continue_button.Location = new System.Drawing.Point(141, 274);
            this.continue_button.Name = "continue_button";
            this.continue_button.Size = new System.Drawing.Size(120, 30);
            this.continue_button.TabIndex = 2;
            this.continue_button.Text = "Продолжить";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // pause_button
            // 
            this.pause_button.Enabled = false;
            this.pause_button.Location = new System.Drawing.Point(15, 274);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(120, 30);
            this.pause_button.TabIndex = 3;
            this.pause_button.Text = "Пауза";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // main_timer
            // 
            this.main_timer.Interval = 1;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // main_time_label_text
            // 
            this.main_time_label_text.AutoSize = true;
            this.main_time_label_text.Location = new System.Drawing.Point(12, 215);
            this.main_time_label_text.Name = "main_time_label_text";
            this.main_time_label_text.Size = new System.Drawing.Size(90, 13);
            this.main_time_label_text.TabIndex = 4;
            this.main_time_label_text.Text = "Текущее время:";
            // 
            // main_time_label
            // 
            this.main_time_label.AutoSize = true;
            this.main_time_label.Location = new System.Drawing.Point(108, 215);
            this.main_time_label.Name = "main_time_label";
            this.main_time_label.Size = new System.Drawing.Size(13, 13);
            this.main_time_label.TabIndex = 5;
            this.main_time_label.Text = "0";
            // 
            // reference_label
            // 
            this.reference_label.AutoSize = true;
            this.reference_label.Location = new System.Drawing.Point(12, 9);
            this.reference_label.Name = "reference_label";
            this.reference_label.Size = new System.Drawing.Size(53, 13);
            this.reference_label.TabIndex = 6;
            this.reference_label.Text = "Уставка:";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(12, 117);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(114, 13);
            this.state_label.TabIndex = 7;
            this.state_label.Text = "Текущее положение:";
            // 
            // z_reference_label
            // 
            this.z_reference_label.AutoSize = true;
            this.z_reference_label.Location = new System.Drawing.Point(34, 77);
            this.z_reference_label.Name = "z_reference_label";
            this.z_reference_label.Size = new System.Drawing.Size(161, 13);
            this.z_reference_label.TabIndex = 8;
            this.z_reference_label.Text = "Требуемый угол вокруг оси Z:";
            // 
            // y_reference_label
            // 
            this.y_reference_label.AutoSize = true;
            this.y_reference_label.Location = new System.Drawing.Point(34, 55);
            this.y_reference_label.Name = "y_reference_label";
            this.y_reference_label.Size = new System.Drawing.Size(161, 13);
            this.y_reference_label.TabIndex = 9;
            this.y_reference_label.Text = "Требуемый угол вокруг оси Y:";
            // 
            // x_reference_label
            // 
            this.x_reference_label.AutoSize = true;
            this.x_reference_label.Location = new System.Drawing.Point(34, 32);
            this.x_reference_label.Name = "x_reference_label";
            this.x_reference_label.Size = new System.Drawing.Size(161, 13);
            this.x_reference_label.TabIndex = 10;
            this.x_reference_label.Text = "Требуемый угол вокруг оси X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Текущий угол вокруг оси X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Текущий угол вокруг оси Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Текущий угол вокруг оси Z:";
            // 
            // x_reference_edit
            // 
            this.x_reference_edit.DecimalPlaces = 2;
            this.x_reference_edit.Location = new System.Drawing.Point(201, 30);
            this.x_reference_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.x_reference_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_reference_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.x_reference_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_reference_edit.Name = "x_reference_edit";
            this.x_reference_edit.Size = new System.Drawing.Size(60, 20);
            this.x_reference_edit.TabIndex = 14;
            // 
            // y_reference_edit
            // 
            this.y_reference_edit.DecimalPlaces = 2;
            this.y_reference_edit.Location = new System.Drawing.Point(201, 53);
            this.y_reference_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.y_reference_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_reference_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.y_reference_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_reference_edit.Name = "y_reference_edit";
            this.y_reference_edit.Size = new System.Drawing.Size(60, 20);
            this.y_reference_edit.TabIndex = 15;
            // 
            // z_reference_edit
            // 
            this.z_reference_edit.DecimalPlaces = 2;
            this.z_reference_edit.Location = new System.Drawing.Point(201, 75);
            this.z_reference_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.z_reference_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_reference_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.z_reference_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_reference_edit.Name = "z_reference_edit";
            this.z_reference_edit.Size = new System.Drawing.Size(60, 20);
            this.z_reference_edit.TabIndex = 16;
            // 
            // z_state_edit
            // 
            this.z_state_edit.DecimalPlaces = 2;
            this.z_state_edit.Location = new System.Drawing.Point(201, 182);
            this.z_state_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.z_state_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_state_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.z_state_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_state_edit.Name = "z_state_edit";
            this.z_state_edit.Size = new System.Drawing.Size(60, 20);
            this.z_state_edit.TabIndex = 19;
            // 
            // y_state_edit
            // 
            this.y_state_edit.DecimalPlaces = 2;
            this.y_state_edit.Location = new System.Drawing.Point(201, 160);
            this.y_state_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.y_state_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_state_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.y_state_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_state_edit.Name = "y_state_edit";
            this.y_state_edit.Size = new System.Drawing.Size(60, 20);
            this.y_state_edit.TabIndex = 18;
            // 
            // x_state_edit
            // 
            this.x_state_edit.DecimalPlaces = 2;
            this.x_state_edit.Location = new System.Drawing.Point(201, 137);
            this.x_state_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.x_state_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_state_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.x_state_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_state_edit.Name = "x_state_edit";
            this.x_state_edit.Size = new System.Drawing.Size(60, 20);
            this.x_state_edit.TabIndex = 17;
            // 
            // control_process_tabs
            // 
            this.control_process_tabs.Controls.Add(this.x_tab);
            this.control_process_tabs.Controls.Add(this.y_tab);
            this.control_process_tabs.Controls.Add(this.z_tab);
            this.control_process_tabs.Location = new System.Drawing.Point(267, 9);
            this.control_process_tabs.Name = "control_process_tabs";
            this.control_process_tabs.SelectedIndex = 0;
            this.control_process_tabs.Size = new System.Drawing.Size(668, 516);
            this.control_process_tabs.TabIndex = 21;
            // 
            // x_tab
            // 
            this.x_tab.Controls.Add(this.x_chart);
            this.x_tab.Location = new System.Drawing.Point(4, 22);
            this.x_tab.Name = "x_tab";
            this.x_tab.Padding = new System.Windows.Forms.Padding(3);
            this.x_tab.Size = new System.Drawing.Size(660, 490);
            this.x_tab.TabIndex = 0;
            this.x_tab.Text = "Угол поворота вокруг оси X";
            this.x_tab.UseVisualStyleBackColor = true;
            // 
            // y_tab
            // 
            this.y_tab.Controls.Add(this.y_chart);
            this.y_tab.Location = new System.Drawing.Point(4, 22);
            this.y_tab.Name = "y_tab";
            this.y_tab.Padding = new System.Windows.Forms.Padding(3);
            this.y_tab.Size = new System.Drawing.Size(660, 490);
            this.y_tab.TabIndex = 1;
            this.y_tab.Text = "Угол поворота вокруг оси Y";
            this.y_tab.UseVisualStyleBackColor = true;
            // 
            // x_chart
            // 
            chartArea7.Name = "ChartArea1";
            this.x_chart.ChartAreas.Add(chartArea7);
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend7.Name = "Legend1";
            this.x_chart.Legends.Add(legend7);
            this.x_chart.Location = new System.Drawing.Point(3, 6);
            this.x_chart.Name = "x_chart";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Уставка";
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "Текущее";
            this.x_chart.Series.Add(series13);
            this.x_chart.Series.Add(series14);
            this.x_chart.Size = new System.Drawing.Size(643, 481);
            this.x_chart.TabIndex = 21;
            this.x_chart.Text = "Угол вокруг оси X";
            // 
            // z_tab
            // 
            this.z_tab.Controls.Add(this.z_chart);
            this.z_tab.Location = new System.Drawing.Point(4, 22);
            this.z_tab.Name = "z_tab";
            this.z_tab.Size = new System.Drawing.Size(660, 490);
            this.z_tab.TabIndex = 2;
            this.z_tab.Text = "Угол поворота вокруг оси Z";
            this.z_tab.UseVisualStyleBackColor = true;
            // 
            // y_chart
            // 
            chartArea8.Name = "ChartArea1";
            this.y_chart.ChartAreas.Add(chartArea8);
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend8.Name = "Legend1";
            this.y_chart.Legends.Add(legend8);
            this.y_chart.Location = new System.Drawing.Point(3, 6);
            this.y_chart.Name = "y_chart";
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "Уставка";
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "Текущее";
            this.y_chart.Series.Add(series15);
            this.y_chart.Series.Add(series16);
            this.y_chart.Size = new System.Drawing.Size(643, 481);
            this.y_chart.TabIndex = 22;
            this.y_chart.Text = "Угол вокруг оси X";
            // 
            // z_chart
            // 
            chartArea9.Name = "ChartArea1";
            this.z_chart.ChartAreas.Add(chartArea9);
            legend9.Alignment = System.Drawing.StringAlignment.Center;
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend9.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend9.Name = "Legend1";
            this.z_chart.Legends.Add(legend9);
            this.z_chart.Location = new System.Drawing.Point(3, 6);
            this.z_chart.Name = "z_chart";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "Уставка";
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "Текущее";
            this.z_chart.Series.Add(series17);
            this.z_chart.Series.Add(series18);
            this.z_chart.Size = new System.Drawing.Size(643, 481);
            this.z_chart.TabIndex = 22;
            this.z_chart.Text = "Угол вокруг оси X";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 532);
            this.Controls.Add(this.control_process_tabs);
            this.Controls.Add(this.z_state_edit);
            this.Controls.Add(this.y_state_edit);
            this.Controls.Add(this.x_state_edit);
            this.Controls.Add(this.z_reference_edit);
            this.Controls.Add(this.y_reference_edit);
            this.Controls.Add(this.x_reference_edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.x_reference_label);
            this.Controls.Add(this.y_reference_label);
            this.Controls.Add(this.z_reference_label);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.reference_label);
            this.Controls.Add(this.main_time_label);
            this.Controls.Add(this.main_time_label_text);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Name = "main_form";
            this.Text = "Нейро-нечеткий ПИД-регулятор";
            ((System.ComponentModel.ISupportInitialize)(this.x_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_state_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_state_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_state_edit)).EndInit();
            this.control_process_tabs.ResumeLayout(false);
            this.x_tab.ResumeLayout(false);
            this.y_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.x_chart)).EndInit();
            this.z_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button continue_button;
        private System.Windows.Forms.Button pause_button;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Label main_time_label_text;
        private System.Windows.Forms.Label main_time_label;
        private System.Windows.Forms.Label reference_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Label z_reference_label;
        private System.Windows.Forms.Label y_reference_label;
        private System.Windows.Forms.Label x_reference_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown x_reference_edit;
        private System.Windows.Forms.NumericUpDown y_reference_edit;
        private System.Windows.Forms.NumericUpDown z_reference_edit;
        private System.Windows.Forms.NumericUpDown z_state_edit;
        private System.Windows.Forms.NumericUpDown y_state_edit;
        private System.Windows.Forms.NumericUpDown x_state_edit;
        private System.Windows.Forms.TabControl control_process_tabs;
        private System.Windows.Forms.TabPage x_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart x_chart;
        private System.Windows.Forms.TabPage y_tab;
        private System.Windows.Forms.TabPage z_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart y_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart z_chart;
    }
}

