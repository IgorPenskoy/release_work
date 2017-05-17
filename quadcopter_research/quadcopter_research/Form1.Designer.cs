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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea43 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend43 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series85 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series86 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea44 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend44 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series87 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series88 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea45 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend45 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series89 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series90 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.continue_button = new System.Windows.Forms.Button();
            this.pause_button = new System.Windows.Forms.Button();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.main_time_label_text = new System.Windows.Forms.Label();
            this.main_time_label = new System.Windows.Forms.Label();
            this.reference_label = new System.Windows.Forms.Label();
            this.inital_state_label = new System.Windows.Forms.Label();
            this.z_reference_label = new System.Windows.Forms.Label();
            this.y_reference_label = new System.Windows.Forms.Label();
            this.x_reference_label = new System.Windows.Forms.Label();
            this.x_initial_label = new System.Windows.Forms.Label();
            this.y_initial_label = new System.Windows.Forms.Label();
            this.z_initial_label = new System.Windows.Forms.Label();
            this.x_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.y_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.z_reference_edit = new System.Windows.Forms.NumericUpDown();
            this.z_initial_edit = new System.Windows.Forms.NumericUpDown();
            this.y_initial_edit = new System.Windows.Forms.NumericUpDown();
            this.x_initial_edit = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.z_initial_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_initial_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_initial_edit)).BeginInit();
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
            this.reference_label.Size = new System.Drawing.Size(125, 13);
            this.reference_label.TabIndex = 6;
            this.reference_label.Text = "Требуемое положение:";
            // 
            // inital_state_label
            // 
            this.inital_state_label.AutoSize = true;
            this.inital_state_label.Location = new System.Drawing.Point(12, 117);
            this.inital_state_label.Name = "inital_state_label";
            this.inital_state_label.Size = new System.Drawing.Size(118, 13);
            this.inital_state_label.TabIndex = 7;
            this.inital_state_label.Text = "Исходное положение:";
            // 
            // z_reference_label
            // 
            this.z_reference_label.AutoSize = true;
            this.z_reference_label.Location = new System.Drawing.Point(40, 76);
            this.z_reference_label.Name = "z_reference_label";
            this.z_reference_label.Size = new System.Drawing.Size(162, 13);
            this.z_reference_label.TabIndex = 8;
            this.z_reference_label.Text = "Требуемый угол рысканья (Z):";
            // 
            // y_reference_label
            // 
            this.y_reference_label.AutoSize = true;
            this.y_reference_label.Location = new System.Drawing.Point(40, 55);
            this.y_reference_label.Name = "y_reference_label";
            this.y_reference_label.Size = new System.Drawing.Size(154, 13);
            this.y_reference_label.TabIndex = 9;
            this.y_reference_label.Text = "Требуемый угол тангажа (Y):";
            // 
            // x_reference_label
            // 
            this.x_reference_label.AutoSize = true;
            this.x_reference_label.Location = new System.Drawing.Point(40, 32);
            this.x_reference_label.Name = "x_reference_label";
            this.x_reference_label.Size = new System.Drawing.Size(142, 13);
            this.x_reference_label.TabIndex = 10;
            this.x_reference_label.Text = "Требуемый угол крена (X):";
            // 
            // x_initial_label
            // 
            this.x_initial_label.AutoSize = true;
            this.x_initial_label.Location = new System.Drawing.Point(47, 139);
            this.x_initial_label.Name = "x_initial_label";
            this.x_initial_label.Size = new System.Drawing.Size(135, 13);
            this.x_initial_label.TabIndex = 13;
            this.x_initial_label.Text = "Исходный угол крена (X):";
            // 
            // y_initial_label
            // 
            this.y_initial_label.AutoSize = true;
            this.y_initial_label.Location = new System.Drawing.Point(47, 162);
            this.y_initial_label.Name = "y_initial_label";
            this.y_initial_label.Size = new System.Drawing.Size(147, 13);
            this.y_initial_label.TabIndex = 12;
            this.y_initial_label.Text = "Исходный угол тангажа (Y):";
            // 
            // z_initial_label
            // 
            this.z_initial_label.AutoSize = true;
            this.z_initial_label.Location = new System.Drawing.Point(47, 184);
            this.z_initial_label.Name = "z_initial_label";
            this.z_initial_label.Size = new System.Drawing.Size(155, 13);
            this.z_initial_label.TabIndex = 11;
            this.z_initial_label.Text = "Исходный угол рысканья (Z):";
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
            // z_initial_edit
            // 
            this.z_initial_edit.DecimalPlaces = 2;
            this.z_initial_edit.Location = new System.Drawing.Point(201, 182);
            this.z_initial_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.z_initial_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_initial_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.z_initial_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_initial_edit.Name = "z_initial_edit";
            this.z_initial_edit.Size = new System.Drawing.Size(60, 20);
            this.z_initial_edit.TabIndex = 19;
            // 
            // y_initial_edit
            // 
            this.y_initial_edit.DecimalPlaces = 2;
            this.y_initial_edit.Location = new System.Drawing.Point(201, 160);
            this.y_initial_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.y_initial_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_initial_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.y_initial_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_initial_edit.Name = "y_initial_edit";
            this.y_initial_edit.Size = new System.Drawing.Size(60, 20);
            this.y_initial_edit.TabIndex = 18;
            // 
            // x_initial_edit
            // 
            this.x_initial_edit.DecimalPlaces = 2;
            this.x_initial_edit.Location = new System.Drawing.Point(201, 137);
            this.x_initial_edit.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.x_initial_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_initial_edit.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.x_initial_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_initial_edit.Name = "x_initial_edit";
            this.x_initial_edit.Size = new System.Drawing.Size(60, 20);
            this.x_initial_edit.TabIndex = 17;
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
            this.x_tab.Text = "Угол крена (X)";
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
            this.y_tab.Text = "Угол тангажа (Y)";
            this.y_tab.UseVisualStyleBackColor = true;
            // 
            // x_chart
            // 
            chartArea43.Name = "ChartArea1";
            this.x_chart.ChartAreas.Add(chartArea43);
            legend43.Alignment = System.Drawing.StringAlignment.Center;
            legend43.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend43.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend43.Name = "Legend1";
            this.x_chart.Legends.Add(legend43);
            this.x_chart.Location = new System.Drawing.Point(3, 6);
            this.x_chart.Name = "x_chart";
            series85.BorderWidth = 3;
            series85.ChartArea = "ChartArea1";
            series85.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series85.Legend = "Legend1";
            series85.Name = "Уставка";
            series86.BorderWidth = 3;
            series86.ChartArea = "ChartArea1";
            series86.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series86.Legend = "Legend1";
            series86.Name = "Текущее";
            this.x_chart.Series.Add(series85);
            this.x_chart.Series.Add(series86);
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
            this.z_tab.Text = "Угол рысканья (Z)";
            this.z_tab.UseVisualStyleBackColor = true;
            // 
            // y_chart
            // 
            chartArea44.Name = "ChartArea1";
            this.y_chart.ChartAreas.Add(chartArea44);
            legend44.Alignment = System.Drawing.StringAlignment.Center;
            legend44.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend44.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend44.Name = "Legend1";
            this.y_chart.Legends.Add(legend44);
            this.y_chart.Location = new System.Drawing.Point(3, 6);
            this.y_chart.Name = "y_chart";
            series87.BorderWidth = 3;
            series87.ChartArea = "ChartArea1";
            series87.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series87.Legend = "Legend1";
            series87.Name = "Уставка";
            series88.BorderWidth = 3;
            series88.ChartArea = "ChartArea1";
            series88.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series88.Legend = "Legend1";
            series88.Name = "Текущее";
            this.y_chart.Series.Add(series87);
            this.y_chart.Series.Add(series88);
            this.y_chart.Size = new System.Drawing.Size(643, 481);
            this.y_chart.TabIndex = 22;
            this.y_chart.Text = "Угол вокруг оси X";
            // 
            // z_chart
            // 
            chartArea45.Name = "ChartArea1";
            this.z_chart.ChartAreas.Add(chartArea45);
            legend45.Alignment = System.Drawing.StringAlignment.Center;
            legend45.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend45.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend45.Name = "Legend1";
            this.z_chart.Legends.Add(legend45);
            this.z_chart.Location = new System.Drawing.Point(10, 22);
            this.z_chart.Name = "z_chart";
            series89.BorderWidth = 3;
            series89.ChartArea = "ChartArea1";
            series89.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series89.Legend = "Legend1";
            series89.Name = "Уставка";
            series90.BorderWidth = 3;
            series90.ChartArea = "ChartArea1";
            series90.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series90.Legend = "Legend1";
            series90.Name = "Текущее";
            this.z_chart.Series.Add(series89);
            this.z_chart.Series.Add(series90);
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
            this.Controls.Add(this.z_initial_edit);
            this.Controls.Add(this.y_initial_edit);
            this.Controls.Add(this.x_initial_edit);
            this.Controls.Add(this.z_reference_edit);
            this.Controls.Add(this.y_reference_edit);
            this.Controls.Add(this.x_reference_edit);
            this.Controls.Add(this.x_initial_label);
            this.Controls.Add(this.y_initial_label);
            this.Controls.Add(this.z_initial_label);
            this.Controls.Add(this.x_reference_label);
            this.Controls.Add(this.y_reference_label);
            this.Controls.Add(this.z_reference_label);
            this.Controls.Add(this.inital_state_label);
            this.Controls.Add(this.reference_label);
            this.Controls.Add(this.main_time_label);
            this.Controls.Add(this.main_time_label_text);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Name = "main_form";
            this.Text = "Нейро-нечеткий ПИД-регулятор в задаче угловой стабилизации мультироторного БПЛА";
            ((System.ComponentModel.ISupportInitialize)(this.x_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_reference_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_initial_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_initial_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_initial_edit)).EndInit();
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
        private System.Windows.Forms.Label inital_state_label;
        private System.Windows.Forms.Label z_reference_label;
        private System.Windows.Forms.Label y_reference_label;
        private System.Windows.Forms.Label x_reference_label;
        private System.Windows.Forms.Label x_initial_label;
        private System.Windows.Forms.Label y_initial_label;
        private System.Windows.Forms.Label z_initial_label;
        private System.Windows.Forms.NumericUpDown x_reference_edit;
        private System.Windows.Forms.NumericUpDown y_reference_edit;
        private System.Windows.Forms.NumericUpDown z_reference_edit;
        private System.Windows.Forms.NumericUpDown z_initial_edit;
        private System.Windows.Forms.NumericUpDown y_initial_edit;
        private System.Windows.Forms.NumericUpDown x_initial_edit;
        private System.Windows.Forms.TabControl control_process_tabs;
        private System.Windows.Forms.TabPage x_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart x_chart;
        private System.Windows.Forms.TabPage y_tab;
        private System.Windows.Forms.TabPage z_tab;
        private System.Windows.Forms.DataVisualization.Charting.Chart y_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart z_chart;
    }
}

