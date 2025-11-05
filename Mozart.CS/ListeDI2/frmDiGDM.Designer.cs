namespace MozartCS
{
  partial class frmDiGDM
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiGDM));
      this.cmdDecisionGDM = new MozartUC.apiButton();
      this.cmdArchiver = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdDecisionGDM
      // 
      resources.ApplyResources(this.cmdDecisionGDM, "cmdDecisionGDM");
      this.cmdDecisionGDM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDecisionGDM.HelpContextID = 426;
      this.cmdDecisionGDM.Name = "cmdDecisionGDM";
      this.cmdDecisionGDM.UseVisualStyleBackColor = true;
      this.cmdDecisionGDM.Click += new System.EventHandler(this.cmdDecisionGDM_Click);
      // 
      // cmdArchiver
      // 
      resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
      this.cmdArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchiver.HelpContextID = 0;
      this.cmdArchiver.Name = "cmdArchiver";
      this.cmdArchiver.Tag = "66";
      this.cmdArchiver.UseVisualStyleBackColor = true;
      this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
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
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmDiGDM
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDecisionGDM);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmDiGDM";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDiGDM_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDecisionGDM;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
