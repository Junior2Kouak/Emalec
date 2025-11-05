namespace MozartCS
{
  partial class frmGestPersArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestPersArch));
      this.CmdDocPersoSecu = new MozartUC.apiButton();
      this.cmdDocPerso = new MozartUC.apiButton();
      this.cmdPlanning = new MozartUC.apiButton();
      this.cmdListeDI = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdComptecli = new MozartUC.apiButton();
      this.cmdWeb = new MozartUC.apiButton();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // CmdDocPersoSecu
      // 
      resources.ApplyResources(this.CmdDocPersoSecu, "CmdDocPersoSecu");
      this.CmdDocPersoSecu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdDocPersoSecu.HelpContextID = 669;
      this.CmdDocPersoSecu.Name = "CmdDocPersoSecu";
      this.CmdDocPersoSecu.UseVisualStyleBackColor = true;
      this.CmdDocPersoSecu.Click += new System.EventHandler(this.CmdDocPersoSecu_Click);
      // 
      // cmdDocPerso
      // 
      resources.ApplyResources(this.cmdDocPerso, "cmdDocPerso");
      this.cmdDocPerso.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDocPerso.HelpContextID = 322;
      this.cmdDocPerso.Name = "cmdDocPerso";
      this.cmdDocPerso.UseVisualStyleBackColor = true;
      this.cmdDocPerso.Click += new System.EventHandler(this.cmdDocPerso_Click);
      // 
      // cmdPlanning
      // 
      resources.ApplyResources(this.cmdPlanning, "cmdPlanning");
      this.cmdPlanning.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPlanning.HelpContextID = 23;
      this.cmdPlanning.Name = "cmdPlanning";
      this.cmdPlanning.Tag = "22";
      this.cmdPlanning.UseVisualStyleBackColor = true;
      this.cmdPlanning.Click += new System.EventHandler(this.cmdPlanning_Click);
      // 
      // cmdListeDI
      // 
      resources.ApplyResources(this.cmdListeDI, "cmdListeDI");
      this.cmdListeDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeDI.HelpContextID = 23;
      this.cmdListeDI.Name = "cmdListeDI";
      this.cmdListeDI.Tag = "16";
      this.cmdListeDI.UseVisualStyleBackColor = true;
      this.cmdListeDI.Click += new System.EventHandler(this.cmdListeDI_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 23;
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
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdComptecli
      // 
      resources.ApplyResources(this.cmdComptecli, "cmdComptecli");
      this.cmdComptecli.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdComptecli.HelpContextID = 0;
      this.cmdComptecli.Name = "cmdComptecli";
      this.cmdComptecli.Tag = "11";
      this.cmdComptecli.UseVisualStyleBackColor = true;
      this.cmdComptecli.Click += new System.EventHandler(this.cmdComptecli_Click);
      // 
      // cmdWeb
      // 
      resources.ApplyResources(this.cmdWeb, "cmdWeb");
      this.cmdWeb.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdWeb.HelpContextID = 0;
      this.cmdWeb.Name = "cmdWeb";
      this.cmdWeb.Tag = "11";
      this.cmdWeb.UseVisualStyleBackColor = true;
      this.cmdWeb.Click += new System.EventHandler(this.cmdWeb_Click);
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "27";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmGestPersArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdDocPersoSecu);
      this.Controls.Add(this.cmdDocPerso);
      this.Controls.Add(this.cmdPlanning);
      this.Controls.Add(this.cmdListeDI);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdComptecli);
      this.Controls.Add(this.cmdWeb);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestPersArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestPersArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdDocPersoSecu;
    private MozartUC.apiButton cmdDocPerso;
    private MozartUC.apiButton cmdPlanning;
    private MozartUC.apiButton cmdListeDI;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdComptecli;
    private MozartUC.apiButton cmdWeb;
    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
