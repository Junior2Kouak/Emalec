namespace MozartCS
{
  partial class frmListeFichesKMS
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFichesKMS));
      this.apicboImmat = new MozartUC.apiCombo();
      this.apicboConducteur = new MozartUC.apiCombo();
      this.cmdScanFrais = new MozartUC.apiButton();
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.cmdDate = new MozartUC.apiButton();
      this.cmdFind = new MozartUC.apiButton();
      this.txtCritDate = new MozartUC.apiTextBox();
      this.Label2 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.label14 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.CmdMax = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTgrid = new MozartUC.apiTGrid();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // apicboImmat
      // 
      resources.ApplyResources(this.apicboImmat, "apicboImmat");
      this.apicboImmat.Name = "apicboImmat";
      // 
      // apicboConducteur
      // 
      resources.ApplyResources(this.apicboConducteur, "apicboConducteur");
      this.apicboConducteur.Name = "apicboConducteur";
      // 
      // cmdScanFrais
      // 
      resources.ApplyResources(this.cmdScanFrais, "cmdScanFrais");
      this.cmdScanFrais.HelpContextID = 0;
      this.cmdScanFrais.Name = "cmdScanFrais";
      this.cmdScanFrais.Tag = "2";
      this.cmdScanFrais.UseVisualStyleBackColor = true;
      this.cmdScanFrais.Click += new System.EventHandler(this.CmdScanFrais_Click);
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
      // cmdDate
      // 
      this.cmdDate.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "5";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // cmdFind
      // 
      this.cmdFind.BackColor = System.Drawing.Color.Transparent;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = false;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // txtCritDate
      // 
      resources.ApplyResources(this.txtCritDate, "txtCritDate");
      this.txtCritDate.HelpContextID = 0;
      this.txtCritDate.Name = "txtCritDate";
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
      // fraCriteres
      // 
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.cmdDate);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.txtCritDate);
      this.fraCriteres.Controls.Add(this.Label2);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.Controls.Add(this.lblPeriode);
      this.fraCriteres.Controls.Add(this.label14);
      this.fraCriteres.HelpContextID = 0;
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // CmdMax
      // 
      resources.ApplyResources(this.CmdMax, "CmdMax");
      this.CmdMax.HelpContextID = 0;
      this.CmdMax.Name = "CmdMax";
      this.CmdMax.UseVisualStyleBackColor = true;
      this.CmdMax.Click += new System.EventHandler(this.CmdMax_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
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
      // apiTgrid
      // 
      this.apiTgrid.FilterBar = true;
      this.apiTgrid.FooterBar = true;
      resources.ApplyResources(this.apiTgrid, "apiTgrid");
      this.apiTgrid.Name = "apiTgrid";
      this.apiTgrid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTgrid_ClickE);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeFichesKMS
      // 
      this.AcceptButton = this.cmdFind;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apicboImmat);
      this.Controls.Add(this.apicboConducteur);
      this.Controls.Add(this.cmdScanFrais);
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.CmdMax);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTgrid);
      this.Controls.Add(this.WebBrowser1);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeFichesKMS";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeFichesKMS_FormClosing);
      this.Load += new System.EventHandler(this.frmListeFichesKMS_Load);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiCombo apicboImmat;
    private MozartUC.apiCombo apicboConducteur;
    private MozartUC.apiButton cmdScanFrais;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiTextBox txtCritDate;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel lblPeriode;
    private MozartUC.apiLabel label14;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiButton CmdMax;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTgrid;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
