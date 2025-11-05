namespace MozartCS
{
  partial class frmListeFournituresArch
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFournituresArch));
      this.cmdPrix = new MozartUC.apiButton();
      this.txtHT = new MozartUC.apiTextBox();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdRestore = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdPrix
      // 
      resources.ApplyResources(this.cmdPrix, "cmdPrix");
      this.cmdPrix.HelpContextID = 0;
      this.cmdPrix.Name = "cmdPrix";
      this.cmdPrix.Tag = "4";
      this.cmdPrix.UseVisualStyleBackColor = true;
      this.cmdPrix.Click += new System.EventHandler(this.cmdPrix_Click);
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdRestore
      // 
      resources.ApplyResources(this.cmdRestore, "cmdRestore");
      this.cmdRestore.HelpContextID = 15;
      this.cmdRestore.Name = "cmdRestore";
      this.cmdRestore.Tag = "2";
      this.cmdRestore.UseVisualStyleBackColor = true;
      this.cmdRestore.Click += new System.EventHandler(this.cmdRestore_Click);
      // 
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
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
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmListeFournituresArch
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdPrix);
      this.Controls.Add(this.txtHT);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdRestore);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.lblLabels6);
      this.Controls.Add(this.Label14);
      this.Name = "frmListeFournituresArch";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeFournituresArch_FormClosing);
      this.Load += new System.EventHandler(this.frmListeFournituresArch_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdPrix;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdRestore;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel lblLabels6;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label14;

  }
}
