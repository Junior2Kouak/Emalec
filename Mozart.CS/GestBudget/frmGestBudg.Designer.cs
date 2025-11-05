namespace MozartCS
{
  partial class frmGestBudget
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestBudget));
      this.ApiGridCtrGeres = new MozartUC.apiTGrid();
      this.lblContratSomme = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.ApiGridCtr = new MozartUC.apiTGrid();
      this.Frame5 = new MozartUC.apiGroupBox();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cboAnnee = new System.Windows.Forms.ComboBox();
      this.cmdAjouter = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.Label3 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.ApiGridSite = new MozartUC.apiTGrid();
      this.lblSiteSomme = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.lblClient = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      // 
      // ApiGridCtrGeres
      // 
      resources.ApplyResources(this.ApiGridCtrGeres, "ApiGridCtrGeres");
      this.ApiGridCtrGeres.FilterBar = true;
      this.ApiGridCtrGeres.FooterBar = true;
      this.ApiGridCtrGeres.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ApiGridCtrGeres.Name = "ApiGridCtrGeres";
      this.ApiGridCtrGeres.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.ApiGrid_CellValueChanged);
      // 
      // lblContratSomme
      // 
      resources.ApplyResources(this.lblContratSomme, "lblContratSomme");
      this.lblContratSomme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblContratSomme.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblContratSomme.HelpContextID = 0;
      this.lblContratSomme.Name = "lblContratSomme";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.Wheat;
      this.Frame3.Controls.Add(this.ApiGridCtrGeres);
      this.Frame3.Controls.Add(this.lblContratSomme);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // ApiGridCtr
      // 
      resources.ApplyResources(this.ApiGridCtr, "ApiGridCtr");
      this.ApiGridCtr.FilterBar = true;
      this.ApiGridCtr.FooterBar = true;
      this.ApiGridCtr.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ApiGridCtr.Name = "ApiGridCtr";
      this.ApiGridCtr.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.ApiGridCtr_Click);
      // 
      // Frame5
      // 
      resources.ApplyResources(this.Frame5, "Frame5");
      this.Frame5.BackColor = System.Drawing.Color.Wheat;
      this.Frame5.Controls.Add(this.ApiGridCtr);
      this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame5.HelpContextID = 0;
      this.Frame5.Name = "Frame5";
      this.Frame5.TabStop = false;
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
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      // 
      // cboAnnee
      // 
      this.cboAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cboAnnee, "cboAnnee");
      this.cboAnnee.Items.AddRange(new object[] {
            resources.GetString("cboAnnee.Items"),
            resources.GetString("cboAnnee.Items1"),
            resources.GetString("cboAnnee.Items2"),
            resources.GetString("cboAnnee.Items3"),
            resources.GetString("cboAnnee.Items4"),
            resources.GetString("cboAnnee.Items5"),
            resources.GetString("cboAnnee.Items6"),
            resources.GetString("cboAnnee.Items7"),
            resources.GetString("cboAnnee.Items8")});
      this.cboAnnee.Name = "cboAnnee";
      this.cboAnnee.SelectedIndexChanged += new System.EventHandler(this.cboAnnee_SelectedIndexChanged);
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
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
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
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cboAnnee);
      this.Frame2.Controls.Add(this.cmdAjouter);
      this.Frame2.Controls.Add(this.txtDateA1);
      this.Frame2.Controls.Add(this.cmdDate2);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.cmdDate1);
      this.Frame2.Controls.Add(this.Label3);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.lblLabels12);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // ApiGridSite
      // 
      resources.ApplyResources(this.ApiGridSite, "ApiGridSite");
      this.ApiGridSite.FilterBar = true;
      this.ApiGridSite.FooterBar = true;
      this.ApiGridSite.ForeColor = System.Drawing.SystemColors.WindowText;
      this.ApiGridSite.Name = "ApiGridSite";
      this.ApiGridSite.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.ApiGridSite_Click);
      this.ApiGridSite.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.ApiGridSite_CellValueChanged);
      // 
      // lblSiteSomme
      // 
      resources.ApplyResources(this.lblSiteSomme, "lblSiteSomme");
      this.lblSiteSomme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblSiteSomme.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSiteSomme.HelpContextID = 0;
      this.lblSiteSomme.Name = "lblSiteSomme";
      // 
      // Frame4
      // 
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.BackColor = System.Drawing.Color.Wheat;
      this.Frame4.Controls.Add(this.ApiGridSite);
      this.Frame4.Controls.Add(this.lblSiteSomme);
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // lblClient
      // 
      this.lblClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblClient.HelpContextID = 0;
      this.lblClient.Name = "lblClient";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmGestBudget
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame5);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestBudget";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestBudget_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame5.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame4.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid ApiGridCtrGeres;
    private MozartUC.apiLabel lblContratSomme;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiTGrid ApiGridCtr;
    private MozartUC.apiGroupBox Frame5;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.ComboBox cboAnnee;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid ApiGridSite;
    private MozartUC.apiLabel lblSiteSomme;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiLabel lblClient;
    private MozartUC.apiLabel lblTitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
