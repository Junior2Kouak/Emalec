
namespace MozartCS
{
  partial class frmGestContratPrev
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestContratPrev));
      this.cmdValider = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiLabel4 = new MozartUC.apiLabel();
      this.apiLabel5 = new MozartUC.apiLabel();
      this.txtRatio = new DevExpress.XtraEditors.TextEdit();
      this.txtTotContFactSaisieManuelle = new DevExpress.XtraEditors.TextEdit();
      this.cmdCalcTotalPrevSeulRemonteeDI = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chkInactif = new System.Windows.Forms.RadioButton();
      this.chkActif = new System.Windows.Forms.RadioButton();
      this.txtTotCurFourSeul = new DevExpress.XtraEditors.TextEdit();
      this.apiLabel3 = new MozartUC.apiLabel();
      this.txtTotContFact = new DevExpress.XtraEditors.TextEdit();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.txtTotPrevDI = new DevExpress.XtraEditors.TextEdit();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.txtTotPrevSeul = new DevExpress.XtraEditors.TextEdit();
      this.cboTypeFact = new MozartUC.apiCombo();
      this.dateFin = new DevExpress.XtraEditors.DateEdit();
      this.dateDebut = new DevExpress.XtraEditors.DateEdit();
      this.cmdOK = new MozartUC.apiButton();
      this.cmdCancel = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.apiGridHisto = new MozartUC.apiTGrid();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotContFactSaisieManuelle.Properties)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotCurFourSeul.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotContFact.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotPrevDI.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotPrevSeul.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateDebut.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateDebut.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "15";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.Frame2.Controls.Add(this.apiLabel4);
      this.Frame2.Controls.Add(this.apiLabel5);
      this.Frame2.Controls.Add(this.txtRatio);
      this.Frame2.Controls.Add(this.txtTotContFactSaisieManuelle);
      this.Frame2.Controls.Add(this.cmdCalcTotalPrevSeulRemonteeDI);
      this.Frame2.Controls.Add(this.groupBox1);
      this.Frame2.Controls.Add(this.txtTotCurFourSeul);
      this.Frame2.Controls.Add(this.apiLabel3);
      this.Frame2.Controls.Add(this.txtTotContFact);
      this.Frame2.Controls.Add(this.apiLabel2);
      this.Frame2.Controls.Add(this.txtTotPrevDI);
      this.Frame2.Controls.Add(this.apiLabel1);
      this.Frame2.Controls.Add(this.txtTotPrevSeul);
      this.Frame2.Controls.Add(this.cboTypeFact);
      this.Frame2.Controls.Add(this.dateFin);
      this.Frame2.Controls.Add(this.dateDebut);
      this.Frame2.Controls.Add(this.cmdOK);
      this.Frame2.Controls.Add(this.cmdCancel);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.lblLabels1);
      this.Frame2.Controls.Add(this.lblLabels2);
      this.Frame2.Controls.Add(this.lblLabels3);
      this.Frame2.Controls.Add(this.lblPeriode);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiLabel4
      // 
      resources.ApplyResources(this.apiLabel4, "apiLabel4");
      this.apiLabel4.BackColor = System.Drawing.Color.Transparent;
      this.apiLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel4.HelpContextID = 0;
      this.apiLabel4.Name = "apiLabel4";
      // 
      // apiLabel5
      // 
      resources.ApplyResources(this.apiLabel5, "apiLabel5");
      this.apiLabel5.BackColor = System.Drawing.Color.Transparent;
      this.apiLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel5.HelpContextID = 0;
      this.apiLabel5.Name = "apiLabel5";
      // 
      // txtRatio
      // 
      resources.ApplyResources(this.txtRatio, "txtRatio");
      this.txtRatio.Name = "txtRatio";
      this.txtRatio.Properties.Mask.EditMask = resources.GetString("txtRatio.Properties.Mask.EditMask");
      this.txtRatio.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtRatio.Properties.Mask.MaskType")));
      this.txtRatio.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtRatio.Properties.Mask.UseMaskAsDisplayFormat")));
      // 
      // txtTotContFactSaisieManuelle
      // 
      resources.ApplyResources(this.txtTotContFactSaisieManuelle, "txtTotContFactSaisieManuelle");
      this.txtTotContFactSaisieManuelle.Name = "txtTotContFactSaisieManuelle";
      this.txtTotContFactSaisieManuelle.Properties.Mask.EditMask = resources.GetString("txtTotContFactSaisieManuelle.Properties.Mask.EditMask");
      this.txtTotContFactSaisieManuelle.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTotContFactSaisieManuelle.Properties.Mask.MaskType")));
      this.txtTotContFactSaisieManuelle.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotContFactSaisieManuelle.Properties.Mask.UseMaskAsDisplayFormat")));
      this.txtTotContFactSaisieManuelle.TextChanged += new System.EventHandler(this.calcTotaux);
      // 
      // cmdCalcTotalPrevSeulRemonteeDI
      // 
      resources.ApplyResources(this.cmdCalcTotalPrevSeulRemonteeDI, "cmdCalcTotalPrevSeulRemonteeDI");
      this.cmdCalcTotalPrevSeulRemonteeDI.Name = "cmdCalcTotalPrevSeulRemonteeDI";
      this.cmdCalcTotalPrevSeulRemonteeDI.UseVisualStyleBackColor = true;
      this.cmdCalcTotalPrevSeulRemonteeDI.Click += new System.EventHandler(this.cmdCalcTotalPrevSeulRemonteeDI_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkInactif);
      this.groupBox1.Controls.Add(this.chkActif);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // chkInactif
      // 
      resources.ApplyResources(this.chkInactif, "chkInactif");
      this.chkInactif.Name = "chkInactif";
      this.chkInactif.TabStop = true;
      this.chkInactif.UseVisualStyleBackColor = true;
      // 
      // chkActif
      // 
      resources.ApplyResources(this.chkActif, "chkActif");
      this.chkActif.Name = "chkActif";
      this.chkActif.TabStop = true;
      this.chkActif.UseVisualStyleBackColor = true;
      // 
      // txtTotCurFourSeul
      // 
      resources.ApplyResources(this.txtTotCurFourSeul, "txtTotCurFourSeul");
      this.txtTotCurFourSeul.Name = "txtTotCurFourSeul";
      this.txtTotCurFourSeul.Properties.Mask.EditMask = resources.GetString("txtTotCurFourSeul.Properties.Mask.EditMask");
      this.txtTotCurFourSeul.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTotCurFourSeul.Properties.Mask.MaskType")));
      this.txtTotCurFourSeul.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotCurFourSeul.Properties.Mask.UseMaskAsDisplayFormat")));
      // 
      // apiLabel3
      // 
      resources.ApplyResources(this.apiLabel3, "apiLabel3");
      this.apiLabel3.BackColor = System.Drawing.Color.Transparent;
      this.apiLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel3.HelpContextID = 0;
      this.apiLabel3.Name = "apiLabel3";
      // 
      // txtTotContFact
      // 
      resources.ApplyResources(this.txtTotContFact, "txtTotContFact");
      this.txtTotContFact.Name = "txtTotContFact";
      this.txtTotContFact.Properties.Mask.EditMask = resources.GetString("txtTotContFact.Properties.Mask.EditMask");
      this.txtTotContFact.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTotContFact.Properties.Mask.MaskType")));
      this.txtTotContFact.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotContFact.Properties.Mask.UseMaskAsDisplayFormat")));
      // 
      // apiLabel2
      // 
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.BackColor = System.Drawing.Color.Transparent;
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // txtTotPrevDI
      // 
      resources.ApplyResources(this.txtTotPrevDI, "txtTotPrevDI");
      this.txtTotPrevDI.Name = "txtTotPrevDI";
      this.txtTotPrevDI.Properties.Mask.EditMask = resources.GetString("txtTotPrevDI.Properties.Mask.EditMask");
      this.txtTotPrevDI.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTotPrevDI.Properties.Mask.MaskType")));
      this.txtTotPrevDI.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotPrevDI.Properties.Mask.UseMaskAsDisplayFormat")));
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Transparent;
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // txtTotPrevSeul
      // 
      resources.ApplyResources(this.txtTotPrevSeul, "txtTotPrevSeul");
      this.txtTotPrevSeul.Name = "txtTotPrevSeul";
      this.txtTotPrevSeul.Properties.Mask.EditMask = resources.GetString("txtTotPrevSeul.Properties.Mask.EditMask");
      this.txtTotPrevSeul.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTotPrevSeul.Properties.Mask.MaskType")));
      this.txtTotPrevSeul.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTotPrevSeul.Properties.Mask.UseMaskAsDisplayFormat")));
      this.txtTotPrevSeul.TextChanged += new System.EventHandler(this.calcTotaux);
      // 
      // cboTypeFact
      // 
      resources.ApplyResources(this.cboTypeFact, "cboTypeFact");
      this.cboTypeFact.Name = "cboTypeFact";
      this.cboTypeFact.NewValues = false;
      // 
      // dateFin
      // 
      resources.ApplyResources(this.dateFin, "dateFin");
      this.dateFin.Name = "dateFin";
      this.dateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateFin.Properties.Buttons"))))});
      this.dateFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateFin.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // dateDebut
      // 
      resources.ApplyResources(this.dateDebut, "dateDebut");
      this.dateDebut.Name = "dateDebut";
      this.dateDebut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateDebut.Properties.Buttons"))))});
      this.dateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateDebut.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // cmdOK
      // 
      resources.ApplyResources(this.cmdOK, "cmdOK");
      this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOK.HelpContextID = 0;
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.UseVisualStyleBackColor = true;
      this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
      // 
      // cmdCancel
      // 
      resources.ApplyResources(this.cmdCancel, "cmdCancel");
      this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCancel.HelpContextID = 0;
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.BackColor = System.Drawing.Color.Transparent;
      this.lblPeriode.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // apiGridHisto
      // 
      this.apiGridHisto.FilterBar = true;
      this.apiGridHisto.FooterBar = true;
      resources.ApplyResources(this.apiGridHisto, "apiGridHisto");
      this.apiGridHisto.Name = "apiGridHisto";
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = false;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.ApiGrid_RowCellStyle);
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
      // 
      // frmGestContratPrev
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.apiGridHisto);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmGestContratPrev";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestContratPrev_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotContFactSaisieManuelle.Properties)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotCurFourSeul.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotContFact.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotPrevDI.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTotPrevSeul.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateDebut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateDebut.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiTGrid apiGridHisto;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiCombo cboTypeFact;
    private DevExpress.XtraEditors.DateEdit dateFin;
    private DevExpress.XtraEditors.DateEdit dateDebut;
    private MozartUC.apiButton cmdOK;
    private MozartUC.apiButton cmdCancel;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblPeriode;
    private DevExpress.XtraEditors.TextEdit txtTotPrevSeul;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton chkInactif;
    private System.Windows.Forms.RadioButton chkActif;
    private DevExpress.XtraEditors.TextEdit txtTotCurFourSeul;
    private MozartUC.apiLabel apiLabel3;
    private DevExpress.XtraEditors.TextEdit txtTotContFact;
    private MozartUC.apiLabel apiLabel2;
    private DevExpress.XtraEditors.TextEdit txtTotPrevDI;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiButton cmdModifier;
    private System.Windows.Forms.Button cmdCalcTotalPrevSeulRemonteeDI;
    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraEditors.TextEdit txtRatio;
    private DevExpress.XtraEditors.TextEdit txtTotContFactSaisieManuelle;
    private MozartUC.apiLabel apiLabel4;
    private MozartUC.apiLabel apiLabel5;
  }
}