namespace MozartCS
{
  partial class frmAbout
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
      this.lblVersion = new System.Windows.Forms.Label();
      this.cmdSuppr = new MozartUC.apiButton();
      this.cmdOK = new MozartUC.apiButton();
      this.lblDisclaimer = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.lblTest = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblVersion
      // 
      resources.ApplyResources(this.lblVersion, "lblVersion");
      this.lblVersion.Name = "lblVersion";
      // 
      // cmdSuppr
      // 
      this.cmdSuppr.HelpContextID = 0;
      resources.ApplyResources(this.cmdSuppr, "cmdSuppr");
      this.cmdSuppr.Name = "cmdSuppr";
      this.cmdSuppr.UseVisualStyleBackColor = true;
      // 
      // cmdOK
      // 
      this.cmdOK.HelpContextID = 0;
      this.cmdOK.Image = global::MozartCS.Properties.Resources.ok_32;
      resources.ApplyResources(this.cmdOK, "cmdOK");
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
      // 
      // lblDisclaimer
      // 
      resources.ApplyResources(this.lblDisclaimer, "lblDisclaimer");
      this.lblDisclaimer.Name = "lblDisclaimer";
      // 
      // lblTitle
      // 
      resources.ApplyResources(this.lblTitle, "lblTitle");
      this.lblTitle.ForeColor = System.Drawing.Color.Blue;
      this.lblTitle.Name = "lblTitle";
      // 
      // lblDescription
      // 
      resources.ApplyResources(this.lblDescription, "lblDescription");
      this.lblDescription.Name = "lblDescription";
      // 
      // lblTest
      // 
      resources.ApplyResources(this.lblTest, "lblTest");
      this.lblTest.ForeColor = System.Drawing.Color.Red;
      this.lblTest.Name = "lblTest";
      // 
      // frmAbout
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.lblTest);
      this.Controls.Add(this.lblDescription);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lblDisclaimer);
      this.Controls.Add(this.cmdOK);
      this.Controls.Add(this.cmdSuppr);
      this.Controls.Add(this.lblVersion);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.FrmAbout_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblVersion;
    private MozartUC.apiButton cmdSuppr;
    private MozartUC.apiButton cmdOK;
    private System.Windows.Forms.Label lblDisclaimer;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblTest;
  }
}