namespace MozartCS
{
  partial class frmDetailDoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailDoc));
			this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
			this.frameVisu = new MozartUC.apiGroupBox();
			this.cmdFichier = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.txtTitre = new MozartUC.apiTextBox();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
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
			this.frameVisu.FrameColor = System.Drawing.Color.Empty;
			this.frameVisu.HelpContextID = 0;
			this.frameVisu.Name = "frameVisu";
			this.frameVisu.TabStop = false;
			// 
			// cmdFichier
			// 
			this.cmdFichier.AllowDrop = true;
			resources.ApplyResources(this.cmdFichier, "cmdFichier");
			this.cmdFichier.HelpContextID = 0;
			this.cmdFichier.Name = "cmdFichier";
			this.cmdFichier.Tag = "2";
			this.cmdFichier.UseVisualStyleBackColor = true;
			this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
			this.cmdFichier.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmdFichier_DragDrop);
			this.cmdFichier.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmdFichier_DragEnter);
			// 
			// cmdFermer
			// 
			resources.ApplyResources(this.cmdFermer, "cmdFermer");
			this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdFermer.HelpContextID = 0;
			this.cmdFermer.Name = "cmdFermer";
			this.cmdFermer.Tag = "15";
			this.cmdFermer.UseVisualStyleBackColor = true;
			// 
			// cmdValider
			// 
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.HelpContextID = 0;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.Tag = "66";
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
			// lblLabels3
			// 
			resources.ApplyResources(this.lblLabels3, "lblLabels3");
			this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels3.HelpContextID = 0;
			this.lblLabels3.Name = "lblLabels3";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.txtTitre);
			this.Frame1.Controls.Add(this.lblLabels3);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Wheat;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
			// 
			// frmDetailDoc
			// 
			this.AcceptButton = this.cmdFermer;
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.frameVisu);
			this.Controls.Add(this.cmdFichier);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.Frame1);
			this.Name = "frmDetailDoc";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDetailDoc_Load);
			this.frameVisu.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiGroupBox frameVisu;
    private MozartUC.apiButton cmdFichier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtTitre;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
