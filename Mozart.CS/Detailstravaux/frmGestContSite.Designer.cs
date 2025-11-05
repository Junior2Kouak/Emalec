namespace MozartCS
{
  partial class frmGestContSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestContSite));
      this.txtduree = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblLabels20 = new System.Windows.Forms.Label();
      this.lblTitre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtduree
      // 
      this.txtduree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtduree, "txtduree");
      this.txtduree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtduree.HelpContextID = 0;
      this.txtduree.Name = "txtduree";
      this.txtduree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtduree_KeyPress);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblLabels20
      // 
      resources.ApplyResources(this.lblLabels20, "lblLabels20");
      this.lblLabels20.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels20.Name = "lblLabels20";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmGestContSite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.txtduree);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblLabels20);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestContSite";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmGestContSite_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtduree;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblLabels20;
    private System.Windows.Forms.Label lblTitre;

  }
}
