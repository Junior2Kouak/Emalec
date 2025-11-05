namespace MozartCS
{
  partial class frmListeDataTabletSTF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDataTabletSTF));
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdArchives = new MozartUC.apiButton();
      this.cmdArchiver = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdAnnule = new MozartUC.apiButton();
      this.txtWeb = new MozartUC.apiTextBox();
      this.FrameWeb = new MozartUC.apiGroupBox();
      this.txtAct = new MozartUC.apiTextBox();
      this.framAct = new MozartUC.apiGroupBox();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.FrameWeb.SuspendLayout();
      this.framAct.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = false;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdArchives
      // 
      resources.ApplyResources(this.cmdArchives, "cmdArchives");
      this.cmdArchives.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchives.HelpContextID = 0;
      this.cmdArchives.Name = "cmdArchives";
      this.cmdArchives.Tag = "28";
      this.cmdArchives.UseVisualStyleBackColor = true;
      this.cmdArchives.Click += new System.EventHandler(this.CmdArchives_Click);
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
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "66";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // cmdAnnule
      // 
      this.cmdAnnule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.cmdAnnule, "cmdAnnule");
      this.cmdAnnule.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAnnule.HelpContextID = 0;
      this.cmdAnnule.Name = "cmdAnnule";
      this.cmdAnnule.UseVisualStyleBackColor = false;
      this.cmdAnnule.Click += new System.EventHandler(this.CmdAnnule_Click);
      // 
      // txtWeb
      // 
      this.txtWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtWeb.HelpContextID = 0;
      resources.ApplyResources(this.txtWeb, "txtWeb");
      this.txtWeb.Name = "txtWeb";
      // 
      // FrameWeb
      // 
      this.FrameWeb.Controls.Add(this.cmdAnnule);
      this.FrameWeb.Controls.Add(this.txtWeb);
      resources.ApplyResources(this.FrameWeb, "FrameWeb");
      this.FrameWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.FrameWeb.HelpContextID = 0;
      this.FrameWeb.Name = "FrameWeb";
      this.FrameWeb.TabStop = false;
      // 
      // txtAct
      // 
      this.txtAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtAct.HelpContextID = 0;
      resources.ApplyResources(this.txtAct, "txtAct");
      this.txtAct.Name = "txtAct";
      // 
      // framAct
      // 
      this.framAct.Controls.Add(this.txtAct);
      resources.ApplyResources(this.framAct, "framAct");
      this.framAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.framAct.HelpContextID = 0;
      this.framAct.Name = "framAct";
      this.framAct.TabStop = false;
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // frmListeDataTabletSTF
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdArchives);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.FrameWeb);
      this.Controls.Add(this.framAct);
      this.Controls.Add(this.apiTGrid);
      this.Name = "frmListeDataTabletSTF";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListeDataTabletSTF_FormClosed);
      this.Load += new System.EventHandler(this.frmListeDataTabletSTF_Load);
      this.FrameWeb.ResumeLayout(false);
      this.FrameWeb.PerformLayout();
      this.framAct.ResumeLayout(false);
      this.framAct.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdArchives;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdAnnule;
    private MozartUC.apiTextBox txtWeb;
    private MozartUC.apiGroupBox FrameWeb;
    private MozartUC.apiTextBox txtAct;
    private MozartUC.apiGroupBox framAct;
    private MozartUC.apiTGrid apiTGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
