namespace MozartCS
{
  partial class frmListeBudgPrest
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeBudgPrest));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdDate1 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cboAnnee = new System.Windows.Forms.ComboBox();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.lblTitre = new MozartUC.apiLabel();
      this.lblClient = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Cal_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Cal_ValueChanged);
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
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
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
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
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
      // cboAnnee
      // 
      this.cboAnnee.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.cboAnnee, "cboAnnee");
      this.cboAnnee.Name = "cboAnnee";
      
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cmdDate1);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.cmdDate2);
      this.Frame2.Controls.Add(this.txtDateA1);
      this.Frame2.Controls.Add(this.cmdAjouter);
      this.Frame2.Controls.Add(this.cboAnnee);
      this.Frame2.Controls.Add(this.lblLabels12);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.Label3);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
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
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      // 
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apigrid_CellValueChanged);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // lblClient
      // 
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblClient.HelpContextID = 0;
      this.lblClient.Name = "lblClient";
      // 
      // frmListeBudgPrest
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.lblClient);
      this.Name = "frmListeBudgPrest";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeBudgPrest_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdAjouter;
    private System.Windows.Forms.ComboBox cboAnnee;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiLabel lblClient;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
