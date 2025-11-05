namespace MozartCS
{
  partial class frmSelectServTech
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectServTech));
      this.cmdEnregistrer = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.label1 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.toolTip1.SetToolTip(this.cmdEnregistrer, resources.GetString("cmdEnregistrer.ToolTip"));
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.toolTip1.SetToolTip(this.cmdFermer, resources.GetString("cmdFermer.ToolTip"));
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
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // frmSelectServTech
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Name = "frmSelectServTech";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSelectServTech_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button cmdEnregistrer;
    private System.Windows.Forms.Button cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}