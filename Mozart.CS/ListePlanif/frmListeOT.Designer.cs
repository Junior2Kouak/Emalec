namespace MozartCS
{
  partial class frmListeOT
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeOT));
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdEditer = new MozartUC.apiButton();
      this.grdDataGridAction = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.grdDataGrid = new MozartUC.apiTGrid();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame1.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
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
      // cmdEditer
      // 
      resources.ApplyResources(this.cmdEditer, "cmdEditer");
      this.cmdEditer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEditer.HelpContextID = 0;
      this.cmdEditer.Name = "cmdEditer";
      this.cmdEditer.Tag = "17";
      this.cmdEditer.UseVisualStyleBackColor = true;
      this.cmdEditer.Click += new System.EventHandler(this.cmdEditer_Click);
      // 
      // grdDataGridAction
      // 
      resources.ApplyResources(this.grdDataGridAction, "grdDataGridAction");
      this.grdDataGridAction.FilterBar = true;
      this.grdDataGridAction.FooterBar = true;
      this.grdDataGridAction.Name = "grdDataGridAction";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.grdDataGridAction);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // grdDataGrid
      // 
      resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
      this.grdDataGrid.FilterBar = true;
      this.grdDataGrid.FooterBar = true;
      this.grdDataGrid.Name = "grdDataGrid";
      this.grdDataGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.grdDataGrid_SelectionChanged);
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.grdDataGrid);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 1);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmListeOT
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdEditer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeOT";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeOT_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdEditer;
    private MozartUC.apiTGrid grdDataGridAction;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiGroupBox Frame3;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}
