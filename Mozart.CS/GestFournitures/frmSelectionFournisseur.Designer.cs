namespace MozartCS
{
  partial class frmSelectionFournisseur
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionFournisseur));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSelectionner = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.mstrFourniture = new System.Windows.Forms.Label();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSelectionner
      // 
      resources.ApplyResources(this.cmdSelectionner, "cmdSelectionner");
      this.cmdSelectionner.HelpContextID = 0;
      this.cmdSelectionner.Name = "cmdSelectionner";
      this.cmdSelectionner.Tag = "20";
      this.cmdSelectionner.UseVisualStyleBackColor = true;
      this.cmdSelectionner.Click += new System.EventHandler(this.cmdSelectionner_and_apigrid_DoubleClick);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label1.Name = "Label1";
      // 
      // mstrFourniture
      // 
      resources.ApplyResources(this.mstrFourniture, "mstrFourniture");
      this.mstrFourniture.BackColor = System.Drawing.Color.Wheat;
      this.mstrFourniture.Name = "mstrFourniture";
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.cmdSelectionner_and_apigrid_DoubleClick);
      // 
      // frmSelectionFournisseur
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSelectionner);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.mstrFourniture);
      this.Name = "frmSelectionFournisseur";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSelectionFournisseur_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSelectionner;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label mstrFourniture;
    private MozartUC.apiTGrid apiTGrid;
  }
}
