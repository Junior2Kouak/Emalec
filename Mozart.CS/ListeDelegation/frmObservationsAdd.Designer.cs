namespace MozartCS
{
  partial class frmObservationsAdd
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservationsAdd));
      this.label1 = new System.Windows.Forms.Label();
      this.txtObs = new System.Windows.Forms.TextBox();
      this.cmdAnObs = new System.Windows.Forms.Button();
      this.cmdValObs = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Name = "label1";
      // 
      // txtObs
      // 
      resources.ApplyResources(this.txtObs, "txtObs");
      this.txtObs.Name = "txtObs";
      // 
      // cmdAnObs
      // 
      resources.ApplyResources(this.cmdAnObs, "cmdAnObs");
      this.cmdAnObs.Name = "cmdAnObs";
      this.cmdAnObs.UseVisualStyleBackColor = true;
      this.cmdAnObs.Click += new System.EventHandler(this.cmdAnObs_Click);
      // 
      // cmdValObs
      // 
      resources.ApplyResources(this.cmdValObs, "cmdValObs");
      this.cmdValObs.Name = "cmdValObs";
      this.cmdValObs.UseVisualStyleBackColor = true;
      this.cmdValObs.Click += new System.EventHandler(this.cmdValObs_Click);
      // 
      // frmObservationsAdd
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cmdValObs);
      this.Controls.Add(this.cmdAnObs);
      this.Controls.Add(this.txtObs);
      this.Controls.Add(this.label1);
      this.Name = "frmObservationsAdd";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Load += new System.EventHandler(this.frmObservationsAdd_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtObs;
    private System.Windows.Forms.Button cmdAnObs;
    private System.Windows.Forms.Button cmdValObs;
  }
}