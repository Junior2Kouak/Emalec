namespace MozartCS
{
  partial class frmCopyProfil
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopyProfil));
      this.panel1 = new System.Windows.Forms.Panel();
      this.cboTech2 = new System.Windows.Forms.ComboBox();
      this.cboTech1 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmdValider = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.cboTech2);
      this.panel1.Controls.Add(this.cboTech1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Name = "panel1";
      // 
      // cboTech2
      // 
      resources.ApplyResources(this.cboTech2, "cboTech2");
      this.cboTech2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTech2.FormattingEnabled = true;
      this.cboTech2.Name = "cboTech2";
      // 
      // cboTech1
      // 
      resources.ApplyResources(this.cboTech1, "cboTech1");
      this.cboTech1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTech1.FormattingEnabled = true;
      this.cboTech1.Name = "cboTech1";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // frmCopyProfil
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.panel1);
      this.Name = "frmCopyProfil";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmCopyProfil_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox cboTech2;
    private System.Windows.Forms.ComboBox cboTech1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Label label1;
  }
}