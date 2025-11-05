namespace MozartCS
{
  partial class frmPlanSimple
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanSimple));
      this.cmdCalendrier = new MozartUC.apiButton();
      this.Calendrier = new System.Windows.Forms.DateTimePicker();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdSuiv = new MozartUC.apiButton();
      this.cmdPrec = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdLegende = new MozartUC.apiButton();
      this.lblLundi = new MozartUC.apiLabel();
      this.lblMardi = new MozartUC.apiLabel();
      this.lblMercredi = new MozartUC.apiLabel();
      this.lblJeudi = new MozartUC.apiLabel();
      this.lblVendredi = new MozartUC.apiLabel();
      this.lblSamedi = new MozartUC.apiLabel();
      this.lblTechnicien = new MozartUC.apiLabel();
      this.lblTech = new MozartUC.apiLabel();
      this.lblInfo0 = new MozartUC.apiLabel();
      this.lblDimanche = new MozartUC.apiLabel();
      this.lblSemaine = new MozartUC.apiLabel();
      this.lblAnnee = new MozartUC.apiLabel();
      this.Label18 = new MozartUC.apiLabel();
      this.pic0 = new MozartUC.apiLabel();
      this.mnuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuDetails = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuVisu = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMoisTech = new System.Windows.Forms.ToolStripMenuItem();
      this.lHeure1 = new MozartUC.apiLabel();
      this.lHeure2 = new MozartUC.apiLabel();
      this.lHeure3 = new MozartUC.apiLabel();
      this.lJour0 = new MozartUC.apiLabel();
      this.lJour1 = new MozartUC.apiLabel();
      this.lJour2 = new MozartUC.apiLabel();
      this.lJour3 = new MozartUC.apiLabel();
      this.lJour4 = new MozartUC.apiLabel();
      this.lJour5 = new MozartUC.apiLabel();
      this.lJour6 = new MozartUC.apiLabel();
      this.lHeure0 = new MozartUC.apiLabel();
      this.mnuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdCalendrier
      // 
      this.cmdCalendrier.BackColor = System.Drawing.Color.Transparent;
      this.cmdCalendrier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCalendrier.HelpContextID = 0;
      this.cmdCalendrier.Image = global::MozartCS.Properties.Resources.calendar;
      resources.ApplyResources(this.cmdCalendrier, "cmdCalendrier");
      this.cmdCalendrier.Name = "cmdCalendrier";
      this.cmdCalendrier.Tag = "5";
      this.cmdCalendrier.UseVisualStyleBackColor = false;
      this.cmdCalendrier.Click += new System.EventHandler(this.cmdCalendrier_Click);
      // 
      // Calendrier
      // 
      this.Calendrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(1)))));
      this.Calendrier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendrier, "Calendrier");
      this.Calendrier.Name = "Calendrier";
      this.Calendrier.CloseUp += new System.EventHandler(this.Calendrier_CloseUp);
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
      // cmdLegende
      // 
      this.cmdLegende.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdLegende.HelpContextID = 0;
      resources.ApplyResources(this.cmdLegende, "cmdLegende");
      this.cmdLegende.Name = "cmdLegende";
      this.cmdLegende.UseVisualStyleBackColor = true;
      this.cmdLegende.Click += new System.EventHandler(this.cmdLegende_Click);
      // 
      // lblLundi
      // 
      this.lblLundi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblLundi, "lblLundi");
      this.lblLundi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblLundi.HelpContextID = 0;
      this.lblLundi.Name = "lblLundi";
      // 
      // lblMardi
      // 
      this.lblMardi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblMardi, "lblMardi");
      this.lblMardi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblMardi.HelpContextID = 0;
      this.lblMardi.Name = "lblMardi";
      // 
      // lblMercredi
      // 
      this.lblMercredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblMercredi, "lblMercredi");
      this.lblMercredi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblMercredi.HelpContextID = 0;
      this.lblMercredi.Name = "lblMercredi";
      // 
      // lblJeudi
      // 
      this.lblJeudi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblJeudi, "lblJeudi");
      this.lblJeudi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblJeudi.HelpContextID = 0;
      this.lblJeudi.Name = "lblJeudi";
      // 
      // lblVendredi
      // 
      this.lblVendredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblVendredi, "lblVendredi");
      this.lblVendredi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblVendredi.HelpContextID = 0;
      this.lblVendredi.Name = "lblVendredi";
      // 
      // lblSamedi
      // 
      this.lblSamedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblSamedi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblSamedi, "lblSamedi");
      this.lblSamedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lblSamedi.HelpContextID = 0;
      this.lblSamedi.Name = "lblSamedi";
      // 
      // lblTechnicien
      // 
      this.lblTechnicien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblTechnicien, "lblTechnicien");
      this.lblTechnicien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblTechnicien.HelpContextID = 0;
      this.lblTechnicien.Name = "lblTechnicien";
      // 
      // lblTech
      // 
      this.lblTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblTech, "lblTech");
      this.lblTech.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTech.HelpContextID = 0;
      this.lblTech.Name = "lblTech";
      this.lblTech.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTech0_MouseUp);
      // 
      // lblInfo0
      // 
      this.lblInfo0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblInfo0, "lblInfo0");
      this.lblInfo0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lblInfo0.HelpContextID = 0;
      this.lblInfo0.Name = "lblInfo0";
      this.lblInfo0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblInfo0_MouseUp);
      // 
      // lblDimanche
      // 
      this.lblDimanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblDimanche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lblDimanche, "lblDimanche");
      this.lblDimanche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lblDimanche.HelpContextID = 0;
      this.lblDimanche.Name = "lblDimanche";
      // 
      // lblSemaine
      // 
      resources.ApplyResources(this.lblSemaine, "lblSemaine");
      this.lblSemaine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblSemaine.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSemaine.HelpContextID = 0;
      this.lblSemaine.Name = "lblSemaine";
      // 
      // lblAnnee
      // 
      resources.ApplyResources(this.lblAnnee, "lblAnnee");
      this.lblAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblAnnee.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAnnee.HelpContextID = 0;
      this.lblAnnee.Name = "lblAnnee";
      // 
      // Label18
      // 
      this.Label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label18, "Label18");
      this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label18.HelpContextID = 0;
      this.Label18.Name = "Label18";
      // 
      // pic0
      // 
      this.pic0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pic0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.pic0, "pic0");
      this.pic0.ForeColor = System.Drawing.Color.Black;
      this.pic0.HelpContextID = 0;
      this.pic0.Name = "pic0";
      // 
      // mnuAffichage
      // 
      this.mnuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDetails,
            this.mnuVisu,
            this.mnuMoisTech});
      this.mnuAffichage.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuAffichage, "mnuAffichage");
      // 
      // mnuDetails
      // 
      this.mnuDetails.Name = "mnuDetails";
      resources.ApplyResources(this.mnuDetails, "mnuDetails");
      this.mnuDetails.Click += new System.EventHandler(this.mnuDetails_Click);
      // 
      // mnuVisu
      // 
      this.mnuVisu.Name = "mnuVisu";
      resources.ApplyResources(this.mnuVisu, "mnuVisu");
      this.mnuVisu.Click += new System.EventHandler(this.mnuVisu_Click);
      // 
      // mnuMoisTech
      // 
      this.mnuMoisTech.Name = "mnuMoisTech";
      resources.ApplyResources(this.mnuMoisTech, "mnuMoisTech");
      this.mnuMoisTech.Click += new System.EventHandler(this.mnuMoisTech_Click);
      // 
      // lHeure1
      // 
      this.lHeure1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lHeure1, "lHeure1");
      this.lHeure1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lHeure1.HelpContextID = 0;
      this.lHeure1.Name = "lHeure1";
      // 
      // lHeure2
      // 
      this.lHeure2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lHeure2, "lHeure2");
      this.lHeure2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lHeure2.HelpContextID = 0;
      this.lHeure2.Name = "lHeure2";
      // 
      // lHeure3
      // 
      this.lHeure3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lHeure3, "lHeure3");
      this.lHeure3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lHeure3.HelpContextID = 0;
      this.lHeure3.Name = "lHeure3";
      // 
      // lJour0
      // 
      this.lJour0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour0, "lJour0");
      this.lJour0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour0.HelpContextID = 0;
      this.lJour0.Name = "lJour0";
      // 
      // lJour1
      // 
      this.lJour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour1, "lJour1");
      this.lJour1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour1.HelpContextID = 0;
      this.lJour1.Name = "lJour1";
      // 
      // lJour2
      // 
      this.lJour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour2, "lJour2");
      this.lJour2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour2.HelpContextID = 0;
      this.lJour2.Name = "lJour2";
      // 
      // lJour3
      // 
      this.lJour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour3, "lJour3");
      this.lJour3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour3.HelpContextID = 0;
      this.lJour3.Name = "lJour3";
      // 
      // lJour4
      // 
      this.lJour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour4, "lJour4");
      this.lJour4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour4.HelpContextID = 0;
      this.lJour4.Name = "lJour4";
      // 
      // lJour5
      // 
      this.lJour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour5, "lJour5");
      this.lJour5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour5.HelpContextID = 0;
      this.lJour5.Name = "lJour5";
      // 
      // lJour6
      // 
      this.lJour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lJour6, "lJour6");
      this.lJour6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lJour6.HelpContextID = 0;
      this.lJour6.Name = "lJour6";
      // 
      // lHeure0
      // 
      this.lHeure0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.lHeure0, "lHeure0");
      this.lHeure0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lHeure0.HelpContextID = 0;
      this.lHeure0.Name = "lHeure0";
      // 
      // frmPlanSimple
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.lHeure2);
      this.Controls.Add(this.lHeure0);
      this.Controls.Add(this.lJour6);
      this.Controls.Add(this.lJour5);
      this.Controls.Add(this.lJour4);
      this.Controls.Add(this.lJour3);
      this.Controls.Add(this.lJour2);
      this.Controls.Add(this.lJour1);
      this.Controls.Add(this.lJour0);
      this.Controls.Add(this.lHeure3);
      this.Controls.Add(this.lHeure1);
      this.Controls.Add(this.pic0);
      this.Controls.Add(this.cmdCalendrier);
      this.Controls.Add(this.Calendrier);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdSuiv);
      this.Controls.Add(this.cmdPrec);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdLegende);
      this.Controls.Add(this.lblLundi);
      this.Controls.Add(this.lblMardi);
      this.Controls.Add(this.lblMercredi);
      this.Controls.Add(this.lblJeudi);
      this.Controls.Add(this.lblVendredi);
      this.Controls.Add(this.lblSamedi);
      this.Controls.Add(this.lblTechnicien);
      this.Controls.Add(this.lblTech);
      this.Controls.Add(this.lblInfo0);
      this.Controls.Add(this.lblDimanche);
      this.Controls.Add(this.lblSemaine);
      this.Controls.Add(this.lblAnnee);
      this.Controls.Add(this.Label18);
      this.Name = "frmPlanSimple";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPlanSimple_Load);
      this.mnuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCalendrier;
    private System.Windows.Forms.DateTimePicker Calendrier;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdSuiv;
    private MozartUC.apiButton cmdPrec;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdLegende;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblLundi;
    private MozartUC.apiLabel lblMardi;
    private MozartUC.apiLabel lblMercredi;
    private MozartUC.apiLabel lblJeudi;
    private MozartUC.apiLabel lblVendredi;
    private MozartUC.apiLabel lblSamedi;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTechnicien;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTech;
    private MozartUC.apiLabel lblInfo0;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblDimanche;
    private MozartUC.apiLabel lblSemaine;
    private MozartUC.apiLabel lblAnnee;
    private MozartUC.apiLabel Label18;
    private MozartUC.apiLabel pic0;
    private System.Windows.Forms.ContextMenuStrip mnuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuDetails;
    private System.Windows.Forms.ToolStripMenuItem mnuVisu;
    private System.Windows.Forms.ToolStripMenuItem mnuMoisTech;
    private MozartUC.apiLabel lHeure1;
    private MozartUC.apiLabel lHeure2;
    private MozartUC.apiLabel lHeure3;
    private MozartUC.apiLabel lJour0;
    private MozartUC.apiLabel lJour1;
    private MozartUC.apiLabel lJour2;
    private MozartUC.apiLabel lJour3;
    private MozartUC.apiLabel lJour4;
    private MozartUC.apiLabel lJour5;
    private MozartUC.apiLabel lJour6;
    private MozartUC.apiLabel lHeure0;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
