
namespace MozartCS
{
  partial class UCSiteClient : UCWizardBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSiteClient));
      this.BtnCreateSiteFalse = new System.Windows.Forms.Button();
      this.BtnCreateSiteTrue = new System.Windows.Forms.Button();
      this.Label1 = new System.Windows.Forms.Label();
      this.LblTitre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnCreateSiteFalse
      // 
      resources.ApplyResources(this.BtnCreateSiteFalse, "BtnCreateSiteFalse");
      this.BtnCreateSiteFalse.Name = "BtnCreateSiteFalse";
      this.BtnCreateSiteFalse.UseVisualStyleBackColor = true;
      this.BtnCreateSiteFalse.Click += new System.EventHandler(this.BtnCreateSiteFalse_Click);
      // 
      // BtnCreateSiteTrue
      // 
      resources.ApplyResources(this.BtnCreateSiteTrue, "BtnCreateSiteTrue");
      this.BtnCreateSiteTrue.Name = "BtnCreateSiteTrue";
      this.BtnCreateSiteTrue.UseVisualStyleBackColor = true;
      this.BtnCreateSiteTrue.Click += new System.EventHandler(this.BtnCreateSiteTrue_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // UCSiteClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.Controls.Add(this.BtnCreateSiteFalse);
      this.Controls.Add(this.BtnCreateSiteTrue);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.LblTitre);
      this.Name = "UCSiteClient";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button BtnCreateSiteFalse;
    internal System.Windows.Forms.Button BtnCreateSiteTrue;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label LblTitre;
  }
}
