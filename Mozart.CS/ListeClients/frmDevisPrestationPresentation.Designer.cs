namespace MozartCS
{
  partial class frmDevisPrestationPresentation
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
      this.CmdVisu = new MozartUC.apiButton();
      this.apiGridCat = new MozartUC.apiTGrid();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiGridPrestation = new MozartUC.apiTGrid();
      this.apiGridSSCat = new MozartUC.apiTGrid();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CmdVisu
      // 
      this.CmdVisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CmdVisu.HelpContextID = 0;
      this.CmdVisu.Location = new System.Drawing.Point(8, 96);
      this.CmdVisu.Name = "CmdVisu";
      this.CmdVisu.Size = new System.Drawing.Size(73, 57);
      this.CmdVisu.TabIndex = 8;
      this.CmdVisu.Tag = "66";
      this.CmdVisu.Text = "Visualiser Brouillon";
      this.CmdVisu.UseVisualStyleBackColor = true;
      this.CmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // apiGridCat
      // 
      this.apiGridCat.FilterBar = true;
      this.apiGridCat.FooterBar = true;
      this.apiGridCat.Location = new System.Drawing.Point(96, 32);
      this.apiGridCat.Name = "apiGridCat";
      this.apiGridCat.Size = new System.Drawing.Size(633, 241);
      this.apiGridCat.TabIndex = 3;
      this.apiGridCat.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.apiGridCat_InitNewRowE);
      this.apiGridCat.ValidateRowE += new MozartUC.apiTGrid.ValidateRowEEventHandler(this.apiGridCat_ValidateRowE);
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Location = new System.Drawing.Point(8, 32);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(73, 57);
      this.cmdValider.TabIndex = 2;
      this.cmdValider.Tag = "66";
      this.cmdValider.Text = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Location = new System.Drawing.Point(8, 745);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(73, 57);
      this.cmdFermer.TabIndex = 0;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiGridPrestation
      // 
      this.apiGridPrestation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.apiGridPrestation.FilterBar = true;
      this.apiGridPrestation.FooterBar = true;
      this.apiGridPrestation.Location = new System.Drawing.Point(96, 304);
      this.apiGridPrestation.Name = "apiGridPrestation";
      this.apiGridPrestation.Size = new System.Drawing.Size(1271, 498);
      this.apiGridPrestation.TabIndex = 1;
      this.apiGridPrestation.PreviewKeyDownE += new MozartUC.apiTGrid.PreviewKeyDownEEventHandler(this.apiGridPrestation_PreviewKeyDownE);
      this.apiGridPrestation.ValidateRowE += new MozartUC.apiTGrid.ValidateRowEEventHandler(this.apiGridPrestation_ValidateRowE);
      // 
      // apiGridSSCat
      // 
      this.apiGridSSCat.FilterBar = true;
      this.apiGridSSCat.FooterBar = true;
      this.apiGridSSCat.Location = new System.Drawing.Point(735, 32);
      this.apiGridSSCat.Name = "apiGridSSCat";
      this.apiGridSSCat.Size = new System.Drawing.Size(632, 241);
      this.apiGridSSCat.TabIndex = 6;
      this.apiGridSSCat.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.apiGridSSCat_InitNewRowE);
      this.apiGridSSCat.ValidateRowE += new MozartUC.apiTGrid.ValidateRowEEventHandler(this.apiGridSSCat_ValidateRowE);
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label2.Location = new System.Drawing.Point(730, 0);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(331, 29);
      this.Label2.TabIndex = 7;
      this.Label2.Text = "Gestion des sous-chapitres";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label1.Location = new System.Drawing.Point(96, 272);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(315, 29);
      this.Label1.TabIndex = 5;
      this.Label1.Text = "Affectation des catégories";
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label3.Location = new System.Drawing.Point(96, 0);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(382, 29);
      this.Label3.TabIndex = 4;
      this.Label3.Text = "Gestion des titres des chapitres";
      // 
      // frmDevisPrestationPresentation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.ClientSize = new System.Drawing.Size(1379, 814);
      this.Controls.Add(this.CmdVisu);
      this.Controls.Add(this.apiGridCat);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiGridPrestation);
      this.Controls.Add(this.apiGridSSCat);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Label3);
      this.Name = "frmDevisPrestationPresentation";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Présentation du devis de prestation";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDevisPrestationPresentation_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdVisu;
    private MozartUC.apiTGrid apiGridCat;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiGridPrestation;
    private MozartUC.apiTGrid apiGridSSCat;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.Label Label3;

  }
}
