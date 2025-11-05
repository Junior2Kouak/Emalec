namespace MozartCS
{
  partial class frmAdminCdes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCdes));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdCdesDI = new MozartUC.apiButton();
      this.cmdCdesPlanifiees = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
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
      // cmdCdesDI
      // 
      this.cmdCdesDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdCdesDI, "cmdCdesDI");
      this.cmdCdesDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCdesDI.HelpContextID = 0;
      this.cmdCdesDI.Name = "cmdCdesDI";
      this.cmdCdesDI.Tag = "49";
      this.cmdCdesDI.UseVisualStyleBackColor = false;
      this.cmdCdesDI.Click += new System.EventHandler(this.cmdCdesDI_Click);
      // 
      // cmdCdesPlanifiees
      // 
      this.cmdCdesPlanifiees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdCdesPlanifiees, "cmdCdesPlanifiees");
      this.cmdCdesPlanifiees.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCdesPlanifiees.HelpContextID = 0;
      this.cmdCdesPlanifiees.Name = "cmdCdesPlanifiees";
      this.cmdCdesPlanifiees.Tag = "5";
      this.cmdCdesPlanifiees.UseVisualStyleBackColor = false;
      this.cmdCdesPlanifiees.Click += new System.EventHandler(this.cmdCdesPlanifiées_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmAdminCdes
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdCdesDI);
      this.Controls.Add(this.cmdCdesPlanifiees);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminCdes";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminCdes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdCdesDI;
    private MozartUC.apiButton cmdCdesPlanifiees;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
