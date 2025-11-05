namespace MozartCS
{
  partial class frmRechCodePostal
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRechCodePostal));
      this.cboDept = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmdRecherche = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cmdValider = new System.Windows.Forms.Button();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.txtVille = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboDept
      // 
      resources.ApplyResources(this.cboDept, "cboDept");
      this.cboDept.FormattingEnabled = true;
      this.cboDept.Name = "cboDept";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.ForeColor = System.Drawing.Color.Green;
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.Color.Green;
      this.label2.Name = "label2";
      // 
      // cmdRecherche
      // 
      this.cmdRecherche.AllowDrop = true;
      resources.ApplyResources(this.cmdRecherche, "cmdRecherche");
      this.cmdRecherche.Name = "cmdRecherche";
      this.cmdRecherche.UseVisualStyleBackColor = true;
      this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.BackColor = System.Drawing.Color.Wheat;
      this.panel1.Controls.Add(this.cmdValider);
      this.panel1.Controls.Add(this.cmdCancel);
      this.panel1.Name = "panel1";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdCancel
      // 
      resources.ApplyResources(this.cmdCancel, "cmdCancel");
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      // 
      // txtVille
      // 
      resources.ApplyResources(this.txtVille, "txtVille");
      this.txtVille.Name = "txtVille";
      this.txtVille.TextChanged += new System.EventHandler(this.txtVille_TextChanged);
      // 
      // frmRechCodePostal
      // 
      this.AcceptButton = this.cmdRecherche;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Controls.Add(this.txtVille);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cmdRecherche);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboDept);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmRechCodePostal";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmRechCodePostal_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox cboDept;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button cmdRecherche;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.Button cmdCancel;
    private System.Windows.Forms.TextBox txtVille;
  }
}