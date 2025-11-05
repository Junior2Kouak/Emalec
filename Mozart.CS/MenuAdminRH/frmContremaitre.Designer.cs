namespace MozartCS
{
  partial class frmContremaitre
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContremaitre));
      this.cmdValider = new MozartUC.apiButton();
      this.cmdAnnuler = new MozartUC.apiButton();
      this.Label51 = new MozartUC.apiLabel();
      this.Label52 = new MozartUC.apiLabel();
      this.fram1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.apitgridRegMait = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTitre = new MozartUC.apiLabel();
      this.cboMaitre = new System.Windows.Forms.ComboBox();
      this.cboTech = new System.Windows.Forms.ComboBox();
      this.fram1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdAnnuler
      // 
      this.cmdAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAnnuler, "cmdAnnuler");
      this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAnnuler.HelpContextID = 20;
      this.cmdAnnuler.Name = "cmdAnnuler";
      this.cmdAnnuler.UseVisualStyleBackColor = false;
      // 
      // Label51
      // 
      resources.ApplyResources(this.Label51, "Label51");
      this.Label51.BackColor = System.Drawing.Color.Wheat;
      this.Label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label51.HelpContextID = 0;
      this.Label51.Name = "Label51";
      // 
      // Label52
      // 
      resources.ApplyResources(this.Label52, "Label52");
      this.Label52.BackColor = System.Drawing.Color.Wheat;
      this.Label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label52.HelpContextID = 0;
      this.Label52.Name = "Label52";
      // 
      // fram1
      // 
      this.fram1.BackColor = System.Drawing.Color.Wheat;
      this.fram1.Controls.Add(this.cboTech);
      this.fram1.Controls.Add(this.cboMaitre);
      this.fram1.Controls.Add(this.cmdValider);
      this.fram1.Controls.Add(this.cmdAnnuler);
      this.fram1.Controls.Add(this.Label51);
      this.fram1.Controls.Add(this.Label52);
      resources.ApplyResources(this.fram1, "fram1");
      this.fram1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.fram1.HelpContextID = 0;
      this.fram1.Name = "fram1";
      this.fram1.TabStop = false;
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid_SelectionChanged);
      // 
      // apitgridRegMait
      // 
      resources.ApplyResources(this.apitgridRegMait, "apitgridRegMait");
      this.apitgridRegMait.FilterBar = true;
      this.apitgridRegMait.FooterBar = true;
      this.apitgridRegMait.Name = "apitgridRegMait";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTitre
      // 
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // cboMaitre
      // 
      this.cboMaitre.FormattingEnabled = true;
      resources.ApplyResources(this.cboMaitre, "cboMaitre");
      this.cboMaitre.Name = "cboMaitre";
      // 
      // cboTech
      // 
      this.cboTech.FormattingEnabled = true;
      resources.ApplyResources(this.cboTech, "cboTech");
      this.cboTech.Name = "cboTech";
      // 
      // frmContremaitre
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.fram1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.apitgridRegMait);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmContremaitre";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmContremaitre_Load);
      this.fram1.ResumeLayout(false);
      this.fram1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdAnnuler;
    private MozartUC.apiLabel Label51;
    private MozartUC.apiLabel Label52;
    private MozartUC.apiGroupBox fram1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiTGrid apitgridRegMait;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lblTitre;
    private System.Windows.Forms.ComboBox cboTech;
    private System.Windows.Forms.ComboBox cboMaitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
