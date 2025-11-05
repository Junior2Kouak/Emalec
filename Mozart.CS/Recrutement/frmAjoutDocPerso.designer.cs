namespace MozartCS
{
  partial class frmAjoutDocPerso
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutDocPerso));
      this.cboFormatFichier = new System.Windows.Forms.ComboBox();
      this.cmdParcourir = new MozartUC.apiButton();
      this.TextFic = new MozartUC.apiTextBox();
      this.TextComment = new MozartUC.apiTextBox();
      this.TextLib = new MozartUC.apiTextBox();
      this.lblLabels2 = new System.Windows.Forms.Label();
      this.lblLabels1 = new System.Windows.Forms.Label();
      this.lblLabels0 = new System.Windows.Forms.Label();
      this.lblLabels11 = new System.Windows.Forms.Label();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdMax = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cboFormatFichier
      // 
      this.cboFormatFichier.DisplayMember = "VFORMAT";
      resources.ApplyResources(this.cboFormatFichier, "cboFormatFichier");
      this.cboFormatFichier.Name = "cboFormatFichier";
      this.cboFormatFichier.ValueMember = "CFORMAT";
      this.cboFormatFichier.SelectedIndexChanged += new System.EventHandler(this.cboFormatFichier_SelectedIndexChanged);
      // 
      // cmdParcourir
      // 
      this.cmdParcourir.HelpContextID = 0;
      resources.ApplyResources(this.cmdParcourir, "cmdParcourir");
      this.cmdParcourir.Name = "cmdParcourir";
      this.cmdParcourir.UseVisualStyleBackColor = true;
      this.cmdParcourir.Click += new System.EventHandler(this.cmdParcourir_Click);
      // 
      // TextFic
      // 
      resources.ApplyResources(this.TextFic, "TextFic");
      this.TextFic.HelpContextID = 0;
      this.TextFic.Name = "TextFic";
      this.TextFic.TextChanged += new System.EventHandler(this.TextFic_TextChanged);
      // 
      // TextComment
      // 
      this.TextComment.HelpContextID = 0;
      resources.ApplyResources(this.TextComment, "TextComment");
      this.TextComment.Name = "TextComment";
      // 
      // TextLib
      // 
      this.TextLib.HelpContextID = 0;
      resources.ApplyResources(this.TextLib, "TextLib");
      this.TextLib.Name = "TextLib";
      this.TextLib.TextChanged += new System.EventHandler(this.TextLib_TextChanged);
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdMax
      // 
      resources.ApplyResources(this.cmdMax, "cmdMax");
      this.cmdMax.HelpContextID = 0;
      this.cmdMax.Name = "cmdMax";
      this.cmdMax.UseVisualStyleBackColor = true;
      this.cmdMax.Click += new System.EventHandler(this.CmdMax_Click);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // frmAjoutDocPerso
      // 
      this.AcceptButton = this.cmdValider;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboFormatFichier);
      this.Controls.Add(this.cmdParcourir);
      this.Controls.Add(this.TextFic);
      this.Controls.Add(this.TextComment);
      this.Controls.Add(this.TextLib);
      this.Controls.Add(this.lblLabels2);
      this.Controls.Add(this.lblLabels1);
      this.Controls.Add(this.lblLabels0);
      this.Controls.Add(this.lblLabels11);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdMax);
      this.Controls.Add(this.WebBrowser1);
      this.Controls.Add(this.Label1);
      this.Name = "frmAjoutDocPerso";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAjoutDocPerso_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboFormatFichier;
    private MozartUC.apiButton cmdParcourir;
    private MozartUC.apiTextBox TextFic;
    private MozartUC.apiTextBox TextComment;
    private MozartUC.apiTextBox TextLib;
    private System.Windows.Forms.Label lblLabels2;
    private System.Windows.Forms.Label lblLabels1;
    private System.Windows.Forms.Label lblLabels0;
    private System.Windows.Forms.Label lblLabels11;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdMax;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private System.Windows.Forms.Label Label1;

  }
}
