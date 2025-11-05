namespace MozartCS
{
  partial class frmListeProcedureConsult
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeProcedureConsult));
      this.CmdListeArch = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // CmdListeArch
      // 
      resources.ApplyResources(this.CmdListeArch, "CmdListeArch");
      this.CmdListeArch.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdListeArch.HelpContextID = 0;
      this.CmdListeArch.Name = "CmdListeArch";
      this.CmdListeArch.UseVisualStyleBackColor = true;
      this.CmdListeArch.Click += new System.EventHandler(this.CmdListeArch_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
      this.apiTGrid1.FocusedRowChanged += new MozartUC.apiTGrid.FocusedRowChangedEventHandler(this.apiTGrid1_FocusedRowChanged);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // frmListeProcedureConsult
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdListeArch);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.WebBrowser1);
      this.Name = "frmListeProcedureConsult";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListeProcedureConsult_FormClosing);
      this.Load += new System.EventHandler(this.frmListeProcedureConsult_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton CmdListeArch;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
