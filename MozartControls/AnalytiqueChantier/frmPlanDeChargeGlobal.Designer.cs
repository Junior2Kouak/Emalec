
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace MozartControls
{
  partial class frmPlanDeChargeGlobal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanDeChargeGlobal));
      this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.ColCAPAINTERNE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColTXCHARGE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColTXCHARGEAN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.gridPlanning = new DevExpress.XtraGrid.GridControl();
      this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
      this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.ColCANNUM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColCHAFF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColMONTANT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColINTITULE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColCHARGEPREV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.bandHeures = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.ColHEURES = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColHDEVIS = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColHREA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColHREST = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.ColHTOT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.bandChargePrevisionnelle = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
      this.ColRELIQUAT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
      this.cmdFermer = new MozartUC.apiButton();
      this.BtnExportXLS = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gridPlanning)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // gridBand2
      // 
      resources.ApplyResources(this.gridBand2, "gridBand2");
      this.gridBand2.Columns.Add(this.ColCAPAINTERNE);
      this.gridBand2.Columns.Add(this.ColTXCHARGE);
      this.gridBand2.Columns.Add(this.ColTXCHARGEAN);
      this.gridBand2.VisibleIndex = -1;
      // 
      // ColCAPAINTERNE
      // 
      resources.ApplyResources(this.ColCAPAINTERNE, "ColCAPAINTERNE");
      this.ColCAPAINTERNE.Name = "ColCAPAINTERNE";
      // 
      // ColTXCHARGE
      // 
      resources.ApplyResources(this.ColTXCHARGE, "ColTXCHARGE");
      this.ColTXCHARGE.Name = "ColTXCHARGE";
      // 
      // ColTXCHARGEAN
      // 
      resources.ApplyResources(this.ColTXCHARGEAN, "ColTXCHARGEAN");
      this.ColTXCHARGEAN.Name = "ColTXCHARGEAN";
      // 
      // gridPlanning
      // 
      resources.ApplyResources(this.gridPlanning, "gridPlanning");
      this.gridPlanning.LookAndFeel.SkinName = "Office 2016 Colorful";
      this.gridPlanning.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
      this.gridPlanning.LookAndFeel.UseDefaultLookAndFeel = false;
      this.gridPlanning.MainView = this.bandedGridView1;
      this.gridPlanning.Name = "gridPlanning";
      this.gridPlanning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
      // 
      // bandedGridView1
      // 
      this.bandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.bandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.bandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.bandedGridView1.Appearance.Empty.BackColor2 = ((System.Drawing.Color)(resources.GetObject("bandedGridView1.Appearance.Empty.BackColor2")));
      this.bandedGridView1.Appearance.Empty.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(234)))));
      this.bandedGridView1.Appearance.EvenRow.BackColor2 = ((System.Drawing.Color)(resources.GetObject("bandedGridView1.Appearance.EvenRow.BackColor2")));
      this.bandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.EvenRow.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.EvenRow.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.bandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(179)))));
      this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(201)))));
      this.bandedGridView1.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("bandedGridView1.Appearance.FilterPanel.BackColor2")));
      this.bandedGridView1.Appearance.FilterPanel.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.FilterPanel.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(114)))), ((int)(((byte)(113)))));
      this.bandedGridView1.Appearance.FixedLine.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandedGridView1.Appearance.FooterPanel.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandedGridView1.Appearance.GroupFooter.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.GroupFooter.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandedGridView1.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("bandedGridView1.Appearance.HeaderPanel.Font")));
      this.bandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.HeaderPanel.Options.UseFont = true;
      this.bandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.bandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.bandedGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.bandedGridView1.Appearance.OddRow.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.OddRow.Options.UseBorderColor = true;
      this.bandedGridView1.Appearance.OddRow.Options.UseFont = true;
      this.bandedGridView1.Appearance.OddRow.Options.UseForeColor = true;
      this.bandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.bandedGridView1.Appearance.Row.Options.UseBackColor = true;
      this.bandedGridView1.Appearance.Row.Options.UseBorderColor = true;
      this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.bandHeures,
            this.bandChargePrevisionnelle,
            this.gridBand4});
      this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColCANNUM,
            this.ColCHAFF,
            this.ColMONTANT,
            this.ColINTITULE,
            this.ColHEURES,
            this.ColHDEVIS,
            this.ColHREA,
            this.ColHREST,
            this.ColHTOT,
            this.ColCHARGEPREV,
            this.ColRELIQUAT});
      this.bandedGridView1.GridControl = this.gridPlanning;
      this.bandedGridView1.Name = "bandedGridView1";
      this.bandedGridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
      this.bandedGridView1.OptionsBehavior.Editable = false;
      this.bandedGridView1.OptionsBehavior.KeepGroupExpandedOnSorting = false;
      this.bandedGridView1.OptionsCustomization.AllowBandMoving = false;
      this.bandedGridView1.OptionsCustomization.AllowColumnMoving = false;
      this.bandedGridView1.OptionsCustomization.AllowGroup = false;
      this.bandedGridView1.OptionsCustomization.ShowBandsInCustomizationForm = false;
      this.bandedGridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
      this.bandedGridView1.OptionsMenu.EnableFooterMenu = false;
      this.bandedGridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
      this.bandedGridView1.OptionsPrint.AutoWidth = false;
      this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
      this.bandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
      this.bandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
      this.bandedGridView1.OptionsView.EnableAppearanceOddRow = true;
      this.bandedGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
      this.bandedGridView1.OptionsView.ShowFooter = true;
      this.bandedGridView1.OptionsView.ShowGroupPanel = false;
      this.bandedGridView1.PaintStyleName = "MixedXP";
      this.bandedGridView1.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.bandedGridView1_CustomDrawFooterCell);
      this.bandedGridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bandedGridView1_RowCellStyle);
      this.bandedGridView1.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.bandedGridView1_CustomSummaryCalculate);
      // 
      // gridBand1
      // 
      this.gridBand1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.gridBand1.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.gridBand1.AppearanceHeader.Options.UseBackColor = true;
      this.gridBand1.AppearanceHeader.Options.UseBorderColor = true;
      this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.gridBand1, "gridBand1");
      this.gridBand1.Columns.Add(this.ColCANNUM);
      this.gridBand1.Columns.Add(this.ColCHAFF);
      this.gridBand1.Columns.Add(this.ColMONTANT);
      this.gridBand1.Columns.Add(this.ColINTITULE);
      this.gridBand1.Columns.Add(this.ColCHARGEPREV);
      this.gridBand1.OptionsBand.ShowCaption = false;
      this.gridBand1.VisibleIndex = 0;
      // 
      // ColCANNUM
      // 
      this.ColCANNUM.AppearanceHeader.Options.UseTextOptions = true;
      this.ColCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColCANNUM, "ColCANNUM");
      this.ColCANNUM.FieldName = "NCANNUM";
      this.ColCANNUM.Name = "ColCANNUM";
      this.ColCANNUM.OptionsColumn.FixedWidth = true;
      this.ColCANNUM.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      // 
      // ColCHAFF
      // 
      this.ColCHAFF.AppearanceHeader.Options.UseTextOptions = true;
      this.ColCHAFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColCHAFF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColCHAFF, "ColCHAFF");
      this.ColCHAFF.FieldName = "CHAFF";
      this.ColCHAFF.Name = "ColCHAFF";
      this.ColCHAFF.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
      this.ColCHAFF.OptionsColumn.FixedWidth = true;
      this.ColCHAFF.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColCHAFF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColCHAFF.Summary"))), resources.GetString("ColCHAFF.Summary1"), resources.GetString("ColCHAFF.Summary2"))});
      // 
      // ColMONTANT
      // 
      this.ColMONTANT.AppearanceCell.Options.UseTextOptions = true;
      this.ColMONTANT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColMONTANT.AppearanceHeader.Options.UseTextOptions = true;
      this.ColMONTANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColMONTANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColMONTANT, "ColMONTANT");
      this.ColMONTANT.FieldName = "NPVHT";
      this.ColMONTANT.Name = "ColMONTANT";
      this.ColMONTANT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColMONTANT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColMONTANT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColMONTANT.Summary"))), resources.GetString("ColMONTANT.Summary1"), resources.GetString("ColMONTANT.Summary2"))});
      // 
      // ColINTITULE
      // 
      this.ColINTITULE.AppearanceHeader.Options.UseTextOptions = true;
      this.ColINTITULE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColINTITULE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColINTITULE, "ColINTITULE");
      this.ColINTITULE.FieldName = "VCANLIB";
      this.ColINTITULE.Name = "ColINTITULE";
      this.ColINTITULE.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColINTITULE.OptionsColumn.FixedWidth = true;
      this.ColINTITULE.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColINTITULE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColINTITULE.Summary"))), resources.GetString("ColINTITULE.Summary1"), resources.GetString("ColINTITULE.Summary2"))});
      // 
      // ColCHARGEPREV
      // 
      resources.ApplyResources(this.ColCHARGEPREV, "ColCHARGEPREV");
      this.ColCHARGEPREV.Name = "ColCHARGEPREV";
      this.ColCHARGEPREV.OptionsColumn.AllowShowHide = false;
      // 
      // bandHeures
      // 
      this.bandHeures.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandHeures.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandHeures.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("bandHeures.AppearanceHeader.Font")));
      this.bandHeures.AppearanceHeader.Options.UseBackColor = true;
      this.bandHeures.AppearanceHeader.Options.UseBorderColor = true;
      this.bandHeures.AppearanceHeader.Options.UseFont = true;
      this.bandHeures.AppearanceHeader.Options.UseForeColor = true;
      this.bandHeures.AppearanceHeader.Options.UseTextOptions = true;
      this.bandHeures.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.bandHeures.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.bandHeures, "bandHeures");
      this.bandHeures.Columns.Add(this.ColHEURES);
      this.bandHeures.Columns.Add(this.ColHDEVIS);
      this.bandHeures.Columns.Add(this.ColHREA);
      this.bandHeures.Columns.Add(this.ColHREST);
      this.bandHeures.Columns.Add(this.ColHTOT);
      this.bandHeures.VisibleIndex = 1;
      // 
      // ColHEURES
      // 
      resources.ApplyResources(this.ColHEURES, "ColHEURES");
      this.ColHEURES.Name = "ColHEURES";
      this.ColHEURES.OptionsColumn.AllowShowHide = false;
      this.ColHEURES.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColHEURES.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHEURES.Summary"))), resources.GetString("ColHEURES.Summary1"), resources.GetString("ColHEURES.Summary2"))});
      // 
      // ColHDEVIS
      // 
      this.ColHDEVIS.AppearanceCell.Options.UseTextOptions = true;
      this.ColHDEVIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColHDEVIS.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColHDEVIS.AppearanceHeader.Font")));
      this.ColHDEVIS.AppearanceHeader.Options.UseFont = true;
      this.ColHDEVIS.AppearanceHeader.Options.UseTextOptions = true;
      this.ColHDEVIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColHDEVIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColHDEVIS, "ColHDEVIS");
      this.ColHDEVIS.FieldName = "NHDEVIS";
      this.ColHDEVIS.Name = "ColHDEVIS";
      this.ColHDEVIS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
      this.ColHDEVIS.OptionsColumn.AllowMove = false;
      this.ColHDEVIS.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColHDEVIS.OptionsColumn.FixedWidth = true;
      this.ColHDEVIS.OptionsFilter.AllowFilter = false;
      this.ColHDEVIS.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColHDEVIS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHDEVIS.Summary"))), resources.GetString("ColHDEVIS.Summary1"), resources.GetString("ColHDEVIS.Summary2"))});
      // 
      // ColHREA
      // 
      this.ColHREA.AppearanceCell.Options.UseTextOptions = true;
      this.ColHREA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColHREA.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColHREA.AppearanceHeader.Font")));
      this.ColHREA.AppearanceHeader.Options.UseFont = true;
      this.ColHREA.AppearanceHeader.Options.UseTextOptions = true;
      this.ColHREA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColHREA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColHREA, "ColHREA");
      this.ColHREA.FieldName = "NHREA";
      this.ColHREA.Name = "ColHREA";
      this.ColHREA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
      this.ColHREA.OptionsColumn.AllowMove = false;
      this.ColHREA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColHREA.OptionsColumn.FixedWidth = true;
      this.ColHREA.OptionsFilter.AllowFilter = false;
      this.ColHREA.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColHREA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHREA.Summary"))), resources.GetString("ColHREA.Summary1"), resources.GetString("ColHREA.Summary2"))});
      // 
      // ColHREST
      // 
      this.ColHREST.AppearanceCell.Options.UseTextOptions = true;
      this.ColHREST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColHREST.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColHREST.AppearanceHeader.Font")));
      this.ColHREST.AppearanceHeader.Options.UseFont = true;
      this.ColHREST.AppearanceHeader.Options.UseTextOptions = true;
      this.ColHREST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColHREST.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColHREST, "ColHREST");
      this.ColHREST.FieldName = "NHREST";
      this.ColHREST.Name = "ColHREST";
      this.ColHREST.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
      this.ColHREST.OptionsColumn.AllowMove = false;
      this.ColHREST.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColHREST.OptionsColumn.FixedWidth = true;
      this.ColHREST.OptionsFilter.AllowFilter = false;
      this.ColHREST.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColHREST.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHREST.Summary"))), resources.GetString("ColHREST.Summary1"), resources.GetString("ColHREST.Summary2"))});
      // 
      // ColHTOT
      // 
      this.ColHTOT.AppearanceCell.Options.UseTextOptions = true;
      this.ColHTOT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColHTOT.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColHTOT.AppearanceHeader.Font")));
      this.ColHTOT.AppearanceHeader.Options.UseFont = true;
      this.ColHTOT.AppearanceHeader.Options.UseTextOptions = true;
      this.ColHTOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColHTOT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.ColHTOT, "ColHTOT");
      this.ColHTOT.FieldName = "NHTOT";
      this.ColHTOT.Name = "ColHTOT";
      this.ColHTOT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
      this.ColHTOT.OptionsColumn.AllowMove = false;
      this.ColHTOT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColHTOT.OptionsColumn.FixedWidth = true;
      this.ColHTOT.OptionsFilter.AllowFilter = false;
      this.ColHTOT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColHTOT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHTOT.Summary"))), resources.GetString("ColHTOT.Summary1"), resources.GetString("ColHTOT.Summary2")),
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHTOT.Summary3"))), resources.GetString("ColHTOT.Summary4"), resources.GetString("ColHTOT.Summary5")),
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHTOT.Summary6"))), resources.GetString("ColHTOT.Summary7"), resources.GetString("ColHTOT.Summary8")),
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColHTOT.Summary9"))), resources.GetString("ColHTOT.Summary10"), resources.GetString("ColHTOT.Summary11"))});
      // 
      // bandChargePrevisionnelle
      // 
      this.bandChargePrevisionnelle.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandChargePrevisionnelle.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.bandChargePrevisionnelle.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("bandChargePrevisionnelle.AppearanceHeader.Font")));
      this.bandChargePrevisionnelle.AppearanceHeader.Options.UseBackColor = true;
      this.bandChargePrevisionnelle.AppearanceHeader.Options.UseBorderColor = true;
      this.bandChargePrevisionnelle.AppearanceHeader.Options.UseFont = true;
      this.bandChargePrevisionnelle.AppearanceHeader.Options.UseTextOptions = true;
      this.bandChargePrevisionnelle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.bandChargePrevisionnelle.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.bandChargePrevisionnelle, "bandChargePrevisionnelle");
      this.bandChargePrevisionnelle.VisibleIndex = 2;
      // 
      // gridBand4
      // 
      this.gridBand4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.gridBand4.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(209)))), ((int)(((byte)(170)))));
      this.gridBand4.AppearanceHeader.Options.UseBackColor = true;
      this.gridBand4.AppearanceHeader.Options.UseBorderColor = true;
      this.gridBand4.AppearanceHeader.Options.UseForeColor = true;
      resources.ApplyResources(this.gridBand4, "gridBand4");
      this.gridBand4.Columns.Add(this.ColRELIQUAT);
      this.gridBand4.OptionsBand.ShowCaption = false;
      this.gridBand4.VisibleIndex = 3;
      // 
      // ColRELIQUAT
      // 
      this.ColRELIQUAT.AppearanceCell.Options.UseTextOptions = true;
      this.ColRELIQUAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.ColRELIQUAT.AppearanceHeader.Options.UseTextOptions = true;
      this.ColRELIQUAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      resources.ApplyResources(this.ColRELIQUAT, "ColRELIQUAT");
      this.ColRELIQUAT.FieldName = "RELIQUAT";
      this.ColRELIQUAT.Name = "ColRELIQUAT";
      this.ColRELIQUAT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
      this.ColRELIQUAT.OptionsColumn.FixedWidth = true;
      this.ColRELIQUAT.OptionsFilter.AllowFilter = false;
      this.ColRELIQUAT.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
      this.ColRELIQUAT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("ColRELIQUAT.Summary"))), resources.GetString("ColRELIQUAT.Summary1"), resources.GetString("ColRELIQUAT.Summary2"))});
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.SystemColors.Control;
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // BtnExportXLS
      // 
      resources.ApplyResources(this.BtnExportXLS, "BtnExportXLS");
      this.BtnExportXLS.Name = "BtnExportXLS";
      this.BtnExportXLS.Tag = "136";
      this.BtnExportXLS.UseVisualStyleBackColor = true;
      this.BtnExportXLS.Click += new System.EventHandler(this.BtnExportXLS_Click);
      // 
      // frmPlanDeChargeGlobal
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.BtnExportXLS);
      this.Controls.Add(this.gridPlanning);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmPlanDeChargeGlobal";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPlanDeChargeGlobal_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridPlanning)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private GridControl gridPlanning;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCAPAINTERNE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColTXCHARGE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColTXCHARGEAN;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCANNUM;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCHAFF;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColMONTANT;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColINTITULE;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColCHARGEPREV;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColHEURES;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColHDEVIS;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColHREA;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColHREST;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColHTOT;
    private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColRELIQUAT;
    internal System.Windows.Forms.Button BtnExportXLS;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandHeures;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandChargePrevisionnelle;
    private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
  }
}