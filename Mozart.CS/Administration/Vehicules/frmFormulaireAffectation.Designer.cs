namespace MozartCS
{
  partial class frmFormulaireAffectation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulaireAffectation));
			this.panelRevision = new System.Windows.Forms.Panel();
			this.cboStatut = new System.Windows.Forms.ComboBox();
			this.apiLabel3 = new MozartUC.apiLabel();
			this.cboSociete = new System.Windows.Forms.ComboBox();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.txtDateDebut = new DevExpress.XtraEditors.DateEdit();
			this.cmdAnnulerRev = new MozartUC.apiButton();
			this.cboEmploye = new System.Windows.Forms.ComboBox();
			this.cmdValiderRev = new MozartUC.apiButton();
			this.apiLabel33 = new MozartUC.apiLabel();
			this.apiLabel34 = new MozartUC.apiLabel();
			this.txtDateFin = new DevExpress.XtraEditors.DateEdit();
			this.apiLabel4 = new MozartUC.apiLabel();
			this.panelRevision.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRevision
			// 
			this.panelRevision.BackColor = System.Drawing.Color.BurlyWood;
			this.panelRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRevision.Controls.Add(this.cboStatut);
			this.panelRevision.Controls.Add(this.apiLabel3);
			this.panelRevision.Controls.Add(this.cboSociete);
			this.panelRevision.Controls.Add(this.apiLabel2);
			this.panelRevision.Controls.Add(this.apiLabel1);
			this.panelRevision.Controls.Add(this.txtDateDebut);
			this.panelRevision.Controls.Add(this.cmdAnnulerRev);
			this.panelRevision.Controls.Add(this.cboEmploye);
			this.panelRevision.Controls.Add(this.cmdValiderRev);
			this.panelRevision.Controls.Add(this.apiLabel33);
			this.panelRevision.Controls.Add(this.apiLabel34);
			this.panelRevision.Controls.Add(this.txtDateFin);
			resources.ApplyResources(this.panelRevision, "panelRevision");
			this.panelRevision.Name = "panelRevision";
			// 
			// cboStatut
			// 
			this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboStatut, "cboStatut");
			this.cboStatut.Name = "cboStatut";
			// 
			// apiLabel3
			// 
			resources.ApplyResources(this.apiLabel3, "apiLabel3");
			this.apiLabel3.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel3.HelpContextID = 0;
			this.apiLabel3.Name = "apiLabel3";
			// 
			// cboSociete
			// 
			this.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboSociete, "cboSociete");
			this.cboSociete.Items.AddRange(new object[] {
            resources.GetString("cboSociete.Items"),
            resources.GetString("cboSociete.Items1")});
			this.cboSociete.Name = "cboSociete";
			this.cboSociete.Tag = "44";
			this.cboSociete.SelectionChangeCommitted += new System.EventHandler(this.cboSociete_SelectionChangeCommitted);
			// 
			// apiLabel2
			// 
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel2.HelpContextID = 0;
			this.apiLabel2.Name = "apiLabel2";
			// 
			// apiLabel1
			// 
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
			// 
			// txtDateDebut
			// 
			resources.ApplyResources(this.txtDateDebut, "txtDateDebut");
			this.txtDateDebut.Name = "txtDateDebut";
			this.txtDateDebut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateDebut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.Buttons"))))});
			this.txtDateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.CalendarTimeProperties.Buttons"))))});
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
			// cboEmploye
			// 
			this.cboEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboEmploye, "cboEmploye");
			this.cboEmploye.Items.AddRange(new object[] {
            resources.GetString("cboEmploye.Items"),
            resources.GetString("cboEmploye.Items1"),
            resources.GetString("cboEmploye.Items2")});
			this.cboEmploye.Name = "cboEmploye";
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
			// txtDateFin
			// 
			resources.ApplyResources(this.txtDateFin, "txtDateFin");
			this.txtDateFin.Name = "txtDateFin";
			this.txtDateFin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.Buttons"))))});
			this.txtDateFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// apiLabel4
			// 
			resources.ApplyResources(this.apiLabel4, "apiLabel4");
			this.apiLabel4.BackColor = System.Drawing.Color.BurlyWood;
			this.apiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.apiLabel4.HelpContextID = 0;
			this.apiLabel4.Name = "apiLabel4";
			// 
			// frmFormulaireAffectation
			// 
			this.BackColor = System.Drawing.Color.BurlyWood;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.apiLabel4);
			this.Controls.Add(this.panelRevision);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFormulaireAffectation";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmDetailFormulaires_Load);
			this.panelRevision.ResumeLayout(false);
			this.panelRevision.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

		#endregion

		private System.Windows.Forms.Panel panelRevision;
		private MozartUC.apiButton cmdAnnulerRev;
		private System.Windows.Forms.ComboBox cboEmploye;
		private MozartUC.apiButton cmdValiderRev;
		private MozartUC.apiLabel apiLabel33;
		private MozartUC.apiLabel apiLabel34;
		private DevExpress.XtraEditors.DateEdit txtDateFin;
		private MozartUC.apiLabel apiLabel1;
		private DevExpress.XtraEditors.DateEdit txtDateDebut;
		private System.Windows.Forms.ComboBox cboSociete;
		private MozartUC.apiLabel apiLabel2;
		private System.Windows.Forms.ComboBox cboStatut;
		private MozartUC.apiLabel apiLabel3;
		private MozartUC.apiLabel apiLabel4;
	}
}
