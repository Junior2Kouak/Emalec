namespace MozartCS
{
  partial class frmStatDepannage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatDepannage));
      this.Label7 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label8 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdStatClient = new MozartUC.apiButton();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.MSChart1 = new DevExpress.XtraCharts.ChartControl();
      this.ApiGrid2 = new MozartUC.apiTGrid();
      this.ApiGrid3 = new MozartUC.apiTGrid();
      this.Frame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).BeginInit();
      this.SuspendLayout();
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
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label6
      // 
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // Label8
      // 
      this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.HelpContextID = 0;
      this.Label8.Name = "Label8";
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
      this.Frame1.Controls.Add(this.Label8);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdImprimer
      // 
      this.cmdImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdStatClient
      // 
      this.cmdStatClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdStatClient, "cmdStatClient");
      this.cmdStatClient.HelpContextID = 0;
      this.cmdStatClient.Name = "cmdStatClient";
      this.cmdStatClient.Tag = "35";
      this.cmdStatClient.UseVisualStyleBackColor = false;
      this.cmdStatClient.Click += new System.EventHandler(this.cmdStatClient_Click);
      // 
      // ApiGrid
      // 
      this.ApiGrid.FilterBar = true;
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGrid_SelectionChanged);
      // 
      // MSChart1
      // 
      resources.ApplyResources(this.MSChart1, "MSChart1");
      this.MSChart1.Legend.Name = "Default Legend";
      this.MSChart1.Name = "MSChart1";
      this.MSChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
      // 
      // ApiGrid2
      // 
      resources.ApplyResources(this.ApiGrid2, "ApiGrid2");
      this.ApiGrid2.FilterBar = true;
      this.ApiGrid2.FooterBar = true;
      this.ApiGrid2.Name = "ApiGrid2";
      // 
      // ApiGrid3
      // 
      resources.ApplyResources(this.ApiGrid3, "ApiGrid3");
      this.ApiGrid3.FilterBar = true;
      this.ApiGrid3.FooterBar = true;
      this.ApiGrid3.Name = "ApiGrid3";
      // 
      // frmStatDepannage
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdStatClient);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.MSChart1);
      this.Controls.Add(this.ApiGrid2);
      this.Controls.Add(this.ApiGrid3);
      this.Name = "frmStatDepannage";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatDepannage_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdStatClient;
    private MozartUC.apiTGrid ApiGrid;
    private DevExpress.XtraCharts.ChartControl MSChart1;
    private MozartUC.apiTGrid ApiGrid2;
    private MozartUC.apiTGrid ApiGrid3;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
