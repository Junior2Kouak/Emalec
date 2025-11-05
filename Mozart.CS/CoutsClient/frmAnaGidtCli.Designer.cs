namespace MozartCS
{
  partial class frmAnaGidtCli
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaGidtCli));
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.grdCentreRes = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.grdAffectCompt = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // grdCentreRes
      // 
      resources.ApplyResources(this.grdCentreRes, "grdCentreRes");
      this.grdCentreRes.FilterBar = true;
      this.grdCentreRes.FooterBar = true;
      this.grdCentreRes.Name = "grdCentreRes";
      this.grdCentreRes.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.grids_InitNewRowE);
      this.grdCentreRes.PreviewKeyDownE += new MozartUC.apiTGrid.PreviewKeyDownEEventHandler(this.grids_PreviewKeyDownE);
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
      // grdAfectCompt
      // 
      resources.ApplyResources(this.grdAffectCompt, "grdAfectCompt");
      this.grdAffectCompt.FilterBar = true;
      this.grdAffectCompt.FooterBar = true;
      this.grdAffectCompt.Name = "grdAfectCompt";
      this.grdAffectCompt.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.grids_InitNewRowE);
      this.grdAffectCompt.PreviewKeyDownE += new MozartUC.apiTGrid.PreviewKeyDownEEventHandler(this.grids_PreviewKeyDownE);
      // 
      // frmAnaGidtCli
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.grdCentreRes);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.grdAffectCompt);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmAnaGidtCli";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmAnaGidtCli_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid grdCentreRes;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid grdAffectCompt;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;

  }
}
