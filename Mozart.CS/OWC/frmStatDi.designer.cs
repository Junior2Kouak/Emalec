namespace MozartCS
{
  partial class frmStatDi
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatDi));
      this.cboCteAna = new System.Windows.Forms.ComboBox();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.ChartSpace1 = new DevExpress.XtraCharts.ChartControl();
      this.lblTitre = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboCteAna
      // 
      resources.ApplyResources(this.cboCteAna, "cboCteAna");
      this.cboCteAna.Name = "cboCteAna";
      this.cboCteAna.SelectedIndexChanged += new System.EventHandler(this.cboCteAna_SelectedIndexChanged);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // ChartSpace1
      // 
      resources.ApplyResources(this.ChartSpace1, "ChartSpace1");
      this.ChartSpace1.Legend.Name = "Default Legend";
      this.ChartSpace1.Name = "ChartSpace1";
      this.ChartSpace1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.lblTitre);
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.BackColor = System.Drawing.Color.Wheat;
      this.lblPeriode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // frmStatDi
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboCteAna);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.ChartSpace1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblPeriode);
      this.Name = "frmStatDi";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatDi_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboCteAna;
    private MozartUC.apiTGrid apiTGrid1;
    private DevExpress.XtraCharts.ChartControl ChartSpace1;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lblPeriode;

  }
}
