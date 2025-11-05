namespace MozartCS
{
  partial class frmGESemalec
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGESemalec));
      DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
      DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
      DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
      DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
      this.Chart = new DevExpress.XtraCharts.ChartControl();
      this.cmdValider = new MozartUC.apiButton();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.cboclient = new MozartUC.apiCombo();
      this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
      this.lblTotal = new MozartUC.apiLabel();
      this.DateEdit_Fin = new DevExpress.XtraEditors.DateEdit();
      this.DateEdit_Debut = new DevExpress.XtraEditors.DateEdit();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.apiGrid = new MozartUC.apiTGrid();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // Chart
      // 
      resources.ApplyResources(this.Chart, "Chart");
      xyDiagram1.AxisX.Label.Angle = ((int)(resources.GetObject("resource.Angle")));
      xyDiagram1.AxisX.Title.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
      xyDiagram1.AxisX.Title.Text = resources.GetString("resource.Text");
      xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
      xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
      xyDiagram1.AxisY.Title.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
      xyDiagram1.AxisY.Title.Text = resources.GetString("resource.Text1");
      xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(146)))));
      xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
      xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
      xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Linen;
      this.Chart.Diagram = xyDiagram1;
      this.Chart.Legend.Name = "Default Legend";
      this.Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
      this.Chart.Name = "Chart";
      series1.ArgumentDataMember = "jourheure";
      series1.ValueDataMembersSerializable = "NB";
      sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
      regressionLine1.Color = System.Drawing.Color.Purple;
      regressionLine1.LineStyle.Thickness = 2;
      resources.ApplyResources(regressionLine1, "regressionLine1");
      sideBySideBarSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
      series1.View = sideBySideBarSeriesView1;
      this.Chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
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
      this.Frame2.Controls.Add(this.apiLabel1);
      this.Frame2.Controls.Add(this.cboclient);
      this.Frame2.Controls.Add(this.apiSocieteAuto1);
      this.Frame2.Controls.Add(this.lblTotal);
      this.Frame2.Controls.Add(this.DateEdit_Fin);
      this.Frame2.Controls.Add(this.DateEdit_Debut);
      this.Frame2.Controls.Add(this.cmdValider);
      this.Frame2.Controls.Add(this.lblLabels12);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      this.cboclient.NewValues = false;
      // 
      // apiSocieteAuto1
      // 
      this.apiSocieteAuto1.CacheOneSoc = false;
      this.apiSocieteAuto1.IdMenuParent = ((short)(710));
      this.apiSocieteAuto1.ListIndex = ((short)(-1));
      resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
      this.apiSocieteAuto1.Name = "apiSocieteAuto1";
      this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
      // 
      // lblTotal
      // 
      resources.ApplyResources(this.lblTotal, "lblTotal");
      this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblTotal.HelpContextID = 0;
      this.lblTotal.Name = "lblTotal";
      // 
      // DateEdit_Fin
      // 
      resources.ApplyResources(this.DateEdit_Fin, "DateEdit_Fin");
      this.DateEdit_Fin.Name = "DateEdit_Fin";
      this.DateEdit_Fin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.Buttons"))))});
      this.DateEdit_Fin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // DateEdit_Debut
      // 
      resources.ApplyResources(this.DateEdit_Debut, "DateEdit_Debut");
      this.DateEdit_Debut.Name = "DateEdit_Debut";
      this.DateEdit_Debut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.Buttons"))))});
      this.DateEdit_Debut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.CalendarTimeProperties.Buttons"))))});
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
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // frmGESemalec
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.Chart);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdImprimer);
      this.Name = "frmGESemalec";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGESemalec_Load);
      ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private DevExpress.XtraCharts.ChartControl Chart;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private DevExpress.XtraEditors.DateEdit DateEdit_Debut;
    private DevExpress.XtraEditors.DateEdit DateEdit_Fin;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiLabel lblTotal;
    private MozartUC.apiSocieteAuto apiSocieteAuto1;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiCombo cboclient;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
