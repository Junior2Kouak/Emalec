namespace MozartCS
{
  partial class frmListeDoc
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDoc));
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdArch = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.CmdVisu = new MozartUC.apiButton();
      this.CmdModifier = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.lblTitre = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdArchive
      // 
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.HelpContextID = 0;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "61";
      this.cmdArchive.UseVisualStyleBackColor = true;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdArch
      // 
      resources.ApplyResources(this.cmdArch, "cmdArch");
      this.cmdArch.HelpContextID = 360;
      this.cmdArch.Name = "cmdArch";
      this.cmdArch.UseVisualStyleBackColor = true;
      this.cmdArch.Click += new System.EventHandler(this.cmdArch_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.HelpContextID = 359;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // CmdVisu
      // 
      resources.ApplyResources(this.CmdVisu, "CmdVisu");
      this.CmdVisu.HelpContextID = 0;
      this.CmdVisu.Name = "CmdVisu";
      this.CmdVisu.UseVisualStyleBackColor = true;
      this.CmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // CmdModifier
      // 
      resources.ApplyResources(this.CmdModifier, "CmdModifier");
      this.CmdModifier.HelpContextID = 358;
      this.CmdModifier.Name = "CmdModifier";
      this.CmdModifier.UseVisualStyleBackColor = true;
      this.CmdModifier.Click += new System.EventHandler(this.CmdModifier_Click);
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
      // frmListeDoc
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdArch);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.CmdVisu);
      this.Controls.Add(this.CmdModifier);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmListeDoc";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDoc_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdArch;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton CmdVisu;
    private MozartUC.apiButton CmdModifier;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel lblTitre;
  }
}
