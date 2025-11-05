namespace MozartCS
{
  partial class frmChoixIntercalaires
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixIntercalaires));
      this.optAutres = new System.Windows.Forms.RadioButton();
      this.optSitesClient = new System.Windows.Forms.RadioButton();
      this.optTexteLibre = new System.Windows.Forms.RadioButton();
      this.lblLabels5 = new System.Windows.Forms.Label();
      this.lblLabels1 = new System.Windows.Forms.Label();
      this.lblLabels19 = new System.Windows.Forms.Label();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.Frame7.SuspendLayout();
      this.SuspendLayout();
      // 
      // optAutres
      // 
      this.optAutres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optAutres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.optAutres, "optAutres");
      this.optAutres.Name = "optAutres";
      this.optAutres.UseVisualStyleBackColor = false;
      // 
      // optSitesClient
      // 
      this.optSitesClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optSitesClient.Checked = true;
      resources.ApplyResources(this.optSitesClient, "optSitesClient");
      this.optSitesClient.Name = "optSitesClient";
      this.optSitesClient.TabStop = true;
      this.optSitesClient.UseVisualStyleBackColor = false;
      // 
      // optTexteLibre
      // 
      this.optTexteLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optTexteLibre, "optTexteLibre");
      this.optTexteLibre.Name = "optTexteLibre";
      this.optTexteLibre.UseVisualStyleBackColor = false;
      // 
      // lblLabels5
      // 
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels19
      // 
      this.lblLabels19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels19, "lblLabels19");
      this.lblLabels19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels19.Name = "lblLabels19";
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame7.Controls.Add(this.optAutres);
      this.Frame7.Controls.Add(this.optSitesClient);
      this.Frame7.Controls.Add(this.optTexteLibre);
      this.Frame7.Controls.Add(this.lblLabels5);
      this.Frame7.Controls.Add(this.lblLabels1);
      this.Frame7.Controls.Add(this.lblLabels19);
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Name = "Label1";
      // 
      // frmChoixIntercalaires
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame7);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixIntercalaires";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixIntercalaires_Load);
      this.Frame7.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RadioButton optAutres;
    private System.Windows.Forms.RadioButton optSitesClient;
    private System.Windows.Forms.RadioButton optTexteLibre;
    private System.Windows.Forms.Label lblLabels5;
    private System.Windows.Forms.Label lblLabels1;
    private System.Windows.Forms.Label lblLabels19;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label Label1;
  }
}
