namespace MozartCS
{
  partial class frmMenuMagasin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuMagasin));
      this.cmdQuitter = new System.Windows.Forms.Button();
      this.Label1 = new System.Windows.Forms.Label();
      this.cmdEtalonnage = new MozartUC.apiButton();
      this.cmdTauxMag = new MozartUC.apiButton();
      this.cmdDelais2 = new MozartUC.apiButton();
      this.cmdDelais = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // cmdEtalonnage
      // 
      this.cmdEtalonnage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdEtalonnage, "cmdEtalonnage");
      this.cmdEtalonnage.HelpContextID = 0;
      this.cmdEtalonnage.Name = "cmdEtalonnage";
      this.cmdEtalonnage.UseVisualStyleBackColor = false;
      this.cmdEtalonnage.Click += new System.EventHandler(this.cmdEtalonnage_Click);
      // 
      // cmdTauxMag
      // 
      this.cmdTauxMag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdTauxMag, "cmdTauxMag");
      this.cmdTauxMag.HelpContextID = 0;
      this.cmdTauxMag.Name = "cmdTauxMag";
      this.cmdTauxMag.UseVisualStyleBackColor = false;
      this.cmdTauxMag.Click += new System.EventHandler(this.cmdTauxMag_Click);
      // 
      // cmdDelais2
      // 
      this.cmdDelais2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDelais2, "cmdDelais2");
      this.cmdDelais2.HelpContextID = 0;
      this.cmdDelais2.Name = "cmdDelais2";
      this.cmdDelais2.UseVisualStyleBackColor = false;
      this.cmdDelais2.Click += new System.EventHandler(this.cmdDelais2_Click);
      // 
      // cmdDelais
      // 
      this.cmdDelais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDelais, "cmdDelais");
      this.cmdDelais.HelpContextID = 0;
      this.cmdDelais.Name = "cmdDelais";
      this.cmdDelais.UseVisualStyleBackColor = false;
      this.cmdDelais.Click += new System.EventHandler(this.cmdDelais_Click);
      // 
      // frmMenuMagasin
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdDelais);
      this.Controls.Add(this.cmdDelais2);
      this.Controls.Add(this.cmdTauxMag);
      this.Controls.Add(this.cmdEtalonnage);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.cmdQuitter);
      this.Name = "frmMenuMagasin";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button cmdQuitter;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiButton cmdEtalonnage;
    private MozartUC.apiButton cmdTauxMag;
    private MozartUC.apiButton cmdDelais2;
    private MozartUC.apiButton cmdDelais;
  }
}