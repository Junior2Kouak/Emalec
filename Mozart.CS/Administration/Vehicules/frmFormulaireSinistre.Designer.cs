namespace MozartCS
{
  partial class frmFormulaireSinistre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulaireSinistre));
			this.panelRevision = new System.Windows.Forms.Panel();
			this.txtGarage = new MozartUC.apiTextBox();
			this.cboStatut = new System.Windows.Forms.ComboBox();
			this.apiLabel3 = new MozartUC.apiLabel();
			this.cboSociete = new System.Windows.Forms.ComboBox();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.cmdAnnulerRev = new MozartUC.apiButton();
			this.cboEmploye = new System.Windows.Forms.ComboBox();
			this.cmdValiderRev = new MozartUC.apiButton();
			this.apiLabel34 = new MozartUC.apiLabel();
			this.apiLabel8 = new MozartUC.apiLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboDoc = new System.Windows.Forms.ComboBox();
			this.apiLabel9 = new MozartUC.apiLabel();
			this.cboResponsabilite = new System.Windows.Forms.ComboBox();
			this.apiLabel10 = new MozartUC.apiLabel();
			this.apiLabel11 = new MozartUC.apiLabel();
			this.apiLabel12 = new MozartUC.apiLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.apiLabel13 = new MozartUC.apiLabel();
			this.apiLabel14 = new MozartUC.apiLabel();
			this.cboAgree = new System.Windows.Forms.ComboBox();
			this.apiLabel15 = new MozartUC.apiLabel();
			this.apiLabel16 = new MozartUC.apiLabel();
			this.txtNumDossier = new MozartUC.apiTextBox();
			this.cboTiers = new System.Windows.Forms.ComboBox();
			this.apiLabel17 = new MozartUC.apiLabel();
			this.cboFranchise = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.apiLabel6 = new MozartUC.apiLabel();
			this.apiLabel7 = new MozartUC.apiLabel();
			this.apiLabel18 = new MozartUC.apiLabel();
			this.txtMontantEmalec = new DevExpress.XtraEditors.TextEdit();
			this.txtTotal = new DevExpress.XtraEditors.TextEdit();
			this.txtMontantAssurance = new DevExpress.XtraEditors.TextEdit();
			this.cmdFichier = new MozartUC.apiButton();
			this.txtObservations = new MozartUC.apiTextBox();
			this.txtDateSinistre = new DevExpress.XtraEditors.DateEdit();
			this.txtDateExpertise = new DevExpress.XtraEditors.DateEdit();
			this.panelRevision.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMontantEmalec.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMontantAssurance.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateSinistre.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateSinistre.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateExpertise.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateExpertise.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRevision
			// 
			this.panelRevision.BackColor = System.Drawing.Color.BurlyWood;
			this.panelRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRevision.Controls.Add(this.txtDateSinistre);
			this.panelRevision.Controls.Add(this.cboSociete);
			this.panelRevision.Controls.Add(this.apiLabel2);
			this.panelRevision.Controls.Add(this.cboEmploye);
			this.panelRevision.Controls.Add(this.apiLabel34);
			this.panelRevision.Controls.Add(this.apiLabel1);
			this.panelRevision.Controls.Add(this.cboStatut);
			this.panelRevision.Controls.Add(this.apiLabel3);
			resources.ApplyResources(this.panelRevision, "panelRevision");
			this.panelRevision.Name = "panelRevision";
			// 
			// txtGarage
			// 
			this.txtGarage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtGarage, "txtGarage");
			this.txtGarage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtGarage.HelpContextID = 0;
			this.txtGarage.Name = "txtGarage";
			// 
			// cboStatut
			// 
			this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboStatut, "cboStatut");
			this.cboStatut.Items.AddRange(new object[] {
            resources.GetString("cboStatut.Items"),
            resources.GetString("cboStatut.Items1")});
			this.cboStatut.Name = "cboStatut";
			// 
			// apiLabel3
			// 
			resources.ApplyResources(this.apiLabel3, "apiLabel3");
			this.apiLabel3.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel3.HelpContextID = 0;
			this.apiLabel3.Name = "apiLabel3";
			// 
			// cboSociete
			// 
			this.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboSociete, "cboSociete");
			this.cboSociete.Items.AddRange(new object[] {
            resources.GetString("cboSociete.Items"),
            resources.GetString("cboSociete.Items1")});
			this.cboSociete.Name = "cboSociete";
			this.cboSociete.Tag = "44";
			this.cboSociete.SelectionChangeCommitted += new System.EventHandler(this.cboSociete_SelectionChangeCommitted);
			// 
			// apiLabel2
			// 
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel2.HelpContextID = 0;
			this.apiLabel2.Name = "apiLabel2";
			// 
			// apiLabel1
			// 
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
			// 
			// cmdAnnulerRev
			// 
			resources.ApplyResources(this.cmdAnnulerRev, "cmdAnnulerRev");
			this.cmdAnnulerRev.HelpContextID = 0;
			this.cmdAnnulerRev.Name = "cmdAnnulerRev";
			this.cmdAnnulerRev.Tag = "66";
			this.cmdAnnulerRev.UseVisualStyleBackColor = true;
			this.cmdAnnulerRev.Click += new System.EventHandler(this.cmdAnnulerRev_Click);
			// 
			// cboEmploye
			// 
			this.cboEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboEmploye, "cboEmploye");
			this.cboEmploye.Items.AddRange(new object[] {
            resources.GetString("cboEmploye.Items"),
            resources.GetString("cboEmploye.Items1"),
            resources.GetString("cboEmploye.Items2")});
			this.cboEmploye.Name = "cboEmploye";
			// 
			// cmdValiderRev
			// 
			resources.ApplyResources(this.cmdValiderRev, "cmdValiderRev");
			this.cmdValiderRev.HelpContextID = 0;
			this.cmdValiderRev.Name = "cmdValiderRev";
			this.cmdValiderRev.Tag = "66";
			this.cmdValiderRev.UseVisualStyleBackColor = true;
			this.cmdValiderRev.Click += new System.EventHandler(this.cmdValiderRev_Click);
			// 
			// apiLabel34
			// 
			resources.ApplyResources(this.apiLabel34, "apiLabel34");
			this.apiLabel34.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel34.HelpContextID = 0;
			this.apiLabel34.Name = "apiLabel34";
			// 
			// apiLabel8
			// 
			resources.ApplyResources(this.apiLabel8, "apiLabel8");
			this.apiLabel8.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel8.HelpContextID = 0;
			this.apiLabel8.Name = "apiLabel8";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BurlyWood;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cboFranchise);
			this.panel1.Controls.Add(this.cboTiers);
			this.panel1.Controls.Add(this.apiLabel17);
			this.panel1.Controls.Add(this.txtNumDossier);
			this.panel1.Controls.Add(this.cboDoc);
			this.panel1.Controls.Add(this.apiLabel9);
			this.panel1.Controls.Add(this.cboResponsabilite);
			this.panel1.Controls.Add(this.apiLabel10);
			this.panel1.Controls.Add(this.apiLabel11);
			this.panel1.Controls.Add(this.apiLabel12);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// cboDoc
			// 
			this.cboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboDoc, "cboDoc");
			this.cboDoc.Items.AddRange(new object[] {
            resources.GetString("cboDoc.Items"),
            resources.GetString("cboDoc.Items1"),
            resources.GetString("cboDoc.Items2")});
			this.cboDoc.Name = "cboDoc";
			// 
			// apiLabel9
			// 
			resources.ApplyResources(this.apiLabel9, "apiLabel9");
			this.apiLabel9.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel9.HelpContextID = 0;
			this.apiLabel9.Name = "apiLabel9";
			// 
			// cboResponsabilite
			// 
			this.cboResponsabilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboResponsabilite, "cboResponsabilite");
			this.cboResponsabilite.Items.AddRange(new object[] {
            resources.GetString("cboResponsabilite.Items"),
            resources.GetString("cboResponsabilite.Items1"),
            resources.GetString("cboResponsabilite.Items2"),
            resources.GetString("cboResponsabilite.Items3")});
			this.cboResponsabilite.Name = "cboResponsabilite";
			this.cboResponsabilite.Tag = "44";
			// 
			// apiLabel10
			// 
			resources.ApplyResources(this.apiLabel10, "apiLabel10");
			this.apiLabel10.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel10.HelpContextID = 0;
			this.apiLabel10.Name = "apiLabel10";
			// 
			// apiLabel11
			// 
			resources.ApplyResources(this.apiLabel11, "apiLabel11");
			this.apiLabel11.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel11.HelpContextID = 0;
			this.apiLabel11.Name = "apiLabel11";
			// 
			// apiLabel12
			// 
			resources.ApplyResources(this.apiLabel12, "apiLabel12");
			this.apiLabel12.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel12.HelpContextID = 0;
			this.apiLabel12.Name = "apiLabel12";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.BurlyWood;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtDateExpertise);
			this.panel2.Controls.Add(this.txtObservations);
			this.panel2.Controls.Add(this.apiLabel13);
			this.panel2.Controls.Add(this.apiLabel14);
			this.panel2.Controls.Add(this.cboAgree);
			this.panel2.Controls.Add(this.txtGarage);
			this.panel2.Controls.Add(this.apiLabel15);
			this.panel2.Controls.Add(this.apiLabel16);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// apiLabel13
			// 
			resources.ApplyResources(this.apiLabel13, "apiLabel13");
			this.apiLabel13.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel13.HelpContextID = 0;
			this.apiLabel13.Name = "apiLabel13";
			// 
			// apiLabel14
			// 
			resources.ApplyResources(this.apiLabel14, "apiLabel14");
			this.apiLabel14.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel14.HelpContextID = 0;
			this.apiLabel14.Name = "apiLabel14";
			// 
			// cboAgree
			// 
			this.cboAgree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboAgree, "cboAgree");
			this.cboAgree.Items.AddRange(new object[] {
            resources.GetString("cboAgree.Items"),
            resources.GetString("cboAgree.Items1")});
			this.cboAgree.Name = "cboAgree";
			// 
			// apiLabel15
			// 
			resources.ApplyResources(this.apiLabel15, "apiLabel15");
			this.apiLabel15.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel15.HelpContextID = 0;
			this.apiLabel15.Name = "apiLabel15";
			// 
			// apiLabel16
			// 
			resources.ApplyResources(this.apiLabel16, "apiLabel16");
			this.apiLabel16.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel16.HelpContextID = 0;
			this.apiLabel16.Name = "apiLabel16";
			// 
			// txtNumDossier
			// 
			this.txtNumDossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtNumDossier, "txtNumDossier");
			this.txtNumDossier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtNumDossier.HelpContextID = 0;
			this.txtNumDossier.Name = "txtNumDossier";
			// 
			// cboTiers
			// 
			this.cboTiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboTiers, "cboTiers");
			this.cboTiers.Items.AddRange(new object[] {
            resources.GetString("cboTiers.Items"),
            resources.GetString("cboTiers.Items1")});
			this.cboTiers.Name = "cboTiers";
			// 
			// apiLabel17
			// 
			resources.ApplyResources(this.apiLabel17, "apiLabel17");
			this.apiLabel17.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel17.HelpContextID = 0;
			this.apiLabel17.Name = "apiLabel17";
			// 
			// cboFranchise
			// 
			this.cboFranchise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboFranchise, "cboFranchise");
			this.cboFranchise.Items.AddRange(new object[] {
            resources.GetString("cboFranchise.Items"),
            resources.GetString("cboFranchise.Items1")});
			this.cboFranchise.Name = "cboFranchise";
			this.cboFranchise.SelectionChangeCommitted += new System.EventHandler(this.cboFranchise_SelectionChangeCommitted);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.BurlyWood;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.txtMontantAssurance);
			this.panel3.Controls.Add(this.txtTotal);
			this.panel3.Controls.Add(this.txtMontantEmalec);
			this.panel3.Controls.Add(this.apiLabel6);
			this.panel3.Controls.Add(this.apiLabel7);
			this.panel3.Controls.Add(this.apiLabel18);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// apiLabel6
			// 
			resources.ApplyResources(this.apiLabel6, "apiLabel6");
			this.apiLabel6.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel6.HelpContextID = 0;
			this.apiLabel6.Name = "apiLabel6";
			// 
			// apiLabel7
			// 
			resources.ApplyResources(this.apiLabel7, "apiLabel7");
			this.apiLabel7.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel7.HelpContextID = 0;
			this.apiLabel7.Name = "apiLabel7";
			// 
			// apiLabel18
			// 
			resources.ApplyResources(this.apiLabel18, "apiLabel18");
			this.apiLabel18.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel18.HelpContextID = 0;
			this.apiLabel18.Name = "apiLabel18";
			// 
			// txtMontantEmalec
			// 
			resources.ApplyResources(this.txtMontantEmalec, "txtMontantEmalec");
			this.txtMontantEmalec.Name = "txtMontantEmalec";
			this.txtMontantEmalec.Properties.Appearance.Options.UseTextOptions = true;
			this.txtMontantEmalec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtMontantEmalec.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtMontantEmalec.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtKMini.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtMontantEmalec.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtMontantEmalec.Properties.MaskSettings.Set("mask", "c");
			// 
			// txtTotal
			// 
			resources.ApplyResources(this.txtTotal, "txtTotal");
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
			this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("textEdit1.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTotal.Properties.MaskSettings.Set("mask", "c");
			// 
			// txtMontantAssurance
			// 
			resources.ApplyResources(this.txtMontantAssurance, "txtMontantAssurance");
			this.txtMontantAssurance.Name = "txtMontantAssurance";
			this.txtMontantAssurance.Properties.Appearance.Options.UseTextOptions = true;
			this.txtMontantAssurance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtMontantAssurance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtMontantAssurance.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("textEdit2.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtMontantAssurance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtMontantAssurance.Properties.MaskSettings.Set("mask", "c");
			this.txtMontantAssurance.TextChanged += new System.EventHandler(this.txtMontantAssurance_TextChanged);
			// 
			// cmdFichier
			// 
			resources.ApplyResources(this.cmdFichier, "cmdFichier");
			this.cmdFichier.HelpContextID = 0;
			this.cmdFichier.Name = "cmdFichier";
			this.cmdFichier.Tag = "66";
			this.cmdFichier.UseVisualStyleBackColor = true;
			this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
			// 
			// txtObservations
			// 
			this.txtObservations.AcceptsReturn = true;
			this.txtObservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtObservations, "txtObservations");
			this.txtObservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtObservations.HelpContextID = 0;
			this.txtObservations.Name = "txtObservations";
			// 
			// txtDateSinistre
			// 
			resources.ApplyResources(this.txtDateSinistre, "txtDateSinistre");
			this.txtDateSinistre.Name = "txtDateSinistre";
			this.txtDateSinistre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateSinistre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateEntre.Properties.Buttons"))))});
			this.txtDateSinistre.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateEntre.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// txtDateExpertise
			// 
			resources.ApplyResources(this.txtDateExpertise, "txtDateExpertise");
			this.txtDateExpertise.Name = "txtDateExpertise";
			this.txtDateExpertise.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateExpertise.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateEntre.Properties.Buttons1"))))});
			this.txtDateExpertise.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateEntre.Properties.CalendarTimeProperties.Buttons1"))))});
			// 
			// frmFormulaireSinistre
			// 
			this.BackColor = System.Drawing.Color.BurlyWood;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdFichier);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.apiLabel8);
			this.Controls.Add(this.panelRevision);
			this.Controls.Add(this.cmdValiderRev);
			this.Controls.Add(this.cmdAnnulerRev);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFormulaireSinistre";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmDetailFormulaires_Load);
			this.panelRevision.ResumeLayout(false);
			this.panelRevision.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtMontantEmalec.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMontantAssurance.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateSinistre.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateSinistre.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateExpertise.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateExpertise.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

		#endregion

		private System.Windows.Forms.Panel panelRevision;
		private MozartUC.apiButton cmdAnnulerRev;
		private System.Windows.Forms.ComboBox cboEmploye;
		private MozartUC.apiButton cmdValiderRev;
		private MozartUC.apiLabel apiLabel34;
		private MozartUC.apiLabel apiLabel1;
		private System.Windows.Forms.ComboBox cboSociete;
		private MozartUC.apiLabel apiLabel2;
		private System.Windows.Forms.ComboBox cboStatut;
		private MozartUC.apiLabel apiLabel3;
		private MozartUC.apiTextBox txtGarage;
		private MozartUC.apiLabel apiLabel8;
		private System.Windows.Forms.Panel panel1;
		private MozartUC.apiTextBox txtNumDossier;
		private System.Windows.Forms.ComboBox cboDoc;
		private MozartUC.apiLabel apiLabel9;
		private System.Windows.Forms.ComboBox cboResponsabilite;
		private MozartUC.apiLabel apiLabel10;
		private MozartUC.apiLabel apiLabel11;
		private MozartUC.apiLabel apiLabel12;
		private System.Windows.Forms.Panel panel2;
		private MozartUC.apiLabel apiLabel13;
		private MozartUC.apiLabel apiLabel14;
		private System.Windows.Forms.ComboBox cboAgree;
		private MozartUC.apiLabel apiLabel15;
		private MozartUC.apiLabel apiLabel16;
		private System.Windows.Forms.ComboBox cboFranchise;
		private System.Windows.Forms.ComboBox cboTiers;
		private MozartUC.apiLabel apiLabel17;
		private System.Windows.Forms.Panel panel3;
		private MozartUC.apiLabel apiLabel6;
		private MozartUC.apiLabel apiLabel7;
		private MozartUC.apiLabel apiLabel18;
		private DevExpress.XtraEditors.TextEdit txtMontantAssurance;
		private DevExpress.XtraEditors.TextEdit txtTotal;
		private DevExpress.XtraEditors.TextEdit txtMontantEmalec;
		private MozartUC.apiButton cmdFichier;
		private MozartUC.apiTextBox txtObservations;
		private DevExpress.XtraEditors.DateEdit txtDateSinistre;
		private DevExpress.XtraEditors.DateEdit txtDateExpertise;
	}
}
