namespace MozartCS
{
  partial class frmChoixArtReapproTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixArtReapproTech));
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdChoix = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
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
      // cmdChoix
      // 
      resources.ApplyResources(this.cmdChoix, "cmdChoix");
      this.cmdChoix.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdChoix.HelpContextID = 0;
      this.cmdChoix.Name = "cmdChoix";
      this.cmdChoix.Tag = "2";
      this.cmdChoix.UseVisualStyleBackColor = true;
      this.cmdChoix.Click += new System.EventHandler(this.cmdChoix_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmChoixArtReapproTech
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdChoix);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixArtReapproTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmChoixArtReapproTech_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdChoix;
    private MozartUC.apiTGrid apiTGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
