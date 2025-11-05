namespace MozartCS
{
  partial class frmAdminStockVeh
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminStockVeh));
      this.cmdListe = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdListeReap = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdListe
      // 
      this.cmdListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdListe, "cmdListe");
      this.cmdListe.HelpContextID = 0;
      this.cmdListe.Name = "cmdListe";
      this.cmdListe.Tag = "90";
      this.cmdListe.UseVisualStyleBackColor = false;
      this.cmdListe.Click += new System.EventHandler(this.cmdListe_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdListeReap
      // 
      this.cmdListeReap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdListeReap, "cmdListeReap");
      this.cmdListeReap.HelpContextID = 0;
      this.cmdListeReap.Name = "cmdListeReap";
      this.cmdListeReap.Tag = "90";
      this.cmdListeReap.UseVisualStyleBackColor = false;
      this.cmdListeReap.Click += new System.EventHandler(this.cmdListeReap_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Name = "Label1";
      // 
      // frmAdminStockVeh
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdListe);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdListeReap);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminStockVeh";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminStockVeh_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdListe;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdListeReap;
    private System.Windows.Forms.Label Label1;
  }
}
