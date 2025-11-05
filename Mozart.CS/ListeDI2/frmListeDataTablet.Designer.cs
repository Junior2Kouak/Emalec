namespace MozartCS
{
  partial class frmListeDataTablet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDataTablet));
            this.txtAct = new MozartUC.apiTextBox();
            this.framAct = new MozartUC.apiGroupBox();
            this.txtWeb = new MozartUC.apiTextBox();
            this.cmdAnnule = new MozartUC.apiButton();
            this.FrameWeb = new MozartUC.apiGroupBox();
            this.cmdVisu = new MozartUC.apiButton();
            this.cmdArchiver = new MozartUC.apiButton();
            this.cmdArchives = new MozartUC.apiButton();
            this.cmdValider = new MozartUC.apiButton();
            this.cmdQuitter = new MozartUC.apiButton();
            this.apiTGrid = new MozartUC.apiTGrid();
            this.apiTGridClients = new MozartUC.apiTGrid();
            this.apiTGridChaff = new MozartUC.apiTGrid();
            this.Label4 = new MozartUC.apiLabel();
            this.Label5 = new MozartUC.apiLabel();
            this.BtnInventairesEquipement = new MozartUC.apiButton();
            this.framAct.SuspendLayout();
            this.FrameWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAct
            // 
            this.txtAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtAct, "txtAct");
            this.txtAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAct.HelpContextID = 0;
            this.txtAct.Name = "txtAct";
            // 
            // framAct
            // 
            this.framAct.Controls.Add(this.txtAct);
            resources.ApplyResources(this.framAct, "framAct");
            this.framAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.framAct.FrameColor = System.Drawing.Color.Empty;
            this.framAct.HelpContextID = 0;
            this.framAct.Name = "framAct";
            this.framAct.TabStop = false;
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtWeb, "txtWeb");
            this.txtWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtWeb.HelpContextID = 0;
            this.txtWeb.Name = "txtWeb";
            // 
            // cmdAnnule
            // 
            this.cmdAnnule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.cmdAnnule, "cmdAnnule");
            this.cmdAnnule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAnnule.HelpContextID = 0;
            this.cmdAnnule.Name = "cmdAnnule";
            this.cmdAnnule.UseVisualStyleBackColor = false;
            this.cmdAnnule.Click += new System.EventHandler(this.CmdAnnule_Click);
            // 
            // FrameWeb
            // 
            this.FrameWeb.Controls.Add(this.txtWeb);
            this.FrameWeb.Controls.Add(this.cmdAnnule);
            resources.ApplyResources(this.FrameWeb, "FrameWeb");
            this.FrameWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FrameWeb.FrameColor = System.Drawing.Color.Empty;
            this.FrameWeb.HelpContextID = 0;
            this.FrameWeb.Name = "FrameWeb";
            this.FrameWeb.TabStop = false;
            // 
            // cmdVisu
            // 
            resources.ApplyResources(this.cmdVisu, "cmdVisu");
            this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdVisu.HelpContextID = 0;
            this.cmdVisu.Name = "cmdVisu";
            this.cmdVisu.Tag = "66";
            this.cmdVisu.UseVisualStyleBackColor = true;
            this.cmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
            // 
            // cmdArchiver
            // 
            this.cmdArchiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
            this.cmdArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdArchiver.HelpContextID = 24;
            this.cmdArchiver.Name = "cmdArchiver";
            this.cmdArchiver.Tag = "27";
            this.cmdArchiver.UseVisualStyleBackColor = false;
            this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
            // 
            // cmdArchives
            // 
            resources.ApplyResources(this.cmdArchives, "cmdArchives");
            this.cmdArchives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdArchives.HelpContextID = 0;
            this.cmdArchives.Name = "cmdArchives";
            this.cmdArchives.Tag = "28";
            this.cmdArchives.UseVisualStyleBackColor = true;
            this.cmdArchives.Click += new System.EventHandler(this.CmdArchives_Click);
            // 
            // cmdValider
            // 
            resources.ApplyResources(this.cmdValider, "cmdValider");
            this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdValider.HelpContextID = 0;
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Tag = "66";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // cmdQuitter
            // 
            resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
            this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdQuitter.HelpContextID = 0;
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // apiTGrid
            // 
            resources.ApplyResources(this.apiTGrid, "apiTGrid");
            this.apiTGrid.FilterBar = true;
            this.apiTGrid.FooterBar = true;
            this.apiTGrid.Name = "apiTGrid";
            // 
            // apiTGridClients
            // 
            resources.ApplyResources(this.apiTGridClients, "apiTGridClients");
            this.apiTGridClients.FilterBar = true;
            this.apiTGridClients.FooterBar = true;
            this.apiTGridClients.Name = "apiTGridClients";
            // 
            // apiTGridChaff
            // 
            resources.ApplyResources(this.apiTGridChaff, "apiTGridChaff");
            this.apiTGridChaff.FilterBar = true;
            this.apiTGridChaff.FooterBar = true;
            this.apiTGridChaff.Name = "apiTGridChaff";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.BackColor = System.Drawing.Color.Wheat;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.HelpContextID = 0;
            this.Label4.Name = "Label4";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.BackColor = System.Drawing.Color.Wheat;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.HelpContextID = 0;
            this.Label5.Name = "Label5";
            // 
            // BtnInventairesEquipement
            // 
            resources.ApplyResources(this.BtnInventairesEquipement, "BtnInventairesEquipement");
            this.BtnInventairesEquipement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnInventairesEquipement.HelpContextID = 742;
            this.BtnInventairesEquipement.Name = "BtnInventairesEquipement";
            this.BtnInventairesEquipement.Tag = "66";
            this.BtnInventairesEquipement.UseVisualStyleBackColor = true;
            this.BtnInventairesEquipement.Click += new System.EventHandler(this.BtnInventairesEquipement_Click);
            // 
            // frmListeDataTablet
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdQuitter;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.BtnInventairesEquipement);
            this.Controls.Add(this.framAct);
            this.Controls.Add(this.FrameWeb);
            this.Controls.Add(this.cmdVisu);
            this.Controls.Add(this.cmdArchiver);
            this.Controls.Add(this.cmdArchives);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.apiTGrid);
            this.Controls.Add(this.apiTGridClients);
            this.Controls.Add(this.apiTGridChaff);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Name = "frmListeDataTablet";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListeDataTablet_FormClosed);
            this.Load += new System.EventHandler(this.frmListeDataTablet_Load);
            this.framAct.ResumeLayout(false);
            this.framAct.PerformLayout();
            this.FrameWeb.ResumeLayout(false);
            this.FrameWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtAct;
    private MozartUC.apiGroupBox framAct;
    private MozartUC.apiTextBox txtWeb;
    private MozartUC.apiButton cmdAnnule;
    private MozartUC.apiGroupBox FrameWeb;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton cmdArchives;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiTGrid apiTGridClients;
    private MozartUC.apiTGrid apiTGridChaff;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label5;
        private MozartUC.apiButton BtnInventairesEquipement;
        // TODO GetCodeDeclareControl cas non traité pour type VB.Line

    }
}
