namespace MozartCS
{
  partial class frmSaisieInfos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieInfos));
      this.chkDroit = new MozartUC.apiCheckBox();
      this.cmdInfoInterne = new MozartUC.apiButton();
      this.cmdInfoOT = new MozartUC.apiButton();
      this.txtDateDebut = new MozartUC.apiTextBox();
      this.cmdSupp1 = new MozartUC.apiButton();
      this.cmdDateDebut = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdDateRetour = new MozartUC.apiButton();
      this.cmdSupp0 = new MozartUC.apiButton();
      this.txtDateRetour = new MozartUC.apiTextBox();
      this.txtInfo = new MozartUC.apiTextBox();
      this.cmdEnreg = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdExit = new MozartUC.apiButton();
      this.cmdPrint = new MozartUC.apiButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels15 = new MozartUC.apiLabel();
      this.lblInfo = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // chkDroit
      // 
      this.chkDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkDroit, "chkDroit");
      this.chkDroit.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkDroit.HelpContextID = 0;
      this.chkDroit.Name = "chkDroit";
      this.chkDroit.UseVisualStyleBackColor = false;
      this.chkDroit.Click += new System.EventHandler(this.chkDroit_Click);
      // 
      // cmdInfoInterne
      // 
      resources.ApplyResources(this.cmdInfoInterne, "cmdInfoInterne");
      this.cmdInfoInterne.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdInfoInterne.HelpContextID = 0;
      this.cmdInfoInterne.Name = "cmdInfoInterne";
      this.cmdInfoInterne.Tag = "102";
      this.cmdInfoInterne.UseVisualStyleBackColor = true;
      this.cmdInfoInterne.Click += new System.EventHandler(this.cmdInfoInterne_Click);
      // 
      // cmdInfoOT
      // 
      resources.ApplyResources(this.cmdInfoOT, "cmdInfoOT");
      this.cmdInfoOT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdInfoOT.HelpContextID = 0;
      this.cmdInfoOT.Name = "cmdInfoOT";
      this.cmdInfoOT.Tag = "78";
      this.cmdInfoOT.UseVisualStyleBackColor = true;
      this.cmdInfoOT.Click += new System.EventHandler(this.cmdInfoOT_Click);
      // 
      // txtDateDebut
      // 
      resources.ApplyResources(this.txtDateDebut, "txtDateDebut");
      this.txtDateDebut.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateDebut.HelpContextID = 0;
      this.txtDateDebut.Name = "txtDateDebut";
      // 
      // cmdSupp1
      // 
      this.cmdSupp1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp1.HelpContextID = 0;
      this.cmdSupp1.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp1, "cmdSupp1");
      this.cmdSupp1.Name = "cmdSupp1";
      this.cmdSupp1.Tag = "27";
      this.cmdSupp1.UseVisualStyleBackColor = true;
      this.cmdSupp1.Click += new System.EventHandler(this.cmdSupp1_Click);
      // 
      // cmdDateDebut
      // 
      resources.ApplyResources(this.cmdDateDebut, "cmdDateDebut");
      this.cmdDateDebut.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDateDebut.HelpContextID = 0;
      this.cmdDateDebut.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDateDebut.Name = "cmdDateDebut";
      this.cmdDateDebut.Tag = "1";
      this.cmdDateDebut.UseVisualStyleBackColor = true;
      this.cmdDateDebut.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(1)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // cmdDateRetour
      // 
      resources.ApplyResources(this.cmdDateRetour, "cmdDateRetour");
      this.cmdDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDateRetour.HelpContextID = 0;
      this.cmdDateRetour.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDateRetour.Name = "cmdDateRetour";
      this.cmdDateRetour.Tag = "0";
      this.cmdDateRetour.UseVisualStyleBackColor = true;
      this.cmdDateRetour.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // cmdSupp0
      // 
      this.cmdSupp0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp0.HelpContextID = 0;
      this.cmdSupp0.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp0, "cmdSupp0");
      this.cmdSupp0.Name = "cmdSupp0";
      this.cmdSupp0.Tag = "27";
      this.cmdSupp0.UseVisualStyleBackColor = true;
      this.cmdSupp0.Click += new System.EventHandler(this.cmdSupp0_Click);
      // 
      // txtDateRetour
      // 
      resources.ApplyResources(this.txtDateRetour, "txtDateRetour");
      this.txtDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateRetour.HelpContextID = 0;
      this.txtDateRetour.Name = "txtDateRetour";
      // 
      // txtInfo
      // 
      this.txtInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtInfo.HelpContextID = 0;
      resources.ApplyResources(this.txtInfo, "txtInfo");
      this.txtInfo.Name = "txtInfo";
      this.txtInfo.Enter += new System.EventHandler(this.txtInfo_Enter);
      // 
      // cmdEnreg
      // 
      resources.ApplyResources(this.cmdEnreg, "cmdEnreg");
      this.cmdEnreg.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnreg.HelpContextID = 0;
      this.cmdEnreg.Name = "cmdEnreg";
      this.cmdEnreg.UseVisualStyleBackColor = true;
      this.cmdEnreg.Click += new System.EventHandler(this.cmdEnreg_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdExit
      // 
      resources.ApplyResources(this.cmdExit, "cmdExit");
      this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdExit.HelpContextID = 0;
      this.cmdExit.Name = "cmdExit";
      this.cmdExit.Tag = "15";
      this.cmdExit.UseVisualStyleBackColor = true;
      // 
      // cmdPrint
      // 
      resources.ApplyResources(this.cmdPrint, "cmdPrint");
      this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrint.HelpContextID = 0;
      this.cmdPrint.Name = "cmdPrint";
      this.cmdPrint.Tag = "17";
      this.cmdPrint.UseVisualStyleBackColor = true;
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels15
      // 
      resources.ApplyResources(this.lblLabels15, "lblLabels15");
      this.lblLabels15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels15.HelpContextID = 0;
      this.lblLabels15.Name = "lblLabels15";
      // 
      // lblInfo
      // 
      resources.ApplyResources(this.lblInfo, "lblInfo");
      this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblInfo.HelpContextID = 0;
      this.lblInfo.Name = "lblInfo";
      // 
      // frmSaisieInfos
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.chkDroit);
      this.Controls.Add(this.cmdInfoInterne);
      this.Controls.Add(this.cmdInfoOT);
      this.Controls.Add(this.txtDateDebut);
      this.Controls.Add(this.cmdSupp1);
      this.Controls.Add(this.cmdDateDebut);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.cmdDateRetour);
      this.Controls.Add(this.cmdSupp0);
      this.Controls.Add(this.txtDateRetour);
      this.Controls.Add(this.txtInfo);
      this.Controls.Add(this.cmdEnreg);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdExit);
      this.Controls.Add(this.cmdPrint);
      this.Controls.Add(this.lblLabels0);
      this.Controls.Add(this.lblLabels15);
      this.Controls.Add(this.lblInfo);
      this.Name = "frmSaisieInfos";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieInfos_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCheckBox chkDroit;
    private MozartUC.apiButton cmdInfoInterne;
    private MozartUC.apiButton cmdInfoOT;
    private MozartUC.apiTextBox txtDateDebut;
    private MozartUC.apiButton cmdSupp1;
    private MozartUC.apiButton cmdDateDebut;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdDateRetour;
    private MozartUC.apiButton cmdSupp0;
    private MozartUC.apiTextBox txtDateRetour;
    private MozartUC.apiTextBox txtInfo;
    private MozartUC.apiButton cmdEnreg;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdExit;
    private MozartUC.apiButton cmdPrint;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels15;
    private MozartUC.apiLabel lblInfo;

  }
}
