
namespace MozartCS
{
  partial class frmSuiviTempsRecupTech_Gest
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
      DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
      DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
      this.GV_Recup_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCol_2_NTPS_RECUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_NPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_VNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_NSOLDE_SEC_BASE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_DATE_AJOUT_VISA = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_NQUI_AJOUT_VISA = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_2_VQUIVISA = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCSuiviTpsRecup = new DevExpress.XtraGrid.GridControl();
      this.GV_ListeTotRecup = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCol_1_NPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_1_VNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_1_TOT_NSOLDE_SEC_BASE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GV_Recup_Solde = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCol_3_NTPS_RECUP_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_NTPS_RECUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_DATCRE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_VNOM_CRE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_DLASTMODIF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_NTOT_SEC_SOLDE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_VOBS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_3_NQUIMODIF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.BtnClose = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.GV_Recup_Detail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCSuiviTpsRecup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GV_ListeTotRecup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GV_Recup_Solde)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // GV_Recup_Detail
      // 
      this.GV_Recup_Detail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.GV_Recup_Detail.Appearance.HeaderPanel.Options.UseFont = true;
      this.GV_Recup_Detail.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GV_Recup_Detail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GV_Recup_Detail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GV_Recup_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_2_NTPS_RECUP_ID,
            this.GCol_2_NPERNUM,
            this.GCol_2_VNOM,
            this.GCol_2_NSOLDE_SEC_BASE,
            this.GCol_2_DATE_AJOUT_VISA,
            this.GCol_2_NQUI_AJOUT_VISA,
            this.GCol_2_VQUIVISA});
      this.GV_Recup_Detail.GridControl = this.GCSuiviTpsRecup;
      this.GV_Recup_Detail.Name = "GV_Recup_Detail";
      this.GV_Recup_Detail.OptionsView.ShowGroupPanel = false;
      this.GV_Recup_Detail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GV_Recup_Detail_CustomColumnDisplayText);
      // 
      // GCol_2_NTPS_RECUP_ID
      // 
      this.GCol_2_NTPS_RECUP_ID.Caption = "NTPS_RECUP_ID";
      this.GCol_2_NTPS_RECUP_ID.FieldName = "NTPS_RECUP_ID";
      this.GCol_2_NTPS_RECUP_ID.Name = "GCol_2_NTPS_RECUP_ID";
      this.GCol_2_NTPS_RECUP_ID.OptionsColumn.AllowEdit = false;
      this.GCol_2_NTPS_RECUP_ID.OptionsColumn.ReadOnly = true;
      // 
      // GCol_2_NPERNUM
      // 
      this.GCol_2_NPERNUM.Caption = "NPERNUM";
      this.GCol_2_NPERNUM.FieldName = "NPERNUM";
      this.GCol_2_NPERNUM.Name = "GCol_2_NPERNUM";
      this.GCol_2_NPERNUM.OptionsColumn.AllowEdit = false;
      this.GCol_2_NPERNUM.OptionsColumn.ReadOnly = true;
      // 
      // GCol_2_VNOM
      // 
      this.GCol_2_VNOM.Caption = "Personne";
      this.GCol_2_VNOM.FieldName = "VNOM";
      this.GCol_2_VNOM.Name = "GCol_2_VNOM";
      this.GCol_2_VNOM.OptionsColumn.AllowEdit = false;
      this.GCol_2_VNOM.OptionsColumn.ReadOnly = true;
      this.GCol_2_VNOM.Visible = true;
      this.GCol_2_VNOM.VisibleIndex = 0;
      // 
      // GCol_2_NSOLDE_SEC_BASE
      // 
      this.GCol_2_NSOLDE_SEC_BASE.Caption = "Temps de récupération validé";
      this.GCol_2_NSOLDE_SEC_BASE.FieldName = "NSOLDE_SEC_BASE";
      this.GCol_2_NSOLDE_SEC_BASE.Name = "GCol_2_NSOLDE_SEC_BASE";
      this.GCol_2_NSOLDE_SEC_BASE.OptionsColumn.AllowEdit = false;
      this.GCol_2_NSOLDE_SEC_BASE.OptionsColumn.ReadOnly = true;
      this.GCol_2_NSOLDE_SEC_BASE.Visible = true;
      this.GCol_2_NSOLDE_SEC_BASE.VisibleIndex = 1;
      // 
      // GCol_2_DATE_AJOUT_VISA
      // 
      this.GCol_2_DATE_AJOUT_VISA.Caption = "Date Visa";
      this.GCol_2_DATE_AJOUT_VISA.FieldName = "DATE_AJOUT_VISA";
      this.GCol_2_DATE_AJOUT_VISA.Name = "GCol_2_DATE_AJOUT_VISA";
      this.GCol_2_DATE_AJOUT_VISA.OptionsColumn.AllowEdit = false;
      this.GCol_2_DATE_AJOUT_VISA.OptionsColumn.ReadOnly = true;
      this.GCol_2_DATE_AJOUT_VISA.Visible = true;
      this.GCol_2_DATE_AJOUT_VISA.VisibleIndex = 2;
      // 
      // GCol_2_NQUI_AJOUT_VISA
      // 
      this.GCol_2_NQUI_AJOUT_VISA.Caption = "NQUI_AJOUT_VISA";
      this.GCol_2_NQUI_AJOUT_VISA.FieldName = "NQUI_AJOUT_VISA";
      this.GCol_2_NQUI_AJOUT_VISA.Name = "GCol_2_NQUI_AJOUT_VISA";
      this.GCol_2_NQUI_AJOUT_VISA.OptionsColumn.AllowEdit = false;
      this.GCol_2_NQUI_AJOUT_VISA.OptionsColumn.ReadOnly = true;
      // 
      // GCol_2_VQUIVISA
      // 
      this.GCol_2_VQUIVISA.Caption = "Qui VISA";
      this.GCol_2_VQUIVISA.FieldName = "VQUIVISA";
      this.GCol_2_VQUIVISA.Name = "GCol_2_VQUIVISA";
      this.GCol_2_VQUIVISA.OptionsColumn.AllowEdit = false;
      this.GCol_2_VQUIVISA.OptionsColumn.ReadOnly = true;
      this.GCol_2_VQUIVISA.Visible = true;
      this.GCol_2_VQUIVISA.VisibleIndex = 3;
      // 
      // GCSuiviTpsRecup
      // 
      gridLevelNode1.LevelTemplate = this.GV_Recup_Detail;
      gridLevelNode2.LevelTemplate = this.GV_Recup_Solde;
      gridLevelNode2.RelationName = "Lvl_Recup_Solde";
      gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
      gridLevelNode1.RelationName = "Lvl_Recup_Detail";
      this.GCSuiviTpsRecup.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
      this.GCSuiviTpsRecup.Location = new System.Drawing.Point(131, 49);
      this.GCSuiviTpsRecup.MainView = this.GV_ListeTotRecup;
      this.GCSuiviTpsRecup.Name = "GCSuiviTpsRecup";
      this.GCSuiviTpsRecup.Size = new System.Drawing.Size(1548, 841);
      this.GCSuiviTpsRecup.TabIndex = 26;
      this.GCSuiviTpsRecup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_ListeTotRecup,
            this.GV_Recup_Solde,
            this.GV_Recup_Detail});
      this.GCSuiviTpsRecup.Click += new System.EventHandler(this.GCSuiviTpsRecup_Click);
      // 
      // GV_ListeTotRecup
      // 
      this.GV_ListeTotRecup.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.GV_ListeTotRecup.Appearance.HeaderPanel.Options.UseFont = true;
      this.GV_ListeTotRecup.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GV_ListeTotRecup.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GV_ListeTotRecup.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GV_ListeTotRecup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_1_NPERNUM,
            this.GCol_1_VNOM,
            this.GCol_1_TOT_NSOLDE_SEC_BASE});
      this.GV_ListeTotRecup.GridControl = this.GCSuiviTpsRecup;
      this.GV_ListeTotRecup.Name = "GV_ListeTotRecup";
      this.GV_ListeTotRecup.OptionsView.ShowGroupPanel = false;
      this.GV_ListeTotRecup.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GV_ListeTotRecup_CustomColumnDisplayText);
      // 
      // GCol_1_NPERNUM
      // 
      this.GCol_1_NPERNUM.Caption = "NPERNUM";
      this.GCol_1_NPERNUM.FieldName = "NPERNUM";
      this.GCol_1_NPERNUM.Name = "GCol_1_NPERNUM";
      this.GCol_1_NPERNUM.OptionsColumn.AllowEdit = false;
      this.GCol_1_NPERNUM.OptionsColumn.ReadOnly = true;
      // 
      // GCol_1_VNOM
      // 
      this.GCol_1_VNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_1_VNOM.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_1_VNOM.Caption = "Personne";
      this.GCol_1_VNOM.FieldName = "VNOM";
      this.GCol_1_VNOM.Name = "GCol_1_VNOM";
      this.GCol_1_VNOM.OptionsColumn.AllowEdit = false;
      this.GCol_1_VNOM.OptionsColumn.ReadOnly = true;
      this.GCol_1_VNOM.Visible = true;
      this.GCol_1_VNOM.VisibleIndex = 0;
      // 
      // GCol_1_TOT_NSOLDE_SEC_BASE
      // 
      this.GCol_1_TOT_NSOLDE_SEC_BASE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_1_TOT_NSOLDE_SEC_BASE.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_1_TOT_NSOLDE_SEC_BASE.Caption = "Tota temps à récupérer";
      this.GCol_1_TOT_NSOLDE_SEC_BASE.FieldName = "TOT_NSOLDE_SEC_BASE";
      this.GCol_1_TOT_NSOLDE_SEC_BASE.Name = "GCol_1_TOT_NSOLDE_SEC_BASE";
      this.GCol_1_TOT_NSOLDE_SEC_BASE.OptionsColumn.AllowEdit = false;
      this.GCol_1_TOT_NSOLDE_SEC_BASE.OptionsColumn.ReadOnly = true;
      this.GCol_1_TOT_NSOLDE_SEC_BASE.Visible = true;
      this.GCol_1_TOT_NSOLDE_SEC_BASE.VisibleIndex = 1;
      // 
      // GV_Recup_Solde
      // 
      this.GV_Recup_Solde.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.GV_Recup_Solde.Appearance.HeaderPanel.Options.UseFont = true;
      this.GV_Recup_Solde.Appearance.HeaderPanel.Options.UseTextOptions = true;
      this.GV_Recup_Solde.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GV_Recup_Solde.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GV_Recup_Solde.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_3_NTPS_RECUP_SOLDE,
            this.GCol_3_NTPS_RECUP_ID,
            this.GCol_3_DATCRE,
            this.GCol_3_VNOM_CRE,
            this.GCol_3_DLASTMODIF,
            this.GCol_3_NTOT_SEC_SOLDE,
            this.GCol_3_VOBS,
            this.GCol_3_NQUIMODIF});
      this.GV_Recup_Solde.GridControl = this.GCSuiviTpsRecup;
      this.GV_Recup_Solde.Name = "GV_Recup_Solde";
      this.GV_Recup_Solde.OptionsView.ShowGroupPanel = false;
      this.GV_Recup_Solde.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GV_Recup_Solde_CustomColumnDisplayText);
      // 
      // GCol_3_NTPS_RECUP_SOLDE
      // 
      this.GCol_3_NTPS_RECUP_SOLDE.Caption = "NTPS_RECUP_SOLDE";
      this.GCol_3_NTPS_RECUP_SOLDE.FieldName = "NTPS_RECUP_SOLDE";
      this.GCol_3_NTPS_RECUP_SOLDE.Name = "GCol_3_NTPS_RECUP_SOLDE";
      this.GCol_3_NTPS_RECUP_SOLDE.OptionsColumn.AllowEdit = false;
      this.GCol_3_NTPS_RECUP_SOLDE.OptionsColumn.ReadOnly = true;
      // 
      // GCol_3_NTPS_RECUP_ID
      // 
      this.GCol_3_NTPS_RECUP_ID.Caption = "NTPS_RECUP_ID";
      this.GCol_3_NTPS_RECUP_ID.FieldName = "NTPS_RECUP_ID";
      this.GCol_3_NTPS_RECUP_ID.Name = "GCol_3_NTPS_RECUP_ID";
      this.GCol_3_NTPS_RECUP_ID.OptionsColumn.AllowEdit = false;
      this.GCol_3_NTPS_RECUP_ID.OptionsColumn.ReadOnly = true;
      // 
      // GCol_3_DATCRE
      // 
      this.GCol_3_DATCRE.Caption = "Date Création";
      this.GCol_3_DATCRE.FieldName = "DATCRE";
      this.GCol_3_DATCRE.Name = "GCol_3_DATCRE";
      this.GCol_3_DATCRE.OptionsColumn.AllowEdit = false;
      this.GCol_3_DATCRE.OptionsColumn.ReadOnly = true;
      this.GCol_3_DATCRE.Visible = true;
      this.GCol_3_DATCRE.VisibleIndex = 0;
      // 
      // GCol_3_VNOM_CRE
      // 
      this.GCol_3_VNOM_CRE.Caption = "Nom créateur";
      this.GCol_3_VNOM_CRE.FieldName = "VNOM_CRE";
      this.GCol_3_VNOM_CRE.Name = "GCol_3_VNOM_CRE";
      this.GCol_3_VNOM_CRE.OptionsColumn.AllowEdit = false;
      this.GCol_3_VNOM_CRE.OptionsColumn.ReadOnly = true;
      this.GCol_3_VNOM_CRE.Visible = true;
      this.GCol_3_VNOM_CRE.VisibleIndex = 1;
      // 
      // GCol_3_DLASTMODIF
      // 
      this.GCol_3_DLASTMODIF.Caption = "Date dernière modif";
      this.GCol_3_DLASTMODIF.FieldName = "DLASTMODIF";
      this.GCol_3_DLASTMODIF.Name = "GCol_3_DLASTMODIF";
      this.GCol_3_DLASTMODIF.OptionsColumn.AllowEdit = false;
      this.GCol_3_DLASTMODIF.OptionsColumn.ReadOnly = true;
      this.GCol_3_DLASTMODIF.Visible = true;
      this.GCol_3_DLASTMODIF.VisibleIndex = 2;
      // 
      // GCol_3_NTOT_SEC_SOLDE
      // 
      this.GCol_3_NTOT_SEC_SOLDE.Caption = "Temps récupéré";
      this.GCol_3_NTOT_SEC_SOLDE.FieldName = "NTOT_SEC_SOLDE";
      this.GCol_3_NTOT_SEC_SOLDE.Name = "GCol_3_NTOT_SEC_SOLDE";
      this.GCol_3_NTOT_SEC_SOLDE.OptionsColumn.AllowEdit = false;
      this.GCol_3_NTOT_SEC_SOLDE.OptionsColumn.ReadOnly = true;
      this.GCol_3_NTOT_SEC_SOLDE.Visible = true;
      this.GCol_3_NTOT_SEC_SOLDE.VisibleIndex = 3;
      // 
      // GCol_3_VOBS
      // 
      this.GCol_3_VOBS.Caption = "Observations";
      this.GCol_3_VOBS.FieldName = "VOBS";
      this.GCol_3_VOBS.Name = "GCol_3_VOBS";
      this.GCol_3_VOBS.OptionsColumn.AllowEdit = false;
      this.GCol_3_VOBS.OptionsColumn.ReadOnly = true;
      this.GCol_3_VOBS.Visible = true;
      this.GCol_3_VOBS.VisibleIndex = 4;
      // 
      // GCol_3_NQUIMODIF
      // 
      this.GCol_3_NQUIMODIF.Caption = "NQUIMODIF";
      this.GCol_3_NQUIMODIF.FieldName = "NQUIMODIF";
      this.GCol_3_NQUIMODIF.Name = "GCol_3_NQUIMODIF";
      this.GCol_3_NQUIMODIF.OptionsColumn.AllowEdit = false;
      this.GCol_3_NQUIMODIF.OptionsColumn.ReadOnly = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.BtnClose);
      this.groupBox2.Location = new System.Drawing.Point(12, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(97, 560);
      this.groupBox2.TabIndex = 25;
      this.groupBox2.TabStop = false;
      // 
      // BtnClose
      // 
      this.BtnClose.Location = new System.Drawing.Point(6, 443);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(83, 35);
      this.BtnClose.TabIndex = 3;
      this.BtnClose.Text = "Fermer";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(115, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(320, 24);
      this.label2.TabIndex = 24;
      this.label2.Text = "Suivi temps de travail techniciens";
      // 
      // frmSuiviTempsRecupTech_Gest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1800, 1013);
      this.Controls.Add(this.GCSuiviTpsRecup);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label2);
      this.Name = "frmSuiviTempsRecupTech_Gest";
      this.Text = "Suivi temps de récupération";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSuiviTempsRecupTech_Gest_Load);
      ((System.ComponentModel.ISupportInitialize)(this.GV_Recup_Detail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCSuiviTpsRecup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GV_ListeTotRecup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GV_Recup_Solde)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button BtnClose;
    private System.Windows.Forms.Label label2;
    private DevExpress.XtraGrid.GridControl GCSuiviTpsRecup;
    private DevExpress.XtraGrid.Views.Grid.GridView GV_ListeTotRecup;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_1_NPERNUM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_1_VNOM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_1_TOT_NSOLDE_SEC_BASE;
    private DevExpress.XtraGrid.Views.Grid.GridView GV_Recup_Detail;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_NTPS_RECUP_ID;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_NPERNUM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_VNOM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_NSOLDE_SEC_BASE;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_DATE_AJOUT_VISA;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_NQUI_AJOUT_VISA;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_2_VQUIVISA;
    private DevExpress.XtraGrid.Views.Grid.GridView GV_Recup_Solde;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_NTPS_RECUP_SOLDE;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_NTPS_RECUP_ID;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_DATCRE;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_VNOM_CRE;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_DLASTMODIF;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_NTOT_SEC_SOLDE;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_VOBS;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_3_NQUIMODIF;
  }
}