namespace MozartCS
{
  partial class frmComSecuFichier
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComSecuFichier));
      this.cmdSupprimer = new MozartUC.apiButton();
      this.apiTGridFichier = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdAjout = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 24;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // apiTGridFichier
      // 
      resources.ApplyResources(this.apiTGridFichier, "apiTGridFichier");
      this.apiTGridFichier.FilterBar = true;
      this.apiTGridFichier.FooterBar = true;
      this.apiTGridFichier.Name = "apiTGridFichier";
      this.apiTGridFichier.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGridFichier_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdAjout
      // 
      resources.ApplyResources(this.cmdAjout, "cmdAjout");
      this.cmdAjout.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjout.HelpContextID = 0;
      this.cmdAjout.Name = "cmdAjout";
      this.cmdAjout.Tag = "2";
      this.cmdAjout.UseVisualStyleBackColor = true;
      this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // frmComSecuFichier
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.apiTGridFichier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdAjout);
      this.Controls.Add(this.WebBrowser1);
      this.Name = "frmComSecuFichier";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmComSecuFichier_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiTGrid apiTGridFichier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdAjout;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
