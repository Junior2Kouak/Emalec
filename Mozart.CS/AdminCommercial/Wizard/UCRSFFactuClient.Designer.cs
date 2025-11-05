
namespace MozartCS
{
  partial class UCRSFFactuClient : UCWizardBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRSFFactuClient));
      this.TxtSIRET = new System.Windows.Forms.TextBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.GrpReglement = new System.Windows.Forms.GroupBox();
      this.txtRSFSup = new DevExpress.XtraEditors.TextEdit();
      this.Label13 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.cboRSFFin = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GVVRSFFINMOIS = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColVRSFFINMOIS = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Label10 = new System.Windows.Forms.Label();
      this.cboRSFNBJ = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GVRSFNBJ = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColVRSFNBJ = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColNRSFNBJ = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Label9 = new System.Windows.Forms.Label();
      this.CboRSFTyp = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GVRSFType = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColVRSFTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
      this.Label8 = new System.Windows.Forms.Label();
      this.TxtRSFTVAIntra = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.TxtRSFServ = new DevExpress.XtraEditors.TextEdit();
      this.Label6 = new System.Windows.Forms.Label();
      this.GridRSFVille = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GVVille = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColCommune = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColCODEPOSTAL = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GridRSFPays = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GridPays = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColNPAYSNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVPAYSNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.TxtRSFNom = new DevExpress.XtraEditors.TextEdit();
      this.TxtRSFCP = new System.Windows.Forms.TextBox();
      this.TxtRSFAD2 = new System.Windows.Forms.TextBox();
      this.TxtRSFAD1 = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.LblTitre = new System.Windows.Forms.Label();
      this.txtVille = new System.Windows.Forms.TextBox();
      this.GrpReglement.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRSFSup.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboRSFFin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVVRSFFINMOIS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboRSFNBJ.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVRSFNBJ)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.CboRSFTyp.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVRSFType)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtRSFServ.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridRSFVille.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVVille)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridRSFPays.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridPays)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtRSFNom.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtSIRET
      // 
      resources.ApplyResources(this.TxtSIRET, "TxtSIRET");
      this.TxtSIRET.Name = "TxtSIRET";
      this.TxtSIRET.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label5.Name = "Label5";
      // 
      // GrpReglement
      // 
      this.GrpReglement.Controls.Add(this.txtRSFSup);
      this.GrpReglement.Controls.Add(this.Label13);
      this.GrpReglement.Controls.Add(this.Label12);
      this.GrpReglement.Controls.Add(this.cboRSFFin);
      this.GrpReglement.Controls.Add(this.Label10);
      this.GrpReglement.Controls.Add(this.cboRSFNBJ);
      this.GrpReglement.Controls.Add(this.Label9);
      this.GrpReglement.Controls.Add(this.CboRSFTyp);
      this.GrpReglement.Controls.Add(this.Label8);
      resources.ApplyResources(this.GrpReglement, "GrpReglement");
      this.GrpReglement.ForeColor = System.Drawing.Color.IndianRed;
      this.GrpReglement.Name = "GrpReglement";
      this.GrpReglement.TabStop = false;
      // 
      // txtRSFSup
      // 
      resources.ApplyResources(this.txtRSFSup, "txtRSFSup");
      this.txtRSFSup.Name = "txtRSFSup";
      this.txtRSFSup.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
      this.txtRSFSup.Properties.MaskSettings.Set("mask", "d");
      this.txtRSFSup.Properties.NullValuePrompt = resources.GetString("txtRSFSup.Properties.NullValuePrompt");
      // 
      // Label13
      // 
      resources.ApplyResources(this.Label13, "Label13");
      this.Label13.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label13.Name = "Label13";
      // 
      // Label12
      // 
      resources.ApplyResources(this.Label12, "Label12");
      this.Label12.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label12.Name = "Label12";
      // 
      // cboRSFFin
      // 
      resources.ApplyResources(this.cboRSFFin, "cboRSFFin");
      this.cboRSFFin.Name = "cboRSFFin";
      this.cboRSFFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cboRSFFin.Properties.Buttons"))))});
      this.cboRSFFin.Properties.DisplayMember = "VRSFFINMOIS";
      this.cboRSFFin.Properties.NullText = resources.GetString("cboRSFFin.Properties.NullText");
      this.cboRSFFin.Properties.NullValuePrompt = resources.GetString("cboRSFFin.Properties.NullValuePrompt");
      this.cboRSFFin.Properties.PopupView = this.GVVRSFFINMOIS;
      this.cboRSFFin.Properties.ValueMember = "VRSFFINMOIS";
      this.cboRSFFin.EditValueChanged += new System.EventHandler(this.Event_EditValueChanged);
      // 
      // GVVRSFFINMOIS
      // 
      this.GVVRSFFINMOIS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColVRSFFINMOIS});
      this.GVVRSFFINMOIS.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVVRSFFINMOIS.Name = "GVVRSFFINMOIS";
      this.GVVRSFFINMOIS.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVVRSFFINMOIS.OptionsView.ShowGroupPanel = false;
      // 
      // GColVRSFFINMOIS
      // 
      this.GColVRSFFINMOIS.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColVRSFFINMOIS.AppearanceHeader.Font")));
      this.GColVRSFFINMOIS.AppearanceHeader.Options.UseFont = true;
      this.GColVRSFFINMOIS.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVRSFFINMOIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVRSFFINMOIS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVRSFFINMOIS, "GColVRSFFINMOIS");
      this.GColVRSFFINMOIS.FieldName = "VRSFFINMOIS";
      this.GColVRSFFINMOIS.Name = "GColVRSFFINMOIS";
      this.GColVRSFFINMOIS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label10.Name = "Label10";
      // 
      // cboRSFNBJ
      // 
      resources.ApplyResources(this.cboRSFNBJ, "cboRSFNBJ");
      this.cboRSFNBJ.Name = "cboRSFNBJ";
      this.cboRSFNBJ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cboRSFNBJ.Properties.Buttons"))))});
      this.cboRSFNBJ.Properties.DisplayMember = "VRSFNBJ";
      this.cboRSFNBJ.Properties.NullText = resources.GetString("cboRSFNBJ.Properties.NullText");
      this.cboRSFNBJ.Properties.NullValuePrompt = resources.GetString("cboRSFNBJ.Properties.NullValuePrompt");
      this.cboRSFNBJ.Properties.PopupView = this.GVRSFNBJ;
      this.cboRSFNBJ.Properties.ValueMember = "NRSFNBJ";
      this.cboRSFNBJ.EditValueChanged += new System.EventHandler(this.Event_EditValueChanged);
      // 
      // GVRSFNBJ
      // 
      this.GVRSFNBJ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColVRSFNBJ,
            this.GColNRSFNBJ});
      this.GVRSFNBJ.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVRSFNBJ.Name = "GVRSFNBJ";
      this.GVRSFNBJ.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVRSFNBJ.OptionsView.ShowGroupPanel = false;
      // 
      // GColVRSFNBJ
      // 
      this.GColVRSFNBJ.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColVRSFNBJ.AppearanceHeader.Font")));
      this.GColVRSFNBJ.AppearanceHeader.Options.UseFont = true;
      this.GColVRSFNBJ.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVRSFNBJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVRSFNBJ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVRSFNBJ, "GColVRSFNBJ");
      this.GColVRSFNBJ.FieldName = "VRSFNBJ";
      this.GColVRSFNBJ.Name = "GColVRSFNBJ";
      this.GColVRSFNBJ.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColNRSFNBJ
      // 
      resources.ApplyResources(this.GColNRSFNBJ, "GColNRSFNBJ");
      this.GColNRSFNBJ.FieldName = "NRSFNBJ";
      this.GColNRSFNBJ.Name = "GColNRSFNBJ";
      // 
      // Label9
      // 
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label9.Name = "Label9";
      // 
      // CboRSFTyp
      // 
      resources.ApplyResources(this.CboRSFTyp, "CboRSFTyp");
      this.CboRSFTyp.Name = "CboRSFTyp";
      this.CboRSFTyp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CboRSFTyp.Properties.Buttons"))))});
      this.CboRSFTyp.Properties.DisplayMember = "VRSFTYPE";
      this.CboRSFTyp.Properties.NullText = resources.GetString("CboRSFTyp.Properties.NullText");
      this.CboRSFTyp.Properties.NullValuePrompt = resources.GetString("CboRSFTyp.Properties.NullValuePrompt");
      this.CboRSFTyp.Properties.PopupView = this.GVRSFType;
      this.CboRSFTyp.Properties.ValueMember = "VRSFTYPE";
      this.CboRSFTyp.EditValueChanged += new System.EventHandler(this.Event_EditValueChanged);
      // 
      // GVRSFType
      // 
      this.GVRSFType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColVRSFTYPE});
      this.GVRSFType.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVRSFType.Name = "GVRSFType";
      this.GVRSFType.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVRSFType.OptionsView.ShowGroupPanel = false;
      // 
      // GColVRSFTYPE
      // 
      this.GColVRSFTYPE.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColVRSFTYPE.AppearanceHeader.Font")));
      this.GColVRSFTYPE.AppearanceHeader.Options.UseFont = true;
      this.GColVRSFTYPE.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVRSFTYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVRSFTYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVRSFTYPE, "GColVRSFTYPE");
      this.GColVRSFTYPE.FieldName = "VRSFTYPE";
      this.GColVRSFTYPE.Name = "GColVRSFTYPE";
      this.GColVRSFTYPE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // Label8
      // 
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label8.Name = "Label8";
      // 
      // TxtRSFTVAIntra
      // 
      resources.ApplyResources(this.TxtRSFTVAIntra, "TxtRSFTVAIntra");
      this.TxtRSFTVAIntra.Name = "TxtRSFTVAIntra";
      this.TxtRSFTVAIntra.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      this.TxtRSFTVAIntra.Leave += new System.EventHandler(this.TxtRSFTVAIntra_Leave);
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label7.Name = "Label7";
      // 
      // TxtRSFServ
      // 
      resources.ApplyResources(this.TxtRSFServ, "TxtRSFServ");
      this.TxtRSFServ.Name = "TxtRSFServ";
      this.TxtRSFServ.Properties.MaskSettings.Set("mask", null);
      this.TxtRSFServ.Properties.MaxLength = 150;
      this.TxtRSFServ.Properties.NullValuePrompt = resources.GetString("TxtRSFServ.Properties.NullValuePrompt");
      // 
      // Label6
      // 
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label6.Name = "Label6";
      // 
      // GridRSFVille
      // 
      resources.ApplyResources(this.GridRSFVille, "GridRSFVille");
      this.GridRSFVille.Name = "GridRSFVille";
      this.GridRSFVille.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("GridRSFVille.Properties.Buttons"))))});
      this.GridRSFVille.Properties.DisplayMember = "VILLE";
      this.GridRSFVille.Properties.NullText = resources.GetString("GridRSFVille.Properties.NullText");
      this.GridRSFVille.Properties.NullValuePrompt = resources.GetString("GridRSFVille.Properties.NullValuePrompt");
      this.GridRSFVille.Properties.PopupView = this.GVVille;
      this.GridRSFVille.Properties.ValueMember = "VILLE";
      this.GridRSFVille.EditValueChanged += new System.EventHandler(this.GridRSFVille_EditValueChanged);
      // 
      // GVVille
      // 
      this.GVVille.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColCommune,
            this.GColCODEPOSTAL});
      this.GVVille.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVVille.Name = "GVVille";
      this.GVVille.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVVille.OptionsView.ShowAutoFilterRow = true;
      this.GVVille.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
      this.GVVille.OptionsView.ShowGroupPanel = false;
      this.GVVille.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GVVille_RowClick);
      // 
      // GColCommune
      // 
      this.GColCommune.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCommune.AppearanceHeader.Font")));
      this.GColCommune.AppearanceHeader.Options.UseFont = true;
      this.GColCommune.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCommune.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCommune.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCommune, "GColCommune");
      this.GColCommune.FieldName = "VILLE";
      this.GColCommune.Name = "GColCommune";
      this.GColCommune.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GColCODEPOSTAL
      // 
      this.GColCODEPOSTAL.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColCODEPOSTAL.AppearanceHeader.Font")));
      this.GColCODEPOSTAL.AppearanceHeader.Options.UseFont = true;
      this.GColCODEPOSTAL.AppearanceHeader.Options.UseTextOptions = true;
      this.GColCODEPOSTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColCODEPOSTAL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColCODEPOSTAL, "GColCODEPOSTAL");
      this.GColCODEPOSTAL.FieldName = "CODEPOSTAL";
      this.GColCODEPOSTAL.Name = "GColCODEPOSTAL";
      this.GColCODEPOSTAL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // GridRSFPays
      // 
      resources.ApplyResources(this.GridRSFPays, "GridRSFPays");
      this.GridRSFPays.Name = "GridRSFPays";
      this.GridRSFPays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("GridRSFPays.Properties.Buttons"))))});
      this.GridRSFPays.Properties.DisplayMember = "VPAYSNOM";
      this.GridRSFPays.Properties.NullText = resources.GetString("GridRSFPays.Properties.NullText");
      this.GridRSFPays.Properties.NullValuePrompt = resources.GetString("GridRSFPays.Properties.NullValuePrompt");
      this.GridRSFPays.Properties.PopupView = this.GridPays;
      this.GridRSFPays.Properties.ValueMember = "NPAYSNUM";
      this.GridRSFPays.EditValueChanged += new System.EventHandler(this.GridRSFPays_EditValueChanged);
      // 
      // GridPays
      // 
      this.GridPays.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColNPAYSNUM,
            this.GColVPAYSNOM});
      this.GridPays.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GridPays.Name = "GridPays";
      this.GridPays.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GridPays.OptionsView.ShowAutoFilterRow = true;
      this.GridPays.OptionsView.ShowGroupPanel = false;
      // 
      // GColNPAYSNUM
      // 
      resources.ApplyResources(this.GColNPAYSNUM, "GColNPAYSNUM");
      this.GColNPAYSNUM.FieldName = "NPAYSNUM";
      this.GColNPAYSNUM.Name = "GColNPAYSNUM";
      // 
      // GColVPAYSNOM
      // 
      this.GColVPAYSNOM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColVPAYSNOM.AppearanceHeader.Font")));
      this.GColVPAYSNOM.AppearanceHeader.Options.UseFont = true;
      this.GColVPAYSNOM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVPAYSNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVPAYSNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVPAYSNOM, "GColVPAYSNOM");
      this.GColVPAYSNOM.FieldName = "VPAYSNOM";
      this.GColVPAYSNOM.Name = "GColVPAYSNOM";
      this.GColVPAYSNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // TxtRSFNom
      // 
      resources.ApplyResources(this.TxtRSFNom, "TxtRSFNom");
      this.TxtRSFNom.Name = "TxtRSFNom";
      this.TxtRSFNom.Properties.MaskSettings.Set("mask", null);
      this.TxtRSFNom.Properties.MaxLength = 150;
      this.TxtRSFNom.Properties.NullValuePrompt = resources.GetString("TxtRSFNom.Properties.NullValuePrompt");
      this.TxtRSFNom.EditValueChanged += new System.EventHandler(this.TxtRSFNom_EditValueChanged);
      // 
      // TxtRSFCP
      // 
      resources.ApplyResources(this.TxtRSFCP, "TxtRSFCP");
      this.TxtRSFCP.Name = "TxtRSFCP";
      this.TxtRSFCP.TextChanged += new System.EventHandler(this.TxtRSFCP_TextChanged);
      // 
      // TxtRSFAD2
      // 
      resources.ApplyResources(this.TxtRSFAD2, "TxtRSFAD2");
      this.TxtRSFAD2.Name = "TxtRSFAD2";
      // 
      // TxtRSFAD1
      // 
      resources.ApplyResources(this.TxtRSFAD1, "TxtRSFAD1");
      this.TxtRSFAD1.Name = "TxtRSFAD1";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label1.Name = "Label1";
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // txtVille
      // 
      resources.ApplyResources(this.txtVille, "txtVille");
      this.txtVille.Name = "txtVille";
      this.txtVille.TextChanged += new System.EventHandler(this.txtVille_TextChanged);
      this.txtVille.Leave += new System.EventHandler(this.txtVille_Leave);
      // 
      // UCRSFFactuClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.txtVille);
      this.Controls.Add(this.TxtSIRET);
      this.Controls.Add(this.Label5);
      this.Controls.Add(this.GrpReglement);
      this.Controls.Add(this.TxtRSFTVAIntra);
      this.Controls.Add(this.Label7);
      this.Controls.Add(this.TxtRSFServ);
      this.Controls.Add(this.Label6);
      this.Controls.Add(this.GridRSFVille);
      this.Controls.Add(this.GridRSFPays);
      this.Controls.Add(this.TxtRSFNom);
      this.Controls.Add(this.TxtRSFCP);
      this.Controls.Add(this.TxtRSFAD2);
      this.Controls.Add(this.TxtRSFAD1);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCRSFFactuClient";
      this.GrpReglement.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtRSFSup.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboRSFFin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVVRSFFINMOIS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboRSFNBJ.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVRSFNBJ)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.CboRSFTyp.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVRSFType)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtRSFServ.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridRSFVille.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVVille)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridRSFPays.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GridPays)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtRSFNom.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.TextBox TxtSIRET;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.GroupBox GrpReglement;
    internal DevExpress.XtraEditors.TextEdit txtRSFSup;
    internal System.Windows.Forms.Label Label13;
    internal System.Windows.Forms.Label Label12;
    internal DevExpress.XtraEditors.GridLookUpEdit cboRSFFin;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVVRSFFINMOIS;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVRSFFINMOIS;
    internal System.Windows.Forms.Label Label10;
    internal DevExpress.XtraEditors.GridLookUpEdit cboRSFNBJ;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVRSFNBJ;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVRSFNBJ;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNRSFNBJ;
    internal System.Windows.Forms.Label Label9;
    internal DevExpress.XtraEditors.GridLookUpEdit CboRSFTyp;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVRSFType;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVRSFTYPE;
    internal System.Windows.Forms.Label Label8;
    internal System.Windows.Forms.TextBox TxtRSFTVAIntra;
    internal System.Windows.Forms.Label Label7;
    internal DevExpress.XtraEditors.TextEdit TxtRSFServ;
    internal System.Windows.Forms.Label Label6;
    internal DevExpress.XtraEditors.GridLookUpEdit GridRSFVille;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVVille;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCommune;
    internal DevExpress.XtraGrid.Columns.GridColumn GColCODEPOSTAL;
    internal DevExpress.XtraEditors.GridLookUpEdit GridRSFPays;
    internal DevExpress.XtraGrid.Views.Grid.GridView GridPays;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNPAYSNUM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVPAYSNOM;
    internal DevExpress.XtraEditors.TextEdit TxtRSFNom;
    internal System.Windows.Forms.TextBox TxtRSFCP;
    internal System.Windows.Forms.TextBox TxtRSFAD2;
    internal System.Windows.Forms.TextBox TxtRSFAD1;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label LblTitre;
    private System.Windows.Forms.TextBox txtVille;
  }
}
