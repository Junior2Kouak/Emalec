namespace MozartCS
{
  partial class frmGestContratSiteST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestContratSiteST));
      this.lblClient = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.ApiGridSite = new MozartUC.apiTGrid();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.ApiGridCtr = new MozartUC.apiTGrid();
      this.Frame5 = new MozartUC.apiGroupBox();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.mnuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuSTun = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSTtous = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupUn = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuSupTous = new System.Windows.Forms.ToolStripMenuItem();
      this.Frame1.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.mnuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblClient
      // 
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.lblClient.HelpContextID = 0;
      this.lblClient.Name = "lblClient";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.lblClient);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // 
      // Frame4
      // 
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.BackColor = System.Drawing.Color.Wheat;
      this.Frame4.Controls.Add(this.ApiGridSite);
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // ApiGridCtr
      // 
      resources.ApplyResources(this.ApiGridCtr, "ApiGridCtr");
      this.ApiGridCtr.FilterBar = true;
      this.ApiGridCtr.FooterBar = true;
      this.ApiGridCtr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ApiGridCtr.Name = "ApiGridCtr";
      this.ApiGridCtr.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGridCtr_SelectionChanged);
      // 
      // Frame5
      // 
      resources.ApplyResources(this.Frame5, "Frame5");
      this.Frame5.BackColor = System.Drawing.Color.Wheat;
      this.Frame5.Controls.Add(this.ApiGridCtr);
      this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame5.HelpContextID = 0;
      this.Frame5.Name = "Frame5";
      this.Frame5.TabStop = false;
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.ApiGrid_RowCellClick);
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.Wheat;
      this.Frame3.Controls.Add(this.ApiGrid);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
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
      this.tableLayoutPanel1.Controls.Add(this.Frame5, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame4, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame3, 2, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // mnuAffichage
      // 
      this.mnuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSTun,
            this.mnuSTtous,
            this.mnuSupUn,
            this.mnuSupTous});
      this.mnuAffichage.Name = "mnuAffichage";
      resources.ApplyResources(this.mnuAffichage, "mnuAffichage");
      // 
      // mnuSTun
      // 
      this.mnuSTun.Name = "mnuSTun";
      resources.ApplyResources(this.mnuSTun, "mnuSTun");
      this.mnuSTun.Click += new System.EventHandler(this.mnuSTun_Click);
      // 
      // mnuSTtous
      // 
      this.mnuSTtous.Name = "mnuSTtous";
      resources.ApplyResources(this.mnuSTtous, "mnuSTtous");
      this.mnuSTtous.Click += new System.EventHandler(this.mnuSTtous_Click);
      // 
      // mnuSupUn
      // 
      this.mnuSupUn.Name = "mnuSupUn";
      resources.ApplyResources(this.mnuSupUn, "mnuSupUn");
      this.mnuSupUn.Click += new System.EventHandler(this.mnuSupUn_Click);
      // 
      // mnuSupTous
      // 
      this.mnuSupTous.Name = "mnuSupTous";
      resources.ApplyResources(this.mnuSupTous, "mnuSupTous");
      this.mnuSupTous.Click += new System.EventHandler(this.mnuSupTous_Click);
      // 
      // frmGestContratSiteST
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmGestContratSiteST";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestContratSiteST_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame4.ResumeLayout(false);
      this.Frame5.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.mnuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiLabel lblClient;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid ApiGridSite;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiTGrid ApiGridCtr;
    private MozartUC.apiGroupBox Frame5;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTitre;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ContextMenuStrip mnuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuSTtous;
    private System.Windows.Forms.ToolStripMenuItem mnuSTun;
    private System.Windows.Forms.ToolStripMenuItem mnuSupTous;
    private System.Windows.Forms.ToolStripMenuItem mnuSupUn;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
