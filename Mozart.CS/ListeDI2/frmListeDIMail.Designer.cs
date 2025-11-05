namespace MozartCS
{
  partial class frmListeDIMail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDIMail));
			this.cmdVisu = new MozartUC.apiButton();
			this.cmdArchive = new MozartUC.apiButton();
			this.cmdSupprimer = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdDebloquer = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// cmdVisu
			// 
			resources.ApplyResources(this.cmdVisu, "cmdVisu");
			this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdVisu.HelpContextID = 0;
			this.cmdVisu.Name = "cmdVisu";
			this.cmdVisu.UseVisualStyleBackColor = true;
			this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
			// 
			// cmdArchive
			// 
			resources.ApplyResources(this.cmdArchive, "cmdArchive");
			this.cmdArchive.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdArchive.HelpContextID = 0;
			this.cmdArchive.Name = "cmdArchive";
			this.cmdArchive.Tag = "61";
			this.cmdArchive.UseVisualStyleBackColor = true;
			this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
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
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValider.HelpContextID = 0;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.Tag = "66";
			this.cmdValider.UseVisualStyleBackColor = true;
			this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// cmdDebloquer
			// 
			resources.ApplyResources(this.cmdDebloquer, "cmdDebloquer");
			this.cmdDebloquer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDebloquer.HelpContextID = 0;
			this.cmdDebloquer.Name = "cmdDebloquer";
			this.cmdDebloquer.Tag = "27";
			this.cmdDebloquer.UseVisualStyleBackColor = true;
			this.cmdDebloquer.Click += new System.EventHandler(this.cmdDebloquer_Click);
			// 
			// frmListeDIMail
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdDebloquer);
			this.Controls.Add(this.cmdVisu);
			this.Controls.Add(this.cmdArchive);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.Label1);
			this.Name = "frmListeDIMail";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeDIMails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
		private MozartUC.apiButton cmdDebloquer;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
