namespace MozartCS
{
  partial class frmListeDevisWebSTArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDevisWebSTArch));
      this.cmdRestaurer = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label2 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdRestaurer
      // 
      this.cmdRestaurer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "27";
      this.cmdRestaurer.UseVisualStyleBackColor = false;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // frmListeDevisWebSTArch
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label2);
      this.Name = "frmListeDevisWebSTArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDevisWebSTArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel Label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
