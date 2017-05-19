﻿using System;
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
        private const double max_angle_degree = 180.0;
        private const double chart_time_amount = 10.0;
        private const double timer_interval_divide = 1000.0;
        private const double axis_x_interval = 1.0;
        private const string chart_label_style_format = "#.";
        private const string label_style_format = "0.00";

        private quadcopter_model qm;

        private Stopwatch main_stopwatch;

        private vector3 reference;
        private vector3 angles;

        private PID phi_PID;
        private PID theta_PID;
        private PID psi_PID;

        private ZieglerNichols zn;

        private double elapsed_time;
        private double dt;

        private double phi_effect;
        private double theta_effect;
        private double psi_effect;

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

        int i_sim;
        int n_sim;

        public main_form()
        {
            InitializeComponent();

            main_stopwatch = new Stopwatch();
            qm = new quadcopter_model();

            phi_PID = new PID();
            theta_PID = new PID();
            psi_PID = new PID();

            zn = new ZieglerNichols();

            dt_box.SelectedIndex = 0;
            x_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            x_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            x_chart.ChartAreas[0].AxisY.Interval = chart_time_amount;
            x_chart.ChartAreas[0].AxisX.Minimum = 0;
            x_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;
            x_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            x_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
            y_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            y_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            y_chart.ChartAreas[0].AxisY.Interval = chart_time_amount;
            y_chart.ChartAreas[0].AxisX.Minimum = 0;
            y_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;
            y_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            y_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
            z_chart.ChartAreas[0].AxisY.Minimum = -max_angle_degree;
            z_chart.ChartAreas[0].AxisY.Maximum = max_angle_degree;
            z_chart.ChartAreas[0].AxisY.Interval = chart_time_amount;
            z_chart.ChartAreas[0].AxisX.Minimum = 0;
            z_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;
            z_chart.ChartAreas[0].AxisX.Interval = axis_x_interval;
            z_chart.ChartAreas[0].AxisX.LabelStyle.Format = chart_label_style_format;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            main_timer.Interval = int.Parse(dt_box.SelectedItem.ToString());

            i_sim = 0;

            mass_frame_edit.Enabled = false;
            mass_engine_edit.Enabled = false;
            radius_edit.Enabled = false;
            arm_length_edit.Enabled = false;

            dt_box.Enabled = false;
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
            x_anfis_check_box.Enabled = false;

            y_reference_edit.Enabled = false;
            y_initial_edit.Enabled = false;
            y_P_edit.Enabled = false;
            y_I_edit.Enabled = false;
            y_D_edit.Enabled = false;
            y_max_effect_edit.Enabled = false;
            y_max_integral_edit.Enabled = false;
            y_period_error_edit.Enabled = false;
            y_ziegler_button.Enabled = false;
            y_anfis_check_box.Enabled = false;

            z_reference_edit.Enabled = false;
            z_initial_edit.Enabled = false;
            z_P_edit.Enabled = false;
            z_I_edit.Enabled = false;
            z_D_edit.Enabled = false;
            z_max_effect_edit.Enabled = false;
            z_max_integral_edit.Enabled = false;
            z_period_error_edit.Enabled = false;
            z_ziegler_button.Enabled = false;
            z_anfis_check_box.Enabled = false;

            simulation();

            main_stopwatch.Start();
            main_timer.Start();
        }

        private void stop_procedure()
        {
            main_stopwatch.Reset();
            main_timer.Stop();
            main_time_label.Text = label_style_format;

            mass_frame_edit.Enabled = true;
            mass_engine_edit.Enabled = true;
            radius_edit.Enabled = true;
            arm_length_edit.Enabled = true;

            dt_box.Enabled = true;
            end_time_edit.Enabled = true;

            start_button.Enabled = true;
            pause_button.Enabled = false;
            continue_button.Enabled = false;
            stop_button.Enabled = false;

            x_overshoot_label.Text = label_style_format;
            x_period_label.Text = label_style_format;
            x_current_label.Text = label_style_format;
            x_reference_edit.Enabled = true;
            x_initial_edit.Enabled = true;
            x_max_effect_edit.Enabled = true;
            x_max_integral_edit.Enabled = true;
            x_period_error_edit.Enabled = true;
            if (x_anfis_check_box.Checked == false)
            {
                x_P_edit.Enabled = true;
                x_I_edit.Enabled = true;
                x_D_edit.Enabled = true;
                x_ziegler_button.Enabled = true;
            }
            x_anfis_check_box.Enabled = true;
            x_chart.Series[0].Points.Clear();
            x_chart.Series[1].Points.Clear();
            x_chart.ChartAreas[0].AxisX.Minimum = 0;
            x_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;

            y_overshoot_label.Text = label_style_format;
            y_period_label.Text = label_style_format;
            y_current_label.Text = label_style_format;
            y_reference_edit.Enabled = true;
            y_initial_edit.Enabled = true;
            y_max_effect_edit.Enabled = true;
            y_max_integral_edit.Enabled = true;
            y_period_error_edit.Enabled = true;
            if (y_anfis_check_box.Checked == false)
            {
                y_P_edit.Enabled = true;
                y_I_edit.Enabled = true;
                y_D_edit.Enabled = true;
                y_ziegler_button.Enabled = true;
            }
            y_anfis_check_box.Enabled = true;
            y_chart.Series[0].Points.Clear();
            y_chart.Series[1].Points.Clear();
            y_chart.ChartAreas[0].AxisX.Minimum = 0;
            y_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;

            z_overshoot_label.Text = label_style_format;
            z_period_label.Text = label_style_format;
            z_current_label.Text = label_style_format;
            z_reference_edit.Enabled = true;
            z_initial_edit.Enabled = true;
            z_max_effect_edit.Enabled = true;
            z_max_integral_edit.Enabled = true;
            z_period_error_edit.Enabled = true;
            if (z_anfis_check_box.Checked == false)
            {
                z_P_edit.Enabled = true;
                z_I_edit.Enabled = true;
                z_D_edit.Enabled = true;
                z_ziegler_button.Enabled = true;
            }
            z_anfis_check_box.Enabled = true;
            z_chart.Series[0].Points.Clear();
            z_chart.Series[1].Points.Clear();
            z_chart.ChartAreas[0].AxisX.Minimum = 0;
            z_chart.ChartAreas[0].AxisX.Maximum = chart_time_amount;
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

            elapsed_time = 0.0;

            reference = new vector3((double)x_reference_edit.Value, (double)y_reference_edit.Value, (double)z_reference_edit.Value);
            angles = new vector3((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);

            qm.init((double)mass_frame_edit.Value, (double)mass_engine_edit.Value, (double)radius_edit.Value, (double)arm_length_edit.Value, dt);
            qm.set_angles((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);

            phi_PID.init(dt, (double)x_max_effect_edit.Value, (double)x_max_integral_edit.Value, (double)x_P_edit.Value, (double)x_I_edit.Value, (double)x_D_edit.Value);
            theta_PID.init(dt, (double)y_max_effect_edit.Value, (double)y_max_integral_edit.Value, (double)y_P_edit.Value, (double)y_I_edit.Value, (double)y_D_edit.Value);
            psi_PID.init(dt, (double)z_max_effect_edit.Value, (double)z_max_integral_edit.Value, (double)z_P_edit.Value, (double)z_I_edit.Value, (double)z_D_edit.Value);

            x_period_error = (double)x_period_error_edit.Value;
            x_period = 0.0;
            x_overshoot = 0.0;
            x_overshoot_error_sign = Math.Sign(reference.x - (double)x_initial_edit.Value);
            x_overshoot_flag = false;

            y_period_error = (double)y_period_error_edit.Value;
            y_period = 0.0;
            y_overshoot = 0.0;
            y_overshoot_error_sign = Math.Sign(reference.y - (double)y_initial_edit.Value);
            y_overshoot_flag = false;

            z_period_error = (double)z_period_error_edit.Value;
            z_period = 0.0;
            z_overshoot = 0.0;
            z_overshoot_error_sign = Math.Sign(reference.z - (double)z_initial_edit.Value);
            z_overshoot_flag = false;

            for (int i = 0; i < n_sim; i++)
            {
                phi_effect = phi_PID.get_effect(angles.x, reference.x);
                theta_effect = theta_PID.get_effect(angles.y, reference.y);
                psi_effect = psi_PID.get_effect(angles.z, reference.z);

                qm.update(phi_effect, theta_effect, psi_effect);

                angles = qm.get_angles();

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
            x_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            x_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(x_current_array[i_sim], 190.0));

            y_period_label.Text = y_period_array[i_sim].ToString(label_style_format);
            y_current_label.Text = y_current_array[i_sim].ToString(label_style_format);
            y_overshoot_label.Text = y_overshoot_array[i_sim].ToString(label_style_format);
            y_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            y_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(y_current_array[i_sim], 190.0));

            z_period_label.Text = z_period_array[i_sim].ToString(label_style_format);
            z_current_label.Text = z_current_array[i_sim].ToString(label_style_format);
            z_overshoot_label.Text = z_overshoot_array[i_sim].ToString(label_style_format);
            z_chart.Series[0].Points.AddXY(Math.Round(elapsed_time, 3), reference.x);
            z_chart.Series[1].Points.AddXY(Math.Round(elapsed_time, 3), clamp(z_current_array[i_sim], 190.0));

            if (elapsed_time > chart_time_amount)
            {
                x_chart.Series[0].Points.RemoveAt(0);
                x_chart.Series[1].Points.RemoveAt(0);
                x_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - chart_time_amount;
                x_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                y_chart.Series[0].Points.RemoveAt(0);
                y_chart.Series[1].Points.RemoveAt(0);
                y_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - chart_time_amount;
                y_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                z_chart.Series[0].Points.RemoveAt(0);
                z_chart.Series[1].Points.RemoveAt(0);
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
            double dt = int.Parse(dt_box.SelectedItem.ToString()) / timer_interval_divide;
            PID pid = new PID(dt, (double)x_max_effect_edit.Value, (double)x_max_integral_edit.Value, (double)x_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model((double)mass_frame_edit.Value, (double)mass_engine_edit.Value, (double)radius_edit.Value, (double)arm_length_edit.Value, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_phi_PID();
            x_P_edit.Value = (decimal)PID.x;
            x_I_edit.Value = (decimal)PID.y;
            x_D_edit.Value = (decimal)PID.z;
        }

        private void y_ziegler_button_Click(object sender, EventArgs e)
        {
            double dt = int.Parse(dt_box.SelectedItem.ToString()) / timer_interval_divide;
            PID pid = new PID(dt, (double)y_max_effect_edit.Value, (double)y_max_integral_edit.Value, (double)y_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model((double)mass_frame_edit.Value, (double)mass_engine_edit.Value, (double)radius_edit.Value, (double)arm_length_edit.Value, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_theta_PID();
            y_P_edit.Value = (decimal)PID.x;
            y_I_edit.Value = (decimal)PID.y;
            y_D_edit.Value = (decimal)PID.z;
        }

        private void z_ziegler_button_Click(object sender, EventArgs e)
        {
            double dt = int.Parse(dt_box.SelectedItem.ToString()) / timer_interval_divide;
            PID pid = new PID(dt, (double)z_max_effect_edit.Value, (double)z_max_integral_edit.Value, (double)z_P_edit.Value, 0.0, 0.0);
            quadcopter_model qm = new quadcopter_model((double)mass_frame_edit.Value, (double)mass_engine_edit.Value, (double)radius_edit.Value, (double)arm_length_edit.Value, dt);
            zn.init(pid, qm, dt);
            vector3 PID = zn.get_psi_PID();
            z_P_edit.Value = (decimal)PID.x;
            z_I_edit.Value = (decimal)PID.y;
            z_D_edit.Value = (decimal)PID.z;
        }

        private void x_anfis_check_box_CheckedChanged(object sender, EventArgs e)
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

        private void y_anfis_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if (y_anfis_check_box.Checked)
            {
                y_P_edit.Enabled = false;
                y_I_edit.Enabled = false;
                y_D_edit.Enabled = false;
                y_ziegler_button.Enabled = false;
            }
            else
            {
                y_P_edit.Enabled = true;
                y_I_edit.Enabled = true;
                y_D_edit.Enabled = true;
                y_ziegler_button.Enabled = true;
            }
        }

        private void z_anfis_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if (z_anfis_check_box.Checked)
            {
                z_P_edit.Enabled = false;
                z_I_edit.Enabled = false;
                z_D_edit.Enabled = false;
                z_ziegler_button.Enabled = false;
            }
            else
            {
                z_P_edit.Enabled = true;
                z_I_edit.Enabled = true;
                z_D_edit.Enabled = true;
                z_ziegler_button.Enabled = true;
            }
        }


        private double clamp(double to_clamp, double edge)
        {
            if (to_clamp >= edge)
                return edge;
            else if(to_clamp <= -edge)
                return -edge;

            return to_clamp;
        }
    }
}
