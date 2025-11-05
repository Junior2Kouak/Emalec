namespace MozartCS
{
  partial class frmListePlanif
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListePlanif));
      this.CmdPlanifAuto = new MozartUC.apiButton();
      this.cmdPlanningMPM = new MozartUC.apiButton();
      this.chkSoc = new MozartUC.apiCheckBox();
      this.cmdS3 = new MozartUC.apiButton();
      this.cmdRetourtech = new MozartUC.apiButton();
      this.cmdConges = new MozartUC.apiButton();
      this.cmdPlanCli = new MozartUC.apiButton();
      this.cmdST = new MozartUC.apiButton();
      this.CmdPlanningsAnnuel = new MozartUC.apiButton();
      this.cmdEdition = new MozartUC.apiButton();
      this.Command1 = new MozartUC.apiButton();
      this.chkPrev = new MozartUC.apiCheckBox();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdPlanning = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdOT = new MozartUC.apiButton();
      this.cmdPlanifier = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // CmdPlanifAuto
      // 
      resources.ApplyResources(this.CmdPlanifAuto, "CmdPlanifAuto");
      this.CmdPlanifAuto.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdPlanifAuto.HelpContextID = 693;
      this.CmdPlanifAuto.Name = "CmdPlanifAuto";
      this.CmdPlanifAuto.UseVisualStyleBackColor = true;
      this.CmdPlanifAuto.Click += new System.EventHandler(this.CmdPlanifAuto_Click);
      // 
      // cmdPlanningMPM
      // 
      resources.ApplyResources(this.cmdPlanningMPM, "cmdPlanningMPM");
      this.cmdPlanningMPM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPlanningMPM.HelpContextID = 641;
      this.cmdPlanningMPM.Name = "cmdPlanningMPM";
      this.cmdPlanningMPM.UseVisualStyleBackColor = true;
      this.cmdPlanningMPM.Click += new System.EventHandler(this.cmdPlanningMPM_Click);
      // 
      // chkSoc
      // 
      resources.ApplyResources(this.chkSoc, "chkSoc");
      this.chkSoc.BackColor = System.Drawing.Color.Wheat;
      this.chkSoc.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkSoc.HelpContextID = 0;
      this.chkSoc.Name = "chkSoc";
      this.chkSoc.UseVisualStyleBackColor = false;
      this.chkSoc.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
      // 
      // cmdS3
      // 
      resources.ApplyResources(this.cmdS3, "cmdS3");
      this.cmdS3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdS3.HelpContextID = 255;
      this.cmdS3.Name = "cmdS3";
      this.cmdS3.UseVisualStyleBackColor = true;
      this.cmdS3.Click += new System.EventHandler(this.cmdS3_Click);
      // 
      // cmdRetourtech
      // 
      resources.ApplyResources(this.cmdRetourtech, "cmdRetourtech");
      this.cmdRetourtech.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRetourtech.HelpContextID = 252;
      this.cmdRetourtech.Name = "cmdRetourtech";
      this.cmdRetourtech.Tag = "121";
      this.cmdRetourtech.UseVisualStyleBackColor = true;
      this.cmdRetourtech.Click += new System.EventHandler(this.cmdRetourTech_Click);
      // 
      // cmdConges
      // 
      this.cmdConges.BackColor = System.Drawing.SystemColors.Info;
      resources.ApplyResources(this.cmdConges, "cmdConges");
      this.cmdConges.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdConges.HelpContextID = 591;
      this.cmdConges.Name = "cmdConges";
      this.cmdConges.Tag = "8";
      this.cmdConges.UseVisualStyleBackColor = false;
      this.cmdConges.Click += new System.EventHandler(this.cmdConges_Click);
      // 
      // cmdPlanCli
      // 
      resources.ApplyResources(this.cmdPlanCli, "cmdPlanCli");
      this.cmdPlanCli.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPlanCli.HelpContextID = 590;
      this.cmdPlanCli.Name = "cmdPlanCli";
      this.cmdPlanCli.Tag = "100";
      this.cmdPlanCli.UseVisualStyleBackColor = true;
      this.cmdPlanCli.Click += new System.EventHandler(this.cmdPlanCli_Click);
      // 
      // cmdST
      // 
      resources.ApplyResources(this.cmdST, "cmdST");
      this.cmdST.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdST.HelpContextID = 199;
      this.cmdST.Name = "cmdST";
      this.cmdST.Tag = "42";
      this.cmdST.UseVisualStyleBackColor = true;
      this.cmdST.Click += new System.EventHandler(this.cmdST_Click);
      // 
      // CmdPlanningsAnnuel
      // 
      resources.ApplyResources(this.CmdPlanningsAnnuel, "CmdPlanningsAnnuel");
      this.CmdPlanningsAnnuel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdPlanningsAnnuel.HelpContextID = 70;
      this.CmdPlanningsAnnuel.Name = "CmdPlanningsAnnuel";
      this.CmdPlanningsAnnuel.Tag = "5";
      this.CmdPlanningsAnnuel.UseVisualStyleBackColor = true;
      this.CmdPlanningsAnnuel.Click += new System.EventHandler(this.CmdPlanningsAnnuel_Click);
      // 
      // cmdEdition
      // 
      resources.ApplyResources(this.cmdEdition, "cmdEdition");
      this.cmdEdition.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEdition.HelpContextID = 69;
      this.cmdEdition.Name = "cmdEdition";
      this.cmdEdition.Tag = "17";
      this.cmdEdition.UseVisualStyleBackColor = true;
      this.cmdEdition.Click += new System.EventHandler(this.CmdEdition_Click);
      // 
      // Command1
      // 
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.Name = "Command1";
      this.Command1.UseVisualStyleBackColor = true;
      // 
      // chkPrev
      // 
      this.chkPrev.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkPrev, "chkPrev");
      this.chkPrev.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkPrev.HelpContextID = 0;
      this.chkPrev.Name = "chkPrev";
      this.chkPrev.UseVisualStyleBackColor = false;
      this.chkPrev.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 66;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdPlanning
      // 
      resources.ApplyResources(this.cmdPlanning, "cmdPlanning");
      this.cmdPlanning.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPlanning.HelpContextID = 65;
      this.cmdPlanning.Name = "cmdPlanning";
      this.cmdPlanning.Tag = "22";
      this.cmdPlanning.UseVisualStyleBackColor = true;
      this.cmdPlanning.Click += new System.EventHandler(this.cmdPlanning_Click);
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
      // cmdOT
      // 
      resources.ApplyResources(this.cmdOT, "cmdOT");
      this.cmdOT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOT.HelpContextID = 68;
      this.cmdOT.Name = "cmdOT";
      this.cmdOT.Tag = "16";
      this.cmdOT.UseVisualStyleBackColor = true;
      this.cmdOT.Click += new System.EventHandler(this.cmdOT_Click);
      // 
      // cmdPlanifier
      // 
      resources.ApplyResources(this.cmdPlanifier, "cmdPlanifier");
      this.cmdPlanifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPlanifier.HelpContextID = 67;
      this.cmdPlanifier.Name = "cmdPlanifier";
      this.cmdPlanifier.Tag = "43";
      this.cmdPlanifier.UseVisualStyleBackColor = true;
      this.cmdPlanifier.Click += new System.EventHandler(this.cmdPlanifier_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListePlanif
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdPlanifAuto);
      this.Controls.Add(this.cmdPlanningMPM);
      this.Controls.Add(this.chkSoc);
      this.Controls.Add(this.cmdS3);
      this.Controls.Add(this.cmdRetourtech);
      this.Controls.Add(this.cmdConges);
      this.Controls.Add(this.cmdPlanCli);
      this.Controls.Add(this.cmdST);
      this.Controls.Add(this.CmdPlanningsAnnuel);
      this.Controls.Add(this.cmdEdition);
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.chkPrev);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdPlanning);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdOT);
      this.Controls.Add(this.cmdPlanifier);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmListePlanif";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListePlanif_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdPlanifAuto;
    private MozartUC.apiButton cmdPlanningMPM;
    private MozartUC.apiCheckBox chkSoc;
    private MozartUC.apiButton cmdS3;
    private MozartUC.apiButton cmdRetourtech;
    private MozartUC.apiButton cmdConges;
    private MozartUC.apiButton cmdPlanCli;
    private MozartUC.apiButton cmdST;
    private MozartUC.apiButton CmdPlanningsAnnuel;
    private MozartUC.apiButton cmdEdition;
    private MozartUC.apiButton Command1;
    private MozartUC.apiCheckBox chkPrev;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdPlanning;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdOT;
    private MozartUC.apiButton cmdPlanifier;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
