
namespace MozartCS
{
  partial class frmListeLocations
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeLocations));
			this.BtnFermer = new System.Windows.Forms.Button();
			this.LabelTitre = new System.Windows.Forms.Label();
			this.grdLoc = new MozartUC.apiTGrid();
			this.btnModifier = new System.Windows.Forms.Button();
			this.btnAjouter = new System.Windows.Forms.Button();
			this.btnSupprimer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnFermer
			// 
			resources.ApplyResources(this.BtnFermer, "BtnFermer");
			this.BtnFermer.Name = "BtnFermer";
			this.BtnFermer.UseVisualStyleBackColor = true;
			this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
			// 
			// LabelTitre
			// 
			resources.ApplyResources(this.LabelTitre, "LabelTitre");
			this.LabelTitre.Name = "LabelTitre";
			// 
			// grdLoc
			// 
			resources.ApplyResources(this.grdLoc, "grdLoc");
			this.grdLoc.CounterColumn = null;
			this.grdLoc.FilterBar = true;
			this.grdLoc.FooterBar = true;
			this.grdLoc.Name = "grdLoc";
			// 
			// btnModifier
			// 
			resources.ApplyResources(this.btnModifier, "btnModifier");
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// btnAjouter
			// 
			resources.ApplyResources(this.btnAjouter, "btnAjouter");
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.UseVisualStyleBackColor = true;
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// btnSupprimer
			// 
			resources.ApplyResources(this.btnSupprimer, "btnSupprimer");
			this.btnSupprimer.Name = "btnSupprimer";
			this.btnSupprimer.UseVisualStyleBackColor = true;
			this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
			// 
			// frmListeLocations
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.btnSupprimer);
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.btnAjouter);
			this.Controls.Add(this.grdLoc);
			this.Controls.Add(this.LabelTitre);
			this.Controls.Add(this.BtnFermer);
			this.Name = "frmListeLocations";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeLocations_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Label LabelTitre;
    private MozartUC.apiTGrid grdLoc;
		internal System.Windows.Forms.Button btnModifier;
		internal System.Windows.Forms.Button btnAjouter;
		internal System.Windows.Forms.Button btnSupprimer;
	}
}