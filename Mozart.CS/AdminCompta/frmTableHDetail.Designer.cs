namespace MozartCS
{
  partial class frmTableHDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableHDetail));
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      this.Label1.Tag = "D�tail des heures pour";
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.DoubleClick += new System.EventHandler(this.apiTGrid1_DoubleClick);
      // 
      // frmTableHDetail
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Name = "frmTableHDetail";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmTableHDetail_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    // TODO GetCodeDeclareControl cas non traité pour type Mozaris.ApiGrid
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGrid1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
