namespace MozartCS
{
  partial class frmlisteDIArchiv
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlisteDIArchiv));
      this.CmdCopyPrev = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.btnReinitFilter = new MozartUC.apiButton();
      this.apiTGridListeInter1 = new MozartCS.apiTGridListeInter();
      this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
      this.SuspendLayout();
      // 
      // CmdCopyPrev
      // 
      resources.ApplyResources(this.CmdCopyPrev, "CmdCopyPrev");
      this.CmdCopyPrev.HelpContextID = 609;
      this.CmdCopyPrev.Name = "CmdCopyPrev";
      this.CmdCopyPrev.Tag = "77";
      this.CmdCopyPrev.UseVisualStyleBackColor = true;
      this.CmdCopyPrev.Click += new System.EventHandler(this.CmdCopyPrev_Click);
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
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // btnReinitFilter
      // 
      resources.ApplyResources(this.btnReinitFilter, "btnReinitFilter");
      this.btnReinitFilter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnReinitFilter.HelpContextID = 0;
      this.btnReinitFilter.Name = "btnReinitFilter";
      this.btnReinitFilter.UseVisualStyleBackColor = true;
      this.btnReinitFilter.Click += new System.EventHandler(this.btnReinitFilter_Click);
      // 
      // apiTGridListeInter1
      // 
      resources.ApplyResources(this.apiTGridListeInter1, "apiTGridListeInter1");
      this.apiTGridListeInter1.FilterBar = true;
      this.apiTGridListeInter1.FooterBar = true;
      this.apiTGridListeInter1.Name = "apiTGridListeInter1";
      this.apiTGridListeInter1.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid1_DoubleClickE);
      // 
      // toolTipController1
      // 
      this.toolTipController1.AutoPopDelay = 600000;
      // 
      // frmlisteDIArchiv
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGridListeInter1);
      this.Controls.Add(this.btnReinitFilter);
      this.Controls.Add(this.CmdCopyPrev);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Name = "frmlisteDIArchiv";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmlisteDIArchiv_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdCopyPrev;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton btnReinitFilter;
    private apiTGridListeInter apiTGridListeInter1;
    private DevExpress.Utils.ToolTipController toolTipController1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
