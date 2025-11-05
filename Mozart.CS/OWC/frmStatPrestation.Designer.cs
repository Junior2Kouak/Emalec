namespace MozartCS
{
  partial class frmStatPrestation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatPrestation));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
      DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.RegressionLine regressionLine2 = new DevExpress.XtraCharts.RegressionLine();
      this.cboChoix = new MozartUC.apiCombo();
      this.cboCli = new MozartUC.apiCombo();
      this.GraphNb = new DevExpress.XtraCharts.ChartControl();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.GraphFact = new DevExpress.XtraCharts.ChartControl();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.apiGrid = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.lbltitre = new MozartUC.apiLabel();
      this.lblChoix = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.GraphNb)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GraphFact)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine2)).BeginInit();
      this.Frame1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboChoix
      // 
      resources.ApplyResources(this.cboChoix, "cboChoix");
      this.cboChoix.Name = "cboChoix";
      this.cboChoix.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboChoix_TxtChanged);
      // 
      // cboCli
      // 
      resources.ApplyResources(this.cboCli, "cboCli");
      this.cboCli.Name = "cboCli";
      this.cboCli.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboCli_TxtChanged);
      // 
      // GraphNb
      // 
      resources.ApplyResources(this.GraphNb, "GraphNb");
      xyDiagram1.AxisX.Reverse = true;
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.GraphNb.Diagram = xyDiagram1;
      this.GraphNb.Legend.Name = "Default Legend";
      this.GraphNb.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.GraphNb.Name = "GraphNb";
      series1.ArgumentDataMember = "periode";
      resources.ApplyResources(series1, "series1");
      series1.ValueDataMembersSerializable = "Cpt";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      regressionLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      regressionLine1.LineStyle.Thickness = 3;
      resources.ApplyResources(regressionLine1, "regressionLine1");
      sideBySideBarSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
      series1.View = sideBySideBarSeriesView1;
      this.GraphNb.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.GraphNb);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // GraphFact
      // 
      resources.ApplyResources(this.GraphFact, "GraphFact");
      xyDiagram2.AxisX.Reverse = true;
      xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.GraphFact.Diagram = xyDiagram2;
      this.GraphFact.Legend.Name = "Default Legend";
      this.GraphFact.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.GraphFact.Name = "GraphFact";
      series2.ArgumentDataMember = "periode";
      resources.ApplyResources(series2, "series2");
      series2.ValueDataMembersSerializable = "Montant";
      sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      regressionLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      regressionLine2.LineStyle.Thickness = 3;
      resources.ApplyResources(regressionLine2, "regressionLine2");
      sideBySideBarSeriesView2.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine2});
      series2.View = sideBySideBarSeriesView2;
      this.GraphFact.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.GraphFact);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
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
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lbltitre
      // 
      resources.ApplyResources(this.lbltitre, "lbltitre");
      this.lbltitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lbltitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbltitre.HelpContextID = 0;
      this.lbltitre.Name = "lbltitre";
      this.lbltitre.Tag = "Tableau analytique mensuel des heures pour :";
      // 
      // lblChoix
      // 
      resources.ApplyResources(this.lblChoix, "lblChoix");
      this.lblChoix.BackColor = System.Drawing.Color.Wheat;
      this.lblChoix.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblChoix.HelpContextID = 0;
      this.lblChoix.Name = "lblChoix";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmStatPrestation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cboChoix);
      this.Controls.Add(this.cboCli);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lbltitre);
      this.Controls.Add(this.lblChoix);
      this.Name = "frmStatPrestation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatPrestation_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GraphNb)).EndInit();
      this.Frame2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GraphFact)).EndInit();
      this.Frame1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCombo cboChoix;
    private MozartUC.apiCombo cboCli;
    private DevExpress.XtraCharts.ChartControl GraphNb;
    private MozartUC.apiGroupBox Frame2;
    private DevExpress.XtraCharts.ChartControl GraphFact;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lbltitre;
    private MozartUC.apiLabel lblChoix;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
