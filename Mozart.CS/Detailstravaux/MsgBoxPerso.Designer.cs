namespace MozartCS
{
  partial class MsgBoxPerso
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBoxPerso));
      this.btYes = new System.Windows.Forms.Button();
      this.btNo = new System.Windows.Forms.Button();
      this.btCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btYes
      // 
      resources.ApplyResources(this.btYes, "btYes");
      this.btYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
      this.btYes.Name = "btYes";
      this.btYes.UseVisualStyleBackColor = true;
      // 
      // btNo
      // 
      resources.ApplyResources(this.btNo, "btNo");
      this.btNo.DialogResult = System.Windows.Forms.DialogResult.No;
      this.btNo.Name = "btNo";
      this.btNo.UseVisualStyleBackColor = true;
      // 
      // btCancel
      // 
      resources.ApplyResources(this.btCancel, "btCancel");
      this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancel.Name = "btCancel";
      this.btCancel.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // pictureBox1
      // 
      resources.ApplyResources(this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      // 
      // MsgBoxPerso
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btCancel;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btCancel);
      this.Controls.Add(this.btNo);
      this.Controls.Add(this.btYes);
      this.Name = "MsgBoxPerso";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btYes;
    private System.Windows.Forms.Button btNo;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}