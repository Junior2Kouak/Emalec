namespace MozartCS
{
  partial class frmChoixDestMail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixDestMail));
      this.cmdAdd_PJ_DocCLi = new MozartUC.apiButton();
      this.chkBonCde = new MozartUC.apiCheckBox();
      this.chkAttachement = new MozartUC.apiCheckBox();
      this.cmdDelPJ = new MozartUC.apiButton();
      this.cmdAddPJ = new MozartUC.apiButton();
      this.lstPJ = new System.Windows.Forms.ListBox();
      this.txtMessage = new MozartUC.apiTextBox();
      this.txtSujet = new MozartUC.apiTextBox();
      this.txtAdrMail = new MozartUC.apiTextBox();
      this.lstDest = new System.Windows.Forms.CheckedListBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdCocher = new MozartUC.apiButton();
      this.cmdDecocher = new MozartUC.apiButton();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblPJSizeFilesAll = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // cmdAdd_PJ_DocCLi
      // 
      resources.ApplyResources(this.cmdAdd_PJ_DocCLi, "cmdAdd_PJ_DocCLi");
      this.cmdAdd_PJ_DocCLi.HelpContextID = 0;
      this.cmdAdd_PJ_DocCLi.Name = "cmdAdd_PJ_DocCLi";
      this.cmdAdd_PJ_DocCLi.Tag = "15";
      this.cmdAdd_PJ_DocCLi.UseVisualStyleBackColor = true;
      this.cmdAdd_PJ_DocCLi.Click += new System.EventHandler(this.cmdAdd_PJ_DocCLi_Click);
      // 
      // chkBonCde
      // 
      this.chkBonCde.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkBonCde, "chkBonCde");
      this.chkBonCde.HelpContextID = 0;
      this.chkBonCde.Name = "chkBonCde";
      this.chkBonCde.UseVisualStyleBackColor = false;
      this.chkBonCde.Click += new System.EventHandler(this.chkBonCmd_Click);
      // 
      // chkAttachement
      // 
      this.chkAttachement.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkAttachement, "chkAttachement");
      this.chkAttachement.HelpContextID = 0;
      this.chkAttachement.Name = "chkAttachement";
      this.chkAttachement.UseVisualStyleBackColor = false;
      this.chkAttachement.Click += new System.EventHandler(this.chkAttachement_Click);
      // 
      // cmdDelPJ
      // 
      resources.ApplyResources(this.cmdDelPJ, "cmdDelPJ");
      this.cmdDelPJ.HelpContextID = 0;
      this.cmdDelPJ.Name = "cmdDelPJ";
      this.cmdDelPJ.Tag = "15";
      this.cmdDelPJ.UseVisualStyleBackColor = true;
      this.cmdDelPJ.Click += new System.EventHandler(this.cmdDelPJ_Click);
      // 
      // cmdAddPJ
      // 
      resources.ApplyResources(this.cmdAddPJ, "cmdAddPJ");
      this.cmdAddPJ.HelpContextID = 0;
      this.cmdAddPJ.Name = "cmdAddPJ";
      this.cmdAddPJ.Tag = "15";
      this.cmdAddPJ.UseVisualStyleBackColor = true;
      this.cmdAddPJ.Click += new System.EventHandler(this.cmdAddPJ_Click);
      // 
      // lstPJ
      // 
      resources.ApplyResources(this.lstPJ, "lstPJ");
      this.lstPJ.Name = "lstPJ";
      // 
      // txtMessage
      // 
      this.txtMessage.HelpContextID = 0;
      resources.ApplyResources(this.txtMessage, "txtMessage");
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Enter += new System.EventHandler(this.txtboxes_Enter);
      // 
      // txtSujet
      // 
      this.txtSujet.HelpContextID = 0;
      resources.ApplyResources(this.txtSujet, "txtSujet");
      this.txtSujet.Name = "txtSujet";
      this.txtSujet.Enter += new System.EventHandler(this.txtboxes_Enter);
      // 
      // txtAdrMail
      // 
      this.txtAdrMail.HelpContextID = 0;
      resources.ApplyResources(this.txtAdrMail, "txtAdrMail");
      this.txtAdrMail.Name = "txtAdrMail";
      this.txtAdrMail.Enter += new System.EventHandler(this.txtboxes_Enter);
      this.txtAdrMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdrMail_Validating);
      // 
      // lstDest
      // 
      resources.ApplyResources(this.lstDest, "lstDest");
      this.lstDest.Name = "lstDest";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdCocher
      // 
      this.cmdCocher.HelpContextID = 0;
      resources.ApplyResources(this.cmdCocher, "cmdCocher");
      this.cmdCocher.Name = "cmdCocher";
      this.cmdCocher.Tag = "15";
      this.cmdCocher.UseVisualStyleBackColor = true;
      this.cmdCocher.Click += new System.EventHandler(this.cmdCocher_Click);
      // 
      // cmdDecocher
      // 
      this.cmdDecocher.HelpContextID = 0;
      resources.ApplyResources(this.cmdDecocher, "cmdDecocher");
      this.cmdDecocher.Name = "cmdDecocher";
      this.cmdDecocher.Tag = "15";
      this.cmdDecocher.UseVisualStyleBackColor = true;
      this.cmdDecocher.Click += new System.EventHandler(this.cmdDecocher_Click);
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.label6, "label6");
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label6.Name = "label6";
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.label5, "label5");
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label5.Name = "label5";
      // 
      // lblPJSizeFilesAll
      // 
      this.lblPJSizeFilesAll.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblPJSizeFilesAll, "lblPJSizeFilesAll");
      this.lblPJSizeFilesAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblPJSizeFilesAll.Name = "lblPJSizeFilesAll";
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.label4, "label4");
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label4.Name = "label4";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.Name = "Label2";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // frmChoixDestMail
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdAdd_PJ_DocCLi);
      this.Controls.Add(this.chkBonCde);
      this.Controls.Add(this.chkAttachement);
      this.Controls.Add(this.cmdDelPJ);
      this.Controls.Add(this.cmdAddPJ);
      this.Controls.Add(this.lstPJ);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.txtSujet);
      this.Controls.Add(this.txtAdrMail);
      this.Controls.Add(this.lstDest);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdCocher);
      this.Controls.Add(this.cmdDecocher);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblPJSizeFilesAll);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Name = "frmChoixDestMail";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixDestMail_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdAdd_PJ_DocCLi;
    private MozartUC.apiCheckBox chkBonCde;
    private MozartUC.apiCheckBox chkAttachement;
    private MozartUC.apiButton cmdDelPJ;
    private MozartUC.apiButton cmdAddPJ;
    private System.Windows.Forms.ListBox lstPJ;
    private MozartUC.apiTextBox txtMessage;
    private MozartUC.apiTextBox txtSujet;
    private MozartUC.apiTextBox txtAdrMail;
    private System.Windows.Forms.CheckedListBox lstDest;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdCocher;
    private MozartUC.apiButton cmdDecocher;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblPJSizeFilesAll;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label Label3;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}
