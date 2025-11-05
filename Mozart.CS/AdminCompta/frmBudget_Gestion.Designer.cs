
namespace MozartCS.AdminCompta
{
  partial class frmBudget_Gestion
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
      this.GCBudget = new DevExpress.XtraGrid.GridControl();
      this.BGV_Budget = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
      this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.GCol_NID_BUDGET_GESTION = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NANNEE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NCANNUM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_VCANLIB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.GCol_NOBJCA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NOBJRESULTANA_MTT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NOBJRESULTANA_PC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.GCol_NBUDGETCA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NBUDGETRESULTANA_MTT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.GCol_NBUDGETRESULTANA_PC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.GCol_VCOMMENTAIRES = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.TextEditNMONTANT = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.TextEditVCOMMENTAIRE = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.GrpActions = new System.Windows.Forms.GroupBox();
      this.BtnImportXLS = new System.Windows.Forms.Button();
      this.BtnSaisonnalite = new System.Windows.Forms.Button();
      this.BtnQuit = new System.Windows.Forms.Button();
      this.BtnSave = new System.Windows.Forms.Button();
      this.GrpCriteres = new System.Windows.Forms.GroupBox();
      this.BtnValid = new System.Windows.Forms.Button();
      this.DateEditAnnee = new DevExpress.XtraEditors.DateEdit();
      this.LblTitre = new System.Windows.Forms.Label();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.GCBudget)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BGV_Budget)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TextEditNMONTANT)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TextEditVCOMMENTAIRE)).BeginInit();
      this.GrpActions.SuspendLayout();
      this.GrpCriteres.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties.CalendarTimeProperties)).BeginInit();
      this.SuspendLayout();
      // 
      // GCBudget
      // 
      this.GCBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.GCBudget.Location = new System.Drawing.Point(210, 132);
      this.GCBudget.MainView = this.BGV_Budget;
      this.GCBudget.Name = "GCBudget";
      this.GCBudget.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TextEditNMONTANT,
            this.TextEditVCOMMENTAIRE});
      this.GCBudget.Size = new System.Drawing.Size(1817, 905);
      this.GCBudget.TabIndex = 6;
      this.GCBudget.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BGV_Budget});
      // 
      // BGV_Budget
      // 
      this.BGV_Budget.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.ColumnFilterButton.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.ColumnFilterButton.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.Empty.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.BGV_Budget.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.BGV_Budget.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.EvenRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.EvenRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.EvenRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.BGV_Budget.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.BGV_Budget.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.FilterCloseButton.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FilterCloseButton.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.FilterCloseButton.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.FilterPanel.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FilterPanel.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(114)))), ((int)(((byte)(113)))));
      this.BGV_Budget.Appearance.FixedLine.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.FocusedCell.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FocusedCell.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(192)))), ((int)(((byte)(157)))));
      this.BGV_Budget.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(188)))));
      this.BGV_Budget.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.FocusedRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FocusedRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.FocusedRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.FooterPanel.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.FooterPanel.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.FooterPanel.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.BGV_Budget.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.BGV_Budget.Appearance.GroupButton.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.GroupButton.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.GroupFooter.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.GroupFooter.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.GroupFooter.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(213)))));
      this.BGV_Budget.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.GroupPanel.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.GroupPanel.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.GroupRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.GroupRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.GroupRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.BGV_Budget.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.HeaderPanel.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.HeaderPanel.Options.UseFont = true;
      this.BGV_Budget.Appearance.HeaderPanel.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.BGV_Budget.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.BGV_Budget.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.BGV_Budget.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.BGV_Budget.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
      this.BGV_Budget.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
      this.BGV_Budget.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.HideSelectionRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.HideSelectionRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.HideSelectionRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.HorzLine.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.BGV_Budget.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.BGV_Budget.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.OddRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.OddRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.OddRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
      this.BGV_Budget.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
      this.BGV_Budget.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
      this.BGV_Budget.Appearance.Preview.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.Preview.Options.UseFont = true;
      this.BGV_Budget.Appearance.Preview.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.BGV_Budget.Appearance.Row.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.Row.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.Row.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.BGV_Budget.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.RowSeparator.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(215)))), ((int)(((byte)(188)))));
      this.BGV_Budget.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(203)))));
      this.BGV_Budget.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
      this.BGV_Budget.Appearance.SelectedRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.SelectedRow.Options.UseBorderColor = true;
      this.BGV_Budget.Appearance.SelectedRow.Options.UseForeColor = true;
      this.BGV_Budget.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
      this.BGV_Budget.Appearance.TopNewRow.Options.UseBackColor = true;
      this.BGV_Budget.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.BGV_Budget.Appearance.VertLine.Options.UseBackColor = true;
      this.BGV_Budget.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand1,
            this.gridBand2,
            this.gridBand4});
      this.BGV_Budget.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.GCol_NCANNUM,
            this.GCol_VCANLIB,
            this.GCol_NID_BUDGET_GESTION,
            this.GCol_NANNEE,
            this.GCol_NOBJCA,
            this.GCol_NOBJRESULTANA_PC,
            this.GCol_NOBJRESULTANA_MTT,
            this.GCol_NBUDGETCA,
            this.GCol_NBUDGETRESULTANA_MTT,
            this.GCol_NBUDGETRESULTANA_PC,
            this.GCol_VCOMMENTAIRES});
      this.BGV_Budget.GridControl = this.GCBudget;
      this.BGV_Budget.Name = "BGV_Budget";
      this.BGV_Budget.OptionsView.EnableAppearanceEvenRow = true;
      this.BGV_Budget.OptionsView.EnableAppearanceOddRow = true;
      this.BGV_Budget.OptionsView.ShowFooter = true;
      this.BGV_Budget.OptionsView.ShowGroupPanel = false;
      this.BGV_Budget.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.BGV_Budget_CustomSummaryCalculate);
      this.BGV_Budget.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.BGV_Budget_CellValueChanged);
      // 
      // gridBand3
      // 
      this.gridBand3.Columns.Add(this.GCol_NID_BUDGET_GESTION);
      this.gridBand3.Columns.Add(this.GCol_NANNEE);
      this.gridBand3.Columns.Add(this.GCol_NCANNUM);
      this.gridBand3.Columns.Add(this.GCol_VCANLIB);
      this.gridBand3.Name = "gridBand3";
      this.gridBand3.RowCount = 2;
      this.gridBand3.VisibleIndex = 0;
      this.gridBand3.Width = 350;
      // 
      // GCol_NID_BUDGET_GESTION
      // 
      this.GCol_NID_BUDGET_GESTION.Caption = "NID_BUDGET_GESTION";
      this.GCol_NID_BUDGET_GESTION.FieldName = "NID_BUDGET_GESTION";
      this.GCol_NID_BUDGET_GESTION.Name = "GCol_NID_BUDGET_GESTION";
      this.GCol_NID_BUDGET_GESTION.Width = 82;
      // 
      // GCol_NANNEE
      // 
      this.GCol_NANNEE.Caption = "NANNEE";
      this.GCol_NANNEE.FieldName = "NANNEE";
      this.GCol_NANNEE.Name = "GCol_NANNEE";
      // 
      // GCol_NCANNUM
      // 
      this.GCol_NCANNUM.Caption = "Cpte Ana";
      this.GCol_NCANNUM.FieldName = "NCANNUM";
      this.GCol_NCANNUM.Name = "GCol_NCANNUM";
      this.GCol_NCANNUM.OptionsColumn.AllowEdit = false;
      this.GCol_NCANNUM.OptionsColumn.ReadOnly = true;
      this.GCol_NCANNUM.Visible = true;
      this.GCol_NCANNUM.Width = 94;
      // 
      // GCol_VCANLIB
      // 
      this.GCol_VCANLIB.Caption = "Intitulé";
      this.GCol_VCANLIB.FieldName = "VCANLIB";
      this.GCol_VCANLIB.Name = "GCol_VCANLIB";
      this.GCol_VCANLIB.OptionsColumn.AllowEdit = false;
      this.GCol_VCANLIB.OptionsColumn.ReadOnly = true;
      this.GCol_VCANLIB.Visible = true;
      this.GCol_VCANLIB.Width = 256;
      // 
      // gridBand1
      // 
      this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
      this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.gridBand1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.gridBand1.Caption = "OBJECTIFS";
      this.gridBand1.Columns.Add(this.GCol_NOBJCA);
      this.gridBand1.Columns.Add(this.GCol_NOBJRESULTANA_MTT);
      this.gridBand1.Columns.Add(this.GCol_NOBJRESULTANA_PC);
      this.gridBand1.Name = "gridBand1";
      this.gridBand1.RowCount = 2;
      this.gridBand1.VisibleIndex = 1;
      this.gridBand1.Width = 457;
      // 
      // GCol_NOBJCA
      // 
      this.GCol_NOBJCA.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
      this.GCol_NOBJCA.AppearanceCell.Options.UseBackColor = true;
      this.GCol_NOBJCA.Caption = "CA";
      this.GCol_NOBJCA.DisplayFormat.FormatString = "c0";
      this.GCol_NOBJCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NOBJCA.FieldName = "NOBJCA";
      this.GCol_NOBJCA.Name = "GCol_NOBJCA";
      this.GCol_NOBJCA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOBJCA", "{0:c0}")});
      this.GCol_NOBJCA.Visible = true;
      this.GCol_NOBJCA.Width = 159;
      // 
      // GCol_NOBJRESULTANA_MTT
      // 
      this.GCol_NOBJRESULTANA_MTT.Caption = "Résultat ana (en €)";
      this.GCol_NOBJRESULTANA_MTT.DisplayFormat.FormatString = "c0";
      this.GCol_NOBJRESULTANA_MTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NOBJRESULTANA_MTT.FieldName = "NOBJRESULTANA_MTT";
      this.GCol_NOBJRESULTANA_MTT.Name = "GCol_NOBJRESULTANA_MTT";
      this.GCol_NOBJRESULTANA_MTT.OptionsColumn.AllowEdit = false;
      this.GCol_NOBJRESULTANA_MTT.OptionsColumn.ReadOnly = true;
      this.GCol_NOBJRESULTANA_MTT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOBJRESULTANA_MTT", "{0:c0}")});
      this.GCol_NOBJRESULTANA_MTT.Visible = true;
      this.GCol_NOBJRESULTANA_MTT.Width = 149;
      // 
      // GCol_NOBJRESULTANA_PC
      // 
      this.GCol_NOBJRESULTANA_PC.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
      this.GCol_NOBJRESULTANA_PC.AppearanceCell.Options.UseBackColor = true;
      this.GCol_NOBJRESULTANA_PC.Caption = "Résultat ana (en %)";
      this.GCol_NOBJRESULTANA_PC.DisplayFormat.FormatString = "{0:n2} %";
      this.GCol_NOBJRESULTANA_PC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NOBJRESULTANA_PC.FieldName = "NOBJRESULTANA_PC";
      this.GCol_NOBJRESULTANA_PC.Name = "GCol_NOBJRESULTANA_PC";
      this.GCol_NOBJRESULTANA_PC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NOBJRESULTANA_PC", "{0:n1} %", "NOBJRESULTANA_PC")});
      this.GCol_NOBJRESULTANA_PC.Visible = true;
      this.GCol_NOBJRESULTANA_PC.Width = 149;
      // 
      // gridBand2
      // 
      this.gridBand2.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
      this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.gridBand2.AppearanceHeader.Options.UseBackColor = true;
      this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
      this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
      this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.gridBand2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.gridBand2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.gridBand2.Caption = "BUDGET";
      this.gridBand2.Columns.Add(this.GCol_NBUDGETCA);
      this.gridBand2.Columns.Add(this.GCol_NBUDGETRESULTANA_MTT);
      this.gridBand2.Columns.Add(this.GCol_NBUDGETRESULTANA_PC);
      this.gridBand2.Name = "gridBand2";
      this.gridBand2.RowCount = 2;
      this.gridBand2.VisibleIndex = 2;
      this.gridBand2.Width = 457;
      // 
      // GCol_NBUDGETCA
      // 
      this.GCol_NBUDGETCA.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
      this.GCol_NBUDGETCA.AppearanceCell.Options.UseBackColor = true;
      this.GCol_NBUDGETCA.Caption = "CA";
      this.GCol_NBUDGETCA.DisplayFormat.FormatString = "c0";
      this.GCol_NBUDGETCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NBUDGETCA.FieldName = "NBUDGETCA";
      this.GCol_NBUDGETCA.Name = "GCol_NBUDGETCA";
      this.GCol_NBUDGETCA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NBUDGETCA", "{0:c0}")});
      this.GCol_NBUDGETCA.Visible = true;
      this.GCol_NBUDGETCA.Width = 159;
      // 
      // GCol_NBUDGETRESULTANA_MTT
      // 
      this.GCol_NBUDGETRESULTANA_MTT.Caption = "Résultat ana (en €)";
      this.GCol_NBUDGETRESULTANA_MTT.DisplayFormat.FormatString = "c0";
      this.GCol_NBUDGETRESULTANA_MTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NBUDGETRESULTANA_MTT.FieldName = "NBUDGETRESULTANA_MTT";
      this.GCol_NBUDGETRESULTANA_MTT.Name = "GCol_NBUDGETRESULTANA_MTT";
      this.GCol_NBUDGETRESULTANA_MTT.OptionsColumn.AllowEdit = false;
      this.GCol_NBUDGETRESULTANA_MTT.OptionsColumn.ReadOnly = true;
      this.GCol_NBUDGETRESULTANA_MTT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NBUDGETRESULTANA_MTT", "{0:c0}")});
      this.GCol_NBUDGETRESULTANA_MTT.Visible = true;
      this.GCol_NBUDGETRESULTANA_MTT.Width = 149;
      // 
      // GCol_NBUDGETRESULTANA_PC
      // 
      this.GCol_NBUDGETRESULTANA_PC.AppearanceCell.BackColor = System.Drawing.Color.LightYellow;
      this.GCol_NBUDGETRESULTANA_PC.AppearanceCell.Options.UseBackColor = true;
      this.GCol_NBUDGETRESULTANA_PC.Caption = "Résultat ana (en %)";
      this.GCol_NBUDGETRESULTANA_PC.DisplayFormat.FormatString = "{0:n2} %";
      this.GCol_NBUDGETRESULTANA_PC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.GCol_NBUDGETRESULTANA_PC.FieldName = "NBUDGETRESULTANA_PC";
      this.GCol_NBUDGETRESULTANA_PC.Name = "GCol_NBUDGETRESULTANA_PC";
      this.GCol_NBUDGETRESULTANA_PC.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NBUDGETRESULTANA_PC", "{0:n1} %", "NBUDGETRESULTANA_PC")});
      this.GCol_NBUDGETRESULTANA_PC.Visible = true;
      this.GCol_NBUDGETRESULTANA_PC.Width = 149;
      // 
      // gridBand4
      // 
      this.gridBand4.Columns.Add(this.GCol_VCOMMENTAIRES);
      this.gridBand4.Name = "gridBand4";
      this.gridBand4.RowCount = 2;
      this.gridBand4.VisibleIndex = 3;
      this.gridBand4.Width = 528;
      // 
      // GCol_VCOMMENTAIRES
      // 
      this.GCol_VCOMMENTAIRES.Caption = "Commentaires";
      this.GCol_VCOMMENTAIRES.FieldName = "VCOMMENTAIRES";
      this.GCol_VCOMMENTAIRES.Name = "GCol_VCOMMENTAIRES";
      this.GCol_VCOMMENTAIRES.Visible = true;
      this.GCol_VCOMMENTAIRES.Width = 528;
      // 
      // TextEditNMONTANT
      // 
      this.TextEditNMONTANT.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
      this.TextEditNMONTANT.AutoHeight = false;
      this.TextEditNMONTANT.Name = "TextEditNMONTANT";
      this.TextEditNMONTANT.NullText = "0";
      // 
      // TextEditVCOMMENTAIRE
      // 
      this.TextEditVCOMMENTAIRE.AutoHeight = false;
      this.TextEditVCOMMENTAIRE.MaxLength = 1000;
      this.TextEditVCOMMENTAIRE.Name = "TextEditVCOMMENTAIRE";
      // 
      // GrpActions
      // 
      this.GrpActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.GrpActions.Controls.Add(this.BtnImportXLS);
      this.GrpActions.Controls.Add(this.BtnSaisonnalite);
      this.GrpActions.Controls.Add(this.BtnQuit);
      this.GrpActions.Controls.Add(this.BtnSave);
      this.GrpActions.Location = new System.Drawing.Point(12, 12);
      this.GrpActions.Name = "GrpActions";
      this.GrpActions.Size = new System.Drawing.Size(181, 1025);
      this.GrpActions.TabIndex = 7;
      this.GrpActions.TabStop = false;
      // 
      // BtnImportXLS
      // 
      this.BtnImportXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnImportXLS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnImportXLS.Location = new System.Drawing.Point(16, 110);
      this.BtnImportXLS.Name = "BtnImportXLS";
      this.BtnImportXLS.Size = new System.Drawing.Size(150, 45);
      this.BtnImportXLS.TabIndex = 3;
      this.BtnImportXLS.Text = "Importer Fichier EXCEL";
      this.BtnImportXLS.UseVisualStyleBackColor = true;
      this.BtnImportXLS.Click += new System.EventHandler(this.BtnImportXLS_Click);
      // 
      // BtnSaisonnalite
      // 
      this.BtnSaisonnalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnSaisonnalite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnSaisonnalite.Location = new System.Drawing.Point(16, 206);
      this.BtnSaisonnalite.Name = "BtnSaisonnalite";
      this.BtnSaisonnalite.Size = new System.Drawing.Size(150, 45);
      this.BtnSaisonnalite.TabIndex = 2;
      this.BtnSaisonnalite.Text = "Saisonnalité";
      this.BtnSaisonnalite.UseVisualStyleBackColor = true;
      this.BtnSaisonnalite.Click += new System.EventHandler(this.BtnSaisonnalite_Click);
      // 
      // BtnQuit
      // 
      this.BtnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnQuit.Location = new System.Drawing.Point(16, 974);
      this.BtnQuit.Name = "BtnQuit";
      this.BtnQuit.Size = new System.Drawing.Size(150, 45);
      this.BtnQuit.TabIndex = 1;
      this.BtnQuit.Text = "Fermer";
      this.BtnQuit.UseVisualStyleBackColor = true;
      // 
      // BtnSave
      // 
      this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnSave.Location = new System.Drawing.Point(16, 30);
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(150, 45);
      this.BtnSave.TabIndex = 0;
      this.BtnSave.Text = "Enregistrer";
      this.BtnSave.UseVisualStyleBackColor = true;
      this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // GrpCriteres
      // 
      this.GrpCriteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.GrpCriteres.Controls.Add(this.BtnValid);
      this.GrpCriteres.Controls.Add(this.DateEditAnnee);
      this.GrpCriteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.GrpCriteres.Location = new System.Drawing.Point(210, 53);
      this.GrpCriteres.Name = "GrpCriteres";
      this.GrpCriteres.Size = new System.Drawing.Size(1817, 73);
      this.GrpCriteres.TabIndex = 8;
      this.GrpCriteres.TabStop = false;
      this.GrpCriteres.Text = "Sélectionner l\'année";
      // 
      // BtnValid
      // 
      this.BtnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnValid.Location = new System.Drawing.Point(306, 27);
      this.BtnValid.Name = "BtnValid";
      this.BtnValid.Size = new System.Drawing.Size(98, 29);
      this.BtnValid.TabIndex = 11;
      this.BtnValid.Text = "Valider";
      this.BtnValid.UseVisualStyleBackColor = true;
      this.BtnValid.Click += new System.EventHandler(this.BtnValid_Click);
      // 
      // DateEditAnnee
      // 
      this.DateEditAnnee.EditValue = null;
      this.DateEditAnnee.Location = new System.Drawing.Point(70, 32);
      this.DateEditAnnee.Name = "DateEditAnnee";
      this.DateEditAnnee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DateEditAnnee.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DateEditAnnee.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
      this.DateEditAnnee.Properties.DisplayFormat.FormatString = "y";
      this.DateEditAnnee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.DateEditAnnee.Properties.EditFormat.FormatString = "y";
      this.DateEditAnnee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.DateEditAnnee.Properties.Mask.EditMask = "yyyy";
      this.DateEditAnnee.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.DateEditAnnee.Properties.ShowMonthHeaders = false;
      this.DateEditAnnee.Properties.ShowToday = false;
      this.DateEditAnnee.Properties.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
      this.DateEditAnnee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.DateEditAnnee.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
      this.DateEditAnnee.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
      this.DateEditAnnee.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
      this.DateEditAnnee.Size = new System.Drawing.Size(230, 20);
      this.DateEditAnnee.TabIndex = 10;
      // 
      // LblTitre
      // 
      this.LblTitre.AutoSize = true;
      this.LblTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.LblTitre.Location = new System.Drawing.Point(205, 12);
      this.LblTitre.Name = "LblTitre";
      this.LblTitre.Size = new System.Drawing.Size(254, 29);
      this.LblTitre.TabIndex = 9;
      this.LblTitre.Text = "Saisie des BUDGETS";
      // 
      // frmBudget_Gestion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.BtnQuit;
      this.ClientSize = new System.Drawing.Size(2039, 1049);
      this.Controls.Add(this.GCBudget);
      this.Controls.Add(this.GrpActions);
      this.Controls.Add(this.GrpCriteres);
      this.Controls.Add(this.LblTitre);
      this.Name = "frmBudget_Gestion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Saisie des budgets";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmBudget_Gestion_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GCBudget)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BGV_Budget)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TextEditNMONTANT)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TextEditVCOMMENTAIRE)).EndInit();
      this.GrpActions.ResumeLayout(false);
      this.GrpCriteres.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl GCBudget;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TextEditNMONTANT;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TextEditVCOMMENTAIRE;
    internal System.Windows.Forms.GroupBox GrpActions;
    internal System.Windows.Forms.Button BtnQuit;
    internal System.Windows.Forms.Button BtnSave;
    internal System.Windows.Forms.GroupBox GrpCriteres;
    internal System.Windows.Forms.Label LblTitre;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView BGV_Budget;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NID_BUDGET_GESTION;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NANNEE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NCANNUM;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_VCANLIB;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NOBJCA;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NBUDGETRESULTANA_PC;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NOBJRESULTANA_MTT;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NBUDGETCA;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NBUDGETRESULTANA_MTT;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_NOBJRESULTANA_PC;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GCol_VCOMMENTAIRES;
    private DevExpress.XtraEditors.DateEdit DateEditAnnee;
    internal System.Windows.Forms.Button BtnValid;
    internal System.Windows.Forms.Button BtnSaisonnalite;
    internal System.Windows.Forms.Button BtnImportXLS;
    private System.Windows.Forms.OpenFileDialog OFD;
  }
}