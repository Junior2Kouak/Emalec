namespace MozartCS
{
  partial class frmStatListeEncoursClients
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatListeEncoursClients));
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "29";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmStatListeEncoursClients
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmStatListeEncoursClients";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatListeEncoursClients_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
