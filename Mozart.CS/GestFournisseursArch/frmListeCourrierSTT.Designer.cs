namespace MozartCS
{
  partial class frmListeCourrierSTT
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCourrierSTT));
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdCreer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdCreer
      // 
      resources.ApplyResources(this.cmdCreer, "cmdCreer");
      this.cmdCreer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCreer.HelpContextID = 0;
      this.cmdCreer.Name = "cmdCreer";
      this.cmdCreer.Tag = "2";
      this.cmdCreer.UseVisualStyleBackColor = true;
      this.cmdCreer.Click += new System.EventHandler(this.cmdCreer_Click);
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
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // frmListeCourrierSTT
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdCreer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdDetail);
      this.Name = "frmListeCourrierSTT";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeCourrierSTT_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdCreer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdDetail;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
