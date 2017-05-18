using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace quadcopter_research
{
    public partial class main_form : Form
    {
        private quadcopter_model qm;
        private Stopwatch main_stopwatch;
        private vector3 reference;
        private PID phi_PID;
        private PID theta_PID;
        private PID psi_PID;
        private vector3 angles;
        private double elapsed_time;

        private double phi_effect;
        private double theta_effect;
        private double psi_effect;


        private double x_overshoot;
        private double x_period;
        private double x_period_error;
        private double y_overshoot;
        private double y_period;
        private double y_period_error;
        private double z_overshoot;
        private double z_period;
        private double z_period_error;
        private double x_overshoot_error_sign;
        private double x_overshoot_prev_error;
        private bool x_overshoot_flag;

        public main_form()
        {
            InitializeComponent();

            main_stopwatch = new Stopwatch();
            qm = new quadcopter_model();

            phi_PID = new PID(main_timer.Interval / 1000.0, (double)x_max_effect_edit.Value, (double)x_min_effect_edit.Value);
            theta_PID = new PID(main_timer.Interval / 1000.0, (double)y_max_effect_edit.Value, (double)y_min_effect_edit.Value);
            psi_PID = new PID(main_timer.Interval / 1000.0, (double)z_max_effect_edit.Value, (double)z_min_effect_edit.Value);

            WindowState = FormWindowState.Maximized;
            dt_box.SelectedIndex = 0;
            x_chart.ChartAreas[0].AxisY.Minimum = -180;
            x_chart.ChartAreas[0].AxisY.Maximum = 180;
            x_chart.ChartAreas[0].AxisY.Interval = 10;
            x_chart.ChartAreas[0].AxisX.Minimum = 0;
            x_chart.ChartAreas[0].AxisX.Maximum = 10;
            x_chart.ChartAreas[0].AxisX.Interval = 1;
            x_chart.ChartAreas[0].AxisX.LabelStyle.Format = "#.";
            y_chart.ChartAreas[0].AxisY.Minimum = -180;
            y_chart.ChartAreas[0].AxisY.Maximum = 180;
            y_chart.ChartAreas[0].AxisY.Interval = 10;
            y_chart.ChartAreas[0].AxisX.Minimum = 0;
            y_chart.ChartAreas[0].AxisX.Maximum = 10;
            y_chart.ChartAreas[0].AxisX.Interval = 1;
            y_chart.ChartAreas[0].AxisX.LabelStyle.Format = "#.";
            z_chart.ChartAreas[0].AxisY.Minimum = -180;
            z_chart.ChartAreas[0].AxisY.Maximum = 180;
            z_chart.ChartAreas[0].AxisY.Interval = 10;
            z_chart.ChartAreas[0].AxisX.Minimum = 0;
            z_chart.ChartAreas[0].AxisX.Maximum = 10;
            z_chart.ChartAreas[0].AxisX.Interval = 1;
            z_chart.ChartAreas[0].AxisX.LabelStyle.Format = "#.";
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            main_timer.Interval = int.Parse(dt_box.SelectedItem.ToString());
            main_stopwatch.Start();
            main_timer.Start();
            reference = new vector3((double)x_reference_edit.Value, (double)y_reference_edit.Value, (double)z_reference_edit.Value);
            qm.init(dt_in: main_timer.Interval / 1000.0);
            qm.set_angles((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);
            phi_PID.set_PID(main_timer.Interval / 1000.0, (double)x_max_effect_edit.Value, (double)x_min_effect_edit.Value, (double)x_P_edit.Value, (double)x_I_edit.Value, (double)x_D_edit.Value);
            theta_PID.set_PID(main_timer.Interval / 1000.0, (double)y_max_effect_edit.Value, (double)y_min_effect_edit.Value, (double)y_P_edit.Value, (double)y_I_edit.Value, (double)y_D_edit.Value);
            psi_PID.set_PID(main_timer.Interval / 1000.0, (double)z_max_effect_edit.Value, (double)z_min_effect_edit.Value, (double)z_P_edit.Value, (double)z_I_edit.Value, (double)z_D_edit.Value);
            x_period_error = (double)x_period_error_edit.Value;
            x_period = 0.0;
            x_overshoot = 0.0;
            y_period_error = (double)y_period_error_edit.Value;
            y_period = 0.0;
            y_overshoot = 0.0;
            z_period_error = (double)z_period_error_edit.Value;
            z_period = 0.0;
            z_overshoot = 0.0;

            phi_effect = phi_PID.get_effect((double)x_initial_edit.Value, reference.x);
            theta_effect = theta_PID.get_effect((double)y_initial_edit.Value, reference.y);
            psi_effect = psi_PID.get_effect((double)z_initial_edit.Value, reference.z);

            x_overshoot_error_sign = Math.Sign(reference.x - (double)x_initial_edit.Value);
            x_overshoot_flag = false;

            dt_box.Enabled = false;
            start_button.Enabled = false;
            pause_button.Enabled = true;
            stop_button.Enabled = true;
            x_reference_edit.Enabled = false;
            y_reference_edit.Enabled = false;
            z_reference_edit.Enabled = false;
            x_initial_edit.Enabled = false;
            y_initial_edit.Enabled = false;
            z_initial_edit.Enabled = false;
            x_P_edit.Enabled = false;
            x_I_edit.Enabled = false;
            x_D_edit.Enabled = false;
            x_max_effect_edit.Enabled = false;
            x_min_effect_edit.Enabled = false;
            x_period_error_edit.Enabled = false;
            y_P_edit.Enabled = false;
            y_I_edit.Enabled = false;
            y_D_edit.Enabled = false;
            y_max_effect_edit.Enabled = false;
            y_min_effect_edit.Enabled = false;
            y_period_error_edit.Enabled = false;
            z_P_edit.Enabled = false;
            z_I_edit.Enabled = false;
            z_D_edit.Enabled = false;
            z_max_effect_edit.Enabled = false;
            z_min_effect_edit.Enabled = false;
            z_period_error_edit.Enabled = false;
            x_ziegler_button.Enabled = false;
            x_anfis_check_box.Enabled = false;

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            main_stopwatch.Reset();
            main_timer.Stop();
            main_time_label.Text = main_stopwatch.ElapsedMilliseconds.ToString();
            x_overshoot_label.Text = "0";
            x_period_label.Text = "0";
            x_current_label.Text = "0";
            qm.reset();
            start_button.Enabled = true;
            pause_button.Enabled = false;
            continue_button.Enabled = false;
            stop_button.Enabled = false;

            x_reference_edit.Enabled = true;
            y_reference_edit.Enabled = true;
            z_reference_edit.Enabled = true;
            x_initial_edit.Enabled = true;
            y_initial_edit.Enabled = true;
            z_initial_edit.Enabled = true;
            x_max_effect_edit.Enabled = true;
            x_min_effect_edit.Enabled = true;
            x_period_error_edit.Enabled = true;
            y_P_edit.Enabled = true;
            y_I_edit.Enabled = true;
            y_D_edit.Enabled = true;
            y_max_effect_edit.Enabled = true;
            y_min_effect_edit.Enabled = true;
            y_period_error_edit.Enabled = true;
            z_P_edit.Enabled = true;
            z_I_edit.Enabled = true;
            z_D_edit.Enabled = true;
            z_max_effect_edit.Enabled = true;
            z_min_effect_edit.Enabled = true;
            z_period_error_edit.Enabled = true;
            if (x_anfis_check_box.Checked == false)
            {
                x_P_edit.Enabled = true;
                x_I_edit.Enabled = true;
                x_D_edit.Enabled = true;
                x_ziegler_button.Enabled = true;
            }
            x_anfis_check_box.Enabled = true;
            dt_box.Enabled = true;

            x_chart.Series[0].Points.Clear();
            x_chart.Series[1].Points.Clear();
            x_chart.ChartAreas[0].AxisX.Minimum = 0;
            x_chart.ChartAreas[0].AxisX.Maximum = 10;
            y_chart.Series[0].Points.Clear();
            y_chart.Series[1].Points.Clear();
            y_chart.ChartAreas[0].AxisX.Minimum = 0;
            y_chart.ChartAreas[0].AxisX.Maximum = 10;
            z_chart.Series[0].Points.Clear();
            z_chart.Series[1].Points.Clear();
            z_chart.ChartAreas[0].AxisX.Minimum = 0;
            z_chart.ChartAreas[0].AxisX.Maximum = 10;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            main_stopwatch.Stop();
            main_timer.Stop();
            pause_button.Enabled = false;
            continue_button.Enabled = true;
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            main_stopwatch.Start();
            main_timer.Start();
            pause_button.Enabled = true;
            continue_button.Enabled = false;
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            angles = qm.get_angles();
            elapsed_time = main_stopwatch.Elapsed.TotalSeconds;
            main_time_label.Text = elapsed_time.ToString("0.00");
            x_current_label.Text = angles.x.ToString("0.00");
            y_current_label.Text = angles.y.ToString("0.00");
            z_current_label.Text = angles.z.ToString("0.00");
            if (Math.Abs(reference.x - angles.x) > x_period_error)
            {
                x_period = elapsed_time;
                x_period_label.Text = elapsed_time.ToString("0.00");
            }
            if (Math.Abs(reference.y - angles.y) > y_period_error)
            {
                y_period = elapsed_time;
                y_period_label.Text = elapsed_time.ToString("0.00");
            }
            if (Math.Abs(reference.z - angles.z) > z_period_error)
            {
                z_period = elapsed_time;
                z_period_label.Text = elapsed_time.ToString("0.00");
            }
            if (Math.Sign(reference.x - angles.x) != x_overshoot_error_sign && x_overshoot_flag == false)
            {
                
                x_overshoot = Math.Max(x_overshoot, Math.Abs(reference.x - angles.x));
                x_overshoot_label.Text = x_overshoot.ToString("0.00");

            }
            if (x_overshoot > 0 && Math.Sign(reference.x - angles.x) == x_overshoot_error_sign)
            {
                x_overshoot_flag = true;
            }
            x_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            x_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), angles.x);
            y_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.y);
            y_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), angles.y);
            z_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.z);
            z_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), angles.z);
            if (elapsed_time > 10)
            {
                x_chart.Series[0].Points.RemoveAt(0);
                x_chart.Series[1].Points.RemoveAt(0);
                x_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;
                x_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                y_chart.Series[0].Points.RemoveAt(0);
                y_chart.Series[1].Points.RemoveAt(0);
                y_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;
                y_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                z_chart.Series[0].Points.RemoveAt(0);
                z_chart.Series[1].Points.RemoveAt(0);
                z_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;
                z_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
            }
            qm.update(phi_effect, theta_effect, psi_effect);
            phi_effect = phi_PID.get_effect(angles.x, reference.x);
            theta_effect = theta_PID.get_effect(angles.y, reference.y);
            psi_effect = psi_PID.get_effect(angles.z, reference.z);
        }

        private void ziegler_button_Click(object sender, EventArgs e)
        {
            
        }

        private void anfis_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if (x_anfis_check_box.Checked)
            {
                x_P_edit.Enabled = false;
                x_I_edit.Enabled = false;
                x_D_edit.Enabled = false;
                x_ziegler_button.Enabled = false;
            }
            else
            {
                x_P_edit.Enabled = true;
                x_I_edit.Enabled = true;
                x_D_edit.Enabled = true;
                x_ziegler_button.Enabled = true;
            }
        }
    }
}
