namespace MozartCS
{
  partial class frmDetailDocVehicule
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailDocVehicule));
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.cboDoc = new System.Windows.Forms.ComboBox();
			this.txtNom = new MozartUC.apiTextBox();
			this.txtComment = new MozartUC.apiTextBox();
			this.txtFichier = new MozartUC.apiTextBox();
			this.cmdFile = new MozartUC.apiButton();
			this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.lblLabels11 = new MozartUC.apiLabel();
			this.lblLabels1 = new MozartUC.apiLabel();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.Label1 = new MozartUC.apiLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Frame3.SuspendLayout();
			this.SuspendLayout();
			// 
			// WebBrowser1
			// 
			resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
			this.WebBrowser1.Name = "WebBrowser1";
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
			// cboDoc
			// 
			resources.ApplyResources(this.cboDoc, "cboDoc");
			this.cboDoc.Name = "cboDoc";
			// 
			// txtNom
			// 
			this.txtNom.AcceptsTab = true;
			resources.ApplyResources(this.txtNom, "txtNom");
			this.txtNom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNom.HelpContextID = 0;
			this.txtNom.Name = "txtNom";
			// 
			// txtComment
			// 
			resources.ApplyResources(this.txtComment, "txtComment");
			this.txtComment.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtComment.HelpContextID = 0;
			this.txtComment.Name = "txtComment";
			// 
			// txtFichier
			// 
			resources.ApplyResources(this.txtFichier, "txtFichier");
			this.txtFichier.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFichier.HelpContextID = 0;
			this.txtFichier.Name = "txtFichier";
			this.txtFichier.TextChanged += new System.EventHandler(this.txtFic_TextChanged);
			// 
			// cmdFile
			// 
			resources.ApplyResources(this.cmdFile, "cmdFile");
			this.cmdFile.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFile.HelpContextID = 0;
			this.cmdFile.Name = "cmdFile";
			this.cmdFile.UseVisualStyleBackColor = true;
			this.cmdFile.Click += new System.EventHandler(this.Command1_Click);
			// 
			// lblLabels3
			// 
			resources.ApplyResources(this.lblLabels3, "lblLabels3");
			this.lblLabels3.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels3.HelpContextID = 0;
			this.lblLabels3.Name = "lblLabels3";
			// 
			// lblLabels11
			// 
			resources.ApplyResources(this.lblLabels11, "lblLabels11");
			this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels11.HelpContextID = 0;
			this.lblLabels11.Name = "lblLabels11";
			// 
			// lblLabels1
			// 
			resources.ApplyResources(this.lblLabels1, "lblLabels1");
			this.lblLabels1.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels1.HelpContextID = 0;
			this.lblLabels1.Name = "lblLabels1";
			// 
			// lblLabels2
			// 
			resources.ApplyResources(this.lblLabels2, "lblLabels2");
			this.lblLabels2.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels2.HelpContextID = 0;
			this.lblLabels2.Name = "lblLabels2";
			// 
			// Frame3
			// 
			resources.ApplyResources(this.Frame3, "Frame3");
			this.Frame3.BackColor = System.Drawing.Color.Wheat;
			this.Frame3.Controls.Add(this.cboDoc);
			this.Frame3.Controls.Add(this.txtNom);
			this.Frame3.Controls.Add(this.txtComment);
			this.Frame3.Controls.Add(this.txtFichier);
			this.Frame3.Controls.Add(this.cmdFile);
			this.Frame3.Controls.Add(this.lblLabels3);
			this.Frame3.Controls.Add(this.lblLabels11);
			this.Frame3.Controls.Add(this.lblLabels1);
			this.Frame3.Controls.Add(this.lblLabels2);
			this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmDetailDocVehicule
			// 
			this.AcceptButton = this.cmdFermer;
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.WebBrowser1);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Label1);
			this.Name = "frmDetailDocVehicule";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDetailDocVehicule_Load);
			this.Frame3.ResumeLayout(false);
			this.Frame3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.ComboBox cboDoc;
    private MozartUC.apiTextBox txtNom;
    private MozartUC.apiTextBox txtComment;
    private MozartUC.apiTextBox txtFichier;
    private MozartUC.apiButton cmdFile;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiGroupBox Frame3;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
