namespace MozartCS
{
  partial class frmGestWebPer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestWebPer));
            this.CmdSendAccesQCM = new MozartUC.apiButton();
            this.Command2 = new MozartUC.apiButton();
            this.Command1 = new MozartUC.apiButton();
            this.cmdMail = new MozartUC.apiButton();
            this.cmdAcces = new MozartUC.apiButton();
            this.cmdInit = new MozartUC.apiButton();
            this.ApiGrid = new MozartUC.apiTGrid();
            this.cmdSupprimer = new MozartUC.apiButton();
            this.cmdAjouter = new MozartUC.apiButton();
            this.cmdDetail = new MozartUC.apiButton();
            this.cmdFermer = new MozartUC.apiButton();
            this.cmdValider = new MozartUC.apiButton();
            this.LblNINTNUM = new MozartUC.apiLabel();
            this.Label6 = new MozartUC.apiLabel();
            this.LblIdWeb = new MozartUC.apiLabel();
            this.Label12 = new MozartUC.apiLabel();
            this.Label11 = new MozartUC.apiLabel();
            this.Label10 = new MozartUC.apiLabel();
            this.Frame1 = new MozartUC.apiGroupBox();
            this.lblIdentifiant = new MozartUC.apiLabel();
            this.txtDbl = new MozartUC.apiTextBox();
            this.cboDroit = new System.Windows.Forms.ComboBox();
            this.txtUtilisateur = new MozartUC.apiTextBox();
            this.txt_pwd = new MozartUC.apiTextBox();
            this.Label5 = new MozartUC.apiLabel();
            this.Label4 = new MozartUC.apiLabel();
            this.Label3 = new MozartUC.apiLabel();
            this.Label2 = new MozartUC.apiLabel();
            this.Frame2 = new MozartUC.apiGroupBox();
            this.lblTitre = new MozartUC.apiLabel();
            this.apiLabel1 = new MozartUC.apiLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new MozartUC.apiButton();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdSendAccesQCM
            // 
            resources.ApplyResources(this.CmdSendAccesQCM, "CmdSendAccesQCM");
            this.CmdSendAccesQCM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdSendAccesQCM.HelpContextID = 0;
            this.CmdSendAccesQCM.Name = "CmdSendAccesQCM";
            this.CmdSendAccesQCM.Tag = "Envoi mail";
            this.CmdSendAccesQCM.UseVisualStyleBackColor = true;
            this.CmdSendAccesQCM.Click += new System.EventHandler(this.CmdSendAccesQCM_Click);
            // 
            // Command2
            // 
            resources.ApplyResources(this.Command2, "Command2");
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.HelpContextID = 0;
            this.Command2.Name = "Command2";
            this.Command2.Tag = "Profil standard avec prev";
            this.Command2.UseVisualStyleBackColor = true;
            this.Command2.Click += new System.EventHandler(this.Command2_Click);
            // 
            // Command1
            // 
            resources.ApplyResources(this.Command1, "Command1");
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.HelpContextID = 0;
            this.Command1.Name = "Command1";
            this.Command1.Tag = "Profil standard sans prev";
            this.Command1.UseVisualStyleBackColor = true;
            this.Command1.Click += new System.EventHandler(this.Command1_Click);
            // 
            // cmdMail
            // 
            resources.ApplyResources(this.cmdMail, "cmdMail");
            this.cmdMail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdMail.HelpContextID = 0;
            this.cmdMail.Name = "cmdMail";
            this.cmdMail.Tag = "Envoi mail";
            this.cmdMail.UseVisualStyleBackColor = true;
            this.cmdMail.Click += new System.EventHandler(this.cmdMail_Click);
            // 
            // cmdAcces
            // 
            resources.ApplyResources(this.cmdAcces, "cmdAcces");
            this.cmdAcces.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAcces.HelpContextID = 0;
            this.cmdAcces.Name = "cmdAcces";
            this.cmdAcces.Tag = "Accès menu";
            this.cmdAcces.UseVisualStyleBackColor = true;
            this.cmdAcces.Click += new System.EventHandler(this.cmdAcces_Click);
            // 
            // cmdInit
            // 
            resources.ApplyResources(this.cmdInit, "cmdInit");
            this.cmdInit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdInit.HelpContextID = 0;
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Tag = "Initialiser";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // ApiGrid
            // 
            this.ApiGrid.FilterBar = true;
            this.ApiGrid.FooterBar = true;
            resources.ApplyResources(this.ApiGrid, "ApiGrid");
            this.ApiGrid.Name = "ApiGrid";
            // 
            // cmdSupprimer
            // 
            resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
            this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSupprimer.HelpContextID = 0;
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Tag = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdAjouter
            // 
            resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
            this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAjouter.HelpContextID = 0;
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Tag = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdDetail
            // 
            resources.ApplyResources(this.cmdDetail, "cmdDetail");
            this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDetail.HelpContextID = 0;
            this.cmdDetail.Name = "cmdDetail";
            this.cmdDetail.Tag = "Détail";
            this.cmdDetail.UseVisualStyleBackColor = true;
            this.cmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
            // 
            // cmdFermer
            // 
            resources.ApplyResources(this.cmdFermer, "cmdFermer");
            this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFermer.HelpContextID = 0;
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Tag = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // cmdValider
            // 
            resources.ApplyResources(this.cmdValider, "cmdValider");
            this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdValider.HelpContextID = 0;
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Tag = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // LblNINTNUM
            // 
            this.LblNINTNUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.LblNINTNUM, "LblNINTNUM");
            this.LblNINTNUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblNINTNUM.HelpContextID = 0;
            this.LblNINTNUM.Name = "LblNINTNUM";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Label6.HelpContextID = 0;
            this.Label6.Name = "Label6";
            // 
            // LblIdWeb
            // 
            this.LblIdWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.LblIdWeb, "LblIdWeb");
            this.LblIdWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblIdWeb.HelpContextID = 0;
            this.LblIdWeb.Name = "LblIdWeb";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Label12.HelpContextID = 0;
            this.Label12.Name = "Label12";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Label11.HelpContextID = 0;
            this.Label11.Name = "Label11";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Label10.HelpContextID = 0;
            this.Label10.Name = "Label10";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Frame1.Controls.Add(this.lblIdentifiant);
            this.Frame1.Controls.Add(this.LblNINTNUM);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.LblIdWeb);
            this.Frame1.Controls.Add(this.Label12);
            this.Frame1.Controls.Add(this.Label11);
            this.Frame1.Controls.Add(this.Label10);
            resources.ApplyResources(this.Frame1, "Frame1");
            this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Frame1.FrameColor = System.Drawing.Color.Empty;
            this.Frame1.HelpContextID = 0;
            this.Frame1.Name = "Frame1";
            this.Frame1.TabStop = false;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.lblIdentifiant, "lblIdentifiant");
            this.lblIdentifiant.ForeColor = System.Drawing.Color.Red;
            this.lblIdentifiant.HelpContextID = 0;
            this.lblIdentifiant.Name = "lblIdentifiant";
            // 
            // txtDbl
            // 
            this.txtDbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDbl.HelpContextID = 0;
            resources.ApplyResources(this.txtDbl, "txtDbl");
            this.txtDbl.Name = "txtDbl";
            // 
            // cboDroit
            // 
            this.cboDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cboDroit, "cboDroit");
            this.cboDroit.Name = "cboDroit";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtUtilisateur, "txtUtilisateur");
            this.txtUtilisateur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUtilisateur.HelpContextID = 0;
            this.txtUtilisateur.Name = "txtUtilisateur";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_pwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pwd.HelpContextID = 0;
            resources.ApplyResources(this.txt_pwd, "txt_pwd");
            this.txt_pwd.Name = "txt_pwd";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.HelpContextID = 0;
            this.Label5.Name = "Label5";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.HelpContextID = 0;
            this.Label4.Name = "Label4";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.HelpContextID = 0;
            this.Label3.Name = "Label3";
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.HelpContextID = 0;
            this.Label2.Name = "Label2";
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Frame2.Controls.Add(this.txtDbl);
            this.Frame2.Controls.Add(this.cboDroit);
            this.Frame2.Controls.Add(this.txtUtilisateur);
            this.Frame2.Controls.Add(this.txt_pwd);
            this.Frame2.Controls.Add(this.Label5);
            this.Frame2.Controls.Add(this.Label4);
            this.Frame2.Controls.Add(this.Label3);
            this.Frame2.Controls.Add(this.Label2);
            resources.ApplyResources(this.Frame2, "Frame2");
            this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Frame2.FrameColor = System.Drawing.Color.Empty;
            this.Frame2.HelpContextID = 0;
            this.Frame2.Name = "Frame2";
            this.Frame2.TabStop = false;
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.BackColor = System.Drawing.Color.Wheat;
            this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitre.HelpContextID = 0;
            this.lblTitre.Name = "lblTitre";
            // 
            // apiLabel1
            // 
            resources.ApplyResources(this.apiLabel1, "apiLabel1");
            this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
            this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiLabel1.HelpContextID = 0;
            this.apiLabel1.Name = "apiLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdSupprimer);
            this.panel1.Controls.Add(this.ApiGrid);
            this.panel1.Controls.Add(this.cmdAjouter);
            this.panel1.Controls.Add(this.cmdDetail);
            this.panel1.Controls.Add(this.apiLabel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BtnDelete
            // 
            resources.ApplyResources(this.BtnDelete, "BtnDelete");
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDelete.HelpContextID = 0;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Tag = "";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // frmGestWebPer
            // 
            this.AcceptButton = this.cmdFermer;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdFermer;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CmdSendAccesQCM);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.Command1);
            this.Controls.Add(this.cmdMail);
            this.Controls.Add(this.cmdAcces);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.Frame2);
            this.Name = "frmGestWebPer";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestWebPer_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdSendAccesQCM;
    private MozartUC.apiButton Command2;
    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdMail;
    private MozartUC.apiButton cmdAcces;
    private MozartUC.apiButton cmdInit;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel LblNINTNUM;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel LblIdWeb;
    private MozartUC.apiLabel Label12;
    private MozartUC.apiLabel Label11;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTextBox txtDbl;
    private System.Windows.Forms.ComboBox cboDroit;
    private MozartUC.apiTextBox txtUtilisateur;
    private MozartUC.apiTextBox txt_pwd;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiLabel apiLabel1;
    private System.Windows.Forms.Panel panel1;
    private MozartUC.apiLabel lblIdentifiant;
        private MozartUC.apiButton BtnDelete;
        // TODO GetCodeDeclareControl cas non traitÃ© pour type VB.Line

    }
}
