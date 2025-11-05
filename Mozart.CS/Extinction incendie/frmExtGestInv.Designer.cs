namespace MozartCS
{
  partial class frmExtGestInv
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtGestInv));
      this.BtnFermer = new System.Windows.Forms.Button();
      this.apiTGridRes = new MozartUC.apiTGrid();
      this.apiTGridCumul = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // BtnFermer
      // 
      resources.ApplyResources(this.BtnFermer, "BtnFermer");
      this.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      // 
      // apiTGridRes
      // 
      resources.ApplyResources(this.apiTGridRes, "apiTGridRes");
      this.apiTGridRes.FilterBar = true;
      this.apiTGridRes.FooterBar = true;
      this.apiTGridRes.Name = "apiTGridRes";
      this.apiTGridRes.ColumnFilterChanged += new MozartUC.apiTGrid.ColumnFilterChangedEventHandler(this.apiTGridRes_ColumnFilterChanged);
      // 
      // apiTGridCumul
      // 
      resources.ApplyResources(this.apiTGridCumul, "apiTGridCumul");
      this.apiTGridCumul.FilterBar = true;
      this.apiTGridCumul.FooterBar = true;
      this.apiTGridCumul.Name = "apiTGridCumul";
      // 
      // frmExtGestInv
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.BtnFermer;
      this.Controls.Add(this.apiTGridRes);
      this.Controls.Add(this.apiTGridCumul);
      this.Controls.Add(this.BtnFermer);
      this.Name = "frmExtGestInv";
      this.Load += new System.EventHandler(this.frmExtGestInv_Load);
      this.ResumeLayout(false);

    }

    #endregion

    internal MozartUC.apiTGrid apiTGridCumul;
    internal System.Windows.Forms.Button BtnFermer;
    private MozartUC.apiTGrid apiTGridRes;
  }
}