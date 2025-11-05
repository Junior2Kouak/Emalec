namespace MozartCS
{
  partial class frmSaisieAlertRavel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieAlertRavel));
      this.chkAcompte = new MozartUC.apiCheckBox();
      this.txtDetail = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // chkAcompte
      // 
      this.chkAcompte.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkAcompte, "chkAcompte");
      this.chkAcompte.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkAcompte.HelpContextID = 0;
      this.chkAcompte.Name = "chkAcompte";
      this.chkAcompte.UseVisualStyleBackColor = false;
      // 
      // txtDetail
      // 
      this.txtDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDetail, "txtDetail");
      this.txtDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDetail.HelpContextID = 0;
      this.txtDetail.Name = "txtDetail";
      this.txtDetail.ReadOnly = true;
      this.txtDetail.Enter += new System.EventHandler(this.txtDetail_Enter);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmSaisieAlertRavel
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.chkAcompte);
      this.Controls.Add(this.txtDetail);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmSaisieAlertRavel";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieAlertRavel_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCheckBox chkAcompte;
    private MozartUC.apiTextBox txtDetail;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;

  }
}
