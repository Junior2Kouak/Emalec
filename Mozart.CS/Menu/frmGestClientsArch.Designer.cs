namespace MozartCS
{
  partial class frmGestClientsArch
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestClientsArch));
      this.cmdPVFO = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdInfo = new MozartUC.apiButton();
      this.cmdComptecli = new MozartUC.apiButton();
      this.cmdCoef = new MozartUC.apiButton();
      this.cmdContacts = new MozartUC.apiButton();
      this.cmdsite = new MozartUC.apiButton();
      this.cmdRSF = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // cmdPVFO
      // 
      resources.ApplyResources(this.cmdPVFO, "cmdPVFO");
      this.cmdPVFO.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPVFO.HelpContextID = 148;
      this.cmdPVFO.Name = "cmdPVFO";
      this.toolTip1.SetToolTip(this.cmdPVFO, resources.GetString("cmdPVFO.ToolTip"));
      this.cmdPVFO.UseVisualStyleBackColor = true;
      this.cmdPVFO.Click += new System.EventHandler(this.cmdPVFO_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.toolTip1.SetToolTip(this.cmdModifier, resources.GetString("cmdModifier.ToolTip"));
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 125;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.toolTip1.SetToolTip(this.cmdSupprimer, resources.GetString("cmdSupprimer.ToolTip"));
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdInfo
      // 
      resources.ApplyResources(this.cmdInfo, "cmdInfo");
      this.cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdInfo.HelpContextID = 77;
      this.cmdInfo.Name = "cmdInfo";
      this.cmdInfo.Tag = "19";
      this.cmdInfo.UseVisualStyleBackColor = true;
      this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
      // 
      // cmdComptecli
      // 
      resources.ApplyResources(this.cmdComptecli, "cmdComptecli");
      this.cmdComptecli.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdComptecli.HelpContextID = 75;
      this.cmdComptecli.Name = "cmdComptecli";
      this.cmdComptecli.Tag = "11";
      this.cmdComptecli.UseVisualStyleBackColor = true;
      this.cmdComptecli.Click += new System.EventHandler(this.cmdComptecli_Click);
      // 
      // cmdCoef
      // 
      resources.ApplyResources(this.cmdCoef, "cmdCoef");
      this.cmdCoef.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCoef.HelpContextID = 74;
      this.cmdCoef.Name = "cmdCoef";
      this.cmdCoef.Tag = "33";
      this.cmdCoef.UseVisualStyleBackColor = true;
      this.cmdCoef.Click += new System.EventHandler(this.cmdCoef_Click);
      // 
      // cmdContacts
      // 
      resources.ApplyResources(this.cmdContacts, "cmdContacts");
      this.cmdContacts.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContacts.HelpContextID = 71;
      this.cmdContacts.Name = "cmdContacts";
      this.cmdContacts.Tag = "68";
      this.cmdContacts.UseVisualStyleBackColor = true;
      this.cmdContacts.Click += new System.EventHandler(this.cmdContacts_Click);
      // 
      // cmdsite
      // 
      resources.ApplyResources(this.cmdsite, "cmdsite");
      this.cmdsite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdsite.HelpContextID = 73;
      this.cmdsite.Name = "cmdsite";
      this.cmdsite.Tag = "26";
      this.cmdsite.UseVisualStyleBackColor = true;
      this.cmdsite.Click += new System.EventHandler(this.cmdsite_Click);
      // 
      // cmdRSF
      // 
      resources.ApplyResources(this.cmdRSF, "cmdRSF");
      this.cmdRSF.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRSF.HelpContextID = 72;
      this.cmdRSF.Name = "cmdRSF";
      this.cmdRSF.Tag = "32";
      this.cmdRSF.UseVisualStyleBackColor = true;
      this.cmdRSF.Click += new System.EventHandler(this.cmdRSF_Click);
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
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid1_RowStyle);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmGestClientsArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdPVFO);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdInfo);
      this.Controls.Add(this.cmdComptecli);
      this.Controls.Add(this.cmdCoef);
      this.Controls.Add(this.cmdContacts);
      this.Controls.Add(this.cmdsite);
      this.Controls.Add(this.cmdRSF);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestClientsArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestClientsArch_FormClosed);
      this.Load += new System.EventHandler(this.frmGestClientsArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdPVFO;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdInfo;
    private MozartUC.apiButton cmdComptecli;
    private MozartUC.apiButton cmdCoef;
    private MozartUC.apiButton cmdContacts;
    private MozartUC.apiButton cmdsite;
    private MozartUC.apiButton cmdRSF;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.ToolTip toolTip1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
