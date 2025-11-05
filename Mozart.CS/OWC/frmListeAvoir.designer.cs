namespace MozartCS
{
  partial class frmListeAvoir
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeAvoir));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
      this.cmdRavel = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.Chartspace1 = new DevExpress.XtraCharts.ChartControl();
      this.Label1 = new MozartUC.apiLabel();
      ((System.ComponentModel.ISupportInitialize)(this.Chartspace1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdRavel
      // 
      resources.ApplyResources(this.cmdRavel, "cmdRavel");
      this.cmdRavel.HelpContextID = 0;
      this.cmdRavel.Name = "cmdRavel";
      this.cmdRavel.UseVisualStyleBackColor = true;
      this.cmdRavel.Click += new System.EventHandler(this.cmdRavel_Click);
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
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      // 
      // Chartspace1
      // 
      resources.ApplyResources(this.Chartspace1, "Chartspace1");
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.Chartspace1.Diagram = xyDiagram1;
      this.Chartspace1.Legend.Name = "Default Legend";
      this.Chartspace1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.Chartspace1.Name = "Chartspace1";
      series1.ArgumentDataMember = "nom";
      resources.ApplyResources(series1, "series1");
      series1.ValueDataMembersSerializable = "valeur";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      series1.View = sideBySideBarSeriesView1;
      this.Chartspace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
	  chartTitle1.TextColor = System.Drawing.Color.Black;
      resources.ApplyResources(chartTitle1, "chartTitle1");
      this.Chartspace1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeAvoir
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdRavel);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.Chartspace1);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeAvoir";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeAvoir_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Chartspace1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdRavel;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apigrid;
    private DevExpress.XtraCharts.ChartControl Chartspace1;
    private MozartUC.apiLabel Label1;

  }
}
