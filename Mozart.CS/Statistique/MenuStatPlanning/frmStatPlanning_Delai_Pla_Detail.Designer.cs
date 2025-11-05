
namespace MozartCS
{
  partial class frmStatPlanning_Delai_Pla_Detail
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
      this.GCDetail = new DevExpress.XtraGrid.GridControl();
      this.GVDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColNACTNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_NSITNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_NDINNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCOl_VDINNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Repo_Item_DI = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
      this.GColVCLINOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVSITNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColdmise_en_planif = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_date_planif = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_DELAI_D = new DevExpress.XtraGrid.Columns.GridColumn();
      this.lblTitre = new MozartUC.apiLabel();
      this.cmdClose = new MozartUC.apiButton();
      this.cmdExcel = new MozartUC.apiButton();
      this.sFD = new System.Windows.Forms.SaveFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.GCDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_Item_DI)).BeginInit();
      this.SuspendLayout();
      // 
      // GCDetail
      // 
      this.GCDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.GCDetail.Location = new System.Drawing.Point(93, 43);
      this.GCDetail.MainView = this.GVDetail;
      this.GCDetail.Name = "GCDetail";
      this.GCDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Repo_Item_DI});
      this.GCDetail.Size = new System.Drawing.Size(961, 539);
      this.GCDetail.TabIndex = 36;
      this.GCDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVDetail});
      // 
      // GVDetail
      // 
      this.GVDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.GVDetail.Appearance.HeaderPanel.Options.UseFont = true;
      this.GVDetail.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GVDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GVDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GVDetail.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.GVDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColNACTNUM,
            this.GCol_NSITNUM,
            this.GCol_NDINNUM,
            this.GCOl_VDINNUM,
            this.GColVCLINOM,
            this.GColVSITNOM,
            this.GColdmise_en_planif,
            this.GCol_date_planif,
            this.GCol_DELAI_D});
      this.GVDetail.GridControl = this.GCDetail;
      this.GVDetail.Name = "GVDetail";
      this.GVDetail.OptionsBehavior.SummariesIgnoreNullValues = true;
      this.GVDetail.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
      this.GVDetail.OptionsView.ShowFooter = true;
      this.GVDetail.OptionsView.ShowGroupPanel = false;
      // 
      // GColNACTNUM
      // 
      this.GColNACTNUM.Caption = "NACTNUM";
      this.GColNACTNUM.FieldName = "NACTNUM";
      this.GColNACTNUM.Name = "GColNACTNUM";
      // 
      // GCol_NSITNUM
      // 
      this.GCol_NSITNUM.Caption = "NSITNUM";
      this.GCol_NSITNUM.FieldName = "NSITNUM";
      this.GCol_NSITNUM.Name = "GCol_NSITNUM";
      // 
      // GCol_NDINNUM
      // 
      this.GCol_NDINNUM.Caption = "NDINNUM";
      this.GCol_NDINNUM.FieldName = "NDINNUM";
      this.GCol_NDINNUM.Name = "GCol_NDINNUM";
      // 
      // GCOl_VDINNUM
      // 
      this.GCOl_VDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCOl_VDINNUM.AppearanceHeader.Options.UseForeColor = true;
      this.GCOl_VDINNUM.Caption = "DI";
      this.GCOl_VDINNUM.ColumnEdit = this.Repo_Item_DI;
      this.GCOl_VDINNUM.FieldName = "VDINNUM";
      this.GCOl_VDINNUM.Name = "GCOl_VDINNUM";
      this.GCOl_VDINNUM.OptionsColumn.ReadOnly = true;
      this.GCOl_VDINNUM.Visible = true;
      this.GCOl_VDINNUM.VisibleIndex = 2;
      this.GCOl_VDINNUM.Width = 71;
      // 
      // Repo_Item_DI
      // 
      this.Repo_Item_DI.AutoHeight = false;
      this.Repo_Item_DI.Name = "Repo_Item_DI";
      this.Repo_Item_DI.SingleClick = true;
      this.Repo_Item_DI.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.Repo_Item_DI_OpenLink);
      // 
      // GColVCLINOM
      // 
      this.GColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColVCLINOM.AppearanceHeader.Options.UseForeColor = true;
      this.GColVCLINOM.Caption = "Client";
      this.GColVCLINOM.FieldName = "VCLINOM";
      this.GColVCLINOM.Name = "GColVCLINOM";
      this.GColVCLINOM.OptionsColumn.AllowEdit = false;
      this.GColVCLINOM.OptionsColumn.ReadOnly = true;
      this.GColVCLINOM.Visible = true;
      this.GColVCLINOM.VisibleIndex = 0;
      this.GColVCLINOM.Width = 188;
      // 
      // GColVSITNOM
      // 
      this.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColVSITNOM.AppearanceHeader.Options.UseForeColor = true;
      this.GColVSITNOM.Caption = "Site";
      this.GColVSITNOM.FieldName = "VSITNOM";
      this.GColVSITNOM.Name = "GColVSITNOM";
      this.GColVSITNOM.OptionsColumn.AllowEdit = false;
      this.GColVSITNOM.OptionsColumn.ReadOnly = true;
      this.GColVSITNOM.Visible = true;
      this.GColVSITNOM.VisibleIndex = 1;
      this.GColVSITNOM.Width = 155;
      // 
      // GColdmise_en_planif
      // 
      this.GColdmise_en_planif.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColdmise_en_planif.AppearanceHeader.Options.UseForeColor = true;
      this.GColdmise_en_planif.Caption = "Date mise en planification";
      this.GColdmise_en_planif.DisplayFormat.FormatString = "g";
      this.GColdmise_en_planif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.GColdmise_en_planif.FieldName = "dmise_en_planif";
      this.GColdmise_en_planif.Name = "GColdmise_en_planif";
      this.GColdmise_en_planif.OptionsColumn.AllowEdit = false;
      this.GColdmise_en_planif.OptionsColumn.ReadOnly = true;
      this.GColdmise_en_planif.Visible = true;
      this.GColdmise_en_planif.VisibleIndex = 3;
      this.GColdmise_en_planif.Width = 176;
      // 
      // GCol_date_planif
      // 
      this.GCol_date_planif.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_date_planif.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_date_planif.Caption = "Date de planification";
      this.GCol_date_planif.DisplayFormat.FormatString = "g";
      this.GCol_date_planif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.GCol_date_planif.FieldName = "date_planif";
      this.GCol_date_planif.Name = "GCol_date_planif";
      this.GCol_date_planif.OptionsColumn.AllowEdit = false;
      this.GCol_date_planif.OptionsColumn.ReadOnly = true;
      this.GCol_date_planif.Visible = true;
      this.GCol_date_planif.VisibleIndex = 4;
      this.GCol_date_planif.Width = 176;
      // 
      // GCol_DELAI_D
      // 
      this.GCol_DELAI_D.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_DELAI_D.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_DELAI_D.Caption = "Délai";
      this.GCol_DELAI_D.FieldName = "DELAI_D";
      this.GCol_DELAI_D.Name = "GCol_DELAI_D";
      this.GCol_DELAI_D.OptionsColumn.AllowEdit = false;
      this.GCol_DELAI_D.OptionsColumn.ReadOnly = true;
      this.GCol_DELAI_D.Visible = true;
      this.GCol_DELAI_D.VisibleIndex = 5;
      this.GCol_DELAI_D.Width = 206;
      // 
      // lblTitre
      // 
      this.lblTitre.AutoSize = true;
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitre.Location = new System.Drawing.Point(89, 9);
      this.lblTitre.Name = "lblTitre";
      this.lblTitre.Size = new System.Drawing.Size(212, 24);
      this.lblTitre.TabIndex = 37;
      this.lblTitre.Text = "Délai par planificateur";
      // 
      // cmdClose
      // 
      this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdClose.HelpContextID = 0;
      this.cmdClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdClose.Location = new System.Drawing.Point(12, 535);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new System.Drawing.Size(75, 47);
      this.cmdClose.TabIndex = 38;
      this.cmdClose.Tag = "15";
      this.cmdClose.Text = "Fermer";
      this.cmdClose.UseVisualStyleBackColor = true;
      // 
      // cmdExcel
      // 
      this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdExcel.HelpContextID = 0;
      this.cmdExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdExcel.Location = new System.Drawing.Point(12, 126);
      this.cmdExcel.Name = "cmdExcel";
      this.cmdExcel.Size = new System.Drawing.Size(73, 57);
      this.cmdExcel.TabIndex = 39;
      this.cmdExcel.Tag = "19";
      this.cmdExcel.Text = "Export EXCEL";
      this.cmdExcel.UseVisualStyleBackColor = true;
      this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
      // 
      // sFD
      // 
      this.sFD.DefaultExt = "xlsx";
      this.sFD.Filter = "Fichiers XLSX |*.xlsx";
      // 
      // frmStatPlanning_Delai_Pla_Detail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdClose;
      this.ClientSize = new System.Drawing.Size(1066, 605);
      this.Controls.Add(this.cmdExcel);
      this.Controls.Add(this.cmdClose);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.GCDetail);
      this.Name = "frmStatPlanning_Delai_Pla_Detail";
      this.Text = "frmStatPalling_Delai_Pla_Detail";
      this.Load += new System.EventHandler(this.frmStatPlanning_Delai_Pla_Detail_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GCDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Repo_Item_DI)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl GCDetail;
    private DevExpress.XtraGrid.Views.Grid.GridView GVDetail;
    private DevExpress.XtraGrid.Columns.GridColumn GColNACTNUM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NSITNUM;
    private DevExpress.XtraGrid.Columns.GridColumn GColVCLINOM;
    private DevExpress.XtraGrid.Columns.GridColumn GColVSITNOM;
    private DevExpress.XtraGrid.Columns.GridColumn GColdmise_en_planif;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_date_planif;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_DELAI_D;
    private DevExpress.XtraGrid.Columns.GridColumn GCOl_VDINNUM;
    private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit Repo_Item_DI;
    private MozartUC.apiLabel lblTitre;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NDINNUM;
    private MozartUC.apiButton cmdClose;
    private MozartUC.apiButton cmdExcel;
    private System.Windows.Forms.SaveFileDialog sFD;
  }
}