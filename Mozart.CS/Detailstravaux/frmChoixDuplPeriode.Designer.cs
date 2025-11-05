namespace MozartCS
{
  partial class frmChoixDuplPeriode
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixDuplPeriode));
      this.cmdMens = new MozartUC.apiButton();
      this.cmdQuot = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdMens
      // 
      resources.ApplyResources(this.cmdMens, "cmdMens");
      this.cmdMens.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdMens.HelpContextID = 0;
      this.cmdMens.Name = "cmdMens";
      this.cmdMens.UseVisualStyleBackColor = true;
      this.cmdMens.Click += new System.EventHandler(this.cmdMens_Click);
      // 
      // cmdQuot
      // 
      resources.ApplyResources(this.cmdQuot, "cmdQuot");
      this.cmdQuot.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuot.HelpContextID = 0;
      this.cmdQuot.Name = "cmdQuot";
      this.cmdQuot.UseVisualStyleBackColor = true;
      this.cmdQuot.Click += new System.EventHandler(this.cmdQuot_Click);
      // 
      // frmChoixDuplPeriode
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdMens);
      this.Controls.Add(this.cmdQuot);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmChoixDuplPeriode";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmChoixDuplPeriode_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdMens;
    private MozartUC.apiButton cmdQuot;
  }
}
