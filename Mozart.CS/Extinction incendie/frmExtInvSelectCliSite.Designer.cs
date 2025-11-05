namespace MozartCS
{
  partial class frmExtInvSelectCliSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtInvSelectCliSite));
      this.LookUpEditSite = new DevExpress.XtraEditors.LookUpEdit();
      this.LookUpEditCli = new DevExpress.XtraEditors.LookUpEdit();
      this.BtnFermer = new System.Windows.Forms.Button();
      this.BtnInvModif = new System.Windows.Forms.Button();
      this.LblLegCli = new System.Windows.Forms.Label();
      this.rdoTousSites = new System.Windows.Forms.RadioButton();
      this.rdoUnSite = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.LookUpEditSite.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCli.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // LookUpEditSite
      // 
      resources.ApplyResources(this.LookUpEditSite, "LookUpEditSite");
      this.LookUpEditSite.Name = "LookUpEditSite";
      this.LookUpEditSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUpEditSite.Properties.Buttons"))))});
      this.LookUpEditSite.Properties.NullText = resources.GetString("LookUpEditSite.Properties.NullText");
      this.LookUpEditSite.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
      // 
      // LookUpEditCli
      // 
      resources.ApplyResources(this.LookUpEditCli, "LookUpEditCli");
      this.LookUpEditCli.Name = "LookUpEditCli";
      this.LookUpEditCli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUpEditCli.Properties.Buttons"))))});
      this.LookUpEditCli.Properties.NullText = resources.GetString("LookUpEditCli.Properties.NullText");
      this.LookUpEditCli.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
      this.LookUpEditCli.EditValueChanged += new System.EventHandler(this.LookUpEditCli_EditValueChanged);
      // 
      // BtnFermer
      // 
      resources.ApplyResources(this.BtnFermer, "BtnFermer");
      this.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      // 
      // BtnInvModif
      // 
      resources.ApplyResources(this.BtnInvModif, "BtnInvModif");
      this.BtnInvModif.Name = "BtnInvModif";
      this.BtnInvModif.UseVisualStyleBackColor = true;
      this.BtnInvModif.Click += new System.EventHandler(this.BtnInvModif_Click);
      // 
      // LblLegCli
      // 
      resources.ApplyResources(this.LblLegCli, "LblLegCli");
      this.LblLegCli.Name = "LblLegCli";
      // 
      // rdoTousSites
      // 
      resources.ApplyResources(this.rdoTousSites, "rdoTousSites");
      this.rdoTousSites.Name = "rdoTousSites";
      this.rdoTousSites.TabStop = true;
      this.rdoTousSites.UseVisualStyleBackColor = true;
      this.rdoTousSites.CheckedChanged += new System.EventHandler(this.rdoSites_chechedChanged);
      // 
      // rdoUnSite
      // 
      resources.ApplyResources(this.rdoUnSite, "rdoUnSite");
      this.rdoUnSite.Name = "rdoUnSite";
      this.rdoUnSite.TabStop = true;
      this.rdoUnSite.UseVisualStyleBackColor = true;
      // 
      // frmExtInvSelectCliSite
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.BtnFermer;
      this.Controls.Add(this.rdoUnSite);
      this.Controls.Add(this.rdoTousSites);
      this.Controls.Add(this.LookUpEditSite);
      this.Controls.Add(this.LookUpEditCli);
      this.Controls.Add(this.BtnFermer);
      this.Controls.Add(this.BtnInvModif);
      this.Controls.Add(this.LblLegCli);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmExtInvSelectCliSite";
      this.Load += new System.EventHandler(this.frmExtInvSelectCliSite_Load);
      ((System.ComponentModel.ISupportInitialize)(this.LookUpEditSite.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.LookUpEditCli.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LookUpEdit LookUpEditSite;
    private DevExpress.XtraEditors.LookUpEdit LookUpEditCli;
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Button BtnInvModif;
    internal System.Windows.Forms.Label LblLegCli;
    private System.Windows.Forms.RadioButton rdoTousSites;
    private System.Windows.Forms.RadioButton rdoUnSite;
  }
}