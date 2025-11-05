namespace MozartCS
{
  partial class frmListeSpyLog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeSpyLog));
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.txtCritUser = new MozartUC.apiCombo();
      this.cmdFermer = new MozartUC.apiButton();
      this.GridT = new MozartUC.apiTGrid();
      this.txtCritAction = new MozartUC.apiTextBox();
      this.txtCritFonction = new MozartUC.apiTextBox();
      this.txtCritObs = new MozartUC.apiTextBox();
      this.txtCritDate = new MozartUC.apiTextBox();
      this.txtCritPID = new MozartUC.apiTextBox();
      this.cmdDate = new MozartUC.apiButton();
      this.cmdFind = new MozartUC.apiButton();
      this.Label16 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.label14 = new MozartUC.apiLabel();
      this.Label30 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // Cal
      // 
      this.Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Cal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Cal, "Cal");
      this.Cal.Name = "Cal";
      this.Cal.CloseUp += new System.EventHandler(this.Cal_CloseUp);
      this.Cal.ValueChanged += new System.EventHandler(this.Cal_ValueChanged);
      // 
      // txtCritUser
      // 
      resources.ApplyResources(this.txtCritUser, "txtCritUser");
      this.txtCritUser.Name = "txtCritUser";
      this.txtCritUser.NewValues = false;
      this.txtCritUser.Enter += new System.EventHandler(this.cbo_Enter);
      this.txtCritUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_MouseClic);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // GridT
      // 
      resources.ApplyResources(this.GridT, "GridT");
      this.GridT.FilterBar = true;
      this.GridT.FooterBar = true;
      this.GridT.Name = "GridT";
      // 
      // txtCritAction
      // 
      resources.ApplyResources(this.txtCritAction, "txtCritAction");
      this.txtCritAction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritAction.HelpContextID = 0;
      this.txtCritAction.Name = "txtCritAction";
      // 
      // txtCritFonction
      // 
      resources.ApplyResources(this.txtCritFonction, "txtCritFonction");
      this.txtCritFonction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritFonction.HelpContextID = 0;
      this.txtCritFonction.Name = "txtCritFonction";
      // 
      // txtCritObs
      // 
      resources.ApplyResources(this.txtCritObs, "txtCritObs");
      this.txtCritObs.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritObs.HelpContextID = 0;
      this.txtCritObs.Name = "txtCritObs";
      // 
      // txtCritDate
      // 
      resources.ApplyResources(this.txtCritDate, "txtCritDate");
      this.txtCritDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritDate.HelpContextID = 0;
      this.txtCritDate.Name = "txtCritDate";
      this.txtCritDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClic);
      this.txtCritDate.Enter += new System.EventHandler(this.txt_Enter);
      // 
      // txtCritPID
      // 
      resources.ApplyResources(this.txtCritPID, "txtCritPID");
      this.txtCritPID.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritPID.HelpContextID = 0;
      this.txtCritPID.Name = "txtCritPID";
      this.txtCritPID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClic);
      this.txtCritPID.Enter += new System.EventHandler(this.txt_Enter);
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
      // cmdFind
      // 
      this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // Label16
      // 
      resources.ApplyResources(this.Label16, "Label16");
      this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label16.HelpContextID = 0;
      this.Label16.Name = "Label16";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label7
      // 
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.Name = "Label7";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // label14
      // 
      resources.ApplyResources(this.label14, "label14");
      this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label14.HelpContextID = 0;
      this.label14.Name = "label14";
      // 
      // Label30
      // 
      resources.ApplyResources(this.Label30, "Label30");
      this.Label30.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label30.HelpContextID = 0;
      this.Label30.Name = "Label30";
      // 
      // fraCriteres
      // 
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtCritAction);
      this.fraCriteres.Controls.Add(this.txtCritFonction);
      this.fraCriteres.Controls.Add(this.txtCritObs);
      this.fraCriteres.Controls.Add(this.txtCritDate);
      this.fraCriteres.Controls.Add(this.txtCritPID);
      this.fraCriteres.Controls.Add(this.cmdDate);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.Label16);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.Label2);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.Controls.Add(this.lblPeriode);
      this.fraCriteres.Controls.Add(this.label14);
      this.fraCriteres.Controls.Add(this.Label30);
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeSpyLog
      // 
      this.AcceptButton = this.cmdFind;
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.txtCritUser);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.GridT);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeSpyLog";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeSpyLog_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeSpyLog_KeyUp);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiCombo txtCritUser;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid GridT;
    private MozartUC.apiTextBox txtCritAction;
    private MozartUC.apiTextBox txtCritFonction;
    private MozartUC.apiTextBox txtCritObs;
    private MozartUC.apiTextBox txtCritDate;
    private MozartUC.apiTextBox txtCritPID;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiLabel Label16;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel lblPeriode;
    private MozartUC.apiLabel label14;
    private MozartUC.apiLabel Label30;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
