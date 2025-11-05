namespace MozartCS
{
  partial class frmResultatStat
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultatStat));
      this.Command1 = new MozartUC.apiButton();
      this.Label7 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.MSChart1 = new DevExpress.XtraCharts.ChartControl();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.grdDataGrid2 = new MozartUC.apiTGrid();
      this.Frame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).BeginInit();
      this.SuspendLayout();
      // 
      // Command1
      // 
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "17";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
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
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.Controls.Add(this.Label2);
      this.Frame1.Controls.Add(this.Label1);
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.Label4);
      this.Frame1.Controls.Add(this.Label5);
      this.Frame1.Controls.Add(this.Label6);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // MSChart1
      // 
      this.MSChart1.Legend.Name = "Default Legend";
      resources.ApplyResources(this.MSChart1, "MSChart1");
      this.MSChart1.Name = "MSChart1";
      this.MSChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
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
      // grdDataGrid2
      // 
      this.grdDataGrid2.FilterBar = true;
      resources.ApplyResources(this.grdDataGrid2, "grdDataGrid2");
      this.grdDataGrid2.FooterBar = true;
      this.grdDataGrid2.Name = "grdDataGrid2";
      // 
      // frmResultatStat
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.MSChart1);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.grdDataGrid2);
      this.Name = "frmResultatStat";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmResultatStat_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton Command1;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiGroupBox Frame1;
    private DevExpress.XtraCharts.ChartControl MSChart1;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid grdDataGrid2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
