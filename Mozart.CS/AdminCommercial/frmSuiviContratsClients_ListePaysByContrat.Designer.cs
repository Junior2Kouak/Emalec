
namespace MozartCS
{
  partial class frmSuiviContratsClients_ListePaysByContrat
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
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.BtnFermer = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // apiTGrid
      // 
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiTGrid.Location = new System.Drawing.Point(13, 42);
      this.apiTGrid.Margin = new System.Windows.Forms.Padding(4);
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.Size = new System.Drawing.Size(620, 479);
      this.apiTGrid.TabIndex = 53;
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(12, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(343, 29);
      this.Label1.TabIndex = 54;
      this.Label1.Text = "Liste des pays d\'intervention";
      // 
      // BtnFermer
      // 
      this.BtnFermer.Location = new System.Drawing.Point(521, 538);
      this.BtnFermer.Name = "BtnFermer";
      this.BtnFermer.Size = new System.Drawing.Size(112, 29);
      this.BtnFermer.TabIndex = 55;
      this.BtnFermer.Text = "Fermer";
      this.BtnFermer.UseVisualStyleBackColor = true;
      this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
      // 
      // frmSuiviContratsClients_ListePaysByContrat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(642, 579);
      this.Controls.Add(this.BtnFermer);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.apiTGrid);
      this.Name = "frmSuiviContratsClients_ListePaysByContrat";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Liste des pays d\'intervention";
      this.Load += new System.EventHandler(this.frmSuiviContratsClients_ListePaysByContrat_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Button BtnFermer;
  }
}