namespace MozartCS
{
  partial class frmIntercalaires
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntercalaires));
      this.cmdEdition = new MozartUC.apiButton();
      this.cmdDecocherTS = new MozartUC.apiButton();
      this.cmdCocherTS = new MozartUC.apiButton();
      this.lstSites = new System.Windows.Forms.CheckedListBox();
      this.lblNbSitesS = new System.Windows.Forms.Label();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cboClient = new System.Windows.Forms.ComboBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.lblIntercalaires = new System.Windows.Forms.Label();
      this.lblTitre = new System.Windows.Forms.Label();
      this.Frame3.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdEdition
      // 
      resources.ApplyResources(this.cmdEdition, "cmdEdition");
      this.cmdEdition.HelpContextID = 0;
      this.cmdEdition.Name = "cmdEdition";
      this.cmdEdition.Tag = "17";
      this.cmdEdition.UseVisualStyleBackColor = true;
      this.cmdEdition.Click += new System.EventHandler(this.cmdEdition_Click);
      // 
      // cmdDecocherTS
      // 
      resources.ApplyResources(this.cmdDecocherTS, "cmdDecocherTS");
      this.cmdDecocherTS.HelpContextID = 0;
      this.cmdDecocherTS.Name = "cmdDecocherTS";
      this.cmdDecocherTS.UseVisualStyleBackColor = true;
      this.cmdDecocherTS.Click += new System.EventHandler(this.cmdDecocherTS_Click);
      // 
      // cmdCocherTS
      // 
      resources.ApplyResources(this.cmdCocherTS, "cmdCocherTS");
      this.cmdCocherTS.HelpContextID = 0;
      this.cmdCocherTS.Name = "cmdCocherTS";
      this.cmdCocherTS.UseVisualStyleBackColor = true;
      this.cmdCocherTS.Click += new System.EventHandler(this.cmdCocherTS_Click);
      // 
      // lstSites
      // 
      this.lstSites.CheckOnClick = true;
      resources.ApplyResources(this.lstSites, "lstSites");
      this.lstSites.Name = "lstSites";
      this.lstSites.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSites_ItemCheck);
      // 
      // lblNbSitesS
      // 
      this.lblNbSitesS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblNbSitesS, "lblNbSitesS");
      this.lblNbSitesS.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNbSitesS.Name = "lblNbSitesS";
      this.lblNbSitesS.Tag = "Nb sites cochés :";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.cmdDecocherTS);
      this.Frame3.Controls.Add(this.cmdCocherTS);
      this.Frame3.Controls.Add(this.lstSites);
      this.Frame3.Controls.Add(this.lblNbSitesS);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cboClient
      // 
      this.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboClient, "cboClient");
      this.cboClient.Name = "cboClient";
      this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Name = "Label3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.cboClient);
      this.Frame4.Controls.Add(this.Label3);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // lblIntercalaires
      // 
      this.lblIntercalaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblIntercalaires, "lblIntercalaires");
      this.lblIntercalaires.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblIntercalaires.Name = "lblIntercalaires";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmIntercalaires
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEdition);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.lblIntercalaires);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmIntercalaires";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmIntercalaires_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame4.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdEdition;
    private MozartUC.apiButton cmdDecocherTS;
    private MozartUC.apiButton cmdCocherTS;
    private System.Windows.Forms.CheckedListBox lstSites;
    private System.Windows.Forms.Label lblNbSitesS;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdVisu;
    private System.Windows.Forms.ComboBox cboClient;
    private System.Windows.Forms.Label Label3;
    private MozartUC.apiGroupBox Frame4;
    private System.Windows.Forms.Label lblIntercalaires;
    private System.Windows.Forms.Label lblTitre;
  }
}
