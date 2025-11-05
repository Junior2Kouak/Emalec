namespace MozartCS
{
  partial class frmMessageBoxPerso
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBoxPerso));
      this.BtnNo = new MozartUC.apiButton();
      this.BtnYes = new MozartUC.apiButton();
      this.LblQuestion = new MozartUC.apiLabel();
      this.ImgIcone = new System.Windows.Forms.PictureBox();
      this.LblMessage = new MozartUC.apiLabel();
      ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnNo
      // 
      resources.ApplyResources(this.BtnNo, "BtnNo");
      this.BtnNo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnNo.HelpContextID = 0;
      this.BtnNo.Name = "BtnNo";
      this.BtnNo.UseVisualStyleBackColor = true;
      this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
      // 
      // BtnYes
      // 
      resources.ApplyResources(this.BtnYes, "BtnYes");
      this.BtnYes.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnYes.HelpContextID = 0;
      this.BtnYes.Name = "BtnYes";
      this.BtnYes.UseVisualStyleBackColor = true;
      this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
      // 
      // LblQuestion
      // 
      resources.ApplyResources(this.LblQuestion, "LblQuestion");
      this.LblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.LblQuestion.HelpContextID = 0;
      this.LblQuestion.Name = "LblQuestion";
      // 
      // ImgIcone
      // 
      resources.ApplyResources(this.ImgIcone, "ImgIcone");
      this.ImgIcone.Name = "ImgIcone";
      this.ImgIcone.TabStop = false;
      // 
      // LblMessage
      // 
      resources.ApplyResources(this.LblMessage, "LblMessage");
      this.LblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.LblMessage.HelpContextID = 0;
      this.LblMessage.Name = "LblMessage";
      // 
      // frmMessageBoxPerso
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.BtnNo);
      this.Controls.Add(this.BtnYes);
      this.Controls.Add(this.LblQuestion);
      this.Controls.Add(this.ImgIcone);
      this.Controls.Add(this.LblMessage);
      this.Name = "frmMessageBoxPerso";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmMessageBoxPerso_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ImgIcone)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton BtnNo;
    private MozartUC.apiButton BtnYes;
    private MozartUC.apiLabel LblQuestion;
    private System.Windows.Forms.PictureBox ImgIcone;
    private MozartUC.apiLabel LblMessage;

  }
}
