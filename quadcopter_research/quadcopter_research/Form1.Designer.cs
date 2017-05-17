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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.x_min_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.x_min_effect_label = new System.Windows.Forms.Label();
            this.x_max_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.x_max_effect_label = new System.Windows.Forms.Label();
            this.x_period_error_edit = new System.Windows.Forms.NumericUpDown();
            this.x_period_error_label = new System.Windows.Forms.Label();
            this.x_period_label = new System.Windows.Forms.Label();
            this.x_period_label_text = new System.Windows.Forms.Label();
            this.x_overshoot_label = new System.Windows.Forms.Label();
            this.x_overshoot_label_text = new System.Windows.Forms.Label();
            this.x_current_label = new System.Windows.Forms.Label();
            this.x_current_label_text = new System.Windows.Forms.Label();
            this.x_D_edit = new System.Windows.Forms.NumericUpDown();
            this.x_D_label = new System.Windows.Forms.Label();
            this.x_I_edit = new System.Windows.Forms.NumericUpDown();
            this.x_I_label = new System.Windows.Forms.Label();
            this.x_P_edit = new System.Windows.Forms.NumericUpDown();
            this.x_P_label = new System.Windows.Forms.Label();
            this.x_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.y_tab = new System.Windows.Forms.TabPage();
            this.y_period_error_edit = new System.Windows.Forms.NumericUpDown();
            this.y_period_error_label = new System.Windows.Forms.Label();
            this.y_period_label = new System.Windows.Forms.Label();
            this.y_period_label_text = new System.Windows.Forms.Label();
            this.y_overshoot_label = new System.Windows.Forms.Label();
            this.y_overshoot_label_text = new System.Windows.Forms.Label();
            this.y_current_label = new System.Windows.Forms.Label();
            this.y_current_label_text = new System.Windows.Forms.Label();
            this.y_D_edit = new System.Windows.Forms.NumericUpDown();
            this.y_D_label = new System.Windows.Forms.Label();
            this.y_I_edit = new System.Windows.Forms.NumericUpDown();
            this.y_I_label = new System.Windows.Forms.Label();
            this.y_P_edit = new System.Windows.Forms.NumericUpDown();
            this.y_P_label = new System.Windows.Forms.Label();
            this.y_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.z_tab = new System.Windows.Forms.TabPage();
            this.z_period_error_edit = new System.Windows.Forms.NumericUpDown();
            this.z_period_error_label = new System.Windows.Forms.Label();
            this.z_period_label = new System.Windows.Forms.Label();
            this.z_period_label_text = new System.Windows.Forms.Label();
            this.z_overshoot_label = new System.Windows.Forms.Label();
            this.z_overshoot_label_text = new System.Windows.Forms.Label();
            this.z_current_label = new System.Windows.Forms.Label();
            this.z_current_label_text = new System.Windows.Forms.Label();
            this.z_D_edit = new System.Windows.Forms.NumericUpDown();
            this.z_D_label = new System.Windows.Forms.Label();
            this.z_I_edit = new System.Windows.Forms.NumericUpDown();
            this.z_I_label = new System.Windows.Forms.Label();
            this.z_P_edit = new System.Windows.Forms.NumericUpDown();
            this.z_P_label = new System.Windows.Forms.Label();
            this.z_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.y_min_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.y_min_effect_label = new System.Windows.Forms.Label();
            this.y_max_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.y_max_effect_label = new System.Windows.Forms.Label();
            this.z_min_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.z_min_effect_label = new System.Windows.Forms.Label();
            this.z_max_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.z_max_effect_label = new System.Windows.Forms.Label();
            this.dt_label = new System.Windows.Forms.Label();
            this.dt_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.x_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_reference_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_initial_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_initial_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_initial_edit)).BeginInit();
            this.control_process_tabs.SuspendLayout();
            this.x_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_min_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_max_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_period_error_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_D_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_I_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_P_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_chart)).BeginInit();
            this.y_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_period_error_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_D_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_I_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_P_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).BeginInit();
            this.z_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_period_error_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_D_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_I_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_P_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_min_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_max_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_min_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_max_effect_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(15, 267);
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
            this.stop_button.Location = new System.Drawing.Point(141, 267);
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
            this.continue_button.Location = new System.Drawing.Point(141, 303);
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
            this.pause_button.Location = new System.Drawing.Point(15, 303);
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
            this.main_time_label_text.Location = new System.Drawing.Point(12, 244);
            this.main_time_label_text.Name = "main_time_label_text";
            this.main_time_label_text.Size = new System.Drawing.Size(90, 13);
            this.main_time_label_text.TabIndex = 4;
            this.main_time_label_text.Text = "Текущее время:";
            // 
            // main_time_label
            // 
            this.main_time_label.AutoSize = true;
            this.main_time_label.Location = new System.Drawing.Point(108, 244);
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
            this.control_process_tabs.Location = new System.Drawing.Point(267, 12);
            this.control_process_tabs.Name = "control_process_tabs";
            this.control_process_tabs.SelectedIndex = 0;
            this.control_process_tabs.Size = new System.Drawing.Size(668, 715);
            this.control_process_tabs.TabIndex = 21;
            // 
            // x_tab
            // 
            this.x_tab.BackColor = System.Drawing.SystemColors.Control;
            this.x_tab.Controls.Add(this.x_min_effect_edit);
            this.x_tab.Controls.Add(this.x_min_effect_label);
            this.x_tab.Controls.Add(this.x_max_effect_edit);
            this.x_tab.Controls.Add(this.x_max_effect_label);
            this.x_tab.Controls.Add(this.x_period_error_edit);
            this.x_tab.Controls.Add(this.x_period_error_label);
            this.x_tab.Controls.Add(this.x_period_label);
            this.x_tab.Controls.Add(this.x_period_label_text);
            this.x_tab.Controls.Add(this.x_overshoot_label);
            this.x_tab.Controls.Add(this.x_overshoot_label_text);
            this.x_tab.Controls.Add(this.x_current_label);
            this.x_tab.Controls.Add(this.x_current_label_text);
            this.x_tab.Controls.Add(this.x_D_edit);
            this.x_tab.Controls.Add(this.x_D_label);
            this.x_tab.Controls.Add(this.x_I_edit);
            this.x_tab.Controls.Add(this.x_I_label);
            this.x_tab.Controls.Add(this.x_P_edit);
            this.x_tab.Controls.Add(this.x_P_label);
            this.x_tab.Controls.Add(this.x_chart);
            this.x_tab.Location = new System.Drawing.Point(4, 22);
            this.x_tab.Name = "x_tab";
            this.x_tab.Padding = new System.Windows.Forms.Padding(3);
            this.x_tab.Size = new System.Drawing.Size(660, 689);
            this.x_tab.TabIndex = 0;
            this.x_tab.Text = "Угол крена (X)";
            // 
            // x_min_effect_edit
            // 
            this.x_min_effect_edit.DecimalPlaces = 2;
            this.x_min_effect_edit.Location = new System.Drawing.Point(144, 32);
            this.x_min_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_min_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x_min_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_min_effect_edit.Name = "x_min_effect_edit";
            this.x_min_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.x_min_effect_edit.TabIndex = 39;
            // 
            // x_min_effect_label
            // 
            this.x_min_effect_label.AutoSize = true;
            this.x_min_effect_label.Location = new System.Drawing.Point(108, 34);
            this.x_min_effect_label.Name = "x_min_effect_label";
            this.x_min_effect_label.Size = new System.Drawing.Size(27, 13);
            this.x_min_effect_label.TabIndex = 38;
            this.x_min_effect_label.Text = "Min:";
            // 
            // x_max_effect_edit
            // 
            this.x_max_effect_edit.DecimalPlaces = 2;
            this.x_max_effect_edit.Location = new System.Drawing.Point(144, 6);
            this.x_max_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_max_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x_max_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_max_effect_edit.Name = "x_max_effect_edit";
            this.x_max_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.x_max_effect_edit.TabIndex = 37;
            // 
            // x_max_effect_label
            // 
            this.x_max_effect_label.AutoSize = true;
            this.x_max_effect_label.Location = new System.Drawing.Point(108, 8);
            this.x_max_effect_label.Name = "x_max_effect_label";
            this.x_max_effect_label.Size = new System.Drawing.Size(30, 13);
            this.x_max_effect_label.TabIndex = 36;
            this.x_max_effect_label.Text = "Max:";
            // 
            // x_period_error_edit
            // 
            this.x_period_error_edit.DecimalPlaces = 2;
            this.x_period_error_edit.Location = new System.Drawing.Point(377, 59);
            this.x_period_error_edit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_period_error_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_period_error_edit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.x_period_error_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_period_error_edit.Name = "x_period_error_edit";
            this.x_period_error_edit.Size = new System.Drawing.Size(60, 20);
            this.x_period_error_edit.TabIndex = 35;
            this.x_period_error_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // x_period_error_label
            // 
            this.x_period_error_label.AutoSize = true;
            this.x_period_error_label.Location = new System.Drawing.Point(220, 61);
            this.x_period_error_label.Name = "x_period_error_label";
            this.x_period_error_label.Size = new System.Drawing.Size(151, 13);
            this.x_period_error_label.TabIndex = 34;
            this.x_period_error_label.Text = "Погрешность установления:";
            // 
            // x_period_label
            // 
            this.x_period_label.AutoSize = true;
            this.x_period_label.Location = new System.Drawing.Point(389, 6);
            this.x_period_label.Name = "x_period_label";
            this.x_period_label.Size = new System.Drawing.Size(13, 13);
            this.x_period_label.TabIndex = 33;
            this.x_period_label.Text = "0";
            // 
            // x_period_label_text
            // 
            this.x_period_label_text.AutoSize = true;
            this.x_period_label_text.Location = new System.Drawing.Point(220, 6);
            this.x_period_label_text.Name = "x_period_label_text";
            this.x_period_label_text.Size = new System.Drawing.Size(121, 13);
            this.x_period_label_text.TabIndex = 32;
            this.x_period_label_text.Text = "Период установления:";
            // 
            // x_overshoot_label
            // 
            this.x_overshoot_label.AutoSize = true;
            this.x_overshoot_label.Location = new System.Drawing.Point(389, 41);
            this.x_overshoot_label.Name = "x_overshoot_label";
            this.x_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.x_overshoot_label.TabIndex = 31;
            this.x_overshoot_label.Text = "0";
            // 
            // x_overshoot_label_text
            // 
            this.x_overshoot_label_text.AutoSize = true;
            this.x_overshoot_label_text.Location = new System.Drawing.Point(220, 41);
            this.x_overshoot_label_text.Name = "x_overshoot_label_text";
            this.x_overshoot_label_text.Size = new System.Drawing.Size(112, 13);
            this.x_overshoot_label_text.TabIndex = 30;
            this.x_overshoot_label_text.Text = "Перерегулирование:";
            // 
            // x_current_label
            // 
            this.x_current_label.AutoSize = true;
            this.x_current_label.Location = new System.Drawing.Point(389, 24);
            this.x_current_label.Name = "x_current_label";
            this.x_current_label.Size = new System.Drawing.Size(13, 13);
            this.x_current_label.TabIndex = 29;
            this.x_current_label.Text = "0";
            // 
            // x_current_label_text
            // 
            this.x_current_label_text.AutoSize = true;
            this.x_current_label_text.Location = new System.Drawing.Point(220, 24);
            this.x_current_label_text.Name = "x_current_label_text";
            this.x_current_label_text.Size = new System.Drawing.Size(163, 13);
            this.x_current_label_text.TabIndex = 28;
            this.x_current_label_text.Text = "Текущее значение угла крена:";
            // 
            // x_D_edit
            // 
            this.x_D_edit.DecimalPlaces = 2;
            this.x_D_edit.Location = new System.Drawing.Point(38, 58);
            this.x_D_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x_D_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_D_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_D_edit.Name = "x_D_edit";
            this.x_D_edit.Size = new System.Drawing.Size(60, 20);
            this.x_D_edit.TabIndex = 27;
            // 
            // x_D_label
            // 
            this.x_D_label.AutoSize = true;
            this.x_D_label.Location = new System.Drawing.Point(15, 61);
            this.x_D_label.Name = "x_D_label";
            this.x_D_label.Size = new System.Drawing.Size(18, 13);
            this.x_D_label.TabIndex = 26;
            this.x_D_label.Text = "D:";
            // 
            // x_I_edit
            // 
            this.x_I_edit.DecimalPlaces = 2;
            this.x_I_edit.Location = new System.Drawing.Point(38, 32);
            this.x_I_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x_I_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_I_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_I_edit.Name = "x_I_edit";
            this.x_I_edit.Size = new System.Drawing.Size(60, 20);
            this.x_I_edit.TabIndex = 25;
            // 
            // x_I_label
            // 
            this.x_I_label.AutoSize = true;
            this.x_I_label.Location = new System.Drawing.Point(15, 34);
            this.x_I_label.Name = "x_I_label";
            this.x_I_label.Size = new System.Drawing.Size(13, 13);
            this.x_I_label.TabIndex = 24;
            this.x_I_label.Text = "I:";
            // 
            // x_P_edit
            // 
            this.x_P_edit.DecimalPlaces = 2;
            this.x_P_edit.Location = new System.Drawing.Point(38, 6);
            this.x_P_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.x_P_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.x_P_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.x_P_edit.Name = "x_P_edit";
            this.x_P_edit.Size = new System.Drawing.Size(60, 20);
            this.x_P_edit.TabIndex = 23;
            // 
            // x_P_label
            // 
            this.x_P_label.AutoSize = true;
            this.x_P_label.Location = new System.Drawing.Point(15, 8);
            this.x_P_label.Name = "x_P_label";
            this.x_P_label.Size = new System.Drawing.Size(17, 13);
            this.x_P_label.TabIndex = 22;
            this.x_P_label.Text = "P:";
            // 
            // x_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.x_chart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.x_chart.Legends.Add(legend1);
            this.x_chart.Location = new System.Drawing.Point(3, 103);
            this.x_chart.Name = "x_chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Требуемое значение угла крена";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Текущее значение угла крена";
            this.x_chart.Series.Add(series1);
            this.x_chart.Series.Add(series2);
            this.x_chart.Size = new System.Drawing.Size(654, 580);
            this.x_chart.TabIndex = 21;
            this.x_chart.Text = "Угол вокруг оси X";
            // 
            // y_tab
            // 
            this.y_tab.BackColor = System.Drawing.SystemColors.Control;
            this.y_tab.Controls.Add(this.y_min_effect_edit);
            this.y_tab.Controls.Add(this.y_min_effect_label);
            this.y_tab.Controls.Add(this.y_max_effect_edit);
            this.y_tab.Controls.Add(this.y_max_effect_label);
            this.y_tab.Controls.Add(this.y_period_error_edit);
            this.y_tab.Controls.Add(this.y_period_error_label);
            this.y_tab.Controls.Add(this.y_period_label);
            this.y_tab.Controls.Add(this.y_period_label_text);
            this.y_tab.Controls.Add(this.y_overshoot_label);
            this.y_tab.Controls.Add(this.y_overshoot_label_text);
            this.y_tab.Controls.Add(this.y_current_label);
            this.y_tab.Controls.Add(this.y_current_label_text);
            this.y_tab.Controls.Add(this.y_D_edit);
            this.y_tab.Controls.Add(this.y_D_label);
            this.y_tab.Controls.Add(this.y_I_edit);
            this.y_tab.Controls.Add(this.y_I_label);
            this.y_tab.Controls.Add(this.y_P_edit);
            this.y_tab.Controls.Add(this.y_P_label);
            this.y_tab.Controls.Add(this.y_chart);
            this.y_tab.Location = new System.Drawing.Point(4, 22);
            this.y_tab.Name = "y_tab";
            this.y_tab.Padding = new System.Windows.Forms.Padding(3);
            this.y_tab.Size = new System.Drawing.Size(660, 689);
            this.y_tab.TabIndex = 1;
            this.y_tab.Text = "Угол тангажа (Y)";
            // 
            // y_period_error_edit
            // 
            this.y_period_error_edit.DecimalPlaces = 2;
            this.y_period_error_edit.Location = new System.Drawing.Point(437, 6);
            this.y_period_error_edit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.y_period_error_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_period_error_edit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.y_period_error_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_period_error_edit.Name = "y_period_error_edit";
            this.y_period_error_edit.Size = new System.Drawing.Size(60, 20);
            this.y_period_error_edit.TabIndex = 49;
            this.y_period_error_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // y_period_error_label
            // 
            this.y_period_error_label.AutoSize = true;
            this.y_period_error_label.Location = new System.Drawing.Point(280, 8);
            this.y_period_error_label.Name = "y_period_error_label";
            this.y_period_error_label.Size = new System.Drawing.Size(151, 13);
            this.y_period_error_label.TabIndex = 48;
            this.y_period_error_label.Text = "Погрешность установления:";
            // 
            // y_period_label
            // 
            this.y_period_label.AutoSize = true;
            this.y_period_label.Location = new System.Drawing.Point(557, 41);
            this.y_period_label.Name = "y_period_label";
            this.y_period_label.Size = new System.Drawing.Size(13, 13);
            this.y_period_label.TabIndex = 47;
            this.y_period_label.Text = "0";
            // 
            // y_period_label_text
            // 
            this.y_period_label_text.AutoSize = true;
            this.y_period_label_text.Location = new System.Drawing.Point(388, 41);
            this.y_period_label_text.Name = "y_period_label_text";
            this.y_period_label_text.Size = new System.Drawing.Size(121, 13);
            this.y_period_label_text.TabIndex = 46;
            this.y_period_label_text.Text = "Период установления:";
            // 
            // y_overshoot_label
            // 
            this.y_overshoot_label.AutoSize = true;
            this.y_overshoot_label.Location = new System.Drawing.Point(557, 76);
            this.y_overshoot_label.Name = "y_overshoot_label";
            this.y_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.y_overshoot_label.TabIndex = 45;
            this.y_overshoot_label.Text = "0";
            // 
            // y_overshoot_label_text
            // 
            this.y_overshoot_label_text.AutoSize = true;
            this.y_overshoot_label_text.Location = new System.Drawing.Point(388, 76);
            this.y_overshoot_label_text.Name = "y_overshoot_label_text";
            this.y_overshoot_label_text.Size = new System.Drawing.Size(112, 13);
            this.y_overshoot_label_text.TabIndex = 44;
            this.y_overshoot_label_text.Text = "Перерегулирование:";
            // 
            // y_current_label
            // 
            this.y_current_label.AutoSize = true;
            this.y_current_label.Location = new System.Drawing.Point(557, 59);
            this.y_current_label.Name = "y_current_label";
            this.y_current_label.Size = new System.Drawing.Size(13, 13);
            this.y_current_label.TabIndex = 43;
            this.y_current_label.Text = "0";
            // 
            // y_current_label_text
            // 
            this.y_current_label_text.AutoSize = true;
            this.y_current_label_text.Location = new System.Drawing.Point(388, 59);
            this.y_current_label_text.Name = "y_current_label_text";
            this.y_current_label_text.Size = new System.Drawing.Size(163, 13);
            this.y_current_label_text.TabIndex = 42;
            this.y_current_label_text.Text = "Текущее значение угла крена:";
            // 
            // y_D_edit
            // 
            this.y_D_edit.DecimalPlaces = 2;
            this.y_D_edit.Location = new System.Drawing.Point(38, 58);
            this.y_D_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y_D_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_D_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_D_edit.Name = "y_D_edit";
            this.y_D_edit.Size = new System.Drawing.Size(60, 20);
            this.y_D_edit.TabIndex = 41;
            // 
            // y_D_label
            // 
            this.y_D_label.AutoSize = true;
            this.y_D_label.Location = new System.Drawing.Point(15, 61);
            this.y_D_label.Name = "y_D_label";
            this.y_D_label.Size = new System.Drawing.Size(18, 13);
            this.y_D_label.TabIndex = 40;
            this.y_D_label.Text = "D:";
            // 
            // y_I_edit
            // 
            this.y_I_edit.DecimalPlaces = 2;
            this.y_I_edit.Location = new System.Drawing.Point(38, 32);
            this.y_I_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y_I_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_I_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_I_edit.Name = "y_I_edit";
            this.y_I_edit.Size = new System.Drawing.Size(60, 20);
            this.y_I_edit.TabIndex = 39;
            // 
            // y_I_label
            // 
            this.y_I_label.AutoSize = true;
            this.y_I_label.Location = new System.Drawing.Point(15, 34);
            this.y_I_label.Name = "y_I_label";
            this.y_I_label.Size = new System.Drawing.Size(13, 13);
            this.y_I_label.TabIndex = 38;
            this.y_I_label.Text = "I:";
            // 
            // y_P_edit
            // 
            this.y_P_edit.DecimalPlaces = 2;
            this.y_P_edit.Location = new System.Drawing.Point(38, 6);
            this.y_P_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y_P_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_P_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_P_edit.Name = "y_P_edit";
            this.y_P_edit.Size = new System.Drawing.Size(60, 20);
            this.y_P_edit.TabIndex = 37;
            // 
            // y_P_label
            // 
            this.y_P_label.AutoSize = true;
            this.y_P_label.Location = new System.Drawing.Point(15, 8);
            this.y_P_label.Name = "y_P_label";
            this.y_P_label.Size = new System.Drawing.Size(17, 13);
            this.y_P_label.TabIndex = 36;
            this.y_P_label.Text = "P:";
            // 
            // y_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.y_chart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.y_chart.Legends.Add(legend2);
            this.y_chart.Location = new System.Drawing.Point(3, 103);
            this.y_chart.Name = "y_chart";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Требуемое значение угла тангажа";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Текущее значение угла тангажа";
            this.y_chart.Series.Add(series3);
            this.y_chart.Series.Add(series4);
            this.y_chart.Size = new System.Drawing.Size(654, 583);
            this.y_chart.TabIndex = 22;
            this.y_chart.Text = "Угол вокруг оси X";
            // 
            // z_tab
            // 
            this.z_tab.BackColor = System.Drawing.SystemColors.Control;
            this.z_tab.Controls.Add(this.z_min_effect_edit);
            this.z_tab.Controls.Add(this.z_min_effect_label);
            this.z_tab.Controls.Add(this.z_max_effect_edit);
            this.z_tab.Controls.Add(this.z_max_effect_label);
            this.z_tab.Controls.Add(this.z_period_error_edit);
            this.z_tab.Controls.Add(this.z_period_error_label);
            this.z_tab.Controls.Add(this.z_period_label);
            this.z_tab.Controls.Add(this.z_period_label_text);
            this.z_tab.Controls.Add(this.z_overshoot_label);
            this.z_tab.Controls.Add(this.z_overshoot_label_text);
            this.z_tab.Controls.Add(this.z_current_label);
            this.z_tab.Controls.Add(this.z_current_label_text);
            this.z_tab.Controls.Add(this.z_D_edit);
            this.z_tab.Controls.Add(this.z_D_label);
            this.z_tab.Controls.Add(this.z_I_edit);
            this.z_tab.Controls.Add(this.z_I_label);
            this.z_tab.Controls.Add(this.z_P_edit);
            this.z_tab.Controls.Add(this.z_P_label);
            this.z_tab.Controls.Add(this.z_chart);
            this.z_tab.Location = new System.Drawing.Point(4, 22);
            this.z_tab.Name = "z_tab";
            this.z_tab.Size = new System.Drawing.Size(660, 689);
            this.z_tab.TabIndex = 2;
            this.z_tab.Text = "Угол рысканья (Z)";
            // 
            // z_period_error_edit
            // 
            this.z_period_error_edit.DecimalPlaces = 2;
            this.z_period_error_edit.Location = new System.Drawing.Point(437, 6);
            this.z_period_error_edit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.z_period_error_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_period_error_edit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.z_period_error_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_period_error_edit.Name = "z_period_error_edit";
            this.z_period_error_edit.Size = new System.Drawing.Size(60, 20);
            this.z_period_error_edit.TabIndex = 49;
            this.z_period_error_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // z_period_error_label
            // 
            this.z_period_error_label.AutoSize = true;
            this.z_period_error_label.Location = new System.Drawing.Point(280, 8);
            this.z_period_error_label.Name = "z_period_error_label";
            this.z_period_error_label.Size = new System.Drawing.Size(151, 13);
            this.z_period_error_label.TabIndex = 48;
            this.z_period_error_label.Text = "Погрешность установления:";
            // 
            // z_period_label
            // 
            this.z_period_label.AutoSize = true;
            this.z_period_label.Location = new System.Drawing.Point(569, 44);
            this.z_period_label.Name = "z_period_label";
            this.z_period_label.Size = new System.Drawing.Size(13, 13);
            this.z_period_label.TabIndex = 47;
            this.z_period_label.Text = "0";
            // 
            // z_period_label_text
            // 
            this.z_period_label_text.AutoSize = true;
            this.z_period_label_text.Location = new System.Drawing.Point(400, 44);
            this.z_period_label_text.Name = "z_period_label_text";
            this.z_period_label_text.Size = new System.Drawing.Size(121, 13);
            this.z_period_label_text.TabIndex = 46;
            this.z_period_label_text.Text = "Период установления:";
            // 
            // z_overshoot_label
            // 
            this.z_overshoot_label.AutoSize = true;
            this.z_overshoot_label.Location = new System.Drawing.Point(569, 79);
            this.z_overshoot_label.Name = "z_overshoot_label";
            this.z_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.z_overshoot_label.TabIndex = 45;
            this.z_overshoot_label.Text = "0";
            // 
            // z_overshoot_label_text
            // 
            this.z_overshoot_label_text.AutoSize = true;
            this.z_overshoot_label_text.Location = new System.Drawing.Point(400, 79);
            this.z_overshoot_label_text.Name = "z_overshoot_label_text";
            this.z_overshoot_label_text.Size = new System.Drawing.Size(112, 13);
            this.z_overshoot_label_text.TabIndex = 44;
            this.z_overshoot_label_text.Text = "Перерегулирование:";
            // 
            // z_current_label
            // 
            this.z_current_label.AutoSize = true;
            this.z_current_label.Location = new System.Drawing.Point(569, 62);
            this.z_current_label.Name = "z_current_label";
            this.z_current_label.Size = new System.Drawing.Size(13, 13);
            this.z_current_label.TabIndex = 43;
            this.z_current_label.Text = "0";
            // 
            // z_current_label_text
            // 
            this.z_current_label_text.AutoSize = true;
            this.z_current_label_text.Location = new System.Drawing.Point(400, 62);
            this.z_current_label_text.Name = "z_current_label_text";
            this.z_current_label_text.Size = new System.Drawing.Size(163, 13);
            this.z_current_label_text.TabIndex = 42;
            this.z_current_label_text.Text = "Текущее значение угла крена:";
            // 
            // z_D_edit
            // 
            this.z_D_edit.DecimalPlaces = 2;
            this.z_D_edit.Location = new System.Drawing.Point(38, 58);
            this.z_D_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.z_D_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_D_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_D_edit.Name = "z_D_edit";
            this.z_D_edit.Size = new System.Drawing.Size(60, 20);
            this.z_D_edit.TabIndex = 41;
            // 
            // z_D_label
            // 
            this.z_D_label.AutoSize = true;
            this.z_D_label.Location = new System.Drawing.Point(15, 61);
            this.z_D_label.Name = "z_D_label";
            this.z_D_label.Size = new System.Drawing.Size(18, 13);
            this.z_D_label.TabIndex = 40;
            this.z_D_label.Text = "D:";
            // 
            // z_I_edit
            // 
            this.z_I_edit.DecimalPlaces = 2;
            this.z_I_edit.Location = new System.Drawing.Point(38, 32);
            this.z_I_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.z_I_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_I_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_I_edit.Name = "z_I_edit";
            this.z_I_edit.Size = new System.Drawing.Size(60, 20);
            this.z_I_edit.TabIndex = 39;
            // 
            // z_I_label
            // 
            this.z_I_label.AutoSize = true;
            this.z_I_label.Location = new System.Drawing.Point(15, 34);
            this.z_I_label.Name = "z_I_label";
            this.z_I_label.Size = new System.Drawing.Size(13, 13);
            this.z_I_label.TabIndex = 38;
            this.z_I_label.Text = "I:";
            // 
            // z_P_edit
            // 
            this.z_P_edit.DecimalPlaces = 2;
            this.z_P_edit.Location = new System.Drawing.Point(38, 6);
            this.z_P_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.z_P_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_P_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_P_edit.Name = "z_P_edit";
            this.z_P_edit.Size = new System.Drawing.Size(60, 20);
            this.z_P_edit.TabIndex = 37;
            // 
            // z_P_label
            // 
            this.z_P_label.AutoSize = true;
            this.z_P_label.Location = new System.Drawing.Point(15, 8);
            this.z_P_label.Name = "z_P_label";
            this.z_P_label.Size = new System.Drawing.Size(17, 13);
            this.z_P_label.TabIndex = 36;
            this.z_P_label.Text = "P:";
            // 
            // z_chart
            // 
            chartArea3.Name = "ChartArea1";
            this.z_chart.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            this.z_chart.Legends.Add(legend3);
            this.z_chart.Location = new System.Drawing.Point(3, 103);
            this.z_chart.Name = "z_chart";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Требуемое значение угла рысканья";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Текущее значение угла рысканья";
            this.z_chart.Series.Add(series5);
            this.z_chart.Series.Add(series6);
            this.z_chart.Size = new System.Drawing.Size(654, 583);
            this.z_chart.TabIndex = 22;
            this.z_chart.Text = "Угол вокруг оси X";
            // 
            // y_min_effect_edit
            // 
            this.y_min_effect_edit.DecimalPlaces = 2;
            this.y_min_effect_edit.Location = new System.Drawing.Point(294, 78);
            this.y_min_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_min_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y_min_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_min_effect_edit.Name = "y_min_effect_edit";
            this.y_min_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.y_min_effect_edit.TabIndex = 53;
            // 
            // y_min_effect_label
            // 
            this.y_min_effect_label.AutoSize = true;
            this.y_min_effect_label.Location = new System.Drawing.Point(108, 34);
            this.y_min_effect_label.Name = "y_min_effect_label";
            this.y_min_effect_label.Size = new System.Drawing.Size(27, 13);
            this.y_min_effect_label.TabIndex = 52;
            this.y_min_effect_label.Text = "Min:";
            // 
            // y_max_effect_edit
            // 
            this.y_max_effect_edit.DecimalPlaces = 2;
            this.y_max_effect_edit.Location = new System.Drawing.Point(294, 52);
            this.y_max_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_max_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y_max_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_max_effect_edit.Name = "y_max_effect_edit";
            this.y_max_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.y_max_effect_edit.TabIndex = 51;
            // 
            // y_max_effect_label
            // 
            this.y_max_effect_label.AutoSize = true;
            this.y_max_effect_label.Location = new System.Drawing.Point(108, 8);
            this.y_max_effect_label.Name = "y_max_effect_label";
            this.y_max_effect_label.Size = new System.Drawing.Size(30, 13);
            this.y_max_effect_label.TabIndex = 50;
            this.y_max_effect_label.Text = "Max:";
            // 
            // z_min_effect_edit
            // 
            this.z_min_effect_edit.DecimalPlaces = 2;
            this.z_min_effect_edit.Location = new System.Drawing.Point(311, 68);
            this.z_min_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_min_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_min_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_min_effect_edit.Name = "z_min_effect_edit";
            this.z_min_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.z_min_effect_edit.TabIndex = 53;
            // 
            // z_min_effect_label
            // 
            this.z_min_effect_label.AutoSize = true;
            this.z_min_effect_label.Location = new System.Drawing.Point(275, 70);
            this.z_min_effect_label.Name = "z_min_effect_label";
            this.z_min_effect_label.Size = new System.Drawing.Size(27, 13);
            this.z_min_effect_label.TabIndex = 52;
            this.z_min_effect_label.Text = "Min:";
            // 
            // z_max_effect_edit
            // 
            this.z_max_effect_edit.DecimalPlaces = 2;
            this.z_max_effect_edit.Location = new System.Drawing.Point(311, 42);
            this.z_max_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_max_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_max_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_max_effect_edit.Name = "z_max_effect_edit";
            this.z_max_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.z_max_effect_edit.TabIndex = 51;
            // 
            // z_max_effect_label
            // 
            this.z_max_effect_label.AutoSize = true;
            this.z_max_effect_label.Location = new System.Drawing.Point(108, 8);
            this.z_max_effect_label.Name = "z_max_effect_label";
            this.z_max_effect_label.Size = new System.Drawing.Size(30, 13);
            this.z_max_effect_label.TabIndex = 50;
            this.z_max_effect_label.Text = "Max:";
            // 
            // dt_label
            // 
            this.dt_label.AutoSize = true;
            this.dt_label.Location = new System.Drawing.Point(12, 216);
            this.dt_label.Name = "dt_label";
            this.dt_label.Size = new System.Drawing.Size(137, 13);
            this.dt_label.TabIndex = 22;
            this.dt_label.Text = "Дискретизация времени:";
            // 
            // dt_box
            // 
            this.dt_box.DisplayMember = "1";
            this.dt_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dt_box.FormattingEnabled = true;
            this.dt_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.dt_box.Location = new System.Drawing.Point(201, 213);
            this.dt_box.Name = "dt_box";
            this.dt_box.Size = new System.Drawing.Size(60, 21);
            this.dt_box.TabIndex = 23;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 729);
            this.Controls.Add(this.dt_box);
            this.Controls.Add(this.dt_label);
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
            this.x_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_min_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_max_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_period_error_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_D_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_I_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_P_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_chart)).EndInit();
            this.y_tab.ResumeLayout(false);
            this.y_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_period_error_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_D_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_I_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_P_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).EndInit();
            this.z_tab.ResumeLayout(false);
            this.z_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_period_error_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_D_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_I_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_P_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_min_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_max_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_min_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_max_effect_edit)).EndInit();
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
        private System.Windows.Forms.NumericUpDown x_D_edit;
        private System.Windows.Forms.Label x_D_label;
        private System.Windows.Forms.NumericUpDown x_I_edit;
        private System.Windows.Forms.Label x_I_label;
        private System.Windows.Forms.NumericUpDown x_P_edit;
        private System.Windows.Forms.Label x_P_label;
        private System.Windows.Forms.Label x_current_label;
        private System.Windows.Forms.Label x_current_label_text;
        private System.Windows.Forms.Label x_overshoot_label;
        private System.Windows.Forms.Label x_overshoot_label_text;
        private System.Windows.Forms.Label x_period_label;
        private System.Windows.Forms.Label x_period_label_text;
        private System.Windows.Forms.NumericUpDown x_period_error_edit;
        private System.Windows.Forms.Label x_period_error_label;
        private System.Windows.Forms.NumericUpDown z_period_error_edit;
        private System.Windows.Forms.Label z_period_error_label;
        private System.Windows.Forms.Label z_period_label;
        private System.Windows.Forms.Label z_period_label_text;
        private System.Windows.Forms.Label z_overshoot_label;
        private System.Windows.Forms.Label z_overshoot_label_text;
        private System.Windows.Forms.Label z_current_label;
        private System.Windows.Forms.Label z_current_label_text;
        private System.Windows.Forms.NumericUpDown z_D_edit;
        private System.Windows.Forms.Label z_D_label;
        private System.Windows.Forms.NumericUpDown z_I_edit;
        private System.Windows.Forms.Label z_I_label;
        private System.Windows.Forms.NumericUpDown z_P_edit;
        private System.Windows.Forms.Label z_P_label;
        private System.Windows.Forms.NumericUpDown y_period_error_edit;
        private System.Windows.Forms.Label y_period_error_label;
        private System.Windows.Forms.Label y_period_label;
        private System.Windows.Forms.Label y_period_label_text;
        private System.Windows.Forms.Label y_overshoot_label;
        private System.Windows.Forms.Label y_overshoot_label_text;
        private System.Windows.Forms.Label y_current_label;
        private System.Windows.Forms.Label y_current_label_text;
        private System.Windows.Forms.NumericUpDown y_D_edit;
        private System.Windows.Forms.Label y_D_label;
        private System.Windows.Forms.NumericUpDown y_I_edit;
        private System.Windows.Forms.Label y_I_label;
        private System.Windows.Forms.NumericUpDown y_P_edit;
        private System.Windows.Forms.Label y_P_label;
        private System.Windows.Forms.NumericUpDown x_min_effect_edit;
        private System.Windows.Forms.Label x_min_effect_label;
        private System.Windows.Forms.NumericUpDown x_max_effect_edit;
        private System.Windows.Forms.Label x_max_effect_label;
        private System.Windows.Forms.NumericUpDown y_min_effect_edit;
        private System.Windows.Forms.Label y_min_effect_label;
        private System.Windows.Forms.NumericUpDown y_max_effect_edit;
        private System.Windows.Forms.Label y_max_effect_label;
        private System.Windows.Forms.NumericUpDown z_min_effect_edit;
        private System.Windows.Forms.Label z_min_effect_label;
        private System.Windows.Forms.NumericUpDown z_max_effect_edit;
        private System.Windows.Forms.Label z_max_effect_label;
        private System.Windows.Forms.Label dt_label;
        private System.Windows.Forms.ComboBox dt_box;
    }
}

