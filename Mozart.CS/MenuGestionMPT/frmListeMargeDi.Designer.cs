namespace MozartCS
{
  partial class frmListeMargeDi
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeMargeDi));
      this.cmdMAJ = new MozartUC.apiButton();
      this.apiToolTipInfos = new MozartUC.apiTooltip();
      this.apiToolTip1 = new MozartUC.apiTooltip();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.lblInfos = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdMAJ
      // 
      resources.ApplyResources(this.cmdMAJ, "cmdMAJ");
      this.cmdMAJ.HelpContextID = 0;
      this.cmdMAJ.Name = "cmdMAJ";
      this.cmdMAJ.Tag = "19";
      this.cmdMAJ.UseVisualStyleBackColor = true;
      this.cmdMAJ.Click += new System.EventHandler(this.cmdMAJ_Click);
      // 
      // apiToolTipInfos
      // 
      this.apiToolTipInfos.BackColor = System.Drawing.Color.SteelBlue;
      this.apiToolTipInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.apiToolTipInfos, "apiToolTipInfos");
      this.apiToolTipInfos.hwnd = ((long)(0));
      this.apiToolTipInfos.Name = "apiToolTipInfos";
      this.apiToolTipInfos.NbLignes = 0;
      this.apiToolTipInfos.Texte = null;
      this.apiToolTipInfos.TexteBox = null;
      this.apiToolTipInfos.Titre = null;
      // 
      // apiToolTip1
      // 
      this.apiToolTip1.BackColor = System.Drawing.Color.SteelBlue;
      this.apiToolTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.apiToolTip1, "apiToolTip1");
      this.apiToolTip1.hwnd = ((long)(0));
      this.apiToolTip1.Name = "apiToolTip1";
      this.apiToolTip1.NbLignes = 0;
      this.apiToolTip1.Texte = null;
      this.apiToolTip1.TexteBox = null;
      this.apiToolTip1.Titre = null;
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apigrid_DoubleClickE);
      this.apigrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apigrid_SelectionChanged);
      // 
      // lblInfos
      // 
      this.lblInfos.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblInfos.HelpContextID = 0;
      resources.ApplyResources(this.lblInfos, "lblInfos");
      this.lblInfos.Name = "lblInfos";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeMargeDi
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdMAJ);
      this.Controls.Add(this.apiToolTipInfos);
      this.Controls.Add(this.apiToolTip1);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.lblInfos);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeMargeDi";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeMargeDi_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdMAJ;
    private MozartUC.apiTooltip apiToolTipInfos;
    private MozartUC.apiTooltip apiToolTip1;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel lblInfos;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
