namespace MozartCS
{
  partial class frmStatAstr
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatAstr));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Label4 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.MSChart1 = new DevExpress.XtraCharts.ChartControl();
      this.grdDataGrid2 = new MozartUC.apiTGrid();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame3.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
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
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.Label1);
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
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
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label4);
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.Label5);
      this.Frame1.Controls.Add(this.Label6);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
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
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
      this.txtDateA1.Tag = "1";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate2, "cmdDate2");
      this.cmdDate2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Tag = "1";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
      this.txtDateA0.Tag = "0";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "0";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
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
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.txtDateA1);
      this.Frame2.Controls.Add(this.cmdDate2);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.cmdDate1);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.lblLabels12);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
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
      // MSChart1
      // 
      resources.ApplyResources(this.MSChart1, "MSChart1");
      this.MSChart1.Legend.Name = "Default Legend";
      this.MSChart1.Name = "MSChart1";
      this.MSChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
      // 
      // grdDataGrid2
      // 
      resources.ApplyResources(this.grdDataGrid2, "grdDataGrid2");
      this.grdDataGrid2.FilterBar = true;
      this.grdDataGrid2.FooterBar = true;
      this.grdDataGrid2.Name = "grdDataGrid2";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.grdDataGrid2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.MSChart1, 1, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmStatAstr
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdValider);
      this.Name = "frmStatAstr";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatAstr_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.MSChart1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdValider;
    private DevExpress.XtraCharts.ChartControl MSChart1;
    private MozartUC.apiTGrid grdDataGrid2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
