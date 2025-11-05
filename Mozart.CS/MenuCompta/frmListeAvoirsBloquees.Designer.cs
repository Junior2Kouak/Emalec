namespace MozartCS
{
  partial class frmListeAvoirsBloquees
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeAvoirsBloquees));
      this.cmdFermer = new MozartUC.apiButton();
      this.TxtTotFact = new MozartUC.apiTextBox();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.LblTot = new System.Windows.Forms.Label();
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
      // TxtTotFact
      // 
      resources.ApplyResources(this.TxtTotFact, "TxtTotFact");
      this.TxtTotFact.HelpContextID = 0;
      this.TxtTotFact.Name = "TxtTotFact";
      this.TxtTotFact.ReadOnly = true;
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // LblTot
      // 
      resources.ApplyResources(this.LblTot, "LblTot");
      this.LblTot.BackColor = System.Drawing.Color.Wheat;
      this.LblTot.Name = "LblTot";
      // 
      // frmListeAvoirsBloquees
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.TxtTotFact);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.LblTot);
      this.Name = "frmListeAvoirsBloquees";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeAvoirsBloquees_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTextBox TxtTotFact;
    private MozartUC.apiTGrid apiTGrid;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label LblTot;

  }
}
