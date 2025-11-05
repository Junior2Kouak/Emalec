namespace MozartCS
{
  partial class frmChoixCadre
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixCadre));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apicboChaff = new MozartUC.apiCombo();
      this.Label1 = new System.Windows.Forms.Label();
      this.lblLabels11 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // apicboChaff
      // 
      resources.ApplyResources(this.apicboChaff, "apicboChaff");
      this.apicboChaff.Name = "apicboChaff";
      this.apicboChaff.NewValues = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Label1.Name = "Label1";
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.lblLabels11.Name = "lblLabels11";
      // 
      // frmChoixCadre
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.apicboChaff);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblLabels11);
      this.Name = "frmChoixCadre";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixCadre_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiCombo apicboChaff;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label lblLabels11;

  }
}
