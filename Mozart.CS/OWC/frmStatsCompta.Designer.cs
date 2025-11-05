namespace MozartCS
{
  partial class frmStatsCompta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatsCompta));
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.Label7 = new MozartUC.apiLabel();
			this.Label3 = new MozartUC.apiLabel();
			this.Label4 = new MozartUC.apiLabel();
			this.Label5 = new MozartUC.apiLabel();
			this.Label6 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.cmdImprimer = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels12 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.txtDateA0 = new DevExpress.XtraEditors.DateEdit();
			this.txtDateA1 = new DevExpress.XtraEditors.DateEdit();
			this.cmdValider = new MozartUC.apiButton();
			this.ChartSpace1 = new DevExpress.XtraCharts.ChartControl();
			this.ApiGrid = new MozartUC.apiTGrid();
			this.Frame3.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			this.SuspendLayout();
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
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.HelpContextID = 0;
			this.Label7.Name = "Label7";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.HelpContextID = 0;
			this.Label4.Name = "Label4";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.HelpContextID = 0;
			this.Label5.Name = "Label5";
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.HelpContextID = 0;
			this.Label6.Name = "Label6";
			// 
			// Frame1
			// 
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.Label7);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
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
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels12
			// 
			resources.ApplyResources(this.lblLabels12, "lblLabels12");
			this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels12.HelpContextID = 0;
			this.lblLabels12.Name = "lblLabels12";
			// 
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame2.Controls.Add(this.txtDateA0);
			this.Frame2.Controls.Add(this.txtDateA1);
			this.Frame2.Controls.Add(this.lblLabels0);
			this.Frame2.Controls.Add(this.lblLabels12);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// txtDateA0
			// 
			resources.ApplyResources(this.txtDateA0, "txtDateA0");
			this.txtDateA0.Name = "txtDateA0";
			this.txtDateA0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateA0.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA0.Properties.Buttons"))))});
			this.txtDateA0.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA0.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// txtDateA1
			// 
			resources.ApplyResources(this.txtDateA1, "txtDateA1");
			this.txtDateA1.Name = "txtDateA1";
			this.txtDateA1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtDateA1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA1.Properties.Buttons"))))});
			this.txtDateA1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA1.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.HelpContextID = 20;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.Tag = "66";
			this.cmdValider.UseVisualStyleBackColor = true;
			this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
			series1.ArgumentDataMember = "NUMMOIS";
			resources.ApplyResources(series1, "series1");
			series1.ValueDataMembersSerializable = "NBFOUFAC";
			sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			series1.View = sideBySideBarSeriesView1;
			this.ChartSpace1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			// 
			// ApiGrid
			// 
			resources.ApplyResources(this.ApiGrid, "ApiGrid");
			this.ApiGrid.CounterColumn = null;
			this.ApiGrid.FilterBar = true;
			this.ApiGrid.FooterBar = true;
			this.ApiGrid.Name = "ApiGrid";
			// 
			// frmStatsCompta
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.ChartSpace1);
			this.Controls.Add(this.ApiGrid);
			this.Name = "frmStatsCompta";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatsCompta_Load);
			this.Frame3.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraCharts.ChartControl ChartSpace1;
    private MozartUC.apiTGrid ApiGrid;
		private DevExpress.XtraEditors.DateEdit txtDateA0;
		private DevExpress.XtraEditors.DateEdit txtDateA1;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
