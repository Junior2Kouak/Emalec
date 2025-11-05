namespace MozartCS
{
  partial class frmStatQualActNonConf
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatQualActNonConf));
      this.Label7 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.LabelInfo = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.apiTGrid_RowCellClick);
      // 
      // LabelInfo
      // 
      resources.ApplyResources(this.LabelInfo, "LabelInfo");
      this.LabelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.LabelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LabelInfo.HelpContextID = 0;
      this.LabelInfo.Name = "LabelInfo";
      // 
      // frmStatQualActNonConf
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.LabelInfo);
      this.Name = "frmStatQualActNonConf";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatQualActNonConf_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel LabelInfo;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
