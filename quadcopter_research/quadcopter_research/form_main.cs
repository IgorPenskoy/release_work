using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace quadcopter_research
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            InitDockableForms();
        }

        public void InitDockableForms()
        {
            Form_Renderer form_renderer = new Form_Renderer();
            form_renderer.Show(dockPanel_Main, DockState.DockRight);

            main_form form_data = new main_form();
            form_data.Show(dockPanel_Main, DockState.DockLeft);
        }
    }
}
