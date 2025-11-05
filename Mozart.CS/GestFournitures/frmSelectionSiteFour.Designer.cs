namespace MozartCS
{
  partial class frmSelectionSiteFour
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionSiteFour));
      this.cmdImplantation = new MozartUC.apiButton();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSelectionner = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdImplantation
      // 
      resources.ApplyResources(this.cmdImplantation, "cmdImplantation");
      this.cmdImplantation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImplantation.HelpContextID = 0;
      this.cmdImplantation.Name = "cmdImplantation";
      this.cmdImplantation.Tag = "96";
      this.cmdImplantation.UseVisualStyleBackColor = true;
      this.cmdImplantation.Click += new System.EventHandler(this.cmdImplantation_Click_1);
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.ApiGrid_DoubleClickE);
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
      // cmdSelectionner
      // 
      resources.ApplyResources(this.cmdSelectionner, "cmdSelectionner");
      this.cmdSelectionner.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSelectionner.HelpContextID = 0;
      this.cmdSelectionner.Name = "cmdSelectionner";
      this.cmdSelectionner.Tag = "20";
      this.cmdSelectionner.UseVisualStyleBackColor = true;
      this.cmdSelectionner.Click += new System.EventHandler(this.cmdSelectionner_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmSelectionSiteFour
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdImplantation);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSelectionner);
      this.Controls.Add(this.Label1);
      this.Name = "frmSelectionSiteFour";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSelectionSiteFour_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdImplantation;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSelectionner;
    private MozartUC.apiLabel Label1;

  }
}
