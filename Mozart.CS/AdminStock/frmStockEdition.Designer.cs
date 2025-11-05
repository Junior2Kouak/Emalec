namespace MozartCS
{
  partial class frmStockEdition
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockEdition));
      this.cmdEdition = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.Label10 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdEdition
      // 
      this.cmdEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdEdition.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEdition.HelpContextID = 0;
      resources.ApplyResources(this.cmdEdition, "cmdEdition");
      this.cmdEdition.Name = "cmdEdition";
      this.cmdEdition.Tag = "17";
      this.cmdEdition.UseVisualStyleBackColor = false;
      // 
      // cmdVisu
      // 
      this.cmdVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = false;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmStockEdition
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEdition);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGridH);
      this.Controls.Add(this.Label10);
      this.Controls.Add(this.Label14);
      this.Name = "frmStockEdition";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockEdition_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdEdition;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridH;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label14;

  }
}
