namespace MozartCS
{
  partial class frmCommandeInterim
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommandeInterim));
      this.lblLabelInterim = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtNB = new System.Windows.Forms.TextBox();
      this.txtDate = new System.Windows.Forms.TextBox();
      this.txtHeure = new System.Windows.Forms.TextBox();
      this.txtDuree = new System.Windows.Forms.TextBox();
      this.txtTaches = new System.Windows.Forms.TextBox();
      this.txtCompetences = new System.Windows.Forms.TextBox();
      this.cmdValider = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblLabelInterim
      // 
      resources.ApplyResources(this.lblLabelInterim, "lblLabelInterim");
      this.lblLabelInterim.Name = "lblLabelInterim";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // label6
      // 
      resources.ApplyResources(this.label6, "label6");
      this.label6.Name = "label6";
      // 
      // label7
      // 
      resources.ApplyResources(this.label7, "label7");
      this.label7.Name = "label7";
      // 
      // txtNB
      // 
      resources.ApplyResources(this.txtNB, "txtNB");
      this.txtNB.Name = "txtNB";
      // 
      // txtDate
      // 
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.Name = "txtDate";
      // 
      // txtHeure
      // 
      resources.ApplyResources(this.txtHeure, "txtHeure");
      this.txtHeure.Name = "txtHeure";
      // 
      // txtDuree
      // 
      resources.ApplyResources(this.txtDuree, "txtDuree");
      this.txtDuree.Name = "txtDuree";
      // 
      // txtTaches
      // 
      resources.ApplyResources(this.txtTaches, "txtTaches");
      this.txtTaches.Name = "txtTaches";
      // 
      // txtCompetences
      // 
      resources.ApplyResources(this.txtCompetences, "txtCompetences");
      this.txtCompetences.Name = "txtCompetences";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // frmCommandeInterim
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.txtCompetences);
      this.Controls.Add(this.txtTaches);
      this.Controls.Add(this.txtDuree);
      this.Controls.Add(this.txtHeure);
      this.Controls.Add(this.txtDate);
      this.Controls.Add(this.txtNB);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblLabelInterim);
      this.Name = "frmCommandeInterim";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmCommandeInterim_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLabelInterim;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtNB;
    private System.Windows.Forms.TextBox txtDate;
    private System.Windows.Forms.TextBox txtHeure;
    private System.Windows.Forms.TextBox txtDuree;
    private System.Windows.Forms.TextBox txtTaches;
    private System.Windows.Forms.TextBox txtCompetences;
    private System.Windows.Forms.Button cmdValider;
  }
}