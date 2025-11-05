namespace MozartCS
{
    partial class frmxVisuImg
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxVisuImg));
      this.browser = new System.Windows.Forms.WebBrowser();
      this.Image1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuEnregImage = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
      this.mnuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // browser
      // 
      resources.ApplyResources(this.browser, "browser");
      this.browser.Name = "browser";
      // 
      // Image1
      // 
      this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Image1, "Image1");
      this.Image1.Name = "Image1";
      this.Image1.TabStop = false;
      this.Image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Image1_MouseUp);
      // 
      // menuStrip1
      // 
      resources.ApplyResources(this.menuStrip1, "menuStrip1");
      this.menuStrip1.Name = "menuStrip1";
      // 
      // mnuAffichage
      // 
      this.mnuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnregImage});
      this.mnuAffichage.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuAffichage, "mnuAffichage");
      // 
      // mnuEnregImage
      // 
      this.mnuEnregImage.Name = "mnuEnregImage";
      resources.ApplyResources(this.mnuEnregImage, "mnuEnregImage");
      this.mnuEnregImage.Click += new System.EventHandler(this.mnuEnregImage_Click);
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
      // 
      // frmxVisuImg
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Image1);
      this.Controls.Add(this.browser);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmxVisuImg";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmxVisuImg_Load);
      this.Resize += new System.EventHandler(this.frmxVisuImg_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
      this.mnuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        public System.Windows.Forms.PictureBox Image1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ContextMenuStrip mnuAffichage;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.ToolStripMenuItem mnuEnregImage;
  }
}