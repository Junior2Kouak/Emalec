namespace MozartCS
{
  partial class frmSaisieKM
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieKM));
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.cmdValider = new MozartUC.apiButton();
      this.txtFinPer = new MozartUC.apiTextBox();
      this.cmdFinPer = new MozartUC.apiButton();
      this.txtDebPer = new MozartUC.apiTextBox();
      this.cmdDebPer = new MozartUC.apiButton();
      this.cmdStatClient = new MozartUC.apiButton();
      this.cboType = new System.Windows.Forms.ComboBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.Label31 = new MozartUC.apiLabel();
      this.Label30 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.ApiGrid = new MozartUC.apiTGrid();
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
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtFinPer
      // 
      resources.ApplyResources(this.txtFinPer, "txtFinPer");
      this.txtFinPer.HelpContextID = 0;
      this.txtFinPer.Name = "txtFinPer";
      // 
      // cmdFinPer
      // 
      this.cmdFinPer.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdFinPer, "cmdFinPer");
      this.cmdFinPer.HelpContextID = 0;
      this.cmdFinPer.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdFinPer.Name = "cmdFinPer";
      this.cmdFinPer.Tag = "5";
      this.cmdFinPer.UseVisualStyleBackColor = false;
      this.cmdFinPer.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDebPer
      // 
      resources.ApplyResources(this.txtDebPer, "txtDebPer");
      this.txtDebPer.HelpContextID = 0;
      this.txtDebPer.Name = "txtDebPer";
      // 
      // cmdDebPer
      // 
      this.cmdDebPer.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDebPer, "cmdDebPer");
      this.cmdDebPer.HelpContextID = 0;
      this.cmdDebPer.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDebPer.Name = "cmdDebPer";
      this.cmdDebPer.Tag = "5";
      this.cmdDebPer.UseVisualStyleBackColor = false;
      this.cmdDebPer.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // cmdStatClient
      // 
      resources.ApplyResources(this.cmdStatClient, "cmdStatClient");
      this.cmdStatClient.HelpContextID = 134;
      this.cmdStatClient.Name = "cmdStatClient";
      this.cmdStatClient.Tag = "35";
      this.cmdStatClient.UseVisualStyleBackColor = true;
      this.cmdStatClient.Click += new System.EventHandler(this.cmdStatClient_Click);
      // 
      // cboType
      // 
      this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboType, "cboType");
      this.cboType.Items.AddRange(new object[] {
            resources.GetString("cboType.Items"),
            resources.GetString("cboType.Items1"),
            resources.GetString("cboType.Items2")});
      this.cboType.Name = "cboType";
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // Label31
      // 
      resources.ApplyResources(this.Label31, "Label31");
      this.Label31.BackColor = System.Drawing.Color.Wheat;
      this.Label31.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label31.HelpContextID = 0;
      this.Label31.Name = "Label31";
      // 
      // Label30
      // 
      resources.ApplyResources(this.Label30, "Label30");
      this.Label30.BackColor = System.Drawing.Color.Wheat;
      this.Label30.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label30.HelpContextID = 0;
      this.Label30.Name = "Label30";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
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
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      // 
      // frmSaisieKM
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.txtFinPer);
      this.Controls.Add(this.cmdFinPer);
      this.Controls.Add(this.txtDebPer);
      this.Controls.Add(this.cmdDebPer);
      this.Controls.Add(this.cmdStatClient);
      this.Controls.Add(this.cboType);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.Label31);
      this.Controls.Add(this.Label30);
      this.Controls.Add(this.lblLabels1);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.ApiGrid);
      this.Name = "frmSaisieKM";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaisieKM_FormClosing);
      this.Load += new System.EventHandler(this.frmSaisieKM_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtFinPer;
    private MozartUC.apiButton cmdFinPer;
    private MozartUC.apiTextBox txtDebPer;
    private MozartUC.apiButton cmdDebPer;
    private MozartUC.apiButton cmdStatClient;
    private System.Windows.Forms.ComboBox cboType;
    // TODO GetCodeDeclareControl cas non traité pour type Mozaris.ApiGrid
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiLabel Label31;
    private MozartUC.apiLabel Label30;
    private MozartUC.apiLabel lblLabels1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid ApiGrid;
  }
}
