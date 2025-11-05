
namespace MozartCS
{
  partial class frmMenuReportingGestTrav
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReportingGestTrav));
      this.cmdDev = new MozartUC.apiButton();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.BtnFermer = new System.Windows.Forms.Button();
      this.LblTitre = new System.Windows.Forms.Label();
      this.BtnChargeDevPrev = new System.Windows.Forms.Button();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDev
      // 
      this.cmdDev.BackColor = System.Drawing.Color.LightGreen;
      resources.ApplyResources(this.cmdDev, "cmdDev");
      this.cmdDev.HelpContextID = 473;
      this.cmdDev.Name = "cmdDev";
      this.cmdDev.UseVisualStyleBackColor = false;
      this.cmdDev.Click += new System.EventHandler(this.cmdDev_Click);
      // 
      // GroupBox1
      // 
      resources.ApplyResources(this.GroupBox1, "GroupBox1");
      this.GroupBox1.Controls.Add(this.BtnFermer);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.TabStop = false;
      // 
      // BtnFermer
      // 
      resources.ApplyResources(this.BtnFermer, "BtnFermer");
      this.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.Name = "LblTitre";
      // 
      // BtnChargeDevPrev
      // 
      this.BtnChargeDevPrev.BackColor = System.Drawing.Color.LightGreen;
      resources.ApplyResources(this.BtnChargeDevPrev, "BtnChargeDevPrev");
      this.BtnChargeDevPrev.Name = "BtnChargeDevPrev";
      this.BtnChargeDevPrev.Tag = "432";
      this.BtnChargeDevPrev.UseVisualStyleBackColor = false;
      this.BtnChargeDevPrev.Click += new System.EventHandler(this.BtnChargeDevPrev_Click);
      // 
      // frmMenuReportingGestTrav
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.BtnFermer;
      this.Controls.Add(this.cmdDev);
      this.Controls.Add(this.GroupBox1);
      this.Controls.Add(this.LblTitre);
      this.Controls.Add(this.BtnChargeDevPrev);
      this.Name = "frmMenuReportingGestTrav";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMenuReportingGestTrav_Load);
      this.GroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdDev;
    internal System.Windows.Forms.GroupBox GroupBox1;
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Label LblTitre;
    internal System.Windows.Forms.Button BtnChargeDevPrev;
  }
}