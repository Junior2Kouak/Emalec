
namespace MozartCS.AdminCompta
{
  partial class frmValorisationStock
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValorisationStock));
      this.BtnFermer = new System.Windows.Forms.Button();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.LblTitre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // BtnFermer
      // 
      resources.ApplyResources(this.BtnFermer, "BtnFermer");
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.Name = "LblTitre";
      // 
      // frmValorisationStock
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.Controls.Add(this.LblTitre);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.BtnFermer);
      this.Name = "frmValorisationStock";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmValorisationStock_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnFermer;
    private MozartUC.apiTGrid apiTGrid1;
    internal System.Windows.Forms.Label LblTitre;
  }
}