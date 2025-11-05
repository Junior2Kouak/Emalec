namespace MozartCS
{
  partial class frmListeFicPerso
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFicPerso));
      this.cmdType = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdAjout = new MozartUC.apiButton();
      this.CmdMax = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdType
      // 
      resources.ApplyResources(this.cmdType, "cmdType");
      this.cmdType.HelpContextID = 0;
      this.cmdType.Name = "cmdType";
      this.cmdType.Tag = "19";
      this.cmdType.UseVisualStyleBackColor = true;
      this.cmdType.Click += new System.EventHandler(this.cmdType_Click);
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      this.apiGrid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiGrid_ClickE);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // cmdModifier
      // 
      this.cmdModifier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdAjout
      // 
      this.cmdAjout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdAjout, "cmdAjout");
      this.cmdAjout.HelpContextID = 0;
      this.cmdAjout.Name = "cmdAjout";
      this.cmdAjout.Tag = "2";
      this.cmdAjout.UseVisualStyleBackColor = true;
      this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
      // 
      // CmdMax
      // 
      resources.ApplyResources(this.CmdMax, "CmdMax");
      this.CmdMax.HelpContextID = 0;
      this.CmdMax.Name = "CmdMax";
      this.CmdMax.UseVisualStyleBackColor = true;
      this.CmdMax.Click += new System.EventHandler(this.CmdMax_Click);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // frmListeFicPerso
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdType);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdAjout);
      this.Controls.Add(this.CmdMax);
      this.Controls.Add(this.WebBrowser1);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeFicPerso";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeFicPerso_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdType;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdAjout;
    private MozartUC.apiButton CmdMax;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private System.Windows.Forms.Label Label1;

  }
}
