
namespace MozartCS
{
  partial class frmMessageTechnicien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageTechnicien));
			this.ButtonArchiver = new System.Windows.Forms.Button();
			this.ButtonDetails = new System.Windows.Forms.Button();
			this.BtnFermer = new System.Windows.Forms.Button();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.LabelTitre = new System.Windows.Forms.Label();
			this.cmdSupprimer = new System.Windows.Forms.Button();
			this.cmdVisu = new System.Windows.Forms.Button();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.SuspendLayout();
			// 
			// ButtonArchiver
			// 
			resources.ApplyResources(this.ButtonArchiver, "ButtonArchiver");
			this.ButtonArchiver.Name = "ButtonArchiver";
			this.ButtonArchiver.UseVisualStyleBackColor = true;
			this.ButtonArchiver.Click += new System.EventHandler(this.ButtonArchiver_Click);
			// 
			// ButtonDetails
			// 
			resources.ApplyResources(this.ButtonDetails, "ButtonDetails");
			this.ButtonDetails.Name = "ButtonDetails";
			this.ButtonDetails.UseVisualStyleBackColor = true;
			this.ButtonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
			// 
			// BtnFermer
			// 
			resources.ApplyResources(this.BtnFermer, "BtnFermer");
			this.BtnFermer.Name = "BtnFermer";
			this.BtnFermer.UseVisualStyleBackColor = true;
			this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
			// 
			// BtnAjouter
			// 
			resources.ApplyResources(this.BtnAjouter, "BtnAjouter");
			this.BtnAjouter.Name = "BtnAjouter";
			this.BtnAjouter.UseVisualStyleBackColor = true;
			this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
			// 
			// LabelTitre
			// 
			resources.ApplyResources(this.LabelTitre, "LabelTitre");
			this.LabelTitre.Name = "LabelTitre";
			// 
			// cmdSupprimer
			// 
			resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
			this.cmdSupprimer.Name = "cmdSupprimer";
			this.cmdSupprimer.UseVisualStyleBackColor = true;
			this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
			// 
			// cmdVisu
			// 
			resources.ApplyResources(this.cmdVisu, "cmdVisu");
			this.cmdVisu.Name = "cmdVisu";
			this.cmdVisu.UseVisualStyleBackColor = true;
			this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			// 
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = true;
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.IdMenuParent = ((short)(44));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// frmMessageTechnicien
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.cmdVisu);
			this.Controls.Add(this.cmdSupprimer);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.apiSocieteAuto1);
			this.Controls.Add(this.LabelTitre);
			this.Controls.Add(this.ButtonArchiver);
			this.Controls.Add(this.ButtonDetails);
			this.Controls.Add(this.BtnFermer);
			this.Controls.Add(this.BtnAjouter);
			this.Name = "frmMessageTechnicien";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeVehicules_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button ButtonArchiver;
    internal System.Windows.Forms.Button ButtonDetails;
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Button BtnAjouter;
    internal MozartUC.apiSocieteAuto apiSocieteAuto1;
    internal System.Windows.Forms.Label LabelTitre;
    private MozartUC.apiTGrid apiTGrid1;
		internal System.Windows.Forms.Button cmdSupprimer;
		internal System.Windows.Forms.Button cmdVisu;
	}
}