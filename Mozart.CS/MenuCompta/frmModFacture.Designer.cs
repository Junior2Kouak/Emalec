namespace MozartCS
{
  partial class frmModFacture
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModFacture));
      this.CmdPrintFacETR = new MozartUC.apiButton();
      this.cmdDI = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.grdDataGrid = new MozartUC.apiTGrid();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.grdDataGridAction = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdDetails = new MozartUC.apiButton();
      this.optFour0 = new System.Windows.Forms.RadioButton();
      this.optFour1 = new System.Windows.Forms.RadioButton();
      this.txtFact4 = new MozartUC.apiTextBox();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.lblLabels9 = new MozartUC.apiLabel();
      this.Frame5 = new MozartUC.apiGroupBox();
      this.txtFact2 = new MozartUC.apiTextBox();
      this.txtFact0 = new MozartUC.apiTextBox();
      this.txtFact3 = new MozartUC.apiTextBox();
      this.txtFact1 = new MozartUC.apiTextBox();
      this.txtFact5 = new MozartUC.apiTextBox();
      this.txtFact6 = new MozartUC.apiTextBox();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels10 = new MozartUC.apiLabel();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblLabels7 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdPrintFacETR
      // 
      resources.ApplyResources(this.CmdPrintFacETR, "CmdPrintFacETR");
      this.CmdPrintFacETR.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdPrintFacETR.HelpContextID = 287;
      this.CmdPrintFacETR.Name = "CmdPrintFacETR";
      this.CmdPrintFacETR.Tag = "99";
      this.CmdPrintFacETR.UseVisualStyleBackColor = true;
      this.CmdPrintFacETR.Click += new System.EventHandler(this.cmdPrintFacETR_Click);
      // 
      // cmdDI
      // 
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "54";
      this.cmdDI.UseVisualStyleBackColor = true;
      this.cmdDI.Click += new System.EventHandler(this.cmdDi_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 205;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 83;
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
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // grdDataGrid
      // 
      this.grdDataGrid.FilterBar = true;
      resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
      this.grdDataGrid.FooterBar = true;
      this.grdDataGrid.Name = "grdDataGrid";
      this.grdDataGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.grdDataGrid_SelectionChanged);
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.grdDataGrid);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // grdDataGridAction
      // 
      this.grdDataGridAction.FilterBar = true;
      resources.ApplyResources(this.grdDataGridAction, "grdDataGridAction");
      this.grdDataGridAction.FooterBar = true;
      this.grdDataGridAction.Name = "grdDataGridAction";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.grdDataGridAction);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cmdDetails
      // 
      resources.ApplyResources(this.cmdDetails, "cmdDetails");
      this.cmdDetails.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetails.HelpContextID = 0;
      this.cmdDetails.Image = global::MozartCS.Properties.Resources.Find;
      this.cmdDetails.Name = "cmdDetails";
      this.cmdDetails.Tag = "8";
      this.cmdDetails.UseVisualStyleBackColor = true;
      this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
      // 
      // optFour0
      // 
      this.optFour0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optFour0, "optFour0");
      this.optFour0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optFour0.Name = "optFour0";
      this.optFour0.UseVisualStyleBackColor = false;
      // 
      // optFour1
      // 
      this.optFour1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optFour1, "optFour1");
      this.optFour1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optFour1.Name = "optFour1";
      this.optFour1.UseVisualStyleBackColor = false;
      // 
      // txtFact4
      // 
      this.txtFact4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact4, "txtFact4");
      this.txtFact4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact4.HelpContextID = 0;
      this.txtFact4.Name = "txtFact4";
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
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // lblLabels9
      // 
      resources.ApplyResources(this.lblLabels9, "lblLabels9");
      this.lblLabels9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels9.HelpContextID = 0;
      this.lblLabels9.Name = "lblLabels9";
      // 
      // Frame5
      // 
      this.Frame5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame5.Controls.Add(this.cmdDetails);
      this.Frame5.Controls.Add(this.optFour0);
      this.Frame5.Controls.Add(this.optFour1);
      this.Frame5.Controls.Add(this.txtFact4);
      this.Frame5.Controls.Add(this.lblLabels2);
      this.Frame5.Controls.Add(this.lblLabels3);
      this.Frame5.Controls.Add(this.lblLabels4);
      this.Frame5.Controls.Add(this.lblLabels9);
      resources.ApplyResources(this.Frame5, "Frame5");
      this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame5.FrameColor = System.Drawing.Color.Empty;
      this.Frame5.HelpContextID = 0;
      this.Frame5.Name = "Frame5";
      this.Frame5.TabStop = false;
      // 
      // txtFact2
      // 
      this.txtFact2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact2, "txtFact2");
      this.txtFact2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact2.HelpContextID = 0;
      this.txtFact2.Name = "txtFact2";
      // 
      // txtFact0
      // 
      this.txtFact0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact0, "txtFact0");
      this.txtFact0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact0.HelpContextID = 0;
      this.txtFact0.Name = "txtFact0";
      // 
      // txtFact3
      // 
      this.txtFact3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact3, "txtFact3");
      this.txtFact3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact3.HelpContextID = 0;
      this.txtFact3.Name = "txtFact3";
      // 
      // txtFact1
      // 
      this.txtFact1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact1, "txtFact1");
      this.txtFact1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact1.HelpContextID = 0;
      this.txtFact1.Name = "txtFact1";
      // 
      // txtFact5
      // 
      this.txtFact5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact5, "txtFact5");
      this.txtFact5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact5.HelpContextID = 0;
      this.txtFact5.Name = "txtFact5";
      // 
      // txtFact6
      // 
      this.txtFact6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtFact6, "txtFact6");
      this.txtFact6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtFact6.HelpContextID = 0;
      this.txtFact6.Name = "txtFact6";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels10
      // 
      resources.ApplyResources(this.lblLabels10, "lblLabels10");
      this.lblLabels10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels10.HelpContextID = 0;
      this.lblLabels10.Name = "lblLabels10";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // lblLabels7
      // 
      resources.ApplyResources(this.lblLabels7, "lblLabels7");
      this.lblLabels7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels7.HelpContextID = 0;
      this.lblLabels7.Name = "lblLabels7";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Frame2);
      this.Frame1.Controls.Add(this.Frame5);
      this.Frame1.Controls.Add(this.txtFact2);
      this.Frame1.Controls.Add(this.txtFact0);
      this.Frame1.Controls.Add(this.txtFact3);
      this.Frame1.Controls.Add(this.txtFact1);
      this.Frame1.Controls.Add(this.txtFact5);
      this.Frame1.Controls.Add(this.txtFact6);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Controls.Add(this.lblLabels1);
      this.Frame1.Controls.Add(this.lblLabels10);
      this.Frame1.Controls.Add(this.lblLabels5);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.Controls.Add(this.lblLabels7);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 82;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmModFacture
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdPrintFacETR);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmModFacture";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmModFacture_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame5.ResumeLayout(false);
      this.Frame5.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdPrintFacETR;
    private MozartUC.apiButton cmdDI;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiTGrid grdDataGridAction;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdDetails;
    private System.Windows.Forms.RadioButton optFour0;
    private System.Windows.Forms.RadioButton optFour1;
    private MozartUC.apiTextBox txtFact4;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiGroupBox Frame5;
    private MozartUC.apiTextBox txtFact2;
    private MozartUC.apiTextBox txtFact0;
    private MozartUC.apiTextBox txtFact3;
    private MozartUC.apiTextBox txtFact1;
    private MozartUC.apiTextBox txtFact5;
    private MozartUC.apiTextBox txtFact6;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblLabels7;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
