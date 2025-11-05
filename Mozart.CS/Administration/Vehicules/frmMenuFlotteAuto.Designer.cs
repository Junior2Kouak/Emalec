namespace MozartCS
{
  partial class frmMenuFlotteAuto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFlotteAuto));
			this.cmdSinistres = new MozartUC.apiButton();
			this.cmdPool = new MozartUC.apiButton();
			this.cmdVehicules = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdLocations = new MozartUC.apiButton();
			this.cmdDepenses = new MozartUC.apiButton();
			this.cmdEquipements = new MozartUC.apiButton();
			this.PanelStat = new System.Windows.Forms.Panel();
			this.cmdB0 = new MozartUC.apiButton();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.cmdB8 = new MozartUC.apiButton();
			this.cmdB7 = new MozartUC.apiButton();
			this.cmdB6 = new MozartUC.apiButton();
			this.cmdB5 = new MozartUC.apiButton();
			this.cmdB4 = new MozartUC.apiButton();
			this.cmdB3 = new MozartUC.apiButton();
			this.cmdB2 = new MozartUC.apiButton();
			this.cmdB1 = new MozartUC.apiButton();
			this.ButtonDetails = new System.Windows.Forms.Button();
			this.panelListe = new System.Windows.Forms.Panel();
			this.lblTitre = new MozartUC.apiLabel();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.PanelStat.SuspendLayout();
			this.panelListe.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdSinistres
			// 
			this.cmdSinistres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdSinistres, "cmdSinistres");
			this.cmdSinistres.HelpContextID = 96;
			this.cmdSinistres.Name = "cmdSinistres";
			this.cmdSinistres.Tag = "";
			this.cmdSinistres.UseVisualStyleBackColor = false;
			this.cmdSinistres.Click += new System.EventHandler(this.cmdSinistres_Click);
			// 
			// cmdPool
			// 
			this.cmdPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdPool, "cmdPool");
			this.cmdPool.HelpContextID = 95;
			this.cmdPool.Name = "cmdPool";
			this.cmdPool.Tag = "";
			this.cmdPool.UseVisualStyleBackColor = false;
			this.cmdPool.Click += new System.EventHandler(this.cmdPool_Click);
			// 
			// cmdVehicules
			// 
			this.cmdVehicules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdVehicules, "cmdVehicules");
			this.cmdVehicules.HelpContextID = 99;
			this.cmdVehicules.Name = "cmdVehicules";
			this.cmdVehicules.Tag = "";
			this.cmdVehicules.UseVisualStyleBackColor = false;
			this.cmdVehicules.Click += new System.EventHandler(this.cmdVehicules_Click);
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
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// cmdLocations
			// 
			this.cmdLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdLocations, "cmdLocations");
			this.cmdLocations.HelpContextID = 97;
			this.cmdLocations.Name = "cmdLocations";
			this.cmdLocations.Tag = "";
			this.cmdLocations.UseVisualStyleBackColor = false;
			this.cmdLocations.Click += new System.EventHandler(this.cmdLocations_Click);
			// 
			// cmdDepenses
			// 
			this.cmdDepenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdDepenses, "cmdDepenses");
			this.cmdDepenses.HelpContextID = 94;
			this.cmdDepenses.Name = "cmdDepenses";
			this.cmdDepenses.Tag = "";
			this.cmdDepenses.UseVisualStyleBackColor = false;
			this.cmdDepenses.Click += new System.EventHandler(this.cmdDepenses_Click);
			// 
			// cmdEquipements
			// 
			this.cmdEquipements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdEquipements, "cmdEquipements");
			this.cmdEquipements.HelpContextID = 98;
			this.cmdEquipements.Name = "cmdEquipements";
			this.cmdEquipements.Tag = "";
			this.cmdEquipements.UseVisualStyleBackColor = false;
			this.cmdEquipements.Click += new System.EventHandler(this.cmdEquipements_Click);
			// 
			// PanelStat
			// 
			this.PanelStat.BackColor = System.Drawing.Color.Bisque;
			this.PanelStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelStat.Controls.Add(this.cmdB0);
			this.PanelStat.Controls.Add(this.apiSocieteAuto1);
			this.PanelStat.Controls.Add(this.cmdB8);
			this.PanelStat.Controls.Add(this.cmdB7);
			this.PanelStat.Controls.Add(this.cmdB6);
			this.PanelStat.Controls.Add(this.cmdB5);
			this.PanelStat.Controls.Add(this.cmdB4);
			this.PanelStat.Controls.Add(this.cmdB3);
			this.PanelStat.Controls.Add(this.cmdB2);
			this.PanelStat.Controls.Add(this.cmdB1);
			resources.ApplyResources(this.PanelStat, "PanelStat");
			this.PanelStat.Name = "PanelStat";
			// 
			// cmdB0
			// 
			this.cmdB0.BackColor = System.Drawing.Color.Green;
			resources.ApplyResources(this.cmdB0, "cmdB0");
			this.cmdB0.ForeColor = System.Drawing.Color.White;
			this.cmdB0.HelpContextID = 0;
			this.cmdB0.Name = "cmdB0";
			this.cmdB0.Tag = "Véhicules arrivants à échéance";
			this.cmdB0.UseVisualStyleBackColor = false;
			this.cmdB0.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = true;
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.IdMenuParent = ((short)(93));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// cmdB8
			// 
			this.cmdB8.BackColor = System.Drawing.Color.SteelBlue;
			resources.ApplyResources(this.cmdB8, "cmdB8");
			this.cmdB8.ForeColor = System.Drawing.Color.White;
			this.cmdB8.HelpContextID = 0;
			this.cmdB8.Name = "cmdB8";
			this.cmdB8.Tag = "Moyenne PRK VU";
			this.cmdB8.UseVisualStyleBackColor = false;
			// 
			// cmdB7
			// 
			this.cmdB7.BackColor = System.Drawing.Color.SteelBlue;
			resources.ApplyResources(this.cmdB7, "cmdB7");
			this.cmdB7.ForeColor = System.Drawing.Color.White;
			this.cmdB7.HelpContextID = 0;
			this.cmdB7.Name = "cmdB7";
			this.cmdB7.Tag = "Moyenne PRK VP";
			this.cmdB7.UseVisualStyleBackColor = false;
			// 
			// cmdB6
			// 
			this.cmdB6.BackColor = System.Drawing.Color.RosyBrown;
			resources.ApplyResources(this.cmdB6, "cmdB6");
			this.cmdB6.ForeColor = System.Drawing.Color.White;
			this.cmdB6.HelpContextID = 0;
			this.cmdB6.Name = "cmdB6";
			this.cmdB6.Tag = "Sinistres 2025";
			this.cmdB6.UseVisualStyleBackColor = false;
			// 
			// cmdB5
			// 
			this.cmdB5.BackColor = System.Drawing.Color.Chocolate;
			resources.ApplyResources(this.cmdB5, "cmdB5");
			this.cmdB5.ForeColor = System.Drawing.Color.White;
			this.cmdB5.HelpContextID = 0;
			this.cmdB5.Name = "cmdB5";
			this.cmdB5.Tag = "Révisions en retard";
			this.cmdB5.UseVisualStyleBackColor = false;
			this.cmdB5.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// cmdB4
			// 
			this.cmdB4.BackColor = System.Drawing.Color.SteelBlue;
			resources.ApplyResources(this.cmdB4, "cmdB4");
			this.cmdB4.ForeColor = System.Drawing.Color.White;
			this.cmdB4.HelpContextID = 0;
			this.cmdB4.Name = "cmdB4";
			this.cmdB4.Tag = "VP";
			this.cmdB4.UseVisualStyleBackColor = false;
			this.cmdB4.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// cmdB3
			// 
			this.cmdB3.BackColor = System.Drawing.Color.SteelBlue;
			resources.ApplyResources(this.cmdB3, "cmdB3");
			this.cmdB3.ForeColor = System.Drawing.Color.White;
			this.cmdB3.HelpContextID = 0;
			this.cmdB3.Name = "cmdB3";
			this.cmdB3.Tag = "VU";
			this.cmdB3.UseVisualStyleBackColor = false;
			this.cmdB3.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// cmdB2
			// 
			this.cmdB2.BackColor = System.Drawing.Color.Orange;
			resources.ApplyResources(this.cmdB2, "cmdB2");
			this.cmdB2.ForeColor = System.Drawing.Color.White;
			this.cmdB2.HelpContextID = 0;
			this.cmdB2.Name = "cmdB2";
			this.cmdB2.Tag = "Véhicules en réparation";
			this.cmdB2.UseVisualStyleBackColor = false;
			this.cmdB2.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// cmdB1
			// 
			this.cmdB1.BackColor = System.Drawing.Color.Green;
			resources.ApplyResources(this.cmdB1, "cmdB1");
			this.cmdB1.ForeColor = System.Drawing.Color.White;
			this.cmdB1.HelpContextID = 0;
			this.cmdB1.Name = "cmdB1";
			this.cmdB1.Tag = "Véhicules disponibles";
			this.cmdB1.UseVisualStyleBackColor = false;
			this.cmdB1.Click += new System.EventHandler(this.cmdB_Click);
			// 
			// ButtonDetails
			// 
			resources.ApplyResources(this.ButtonDetails, "ButtonDetails");
			this.ButtonDetails.Name = "ButtonDetails";
			this.ButtonDetails.UseVisualStyleBackColor = true;
			this.ButtonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
			// 
			// panelListe
			// 
			this.panelListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.panelListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelListe.Controls.Add(this.ButtonDetails);
			this.panelListe.Controls.Add(this.lblTitre);
			this.panelListe.Controls.Add(this.apiTGrid1);
			resources.ApplyResources(this.panelListe, "panelListe");
			this.panelListe.Name = "panelListe";
			// 
			// lblTitre
			// 
			resources.ApplyResources(this.lblTitre, "lblTitre");
			this.lblTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitre.HelpContextID = 0;
			this.lblTitre.Name = "lblTitre";
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			// 
			// frmMenuFlotteAuto
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelListe);
			this.Controls.Add(this.PanelStat);
			this.Controls.Add(this.cmdEquipements);
			this.Controls.Add(this.cmdDepenses);
			this.Controls.Add(this.cmdLocations);
			this.Controls.Add(this.cmdSinistres);
			this.Controls.Add(this.cmdPool);
			this.Controls.Add(this.cmdVehicules);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Label1);
			this.Name = "frmMenuFlotteAuto";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMenuFlotteAuto_Load);
			this.PanelStat.ResumeLayout(false);
			this.panelListe.ResumeLayout(false);
			this.panelListe.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSinistres;
    private MozartUC.apiButton cmdPool;
    private MozartUC.apiButton cmdVehicules;
    private MozartUC.apiButton cmdQuitter;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
        private MozartUC.apiButton cmdLocations;
    private MozartUC.apiButton cmdDepenses;
    private MozartUC.apiButton cmdEquipements;
		private System.Windows.Forms.Panel PanelStat;
		private MozartUC.apiButton cmdB1;
		private MozartUC.apiButton cmdB8;
		private MozartUC.apiButton cmdB7;
		private MozartUC.apiButton cmdB6;
		private MozartUC.apiButton cmdB5;
		private MozartUC.apiButton cmdB4;
		private MozartUC.apiButton cmdB3;
		private MozartUC.apiButton cmdB2;
		internal MozartUC.apiSocieteAuto apiSocieteAuto1;
		private MozartUC.apiButton cmdB0;
		internal System.Windows.Forms.Button ButtonDetails;
		private System.Windows.Forms.Panel panelListe;
		private MozartUC.apiLabel lblTitre;
		private MozartUC.apiTGrid apiTGrid1;
	}
}
