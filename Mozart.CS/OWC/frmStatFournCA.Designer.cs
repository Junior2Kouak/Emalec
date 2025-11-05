namespace MozartCS
{
  partial class frmStatFournCA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatFournCA));
			DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			this.cmdValider = new MozartUC.apiButton();
			this.apiGrid = new MozartUC.apiTGrid();
			this.CmdFacFourAn = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdImprimer = new MozartUC.apiButton();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.lblLabels12 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.Chart = new DevExpress.XtraCharts.ChartControl();
			this.apiTGrid2 = new MozartUC.apiTGrid();
			this.apiTGrid3 = new MozartUC.apiTGrid();
			this.Label2 = new MozartUC.apiLabel();
			this.Label63 = new MozartUC.apiLabel();
			this.Label62 = new MozartUC.apiLabel();
			this.Label4 = new MozartUC.apiLabel();
			this.Label3 = new MozartUC.apiLabel();
			this.Label60 = new MozartUC.apiLabel();
			this.Label7 = new MozartUC.apiLabel();
			this.Label65 = new MozartUC.apiLabel();
			this.Label64 = new MozartUC.apiLabel();
			this.LabelDate = new MozartUC.apiLabel();
			this.Label61 = new MozartUC.apiLabel();
			this.txtDateA0 = new DevExpress.XtraEditors.DateEdit();
			this.txtDateA1 = new DevExpress.XtraEditors.DateEdit();
			this.Frame2.SuspendLayout();
			this.Frame3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
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
			// apiGrid
			// 
			this.apiGrid.CounterColumn = null;
			this.apiGrid.FilterBar = true;
			this.apiGrid.FooterBar = true;
			resources.ApplyResources(this.apiGrid, "apiGrid");
			this.apiGrid.Name = "apiGrid";
			this.apiGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiGrid_SelectionChanged);
			// 
			// CmdFacFourAn
			// 
			resources.ApplyResources(this.CmdFacFourAn, "CmdFacFourAn");
			this.CmdFacFourAn.HelpContextID = 0;
			this.CmdFacFourAn.Name = "CmdFacFourAn";
			this.CmdFacFourAn.Tag = "22";
			this.CmdFacFourAn.UseVisualStyleBackColor = true;
			this.CmdFacFourAn.Click += new System.EventHandler(this.CmdFacFourAn_Click);
			// 
			// cmdQuitter
			// 
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
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
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = false;
			this.apiSocieteAuto1.IdMenuParent = ((short)(415));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// lblLabels12
			// 
			resources.ApplyResources(this.lblLabels12, "lblLabels12");
			this.lblLabels12.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels12.HelpContextID = 0;
			this.lblLabels12.Name = "lblLabels12";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.Color.Wheat;
			this.Frame2.Controls.Add(this.txtDateA0);
			this.Frame2.Controls.Add(this.txtDateA1);
			this.Frame2.Controls.Add(this.apiSocieteAuto1);
			this.Frame2.Controls.Add(this.lblLabels12);
			this.Frame2.Controls.Add(this.lblLabels0);
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame3.Controls.Add(this.Label1);
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			resources.ApplyResources(this.Frame3, "Frame3");
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// Chart
			// 
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram2.DefaultPane.BackColor = System.Drawing.Color.Wheat;
			this.Chart.Diagram = xyDiagram2;
			this.Chart.Legend.Name = "Default Legend";
			this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
			resources.ApplyResources(this.Chart, "Chart");
			this.Chart.Name = "Chart";
			series2.ArgumentDataMember = "moisannee";
			resources.ApplyResources(series2, "series2");
			series2.ValueDataMembersSerializable = "TotalHT";
			sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
			series2.View = sideBySideBarSeriesView2;
			this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			// 
			// apiTGrid2
			// 
			this.apiTGrid2.CounterColumn = null;
			this.apiTGrid2.FilterBar = true;
			this.apiTGrid2.FooterBar = true;
			resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
			this.apiTGrid2.Name = "apiTGrid2";
			// 
			// apiTGrid3
			// 
			this.apiTGrid3.CounterColumn = null;
			this.apiTGrid3.FilterBar = true;
			this.apiTGrid3.FooterBar = true;
			resources.ApplyResources(this.apiTGrid3, "apiTGrid3");
			this.apiTGrid3.Name = "apiTGrid3";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BackColor = System.Drawing.Color.Wheat;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// Label63
			// 
			this.Label63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label63, "Label63");
			this.Label63.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label63.HelpContextID = 0;
			this.Label63.Name = "Label63";
			// 
			// Label62
			// 
			this.Label62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label62, "Label62");
			this.Label62.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label62.HelpContextID = 0;
			this.Label62.Name = "Label62";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.HelpContextID = 0;
			this.Label4.Name = "Label4";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
			// 
			// Label60
			// 
			this.Label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label60, "Label60");
			this.Label60.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label60.HelpContextID = 0;
			this.Label60.Name = "Label60";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.HelpContextID = 0;
			this.Label7.Name = "Label7";
			// 
			// Label65
			// 
			this.Label65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label65, "Label65");
			this.Label65.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label65.HelpContextID = 0;
			this.Label65.Name = "Label65";
			// 
			// Label64
			// 
			this.Label64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label64, "Label64");
			this.Label64.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label64.HelpContextID = 0;
			this.Label64.Name = "Label64";
			// 
			// LabelDate
			// 
			this.LabelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.LabelDate, "LabelDate");
			this.LabelDate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelDate.HelpContextID = 0;
			this.LabelDate.Name = "LabelDate";
			// 
			// Label61
			// 
			this.Label61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Label61, "Label61");
			this.Label61.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label61.HelpContextID = 0;
			this.Label61.Name = "Label61";
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
			// frmStatFournCA
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.apiGrid);
			this.Controls.Add(this.CmdFacFourAn);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Chart);
			this.Controls.Add(this.apiTGrid2);
			this.Controls.Add(this.apiTGrid3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label63);
			this.Controls.Add(this.Label62);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label60);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label65);
			this.Controls.Add(this.Label64);
			this.Controls.Add(this.LabelDate);
			this.Controls.Add(this.Label61);
			this.Name = "frmStatFournCA";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatFournCA_Load);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Frame3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateA1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton CmdFacFourAn;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiSocieteAuto apiSocieteAuto1;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame3;
    private DevExpress.XtraCharts.ChartControl Chart;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiTGrid apiTGrid3;
    private MozartUC.apiLabel Label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label63;
    private MozartUC.apiLabel Label62;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label60;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label65;
    private MozartUC.apiLabel Label64;
    private MozartUC.apiLabel LabelDate;
    private MozartUC.apiLabel Label61;
		private DevExpress.XtraEditors.DateEdit txtDateA0;
		private DevExpress.XtraEditors.DateEdit txtDateA1;
	}
}
