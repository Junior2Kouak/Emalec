namespace MozartCS
{
  partial class frmAdminDI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDI));
      this.cmdSS = new MozartUC.apiButton();
      this.cmdDeblock = new MozartUC.apiButton();
      this.cmdDeci = new MozartUC.apiButton();
      this.cmdDIFromweb = new MozartUC.apiButton();
      this.cmdDIweb = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdDI = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdSS
      // 
      this.cmdSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSS, "cmdSS");
      this.cmdSS.HelpContextID = 651;
      this.cmdSS.Name = "cmdSS";
      this.cmdSS.Tag = "52";
      this.cmdSS.UseVisualStyleBackColor = false;
      this.cmdSS.Click += new System.EventHandler(this.cmdSS_Click);
      // 
      // cmdDeblock
      // 
      this.cmdDeblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDeblock, "cmdDeblock");
      this.cmdDeblock.HelpContextID = 143;
      this.cmdDeblock.Name = "cmdDeblock";
      this.cmdDeblock.Tag = "52";
      this.cmdDeblock.UseVisualStyleBackColor = false;
      this.cmdDeblock.Click += new System.EventHandler(this.cmdDeblock_Click);
      // 
      // cmdDeci
      // 
      this.cmdDeci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDeci, "cmdDeci");
      this.cmdDeci.HelpContextID = 0;
      this.cmdDeci.Name = "cmdDeci";
      this.cmdDeci.Tag = "12";
      this.cmdDeci.UseVisualStyleBackColor = false;
      this.cmdDeci.Click += new System.EventHandler(this.cmdDeci_Click);
      // 
      // cmdDIFromweb
      // 
      this.cmdDIFromweb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDIFromweb, "cmdDIFromweb");
      this.cmdDIFromweb.HelpContextID = 36;
      this.cmdDIFromweb.Name = "cmdDIFromweb";
      this.cmdDIFromweb.Tag = "16";
      this.cmdDIFromweb.UseVisualStyleBackColor = false;
      this.cmdDIFromweb.Click += new System.EventHandler(this.cmdDIFromweb_Click);
      // 
      // cmdDIweb
      // 
      this.cmdDIweb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDIweb, "cmdDIweb");
      this.cmdDIweb.HelpContextID = 39;
      this.cmdDIweb.Name = "cmdDIweb";
      this.cmdDIweb.Tag = "26";
      this.cmdDIweb.UseVisualStyleBackColor = false;
      this.cmdDIweb.Click += new System.EventHandler(this.cmdDIweb_Click);
      // 
      // cmdArchive
      // 
      this.cmdArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.HelpContextID = 110;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "28";
      this.cmdArchive.UseVisualStyleBackColor = false;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdDI
      // 
      this.cmdDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.HelpContextID = 109;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "27";
      this.cmdDI.UseVisualStyleBackColor = false;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
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
      // frmAdminDI
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSS);
      this.Controls.Add(this.cmdDeblock);
      this.Controls.Add(this.cmdDeci);
      this.Controls.Add(this.cmdDIFromweb);
      this.Controls.Add(this.cmdDIweb);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminDI";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminDI_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSS;
    private MozartUC.apiButton cmdDeblock;
    private MozartUC.apiButton cmdDeci;
    private MozartUC.apiButton cmdDIFromweb;
    private MozartUC.apiButton cmdDIweb;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdDI;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
