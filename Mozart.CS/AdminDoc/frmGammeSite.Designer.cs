namespace MozartCS
{
  partial class frmGammeSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGammeSite));
      this.lstCat = new System.Windows.Forms.CheckedListBox();
      this.cmdCocherTC = new MozartUC.apiButton();
      this.cmdDecocherTC = new MozartUC.apiButton();
      this.lstDet = new System.Windows.Forms.CheckedListBox();
      this.lblNbSitesC = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdAjout = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.txtContrat = new MozartUC.apiTextBox();
      this.cboSite = new System.Windows.Forms.ComboBox();
      this.cboNumSite = new System.Windows.Forms.ComboBox();
      this.txtAE = new MozartUC.apiTextBox();
      this.txtDate = new MozartUC.apiTextBox();
      this.txtNum = new MozartUC.apiTextBox();
      this.cboType = new System.Windows.Forms.ComboBox();
      this.Label6 = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.apicboClient = new MozartUC.apiCombo();
      this.Label14 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstCat
      // 
      resources.ApplyResources(this.lstCat, "lstCat");
      this.lstCat.Name = "lstCat";
      this.lstCat.SelectedIndexChanged += new System.EventHandler(this.lstCat_SelectedIndexChanged);
      // 
      // cmdCocherTC
      // 
      resources.ApplyResources(this.cmdCocherTC, "cmdCocherTC");
      this.cmdCocherTC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCocherTC.HelpContextID = 0;
      this.cmdCocherTC.Name = "cmdCocherTC";
      this.cmdCocherTC.UseVisualStyleBackColor = true;
      this.cmdCocherTC.Click += new System.EventHandler(this.cmdCocherTC_Click);
      // 
      // cmdDecocherTC
      // 
      resources.ApplyResources(this.cmdDecocherTC, "cmdDecocherTC");
      this.cmdDecocherTC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDecocherTC.HelpContextID = 0;
      this.cmdDecocherTC.Name = "cmdDecocherTC";
      this.cmdDecocherTC.UseVisualStyleBackColor = true;
      this.cmdDecocherTC.Click += new System.EventHandler(this.cmdDecocherTC_Click);
      // 
      // lstDet
      // 
      resources.ApplyResources(this.lstDet, "lstDet");
      this.lstDet.Name = "lstDet";
      // 
      // lblNbSitesC
      // 
      this.lblNbSitesC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblNbSitesC, "lblNbSitesC");
      this.lblNbSitesC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNbSitesC.HelpContextID = 0;
      this.lblNbSitesC.Name = "lblNbSitesC";
      this.lblNbSitesC.Tag = "Nb catégories cochées :";
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.lstCat);
      this.Frame1.Controls.Add(this.cmdCocherTC);
      this.Frame1.Controls.Add(this.cmdDecocherTC);
      this.Frame1.Controls.Add(this.lstDet);
      this.Frame1.Controls.Add(this.lblNbSitesC);
      this.Frame1.Controls.Add(this.Label7);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdAjout
      // 
      resources.ApplyResources(this.cmdAjout, "cmdAjout");
      this.cmdAjout.HelpContextID = 0;
      this.cmdAjout.Name = "cmdAjout";
      this.cmdAjout.Tag = "2";
      this.cmdAjout.UseVisualStyleBackColor = true;
      this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
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
      // txtContrat
      // 
      this.txtContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtContrat, "txtContrat");
      this.txtContrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtContrat.HelpContextID = 0;
      this.txtContrat.Name = "txtContrat";
      // 
      // cboSite
      // 
      this.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboSite, "cboSite");
      this.cboSite.Name = "cboSite";
      this.cboSite.SelectedIndexChanged += new System.EventHandler(this.cboSite_SelectedIndexChanged);
      // 
      // cboNumSite
      // 
      this.cboNumSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboNumSite, "cboNumSite");
      this.cboNumSite.Name = "cboNumSite";
      this.cboNumSite.SelectedIndexChanged += new System.EventHandler(this.cboNumSite_SelectedIndexChanged);
      // 
      // txtAE
      // 
      this.txtAE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtAE, "txtAE");
      this.txtAE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtAE.HelpContextID = 0;
      this.txtAE.Name = "txtAE";
      // 
      // txtDate
      // 
      this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtDate.HelpContextID = 0;
      this.txtDate.Name = "txtDate";
      // 
      // txtNum
      // 
      this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNum, "txtNum");
      this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNum.HelpContextID = 0;
      this.txtNum.Name = "txtNum";
      // 
      // cboType
      // 
      this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboType, "cboType");
      this.cboType.Name = "cboType";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // lblLabels8
      // 
      this.lblLabels8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels4
      // 
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // Label5
      // 
      this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.txtContrat);
      this.Frame4.Controls.Add(this.cboSite);
      this.Frame4.Controls.Add(this.cboNumSite);
      this.Frame4.Controls.Add(this.txtAE);
      this.Frame4.Controls.Add(this.txtDate);
      this.Frame4.Controls.Add(this.txtNum);
      this.Frame4.Controls.Add(this.cboType);
      this.Frame4.Controls.Add(this.Label6);
      this.Frame4.Controls.Add(this.lblLabels8);
      this.Frame4.Controls.Add(this.lblLabels4);
      this.Frame4.Controls.Add(this.Label5);
      this.Frame4.Controls.Add(this.Label2);
      this.Frame4.Controls.Add(this.Label4);
      this.Frame4.Controls.Add(this.Label3);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // apicboClient
      // 
      this.apicboClient.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.apicboClient, "apicboClient");
      this.apicboClient.Name = "apicboClient";
      this.apicboClient.Leave += new System.EventHandler(this.cboclient_Leave);
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmGammeSite
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apicboClient);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdAjout);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.Label14);
      this.Name = "frmGammeSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGammeSite_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckedListBox lstCat;
    private MozartUC.apiButton cmdCocherTC;
    private MozartUC.apiButton cmdDecocherTC;
    private System.Windows.Forms.CheckedListBox lstDet;
    private MozartUC.apiLabel lblNbSitesC;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdAjout;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtContrat;
    private System.Windows.Forms.ComboBox cboSite;
    private System.Windows.Forms.ComboBox cboNumSite;
    private MozartUC.apiTextBox txtAE;
    private MozartUC.apiTextBox txtDate;
    private MozartUC.apiTextBox txtNum;
    private System.Windows.Forms.ComboBox cboType;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiLabel Label14;
    private MozartUC.apiCombo apicboClient;
  }
}
