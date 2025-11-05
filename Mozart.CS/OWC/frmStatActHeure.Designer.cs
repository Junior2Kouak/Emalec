namespace MozartCS
{
  partial class frmStatActHeure
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatActHeure));
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			this.Chart = new DevExpress.XtraCharts.ChartControl();
			this.cmdValider = new MozartUC.apiButton();
			this.lblLabels12 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdImprimer = new MozartUC.apiButton();
			this.Label6 = new MozartUC.apiLabel();
			this.Label5 = new MozartUC.apiLabel();
			this.Label4 = new MozartUC.apiLabel();
			this.Label3 = new MozartUC.apiLabel();
			this.Label7 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.txtDateA0 = new DevExpress.XtraEditors.DateEdit();
			this.txtDateA1 = new DevExpress.XtraEditors.DateEdit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// Chart
			// 
			resources.ApplyResources(this.Chart, "Chart");
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.Label.TextPattern = "{V:## ### ##0}";
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Wheat;
			this.Chart.Diagram = xyDiagram1;
			this.Chart.Legend.Name = "Default Legend";
			this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
			this.Chart.Name = "Chart";
			series1.ArgumentDataMember = "heure";
			resources.ApplyResources(series1, "series1");
			series1.ValueDataMembersSerializable = "valeur";
			sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			series1.View = sideBySideBarSeriesView1;
			this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			chartTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
			resources.ApplyResources(chartTitle1, "chartTitle1");
			chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			this.Chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
			// 
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValider.HelpContextID = 20;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.Tag = "66";
			this.cmdValider.UseVisualStyleBackColor = true;
			this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame2.Controls.Add(this.txtDateA0);
			this.Frame2.Controls.Add(this.txtDateA1);
			this.Frame2.Controls.Add(this.cmdValider);
			this.Frame2.Controls.Add(this.lblLabels12);
			this.Frame2.Controls.Add(this.lblLabels0);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
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
			// Label6
			// 
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.HelpContextID = 0;
			this.Label6.Name = "Label6";
			// 
			// Label5
			// 
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.HelpContextID = 0;
			this.Label5.Name = "Label5";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.HelpContextID = 0;
			this.Label4.Name = "Label4";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
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
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label7);
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// txtDateA0
			// 
			resources.ApplyResources(this.txtDateA0, "txtDateA0");
			this.txtDateA0.Name = "txtDateA0";
			this.txtDateA0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateA0.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.Buttons"))))});
			this.txtDateA0.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// txtDateA1
			// 
			resources.ApplyResources(this.txtDateA1, "txtDateA1");
			this.txtDateA1.Name = "txtDateA1";
			this.txtDateA1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateA1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.Buttons"))))});
			this.txtDateA1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// frmStatActHeure
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Chart);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.Frame1);
			this.Name = "frmStatActHeure";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatActHeure_Load);
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraCharts.ChartControl Chart;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;
		private DevExpress.XtraEditors.DateEdit txtDateA0;
		private DevExpress.XtraEditors.DateEdit txtDateA1;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
