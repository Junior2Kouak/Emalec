namespace MozartCS
{
  partial class frmDetailsProcedure
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsProcedure));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.chkPasDeContratEI = new MozartUC.apiCheckBox();
      this.cmdDelSignContEI = new MozartUC.apiButton();
      this.cmdSelectContEiCliSigne = new MozartUC.apiButton();
      this.chkTaciteRecond = new MozartUC.apiCheckBox();
      this.txtDateEcheance = new MozartUC.apiTextBox();
      this.cboTypProc = new System.Windows.Forms.ComboBox();
      this.txtDateValidation = new MozartUC.apiTextBox();
      this.txtTitre = new MozartUC.apiTextBox();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cboLangue = new System.Windows.Forms.ComboBox();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.ChkPDP_Action = new MozartUC.apiCheckBox();
      this.cmdSuppEche = new MozartUC.apiButton();
      this.cmdDateEche = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdDate = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdFichier = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.frameVisu = new MozartUC.apiGroupBox();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Frame1.SuspendLayout();
      this.frameVisu.SuspendLayout();
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
      // chkPasDeContratEI
      // 
      this.chkPasDeContratEI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkPasDeContratEI, "chkPasDeContratEI");
      this.chkPasDeContratEI.HelpContextID = 0;
      this.chkPasDeContratEI.Name = "chkPasDeContratEI";
      this.chkPasDeContratEI.UseVisualStyleBackColor = false;
      // 
      // cmdDelSignContEI
      // 
      this.cmdDelSignContEI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.cmdDelSignContEI, "cmdDelSignContEI");
      this.cmdDelSignContEI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDelSignContEI.HelpContextID = 0;
      this.cmdDelSignContEI.Name = "cmdDelSignContEI";
      this.cmdDelSignContEI.Tag = "Supprimer la date";
      this.cmdDelSignContEI.UseVisualStyleBackColor = true;
      this.cmdDelSignContEI.Click += new System.EventHandler(this.CmdDelSignContEI_Click);
      // 
      // cmdSelectContEiCliSigne
      // 
      this.cmdSelectContEiCliSigne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdSelectContEiCliSigne, "cmdSelectContEiCliSigne");
      this.cmdSelectContEiCliSigne.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSelectContEiCliSigne.HelpContextID = 0;
      this.cmdSelectContEiCliSigne.Name = "cmdSelectContEiCliSigne";
      this.cmdSelectContEiCliSigne.Tag = "Contrat EI signé";
      this.cmdSelectContEiCliSigne.UseVisualStyleBackColor = false;
      this.cmdSelectContEiCliSigne.Click += new System.EventHandler(this.CmdSelectContEiCliSigne_Click);
      // 
      // chkTaciteRecond
      // 
      this.chkTaciteRecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkTaciteRecond, "chkTaciteRecond");
      this.chkTaciteRecond.HelpContextID = 0;
      this.chkTaciteRecond.Name = "chkTaciteRecond";
      this.chkTaciteRecond.UseVisualStyleBackColor = false;
      this.chkTaciteRecond.CheckedChanged += new System.EventHandler(this.ChkTaciteRecond_CheckedChanged);
      // 
      // txtDateEcheance
      // 
      this.txtDateEcheance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateEcheance, "txtDateEcheance");
      this.txtDateEcheance.HelpContextID = 0;
      this.txtDateEcheance.Name = "txtDateEcheance";
      // 
      // cboTypProc
      // 
      this.cboTypProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTypProc, "cboTypProc");
      this.cboTypProc.Name = "cboTypProc";
      this.cboTypProc.Sorted = true;
      this.cboTypProc.SelectedIndexChanged += new System.EventHandler(this.cboTypProc_SelectedIndexChanged);
      // 
      // txtDateValidation
      // 
      this.txtDateValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateValidation, "txtDateValidation");
      this.txtDateValidation.HelpContextID = 0;
      this.txtDateValidation.Name = "txtDateValidation";
      // 
      // txtTitre
      // 
      this.txtTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTitre, "txtTitre");
      this.txtTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTitre.HelpContextID = 0;
      this.txtTitre.Name = "txtTitre";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.cboLangue);
      this.Frame1.Controls.Add(this.apiLabel1);
      this.Frame1.Controls.Add(this.ChkPDP_Action);
      this.Frame1.Controls.Add(this.cmdSuppEche);
      this.Frame1.Controls.Add(this.cmdDateEche);
      this.Frame1.Controls.Add(this.cmdSupp);
      this.Frame1.Controls.Add(this.cmdDate);
      this.Frame1.Controls.Add(this.chkPasDeContratEI);
      this.Frame1.Controls.Add(this.cmdDelSignContEI);
      this.Frame1.Controls.Add(this.cmdSelectContEiCliSigne);
      this.Frame1.Controls.Add(this.chkTaciteRecond);
      this.Frame1.Controls.Add(this.txtDateEcheance);
      this.Frame1.Controls.Add(this.cboTypProc);
      this.Frame1.Controls.Add(this.txtDateValidation);
      this.Frame1.Controls.Add(this.txtTitre);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.Controls.Add(this.lblLabels5);
      this.Frame1.Controls.Add(this.lblLabels4);
      this.Frame1.Controls.Add(this.lblLabels2);
      this.Frame1.Controls.Add(this.lblTitre);
      this.Frame1.Controls.Add(this.lblLabels1);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Controls.Add(this.lblLabels3);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cboLangue
      // 
      this.cboLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboLangue, "cboLangue");
      this.cboLangue.Name = "cboLangue";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // ChkPDP_Action
      // 
      this.ChkPDP_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.ChkPDP_Action, "ChkPDP_Action");
      this.ChkPDP_Action.ForeColor = System.Drawing.Color.Black;
      this.ChkPDP_Action.HelpContextID = 0;
      this.ChkPDP_Action.Name = "ChkPDP_Action";
      this.ChkPDP_Action.UseVisualStyleBackColor = false;
      // 
      // cmdSuppEche
      // 
      this.cmdSuppEche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdSuppEche, "cmdSuppEche");
      this.cmdSuppEche.HelpContextID = 0;
      this.cmdSuppEche.Name = "cmdSuppEche";
      this.cmdSuppEche.Tag = "txtDateNaissance";
      this.cmdSuppEche.UseVisualStyleBackColor = false;
      this.cmdSuppEche.Click += new System.EventHandler(this.cmdSuppEcheance_Click);
      // 
      // cmdDateEche
      // 
      this.cmdDateEche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDateEche, "cmdDateEche");
      this.cmdDateEche.HelpContextID = 0;
      this.cmdDateEche.Name = "cmdDateEche";
      this.cmdDateEche.Tag = "txtDateNaissance";
      this.cmdDateEche.UseVisualStyleBackColor = false;
      this.cmdDateEche.Click += new System.EventHandler(this.cmdDate1_2_Click);
      // 
      // cmdSupp
      // 
      this.cmdSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "txtDateNaissance";
      this.cmdSupp.UseVisualStyleBackColor = false;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSuppValidation_Click);
      // 
      // cmdDate
      // 
      this.cmdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "txtDateNaissance";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate1_2_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // cmdFichier
      // 
      resources.ApplyResources(this.cmdFichier, "cmdFichier");
      this.cmdFichier.HelpContextID = 0;
      this.cmdFichier.Name = "cmdFichier";
      this.cmdFichier.Tag = "Joindre un fichier";
      this.cmdFichier.UseVisualStyleBackColor = true;
      this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // frameVisu
      // 
      resources.ApplyResources(this.frameVisu, "frameVisu");
      this.frameVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.frameVisu.Controls.Add(this.WebBrowser1);
      this.frameVisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.frameVisu.FrameColor = System.Drawing.Color.Empty;
      this.frameVisu.HelpContextID = 0;
      this.frameVisu.Name = "frameVisu";
      this.frameVisu.TabStop = false;
      // 
      // frmDetailsProcedure
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdFichier);
      this.Controls.Add(this.frameVisu);
      this.Name = "frmDetailsProcedure";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetailsProcedure_FormClosed);
      this.Load += new System.EventHandler(this.frmDetailsProcedure_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.frameVisu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiCheckBox chkPasDeContratEI;
    private MozartUC.apiButton cmdDelSignContEI;
    private MozartUC.apiButton cmdSelectContEiCliSigne;
    private MozartUC.apiCheckBox chkTaciteRecond;
    private MozartUC.apiTextBox txtDateEcheance;
    private System.Windows.Forms.ComboBox cboTypProc;
    private MozartUC.apiTextBox txtDateValidation;
    private MozartUC.apiTextBox txtTitre;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdFichier;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiGroupBox frameVisu;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiButton cmdSuppEche;
    private MozartUC.apiButton cmdDateEche;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiCheckBox ChkPDP_Action;
    private System.Windows.Forms.ComboBox cboLangue;
    private MozartUC.apiLabel apiLabel1;
  }
}
