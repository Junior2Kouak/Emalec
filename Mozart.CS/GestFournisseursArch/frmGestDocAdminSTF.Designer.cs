namespace MozartCS
{
  partial class frmGestDocAdminSTF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestDocAdminSTF));
      this.cmdCourRelance = new MozartUC.apiButton();
      this.cmdArchives = new MozartUC.apiButton();
      this.cmdSuppRestaure = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdAjout = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.apiTGrid2 = new MozartUC.apiTGrid();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdCourRelance
      // 
      resources.ApplyResources(this.cmdCourRelance, "cmdCourRelance");
      this.cmdCourRelance.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCourRelance.HelpContextID = 0;
      this.cmdCourRelance.Name = "cmdCourRelance";
      this.cmdCourRelance.Tag = "2";
      this.cmdCourRelance.UseVisualStyleBackColor = true;
      this.cmdCourRelance.Click += new System.EventHandler(this.cmdCourRelance_Click);
      // 
      // cmdArchives
      // 
      resources.ApplyResources(this.cmdArchives, "cmdArchives");
      this.cmdArchives.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchives.HelpContextID = 0;
      this.cmdArchives.Name = "cmdArchives";
      this.cmdArchives.Tag = "27";
      this.cmdArchives.UseVisualStyleBackColor = true;
      this.cmdArchives.Click += new System.EventHandler(this.CmdArchives_Click);
      // 
      // cmdSuppRestaure
      // 
      resources.ApplyResources(this.cmdSuppRestaure, "cmdSuppRestaure");
      this.cmdSuppRestaure.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuppRestaure.HelpContextID = 0;
      this.cmdSuppRestaure.Name = "cmdSuppRestaure";
      this.cmdSuppRestaure.Tag = "27";
      this.cmdSuppRestaure.UseVisualStyleBackColor = true;
      this.cmdSuppRestaure.Click += new System.EventHandler(this.CmdSuppRestaure_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
      // 
      // cmdAjout
      // 
      resources.ApplyResources(this.cmdAjout, "cmdAjout");
      this.cmdAjout.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjout.HelpContextID = 0;
      this.cmdAjout.Name = "cmdAjout";
      this.cmdAjout.Tag = "2";
      this.cmdAjout.UseVisualStyleBackColor = true;
      this.cmdAjout.Click += new System.EventHandler(this.CmdAjout_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // apiTGrid2
      // 
      resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
      this.apiTGrid2.FilterBar = true;
      this.apiTGrid2.FooterBar = true;
      this.apiTGrid2.Name = "apiTGrid2";
      this.apiTGrid2.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid2_RowCellStyle);
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmGestDocAdminSTF
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdCourRelance);
      this.Controls.Add(this.cmdArchives);
      this.Controls.Add(this.cmdSuppRestaure);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdAjout);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.apiTGrid2);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestDocAdminSTF";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestDocAdminSTF_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCourRelance;
    private MozartUC.apiButton cmdArchives;
    private MozartUC.apiButton cmdSuppRestaure;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdAjout;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
