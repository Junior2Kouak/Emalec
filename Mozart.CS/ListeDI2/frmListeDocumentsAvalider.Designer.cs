namespace MozartCS
{
  partial class frmListeDocumentsAvalider
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDocumentsAvalider));
      this.cmdVisualiser = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.LblTitre = new MozartUC.apiLabel();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.txtSujet = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmdAnnuler = new System.Windows.Forms.Button();
      this.cmdValiderMail = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAdrMail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lstDest = new System.Windows.Forms.CheckedListBox();
      this.cmdModifier = new MozartUC.apiButton();
      this.apiButton1 = new MozartUC.apiButton();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdVisualiser
      // 
      resources.ApplyResources(this.cmdVisualiser, "cmdVisualiser");
      this.cmdVisualiser.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisualiser.HelpContextID = 0;
      this.cmdVisualiser.Name = "cmdVisualiser";
      this.cmdVisualiser.Tag = "15";
      this.cmdVisualiser.UseVisualStyleBackColor = true;
      this.cmdVisualiser.Click += new System.EventHandler(this.cmdVisualiser_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.BackColor = System.Drawing.Color.Wheat;
      this.LblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblTitre.HelpContextID = 0;
      this.LblTitre.Name = "LblTitre";
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "15";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.txtMessage);
      this.panel1.Controls.Add(this.txtSujet);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.cmdAnnuler);
      this.panel1.Controls.Add(this.cmdValiderMail);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtAdrMail);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lstDest);
      this.panel1.Name = "panel1";
      // 
      // txtMessage
      // 
      resources.ApplyResources(this.txtMessage, "txtMessage");
      this.txtMessage.Name = "txtMessage";
      // 
      // txtSujet
      // 
      resources.ApplyResources(this.txtSujet, "txtSujet");
      this.txtSujet.Name = "txtSujet";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label4.Name = "label4";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label3.Name = "label3";
      // 
      // cmdAnnuler
      // 
      resources.ApplyResources(this.cmdAnnuler, "cmdAnnuler");
      this.cmdAnnuler.Name = "cmdAnnuler";
      this.cmdAnnuler.UseVisualStyleBackColor = true;
      this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
      // 
      // cmdValiderMail
      // 
      resources.ApplyResources(this.cmdValiderMail, "cmdValiderMail");
      this.cmdValiderMail.Name = "cmdValiderMail";
      this.cmdValiderMail.UseVisualStyleBackColor = true;
      this.cmdValiderMail.Click += new System.EventHandler(this.cmdValiderMail_Click);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label2.Name = "label2";
      // 
      // txtAdrMail
      // 
      resources.ApplyResources(this.txtAdrMail, "txtAdrMail");
      this.txtAdrMail.Name = "txtAdrMail";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // lstDest
      // 
      resources.ApplyResources(this.lstDest, "lstDest");
      this.lstDest.CheckOnClick = true;
      this.lstDest.FormattingEnabled = true;
      this.lstDest.Name = "lstDest";
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // apiButton1
      // 
      resources.ApplyResources(this.apiButton1, "apiButton1");
      this.apiButton1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiButton1.HelpContextID = 0;
      this.apiButton1.Name = "apiButton1";
      this.apiButton1.Tag = "19";
      this.apiButton1.UseVisualStyleBackColor = true;
      this.apiButton1.Click += new System.EventHandler(this.apiButton1_Click);
      // 
      // frmListeDocumentsAvalider
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiButton1);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdVisualiser);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.LblTitre);
      this.Name = "frmListeDocumentsAvalider";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSousTenCours_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdVisualiser;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel LblTitre;
    private MozartUC.apiButton cmdSupprimer;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtAdrMail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckedListBox lstDest;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.TextBox txtSujet;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button cmdAnnuler;
    private System.Windows.Forms.Button cmdValiderMail;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton apiButton1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
