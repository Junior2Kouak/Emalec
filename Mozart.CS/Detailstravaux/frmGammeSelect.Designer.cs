namespace MozartCS
{
  partial class frmGammeSelect
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGammeSelect));
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGridGamme = new MozartUC.apiTGrid();
      this.Label8 = new System.Windows.Forms.Label();
      this.lblColorGamme = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.apiTGridGamme_DoubleClick_cmdValider_Click);
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
      // apiTGridGamme
      // 
      resources.ApplyResources(this.apiTGridGamme, "apiTGridGamme");
      this.apiTGridGamme.FilterBar = true;
      this.apiTGridGamme.FooterBar = true;
      this.apiTGridGamme.Name = "apiTGridGamme";
      this.apiTGridGamme.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGridGamme_DoubleClick_cmdValider_Click);
      this.apiTGridGamme.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGridGamme_RowStyle);
      // 
      // Label8
      // 
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.BackColor = System.Drawing.Color.Wheat;
      this.Label8.Name = "Label8";
      // 
      // lblColorGamme
      // 
      this.lblColorGamme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.lblColorGamme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblColorGamme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.lblColorGamme, "lblColorGamme");
      this.lblColorGamme.Name = "lblColorGamme";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.Name = "Label14";
      // 
      // frmGammeSelect
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGridGamme);
      this.Controls.Add(this.Label8);
      this.Controls.Add(this.lblColorGamme);
      this.Controls.Add(this.Label14);
      this.Name = "frmGammeSelect";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmGammeSelect_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridGamme;
    private System.Windows.Forms.Label Label8;
    private System.Windows.Forms.Label lblColorGamme;
    private System.Windows.Forms.Label Label14;

  }
}
