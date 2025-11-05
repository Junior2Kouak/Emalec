namespace MozartCS
{
  partial class frmProcedures
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedures));
      this.CmdEdition = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnreg = new MozartUC.apiButton();
      this.txtInfo = new MozartUC.apiTextBox();
      this.lblInfo = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // CmdEdition
      // 
      resources.ApplyResources(this.CmdEdition, "CmdEdition");
      this.CmdEdition.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdEdition.HelpContextID = 201;
      this.CmdEdition.Name = "CmdEdition";
      this.CmdEdition.UseVisualStyleBackColor = true;
      this.CmdEdition.Click += new System.EventHandler(this.CmdEdition_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdEnreg
      // 
      resources.ApplyResources(this.cmdEnreg, "cmdEnreg");
      this.cmdEnreg.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnreg.HelpContextID = 201;
      this.cmdEnreg.Name = "cmdEnreg";
      this.cmdEnreg.UseVisualStyleBackColor = true;
      this.cmdEnreg.Click += new System.EventHandler(this.cmdEnreg_Click);
      // 
      // txtInfo
      // 
      resources.ApplyResources(this.txtInfo, "txtInfo");
      this.txtInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtInfo.HelpContextID = 0;
      this.txtInfo.Name = "txtInfo";
      // 
      // lblInfo
      // 
      resources.ApplyResources(this.lblInfo, "lblInfo");
      this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblInfo.HelpContextID = 0;
      this.lblInfo.Name = "lblInfo";
      // 
      // frmProcedures
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdEdition);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnreg);
      this.Controls.Add(this.txtInfo);
      this.Controls.Add(this.lblInfo);
      this.Name = "frmProcedures";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmProcedures_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdEdition;
    //private System.Windows.Forms.Timer Timer1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnreg;
    private MozartUC.apiTextBox txtInfo;
    private MozartUC.apiLabel lblInfo;

  }
}
