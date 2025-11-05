namespace MozartCS
{
  partial class frmListeTxChange
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeTxChange));
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
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
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeTxChange
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeTxChange";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeTxChange_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
