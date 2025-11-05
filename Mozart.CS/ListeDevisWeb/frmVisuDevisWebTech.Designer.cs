namespace MozartCS
{
  partial class frmVisuDevisWebTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisuDevisWebTech));
      this.cmdPrint = new MozartUC.apiButton();
      this.cmdExit = new MozartUC.apiButton();
      this.cmdFax = new MozartUC.apiButton();
      this.cmdform = new MozartUC.apiButton();
      this.brwWebBrowser = new System.Windows.Forms.WebBrowser();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdPrint
      // 
      resources.ApplyResources(this.cmdPrint, "cmdPrint");
      this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrint.HelpContextID = 0;
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.Tag = "17";
      this.cmdPrint.UseVisualStyleBackColor = true;
      this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
      // 
      // cmdExit
      // 
      resources.ApplyResources(this.cmdExit, "cmdExit");
      this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdExit.HelpContextID = 0;
      this.cmdExit.Name = "cmdExit";
      this.cmdExit.Tag = "15";
      this.cmdExit.UseVisualStyleBackColor = true;
      this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
      // 
      // cmdFax
      // 
      resources.ApplyResources(this.cmdFax, "cmdFax");
      this.cmdFax.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFax.HelpContextID = 0;
      this.cmdFax.Name = "cmdFax";
      this.cmdFax.Tag = "91";
      this.cmdFax.UseVisualStyleBackColor = true;
      this.cmdFax.Click += new System.EventHandler(this.cmdFax_Click);
      // 
      // cmdform
      // 
      resources.ApplyResources(this.cmdform, "cmdform");
      this.cmdform.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdform.HelpContextID = 0;
      this.cmdform.Name = "cmdform";
      this.cmdform.UseVisualStyleBackColor = true;
      // 
      // brwWebBrowser
      // 
      resources.ApplyResources(this.brwWebBrowser, "brwWebBrowser");
      this.brwWebBrowser.CausesValidation = false;
      this.brwWebBrowser.Name = "brwWebBrowser";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmVisuDevisWebTech
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdPrint);
      this.Controls.Add(this.cmdExit);
      this.Controls.Add(this.cmdFax);
      this.Controls.Add(this.cmdform);
      this.Controls.Add(this.brwWebBrowser);
      this.Controls.Add(this.Label1);
      this.Name = "frmVisuDevisWebTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmVisuDevisWebTech_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdPrint;
    private MozartUC.apiButton cmdExit;
    private MozartUC.apiButton cmdFax;
    private MozartUC.apiButton cmdform;
    private System.Windows.Forms.WebBrowser brwWebBrowser;
    private MozartUC.apiLabel Label1;

  }
}
