namespace MozartCS
{
  partial class frmDetailFormuleRev
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailFormuleRev));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.txtFormule = new MozartUC.apiTextBox();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.txtFormule);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // txtFormule
      // 
      resources.ApplyResources(this.txtFormule, "txtFormule");
      this.txtFormule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtFormule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFormule.HelpContextID = 0;
      this.txtFormule.Name = "txtFormule";
      // 
      // frmDetailFormuleRev
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Name = "frmDetailFormuleRev";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmDetailFormuleRev_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTextBox txtFormule;
  }
}
