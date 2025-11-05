namespace MozartCS
{
  partial class frmListeDevisST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDevisST));
      this.cmdDevPrest = new MozartUC.apiButton();
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.txtCritSTF = new MozartUC.apiCombo();
      this.txtCritNumDI = new MozartUC.apiTextBox();
      this.txtCritNumDevis = new MozartUC.apiTextBox();
      this.txtCritDate0 = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.txtCritDate1 = new MozartUC.apiTextBox();
      this.cmdDate0 = new MozartUC.apiButton();
      this.cmdDate1 = new MozartUC.apiButton();
      this.Label5 = new MozartUC.apiLabel();
      this.label2 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.lblDateAu = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.chkAll = new MozartUC.apiCheckBox();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdNouveau = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.grid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDevPrest
      // 
      resources.ApplyResources(this.cmdDevPrest, "cmdDevPrest");
      this.cmdDevPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDevPrest.HelpContextID = 0;
      this.cmdDevPrest.Name = "cmdDevPrest";
      this.cmdDevPrest.Tag = "2";
      this.cmdDevPrest.UseVisualStyleBackColor = true;
      this.cmdDevPrest.Click += new System.EventHandler(this.cmdDevPrest_Click);
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
      // txtCritSTF
      // 
      resources.ApplyResources(this.txtCritSTF, "txtCritSTF");
      this.txtCritSTF.Name = "txtCritSTF";
      // 
      // txtCritNumDI
      // 
      resources.ApplyResources(this.txtCritNumDI, "txtCritNumDI");
      this.txtCritNumDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritNumDI.HelpContextID = 0;
      this.txtCritNumDI.Name = "txtCritNumDI";
      this.txtCritNumDI.Enter += new System.EventHandler(this.txtALL_Enter);
      // 
      // txtCritNumDevis
      // 
      resources.ApplyResources(this.txtCritNumDevis, "txtCritNumDevis");
      this.txtCritNumDevis.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritNumDevis.HelpContextID = 0;
      this.txtCritNumDevis.Name = "txtCritNumDevis";
      this.txtCritNumDevis.Enter += new System.EventHandler(this.txtALL_Enter);
      // 
      // txtCritDate0
      // 
      resources.ApplyResources(this.txtCritDate0, "txtCritDate0");
      this.txtCritDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritDate0.HelpContextID = 0;
      this.txtCritDate0.Name = "txtCritDate0";
      this.txtCritDate0.Enter += new System.EventHandler(this.txtALL_Enter);
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
      // txtCritDate1
      // 
      resources.ApplyResources(this.txtCritDate1, "txtCritDate1");
      this.txtCritDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritDate1.HelpContextID = 0;
      this.txtCritDate1.Name = "txtCritDate1";
      this.txtCritDate1.Enter += new System.EventHandler(this.txtALL_Enter);
      // 
      // cmdDate0
      // 
      this.cmdDate0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate0, "cmdDate0");
      this.cmdDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate0.HelpContextID = 0;
      this.cmdDate0.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate0.Name = "cmdDate0";
      this.cmdDate0.Tag = "0";
      this.cmdDate0.UseVisualStyleBackColor = false;
      this.cmdDate0.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "1";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.HelpContextID = 0;
      this.label2.Name = "label2";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // lblDateAu
      // 
      resources.ApplyResources(this.lblDateAu, "lblDateAu");
      this.lblDateAu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDateAu.HelpContextID = 0;
      this.lblDateAu.Name = "lblDateAu";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.Name = "Label3";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtCritNumDI);
      this.fraCriteres.Controls.Add(this.txtCritNumDevis);
      this.fraCriteres.Controls.Add(this.txtCritDate0);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.txtCritDate1);
      this.fraCriteres.Controls.Add(this.cmdDate0);
      this.fraCriteres.Controls.Add(this.cmdDate1);
      this.fraCriteres.Controls.Add(this.Label5);
      this.fraCriteres.Controls.Add(this.label2);
      this.fraCriteres.Controls.Add(this.Label4);
      this.fraCriteres.Controls.Add(this.lblDateAu);
      this.fraCriteres.Controls.Add(this.lblPeriode);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // chkAll
      // 
      this.chkAll.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkAll, "chkAll");
      this.chkAll.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkAll.HelpContextID = 0;
      this.chkAll.Name = "chkAll";
      this.chkAll.UseVisualStyleBackColor = false;
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // cmdNouveau
      // 
      resources.ApplyResources(this.cmdNouveau, "cmdNouveau");
      this.cmdNouveau.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouveau.HelpContextID = 0;
      this.cmdNouveau.Name = "cmdNouveau";
      this.cmdNouveau.Tag = "2";
      this.cmdNouveau.UseVisualStyleBackColor = true;
      this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
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
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // grid
      // 
      resources.ApplyResources(this.grid, "grid");
      this.grid.FilterBar = true;
      this.grid.FooterBar = true;
      this.grid.Name = "grid";
      this.grid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.grid_DoubleClickE);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeDevisST
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDevPrest);
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.txtCritSTF);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.chkAll);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdNouveau);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.grid);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeDevisST";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDevisST_Load);
      this.ResizeEnd += new System.EventHandler(this.frmListeDevisST_ResizeEnd);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeDevisST_KeyUp);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDevPrest;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiCombo txtCritSTF;
    private MozartUC.apiTextBox txtCritNumDI;
    private MozartUC.apiTextBox txtCritNumDevis;
    private MozartUC.apiTextBox txtCritDate0;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiTextBox txtCritDate1;
    private MozartUC.apiButton cmdDate0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel label2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel lblDateAu;
    private MozartUC.apiLabel lblPeriode;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiCheckBox chkAll;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdNouveau;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid grid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
