
namespace MozartCS
{
  partial class frmWizardProspeClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWizardProspeClient));
      this.PanelMaster = new System.Windows.Forms.Panel();
      this.LblTitre = new System.Windows.Forms.Label();
      this.GrpBtn = new System.Windows.Forms.GroupBox();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.BtnPrevious = new MozartUC.apiButton();
      this.BtnNext = new MozartUC.apiButton();
      this.BtnFinish = new MozartUC.apiButton();
      this.PictSociete = new System.Windows.Forms.PictureBox();
      this.PanelMaster.SuspendLayout();
      this.GrpBtn.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PictSociete)).BeginInit();
      this.SuspendLayout();
      // 
      // PanelMaster
      // 
      resources.ApplyResources(this.PanelMaster, "PanelMaster");
      this.PanelMaster.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.PanelMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PanelMaster.Controls.Add(this.LblTitre);
      this.PanelMaster.Name = "PanelMaster";
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.ForeColor = System.Drawing.Color.IndianRed;
      this.LblTitre.Name = "LblTitre";
      // 
      // GrpBtn
      // 
      this.GrpBtn.BackColor = System.Drawing.Color.Wheat;
      this.GrpBtn.Controls.Add(this.BtnCancel);
      this.GrpBtn.Controls.Add(this.BtnPrevious);
      this.GrpBtn.Controls.Add(this.BtnNext);
      this.GrpBtn.Controls.Add(this.BtnFinish);
      resources.ApplyResources(this.GrpBtn, "GrpBtn");
      this.GrpBtn.Name = "GrpBtn";
      this.GrpBtn.TabStop = false;
      // 
      // BtnCancel
      // 
      this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.BtnCancel, "BtnCancel");
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.UseVisualStyleBackColor = true;
      // 
      // BtnPrevious
      // 
      this.BtnPrevious.HelpContextID = 0;
      resources.ApplyResources(this.BtnPrevious, "BtnPrevious");
      this.BtnPrevious.Name = "BtnPrevious";
      this.BtnPrevious.UseVisualStyleBackColor = true;
      this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
      // 
      // BtnNext
      // 
      this.BtnNext.HelpContextID = 0;
      resources.ApplyResources(this.BtnNext, "BtnNext");
      this.BtnNext.Name = "BtnNext";
      this.BtnNext.UseVisualStyleBackColor = true;
      this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
      // 
      // BtnFinish
      // 
      this.BtnFinish.HelpContextID = 0;
      resources.ApplyResources(this.BtnFinish, "BtnFinish");
      this.BtnFinish.Name = "BtnFinish";
      this.BtnFinish.UseVisualStyleBackColor = true;
      this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
      // 
      // PictSociete
      // 
      resources.ApplyResources(this.PictSociete, "PictSociete");
      this.PictSociete.Name = "PictSociete";
      this.PictSociete.TabStop = false;
      // 
      // frmWizardProspeClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
      this.CancelButton = this.BtnCancel;
      this.Controls.Add(this.PanelMaster);
      this.Controls.Add(this.GrpBtn);
      this.Controls.Add(this.PictSociete);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmWizardProspeClient";
      this.Load += new System.EventHandler(this.frmWizardProspeClient_Load);
      this.PanelMaster.ResumeLayout(false);
      this.PanelMaster.PerformLayout();
      this.GrpBtn.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PictSociete)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Panel PanelMaster;
    internal System.Windows.Forms.GroupBox GrpBtn;
    internal System.Windows.Forms.Button BtnCancel;
    internal MozartUC.apiButton BtnPrevious;
    internal MozartUC.apiButton BtnNext;
    internal MozartUC.apiButton BtnFinish;
    internal System.Windows.Forms.PictureBox PictSociete;
    internal System.Windows.Forms.Label LblTitre;
  }
}