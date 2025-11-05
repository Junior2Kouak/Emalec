namespace MozartCS
{
  partial class frmModelTextTypeListe
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModelTextTypeListe));
      this.txtFilter0 = new MozartUC.apiTextBox();
      this.txtFilter1 = new MozartUC.apiTextBox();
      this.txtFilter2 = new MozartUC.apiTextBox();
      this.label2 = new MozartUC.apiLabel();
      this.lblDateAu = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtFilter0
      // 
      resources.ApplyResources(this.txtFilter0, "txtFilter0");
      this.txtFilter0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFilter0.HelpContextID = 0;
      this.txtFilter0.Name = "txtFilter0";
      this.txtFilter0.TextChanged += new System.EventHandler(this.txtFilter_Change);
      // 
      // txtFilter1
      // 
      resources.ApplyResources(this.txtFilter1, "txtFilter1");
      this.txtFilter1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFilter1.HelpContextID = 0;
      this.txtFilter1.Name = "txtFilter1";
      this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter_Change);
      // 
      // txtFilter2
      // 
      resources.ApplyResources(this.txtFilter2, "txtFilter2");
      this.txtFilter2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFilter2.HelpContextID = 0;
      this.txtFilter2.Name = "txtFilter2";
      this.txtFilter2.TextChanged += new System.EventHandler(this.txtFilter_Change);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.HelpContextID = 0;
      this.label2.Name = "label2";
      // 
      // lblDateAu
      // 
      resources.ApplyResources(this.lblDateAu, "lblDateAu");
      this.lblDateAu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDateAu.HelpContextID = 0;
      this.lblDateAu.Name = "lblDateAu";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtFilter0);
      this.fraCriteres.Controls.Add(this.txtFilter1);
      this.fraCriteres.Controls.Add(this.txtFilter2);
      this.fraCriteres.Controls.Add(this.label2);
      this.fraCriteres.Controls.Add(this.lblDateAu);
      this.fraCriteres.Controls.Add(this.lblPeriode);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
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
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.TabStop = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmModelTextTypeListe
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmModelTextTypeListe";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmModelTextTypeListe_Load);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtFilter0;
    private MozartUC.apiTextBox txtFilter1;
    private MozartUC.apiTextBox txtFilter2;
    private MozartUC.apiLabel label2;
    private MozartUC.apiLabel lblDateAu;
    private MozartUC.apiLabel lblPeriode;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGrid1;
  }
}
