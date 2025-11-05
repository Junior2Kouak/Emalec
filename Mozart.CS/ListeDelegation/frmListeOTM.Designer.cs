namespace MozartCS
{
  partial class frmListeOTM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeOTM));
			this.apiGrid = new MozartUC.apiTGrid();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdModifier = new MozartUC.apiButton();
			this.cmdNouvelle = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdRestaurer = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// apiGrid
			// 
			resources.ApplyResources(this.apiGrid, "apiGrid");
			this.apiGrid.FilterBar = true;
			this.apiGrid.FooterBar = true;
			this.apiGrid.Name = "apiGrid";
			this.apiGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiGrid_DoubleClickE);
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
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
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
			// cmdNouvelle
			// 
			resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
			this.cmdNouvelle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNouvelle.HelpContextID = 0;
			this.cmdNouvelle.Name = "cmdNouvelle";
			this.cmdNouvelle.Tag = "2";
			this.cmdNouvelle.UseVisualStyleBackColor = true;
			this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
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
			// frmListeOTM
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdRestaurer);
			this.Controls.Add(this.apiGrid);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdModifier);
			this.Controls.Add(this.cmdNouvelle);
			this.Controls.Add(this.Label1);
			this.Name = "frmListeOTM";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeOM_FormClosing);
			this.Load += new System.EventHandler(this.frmListeOM_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdNouvelle;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
		private MozartUC.apiButton cmdRestaurer;
	}
}
