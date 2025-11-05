namespace MozartCS
{
  partial class frmStockVehTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockVehTech));
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiGridb = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiGridb
      // 
      resources.ApplyResources(this.apiGridb, "apiGridb");
      this.apiGridb.FilterBar = true;
      this.apiGridb.FooterBar = true;
      this.apiGridb.Name = "apiGridb";
      this.apiGridb.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiGridb_RowCellStyle);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // frmStockVehTech
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiGridb);
      this.Controls.Add(this.Label1);
      this.Name = "frmStockVehTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockVehTech_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiGridb;
    private System.Windows.Forms.Label Label1;

  }
}
