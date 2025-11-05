namespace MozartCS
{
  partial class frmGestIntervenants
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestIntervenants));
      this.CmdInitEnvoiFormulaire = new MozartUC.apiButton();
      this.cmdMail = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.cmdArchiver = new MozartUC.apiButton();
      this.cmdListeArchive = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.txtNom = new MozartUC.apiTextBox();
      this.txtFonction = new MozartUC.apiTextBox();
      this.txtPrenom = new MozartUC.apiTextBox();
      this.cboCiv = new System.Windows.Forms.ComboBox();
      this.lblLabels20 = new MozartUC.apiLabel();
      this.lblLabels24 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label53 = new MozartUC.apiLabel();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.txtMail = new MozartUC.apiTextBox();
      this.txtPort = new MozartUC.apiTextBox();
      this.txtTel = new MozartUC.apiTextBox();
      this.txtFax = new MozartUC.apiTextBox();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Frame10 = new MozartUC.apiGroupBox();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblDateEnvoiFormulaire = new MozartUC.apiLabel();
      this.lblDateReceptionFormulaire = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.Frame7.SuspendLayout();
      this.Frame10.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdInitEnvoiFormulaire
      // 
      resources.ApplyResources(this.CmdInitEnvoiFormulaire, "CmdInitEnvoiFormulaire");
      this.CmdInitEnvoiFormulaire.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdInitEnvoiFormulaire.HelpContextID = 448;
      this.CmdInitEnvoiFormulaire.Name = "CmdInitEnvoiFormulaire";
      this.CmdInitEnvoiFormulaire.Tag = "29";
      this.CmdInitEnvoiFormulaire.UseVisualStyleBackColor = true;
      this.CmdInitEnvoiFormulaire.Click += new System.EventHandler(this.CmdInitEnvoiFormulaire_Click);
      // 
      // cmdMail
      // 
      resources.ApplyResources(this.cmdMail, "cmdMail");
      this.cmdMail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdMail.HelpContextID = 448;
      this.cmdMail.Name = "cmdMail";
      this.cmdMail.Tag = "29";
      this.cmdMail.UseVisualStyleBackColor = true;
      this.cmdMail.Click += new System.EventHandler(this.cmdMail_Click);
      // 
      // apiGrid
      // 
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.Name = "apiGrid";
      this.apiGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiGrid_SelectionChanged);
      // 
      // cmdArchiver
      // 
      this.cmdArchiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
      this.cmdArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchiver.HelpContextID = 0;
      this.cmdArchiver.Name = "cmdArchiver";
      this.cmdArchiver.Tag = "27";
      this.cmdArchiver.UseVisualStyleBackColor = false;
      this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
      // 
      // cmdListeArchive
      // 
      this.cmdListeArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdListeArchive, "cmdListeArchive");
      this.cmdListeArchive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeArchive.HelpContextID = 0;
      this.cmdListeArchive.Name = "cmdListeArchive";
      this.cmdListeArchive.UseVisualStyleBackColor = false;
      this.cmdListeArchive.Click += new System.EventHandler(this.cmdListeArchive_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // txtNom
      // 
      this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNom, "txtNom");
      this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNom.HelpContextID = 0;
      this.txtNom.Name = "txtNom";
      // 
      // txtFonction
      // 
      this.txtFonction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFonction, "txtFonction");
      this.txtFonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFonction.HelpContextID = 0;
      this.txtFonction.Name = "txtFonction";
      // 
      // txtPrenom
      // 
      resources.ApplyResources(this.txtPrenom, "txtPrenom");
      this.txtPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtPrenom.HelpContextID = 0;
      this.txtPrenom.Name = "txtPrenom";
      // 
      // cboCiv
      // 
      this.cboCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCiv, "cboCiv");
      this.cboCiv.Items.AddRange(new object[] {
            resources.GetString("cboCiv.Items"),
            resources.GetString("cboCiv.Items1"),
            resources.GetString("cboCiv.Items2")});
      this.cboCiv.Name = "cboCiv";
      // 
      // lblLabels20
      // 
      resources.ApplyResources(this.lblLabels20, "lblLabels20");
      this.lblLabels20.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels20.HelpContextID = 0;
      this.lblLabels20.Name = "lblLabels20";
      // 
      // lblLabels24
      // 
      resources.ApplyResources(this.lblLabels24, "lblLabels24");
      this.lblLabels24.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels24.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels24.HelpContextID = 0;
      this.lblLabels24.Name = "lblLabels24";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label53
      // 
      resources.ApplyResources(this.Label53, "Label53");
      this.Label53.BackColor = System.Drawing.Color.Wheat;
      this.Label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label53.HelpContextID = 0;
      this.Label53.Name = "Label53";
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.Wheat;
      this.Frame7.Controls.Add(this.txtNom);
      this.Frame7.Controls.Add(this.txtFonction);
      this.Frame7.Controls.Add(this.txtPrenom);
      this.Frame7.Controls.Add(this.cboCiv);
      this.Frame7.Controls.Add(this.lblLabels20);
      this.Frame7.Controls.Add(this.lblLabels24);
      this.Frame7.Controls.Add(this.Label2);
      this.Frame7.Controls.Add(this.Label53);
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // txtMail
      // 
      this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtMail, "txtMail");
      this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtMail.HelpContextID = 0;
      this.txtMail.Name = "txtMail";
      this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
      // 
      // txtPort
      // 
      this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtPort, "txtPort");
      this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtPort.HelpContextID = 0;
      this.txtPort.Name = "txtPort";
      // 
      // txtTel
      // 
      this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTel, "txtTel");
      this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTel.HelpContextID = 0;
      this.txtTel.Name = "txtTel";
      // 
      // txtFax
      // 
      this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFax, "txtFax");
      this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFax.HelpContextID = 0;
      this.txtFax.Name = "txtFax";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels8
      // 
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // Frame10
      // 
      this.Frame10.BackColor = System.Drawing.Color.Wheat;
      this.Frame10.Controls.Add(this.txtMail);
      this.Frame10.Controls.Add(this.txtPort);
      this.Frame10.Controls.Add(this.txtTel);
      this.Frame10.Controls.Add(this.txtFax);
      this.Frame10.Controls.Add(this.lblLabels5);
      this.Frame10.Controls.Add(this.lblLabels8);
      this.Frame10.Controls.Add(this.lblLabels1);
      this.Frame10.Controls.Add(this.lblLabels0);
      resources.ApplyResources(this.Frame10, "Frame10");
      this.Frame10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame10.HelpContextID = 0;
      this.Frame10.Name = "Frame10";
      this.Frame10.TabStop = false;
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Frame7);
      this.Frame1.Controls.Add(this.Frame10);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.Frame1.HelpContextID = 0;
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // lblDateEnvoiFormulaire
      // 
      resources.ApplyResources(this.lblDateEnvoiFormulaire, "lblDateEnvoiFormulaire");
      this.lblDateEnvoiFormulaire.BackColor = System.Drawing.Color.Wheat;
      this.lblDateEnvoiFormulaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblDateEnvoiFormulaire.HelpContextID = 0;
      this.lblDateEnvoiFormulaire.Name = "lblDateEnvoiFormulaire";
      // 
      // lblDateReceptionFormulaire
      // 
      resources.ApplyResources(this.lblDateReceptionFormulaire, "lblDateReceptionFormulaire");
      this.lblDateReceptionFormulaire.BackColor = System.Drawing.Color.Wheat;
      this.lblDateReceptionFormulaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblDateReceptionFormulaire.HelpContextID = 0;
      this.lblDateReceptionFormulaire.Name = "lblDateReceptionFormulaire";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTitre
      // 
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmGestIntervenants
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdInitEnvoiFormulaire);
      this.Controls.Add(this.cmdMail);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.cmdListeArchive);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblDateEnvoiFormulaire);
      this.Controls.Add(this.lblDateReceptionFormulaire);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestIntervenants";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestIntervenants_Load);
      this.Frame7.ResumeLayout(false);
      this.Frame7.PerformLayout();
      this.Frame10.ResumeLayout(false);
      this.Frame10.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdInitEnvoiFormulaire;
    private MozartUC.apiButton cmdMail;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton cmdListeArchive;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiTextBox txtNom;
    private MozartUC.apiTextBox txtFonction;
    private MozartUC.apiTextBox txtPrenom;
    private System.Windows.Forms.ComboBox cboCiv;
    private MozartUC.apiLabel lblLabels20;
    private MozartUC.apiLabel lblLabels24;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label53;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiTextBox txtMail;
    private MozartUC.apiTextBox txtPort;
    private MozartUC.apiTextBox txtTel;
    private MozartUC.apiTextBox txtFax;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame10;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblDateEnvoiFormulaire;
    private MozartUC.apiLabel lblDateReceptionFormulaire;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lblTitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
