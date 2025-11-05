namespace MozartCS
{
  partial class frmStatDelaiDI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatDelaiDI));
      this.cmdCalc = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cboCli = new MozartUC.apiCombo();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.cmdQuitter = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // cmdCalc
      // 
      resources.ApplyResources(this.cmdCalc, "cmdCalc");
      this.cmdCalc.HelpContextID = 0;
      this.cmdCalc.Name = "cmdCalc";
      this.cmdCalc.Tag = "19";
      this.cmdCalc.UseVisualStyleBackColor = true;
      this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      // 
      // cboCli
      // 
      resources.ApplyResources(this.cboCli, "cboCli");
      this.cboCli.Name = "cboCli";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      resources.ApplyResources(this.listBox1, "listBox1");
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Name = "listBox1";
      // 
      // frmStatDelaiDI
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdCalc);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cboCli);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmStatDelaiDI";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatDelaiDI_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCalc;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiCombo cboCli;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTitre;
    private System.Windows.Forms.Button cmdQuitter;
    private System.Windows.Forms.ListBox listBox1;
  }
}
