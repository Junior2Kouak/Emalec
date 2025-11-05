namespace MozartCS
{
  partial class frmStockStatsTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockStatsTech));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      this.cmdDetails = new MozartUC.apiButton();
      this.txtSolde = new MozartUC.apiTextBox();
      this.txtTotDebit = new MozartUC.apiTextBox();
      this.txtTotCredit = new MozartUC.apiTextBox();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdDate1 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label8 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Chart = new DevExpress.XtraCharts.ChartControl();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdDetails
      // 
      this.cmdDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdDetails, "cmdDetails");
      this.cmdDetails.HelpContextID = 0;
      this.cmdDetails.Name = "cmdDetails";
      this.cmdDetails.Tag = "19";
      this.cmdDetails.UseVisualStyleBackColor = false;
      this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
      // 
      // txtSolde
      // 
      resources.ApplyResources(this.txtSolde, "txtSolde");
      this.txtSolde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtSolde.HelpContextID = 0;
      this.txtSolde.Name = "txtSolde";
      // 
      // txtTotDebit
      // 
      resources.ApplyResources(this.txtTotDebit, "txtTotDebit");
      this.txtTotDebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtTotDebit.HelpContextID = 0;
      this.txtTotDebit.Name = "txtTotDebit";
      // 
      // txtTotCredit
      // 
      resources.ApplyResources(this.txtTotCredit, "txtTotCredit");
      this.txtTotCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtTotCredit.HelpContextID = 0;
      this.txtTotCredit.Name = "txtTotCredit";
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      resources.ApplyResources(this.cmdDate2, "cmdDate2");
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Tag = "5";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(131)))));
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label8
      // 
      this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label8.HelpContextID = 0;
      this.Label8.Name = "Label8";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.cmdDate1);
      this.Frame1.Controls.Add(this.txtDateA0);
      this.Frame1.Controls.Add(this.cmdDate2);
      this.Frame1.Controls.Add(this.txtDateA1);
      this.Frame1.Controls.Add(this.cmdValider);
      this.Frame1.Controls.Add(this.lblLabels12);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.Label8);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // Chart
      // 
      resources.ApplyResources(this.Chart, "Chart");
      xyDiagram1.AxisX.Reverse = true;
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.Label.TextPattern = "{V:## ### ##0}";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Wheat;
      xyDiagram1.Rotated = true;
      this.Chart.Diagram = xyDiagram1;
      this.Chart.Legend.Name = "Default Legend";
      this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.Chart.Name = "Chart";
      series1.ArgumentDataMember = "VPERNOM";
      resources.ApplyResources(series1, "series1");
      series1.ValueDataMembersSerializable = "RESTE";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      series1.View = sideBySideBarSeriesView1;
      this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
      // 
      // cmdImprimer
      // 
      this.cmdImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = false;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = false;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.lblLabels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(131)))));
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.lblLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(131)))));
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // frmStockStatsTech
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDetails);
      this.Controls.Add(this.txtSolde);
      this.Controls.Add(this.txtTotDebit);
      this.Controls.Add(this.txtTotCredit);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Chart);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.lblLabels2);
      this.Controls.Add(this.lblLabels1);
      this.Name = "frmStockStatsTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockStatsTech_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDetails;
    private MozartUC.apiTextBox txtSolde;
    private MozartUC.apiTextBox txtTotDebit;
    private MozartUC.apiTextBox txtTotCredit;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGrid;
    private DevExpress.XtraCharts.ChartControl Chart;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
