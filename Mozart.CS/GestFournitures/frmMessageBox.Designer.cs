namespace MozartCS
{
  partial class frmMessageBox
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
      this.lblMessage = new System.Windows.Forms.Label();
      this.cmdYes = new System.Windows.Forms.Button();
      this.cmdNo = new System.Windows.Forms.Button();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblMessage
      // 
      resources.ApplyResources(this.lblMessage, "lblMessage");
      this.lblMessage.ForeColor = System.Drawing.Color.Red;
      this.lblMessage.Name = "lblMessage";
      // 
      // cmdYes
      // 
      resources.ApplyResources(this.cmdYes, "cmdYes");
      this.cmdYes.Name = "cmdYes";
      this.cmdYes.UseVisualStyleBackColor = true;
      this.cmdYes.Click += new System.EventHandler(this.cmdYes_Click);
      // 
      // cmdNo
      // 
      resources.ApplyResources(this.cmdNo, "cmdNo");
      this.cmdNo.Name = "cmdNo";
      this.cmdNo.UseVisualStyleBackColor = true;
      this.cmdNo.Click += new System.EventHandler(this.cmdNo_Click);
      // 
      // cmdCancel
      // 
      resources.ApplyResources(this.cmdCancel, "cmdCancel");
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
      // 
      // frmMessageBox
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Controls.Add(this.cmdCancel);
      this.Controls.Add(this.cmdNo);
      this.Controls.Add(this.cmdYes);
      this.Controls.Add(this.lblMessage);
      this.Name = "frmMessageBox";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmMessageBox_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button cmdYes;
    private System.Windows.Forms.Button cmdNo;
    private System.Windows.Forms.Button cmdCancel;
  }
}