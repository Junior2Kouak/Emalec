namespace MozartCS
{
  partial class frmRegoupRegPlan
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegoupRegPlan));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.txtRegroup0 = new MozartUC.apiTextBox();
      this.txtRegion0 = new MozartUC.apiTextBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
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
      // txtRegroup0
      // 
      resources.ApplyResources(this.txtRegroup0, "txtRegroup0");
      this.txtRegroup0.HelpContextID = 0;
      this.txtRegroup0.Name = "txtRegroup0";
      // 
      // txtRegion0
      // 
      this.txtRegion0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.txtRegion0, "txtRegion0");
      this.txtRegion0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.txtRegion0.HelpContextID = 0;
      this.txtRegion0.Name = "txtRegion0";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // frmRegoupRegPlan
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.txtRegroup0);
      this.Controls.Add(this.txtRegion0);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmRegoupRegPlan";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmRegoupRegPlan_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTextBox txtRegroup0;
    private MozartUC.apiTextBox txtRegion0;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
  }
}
