namespace MozartCS
{
  partial class frmAdminBudget
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminBudget));
      this.Label1 = new System.Windows.Forms.Label();
      this.cmdFermer = new MozartUC.apiButton();
      this.grdAffectCompt = new MozartUC.apiTGrid();
      this.btnCopier = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
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
      // grdAffectCompt
      // 
      resources.ApplyResources(this.grdAffectCompt, "grdAffectCompt");
      this.grdAffectCompt.FilterBar = true;
      this.grdAffectCompt.FooterBar = true;
      this.grdAffectCompt.Name = "grdAffectCompt";
      this.grdAffectCompt.Tag = "";
      this.grdAffectCompt.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.grids_InitNewRowE);
      this.grdAffectCompt.PreviewKeyDownE += new MozartUC.apiTGrid.PreviewKeyDownEEventHandler(this.grids_PreviewKeyDownE);
      // 
      // btnCopier
      // 
      resources.ApplyResources(this.btnCopier, "btnCopier");
      this.btnCopier.HelpContextID = 0;
      this.btnCopier.Name = "btnCopier";
      this.btnCopier.Tag = "15";
      this.btnCopier.UseVisualStyleBackColor = true;
      this.btnCopier.Click += new System.EventHandler(this.btnCopier_Click);
      // 
      // frmAdminBudget
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.btnCopier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.grdAffectCompt);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminBudget";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmAnaGidtCli_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid grdAffectCompt;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiButton btnCopier;
  }
}
