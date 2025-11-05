
namespace MozartCS
{
  partial class frmListeDepenses
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDepenses));
			this.BtnFermer = new System.Windows.Forms.Button();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.LabelTitre = new System.Windows.Forms.Label();
			this.apiTGrid1 = new MozartUC.apiTGrid();
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
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = true;
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.IdMenuParent = ((short)(93));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// LabelTitre
			// 
			resources.ApplyResources(this.LabelTitre, "LabelTitre");
			this.LabelTitre.Name = "LabelTitre";
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.CounterColumn = null;
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			this.apiTGrid1.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
			// 
			// btnModifier
			// 
			resources.ApplyResources(this.btnModifier, "btnModifier");
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// frmListeDepenses
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.apiSocieteAuto1);
			this.Controls.Add(this.LabelTitre);
			this.Controls.Add(this.BtnFermer);
			this.Name = "frmListeDepenses";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeDepenses_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button BtnFermer;
    internal MozartUC.apiSocieteAuto apiSocieteAuto1;
    internal System.Windows.Forms.Label LabelTitre;
    private MozartUC.apiTGrid apiTGrid1;
		internal System.Windows.Forms.Button btnModifier;
	}
}