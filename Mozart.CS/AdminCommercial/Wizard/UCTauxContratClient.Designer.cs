
namespace MozartCS
{
  partial class UCTauxContratClient : UCWizardBase
  {
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTauxContratClient));
      this.GCTauxContrat = new DevExpress.XtraGrid.GridControl();
      this.GVTauxContrat = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColNTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColTauxContVPAYS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColTauxContNCLICONTHOR = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.GColTauxContNCLICONTDEP = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColTauxContNCLICONTHORSAM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColTauxCont5 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemCheckEditCHECK = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.LblTitre = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.GCTauxContrat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVTauxContrat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).BeginInit();
      this.SuspendLayout();
      // 
      // GCTauxContrat
      // 
      resources.ApplyResources(this.GCTauxContrat, "GCTauxContrat");
      this.GCTauxContrat.MainView = this.GVTauxContrat;
      this.GCTauxContrat.Name = "GCTauxContrat";
      this.GCTauxContrat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemCheckEditCHECK,
            this.RepositoryItemTextEdit1});
      this.GCTauxContrat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVTauxContrat});
      // 
      // GVTauxContrat
      // 
      this.GVTauxContrat.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.ColumnFilterButton.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.ColumnFilterButton.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.Empty.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVTauxContrat.Appearance.Empty.BackColor2")));
      this.GVTauxContrat.Appearance.Empty.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVTauxContrat.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVTauxContrat.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.EvenRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.EvenRow.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.EvenRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.FilterCloseButton.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FilterCloseButton.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.FilterCloseButton.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVTauxContrat.Appearance.FilterPanel.BackColor2")));
      this.GVTauxContrat.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.FilterPanel.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FilterPanel.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVTauxContrat.Appearance.FixedLine.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
      this.GVTauxContrat.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.FocusedCell.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FocusedCell.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
      this.GVTauxContrat.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
      this.GVTauxContrat.Appearance.FocusedRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FocusedRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVTauxContrat.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.FooterPanel.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.FooterPanel.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.FooterPanel.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVTauxContrat.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVTauxContrat.Appearance.GroupButton.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.GroupButton.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVTauxContrat.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVTauxContrat.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.GroupFooter.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.GroupFooter.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.GroupFooter.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVTauxContrat.Appearance.GroupPanel.BackColor2")));
      this.GVTauxContrat.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.GroupPanel.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.GroupPanel.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVTauxContrat.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVTauxContrat.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.GroupRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.GroupRow.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.GroupRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVTauxContrat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVTauxContrat.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("GVTauxContrat.Appearance.HeaderPanel.Font")));
      this.GVTauxContrat.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.HeaderPanel.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVTauxContrat.Appearance.HeaderPanel.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GVTauxContrat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GVTauxContrat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GVTauxContrat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.GVTauxContrat.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
      this.GVTauxContrat.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVTauxContrat.Appearance.HideSelectionRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.HideSelectionRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVTauxContrat.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVTauxContrat.Appearance.HorzLine.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.HorzLine.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.OddRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.OddRow.Options.UseBorderColor = true;
      this.GVTauxContrat.Appearance.OddRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
      this.GVTauxContrat.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("GVTauxContrat.Appearance.Preview.Font")));
      this.GVTauxContrat.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVTauxContrat.Appearance.Preview.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.Preview.Options.UseFont = true;
      this.GVTauxContrat.Appearance.Preview.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("GVTauxContrat.Appearance.Row.Font")));
      this.GVTauxContrat.Appearance.Row.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.Row.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.Row.Options.UseFont = true;
      this.GVTauxContrat.Appearance.Row.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVTauxContrat.Appearance.RowSeparator.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVTauxContrat.Appearance.RowSeparator.BackColor2")));
      this.GVTauxContrat.Appearance.RowSeparator.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
      this.GVTauxContrat.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
      this.GVTauxContrat.Appearance.SelectedRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.SelectedRow.Options.UseForeColor = true;
      this.GVTauxContrat.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
      this.GVTauxContrat.Appearance.TopNewRow.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVTauxContrat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVTauxContrat.Appearance.VertLine.Options.UseBackColor = true;
      this.GVTauxContrat.Appearance.VertLine.Options.UseBorderColor = true;
      this.GVTauxContrat.ColumnPanelRowHeight = 40;
      this.GVTauxContrat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColNTYPECONTRAT,
            this.GColVTYPECONTRAT,
            this.GColTauxContVPAYS,
            this.GColTauxContNCLICONTHOR,
            this.GColTauxContNCLICONTDEP,
            this.GColTauxContNCLICONTHORSAM,
            this.GColTauxCont5});
      this.GVTauxContrat.GridControl = this.GCTauxContrat;
      this.GVTauxContrat.Name = "GVTauxContrat";
      this.GVTauxContrat.OptionsView.EnableAppearanceEvenRow = true;
      this.GVTauxContrat.OptionsView.EnableAppearanceOddRow = true;
      this.GVTauxContrat.OptionsView.ShowAutoFilterRow = true;
      this.GVTauxContrat.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
      this.GVTauxContrat.OptionsView.ShowFooter = true;
      this.GVTauxContrat.OptionsView.ShowGroupPanel = false;
      this.GVTauxContrat.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GVTauxContrat_CustomDrawCell);
      // 
      // GColNTYPECONTRAT
      // 
      resources.ApplyResources(this.GColNTYPECONTRAT, "GColNTYPECONTRAT");
      this.GColNTYPECONTRAT.FieldName = "NTYPECONTRAT";
      this.GColNTYPECONTRAT.Name = "GColNTYPECONTRAT";
      this.GColNTYPECONTRAT.OptionsColumn.ReadOnly = true;
      // 
      // GColVTYPECONTRAT
      // 
      this.GColVTYPECONTRAT.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVTYPECONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVTYPECONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVTYPECONTRAT, "GColVTYPECONTRAT");
      this.GColVTYPECONTRAT.FieldName = "VTYPECONTRAT";
      this.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT";
      this.GColVTYPECONTRAT.OptionsColumn.AllowEdit = false;
      this.GColVTYPECONTRAT.OptionsColumn.ReadOnly = true;
      this.GColVTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColTauxContVPAYS
      // 
      resources.ApplyResources(this.GColTauxContVPAYS, "GColTauxContVPAYS");
      this.GColTauxContVPAYS.FieldName = "VPAYS";
      this.GColTauxContVPAYS.Name = "GColTauxContVPAYS";
      this.GColTauxContVPAYS.OptionsColumn.AllowEdit = false;
      this.GColTauxContVPAYS.OptionsColumn.ReadOnly = true;
      // 
      // GColTauxContNCLICONTHOR
      // 
      this.GColTauxContNCLICONTHOR.AppearanceCell.Options.UseTextOptions = true;
      this.GColTauxContNCLICONTHOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.GColTauxContNCLICONTHOR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColTauxContNCLICONTHOR, "GColTauxContNCLICONTHOR");
      this.GColTauxContNCLICONTHOR.ColumnEdit = this.RepositoryItemTextEdit1;
      this.GColTauxContNCLICONTHOR.FieldName = "NCLICONTHOR";
      this.GColTauxContNCLICONTHOR.Name = "GColTauxContNCLICONTHOR";
      // 
      // RepositoryItemTextEdit1
      // 
      this.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
      this.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.RepositoryItemTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.RepositoryItemTextEdit1, "RepositoryItemTextEdit1");
      this.RepositoryItemTextEdit1.Mask.EditMask = resources.GetString("RepositoryItemTextEdit1.Mask.EditMask");
      this.RepositoryItemTextEdit1.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("RepositoryItemTextEdit1.Mask.MaskType")));
      this.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")));
      this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
      this.RepositoryItemTextEdit1.Click += new System.EventHandler(this.RepositoryItemTextEdit1_Click);
      this.RepositoryItemTextEdit1.Enter += new System.EventHandler(this.RepositoryItemTextEdit1_Enter);
      this.RepositoryItemTextEdit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RepositoryItemTextEdit1_MouseDown);
      // 
      // GColTauxContNCLICONTDEP
      // 
      resources.ApplyResources(this.GColTauxContNCLICONTDEP, "GColTauxContNCLICONTDEP");
      this.GColTauxContNCLICONTDEP.ColumnEdit = this.RepositoryItemTextEdit1;
      this.GColTauxContNCLICONTDEP.FieldName = "NCLICONTDEP";
      this.GColTauxContNCLICONTDEP.Name = "GColTauxContNCLICONTDEP";
      // 
      // GColTauxContNCLICONTHORSAM
      // 
      resources.ApplyResources(this.GColTauxContNCLICONTHORSAM, "GColTauxContNCLICONTHORSAM");
      this.GColTauxContNCLICONTHORSAM.ColumnEdit = this.RepositoryItemTextEdit1;
      this.GColTauxContNCLICONTHORSAM.FieldName = "NCLICONTHORSAM";
      this.GColTauxContNCLICONTHORSAM.Name = "GColTauxContNCLICONTHORSAM";
      // 
      // GColTauxCont5
      // 
      resources.ApplyResources(this.GColTauxCont5, "GColTauxCont5");
      this.GColTauxCont5.ColumnEdit = this.RepositoryItemTextEdit1;
      this.GColTauxCont5.FieldName = "NCLICONTHORNUIDIM";
      this.GColTauxCont5.Name = "GColTauxCont5";
      // 
      // RepositoryItemCheckEditCHECK
      // 
      this.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK";
      this.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
      this.RepositoryItemCheckEditCHECK.ValueChecked = 1;
      this.RepositoryItemCheckEditCHECK.ValueUnchecked = 0;
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // UCTauxContratClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.GCTauxContrat);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCTauxContratClient";
      ((System.ComponentModel.ISupportInitialize)(this.GCTauxContrat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVTauxContrat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemTextEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal DevExpress.XtraGrid.GridControl GCTauxContrat;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVTauxContrat;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNTYPECONTRAT;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVTYPECONTRAT;
    internal DevExpress.XtraGrid.Columns.GridColumn GColTauxContVPAYS;
    internal DevExpress.XtraGrid.Columns.GridColumn GColTauxContNCLICONTHOR;
    internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
    internal DevExpress.XtraGrid.Columns.GridColumn GColTauxContNCLICONTDEP;
    internal DevExpress.XtraGrid.Columns.GridColumn GColTauxContNCLICONTHORSAM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColTauxCont5;
    internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepositoryItemCheckEditCHECK;
    internal System.Windows.Forms.Label LblTitre;
  }
}
