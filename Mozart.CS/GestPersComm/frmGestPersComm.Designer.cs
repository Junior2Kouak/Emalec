namespace MozartCS
{
  partial class frmGestPersComm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestPersComm));
      this.cmdGoogle = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdImplantation = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdGoogle
      // 
      resources.ApplyResources(this.cmdGoogle, "cmdGoogle");
      this.cmdGoogle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGoogle.HelpContextID = 0;
      this.cmdGoogle.Name = "cmdGoogle";
      this.cmdGoogle.UseVisualStyleBackColor = true;
      this.cmdGoogle.Click += new System.EventHandler(this.cmdGoogle_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "27";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
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
      // cmdImplantation
      // 
      resources.ApplyResources(this.cmdImplantation, "cmdImplantation");
      this.cmdImplantation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImplantation.HelpContextID = 0;
      this.cmdImplantation.Name = "cmdImplantation";
      this.cmdImplantation.UseVisualStyleBackColor = true;
      this.cmdImplantation.Click += new System.EventHandler(this.cmdImplantation_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmGestPersComm
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdGoogle);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdImplantation);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestPersComm";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestPersComm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdGoogle;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdImplantation;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
