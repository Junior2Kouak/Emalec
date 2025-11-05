
namespace MozartCS
{
  partial class UCContratClient : UCWizardBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContratClient));
      this.GCContrat = new DevExpress.XtraGrid.GridControl();
      this.GVContrat = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColCHECK = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemCheckEditCHECK = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.GColNTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.LblTitre = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.GCContrat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVContrat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).BeginInit();
      this.SuspendLayout();
      // 
      // GCContrat
      // 
      resources.ApplyResources(this.GCContrat, "GCContrat");
      this.GCContrat.MainView = this.GVContrat;
      this.GCContrat.Name = "GCContrat";
      this.GCContrat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemCheckEditCHECK});
      this.GCContrat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVContrat});
      // 
      // GVContrat
      // 
      this.GVContrat.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.ColumnFilterButton.Options.UseBackColor = true;
      this.GVContrat.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
      this.GVContrat.Appearance.ColumnFilterButton.Options.UseForeColor = true;
      this.GVContrat.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVContrat.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVContrat.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
      this.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
      this.GVContrat.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
      this.GVContrat.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.Empty.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVContrat.Appearance.Empty.BackColor2")));
      this.GVContrat.Appearance.Empty.Options.UseBackColor = true;
      this.GVContrat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVContrat.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVContrat.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.EvenRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.EvenRow.Options.UseBorderColor = true;
      this.GVContrat.Appearance.EvenRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.FilterCloseButton.Options.UseBackColor = true;
      this.GVContrat.Appearance.FilterCloseButton.Options.UseBorderColor = true;
      this.GVContrat.Appearance.FilterCloseButton.Options.UseForeColor = true;
      this.GVContrat.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVContrat.Appearance.FilterPanel.BackColor2")));
      this.GVContrat.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.FilterPanel.Options.UseBackColor = true;
      this.GVContrat.Appearance.FilterPanel.Options.UseForeColor = true;
      this.GVContrat.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVContrat.Appearance.FixedLine.Options.UseBackColor = true;
      this.GVContrat.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
      this.GVContrat.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.FocusedCell.Options.UseBackColor = true;
      this.GVContrat.Appearance.FocusedCell.Options.UseForeColor = true;
      this.GVContrat.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
      this.GVContrat.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
      this.GVContrat.Appearance.FocusedRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.FocusedRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVContrat.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.FooterPanel.Options.UseBackColor = true;
      this.GVContrat.Appearance.FooterPanel.Options.UseBorderColor = true;
      this.GVContrat.Appearance.FooterPanel.Options.UseForeColor = true;
      this.GVContrat.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVContrat.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVContrat.Appearance.GroupButton.Options.UseBackColor = true;
      this.GVContrat.Appearance.GroupButton.Options.UseBorderColor = true;
      this.GVContrat.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVContrat.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVContrat.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.GroupFooter.Options.UseBackColor = true;
      this.GVContrat.Appearance.GroupFooter.Options.UseBorderColor = true;
      this.GVContrat.Appearance.GroupFooter.Options.UseForeColor = true;
      this.GVContrat.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVContrat.Appearance.GroupPanel.BackColor2")));
      this.GVContrat.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.GroupPanel.Options.UseBackColor = true;
      this.GVContrat.Appearance.GroupPanel.Options.UseForeColor = true;
      this.GVContrat.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVContrat.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVContrat.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.GroupRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.GroupRow.Options.UseBorderColor = true;
      this.GVContrat.Appearance.GroupRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVContrat.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVContrat.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("GVContrat.Appearance.HeaderPanel.Font")));
      this.GVContrat.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.GVContrat.Appearance.HeaderPanel.Options.UseBorderColor = true;
      this.GVContrat.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVContrat.Appearance.HeaderPanel.Options.UseForeColor = true;
      this.GVContrat.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
      this.GVContrat.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVContrat.Appearance.HideSelectionRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.HideSelectionRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVContrat.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVContrat.Appearance.HorzLine.Options.UseBackColor = true;
      this.GVContrat.Appearance.HorzLine.Options.UseBorderColor = true;
      this.GVContrat.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.OddRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.OddRow.Options.UseBorderColor = true;
      this.GVContrat.Appearance.OddRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
      this.GVContrat.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("GVContrat.Appearance.Preview.Font")));
      this.GVContrat.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVContrat.Appearance.Preview.Options.UseBackColor = true;
      this.GVContrat.Appearance.Preview.Options.UseFont = true;
      this.GVContrat.Appearance.Preview.Options.UseForeColor = true;
      this.GVContrat.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("GVContrat.Appearance.Row.Font")));
      this.GVContrat.Appearance.Row.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.Row.Options.UseBackColor = true;
      this.GVContrat.Appearance.Row.Options.UseFont = true;
      this.GVContrat.Appearance.Row.Options.UseForeColor = true;
      this.GVContrat.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVContrat.Appearance.RowSeparator.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVContrat.Appearance.RowSeparator.BackColor2")));
      this.GVContrat.Appearance.RowSeparator.Options.UseBackColor = true;
      this.GVContrat.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
      this.GVContrat.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
      this.GVContrat.Appearance.SelectedRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.SelectedRow.Options.UseForeColor = true;
      this.GVContrat.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
      this.GVContrat.Appearance.TopNewRow.Options.UseBackColor = true;
      this.GVContrat.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVContrat.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVContrat.Appearance.VertLine.Options.UseBackColor = true;
      this.GVContrat.Appearance.VertLine.Options.UseBorderColor = true;
      this.GVContrat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCHECK,
            this.GColNTYPECONTRAT,
            this.GColVTYPECONTRAT});
      this.GVContrat.GridControl = this.GCContrat;
      this.GVContrat.Name = "GVContrat";
      this.GVContrat.OptionsView.EnableAppearanceEvenRow = true;
      this.GVContrat.OptionsView.EnableAppearanceOddRow = true;
      this.GVContrat.OptionsView.ShowAutoFilterRow = true;
      this.GVContrat.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
      this.GVContrat.OptionsView.ShowFooter = true;
      this.GVContrat.OptionsView.ShowGroupPanel = false;
      this.GVContrat.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GVContrat_CustomDrawFooter);
      // 
      // GColCHECK
      // 
      this.GColCHECK.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCHECK, "GColCHECK");
      this.GColCHECK.ColumnEdit = this.RepositoryItemCheckEditCHECK;
      this.GColCHECK.FieldName = "BCONTRATAFFECTE";
      this.GColCHECK.Name = "GColCHECK";
      // 
      // RepositoryItemCheckEditCHECK
      // 
      resources.ApplyResources(this.RepositoryItemCheckEditCHECK, "RepositoryItemCheckEditCHECK");
      this.RepositoryItemCheckEditCHECK.Name = "RepositoryItemCheckEditCHECK";
      this.RepositoryItemCheckEditCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
      this.RepositoryItemCheckEditCHECK.ValueChecked = 1;
      this.RepositoryItemCheckEditCHECK.ValueUnchecked = 0;
      this.RepositoryItemCheckEditCHECK.CheckedChanged += new System.EventHandler(this.RepositoryItemCheckEditCHECK_CheckedChanged);
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
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // UCContratClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.GCContrat);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCContratClient";
      ((System.ComponentModel.ISupportInitialize)(this.GCContrat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVContrat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal DevExpress.XtraGrid.GridControl GCContrat;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVContrat;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCHECK;
    internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepositoryItemCheckEditCHECK;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNTYPECONTRAT;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVTYPECONTRAT;
    internal System.Windows.Forms.Label LblTitre;
  }
}
