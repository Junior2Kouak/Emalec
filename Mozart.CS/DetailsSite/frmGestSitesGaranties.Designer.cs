namespace MozartCS
{
  partial class frmGestSitesGaranties
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestSitesGaranties));
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.CmdSuppDate1 = new MozartUC.apiButton();
      this.CmdSuppDate0 = new MozartUC.apiButton();
      this.CmdDate1 = new MozartUC.apiButton();
      this.CmdDate0 = new MozartUC.apiButton();
      this.CmdClose = new MozartUC.apiButton();
      this.BtnCancel = new MozartUC.apiButton();
      this.CmdEnregLot = new MozartUC.apiButton();
      this.txtDateFinGarant = new MozartUC.apiTextBox();
      this.txtDateRecept = new MozartUC.apiTextBox();
      this.txtNomLot = new MozartUC.apiTextBox();
      this.LblLegende2 = new MozartUC.apiLabel();
      this.LblLegende1 = new MozartUC.apiLabel();
      this.LblLegende0 = new MozartUC.apiLabel();
      this.FrameLot = new MozartUC.apiGroupBox();
      this.CmdModSTFInstall = new MozartUC.apiButton();
      this.CmdSuppSTFInstall = new MozartUC.apiButton();
      this.CmdAjoutSTFInstall = new MozartUC.apiButton();
      this.CmdModifLot = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGridLot = new MozartUC.apiTGrid();
      this.ApiTgridSTFInstall = new MozartUC.apiTGrid();
      this.lblSite = new MozartUC.apiLabel();
      this.LblNomLot = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.FrameLot.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
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
      // CmdSuppDate1
      // 
      this.CmdSuppDate1.BackgroundImage = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.CmdSuppDate1, "CmdSuppDate1");
      this.CmdSuppDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdSuppDate1.HelpContextID = 0;
      this.CmdSuppDate1.Name = "CmdSuppDate1";
      this.CmdSuppDate1.Tag = "27";
      this.CmdSuppDate1.UseVisualStyleBackColor = true;
      this.CmdSuppDate1.Click += new System.EventHandler(this.CmdSuppDate1_Click);
      // 
      // CmdSuppDate0
      // 
      this.CmdSuppDate0.BackgroundImage = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.CmdSuppDate0, "CmdSuppDate0");
      this.CmdSuppDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdSuppDate0.HelpContextID = 0;
      this.CmdSuppDate0.Name = "CmdSuppDate0";
      this.CmdSuppDate0.Tag = "27";
      this.CmdSuppDate0.UseVisualStyleBackColor = true;
      this.CmdSuppDate0.Click += new System.EventHandler(this.CmdSuppDate0_Click);
      // 
      // CmdDate1
      // 
      this.CmdDate1.BackgroundImage = global::MozartCS.Properties.Resources.calendar;
      this.CmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdDate1.HelpContextID = 0;
      resources.ApplyResources(this.CmdDate1, "CmdDate1");
      this.CmdDate1.Name = "CmdDate1";
      this.CmdDate1.Tag = "5";
      this.CmdDate1.UseVisualStyleBackColor = true;
      this.CmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // CmdDate0
      // 
      this.CmdDate0.BackgroundImage = global::MozartCS.Properties.Resources.calendar;
      this.CmdDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdDate0.HelpContextID = 0;
      resources.ApplyResources(this.CmdDate0, "CmdDate0");
      this.CmdDate0.Name = "CmdDate0";
      this.CmdDate0.Tag = "5";
      this.CmdDate0.UseVisualStyleBackColor = true;
      this.CmdDate0.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // CmdClose
      // 
      this.CmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.CmdClose, "CmdClose");
      this.CmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdClose.HelpContextID = 0;
      this.CmdClose.Name = "CmdClose";
      this.CmdClose.UseVisualStyleBackColor = false;
      this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
      // 
      // BtnCancel
      // 
      resources.ApplyResources(this.BtnCancel, "BtnCancel");
      this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnCancel.HelpContextID = 0;
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.UseVisualStyleBackColor = true;
      this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // CmdEnregLot
      // 
      resources.ApplyResources(this.CmdEnregLot, "CmdEnregLot");
      this.CmdEnregLot.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdEnregLot.HelpContextID = 0;
      this.CmdEnregLot.Name = "CmdEnregLot";
      this.CmdEnregLot.UseVisualStyleBackColor = true;
      this.CmdEnregLot.Click += new System.EventHandler(this.CmdEnregLot_Click);
      // 
      // txtDateFinGarant
      // 
      this.txtDateFinGarant.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateFinGarant.HelpContextID = 0;
      resources.ApplyResources(this.txtDateFinGarant, "txtDateFinGarant");
      this.txtDateFinGarant.Name = "txtDateFinGarant";
      // 
      // txtDateRecept
      // 
      this.txtDateRecept.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateRecept.HelpContextID = 0;
      resources.ApplyResources(this.txtDateRecept, "txtDateRecept");
      this.txtDateRecept.Name = "txtDateRecept";
      // 
      // txtNomLot
      // 
      this.txtNomLot.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtNomLot.HelpContextID = 0;
      resources.ApplyResources(this.txtNomLot, "txtNomLot");
      this.txtNomLot.Name = "txtNomLot";
      // 
      // LblLegende2
      // 
      resources.ApplyResources(this.LblLegende2, "LblLegende2");
      this.LblLegende2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblLegende2.HelpContextID = 0;
      this.LblLegende2.Name = "LblLegende2";
      // 
      // LblLegende1
      // 
      resources.ApplyResources(this.LblLegende1, "LblLegende1");
      this.LblLegende1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblLegende1.HelpContextID = 0;
      this.LblLegende1.Name = "LblLegende1";
      // 
      // LblLegende0
      // 
      resources.ApplyResources(this.LblLegende0, "LblLegende0");
      this.LblLegende0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblLegende0.HelpContextID = 0;
      this.LblLegende0.Name = "LblLegende0";
      // 
      // FrameLot
      // 
      this.FrameLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.FrameLot.Controls.Add(this.CmdSuppDate1);
      this.FrameLot.Controls.Add(this.CmdSuppDate0);
      this.FrameLot.Controls.Add(this.CmdDate1);
      this.FrameLot.Controls.Add(this.CmdDate0);
      this.FrameLot.Controls.Add(this.CmdClose);
      this.FrameLot.Controls.Add(this.BtnCancel);
      this.FrameLot.Controls.Add(this.CmdEnregLot);
      this.FrameLot.Controls.Add(this.txtDateFinGarant);
      this.FrameLot.Controls.Add(this.txtDateRecept);
      this.FrameLot.Controls.Add(this.txtNomLot);
      this.FrameLot.Controls.Add(this.LblLegende2);
      this.FrameLot.Controls.Add(this.LblLegende1);
      this.FrameLot.Controls.Add(this.LblLegende0);
      resources.ApplyResources(this.FrameLot, "FrameLot");
      this.FrameLot.HelpContextID = 0;
      this.FrameLot.Name = "FrameLot";
      this.FrameLot.TabStop = false;
      // 
      // CmdModSTFInstall
      // 
      resources.ApplyResources(this.CmdModSTFInstall, "CmdModSTFInstall");
      this.CmdModSTFInstall.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModSTFInstall.HelpContextID = 0;
      this.CmdModSTFInstall.Name = "CmdModSTFInstall";
      this.CmdModSTFInstall.Tag = "19";
      this.CmdModSTFInstall.UseVisualStyleBackColor = true;
      this.CmdModSTFInstall.Click += new System.EventHandler(this.CmdModSTFInstall_Click);
      // 
      // CmdSuppSTFInstall
      // 
      resources.ApplyResources(this.CmdSuppSTFInstall, "CmdSuppSTFInstall");
      this.CmdSuppSTFInstall.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdSuppSTFInstall.HelpContextID = 0;
      this.CmdSuppSTFInstall.Name = "CmdSuppSTFInstall";
      this.CmdSuppSTFInstall.Tag = "27";
      this.CmdSuppSTFInstall.UseVisualStyleBackColor = true;
      this.CmdSuppSTFInstall.Click += new System.EventHandler(this.CmdSuppSTFInstall_Click);
      // 
      // CmdAjoutSTFInstall
      // 
      resources.ApplyResources(this.CmdAjoutSTFInstall, "CmdAjoutSTFInstall");
      this.CmdAjoutSTFInstall.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdAjoutSTFInstall.HelpContextID = 22;
      this.CmdAjoutSTFInstall.Name = "CmdAjoutSTFInstall";
      this.CmdAjoutSTFInstall.Tag = "2";
      this.CmdAjoutSTFInstall.UseVisualStyleBackColor = true;
      this.CmdAjoutSTFInstall.Click += new System.EventHandler(this.CmdAjoutSTFInstall_Click);
      // 
      // CmdModifLot
      // 
      resources.ApplyResources(this.CmdModifLot, "CmdModifLot");
      this.CmdModifLot.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModifLot.HelpContextID = 0;
      this.CmdModifLot.Name = "CmdModifLot";
      this.CmdModifLot.Tag = "19";
      this.CmdModifLot.UseVisualStyleBackColor = true;
      this.CmdModifLot.Click += new System.EventHandler(this.CmdModifLot_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 22;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGridLot
      // 
      resources.ApplyResources(this.apiTGridLot, "apiTGridLot");
      this.apiTGridLot.FilterBar = true;
      this.apiTGridLot.FooterBar = true;
      this.apiTGridLot.Name = "apiTGridLot";
      this.apiTGridLot.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGridLot_SelectionChanged);
      // 
      // ApiTgridSTFInstall
      // 
      resources.ApplyResources(this.ApiTgridSTFInstall, "ApiTgridSTFInstall");
      this.ApiTgridSTFInstall.FilterBar = true;
      this.ApiTgridSTFInstall.FooterBar = true;
      this.ApiTgridSTFInstall.Name = "ApiTgridSTFInstall";
      // 
      // lblSite
      // 
      this.lblSite.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblSite, "lblSite");
      this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblSite.HelpContextID = 0;
      this.lblSite.Name = "lblSite";
      // 
      // LblNomLot
      // 
      this.LblNomLot.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.LblNomLot, "LblNomLot");
      this.LblNomLot.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblNomLot.HelpContextID = 0;
      this.LblNomLot.Name = "LblNomLot";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.lblTitre);
      this.panel2.Controls.Add(this.LblNomLot);
      this.panel2.Controls.Add(this.ApiTgridSTFInstall);
      this.panel2.Controls.Add(this.CmdModSTFInstall);
      this.panel2.Controls.Add(this.CmdSuppSTFInstall);
      this.panel2.Controls.Add(this.CmdAjoutSTFInstall);
      this.panel2.Controls.Add(this.cmdFermer);
      this.panel2.Name = "panel2";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.FrameLot);
      this.panel1.Controls.Add(this.lblSite);
      this.panel1.Controls.Add(this.apiTGridLot);
      this.panel1.Controls.Add(this.CmdModifLot);
      this.panel1.Controls.Add(this.cmdAjouter);
      this.panel1.Controls.Add(this.Label1);
      this.panel1.Controls.Add(this.cmdSupprimer);
      this.panel1.Name = "panel1";
      // 
      // frmGestSitesGaranties
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.Cal);
      this.Name = "frmGestSitesGaranties";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestSitesGaranties_Load);
      this.FrameLot.ResumeLayout(false);
      this.FrameLot.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton CmdSuppDate1;
    private MozartUC.apiButton CmdSuppDate0;
    private MozartUC.apiButton CmdDate1;
    private MozartUC.apiButton CmdDate0;
    private MozartUC.apiButton CmdClose;
    private MozartUC.apiButton BtnCancel;
    private MozartUC.apiButton CmdEnregLot;
    private MozartUC.apiTextBox txtDateFinGarant;
    private MozartUC.apiTextBox txtDateRecept;
    private MozartUC.apiTextBox txtNomLot;
    private MozartUC.apiLabel LblLegende2;
    private MozartUC.apiLabel LblLegende1;
    private MozartUC.apiLabel LblLegende0;
    private MozartUC.apiGroupBox FrameLot;
    private MozartUC.apiButton CmdModSTFInstall;
    private MozartUC.apiButton CmdSuppSTFInstall;
    private MozartUC.apiButton CmdAjoutSTFInstall;
    private MozartUC.apiButton CmdModifLot;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridLot;
    private MozartUC.apiTGrid ApiTgridSTFInstall;
    private MozartUC.apiLabel lblSite;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel LblNomLot;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lblTitre;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
