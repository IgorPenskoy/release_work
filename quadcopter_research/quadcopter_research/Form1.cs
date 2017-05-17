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

        public main_form()
        {
            main_stopwatch = new Stopwatch();
            qm = new quadcopter_model();
            InitializeComponent();
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
            main_stopwatch.Start();
            main_timer.Start();
            reference = new vector3((double)x_reference_edit.Value, (double)y_reference_edit.Value, (double)z_reference_edit.Value);
            qm.init();
            qm.set_angles((double)x_initial_edit.Value, (double)y_initial_edit.Value, (double)z_initial_edit.Value);
            start_button.Enabled = false;
            pause_button.Enabled = true;
            stop_button.Enabled = true;
            x_reference_edit.Enabled = false;
            y_reference_edit.Enabled = false;
            z_reference_edit.Enabled = false;
            x_initial_edit.Enabled = false;
            y_initial_edit.Enabled = false;
            z_initial_edit.Enabled = false;

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            main_stopwatch.Reset();
            main_timer.Stop();
            main_time_label.Text = main_stopwatch.ElapsedMilliseconds.ToString();
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
            vector3 angles = qm.get_angles();
            double elapsed_time = main_stopwatch.Elapsed.TotalSeconds;
            main_time_label.Text = elapsed_time.ToString();
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
                x_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;//x_chart.Series[0].Points[0].XValue;
                x_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                y_chart.Series[0].Points.RemoveAt(0);
                y_chart.Series[1].Points.RemoveAt(0);
                y_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;//y_chart.Series[0].Points[0].XValue;
                y_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
                z_chart.Series[0].Points.RemoveAt(0);
                z_chart.Series[1].Points.RemoveAt(0);
                z_chart.ChartAreas[0].AxisX.Minimum = elapsed_time - 10;//z_chart.Series[0].Points[0].XValue;
                z_chart.ChartAreas[0].AxisX.Maximum = elapsed_time;
            }
            qm.update(reference);
        }
    }
}
