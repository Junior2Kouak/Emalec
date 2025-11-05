namespace MozartCS
{
  partial class frmGestAstr
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestAstr));
      this.cboMois = new System.Windows.Forms.ComboBox();
      this.cboAnnee = new System.Windows.Forms.ComboBox();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cboMois
      // 
      this.cboMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboMois, "cboMois");
      this.cboMois.Name = "cboMois";
      // 
      // cboAnnee
      // 
      this.cboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboAnnee, "cboAnnee");
      this.cboAnnee.Name = "cboAnnee";
      // 
      // cmdVisu
      // 
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      // 
      // cmdValider
      // 
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
      // 
      // lblLabels8
      // 
      this.lblLabels8.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels0
      // 
      this.lblLabels0.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmGestAstr
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboMois);
      this.Controls.Add(this.cboAnnee);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.lblLabels8);
      this.Controls.Add(this.lblLabels0);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestAstr";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestAstr_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboMois;
    private System.Windows.Forms.ComboBox cboAnnee;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
