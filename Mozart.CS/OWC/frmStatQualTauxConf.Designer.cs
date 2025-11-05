namespace MozartCS
{
  partial class frmStatQualTauxConf
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatQualTauxConf));
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
			this.lblDefStat = new MozartUC.apiLabel();
			this.Frame5 = new MozartUC.apiGroupBox();
			this.lblTaux = new MozartUC.apiLabel();
			this.ChartSpace1 = new DevExpress.XtraCharts.ChartControl();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdImprimer = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.Label7 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.Frame5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDefStat
			// 
			this.lblDefStat.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.lblDefStat, "lblDefStat");
			this.lblDefStat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDefStat.HelpContextID = 0;
			this.lblDefStat.Name = "lblDefStat";
			// 
			// Frame5
			// 
			resources.ApplyResources(this.Frame5, "Frame5");
			this.Frame5.BackColor = System.Drawing.SystemColors.Control;
			this.Frame5.Controls.Add(this.lblDefStat);
			this.Frame5.FrameColor = System.Drawing.Color.Empty;
			this.Frame5.HelpContextID = 0;
			this.Frame5.Name = "Frame5";
			this.Frame5.TabStop = false;
			// 
			// lblTaux
			// 
			this.lblTaux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.lblTaux, "lblTaux");
			this.lblTaux.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTaux.HelpContextID = 0;
			this.lblTaux.Name = "lblTaux";
			// 
			// ChartSpace1
			// 
			resources.ApplyResources(this.ChartSpace1, "ChartSpace1");
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
			this.ChartSpace1.Diagram = xyDiagram1;
			this.ChartSpace1.Legend.Name = "Default Legend";
			this.ChartSpace1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
			this.ChartSpace1.Name = "ChartSpace1";
			series1.ArgumentDataMember = "periode";
			resources.ApplyResources(series1, "series1");
			series1.ValueDataMembersSerializable = "nb";
			sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			regressionLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			regressionLine1.LineStyle.Thickness = 3;
			resources.ApplyResources(regressionLine1, "regressionLine1");
			sideBySideBarSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
			series1.View = sideBySideBarSeriesView1;
			this.ChartSpace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
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
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
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
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// frmStatQualTauxConf
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame5);
			this.Controls.Add(this.ChartSpace1);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Frame1);
			this.Name = "frmStatQualTauxConf";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatQualTauxConf_Load);
			this.Frame5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiLabel lblDefStat;
    private MozartUC.apiGroupBox Frame5;
    private MozartUC.apiLabel lblTaux;
    //private MozartUC.apiGroupBox Frame4;
    //private MozartUC.apiTGrid ApiGrid;
    private DevExpress.XtraCharts.ChartControl ChartSpace1;
    private MozartUC.apiLabel Label1;
    //private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;

  }
}
