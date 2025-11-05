namespace MozartCS
{
  partial class frmListeContactsFour
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeContactsFour));
      this.cmdFermer = new System.Windows.Forms.Button();
      this.lblTitre = new System.Windows.Forms.Label();
      this.ApiTGrid = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.Name = "lblTitre";
      // 
      // ApiTGrid
      // 
      resources.ApplyResources(this.ApiTGrid, "ApiTGrid");
      this.ApiTGrid.FilterBar = true;
      this.ApiTGrid.FooterBar = true;
      this.ApiTGrid.Name = "ApiTGrid";
      // 
      // frmListeContactsFour
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Controls.Add(this.ApiTGrid);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmListeContactsFour";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmListeContactsFour_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Label lblTitre;
    private MozartUC.apiTGrid ApiTGrid;
  }
}