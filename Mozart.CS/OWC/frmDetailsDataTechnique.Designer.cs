namespace MozartCS
{
  partial class frmDetailsDataTechnique
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsDataTechnique));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
      this.ChartSpace1 = new DevExpress.XtraCharts.ChartControl();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.DateReleve = new DevExpress.XtraEditors.DateEdit();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.cmdValider = new MozartUC.apiButton();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.txtIndice = new DevExpress.XtraEditors.TextEdit();
      this.apiLabel3 = new MozartUC.apiLabel();
      this.apiLabel4 = new MozartUC.apiLabel();
      this.txtConso = new DevExpress.XtraEditors.TextEdit();
      this.apiLabel5 = new MozartUC.apiLabel();
      this.apiLabel6 = new MozartUC.apiLabel();
      this.apiLabel7 = new MozartUC.apiLabel();
      this.apiLabel8 = new MozartUC.apiLabel();
      this.cmdSup = new MozartUC.apiButton();
      ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateReleve.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateReleve.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtIndice.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtConso.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // ChartSpace1
      // 
      resources.ApplyResources(this.ChartSpace1, "ChartSpace1");
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      this.ChartSpace1.Diagram = xyDiagram1;
      this.ChartSpace1.Legend.Name = "Default Legend";
      this.ChartSpace1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.ChartSpace1.Name = "ChartSpace1";
      series1.ArgumentDataMember = "per";
      series1.ValueDataMembersSerializable = "ninfoconso";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      regressionLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      regressionLine1.LineStyle.Thickness = 3;
      sideBySideBarSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
      series1.View = sideBySideBarSeriesView1;
      this.ChartSpace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // DateReleve
      // 
      resources.ApplyResources(this.DateReleve, "DateReleve");
      this.DateReleve.Name = "DateReleve";
      this.DateReleve.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateReleve.Properties.Buttons"))))});
      this.DateReleve.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateReleve.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValide_Click);
      // 
      // apiLabel2
      // 
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // txtIndice
      // 
      resources.ApplyResources(this.txtIndice, "txtIndice");
      this.txtIndice.Name = "txtIndice";
      this.txtIndice.Properties.Appearance.Options.UseTextOptions = true;
      this.txtIndice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.txtIndice.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.txtIndice.Properties.Mask.EditMask = resources.GetString("TxtIndice.Properties.Mask.EditMask");
      this.txtIndice.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("TxtIndice.Properties.Mask.MaskType")));
      this.txtIndice.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("TxtIndice.Properties.Mask.UseMaskAsDisplayFormat")));
      this.txtIndice.TextChanged += new System.EventHandler(this.TxtIndice_TextChanged);
      // 
      // apiLabel3
      // 
      resources.ApplyResources(this.apiLabel3, "apiLabel3");
      this.apiLabel3.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel3.HelpContextID = 0;
      this.apiLabel3.Name = "apiLabel3";
      // 
      // apiLabel4
      // 
      resources.ApplyResources(this.apiLabel4, "apiLabel4");
      this.apiLabel4.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel4.HelpContextID = 0;
      this.apiLabel4.Name = "apiLabel4";
      // 
      // txtConso
      // 
      resources.ApplyResources(this.txtConso, "txtConso");
      this.txtConso.Name = "txtConso";
      this.txtConso.Properties.Appearance.Options.UseTextOptions = true;
      this.txtConso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.txtConso.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.txtConso.Properties.Mask.EditMask = resources.GetString("txtConso.Properties.Mask.EditMask");
      this.txtConso.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtConso.Properties.Mask.MaskType")));
      this.txtConso.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtConso.Properties.Mask.UseMaskAsDisplayFormat")));
      this.txtConso.Properties.NullValuePromptShowForEmptyValue = ((bool)(resources.GetObject("txtConso.Properties.NullValuePromptShowForEmptyValue")));
      this.txtConso.TextChanged += new System.EventHandler(this.txtConso_TextChanged);
      // 
      // apiLabel5
      // 
      resources.ApplyResources(this.apiLabel5, "apiLabel5");
      this.apiLabel5.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel5.HelpContextID = 0;
      this.apiLabel5.Name = "apiLabel5";
      // 
      // apiLabel6
      // 
      resources.ApplyResources(this.apiLabel6, "apiLabel6");
      this.apiLabel6.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel6.HelpContextID = 0;
      this.apiLabel6.Name = "apiLabel6";
      // 
      // apiLabel7
      // 
      resources.ApplyResources(this.apiLabel7, "apiLabel7");
      this.apiLabel7.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel7.HelpContextID = 0;
      this.apiLabel7.Name = "apiLabel7";
      // 
      // apiLabel8
      // 
      resources.ApplyResources(this.apiLabel8, "apiLabel8");
      this.apiLabel8.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel8.HelpContextID = 0;
      this.apiLabel8.Name = "apiLabel8";
      // 
      // cmdSup
      // 
      resources.ApplyResources(this.cmdSup, "cmdSup");
      this.cmdSup.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSup.HelpContextID = 20;
      this.cmdSup.Name = "cmdSup";
      this.cmdSup.Tag = "66";
      this.cmdSup.UseVisualStyleBackColor = true;
      this.cmdSup.Click += new System.EventHandler(this.cmdSup_Click);
      // 
      // frmDetailsDataTechnique
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSup);
      this.Controls.Add(this.apiLabel8);
      this.Controls.Add(this.apiLabel7);
      this.Controls.Add(this.apiLabel6);
      this.Controls.Add(this.txtConso);
      this.Controls.Add(this.apiLabel5);
      this.Controls.Add(this.apiLabel4);
      this.Controls.Add(this.apiLabel3);
      this.Controls.Add(this.txtIndice);
      this.Controls.Add(this.apiLabel2);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.DateReleve);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.ChartSpace1);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailsDataTechnique";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmDetailsDataTechnique_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateReleve.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateReleve.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtIndice.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtConso.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private DevExpress.XtraCharts.ChartControl ChartSpace1;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private DevExpress.XtraEditors.DateEdit DateReleve;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel apiLabel2;
    private DevExpress.XtraEditors.TextEdit txtIndice;
    private MozartUC.apiLabel apiLabel3;
    private MozartUC.apiLabel apiLabel4;
    private DevExpress.XtraEditors.TextEdit txtConso;
    private MozartUC.apiLabel apiLabel5;
    private MozartUC.apiLabel apiLabel6;
    private MozartUC.apiLabel apiLabel7;
    private MozartUC.apiLabel apiLabel8;
    private MozartUC.apiButton cmdSup;
  }
}
