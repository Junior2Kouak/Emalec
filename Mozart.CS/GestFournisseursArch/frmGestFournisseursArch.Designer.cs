namespace MozartCS
{
  partial class frmGestFournisseursArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFournisseursArch));
      this.ApiGridStf = new MozartUC.apiTGrid();
      this.apiGridStfGRP = new MozartUC.apiTGrid();
      this.cmdArchSite = new MozartUC.apiButton();
      this.cmdModifierSTF = new MozartUC.apiButton();
      this.cmdModifierSiteSTF = new MozartUC.apiButton();
      this.cmdInfo = new MozartUC.apiButton();
      this.cmdFourniture = new MozartUC.apiButton();
      this.cmdContacts = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label10 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // ApiGridStf
      // 
      resources.ApplyResources(this.ApiGridStf, "ApiGridStf");
      this.ApiGridStf.FilterBar = true;
      this.ApiGridStf.FooterBar = true;
      this.ApiGridStf.Name = "ApiGridStf";
      // 
      // apiGridStfGRP
      // 
      resources.ApplyResources(this.apiGridStfGRP, "apiGridStfGRP");
      this.apiGridStfGRP.FilterBar = true;
      this.apiGridStfGRP.FooterBar = true;
      this.apiGridStfGRP.Name = "apiGridStfGRP";
      this.apiGridStfGRP.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiGridStfGRP_SelectionChanged);
      // 
      // cmdArchSite
      // 
      resources.ApplyResources(this.cmdArchSite, "cmdArchSite");
      this.cmdArchSite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchSite.HelpContextID = 0;
      this.cmdArchSite.Name = "cmdArchSite";
      this.cmdArchSite.Tag = "27";
      this.cmdArchSite.UseVisualStyleBackColor = true;
      this.cmdArchSite.Click += new System.EventHandler(this.cmdArchSite_Click);
      // 
      // cmdModifierSTF
      // 
      resources.ApplyResources(this.cmdModifierSTF, "cmdModifierSTF");
      this.cmdModifierSTF.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifierSTF.HelpContextID = 0;
      this.cmdModifierSTF.Name = "cmdModifierSTF";
      this.cmdModifierSTF.Tag = "19";
      this.cmdModifierSTF.UseVisualStyleBackColor = true;
      this.cmdModifierSTF.Click += new System.EventHandler(this.cmdModifierSTF_Click);
      // 
      // cmdModifierSiteSTF
      // 
      resources.ApplyResources(this.cmdModifierSiteSTF, "cmdModifierSiteSTF");
      this.cmdModifierSiteSTF.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifierSiteSTF.HelpContextID = 0;
      this.cmdModifierSiteSTF.Name = "cmdModifierSiteSTF";
      this.cmdModifierSiteSTF.Tag = "19";
      this.cmdModifierSiteSTF.UseVisualStyleBackColor = true;
      this.cmdModifierSiteSTF.Click += new System.EventHandler(this.cmdModifierSiteSTF_Click);
      // 
      // cmdInfo
      // 
      resources.ApplyResources(this.cmdInfo, "cmdInfo");
      this.cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdInfo.HelpContextID = 144;
      this.cmdInfo.Name = "cmdInfo";
      this.cmdInfo.Tag = "91";
      this.cmdInfo.UseVisualStyleBackColor = true;
      this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
      // 
      // cmdFourniture
      // 
      resources.ApplyResources(this.cmdFourniture, "cmdFourniture");
      this.cmdFourniture.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFourniture.HelpContextID = 0;
      this.cmdFourniture.Name = "cmdFourniture";
      this.cmdFourniture.Tag = "11";
      this.cmdFourniture.UseVisualStyleBackColor = true;
      this.cmdFourniture.Click += new System.EventHandler(this.cmdFourniture_Click);
      // 
      // cmdContacts
      // 
      resources.ApplyResources(this.cmdContacts, "cmdContacts");
      this.cmdContacts.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContacts.HelpContextID = 0;
      this.cmdContacts.Name = "cmdContacts";
      this.cmdContacts.Tag = "21";
      this.cmdContacts.UseVisualStyleBackColor = true;
      this.cmdContacts.Click += new System.EventHandler(this.cmdContacts_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.BackColor = System.Drawing.Color.Wheat;
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmGestFournisseursArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.ApiGridStf);
      this.Controls.Add(this.apiGridStfGRP);
      this.Controls.Add(this.cmdArchSite);
      this.Controls.Add(this.cmdModifierSTF);
      this.Controls.Add(this.cmdModifierSiteSTF);
      this.Controls.Add(this.cmdInfo);
      this.Controls.Add(this.cmdFourniture);
      this.Controls.Add(this.cmdContacts);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label10);
      this.Controls.Add(this.Label14);
      this.Name = "frmGestFournisseursArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestFournisseursArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid ApiGridStf;
    private MozartUC.apiTGrid apiGridStfGRP;
    private MozartUC.apiButton cmdArchSite;
    private MozartUC.apiButton cmdModifierSTF;
    private MozartUC.apiButton cmdModifierSiteSTF;
    private MozartUC.apiButton cmdInfo;
    private MozartUC.apiButton cmdFourniture;
    private MozartUC.apiButton cmdContacts;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label14;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
