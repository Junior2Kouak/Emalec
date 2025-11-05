namespace MozartCS
{
  partial class frmStockArticleClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockArticleClient));
      this.CmdCoeffTousCli = new MozartUC.apiButton();
      this.cmdSuppTout = new MozartUC.apiButton();
      this.cmdSaisieCoeff = new MozartUC.apiButton();
      this.cmdCoef = new MozartUC.apiButton();
      this.cmdFournisseur = new MozartUC.apiButton();
      this.cmdRechercher = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.frameSearch = new MozartUC.apiGroupBox();
      this.cboClient = new MozartUC.apiCombo();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Frame6 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.mnuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAffecterTous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDesaffecter = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuContrat = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAffecterContrat = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDesaffecterContrat = new System.Windows.Forms.ToolStripMenuItem();
      this.frameSearch.SuspendLayout();
      this.Frame6.SuspendLayout();
      this.mnuAffichage.SuspendLayout();
      this.mnuContrat.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdCoeffTousCli
      // 
      resources.ApplyResources(this.CmdCoeffTousCli, "CmdCoeffTousCli");
      this.CmdCoeffTousCli.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdCoeffTousCli.HelpContextID = 637;
      this.CmdCoeffTousCli.Name = "CmdCoeffTousCli";
      this.CmdCoeffTousCli.Tag = "67";
      this.CmdCoeffTousCli.UseVisualStyleBackColor = true;
      this.CmdCoeffTousCli.Click += new System.EventHandler(this.CmdCoeffTousCli_Click);
      // 
      // cmdSuppTout
      // 
      resources.ApplyResources(this.cmdSuppTout, "cmdSuppTout");
      this.cmdSuppTout.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuppTout.HelpContextID = 156;
      this.cmdSuppTout.Name = "cmdSuppTout";
      this.cmdSuppTout.Tag = "27";
      this.cmdSuppTout.UseVisualStyleBackColor = true;
      this.cmdSuppTout.Click += new System.EventHandler(this.cmdSuppTout_Click);
      // 
      // cmdSaisieCoeff
      // 
      resources.ApplyResources(this.cmdSaisieCoeff, "cmdSaisieCoeff");
      this.cmdSaisieCoeff.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSaisieCoeff.HelpContextID = 256;
      this.cmdSaisieCoeff.Name = "cmdSaisieCoeff";
      this.cmdSaisieCoeff.Tag = "67";
      this.cmdSaisieCoeff.UseVisualStyleBackColor = true;
      this.cmdSaisieCoeff.Click += new System.EventHandler(this.cmdSaisieCoeff_Click);
      // 
      // cmdCoef
      // 
      resources.ApplyResources(this.cmdCoef, "cmdCoef");
      this.cmdCoef.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCoef.HelpContextID = 74;
      this.cmdCoef.Name = "cmdCoef";
      this.cmdCoef.Tag = "85";
      this.cmdCoef.UseVisualStyleBackColor = true;
      this.cmdCoef.Click += new System.EventHandler(this.cmdCoef_Click);
      // 
      // cmdFournisseur
      // 
      resources.ApplyResources(this.cmdFournisseur, "cmdFournisseur");
      this.cmdFournisseur.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFournisseur.HelpContextID = 156;
      this.cmdFournisseur.Name = "cmdFournisseur";
      this.cmdFournisseur.Tag = "87";
      this.cmdFournisseur.UseVisualStyleBackColor = true;
      this.cmdFournisseur.Click += new System.EventHandler(this.cmdFournisseur_Click);
      // 
      // cmdRechercher
      // 
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRechercher.HelpContextID = 156;
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "91";
      this.cmdRechercher.UseVisualStyleBackColor = true;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 156;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      this.apiTGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.apiTGrid_RowCellClick);
      this.apiTGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.ApiGrid_CellValueChanged);
      // 
      // frameSearch
      // 
      resources.ApplyResources(this.frameSearch, "frameSearch");
      this.frameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.frameSearch.Controls.Add(this.apiTGrid);
      this.frameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.frameSearch.FrameColor = System.Drawing.Color.Empty;
      this.frameSearch.HelpContextID = 0;
      this.frameSearch.Name = "frameSearch";
      this.frameSearch.TabStop = false;
      // 
      // cboClient
      // 
      resources.ApplyResources(this.cboClient, "cboClient");
      this.cboClient.Name = "cboClient";
      this.cboClient.NewValues = false;
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Frame6
      // 
      resources.ApplyResources(this.Frame6, "Frame6");
      this.Frame6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame6.Controls.Add(this.lblLabels11);
      this.Frame6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame6.FrameColor = System.Drawing.Color.Empty;
      this.Frame6.HelpContextID = 0;
      this.Frame6.Name = "Frame6";
      this.Frame6.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 156;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // mnuAffichage
      // 
      this.mnuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAffecterTous,
            this.mnuDesaffecter});
      this.mnuAffichage.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuAffichage, "mnuAffichage");
      // 
      // mnuAffecterTous
      // 
      this.mnuAffecterTous.Name = "mnuAffecterTous";
      resources.ApplyResources(this.mnuAffecterTous, "mnuAffecterTous");
      this.mnuAffecterTous.Click += new System.EventHandler(this.mnuAffecterTous_Click);
      // 
      // mnuDesaffecter
      // 
      this.mnuDesaffecter.Name = "mnuDesaffecter";
      resources.ApplyResources(this.mnuDesaffecter, "mnuDesaffecter");
      this.mnuDesaffecter.Click += new System.EventHandler(this.mnuDesaffecter_Click);
      // 
      // mnuContrat
      // 
      this.mnuContrat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAffecterContrat,
            this.mnuDesaffecterContrat});
      this.mnuContrat.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuContrat, "mnuContrat");
      // 
      // mnuAffecterContrat
      // 
      this.mnuAffecterContrat.Name = "mnuAffecterContrat";
      resources.ApplyResources(this.mnuAffecterContrat, "mnuAffecterContrat");
      this.mnuAffecterContrat.Click += new System.EventHandler(this.mnuAffecterContrat_Click);
      // 
      // mnuDesaffecterContrat
      // 
      this.mnuDesaffecterContrat.Name = "mnuDesaffecterContrat";
      resources.ApplyResources(this.mnuDesaffecterContrat, "mnuDesaffecterContrat");
      this.mnuDesaffecterContrat.Click += new System.EventHandler(this.mnuDesaffecterContrat_Click);
      // 
      // frmStockArticleClient
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdCoeffTousCli);
      this.Controls.Add(this.cboClient);
      this.Controls.Add(this.cmdSuppTout);
      this.Controls.Add(this.cmdSaisieCoeff);
      this.Controls.Add(this.cmdCoef);
      this.Controls.Add(this.cmdFournisseur);
      this.Controls.Add(this.cmdRechercher);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.frameSearch);
      this.Controls.Add(this.Frame6);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmStockArticleClient";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockArticleClient_Load);
      this.frameSearch.ResumeLayout(false);
      this.Frame6.ResumeLayout(false);
      this.mnuAffichage.ResumeLayout(false);
      this.mnuContrat.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdCoeffTousCli;
    private MozartUC.apiButton cmdSuppTout;
    private MozartUC.apiButton cmdSaisieCoeff;
    private MozartUC.apiButton cmdCoef;
    private MozartUC.apiButton cmdFournisseur;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiGroupBox frameSearch;
    private MozartUC.apiCombo cboClient;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiGroupBox Frame6;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.ContextMenuStrip mnuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuAffecterTous;
    private System.Windows.Forms.ToolStripMenuItem mnuDesaffecter;
    private System.Windows.Forms.ContextMenuStrip mnuContrat;
    private System.Windows.Forms.ToolStripMenuItem mnuAffecterContrat;
    private System.Windows.Forms.ToolStripMenuItem mnuDesaffecterContrat;
  }
}
