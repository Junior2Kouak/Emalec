namespace MozartCS
{
  partial class frmStatAnaCSTByCte
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatAnaCSTByCte));
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiGridListe = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiGridListe
      // 
      resources.ApplyResources(this.apiGridListe, "apiGridListe");
      this.apiGridListe.FilterBar = true;
      this.apiGridListe.FooterBar = true;
      this.apiGridListe.Name = "apiGridListe";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // frmStatAnaCSTByCte
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiGridListe);
      this.Controls.Add(this.Label1);
      this.Name = "frmStatAnaCSTByCte";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmStatAnaCSTByCte_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiGridListe;
    private System.Windows.Forms.Label Label1;

  }
}
