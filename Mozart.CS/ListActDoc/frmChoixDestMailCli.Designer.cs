namespace MozartCS
{
  partial class frmChoixDestMailCli
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixDestMailCli));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.txtAdrMail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lstDest = new System.Windows.Forms.CheckedListBox();
      this.txtSujet = new System.Windows.Forms.TextBox();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.cmdValider = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.cmdCocher = new System.Windows.Forms.Button();
      this.cmdDecocher = new System.Windows.Forms.Button();
      this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtAdrMail);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lstDest);
      this.panel1.Name = "panel1";
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
      this.txtAdrMail.Enter += new System.EventHandler(this.txtAdrMail_Enter);
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
      // txtSujet
      // 
      resources.ApplyResources(this.txtSujet, "txtSujet");
      this.txtSujet.Name = "txtSujet";
      // 
      // txtMessage
      // 
      resources.ApplyResources(this.txtMessage, "txtMessage");
      this.txtMessage.Name = "txtMessage";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdCocher
      // 
      resources.ApplyResources(this.cmdCocher, "cmdCocher");
      this.cmdCocher.Name = "cmdCocher";
      this.cmdCocher.UseVisualStyleBackColor = true;
      this.cmdCocher.Click += new System.EventHandler(this.cmdCocher_Click);
      // 
      // cmdDecocher
      // 
      resources.ApplyResources(this.cmdDecocher, "cmdDecocher");
      this.cmdDecocher.Name = "cmdDecocher";
      this.cmdDecocher.UseVisualStyleBackColor = true;
      this.cmdDecocher.Click += new System.EventHandler(this.cmdDecocher_Click);
      // 
      // fileSystemWatcher1
      // 
      this.fileSystemWatcher1.EnableRaisingEvents = true;
      this.fileSystemWatcher1.SynchronizingObject = this;
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label4.Name = "label4";
      // 
      // frmChoixDestMailCli
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.txtSujet);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cmdDecocher);
      this.Controls.Add(this.cmdCocher);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.panel1);
      this.Name = "frmChoixDestMailCli";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixDestMailCli_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtAdrMail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckedListBox lstDest;
    private System.Windows.Forms.TextBox txtSujet;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Button cmdCocher;
    private System.Windows.Forms.Button cmdDecocher;
    private System.Windows.Forms.Label label2;
    private System.IO.FileSystemWatcher fileSystemWatcher1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}