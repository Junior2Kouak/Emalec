
namespace MozartCS
{
  partial class frmStatJourAbscence
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
      this.GrpActions = new System.Windows.Forms.GroupBox();
      this.BtnExportXLS = new System.Windows.Forms.Button();
      this.BtnFermer = new System.Windows.Forms.Button();
      this.LblTitre = new System.Windows.Forms.Label();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.PGCHeures = new DevExpress.XtraPivotGrid.PivotGridControl();
      this.PGF_VPERNOM = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_VSERLIB = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_Type = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_Age = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_RRET = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_CRMTR = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_VSITNOM = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_TOTALHR = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_NPERNUM = new DevExpress.XtraPivotGrid.PivotGridField();
      this.SFD = new System.Windows.Forms.SaveFileDialog();
      this.GrpActions.SuspendLayout();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PGCHeures)).BeginInit();
      this.SuspendLayout();
      // 
      // GrpActions
      // 
      this.GrpActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.GrpActions.Controls.Add(this.BtnExportXLS);
      this.GrpActions.Controls.Add(this.BtnFermer);
      this.GrpActions.Location = new System.Drawing.Point(12, 44);
      this.GrpActions.Name = "GrpActions";
      this.GrpActions.Size = new System.Drawing.Size(87, 913);
      this.GrpActions.TabIndex = 24;
      this.GrpActions.TabStop = false;
      // 
      // BtnExportXLS
      // 
      this.BtnExportXLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnExportXLS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnExportXLS.Location = new System.Drawing.Point(6, 64);
      this.BtnExportXLS.Name = "BtnExportXLS";
      this.BtnExportXLS.Size = new System.Drawing.Size(73, 58);
      this.BtnExportXLS.TabIndex = 9;
      this.BtnExportXLS.Tag = "";
      this.BtnExportXLS.Text = "Export EXCEL";
      this.BtnExportXLS.UseVisualStyleBackColor = true;
      this.BtnExportXLS.Click += new System.EventHandler(this.BtnExportXLS_Click);
      // 
      // BtnFermer
      // 
      this.BtnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnFermer.Location = new System.Drawing.Point(6, 850);
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.Size = new System.Drawing.Size(73, 57);
      this.BtnFermer.TabIndex = 1;
      this.BtnFermer.Text = "Fermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
      // 
      // LblTitre
      // 
      this.LblTitre.AutoSize = true;
      this.LblTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.LblTitre.Location = new System.Drawing.Point(100, 12);
      this.LblTitre.Name = "LblTitre";
      this.LblTitre.Size = new System.Drawing.Size(339, 29);
      this.LblTitre.TabIndex = 25;
      this.LblTitre.Text = "Tableau des jours d\'absence";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cmdValider);
      this.Frame2.Controls.Add(this.Calendar1);
      this.Frame2.Controls.Add(this.txtDateA1);
      this.Frame2.Controls.Add(this.cmdDate2);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.cmdDate1);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.lblLabels12);
      this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Location = new System.Drawing.Point(105, 44);
      this.Frame2.Name = "Frame2";
      this.Frame2.Size = new System.Drawing.Size(904, 65);
      this.Frame2.TabIndex = 29;
      this.Frame2.TabStop = false;
      this.Frame2.Text = "Choix de la période";
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdValider.Location = new System.Drawing.Point(813, 16);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(75, 34);
      this.cmdValider.TabIndex = 10;
      this.cmdValider.Tag = "66";
      this.cmdValider.Text = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.Calendar1.Location = new System.Drawing.Point(354, 38);
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.Size = new System.Drawing.Size(120, 21);
      this.Calendar1.TabIndex = 9;
      this.Calendar1.Visible = false;
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDateA1.Enabled = false;
      this.txtDateA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Location = new System.Drawing.Point(560, 24);
      this.txtDateA1.Name = "txtDateA1";
      this.txtDateA1.Size = new System.Drawing.Size(129, 20);
      this.txtDateA1.TabIndex = 6;
      this.txtDateA1.Tag = "1";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDate2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDate2.Location = new System.Drawing.Point(704, 16);
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Size = new System.Drawing.Size(40, 35);
      this.cmdDate2.TabIndex = 5;
      this.cmdDate2.Tag = "1";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDateA0.Enabled = false;
      this.txtDateA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Location = new System.Drawing.Point(128, 24);
      this.txtDateA0.Name = "txtDateA0";
      this.txtDateA0.Size = new System.Drawing.Size(129, 20);
      this.txtDateA0.TabIndex = 4;
      this.txtDateA0.Tag = "0";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDate1.Location = new System.Drawing.Point(272, 16);
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Size = new System.Drawing.Size(40, 35);
      this.cmdDate1.TabIndex = 3;
      this.cmdDate1.Tag = "0";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // lblLabels0
      // 
      this.lblLabels0.AutoSize = true;
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels0.Location = new System.Drawing.Point(472, 24);
      this.lblLabels0.Name = "lblLabels0";
      this.lblLabels0.Size = new System.Drawing.Size(78, 13);
      this.lblLabels0.TabIndex = 8;
      this.lblLabels0.Text = "Date de fin :";
      // 
      // lblLabels12
      // 
      this.lblLabels12.AutoSize = true;
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels12.Location = new System.Drawing.Point(16, 24);
      this.lblLabels12.Name = "lblLabels12";
      this.lblLabels12.Size = new System.Drawing.Size(96, 13);
      this.lblLabels12.TabIndex = 7;
      this.lblLabels12.Text = "Date de début :";
      // 
      // PGCHeures
      // 
      this.PGCHeures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PGCHeures.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGCHeures.Appearance.ColumnHeaderArea.Options.UseFont = true;
      this.PGCHeures.Appearance.ColumnHeaderArea.Options.UseTextOptions = true;
      this.PGCHeures.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGCHeures.Appearance.ColumnHeaderArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PGCHeures.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.DarkSeaGreen;
      this.PGCHeures.Appearance.GrandTotalCell.Options.UseBackColor = true;
      this.PGCHeures.Appearance.GrandTotalCell.Options.UseTextOptions = true;
      this.PGCHeures.Appearance.GrandTotalCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGCHeures.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.PGF_VPERNOM,
            this.PGF_VSERLIB,
            this.PGF_Type,
            this.PGF_Age,
            this.PGF_RRET,
            this.PGF_CRMTR,
            this.PGF_VSITNOM,
            this.PGF_TOTALHR,
            this.PGF_NPERNUM});
      this.PGCHeures.Location = new System.Drawing.Point(105, 115);
      this.PGCHeures.Name = "PGCHeures";
      this.PGCHeures.OptionsPrint.PageSettings.Landscape = true;
      this.PGCHeures.OptionsPrint.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
      this.PGCHeures.OptionsPrint.UsePrintAppearance = true;
      this.PGCHeures.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
      this.PGCHeures.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Near;
      this.PGCHeures.OptionsView.ShowDataHeaders = false;
      this.PGCHeures.OptionsView.ShowFilterHeaders = false;
      this.PGCHeures.Size = new System.Drawing.Size(1303, 842);
      this.PGCHeures.TabIndex = 30;
      // 
      // PGF_VPERNOM
      // 
      this.PGF_VPERNOM.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGF_VPERNOM.Appearance.Header.Options.UseFont = true;
      this.PGF_VPERNOM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_VPERNOM.AreaIndex = 0;
      this.PGF_VPERNOM.Caption = "Personnel";
      this.PGF_VPERNOM.FieldName = "VPERNOM";
      this.PGF_VPERNOM.Name = "PGF_VPERNOM";
      this.PGF_VPERNOM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      this.PGF_VPERNOM.Options.ReadOnly = true;
      this.PGF_VPERNOM.Width = 150;
      // 
      // PGF_VSERLIB
      // 
      this.PGF_VSERLIB.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_VSERLIB.AreaIndex = 1;
      this.PGF_VSERLIB.Caption = "Service";
      this.PGF_VSERLIB.FieldName = "VSERLIB";
      this.PGF_VSERLIB.Name = "PGF_VSERLIB";
      this.PGF_VSERLIB.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      // 
      // PGF_Type
      // 
      this.PGF_Type.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_Type.AreaIndex = 2;
      this.PGF_Type.Caption = "Type";
      this.PGF_Type.ExpandedInFieldsGroup = false;
      this.PGF_Type.FieldName = "VTYPEDETAILLIB";
      this.PGF_Type.Name = "PGF_Type";
      this.PGF_Type.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      // 
      // PGF_Age
      // 
      this.PGF_Age.Appearance.Cell.Options.UseTextOptions = true;
      this.PGF_Age.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_Age.Appearance.Header.Options.UseTextOptions = true;
      this.PGF_Age.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_Age.Appearance.Value.Options.UseTextOptions = true;
      this.PGF_Age.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_Age.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_Age.AreaIndex = 3;
      this.PGF_Age.Caption = "Age";
      this.PGF_Age.ExpandedInFieldsGroup = false;
      this.PGF_Age.FieldName = "AGE";
      this.PGF_Age.Name = "PGF_Age";
      this.PGF_Age.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      this.PGF_Age.Width = 70;
      // 
      // PGF_RRET
      // 
      this.PGF_RRET.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_RRET.AreaIndex = 4;
      this.PGF_RRET.Caption = "RRET";
      this.PGF_RRET.ExpandedInFieldsGroup = false;
      this.PGF_RRET.FieldName = "RRET";
      this.PGF_RRET.Name = "PGF_RRET";
      this.PGF_RRET.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      // 
      // PGF_CRMTR
      // 
      this.PGF_CRMTR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_CRMTR.AreaIndex = 5;
      this.PGF_CRMTR.Caption = "Contremaitre";
      this.PGF_CRMTR.ExpandedInFieldsGroup = false;
      this.PGF_CRMTR.FieldName = "CTRMTR";
      this.PGF_CRMTR.Name = "PGF_CRMTR";
      this.PGF_CRMTR.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      this.PGF_CRMTR.Width = 120;
      // 
      // PGF_VSITNOM
      // 
      this.PGF_VSITNOM.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGF_VSITNOM.Appearance.Header.Options.UseFont = true;
      this.PGF_VSITNOM.Appearance.Header.Options.UseTextOptions = true;
      this.PGF_VSITNOM.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_VSITNOM.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PGF_VSITNOM.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.PGF_VSITNOM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
      this.PGF_VSITNOM.AreaIndex = 0;
      this.PGF_VSITNOM.Caption = "Type absence";
      this.PGF_VSITNOM.FieldName = "VSITNOM";
      this.PGF_VSITNOM.Name = "PGF_VSITNOM";
      this.PGF_VSITNOM.Options.ReadOnly = true;
      this.PGF_VSITNOM.Width = 90;
      // 
      // PGF_TOTALHR
      // 
      this.PGF_TOTALHR.Appearance.Cell.Options.UseTextOptions = true;
      this.PGF_TOTALHR.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_TOTALHR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.PGF_TOTALHR.AreaIndex = 0;
      this.PGF_TOTALHR.Caption = "Jours";
      this.PGF_TOTALHR.CellFormat.FormatString = "n0";
      this.PGF_TOTALHR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.PGF_TOTALHR.FieldName = "NBJOUR";
      this.PGF_TOTALHR.Name = "PGF_TOTALHR";
      this.PGF_TOTALHR.Options.AllowEdit = false;
      this.PGF_TOTALHR.Options.ReadOnly = true;
      this.PGF_TOTALHR.Options.ShowInFilter = false;
      this.PGF_TOTALHR.Options.ShowInPrefilter = false;
      // 
      // PGF_NPERNUM
      // 
      this.PGF_NPERNUM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_NPERNUM.AreaIndex = 1;
      this.PGF_NPERNUM.ExpandedInFieldsGroup = false;
      this.PGF_NPERNUM.FieldName = "NPERNUM";
      this.PGF_NPERNUM.MinWidth = 0;
      this.PGF_NPERNUM.Name = "PGF_NPERNUM";
      this.PGF_NPERNUM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
      this.PGF_NPERNUM.Visible = false;
      this.PGF_NPERNUM.Width = 50;
      // 
      // frmStatJourAbscence
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1431, 987);
      this.Controls.Add(this.PGCHeures);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.GrpActions);
      this.Controls.Add(this.LblTitre);
      this.Name = "frmStatJourAbscence";
      this.Text = "frmStatJourAbscence";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatJourAbscence_Load);
      this.GrpActions.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PGCHeures)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.GroupBox GrpActions;
    internal System.Windows.Forms.Button BtnExportXLS;
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Label LblTitre;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private DevExpress.XtraPivotGrid.PivotGridControl PGCHeures;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_VPERNOM;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_VSITNOM;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_TOTALHR;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_NPERNUM;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_VSERLIB;
    private System.Windows.Forms.SaveFileDialog SFD;
    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_Type;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_Age;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_RRET;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_CRMTR;
  }
}