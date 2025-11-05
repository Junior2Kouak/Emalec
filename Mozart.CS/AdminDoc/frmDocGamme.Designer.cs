namespace MozartCS
{
  partial class frmDocGamme
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGamme));
      this.cmdCli = new MozartUC.apiButton();
      this.cmdSite = new MozartUC.apiButton();
      this.cmdTram = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdCli
      // 
      this.cmdCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdCli, "cmdCli");
      this.cmdCli.HelpContextID = 165;
      this.cmdCli.Name = "cmdCli";
      this.cmdCli.Tag = "21";
      this.cmdCli.UseVisualStyleBackColor = false;
      this.cmdCli.Click += new System.EventHandler(this.cmdCli_Click);
      // 
      // cmdSite
      // 
      this.cmdSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSite, "cmdSite");
      this.cmdSite.HelpContextID = 166;
      this.cmdSite.Name = "cmdSite";
      this.cmdSite.Tag = "49";
      this.cmdSite.UseVisualStyleBackColor = false;
      this.cmdSite.Click += new System.EventHandler(this.cmdSite_Click);
      // 
      // cmdTram
      // 
      this.cmdTram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdTram, "cmdTram");
      this.cmdTram.HelpContextID = 164;
      this.cmdTram.Name = "cmdTram";
      this.cmdTram.Tag = "18";
      this.cmdTram.UseVisualStyleBackColor = false;
      this.cmdTram.Click += new System.EventHandler(this.cmdTram_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmDocGamme
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdCli);
      this.Controls.Add(this.cmdSite);
      this.Controls.Add(this.cmdTram);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmDocGamme";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDocGamme_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCli;
    private MozartUC.apiButton cmdSite;
    private MozartUC.apiButton cmdTram;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
  }
}
