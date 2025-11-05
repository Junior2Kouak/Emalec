
namespace MozartCS
{
  partial class UCCommercialClient : UCWizardBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCommercialClient));
      this.CboCommercial = new DevExpress.XtraEditors.GridLookUpEdit();
      this.GVCommercial = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GColNPERNUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GColVPERNOM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.LblTitre = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.CboCommercial.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCommercial)).BeginInit();
      this.SuspendLayout();
      // 
      // CboCommercial
      // 
      resources.ApplyResources(this.CboCommercial, "CboCommercial");
      this.CboCommercial.Name = "CboCommercial";
      this.CboCommercial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("CboCommercial.Properties.Buttons"))))});
      this.CboCommercial.Properties.DisplayMember = "VPERNOM";
      this.CboCommercial.Properties.NullText = resources.GetString("CboCommercial.Properties.NullText");
      this.CboCommercial.Properties.NullValuePrompt = resources.GetString("CboCommercial.Properties.NullValuePrompt");
      this.CboCommercial.Properties.PopupView = this.GVCommercial;
      this.CboCommercial.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
      this.CboCommercial.Properties.ValueMember = "NPERNUM";
      // 
      // GVCommercial
      // 
      this.GVCommercial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GColNPERNUM,
            this.GColVPERNOM});
      this.GVCommercial.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.GVCommercial.Name = "GVCommercial";
      this.GVCommercial.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.GVCommercial.OptionsView.ShowAutoFilterRow = true;
      this.GVCommercial.OptionsView.ShowGroupPanel = false;
      // 
      // GColNPERNUM
      // 
      this.GColNPERNUM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColNPERNUM.AppearanceHeader.Font")));
      this.GColNPERNUM.AppearanceHeader.Options.UseFont = true;
      this.GColNPERNUM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColNPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColNPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColNPERNUM, "GColNPERNUM");
      this.GColNPERNUM.FieldName = "NPERNUM";
      this.GColNPERNUM.Name = "GColNPERNUM";
      // 
      // GColVPERNOM
      // 
      this.GColVPERNOM.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GColVPERNOM.AppearanceHeader.Font")));
      this.GColVPERNOM.AppearanceHeader.Options.UseFont = true;
      this.GColVPERNOM.AppearanceHeader.Options.UseTextOptions = true;
      this.GColVPERNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GColVPERNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      resources.ApplyResources(this.GColVPERNOM, "GColVPERNOM");
      this.GColVPERNOM.FieldName = "VPERNOM";
      this.GColVPERNOM.Name = "GColVPERNOM";
      this.GColVPERNOM.OptionsColumn.AllowEdit = false;
      this.GColVPERNOM.OptionsColumn.ReadOnly = true;
      this.GColVPERNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label3.Name = "Label3";
      // 
      // UCCommercialClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.CboCommercial);
      this.Controls.Add(this.LblTitre);
      this.Controls.Add(this.Label3);
      this.Name = "UCCommercialClient";
      ((System.ComponentModel.ISupportInitialize)(this.CboCommercial.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVCommercial)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal DevExpress.XtraEditors.GridLookUpEdit CboCommercial;
    internal DevExpress.XtraGrid.Views.Grid.GridView GVCommercial;
    internal DevExpress.XtraGrid.Columns.GridColumn GColNPERNUM;
    internal DevExpress.XtraGrid.Columns.GridColumn GColVPERNOM;
    internal System.Windows.Forms.Label LblTitre;
    internal System.Windows.Forms.Label Label3;
  }
}
