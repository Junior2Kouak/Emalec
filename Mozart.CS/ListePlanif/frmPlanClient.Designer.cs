namespace MozartCS
{
  partial class frmPlanClient
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanClient));
      this.cmdRefresh = new MozartUC.apiButton();
      this.cmdLegende = new MozartUC.apiButton();
      this.cmdContS = new MozartUC.apiButton();
      this.cmdContP = new MozartUC.apiButton();
      this.cmdTechS = new MozartUC.apiButton();
      this.cmdTechP = new MozartUC.apiButton();
      this.cmdSemSuiv = new MozartUC.apiButton();
      this.cmdSemPrec = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.cboclient = new MozartUC.apiCombo();
      this.lblSemaine = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.grilleUITech = new MozartCS.frmPlanClient.grillePlanning();
      this.lblDimanche = new System.Windows.Forms.Label();
      this.lblSamedi = new System.Windows.Forms.Label();
      this.lblVendredi = new System.Windows.Forms.Label();
      this.lblJeudi = new System.Windows.Forms.Label();
      this.lblMercredi = new System.Windows.Forms.Label();
      this.lblMardi = new System.Windows.Forms.Label();
      this.lblLundi = new System.Windows.Forms.Label();
      this.grilleUISTT = new MozartCS.frmPlanClient.grillePlanning();
      this.menuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuDetails = new System.Windows.Forms.ToolStripMenuItem();
      this.grilleUITech.SuspendLayout();
      this.menuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdRefresh
      // 
      this.cmdRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRefresh.HelpContextID = 0;
      resources.ApplyResources(this.cmdRefresh, "cmdRefresh");
      this.cmdRefresh.Name = "cmdRefresh";
      this.cmdRefresh.UseVisualStyleBackColor = true;
      this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
      // 
      // cmdLegende
      // 
      this.cmdLegende.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdLegende.HelpContextID = 0;
      resources.ApplyResources(this.cmdLegende, "cmdLegende");
      this.cmdLegende.Name = "cmdLegende";
      this.cmdLegende.UseVisualStyleBackColor = true;
      this.cmdLegende.Click += new System.EventHandler(this.cmdLegende_Click);
      // 
      // cmdContS
      // 
      this.cmdContS.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContS.HelpContextID = 0;
      resources.ApplyResources(this.cmdContS, "cmdContS");
      this.cmdContS.Name = "cmdContS";
      this.cmdContS.UseVisualStyleBackColor = true;
      this.cmdContS.Click += new System.EventHandler(this.cmdContS_Click);
      // 
      // cmdContP
      // 
      this.cmdContP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContP.HelpContextID = 0;
      resources.ApplyResources(this.cmdContP, "cmdContP");
      this.cmdContP.Name = "cmdContP";
      this.cmdContP.UseVisualStyleBackColor = true;
      this.cmdContP.Click += new System.EventHandler(this.cmdContP_Click);
      // 
      // cmdTechS
      // 
      this.cmdTechS.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTechS.HelpContextID = 0;
      resources.ApplyResources(this.cmdTechS, "cmdTechS");
      this.cmdTechS.Name = "cmdTechS";
      this.cmdTechS.UseVisualStyleBackColor = true;
      this.cmdTechS.Click += new System.EventHandler(this.cmdTechS_Click);
      // 
      // cmdTechP
      // 
      this.cmdTechP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTechP.HelpContextID = 0;
      resources.ApplyResources(this.cmdTechP, "cmdTechP");
      this.cmdTechP.Name = "cmdTechP";
      this.cmdTechP.UseVisualStyleBackColor = true;
      this.cmdTechP.Click += new System.EventHandler(this.cmdTechP_Click);
      // 
      // cmdSemSuiv
      // 
      resources.ApplyResources(this.cmdSemSuiv, "cmdSemSuiv");
      this.cmdSemSuiv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSemSuiv.HelpContextID = 0;
      this.cmdSemSuiv.Name = "cmdSemSuiv";
      this.cmdSemSuiv.UseVisualStyleBackColor = true;
      this.cmdSemSuiv.Click += new System.EventHandler(this.cmdSemSuiv_Click);
      // 
      // cmdSemPrec
      // 
      resources.ApplyResources(this.cmdSemPrec, "cmdSemPrec");
      this.cmdSemPrec.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSemPrec.HelpContextID = 0;
      this.cmdSemPrec.Name = "cmdSemPrec";
      this.cmdSemPrec.UseVisualStyleBackColor = true;
      this.cmdSemPrec.Click += new System.EventHandler(this.cmdSemPrec_Click);
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
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.Wheat;
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      this.cboclient.cboClick += new MozartUC.apiCombo.cboClickEventHandler(this.cboclient_cboClick);
      this.cboclient.Leave += new System.EventHandler(this.cboclient_Leave);
      // 
      // lblSemaine
      // 
      this.lblSemaine.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblSemaine, "lblSemaine");
      this.lblSemaine.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSemaine.HelpContextID = 0;
      this.lblSemaine.Name = "lblSemaine";
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // grilleUITech
      // 
      this.grilleUITech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.grilleUITech, "grilleUITech");
      this.grilleUITech.Controls.Add(this.lblDimanche, 6, 0);
      this.grilleUITech.Controls.Add(this.lblSamedi, 5, 0);
      this.grilleUITech.Controls.Add(this.lblVendredi, 4, 0);
      this.grilleUITech.Controls.Add(this.lblJeudi, 3, 0);
      this.grilleUITech.Controls.Add(this.lblMercredi, 2, 0);
      this.grilleUITech.Controls.Add(this.lblMardi, 1, 0);
      this.grilleUITech.Controls.Add(this.lblLundi, 0, 0);
      this.grilleUITech.Name = "grilleUITech";
      this.grilleUITech.MouseUp += new System.Windows.Forms.MouseEventHandler(this.table_MouseUp);
      // 
      // lblDimanche
      // 
      resources.ApplyResources(this.lblDimanche, "lblDimanche");
      this.lblDimanche.Name = "lblDimanche";
      // 
      // lblSamedi
      // 
      resources.ApplyResources(this.lblSamedi, "lblSamedi");
      this.lblSamedi.Name = "lblSamedi";
      // 
      // lblVendredi
      // 
      resources.ApplyResources(this.lblVendredi, "lblVendredi");
      this.lblVendredi.Name = "lblVendredi";
      // 
      // lblJeudi
      // 
      resources.ApplyResources(this.lblJeudi, "lblJeudi");
      this.lblJeudi.Name = "lblJeudi";
      // 
      // lblMercredi
      // 
      resources.ApplyResources(this.lblMercredi, "lblMercredi");
      this.lblMercredi.Name = "lblMercredi";
      // 
      // lblMardi
      // 
      resources.ApplyResources(this.lblMardi, "lblMardi");
      this.lblMardi.Name = "lblMardi";
      // 
      // lblLundi
      // 
      resources.ApplyResources(this.lblLundi, "lblLundi");
      this.lblLundi.Name = "lblLundi";
      // 
      // grilleUISTT
      // 
      this.grilleUISTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.grilleUISTT, "grilleUISTT");
      this.grilleUISTT.Name = "grilleUISTT";
      this.grilleUISTT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.table_MouseUp);
      // 
      // menuAffichage
      // 
      this.menuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDetails});
      this.menuAffichage.Name = "contextMenuStrip1";
      resources.ApplyResources(this.menuAffichage, "menuAffichage");
      // 
      // mnuDetails
      // 
      this.mnuDetails.Name = "mnuDetails";
      resources.ApplyResources(this.mnuDetails, "mnuDetails");
      this.mnuDetails.Click += new System.EventHandler(this.mnuDetails_Click);
      // 
      // frmPlanClient
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.grilleUISTT);
      this.Controls.Add(this.grilleUITech);
      this.Controls.Add(this.cmdContS);
      this.Controls.Add(this.cmdContP);
      this.Controls.Add(this.cmdTechS);
      this.Controls.Add(this.cmdTechP);
      this.Controls.Add(this.cmdSemSuiv);
      this.Controls.Add(this.cmdSemPrec);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.cmdRefresh);
      this.Controls.Add(this.cmdLegende);
      this.Controls.Add(this.cboclient);
      this.Controls.Add(this.lblSemaine);
      this.Controls.Add(this.lblLabels11);
      this.KeyPreview = true;
      this.Name = "frmPlanClient";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPlanClient_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPlanClient_KeyUp);
      this.grilleUITech.ResumeLayout(false);
      this.grilleUITech.PerformLayout();
      this.menuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdRefresh;
    private MozartUC.apiButton cmdLegende;
    private MozartUC.apiButton cmdContS;
    private MozartUC.apiButton cmdContP;
    private MozartUC.apiButton cmdTechS;
    private MozartUC.apiButton cmdTechP;
    private MozartUC.apiButton cmdSemSuiv;
    private MozartUC.apiButton cmdSemPrec;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiCombo cboclient;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblSemaine;
    private MozartUC.apiLabel lblLabels11;
    private grillePlanning grilleUITech;
    private grillePlanning grilleUISTT;
    private System.Windows.Forms.Label lblDimanche;
    private System.Windows.Forms.Label lblSamedi;
    private System.Windows.Forms.Label lblVendredi;
    private System.Windows.Forms.Label lblJeudi;
    private System.Windows.Forms.Label lblMercredi;
    private System.Windows.Forms.Label lblMardi;
    private System.Windows.Forms.Label lblLundi;
    private System.Windows.Forms.ContextMenuStrip menuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuDetails;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
