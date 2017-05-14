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

        public main_form()
        {
            main_stopwatch = new Stopwatch();
            qm = new quadcopter_model();
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            main_stopwatch.Start();
            main_timer.Start();
            qm.init();
            start_button.Enabled = false;
            pause_button.Enabled = true;
            stop_button.Enabled = true;
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
            main_time_label.Text = qm.get_phi().ToString(); //main_stopwatch.ElapsedMilliseconds.ToString();
            qm.update();
        }
    }
}
