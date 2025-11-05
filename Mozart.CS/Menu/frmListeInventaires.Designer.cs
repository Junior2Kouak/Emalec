namespace MozartCS
{
  partial class frmListeInventaires
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeInventaires));
      this.cmdQTE = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdQTE
      // 
      resources.ApplyResources(this.cmdQTE, "cmdQTE");
      this.cmdQTE.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQTE.HelpContextID = 0;
      this.cmdQTE.Name = "cmdQTE";
      this.cmdQTE.Tag = "80";
      this.cmdQTE.UseVisualStyleBackColor = true;
      this.cmdQTE.Click += new System.EventHandler(this.cmdQTE_Click);
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
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "85";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.DoubleClick += new System.EventHandler(this.apigrid_DoubleClick);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeInventaires
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQTE);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeInventaires";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeInventaires_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQTE;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apigrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
