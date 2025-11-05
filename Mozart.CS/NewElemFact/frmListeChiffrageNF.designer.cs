namespace MozartCS
{
  partial class frmListeChiffrageNF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeChiffrageNF));
			this.apiTGrid = new MozartUC.apiTGrid();
			this.cmdQuitter = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdNouveau = new MozartUC.apiButton();
			this.cmdModifier = new MozartUC.apiButton();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// apiTGrid
			// 
			resources.ApplyResources(this.apiTGrid, "apiTGrid");
			this.apiTGrid.FilterBar = true;
			this.apiTGrid.FooterBar = true;
			this.apiTGrid.Name = "apiTGrid";
			// 
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
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
			// cmdNouveau
			// 
			resources.ApplyResources(this.cmdNouveau, "cmdNouveau");
			this.cmdNouveau.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNouveau.HelpContextID = 0;
			this.cmdNouveau.Name = "cmdNouveau";
			this.cmdNouveau.Tag = "";
			this.cmdNouveau.UseVisualStyleBackColor = true;
			this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
			// 
			// cmdModifier
			// 
			resources.ApplyResources(this.cmdModifier, "cmdModifier");
			this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdModifier.HelpContextID = 0;
			this.cmdModifier.Name = "cmdModifier";
			this.cmdModifier.Tag = "";
			this.cmdModifier.UseVisualStyleBackColor = true;
			this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
			// 
			// cmdSupprimer
			// 
			resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
			this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupprimer.HelpContextID = 0;
			this.cmdSupprimer.Name = "cmdSupprimer";
			this.cmdSupprimer.Tag = "";
			this.cmdSupprimer.UseVisualStyleBackColor = true;
			this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
			// 
			// frmListeChiffrageNF
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdNouveau);
			this.Controls.Add(this.cmdModifier);
			this.Controls.Add(this.apiTGrid);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Label1);
			this.Name = "frmListeChiffrageNF";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatFourNF_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdNouveau;
    private MozartUC.apiButton cmdModifier;
		private MozartUC.apiButton cmdSupprimer;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
