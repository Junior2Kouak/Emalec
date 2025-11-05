namespace MozartCS
{
  partial class frmStatPreparation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatPreparation));
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.Label7 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
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
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate2, "cmdDate2");
      this.cmdDate2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Tag = "5";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate_Click);
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
      this.Frame2.Controls.Add(this.cmdValider);
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
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
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // frmStatPreparation
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Label7);
      this.Name = "frmStatPreparation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatPreparation_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid apiTGrid;
    private System.Windows.Forms.DateTimePicker Calendar1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label7;

  }
}
