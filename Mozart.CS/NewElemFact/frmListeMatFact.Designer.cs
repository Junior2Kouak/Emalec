namespace MozartCS
{
  partial class frmListeMatFact
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeMatFact));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.apiTgrid = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      this.cmdEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // apiTgrid
      // 
      resources.ApplyResources(this.apiTgrid, "apiTgrid");
      this.apiTgrid.FilterBar = true;
      this.apiTgrid.FooterBar = true;
      this.apiTgrid.Name = "apiTgrid";
      // 
      // frmListeMatFact
      // 
      this.AcceptButton = this.cmdEnregistrer;
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.apiTgrid);
      this.Name = "frmListeMatFact";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmListeMatFact_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiTGrid apiTgrid;

  }
}
