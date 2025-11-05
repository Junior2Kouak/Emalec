namespace MozartCS
{
  partial class frmZoomText
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZoomText));
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtChamps = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.txtChamps);
      this.panel1.Name = "panel1";
      // 
      // txtChamps
      // 
      resources.ApplyResources(this.txtChamps, "txtChamps");
      this.txtChamps.Name = "txtChamps";
      this.txtChamps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChamps_KeyPress);
      // 
      // frmZoomText
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmZoomText";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmZoomText_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmZoomText_KeyDown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtChamps;
  }
}