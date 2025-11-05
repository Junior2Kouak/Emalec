
namespace MozartCS
{
  partial class frmPrixClientContratPays_ListePays
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrixClientContratPays_ListePays));
      this.GCPays = new DevExpress.XtraGrid.GridControl();
      this.GVPays = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColCHECK = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemCheckEditCHECK = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.GColNTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.cmdValider = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GCPays)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVPays)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).BeginInit();
      this.SuspendLayout();
      // 
      // GCPays
      // 
      resources.ApplyResources(this.GCPays, "GCPays");
      this.GCPays.MainView = this.GVPays;
      this.GCPays.Name = "GCPays";
      this.GCPays.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepositoryItemCheckEditCHECK});
      this.GCPays.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVPays});
      // 
      // GVPays
      // 
      this.GVPays.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.ColumnFilterButton.Options.UseBackColor = true;
      this.GVPays.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
      this.GVPays.Appearance.ColumnFilterButton.Options.UseForeColor = true;
      this.GVPays.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVPays.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVPays.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
      this.GVPays.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
      this.GVPays.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
      this.GVPays.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.Empty.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVPays.Appearance.Empty.BackColor2")));
      this.GVPays.Appearance.Empty.Options.UseBackColor = true;
      this.GVPays.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVPays.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
      this.GVPays.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.EvenRow.Options.UseBackColor = true;
      this.GVPays.Appearance.EvenRow.Options.UseBorderColor = true;
      this.GVPays.Appearance.EvenRow.Options.UseForeColor = true;
      this.GVPays.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.FilterCloseButton.Options.UseBackColor = true;
      this.GVPays.Appearance.FilterCloseButton.Options.UseBorderColor = true;
      this.GVPays.Appearance.FilterCloseButton.Options.UseForeColor = true;
      this.GVPays.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.FilterPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVPays.Appearance.FilterPanel.BackColor2")));
      this.GVPays.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.FilterPanel.Options.UseBackColor = true;
      this.GVPays.Appearance.FilterPanel.Options.UseForeColor = true;
      this.GVPays.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVPays.Appearance.FixedLine.Options.UseBackColor = true;
      this.GVPays.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
      this.GVPays.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.FocusedCell.Options.UseBackColor = true;
      this.GVPays.Appearance.FocusedCell.Options.UseForeColor = true;
      this.GVPays.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
      this.GVPays.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
      this.GVPays.Appearance.FocusedRow.Options.UseBackColor = true;
      this.GVPays.Appearance.FocusedRow.Options.UseForeColor = true;
      this.GVPays.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
      this.GVPays.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.FooterPanel.Options.UseBackColor = true;
      this.GVPays.Appearance.FooterPanel.Options.UseBorderColor = true;
      this.GVPays.Appearance.FooterPanel.Options.UseForeColor = true;
      this.GVPays.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVPays.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
      this.GVPays.Appearance.GroupButton.Options.UseBackColor = true;
      this.GVPays.Appearance.GroupButton.Options.UseBorderColor = true;
      this.GVPays.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVPays.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVPays.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.GroupFooter.Options.UseBackColor = true;
      this.GVPays.Appearance.GroupFooter.Options.UseBorderColor = true;
      this.GVPays.Appearance.GroupFooter.Options.UseForeColor = true;
      this.GVPays.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.GroupPanel.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVPays.Appearance.GroupPanel.BackColor2")));
      this.GVPays.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.GroupPanel.Options.UseBackColor = true;
      this.GVPays.Appearance.GroupPanel.Options.UseForeColor = true;
      this.GVPays.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVPays.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
      this.GVPays.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.GroupRow.Options.UseBackColor = true;
      this.GVPays.Appearance.GroupRow.Options.UseBorderColor = true;
      this.GVPays.Appearance.GroupRow.Options.UseForeColor = true;
      this.GVPays.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVPays.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
      this.GVPays.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("GVPays.Appearance.HeaderPanel.Font")));
      this.GVPays.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.HeaderPanel.Options.UseBackColor = true;
      this.GVPays.Appearance.HeaderPanel.Options.UseBorderColor = true;
      this.GVPays.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVPays.Appearance.HeaderPanel.Options.UseForeColor = true;
      this.GVPays.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
      this.GVPays.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVPays.Appearance.HideSelectionRow.Options.UseBackColor = true;
      this.GVPays.Appearance.HideSelectionRow.Options.UseForeColor = true;
      this.GVPays.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVPays.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVPays.Appearance.HorzLine.Options.UseBackColor = true;
      this.GVPays.Appearance.HorzLine.Options.UseBorderColor = true;
      this.GVPays.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.OddRow.Options.UseBackColor = true;
      this.GVPays.Appearance.OddRow.Options.UseBorderColor = true;
      this.GVPays.Appearance.OddRow.Options.UseForeColor = true;
      this.GVPays.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
      this.GVPays.Appearance.Preview.Font = ((System.Drawing.Font)(resources.GetObject("GVPays.Appearance.Preview.Font")));
      this.GVPays.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
      this.GVPays.Appearance.Preview.Options.UseBackColor = true;
      this.GVPays.Appearance.Preview.Options.UseFont = true;
      this.GVPays.Appearance.Preview.Options.UseForeColor = true;
      this.GVPays.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("GVPays.Appearance.Row.Font")));
      this.GVPays.Appearance.Row.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.Row.Options.UseBackColor = true;
      this.GVPays.Appearance.Row.Options.UseFont = true;
      this.GVPays.Appearance.Row.Options.UseForeColor = true;
      this.GVPays.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
      this.GVPays.Appearance.RowSeparator.BackColor2 = ((System.Drawing.Color)(resources.GetObject("GVPays.Appearance.RowSeparator.BackColor2")));
      this.GVPays.Appearance.RowSeparator.Options.UseBackColor = true;
      this.GVPays.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
      this.GVPays.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
      this.GVPays.Appearance.SelectedRow.Options.UseBackColor = true;
      this.GVPays.Appearance.SelectedRow.Options.UseForeColor = true;
      this.GVPays.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
      this.GVPays.Appearance.TopNewRow.Options.UseBackColor = true;
      this.GVPays.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
      this.GVPays.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
      this.GVPays.Appearance.VertLine.Options.UseBackColor = true;
      this.GVPays.Appearance.VertLine.Options.UseBorderColor = true;
      this.GVPays.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCHECK,
            this.GColNTYPECONTRAT,
            this.GColVTYPECONTRAT});
      this.GVPays.GridControl = this.GCPays;
      this.GVPays.Name = "GVPays";
      this.GVPays.OptionsView.EnableAppearanceEvenRow = true;
      this.GVPays.OptionsView.EnableAppearanceOddRow = true;
      this.GVPays.OptionsView.ShowAutoFilterRow = true;
      this.GVPays.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
      this.GVPays.OptionsView.ShowFooter = true;
      this.GVPays.OptionsView.ShowGroupPanel = false;
      this.GVPays.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GVPays_CustomDrawFooter);
      // 
      // GColCHECK
      // 
      this.GColCHECK.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCHECK, "GColCHECK");
      this.GColCHECK.ColumnEdit = this.RepositoryItemCheckEditCHECK;
      this.GColCHECK.FieldName = "BPAYSSELECT";
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
      this.GColVTYPECONTRAT.FieldName = "VPAYSNOM";
      this.GColVTYPECONTRAT.Name = "GColVTYPECONTRAT";
      this.GColVTYPECONTRAT.OptionsColumn.AllowEdit = false;
      this.GColVTYPECONTRAT.OptionsColumn.ReadOnly = true;
      this.GColVTYPECONTRAT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // BtnCancel
      // 
      resources.ApplyResources(this.BtnCancel, "BtnCancel");
      this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.UseVisualStyleBackColor = true;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // frmPrixClientContratPays_ListePays
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.BtnCancel;
      this.Controls.Add(this.GCPays);
      this.Controls.Add(this.BtnCancel);
      this.Controls.Add(this.cmdValider);
      this.Name = "frmPrixClientContratPays_ListePays";
      this.Load += new System.EventHandler(this.frmPrixClientContratPays_ListePays_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GCPays)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVPays)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemCheckEditCHECK)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    internal DevExpress.XtraGrid.GridControl GCPays;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVPays;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCHECK;
    internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepositoryItemCheckEditCHECK;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNTYPECONTRAT;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVTYPECONTRAT;
    internal System.Windows.Forms.Button BtnCancel;
    internal System.Windows.Forms.Button cmdValider;
  }
}