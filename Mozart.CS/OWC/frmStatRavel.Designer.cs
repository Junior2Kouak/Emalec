namespace MozartCS
{
  partial class frmStatRavel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatRavel));
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.cmdSTT = new MozartUC.apiButton();
			this.Chartspace1 = new DevExpress.XtraCharts.ChartControl();
			this.CmdDetail = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.Grid = new MozartUC.apiTGrid();
			this.Label1 = new MozartUC.apiLabel();
			((System.ComponentModel.ISupportInitialize)(this.Chartspace1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdSTT
			// 
			resources.ApplyResources(this.cmdSTT, "cmdSTT");
			this.cmdSTT.HelpContextID = 0;
			this.cmdSTT.Name = "cmdSTT";
			this.cmdSTT.UseVisualStyleBackColor = true;
			this.cmdSTT.Click += new System.EventHandler(this.cmdSTT_Click);
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
			series1.LegendName = "Default Legend";
			resources.ApplyResources(series1, "series1");
			series1.ValueDataMembersSerializable = "valeur";
			sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			series1.View = sideBySideBarSeriesView1;
			this.Chartspace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			chartTitle1.TextColor = System.Drawing.Color.Black;
			this.Chartspace1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// CmdDetail
			// 
			resources.ApplyResources(this.CmdDetail, "CmdDetail");
			this.CmdDetail.HelpContextID = 0;
			this.CmdDetail.Name = "CmdDetail";
			this.CmdDetail.UseVisualStyleBackColor = true;
			this.CmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
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
			// Grid
			// 
			resources.ApplyResources(this.Grid, "Grid");
			this.Grid.CounterColumn = null;
			this.Grid.FilterBar = true;
			this.Grid.FooterBar = true;
			this.Grid.Name = "Grid";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmStatRavel
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdSTT);
			this.Controls.Add(this.Chartspace1);
			this.Controls.Add(this.CmdDetail);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Grid);
			this.Controls.Add(this.Label1);
			this.Name = "frmStatRavel";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatRavel_Load);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chartspace1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSTT;
    private DevExpress.XtraCharts.ChartControl Chartspace1;
    private MozartUC.apiButton CmdDetail;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid Grid;
    private MozartUC.apiLabel Label1;

  }
}
