namespace MozartCS
{
  partial class frmMedia
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedia));
      this.TextRep = new MozartUC.apiTextBox();
      this.TextSite = new MozartUC.apiTextBox();
      this.txtClient = new MozartUC.apiTextBox();
      this.O4 = new MozartUC.apiLabel();
      this.lblLabels13 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.Combo1 = new System.Windows.Forms.ComboBox();
      this.cmdFile = new MozartUC.apiButton();
      this.TextImg = new MozartUC.apiTextBox();
      this.TextComment = new MozartUC.apiTextBox();
      this.TextLib = new MozartUC.apiTextBox();
      this.TextDate = new MozartUC.apiTextBox();
      this.brwWebBrowser = new System.Windows.Forms.WebBrowser();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Image1 = new System.Windows.Forms.PictureBox();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      // 
      // TextRep
      // 
      this.TextRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.TextRep, "TextRep");
      this.TextRep.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextRep.HelpContextID = 0;
      this.TextRep.Name = "TextRep";
      // 
      // TextSite
      // 
      this.TextSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.TextSite, "TextSite");
      this.TextSite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextSite.HelpContextID = 0;
      this.TextSite.Name = "TextSite";
      // 
      // txtClient
      // 
      this.txtClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtClient, "txtClient");
      this.txtClient.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtClient.HelpContextID = 0;
      this.txtClient.Name = "txtClient";
      // 
      // O4
      // 
      resources.ApplyResources(this.O4, "O4");
      this.O4.BackColor = System.Drawing.Color.Transparent;
      this.O4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.O4.HelpContextID = 0;
      this.O4.Name = "O4";
      // 
      // lblLabels13
      // 
      resources.ApplyResources(this.lblLabels13, "lblLabels13");
      this.lblLabels13.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels13.HelpContextID = 0;
      this.lblLabels13.Name = "lblLabels13";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.Frame4.Controls.Add(this.TextRep);
      this.Frame4.Controls.Add(this.TextSite);
      this.Frame4.Controls.Add(this.txtClient);
      this.Frame4.Controls.Add(this.O4);
      this.Frame4.Controls.Add(this.lblLabels13);
      this.Frame4.Controls.Add(this.lblLabels3);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Combo1
      // 
      this.Combo1.Items.AddRange(new object[] {
            resources.GetString("Combo1.Items"),
            resources.GetString("Combo1.Items1"),
            resources.GetString("Combo1.Items2"),
            resources.GetString("Combo1.Items3")});
      resources.ApplyResources(this.Combo1, "Combo1");
      this.Combo1.Name = "Combo1";
      this.Combo1.SelectedIndexChanged += new System.EventHandler(this.Combo1_SelectedIndexChanged);
      // 
      // cmdFile
      // 
      this.cmdFile.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFile.HelpContextID = 0;
      resources.ApplyResources(this.cmdFile, "cmdFile");
      this.cmdFile.Name = "cmdFile";
      this.cmdFile.UseVisualStyleBackColor = true;
      this.cmdFile.Click += new System.EventHandler(this.cmdFile_Click);
      // 
      // TextImg
      // 
      resources.ApplyResources(this.TextImg, "TextImg");
      this.TextImg.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextImg.HelpContextID = 0;
      this.TextImg.Name = "TextImg";
      this.TextImg.TextChanged += new System.EventHandler(this.TextImg_TextChanged);
      // 
      // TextComment
      // 
      this.TextComment.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextComment.HelpContextID = 0;
      resources.ApplyResources(this.TextComment, "TextComment");
      this.TextComment.Name = "TextComment";
      // 
      // TextLib
      // 
      this.TextLib.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextLib.HelpContextID = 0;
      resources.ApplyResources(this.TextLib, "TextLib");
      this.TextLib.Name = "TextLib";
      this.TextLib.TextChanged += new System.EventHandler(this.TextLib_TextChanged);
      // 
      // TextDate
      // 
      resources.ApplyResources(this.TextDate, "TextDate");
      this.TextDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TextDate.HelpContextID = 0;
      this.TextDate.Name = "TextDate";
      // 
      // brwWebBrowser
      // 
      resources.ApplyResources(this.brwWebBrowser, "brwWebBrowser");
      this.brwWebBrowser.Name = "brwWebBrowser";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Image1
      // 
      this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Image1, "Image1");
      this.Image1.Name = "Image1";
      this.Image1.TabStop = false;
      this.Image1.DoubleClick += new System.EventHandler(this.Image1_DoubleClick);
      // 
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.Frame3.Controls.Add(this.Combo1);
      this.Frame3.Controls.Add(this.cmdFile);
      this.Frame3.Controls.Add(this.TextImg);
      this.Frame3.Controls.Add(this.TextComment);
      this.Frame3.Controls.Add(this.TextLib);
      this.Frame3.Controls.Add(this.TextDate);
      this.Frame3.Controls.Add(this.brwWebBrowser);
      this.Frame3.Controls.Add(this.lblLabels2);
      this.Frame3.Controls.Add(this.lblLabels1);
      this.Frame3.Controls.Add(this.lblLabels0);
      this.Frame3.Controls.Add(this.lblLabels11);
      this.Frame3.Controls.Add(this.Image1);
      this.Frame3.Controls.Add(this.lblLabels4);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
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
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmMedia
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmMedia";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMedia_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox TextRep;
    private MozartUC.apiTextBox TextSite;
    private MozartUC.apiTextBox txtClient;
    private MozartUC.apiLabel O4;
    private MozartUC.apiLabel lblLabels13;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame4;
    private System.Windows.Forms.ComboBox Combo1;
    private MozartUC.apiButton cmdFile;
    private MozartUC.apiTextBox TextImg;
    private MozartUC.apiTextBox TextComment;
    private MozartUC.apiTextBox TextLib;
    private MozartUC.apiTextBox TextDate;
    private System.Windows.Forms.WebBrowser brwWebBrowser;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels11;
    private System.Windows.Forms.PictureBox Image1;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
