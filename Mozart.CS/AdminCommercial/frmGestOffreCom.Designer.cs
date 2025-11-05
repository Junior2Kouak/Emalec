namespace MozartCS
{
  partial class frmGestOffreCom
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestOffreCom));
      this.lblTitre = new System.Windows.Forms.Label();
      this.cmdFermer = new MozartUC.apiButton();
      this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.ucListeOffres1 = new MozartCS.UCListeOffres();
      this.flpButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // flpButtons
      // 
      resources.ApplyResources(this.flpButtons, "flpButtons");
      this.flpButtons.Controls.Add(this.cmdArchive);
      this.flpButtons.Controls.Add(this.cmdSupprimer);
      this.flpButtons.Name = "flpButtons";
      // 
      // cmdArchive
      // 
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.HelpContextID = 396;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "80";
      this.cmdArchive.UseVisualStyleBackColor = true;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 765;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "83";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // ucListeOffres1
      // 
      resources.ApplyResources(this.ucListeOffres1, "ucListeOffres1");
      this.ucListeOffres1.MultiProspects = false;
      this.ucListeOffres1.Name = "ucListeOffres1";
      this.ucListeOffres1.TypeFiltreOffre = 0;
      // 
      // frmGestOffreCom
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.flpButtons);
      this.Controls.Add(this.ucListeOffres1);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmGestOffreCom";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestOffreCom_Load);
      this.flpButtons.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblTitre;
    private UCListeOffres ucListeOffres1;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdSupprimer;
  }
}