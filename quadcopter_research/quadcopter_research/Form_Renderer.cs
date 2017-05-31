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

using System.Security.Permissions;
using System.Runtime.InteropServices;

using System.IO;

namespace quadcopter_research
{
    [ComVisible(true)]
    [PermissionSet(SecurityAction.Demand, Name ="FullTrust")]
    public partial class Form_Renderer : DockContent
    {
        private string _currentDirectory = string.Empty;
        private string _pathToUnityAssets = "/Core/Unity/_RENDERER.html";

        public Form_Renderer()
        {
            InitializeComponent();
            _currentDirectory = Directory.GetCurrentDirectory();
            webBrowser_Renderer.Url = new Uri(string.Format("{0}{1}", _currentDirectory, _pathToUnityAssets));
        }

        private void webBrowser_Renderer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_Renderer.ObjectForScripting = this;
        }
    }
}
