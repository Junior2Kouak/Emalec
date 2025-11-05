
namespace MozartCS
{
  partial class frmListeVisites
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeVisites));
      this.cmdAjouterVisite = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGridVisites = new MozartUC.apiTGrid();
      this.cmdDetails = new MozartUC.apiButton();
      this.cmdListeArchives = new MozartUC.apiButton();
      this.cmdTerminer = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdAjouterVisite
      // 
      resources.ApplyResources(this.cmdAjouterVisite, "cmdAjouterVisite");
      this.cmdAjouterVisite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouterVisite.HelpContextID = 0;
      this.cmdAjouterVisite.Name = "cmdAjouterVisite";
      this.cmdAjouterVisite.Tag = "2";
      this.cmdAjouterVisite.UseVisualStyleBackColor = true;
      this.cmdAjouterVisite.Click += new System.EventHandler(this.cmdAjouterVisite_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // apiTGridVisites
      // 
      resources.ApplyResources(this.apiTGridVisites, "apiTGridVisites");
      this.apiTGridVisites.FilterBar = true;
      this.apiTGridVisites.FooterBar = true;
      this.apiTGridVisites.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.apiTGridVisites.Name = "apiTGridVisites";
      // 
      // cmdDetails
      // 
      resources.ApplyResources(this.cmdDetails, "cmdDetails");
      this.cmdDetails.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetails.HelpContextID = 0;
      this.cmdDetails.Name = "cmdDetails";
      this.cmdDetails.Tag = "2";
      this.cmdDetails.UseVisualStyleBackColor = true;
      this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
      // 
      // cmdListeArchives
      // 
      resources.ApplyResources(this.cmdListeArchives, "cmdListeArchives");
      this.cmdListeArchives.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeArchives.HelpContextID = 0;
      this.cmdListeArchives.Name = "cmdListeArchives";
      this.cmdListeArchives.Tag = "2";
      this.cmdListeArchives.UseVisualStyleBackColor = true;
      this.cmdListeArchives.Click += new System.EventHandler(this.cmdListeArchives_Click);
      // 
      // cmdTerminer
      // 
      resources.ApplyResources(this.cmdTerminer, "cmdTerminer");
      this.cmdTerminer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTerminer.HelpContextID = 0;
      this.cmdTerminer.Name = "cmdTerminer";
      this.cmdTerminer.Tag = "2";
      this.cmdTerminer.UseVisualStyleBackColor = true;
      this.cmdTerminer.Click += new System.EventHandler(this.cmdTerminer_Click);
      // 
      // frmListeVisites
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdTerminer);
      this.Controls.Add(this.cmdListeArchives);
      this.Controls.Add(this.cmdDetails);
      this.Controls.Add(this.cmdAjouterVisite);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGridVisites);
      this.Name = "frmListeVisites";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeVisites_Load);
      this.ResumeLayout(false);

    }

    #endregion

    internal MozartUC.apiButton cmdAjouterVisite;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridVisites;
    internal MozartUC.apiButton cmdDetails;
    internal MozartUC.apiButton cmdListeArchives;
    internal MozartUC.apiButton cmdTerminer;
  }
}