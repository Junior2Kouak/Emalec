namespace MozartCS
{
  partial class frmStatDelaiPR
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatDelaiPR));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.Chart = new DevExpress.XtraCharts.ChartControl();
      this.Label7 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cboclient = new MozartUC.apiCombo();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.grdDataGrid2 = new MozartUC.apiTGrid();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      this.Frame1.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
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
      // Chart
      // 
      resources.ApplyResources(this.Chart, "Chart");
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Wheat;
      this.Chart.Diagram = xyDiagram1;
      this.Chart.Legend.Name = "Default Legend";
      this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.Chart.Name = "Chart";
      series1.ArgumentDataMember = "duree";
      resources.ApplyResources(series1, "series1");
      series1.ValueDataMembersSerializable = "NB";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      series1.View = sideBySideBarSeriesView1;
      this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
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
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.Label1);
      this.Frame3.Controls.Add(this.Label2);
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cmdDate1);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.cmdDate2);
      this.Frame2.Controls.Add(this.txtDateA1);
      this.Frame2.Controls.Add(this.cboclient);
      this.Frame2.Controls.Add(this.lblLabels12);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.lblLabels1);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // grdDataGrid2
      // 
      resources.ApplyResources(this.grdDataGrid2, "grdDataGrid2");
      this.grdDataGrid2.FilterBar = true;
      this.grdDataGrid2.FooterBar = true;
      this.grdDataGrid2.Name = "grdDataGrid2";
      // 
      // frmStatDelaiPR
      // 
      this.AcceptButton = this.cmdValider;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Chart);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.grdDataGrid2);
      this.Name = "frmStatDelaiPR";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatDelaiPR_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
      this.Frame1.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private DevExpress.XtraCharts.ChartControl Chart;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiCombo cboclient;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid grdDataGrid2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
