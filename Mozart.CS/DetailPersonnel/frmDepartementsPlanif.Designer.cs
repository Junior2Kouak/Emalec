
namespace MozartCS.DetailPersonnel
{
  partial class frmDepartementsPlanif
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
      this.GCListeDep = new DevExpress.XtraGrid.GridControl();
      this.GVListeDep = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.Col_NDEPNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_NUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_DEP = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_REG = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_NPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_VPERNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Col_BAFFECTE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RItem_BAFFECTE = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.BtnClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.GCListeDep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVListeDep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RItem_BAFFECTE)).BeginInit();
      this.SuspendLayout();
      // 
      // GCListeDep
      // 
      this.GCListeDep.Location = new System.Drawing.Point(116, 35);
      this.GCListeDep.MainView = this.GVListeDep;
      this.GCListeDep.Name = "GCListeDep";
      this.GCListeDep.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RItem_BAFFECTE});
      this.GCListeDep.Size = new System.Drawing.Size(750, 573);
      this.GCListeDep.TabIndex = 0;
      this.GCListeDep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVListeDep});
      // 
      // GVListeDep
      // 
      this.GVListeDep.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.GVListeDep.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVListeDep.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GVListeDep.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GVListeDep.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GVListeDep.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.GVListeDep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_NDEPNUM,
            this.Col_NUM,
            this.Col_DEP,
            this.Col_REG,
            this.Col_NPERNUM,
            this.Col_VPERNOM,
            this.Col_BAFFECTE});
      this.GVListeDep.GridControl = this.GCListeDep;
      this.GVListeDep.Name = "GVListeDep";
      this.GVListeDep.OptionsView.ShowAutoFilterRow = true;
      this.GVListeDep.OptionsView.ShowGroupPanel = false;
      // 
      // Col_NDEPNUM
      // 
      this.Col_NDEPNUM.Caption = "NDEPNUM";
      this.Col_NDEPNUM.FieldName = "NDEPNUM";
      this.Col_NDEPNUM.Name = "Col_NDEPNUM";
      // 
      // Col_NUM
      // 
      this.Col_NUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.Col_NUM.AppearanceHeader.Options.UseForeColor = true;
      this.Col_NUM.Caption = "N° Département";
      this.Col_NUM.FieldName = "NUM";
      this.Col_NUM.Name = "Col_NUM";
      this.Col_NUM.OptionsColumn.AllowEdit = false;
      this.Col_NUM.OptionsColumn.ReadOnly = true;
      this.Col_NUM.Visible = true;
      this.Col_NUM.VisibleIndex = 0;
      this.Col_NUM.Width = 109;
      // 
      // Col_DEP
      // 
      this.Col_DEP.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.Col_DEP.AppearanceHeader.Options.UseForeColor = true;
      this.Col_DEP.Caption = "Département";
      this.Col_DEP.FieldName = "DEP";
      this.Col_DEP.Name = "Col_DEP";
      this.Col_DEP.OptionsColumn.AllowEdit = false;
      this.Col_DEP.OptionsColumn.ReadOnly = true;
      this.Col_DEP.Visible = true;
      this.Col_DEP.VisibleIndex = 1;
      this.Col_DEP.Width = 173;
      // 
      // Col_REG
      // 
      this.Col_REG.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.Col_REG.AppearanceHeader.Options.UseForeColor = true;
      this.Col_REG.Caption = "Région";
      this.Col_REG.FieldName = "REG";
      this.Col_REG.Name = "Col_REG";
      this.Col_REG.OptionsColumn.AllowEdit = false;
      this.Col_REG.OptionsColumn.ReadOnly = true;
      this.Col_REG.Visible = true;
      this.Col_REG.VisibleIndex = 2;
      this.Col_REG.Width = 146;
      // 
      // Col_NPERNUM
      // 
      this.Col_NPERNUM.Caption = "NPERNUM";
      this.Col_NPERNUM.FieldName = "NPERNUM";
      this.Col_NPERNUM.Name = "Col_NPERNUM";
      // 
      // Col_VPERNOM
      // 
      this.Col_VPERNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.Col_VPERNOM.AppearanceHeader.Options.UseForeColor = true;
      this.Col_VPERNOM.Caption = "Planificateur";
      this.Col_VPERNOM.FieldName = "VPERNOM";
      this.Col_VPERNOM.Name = "Col_VPERNOM";
      this.Col_VPERNOM.OptionsColumn.AllowEdit = false;
      this.Col_VPERNOM.OptionsColumn.ReadOnly = true;
      this.Col_VPERNOM.Visible = true;
      this.Col_VPERNOM.VisibleIndex = 4;
      this.Col_VPERNOM.Width = 228;
      // 
      // Col_BAFFECTE
      // 
      this.Col_BAFFECTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.Col_BAFFECTE.AppearanceHeader.Options.UseForeColor = true;
      this.Col_BAFFECTE.Caption = "Affecté";
      this.Col_BAFFECTE.ColumnEdit = this.RItem_BAFFECTE;
      this.Col_BAFFECTE.FieldName = "BAFFECTE";
      this.Col_BAFFECTE.Name = "Col_BAFFECTE";
      this.Col_BAFFECTE.Visible = true;
      this.Col_BAFFECTE.VisibleIndex = 3;
      this.Col_BAFFECTE.Width = 76;
      // 
      // RItem_BAFFECTE
      // 
      this.RItem_BAFFECTE.AutoHeight = false;
      this.RItem_BAFFECTE.Name = "RItem_BAFFECTE";
      this.RItem_BAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
      this.RItem_BAFFECTE.ValueChecked = 1;
      this.RItem_BAFFECTE.ValueUnchecked = 0;
      this.RItem_BAFFECTE.CheckedChanged += new System.EventHandler(this.RItem_BAFFECTE_CheckedChanged);
      // 
      // BtnClose
      // 
      this.BtnClose.Location = new System.Drawing.Point(12, 558);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(90, 50);
      this.BtnClose.TabIndex = 2;
      this.BtnClose.Text = "Fermer";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // frmDepartementsPlanif
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(894, 642);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.GCListeDep);
      this.Name = "frmDepartementsPlanif";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Liste des départements par planificateur";
      this.Load += new System.EventHandler(this.frmDepartementsPlanif_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GCListeDep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVListeDep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RItem_BAFFECTE)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl GCListeDep;
    private DevExpress.XtraGrid.Views.Grid.GridView GVListeDep;
    private System.Windows.Forms.Button BtnClose;
    private DevExpress.XtraGrid.Columns.GridColumn Col_NDEPNUM;
    private DevExpress.XtraGrid.Columns.GridColumn Col_NUM;
    private DevExpress.XtraGrid.Columns.GridColumn Col_DEP;
    private DevExpress.XtraGrid.Columns.GridColumn Col_REG;
    private DevExpress.XtraGrid.Columns.GridColumn Col_NPERNUM;
    private DevExpress.XtraGrid.Columns.GridColumn Col_VPERNOM;
    private DevExpress.XtraGrid.Columns.GridColumn Col_BAFFECTE;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RItem_BAFFECTE;
  }
}