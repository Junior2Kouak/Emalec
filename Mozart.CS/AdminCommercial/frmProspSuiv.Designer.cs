namespace MozartCS
{
  partial class frmProspSuiv
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspSuiv));
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.ApiTGridAction = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblTitre = new System.Windows.Forms.Label();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.ucListeOffres1 = new MozartCS.UCListeOffres();
      this.cmdDelOffre = new MozartUC.apiButton();
      this.cmdDetailOffre = new MozartUC.apiButton();
      this.cmdAddOffre = new MozartUC.apiButton();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame2.SuspendLayout();
      this.apiGroupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.Color.Black;
      this.cmdSupprimer.HelpContextID = 425;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdModifier
      // 
      this.cmdModifier.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.Color.Black;
      this.cmdModifier.HelpContextID = 445;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = false;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdAjouter
      // 
      this.cmdAjouter.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.Color.Black;
      this.cmdAjouter.HelpContextID = 445;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = false;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // ApiTGridAction
      // 
      resources.ApplyResources(this.ApiTGridAction, "ApiTGridAction");
      this.ApiTGridAction.CounterColumn = null;
      this.ApiTGridAction.FilterBar = true;
      this.ApiTGridAction.FooterBar = true;
      this.ApiTGridAction.Name = "ApiTGridAction";
      this.ApiTGridAction.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.cmdModifier_Click);
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.cmdSupprimer);
      this.Frame2.Controls.Add(this.ApiTGridAction);
      this.Frame2.Controls.Add(this.cmdModifier);
      this.Frame2.Controls.Add(this.cmdAjouter);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Black;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // apiGroupBox1
      // 
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox1.Controls.Add(this.ucListeOffres1);
      this.apiGroupBox1.Controls.Add(this.cmdDelOffre);
      this.apiGroupBox1.Controls.Add(this.cmdDetailOffre);
      this.apiGroupBox1.Controls.Add(this.cmdAddOffre);
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.apiGroupBox1.FrameColor = System.Drawing.Color.Black;
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // ucListeOffres1
      // 
      resources.ApplyResources(this.ucListeOffres1, "ucListeOffres1");
      this.ucListeOffres1.Name = "ucListeOffres1";
      // 
      // cmdDelOffre
      // 
      this.cmdDelOffre.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdDelOffre, "cmdDelOffre");
      this.cmdDelOffre.ForeColor = System.Drawing.Color.Black;
      this.cmdDelOffre.HelpContextID = 425;
      this.cmdDelOffre.Name = "cmdDelOffre";
      this.cmdDelOffre.Tag = "27";
      this.cmdDelOffre.UseVisualStyleBackColor = false;
      this.cmdDelOffre.Click += new System.EventHandler(this.cmdDelOffre_Click);
      // 
      // cmdDetailOffre
      // 
      this.cmdDetailOffre.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdDetailOffre, "cmdDetailOffre");
      this.cmdDetailOffre.ForeColor = System.Drawing.Color.Black;
      this.cmdDetailOffre.HelpContextID = 445;
      this.cmdDetailOffre.Name = "cmdDetailOffre";
      this.cmdDetailOffre.Tag = "19";
      this.cmdDetailOffre.UseVisualStyleBackColor = false;
      this.cmdDetailOffre.Click += new System.EventHandler(this.cmdDetailOffre_Click);
      // 
      // cmdAddOffre
      // 
      this.cmdAddOffre.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdAddOffre, "cmdAddOffre");
      this.cmdAddOffre.ForeColor = System.Drawing.Color.Black;
      this.cmdAddOffre.HelpContextID = 445;
      this.cmdAddOffre.Name = "cmdAddOffre";
      this.cmdAddOffre.Tag = "2";
      this.cmdAddOffre.UseVisualStyleBackColor = false;
      this.cmdAddOffre.Click += new System.EventHandler(this.cmdAddOffre_Click);
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.apiGroupBox1, 0, 1);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmProspSuiv
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmProspSuiv";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmProspSuiv_Load);
      this.Frame2.ResumeLayout(false);
      this.apiGroupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiTGrid ApiTGridAction;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblTitre;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiGroupBox apiGroupBox1;
    private MozartUC.apiButton cmdDelOffre;
    private MozartUC.apiButton cmdDetailOffre;
    private MozartUC.apiButton cmdAddOffre;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private UCListeOffres ucListeOffres1;
  }
}
