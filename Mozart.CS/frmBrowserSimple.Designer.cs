namespace MozartCS
{
    partial class frmBrowserSimple
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowserSimple));
      this.brwWebBrowser = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // brwWebBrowser
      // 
      resources.ApplyResources(this.brwWebBrowser, "brwWebBrowser");
      this.brwWebBrowser.Name = "brwWebBrowser";
      // 
      // frmBrowserSimple
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.brwWebBrowser);
      this.Name = "frmBrowserSimple";
      this.ShowInTaskbar = false;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrowserSimple_FormClosing);
      this.Load += new System.EventHandler(this.frmBrowserSimple_Load);
      this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser brwWebBrowser;
    }
}