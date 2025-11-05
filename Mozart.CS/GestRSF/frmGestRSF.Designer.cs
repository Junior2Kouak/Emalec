namespace MozartCS
{
  partial class frmGestRSF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestRSF));
      this.cmdValiderModifs = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdAnnulerAjout = new MozartUC.apiButton();
      this.cboRsfFin = new System.Windows.Forms.ComboBox();
      this.txtRsfSup = new MozartUC.apiTextBox();
      this.cboRsfNbj = new System.Windows.Forms.ComboBox();
      this.cboRsfTyp = new System.Windows.Forms.ComboBox();
      this.txtSiret = new MozartUC.apiTextBox();
      this.txtTVA = new MozartUC.apiTextBox();
      this.Label518 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label516 = new MozartUC.apiLabel();
      this.Label515 = new MozartUC.apiLabel();
      this.lblSIRET = new MozartUC.apiLabel();
      this.label20 = new MozartUC.apiLabel();
      this.fraReglement = new MozartUC.apiGroupBox();
      this.txtMail = new MozartUC.apiTextBox();
      this.txtNom = new MozartUC.apiTextBox();
      this.txtService = new MozartUC.apiTextBox();
      this.chkActif = new MozartUC.apiCheckBox();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.Label517 = new MozartUC.apiLabel();
      this.Label55 = new MozartUC.apiLabel();
      this.fraContact = new MozartUC.apiGroupBox();
      this.apiFilEMALEC = new MozartUC.apiCheckBox();
      this.cmdAide = new MozartUC.apiButton();
      this.cboLangue = new System.Windows.Forms.ComboBox();
      this.cboLangueAbrev = new System.Windows.Forms.ComboBox();
      this.cboVille = new System.Windows.Forms.ComboBox();
      this.cboPays = new System.Windows.Forms.ComboBox();
      this.txtVille = new MozartUC.apiTextBox();
      this.cmdRecherche = new MozartUC.apiButton();
      this.txtCP = new MozartUC.apiTextBox();
      this.txtAD2 = new MozartUC.apiTextBox();
      this.txtAD1 = new MozartUC.apiTextBox();
      this.txtRegion = new MozartUC.apiTextBox();
      this.Label53 = new MozartUC.apiLabel();
      this.Label521 = new MozartUC.apiLabel();
      this.Label513 = new MozartUC.apiLabel();
      this.Label512 = new MozartUC.apiLabel();
      this.Label50 = new MozartUC.apiLabel();
      this.Label51 = new MozartUC.apiLabel();
      this.fraAdresse = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame0 = new MozartUC.apiGroupBox();
      this.apiGroupBox2 = new MozartUC.apiGroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cboBanque = new System.Windows.Forms.ComboBox();
      this.txtCompteCompta = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.frameTVAIntra = new MozartUC.apiGroupBox();
      this.ucGridTvaIntra = new MozartControls.UCGridTva();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.fraReglement.SuspendLayout();
      this.fraContact.SuspendLayout();
      this.fraAdresse.SuspendLayout();
      this.Frame0.SuspendLayout();
      this.apiGroupBox2.SuspendLayout();
      this.frameTVAIntra.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdValiderModifs
      // 
      resources.ApplyResources(this.cmdValiderModifs, "cmdValiderModifs");
      this.cmdValiderModifs.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValiderModifs.HelpContextID = 461;
      this.cmdValiderModifs.Name = "cmdValiderModifs";
      this.cmdValiderModifs.Tag = "Valider modifications";
      this.cmdValiderModifs.UseVisualStyleBackColor = true;
      this.cmdValiderModifs.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "Valider ajout";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdAnnulerAjout
      // 
      resources.ApplyResources(this.cmdAnnulerAjout, "cmdAnnulerAjout");
      this.cmdAnnulerAjout.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAnnulerAjout.HelpContextID = 0;
      this.cmdAnnulerAjout.Name = "cmdAnnulerAjout";
      this.cmdAnnulerAjout.Tag = "Annuler ajout";
      this.cmdAnnulerAjout.UseVisualStyleBackColor = true;
      this.cmdAnnulerAjout.Click += new System.EventHandler(this.cmdAnnulerAjout_Click);
      // 
      // cboRsfFin
      // 
      this.cboRsfFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboRsfFin, "cboRsfFin");
      this.cboRsfFin.Name = "cboRsfFin";
      // 
      // txtRsfSup
      // 
      resources.ApplyResources(this.txtRsfSup, "txtRsfSup");
      this.txtRsfSup.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtRsfSup.HelpContextID = 0;
      this.txtRsfSup.Name = "txtRsfSup";
      // 
      // cboRsfNbj
      // 
      this.cboRsfNbj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboRsfNbj, "cboRsfNbj");
      this.cboRsfNbj.Name = "cboRsfNbj";
      // 
      // cboRsfTyp
      // 
      this.cboRsfTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboRsfTyp, "cboRsfTyp");
      this.cboRsfTyp.Name = "cboRsfTyp";
      // 
      // txtSiret
      // 
      this.txtSiret.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtSiret.HelpContextID = 0;
      resources.ApplyResources(this.txtSiret, "txtSiret");
      this.txtSiret.Name = "txtSiret";
      // 
      // txtTVA
      // 
      this.txtTVA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtTVA.HelpContextID = 0;
      resources.ApplyResources(this.txtTVA, "txtTVA");
      this.txtTVA.Name = "txtTVA";
      // 
      // Label518
      // 
      resources.ApplyResources(this.Label518, "Label518");
      this.Label518.BackColor = System.Drawing.Color.Wheat;
      this.Label518.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label518.HelpContextID = 0;
      this.Label518.Name = "Label518";
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.BackColor = System.Drawing.Color.Wheat;
      this.Label7.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label6
      // 
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.BackColor = System.Drawing.Color.Wheat;
      this.Label6.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // Label516
      // 
      resources.ApplyResources(this.Label516, "Label516");
      this.Label516.BackColor = System.Drawing.Color.Wheat;
      this.Label516.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label516.HelpContextID = 0;
      this.Label516.Name = "Label516";
      // 
      // Label515
      // 
      resources.ApplyResources(this.Label515, "Label515");
      this.Label515.BackColor = System.Drawing.Color.Wheat;
      this.Label515.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label515.HelpContextID = 0;
      this.Label515.Name = "Label515";
      // 
      // lblSIRET
      // 
      this.lblSIRET.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblSIRET, "lblSIRET");
      this.lblSIRET.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblSIRET.HelpContextID = 0;
      this.lblSIRET.Name = "lblSIRET";
      // 
      // label20
      // 
      resources.ApplyResources(this.label20, "label20");
      this.label20.BackColor = System.Drawing.Color.Wheat;
      this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label20.HelpContextID = 0;
      this.label20.Name = "label20";
      // 
      // fraReglement
      // 
      this.fraReglement.BackColor = System.Drawing.Color.Wheat;
      this.fraReglement.Controls.Add(this.cboRsfFin);
      this.fraReglement.Controls.Add(this.txtRsfSup);
      this.fraReglement.Controls.Add(this.cboRsfNbj);
      this.fraReglement.Controls.Add(this.cboRsfTyp);
      this.fraReglement.Controls.Add(this.Label518);
      this.fraReglement.Controls.Add(this.Label7);
      this.fraReglement.Controls.Add(this.Label6);
      this.fraReglement.Controls.Add(this.Label516);
      this.fraReglement.Controls.Add(this.Label515);
      resources.ApplyResources(this.fraReglement, "fraReglement");
      this.fraReglement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.fraReglement.FrameColor = System.Drawing.Color.Empty;
      this.fraReglement.HelpContextID = 0;
      this.fraReglement.Name = "fraReglement";
      this.fraReglement.TabStop = false;
      // 
      // txtMail
      // 
      this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtMail, "txtMail");
      this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtMail.HelpContextID = 0;
      this.txtMail.Name = "txtMail";
      // 
      // txtNom
      // 
      resources.ApplyResources(this.txtNom, "txtNom");
      this.txtNom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtNom.HelpContextID = 0;
      this.txtNom.Name = "txtNom";
      // 
      // txtService
      // 
      resources.ApplyResources(this.txtService, "txtService");
      this.txtService.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtService.HelpContextID = 0;
      this.txtService.Name = "txtService";
      // 
      // chkActif
      // 
      this.chkActif.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkActif, "chkActif");
      this.chkActif.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkActif.HelpContextID = 0;
      this.chkActif.Name = "chkActif";
      this.chkActif.UseVisualStyleBackColor = false;
      // 
      // lblLabels8
      // 
      this.lblLabels8.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // Label517
      // 
      resources.ApplyResources(this.Label517, "Label517");
      this.Label517.BackColor = System.Drawing.Color.Wheat;
      this.Label517.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label517.HelpContextID = 0;
      this.Label517.Name = "Label517";
      // 
      // Label55
      // 
      resources.ApplyResources(this.Label55, "Label55");
      this.Label55.BackColor = System.Drawing.Color.Wheat;
      this.Label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label55.HelpContextID = 0;
      this.Label55.Name = "Label55";
      // 
      // fraContact
      // 
      this.fraContact.BackColor = System.Drawing.Color.Wheat;
      this.fraContact.Controls.Add(this.apiFilEMALEC);
      this.fraContact.Controls.Add(this.txtMail);
      this.fraContact.Controls.Add(this.txtNom);
      this.fraContact.Controls.Add(this.txtService);
      this.fraContact.Controls.Add(this.chkActif);
      this.fraContact.Controls.Add(this.lblLabels8);
      this.fraContact.Controls.Add(this.Label517);
      this.fraContact.Controls.Add(this.Label55);
      resources.ApplyResources(this.fraContact, "fraContact");
      this.fraContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.fraContact.FrameColor = System.Drawing.Color.Empty;
      this.fraContact.HelpContextID = 0;
      this.fraContact.Name = "fraContact";
      this.fraContact.TabStop = false;
      // 
      // apiFilEMALEC
      // 
      this.apiFilEMALEC.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.apiFilEMALEC, "apiFilEMALEC");
      this.apiFilEMALEC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiFilEMALEC.HelpContextID = 0;
      this.apiFilEMALEC.Name = "apiFilEMALEC";
      this.apiFilEMALEC.UseVisualStyleBackColor = false;
      // 
      // cmdAide
      // 
      resources.ApplyResources(this.cmdAide, "cmdAide");
      this.cmdAide.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAide.HelpContextID = 0;
      this.cmdAide.Name = "cmdAide";
      this.cmdAide.UseVisualStyleBackColor = true;
      this.cmdAide.Click += new System.EventHandler(this.cmdAide_Click);
      // 
      // cboLangue
      // 
      this.cboLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboLangue, "cboLangue");
      this.cboLangue.Name = "cboLangue";
      this.cboLangue.Validated += new System.EventHandler(this.cboLangue_Validated);
      // 
      // cboLangueAbrev
      // 
      this.cboLangueAbrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cboLangueAbrev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboLangueAbrev, "cboLangueAbrev");
      this.cboLangueAbrev.Name = "cboLangueAbrev";
      // 
      // cboVille
      // 
      this.cboVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboVille, "cboVille");
      this.cboVille.Name = "cboVille";
      this.cboVille.Sorted = true;
      // 
      // cboPays
      // 
      this.cboPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPays, "cboPays");
      this.cboPays.Name = "cboPays";
      this.cboPays.Sorted = true;
      this.cboPays.SelectedIndexChanged += new System.EventHandler(this.cboPays_SelectedIndexChanged);
      // 
      // txtVille
      // 
      this.txtVille.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtVille.HelpContextID = 0;
      resources.ApplyResources(this.txtVille, "txtVille");
      this.txtVille.Name = "txtVille";
      this.txtVille.Leave += new System.EventHandler(this.txtVille_Leave);
      // 
      // cmdRecherche
      // 
      resources.ApplyResources(this.cmdRecherche, "cmdRecherche");
      this.cmdRecherche.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRecherche.HelpContextID = 0;
      this.cmdRecherche.Name = "cmdRecherche";
      this.cmdRecherche.UseVisualStyleBackColor = true;
      this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
      // 
      // txtCP
      // 
      resources.ApplyResources(this.txtCP, "txtCP");
      this.txtCP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCP.HelpContextID = 0;
      this.txtCP.Name = "txtCP";
      this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
      // 
      // txtAD2
      // 
      resources.ApplyResources(this.txtAD2, "txtAD2");
      this.txtAD2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAD2.HelpContextID = 0;
      this.txtAD2.Name = "txtAD2";
      // 
      // txtAD1
      // 
      resources.ApplyResources(this.txtAD1, "txtAD1");
      this.txtAD1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAD1.HelpContextID = 0;
      this.txtAD1.Name = "txtAD1";
      // 
      // txtRegion
      // 
      resources.ApplyResources(this.txtRegion, "txtRegion");
      this.txtRegion.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtRegion.HelpContextID = 0;
      this.txtRegion.Name = "txtRegion";
      // 
      // Label53
      // 
      resources.ApplyResources(this.Label53, "Label53");
      this.Label53.BackColor = System.Drawing.Color.Wheat;
      this.Label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label53.HelpContextID = 0;
      this.Label53.Name = "Label53";
      // 
      // Label521
      // 
      resources.ApplyResources(this.Label521, "Label521");
      this.Label521.BackColor = System.Drawing.Color.Wheat;
      this.Label521.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label521.HelpContextID = 0;
      this.Label521.Name = "Label521";
      // 
      // Label513
      // 
      resources.ApplyResources(this.Label513, "Label513");
      this.Label513.BackColor = System.Drawing.Color.Wheat;
      this.Label513.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label513.HelpContextID = 0;
      this.Label513.Name = "Label513";
      // 
      // Label512
      // 
      resources.ApplyResources(this.Label512, "Label512");
      this.Label512.BackColor = System.Drawing.Color.Wheat;
      this.Label512.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label512.HelpContextID = 0;
      this.Label512.Name = "Label512";
      // 
      // Label50
      // 
      resources.ApplyResources(this.Label50, "Label50");
      this.Label50.BackColor = System.Drawing.Color.Wheat;
      this.Label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label50.HelpContextID = 0;
      this.Label50.Name = "Label50";
      // 
      // Label51
      // 
      resources.ApplyResources(this.Label51, "Label51");
      this.Label51.BackColor = System.Drawing.Color.Wheat;
      this.Label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label51.HelpContextID = 0;
      this.Label51.Name = "Label51";
      // 
      // fraAdresse
      // 
      this.fraAdresse.BackColor = System.Drawing.Color.Wheat;
      this.fraAdresse.Controls.Add(this.cmdAide);
      this.fraAdresse.Controls.Add(this.cboLangue);
      this.fraAdresse.Controls.Add(this.cboLangueAbrev);
      this.fraAdresse.Controls.Add(this.cboVille);
      this.fraAdresse.Controls.Add(this.cboPays);
      this.fraAdresse.Controls.Add(this.txtVille);
      this.fraAdresse.Controls.Add(this.cmdRecherche);
      this.fraAdresse.Controls.Add(this.txtCP);
      this.fraAdresse.Controls.Add(this.txtAD2);
      this.fraAdresse.Controls.Add(this.txtAD1);
      this.fraAdresse.Controls.Add(this.txtRegion);
      this.fraAdresse.Controls.Add(this.Label53);
      this.fraAdresse.Controls.Add(this.Label521);
      this.fraAdresse.Controls.Add(this.Label513);
      this.fraAdresse.Controls.Add(this.Label512);
      this.fraAdresse.Controls.Add(this.Label50);
      this.fraAdresse.Controls.Add(this.Label51);
      resources.ApplyResources(this.fraAdresse, "fraAdresse");
      this.fraAdresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.fraAdresse.FrameColor = System.Drawing.Color.Empty;
      this.fraAdresse.HelpContextID = 0;
      this.fraAdresse.Name = "fraAdresse";
      this.fraAdresse.TabStop = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Frame0
      // 
      resources.ApplyResources(this.Frame0, "Frame0");
      this.Frame0.BackColor = System.Drawing.Color.Wheat;
      this.Frame0.Controls.Add(this.apiGroupBox2);
      this.Frame0.Controls.Add(this.frameTVAIntra);
      this.Frame0.Controls.Add(this.fraReglement);
      this.Frame0.Controls.Add(this.cmdValider);
      this.Frame0.Controls.Add(this.cmdAnnulerAjout);
      this.Frame0.Controls.Add(this.fraContact);
      this.Frame0.Controls.Add(this.fraAdresse);
      this.Frame0.Controls.Add(this.Label1);
      this.Frame0.FrameColor = System.Drawing.Color.Empty;
      this.Frame0.HelpContextID = 0;
      this.Frame0.Name = "Frame0";
      this.Frame0.TabStop = false;
      // 
      // apiGroupBox2
      // 
      resources.ApplyResources(this.apiGroupBox2, "apiGroupBox2");
      this.apiGroupBox2.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox2.Controls.Add(this.label2);
      this.apiGroupBox2.Controls.Add(this.cboBanque);
      this.apiGroupBox2.Controls.Add(this.txtCompteCompta);
      this.apiGroupBox2.Controls.Add(this.Label4);
      this.apiGroupBox2.Controls.Add(this.lblSIRET);
      this.apiGroupBox2.Controls.Add(this.txtSiret);
      this.apiGroupBox2.Controls.Add(this.txtTVA);
      this.apiGroupBox2.Controls.Add(this.label20);
      this.apiGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.apiGroupBox2.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox2.HelpContextID = 0;
      this.apiGroupBox2.Name = "apiGroupBox2";
      this.apiGroupBox2.TabStop = false;
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Name = "label2";
      // 
      // cboBanque
      // 
      this.cboBanque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboBanque, "cboBanque");
      this.cboBanque.Name = "cboBanque";
      this.cboBanque.Sorted = true;
      // 
      // txtCompteCompta
      // 
      resources.ApplyResources(this.txtCompteCompta, "txtCompteCompta");
      this.txtCompteCompta.Name = "txtCompteCompta";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.Color.Black;
      this.Label4.Name = "Label4";
      // 
      // frameTVAIntra
      // 
      this.frameTVAIntra.BackColor = System.Drawing.Color.Wheat;
      this.frameTVAIntra.Controls.Add(this.ucGridTvaIntra);
      resources.ApplyResources(this.frameTVAIntra, "frameTVAIntra");
      this.frameTVAIntra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.frameTVAIntra.FrameColor = System.Drawing.Color.Empty;
      this.frameTVAIntra.HelpContextID = 0;
      this.frameTVAIntra.Name = "frameTVAIntra";
      this.frameTVAIntra.TabStop = false;
      // 
      // ucGridTvaIntra
      // 
      resources.ApplyResources(this.ucGridTvaIntra, "ucGridTvaIntra");
      this.ucGridTvaIntra.Name = "ucGridTvaIntra";
      this.ucGridTvaIntra.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ucGridTvaIntra_RowStyle);
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGrid_SelectionChanged);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 22;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "Ajouter";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
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
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmGestRSF
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdValiderModifs);
      this.Controls.Add(this.Frame0);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestRSF";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestRSF_FormClosed);
      this.Load += new System.EventHandler(this.frmGestRSF_Load);
      this.fraReglement.ResumeLayout(false);
      this.fraReglement.PerformLayout();
      this.fraContact.ResumeLayout(false);
      this.fraContact.PerformLayout();
      this.fraAdresse.ResumeLayout(false);
      this.fraAdresse.PerformLayout();
      this.Frame0.ResumeLayout(false);
      this.Frame0.PerformLayout();
      this.apiGroupBox2.ResumeLayout(false);
      this.apiGroupBox2.PerformLayout();
      this.frameTVAIntra.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdValiderModifs;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdAnnulerAjout;
    private System.Windows.Forms.ComboBox cboRsfFin;
    private MozartUC.apiTextBox txtRsfSup;
    private System.Windows.Forms.ComboBox cboRsfNbj;
    private System.Windows.Forms.ComboBox cboRsfTyp;
    private MozartUC.apiTextBox txtSiret;
    private MozartUC.apiTextBox txtTVA;
    private MozartUC.apiLabel Label518;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label516;
    private MozartUC.apiLabel Label515;
    private MozartUC.apiLabel lblSIRET;
    private MozartUC.apiLabel label20;
    private MozartUC.apiGroupBox fraReglement;
    private MozartUC.apiTextBox txtMail;
    private MozartUC.apiTextBox txtNom;
    private MozartUC.apiTextBox txtService;
    private MozartUC.apiCheckBox chkActif;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel Label517;
    private MozartUC.apiLabel Label55;
    private MozartUC.apiGroupBox fraContact;
    private MozartUC.apiButton cmdAide;
    private System.Windows.Forms.ComboBox cboLangue;
    private System.Windows.Forms.ComboBox cboLangueAbrev;
    private System.Windows.Forms.ComboBox cboVille;
    private System.Windows.Forms.ComboBox cboPays;
    private MozartUC.apiTextBox txtVille;
    private MozartUC.apiButton cmdRecherche;
    private MozartUC.apiTextBox txtCP;
    private MozartUC.apiTextBox txtAD2;
    private MozartUC.apiTextBox txtAD1;
    private MozartUC.apiTextBox txtRegion;
    private MozartUC.apiLabel Label53;
    private MozartUC.apiLabel Label521;
    private MozartUC.apiLabel Label513;
    private MozartUC.apiLabel Label512;
    private MozartUC.apiLabel Label50;
    private MozartUC.apiLabel Label51;
    private MozartUC.apiGroupBox fraAdresse;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame0;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiGroupBox frameTVAIntra;
    private MozartUC.apiGroupBox apiGroupBox2;
    private MozartControls.UCGridTva ucGridTvaIntra;
    internal System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboBanque;
    internal System.Windows.Forms.TextBox txtCompteCompta;
    internal System.Windows.Forms.Label Label4;
    private MozartUC.apiCheckBox apiFilEMALEC;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
