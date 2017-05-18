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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.x_anfis_check_box = new System.Windows.Forms.CheckBox();
            this.x_ziegler_button = new System.Windows.Forms.Button();
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
            this.y_anfis_check_box = new System.Windows.Forms.CheckBox();
            this.y_ziegler_button = new System.Windows.Forms.Button();
            this.y_min_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.y_min_effect_label = new System.Windows.Forms.Label();
            this.y_max_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.y_max_effect_label = new System.Windows.Forms.Label();
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
            this.z_anfis_check_box = new System.Windows.Forms.CheckBox();
            this.z_ziegler_button = new System.Windows.Forms.Button();
            this.z_min_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.z_min_effect_label = new System.Windows.Forms.Label();
            this.z_max_effect_edit = new System.Windows.Forms.NumericUpDown();
            this.z_max_effect_label = new System.Windows.Forms.Label();
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
            this.dt_label = new System.Windows.Forms.Label();
            this.dt_box = new System.Windows.Forms.ComboBox();
            this.quadcopter_label = new System.Windows.Forms.Label();
            this.mass_frame_edit = new System.Windows.Forms.NumericUpDown();
            this.mass_frame_label = new System.Windows.Forms.Label();
            this.radius_edit = new System.Windows.Forms.NumericUpDown();
            this.radius_label = new System.Windows.Forms.Label();
            this.mass_engine_edit = new System.Windows.Forms.NumericUpDown();
            this.mass_engine_label = new System.Windows.Forms.Label();
            this.arm_length_edit = new System.Windows.Forms.NumericUpDown();
            this.arm_length_label = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.y_min_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_max_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_period_error_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_D_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_I_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_P_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).BeginInit();
            this.z_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_min_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_max_effect_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_period_error_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_D_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_I_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_P_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_frame_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_engine_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arm_length_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(141, 460);
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
            this.stop_button.Location = new System.Drawing.Point(141, 496);
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
            this.continue_button.Location = new System.Drawing.Point(267, 460);
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
            this.pause_button.Location = new System.Drawing.Point(267, 496);
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
            this.main_time_label_text.Location = new System.Drawing.Point(163, 435);
            this.main_time_label_text.Name = "main_time_label_text";
            this.main_time_label_text.Size = new System.Drawing.Size(105, 13);
            this.main_time_label_text.TabIndex = 4;
            this.main_time_label_text.Text = "Текущее время (с):";
            // 
            // main_time_label
            // 
            this.main_time_label.AutoSize = true;
            this.main_time_label.Location = new System.Drawing.Point(326, 435);
            this.main_time_label.Name = "main_time_label";
            this.main_time_label.Size = new System.Drawing.Size(13, 13);
            this.main_time_label.TabIndex = 5;
            this.main_time_label.Text = "0";
            // 
            // reference_label
            // 
            this.reference_label.AutoSize = true;
            this.reference_label.Location = new System.Drawing.Point(12, 166);
            this.reference_label.Name = "reference_label";
            this.reference_label.Size = new System.Drawing.Size(176, 13);
            this.reference_label.TabIndex = 6;
            this.reference_label.Text = "Требуемое положение (градусы):";
            // 
            // inital_state_label
            // 
            this.inital_state_label.AutoSize = true;
            this.inital_state_label.Location = new System.Drawing.Point(12, 274);
            this.inital_state_label.Name = "inital_state_label";
            this.inital_state_label.Size = new System.Drawing.Size(169, 13);
            this.inital_state_label.TabIndex = 7;
            this.inital_state_label.Text = "Исходное положение (градусы):";
            // 
            // z_reference_label
            // 
            this.z_reference_label.AutoSize = true;
            this.z_reference_label.Location = new System.Drawing.Point(161, 240);
            this.z_reference_label.Name = "z_reference_label";
            this.z_reference_label.Size = new System.Drawing.Size(162, 13);
            this.z_reference_label.TabIndex = 8;
            this.z_reference_label.Text = "Требуемый угол рысканья (Z):";
            // 
            // y_reference_label
            // 
            this.y_reference_label.AutoSize = true;
            this.y_reference_label.Location = new System.Drawing.Point(161, 218);
            this.y_reference_label.Name = "y_reference_label";
            this.y_reference_label.Size = new System.Drawing.Size(154, 13);
            this.y_reference_label.TabIndex = 9;
            this.y_reference_label.Text = "Требуемый угол тангажа (Y):";
            // 
            // x_reference_label
            // 
            this.x_reference_label.AutoSize = true;
            this.x_reference_label.Location = new System.Drawing.Point(161, 195);
            this.x_reference_label.Name = "x_reference_label";
            this.x_reference_label.Size = new System.Drawing.Size(142, 13);
            this.x_reference_label.TabIndex = 10;
            this.x_reference_label.Text = "Требуемый угол крена (X):";
            // 
            // x_initial_label
            // 
            this.x_initial_label.AutoSize = true;
            this.x_initial_label.Location = new System.Drawing.Point(168, 307);
            this.x_initial_label.Name = "x_initial_label";
            this.x_initial_label.Size = new System.Drawing.Size(135, 13);
            this.x_initial_label.TabIndex = 13;
            this.x_initial_label.Text = "Исходный угол крена (X):";
            // 
            // y_initial_label
            // 
            this.y_initial_label.AutoSize = true;
            this.y_initial_label.Location = new System.Drawing.Point(168, 330);
            this.y_initial_label.Name = "y_initial_label";
            this.y_initial_label.Size = new System.Drawing.Size(147, 13);
            this.y_initial_label.TabIndex = 12;
            this.y_initial_label.Text = "Исходный угол тангажа (Y):";
            // 
            // z_initial_label
            // 
            this.z_initial_label.AutoSize = true;
            this.z_initial_label.Location = new System.Drawing.Point(168, 352);
            this.z_initial_label.Name = "z_initial_label";
            this.z_initial_label.Size = new System.Drawing.Size(155, 13);
            this.z_initial_label.TabIndex = 11;
            this.z_initial_label.Text = "Исходный угол рысканья (Z):";
            // 
            // x_reference_edit
            // 
            this.x_reference_edit.DecimalPlaces = 2;
            this.x_reference_edit.Location = new System.Drawing.Point(329, 193);
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
            this.y_reference_edit.Location = new System.Drawing.Point(329, 216);
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
            this.z_reference_edit.Location = new System.Drawing.Point(329, 238);
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
            this.z_initial_edit.Location = new System.Drawing.Point(329, 350);
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
            this.y_initial_edit.Location = new System.Drawing.Point(329, 328);
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
            this.x_initial_edit.Location = new System.Drawing.Point(329, 305);
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
            this.x_initial_edit.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // control_process_tabs
            // 
            this.control_process_tabs.Controls.Add(this.x_tab);
            this.control_process_tabs.Controls.Add(this.y_tab);
            this.control_process_tabs.Controls.Add(this.z_tab);
            this.control_process_tabs.Location = new System.Drawing.Point(395, 12);
            this.control_process_tabs.Name = "control_process_tabs";
            this.control_process_tabs.SelectedIndex = 0;
            this.control_process_tabs.Size = new System.Drawing.Size(711, 715);
            this.control_process_tabs.TabIndex = 21;
            // 
            // x_tab
            // 
            this.x_tab.BackColor = System.Drawing.SystemColors.Control;
            this.x_tab.Controls.Add(this.x_anfis_check_box);
            this.x_tab.Controls.Add(this.x_ziegler_button);
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
            this.x_tab.Size = new System.Drawing.Size(703, 689);
            this.x_tab.TabIndex = 0;
            this.x_tab.Text = "Угол крена (X)";
            // 
            // x_anfis_check_box
            // 
            this.x_anfis_check_box.AutoSize = true;
            this.x_anfis_check_box.Location = new System.Drawing.Point(419, 89);
            this.x_anfis_check_box.Name = "x_anfis_check_box";
            this.x_anfis_check_box.Size = new System.Drawing.Size(277, 17);
            this.x_anfis_check_box.TabIndex = 41;
            this.x_anfis_check_box.Text = "Использовать Нейро - нечеткий ПИД - регулятор";
            this.x_anfis_check_box.UseVisualStyleBackColor = true;
            this.x_anfis_check_box.CheckedChanged += new System.EventHandler(this.x_anfis_check_box_CheckedChanged);
            // 
            // x_ziegler_button
            // 
            this.x_ziegler_button.Location = new System.Drawing.Point(18, 85);
            this.x_ziegler_button.Name = "x_ziegler_button";
            this.x_ziegler_button.Size = new System.Drawing.Size(395, 23);
            this.x_ziegler_button.TabIndex = 40;
            this.x_ziegler_button.Text = "Рассчитать коэффициенты ПИД-регулятора методом Зиглера-Никольса";
            this.x_ziegler_button.UseVisualStyleBackColor = true;
            this.x_ziegler_button.Click += new System.EventHandler(this.ziegler_button_Click);
            // 
            // x_min_effect_edit
            // 
            this.x_min_effect_edit.DecimalPlaces = 2;
            this.x_min_effect_edit.Location = new System.Drawing.Point(333, 32);
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
            this.x_min_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // x_min_effect_label
            // 
            this.x_min_effect_label.AutoSize = true;
            this.x_min_effect_label.Location = new System.Drawing.Point(125, 34);
            this.x_min_effect_label.Name = "x_min_effect_label";
            this.x_min_effect_label.Size = new System.Drawing.Size(146, 13);
            this.x_min_effect_label.TabIndex = 38;
            this.x_min_effect_label.Text = "Мин. сила воздействия (Н):";
            // 
            // x_max_effect_edit
            // 
            this.x_max_effect_edit.DecimalPlaces = 2;
            this.x_max_effect_edit.Location = new System.Drawing.Point(333, 6);
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
            this.x_max_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // x_max_effect_label
            // 
            this.x_max_effect_label.AutoSize = true;
            this.x_max_effect_label.Location = new System.Drawing.Point(125, 8);
            this.x_max_effect_label.Name = "x_max_effect_label";
            this.x_max_effect_label.Size = new System.Drawing.Size(152, 13);
            this.x_max_effect_label.TabIndex = 36;
            this.x_max_effect_label.Text = "Макс. сила воздействия (Н):";
            // 
            // x_period_error_edit
            // 
            this.x_period_error_edit.DecimalPlaces = 2;
            this.x_period_error_edit.Location = new System.Drawing.Point(333, 59);
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
            0});
            // 
            // x_period_error_label
            // 
            this.x_period_error_label.AutoSize = true;
            this.x_period_error_label.Location = new System.Drawing.Point(125, 61);
            this.x_period_error_label.Name = "x_period_error_label";
            this.x_period_error_label.Size = new System.Drawing.Size(202, 13);
            this.x_period_error_label.TabIndex = 34;
            this.x_period_error_label.Text = "Погрешность установления (градусы):";
            // 
            // x_period_label
            // 
            this.x_period_label.AutoSize = true;
            this.x_period_label.Location = new System.Drawing.Point(636, 6);
            this.x_period_label.Name = "x_period_label";
            this.x_period_label.Size = new System.Drawing.Size(13, 13);
            this.x_period_label.TabIndex = 33;
            this.x_period_label.Text = "0";
            // 
            // x_period_label_text
            // 
            this.x_period_label_text.AutoSize = true;
            this.x_period_label_text.Location = new System.Drawing.Point(416, 8);
            this.x_period_label_text.Name = "x_period_label_text";
            this.x_period_label_text.Size = new System.Drawing.Size(136, 13);
            this.x_period_label_text.TabIndex = 32;
            this.x_period_label_text.Text = "Период установления (с):";
            // 
            // x_overshoot_label
            // 
            this.x_overshoot_label.AutoSize = true;
            this.x_overshoot_label.Location = new System.Drawing.Point(636, 61);
            this.x_overshoot_label.Name = "x_overshoot_label";
            this.x_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.x_overshoot_label.TabIndex = 31;
            this.x_overshoot_label.Text = "0";
            // 
            // x_overshoot_label_text
            // 
            this.x_overshoot_label_text.AutoSize = true;
            this.x_overshoot_label_text.Location = new System.Drawing.Point(416, 61);
            this.x_overshoot_label_text.Name = "x_overshoot_label_text";
            this.x_overshoot_label_text.Size = new System.Drawing.Size(163, 13);
            this.x_overshoot_label_text.TabIndex = 30;
            this.x_overshoot_label_text.Text = "Перерегулирование (градусы):";
            // 
            // x_current_label
            // 
            this.x_current_label.AutoSize = true;
            this.x_current_label.Location = new System.Drawing.Point(636, 34);
            this.x_current_label.Name = "x_current_label";
            this.x_current_label.Size = new System.Drawing.Size(13, 13);
            this.x_current_label.TabIndex = 29;
            this.x_current_label.Text = "0";
            // 
            // x_current_label_text
            // 
            this.x_current_label_text.AutoSize = true;
            this.x_current_label_text.Location = new System.Drawing.Point(416, 34);
            this.x_current_label_text.Name = "x_current_label_text";
            this.x_current_label_text.Size = new System.Drawing.Size(214, 13);
            this.x_current_label_text.TabIndex = 28;
            this.x_current_label_text.Text = "Текущее значение угла крена (градусы):";
            // 
            // x_D_edit
            // 
            this.x_D_edit.DecimalPlaces = 2;
            this.x_D_edit.Location = new System.Drawing.Point(38, 59);
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
            this.x_D_edit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // x_D_label
            // 
            this.x_D_label.AutoSize = true;
            this.x_D_label.Location = new System.Drawing.Point(15, 61);
            this.x_D_label.Name = "x_D_label";
            this.x_D_label.Size = new System.Drawing.Size(19, 13);
            this.x_D_label.TabIndex = 26;
            this.x_D_label.Text = "Д:";
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
            this.x_I_label.Size = new System.Drawing.Size(18, 13);
            this.x_I_label.TabIndex = 24;
            this.x_I_label.Text = "И:";
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
            this.x_P_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // x_P_label
            // 
            this.x_P_label.AutoSize = true;
            this.x_P_label.Location = new System.Drawing.Point(15, 8);
            this.x_P_label.Name = "x_P_label";
            this.x_P_label.Size = new System.Drawing.Size(18, 13);
            this.x_P_label.TabIndex = 22;
            this.x_P_label.Text = "П:";
            // 
            // x_chart
            // 
            chartArea5.Name = "ChartArea1";
            this.x_chart.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend5.Name = "Legend1";
            this.x_chart.Legends.Add(legend5);
            this.x_chart.Location = new System.Drawing.Point(3, 114);
            this.x_chart.Name = "x_chart";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Требуемое значение угла крена";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Текущее значение угла крена";
            this.x_chart.Series.Add(series9);
            this.x_chart.Series.Add(series10);
            this.x_chart.Size = new System.Drawing.Size(695, 570);
            this.x_chart.TabIndex = 21;
            this.x_chart.Text = "Угол вокруг оси X";
            // 
            // y_tab
            // 
            this.y_tab.BackColor = System.Drawing.SystemColors.Control;
            this.y_tab.Controls.Add(this.y_anfis_check_box);
            this.y_tab.Controls.Add(this.y_ziegler_button);
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
            this.y_tab.Size = new System.Drawing.Size(703, 689);
            this.y_tab.TabIndex = 1;
            this.y_tab.Text = "Угол тангажа (Y)";
            // 
            // y_anfis_check_box
            // 
            this.y_anfis_check_box.AutoSize = true;
            this.y_anfis_check_box.Location = new System.Drawing.Point(419, 89);
            this.y_anfis_check_box.Name = "y_anfis_check_box";
            this.y_anfis_check_box.Size = new System.Drawing.Size(277, 17);
            this.y_anfis_check_box.TabIndex = 61;
            this.y_anfis_check_box.Text = "Использовать Нейро - нечеткий ПИД - регулятор";
            this.y_anfis_check_box.UseVisualStyleBackColor = true;
            this.y_anfis_check_box.CheckedChanged += new System.EventHandler(this.y_anfis_check_box_CheckedChanged);
            // 
            // y_ziegler_button
            // 
            this.y_ziegler_button.Location = new System.Drawing.Point(18, 85);
            this.y_ziegler_button.Name = "y_ziegler_button";
            this.y_ziegler_button.Size = new System.Drawing.Size(395, 23);
            this.y_ziegler_button.TabIndex = 60;
            this.y_ziegler_button.Text = "Рассчитать коэффициенты ПИД-регулятора методом Зиглера-Никольса";
            this.y_ziegler_button.UseVisualStyleBackColor = true;
            // 
            // y_min_effect_edit
            // 
            this.y_min_effect_edit.DecimalPlaces = 2;
            this.y_min_effect_edit.Location = new System.Drawing.Point(333, 32);
            this.y_min_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_min_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y_min_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_min_effect_edit.Name = "y_min_effect_edit";
            this.y_min_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.y_min_effect_edit.TabIndex = 59;
            this.y_min_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // y_min_effect_label
            // 
            this.y_min_effect_label.AutoSize = true;
            this.y_min_effect_label.Location = new System.Drawing.Point(125, 34);
            this.y_min_effect_label.Name = "y_min_effect_label";
            this.y_min_effect_label.Size = new System.Drawing.Size(146, 13);
            this.y_min_effect_label.TabIndex = 58;
            this.y_min_effect_label.Text = "Мин. сила воздействия (Н):";
            // 
            // y_max_effect_edit
            // 
            this.y_max_effect_edit.DecimalPlaces = 2;
            this.y_max_effect_edit.Location = new System.Drawing.Point(333, 6);
            this.y_max_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_max_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y_max_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_max_effect_edit.Name = "y_max_effect_edit";
            this.y_max_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.y_max_effect_edit.TabIndex = 57;
            this.y_max_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // y_max_effect_label
            // 
            this.y_max_effect_label.AutoSize = true;
            this.y_max_effect_label.Location = new System.Drawing.Point(125, 8);
            this.y_max_effect_label.Name = "y_max_effect_label";
            this.y_max_effect_label.Size = new System.Drawing.Size(152, 13);
            this.y_max_effect_label.TabIndex = 56;
            this.y_max_effect_label.Text = "Макс. сила воздействия (Н):";
            // 
            // y_period_error_edit
            // 
            this.y_period_error_edit.DecimalPlaces = 2;
            this.y_period_error_edit.Location = new System.Drawing.Point(333, 59);
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
            this.y_period_error_edit.TabIndex = 55;
            this.y_period_error_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // y_period_error_label
            // 
            this.y_period_error_label.AutoSize = true;
            this.y_period_error_label.Location = new System.Drawing.Point(125, 61);
            this.y_period_error_label.Name = "y_period_error_label";
            this.y_period_error_label.Size = new System.Drawing.Size(202, 13);
            this.y_period_error_label.TabIndex = 54;
            this.y_period_error_label.Text = "Погрешность установления (градусы):";
            // 
            // y_period_label
            // 
            this.y_period_label.AutoSize = true;
            this.y_period_label.Location = new System.Drawing.Point(636, 6);
            this.y_period_label.Name = "y_period_label";
            this.y_period_label.Size = new System.Drawing.Size(13, 13);
            this.y_period_label.TabIndex = 53;
            this.y_period_label.Text = "0";
            // 
            // y_period_label_text
            // 
            this.y_period_label_text.AutoSize = true;
            this.y_period_label_text.Location = new System.Drawing.Point(416, 8);
            this.y_period_label_text.Name = "y_period_label_text";
            this.y_period_label_text.Size = new System.Drawing.Size(136, 13);
            this.y_period_label_text.TabIndex = 52;
            this.y_period_label_text.Text = "Период установления (с):";
            // 
            // y_overshoot_label
            // 
            this.y_overshoot_label.AutoSize = true;
            this.y_overshoot_label.Location = new System.Drawing.Point(636, 61);
            this.y_overshoot_label.Name = "y_overshoot_label";
            this.y_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.y_overshoot_label.TabIndex = 51;
            this.y_overshoot_label.Text = "0";
            // 
            // y_overshoot_label_text
            // 
            this.y_overshoot_label_text.AutoSize = true;
            this.y_overshoot_label_text.Location = new System.Drawing.Point(416, 61);
            this.y_overshoot_label_text.Name = "y_overshoot_label_text";
            this.y_overshoot_label_text.Size = new System.Drawing.Size(163, 13);
            this.y_overshoot_label_text.TabIndex = 50;
            this.y_overshoot_label_text.Text = "Перерегулирование (градусы):";
            // 
            // y_current_label
            // 
            this.y_current_label.AutoSize = true;
            this.y_current_label.Location = new System.Drawing.Point(636, 34);
            this.y_current_label.Name = "y_current_label";
            this.y_current_label.Size = new System.Drawing.Size(13, 13);
            this.y_current_label.TabIndex = 49;
            this.y_current_label.Text = "0";
            // 
            // y_current_label_text
            // 
            this.y_current_label_text.AutoSize = true;
            this.y_current_label_text.Location = new System.Drawing.Point(416, 34);
            this.y_current_label_text.Name = "y_current_label_text";
            this.y_current_label_text.Size = new System.Drawing.Size(214, 13);
            this.y_current_label_text.TabIndex = 48;
            this.y_current_label_text.Text = "Текущее значение угла крена (градусы):";
            // 
            // y_D_edit
            // 
            this.y_D_edit.DecimalPlaces = 2;
            this.y_D_edit.Location = new System.Drawing.Point(38, 59);
            this.y_D_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.y_D_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.y_D_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.y_D_edit.Name = "y_D_edit";
            this.y_D_edit.Size = new System.Drawing.Size(60, 20);
            this.y_D_edit.TabIndex = 47;
            this.y_D_edit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // y_D_label
            // 
            this.y_D_label.AutoSize = true;
            this.y_D_label.Location = new System.Drawing.Point(15, 61);
            this.y_D_label.Name = "y_D_label";
            this.y_D_label.Size = new System.Drawing.Size(19, 13);
            this.y_D_label.TabIndex = 46;
            this.y_D_label.Text = "Д:";
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
            this.y_I_edit.TabIndex = 45;
            // 
            // y_I_label
            // 
            this.y_I_label.AutoSize = true;
            this.y_I_label.Location = new System.Drawing.Point(15, 34);
            this.y_I_label.Name = "y_I_label";
            this.y_I_label.Size = new System.Drawing.Size(18, 13);
            this.y_I_label.TabIndex = 44;
            this.y_I_label.Text = "И:";
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
            this.y_P_edit.TabIndex = 43;
            this.y_P_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // y_P_label
            // 
            this.y_P_label.AutoSize = true;
            this.y_P_label.Location = new System.Drawing.Point(15, 8);
            this.y_P_label.Name = "y_P_label";
            this.y_P_label.Size = new System.Drawing.Size(18, 13);
            this.y_P_label.TabIndex = 42;
            this.y_P_label.Text = "П:";
            // 
            // y_chart
            // 
            chartArea6.Name = "ChartArea1";
            this.y_chart.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend6.Name = "Legend1";
            this.y_chart.Legends.Add(legend6);
            this.y_chart.Location = new System.Drawing.Point(3, 114);
            this.y_chart.Name = "y_chart";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Требуемое значение угла тангажа";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Текущее значение угла тангажа";
            this.y_chart.Series.Add(series11);
            this.y_chart.Series.Add(series12);
            this.y_chart.Size = new System.Drawing.Size(695, 570);
            this.y_chart.TabIndex = 22;
            this.y_chart.Text = "Угол вокруг оси X";
            // 
            // z_tab
            // 
            this.z_tab.BackColor = System.Drawing.SystemColors.Control;
            this.z_tab.Controls.Add(this.z_anfis_check_box);
            this.z_tab.Controls.Add(this.z_ziegler_button);
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
            this.z_tab.Size = new System.Drawing.Size(703, 689);
            this.z_tab.TabIndex = 2;
            this.z_tab.Text = "Угол рысканья (Z)";
            // 
            // z_anfis_check_box
            // 
            this.z_anfis_check_box.AutoSize = true;
            this.z_anfis_check_box.Location = new System.Drawing.Point(419, 89);
            this.z_anfis_check_box.Name = "z_anfis_check_box";
            this.z_anfis_check_box.Size = new System.Drawing.Size(277, 17);
            this.z_anfis_check_box.TabIndex = 81;
            this.z_anfis_check_box.Text = "Использовать Нейро - нечеткий ПИД - регулятор";
            this.z_anfis_check_box.UseVisualStyleBackColor = true;
            this.z_anfis_check_box.CheckedChanged += new System.EventHandler(this.z_anfis_check_box_CheckedChanged);
            // 
            // z_ziegler_button
            // 
            this.z_ziegler_button.Location = new System.Drawing.Point(18, 85);
            this.z_ziegler_button.Name = "z_ziegler_button";
            this.z_ziegler_button.Size = new System.Drawing.Size(395, 23);
            this.z_ziegler_button.TabIndex = 80;
            this.z_ziegler_button.Text = "Рассчитать коэффициенты ПИД-регулятора методом Зиглера-Никольса";
            this.z_ziegler_button.UseVisualStyleBackColor = true;
            // 
            // z_min_effect_edit
            // 
            this.z_min_effect_edit.DecimalPlaces = 2;
            this.z_min_effect_edit.Location = new System.Drawing.Point(333, 32);
            this.z_min_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_min_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_min_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_min_effect_edit.Name = "z_min_effect_edit";
            this.z_min_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.z_min_effect_edit.TabIndex = 79;
            this.z_min_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // z_min_effect_label
            // 
            this.z_min_effect_label.AutoSize = true;
            this.z_min_effect_label.Location = new System.Drawing.Point(125, 34);
            this.z_min_effect_label.Name = "z_min_effect_label";
            this.z_min_effect_label.Size = new System.Drawing.Size(146, 13);
            this.z_min_effect_label.TabIndex = 78;
            this.z_min_effect_label.Text = "Мин. сила воздействия (Н):";
            // 
            // z_max_effect_edit
            // 
            this.z_max_effect_edit.DecimalPlaces = 2;
            this.z_max_effect_edit.Location = new System.Drawing.Point(333, 6);
            this.z_max_effect_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_max_effect_edit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_max_effect_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_max_effect_edit.Name = "z_max_effect_edit";
            this.z_max_effect_edit.Size = new System.Drawing.Size(60, 20);
            this.z_max_effect_edit.TabIndex = 77;
            this.z_max_effect_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // z_max_effect_label
            // 
            this.z_max_effect_label.AutoSize = true;
            this.z_max_effect_label.Location = new System.Drawing.Point(125, 8);
            this.z_max_effect_label.Name = "z_max_effect_label";
            this.z_max_effect_label.Size = new System.Drawing.Size(152, 13);
            this.z_max_effect_label.TabIndex = 76;
            this.z_max_effect_label.Text = "Макс. сила воздействия (Н):";
            // 
            // z_period_error_edit
            // 
            this.z_period_error_edit.DecimalPlaces = 2;
            this.z_period_error_edit.Location = new System.Drawing.Point(333, 59);
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
            this.z_period_error_edit.TabIndex = 75;
            this.z_period_error_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // z_period_error_label
            // 
            this.z_period_error_label.AutoSize = true;
            this.z_period_error_label.Location = new System.Drawing.Point(125, 61);
            this.z_period_error_label.Name = "z_period_error_label";
            this.z_period_error_label.Size = new System.Drawing.Size(202, 13);
            this.z_period_error_label.TabIndex = 74;
            this.z_period_error_label.Text = "Погрешность установления (градусы):";
            // 
            // z_period_label
            // 
            this.z_period_label.AutoSize = true;
            this.z_period_label.Location = new System.Drawing.Point(636, 6);
            this.z_period_label.Name = "z_period_label";
            this.z_period_label.Size = new System.Drawing.Size(13, 13);
            this.z_period_label.TabIndex = 73;
            this.z_period_label.Text = "0";
            // 
            // z_period_label_text
            // 
            this.z_period_label_text.AutoSize = true;
            this.z_period_label_text.Location = new System.Drawing.Point(416, 8);
            this.z_period_label_text.Name = "z_period_label_text";
            this.z_period_label_text.Size = new System.Drawing.Size(136, 13);
            this.z_period_label_text.TabIndex = 72;
            this.z_period_label_text.Text = "Период установления (с):";
            // 
            // z_overshoot_label
            // 
            this.z_overshoot_label.AutoSize = true;
            this.z_overshoot_label.Location = new System.Drawing.Point(636, 61);
            this.z_overshoot_label.Name = "z_overshoot_label";
            this.z_overshoot_label.Size = new System.Drawing.Size(13, 13);
            this.z_overshoot_label.TabIndex = 71;
            this.z_overshoot_label.Text = "0";
            // 
            // z_overshoot_label_text
            // 
            this.z_overshoot_label_text.AutoSize = true;
            this.z_overshoot_label_text.Location = new System.Drawing.Point(416, 61);
            this.z_overshoot_label_text.Name = "z_overshoot_label_text";
            this.z_overshoot_label_text.Size = new System.Drawing.Size(163, 13);
            this.z_overshoot_label_text.TabIndex = 70;
            this.z_overshoot_label_text.Text = "Перерегулирование (градусы):";
            // 
            // z_current_label
            // 
            this.z_current_label.AutoSize = true;
            this.z_current_label.Location = new System.Drawing.Point(636, 34);
            this.z_current_label.Name = "z_current_label";
            this.z_current_label.Size = new System.Drawing.Size(13, 13);
            this.z_current_label.TabIndex = 69;
            this.z_current_label.Text = "0";
            // 
            // z_current_label_text
            // 
            this.z_current_label_text.AutoSize = true;
            this.z_current_label_text.Location = new System.Drawing.Point(416, 34);
            this.z_current_label_text.Name = "z_current_label_text";
            this.z_current_label_text.Size = new System.Drawing.Size(214, 13);
            this.z_current_label_text.TabIndex = 68;
            this.z_current_label_text.Text = "Текущее значение угла крена (градусы):";
            // 
            // z_D_edit
            // 
            this.z_D_edit.DecimalPlaces = 2;
            this.z_D_edit.Location = new System.Drawing.Point(38, 59);
            this.z_D_edit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.z_D_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.z_D_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.z_D_edit.Name = "z_D_edit";
            this.z_D_edit.Size = new System.Drawing.Size(60, 20);
            this.z_D_edit.TabIndex = 67;
            this.z_D_edit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // z_D_label
            // 
            this.z_D_label.AutoSize = true;
            this.z_D_label.Location = new System.Drawing.Point(15, 61);
            this.z_D_label.Name = "z_D_label";
            this.z_D_label.Size = new System.Drawing.Size(19, 13);
            this.z_D_label.TabIndex = 66;
            this.z_D_label.Text = "Д:";
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
            this.z_I_edit.TabIndex = 65;
            // 
            // z_I_label
            // 
            this.z_I_label.AutoSize = true;
            this.z_I_label.Location = new System.Drawing.Point(15, 34);
            this.z_I_label.Name = "z_I_label";
            this.z_I_label.Size = new System.Drawing.Size(18, 13);
            this.z_I_label.TabIndex = 64;
            this.z_I_label.Text = "И:";
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
            this.z_P_edit.TabIndex = 63;
            this.z_P_edit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // z_P_label
            // 
            this.z_P_label.AutoSize = true;
            this.z_P_label.Location = new System.Drawing.Point(15, 8);
            this.z_P_label.Name = "z_P_label";
            this.z_P_label.Size = new System.Drawing.Size(18, 13);
            this.z_P_label.TabIndex = 62;
            this.z_P_label.Text = "П:";
            // 
            // z_chart
            // 
            chartArea4.Name = "ChartArea1";
            this.z_chart.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend4.Name = "Legend1";
            this.z_chart.Legends.Add(legend4);
            this.z_chart.Location = new System.Drawing.Point(3, 114);
            this.z_chart.Name = "z_chart";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Требуемое значение угла рысканья";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Текущее значение угла рысканья";
            this.z_chart.Series.Add(series7);
            this.z_chart.Series.Add(series8);
            this.z_chart.Size = new System.Drawing.Size(695, 570);
            this.z_chart.TabIndex = 22;
            this.z_chart.Text = "Угол вокруг оси X";
            // 
            // dt_label
            // 
            this.dt_label.AutoSize = true;
            this.dt_label.Location = new System.Drawing.Point(163, 404);
            this.dt_label.Name = "dt_label";
            this.dt_label.Size = new System.Drawing.Size(160, 13);
            this.dt_label.TabIndex = 22;
            this.dt_label.Text = "Дискретизация времени (мс):";
            // 
            // dt_box
            // 
            this.dt_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dt_box.FormattingEnabled = true;
            this.dt_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dt_box.Location = new System.Drawing.Point(329, 401);
            this.dt_box.Name = "dt_box";
            this.dt_box.Size = new System.Drawing.Size(60, 21);
            this.dt_box.TabIndex = 23;
            // 
            // quadcopter_label
            // 
            this.quadcopter_label.AutoSize = true;
            this.quadcopter_label.Location = new System.Drawing.Point(12, 12);
            this.quadcopter_label.Name = "quadcopter_label";
            this.quadcopter_label.Size = new System.Drawing.Size(149, 13);
            this.quadcopter_label.TabIndex = 24;
            this.quadcopter_label.Text = "Параметры квадрокоптера:";
            // 
            // mass_frame_edit
            // 
            this.mass_frame_edit.DecimalPlaces = 2;
            this.mass_frame_edit.Location = new System.Drawing.Point(329, 40);
            this.mass_frame_edit.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mass_frame_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.mass_frame_edit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.mass_frame_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.mass_frame_edit.Name = "mass_frame_edit";
            this.mass_frame_edit.Size = new System.Drawing.Size(60, 20);
            this.mass_frame_edit.TabIndex = 26;
            this.mass_frame_edit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // mass_frame_label
            // 
            this.mass_frame_label.AutoSize = true;
            this.mass_frame_label.Location = new System.Drawing.Point(16, 42);
            this.mass_frame_label.Name = "mass_frame_label";
            this.mass_frame_label.Size = new System.Drawing.Size(193, 13);
            this.mass_frame_label.TabIndex = 25;
            this.mass_frame_label.Text = "Масса центральной платформы (кг):";
            // 
            // radius_edit
            // 
            this.radius_edit.DecimalPlaces = 2;
            this.radius_edit.Location = new System.Drawing.Point(329, 117);
            this.radius_edit.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.radius_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.radius_edit.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.radius_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.radius_edit.Name = "radius_edit";
            this.radius_edit.Size = new System.Drawing.Size(60, 20);
            this.radius_edit.TabIndex = 28;
            this.radius_edit.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // radius_label
            // 
            this.radius_label.AutoSize = true;
            this.radius_label.Location = new System.Drawing.Point(15, 119);
            this.radius_label.Name = "radius_label";
            this.radius_label.Size = new System.Drawing.Size(246, 13);
            this.radius_label.TabIndex = 27;
            this.radius_label.Text = "Окружной радиус центральной платформы (м):";
            // 
            // mass_engine_edit
            // 
            this.mass_engine_edit.DecimalPlaces = 2;
            this.mass_engine_edit.Location = new System.Drawing.Point(329, 66);
            this.mass_engine_edit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mass_engine_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.mass_engine_edit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mass_engine_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.mass_engine_edit.Name = "mass_engine_edit";
            this.mass_engine_edit.Size = new System.Drawing.Size(60, 20);
            this.mass_engine_edit.TabIndex = 30;
            this.mass_engine_edit.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // mass_engine_label
            // 
            this.mass_engine_label.AutoSize = true;
            this.mass_engine_label.Location = new System.Drawing.Point(16, 68);
            this.mass_engine_label.Name = "mass_engine_label";
            this.mass_engine_label.Size = new System.Drawing.Size(118, 13);
            this.mass_engine_label.TabIndex = 29;
            this.mass_engine_label.Text = "Масса двигателя (кг):";
            // 
            // arm_length_edit
            // 
            this.arm_length_edit.DecimalPlaces = 2;
            this.arm_length_edit.Location = new System.Drawing.Point(329, 91);
            this.arm_length_edit.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arm_length_edit.MaximumSize = new System.Drawing.Size(60, 0);
            this.arm_length_edit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.arm_length_edit.MinimumSize = new System.Drawing.Size(60, 0);
            this.arm_length_edit.Name = "arm_length_edit";
            this.arm_length_edit.Size = new System.Drawing.Size(60, 20);
            this.arm_length_edit.TabIndex = 32;
            this.arm_length_edit.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // arm_length_label
            // 
            this.arm_length_label.AutoSize = true;
            this.arm_length_label.Location = new System.Drawing.Point(16, 93);
            this.arm_length_label.Name = "arm_length_label";
            this.arm_length_label.Size = new System.Drawing.Size(307, 13);
            this.arm_length_label.TabIndex = 31;
            this.arm_length_label.Text = "Расстояние от двигателей до центральной платформы (м):";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 729);
            this.Controls.Add(this.arm_length_edit);
            this.Controls.Add(this.arm_length_label);
            this.Controls.Add(this.mass_engine_edit);
            this.Controls.Add(this.mass_engine_label);
            this.Controls.Add(this.radius_edit);
            this.Controls.Add(this.radius_label);
            this.Controls.Add(this.mass_frame_edit);
            this.Controls.Add(this.mass_frame_label);
            this.Controls.Add(this.quadcopter_label);
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
            ((System.ComponentModel.ISupportInitialize)(this.y_min_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_max_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_period_error_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_D_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_I_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_P_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_chart)).EndInit();
            this.z_tab.ResumeLayout(false);
            this.z_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z_min_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_max_effect_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_period_error_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_D_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_I_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_P_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_frame_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_engine_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arm_length_edit)).EndInit();
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
        private System.Windows.Forms.NumericUpDown x_min_effect_edit;
        private System.Windows.Forms.Label x_min_effect_label;
        private System.Windows.Forms.NumericUpDown x_max_effect_edit;
        private System.Windows.Forms.Label x_max_effect_label;
        private System.Windows.Forms.Label dt_label;
        private System.Windows.Forms.ComboBox dt_box;
        private System.Windows.Forms.Button x_ziegler_button;
        private System.Windows.Forms.CheckBox x_anfis_check_box;
        private System.Windows.Forms.Label quadcopter_label;
        private System.Windows.Forms.NumericUpDown mass_frame_edit;
        private System.Windows.Forms.Label mass_frame_label;
        private System.Windows.Forms.NumericUpDown radius_edit;
        private System.Windows.Forms.Label radius_label;
        private System.Windows.Forms.NumericUpDown mass_engine_edit;
        private System.Windows.Forms.Label mass_engine_label;
        private System.Windows.Forms.NumericUpDown arm_length_edit;
        private System.Windows.Forms.Label arm_length_label;
        private System.Windows.Forms.CheckBox y_anfis_check_box;
        private System.Windows.Forms.Button y_ziegler_button;
        private System.Windows.Forms.NumericUpDown y_min_effect_edit;
        private System.Windows.Forms.Label y_min_effect_label;
        private System.Windows.Forms.NumericUpDown y_max_effect_edit;
        private System.Windows.Forms.Label y_max_effect_label;
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
        private System.Windows.Forms.CheckBox z_anfis_check_box;
        private System.Windows.Forms.Button z_ziegler_button;
        private System.Windows.Forms.NumericUpDown z_min_effect_edit;
        private System.Windows.Forms.Label z_min_effect_label;
        private System.Windows.Forms.NumericUpDown z_max_effect_edit;
        private System.Windows.Forms.Label z_max_effect_label;
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
    }
}

