namespace MozartCS
{
  partial class frmPrixClientContrat
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrixClientContrat));
      this.txtAction = new MozartUC.apiTextBox();
      this.CmdValidTexteAstr = new MozartUC.apiButton();
      this.CmdCancel = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.CmdModifTexteAstr = new MozartUC.apiButton();
      this.CmdModifMttAstr = new MozartUC.apiButton();
      this.CmdModSam = new MozartUC.apiButton();
      this.CmdModifDimNuit = new MozartUC.apiButton();
      this.cmdModifDep = new MozartUC.apiButton();
      this.cmdModifMO = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.lblTitre = new MozartUC.apiLabel();
      this.BtnHisto = new MozartUC.apiButton();
      this.BtnGestPays = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtAction
      // 
      this.txtAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtAction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAction.HelpContextID = 0;
      resources.ApplyResources(this.txtAction, "txtAction");
      this.txtAction.Name = "txtAction";
      // 
      // CmdValidTexteAstr
      // 
      resources.ApplyResources(this.CmdValidTexteAstr, "CmdValidTexteAstr");
      this.CmdValidTexteAstr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdValidTexteAstr.HelpContextID = 0;
      this.CmdValidTexteAstr.Name = "CmdValidTexteAstr";
      this.CmdValidTexteAstr.UseVisualStyleBackColor = true;
      this.CmdValidTexteAstr.Click += new System.EventHandler(this.CmdValidTexteAstr_Click);
      // 
      // CmdCancel
      // 
      resources.ApplyResources(this.CmdCancel, "CmdCancel");
      this.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdCancel.HelpContextID = 0;
      this.CmdCancel.Name = "CmdCancel";
      this.CmdCancel.UseVisualStyleBackColor = true;
      this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Frame1.Controls.Add(this.txtAction);
      this.Frame1.Controls.Add(this.CmdValidTexteAstr);
      this.Frame1.Controls.Add(this.CmdCancel);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // CmdModifTexteAstr
      // 
      this.CmdModifTexteAstr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModifTexteAstr.HelpContextID = 0;
      resources.ApplyResources(this.CmdModifTexteAstr, "CmdModifTexteAstr");
      this.CmdModifTexteAstr.Name = "CmdModifTexteAstr";
      this.CmdModifTexteAstr.Tag = "";
      this.CmdModifTexteAstr.UseVisualStyleBackColor = true;
      this.CmdModifTexteAstr.Click += new System.EventHandler(this.CmdModifTexteAstr_Click);
      // 
      // CmdModifMttAstr
      // 
      this.CmdModifMttAstr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModifMttAstr.HelpContextID = 0;
      resources.ApplyResources(this.CmdModifMttAstr, "CmdModifMttAstr");
      this.CmdModifMttAstr.Name = "CmdModifMttAstr";
      this.CmdModifMttAstr.UseVisualStyleBackColor = true;
      this.CmdModifMttAstr.Click += new System.EventHandler(this.CmdModifMttAstr_Click);
      // 
      // CmdModSam
      // 
      this.CmdModSam.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModSam.HelpContextID = 0;
      resources.ApplyResources(this.CmdModSam, "CmdModSam");
      this.CmdModSam.Name = "CmdModSam";
      this.CmdModSam.UseVisualStyleBackColor = true;
      this.CmdModSam.Click += new System.EventHandler(this.CmdModSam_Click);
      // 
      // CmdModifDimNuit
      // 
      this.CmdModifDimNuit.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdModifDimNuit.HelpContextID = 0;
      resources.ApplyResources(this.CmdModifDimNuit, "CmdModifDimNuit");
      this.CmdModifDimNuit.Name = "CmdModifDimNuit";
      this.CmdModifDimNuit.UseVisualStyleBackColor = true;
      this.CmdModifDimNuit.Click += new System.EventHandler(this.CmdModifDimNuit_Click);
      // 
      // cmdModifDep
      // 
      this.cmdModifDep.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifDep.HelpContextID = 0;
      resources.ApplyResources(this.cmdModifDep, "cmdModifDep");
      this.cmdModifDep.Name = "cmdModifDep";
      this.cmdModifDep.UseVisualStyleBackColor = true;
      this.cmdModifDep.Click += new System.EventHandler(this.cmdModifDep_Click);
      // 
      // cmdModifMO
      // 
      this.cmdModifMO.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifMO.HelpContextID = 0;
      resources.ApplyResources(this.cmdModifMO, "cmdModifMO");
      this.cmdModifMO.Name = "cmdModifMO";
      this.cmdModifMO.UseVisualStyleBackColor = true;
      this.cmdModifMO.Click += new System.EventHandler(this.cmdModifMO_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid_DoubleClickE);
      this.apiTGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGrid_CellValueChanged);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // BtnHisto
      // 
      this.BtnHisto.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnHisto.HelpContextID = 723;
      resources.ApplyResources(this.BtnHisto, "BtnHisto");
      this.BtnHisto.Name = "BtnHisto";
      this.BtnHisto.Tag = "";
      this.BtnHisto.UseVisualStyleBackColor = true;
      this.BtnHisto.Click += new System.EventHandler(this.BtnHisto_Click);
      // 
      // BtnGestPays
      // 
      this.BtnGestPays.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnGestPays.HelpContextID = 0;
      resources.ApplyResources(this.BtnGestPays, "BtnGestPays");
      this.BtnGestPays.Name = "BtnGestPays";
      this.BtnGestPays.Tag = "";
      this.BtnGestPays.UseVisualStyleBackColor = true;
      this.BtnGestPays.Click += new System.EventHandler(this.BtnGestPays_Click);
      // 
      // frmPrixClientContrat
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.BtnGestPays);
      this.Controls.Add(this.BtnHisto);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.CmdModifTexteAstr);
      this.Controls.Add(this.CmdModifMttAstr);
      this.Controls.Add(this.CmdModSam);
      this.Controls.Add(this.CmdModifDimNuit);
      this.Controls.Add(this.cmdModifDep);
      this.Controls.Add(this.cmdModifMO);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmPrixClientContrat";
      this.ShowInTaskbar = false;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrixClientContrat_FormClosed);
      this.Load += new System.EventHandler(this.frmPrixClientContrat_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtAction;
    private MozartUC.apiButton CmdValidTexteAstr;
    private MozartUC.apiButton CmdCancel;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton CmdModifTexteAstr;
    private MozartUC.apiButton CmdModifMttAstr;
    private MozartUC.apiButton CmdModSam;
    private MozartUC.apiButton CmdModifDimNuit;
    private MozartUC.apiButton cmdModifDep;
    private MozartUC.apiButton cmdModifMO;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiButton BtnHisto;
    private MozartUC.apiButton BtnGestPays;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
