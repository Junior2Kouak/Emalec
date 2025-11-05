namespace MozartCS
{
  partial class frmListDocOTTech
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDocOTTech));
			this.cmdValider = new MozartUC.apiButton();
			this.cmdAnnuler = new MozartUC.apiButton();
			this.lstEns = new System.Windows.Forms.CheckedListBox();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.BtnDeCocheTS = new MozartUC.apiButton();
			this.BtnCocheTS = new MozartUC.apiButton();
			this.cmdcopier = new MozartUC.apiButton();
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.CmdMax = new MozartUC.apiButton();
			this.cmdAjout = new MozartUC.apiButton();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.cmdModifier = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.txtClient = new MozartUC.apiTextBox();
			this.txtSite = new MozartUC.apiTextBox();
			this.txtDI = new MozartUC.apiTextBox();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.apigrid = new MozartUC.apiTGrid();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValider.HelpContextID = 0;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.UseVisualStyleBackColor = true;
			this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
			// 
			// cmdAnnuler
			// 
			resources.ApplyResources(this.cmdAnnuler, "cmdAnnuler");
			this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAnnuler.HelpContextID = 0;
			this.cmdAnnuler.Name = "cmdAnnuler";
			this.cmdAnnuler.UseVisualStyleBackColor = true;
			this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
			// 
			// lstEns
			// 
			this.lstEns.CheckOnClick = true;
			resources.ApplyResources(this.lstEns, "lstEns");
			this.lstEns.Name = "lstEns";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.BtnDeCocheTS);
			this.Frame1.Controls.Add(this.BtnCocheTS);
			this.Frame1.Controls.Add(this.cmdValider);
			this.Frame1.Controls.Add(this.cmdAnnuler);
			this.Frame1.Controls.Add(this.lstEns);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// BtnDeCocheTS
			// 
			resources.ApplyResources(this.BtnDeCocheTS, "BtnDeCocheTS");
			this.BtnDeCocheTS.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnDeCocheTS.HelpContextID = 0;
			this.BtnDeCocheTS.Name = "BtnDeCocheTS";
			this.BtnDeCocheTS.UseVisualStyleBackColor = true;
			this.BtnDeCocheTS.Click += new System.EventHandler(this.BtnDeCocheTS_Click);
			// 
			// BtnCocheTS
			// 
			resources.ApplyResources(this.BtnCocheTS, "BtnCocheTS");
			this.BtnCocheTS.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnCocheTS.HelpContextID = 0;
			this.BtnCocheTS.Name = "BtnCocheTS";
			this.BtnCocheTS.UseVisualStyleBackColor = true;
			this.BtnCocheTS.Click += new System.EventHandler(this.BtnCocheTS_Click);
			// 
			// cmdcopier
			// 
			resources.ApplyResources(this.cmdcopier, "cmdcopier");
			this.cmdcopier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdcopier.HelpContextID = 0;
			this.cmdcopier.Name = "cmdcopier";
			this.cmdcopier.Tag = "27";
			this.cmdcopier.UseVisualStyleBackColor = true;
			this.cmdcopier.Click += new System.EventHandler(this.cmdCopier_Click);
			// 
			// WebBrowser1
			// 
			resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
			this.WebBrowser1.Name = "WebBrowser1";
			// 
			// CmdMax
			// 
			resources.ApplyResources(this.CmdMax, "CmdMax");
			this.CmdMax.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdMax.HelpContextID = 0;
			this.CmdMax.Name = "CmdMax";
			this.CmdMax.UseVisualStyleBackColor = true;
			this.CmdMax.Click += new System.EventHandler(this.CmdMax_Click);
			// 
			// cmdAjout
			// 
			resources.ApplyResources(this.cmdAjout, "cmdAjout");
			this.cmdAjout.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAjout.HelpContextID = 0;
			this.cmdAjout.Name = "cmdAjout";
			this.cmdAjout.Tag = "2";
			this.cmdAjout.UseVisualStyleBackColor = true;
			this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
			// 
			// cmdSupprimer
			// 
			resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
			this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupprimer.HelpContextID = 0;
			this.cmdSupprimer.Name = "cmdSupprimer";
			this.cmdSupprimer.Tag = "27";
			this.cmdSupprimer.UseVisualStyleBackColor = true;
			this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
			// 
			// cmdModifier
			// 
			resources.ApplyResources(this.cmdModifier, "cmdModifier");
			this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdModifier.HelpContextID = 0;
			this.cmdModifier.Name = "cmdModifier";
			this.cmdModifier.Tag = "19";
			this.cmdModifier.UseVisualStyleBackColor = true;
			this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
			// txtClient
			// 
			this.txtClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtClient, "txtClient");
			this.txtClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtClient.HelpContextID = 0;
			this.txtClient.Name = "txtClient";
			// 
			// txtSite
			// 
			this.txtSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtSite, "txtSite");
			this.txtSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtSite.HelpContextID = 0;
			this.txtSite.Name = "txtSite";
			// 
			// txtDI
			// 
			this.txtDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtDI, "txtDI");
			this.txtDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.txtDI.HelpContextID = 0;
			this.txtDI.Name = "txtDI";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels2
			// 
			resources.ApplyResources(this.lblLabels2, "lblLabels2");
			this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels2.HelpContextID = 0;
			this.lblLabels2.Name = "lblLabels2";
			// 
			// lblLabels3
			// 
			resources.ApplyResources(this.lblLabels3, "lblLabels3");
			this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels3.HelpContextID = 0;
			this.lblLabels3.Name = "lblLabels3";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame2.Controls.Add(this.txtClient);
			this.Frame2.Controls.Add(this.txtSite);
			this.Frame2.Controls.Add(this.txtDI);
			this.Frame2.Controls.Add(this.lblLabels0);
			this.Frame2.Controls.Add(this.lblLabels2);
			this.Frame2.Controls.Add(this.lblLabels3);
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// apigrid
			// 
			this.apigrid.FilterBar = true;
			resources.ApplyResources(this.apigrid, "apigrid");
			this.apigrid.FooterBar = true;
			this.apigrid.Name = "apigrid";
			this.apigrid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apigrid_ClickE);
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmListDocOTTech
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdcopier);
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.CmdMax);
			this.Controls.Add(this.cmdAjout);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdModifier);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.apigrid);
			this.Controls.Add(this.Label1);
			this.Name = "frmListDocOTTech";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListDocOTTech_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdAnnuler;
    private System.Windows.Forms.CheckedListBox lstEns;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdcopier;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiButton CmdMax;
    private MozartUC.apiButton cmdAjout;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTextBox txtClient;
    private MozartUC.apiTextBox txtSite;
    private MozartUC.apiTextBox txtDI;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton BtnDeCocheTS;
    private MozartUC.apiButton BtnCocheTS;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
