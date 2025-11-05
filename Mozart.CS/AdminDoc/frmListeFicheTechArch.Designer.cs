namespace MozartCS
{
  partial class frmListeFicheTechArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFicheTechArch));
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdRest = new MozartUC.apiButton();
      this.apiTGrid_FicheTech = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.HelpContextID = 317;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // cmdRest
      // 
      resources.ApplyResources(this.cmdRest, "cmdRest");
      this.cmdRest.HelpContextID = 317;
      this.cmdRest.Name = "cmdRest";
      this.cmdRest.Tag = "27";
      this.cmdRest.UseVisualStyleBackColor = true;
      this.cmdRest.Click += new System.EventHandler(this.cmdRest_Click);
      // 
      // apiTGrid_FicheTech
      // 
      resources.ApplyResources(this.apiTGrid_FicheTech, "apiTGrid_FicheTech");
      this.apiTGrid_FicheTech.FilterBar = true;
      this.apiTGrid_FicheTech.FooterBar = true;
      this.apiTGrid_FicheTech.Name = "apiTGrid_FicheTech";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeFicheTechArch
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdRest);
      this.Controls.Add(this.apiTGrid_FicheTech);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeFicheTechArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeFicheTechArch_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdRest;
    private MozartUC.apiTGrid apiTGrid_FicheTech;
    private MozartUC.apiLabel Label1;
  }
}
