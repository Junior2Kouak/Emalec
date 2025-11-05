namespace MozartCS
{
  partial class frmListeGeoLocalisation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeGeoLocalisation));
      this.cmdSuivi = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apicboTech = new MozartUC.apiCombo();
      this.lblLabels12 = new System.Windows.Forms.Label();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDate = new DevExpress.XtraEditors.DateEdit();
      this.txtDateFin = new DevExpress.XtraEditors.DateEdit();
      this.cmdJournee = new MozartUC.apiButton();
      this.cmdCarte = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdSuivi
      // 
      resources.ApplyResources(this.cmdSuivi, "cmdSuivi");
      this.cmdSuivi.HelpContextID = 0;
      this.cmdSuivi.Name = "cmdSuivi";
      this.cmdSuivi.Tag = "62";
      this.cmdSuivi.UseVisualStyleBackColor = true;
      this.cmdSuivi.Click += new System.EventHandler(this.cmdSuivi_Click);
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
      // apicboTech
      // 
      resources.ApplyResources(this.apicboTech, "apicboTech");
      this.apicboTech.Name = "apicboTech";
      this.apicboTech.NewValues = false;
      this.apicboTech.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cbotech_TxtChanged);
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.label1);
      this.Frame2.Controls.Add(this.txtDate);
      this.Frame2.Controls.Add(this.txtDateFin);
      this.Frame2.Controls.Add(this.cmdValider);
      this.Frame2.Controls.Add(this.lblLabels12);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Name = "label1";
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
      this.txtDate.EditValueChanged += new System.EventHandler(this.txtDate_EditValueChanged);
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
      this.txtDateFin.EditValueChanged += new System.EventHandler(this.txtDateFin_EditValueChanged);
      // 
      // cmdJournee
      // 
      resources.ApplyResources(this.cmdJournee, "cmdJournee");
      this.cmdJournee.HelpContextID = 0;
      this.cmdJournee.Name = "cmdJournee";
      this.cmdJournee.Tag = "5";
      this.cmdJournee.UseVisualStyleBackColor = true;
      this.cmdJournee.Click += new System.EventHandler(this.cmdJournee_Click);
      // 
      // cmdCarte
      // 
      resources.ApplyResources(this.cmdCarte, "cmdCarte");
      this.cmdCarte.HelpContextID = 0;
      this.cmdCarte.Name = "cmdCarte";
      this.cmdCarte.Tag = "70";
      this.cmdCarte.UseVisualStyleBackColor = true;
      this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // frmListeGeoLocalisation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apicboTech);
      this.Controls.Add(this.cmdSuivi);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdJournee);
      this.Controls.Add(this.cmdCarte);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Name = "frmListeGeoLocalisation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeGeoLocalisation_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdSuivi;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiCombo apicboTech;
    private System.Windows.Forms.Label lblLabels12;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdJournee;
    private MozartUC.apiButton cmdCarte;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Label label1;
    private DevExpress.XtraEditors.DateEdit txtDate;
    private DevExpress.XtraEditors.DateEdit txtDateFin;
  }
}
