namespace MozartCS
{
  partial class frmSaisieContratTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieContratTech));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.lstContrat = new System.Windows.Forms.CheckedListBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      this.cmdEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = false;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // lstContrat
      // 
      this.lstContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lstContrat.CheckOnClick = true;
      this.lstContrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.lstContrat, "lstContrat");
      this.lstContrat.MultiColumn = true;
      this.lstContrat.Name = "lstContrat";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmSaisieContratTech
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.lstContrat);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmSaisieContratTech";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieContratTech_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdEnregistrer;
    private System.Windows.Forms.CheckedListBox lstContrat;
    private MozartUC.apiButton cmdFermer;
  }
}
