namespace MozartCS
{
  partial class frmStatMenuWebClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatMenuWebClient));
			this.cmdQuitter = new MozartUC.apiButton();
			this.apiGrid = new MozartUC.apiTGrid();
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
			// apiGrid
			// 
			resources.ApplyResources(this.apiGrid, "apiGrid");
			this.apiGrid.FilterBar = true;
			this.apiGrid.FooterBar = true;
			this.apiGrid.Name = "apiGrid";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmStatMenuWebClient
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.apiGrid);
			this.Controls.Add(this.Label1);
			this.Name = "frmStatMenuWebClient";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatMenuWebClient_FormClosing);
			this.Load += new System.EventHandler(this.frmStatMenuWebClient_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
