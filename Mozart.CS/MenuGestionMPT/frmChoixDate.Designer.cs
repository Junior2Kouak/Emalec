namespace MozartCS
{
  partial class frmChoixDate
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixDate));
      this.cboClient = new MozartUC.apiCombo();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.chkSite = new MozartUC.apiCheckBox();
      this.optInfo1 = new System.Windows.Forms.RadioButton();
      this.optInfo0 = new System.Windows.Forms.RadioButton();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.optInter3 = new System.Windows.Forms.RadioButton();
      this.optInter2 = new System.Windows.Forms.RadioButton();
      this.optInter0 = new System.Windows.Forms.RadioButton();
      this.optInter1 = new System.Windows.Forms.RadioButton();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels19 = new MozartUC.apiLabel();
      this.lblLabels25 = new MozartUC.apiLabel();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame7.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboClient
      // 
      resources.ApplyResources(this.cboClient, "cboClient");
      this.cboClient.Name = "cboClient";
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
      // chkSite
      // 
      this.chkSite.BackColor = System.Drawing.Color.Wheat;
      this.chkSite.HelpContextID = 0;
      resources.ApplyResources(this.chkSite, "chkSite");
      this.chkSite.Name = "chkSite";
      this.chkSite.UseVisualStyleBackColor = false;
      // 
      // optInfo1
      // 
      this.optInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optInfo1, "optInfo1");
      this.optInfo1.Name = "optInfo1";
      this.optInfo1.UseVisualStyleBackColor = false;
      // 
      // optInfo0
      // 
      this.optInfo0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInfo0.Checked = true;
      resources.ApplyResources(this.optInfo0, "optInfo0");
      this.optInfo0.Name = "optInfo0";
      this.optInfo0.TabStop = true;
      this.optInfo0.UseVisualStyleBackColor = false;
      // 
      // lblLabels4
      // 
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // lblLabels3
      // 
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.optInfo1);
      this.Frame2.Controls.Add(this.optInfo0);
      this.Frame2.Controls.Add(this.lblLabels4);
      this.Frame2.Controls.Add(this.lblLabels3);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate2, "cmdDate2");
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Tag = "5";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // lblLabels0
      // 
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels12
      // 
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.txtDateA1);
      this.Frame1.Controls.Add(this.cmdDate2);
      this.Frame1.Controls.Add(this.txtDateA0);
      this.Frame1.Controls.Add(this.cmdDate1);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Controls.Add(this.lblLabels12);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // optInter3
      // 
      this.optInter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.optInter3, "optInter3");
      this.optInter3.Name = "optInter3";
      this.optInter3.UseVisualStyleBackColor = false;
      // 
      // optInter2
      // 
      this.optInter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optInter2, "optInter2");
      this.optInter2.Name = "optInter2";
      this.optInter2.UseVisualStyleBackColor = false;
      // 
      // optInter0
      // 
      this.optInter0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter0.Checked = true;
      resources.ApplyResources(this.optInter0, "optInter0");
      this.optInter0.Name = "optInter0";
      this.optInter0.TabStop = true;
      this.optInter0.UseVisualStyleBackColor = false;
      // 
      // optInter1
      // 
      this.optInter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optInter1, "optInter1");
      this.optInter1.Name = "optInter1";
      this.optInter1.UseVisualStyleBackColor = false;
      // 
      // lblLabels5
      // 
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels19
      // 
      this.lblLabels19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels19, "lblLabels19");
      this.lblLabels19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels19.HelpContextID = 0;
      this.lblLabels19.Name = "lblLabels19";
      // 
      // lblLabels25
      // 
      this.lblLabels25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels25, "lblLabels25");
      this.lblLabels25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels25.HelpContextID = 0;
      this.lblLabels25.Name = "lblLabels25";
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame7.Controls.Add(this.optInter3);
      this.Frame7.Controls.Add(this.optInter2);
      this.Frame7.Controls.Add(this.optInter0);
      this.Frame7.Controls.Add(this.optInter1);
      this.Frame7.Controls.Add(this.lblLabels5);
      this.Frame7.Controls.Add(this.lblLabels1);
      this.Frame7.Controls.Add(this.lblLabels19);
      this.Frame7.Controls.Add(this.lblLabels25);
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblLabels2
      // 
      this.lblLabels2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmChoixDate
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboClient);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.chkSite);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Frame7);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblLabels2);
      this.Controls.Add(this.lblLabels11);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixDate";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixDate_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame7.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    public MozartUC.apiCombo cboClient;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiCheckBox chkSite;
    private System.Windows.Forms.RadioButton optInfo1;
    private System.Windows.Forms.RadioButton optInfo0;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame2;
    public MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    public MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.RadioButton optInter3;
    private System.Windows.Forms.RadioButton optInter2;
    private System.Windows.Forms.RadioButton optInter0;
    private System.Windows.Forms.RadioButton optInter1;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels19;
    private MozartUC.apiLabel lblLabels25;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel Label1;

  }
}
