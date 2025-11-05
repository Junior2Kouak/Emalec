namespace MozartCS
{
  partial class frmInventaireEquipementClientStatByItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventaireEquipementClientStatByItem));
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.cmdFermer = new MozartUC.apiButton();
            this.apiTGrid1 = new MozartUC.apiTGrid();
            this.LblTitre = new MozartUC.apiLabel();
            this.apiTGrid2 = new MozartUC.apiTGrid();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.BtnExportXls = new MozartUC.apiButton();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFermer
            // 
            resources.ApplyResources(this.cmdFermer, "cmdFermer");
            this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFermer.HelpContextID = 0;
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Tag = "15";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // apiTGrid1
            // 
            resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
            this.apiTGrid1.FilterBar = true;
            this.apiTGrid1.FooterBar = true;
            this.apiTGrid1.Name = "apiTGrid1";
            this.apiTGrid1.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid1_SelectionChanged);
            // 
            // LblTitre
            // 
            resources.ApplyResources(this.LblTitre, "LblTitre");
            this.LblTitre.BackColor = System.Drawing.Color.Wheat;
            this.LblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitre.HelpContextID = 0;
            this.LblTitre.Name = "LblTitre";
            // 
            // apiTGrid2
            // 
            resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
            this.apiTGrid2.FilterBar = true;
            this.apiTGrid2.FooterBar = true;
            this.apiTGrid2.Name = "apiTGrid2";
            // 
            // chartControl1
            // 
            resources.ApplyResources(this.chartControl1, "chartControl1");
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Name = "chartControl1";
            series3.ArgumentDataMember = "OVALUE";
            resources.ApplyResources(series3, "series3");
            series3.ValueDataMembersSerializable = "NB";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            chartTitle3.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // BtnExportXls
            // 
            resources.ApplyResources(this.BtnExportXls, "BtnExportXls");
            this.BtnExportXls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExportXls.HelpContextID = 0;
            this.BtnExportXls.Name = "BtnExportXls";
            this.BtnExportXls.Tag = "15";
            this.BtnExportXls.UseVisualStyleBackColor = true;
            this.BtnExportXls.Click += new System.EventHandler(this.BtnExportXls_Click);
            // 
            // frmInventaireEquipementClientStatByItem
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.BtnExportXls);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.apiTGrid2);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.apiTGrid1);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmInventaireEquipementClientStatByItem";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventaireEquipementClientStatByItem_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel LblTitre;
        private MozartUC.apiTGrid apiTGrid2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private MozartUC.apiButton BtnExportXls;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}
