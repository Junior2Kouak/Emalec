namespace MozartCS
{
  partial class frmFormulaireRevision
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulaireRevision));
			this.panelRevision = new System.Windows.Forms.Panel();
			this.txtKmRev = new DevExpress.XtraEditors.TextEdit();
			this.cmdAnnulerRev = new MozartUC.apiButton();
			this.cboTypeRev = new System.Windows.Forms.ComboBox();
			this.cmdValiderRev = new MozartUC.apiButton();
			this.apiLabel27 = new MozartUC.apiLabel();
			this.txtDiversRev = new MozartUC.apiTextBox();
			this.apiLabel33 = new MozartUC.apiLabel();
			this.apiLabel34 = new MozartUC.apiLabel();
			this.apiLabel35 = new MozartUC.apiLabel();
			this.txtDateRev = new DevExpress.XtraEditors.DateEdit();
			this.apiLabel4 = new MozartUC.apiLabel();
			this.panelRevision.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKmRev.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateRev.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateRev.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRevision
			// 
			this.panelRevision.BackColor = System.Drawing.Color.BurlyWood;
			this.panelRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRevision.Controls.Add(this.txtKmRev);
			this.panelRevision.Controls.Add(this.cmdAnnulerRev);
			this.panelRevision.Controls.Add(this.cboTypeRev);
			this.panelRevision.Controls.Add(this.cmdValiderRev);
			this.panelRevision.Controls.Add(this.apiLabel27);
			this.panelRevision.Controls.Add(this.txtDiversRev);
			this.panelRevision.Controls.Add(this.apiLabel33);
			this.panelRevision.Controls.Add(this.apiLabel34);
			this.panelRevision.Controls.Add(this.apiLabel35);
			this.panelRevision.Controls.Add(this.txtDateRev);
			resources.ApplyResources(this.panelRevision, "panelRevision");
			this.panelRevision.Name = "panelRevision";
			// 
			// txtKmRev
			// 
			resources.ApplyResources(this.txtKmRev, "txtKmRev");
			this.txtKmRev.Name = "txtKmRev";
			this.txtKmRev.Properties.Appearance.Options.UseTextOptions = true;
			this.txtKmRev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtKmRev.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtKmRev.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtKmRev.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtKmRev.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtKmRev.Properties.MaskSettings.Set("mask", "n0");
			// 
			// cmdAnnulerRev
			// 
			resources.ApplyResources(this.cmdAnnulerRev, "cmdAnnulerRev");
			this.cmdAnnulerRev.HelpContextID = 0;
			this.cmdAnnulerRev.Name = "cmdAnnulerRev";
			this.cmdAnnulerRev.Tag = "66";
			this.cmdAnnulerRev.UseVisualStyleBackColor = true;
			this.cmdAnnulerRev.Click += new System.EventHandler(this.cmdAnnulerRev_Click);
			// 
			// cboTypeRev
			// 
			this.cboTypeRev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboTypeRev, "cboTypeRev");
			this.cboTypeRev.Items.AddRange(new object[] {
            resources.GetString("cboTypeRev.Items"),
            resources.GetString("cboTypeRev.Items1")});
			this.cboTypeRev.Name = "cboTypeRev";
			// 
			// cmdValiderRev
			// 
			resources.ApplyResources(this.cmdValiderRev, "cmdValiderRev");
			this.cmdValiderRev.HelpContextID = 0;
			this.cmdValiderRev.Name = "cmdValiderRev";
			this.cmdValiderRev.Tag = "66";
			this.cmdValiderRev.UseVisualStyleBackColor = true;
			this.cmdValiderRev.Click += new System.EventHandler(this.cmdValiderRev_Click);
			// 
			// apiLabel27
			// 
			resources.ApplyResources(this.apiLabel27, "apiLabel27");
			this.apiLabel27.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel27.HelpContextID = 0;
			this.apiLabel27.Name = "apiLabel27";
			// 
			// txtDiversRev
			// 
			this.txtDiversRev.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDiversRev.HelpContextID = 0;
			resources.ApplyResources(this.txtDiversRev, "txtDiversRev");
			this.txtDiversRev.Name = "txtDiversRev";
			// 
			// apiLabel33
			// 
			resources.ApplyResources(this.apiLabel33, "apiLabel33");
			this.apiLabel33.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel33.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel33.HelpContextID = 0;
			this.apiLabel33.Name = "apiLabel33";
			// 
			// apiLabel34
			// 
			resources.ApplyResources(this.apiLabel34, "apiLabel34");
			this.apiLabel34.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel34.HelpContextID = 0;
			this.apiLabel34.Name = "apiLabel34";
			// 
			// apiLabel35
			// 
			resources.ApplyResources(this.apiLabel35, "apiLabel35");
			this.apiLabel35.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel35.HelpContextID = 0;
			this.apiLabel35.Name = "apiLabel35";
			// 
			// txtDateRev
			// 
			resources.ApplyResources(this.txtDateRev, "txtDateRev");
			this.txtDateRev.Name = "txtDateRev";
			this.txtDateRev.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateRev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateRev.Properties.Buttons"))))});
			this.txtDateRev.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateRev.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// apiLabel4
			// 
			resources.ApplyResources(this.apiLabel4, "apiLabel4");
			this.apiLabel4.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel4.HelpContextID = 0;
			this.apiLabel4.Name = "apiLabel4";
			// 
			// frmFormulaireRevision
			// 
			this.BackColor = System.Drawing.Color.BurlyWood;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.apiLabel4);
			this.Controls.Add(this.panelRevision);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFormulaireRevision";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmDetailFormulaires_Load);
			this.panelRevision.ResumeLayout(false);
			this.panelRevision.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtKmRev.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateRev.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateRev.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

		#endregion

		private System.Windows.Forms.Panel panelRevision;
		private DevExpress.XtraEditors.TextEdit txtKmRev;
		private MozartUC.apiButton cmdAnnulerRev;
		private System.Windows.Forms.ComboBox cboTypeRev;
		private MozartUC.apiButton cmdValiderRev;
		private MozartUC.apiLabel apiLabel27;
		private MozartUC.apiTextBox txtDiversRev;
		private MozartUC.apiLabel apiLabel33;
		private MozartUC.apiLabel apiLabel34;
		private MozartUC.apiLabel apiLabel35;
		private DevExpress.XtraEditors.DateEdit txtDateRev;
		private MozartUC.apiLabel apiLabel4;
	}
}
