namespace MozartCS
{
  partial class frmListeInventairesEquipementAValider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeInventairesEquipementAValider));
            this.cmdQuitter = new MozartUC.apiButton();
            this.apigrid = new MozartUC.apiTGrid();
            this.Label1 = new MozartUC.apiLabel();
            this.cmdinventaireEquipDetail = new MozartUC.apiButton();
            this.cmdArchiver = new MozartUC.apiButton();
            this.cmdArchives = new MozartUC.apiButton();
            this.SuspendLayout();
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
            // apigrid
            // 
            resources.ApplyResources(this.apigrid, "apigrid");
            this.apigrid.FilterBar = true;
            this.apigrid.FooterBar = true;
            this.apigrid.Name = "apigrid";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.HelpContextID = 0;
            this.Label1.Name = "Label1";
            // 
            // cmdinventaireEquipDetail
            // 
            resources.ApplyResources(this.cmdinventaireEquipDetail, "cmdinventaireEquipDetail");
            this.cmdinventaireEquipDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdinventaireEquipDetail.HelpContextID = 0;
            this.cmdinventaireEquipDetail.Name = "cmdinventaireEquipDetail";
            this.cmdinventaireEquipDetail.Tag = "19";
            this.cmdinventaireEquipDetail.UseVisualStyleBackColor = true;
            this.cmdinventaireEquipDetail.Click += new System.EventHandler(this.cmdinventaireEquipDetail_Click_1);
            // 
            // cmdArchiver
            // 
            this.cmdArchiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
            this.cmdArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdArchiver.HelpContextID = 24;
            this.cmdArchiver.Name = "cmdArchiver";
            this.cmdArchiver.Tag = "27";
            this.cmdArchiver.UseVisualStyleBackColor = false;
            this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
            // 
            // cmdArchives
            // 
            resources.ApplyResources(this.cmdArchives, "cmdArchives");
            this.cmdArchives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdArchives.HelpContextID = 0;
            this.cmdArchives.Name = "cmdArchives";
            this.cmdArchives.Tag = "28";
            this.cmdArchives.UseVisualStyleBackColor = true;
            this.cmdArchives.Click += new System.EventHandler(this.cmdArchives_Click);
            // 
            // frmListeInventairesEquipementAValider
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdQuitter;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cmdArchiver);
            this.Controls.Add(this.cmdArchives);
            this.Controls.Add(this.cmdinventaireEquipDetail);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.apigrid);
            this.Controls.Add(this.Label1);
            this.Name = "frmListeInventairesEquipementAValider";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListeInventairesEquipementAValider_Load);
            this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apigrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdinventaireEquipDetail;
        private MozartUC.apiButton cmdArchiver;
        private MozartUC.apiButton cmdArchives;
    }
}
