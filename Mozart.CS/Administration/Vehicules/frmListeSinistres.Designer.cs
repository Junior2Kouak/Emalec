
namespace MozartCS
{
  partial class frmListeSinistres
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeSinistres));
			this.BtnFermer = new System.Windows.Forms.Button();
			this.LabelTitre = new System.Windows.Forms.Label();
			this.grd = new MozartUC.apiTGrid();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.btnModifier = new System.Windows.Forms.Button();
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
			// grd
			// 
			resources.ApplyResources(this.grd, "grd");
			this.grd.CounterColumn = null;
			this.grd.FilterBar = true;
			this.grd.FooterBar = true;
			this.grd.Name = "grd";
			this.grd.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.grd_RowStyle);
			// 
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = true;
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.IdMenuParent = ((short)(93));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// btnModifier
			// 
			resources.ApplyResources(this.btnModifier, "btnModifier");
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// frmListeSinistres
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.apiSocieteAuto1);
			this.Controls.Add(this.grd);
			this.Controls.Add(this.LabelTitre);
			this.Controls.Add(this.BtnFermer);
			this.Name = "frmListeSinistres";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeSinistres_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Label LabelTitre;
    private MozartUC.apiTGrid grd;
		internal MozartUC.apiSocieteAuto apiSocieteAuto1;
		internal System.Windows.Forms.Button btnModifier;
	}
}