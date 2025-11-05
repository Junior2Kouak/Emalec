namespace MozartCS
{
  partial class frmStockSaisieInventaire
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockSaisieInventaire));
      this.cmdFermer = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtQteInv = new System.Windows.Forms.TextBox();
      this.txtDateInv = new System.Windows.Forms.TextBox();
      this.txtQte = new System.Windows.Forms.TextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.lblFoumat = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // txtQteInv
      // 
      resources.ApplyResources(this.txtQteInv, "txtQteInv");
      this.txtQteInv.Name = "txtQteInv";
      this.txtQteInv.ReadOnly = true;
      this.txtQteInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQteInv_KeyPress);
      // 
      // txtDateInv
      // 
      resources.ApplyResources(this.txtDateInv, "txtDateInv");
      this.txtDateInv.Name = "txtDateInv";
      this.txtDateInv.ReadOnly = true;
      // 
      // txtQte
      // 
      resources.ApplyResources(this.txtQte, "txtQte");
      this.txtQte.Name = "txtQte";
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblFoumat
      // 
      resources.ApplyResources(this.lblFoumat, "lblFoumat");
      this.lblFoumat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.lblFoumat.Name = "lblFoumat";
      // 
      // frmStockSaisieInventaire
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Controls.Add(this.lblFoumat);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.txtQte);
      this.Controls.Add(this.txtDateInv);
      this.Controls.Add(this.txtQteInv);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmdFermer);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Name = "frmStockSaisieInventaire";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmStockSasieInventaire_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtQteInv;
    private System.Windows.Forms.TextBox txtDateInv;
    private System.Windows.Forms.TextBox txtQte;
    //private System.Windows.Forms.Button cmdValider;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.Label lblFoumat;
  }
}