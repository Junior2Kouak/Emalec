namespace MozartCS
{
  partial class frmStockInventaireDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInventaireDetail));
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdCommande = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      // 
      // cmdCommande
      // 
      resources.ApplyResources(this.cmdCommande, "cmdCommande");
      this.cmdCommande.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCommande.HelpContextID = 0;
      this.cmdCommande.Name = "cmdCommande";
      this.cmdCommande.Tag = "4";
      this.cmdCommande.UseVisualStyleBackColor = true;
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmStockInventaireDetail
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdCommande);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmStockInventaireDetail";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmStockInventaireDetail_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdCommande;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblTitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
