namespace MozartCS
{
  partial class frmListeLogweb
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeLogweb));
			this.apiGrid = new MozartUC.apiTGrid();
			this.cmdQuitter = new MozartUC.apiButton();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// apiGrid
			// 
			resources.ApplyResources(this.apiGrid, "apiGrid");
			this.apiGrid.FilterBar = true;
			this.apiGrid.FooterBar = true;
			this.apiGrid.Name = "apiGrid";
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
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.Name = "Label1";
			// 
			// frmListeLogweb
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.apiGrid);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Label1);
			this.Name = "frmListeLogweb";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeLogweb_FormClosing);
			this.Load += new System.EventHandler(this.frmListeLogweb_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.Label Label1;

  }
}
