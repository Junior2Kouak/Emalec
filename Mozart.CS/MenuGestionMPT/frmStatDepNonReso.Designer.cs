namespace MozartCS
{
  partial class frmStatDepNonReso
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatDepNonReso));
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.lblinfo = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // lblinfo
      // 
      resources.ApplyResources(this.lblinfo, "lblinfo");
      this.lblinfo.BackColor = System.Drawing.Color.White;
      this.lblinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblinfo.HelpContextID = 0;
      this.lblinfo.Name = "lblinfo";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmStatDepNonReso
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.lblinfo);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmStatDepNonReso";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatDepNonReso_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel lblinfo;
    private MozartUC.apiLabel lblTitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
