namespace MozartCS
{
  partial class frmStatAppreciation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatAppreciation));
      DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.RegressionLine regressionLine2 = new DevExpress.XtraCharts.RegressionLine();
      DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
      DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
      DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cboclient = new MozartUC.apiCombo();
      this.GraphFact = new DevExpress.XtraCharts.ChartControl();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      ((System.ComponentModel.ISupportInitialize)(this.GraphFact)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
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
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      this.cboclient.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboclient_TxtChanged);
      // 
      // GraphFact
      // 
      resources.ApplyResources(this.GraphFact, "GraphFact");
      xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram2.AxisY.NumericScaleOptions.AutoGrid = false;
      xyDiagram2.AxisY.NumericScaleOptions.GridSpacing = 5D;
      xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.GraphFact.Diagram = xyDiagram2;
      this.GraphFact.Legend.AlignmentVertical = ((DevExpress.XtraCharts.LegendAlignmentVertical)(resources.GetObject("GraphFact.Legend.AlignmentVertical")));
      this.GraphFact.Legend.Name = "Default Legend";
      this.GraphFact.Name = "GraphFact";
      series3.ArgumentDataMember = "cat";
      sideBySideBarSeriesLabel2.BackColor = System.Drawing.Color.Transparent;
      sideBySideBarSeriesLabel2.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
      resources.ApplyResources(sideBySideBarSeriesLabel2, "sideBySideBarSeriesLabel2");
      sideBySideBarSeriesLabel2.LineLength = 3;
      sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.False;
      sideBySideBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
      sideBySideBarSeriesLabel2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(55)))), ((int)(((byte)(52)))));
      series3.Label = sideBySideBarSeriesLabel2;
      series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
      resources.ApplyResources(series3, "series3");
      series3.ValueDataMembersSerializable = "val";
      sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      regressionLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
      resources.ApplyResources(regressionLine2, "regressionLine2");
      regressionLine2.LineStyle.Thickness = 3;
      regressionLine2.ShowInLegend = true;
      sideBySideBarSeriesView2.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine2});
      series3.View = sideBySideBarSeriesView2;
      series4.ArgumentDataMember = "cat";
      pointSeriesLabel2.TextPattern = "Moyenne ({V}%)";
      series4.Label = pointSeriesLabel2;
      resources.ApplyResources(series4, "series4");
      series4.ValueDataMembersSerializable = "moy";
      series4.View = lineSeriesView2;
      this.GraphFact.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
	  chartTitle2.TextColor = System.Drawing.Color.Black;
      resources.ApplyResources(chartTitle2, "chartTitle2");
      this.GraphFact.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmStatAppreciation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cboclient);
      this.Controls.Add(this.GraphFact);
      this.Controls.Add(this.lblLabels11);
      this.Controls.Add(this.Label1);
      this.Name = "frmStatAppreciation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatAppreciation_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GraphFact)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiCombo cboclient;
    private DevExpress.XtraCharts.ChartControl GraphFact;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel Label1;

  }
}
