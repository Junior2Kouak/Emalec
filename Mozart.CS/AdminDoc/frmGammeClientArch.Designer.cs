namespace MozartCS
{
  partial class frmGammeClientArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGammeClientArch));
      this.CmdEdit = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdRest = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // CmdEdit
      // 
      resources.ApplyResources(this.CmdEdit, "CmdEdit");
      this.CmdEdit.HelpContextID = 0;
      this.CmdEdit.Name = "CmdEdit";
      this.CmdEdit.Tag = "17";
      this.CmdEdit.UseVisualStyleBackColor = true;
      this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "40";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
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
      // cmdRest
      // 
      resources.ApplyResources(this.cmdRest, "cmdRest");
      this.cmdRest.HelpContextID = 0;
      this.cmdRest.Name = "cmdRest";
      this.cmdRest.Tag = "27";
      this.cmdRest.UseVisualStyleBackColor = true;
      this.cmdRest.Click += new System.EventHandler(this.cmdRest_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // frmGammeClientArch
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.CmdEdit);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdRest);
      this.Controls.Add(this.Label1);
      this.Name = "frmGammeClientArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGammeClientArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdEdit;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdRest;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGrid1;
  }
}
