namespace MozartCS
{
  partial class frmListeScanFichesKMS
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeScanFichesKMS));
      this.cmdOK = new MozartUC.apiButton();
      this.cmdPrev = new MozartUC.apiButton();
      this.cmdNext = new MozartUC.apiButton();
      this.cmdDel = new MozartUC.apiButton();
      this.cmdLast = new MozartUC.apiButton();
      this.cmdFirst = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Pdf1 = new System.Windows.Forms.WebBrowser();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdOK
      // 
      resources.ApplyResources(this.cmdOK, "cmdOK");
      this.cmdOK.HelpContextID = 0;
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Tag = "66";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
      // 
      // cmdPrev
      // 
      resources.ApplyResources(this.cmdPrev, "cmdPrev");
      this.cmdPrev.HelpContextID = 0;
      this.cmdPrev.Name = "cmdPrev";
      this.cmdPrev.UseVisualStyleBackColor = true;
      this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
      // 
      // cmdNext
      // 
      resources.ApplyResources(this.cmdNext, "cmdNext");
      this.cmdNext.HelpContextID = 0;
      this.cmdNext.Name = "cmdNext";
      this.cmdNext.UseVisualStyleBackColor = true;
      this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
      // 
      // cmdDel
      // 
      resources.ApplyResources(this.cmdDel, "cmdDel");
      this.cmdDel.HelpContextID = 0;
      this.cmdDel.Name = "cmdDel";
      this.cmdDel.Tag = "65";
      this.cmdDel.UseVisualStyleBackColor = true;
      this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
      // 
      // cmdLast
      // 
      resources.ApplyResources(this.cmdLast, "cmdLast");
      this.cmdLast.HelpContextID = 0;
      this.cmdLast.Name = "cmdLast";
      this.cmdLast.UseVisualStyleBackColor = true;
      this.cmdLast.Click += new System.EventHandler(this.cmdLast_Click);
      // 
      // cmdFirst
      // 
      resources.ApplyResources(this.cmdFirst, "cmdFirst");
      this.cmdFirst.HelpContextID = 0;
      this.cmdFirst.Name = "cmdFirst";
      this.cmdFirst.UseVisualStyleBackColor = true;
      this.cmdFirst.Click += new System.EventHandler(this.cmdFirst_Click);
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(128)))));
      this.Frame1.Controls.Add(this.cmdOK);
      this.Frame1.Controls.Add(this.cmdPrev);
      this.Frame1.Controls.Add(this.cmdNext);
      this.Frame1.Controls.Add(this.cmdDel);
      this.Frame1.Controls.Add(this.cmdLast);
      this.Frame1.Controls.Add(this.cmdFirst);
      this.Frame1.HelpContextID = 0;
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // Pdf1
      // 
      resources.ApplyResources(this.Pdf1, "Pdf1");
      this.Pdf1.Name = "Pdf1";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeScanFichesKMS
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Pdf1);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeScanFichesKMS";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeScanFichesKMS_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdOK;
    private MozartUC.apiButton cmdPrev;
    private MozartUC.apiButton cmdNext;
    private MozartUC.apiButton cmdDel;
    private MozartUC.apiButton cmdLast;
    private MozartUC.apiButton cmdFirst;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.WebBrowser Pdf1;
    public MozartUC.apiLabel Label2;
    public MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
