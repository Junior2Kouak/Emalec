
namespace MozartControls
{
  partial class UCGridTva
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGridTva));
      this.cmdSupprTVA = new MozartUC.apiButton();
      this.cmdAddTVA = new MozartUC.apiButton();
      this.apiTGridTva = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdSupprTVA
      // 
      resources.ApplyResources(this.cmdSupprTVA, "cmdSupprTVA");
      this.cmdSupprTVA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprTVA.HelpContextID = 0;
      this.cmdSupprTVA.Image = global::MozartControls.Properties.Resources.delete_32;
      this.cmdSupprTVA.Name = "cmdSupprTVA";
      this.cmdSupprTVA.Tag = "65";
      this.cmdSupprTVA.UseVisualStyleBackColor = true;
      this.cmdSupprTVA.Click += new System.EventHandler(this.cmdSupprTVA_Click);
      // 
      // cmdAddTVA
      // 
      resources.ApplyResources(this.cmdAddTVA, "cmdAddTVA");
      this.cmdAddTVA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAddTVA.HelpContextID = 0;
      this.cmdAddTVA.Image = global::MozartControls.Properties.Resources.add_32;
      this.cmdAddTVA.Name = "cmdAddTVA";
      this.cmdAddTVA.Tag = "2";
      this.cmdAddTVA.UseVisualStyleBackColor = true;
      this.cmdAddTVA.Click += new System.EventHandler(this.cmdAddTVA_Click);
      // 
      // apiTGridTva
      // 
      resources.ApplyResources(this.apiTGridTva, "apiTGridTva");
      this.apiTGridTva.FilterBar = false;
      this.apiTGridTva.FooterBar = true;
      this.apiTGridTva.Name = "apiTGridTva";
      this.apiTGridTva.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.apiTGridTva_InitNewRowE);
      this.apiTGridTva.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGridTva_RowStyle);
      // 
      // UCGridTva
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cmdSupprTVA);
      this.Controls.Add(this.cmdAddTVA);
      this.Controls.Add(this.apiTGridTva);
      this.Name = "UCGridTva";
      this.Resize += new System.EventHandler(this.UCGridTva_Resize);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTGrid apiTGridTva;
    private MozartUC.apiButton cmdSupprTVA;
    private MozartUC.apiButton cmdAddTVA;
  }
}
