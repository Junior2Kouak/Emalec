namespace MozartCS
{
  partial class frmStatPlanning_Delai_Pla_Reg
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatPlanning_Delai_Pla_Reg));
      this.cmdExcel = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.DateEdit_Fin = new DevExpress.XtraEditors.DateEdit();
      this.DateEdit_Debut = new DevExpress.XtraEditors.DateEdit();
      this.cmdValider = new MozartUC.apiButton();
      this.GCMain = new DevExpress.XtraGrid.GridControl();
      this.GVMain = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCol_NPERNUM_PLA = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColNREGCOD = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_NPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColDEPARTEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVPERNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColMOY_DELAI_D = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_HL_Delai_D = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GCol_MOY_DELAI_HORS_D = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_HL_Delai_Hors_D = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GColMOY_DELAI_PLANIF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_HL_Delai_Planif = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GCol_TOT_NB_NOK = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_HL_NB_NOK = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GCol_TOT_NB_NOK_SUP_1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_HL_NB_ACT_NOK_SUP1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GrpObjectif = new System.Windows.Forms.GroupBox();
      this.LblObjectif = new System.Windows.Forms.Label();
      this.GrpMemo = new System.Windows.Forms.GroupBox();
      this.LblMemo = new System.Windows.Forms.Label();
      this.sFD = new System.Windows.Forms.SaveFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_D)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_Hors_D)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_Planif)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_NB_NOK)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_NB_ACT_NOK_SUP1)).BeginInit();
      this.GrpObjectif.SuspendLayout();
      this.GrpMemo.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdExcel
      // 
      resources.ApplyResources(this.cmdExcel, "cmdExcel");
      this.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdExcel.HelpContextID = 0;
      this.cmdExcel.Name = "cmdExcel";
      this.cmdExcel.Tag = "19";
      this.cmdExcel.UseVisualStyleBackColor = true;
      this.cmdExcel.Click += new System.EventHandler(this.cmdExportXLSX_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // apiLabel2
      // 
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // DateEdit_Fin
      // 
      resources.ApplyResources(this.DateEdit_Fin, "DateEdit_Fin");
      this.DateEdit_Fin.Name = "DateEdit_Fin";
      this.DateEdit_Fin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.Buttons"))))});
      this.DateEdit_Fin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // DateEdit_Debut
      // 
      resources.ApplyResources(this.DateEdit_Debut, "DateEdit_Debut");
      this.DateEdit_Debut.Name = "DateEdit_Debut";
      this.DateEdit_Debut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.Buttons"))))});
      this.DateEdit_Debut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // GCMain
      // 
      resources.ApplyResources(this.GCMain, "GCMain");
      this.GCMain.MainView = this.GVMain;
      this.GCMain.Name = "GCMain";
      this.GCMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_HL_Delai_D,
            this.Repo_HL_Delai_Hors_D,
            this.Repo_HL_Delai_Planif,
            this.Repo_HL_NB_NOK,
            this.Repo_HL_NB_ACT_NOK_SUP1});
      this.GCMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVMain});
      // 
      // GVMain
      // 
      this.GVMain.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("GVMain.Appearance.HeaderPanel.Font")));
      this.GVMain.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVMain.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GVMain.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GVMain.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GVMain.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.GVMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_NPERNUM_PLA,
            this.GColNREGCOD,
            this.GCol_NPERNUM,
            this.GColDEPARTEMENT,
            this.GColVPERNOM,
            this.GColMOY_DELAI_D,
            this.GCol_MOY_DELAI_HORS_D,
            this.GColMOY_DELAI_PLANIF,
            this.GCol_TOT_NB_NOK,
            this.GCol_TOT_NB_NOK_SUP_1});
      this.GVMain.GridControl = this.GCMain;
      this.GVMain.Name = "GVMain";
      this.GVMain.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
      this.GVMain.OptionsView.ShowFooter = true;
      this.GVMain.OptionsView.ShowGroupPanel = false;
      // 
      // GCol_NPERNUM_PLA
      // 
      resources.ApplyResources(this.GCol_NPERNUM_PLA, "GCol_NPERNUM_PLA");
      this.GCol_NPERNUM_PLA.FieldName = "NPERNUM_PLA";
      this.GCol_NPERNUM_PLA.Name = "GCol_NPERNUM_PLA";
      // 
      // GColNREGCOD
      // 
      resources.ApplyResources(this.GColNREGCOD, "GColNREGCOD");
      this.GColNREGCOD.FieldName = "NREGCOD";
      this.GColNREGCOD.Name = "GColNREGCOD";
      // 
      // GCol_NPERNUM
      // 
      resources.ApplyResources(this.GCol_NPERNUM, "GCol_NPERNUM");
      this.GCol_NPERNUM.FieldName = "NPERNUM";
      this.GCol_NPERNUM.Name = "GCol_NPERNUM";
      // 
      // GColDEPARTEMENT
      // 
      this.GColDEPARTEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColDEPARTEMENT.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GColDEPARTEMENT, "GColDEPARTEMENT");
      this.GColDEPARTEMENT.FieldName = "DEPARTEMENT";
      this.GColDEPARTEMENT.Name = "GColDEPARTEMENT";
      this.GColDEPARTEMENT.OptionsColumn.AllowEdit = false;
      this.GColDEPARTEMENT.OptionsColumn.ReadOnly = true;
      // 
      // GColVPERNOM
      // 
      this.GColVPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColVPERNOM.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GColVPERNOM, "GColVPERNOM");
      this.GColVPERNOM.FieldName = "VPERNOM";
      this.GColVPERNOM.Name = "GColVPERNOM";
      this.GColVPERNOM.OptionsColumn.AllowEdit = false;
      this.GColVPERNOM.OptionsColumn.ReadOnly = true;
      // 
      // GColMOY_DELAI_D
      // 
      this.GColMOY_DELAI_D.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColMOY_DELAI_D.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GColMOY_DELAI_D, "GColMOY_DELAI_D");
      this.GColMOY_DELAI_D.ColumnEdit = this.Repo_HL_Delai_D;
      this.GColMOY_DELAI_D.DisplayFormat.FormatString = "n2";
      this.GColMOY_DELAI_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GColMOY_DELAI_D.FieldName = "MOY_DELAI_D";
      this.GColMOY_DELAI_D.Name = "GColMOY_DELAI_D";
      this.GColMOY_DELAI_D.OptionsColumn.ReadOnly = true;
      this.GColMOY_DELAI_D.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("GColMOY_DELAI_D.Summary"))), resources.GetString("GColMOY_DELAI_D.Summary1"), resources.GetString("GColMOY_DELAI_D.Summary2"))});
      // 
      // Repo_HL_Delai_D
      // 
      resources.ApplyResources(this.Repo_HL_Delai_D, "Repo_HL_Delai_D");
      this.Repo_HL_Delai_D.DisplayFormat.FormatString = "n2";
      this.Repo_HL_Delai_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.Repo_HL_Delai_D.Name = "Repo_HL_Delai_D";
      this.Repo_HL_Delai_D.SingleClick = true;
      this.Repo_HL_Delai_D.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_HL_Delai_D_OpenLink);
      // 
      // GCol_MOY_DELAI_HORS_D
      // 
      this.GCol_MOY_DELAI_HORS_D.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_MOY_DELAI_HORS_D.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GCol_MOY_DELAI_HORS_D, "GCol_MOY_DELAI_HORS_D");
      this.GCol_MOY_DELAI_HORS_D.ColumnEdit = this.Repo_HL_Delai_Hors_D;
      this.GCol_MOY_DELAI_HORS_D.DisplayFormat.FormatString = "n2";
      this.GCol_MOY_DELAI_HORS_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_MOY_DELAI_HORS_D.FieldName = "MOY_DELAI_HORS_D";
      this.GCol_MOY_DELAI_HORS_D.Name = "GCol_MOY_DELAI_HORS_D";
      this.GCol_MOY_DELAI_HORS_D.OptionsColumn.ReadOnly = true;
      this.GCol_MOY_DELAI_HORS_D.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("GCol_MOY_DELAI_HORS_D.Summary"))), resources.GetString("GCol_MOY_DELAI_HORS_D.Summary1"), resources.GetString("GCol_MOY_DELAI_HORS_D.Summary2"))});
      // 
      // Repo_HL_Delai_Hors_D
      // 
      resources.ApplyResources(this.Repo_HL_Delai_Hors_D, "Repo_HL_Delai_Hors_D");
      this.Repo_HL_Delai_Hors_D.DisplayFormat.FormatString = "n2";
      this.Repo_HL_Delai_Hors_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.Repo_HL_Delai_Hors_D.Name = "Repo_HL_Delai_Hors_D";
      this.Repo_HL_Delai_Hors_D.SingleClick = true;
      this.Repo_HL_Delai_Hors_D.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_HL_Delai_Hors_D_OpenLink);
      // 
      // GColMOY_DELAI_PLANIF
      // 
      this.GColMOY_DELAI_PLANIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColMOY_DELAI_PLANIF.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GColMOY_DELAI_PLANIF, "GColMOY_DELAI_PLANIF");
      this.GColMOY_DELAI_PLANIF.ColumnEdit = this.Repo_HL_Delai_Planif;
      this.GColMOY_DELAI_PLANIF.DisplayFormat.FormatString = "n0";
      this.GColMOY_DELAI_PLANIF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GColMOY_DELAI_PLANIF.FieldName = "MOY_DELAI_PLANIF";
      this.GColMOY_DELAI_PLANIF.Name = "GColMOY_DELAI_PLANIF";
      this.GColMOY_DELAI_PLANIF.OptionsColumn.ReadOnly = true;
      this.GColMOY_DELAI_PLANIF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("GColMOY_DELAI_PLANIF.Summary"))), resources.GetString("GColMOY_DELAI_PLANIF.Summary1"), resources.GetString("GColMOY_DELAI_PLANIF.Summary2"))});
      // 
      // Repo_HL_Delai_Planif
      // 
      resources.ApplyResources(this.Repo_HL_Delai_Planif, "Repo_HL_Delai_Planif");
      this.Repo_HL_Delai_Planif.DisplayFormat.FormatString = "n2";
      this.Repo_HL_Delai_Planif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.Repo_HL_Delai_Planif.Name = "Repo_HL_Delai_Planif";
      this.Repo_HL_Delai_Planif.SingleClick = true;
      this.Repo_HL_Delai_Planif.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_HL_Delai_Planif_OpenLink);
      // 
      // GCol_TOT_NB_NOK
      // 
      this.GCol_TOT_NB_NOK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_TOT_NB_NOK.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GCol_TOT_NB_NOK, "GCol_TOT_NB_NOK");
      this.GCol_TOT_NB_NOK.ColumnEdit = this.Repo_HL_NB_NOK;
      this.GCol_TOT_NB_NOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_TOT_NB_NOK.FieldName = "TOT_NB_NOK";
      this.GCol_TOT_NB_NOK.Name = "GCol_TOT_NB_NOK";
      this.GCol_TOT_NB_NOK.OptionsColumn.ReadOnly = true;
      this.GCol_TOT_NB_NOK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("GCol_TOT_NB_NOK.Summary"))), resources.GetString("GCol_TOT_NB_NOK.Summary1"), resources.GetString("GCol_TOT_NB_NOK.Summary2"))});
      // 
      // Repo_HL_NB_NOK
      // 
      resources.ApplyResources(this.Repo_HL_NB_NOK, "Repo_HL_NB_NOK");
      this.Repo_HL_NB_NOK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.Repo_HL_NB_NOK.Name = "Repo_HL_NB_NOK";
      this.Repo_HL_NB_NOK.SingleClick = true;
      this.Repo_HL_NB_NOK.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_HL_NB_NOK_OpenLink);
      // 
      // GCol_TOT_NB_NOK_SUP_1
      // 
      this.GCol_TOT_NB_NOK_SUP_1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_TOT_NB_NOK_SUP_1.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.GCol_TOT_NB_NOK_SUP_1, "GCol_TOT_NB_NOK_SUP_1");
      this.GCol_TOT_NB_NOK_SUP_1.ColumnEdit = this.Repo_HL_NB_ACT_NOK_SUP1;
      this.GCol_TOT_NB_NOK_SUP_1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_TOT_NB_NOK_SUP_1.FieldName = "TOT_NB_NOK_SUP_1";
      this.GCol_TOT_NB_NOK_SUP_1.Name = "GCol_TOT_NB_NOK_SUP_1";
      this.GCol_TOT_NB_NOK_SUP_1.OptionsColumn.ReadOnly = true;
      this.GCol_TOT_NB_NOK_SUP_1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("GCol_TOT_NB_NOK_SUP_1.Summary"))), resources.GetString("GCol_TOT_NB_NOK_SUP_1.Summary1"), resources.GetString("GCol_TOT_NB_NOK_SUP_1.Summary2"))});
      // 
      // Repo_HL_NB_ACT_NOK_SUP1
      // 
      resources.ApplyResources(this.Repo_HL_NB_ACT_NOK_SUP1, "Repo_HL_NB_ACT_NOK_SUP1");
      this.Repo_HL_NB_ACT_NOK_SUP1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.Repo_HL_NB_ACT_NOK_SUP1.Name = "Repo_HL_NB_ACT_NOK_SUP1";
      this.Repo_HL_NB_ACT_NOK_SUP1.SingleClick = true;
      this.Repo_HL_NB_ACT_NOK_SUP1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_HL_NB_ACT_NOK_SUP1_OpenLink);
      // 
      // GrpObjectif
      // 
      resources.ApplyResources(this.GrpObjectif, "GrpObjectif");
      this.GrpObjectif.Controls.Add(this.LblObjectif);
      this.GrpObjectif.Name = "GrpObjectif";
      this.GrpObjectif.TabStop = false;
      // 
      // LblObjectif
      // 
      this.LblObjectif.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.LblObjectif, "LblObjectif");
      this.LblObjectif.Name = "LblObjectif";
      // 
      // GrpMemo
      // 
      resources.ApplyResources(this.GrpMemo, "GrpMemo");
      this.GrpMemo.Controls.Add(this.LblMemo);
      this.GrpMemo.Name = "GrpMemo";
      this.GrpMemo.TabStop = false;
      // 
      // LblMemo
      // 
      this.LblMemo.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.LblMemo, "LblMemo");
      this.LblMemo.Name = "LblMemo";
      // 
      // sFD
      // 
      this.sFD.DefaultExt = "xlsx";
      resources.ApplyResources(this.sFD, "sFD");
      // 
      // frmStatPlanning_Delai_Pla_Reg
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.GrpMemo);
      this.Controls.Add(this.GrpObjectif);
      this.Controls.Add(this.GCMain);
      this.Controls.Add(this.apiLabel2);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.DateEdit_Fin);
      this.Controls.Add(this.DateEdit_Debut);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdExcel);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmStatPlanning_Delai_Pla_Reg";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatHeureDevisTech_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_D)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_Hors_D)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_Delai_Planif)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_NB_NOK)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_HL_NB_ACT_NOK_SUP1)).EndInit();
      this.GrpObjectif.ResumeLayout(false);
      this.GrpMemo.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdExcel;
    private MozartUC.apiButton cmdQuitter;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel apiLabel1;
    private DevExpress.XtraEditors.DateEdit DateEdit_Fin;
    private DevExpress.XtraEditors.DateEdit DateEdit_Debut;
    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraGrid.GridControl GCMain;
    private DevExpress.XtraGrid.Views.Grid.GridView GVMain;
    private DevExpress.XtraGrid.Columns.GridColumn GColNREGCOD;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NPERNUM;
    private DevExpress.XtraGrid.Columns.GridColumn GColDEPARTEMENT;
    private DevExpress.XtraGrid.Columns.GridColumn GColVPERNOM;
    private DevExpress.XtraGrid.Columns.GridColumn GColMOY_DELAI_D;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_MOY_DELAI_HORS_D;
    private DevExpress.XtraGrid.Columns.GridColumn GColMOY_DELAI_PLANIF;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_TOT_NB_NOK;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_TOT_NB_NOK_SUP_1;
    private System.Windows.Forms.GroupBox GrpObjectif;
    private System.Windows.Forms.Label LblObjectif;
    private System.Windows.Forms.GroupBox GrpMemo;
    private System.Windows.Forms.Label LblMemo;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HL_Delai_D;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HL_Delai_Hors_D;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HL_Delai_Planif;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HL_NB_NOK;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_HL_NB_ACT_NOK_SUP1;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NPERNUM_PLA;
    private System.Windows.Forms.SaveFileDialog sFD;
  }
}
