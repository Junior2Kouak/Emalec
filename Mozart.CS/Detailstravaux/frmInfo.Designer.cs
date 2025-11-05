namespace MozartCS
{
  partial class frmInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtInfo = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.txtInfo);
			this.panel1.Name = "panel1";
			// 
			// txtInfo
			// 
			resources.ApplyResources(this.txtInfo, "txtInfo");
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtInfo_LinkClicked);
			// 
			// frmInfo
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInfo";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmInfo_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox txtInfo;
	}
}