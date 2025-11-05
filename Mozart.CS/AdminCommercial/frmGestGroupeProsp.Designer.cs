namespace MozartCS
{
  partial class frmGestGroupeProsp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestGroupeProsp));
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.lblTitre = new System.Windows.Forms.Label();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiEnreg = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.CounterColumn = null;
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.ValidatingEditor += new MozartUC.apiTGrid.ValidatingEditorEventHandler(this.apiTGrid1_ValidatingEditor);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.Name = "lblTitre";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // apiEnreg
      // 
      resources.ApplyResources(this.apiEnreg, "apiEnreg");
      this.apiEnreg.HelpContextID = 0;
      this.apiEnreg.Name = "apiEnreg";
      this.apiEnreg.Tag = "15";
      this.apiEnreg.UseVisualStyleBackColor = true;
      this.apiEnreg.Click += new System.EventHandler(this.apiEnreg_Click);
      // 
      // frmGestGroupeProsp
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.apiEnreg);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.apiTGrid1);
      this.Name = "frmGestGroupeProsp";
      this.Load += new System.EventHandler(this.frmGestGroupeProsp_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Label lblTitre;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton apiEnreg;
  }
}