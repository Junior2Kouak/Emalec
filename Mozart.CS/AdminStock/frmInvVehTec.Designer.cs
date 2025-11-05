namespace MozartCS
{
  partial class frmInvVehTec
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvVehTec));
      this.LblTitre = new System.Windows.Forms.Label();
      this.cmdChoisir = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apicboPerTec = new MozartUC.apiCombo();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.BackColor = System.Drawing.Color.Wheat;
      this.LblTitre.Name = "LblTitre";
      // 
      // cmdChoisir
      // 
      resources.ApplyResources(this.cmdChoisir, "cmdChoisir");
      this.cmdChoisir.HelpContextID = 0;
      this.cmdChoisir.Name = "cmdChoisir";
      this.cmdChoisir.Tag = "15";
      this.cmdChoisir.UseVisualStyleBackColor = true;
      this.cmdChoisir.Click += new System.EventHandler(this.cmdChoisir_Click);
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
      // apicboPerTec
      // 
      resources.ApplyResources(this.apicboPerTec, "apicboPerTec");
      this.apicboPerTec.Name = "apicboPerTec";
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // frmInvVehTec
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdChoisir);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apicboPerTec);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.LblTitre);
      this.Name = "frmInvVehTec";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmInvVehTec_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Label LblTitre;
    private MozartUC.apiButton cmdChoisir;
    private MozartUC.apiCombo apicboPerTec;
  }
}
