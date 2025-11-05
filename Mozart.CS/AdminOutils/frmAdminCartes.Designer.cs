namespace MozartCS
{
  partial class frmAdminCartes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCartes));
      this.cmdGeoInst = new MozartUC.apiButton();
      this.cmdGeoLoc = new MozartUC.apiButton();
      this.cmdCarte = new MozartUC.apiButton();
      this.cmdRep = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lbltitre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdGeoInst
      // 
      this.cmdGeoInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGeoInst, "cmdGeoInst");
      this.cmdGeoInst.HelpContextID = 194;
      this.cmdGeoInst.Name = "cmdGeoInst";
      this.cmdGeoInst.Tag = "62";
      this.cmdGeoInst.UseVisualStyleBackColor = false;
      this.cmdGeoInst.Click += new System.EventHandler(this.cmdGeoInst_Click);
      // 
      // cmdGeoLoc
      // 
      this.cmdGeoLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGeoLoc, "cmdGeoLoc");
      this.cmdGeoLoc.HelpContextID = 194;
      this.cmdGeoLoc.Name = "cmdGeoLoc";
      this.cmdGeoLoc.Tag = "113";
      this.cmdGeoLoc.UseVisualStyleBackColor = false;
      this.cmdGeoLoc.Click += new System.EventHandler(this.cmdGeoLoc_Click);
      // 
      // cmdCarte
      // 
      this.cmdCarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdCarte, "cmdCarte");
      this.cmdCarte.HelpContextID = 137;
      this.cmdCarte.Name = "cmdCarte";
      this.cmdCarte.Tag = "26";
      this.cmdCarte.UseVisualStyleBackColor = false;
      this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
      // 
      // cmdRep
      // 
      this.cmdRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdRep, "cmdRep");
      this.cmdRep.HelpContextID = 62;
      this.cmdRep.Name = "cmdRep";
      this.cmdRep.Tag = "76";
      this.cmdRep.UseVisualStyleBackColor = false;
      this.cmdRep.Click += new System.EventHandler(this.cmdRep_Click);
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
      // lbltitre
      // 
      resources.ApplyResources(this.lbltitre, "lbltitre");
      this.lbltitre.BackColor = System.Drawing.Color.Wheat;
      this.lbltitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbltitre.Name = "lbltitre";
      // 
      // frmAdminCartes
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdGeoInst);
      this.Controls.Add(this.cmdGeoLoc);
      this.Controls.Add(this.cmdCarte);
      this.Controls.Add(this.cmdRep);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lbltitre);
      this.Name = "frmAdminCartes";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminCartes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdGeoInst;
    private MozartUC.apiButton cmdGeoLoc;
    private MozartUC.apiButton cmdCarte;
    private MozartUC.apiButton cmdRep;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lbltitre;
  }
}
