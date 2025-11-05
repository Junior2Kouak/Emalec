namespace MozartCS
{
  partial class frmSaisieKMvehPret
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieKMvehPret));
      this.cmdQuitter = new MozartUC.apiButton();
      this.txtKm0 = new MozartUC.apiTextBox();
      this.txtKm5 = new MozartUC.apiTextBox();
      this.txtKm1 = new MozartUC.apiTextBox();
      this.txtDerKm = new MozartUC.apiTextBox();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdDate1 = new MozartUC.apiButton();
      this.lblSemaine = new MozartUC.apiLabel();
      this.lblDate1 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.lblDate2 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.cboAuto = new System.Windows.Forms.ComboBox();
      this.cmdSuppDate = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label22 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Label20 = new MozartUC.apiLabel();
      this.Label21 = new MozartUC.apiLabel();
      this.Label24 = new MozartUC.apiLabel();
      this.lblDerKM = new MozartUC.apiLabel();
      this.cboTech = new System.Windows.Forms.ComboBox();
      this.Frame4.SuspendLayout();
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
      // txtKm0
      // 
      resources.ApplyResources(this.txtKm0, "txtKm0");
      this.txtKm0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtKm0.HelpContextID = 0;
      this.txtKm0.Name = "txtKm0";
      this.txtKm0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm0_KeyPress);
      // 
      // txtKm5
      // 
      resources.ApplyResources(this.txtKm5, "txtKm5");
      this.txtKm5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtKm5.HelpContextID = 0;
      this.txtKm5.Name = "txtKm5";
      this.txtKm5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm1_KeyPress);
      // 
      // txtKm1
      // 
      resources.ApplyResources(this.txtKm1, "txtKm1");
      this.txtKm1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtKm1.HelpContextID = 0;
      this.txtKm1.Name = "txtKm1";
      this.txtKm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm1_KeyPress);
      // 
      // txtDerKm
      // 
      resources.ApplyResources(this.txtDerKm, "txtDerKm");
      this.txtDerKm.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDerKm.HelpContextID = 0;
      this.txtDerKm.Name = "txtDerKm";
      this.txtDerKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm1_KeyPress);
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
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
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // lblSemaine
      // 
      resources.ApplyResources(this.lblSemaine, "lblSemaine");
      this.lblSemaine.BackColor = System.Drawing.Color.Transparent;
      this.lblSemaine.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSemaine.HelpContextID = 0;
      this.lblSemaine.Name = "lblSemaine";
      // 
      // lblDate1
      // 
      this.lblDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblDate1, "lblDate1");
      this.lblDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblDate1.HelpContextID = 0;
      this.lblDate1.Name = "lblDate1";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // lblDate2
      // 
      this.lblDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblDate2, "lblDate2");
      this.lblDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblDate2.HelpContextID = 0;
      this.lblDate2.Name = "lblDate2";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.cboAuto);
      this.Frame4.Controls.Add(this.cmdDate1);
      this.Frame4.Controls.Add(this.lblSemaine);
      this.Frame4.Controls.Add(this.lblDate1);
      this.Frame4.Controls.Add(this.Label4);
      this.Frame4.Controls.Add(this.lblDate2);
      this.Frame4.Controls.Add(this.lblLabels3);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // cboAuto
      // 
      this.cboAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboAuto.FormattingEnabled = true;
      resources.ApplyResources(this.cboAuto, "cboAuto");
      this.cboAuto.Name = "cboAuto";
      this.cboAuto.DropDownClosed += new System.EventHandler(this.cboAuto1_Click);
      this.cboAuto.Click += new System.EventHandler(this.cboAuto1_Click);
      // 
      // cmdSuppDate
      // 
      resources.ApplyResources(this.cmdSuppDate, "cmdSuppDate");
      this.cmdSuppDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuppDate.HelpContextID = 0;
      this.cmdSuppDate.Name = "cmdSuppDate";
      this.cmdSuppDate.Tag = "65";
      this.cmdSuppDate.UseVisualStyleBackColor = true;
      this.cmdSuppDate.Click += new System.EventHandler(this.cmdSuppDate_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.Value = new System.DateTime(2021, 6, 29, 16, 56, 8, 0);
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      // 
      // apiTGrid
      // 
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.Name = "apiTGrid";
      // 
      // Label22
      // 
      this.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label22, "Label22");
      this.Label22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label22.HelpContextID = 0;
      this.Label22.Name = "Label22";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      this.Label1.Tag = "Tableau analytique mensuel des heures pour :";
      // 
      // Label20
      // 
      this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label20, "Label20");
      this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label20.HelpContextID = 0;
      this.Label20.Name = "Label20";
      // 
      // Label21
      // 
      this.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label21, "Label21");
      this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label21.HelpContextID = 0;
      this.Label21.Name = "Label21";
      // 
      // Label24
      // 
      this.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label24, "Label24");
      this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label24.HelpContextID = 0;
      this.Label24.Name = "Label24";
      // 
      // lblDerKM
      // 
      resources.ApplyResources(this.lblDerKM, "lblDerKM");
      this.lblDerKM.BackColor = System.Drawing.Color.Wheat;
      this.lblDerKM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDerKM.HelpContextID = 0;
      this.lblDerKM.Name = "lblDerKM";
      // 
      // cboTech
      // 
      this.cboTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTech.FormattingEnabled = true;
      resources.ApplyResources(this.cboTech, "cboTech");
      this.cboTech.Name = "cboTech";
      // 
      // frmSaisieKMvehPret
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboTech);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.txtKm0);
      this.Controls.Add(this.txtKm5);
      this.Controls.Add(this.txtKm1);
      this.Controls.Add(this.txtDerKm);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.cmdSuppDate);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label22);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Label20);
      this.Controls.Add(this.Label21);
      this.Controls.Add(this.Label24);
      this.Controls.Add(this.lblDerKM);
      this.Name = "frmSaisieKMvehPret";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSaisieKMvehPret_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTextBox txtKm0;
    private MozartUC.apiTextBox txtKm5;
    private MozartUC.apiTextBox txtKm1;
    private MozartUC.apiTextBox txtDerKm;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel lblSemaine;
    private MozartUC.apiLabel lblDate1;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel lblDate2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiButton cmdSuppDate;
    private MozartUC.apiButton cmdAjouter;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel Label22;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label20;
    private MozartUC.apiLabel Label21;
    private MozartUC.apiLabel Label24;
    private MozartUC.apiLabel lblDerKM;
    private System.Windows.Forms.ComboBox cboAuto;
    private System.Windows.Forms.ComboBox cboTech;
  }
}
