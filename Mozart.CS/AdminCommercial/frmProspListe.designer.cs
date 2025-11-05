using System;
using System.Windows;

namespace MozartCS
{
  partial class frmProspListe
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspListe));
      this.chkDateRelDepassee = new MozartUC.apiCheckBox();
      this.chkOffreEnCours = new MozartUC.apiCheckBox();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdcarte = new MozartUC.apiButton();
      this.cmdEditer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblTitre = new System.Windows.Forms.Label();
      this.cmdModifMasse = new MozartUC.apiButton();
      this.chkRdvNonEchus = new MozartUC.apiCheckBox();
      this.cmdLegend = new MozartUC.apiButton();
      this.frmLegend = new MozartUC.apiGroupBox();
      this.Command1 = new MozartUC.apiButton();
      this.Label26 = new MozartUC.apiLabel();
      this.Label25 = new MozartUC.apiLabel();
      this.Label24 = new MozartUC.apiLabel();
      this.lblRDVNonEchu = new MozartUC.apiLabel();
      this.lblFinDeContrat = new MozartUC.apiLabel();
      this.lblOffreComActive = new MozartUC.apiLabel();
      this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
      this.gridListeProspects = new MozartCS.UCListeProspects();
      this.frmLegend.SuspendLayout();
      this.flpButtons.SuspendLayout();
      this.flpFilters.SuspendLayout();
      this.SuspendLayout();
      // 
      // chkDateRelDepassee
      // 
      resources.ApplyResources(this.chkDateRelDepassee, "chkDateRelDepassee");
      this.chkDateRelDepassee.BackColor = System.Drawing.Color.Wheat;
      this.chkDateRelDepassee.HelpContextID = 0;
      this.chkDateRelDepassee.Name = "chkDateRelDepassee";
      this.chkDateRelDepassee.UseVisualStyleBackColor = false;
      this.chkDateRelDepassee.Click += new System.EventHandler(this.Check1_Click);
      // 
      // chkOffreEnCours
      // 
      resources.ApplyResources(this.chkOffreEnCours, "chkOffreEnCours");
      this.chkOffreEnCours.BackColor = System.Drawing.Color.Wheat;
      this.chkOffreEnCours.HelpContextID = 0;
      this.chkOffreEnCours.Name = "chkOffreEnCours";
      this.chkOffreEnCours.UseVisualStyleBackColor = false;
      this.chkOffreEnCours.Click += new System.EventHandler(this.Check1_Click);
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.HelpContextID = 376;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "83";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
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
      // cmdcarte
      // 
      resources.ApplyResources(this.cmdcarte, "cmdcarte");
      this.cmdcarte.HelpContextID = 0;
      this.cmdcarte.Name = "cmdcarte";
      this.cmdcarte.Tag = "95";
      this.cmdcarte.UseVisualStyleBackColor = true;
      this.cmdcarte.Click += new System.EventHandler(this.cmdcarte_Click);
      // 
      // cmdEditer
      // 
      resources.ApplyResources(this.cmdEditer, "cmdEditer");
      this.cmdEditer.HelpContextID = 0;
      this.cmdEditer.Name = "cmdEditer";
      this.cmdEditer.Tag = "17";
      this.cmdEditer.UseVisualStyleBackColor = true;
      this.cmdEditer.Click += new System.EventHandler(this.cmdEditer_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "4";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // cmdModifMasse
      // 
      resources.ApplyResources(this.cmdModifMasse, "cmdModifMasse");
      this.cmdModifMasse.HelpContextID = 761;
      this.cmdModifMasse.Name = "cmdModifMasse";
      this.cmdModifMasse.Tag = "36";
      this.cmdModifMasse.UseVisualStyleBackColor = true;
      this.cmdModifMasse.Click += new System.EventHandler(this.cmdModifMasse_Click);
      // 
      // chkRdvNonEchus
      // 
      resources.ApplyResources(this.chkRdvNonEchus, "chkRdvNonEchus");
      this.chkRdvNonEchus.BackColor = System.Drawing.Color.Wheat;
      this.chkRdvNonEchus.HelpContextID = 0;
      this.chkRdvNonEchus.Name = "chkRdvNonEchus";
      this.chkRdvNonEchus.UseVisualStyleBackColor = false;
      this.chkRdvNonEchus.Click += new System.EventHandler(this.Check1_Click);
      // 
      // cmdLegend
      // 
      resources.ApplyResources(this.cmdLegend, "cmdLegend");
      this.cmdLegend.HelpContextID = 0;
      this.cmdLegend.Name = "cmdLegend";
      this.cmdLegend.Tag = "2";
      this.cmdLegend.UseVisualStyleBackColor = true;
      this.cmdLegend.Click += new System.EventHandler(this.cmdLegend_Click);
      // 
      // frmLegend
      // 
      this.frmLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.frmLegend.Controls.Add(this.Command1);
      this.frmLegend.Controls.Add(this.Label26);
      this.frmLegend.Controls.Add(this.Label25);
      this.frmLegend.Controls.Add(this.Label24);
      this.frmLegend.Controls.Add(this.lblRDVNonEchu);
      this.frmLegend.Controls.Add(this.lblFinDeContrat);
      this.frmLegend.Controls.Add(this.lblOffreComActive);
      resources.ApplyResources(this.frmLegend, "frmLegend");
      this.frmLegend.FrameColor = System.Drawing.Color.Empty;
      this.frmLegend.HelpContextID = 0;
      this.frmLegend.Name = "frmLegend";
      this.frmLegend.TabStop = false;
      // 
      // Command1
      // 
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.Name = "Command1";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.cmdLegend_Click);
      // 
      // Label26
      // 
      this.Label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.Label26, "Label26");
      this.Label26.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label26.HelpContextID = 0;
      this.Label26.Name = "Label26";
      // 
      // Label25
      // 
      this.Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.Label25, "Label25");
      this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label25.HelpContextID = 0;
      this.Label25.Name = "Label25";
      // 
      // Label24
      // 
      this.Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.Label24, "Label24");
      this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label24.HelpContextID = 0;
      this.Label24.Name = "Label24";
      // 
      // lblRDVNonEchu
      // 
      this.lblRDVNonEchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.lblRDVNonEchu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblRDVNonEchu.HelpContextID = 0;
      resources.ApplyResources(this.lblRDVNonEchu, "lblRDVNonEchu");
      this.lblRDVNonEchu.Name = "lblRDVNonEchu";
      // 
      // lblFinDeContrat
      // 
      this.lblFinDeContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lblFinDeContrat.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblFinDeContrat.HelpContextID = 0;
      resources.ApplyResources(this.lblFinDeContrat, "lblFinDeContrat");
      this.lblFinDeContrat.Name = "lblFinDeContrat";
      // 
      // lblOffreComActive
      // 
      this.lblOffreComActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblOffreComActive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblOffreComActive.HelpContextID = 0;
      resources.ApplyResources(this.lblOffreComActive, "lblOffreComActive");
      this.lblOffreComActive.Name = "lblOffreComActive";
      // 
      // flpButtons
      // 
      resources.ApplyResources(this.flpButtons, "flpButtons");
      this.flpButtons.Controls.Add(this.cmdAjouter);
      this.flpButtons.Controls.Add(this.cmdDetail);
      this.flpButtons.Controls.Add(this.cmdModifier);
      this.flpButtons.Controls.Add(this.cmdcarte);
      this.flpButtons.Controls.Add(this.cmdEditer);
      this.flpButtons.Controls.Add(this.cmdArchive);
      this.flpButtons.Controls.Add(this.cmdSupprimer);
      this.flpButtons.Controls.Add(this.cmdRestaurer);
      this.flpButtons.Controls.Add(this.cmdModifMasse);
      this.flpButtons.Name = "flpButtons";
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "83";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // flpFilters
      // 
      this.flpFilters.Controls.Add(this.chkOffreEnCours);
      this.flpFilters.Controls.Add(this.chkDateRelDepassee);
      this.flpFilters.Controls.Add(this.chkRdvNonEchus);
      resources.ApplyResources(this.flpFilters, "flpFilters");
      this.flpFilters.Name = "flpFilters";
      // 
      // gridListeProspects
      // 
      resources.ApplyResources(this.gridListeProspects, "gridListeProspects");
      this.gridListeProspects.Name = "gridListeProspects";
      // 
      // frmProspListe
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.flpFilters);
      this.Controls.Add(this.flpButtons);
      this.Controls.Add(this.frmLegend);
      this.Controls.Add(this.cmdLegend);
      this.Controls.Add(this.gridListeProspects);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmProspListe";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmProspListeSuivi_Load);
      this.frmLegend.ResumeLayout(false);
      this.flpButtons.ResumeLayout(false);
      this.flpFilters.ResumeLayout(false);
      this.flpFilters.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiCheckBox chkDateRelDepassee;
    private MozartUC.apiCheckBox chkOffreEnCours;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdcarte;
    private MozartUC.apiButton cmdEditer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblTitre;
    private MozartUC.apiButton cmdModifMasse;
    private UCListeProspects gridListeProspects;
    private MozartUC.apiCheckBox chkRdvNonEchus;
    private MozartUC.apiButton cmdLegend;
    private MozartUC.apiGroupBox frmLegend;
    private MozartUC.apiButton Command1;
    private MozartUC.apiLabel Label26;
    private MozartUC.apiLabel Label25;
    private MozartUC.apiLabel Label24;
    private MozartUC.apiLabel lblRDVNonEchu;
    private MozartUC.apiLabel lblFinDeContrat;
    private MozartUC.apiLabel lblOffreComActive;
    private System.Windows.Forms.FlowLayoutPanel flpButtons;
    private System.Windows.Forms.FlowLayoutPanel flpFilters;
    private MozartUC.apiButton cmdRestaurer;
  }
}
