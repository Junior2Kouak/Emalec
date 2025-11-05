namespace MozartCS
{
  partial class frmSaisieLangPers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieLangPers));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.lstLangue = new System.Windows.Forms.CheckedListBox();
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
      // lstLangue
      // 
      resources.ApplyResources(this.lstLangue, "lstLangue");
      this.lstLangue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lstLangue.CheckOnClick = true;
      this.lstLangue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lstLangue.Name = "lstLangue";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmSaisieLangPers
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.lstLangue);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmSaisieLangPers";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieLangPers_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdEnregistrer;
    private System.Windows.Forms.CheckedListBox lstLangue;
    private MozartUC.apiButton cmdFermer;

  }
}
