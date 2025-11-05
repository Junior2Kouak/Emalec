namespace MozartCS
{
  partial class frmGestRecrutement
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestRecrutement));
      this.cmdCarteTousTechs = new MozartUC.apiButton();
      this.CmdQCMRecru = new MozartUC.apiButton();
      this.CmdFicheContrat = new MozartUC.apiButton();
      this.cmdImplantation = new MozartUC.apiButton();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdCarteTousTechs
      // 
      resources.ApplyResources(this.cmdCarteTousTechs, "cmdCarteTousTechs");
      this.cmdCarteTousTechs.HelpContextID = 130;
      this.cmdCarteTousTechs.Name = "cmdCarteTousTechs";
      this.cmdCarteTousTechs.Tag = "76";
      this.cmdCarteTousTechs.UseVisualStyleBackColor = true;
      this.cmdCarteTousTechs.Click += new System.EventHandler(this.cmdCarteTousTechs_Click);
      // 
      // CmdQCMRecru
      // 
      resources.ApplyResources(this.CmdQCMRecru, "CmdQCMRecru");
      this.CmdQCMRecru.HelpContextID = 0;
      this.CmdQCMRecru.Name = "CmdQCMRecru";
      this.CmdQCMRecru.UseVisualStyleBackColor = true;
      this.CmdQCMRecru.Click += new System.EventHandler(this.CmdQCMRecru_Click);
      // 
      // CmdFicheContrat
      // 
      resources.ApplyResources(this.CmdFicheContrat, "CmdFicheContrat");
      this.CmdFicheContrat.HelpContextID = 0;
      this.CmdFicheContrat.Name = "CmdFicheContrat";
      this.CmdFicheContrat.UseVisualStyleBackColor = true;
      this.CmdFicheContrat.Click += new System.EventHandler(this.CmdFicheContrat_Click);
      // 
      // cmdImplantation
      // 
      resources.ApplyResources(this.cmdImplantation, "cmdImplantation");
      this.cmdImplantation.HelpContextID = 130;
      this.cmdImplantation.Name = "cmdImplantation";
      this.cmdImplantation.Tag = "76";
      this.cmdImplantation.UseVisualStyleBackColor = true;
      this.cmdImplantation.Click += new System.EventHandler(this.cmdImplantation_Click);
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "27";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // cmdArchive
      // 
      this.cmdArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.HelpContextID = 0;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "21";
      this.cmdArchive.UseVisualStyleBackColor = false;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.HelpContextID = 0;
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
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
      this.Label1.Name = "Label1";
      // 
      // frmGestRecrutement
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdCarteTousTechs);
      this.Controls.Add(this.CmdQCMRecru);
      this.Controls.Add(this.CmdFicheContrat);
      this.Controls.Add(this.cmdImplantation);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestRecrutement";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestRecrutement_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCarteTousTechs;
    private MozartUC.apiButton CmdQCMRecru;
    private MozartUC.apiButton CmdFicheContrat;
    private MozartUC.apiButton cmdImplantation;
    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiTGrid apiGrid;
    private System.Windows.Forms.Label Label1;

  }
}
