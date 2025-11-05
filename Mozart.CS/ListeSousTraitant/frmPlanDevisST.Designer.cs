namespace MozartCS
{
  partial class frmPlanDevisST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanDevisST));
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdPrec = new MozartUC.apiButton();
      this.cmdSuiv = new MozartUC.apiButton();
      this.cmdTechS = new MozartUC.apiButton();
      this.cmdTechP = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
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
      // cmdPrec
      // 
      resources.ApplyResources(this.cmdPrec, "cmdPrec");
      this.cmdPrec.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrec.HelpContextID = 0;
      this.cmdPrec.Name = "cmdPrec";
      this.cmdPrec.UseVisualStyleBackColor = true;
      this.cmdPrec.Click += new System.EventHandler(this.cmdPrec_Click);
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
      // cmdTechS
      // 
      resources.ApplyResources(this.cmdTechS, "cmdTechS");
      this.cmdTechS.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTechS.HelpContextID = 0;
      this.cmdTechS.Name = "cmdTechS";
      this.cmdTechS.UseVisualStyleBackColor = true;
      this.cmdTechS.Click += new System.EventHandler(this.cmdTechS_Click);
      // 
      // cmdTechP
      // 
      resources.ApplyResources(this.cmdTechP, "cmdTechP");
      this.cmdTechP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTechP.HelpContextID = 0;
      this.cmdTechP.Name = "cmdTechP";
      this.cmdTechP.UseVisualStyleBackColor = true;
      this.cmdTechP.Click += new System.EventHandler(this.cmdTechP_Click);
      // 
      // frmPlanDevisST
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdPrec);
      this.Controls.Add(this.cmdSuiv);
      this.Controls.Add(this.cmdTechS);
      this.Controls.Add(this.cmdTechP);
      this.MinimizeBox = false;
      this.Name = "frmPlanDevisST";
      this.Load += new System.EventHandler(this.frmPlanDevisST_Load);
      this.Controls.SetChildIndex(this.cmdTechP, 0);
      this.Controls.SetChildIndex(this.cmdTechS, 0);
      this.Controls.SetChildIndex(this.cmdSuiv, 0);
      this.Controls.SetChildIndex(this.cmdPrec, 0);
      this.Controls.SetChildIndex(this.cmdFermer, 0);
      this.Controls.SetChildIndex(this.cmdImprimer, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdPrec;
    private MozartUC.apiButton cmdSuiv;
    private MozartUC.apiButton cmdTechS;
    private MozartUC.apiButton cmdTechP;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
