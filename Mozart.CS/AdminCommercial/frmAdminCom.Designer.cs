namespace MozartCS
{
  partial class frmAdminCom
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCom));
      this.Frame1 = new MozartUC.apiGroupBox();
      this.CmdChoixStatClose = new MozartUC.apiButton();
      this.cmdProsp = new MozartUC.apiButton();
      this.CmdStatCliCom = new MozartUC.apiButton();
      this.FrameCliProsp = new MozartUC.apiGroupBox();
      this.apiTGridCliProsp = new MozartUC.apiTGrid();
      this.CmdAnnule = new MozartUC.apiButton();
      this.cmdValide = new MozartUC.apiButton();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.CmdQui = new MozartUC.apiButton();
      this.cmdCourrier = new MozartUC.apiButton();
      this.cmdSuivi = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.CmdChoixStat = new MozartUC.apiButton();
      this.cmdClients = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.BtnSuiviContratCli = new MozartUC.apiButton();
      this.cmdRefonteProspe = new MozartUC.apiButton();
      this.cmdGestGroupe = new MozartUC.apiButton();
      this.cmdGestSecteurs = new MozartUC.apiButton();
      this.cmdGestOffreCom = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      this.FrameCliProsp.SuspendLayout();
      this.SuspendLayout();
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.CmdChoixStatClose);
      this.Frame1.Controls.Add(this.cmdProsp);
      this.Frame1.Controls.Add(this.CmdStatCliCom);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // CmdChoixStatClose
      // 
      this.CmdChoixStatClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdChoixStatClose, "CmdChoixStatClose");
      this.CmdChoixStatClose.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdChoixStatClose.HelpContextID = 151;
      this.CmdChoixStatClose.Name = "CmdChoixStatClose";
      this.CmdChoixStatClose.UseVisualStyleBackColor = false;
      this.CmdChoixStatClose.Click += new System.EventHandler(this.CmdChoixStatClose_Click);
      // 
      // cmdProsp
      // 
      this.cmdProsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdProsp, "cmdProsp");
      this.cmdProsp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdProsp.HelpContextID = 283;
      this.cmdProsp.Name = "cmdProsp";
      this.cmdProsp.Tag = "35";
      this.cmdProsp.UseVisualStyleBackColor = false;
      this.cmdProsp.Click += new System.EventHandler(this.cmdProsp_Click);
      // 
      // CmdStatCliCom
      // 
      this.CmdStatCliCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdStatCliCom, "CmdStatCliCom");
      this.CmdStatCliCom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdStatCliCom.HelpContextID = 282;
      this.CmdStatCliCom.Name = "CmdStatCliCom";
      this.CmdStatCliCom.Tag = "67";
      this.CmdStatCliCom.UseVisualStyleBackColor = false;
      this.CmdStatCliCom.Click += new System.EventHandler(this.CmdStatCliCom_Click);
      // 
      // FrameCliProsp
      // 
      resources.ApplyResources(this.FrameCliProsp, "FrameCliProsp");
      this.FrameCliProsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.FrameCliProsp.Controls.Add(this.apiTGridCliProsp);
      this.FrameCliProsp.Controls.Add(this.CmdAnnule);
      this.FrameCliProsp.Controls.Add(this.cmdValide);
      this.FrameCliProsp.Controls.Add(this.Label2);
      this.FrameCliProsp.Controls.Add(this.Label3);
      this.FrameCliProsp.FrameColor = System.Drawing.Color.Empty;
      this.FrameCliProsp.HelpContextID = 0;
      this.FrameCliProsp.Name = "FrameCliProsp";
      this.FrameCliProsp.TabStop = false;
      // 
      // apiTGridCliProsp
      // 
      resources.ApplyResources(this.apiTGridCliProsp, "apiTGridCliProsp");
      this.apiTGridCliProsp.CounterColumn = null;
      this.apiTGridCliProsp.FilterBar = true;
      this.apiTGridCliProsp.FooterBar = true;
      this.apiTGridCliProsp.Name = "apiTGridCliProsp";
      this.apiTGridCliProsp.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGridCliProsp_DoubleClickE);
      // 
      // CmdAnnule
      // 
      resources.ApplyResources(this.CmdAnnule, "CmdAnnule");
      this.CmdAnnule.HelpContextID = 0;
      this.CmdAnnule.Name = "CmdAnnule";
      this.CmdAnnule.UseVisualStyleBackColor = true;
      this.CmdAnnule.Click += new System.EventHandler(this.cmdAnnule_Click);
      // 
      // cmdValide
      // 
      resources.ApplyResources(this.cmdValide, "cmdValide");
      this.cmdValide.HelpContextID = 0;
      this.cmdValide.Name = "cmdValide";
      this.cmdValide.UseVisualStyleBackColor = true;
      this.cmdValide.Click += new System.EventHandler(this.cmdValide_Click);
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.Name = "Label2";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.Name = "Label3";
      // 
      // CmdQui
      // 
      this.CmdQui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdQui, "CmdQui");
      this.CmdQui.HelpContextID = 276;
      this.CmdQui.Name = "CmdQui";
      this.CmdQui.Tag = "23";
      this.CmdQui.UseVisualStyleBackColor = false;
      this.CmdQui.Click += new System.EventHandler(this.CmdQui_Click);
      // 
      // cmdCourrier
      // 
      this.cmdCourrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdCourrier, "cmdCourrier");
      this.cmdCourrier.HelpContextID = 0;
      this.cmdCourrier.Name = "cmdCourrier";
      this.cmdCourrier.Tag = "36";
      this.cmdCourrier.UseVisualStyleBackColor = false;
      this.cmdCourrier.Click += new System.EventHandler(this.cmdCourrier_Click);
      // 
      // cmdSuivi
      // 
      this.cmdSuivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSuivi, "cmdSuivi");
      this.cmdSuivi.HelpContextID = 152;
      this.cmdSuivi.Name = "cmdSuivi";
      this.cmdSuivi.Tag = "68";
      this.cmdSuivi.UseVisualStyleBackColor = false;
      this.cmdSuivi.Click += new System.EventHandler(this.cmdSuivi_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // CmdChoixStat
      // 
      this.CmdChoixStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdChoixStat, "CmdChoixStat");
      this.CmdChoixStat.HelpContextID = 151;
      this.CmdChoixStat.Name = "CmdChoixStat";
      this.CmdChoixStat.Tag = "34";
      this.CmdChoixStat.UseVisualStyleBackColor = false;
      this.CmdChoixStat.Click += new System.EventHandler(this.CmdChoixStat_Click);
      // 
      // cmdClients
      // 
      this.cmdClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdClients, "cmdClients");
      this.cmdClients.HelpContextID = 514;
      this.cmdClients.Name = "cmdClients";
      this.cmdClients.Tag = "35";
      this.cmdClients.UseVisualStyleBackColor = false;
      this.cmdClients.Click += new System.EventHandler(this.cmdClients_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // BtnSuiviContratCli
      // 
      this.BtnSuiviContratCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.BtnSuiviContratCli, "BtnSuiviContratCli");
      this.BtnSuiviContratCli.HelpContextID = 724;
      this.BtnSuiviContratCli.Name = "BtnSuiviContratCli";
      this.BtnSuiviContratCli.Tag = "36";
      this.BtnSuiviContratCli.UseVisualStyleBackColor = false;
      this.BtnSuiviContratCli.Click += new System.EventHandler(this.BtnSuiviContratCli_Click);
      // 
      // cmdRefonteProspe
      // 
      this.cmdRefonteProspe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdRefonteProspe, "cmdRefonteProspe");
      this.cmdRefonteProspe.HelpContextID = 0;
      this.cmdRefonteProspe.Name = "cmdRefonteProspe";
      this.cmdRefonteProspe.Tag = "68";
      this.cmdRefonteProspe.UseVisualStyleBackColor = false;
      this.cmdRefonteProspe.Click += new System.EventHandler(this.cmdRefonteProspe_Click);
      // 
      // cmdGestGroupe
      // 
      this.cmdGestGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGestGroupe, "cmdGestGroupe");
      this.cmdGestGroupe.HelpContextID = 763;
      this.cmdGestGroupe.Name = "cmdGestGroupe";
      this.cmdGestGroupe.Tag = "36";
      this.cmdGestGroupe.UseVisualStyleBackColor = false;
      this.cmdGestGroupe.Click += new System.EventHandler(this.cmdGestGroupe_Click);
      // 
      // cmdGestSecteurs
      // 
      this.cmdGestSecteurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGestSecteurs, "cmdGestSecteurs");
      this.cmdGestSecteurs.HelpContextID = 762;
      this.cmdGestSecteurs.Name = "cmdGestSecteurs";
      this.cmdGestSecteurs.Tag = "36";
      this.cmdGestSecteurs.UseVisualStyleBackColor = false;
      this.cmdGestSecteurs.Click += new System.EventHandler(this.cmdGestSecteurs_Click);
      // 
      // cmdGestOffreCom
      // 
      this.cmdGestOffreCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGestOffreCom, "cmdGestOffreCom");
      this.cmdGestOffreCom.HelpContextID = 764;
      this.cmdGestOffreCom.Name = "cmdGestOffreCom";
      this.cmdGestOffreCom.Tag = "36";
      this.cmdGestOffreCom.UseVisualStyleBackColor = false;
      this.cmdGestOffreCom.Click += new System.EventHandler(this.cmdGestOffreCom_Click);
      // 
      // frmAdminCom
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdGestOffreCom);
      this.Controls.Add(this.cmdGestSecteurs);
      this.Controls.Add(this.cmdGestGroupe);
      this.Controls.Add(this.cmdRefonteProspe);
      this.Controls.Add(this.BtnSuiviContratCli);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.FrameCliProsp);
      this.Controls.Add(this.CmdQui);
      this.Controls.Add(this.cmdCourrier);
      this.Controls.Add(this.cmdSuivi);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.CmdChoixStat);
      this.Controls.Add(this.cmdClients);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminCom";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminCom_Load);
      this.Frame1.ResumeLayout(false);
      this.FrameCliProsp.ResumeLayout(false);
      this.FrameCliProsp.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiGroupBox FrameCliProsp;
    private MozartUC.apiButton CmdQui;
    private MozartUC.apiButton cmdCourrier;
    private MozartUC.apiButton cmdSuivi;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton CmdChoixStat;
    private MozartUC.apiButton cmdClients;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiButton CmdChoixStatClose;
    private MozartUC.apiButton cmdProsp;
    private MozartUC.apiButton CmdStatCliCom;
    private MozartUC.apiTGrid apiTGridCliProsp;
    private MozartUC.apiButton CmdAnnule;
    private MozartUC.apiButton cmdValide;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label3;
    private MozartUC.apiButton BtnSuiviContratCli;
    private MozartUC.apiButton cmdRefonteProspe;
    private MozartUC.apiButton cmdGestGroupe;
    private MozartUC.apiButton cmdGestSecteurs;
    private MozartUC.apiButton cmdGestOffreCom;
  }
}
