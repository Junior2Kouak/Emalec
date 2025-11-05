namespace MozartCS
{
  partial class frmListeDiRelance
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDiRelance));
      this.Label3 = new MozartUC.apiLabel();
      this.lblNbRelance = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.ChkTous = new MozartUC.apiCheckBox();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // lblNbRelance
      // 
      resources.ApplyResources(this.lblNbRelance, "lblNbRelance");
      this.lblNbRelance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblNbRelance.HelpContextID = 0;
      this.lblNbRelance.Name = "lblNbRelance";
      // 
      // Frame1
      // 
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.lblNbRelance);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      this.Frame1.DoubleClick += new System.EventHandler(this.Frame1_DoubleClick);
      this.Frame1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frame1_MouseDown);
      // 
      // ChkTous
      // 
      this.ChkTous.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.ChkTous, "ChkTous");
      this.ChkTous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.ChkTous.HelpContextID = 0;
      this.ChkTous.Name = "ChkTous";
      this.ChkTous.UseVisualStyleBackColor = false;
      this.ChkTous.Click += new System.EventHandler(this.ChkTous_Click);
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
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.cmdModifier_Click);
      this.apigrid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.Apigrid_Rowstyle);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeDiRelance
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.ChkTous);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeDiRelance";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmListeDiRelance_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel lblNbRelance;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiCheckBox ChkTous;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
