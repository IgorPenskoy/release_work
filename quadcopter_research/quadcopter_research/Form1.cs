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
using System.IO;
using System.Threading;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace quadcopter_research
{
    public partial class main_form : Form
    {
        private static object _sbSync = new Object();

        private const double max_angle_degree = 45.0;
        private const double chart_time_amount = 10.0;
        private const double timer_interval_divide = 1000.0;
        private const double axis_x_interval = 1.0;
        private const double axis_y_interval = 5.0;
        private const string chart_label_style_format = "#.";
        private const string label_style_format = "0.00";
        private const int dt_const = 50;

        private quadcopter_model qm;
        private quadcopter_model qm_fis;

        private Stopwatch main_stopwatch;

        private vector3 reference;
        private vector3 angles;
        private vector3 angles_fis;

        private PID phi_PID;
        private PID theta_PID;
        private PID psi_PID;

        private ANFISPID phi_PID_fis;
        private ANFISPID theta_PID_fis;
        private ANFISPID psi_PID_fis;

        private ZieglerNichols zn;

        private double elapsed_time;
        private double dt;

        private double phi_effect;
        private double theta_effect;
        private double psi_effect;

        private double phi_effect_fis;
        private double theta_effect_fis;
        private double psi_effect_fis;

        private double x_overshoot;
        private double x_period;
        private double x_period_error;
        private double x_overshoot_error_sign;
        private bool x_overshoot_flag;

        private double[] x_overshoot_array;
        private double[] x_period_array;
        private double[] x_current_array;

        private double y_overshoot;
        private double y_period;
        private double y_period_error;
        private double y_overshoot_error_sign;
        private bool y_overshoot_flag;

        private double[] y_overshoot_array;
        private double[] y_period_array;
        private double[] y_current_array;

        private double z_overshoot;
        private double z_period;
        private double z_period_error;
        private double z_overshoot_error_sign;
        private bool z_overshoot_flag;

        private double[] z_overshoot_array;
        private double[] z_period_array;
        private double[] z_current_array;

        private double x_overshoot_fis;
        private double x_period_fis;
        private double x_overshoot_error_sign_fis;
        private bool x_overshoot_flag_fis;

        private double[] x_overshoot_array_fis;
        private double[] x_period_array_fis;
        private double[] x_current_array_fis;

        private double y_overshoot_fis;
        private double y_period_fis;
        private double y_overshoot_error_sign_fis;
        private bool y_overshoot_flag_fis;

        private double[] y_overshoot_array_fis;
        private double[] y_period_array_fis;
        private double[] y_current_array_fis;

        private double z_overshoot_fis;
        private double z_period_fis;
        private double z_overshoot_error_sign_fis;
        private bool z_overshoot_flag_fis;

        private double[] z_overshoot_array_fis;
        private double[] z_period_array_fis;
        private double[] z_current_array_fis;

        int i_sim;
        int n_sim;

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);

        [DllImport("user32.dll")]
        private extern static bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll")]
        static extern bool BringWindowToTop(IntPtr hWnd);

        public main_form()
        {
            InitializeComponent();

            main_stopwatch = new Stopwatch();
            qm = new quadcopter_model();
            qm_fis = new quadcopter_model();

            phi_PID = new PID();
            theta_PID = new PID();
            psi_PID = new PID();

            phi_PID_fis = new ANFISPID();
            theta_PID_fis = new ANFISPID();
            psi_PID_fis = new ANFISPID();

            zn = new ZieglerNichols();

            x_reference_edit.Minimum = (decimal)-max_angle_degree;
            x_reference_edit.Maximum = (decimal)max_angle_degree;
            y_reference_edit.Minimum = (decimal)-max_angle_degree;
            y_reference_edit.Maximum = (decimal)max_angle_degree;
            z_reference_edit.Minimum = (decimal)-max_angle_degree;
            z_reference_edit.Maximum = (decimal)max_angle_degree;

            x_initial_edit.Minimum = (decimal)-max_angle_degree;
            x_initial_edit.Maximum = (decimal)max_angle_degree;
            y_initial_edit.Minimum = (decimal)-max_angle_degree;
            y_initial_edit.Maximum = (decimal)max_angle_degree;
            z_initial_edit.Minimum = (decimal)-max_angle_degree;
            z_initial_edit.Maximum = (decimal)max_angle_degree;

            x_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            x_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            x_chart.ChartAreas[0].AxisY.Interval = axis_y_interval;
            x_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            x_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
            y_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            y_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            y_chart.ChartAreas[0].AxisY.Interval = axis_y_interval;
            y_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            y_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
            z_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            z_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            z_chart.ChartAreas[0].AxisY.Interval = axis_y_interval;
            z_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            z_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
            stop_procedure();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            main_timer.Interval = dt_const;

            i_sim = 0;

            random_effect_check.Enabled = false;

            end_time_edit.Enabled = false;

            start_button.Enabled = false;
            pause_button.Enabled = true;
            stop_button.Enabled = true;

            x_reference_edit.Enabled = false;
            x_initial_edit.Enabled = false;
            x_P_edit.Enabled = false;
            x_I_edit.Enabled = false;
            x_D_edit.Enabled = false;
            x_max_effect_edit.Enabled = false;
            x_max_integral_edit.Enabled = false;
            x_period_error_edit.Enabled = false;
            x_ziegler_button.Enabled = false;

            y_reference_edit.Enabled = false;
            y_initial_edit.Enabled = false;
            y_P_edit.Enabled = false;
            y_I_edit.Enabled = false;
            y_D_edit.Enabled = false;
            y_max_effect_edit.Enabled = false;
            y_max_integral_edit.Enabled = false;
            y_period_error_edit.Enabled = false;
            y_ziegler_button.Enabled = false;

            z_reference_edit.Enabled = false;
            z_initial_edit.Enabled = false;
            z_P_edit.Enabled = false;
            z_I_edit.Enabled = false;
            z_D_edit.Enabled = false;
            z_max_effect_edit.Enabled = false;
            z_max_integral_edit.Enabled = false;
            z_period_error_edit.Enabled = false;
            z_ziegler_button.Enabled = false;

            simulation();

            main_stopwatch.Start();
            main_timer.Start();
        }

        private void stop_procedure()
        {
            main_stopwatch.Reset();
            main_timer.Stop();
            main_time_label.Text = label_style_format;

            random_effect_check.Enabled = true;

            end_time_edit.Enabled = true;

            start_button.Enabled = true;
            pause_button.Enabled = false;
            continue_button.Enabled = false;
            stop_button.Enabled = false;

            x_overshoot_label.Text = label_style_format;
            x_period_label.Text = label_style_format;
            x_current_label.Text = label_style_format;
            x_overshoot_fis_label.Text = label_style_format;
            x_period_fis_label.Text = label_style_format;
            x_current_fis_label.Text = label_style_format;
            x_reference_edit.Enabled = true;
            x_initial_edit.Enabled = true;
            x_max_effect_edit.Enabled = true;
            x_max_integral_edit.Enabled = true;
            x_period_error_edit.Enabled = true;
            x_P_edit.Enabled = true;
            x_I_edit.Enabled = true;
            x_D_edit.Enabled = true;
            x_ziegler_button.Enabled = true;
            x_chart.Series[0].Points.Clear();
            x_chart.Series[1].Points.Clear();
            x_chart.Series[2].Points.Clear();
            x_chart.ChartAreas[0].AxisX.Minimum = 0;
            x_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;

            y_overshoot_label.Text = label_style_format;
            y_period_label.Text = label_style_format;
            y_current_label.Text = label_style_format;
            y_overshoot_fis_label.Text = label_style_format;
            y_period_fis_label.Text = label_style_format;
            y_current_fis_label.Text = label_style_format;
            y_reference_edit.Enabled = true;
            y_initial_edit.Enabled = true;
            y_max_effect_edit.Enabled = true;
            y_max_integral_edit.Enabled = true;
            y_period_error_edit.Enabled = true;
            y_P_edit.Enabled = true;
            y_I_edit.Enabled = true;
            y_D_edit.Enabled = true;
            y_ziegler_button.Enabled = true;
            y_chart.Series[0].Points.Clear();
            y_chart.Series[1].Points.Clear();
            y_chart.Series[2].Points.Clear();
            y_chart.ChartAreas[0].AxisX.Minimum = 0;
            y_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;

            z_overshoot_label.Text = label_style_format;
            z_period_label.Text = label_style_format;
            z_current_label.Text = label_style_format;
            z_overshoot_fis_label.Text = label_style_format;
            z_period_fis_label.Text = label_style_format;
            z_current_fis_label.Text = label_style_format;
            z_reference_edit.Enabled = true;
            z_initial_edit.Enabled = true;
            z_max_effect_edit.Enabled = true;
            z_max_integral_edit.Enabled = true;
            z_period_error_edit.Enabled = true;
            z_P_edit.Enabled = true;
            z_I_edit.Enabled = true;
            z_D_edit.Enabled = true;
            z_ziegler_button.Enabled = true;
            z_chart.Series[0].Points.Clear();
            z_chart.Series[1].Points.Clear();
            z_chart.Series[2].Points.Clear();
            z_chart.ChartAreas[0].AxisX.Minimum = 0;
            z_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;

            var sw = new StreamWriter("copter.txt");
            sw.Close();
            sw = new StreamWriter("copter_fis.txt");
            sw.Close();

            var outStream_copter = new FileStream("copter.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            var sw_copter = new StreamWriter(outStream_copter);

            sw_copter.WriteLine(x_initial_edit.Value.ToString());
            sw_copter.WriteLine(y_initial_edit.Value.ToString());
            sw_copter.WriteLine(z_initial_edit.Value.ToString());
            sw_copter.Close();


            var outStream_copter_fis = new FileStream("copter_fis.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            var sw_copter_fis = new StreamWriter(outStream_copter_fis);

            sw_copter_fis.WriteLine(x_initial_edit.Value.ToString());
            sw_copter_fis.WriteLine(y_initial_edit.Value.ToString());
            sw_copter_fis.WriteLine(z_initial_edit.Value.ToString());
            sw_copter_fis.Close();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            stop_procedure();
        }

        private void pause_procedure()
        {
            main_stopwatch.Stop();
            main_timer.Stop();
            pause_button.Enabled = false;
            continue_button.Enabled = true;
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            pause_procedure();
        }

        private void continue_button_Click(object sender, EventArgs e)
        {
            pause_button.Enabled = true;
            continue_button.Enabled = false;
            main_stopwatch.Start();
            main_timer.Start();
        }

        private void simulation()
        {
            dt = main_timer.Interval / timer_interval_divide;
            n_sim = (int)Math.Floor((double)end_time_edit.Value / dt);

            x_current_array = new double[n_sim];
            x_period_array = new double[n_sim];
            x_overshoot_array = new double[n_sim];

            y_current_array = new double[n_sim];
            y_period_array = new double[n_sim];
            y_overshoot_array = new double[n_sim];

            z_current_array = new double[n_sim];
            z_period_array = new double[n_sim];
            z_overshoot_array = new double[n_sim];

            x_current_array_fis = new double[n_sim];
            x_period_array_fis = new double[n_sim];
            x_overshoot_array_fis = new double[n_sim];

            y_current_array_fis = new double[n_sim];
            y_period_array_fis = new double[n_sim];
            y_overshoot_array_fis = new double[n_sim];

            z_current_array_fis = new double[n_sim];
            z_period_array_fis = new double[n_sim];
            z_overshoot_array_fis = new double[n_sim];

            elapsed_time = 0.0;

            reference = new vector3((double)x_reference_edit.Value, (double)y_reference_edit.Value, (double)z_reference_edit.Value);
            angles = new vector3((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);
            angles_fis = new vector3((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);
            if (random_effect_check.Checked)
            {
                qm.init(0.5, 0.1, 0.25, 0.2, dt, (double)random_effect_edit.Value);
                qm_fis.init(0.5, 0.1, 0.25, 0.2, dt, (double)random_effect_edit.Value);
            }
            else
            {
                qm.init(0.5, 0.1, 0.25, 0.2, dt, 0.0);
                qm_fis.init(0.5, 0.1, 0.25, 0.2, dt, 0.0);
            }
            qm.set_angles((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);
            qm_fis.set_angles((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);

            phi_PID.init(dt, (double)x_max_effect_edit.Value, (double)x_max_integral_edit.Value, (double)x_P_edit.Value, (double)x_I_edit.Value, (double)x_D_edit.Value);
            theta_PID.init(dt, (double)y_max_effect_edit.Value, (double)y_max_integral_edit.Value, (double)y_P_edit.Value, (double)y_I_edit.Value, (double)y_D_edit.Value);
            psi_PID.init(dt, (double)z_max_effect_edit.Value, (double)z_max_integral_edit.Value, (double)z_P_edit.Value, (double)z_I_edit.Value, (double)z_D_edit.Value);

            ANFIS P_fis = new ANFIS(new Random(), "P.txt");
            ANFIS I_fis = new ANFIS(new Random(), "I.txt");
            ANFIS D_fis = new ANFIS(new Random(), "D.txt");

            phi_PID_fis.init(P_fis, I_fis, D_fis, dt, (double)x_max_effect_edit.Value, (double)x_max_integral_edit.Value);
            theta_PID_fis.init(P_fis, I_fis, D_fis, dt, (double)y_max_effect_edit.Value, (double)y_max_integral_edit.Value);
            psi_PID_fis.init(P_fis, I_fis, D_fis, dt, (double)z_max_effect_edit.Value, (double)z_max_integral_edit.Value);

            x_period_error = (double)x_period_error_edit.Value;
            x_period = 0.0;
            x_overshoot = 0.0;
            x_overshoot_error_sign = Math.Sign(reference.x - (double)x_initial_edit.Value);
            x_overshoot_flag = false;

            x_period_fis = 0.0;
            x_overshoot_fis = 0.0;
            x_overshoot_error_sign_fis = Math.Sign(reference.x - (double)x_initial_edit.Value);
            x_overshoot_flag_fis = false;

            y_period_error = (double)y_period_error_edit.Value;
            y_period = 0.0;
            y_overshoot = 0.0;
            y_overshoot_error_sign = Math.Sign(reference.y - (double)y_initial_edit.Value);
            y_overshoot_flag = false;

            y_period_fis = 0.0;
            y_overshoot_fis = 0.0;
            y_overshoot_error_sign_fis = Math.Sign(reference.y - (double)y_initial_edit.Value);
            y_overshoot_flag_fis = false;

            z_period_error = (double)z_period_error_edit.Value;
            z_period = 0.0;
            z_overshoot = 0.0;
            z_overshoot_error_sign = Math.Sign(reference.z - (double)z_initial_edit.Value);
            z_overshoot_flag = false;

            z_period_fis = 0.0;
            z_overshoot_fis = 0.0;
            z_overshoot_error_sign_fis = Math.Sign(reference.z - (double)z_initial_edit.Value);
            z_overshoot_flag_fis = false;

            for (int i = 0; i < n_sim; i++)
            {
                phi_effect = phi_PID.get_effect(angles.x, reference.x);
                theta_effect = theta_PID.get_effect(angles.y, reference.y);
                psi_effect = psi_PID.get_effect(angles.z, reference.z);

                phi_effect_fis = phi_PID_fis.get_effect_fis(angles_fis.x, reference.x);
                theta_effect_fis = theta_PID_fis.get_effect_fis(angles_fis.y, reference.y);
                psi_effect_fis = psi_PID_fis.get_effect_fis(angles_fis.z, reference.z);

                qm.update(phi_effect, theta_effect, psi_effect);
                qm_fis.update(phi_effect_fis, theta_effect_fis, psi_effect_fis);

                angles = qm.get_angles();
                angles_fis = qm_fis.get_angles();

                if (Math.Abs(reference.x - angles.x) > x_period_error)
                    x_period = elapsed_time;
                if (Math.Sign(reference.x - angles.x) != x_overshoot_error_sign && x_overshoot_flag == false)
                    x_overshoot = Math.Max(x_overshoot, Math.Abs(reference.x - angles.x));
                if (x_overshoot > 0 && Math.Sign(reference.x - angles.x) == x_overshoot_error_sign)
                    x_overshoot_flag = true;

                if (Math.Abs(reference.y - angles.y) > y_period_error)
                    y_period = elapsed_time;
                if (Math.Sign(reference.y - angles.y) != y_overshoot_error_sign && y_overshoot_flag == false)
                    y_overshoot = Math.Max(y_overshoot, Math.Abs(reference.y - angles.y));
                if (y_overshoot > 0 && Math.Sign(reference.y - angles.y) == y_overshoot_error_sign)
                    y_overshoot_flag = true;

                if (Math.Abs(reference.z - angles.z) > z_period_error)
                    z_period = elapsed_time;
                if (Math.Sign(reference.z - angles.z) != z_overshoot_error_sign && z_overshoot_flag == false)
                    z_overshoot = Math.Max(z_overshoot, Math.Abs(reference.z - angles.z));
                if (z_overshoot > 0 && Math.Sign(reference.z - angles.z) == z_overshoot_error_sign)
                    z_overshoot_flag = true;
                
                //////////////// FIS

                if (Math.Abs(reference.x - angles_fis.x) > x_period_error)
                    x_period_fis = elapsed_time;
                if (Math.Sign(reference.x - angles_fis.x) != x_overshoot_error_sign_fis && x_overshoot_flag_fis == false)
                    x_overshoot_fis = Math.Max(x_overshoot_fis , Math.Abs(reference.x - angles_fis.x));
                if (x_overshoot_fis > 0 && Math.Sign(reference.x - angles_fis.x) == x_overshoot_error_sign_fis)
                    x_overshoot_flag_fis = true;

                if (Math.Abs(reference.y - angles_fis.y) > y_period_error)
                    y_period_fis = elapsed_time;
                if (Math.Sign(reference.y - angles_fis.y) != y_overshoot_error_sign_fis && y_overshoot_flag_fis == false)
                    y_overshoot_fis = Math.Max(y_overshoot_fis , Math.Abs(reference.y - angles_fis.y));
                if (y_overshoot_fis > 0 && Math.Sign(reference.y - angles_fis.y) == y_overshoot_error_sign_fis)
                    y_overshoot_flag_fis = true;

                if (Math.Abs(reference.z - angles_fis.z) > z_period_error)
                    z_period_fis = elapsed_time;
                if (Math.Sign(reference.z - angles_fis.z) != z_overshoot_error_sign_fis && z_overshoot_flag_fis == false)
                    z_overshoot_fis = Math.Max(z_overshoot_fis , Math.Abs(reference.z - angles_fis.z));
                if (z_overshoot_fis > 0 && Math.Sign(reference.z - angles_fis.z) == z_overshoot_error_sign_fis)
                    z_overshoot_flag_fis = true;

                elapsed_time += dt;

                x_current_array[i] = angles.x;
                x_period_array[i] = x_period;
                x_overshoot_array[i] = x_overshoot;

                y_current_array[i] = angles.y;
                y_period_array[i] = y_period;
                y_overshoot_array[i] = y_overshoot;

                z_current_array[i] = angles.z;
                z_period_array[i] = z_period;
                z_overshoot_array[i] = z_overshoot;

                x_current_array_fis[i] = angles_fis.x;
                x_period_array_fis[i] = x_period_fis;
                x_overshoot_array_fis[i] = x_overshoot_fis;

                y_current_array_fis[i] = angles_fis.y;
                y_period_array_fis[i] = y_period_fis;
                y_overshoot_array_fis[i] = y_overshoot_fis;

                z_current_array_fis[i] = angles_fis.z;
                z_period_array_fis[i] = z_period_fis;
                z_overshoot_array_fis[i] = z_overshoot_fis;
            }

            elapsed_time = 0.0;
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            elapsed_time += dt;
            main_time_label.Text = elapsed_time.ToString(label_style_format);

            x_period_label.Text = x_period_array[i_sim].ToString(label_style_format);
            x_current_label.Text = x_current_array[i_sim].ToString(label_style_format);
            x_overshoot_label.Text = x_overshoot_array[i_sim].ToString(label_style_format);
            x_period_fis_label.Text = x_period_array_fis[i_sim].ToString(label_style_format);
            x_current_fis_label.Text = x_current_array_fis[i_sim].ToString(label_style_format);
            x_overshoot_fis_label.Text = x_overshoot_array_fis[i_sim].ToString(label_style_format);
            x_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            x_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(x_current_array[i_sim], max_angle_degree + 10));
            x_chart.Series[2].Points.AddXY(Math.Round(elapsed_time, 3), clamp(x_current_array_fis[i_sim], max_angle_degree + 10));

            y_period_label.Text = y_period_array[i_sim].ToString(label_style_format);
            y_current_label.Text = y_current_array[i_sim].ToString(label_style_format);
            y_overshoot_label.Text = y_overshoot_array[i_sim].ToString(label_style_format);
            y_period_fis_label.Text = y_period_array_fis[i_sim].ToString(label_style_format);
            y_current_fis_label.Text = y_current_array_fis[i_sim].ToString(label_style_format);
            y_overshoot_fis_label.Text = y_overshoot_array_fis[i_sim].ToString(label_style_format);
            y_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            y_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(y_current_array[i_sim], max_angle_degree + 10));
            y_chart.Series[2].Points.AddXY(Math.Round(elapsed_time, 3), clamp(y_current_array_fis[i_sim], max_angle_degree + 10));

            z_period_label.Text = z_period_array[i_sim].ToString(label_style_format);
            z_current_label.Text = z_current_array[i_sim].ToString(label_style_format);
            z_overshoot_label.Text = z_overshoot_array[i_sim].ToString(label_style_format);
            z_period_fis_label.Text = z_period_array_fis[i_sim].ToString(label_style_format);
            z_current_fis_label.Text = z_current_array_fis[i_sim].ToString(label_style_format);
            z_overshoot_fis_label.Text = z_overshoot_array_fis[i_sim].ToString(label_style_format);
            z_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            z_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(z_current_array[i_sim], max_angle_degree + 10));
            z_chart.Series[2].Points.AddXY(Math.Round(elapsed_time, 3), clamp(z_current_array_fis[i_sim], max_angle_degree + 10));

            var outStream_copter = new FileStream("copter.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            var sw_copter = new StreamWriter(outStream_copter);

            sw_copter.WriteLine(x_current_array[i_sim].ToString());
            sw_copter.WriteLine(y_current_array[i_sim].ToString());
            sw_copter.WriteLine(z_current_array[i_sim].ToString());
            sw_copter.Close();


            var outStream_copter_fis = new FileStream("copter_fis.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            var sw_copter_fis = new StreamWriter(outStream_copter_fis);

            sw_copter_fis.WriteLine(x_current_array_fis[i_sim].ToString());
            sw_copter_fis.WriteLine(y_current_array_fis[i_sim].ToString());
            sw_copter_fis.WriteLine(z_current_array_fis[i_sim].ToString());
            sw_copter_fis.Close();

            if (elapsed_time > chart_time_amount)
            {
                x_chart.Series[0].Points.RemoveAt(0);
                x_chart.Series[1].Points.RemoveAt(0);
                x_chart.Series[2].Points.RemoveAt(0);
                x_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - chart_time_amount;
                x_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                y_chart.Series[0].Points.RemoveAt(0);
                y_chart.Series[1].Points.RemoveAt(0);
                y_chart.Series[2].Points.RemoveAt(0);
                y_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - chart_time_amount;
                y_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                z_chart.Series[0].Points.RemoveAt(0);
                z_chart.Series[1].Points.RemoveAt(0);
                z_chart.Series[2].Points.RemoveAt(0);
                z_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - chart_time_amount;
                z_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
            }

            i_sim += 1;
            if (i_sim >= n_sim)
            {
                pause_procedure();
                continue_button.Enabled = false;
            }
        }

        private void x_ziegler_button_Click(object sender, EventArgs e)
        {
            double dt = (double)dt_const / timer_interval_divide;
            PID pid = new PID(dt, (double)x_max_effect_edit.Value, (double)x_max_integral_edit.Value, (double)x_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model(0.5, 0.1, 0.25, 0.2, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_phi_PID();
            x_P_edit.Value = (decimal)clamp(PID.x, (double)x_P_edit.Maximum);
            x_I_edit.Value = (decimal)clamp(PID.y, (double)x_I_edit.Maximum);
            x_D_edit.Value = (decimal)clamp(PID.z, (double)x_D_edit.Maximum);
        }

        private void y_ziegler_button_Click(object sender, EventArgs e)
        {
            double dt = (double)dt_const / timer_interval_divide;
            PID pid = new PID(dt, (double)y_max_effect_edit.Value, (double)y_max_integral_edit.Value, (double)y_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model(0.5, 0.1, 0.25, 0.2, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_theta_PID();
            y_P_edit.Value = (decimal)clamp(PID.x, (double)y_P_edit.Maximum);
            y_I_edit.Value = (decimal)clamp(PID.y, (double)y_I_edit.Maximum);
            y_D_edit.Value = (decimal)clamp(PID.z, (double)y_D_edit.Maximum);
        }

        private void z_ziegler_button_Click(object sender, EventArgs e)
        {
            double dt = (double)dt_const / timer_interval_divide;
            PID pid = new PID(dt, (double)z_max_effect_edit.Value, (double)z_max_integral_edit.Value, (double)z_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model(0.5, 0.1, 0.25, 0.2, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_psi_PID();
            z_P_edit.Value = (decimal)clamp(PID.x, (double)z_P_edit.Maximum);
            z_I_edit.Value = (decimal)clamp(PID.y, (double)z_I_edit.Maximum);
            z_D_edit.Value = (decimal)clamp(PID.z, (double)z_D_edit.Maximum);
        }

        private double clamp(double to_clamp, double edge)
        {
            if (to_clamp >= edge)
                return edge;
            else if(to_clamp <= -edge)
                return -edge;

            return to_clamp;
        }

        private void random_effect_check_CheckedChanged(object sender, EventArgs e)
        {
            if (random_effect_edit.Enabled)
                random_effect_edit.Enabled = false;
            else
                random_effect_edit.Enabled = true;
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            Process p = Process.Start("copter.exe", "-popupwindow");
            p.WaitForInputIdle();
            SetWindowPos(p.MainWindowHandle, this.Handle, 985, 12, 0, 0, 0);
            SetParent(p.MainWindowHandle, this.Handle);

            Process p_fis = Process.Start("copter_fis.exe", "-popupwindow");
            p_fis.WaitForInputIdle();
            SetWindowPos(p_fis.MainWindowHandle, this.Handle, 985, 372, 0, 0, 0);
            SetParent(p_fis.MainWindowHandle, this.Handle);
        }
    }
}
