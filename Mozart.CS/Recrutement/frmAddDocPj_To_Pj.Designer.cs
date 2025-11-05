namespace MozartCS
{
  partial class frmAddDocPj_To_PJ
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDocPj_To_PJ));
      this.CmdAddPJ = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CmdAddPJ
      // 
      resources.ApplyResources(this.CmdAddPJ, "CmdAddPJ");
      this.CmdAddPJ.HelpContextID = 0;
      this.CmdAddPJ.Name = "CmdAddPJ";
      this.CmdAddPJ.UseVisualStyleBackColor = true;
      this.CmdAddPJ.Click += new System.EventHandler(this.CmdAddPJ_Click);
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
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGrid1_Click);
      this.apiTGrid1.Click += new System.EventHandler(this.apiTGrid1_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label1.Name = "Label1";
      // 
      // frmAddDocPj_To_PJ
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdAddPJ);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.WebBrowser1);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmAddDocPj_To_PJ";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.Load += new System.EventHandler(this.frmAddDocPj_To_PJ_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdAddPJ;
    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Label Label1;
  }
}
