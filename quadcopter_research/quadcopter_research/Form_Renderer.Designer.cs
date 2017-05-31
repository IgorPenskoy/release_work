namespace quadcopter_research
{
    partial class Form_Renderer
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
            this.webBrowser_Renderer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_Renderer
            // 
            this.webBrowser_Renderer.AllowWebBrowserDrop = false;
            this.webBrowser_Renderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_Renderer.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_Renderer.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_Renderer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Renderer.Name = "webBrowser_Renderer";
            this.webBrowser_Renderer.ScrollBarsEnabled = false;
            this.webBrowser_Renderer.Size = new System.Drawing.Size(284, 261);
            this.webBrowser_Renderer.TabIndex = 0;
            this.webBrowser_Renderer.WebBrowserShortcutsEnabled = false;
            this.webBrowser_Renderer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_Renderer_DocumentCompleted);
            // 
            // Form_Renderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.webBrowser_Renderer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form_Renderer";
            this.Text = "Form_Renderer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Renderer;
    }
}