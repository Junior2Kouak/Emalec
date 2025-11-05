
namespace MozartCS
{
  partial class UCContactClient : UCWizardBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCContactClient));
      this.TxtCCLFonction = new System.Windows.Forms.TextBox();
      this.Label11 = new System.Windows.Forms.Label();
      this.TxtCCLMail = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.TxtCCLPort = new System.Windows.Forms.TextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.TxtCCLTel = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.TxtCCLPrenom = new DevExpress.XtraEditors.TextEdit();
      this.Label7 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.CboCCLCiv = new System.Windows.Forms.ComboBox();
      this.TxtCCLNom = new DevExpress.XtraEditors.TextEdit();
      this.Label1 = new System.Windows.Forms.Label();
      this.GrpCCL = new System.Windows.Forms.GroupBox();
      this.LblTitre = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.TxtCCLPrenom.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtCCLNom.Properties)).BeginInit();
      this.GrpCCL.SuspendLayout();
      this.SuspendLayout();
      // 
      // TxtCCLFonction
      // 
      resources.ApplyResources(this.TxtCCLFonction, "TxtCCLFonction");
      this.TxtCCLFonction.Name = "TxtCCLFonction";
      // 
      // Label11
      // 
      resources.ApplyResources(this.Label11, "Label11");
      this.Label11.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label11.Name = "Label11";
      // 
      // TxtCCLMail
      // 
      resources.ApplyResources(this.TxtCCLMail, "TxtCCLMail");
      this.TxtCCLMail.Name = "TxtCCLMail";
      this.TxtCCLMail.TextChanged += new System.EventHandler(this.TxtCCLMail_TextChanged);
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label10.Name = "Label10";
      // 
      // TxtCCLPort
      // 
      resources.ApplyResources(this.TxtCCLPort, "TxtCCLPort");
      this.TxtCCLPort.Name = "TxtCCLPort";
      this.TxtCCLPort.Leave += new System.EventHandler(this.TxtCCLTel_Leave);
      // 
      // Label9
      // 
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label9.Name = "Label9";
      // 
      // TxtCCLTel
      // 
      resources.ApplyResources(this.TxtCCLTel, "TxtCCLTel");
      this.TxtCCLTel.Name = "TxtCCLTel";
      this.TxtCCLTel.Leave += new System.EventHandler(this.TxtCCLTel_Leave);
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label3.Name = "Label3";
      // 
      // TxtCCLPrenom
      // 
      resources.ApplyResources(this.TxtCCLPrenom, "TxtCCLPrenom");
      this.TxtCCLPrenom.Name = "TxtCCLPrenom";
      this.TxtCCLPrenom.Properties.MaskSettings.Set("mask", null);
      this.TxtCCLPrenom.Properties.MaxLength = 30;
      this.TxtCCLPrenom.Properties.NullValuePrompt = resources.GetString("TxtCCLPrenom.Properties.NullValuePrompt");
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label7.Name = "Label7";
      // 
      // Label6
      // 
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label6.Name = "Label6";
      // 
      // CboCCLCiv
      // 
      this.CboCCLCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CboCCLCiv.FormattingEnabled = true;
      this.CboCCLCiv.Items.AddRange(new object[] {
            resources.GetString("CboCCLCiv.Items"),
            resources.GetString("CboCCLCiv.Items1"),
            resources.GetString("CboCCLCiv.Items2")});
      resources.ApplyResources(this.CboCCLCiv, "CboCCLCiv");
      this.CboCCLCiv.Name = "CboCCLCiv";
      // 
      // TxtCCLNom
      // 
      resources.ApplyResources(this.TxtCCLNom, "TxtCCLNom");
      this.TxtCCLNom.Name = "TxtCCLNom";
      this.TxtCCLNom.Properties.MaskSettings.Set("mask", null);
      this.TxtCCLNom.Properties.MaxLength = 70;
      this.TxtCCLNom.Properties.NullValuePrompt = resources.GetString("TxtCCLNom.Properties.NullValuePrompt");
      this.TxtCCLNom.EditValueChanged += new System.EventHandler(this.TxtCCLNom_EditValueChanged);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.Color.DarkGreen;
      this.Label1.Name = "Label1";
      // 
      // GrpCCL
      // 
      this.GrpCCL.Controls.Add(this.TxtCCLFonction);
      this.GrpCCL.Controls.Add(this.Label11);
      this.GrpCCL.Controls.Add(this.TxtCCLMail);
      this.GrpCCL.Controls.Add(this.Label10);
      this.GrpCCL.Controls.Add(this.TxtCCLPort);
      this.GrpCCL.Controls.Add(this.Label9);
      this.GrpCCL.Controls.Add(this.TxtCCLTel);
      this.GrpCCL.Controls.Add(this.Label3);
      this.GrpCCL.Controls.Add(this.TxtCCLPrenom);
      this.GrpCCL.Controls.Add(this.Label7);
      this.GrpCCL.Controls.Add(this.Label6);
      this.GrpCCL.Controls.Add(this.CboCCLCiv);
      this.GrpCCL.Controls.Add(this.TxtCCLNom);
      this.GrpCCL.Controls.Add(this.Label1);
      resources.ApplyResources(this.GrpCCL, "GrpCCL");
      this.GrpCCL.Name = "GrpCCL";
      this.GrpCCL.TabStop = false;
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // UCContactClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.GrpCCL);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCContactClient";
      ((System.ComponentModel.ISupportInitialize)(this.TxtCCLPrenom.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TxtCCLNom.Properties)).EndInit();
      this.GrpCCL.ResumeLayout(false);
      this.GrpCCL.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.TextBox TxtCCLFonction;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.TextBox TxtCCLMail;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.TextBox TxtCCLPort;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.TextBox TxtCCLTel;
    internal System.Windows.Forms.Label Label3;
    internal DevExpress.XtraEditors.TextEdit TxtCCLPrenom;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ComboBox CboCCLCiv;
    internal DevExpress.XtraEditors.TextEdit TxtCCLNom;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.GroupBox GrpCCL;
    internal System.Windows.Forms.Label LblTitre;
  }
}
