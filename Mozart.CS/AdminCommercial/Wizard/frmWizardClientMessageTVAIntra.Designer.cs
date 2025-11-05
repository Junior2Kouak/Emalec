
namespace MozartCS
{
  partial class frmWizardClientMessageTVAIntra
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardClientMessageTVAIntra));
      this.Label1 = new System.Windows.Forms.Label();
      this.BtnOK = new System.Windows.Forms.Button();
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.White;
      this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // BtnOK
      // 
      this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.BtnOK, "BtnOK");
      this.BtnOK.Name = "BtnOK";
      this.BtnOK.UseVisualStyleBackColor = true;
      // 
      // PictureBox1
      // 
      resources.ApplyResources(this.PictureBox1, "PictureBox1");
      this.PictureBox1.Image = global::MozartCS.Properties.Resources.Tabl_TVA_INTRA;
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.TabStop = false;
      // 
      // frmWizardClientMessageTVAIntra
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BtnOK;
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.BtnOK);
      this.Controls.Add(this.PictureBox1);
      this.Name = "frmWizardClientMessageTVAIntra";
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Button BtnOK;
    internal System.Windows.Forms.PictureBox PictureBox1;
  }
}