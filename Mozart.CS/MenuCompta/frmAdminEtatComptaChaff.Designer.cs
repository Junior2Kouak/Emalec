namespace MozartCS
{
  partial class frmAdminEtatComptaChaff
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminEtatComptaChaff));
      this.CmdCSP = new MozartUC.apiButton();
      this.cCalendar = new System.Windows.Forms.DateTimePicker();
      this.Command2 = new MozartUC.apiButton();
      this.cmdDate = new MozartUC.apiButton();
      this.txtDateA = new MozartUC.apiTextBox();
      this.lblLabels10 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.frameSaisie = new MozartUC.apiGroupBox();
      this.cboChoixCompte = new MozartUC.apiCombo();
      this.cbCritChaff = new MozartUC.apiCombo();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.Command1 = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmd2 = new MozartUC.apiButton();
      this.cmdAssist = new MozartUC.apiButton();
      this.cmdTech = new MozartUC.apiButton();
      this.cmd1 = new MozartUC.apiButton();
      this.cmdSynt = new MozartUC.apiButton();
      this.cmdFAEPCA = new MozartUC.apiButton();
      this.frameSaisie.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdCSP
      // 
      this.CmdCSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdCSP, "CmdCSP");
      this.CmdCSP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdCSP.HelpContextID = 0;
      this.CmdCSP.Name = "CmdCSP";
      this.CmdCSP.Tag = "90";
      this.CmdCSP.UseVisualStyleBackColor = false;
      this.CmdCSP.Click += new System.EventHandler(this.CmdCSP_Click);
      // 
      // cCalendar
      // 
      this.cCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.cCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.cCalendar, "cCalendar");
      this.cCalendar.Name = "cCalendar";
      this.cCalendar.CloseUp += new System.EventHandler(this.cCalendar_CloseUp);
      this.cCalendar.ValueChanged += new System.EventHandler(this.cCalendar_ValueChanged);
      // 
      // Command2
      // 
      this.Command2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Command2, "Command2");
      this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command2.HelpContextID = 0;
      this.Command2.Name = "Command2";
      this.Command2.Tag = "90";
      this.Command2.UseVisualStyleBackColor = false;
      this.Command2.Click += new System.EventHandler(this.Command2_Click);
      // 
      // cmdDate
      // 
      this.cmdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "5";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // txtDateA
      // 
      this.txtDateA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA, "txtDateA");
      this.txtDateA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA.HelpContextID = 0;
      this.txtDateA.Name = "txtDateA";
      // 
      // lblLabels10
      // 
      this.lblLabels10.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels10, "lblLabels10");
      this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels10.HelpContextID = 0;
      this.lblLabels10.Name = "lblLabels10";
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // frameSaisie
      // 
      this.frameSaisie.BackColor = System.Drawing.Color.Wheat;
      this.frameSaisie.Controls.Add(this.cboChoixCompte);
      this.frameSaisie.Controls.Add(this.cbCritChaff);
      this.frameSaisie.Controls.Add(this.apiLabel1);
      this.frameSaisie.Controls.Add(this.cmdDate);
      this.frameSaisie.Controls.Add(this.txtDateA);
      this.frameSaisie.Controls.Add(this.lblLabels10);
      this.frameSaisie.Controls.Add(this.lblLabels12);
      resources.ApplyResources(this.frameSaisie, "frameSaisie");
      this.frameSaisie.FrameColor = System.Drawing.Color.Gainsboro;
      this.frameSaisie.HelpContextID = 0;
      this.frameSaisie.Name = "frameSaisie";
      this.frameSaisie.TabStop = false;
      // 
      // cboChoixCompte
      // 
      resources.ApplyResources(this.cboChoixCompte, "cboChoixCompte");
      this.cboChoixCompte.Name = "cboChoixCompte";
      this.cboChoixCompte.NewValues = false;
      this.cboChoixCompte.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboChoixCompte_TxtChanged);
      // 
      // cbCritChaff
      // 
      resources.ApplyResources(this.cbCritChaff, "cbCritChaff");
      this.cbCritChaff.Name = "cbCritChaff";
      this.cbCritChaff.NewValues = false;
      this.cbCritChaff.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cbCritChaff_TxtChanged);
      // 
      // apiLabel1
      // 
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // Command1
      // 
      this.Command1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "112";
      this.Command1.UseVisualStyleBackColor = false;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmd2
      // 
      this.cmd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmd2, "cmd2");
      this.cmd2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmd2.HelpContextID = 0;
      this.cmd2.Name = "cmd2";
      this.cmd2.Tag = "114";
      this.cmd2.UseVisualStyleBackColor = false;
      this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
      // 
      // cmdAssist
      // 
      this.cmdAssist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAssist, "cmdAssist");
      this.cmdAssist.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAssist.HelpContextID = 0;
      this.cmdAssist.Name = "cmdAssist";
      this.cmdAssist.Tag = "115";
      this.cmdAssist.UseVisualStyleBackColor = false;
      this.cmdAssist.Click += new System.EventHandler(this.cmdAssist_Click);
      // 
      // cmdTech
      // 
      this.cmdTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdTech, "cmdTech");
      this.cmdTech.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTech.HelpContextID = 0;
      this.cmdTech.Name = "cmdTech";
      this.cmdTech.Tag = "88";
      this.cmdTech.UseVisualStyleBackColor = false;
      this.cmdTech.Click += new System.EventHandler(this.cmdTech_Click);
      // 
      // cmd1
      // 
      this.cmd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmd1, "cmd1");
      this.cmd1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmd1.HelpContextID = 0;
      this.cmd1.Name = "cmd1";
      this.cmd1.Tag = "90";
      this.cmd1.UseVisualStyleBackColor = false;
      this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
      // 
      // cmdSynt
      // 
      this.cmdSynt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSynt, "cmdSynt");
      this.cmdSynt.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSynt.HelpContextID = 0;
      this.cmdSynt.Name = "cmdSynt";
      this.cmdSynt.Tag = "33";
      this.cmdSynt.UseVisualStyleBackColor = false;
      this.cmdSynt.Click += new System.EventHandler(this.cmdSynt_Click);
      // 
      // cmdFAEPCA
      // 
      this.cmdFAEPCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdFAEPCA, "cmdFAEPCA");
      this.cmdFAEPCA.HelpContextID = 0;
      this.cmdFAEPCA.Name = "cmdFAEPCA";
      this.cmdFAEPCA.Tag = "112";
      this.cmdFAEPCA.UseVisualStyleBackColor = false;
      this.cmdFAEPCA.Click += new System.EventHandler(this.cmdFAEPCA_Click);
      // 
      // frmAdminEtatComptaChaff
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFAEPCA);
      this.Controls.Add(this.CmdCSP);
      this.Controls.Add(this.cCalendar);
      this.Controls.Add(this.Command2);
      this.Controls.Add(this.frameSaisie);
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmd2);
      this.Controls.Add(this.cmdAssist);
      this.Controls.Add(this.cmdTech);
      this.Controls.Add(this.cmd1);
      this.Controls.Add(this.cmdSynt);
      this.Name = "frmAdminEtatComptaChaff";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminEtatComptaChaff_Load);
      this.frameSaisie.ResumeLayout(false);
      this.frameSaisie.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton CmdCSP;
    private System.Windows.Forms.DateTimePicker cCalendar;
    private MozartUC.apiButton Command2;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiTextBox txtDateA;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox frameSaisie;
    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmd2;
    private MozartUC.apiButton cmdAssist;
    private MozartUC.apiButton cmdTech;
    private MozartUC.apiButton cmd1;
    private MozartUC.apiButton cmdSynt;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiCombo cbCritChaff;
    private MozartUC.apiCombo cboChoixCompte;
    private MozartUC.apiButton cmdFAEPCA;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
