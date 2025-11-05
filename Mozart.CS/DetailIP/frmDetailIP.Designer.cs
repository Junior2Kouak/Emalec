namespace MozartCS
{
  partial class frmDetailIP
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailIP));
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.grdDataGridAction = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
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
      // grdDataGridAction
      // 
      resources.ApplyResources(this.grdDataGridAction, "grdDataGridAction");
      this.grdDataGridAction.FilterBar = true;
      this.grdDataGridAction.FooterBar = true;
      this.grdDataGridAction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdDataGridAction.Name = "grdDataGridAction";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.grdDataGridAction);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmDetailIP
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailIP";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmDetailIP_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid grdDataGridAction;
    private MozartUC.apiGroupBox Frame1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
