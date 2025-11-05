namespace MozartCS
{
  partial class frmChoixLanguesTraduction
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixLanguesTraduction));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lstLgFrom = new System.Windows.Forms.ListBox();
      this.lstLgTo = new System.Windows.Forms.ListBox();
      this.cmdValider = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
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
      // lstLgFrom
      // 
      resources.ApplyResources(this.lstLgFrom, "lstLgFrom");
      this.lstLgFrom.FormattingEnabled = true;
      this.lstLgFrom.Items.AddRange(new object[] {
            resources.GetString("lstLgFrom.Items"),
            resources.GetString("lstLgFrom.Items1"),
            resources.GetString("lstLgFrom.Items2"),
            resources.GetString("lstLgFrom.Items3"),
            resources.GetString("lstLgFrom.Items4"),
            resources.GetString("lstLgFrom.Items5")});
      this.lstLgFrom.Name = "lstLgFrom";
      // 
      // lstLgTo
      // 
      resources.ApplyResources(this.lstLgTo, "lstLgTo");
      this.lstLgTo.FormattingEnabled = true;
      this.lstLgTo.Items.AddRange(new object[] {
            resources.GetString("lstLgTo.Items"),
            resources.GetString("lstLgTo.Items1"),
            resources.GetString("lstLgTo.Items2"),
            resources.GetString("lstLgTo.Items3"),
            resources.GetString("lstLgTo.Items4"),
            resources.GetString("lstLgTo.Items5")});
      this.lstLgTo.Name = "lstLgTo";
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
      // frmChoixLanguesTraduction
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.lstLgTo);
      this.Controls.Add(this.lstLgFrom);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmChoixLanguesTraduction";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixLanguesTraduction_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox lstLgFrom;
    private System.Windows.Forms.ListBox lstLgTo;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.Button cmdFermer;
  }
}