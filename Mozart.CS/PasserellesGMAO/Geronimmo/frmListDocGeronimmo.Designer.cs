namespace MozartCS
{
  partial class frmListDocGeronimmo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDocGeronimmo));
			this.cmdcopier = new MozartUC.apiButton();
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.CmdMax = new MozartUC.apiButton();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.apigrid = new MozartUC.apiTGrid();
			this.Label1 = new MozartUC.apiLabel();
			this.SuspendLayout();
			// 
			// cmdcopier
			// 
			resources.ApplyResources(this.cmdcopier, "cmdcopier");
			this.cmdcopier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdcopier.HelpContextID = 0;
			this.cmdcopier.Name = "cmdcopier";
			this.cmdcopier.Tag = "27";
			this.cmdcopier.UseVisualStyleBackColor = true;
			this.cmdcopier.Click += new System.EventHandler(this.cmdCopier_Click);
			// 
			// WebBrowser1
			// 
			resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
			this.WebBrowser1.Name = "WebBrowser1";
			// 
			// CmdMax
			// 
			resources.ApplyResources(this.CmdMax, "CmdMax");
			this.CmdMax.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdMax.HelpContextID = 0;
			this.CmdMax.Name = "CmdMax";
			this.CmdMax.UseVisualStyleBackColor = true;
			this.CmdMax.Click += new System.EventHandler(this.CmdMax_Click);
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
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// apigrid
			// 
			this.apigrid.FilterBar = true;
			resources.ApplyResources(this.apigrid, "apigrid");
			this.apigrid.FooterBar = true;
			this.apigrid.Name = "apigrid";
			this.apigrid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apigrid_ClickE);
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmListDocEmPlus
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdcopier);
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.CmdMax);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.apigrid);
			this.Controls.Add(this.Label1);
			this.Name = "frmListDocEmPlus";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListDocOTTech_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdcopier;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiButton CmdMax;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
