namespace MozartCS
{
  partial class frmGestContratSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestContratSite));
      this.cmdImplantation = new MozartUC.apiButton();
      this.ApiGridSite = new MozartUC.apiTGrid();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.framePrix = new MozartUC.apiGroupBox();
      this.txtCoef = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmdCopieFiliale0 = new MozartUC.apiButton();
      this.cmdCopieFiliale6 = new MozartUC.apiButton();
      this.Frame5 = new MozartUC.apiGroupBox();
      this.ApiGridCtr = new MozartUC.apiTGrid();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblClient = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cmdPrix = new MozartUC.apiButton();
      this.mnuNbInter = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutNbInterTous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupNbInterTous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDuree = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutDuree = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupDuree = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMontant = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutMontant = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupMontant = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMontantSTT = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutMontantSTT = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupMontantSTT = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMontantP3 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutMontantP3 = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupMontantP3 = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuNbEquip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutNbEquip = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupNbEquip = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDate = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAjoutDate = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupDate = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuAffecterTous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDesaffecter = new System.Windows.Forms.ToolStripMenuItem();
      this.Frame4.SuspendLayout();
      this.framePrix.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.mnuNbInter.SuspendLayout();
      this.mnuDuree.SuspendLayout();
      this.mnuMontant.SuspendLayout();
      this.mnuMontantSTT.SuspendLayout();
      this.mnuMontantP3.SuspendLayout();
      this.mnuNbEquip.SuspendLayout();
      this.mnuDate.SuspendLayout();
      this.mnuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdImplantation
      // 
      resources.ApplyResources(this.cmdImplantation, "cmdImplantation");
      this.cmdImplantation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImplantation.HelpContextID = 0;
      this.cmdImplantation.Name = "cmdImplantation";
      this.cmdImplantation.Tag = "96";
      this.cmdImplantation.UseVisualStyleBackColor = true;
      this.cmdImplantation.Click += new System.EventHandler(this.cmdImplantation_Click);
      // 
      // ApiGridSite
      // 
      resources.ApplyResources(this.ApiGridSite, "ApiGridSite");
      this.ApiGridSite.FilterBar = true;
      this.ApiGridSite.FooterBar = true;
      this.ApiGridSite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ApiGridSite.Name = "ApiGridSite";
      this.ApiGridSite.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGridSite_SelectionChanged);
      this.ApiGridSite.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.ApiGridSite_RowCellClick);
      this.ApiGridSite.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.ApiGridSite_CellValueChanged);
      // 
      // Frame4
      // 
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.BackColor = System.Drawing.Color.Wheat;
      this.tableLayoutPanel1.SetColumnSpan(this.Frame4, 2);
      this.Frame4.Controls.Add(this.framePrix);
      this.Frame4.Controls.Add(this.ApiGridSite);
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame4.FrameColor = System.Drawing.Color.Empty;
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // framePrix
      // 
      this.framePrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
      this.framePrix.Controls.Add(this.txtCoef);
      this.framePrix.Controls.Add(this.label3);
      this.framePrix.Controls.Add(this.label2);
      this.framePrix.Controls.Add(this.cmdCopieFiliale0);
      this.framePrix.Controls.Add(this.cmdCopieFiliale6);
      resources.ApplyResources(this.framePrix, "framePrix");
      this.framePrix.FrameColor = System.Drawing.Color.Empty;
      this.framePrix.HelpContextID = 0;
      this.framePrix.Name = "framePrix";
      this.framePrix.TabStop = false;
      // 
      // txtCoef
      // 
      resources.ApplyResources(this.txtCoef, "txtCoef");
      this.txtCoef.Name = "txtCoef";
      this.txtCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoef_KeyPress);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // cmdCopieFiliale0
      // 
      this.cmdCopieFiliale0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdCopieFiliale0, "cmdCopieFiliale0");
      this.cmdCopieFiliale0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCopieFiliale0.HelpContextID = 0;
      this.cmdCopieFiliale0.Name = "cmdCopieFiliale0";
      this.cmdCopieFiliale0.UseVisualStyleBackColor = false;
      this.cmdCopieFiliale0.Click += new System.EventHandler(this.cmdCopieFiliale0_Click);
      // 
      // cmdCopieFiliale6
      // 
      this.cmdCopieFiliale6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdCopieFiliale6, "cmdCopieFiliale6");
      this.cmdCopieFiliale6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCopieFiliale6.HelpContextID = 0;
      this.cmdCopieFiliale6.Name = "cmdCopieFiliale6";
      this.cmdCopieFiliale6.UseVisualStyleBackColor = false;
      this.cmdCopieFiliale6.Click += new System.EventHandler(this.cmdCopieFiliale6_Click);
      // 
      // Frame5
      // 
      resources.ApplyResources(this.Frame5, "Frame5");
      this.Frame5.BackColor = System.Drawing.Color.Wheat;
      this.Frame5.Controls.Add(this.ApiGridCtr);
      this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame5.FrameColor = System.Drawing.Color.Empty;
      this.Frame5.HelpContextID = 0;
      this.Frame5.Name = "Frame5";
      this.Frame5.TabStop = false;
      // 
      // ApiGridCtr
      // 
      resources.ApplyResources(this.ApiGridCtr, "ApiGridCtr");
      this.ApiGridCtr.FilterBar = true;
      this.ApiGridCtr.FooterBar = true;
      this.ApiGridCtr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ApiGridCtr.Name = "ApiGridCtr";
      this.ApiGridCtr.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.ApiGridCtr_RowCellStyle);
      this.ApiGridCtr.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGridCtr_SelectionChanged);
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.ApiGrid_CellValueChanged);
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.Wheat;
      this.Frame3.Controls.Add(this.ApiGrid);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
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
      // 
      // lblClient
      // 
      this.lblClient.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblClient.HelpContextID = 0;
      this.lblClient.Name = "lblClient";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.Frame3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame4, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.Frame5, 1, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.cmdPrix);
      this.panel1.Controls.Add(this.cmdFermer);
      this.panel1.Controls.Add(this.cmdImplantation);
      this.panel1.Name = "panel1";
      // 
      // cmdPrix
      // 
      resources.ApplyResources(this.cmdPrix, "cmdPrix");
      this.cmdPrix.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPrix.HelpContextID = 698;
      this.cmdPrix.Name = "cmdPrix";
      this.cmdPrix.Tag = "96";
      this.cmdPrix.UseVisualStyleBackColor = true;
      this.cmdPrix.Click += new System.EventHandler(this.cmdPrix_Click);
      // 
      // mnuNbInter
      // 
      this.mnuNbInter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutNbInterTous,
            this.mnuSupNbInterTous});
      this.mnuNbInter.Name = "mnuNbInter";
      resources.ApplyResources(this.mnuNbInter, "mnuNbInter");
      // 
      // mnuAjoutNbInterTous
      // 
      this.mnuAjoutNbInterTous.Name = "mnuAjoutNbInterTous";
      resources.ApplyResources(this.mnuAjoutNbInterTous, "mnuAjoutNbInterTous");
      this.mnuAjoutNbInterTous.Click += new System.EventHandler(this.mnuAjoutNbInterTous_Click);
      // 
      // mnuSupNbInterTous
      // 
      this.mnuSupNbInterTous.Name = "mnuSupNbInterTous";
      resources.ApplyResources(this.mnuSupNbInterTous, "mnuSupNbInterTous");
      this.mnuSupNbInterTous.Click += new System.EventHandler(this.mnuSupNbInterTous_Click);
      // 
      // mnuDuree
      // 
      this.mnuDuree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutDuree,
            this.mnuSupDuree});
      this.mnuDuree.Name = "mnuDuree";
      resources.ApplyResources(this.mnuDuree, "mnuDuree");
      // 
      // mnuAjoutDuree
      // 
      this.mnuAjoutDuree.Name = "mnuAjoutDuree";
      resources.ApplyResources(this.mnuAjoutDuree, "mnuAjoutDuree");
      this.mnuAjoutDuree.Click += new System.EventHandler(this.mnuAjoutDuree_Click);
      // 
      // mnuSupDuree
      // 
      this.mnuSupDuree.Name = "mnuSupDuree";
      resources.ApplyResources(this.mnuSupDuree, "mnuSupDuree");
      this.mnuSupDuree.Click += new System.EventHandler(this.mnuSupDuree_Click);
      // 
      // mnuMontant
      // 
      this.mnuMontant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutMontant,
            this.mnuSupMontant});
      this.mnuMontant.Name = "mnuMontant";
      resources.ApplyResources(this.mnuMontant, "mnuMontant");
      // 
      // mnuAjoutMontant
      // 
      this.mnuAjoutMontant.Name = "mnuAjoutMontant";
      resources.ApplyResources(this.mnuAjoutMontant, "mnuAjoutMontant");
      this.mnuAjoutMontant.Click += new System.EventHandler(this.mnuMontant_Click);
      // 
      // mnuSupMontant
      // 
      this.mnuSupMontant.Name = "mnuSupMontant";
      resources.ApplyResources(this.mnuSupMontant, "mnuSupMontant");
      this.mnuSupMontant.Click += new System.EventHandler(this.mnuSupMontant_Click);
      // 
      // mnuMontantSTT
      // 
      this.mnuMontantSTT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutMontantSTT,
            this.mnuSupMontantSTT});
      this.mnuMontantSTT.Name = "mnuMontantSTT";
      resources.ApplyResources(this.mnuMontantSTT, "mnuMontantSTT");
      // 
      // mnuAjoutMontantSTT
      // 
      this.mnuAjoutMontantSTT.Name = "mnuAjoutMontantSTT";
      resources.ApplyResources(this.mnuAjoutMontantSTT, "mnuAjoutMontantSTT");
      this.mnuAjoutMontantSTT.Click += new System.EventHandler(this.mnuAjoutMontantSTT_Click);
      // 
      // mnuSupMontantSTT
      // 
      this.mnuSupMontantSTT.Name = "mnuSupMontantSTT";
      resources.ApplyResources(this.mnuSupMontantSTT, "mnuSupMontantSTT");
      this.mnuSupMontantSTT.Click += new System.EventHandler(this.mnuSupMontantSTT_Click);
      // 
      // mnuMontantP3
      // 
      this.mnuMontantP3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutMontantP3,
            this.mnuSupMontantP3});
      this.mnuMontantP3.Name = "mnuMontantP3";
      resources.ApplyResources(this.mnuMontantP3, "mnuMontantP3");
      // 
      // mnuAjoutMontantP3
      // 
      this.mnuAjoutMontantP3.Name = "mnuAjoutMontantP3";
      resources.ApplyResources(this.mnuAjoutMontantP3, "mnuAjoutMontantP3");
      this.mnuAjoutMontantP3.Click += new System.EventHandler(this.mnuAjoutMontantP3_Click);
      // 
      // mnuSupMontantP3
      // 
      this.mnuSupMontantP3.Name = "mnuSupMontantP3";
      resources.ApplyResources(this.mnuSupMontantP3, "mnuSupMontantP3");
      this.mnuSupMontantP3.Click += new System.EventHandler(this.mnuSupMontantP3_Click);
      // 
      // mnuNbEquip
      // 
      this.mnuNbEquip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutNbEquip,
            this.mnuSupNbEquip});
      this.mnuNbEquip.Name = "mnuNbEquip";
      resources.ApplyResources(this.mnuNbEquip, "mnuNbEquip");
      // 
      // mnuAjoutNbEquip
      // 
      this.mnuAjoutNbEquip.Name = "mnuAjoutNbEquip";
      resources.ApplyResources(this.mnuAjoutNbEquip, "mnuAjoutNbEquip");
      this.mnuAjoutNbEquip.Click += new System.EventHandler(this.mnuAjoutNbEquip_Click);
      // 
      // mnuSupNbEquip
      // 
      this.mnuSupNbEquip.Name = "mnuSupNbEquip";
      resources.ApplyResources(this.mnuSupNbEquip, "mnuSupNbEquip");
      this.mnuSupNbEquip.Click += new System.EventHandler(this.mnuSupNbEquip_Click);
      // 
      // mnuDate
      // 
      this.mnuDate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjoutDate,
            this.mnuSupDate});
      this.mnuDate.Name = "mnuDate";
      resources.ApplyResources(this.mnuDate, "mnuDate");
      // 
      // mnuAjoutDate
      // 
      this.mnuAjoutDate.Name = "mnuAjoutDate";
      resources.ApplyResources(this.mnuAjoutDate, "mnuAjoutDate");
      this.mnuAjoutDate.Click += new System.EventHandler(this.mnuAjoutDate_Click);
      // 
      // mnuSupDate
      // 
      this.mnuSupDate.Name = "mnuSupDate";
      resources.ApplyResources(this.mnuSupDate, "mnuSupDate");
      this.mnuSupDate.Click += new System.EventHandler(this.mnuSupDate_Click);
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
      // frmGestContratSite
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestContratSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestContratSite_Load);
      this.Frame4.ResumeLayout(false);
      this.framePrix.ResumeLayout(false);
      this.framePrix.PerformLayout();
      this.Frame5.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.mnuNbInter.ResumeLayout(false);
      this.mnuDuree.ResumeLayout(false);
      this.mnuMontant.ResumeLayout(false);
      this.mnuMontantSTT.ResumeLayout(false);
      this.mnuMontantP3.ResumeLayout(false);
      this.mnuNbEquip.ResumeLayout(false);
      this.mnuDate.ResumeLayout(false);
      this.mnuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdImplantation;
    private MozartUC.apiTGrid ApiGridSite;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiGroupBox Frame5;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblClient;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTitre;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private MozartUC.apiTGrid ApiGridCtr;
    private System.Windows.Forms.ContextMenuStrip mnuNbInter;
    private System.Windows.Forms.ContextMenuStrip mnuDuree;
    private System.Windows.Forms.ContextMenuStrip mnuMontant;
    private System.Windows.Forms.ContextMenuStrip mnuMontantSTT;
    private System.Windows.Forms.ContextMenuStrip mnuMontantP3;
    private System.Windows.Forms.ContextMenuStrip mnuNbEquip;
    private System.Windows.Forms.ContextMenuStrip mnuDate;
    private System.Windows.Forms.ContextMenuStrip mnuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutDate;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutMontant;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutDuree;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutMontantP3;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutMontantSTT;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutNbEquip;
    private System.Windows.Forms.ToolStripMenuItem mnuAjoutNbInterTous;
    private System.Windows.Forms.ToolStripMenuItem mnuAffecterTous;
    private System.Windows.Forms.ToolStripMenuItem mnuDesaffecter;
    private System.Windows.Forms.ToolStripMenuItem mnuSupDate;
    private System.Windows.Forms.ToolStripMenuItem mnuSupDuree;
    private System.Windows.Forms.ToolStripMenuItem mnuSupMontant;
    private System.Windows.Forms.ToolStripMenuItem mnuSupMontantP3;
    private System.Windows.Forms.ToolStripMenuItem mnuSupMontantSTT;
    private System.Windows.Forms.ToolStripMenuItem mnuSupNbEquip;
    private System.Windows.Forms.ToolStripMenuItem mnuSupNbInterTous;
    private MozartUC.apiButton cmdPrix;
    private MozartUC.apiGroupBox framePrix;
    private MozartUC.apiButton cmdCopieFiliale0;
    private MozartUC.apiButton cmdCopieFiliale6;
    private System.Windows.Forms.TextBox txtCoef;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
