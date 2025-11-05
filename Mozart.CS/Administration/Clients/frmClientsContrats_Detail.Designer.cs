namespace MozartCS
{
  partial class frmClientsContrats_Detail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientsContrats_Detail));
			this.Calendar1 = new System.Windows.Forms.DateTimePicker();
			this.CDG = new System.Windows.Forms.OpenFileDialog();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.chkNoDoc = new System.Windows.Forms.CheckBox();
			this.GLU_Contrat_Avenant = new DevExpress.XtraEditors.GridLookUpEdit();
			this.GLU_Contrat_AvenantView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
			this.GB_Client = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.BGCol_NIDCONTRATCLI_DETAIL = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_VCLINOM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_STR_LST_CAN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_STR_LST_PAYS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_STR_LST_SITES = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.GB_Contrat = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.BGCol_VPRESENCE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_DDATE_DEBUT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_DDATE_FIN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_VCONTRATCLI_TACITE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.BGCol_VNOMDOCUMENT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.CboFormuleRev = new DevExpress.XtraEditors.LookUpEdit();
			this.CboTypeDoc = new DevExpress.XtraEditors.LookUpEdit();
			this.ChkCboEditSites = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.ChkCboEditPays = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.ChkCboEditCAN = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.Txt_PC_BPU = new DevExpress.XtraEditors.TextEdit();
			this.Txt_PC_Prev = new DevExpress.XtraEditors.TextEdit();
			this.Txt_PC_Cur = new DevExpress.XtraEditors.TextEdit();
			this.BtnInfoFormule = new MozartUC.apiButton();
			this.Txt_Obs_Manu = new MozartUC.apiTextBox();
			this.apiLabel20 = new MozartUC.apiLabel();
			this.BtnObsNextAppli = new MozartUC.apiButton();
			this.TxtDateNextAppli = new MozartUC.apiTextBox();
			this.CmdSuppDateNextAppli = new MozartUC.apiButton();
			this.CmdDateNextAppli = new MozartUC.apiButton();
			this.apiLabel19 = new MozartUC.apiLabel();
			this.BtnHisto_PC_BPU = new MozartUC.apiButton();
			this.apiLabel17 = new MozartUC.apiLabel();
			this.apiLabel18 = new MozartUC.apiLabel();
			this.BtnHisto_PC_Prev = new MozartUC.apiButton();
			this.apiLabel15 = new MozartUC.apiLabel();
			this.apiLabel16 = new MozartUC.apiLabel();
			this.BtnHisto_PC_Curatif = new MozartUC.apiButton();
			this.apiLabel14 = new MozartUC.apiLabel();
			this.apiLabel13 = new MozartUC.apiLabel();
			this.BtnObsDerAppli = new MozartUC.apiButton();
			this.TxtDateDerAppli = new MozartUC.apiTextBox();
			this.CmdSuppDateDerAppli = new MozartUC.apiButton();
			this.CmdDateDerAppli = new MozartUC.apiButton();
			this.apiLabel12 = new MozartUC.apiLabel();
			this.ChkRemiseAucune = new System.Windows.Forms.CheckBox();
			this.apiLabel11 = new MozartUC.apiLabel();
			this.BtnObsRemise = new MozartUC.apiButton();
			this.apiLabel10 = new MozartUC.apiLabel();
			this.Chk_Tacite = new System.Windows.Forms.CheckBox();
			this.BtnInfoDateFin = new MozartUC.apiButton();
			this.BtnObsDoc = new MozartUC.apiButton();
			this.apiLabel9 = new MozartUC.apiLabel();
			this.apiLabel8 = new MozartUC.apiLabel();
			this.LblNbSitesSelected = new MozartUC.apiLabel();
			this.apiLabel7 = new MozartUC.apiLabel();
			this.LblNbPaysSelected = new MozartUC.apiLabel();
			this.apiLabel5 = new MozartUC.apiLabel();
			this.LblNbCptSelected = new MozartUC.apiLabel();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.txtDateFin = new MozartUC.apiTextBox();
			this.cmdSuppFin = new MozartUC.apiButton();
			this.cmdDateFin = new MozartUC.apiButton();
			this.txtDateDebut = new MozartUC.apiTextBox();
			this.cmdSuppDebut = new MozartUC.apiButton();
			this.cmdDateDebut = new MozartUC.apiButton();
			this.cmdDateDoc = new MozartUC.apiButton();
			this.cmdSuppDateDoc = new MozartUC.apiButton();
			this.txtDate_Doc = new MozartUC.apiTextBox();
			this.lblLabels11 = new MozartUC.apiLabel();
			this.lblLabels10 = new MozartUC.apiLabel();
			this.lblLabels12 = new MozartUC.apiLabel();
			this.Txt_NomDoc = new MozartUC.apiTextBox();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdEnregistrer = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.BtnAddDoc = new MozartUC.apiButton();
			this.BtnVisuDoc = new MozartUC.apiButton();
			this.BtnContratDocDel = new MozartUC.apiButton();
			this.Txt_Obs = new MozartUC.apiTextBox();
			this.apiLabel3 = new MozartUC.apiLabel();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GLU_Contrat_Avenant.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GLU_Contrat_AvenantView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CboFormuleRev.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CboTypeDoc.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditSites.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditPays.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditCAN.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_BPU.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_Prev.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_Cur.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
			this.SuspendLayout();
			// 
			// Calendar1
			// 
			this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
			this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			resources.ApplyResources(this.Calendar1, "Calendar1");
			this.Calendar1.Name = "Calendar1";
			this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
			this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
			// 
			// Frame1
			// 
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.Txt_Obs);
			this.Frame1.Controls.Add(this.apiLabel3);
			this.Frame1.Controls.Add(this.chkNoDoc);
			this.Frame1.Controls.Add(this.GLU_Contrat_Avenant);
			this.Frame1.Controls.Add(this.CboFormuleRev);
			this.Frame1.Controls.Add(this.CboTypeDoc);
			this.Frame1.Controls.Add(this.ChkCboEditSites);
			this.Frame1.Controls.Add(this.ChkCboEditPays);
			this.Frame1.Controls.Add(this.ChkCboEditCAN);
			this.Frame1.Controls.Add(this.Txt_PC_BPU);
			this.Frame1.Controls.Add(this.Txt_PC_Prev);
			this.Frame1.Controls.Add(this.Txt_PC_Cur);
			this.Frame1.Controls.Add(this.BtnInfoFormule);
			this.Frame1.Controls.Add(this.Txt_Obs_Manu);
			this.Frame1.Controls.Add(this.apiLabel20);
			this.Frame1.Controls.Add(this.BtnObsNextAppli);
			this.Frame1.Controls.Add(this.TxtDateNextAppli);
			this.Frame1.Controls.Add(this.CmdSuppDateNextAppli);
			this.Frame1.Controls.Add(this.CmdDateNextAppli);
			this.Frame1.Controls.Add(this.apiLabel19);
			this.Frame1.Controls.Add(this.BtnHisto_PC_BPU);
			this.Frame1.Controls.Add(this.apiLabel17);
			this.Frame1.Controls.Add(this.apiLabel18);
			this.Frame1.Controls.Add(this.BtnHisto_PC_Prev);
			this.Frame1.Controls.Add(this.apiLabel15);
			this.Frame1.Controls.Add(this.apiLabel16);
			this.Frame1.Controls.Add(this.BtnHisto_PC_Curatif);
			this.Frame1.Controls.Add(this.apiLabel14);
			this.Frame1.Controls.Add(this.apiLabel13);
			this.Frame1.Controls.Add(this.BtnObsDerAppli);
			this.Frame1.Controls.Add(this.TxtDateDerAppli);
			this.Frame1.Controls.Add(this.CmdSuppDateDerAppli);
			this.Frame1.Controls.Add(this.CmdDateDerAppli);
			this.Frame1.Controls.Add(this.apiLabel12);
			this.Frame1.Controls.Add(this.ChkRemiseAucune);
			this.Frame1.Controls.Add(this.apiLabel11);
			this.Frame1.Controls.Add(this.BtnObsRemise);
			this.Frame1.Controls.Add(this.apiLabel10);
			this.Frame1.Controls.Add(this.Chk_Tacite);
			this.Frame1.Controls.Add(this.BtnInfoDateFin);
			this.Frame1.Controls.Add(this.BtnObsDoc);
			this.Frame1.Controls.Add(this.apiLabel9);
			this.Frame1.Controls.Add(this.apiLabel8);
			this.Frame1.Controls.Add(this.LblNbSitesSelected);
			this.Frame1.Controls.Add(this.apiLabel7);
			this.Frame1.Controls.Add(this.LblNbPaysSelected);
			this.Frame1.Controls.Add(this.apiLabel5);
			this.Frame1.Controls.Add(this.LblNbCptSelected);
			this.Frame1.Controls.Add(this.apiLabel2);
			this.Frame1.Controls.Add(this.txtDateFin);
			this.Frame1.Controls.Add(this.cmdSuppFin);
			this.Frame1.Controls.Add(this.cmdDateFin);
			this.Frame1.Controls.Add(this.txtDateDebut);
			this.Frame1.Controls.Add(this.cmdSuppDebut);
			this.Frame1.Controls.Add(this.cmdDateDebut);
			this.Frame1.Controls.Add(this.cmdDateDoc);
			this.Frame1.Controls.Add(this.cmdSuppDateDoc);
			this.Frame1.Controls.Add(this.txtDate_Doc);
			this.Frame1.Controls.Add(this.lblLabels11);
			this.Frame1.Controls.Add(this.lblLabels10);
			this.Frame1.Controls.Add(this.lblLabels12);
			this.Frame1.Controls.Add(this.Txt_NomDoc);
			this.Frame1.Controls.Add(this.apiLabel1);
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// chkNoDoc
			// 
			resources.ApplyResources(this.chkNoDoc, "chkNoDoc");
			this.chkNoDoc.ForeColor = System.Drawing.Color.Black;
			this.chkNoDoc.Name = "chkNoDoc";
			this.chkNoDoc.UseVisualStyleBackColor = true;
			this.chkNoDoc.CheckedChanged += new System.EventHandler(this.chkNoDoc_CheckedChanged);
			// 
			// GLU_Contrat_Avenant
			// 
			resources.ApplyResources(this.GLU_Contrat_Avenant, "GLU_Contrat_Avenant");
			this.GLU_Contrat_Avenant.Name = "GLU_Contrat_Avenant";
			this.GLU_Contrat_Avenant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("GLU_Contrat_Avenant.Properties.Buttons"))))});
			this.GLU_Contrat_Avenant.Properties.DisplayMember = "VNOMDOCUMENT";
			this.GLU_Contrat_Avenant.Properties.NullText = resources.GetString("GLU_Contrat_Avenant.Properties.NullText");
			this.GLU_Contrat_Avenant.Properties.PopupView = this.GLU_Contrat_AvenantView;
			this.GLU_Contrat_Avenant.Properties.ValueMember = "NIDCONTRATCLI_DETAIL";
			this.GLU_Contrat_Avenant.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.BandedView;
			// 
			// GLU_Contrat_AvenantView
			// 
			this.GLU_Contrat_AvenantView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.GB_Client,
            this.GB_Contrat});
			this.GLU_Contrat_AvenantView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.BGCol_NIDCONTRATCLI_DETAIL,
            this.BGCol_VCLINOM,
            this.BGCol_STR_LST_CAN,
            this.BGCol_STR_LST_SITES,
            this.BGCol_STR_LST_PAYS,
            this.BGCol_VNOMDOCUMENT,
            this.BGCol_VPRESENCE,
            this.BGCol_DDATE_DEBUT,
            this.BGCol_DDATE_FIN,
            this.BGCol_VCONTRATCLI_TACITE});
			this.GLU_Contrat_AvenantView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.GLU_Contrat_AvenantView.Name = "GLU_Contrat_AvenantView";
			this.GLU_Contrat_AvenantView.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.GLU_Contrat_AvenantView.OptionsView.ShowGroupPanel = false;
			// 
			// GB_Client
			// 
			this.GB_Client.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GB_Client.AppearanceHeader.Font")));
			this.GB_Client.AppearanceHeader.Options.UseFont = true;
			this.GB_Client.AppearanceHeader.Options.UseTextOptions = true;
			this.GB_Client.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GB_Client.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			resources.ApplyResources(this.GB_Client, "GB_Client");
			this.GB_Client.Columns.Add(this.BGCol_NIDCONTRATCLI_DETAIL);
			this.GB_Client.Columns.Add(this.BGCol_VCLINOM);
			this.GB_Client.Columns.Add(this.BGCol_STR_LST_CAN);
			this.GB_Client.Columns.Add(this.BGCol_STR_LST_PAYS);
			this.GB_Client.Columns.Add(this.BGCol_STR_LST_SITES);
			this.GB_Client.VisibleIndex = 0;
			// 
			// BGCol_NIDCONTRATCLI_DETAIL
			// 
			resources.ApplyResources(this.BGCol_NIDCONTRATCLI_DETAIL, "BGCol_NIDCONTRATCLI_DETAIL");
			this.BGCol_NIDCONTRATCLI_DETAIL.FieldName = "NIDCONTRATCLI_DETAIL";
			this.BGCol_NIDCONTRATCLI_DETAIL.Name = "BGCol_NIDCONTRATCLI_DETAIL";
			// 
			// BGCol_VCLINOM
			// 
			resources.ApplyResources(this.BGCol_VCLINOM, "BGCol_VCLINOM");
			this.BGCol_VCLINOM.FieldName = "VCLINOM";
			this.BGCol_VCLINOM.Name = "BGCol_VCLINOM";
			this.BGCol_VCLINOM.OptionsColumn.AllowEdit = false;
			this.BGCol_VCLINOM.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_STR_LST_CAN
			// 
			resources.ApplyResources(this.BGCol_STR_LST_CAN, "BGCol_STR_LST_CAN");
			this.BGCol_STR_LST_CAN.FieldName = "STR_LST_CAN";
			this.BGCol_STR_LST_CAN.Name = "BGCol_STR_LST_CAN";
			this.BGCol_STR_LST_CAN.OptionsColumn.AllowEdit = false;
			this.BGCol_STR_LST_CAN.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_STR_LST_PAYS
			// 
			resources.ApplyResources(this.BGCol_STR_LST_PAYS, "BGCol_STR_LST_PAYS");
			this.BGCol_STR_LST_PAYS.FieldName = "STR_LST_PAYS";
			this.BGCol_STR_LST_PAYS.Name = "BGCol_STR_LST_PAYS";
			this.BGCol_STR_LST_PAYS.OptionsColumn.AllowEdit = false;
			this.BGCol_STR_LST_PAYS.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_STR_LST_SITES
			// 
			resources.ApplyResources(this.BGCol_STR_LST_SITES, "BGCol_STR_LST_SITES");
			this.BGCol_STR_LST_SITES.FieldName = "STR_LST_SITES";
			this.BGCol_STR_LST_SITES.Name = "BGCol_STR_LST_SITES";
			this.BGCol_STR_LST_SITES.OptionsColumn.AllowEdit = false;
			this.BGCol_STR_LST_SITES.OptionsColumn.ReadOnly = true;
			// 
			// GB_Contrat
			// 
			this.GB_Contrat.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GB_Contrat.AppearanceHeader.Font")));
			this.GB_Contrat.AppearanceHeader.Options.UseFont = true;
			this.GB_Contrat.AppearanceHeader.Options.UseTextOptions = true;
			this.GB_Contrat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GB_Contrat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GB_Contrat.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			resources.ApplyResources(this.GB_Contrat, "GB_Contrat");
			this.GB_Contrat.Columns.Add(this.BGCol_VPRESENCE);
			this.GB_Contrat.Columns.Add(this.BGCol_DDATE_DEBUT);
			this.GB_Contrat.Columns.Add(this.BGCol_DDATE_FIN);
			this.GB_Contrat.Columns.Add(this.BGCol_VCONTRATCLI_TACITE);
			this.GB_Contrat.VisibleIndex = 1;
			// 
			// BGCol_VPRESENCE
			// 
			resources.ApplyResources(this.BGCol_VPRESENCE, "BGCol_VPRESENCE");
			this.BGCol_VPRESENCE.FieldName = "VPRESENCE";
			this.BGCol_VPRESENCE.Name = "BGCol_VPRESENCE";
			this.BGCol_VPRESENCE.OptionsColumn.AllowEdit = false;
			this.BGCol_VPRESENCE.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_DDATE_DEBUT
			// 
			resources.ApplyResources(this.BGCol_DDATE_DEBUT, "BGCol_DDATE_DEBUT");
			this.BGCol_DDATE_DEBUT.FieldName = "DDATE_DEBUT";
			this.BGCol_DDATE_DEBUT.Name = "BGCol_DDATE_DEBUT";
			this.BGCol_DDATE_DEBUT.OptionsColumn.AllowEdit = false;
			this.BGCol_DDATE_DEBUT.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_DDATE_FIN
			// 
			resources.ApplyResources(this.BGCol_DDATE_FIN, "BGCol_DDATE_FIN");
			this.BGCol_DDATE_FIN.FieldName = "DDATE_FIN";
			this.BGCol_DDATE_FIN.Name = "BGCol_DDATE_FIN";
			this.BGCol_DDATE_FIN.OptionsColumn.AllowEdit = false;
			this.BGCol_DDATE_FIN.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_VCONTRATCLI_TACITE
			// 
			resources.ApplyResources(this.BGCol_VCONTRATCLI_TACITE, "BGCol_VCONTRATCLI_TACITE");
			this.BGCol_VCONTRATCLI_TACITE.FieldName = "VCONTRATCLI_TACITE";
			this.BGCol_VCONTRATCLI_TACITE.Name = "BGCol_VCONTRATCLI_TACITE";
			this.BGCol_VCONTRATCLI_TACITE.OptionsColumn.AllowEdit = false;
			this.BGCol_VCONTRATCLI_TACITE.OptionsColumn.ReadOnly = true;
			// 
			// BGCol_VNOMDOCUMENT
			// 
			resources.ApplyResources(this.BGCol_VNOMDOCUMENT, "BGCol_VNOMDOCUMENT");
			this.BGCol_VNOMDOCUMENT.FieldName = "VNOMDOCUMENT";
			this.BGCol_VNOMDOCUMENT.Name = "BGCol_VNOMDOCUMENT";
			// 
			// CboFormuleRev
			// 
			resources.ApplyResources(this.CboFormuleRev, "CboFormuleRev");
			this.CboFormuleRev.Name = "CboFormuleRev";
			this.CboFormuleRev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CboFormuleRev.Properties.Buttons"))))});
			this.CboFormuleRev.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboFormuleRev.Properties.Columns"), resources.GetString("CboFormuleRev.Properties.Columns1"), ((int)(resources.GetObject("CboFormuleRev.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("CboFormuleRev.Properties.Columns3"))), resources.GetString("CboFormuleRev.Properties.Columns4"), ((bool)(resources.GetObject("CboFormuleRev.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("CboFormuleRev.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("CboFormuleRev.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CboFormuleRev.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboFormuleRev.Properties.Columns9"), resources.GetString("CboFormuleRev.Properties.Columns10"))});
			this.CboFormuleRev.Properties.DisplayMember = "VFORMULE_REV";
			this.CboFormuleRev.Properties.NullText = resources.GetString("CboFormuleRev.Properties.NullText");
			this.CboFormuleRev.Properties.ValueMember = "NIDFORMULE_REV";
			// 
			// CboTypeDoc
			// 
			resources.ApplyResources(this.CboTypeDoc, "CboTypeDoc");
			this.CboTypeDoc.Name = "CboTypeDoc";
			this.CboTypeDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CboTypeDoc.Properties.Buttons"))))});
			this.CboTypeDoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboTypeDoc.Properties.Columns"), resources.GetString("CboTypeDoc.Properties.Columns1"), ((int)(resources.GetObject("CboTypeDoc.Properties.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("CboTypeDoc.Properties.Columns3"))), resources.GetString("CboTypeDoc.Properties.Columns4"), ((bool)(resources.GetObject("CboTypeDoc.Properties.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("CboTypeDoc.Properties.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("CboTypeDoc.Properties.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("CboTypeDoc.Properties.Columns8")))),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("CboTypeDoc.Properties.Columns9"), resources.GetString("CboTypeDoc.Properties.Columns10"))});
			this.CboTypeDoc.Properties.DisplayMember = "VCONTRAT_TYPEDOC_LIB";
			this.CboTypeDoc.Properties.NullText = resources.GetString("CboTypeDoc.Properties.NullText");
			this.CboTypeDoc.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
			this.CboTypeDoc.Properties.ValueMember = "NIDCONTRAT_TYPEDOC";
			this.CboTypeDoc.EditValueChanged += new System.EventHandler(this.CboTypeDoc_EditValueChanged);
			// 
			// ChkCboEditSites
			// 
			resources.ApplyResources(this.ChkCboEditSites, "ChkCboEditSites");
			this.ChkCboEditSites.Name = "ChkCboEditSites";
			this.ChkCboEditSites.Properties.AllowMultiSelect = true;
			this.ChkCboEditSites.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ChkCboEditSites.Properties.Buttons"))))});
			this.ChkCboEditSites.Properties.DisplayMember = "VSITNOM";
			this.ChkCboEditSites.Properties.ValueMember = "NSITNUM";
			this.ChkCboEditSites.EditValueChanged += new System.EventHandler(this.ChkCboEditSites_EditValueChanged);
			// 
			// ChkCboEditPays
			// 
			resources.ApplyResources(this.ChkCboEditPays, "ChkCboEditPays");
			this.ChkCboEditPays.Name = "ChkCboEditPays";
			this.ChkCboEditPays.Properties.AllowMultiSelect = true;
			this.ChkCboEditPays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ChkCboEditPays.Properties.Buttons"))))});
			this.ChkCboEditPays.Properties.DisplayMember = "VPAYSNOM";
			this.ChkCboEditPays.Properties.IncrementalSearch = true;
			this.ChkCboEditPays.Properties.ValueMember = "NPAYSNUM";
			this.ChkCboEditPays.EditValueChanged += new System.EventHandler(this.ChkCboEditPays_EditValueChanged);
			// 
			// ChkCboEditCAN
			// 
			resources.ApplyResources(this.ChkCboEditCAN, "ChkCboEditCAN");
			this.ChkCboEditCAN.Name = "ChkCboEditCAN";
			this.ChkCboEditCAN.Properties.AllowMultiSelect = true;
			this.ChkCboEditCAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ChkCboEditCAN.Properties.Buttons"))))});
			this.ChkCboEditCAN.Properties.DisplayMember = "VCANLIB";
			this.ChkCboEditCAN.Properties.ValueMember = "NCANNUM";
			this.ChkCboEditCAN.EditValueChanged += new System.EventHandler(this.ChkCboEditCAN_EditValueChanged);
			// 
			// Txt_PC_BPU
			// 
			resources.ApplyResources(this.Txt_PC_BPU, "Txt_PC_BPU");
			this.Txt_PC_BPU.Name = "Txt_PC_BPU";
			this.Txt_PC_BPU.Properties.Appearance.Options.UseTextOptions = true;
			this.Txt_PC_BPU.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.Txt_PC_BPU.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Txt_PC_BPU.Properties.Mask.EditMask = resources.GetString("Txt_PC_BPU.Properties.Mask.EditMask");
			this.Txt_PC_BPU.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("Txt_PC_BPU.Properties.Mask.MaskType")));
			this.Txt_PC_BPU.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("Txt_PC_BPU.Properties.Mask.UseMaskAsDisplayFormat")));
			// 
			// Txt_PC_Prev
			// 
			resources.ApplyResources(this.Txt_PC_Prev, "Txt_PC_Prev");
			this.Txt_PC_Prev.Name = "Txt_PC_Prev";
			this.Txt_PC_Prev.Properties.Appearance.Options.UseTextOptions = true;
			this.Txt_PC_Prev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.Txt_PC_Prev.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Txt_PC_Prev.Properties.Mask.EditMask = resources.GetString("Txt_PC_Prev.Properties.Mask.EditMask");
			this.Txt_PC_Prev.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("Txt_PC_Prev.Properties.Mask.MaskType")));
			this.Txt_PC_Prev.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("Txt_PC_Prev.Properties.Mask.UseMaskAsDisplayFormat")));
			// 
			// Txt_PC_Cur
			// 
			resources.ApplyResources(this.Txt_PC_Cur, "Txt_PC_Cur");
			this.Txt_PC_Cur.Name = "Txt_PC_Cur";
			this.Txt_PC_Cur.Properties.Appearance.Options.UseTextOptions = true;
			this.Txt_PC_Cur.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.Txt_PC_Cur.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Txt_PC_Cur.Properties.DisplayFormat.FormatString = "n2";
			this.Txt_PC_Cur.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Txt_PC_Cur.Properties.EditFormat.FormatString = "n2";
			this.Txt_PC_Cur.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Txt_PC_Cur.Properties.Mask.EditMask = resources.GetString("Txt_PC_Cur.Properties.Mask.EditMask");
			this.Txt_PC_Cur.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("Txt_PC_Cur.Properties.Mask.MaskType")));
			this.Txt_PC_Cur.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("Txt_PC_Cur.Properties.Mask.UseMaskAsDisplayFormat")));
			// 
			// BtnInfoFormule
			// 
			this.BtnInfoFormule.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.BtnInfoFormule, "BtnInfoFormule");
			this.BtnInfoFormule.ForeColor = System.Drawing.Color.Black;
			this.BtnInfoFormule.HelpContextID = 0;
			this.BtnInfoFormule.Name = "BtnInfoFormule";
			this.BtnInfoFormule.Tag = "65";
			this.BtnInfoFormule.UseVisualStyleBackColor = false;
			this.BtnInfoFormule.Click += new System.EventHandler(this.BtnInfoFormule_Click);
			// 
			// Txt_Obs_Manu
			// 
			this.Txt_Obs_Manu.HelpContextID = 0;
			resources.ApplyResources(this.Txt_Obs_Manu, "Txt_Obs_Manu");
			this.Txt_Obs_Manu.Name = "Txt_Obs_Manu";
			this.Txt_Obs_Manu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Obs_Manu_MouseClick);
			// 
			// apiLabel20
			// 
			this.apiLabel20.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel20, "apiLabel20");
			this.apiLabel20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel20.HelpContextID = 0;
			this.apiLabel20.Name = "apiLabel20";
			// 
			// BtnObsNextAppli
			// 
			resources.ApplyResources(this.BtnObsNextAppli, "BtnObsNextAppli");
			this.BtnObsNextAppli.ForeColor = System.Drawing.Color.Black;
			this.BtnObsNextAppli.HelpContextID = 0;
			this.BtnObsNextAppli.Name = "BtnObsNextAppli";
			this.BtnObsNextAppli.Tag = "66";
			this.BtnObsNextAppli.UseVisualStyleBackColor = true;
			this.BtnObsNextAppli.Click += new System.EventHandler(this.BtnObsNextAppli_Click);
			// 
			// TxtDateNextAppli
			// 
			this.TxtDateNextAppli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.TxtDateNextAppli, "TxtDateNextAppli");
			this.TxtDateNextAppli.HelpContextID = 0;
			this.TxtDateNextAppli.Name = "TxtDateNextAppli";
			this.TxtDateNextAppli.ReadOnly = true;
			// 
			// CmdSuppDateNextAppli
			// 
			this.CmdSuppDateNextAppli.BackColor = System.Drawing.Color.Transparent;
			this.CmdSuppDateNextAppli.HelpContextID = 0;
			resources.ApplyResources(this.CmdSuppDateNextAppli, "CmdSuppDateNextAppli");
			this.CmdSuppDateNextAppli.Name = "CmdSuppDateNextAppli";
			this.CmdSuppDateNextAppli.Tag = "65";
			this.CmdSuppDateNextAppli.UseVisualStyleBackColor = false;
			this.CmdSuppDateNextAppli.Click += new System.EventHandler(this.cmdSupp1_Click);
			// 
			// CmdDateNextAppli
			// 
			this.CmdDateNextAppli.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.CmdDateNextAppli, "CmdDateNextAppli");
			this.CmdDateNextAppli.HelpContextID = 0;
			this.CmdDateNextAppli.Name = "CmdDateNextAppli";
			this.CmdDateNextAppli.Tag = "5";
			this.CmdDateNextAppli.UseVisualStyleBackColor = false;
			this.CmdDateNextAppli.Click += new System.EventHandler(this.cmdDate_Click);
			// 
			// apiLabel19
			// 
			this.apiLabel19.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel19, "apiLabel19");
			this.apiLabel19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel19.HelpContextID = 0;
			this.apiLabel19.Name = "apiLabel19";
			// 
			// BtnHisto_PC_BPU
			// 
			resources.ApplyResources(this.BtnHisto_PC_BPU, "BtnHisto_PC_BPU");
			this.BtnHisto_PC_BPU.ForeColor = System.Drawing.Color.Black;
			this.BtnHisto_PC_BPU.HelpContextID = 0;
			this.BtnHisto_PC_BPU.Name = "BtnHisto_PC_BPU";
			this.BtnHisto_PC_BPU.Tag = "66";
			this.BtnHisto_PC_BPU.UseVisualStyleBackColor = true;
			this.BtnHisto_PC_BPU.Click += new System.EventHandler(this.BtnHisto_PC_BPU_Click);
			// 
			// apiLabel17
			// 
			this.apiLabel17.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel17, "apiLabel17");
			this.apiLabel17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel17.HelpContextID = 0;
			this.apiLabel17.Name = "apiLabel17";
			// 
			// apiLabel18
			// 
			this.apiLabel18.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel18, "apiLabel18");
			this.apiLabel18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel18.HelpContextID = 0;
			this.apiLabel18.Name = "apiLabel18";
			// 
			// BtnHisto_PC_Prev
			// 
			resources.ApplyResources(this.BtnHisto_PC_Prev, "BtnHisto_PC_Prev");
			this.BtnHisto_PC_Prev.ForeColor = System.Drawing.Color.Black;
			this.BtnHisto_PC_Prev.HelpContextID = 0;
			this.BtnHisto_PC_Prev.Name = "BtnHisto_PC_Prev";
			this.BtnHisto_PC_Prev.Tag = "66";
			this.BtnHisto_PC_Prev.UseVisualStyleBackColor = true;
			this.BtnHisto_PC_Prev.Click += new System.EventHandler(this.BtnHisto_PC_Prev_Click);
			// 
			// apiLabel15
			// 
			this.apiLabel15.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel15, "apiLabel15");
			this.apiLabel15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel15.HelpContextID = 0;
			this.apiLabel15.Name = "apiLabel15";
			// 
			// apiLabel16
			// 
			this.apiLabel16.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel16, "apiLabel16");
			this.apiLabel16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel16.HelpContextID = 0;
			this.apiLabel16.Name = "apiLabel16";
			// 
			// BtnHisto_PC_Curatif
			// 
			resources.ApplyResources(this.BtnHisto_PC_Curatif, "BtnHisto_PC_Curatif");
			this.BtnHisto_PC_Curatif.ForeColor = System.Drawing.Color.Black;
			this.BtnHisto_PC_Curatif.HelpContextID = 0;
			this.BtnHisto_PC_Curatif.Name = "BtnHisto_PC_Curatif";
			this.BtnHisto_PC_Curatif.Tag = "66";
			this.BtnHisto_PC_Curatif.UseVisualStyleBackColor = true;
			this.BtnHisto_PC_Curatif.Click += new System.EventHandler(this.BtnHisto_PC_Curatif_Click);
			// 
			// apiLabel14
			// 
			this.apiLabel14.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel14, "apiLabel14");
			this.apiLabel14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel14.HelpContextID = 0;
			this.apiLabel14.Name = "apiLabel14";
			// 
			// apiLabel13
			// 
			this.apiLabel13.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel13, "apiLabel13");
			this.apiLabel13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel13.HelpContextID = 0;
			this.apiLabel13.Name = "apiLabel13";
			// 
			// BtnObsDerAppli
			// 
			resources.ApplyResources(this.BtnObsDerAppli, "BtnObsDerAppli");
			this.BtnObsDerAppli.ForeColor = System.Drawing.Color.Black;
			this.BtnObsDerAppli.HelpContextID = 0;
			this.BtnObsDerAppli.Name = "BtnObsDerAppli";
			this.BtnObsDerAppli.Tag = "66";
			this.BtnObsDerAppli.UseVisualStyleBackColor = true;
			this.BtnObsDerAppli.Click += new System.EventHandler(this.BtnObsDerAppli_Click);
			// 
			// TxtDateDerAppli
			// 
			this.TxtDateDerAppli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.TxtDateDerAppli, "TxtDateDerAppli");
			this.TxtDateDerAppli.HelpContextID = 0;
			this.TxtDateDerAppli.Name = "TxtDateDerAppli";
			this.TxtDateDerAppli.ReadOnly = true;
			// 
			// CmdSuppDateDerAppli
			// 
			this.CmdSuppDateDerAppli.BackColor = System.Drawing.Color.Transparent;
			this.CmdSuppDateDerAppli.HelpContextID = 0;
			resources.ApplyResources(this.CmdSuppDateDerAppli, "CmdSuppDateDerAppli");
			this.CmdSuppDateDerAppli.Name = "CmdSuppDateDerAppli";
			this.CmdSuppDateDerAppli.Tag = "65";
			this.CmdSuppDateDerAppli.UseVisualStyleBackColor = false;
			this.CmdSuppDateDerAppli.Click += new System.EventHandler(this.cmdSupp1_Click);
			// 
			// CmdDateDerAppli
			// 
			this.CmdDateDerAppli.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.CmdDateDerAppli, "CmdDateDerAppli");
			this.CmdDateDerAppli.HelpContextID = 0;
			this.CmdDateDerAppli.Name = "CmdDateDerAppli";
			this.CmdDateDerAppli.Tag = "5";
			this.CmdDateDerAppli.UseVisualStyleBackColor = false;
			this.CmdDateDerAppli.Click += new System.EventHandler(this.cmdDate_Click);
			// 
			// apiLabel12
			// 
			this.apiLabel12.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel12, "apiLabel12");
			this.apiLabel12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel12.HelpContextID = 0;
			this.apiLabel12.Name = "apiLabel12";
			// 
			// ChkRemiseAucune
			// 
			resources.ApplyResources(this.ChkRemiseAucune, "ChkRemiseAucune");
			this.ChkRemiseAucune.ForeColor = System.Drawing.Color.Black;
			this.ChkRemiseAucune.Name = "ChkRemiseAucune";
			this.ChkRemiseAucune.UseVisualStyleBackColor = true;
			// 
			// apiLabel11
			// 
			this.apiLabel11.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel11, "apiLabel11");
			this.apiLabel11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel11.HelpContextID = 0;
			this.apiLabel11.Name = "apiLabel11";
			// 
			// BtnObsRemise
			// 
			this.BtnObsRemise.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.BtnObsRemise, "BtnObsRemise");
			this.BtnObsRemise.ForeColor = System.Drawing.Color.Black;
			this.BtnObsRemise.HelpContextID = 0;
			this.BtnObsRemise.Name = "BtnObsRemise";
			this.BtnObsRemise.Tag = "65";
			this.BtnObsRemise.UseVisualStyleBackColor = false;
			this.BtnObsRemise.Click += new System.EventHandler(this.BtnObsRemise_Click);
			// 
			// apiLabel10
			// 
			this.apiLabel10.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel10, "apiLabel10");
			this.apiLabel10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel10.HelpContextID = 0;
			this.apiLabel10.Name = "apiLabel10";
			// 
			// Chk_Tacite
			// 
			resources.ApplyResources(this.Chk_Tacite, "Chk_Tacite");
			this.Chk_Tacite.ForeColor = System.Drawing.Color.Black;
			this.Chk_Tacite.Name = "Chk_Tacite";
			this.Chk_Tacite.UseVisualStyleBackColor = true;
			// 
			// BtnInfoDateFin
			// 
			this.BtnInfoDateFin.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.BtnInfoDateFin, "BtnInfoDateFin");
			this.BtnInfoDateFin.ForeColor = System.Drawing.Color.Black;
			this.BtnInfoDateFin.HelpContextID = 0;
			this.BtnInfoDateFin.Name = "BtnInfoDateFin";
			this.BtnInfoDateFin.Tag = "65";
			this.BtnInfoDateFin.UseVisualStyleBackColor = false;
			this.BtnInfoDateFin.Click += new System.EventHandler(this.BtnInfoDateFin_Click);
			// 
			// BtnObsDoc
			// 
			resources.ApplyResources(this.BtnObsDoc, "BtnObsDoc");
			this.BtnObsDoc.ForeColor = System.Drawing.Color.Black;
			this.BtnObsDoc.HelpContextID = 0;
			this.BtnObsDoc.Name = "BtnObsDoc";
			this.BtnObsDoc.Tag = "66";
			this.BtnObsDoc.UseVisualStyleBackColor = true;
			this.BtnObsDoc.Click += new System.EventHandler(this.BtnObsDoc_Click);
			// 
			// apiLabel9
			// 
			this.apiLabel9.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel9, "apiLabel9");
			this.apiLabel9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel9.HelpContextID = 0;
			this.apiLabel9.Name = "apiLabel9";
			// 
			// apiLabel8
			// 
			this.apiLabel8.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel8, "apiLabel8");
			this.apiLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel8.HelpContextID = 0;
			this.apiLabel8.Name = "apiLabel8";
			// 
			// LblNbSitesSelected
			// 
			this.LblNbSitesSelected.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.LblNbSitesSelected, "LblNbSitesSelected");
			this.LblNbSitesSelected.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LblNbSitesSelected.HelpContextID = 0;
			this.LblNbSitesSelected.Name = "LblNbSitesSelected";
			// 
			// apiLabel7
			// 
			this.apiLabel7.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel7, "apiLabel7");
			this.apiLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel7.HelpContextID = 0;
			this.apiLabel7.Name = "apiLabel7";
			// 
			// LblNbPaysSelected
			// 
			this.LblNbPaysSelected.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.LblNbPaysSelected, "LblNbPaysSelected");
			this.LblNbPaysSelected.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LblNbPaysSelected.HelpContextID = 0;
			this.LblNbPaysSelected.Name = "LblNbPaysSelected";
			// 
			// apiLabel5
			// 
			this.apiLabel5.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel5, "apiLabel5");
			this.apiLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel5.HelpContextID = 0;
			this.apiLabel5.Name = "apiLabel5";
			// 
			// LblNbCptSelected
			// 
			this.LblNbCptSelected.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.LblNbCptSelected, "LblNbCptSelected");
			this.LblNbCptSelected.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LblNbCptSelected.HelpContextID = 0;
			this.LblNbCptSelected.Name = "LblNbCptSelected";
			// 
			// apiLabel2
			// 
			this.apiLabel2.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel2.HelpContextID = 0;
			this.apiLabel2.Name = "apiLabel2";
			// 
			// txtDateFin
			// 
			this.txtDateFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtDateFin, "txtDateFin");
			this.txtDateFin.HelpContextID = 0;
			this.txtDateFin.Name = "txtDateFin";
			this.txtDateFin.ReadOnly = true;
			// 
			// cmdSuppFin
			// 
			this.cmdSuppFin.BackColor = System.Drawing.Color.Transparent;
			this.cmdSuppFin.HelpContextID = 0;
			resources.ApplyResources(this.cmdSuppFin, "cmdSuppFin");
			this.cmdSuppFin.Name = "cmdSuppFin";
			this.cmdSuppFin.Tag = "65";
			this.cmdSuppFin.UseVisualStyleBackColor = false;
			this.cmdSuppFin.Click += new System.EventHandler(this.cmdSupp1_Click);
			// 
			// cmdDateFin
			// 
			this.cmdDateFin.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.cmdDateFin, "cmdDateFin");
			this.cmdDateFin.HelpContextID = 0;
			this.cmdDateFin.Name = "cmdDateFin";
			this.cmdDateFin.Tag = "5";
			this.cmdDateFin.UseVisualStyleBackColor = false;
			this.cmdDateFin.Click += new System.EventHandler(this.cmdDate_Click);
			// 
			// txtDateDebut
			// 
			this.txtDateDebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtDateDebut, "txtDateDebut");
			this.txtDateDebut.HelpContextID = 0;
			this.txtDateDebut.Name = "txtDateDebut";
			this.txtDateDebut.ReadOnly = true;
			// 
			// cmdSuppDebut
			// 
			this.cmdSuppDebut.BackColor = System.Drawing.Color.Transparent;
			this.cmdSuppDebut.HelpContextID = 0;
			resources.ApplyResources(this.cmdSuppDebut, "cmdSuppDebut");
			this.cmdSuppDebut.Name = "cmdSuppDebut";
			this.cmdSuppDebut.Tag = "65";
			this.cmdSuppDebut.UseVisualStyleBackColor = false;
			this.cmdSuppDebut.Click += new System.EventHandler(this.cmdSupp1_Click);
			// 
			// cmdDateDebut
			// 
			this.cmdDateDebut.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.cmdDateDebut, "cmdDateDebut");
			this.cmdDateDebut.HelpContextID = 0;
			this.cmdDateDebut.Name = "cmdDateDebut";
			this.cmdDateDebut.Tag = "5";
			this.cmdDateDebut.UseVisualStyleBackColor = false;
			this.cmdDateDebut.Click += new System.EventHandler(this.cmdDate_Click);
			// 
			// cmdDateDoc
			// 
			this.cmdDateDoc.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.cmdDateDoc, "cmdDateDoc");
			this.cmdDateDoc.HelpContextID = 0;
			this.cmdDateDoc.Name = "cmdDateDoc";
			this.cmdDateDoc.Tag = "5";
			this.cmdDateDoc.UseVisualStyleBackColor = false;
			this.cmdDateDoc.Click += new System.EventHandler(this.cmdDate_Click);
			// 
			// cmdSuppDateDoc
			// 
			this.cmdSuppDateDoc.BackColor = System.Drawing.Color.Transparent;
			this.cmdSuppDateDoc.HelpContextID = 0;
			resources.ApplyResources(this.cmdSuppDateDoc, "cmdSuppDateDoc");
			this.cmdSuppDateDoc.Name = "cmdSuppDateDoc";
			this.cmdSuppDateDoc.Tag = "65";
			this.cmdSuppDateDoc.UseVisualStyleBackColor = false;
			this.cmdSuppDateDoc.Click += new System.EventHandler(this.cmdSupp1_Click);
			// 
			// txtDate_Doc
			// 
			this.txtDate_Doc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtDate_Doc, "txtDate_Doc");
			this.txtDate_Doc.HelpContextID = 0;
			this.txtDate_Doc.Name = "txtDate_Doc";
			this.txtDate_Doc.ReadOnly = true;
			// 
			// lblLabels11
			// 
			this.lblLabels11.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.lblLabels11, "lblLabels11");
			this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels11.HelpContextID = 0;
			this.lblLabels11.Name = "lblLabels11";
			// 
			// lblLabels10
			// 
			this.lblLabels10.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.lblLabels10, "lblLabels10");
			this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels10.HelpContextID = 0;
			this.lblLabels10.Name = "lblLabels10";
			// 
			// lblLabels12
			// 
			this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.lblLabels12, "lblLabels12");
			this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels12.HelpContextID = 0;
			this.lblLabels12.Name = "lblLabels12";
			// 
			// Txt_NomDoc
			// 
			this.Txt_NomDoc.HelpContextID = 0;
			resources.ApplyResources(this.Txt_NomDoc, "Txt_NomDoc");
			this.Txt_NomDoc.Name = "Txt_NomDoc";
			// 
			// apiLabel1
			// 
			this.apiLabel1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
			// 
			// repositoryItemCheckEdit2
			// 
			resources.ApplyResources(this.repositoryItemCheckEdit2, "repositoryItemCheckEdit2");
			this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
			this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
			this.repositoryItemCheckEdit2.ValueChecked = ((short)(1));
			this.repositoryItemCheckEdit2.ValueUnchecked = ((short)(0));
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
			// cmdEnregistrer
			// 
			resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
			this.cmdEnregistrer.HelpContextID = 0;
			this.cmdEnregistrer.Name = "cmdEnregistrer";
			this.cmdEnregistrer.Tag = "66";
			this.cmdEnregistrer.UseVisualStyleBackColor = true;
			this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// BtnAddDoc
			// 
			resources.ApplyResources(this.BtnAddDoc, "BtnAddDoc");
			this.BtnAddDoc.HelpContextID = 0;
			this.BtnAddDoc.Name = "BtnAddDoc";
			this.BtnAddDoc.Tag = "66";
			this.BtnAddDoc.UseVisualStyleBackColor = true;
			this.BtnAddDoc.Click += new System.EventHandler(this.BtnAddDoc_Click);
			// 
			// BtnVisuDoc
			// 
			resources.ApplyResources(this.BtnVisuDoc, "BtnVisuDoc");
			this.BtnVisuDoc.HelpContextID = 0;
			this.BtnVisuDoc.Name = "BtnVisuDoc";
			this.BtnVisuDoc.Tag = "66";
			this.BtnVisuDoc.UseVisualStyleBackColor = true;
			this.BtnVisuDoc.Click += new System.EventHandler(this.BtnVisuDoc_Click);
			// 
			// BtnContratDocDel
			// 
			resources.ApplyResources(this.BtnContratDocDel, "BtnContratDocDel");
			this.BtnContratDocDel.HelpContextID = 0;
			this.BtnContratDocDel.Name = "BtnContratDocDel";
			this.BtnContratDocDel.Tag = "66";
			this.BtnContratDocDel.UseVisualStyleBackColor = true;
			this.BtnContratDocDel.Click += new System.EventHandler(this.BtnContratDocDel_Click);
			// 
			// Txt_Obs
			// 
			this.Txt_Obs.HelpContextID = 0;
			resources.ApplyResources(this.Txt_Obs, "Txt_Obs");
			this.Txt_Obs.Name = "Txt_Obs";
			this.Txt_Obs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Txt_Obs_MouseClick);
			// 
			// apiLabel3
			// 
			this.apiLabel3.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.apiLabel3, "apiLabel3");
			this.apiLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel3.HelpContextID = 0;
			this.apiLabel3.Name = "apiLabel3";
			// 
			// frmClientsContrats_Detail
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.BtnContratDocDel);
			this.Controls.Add(this.BtnVisuDoc);
			this.Controls.Add(this.BtnAddDoc);
			this.Controls.Add(this.Calendar1);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdEnregistrer);
			this.Controls.Add(this.Label1);
			this.Name = "frmClientsContrats_Detail";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmClientsContrats_Detail_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GLU_Contrat_Avenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GLU_Contrat_AvenantView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CboFormuleRev.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CboTypeDoc.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditSites.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditPays.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChkCboEditCAN.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_BPU.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_Prev.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Txt_PC_Cur.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private System.Windows.Forms.OpenFileDialog CDG;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTextBox txtDateFin;
    private MozartUC.apiButton cmdSuppFin;
    private MozartUC.apiButton cmdDateFin;
    private MozartUC.apiTextBox txtDateDebut;
    private MozartUC.apiButton cmdSuppDebut;
    private MozartUC.apiButton cmdDateDebut;
    private MozartUC.apiButton cmdDateDoc;
    private MozartUC.apiButton cmdSuppDateDoc;
    private MozartUC.apiTextBox txtDate_Doc;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiTextBox Txt_NomDoc;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel LblNbCptSelected;
    private System.Windows.Forms.CheckBox ChkRemiseAucune;
    private MozartUC.apiLabel apiLabel11;
    private MozartUC.apiButton BtnObsRemise;
    private MozartUC.apiLabel apiLabel10;
    private System.Windows.Forms.CheckBox Chk_Tacite;
    private MozartUC.apiButton BtnInfoDateFin;
    private MozartUC.apiButton BtnObsDoc;
    private MozartUC.apiLabel apiLabel9;
    private MozartUC.apiLabel apiLabel8;
    private MozartUC.apiLabel LblNbSitesSelected;
    private MozartUC.apiLabel apiLabel7;
    private MozartUC.apiLabel LblNbPaysSelected;
    private MozartUC.apiLabel apiLabel5;
    private MozartUC.apiButton BtnObsDerAppli;
    private MozartUC.apiTextBox TxtDateDerAppli;
    private MozartUC.apiButton CmdSuppDateDerAppli;
    private MozartUC.apiButton CmdDateDerAppli;
    private MozartUC.apiLabel apiLabel12;
    private MozartUC.apiTextBox Txt_Obs_Manu;
    private MozartUC.apiLabel apiLabel20;
    private MozartUC.apiButton BtnObsNextAppli;
    private MozartUC.apiTextBox TxtDateNextAppli;
    private MozartUC.apiButton CmdSuppDateNextAppli;
    private MozartUC.apiButton CmdDateNextAppli;
    private MozartUC.apiLabel apiLabel19;
    private MozartUC.apiButton BtnHisto_PC_BPU;
    private MozartUC.apiLabel apiLabel17;
    private MozartUC.apiLabel apiLabel18;
    private MozartUC.apiButton BtnHisto_PC_Prev;
    private MozartUC.apiLabel apiLabel15;
    private MozartUC.apiLabel apiLabel16;
    private MozartUC.apiButton BtnHisto_PC_Curatif;
    private MozartUC.apiLabel apiLabel14;
    private MozartUC.apiLabel apiLabel13;
    private MozartUC.apiButton BtnInfoFormule;
    private DevExpress.XtraEditors.TextEdit Txt_PC_BPU;
    private DevExpress.XtraEditors.TextEdit Txt_PC_Prev;
    private DevExpress.XtraEditors.TextEdit Txt_PC_Cur;
    private DevExpress.XtraEditors.CheckedComboBoxEdit ChkCboEditCAN;
    private DevExpress.XtraEditors.CheckedComboBoxEdit ChkCboEditSites;
    private DevExpress.XtraEditors.CheckedComboBoxEdit ChkCboEditPays;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    private DevExpress.XtraEditors.LookUpEdit CboTypeDoc;
    private DevExpress.XtraEditors.LookUpEdit CboFormuleRev;
    private DevExpress.XtraEditors.GridLookUpEdit GLU_Contrat_Avenant;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView GLU_Contrat_AvenantView;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand GB_Client;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_NIDCONTRATCLI_DETAIL;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_VCLINOM;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_STR_LST_CAN;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_STR_LST_PAYS;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_STR_LST_SITES;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand GB_Contrat;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_VPRESENCE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_DDATE_DEBUT;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_DDATE_FIN;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_VCONTRATCLI_TACITE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BGCol_VNOMDOCUMENT;
    private MozartUC.apiButton BtnAddDoc;
    private MozartUC.apiButton BtnVisuDoc;
    private MozartUC.apiButton BtnContratDocDel;
        private System.Windows.Forms.CheckBox chkNoDoc;
		private MozartUC.apiTextBox Txt_Obs;
		private MozartUC.apiLabel apiLabel3;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
