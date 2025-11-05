namespace MozartCS
{
  partial class frmStatCAClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatCAClient));
			DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.TrendLine trendLine2 = new DevExpress.XtraCharts.TrendLine();
			DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
			this.cmdValider = new MozartUC.apiButton();
			this.ChartSpace1 = new DevExpress.XtraCharts.ChartControl();
			this.Label7 = new MozartUC.apiLabel();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdImprimer = new MozartUC.apiButton();
			this.grdDataGrid2 = new MozartUC.apiTGrid();
			this.cboClient = new MozartUC.apiCombo();
			this.lblLabels11 = new MozartUC.apiLabel();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.txtDateFin = new DevExpress.XtraEditors.DateEdit();
			this.txtDateDebut = new DevExpress.XtraEditors.DateEdit();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(trendLine2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.HelpContextID = 0;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.UseVisualStyleBackColor = true;
			this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
			// 
			// ChartSpace1
			// 
			resources.ApplyResources(this.ChartSpace1, "ChartSpace1");
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram2.AxisY.Label.TextPattern = "{V:C0}";
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ChartSpace1.Diagram = xyDiagram2;
			this.ChartSpace1.Legend.Name = "Default Legend";
			this.ChartSpace1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
			this.ChartSpace1.Name = "ChartSpace1";
			series2.ArgumentDataMember = "per";
			resources.ApplyResources(series2, "series2");
			series2.ValueDataMembersSerializable = "THT";
			sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			trendLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			trendLine2.LineStyle.Thickness = 3;
			resources.ApplyResources(trendLine2, "trendLine2");
			trendLine2.Point1.ArgumentSerializable = "0";
			trendLine2.Point2.ArgumentSerializable = "9";
			sideBySideBarSeriesView2.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            trendLine2});
			series2.View = sideBySideBarSeriesView2;
			this.ChartSpace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			resources.ApplyResources(chartTitle2, "chartTitle2");
			chartTitle2.TextColor = System.Drawing.Color.Black;
			this.ChartSpace1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.HelpContextID = 0;
			this.Label7.Name = "Label7";
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
			// cmdImprimer
			// 
			resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
			this.cmdImprimer.HelpContextID = 0;
			this.cmdImprimer.Name = "cmdImprimer";
			this.cmdImprimer.Tag = "17";
			this.cmdImprimer.UseVisualStyleBackColor = true;
			this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
			// 
			// grdDataGrid2
			// 
			resources.ApplyResources(this.grdDataGrid2, "grdDataGrid2");
			this.grdDataGrid2.CounterColumn = null;
			this.grdDataGrid2.FilterBar = true;
			this.grdDataGrid2.FooterBar = true;
			this.grdDataGrid2.Name = "grdDataGrid2";
			// 
			// cboClient
			// 
			resources.ApplyResources(this.cboClient, "cboClient");
			this.cboClient.Name = "cboClient";
			this.cboClient.NewValues = false;
			// 
			// lblLabels11
			// 
			this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.lblLabels11, "lblLabels11");
			this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels11.HelpContextID = 0;
			this.lblLabels11.Name = "lblLabels11";
			// 
			// apiLabel1
			// 
			this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
			// 
			// apiLabel2
			// 
			this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel2.HelpContextID = 0;
			this.apiLabel2.Name = "apiLabel2";
			// 
			// txtDateFin
			// 
			resources.ApplyResources(this.txtDateFin, "txtDateFin");
			this.txtDateFin.Name = "txtDateFin";
			this.txtDateFin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateMEC.Properties.Buttons"))))});
			this.txtDateFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateMEC.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// txtDateDebut
			// 
			resources.ApplyResources(this.txtDateDebut, "txtDateDebut");
			this.txtDateDebut.Name = "txtDateDebut";
			this.txtDateDebut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateDebut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEdit1.Properties.Buttons"))))});
			this.txtDateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateEdit1.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// frmStatCAClient
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.txtDateDebut);
			this.Controls.Add(this.txtDateFin);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.apiLabel2);
			this.Controls.Add(this.apiLabel1);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.ChartSpace1);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.grdDataGrid2);
			this.Controls.Add(this.cboClient);
			this.Controls.Add(this.lblLabels11);
			this.Name = "frmStatCAClient";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatCAClient_Load);
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(trendLine2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraCharts.ChartControl ChartSpace1;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiTGrid grdDataGrid2;
    private MozartUC.apiCombo cboClient;
    private MozartUC.apiLabel lblLabels11;
		private MozartUC.apiLabel apiLabel1;
		private MozartUC.apiLabel apiLabel2;
		private DevExpress.XtraEditors.DateEdit txtDateFin;
		private DevExpress.XtraEditors.DateEdit txtDateDebut;
	}
}
