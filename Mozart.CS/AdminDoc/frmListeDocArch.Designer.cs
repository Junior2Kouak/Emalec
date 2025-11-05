namespace MozartCS
{
  partial class frmListeDocArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDocArch));
      this.cmdSupprimer = new MozartUC.apiButton();
      this.CmdVisu = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.lblTitre = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 356;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // CmdVisu
      // 
      resources.ApplyResources(this.CmdVisu, "CmdVisu");
      this.CmdVisu.HelpContextID = 0;
      this.CmdVisu.Name = "CmdVisu";
      this.CmdVisu.UseVisualStyleBackColor = true;
      this.CmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.HelpContextID = 356;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmListeDocArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.CmdVisu);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmListeDocArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDocArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton CmdVisu;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel lblTitre;
  }
}
