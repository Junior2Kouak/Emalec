namespace MozartCS
{
  partial class frmSaisieLettreModeles
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieLettreModeles));
      this.cmdValider = new MozartUC.apiButton();
      this.optModeles3 = new System.Windows.Forms.RadioButton();
      this.optModeles2 = new System.Windows.Forms.RadioButton();
      this.optModeles1 = new System.Windows.Forms.RadioButton();
      this.optModeles0 = new System.Windows.Forms.RadioButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // optModeles3
      // 
      this.optModeles3.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optModeles3, "optModeles3");
      this.optModeles3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.optModeles3.Name = "optModeles3";
      this.optModeles3.UseVisualStyleBackColor = false;
      this.optModeles3.Click += new System.EventHandler(this.optModeles_Click);
      // 
      // optModeles2
      // 
      this.optModeles2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optModeles2, "optModeles2");
      this.optModeles2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.optModeles2.Name = "optModeles2";
      this.optModeles2.UseVisualStyleBackColor = false;
      this.optModeles2.Click += new System.EventHandler(this.optModeles_Click);
      // 
      // optModeles1
      // 
      this.optModeles1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optModeles1, "optModeles1");
      this.optModeles1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.optModeles1.Name = "optModeles1";
      this.optModeles1.UseVisualStyleBackColor = false;
      this.optModeles1.Click += new System.EventHandler(this.optModeles_Click);
      // 
      // optModeles0
      // 
      this.optModeles0.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.optModeles0, "optModeles0");
      this.optModeles0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.optModeles0.Name = "optModeles0";
      this.optModeles0.UseVisualStyleBackColor = false;
      this.optModeles0.Click += new System.EventHandler(this.optModeles_Click);
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.cmdValider);
      this.Frame1.Controls.Add(this.optModeles3);
      this.Frame1.Controls.Add(this.optModeles2);
      this.Frame1.Controls.Add(this.optModeles1);
      this.Frame1.Controls.Add(this.optModeles0);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // frmSaisieLettreModeles
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MinimizeBox = false;
      this.Name = "frmSaisieLettreModeles";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmSaisieLettreModeles_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.RadioButton optModeles3;
    private System.Windows.Forms.RadioButton optModeles2;
    private System.Windows.Forms.RadioButton optModeles1;
    private System.Windows.Forms.RadioButton optModeles0;
    private MozartUC.apiGroupBox Frame1;

  }
}
