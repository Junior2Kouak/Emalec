
namespace MozartCS
{
  partial class frmGIDTRechercheST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIDTRechercheST));
      this.label1 = new System.Windows.Forms.Label();
      this.Grid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSelectionner = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.ForeColor = System.Drawing.Color.Yellow;
      this.label1.Name = "label1";
      // 
      // Grid
      // 
      resources.ApplyResources(this.Grid, "Grid");
      this.Grid.FilterBar = true;
      this.Grid.FooterBar = true;
      this.Grid.Name = "Grid";
      this.Grid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.Grid_DoubleClickE);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSelectionner
      // 
      this.cmdSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdSelectionner, "cmdSelectionner");
      this.cmdSelectionner.HelpContextID = 0;
      this.cmdSelectionner.Name = "cmdSelectionner";
      this.cmdSelectionner.UseVisualStyleBackColor = false;
      this.cmdSelectionner.Click += new System.EventHandler(this.cmdSelectionner_Click);
      // 
      // frmGIDTRechercheST
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.Controls.Add(this.cmdSelectionner);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Grid);
      this.Controls.Add(this.label1);
      this.Name = "frmGIDTRechercheST";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGIDTRechercheST_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private MozartUC.apiTGrid Grid;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSelectionner;
  }
}