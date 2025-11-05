namespace MozartCS
{
  partial class frmStatFournCAByAn
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatFournCAByAn));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      this.cmdImprimer = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Label7 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Chart = new DevExpress.XtraCharts.ChartControl();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.Frame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      this.SuspendLayout();
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.Label1);
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Chart
      // 
      resources.ApplyResources(this.Chart, "Chart");
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.Label.TextPattern = "{V} €";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Wheat;
      xyDiagram1.DefaultPane.Title.Alignment = System.Drawing.StringAlignment.Center;
      xyDiagram1.DefaultPane.Title.Text = resources.GetString("resource.Text");
      this.Chart.Diagram = xyDiagram1;
      this.Chart.Legend.Name = "Default Legend";
      this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.Chart.Name = "Chart";
      series1.ArgumentDataMember = "Annee";
      resources.ApplyResources(series1, "series1");
      series1.ValueDataMembersSerializable = "TotalHT";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      series1.View = sideBySideBarSeriesView1;
      this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // frmStatFournCAByAn
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Chart);
      this.Controls.Add(this.Label3);
      this.Name = "frmStatFournCAByAn";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatFournCAByAn_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;
    private DevExpress.XtraCharts.ChartControl Chart;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label3;

  }
}
