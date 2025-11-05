namespace MozartCS
{
  partial class frmOutillageDocDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutillageDocDetail));
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.frameVisu = new MozartUC.apiGroupBox();
      this.cmdFichier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.txtTitre = new MozartUC.apiTextBox();
      this.LblDateDoc = new MozartUC.apiLabel();
      this.LblCreateur = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.frameVisu.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // frameVisu
      // 
      resources.ApplyResources(this.frameVisu, "frameVisu");
      this.frameVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.frameVisu.Controls.Add(this.WebBrowser1);
      this.frameVisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.frameVisu.HelpContextID = 0;
      this.frameVisu.Name = "frameVisu";
      this.frameVisu.TabStop = false;
      // 
      // cmdFichier
      // 
      resources.ApplyResources(this.cmdFichier, "cmdFichier");
      this.cmdFichier.HelpContextID = 0;
      this.cmdFichier.Name = "cmdFichier";
      this.cmdFichier.Tag = "Joindre un fichier";
      this.cmdFichier.UseVisualStyleBackColor = true;
      this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
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
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtTitre
      // 
      this.txtTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTitre, "txtTitre");
      this.txtTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTitre.HelpContextID = 0;
      this.txtTitre.Name = "txtTitre";
      // 
      // LblDateDoc
      // 
      this.LblDateDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.LblDateDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.LblDateDoc, "LblDateDoc");
      this.LblDateDoc.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblDateDoc.HelpContextID = 0;
      this.LblDateDoc.Name = "LblDateDoc";
      // 
      // LblCreateur
      // 
      this.LblCreateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.LblCreateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.LblCreateur, "LblCreateur");
      this.LblCreateur.ForeColor = System.Drawing.SystemColors.ControlText;
      this.LblCreateur.HelpContextID = 0;
      this.LblCreateur.Name = "LblCreateur";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.txtTitre);
      this.Frame1.Controls.Add(this.LblDateDoc);
      this.Frame1.Controls.Add(this.LblCreateur);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Controls.Add(this.lblLabels3);
      this.Frame1.Controls.Add(this.lblLabels1);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // frmOutillageDocDetail
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.frameVisu);
      this.Controls.Add(this.cmdFichier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame1);
      this.Name = "frmOutillageDocDetail";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOutillageDocDetail_FormClosed);
      this.Load += new System.EventHandler(this.frmOutillageDocDetail_Load);
      this.frameVisu.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiGroupBox frameVisu;
    private MozartUC.apiButton cmdFichier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtTitre;
    private MozartUC.apiLabel LblDateDoc;
    private MozartUC.apiLabel LblCreateur;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
