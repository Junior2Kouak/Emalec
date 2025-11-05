namespace MozartCS
{
  partial class frmBrowser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
      this.cmdRavel = new MozartUC.apiButton();
      this.cmdFicheTech = new MozartUC.apiButton();
      this.cmdMail = new MozartUC.apiButton();
      this.cmdPrintChoix = new MozartUC.apiButton();
      this.cmdPrec = new MozartUC.apiButton();
      this.cmdSuiv = new MozartUC.apiButton();
      this.cmdExit = new MozartUC.apiButton();
      this.cmdPrint = new MozartUC.apiButton();
      this.brwWebBrowser = new System.Windows.Forms.WebBrowser();
      this.Label1 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnu_Affichage = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDetails = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.menuStrip1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdRavel
      // 
      resources.ApplyResources(this.cmdRavel, "cmdRavel");
      this.cmdRavel.HelpContextID = 0;
      this.cmdRavel.Name = "cmdRavel";
      this.cmdRavel.UseVisualStyleBackColor = true;
      this.cmdRavel.Click += new System.EventHandler(this.cmdRavel_Click);
      // 
      // cmdFicheTech
      // 
      resources.ApplyResources(this.cmdFicheTech, "cmdFicheTech");
      this.cmdFicheTech.HelpContextID = -1;
      this.cmdFicheTech.Name = "cmdFicheTech";
      this.cmdFicheTech.UseVisualStyleBackColor = true;
      this.cmdFicheTech.Click += new System.EventHandler(this.cmdFicheTech_Click);
      // 
      // cmdMail
      // 
      resources.ApplyResources(this.cmdMail, "cmdMail");
      this.cmdMail.HelpContextID = 0;
      this.cmdMail.Name = "cmdMail";
      this.cmdMail.Tag = "36";
      this.cmdMail.UseVisualStyleBackColor = true;
      this.cmdMail.Click += new System.EventHandler(this.cmdMail_Click);
      // 
      // cmdPrintChoix
      // 
      resources.ApplyResources(this.cmdPrintChoix, "cmdPrintChoix");
      this.cmdPrintChoix.HelpContextID = 0;
      this.cmdPrintChoix.Name = "cmdPrintChoix";
      this.cmdPrintChoix.Tag = "91";
      this.cmdPrintChoix.UseVisualStyleBackColor = true;
      this.cmdPrintChoix.Click += new System.EventHandler(this.cmdPrintChoix_Click);
      // 
      // cmdPrec
      // 
      this.cmdPrec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdPrec, "cmdPrec");
      this.cmdPrec.HelpContextID = 0;
      this.cmdPrec.Name = "cmdPrec";
      this.cmdPrec.UseVisualStyleBackColor = true;
      this.cmdPrec.Click += new System.EventHandler(this.cmdPrec_Click);
      // 
      // cmdSuiv
      // 
      resources.ApplyResources(this.cmdSuiv, "cmdSuiv");
      this.cmdSuiv.HelpContextID = 0;
      this.cmdSuiv.Name = "cmdSuiv";
      this.cmdSuiv.UseVisualStyleBackColor = true;
      this.cmdSuiv.Click += new System.EventHandler(this.cmdSuiv_Click);
      // 
      // cmdExit
      // 
      this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdExit, "cmdExit");
      this.cmdExit.HelpContextID = 0;
      this.cmdExit.Name = "cmdExit";
      this.cmdExit.Tag = "15";
      this.cmdExit.UseVisualStyleBackColor = true;
      this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
      // 
      // cmdPrint
      // 
      resources.ApplyResources(this.cmdPrint, "cmdPrint");
      this.cmdPrint.HelpContextID = 0;
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.Tag = "17";
      this.cmdPrint.UseVisualStyleBackColor = true;
      this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
      // 
      // brwWebBrowser
      // 
      this.brwWebBrowser.CausesValidation = false;
      resources.ApplyResources(this.brwWebBrowser, "brwWebBrowser");
      this.brwWebBrowser.Name = "brwWebBrowser";
      this.brwWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.brwWebBrowser_DocumentCompleted);
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Affichage});
      resources.ApplyResources(this.menuStrip1, "menuStrip1");
      this.menuStrip1.Name = "menuStrip1";
      // 
      // mnu_Affichage
      // 
      this.mnu_Affichage.Name = "mnu_Affichage";
      resources.ApplyResources(this.mnu_Affichage, "mnu_Affichage");
      // 
      // mnuDetails
      // 
      this.mnuDetails.Name = "mnuDetails";
      resources.ApplyResources(this.mnuDetails, "mnuDetails");
      this.mnuDetails.Click += new System.EventHandler(this.mnuDetails_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDetails});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
      // 
      // webView21
      // 
      this.webView21.AllowExternalDrop = true;
      this.webView21.BackColor = System.Drawing.Color.White;
      this.webView21.CreationProperties = null;
      this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
      resources.ApplyResources(this.webView21, "webView21");
      this.webView21.Name = "webView21";
      this.webView21.ZoomFactor = 1D;
      // 
      // frmBrowser
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdExit;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdRavel);
      this.Controls.Add(this.cmdFicheTech);
      this.Controls.Add(this.cmdMail);
      this.Controls.Add(this.cmdPrintChoix);
      this.Controls.Add(this.cmdPrec);
      this.Controls.Add(this.cmdSuiv);
      this.Controls.Add(this.cmdExit);
      this.Controls.Add(this.cmdPrint);
      this.Controls.Add(this.brwWebBrowser);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.webView21);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmBrowser";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrowser_FormClosing);
      this.Load += new System.EventHandler(this.frmBrowser_Load);
      this.Resize += new System.EventHandler(this.frmBrowser_Resize);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdRavel;
    private MozartUC.apiButton cmdFicheTech;
    private MozartUC.apiButton cmdMail;
    private MozartUC.apiButton cmdPrintChoix;
    private MozartUC.apiButton cmdPrec;
    private MozartUC.apiButton cmdSuiv;
    private MozartUC.apiButton cmdExit;
    private MozartUC.apiButton cmdPrint;
    private System.Windows.Forms.WebBrowser brwWebBrowser;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnu_Affichage;
    private System.Windows.Forms.ToolStripMenuItem mnuDetails;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
  }
}
