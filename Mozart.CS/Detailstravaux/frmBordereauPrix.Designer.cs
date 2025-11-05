namespace MozartCS
{
  partial class frmBordereauPrix
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBordereauPrix));
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdCre = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGridHaut = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "66";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdCre
      // 
      resources.ApplyResources(this.cmdCre, "cmdCre");
      this.cmdCre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCre.HelpContextID = 0;
      this.cmdCre.Name = "cmdCre";
      this.cmdCre.Tag = "66";
      this.cmdCre.UseVisualStyleBackColor = true;
      this.cmdCre.Click += new System.EventHandler(this.cmdCre_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGridHaut
      // 
      resources.ApplyResources(this.apiTGridHaut, "apiTGridHaut");
      this.apiTGridHaut.FilterBar = true;
      this.apiTGridHaut.FooterBar = true;
      this.apiTGridHaut.Name = "apiTGridHaut";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmBordereauPrix
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdCre);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGridHaut);
      this.Controls.Add(this.Label1);
      this.Name = "frmBordereauPrix";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmBordereauPrix_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdCre;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridHaut;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
