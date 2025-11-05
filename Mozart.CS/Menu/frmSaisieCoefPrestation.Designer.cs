namespace MozartCS
{
  partial class frmSaisieCoefPrestation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieCoefPrestation));
      this.lblTitre = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.cmdValider = new System.Windows.Forms.Button();
      this.txtCoef = new System.Windows.Forms.TextBox();
      this.cboSerie = new System.Windows.Forms.ComboBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip();
      this.SuspendLayout();
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.Name = "lblTitre";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtCoef
      // 
      resources.ApplyResources(this.txtCoef, "txtCoef");
      this.txtCoef.Name = "txtCoef";
      this.txtCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoef_KeyPress);
      this.txtCoef.Leave += new System.EventHandler(this.txtCoef_Leave);
      // 
      // cboSerie
      // 
      this.cboSerie.DisplayMember = "VPRESTSER";
      resources.ApplyResources(this.cboSerie, "cboSerie");
      this.cboSerie.FormattingEnabled = true;
      this.cboSerie.Name = "cboSerie";
      this.cboSerie.ValueMember = "NPRESTSERID";
      // 
      // frmSaisieCoefPrestation
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cboSerie);
      this.Controls.Add(this.txtCoef);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmSaisieCoefPrestation";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieCoefPrestation_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.TextBox txtCoef;
    private System.Windows.Forms.ComboBox cboSerie;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}