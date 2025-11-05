
namespace MozartCS
{
  partial class frmGIDTAdmin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIDTAdmin));
      this.cboclient = new MozartUC.apiCombo();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.cmdGIDTListe = new MozartUC.apiButton();
      this.cmdGIDTSaisie = new MozartUC.apiButton();
      this.cmdGIDTArbo = new MozartUC.apiButton();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiGroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      this.cboclient.NewValues = false;
      // 
      // apiGroupBox1
      // 
      this.apiGroupBox1.Controls.Add(this.cmdGIDTListe);
      this.apiGroupBox1.Controls.Add(this.cmdGIDTSaisie);
      this.apiGroupBox1.Controls.Add(this.cmdGIDTArbo);
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // cmdGIDTListe
      // 
      this.cmdGIDTListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdGIDTListe, "cmdGIDTListe");
      this.cmdGIDTListe.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGIDTListe.HelpContextID = 0;
      this.cmdGIDTListe.Name = "cmdGIDTListe";
      this.cmdGIDTListe.UseVisualStyleBackColor = false;
      this.cmdGIDTListe.Click += new System.EventHandler(this.cmdGIDTListe_Click);
      // 
      // cmdGIDTSaisie
      // 
      this.cmdGIDTSaisie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdGIDTSaisie, "cmdGIDTSaisie");
      this.cmdGIDTSaisie.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGIDTSaisie.HelpContextID = 0;
      this.cmdGIDTSaisie.Name = "cmdGIDTSaisie";
      this.cmdGIDTSaisie.UseVisualStyleBackColor = false;
      this.cmdGIDTSaisie.Click += new System.EventHandler(this.cmdGIDTSaisie_Click);
      // 
      // cmdGIDTArbo
      // 
      this.cmdGIDTArbo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdGIDTArbo, "cmdGIDTArbo");
      this.cmdGIDTArbo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGIDTArbo.HelpContextID = 206;
      this.cmdGIDTArbo.Name = "cmdGIDTArbo";
      this.cmdGIDTArbo.UseVisualStyleBackColor = false;
      this.cmdGIDTArbo.Click += new System.EventHandler(this.cmdGIDTArbo_Click);
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // cmdFermer
      // 
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmGIDTAdmin
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.apiGroupBox1);
      this.Controls.Add(this.cboclient);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmGIDTAdmin";
      this.Load += new System.EventHandler(this.frmGIDTAdmin_Load);
      this.apiGroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCombo cboclient;
    private MozartUC.apiGroupBox apiGroupBox1;
    private MozartUC.apiButton cmdGIDTListe;
    private MozartUC.apiButton cmdGIDTSaisie;
    private MozartUC.apiButton cmdGIDTArbo;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiButton cmdFermer;
  }
}