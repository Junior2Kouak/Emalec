namespace MozartCS
{
  partial class frmLanguePers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguePers));
      this.apiTGrid2 = new MozartUC.apiTGrid();
      this.cmdPAR = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // apiTGrid2
      // 
      this.apiTGrid2.FilterBar = true;
      this.apiTGrid2.FooterBar = true;
      resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
      this.apiTGrid2.Name = "apiTGrid2";
      this.apiTGrid2.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGrid2_ClickE);
      this.apiTGrid2.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid2_SelectionChanged);
      // 
      // cmdPAR
      // 
      resources.ApplyResources(this.cmdPAR, "cmdPAR");
      this.cmdPAR.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPAR.HelpContextID = 0;
      this.cmdPAR.Name = "cmdPAR";
      this.cmdPAR.Tag = "LANGUE";
      this.cmdPAR.UseVisualStyleBackColor = true;
      this.cmdPAR.Click += new System.EventHandler(this.cmdPAR_Click);
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
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGrid1_ClickE);
      this.apiTGrid1.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid1_SelectionChanged);
      // 
      // frmLanguePers
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid2);
      this.Controls.Add(this.cmdPAR);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Name = "frmLanguePers";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmLanguePers_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiButton cmdPAR;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
