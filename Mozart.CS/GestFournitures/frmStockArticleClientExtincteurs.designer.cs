namespace MozartCS
{
  partial class frmStockArticleClientExtincteurs
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockArticleClientExtincteurs));
      this.cmdSaisieCoeff = new MozartUC.apiButton();
      this.cmdP3 = new MozartUC.apiButton();
      this.cmdP2 = new MozartUC.apiButton();
      this.cmdP1 = new MozartUC.apiButton();
      this.cmdSuppTout = new MozartUC.apiButton();
      this.cmdImport = new MozartUC.apiButton();
      this.cmdRechercher = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.frameSearch = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.mnuAffichageWeb = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAffecterTous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDesaffecter = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuContrat = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAffecterContrat = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDesaffecterContrat = new System.Windows.Forms.ToolStripMenuItem();
      this.frameSearch.SuspendLayout();
      this.mnuAffichageWeb.SuspendLayout();
      this.mnuContrat.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdSaisieCoeff
      // 
      resources.ApplyResources(this.cmdSaisieCoeff, "cmdSaisieCoeff");
      this.cmdSaisieCoeff.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSaisieCoeff.HelpContextID = 660;
      this.cmdSaisieCoeff.Name = "cmdSaisieCoeff";
      this.cmdSaisieCoeff.Tag = "67";
      this.cmdSaisieCoeff.UseVisualStyleBackColor = true;
      this.cmdSaisieCoeff.Click += new System.EventHandler(this.cmdSaisieCoeff_Click);
      // 
      // cmdP3
      // 
      resources.ApplyResources(this.cmdP3, "cmdP3");
      this.cmdP3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdP3.HelpContextID = 256;
      this.cmdP3.Name = "cmdP3";
      this.cmdP3.Tag = "2";
      this.cmdP3.UseVisualStyleBackColor = true;
      this.cmdP3.Click += new System.EventHandler(this.cmdP3_Click);
      // 
      // cmdP2
      // 
      resources.ApplyResources(this.cmdP2, "cmdP2");
      this.cmdP2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdP2.HelpContextID = 256;
      this.cmdP2.Name = "cmdP2";
      this.cmdP2.Tag = "2";
      this.cmdP2.UseVisualStyleBackColor = true;
      this.cmdP2.Click += new System.EventHandler(this.cmdP2_Click);
      // 
      // cmdP1
      // 
      resources.ApplyResources(this.cmdP1, "cmdP1");
      this.cmdP1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdP1.HelpContextID = 256;
      this.cmdP1.Name = "cmdP1";
      this.cmdP1.Tag = "2";
      this.cmdP1.UseVisualStyleBackColor = true;
      this.cmdP1.Click += new System.EventHandler(this.cmdP1_Click);
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
      // cmdImport
      // 
      resources.ApplyResources(this.cmdImport, "cmdImport");
      this.cmdImport.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImport.HelpContextID = 256;
      this.cmdImport.Name = "cmdImport";
      this.cmdImport.Tag = "2";
      this.cmdImport.UseVisualStyleBackColor = true;
      this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      this.apiTGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.apiTGrid_RowCellClick);
      this.apiTGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGrid_CellValueChanged);
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.Name = "Label2";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.Name = "Label3";
      // 
      // mnuAffichageWeb
      // 
      this.mnuAffichageWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAffecterTous,
            this.mnuDesaffecter});
      this.mnuAffichageWeb.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuAffichageWeb, "mnuAffichageWeb");
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
      // frmStockArticleClientExtincteurs
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSaisieCoeff);
      this.Controls.Add(this.cmdP3);
      this.Controls.Add(this.cmdP2);
      this.Controls.Add(this.cmdP1);
      this.Controls.Add(this.cmdSuppTout);
      this.Controls.Add(this.cmdImport);
      this.Controls.Add(this.cmdRechercher);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.frameSearch);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label3);
      this.Name = "frmStockArticleClientExtincteurs";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockArticleClientExtincteurs_Load);
      this.frameSearch.ResumeLayout(false);
      this.mnuAffichageWeb.ResumeLayout(false);
      this.mnuContrat.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSaisieCoeff;
    private MozartUC.apiButton cmdP3;
    private MozartUC.apiButton cmdP2;
    private MozartUC.apiButton cmdP1;
    private MozartUC.apiButton cmdSuppTout;
    private MozartUC.apiButton cmdImport;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiGroupBox frameSearch;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label3;
    private System.Windows.Forms.ContextMenuStrip mnuAffichageWeb;
    private System.Windows.Forms.ToolStripMenuItem mnuAffecterTous;
    private System.Windows.Forms.ToolStripMenuItem mnuDesaffecter;
    private System.Windows.Forms.ContextMenuStrip mnuContrat;
    private System.Windows.Forms.ToolStripMenuItem mnuAffecterContrat;
    private System.Windows.Forms.ToolStripMenuItem mnuDesaffecterContrat;
  }
}
