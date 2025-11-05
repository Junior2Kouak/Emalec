namespace MozartCS
{
  partial class frmChoixImage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixImage));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdChgDir = new MozartUC.apiButton();
      this.cmdFirst = new MozartUC.apiButton();
      this.cmdDernier = new MozartUC.apiButton();
      this.cmdDel = new MozartUC.apiButton();
      this.cmdNext = new MozartUC.apiButton();
      this.cmdPrev = new MozartUC.apiButton();
      this.cmdOK = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Pdf1 = new System.Windows.Forms.WebBrowser();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdChgDir
      // 
      resources.ApplyResources(this.cmdChgDir, "cmdChgDir");
      this.cmdChgDir.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdChgDir.HelpContextID = 0;
      this.cmdChgDir.Name = "cmdChgDir";
      this.cmdChgDir.Tag = "20";
      this.cmdChgDir.UseVisualStyleBackColor = true;
      this.cmdChgDir.Click += new System.EventHandler(this.CmdChgDir_Click);
      // 
      // cmdFirst
      // 
      resources.ApplyResources(this.cmdFirst, "cmdFirst");
      this.cmdFirst.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFirst.HelpContextID = 0;
      this.cmdFirst.Name = "cmdFirst";
      this.cmdFirst.UseVisualStyleBackColor = true;
      this.cmdFirst.Click += new System.EventHandler(this.cmdFirst_Click);
      // 
      // cmdDernier
      // 
      resources.ApplyResources(this.cmdDernier, "cmdDernier");
      this.cmdDernier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDernier.HelpContextID = 0;
      this.cmdDernier.Name = "cmdDernier";
      this.cmdDernier.UseVisualStyleBackColor = true;
      this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
      // 
      // cmdDel
      // 
      resources.ApplyResources(this.cmdDel, "cmdDel");
      this.cmdDel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDel.HelpContextID = 0;
      this.cmdDel.Name = "cmdDel";
      this.cmdDel.Tag = "65";
      this.cmdDel.UseVisualStyleBackColor = true;
      this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
      // 
      // cmdNext
      // 
      resources.ApplyResources(this.cmdNext, "cmdNext");
      this.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNext.HelpContextID = 0;
      this.cmdNext.Name = "cmdNext";
      this.cmdNext.UseVisualStyleBackColor = true;
      this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
      // 
      // cmdPrev
      // 
      resources.ApplyResources(this.cmdPrev, "cmdPrev");
      this.cmdPrev.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrev.HelpContextID = 0;
      this.cmdPrev.Name = "cmdPrev";
      this.cmdPrev.UseVisualStyleBackColor = true;
      this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
      // 
      // cmdOK
      // 
      resources.ApplyResources(this.cmdOK, "cmdOK");
      this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOK.HelpContextID = 0;
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Tag = "66";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.cmdChgDir);
      this.Frame1.Controls.Add(this.cmdFirst);
      this.Frame1.Controls.Add(this.cmdDernier);
      this.Frame1.Controls.Add(this.cmdDel);
      this.Frame1.Controls.Add(this.cmdNext);
      this.Frame1.Controls.Add(this.cmdPrev);
      this.Frame1.Controls.Add(this.cmdOK);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Pdf1
      // 
      resources.ApplyResources(this.Pdf1, "Pdf1");
      this.Pdf1.CausesValidation = false;
      this.Pdf1.Name = "Pdf1";
      // 
      // frmChoixImage
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Pdf1);
      this.Name = "frmChoixImage";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmChoixImage_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdChgDir;
    private MozartUC.apiButton cmdFirst;
    private MozartUC.apiButton cmdDernier;
    private MozartUC.apiButton cmdDel;
    private MozartUC.apiButton cmdNext;
    private MozartUC.apiButton cmdPrev;
    private MozartUC.apiButton cmdOK;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.WebBrowser Pdf1;

  }
}
