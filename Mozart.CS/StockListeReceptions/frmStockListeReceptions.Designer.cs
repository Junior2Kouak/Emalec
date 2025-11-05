namespace MozartCS
{
  partial class frmStockListeReceptions
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockListeReceptions));
      this.Check2 = new MozartUC.apiCheckBox();
      this.cmdArchiver = new MozartUC.apiButton();
      this.cmdArchives = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // Check2
      // 
      this.Check2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.Check2, "Check2");
      this.Check2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Check2.HelpContextID = 0;
      this.Check2.Name = "Check2";
      this.Check2.UseVisualStyleBackColor = false;
      this.Check2.CheckedChanged += new System.EventHandler(this.Check2_CheckedChanged);
      // 
      // cmdArchiver
      // 
      this.cmdArchiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchiver, "cmdArchiver");
      this.cmdArchiver.HelpContextID = 0;
      this.cmdArchiver.Name = "cmdArchiver";
      this.cmdArchiver.UseVisualStyleBackColor = false;
      this.cmdArchiver.Click += new System.EventHandler(this.cmdArchiver_Click);
      // 
      // cmdArchives
      // 
      this.cmdArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchives, "cmdArchives");
      this.cmdArchives.HelpContextID = 0;
      this.cmdArchives.Name = "cmdArchives";
      this.cmdArchives.UseVisualStyleBackColor = false;
      this.cmdArchives.Click += new System.EventHandler(this.cmdArchives_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid_DoubleClick);
      this.apiTGrid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid_RowStyle);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdDetail
      // 
      this.cmdDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "2";
      this.cmdDetail.UseVisualStyleBackColor = false;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmStockListeReceptions
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Check2);
      this.Controls.Add(this.cmdArchiver);
      this.Controls.Add(this.cmdArchives);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.Label1);
      this.Name = "frmStockListeReceptions";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockListeReceptions_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCheckBox Check2;
    private MozartUC.apiButton cmdArchiver;
    private MozartUC.apiButton cmdArchives;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdDetail;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
