namespace MozartCS
{
  partial class frmGestFournitureArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFournitureArch));
      this.apiGrid = new MozartUC.apiTGrid();
      this.Command1 = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdArchiver = new MozartUC.apiButton();
      this.Label14 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Command1
      // 
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "29";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
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
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdArchiver
      // 
      resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
      this.cmdArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchiver.HelpContextID = 0;
      this.cmdArchiver.Name = "cmdArchiver";
      this.cmdArchiver.Tag = "27";
      this.cmdArchiver.UseVisualStyleBackColor = true;
      this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmGestFournitureArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.Label14);
      this.Name = "frmGestFournitureArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestFournitureArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiLabel Label14;

  }
}
