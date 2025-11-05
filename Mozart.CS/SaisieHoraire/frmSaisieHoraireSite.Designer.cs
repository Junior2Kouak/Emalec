namespace MozartCS
{
  partial class frmSaisieHoraireSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieHoraireSite));
      this.chkCheckTout = new MozartUC.apiCheckBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.lstSite = new System.Windows.Forms.CheckedListBox();
      this.lblClient = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // chkCheckTout
      // 
      resources.ApplyResources(this.chkCheckTout, "chkCheckTout");
      this.chkCheckTout.BackColor = System.Drawing.Color.Wheat;
      this.chkCheckTout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.chkCheckTout.HelpContextID = 0;
      this.chkCheckTout.Name = "chkCheckTout";
      this.chkCheckTout.UseVisualStyleBackColor = false;
      this.chkCheckTout.CheckedChanged += new System.EventHandler(this.chkCheckTout_CheckedChanged);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.BackgroundImage = global::MozartCS.Properties.Resources.ok_32;
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.BackgroundImage = global::MozartCS.Properties.Resources.delete_32;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "65";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // lstSite
      // 
      resources.ApplyResources(this.lstSite, "lstSite");
      this.lstSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lstSite.CheckOnClick = true;
      this.lstSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lstSite.Name = "lstSite";
      // 
      // lblClient
      // 
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.BackColor = System.Drawing.Color.Wheat;
      this.lblClient.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblClient.HelpContextID = 0;
      this.lblClient.Name = "lblClient";
      // 
      // frmSaisieHoraireSite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.chkCheckTout);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.lstSite);
      this.Controls.Add(this.lblClient);
      this.Name = "frmSaisieHoraireSite";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieHoraireSite_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCheckBox chkCheckTout;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.CheckedListBox lstSite;
    private MozartUC.apiLabel lblClient;

  }
}
