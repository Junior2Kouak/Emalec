namespace MozartCS
{
  partial class frmListeActRetQualite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeActRetQualite));
      this.CmdEnCours = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
      this.cmdEnquete = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // CmdEnCours
      // 
      resources.ApplyResources(this.CmdEnCours, "CmdEnCours");
      this.CmdEnCours.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdEnCours.HelpContextID = 18;
      this.CmdEnCours.Name = "CmdEnCours";
      this.CmdEnCours.UseVisualStyleBackColor = true;
      this.CmdEnCours.Click += new System.EventHandler(this.CmdEnCours_Click);
      // 
      // cmdArchive
      // 
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchive.HelpContextID = 18;
      this.cmdArchive.Name = "cmdArchive";
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
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apigrid_DblClickE);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // cmdEnquete
      // 
      resources.ApplyResources(this.cmdEnquete, "cmdEnquete");
      this.cmdEnquete.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnquete.HelpContextID = 0;
      this.cmdEnquete.Name = "cmdEnquete";
      this.cmdEnquete.Tag = "19";
      this.cmdEnquete.UseVisualStyleBackColor = true;
      this.cmdEnquete.Click += new System.EventHandler(this.cmdEnquete_Click);
      // 
      // frmListeActRetQualite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEnquete);
      this.Controls.Add(this.CmdEnCours);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeActRetQualite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeActRetQualite_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton CmdEnCours;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apigrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private DevExpress.Utils.ToolTipController toolTipController1;
    private MozartUC.apiButton cmdEnquete;
  }
}
