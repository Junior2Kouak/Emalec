namespace MozartCS
{
  partial class frmChoixTriPlaConges
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixTriPlaConges));
      this.cmdPrint = new MozartUC.apiButton();
      this.cmdSuiv = new MozartUC.apiButton();
      this.cmdPrec = new MozartUC.apiButton();
      this.optri2 = new System.Windows.Forms.RadioButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.optri1 = new System.Windows.Forms.RadioButton();
      this.optri0 = new System.Windows.Forms.RadioButton();
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
      // cmdSuiv
      // 
      resources.ApplyResources(this.cmdSuiv, "cmdSuiv");
      this.cmdSuiv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuiv.HelpContextID = 0;
      this.cmdSuiv.Name = "cmdSuiv";
      this.cmdSuiv.UseVisualStyleBackColor = true;
      this.cmdSuiv.Click += new System.EventHandler(this.cmdSuiv_Click);
      // 
      // cmdPrec
      // 
      resources.ApplyResources(this.cmdPrec, "cmdPrec");
      this.cmdPrec.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrec.HelpContextID = 0;
      this.cmdPrec.Name = "cmdPrec";
      this.cmdPrec.UseVisualStyleBackColor = true;
      this.cmdPrec.Click += new System.EventHandler(this.cmdPrec_Click);
      // 
      // optri2
      // 
      this.optri2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optri2, "optri2");
      this.optri2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optri2.Name = "optri2";
      this.optri2.UseVisualStyleBackColor = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // optri1
      // 
      this.optri1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optri1, "optri1");
      this.optri1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optri1.Name = "optri1";
      this.optri1.UseVisualStyleBackColor = false;
      // 
      // optri0
      // 
      this.optri0.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optri0, "optri0");
      this.optri0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optri0.Name = "optri0";
      this.optri0.UseVisualStyleBackColor = false;
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
      // frmChoixTriPlaConges
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdPrint);
      this.Controls.Add(this.cmdSuiv);
      this.Controls.Add(this.cmdPrec);
      this.Controls.Add(this.optri2);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.optri1);
      this.Controls.Add(this.optri0);
      this.Controls.Add(this.brwWebBrowser);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixTriPlaConges";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmChoixTriPlaConges_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdPrint;
    private MozartUC.apiButton cmdSuiv;
    private MozartUC.apiButton cmdPrec;
    private System.Windows.Forms.RadioButton optri2;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.RadioButton optri1;
    private System.Windows.Forms.RadioButton optri0;
    private System.Windows.Forms.WebBrowser brwWebBrowser;
    private MozartUC.apiLabel Label1;

  }
}
