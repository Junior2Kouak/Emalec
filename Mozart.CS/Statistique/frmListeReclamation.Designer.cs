namespace MozartCS
{
  partial class frmListeReclamation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeReclamation));
      this.cmdTauxMag = new MozartUC.apiButton();
      this.cmdTauxACH = new MozartUC.apiButton();
      this.cmdRMPT = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdDIweb = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
      this.SuspendLayout();
      // 
      // cmdTauxMag
      // 
      resources.ApplyResources(this.cmdTauxMag, "cmdTauxMag");
      this.cmdTauxMag.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTauxMag.HelpContextID = 0;
      this.cmdTauxMag.Name = "cmdTauxMag";
      this.cmdTauxMag.Tag = "69";
      this.cmdTauxMag.UseVisualStyleBackColor = true;
      this.cmdTauxMag.Click += new System.EventHandler(this.cmdTauxMag_Click);
      // 
      // cmdTauxACH
      // 
      resources.ApplyResources(this.cmdTauxACH, "cmdTauxACH");
      this.cmdTauxACH.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTauxACH.HelpContextID = 0;
      this.cmdTauxACH.Name = "cmdTauxACH";
      this.cmdTauxACH.Tag = "69";
      this.cmdTauxACH.UseVisualStyleBackColor = true;
      this.cmdTauxACH.Click += new System.EventHandler(this.cmdTauxACH_Click);
      // 
      // cmdRMPT
      // 
      resources.ApplyResources(this.cmdRMPT, "cmdRMPT");
      this.cmdRMPT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRMPT.HelpContextID = 0;
      this.cmdRMPT.Name = "cmdRMPT";
      this.cmdRMPT.Tag = "69";
      this.cmdRMPT.UseVisualStyleBackColor = true;
      this.cmdRMPT.Click += new System.EventHandler(this.cmdRMPT_Click);
      // 
      // cmdArchive
      // 
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchive.HelpContextID = 0;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "124";
      this.cmdArchive.UseVisualStyleBackColor = true;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
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
      // cmdDIweb
      // 
      resources.ApplyResources(this.cmdDIweb, "cmdDIweb");
      this.cmdDIweb.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDIweb.HelpContextID = 0;
      this.cmdDIweb.Name = "cmdDIweb";
      this.cmdDIweb.Tag = "69";
      this.cmdDIweb.UseVisualStyleBackColor = true;
      this.cmdDIweb.Click += new System.EventHandler(this.cmdDIweb_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // frmListeReclamation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdTauxMag);
      this.Controls.Add(this.cmdTauxACH);
      this.Controls.Add(this.cmdRMPT);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdDIweb);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeReclamation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeReclamation_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdTauxMag;
    private MozartUC.apiButton cmdTauxACH;
    private MozartUC.apiButton cmdRMPT;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdDIweb;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apiTGrid1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private DevExpress.Utils.ToolTipController toolTipController1;
  }
}
