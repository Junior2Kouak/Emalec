namespace MozartCS
{
  partial class frmGestionAbsences
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAbsences));
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame9 = new MozartUC.apiGroupBox();
      this.txtNbHeures = new DevExpress.XtraEditors.TextEdit();
      this.lblNbMoisContractuel = new MozartUC.apiLabel();
      this.cboAbs = new MozartUC.apiCombo();
      this.lblAbs = new MozartUC.apiLabel();
      this.txtDate = new DevExpress.XtraEditors.DateEdit();
      this.Label58 = new MozartUC.apiLabel();
      this.cboPersonnel = new MozartUC.apiCombo();
      this.Label548 = new MozartUC.apiLabel();
      this.CmdEnregistrer = new MozartUC.apiButton();
      this.Frame9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNbHeures.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
      this.SuspendLayout();
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Frame9
      // 
      this.Frame9.BackColor = System.Drawing.Color.Wheat;
      this.Frame9.Controls.Add(this.txtNbHeures);
      this.Frame9.Controls.Add(this.lblNbMoisContractuel);
      this.Frame9.Controls.Add(this.cboAbs);
      this.Frame9.Controls.Add(this.lblAbs);
      this.Frame9.Controls.Add(this.txtDate);
      this.Frame9.Controls.Add(this.Label58);
      this.Frame9.Controls.Add(this.cboPersonnel);
      this.Frame9.Controls.Add(this.Label548);
      this.Frame9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame9.HelpContextID = 0;
      resources.ApplyResources(this.Frame9, "Frame9");
      this.Frame9.Name = "Frame9";
      this.Frame9.TabStop = false;
      // 
      // txtNbHeures
      // 
      resources.ApplyResources(this.txtNbHeures, "txtNbHeures");
      this.txtNbHeures.Name = "txtNbHeures";
      this.txtNbHeures.Properties.Appearance.Options.UseTextOptions = true;
      this.txtNbHeures.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.txtNbHeures.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.txtNbHeures.Properties.Mask.EditMask = resources.GetString("txtNbMoisContractuel.Properties.Mask.EditMask");
      this.txtNbHeures.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtNbMoisContractuel.Properties.Mask.MaskType")));
      this.txtNbHeures.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtNbMoisContractuel.Properties.Mask.UseMaskAsDisplayFormat")));
      // 
      // lblNbMoisContractuel
      // 
      resources.ApplyResources(this.lblNbMoisContractuel, "lblNbMoisContractuel");
      this.lblNbMoisContractuel.BackColor = System.Drawing.Color.Wheat;
      this.lblNbMoisContractuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblNbMoisContractuel.HelpContextID = 0;
      this.lblNbMoisContractuel.Name = "lblNbMoisContractuel";
      // 
      // cboAbs
      // 
      resources.ApplyResources(this.cboAbs, "cboAbs");
      this.cboAbs.Name = "cboAbs";
      this.cboAbs.NewValues = false;
      // 
      // lblAbs
      // 
      resources.ApplyResources(this.lblAbs, "lblAbs");
      this.lblAbs.BackColor = System.Drawing.Color.Wheat;
      this.lblAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblAbs.HelpContextID = 0;
      this.lblAbs.Name = "lblAbs";
      // 
      // txtDate
      // 
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.Name = "txtDate";
      this.txtDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDate.Properties.Buttons"))))});
      this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDate.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // Label58
      // 
      resources.ApplyResources(this.Label58, "Label58");
      this.Label58.BackColor = System.Drawing.Color.Wheat;
      this.Label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label58.HelpContextID = 0;
      this.Label58.Name = "Label58";
      // 
      // cboPersonnel
      // 
      resources.ApplyResources(this.cboPersonnel, "cboPersonnel");
      this.cboPersonnel.Name = "cboPersonnel";
      this.cboPersonnel.NewValues = false;
      // 
      // Label548
      // 
      resources.ApplyResources(this.Label548, "Label548");
      this.Label548.BackColor = System.Drawing.Color.Wheat;
      this.Label548.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label548.HelpContextID = 0;
      this.Label548.Name = "Label548";
      // 
      // CmdEnregistrer
      // 
      resources.ApplyResources(this.CmdEnregistrer, "CmdEnregistrer");
      this.CmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdEnregistrer.HelpContextID = 0;
      this.CmdEnregistrer.Name = "CmdEnregistrer";
      this.CmdEnregistrer.Tag = "1";
      this.CmdEnregistrer.UseVisualStyleBackColor = true;
      this.CmdEnregistrer.Click += new System.EventHandler(this.CmdEnregistrer_Click);
      // 
      // frmGestionAbsences
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdEnregistrer);
      this.Controls.Add(this.Frame9);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestionAbsences";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmGestionAbsences_Load);
      this.Frame9.ResumeLayout(false);
      this.Frame9.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtNbHeures.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdQuitter;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame9;
    private MozartUC.apiCombo cboPersonnel;
    private MozartUC.apiLabel Label548;
    private MozartUC.apiCombo cboAbs;
    private MozartUC.apiLabel lblAbs;
    private DevExpress.XtraEditors.DateEdit txtDate;
    private MozartUC.apiLabel Label58;
    private DevExpress.XtraEditors.TextEdit txtNbHeures;
    private MozartUC.apiLabel lblNbMoisContractuel;
    private MozartUC.apiButton CmdEnregistrer;
  }
}
