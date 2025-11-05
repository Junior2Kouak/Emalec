
namespace MozartCS
{
  partial class UCCompteAnaClient : UCWizardBase
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCompteAnaClient));
      this.BtnDel = new System.Windows.Forms.Button();
      this.GCol_View_VPERNOM_ASSCHAFF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_View_NPERNUM_ASSCHAFF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemGridLookUpEditView_ASSCHAFF = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.RepositoryItemGV_ASSCHAFF = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.GColCLI_ASSCHAFF = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColView_FACTU_VPERNOM_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColView_FACTU_NPERNUM_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemGridLookUpEditView_FACTU = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.RepositoryItemGV_FACTU = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.GColCLI_FACTU = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColGVASS_VPERNOM_ASS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColGVASS_NPERNUM_ASS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepositoryItemGridLookUpEditView_ASS = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.RepositoryItemGV_ASS = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.GColCLI_ASS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColCboChaffVPERNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColCboChaffNPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GVCBOCHAFF = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.RepCboChaff = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.GColCPTANANPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColCboCPTANAVCANLIB = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColCboCPTANANCANNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GVCBOCPTANA = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.RepCboNCANNUM = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.GColCPTANANCANNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GVCPTANA = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCCPTANA = new DevExpress.XtraGrid.GridControl();
      this.BtnAdd = new System.Windows.Forms.Button();
      this.LblTitre = new System.Windows.Forms.Label();
      this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_ASSCHAFF)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_ASSCHAFF)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_FACTU)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_FACTU)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_ASS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_ASS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCBOCHAFF)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepCboChaff)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCBOCPTANA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepCboNCANNUM)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCPTANA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCCPTANA)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnDel
      // 
      resources.ApplyResources(this.BtnDel, "BtnDel");
      this.BtnDel.Image = global::MozartCS.Properties.Resources.delete_32;
      this.BtnDel.Name = "BtnDel";
      this.BtnDel.UseVisualStyleBackColor = true;
      this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
      // 
      // GCol_View_VPERNOM_ASSCHAFF
      // 
      resources.ApplyResources(this.GCol_View_VPERNOM_ASSCHAFF, "GCol_View_VPERNOM_ASSCHAFF");
      this.GCol_View_VPERNOM_ASSCHAFF.FieldName = "VPERNOMASSCHAFF";
      this.GCol_View_VPERNOM_ASSCHAFF.Name = "GCol_View_VPERNOM_ASSCHAFF";
      // 
      // GCol_View_NPERNUM_ASSCHAFF
      // 
      resources.ApplyResources(this.GCol_View_NPERNUM_ASSCHAFF, "GCol_View_NPERNUM_ASSCHAFF");
      this.GCol_View_NPERNUM_ASSCHAFF.FieldName = "NPERNUMASSCHAFF";
      this.GCol_View_NPERNUM_ASSCHAFF.Name = "GCol_View_NPERNUM_ASSCHAFF";
      // 
      // RepositoryItemGridLookUpEditView_ASSCHAFF
      // 
      this.RepositoryItemGridLookUpEditView_ASSCHAFF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_View_NPERNUM_ASSCHAFF,
            this.GCol_View_VPERNOM_ASSCHAFF});
      this.RepositoryItemGridLookUpEditView_ASSCHAFF.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.RepositoryItemGridLookUpEditView_ASSCHAFF.Name = "RepositoryItemGridLookUpEditView_ASSCHAFF";
      this.RepositoryItemGridLookUpEditView_ASSCHAFF.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.RepositoryItemGridLookUpEditView_ASSCHAFF.OptionsView.ShowGroupPanel = false;
      // 
      // RepositoryItemGV_ASSCHAFF
      // 
      resources.ApplyResources(this.RepositoryItemGV_ASSCHAFF, "RepositoryItemGV_ASSCHAFF");
      this.RepositoryItemGV_ASSCHAFF.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("RepositoryItemGV_ASSCHAFF.Buttons"))))});
      this.RepositoryItemGV_ASSCHAFF.DisplayMember = "VPERNOMASSCHAFF";
      this.RepositoryItemGV_ASSCHAFF.Name = "RepositoryItemGV_ASSCHAFF";
      this.RepositoryItemGV_ASSCHAFF.PopupView = this.RepositoryItemGridLookUpEditView_ASSCHAFF;
      this.RepositoryItemGV_ASSCHAFF.ValueMember = "NPERNUMASSCHAFF";
      // 
      // GColCLI_ASSCHAFF
      // 
      this.GColCLI_ASSCHAFF.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCLI_ASSCHAFF.AppearanceHeader.Font")));
      this.GColCLI_ASSCHAFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColCLI_ASSCHAFF.AppearanceHeader.Options.UseFont = true;
      this.GColCLI_ASSCHAFF.AppearanceHeader.Options.UseForeColor = true;
      this.GColCLI_ASSCHAFF.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCLI_ASSCHAFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCLI_ASSCHAFF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GColCLI_ASSCHAFF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GColCLI_ASSCHAFF, "GColCLI_ASSCHAFF");
      this.GColCLI_ASSCHAFF.ColumnEdit = this.RepositoryItemGV_ASSCHAFF;
      this.GColCLI_ASSCHAFF.FieldName = "NPERNUMASSCHAFF";
      this.GColCLI_ASSCHAFF.Name = "GColCLI_ASSCHAFF";
      // 
      // GColView_FACTU_VPERNOM_FACTU
      // 
      resources.ApplyResources(this.GColView_FACTU_VPERNOM_FACTU, "GColView_FACTU_VPERNOM_FACTU");
      this.GColView_FACTU_VPERNOM_FACTU.FieldName = "VPERNOMFAC";
      this.GColView_FACTU_VPERNOM_FACTU.Name = "GColView_FACTU_VPERNOM_FACTU";
      this.GColView_FACTU_VPERNOM_FACTU.OptionsColumn.AllowEdit = false;
      this.GColView_FACTU_VPERNOM_FACTU.OptionsColumn.ReadOnly = true;
      this.GColView_FACTU_VPERNOM_FACTU.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColView_FACTU_NPERNUM_FACTU
      // 
      resources.ApplyResources(this.GColView_FACTU_NPERNUM_FACTU, "GColView_FACTU_NPERNUM_FACTU");
      this.GColView_FACTU_NPERNUM_FACTU.FieldName = "NPERNUMFAC";
      this.GColView_FACTU_NPERNUM_FACTU.Name = "GColView_FACTU_NPERNUM_FACTU";
      this.GColView_FACTU_NPERNUM_FACTU.OptionsColumn.AllowEdit = false;
      this.GColView_FACTU_NPERNUM_FACTU.OptionsColumn.ReadOnly = true;
      // 
      // RepositoryItemGridLookUpEditView_FACTU
      // 
      this.RepositoryItemGridLookUpEditView_FACTU.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColView_FACTU_NPERNUM_FACTU,
            this.GColView_FACTU_VPERNOM_FACTU});
      this.RepositoryItemGridLookUpEditView_FACTU.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.RepositoryItemGridLookUpEditView_FACTU.Name = "RepositoryItemGridLookUpEditView_FACTU";
      this.RepositoryItemGridLookUpEditView_FACTU.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.RepositoryItemGridLookUpEditView_FACTU.OptionsView.ShowGroupPanel = false;
      // 
      // RepositoryItemGV_FACTU
      // 
      resources.ApplyResources(this.RepositoryItemGV_FACTU, "RepositoryItemGV_FACTU");
      this.RepositoryItemGV_FACTU.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("RepositoryItemGV_FACTU.Buttons"))))});
      this.RepositoryItemGV_FACTU.DisplayMember = "VPERNOMFAC";
      this.RepositoryItemGV_FACTU.Name = "RepositoryItemGV_FACTU";
      this.RepositoryItemGV_FACTU.PopupView = this.RepositoryItemGridLookUpEditView_FACTU;
      this.RepositoryItemGV_FACTU.ValueMember = "NPERNUMFAC";
      // 
      // GColCLI_FACTU
      // 
      this.GColCLI_FACTU.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCLI_FACTU.AppearanceHeader.Font")));
      this.GColCLI_FACTU.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColCLI_FACTU.AppearanceHeader.Options.UseFont = true;
      this.GColCLI_FACTU.AppearanceHeader.Options.UseForeColor = true;
      this.GColCLI_FACTU.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCLI_FACTU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCLI_FACTU.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GColCLI_FACTU.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GColCLI_FACTU, "GColCLI_FACTU");
      this.GColCLI_FACTU.ColumnEdit = this.RepositoryItemGV_FACTU;
      this.GColCLI_FACTU.FieldName = "NPERNUMFAC";
      this.GColCLI_FACTU.Name = "GColCLI_FACTU";
      // 
      // GColGVASS_VPERNOM_ASS
      // 
      resources.ApplyResources(this.GColGVASS_VPERNOM_ASS, "GColGVASS_VPERNOM_ASS");
      this.GColGVASS_VPERNOM_ASS.FieldName = "VPERNOMASS";
      this.GColGVASS_VPERNOM_ASS.Name = "GColGVASS_VPERNOM_ASS";
      this.GColGVASS_VPERNOM_ASS.OptionsColumn.AllowEdit = false;
      this.GColGVASS_VPERNOM_ASS.OptionsColumn.ReadOnly = true;
      this.GColGVASS_VPERNOM_ASS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColGVASS_NPERNUM_ASS
      // 
      resources.ApplyResources(this.GColGVASS_NPERNUM_ASS, "GColGVASS_NPERNUM_ASS");
      this.GColGVASS_NPERNUM_ASS.FieldName = "NPERNUMASS";
      this.GColGVASS_NPERNUM_ASS.Name = "GColGVASS_NPERNUM_ASS";
      this.GColGVASS_NPERNUM_ASS.OptionsColumn.AllowEdit = false;
      this.GColGVASS_NPERNUM_ASS.OptionsColumn.ReadOnly = true;
      // 
      // RepositoryItemGridLookUpEditView_ASS
      // 
      this.RepositoryItemGridLookUpEditView_ASS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColGVASS_NPERNUM_ASS,
            this.GColGVASS_VPERNOM_ASS});
      this.RepositoryItemGridLookUpEditView_ASS.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.RepositoryItemGridLookUpEditView_ASS.Name = "RepositoryItemGridLookUpEditView_ASS";
      this.RepositoryItemGridLookUpEditView_ASS.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.RepositoryItemGridLookUpEditView_ASS.OptionsView.ShowGroupPanel = false;
      // 
      // RepositoryItemGV_ASS
      // 
      resources.ApplyResources(this.RepositoryItemGV_ASS, "RepositoryItemGV_ASS");
      this.RepositoryItemGV_ASS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("RepositoryItemGV_ASS.Buttons"))))});
      this.RepositoryItemGV_ASS.DisplayMember = "VPERNOMASS";
      this.RepositoryItemGV_ASS.Name = "RepositoryItemGV_ASS";
      this.RepositoryItemGV_ASS.PopupView = this.RepositoryItemGridLookUpEditView_ASS;
      this.RepositoryItemGV_ASS.ValueMember = "NPERNUMASS";
      // 
      // GColCLI_ASS
      // 
      this.GColCLI_ASS.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCLI_ASS.AppearanceHeader.Font")));
      this.GColCLI_ASS.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColCLI_ASS.AppearanceHeader.Options.UseFont = true;
      this.GColCLI_ASS.AppearanceHeader.Options.UseForeColor = true;
      this.GColCLI_ASS.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCLI_ASS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCLI_ASS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GColCLI_ASS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GColCLI_ASS, "GColCLI_ASS");
      this.GColCLI_ASS.ColumnEdit = this.RepositoryItemGV_ASS;
      this.GColCLI_ASS.FieldName = "NPERNUMASS";
      this.GColCLI_ASS.Name = "GColCLI_ASS";
      // 
      // GColCboChaffVPERNOM
      // 
      this.GColCboChaffVPERNOM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCboChaffVPERNOM.AppearanceHeader.Font")));
      this.GColCboChaffVPERNOM.AppearanceHeader.Options.UseBackColor = true;
      this.GColCboChaffVPERNOM.AppearanceHeader.Options.UseFont = true;
      this.GColCboChaffVPERNOM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCboChaffVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCboChaffVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCboChaffVPERNOM, "GColCboChaffVPERNOM");
      this.GColCboChaffVPERNOM.FieldName = "VPERNOM";
      this.GColCboChaffVPERNOM.Name = "GColCboChaffVPERNOM";
      this.GColCboChaffVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColCboChaffNPERNUM
      // 
      resources.ApplyResources(this.GColCboChaffNPERNUM, "GColCboChaffNPERNUM");
      this.GColCboChaffNPERNUM.FieldName = "NPERNUM";
      this.GColCboChaffNPERNUM.Name = "GColCboChaffNPERNUM";
      // 
      // GVCBOCHAFF
      // 
      this.GVCBOCHAFF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCboChaffNPERNUM,
            this.GColCboChaffVPERNOM});
      this.GVCBOCHAFF.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVCBOCHAFF.Name = "GVCBOCHAFF";
      this.GVCBOCHAFF.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVCBOCHAFF.OptionsView.ShowAutoFilterRow = true;
      this.GVCBOCHAFF.OptionsView.ShowGroupPanel = false;
      this.GVCBOCHAFF.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GVCBOCHAFF_RowCellClick);
      // 
      // RepCboChaff
      // 
      resources.ApplyResources(this.RepCboChaff, "RepCboChaff");
      this.RepCboChaff.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("RepCboChaff.Buttons"))))});
      this.RepCboChaff.DisplayMember = "VPERNOM";
      this.RepCboChaff.Name = "RepCboChaff";
      this.RepCboChaff.PopupView = this.GVCBOCHAFF;
      this.RepCboChaff.ValueMember = "NPERNUM";
      // 
      // GColCPTANANPERNUM
      // 
      this.GColCPTANANPERNUM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCPTANANPERNUM.AppearanceHeader.Font")));
      this.GColCPTANANPERNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColCPTANANPERNUM.AppearanceHeader.Options.UseFont = true;
      this.GColCPTANANPERNUM.AppearanceHeader.Options.UseForeColor = true;
      this.GColCPTANANPERNUM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCPTANANPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCPTANANPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCPTANANPERNUM, "GColCPTANANPERNUM");
      this.GColCPTANANPERNUM.ColumnEdit = this.RepCboChaff;
      this.GColCPTANANPERNUM.FieldName = "NPERNUM";
      this.GColCPTANANPERNUM.Name = "GColCPTANANPERNUM";
      // 
      // GColCboCPTANAVCANLIB
      // 
      this.GColCboCPTANAVCANLIB.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCboCPTANAVCANLIB.AppearanceHeader.Font")));
      this.GColCboCPTANAVCANLIB.AppearanceHeader.Options.UseFont = true;
      this.GColCboCPTANAVCANLIB.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCboCPTANAVCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCboCPTANAVCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCboCPTANAVCANLIB, "GColCboCPTANAVCANLIB");
      this.GColCboCPTANAVCANLIB.FieldName = "VCANLIB";
      this.GColCboCPTANAVCANLIB.Name = "GColCboCPTANAVCANLIB";
      this.GColCboCPTANAVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColCboCPTANANCANNUM
      // 
      resources.ApplyResources(this.GColCboCPTANANCANNUM, "GColCboCPTANANCANNUM");
      this.GColCboCPTANANCANNUM.FieldName = "NCANNUM";
      this.GColCboCPTANANCANNUM.Name = "GColCboCPTANANCANNUM";
      // 
      // GVCBOCPTANA
      // 
      this.GVCBOCPTANA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCboCPTANANCANNUM,
            this.GColCboCPTANAVCANLIB});
      this.GVCBOCPTANA.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVCBOCPTANA.Name = "GVCBOCPTANA";
      this.GVCBOCPTANA.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVCBOCPTANA.OptionsView.ShowAutoFilterRow = true;
      this.GVCBOCPTANA.OptionsView.ShowGroupPanel = false;
      this.GVCBOCPTANA.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GVCBOCPTANA_RowCellClick);
      // 
      // RepCboNCANNUM
      // 
      resources.ApplyResources(this.RepCboNCANNUM, "RepCboNCANNUM");
      this.RepCboNCANNUM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("RepCboNCANNUM.Buttons"))))});
      this.RepCboNCANNUM.DisplayMember = "VCANLIB";
      this.RepCboNCANNUM.Name = "RepCboNCANNUM";
      this.RepCboNCANNUM.PopupView = this.GVCBOCPTANA;
      this.RepCboNCANNUM.ValueMember = "NCANNUM";
      // 
      // GColCPTANANCANNUM
      // 
      this.GColCPTANANCANNUM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCPTANANCANNUM.AppearanceHeader.Font")));
      this.GColCPTANANCANNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GColCPTANANCANNUM.AppearanceHeader.Options.UseFont = true;
      this.GColCPTANANCANNUM.AppearanceHeader.Options.UseForeColor = true;
      this.GColCPTANANCANNUM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCPTANANCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCPTANANCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCPTANANCANNUM, "GColCPTANANCANNUM");
      this.GColCPTANANCANNUM.ColumnEdit = this.RepCboNCANNUM;
      this.GColCPTANANCANNUM.FieldName = "NCANNUM";
      this.GColCPTANANCANNUM.Name = "GColCPTANANCANNUM";
      // 
      // GVCPTANA
      // 
      this.GVCPTANA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCPTANANCANNUM,
            this.GColCPTANANPERNUM,
            this.GColCLI_ASS,
            this.GColCLI_FACTU,
            this.GColCLI_ASSCHAFF});
      this.GVCPTANA.GridControl = this.GCCPTANA;
      this.GVCPTANA.Name = "GVCPTANA";
      this.GVCPTANA.OptionsView.ShowGroupPanel = false;
      this.GVCPTANA.ShownEditor += new System.EventHandler(this.GVCPTANA_ShownEditor);
      this.GVCPTANA.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GVCPTANA_InvalidRowException);
      this.GVCPTANA.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GVCPTANA_ValidateRow);
      // 
      // GCCPTANA
      // 
      resources.ApplyResources(this.GCCPTANA, "GCCPTANA");
      this.GCCPTANA.MainView = this.GVCPTANA;
      this.GCCPTANA.Name = "GCCPTANA";
      this.GCCPTANA.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepCboChaff,
            this.RepCboNCANNUM,
            this.RepositoryItemGV_ASS,
            this.RepositoryItemGV_FACTU,
            this.RepositoryItemGV_ASSCHAFF});
      this.GCCPTANA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVCPTANA});
      // 
      // BtnAdd
      // 
      resources.ApplyResources(this.BtnAdd, "BtnAdd");
      this.BtnAdd.Image = global::MozartCS.Properties.Resources.add_32;
      this.BtnAdd.Name = "BtnAdd";
      this.BtnAdd.UseVisualStyleBackColor = true;
      this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // UCCompteAnaClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.BtnDel);
      this.Controls.Add(this.BtnAdd);
      this.Controls.Add(this.GCCPTANA);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCCompteAnaClient";
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_ASSCHAFF)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_ASSCHAFF)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_FACTU)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_FACTU)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGridLookUpEditView_ASS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemGV_ASS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCBOCHAFF)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepCboChaff)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCBOCPTANA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepCboNCANNUM)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCPTANA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GCCPTANA)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button BtnDel;
    internal DevExpress.XtraGrid.Columns.GridColumn GCol_View_VPERNOM_ASSCHAFF;
    internal DevExpress.XtraGrid.Columns.GridColumn GCol_View_NPERNUM_ASSCHAFF;
    internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEditView_ASSCHAFF;
    internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGV_ASSCHAFF;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCLI_ASSCHAFF;
    internal DevExpress.XtraGrid.Columns.GridColumn GColView_FACTU_VPERNOM_FACTU;
    internal DevExpress.XtraGrid.Columns.GridColumn GColView_FACTU_NPERNUM_FACTU;
    internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEditView_FACTU;
    internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGV_FACTU;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCLI_FACTU;
    internal DevExpress.XtraGrid.Columns.GridColumn GColGVASS_VPERNOM_ASS;
    internal DevExpress.XtraGrid.Columns.GridColumn GColGVASS_NPERNUM_ASS;
    internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEditView_ASS;
    internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGV_ASS;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCLI_ASS;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCboChaffVPERNOM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCboChaffNPERNUM;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVCBOCHAFF;
    internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepCboChaff;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCPTANANPERNUM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCboCPTANAVCANLIB;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCboCPTANANCANNUM;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVCBOCPTANA;
    internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepCboNCANNUM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCPTANANCANNUM;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVCPTANA;
    internal DevExpress.XtraGrid.GridControl GCCPTANA;
    internal System.Windows.Forms.Button BtnAdd;
    internal System.Windows.Forms.Label LblTitre;
    private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
  }
}
