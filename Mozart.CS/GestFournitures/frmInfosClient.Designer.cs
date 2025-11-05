namespace MozartCS
{
  partial class frmInfosClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfosClient));
      this.txtInfo = new System.Windows.Forms.TextBox();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtInfo
      // 
      resources.ApplyResources(this.txtInfo, "txtInfo");
      this.txtInfo.BackColor = System.Drawing.SystemColors.Info;
      this.txtInfo.Name = "txtInfo";
      this.txtInfo.ReadOnly = true;
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmInfosClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.txtInfo);
      this.Name = "frmInfosClient";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmInfosClient_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInfo;
    private System.Windows.Forms.Button cmdFermer;
  }
}