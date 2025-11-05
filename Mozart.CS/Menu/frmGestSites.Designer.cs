namespace MozartCS
{
  partial class frmGestSites
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestSites));
			this.Command1 = new MozartUC.apiButton();
			this.cmdProcSite = new MozartUC.apiButton();
			this.cmdHoraires = new MozartUC.apiButton();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.cmdBudg = new MozartUC.apiButton();
			this.cmdModifier = new MozartUC.apiButton();
			this.cmdAjouter = new MozartUC.apiButton();
			this.cmdCarte = new MozartUC.apiButton();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.cmdArchive = new MozartUC.apiButton();
			this.cmdBudget = new MozartUC.apiButton();
			this.cmdInfo = new MozartUC.apiButton();
			this.cmdST = new MozartUC.apiButton();
			this.cmdCont = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.lblNom = new MozartUC.apiLabel();
			this.lblTitre = new MozartUC.apiLabel();
			this.cmdModifResp = new MozartUC.apiButton();
			this.BtnPlanPrevSite = new MozartUC.apiButton();
			this.BtnInvSite = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// Command1
			// 
			resources.ApplyResources(this.Command1, "Command1");
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.HelpContextID = 78;
			this.Command1.Name = "Command1";
			this.Command1.UseVisualStyleBackColor = true;
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// cmdProcSite
			// 
			resources.ApplyResources(this.cmdProcSite, "cmdProcSite");
			this.cmdProcSite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdProcSite.HelpContextID = 0;
			this.cmdProcSite.Name = "cmdProcSite";
			this.cmdProcSite.UseVisualStyleBackColor = true;
			this.cmdProcSite.Click += new System.EventHandler(this.cmdProcSite_Click);
			// 
			// cmdHoraires
			// 
			resources.ApplyResources(this.cmdHoraires, "cmdHoraires");
			this.cmdHoraires.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdHoraires.HelpContextID = 217;
			this.cmdHoraires.Name = "cmdHoraires";
			this.cmdHoraires.UseVisualStyleBackColor = true;
			this.cmdHoraires.Click += new System.EventHandler(this.cmdHoraires_Click);
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			this.apiTGrid1.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid1_RowStyle);
			this.apiTGrid1.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid1_SelectionChanged);
			// 
			// cmdBudg
			// 
			resources.ApplyResources(this.cmdBudg, "cmdBudg");
			this.cmdBudg.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdBudg.HelpContextID = 176;
			this.cmdBudg.Name = "cmdBudg";
			this.cmdBudg.UseVisualStyleBackColor = true;
			this.cmdBudg.Click += new System.EventHandler(this.cmdBudg_Click);
			// 
			// cmdModifier
			// 
			resources.ApplyResources(this.cmdModifier, "cmdModifier");
			this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdModifier.HelpContextID = 324;
			this.cmdModifier.Name = "cmdModifier";
			this.cmdModifier.Tag = "19";
			this.cmdModifier.UseVisualStyleBackColor = true;
			this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
			// cmdCarte
			// 
			resources.ApplyResources(this.cmdCarte, "cmdCarte");
			this.cmdCarte.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCarte.HelpContextID = 130;
			this.cmdCarte.Name = "cmdCarte";
			this.cmdCarte.UseVisualStyleBackColor = true;
			this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
			// 
			// cmdSupprimer
			// 
			resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
			this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupprimer.HelpContextID = 100;
			this.cmdSupprimer.Name = "cmdSupprimer";
			this.cmdSupprimer.UseVisualStyleBackColor = true;
			this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
			// 
			// cmdArchive
			// 
			resources.ApplyResources(this.cmdArchive, "cmdArchive");
			this.cmdArchive.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdArchive.HelpContextID = 101;
			this.cmdArchive.Name = "cmdArchive";
			this.cmdArchive.UseVisualStyleBackColor = true;
			this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
			// 
			// cmdBudget
			// 
			resources.ApplyResources(this.cmdBudget, "cmdBudget");
			this.cmdBudget.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdBudget.HelpContextID = 81;
			this.cmdBudget.Name = "cmdBudget";
			this.cmdBudget.UseVisualStyleBackColor = true;
			this.cmdBudget.Click += new System.EventHandler(this.cmdBudget_Click);
			// 
			// cmdInfo
			// 
			resources.ApplyResources(this.cmdInfo, "cmdInfo");
			this.cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdInfo.HelpContextID = 80;
			this.cmdInfo.Name = "cmdInfo";
			this.cmdInfo.UseVisualStyleBackColor = true;
			this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
			// 
			// cmdST
			// 
			resources.ApplyResources(this.cmdST, "cmdST");
			this.cmdST.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdST.HelpContextID = 79;
			this.cmdST.Name = "cmdST";
			this.cmdST.UseVisualStyleBackColor = true;
			this.cmdST.Click += new System.EventHandler(this.cmdST_Click);
			// 
			// cmdCont
			// 
			resources.ApplyResources(this.cmdCont, "cmdCont");
			this.cmdCont.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCont.HelpContextID = 78;
			this.cmdCont.Name = "cmdCont";
			this.cmdCont.UseVisualStyleBackColor = true;
			this.cmdCont.Click += new System.EventHandler(this.cmdCont_Click);
			// 
			// cmdFermer
			// 
			resources.ApplyResources(this.cmdFermer, "cmdFermer");
			this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFermer.HelpContextID = 0;
			this.cmdFermer.Name = "cmdFermer";
			this.cmdFermer.Tag = "15";
			this.cmdFermer.UseVisualStyleBackColor = true;
			// 
			// lblNom
			// 
			resources.ApplyResources(this.lblNom, "lblNom");
			this.lblNom.BackColor = System.Drawing.Color.Wheat;
			this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblNom.HelpContextID = 0;
			this.lblNom.Name = "lblNom";
			// 
			// lblTitre
			// 
			resources.ApplyResources(this.lblTitre, "lblTitre");
			this.lblTitre.BackColor = System.Drawing.Color.Wheat;
			this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitre.HelpContextID = 0;
			this.lblTitre.Name = "lblTitre";
			// 
			// cmdModifResp
			// 
			resources.ApplyResources(this.cmdModifResp, "cmdModifResp");
			this.cmdModifResp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdModifResp.HelpContextID = 0;
			this.cmdModifResp.Name = "cmdModifResp";
			this.cmdModifResp.Tag = "2";
			this.cmdModifResp.UseVisualStyleBackColor = true;
			this.cmdModifResp.Click += new System.EventHandler(this.cmdModifResp_Click);
			// 
			// BtnPlanPrevSite
			// 
			resources.ApplyResources(this.BtnPlanPrevSite, "BtnPlanPrevSite");
			this.BtnPlanPrevSite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnPlanPrevSite.HelpContextID = 759;
			this.BtnPlanPrevSite.Name = "BtnPlanPrevSite";
			this.BtnPlanPrevSite.UseVisualStyleBackColor = true;
			this.BtnPlanPrevSite.Click += new System.EventHandler(this.BtnPlanPrevSite_Click);
			// 
			// BtnInvSite
			// 
			resources.ApplyResources(this.BtnInvSite, "BtnInvSite");
			this.BtnInvSite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnInvSite.HelpContextID = 753;
			this.BtnInvSite.Name = "BtnInvSite";
			this.BtnInvSite.UseVisualStyleBackColor = true;
			this.BtnInvSite.Click += new System.EventHandler(this.BtnInvSite_Click);
			// 
			// frmGestSites
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.BtnInvSite);
			this.Controls.Add(this.BtnPlanPrevSite);
			this.Controls.Add(this.cmdModifResp);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.cmdProcSite);
			this.Controls.Add(this.cmdHoraires);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.cmdBudg);
			this.Controls.Add(this.cmdModifier);
			this.Controls.Add(this.cmdAjouter);
			this.Controls.Add(this.cmdCarte);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdArchive);
			this.Controls.Add(this.cmdBudget);
			this.Controls.Add(this.cmdInfo);
			this.Controls.Add(this.cmdST);
			this.Controls.Add(this.cmdCont);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.lblNom);
			this.Controls.Add(this.lblTitre);
			this.KeyPreview = true;
			this.Name = "frmGestSites";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGestSites_FormClosed);
			this.Load += new System.EventHandler(this.frmGestSites_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGestSites_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdProcSite;
    private MozartUC.apiButton cmdHoraires;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiButton cmdBudg;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdCarte;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdBudget;
    private MozartUC.apiButton cmdInfo;
    private MozartUC.apiButton cmdST;
    private MozartUC.apiButton cmdCont;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblNom;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiButton cmdModifResp;
    private MozartUC.apiButton BtnPlanPrevSite;
        private MozartUC.apiButton BtnInvSite;
        // TODO GetCodeDeclareControl cas non traité pour type VB.Line

    }
}
