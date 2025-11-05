namespace MozartCS
{
  partial class frmGestProcedure
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestProcedure));
      this.CmdListeArch = new MozartUC.apiButton();
      this.cmdWebCont = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdArchiver = new MozartUC.apiButton();
      this.CmdVisu = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.lblTitre = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // CmdListeArch
      // 
      this.CmdListeArch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.CmdListeArch, "CmdListeArch");
      this.CmdListeArch.HelpContextID = 364;
      this.CmdListeArch.Name = "CmdListeArch";
      this.CmdListeArch.UseVisualStyleBackColor = false;
      this.CmdListeArch.Click += new System.EventHandler(this.CmdListeArch_Click);
      // 
      // cmdWebCont
      // 
      resources.ApplyResources(this.cmdWebCont, "cmdWebCont");
      this.cmdWebCont.HelpContextID = 249;
      this.cmdWebCont.Name = "cmdWebCont";
      this.cmdWebCont.UseVisualStyleBackColor = true;
      this.cmdWebCont.Click += new System.EventHandler(this.cmdWebCont_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 363;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.CmdModifier_Click);
      // 
      // cmdArchiver
      // 
      this.cmdArchiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
      this.cmdArchiver.HelpContextID = 364;
      this.cmdArchiver.Name = "cmdArchiver";
      this.cmdArchiver.UseVisualStyleBackColor = false;
      this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
      // 
      // CmdVisu
      // 
      resources.ApplyResources(this.CmdVisu, "CmdVisu");
      this.CmdVisu.HelpContextID = 0;
      this.CmdVisu.Name = "CmdVisu";
      this.CmdVisu.UseVisualStyleBackColor = true;
      this.CmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.HelpContextID = 362;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
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
      // frmGestProcedure
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdListeArch);
      this.Controls.Add(this.cmdWebCont);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.CmdVisu);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestProcedure";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestProcedure_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton CmdListeArch;
    private MozartUC.apiButton cmdWebCont;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton CmdVisu;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel lblTitre;
  }
}
