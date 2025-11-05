
namespace MozartCS.DetailPersonnel
{
  partial class frmSaisiePrimes
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisiePrimes));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.grdPrimes = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // grdPrimes
      // 
      this.grdPrimes.FilterBar = false;
      this.grdPrimes.FooterBar = false;
      resources.ApplyResources(this.grdPrimes, "grdPrimes");
      this.grdPrimes.Name = "grdPrimes";
      this.grdPrimes.PreviewKeyDownE += new MozartUC.apiTGrid.PreviewKeyDownEEventHandler(this.grdPrimes_PreviewKeyDownE);
      // 
      // frmSaisiePrimes
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.grdPrimes);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Name = "frmSaisiePrimes";
      this.Load += new System.EventHandler(this.frmSaisiePrimes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiLabel lblTitre;
    private MozartUC.apiTGrid grdPrimes;
  }
}