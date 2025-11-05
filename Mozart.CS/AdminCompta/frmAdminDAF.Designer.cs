
namespace MozartCS
{
  partial class frmAdminDAF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDAF));
      this.cmdAdminDAF = new MozartUC.apiButton();
      this.cmdAdminRegleTVA = new MozartUC.apiButton();
      this.cmdTypePrestaTVAIntra = new MozartUC.apiButton();
      this.cmdAdminTvaFilliale = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdAdminDAF
      // 
      this.cmdAdminDAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAdminDAF, "cmdAdminDAF");
      this.cmdAdminDAF.HelpContextID = 0;
      this.cmdAdminDAF.Name = "cmdAdminDAF";
      this.cmdAdminDAF.Tag = "33";
      this.cmdAdminDAF.UseVisualStyleBackColor = false;
      this.cmdAdminDAF.Click += new System.EventHandler(this.cmdAdminDAF_Click);
      // 
      // cmdAdminRegleTVA
      // 
      this.cmdAdminRegleTVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAdminRegleTVA, "cmdAdminRegleTVA");
      this.cmdAdminRegleTVA.HelpContextID = 0;
      this.cmdAdminRegleTVA.Name = "cmdAdminRegleTVA";
      this.cmdAdminRegleTVA.Tag = "33";
      this.cmdAdminRegleTVA.UseVisualStyleBackColor = false;
      this.cmdAdminRegleTVA.Click += new System.EventHandler(this.cmdAdminRegleTVA_Click);
      // 
      // cmdTypePrestaTVAIntra
      // 
      this.cmdTypePrestaTVAIntra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdTypePrestaTVAIntra, "cmdTypePrestaTVAIntra");
      this.cmdTypePrestaTVAIntra.HelpContextID = 0;
      this.cmdTypePrestaTVAIntra.Name = "cmdTypePrestaTVAIntra";
      this.cmdTypePrestaTVAIntra.Tag = "33";
      this.cmdTypePrestaTVAIntra.UseVisualStyleBackColor = false;
      this.cmdTypePrestaTVAIntra.Click += new System.EventHandler(this.cmdTypePrestaTVAIntra_Click);
      // 
      // cmdAdminTvaFilliale
      // 
      this.cmdAdminTvaFilliale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAdminTvaFilliale, "cmdAdminTvaFilliale");
      this.cmdAdminTvaFilliale.HelpContextID = 0;
      this.cmdAdminTvaFilliale.Name = "cmdAdminTvaFilliale";
      this.cmdAdminTvaFilliale.Tag = "33";
      this.cmdAdminTvaFilliale.UseVisualStyleBackColor = false;
      this.cmdAdminTvaFilliale.Click += new System.EventHandler(this.cmdAdminTvaFilliale_Click);
      // 
      // frmAdminDAF
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdAdminTvaFilliale);
      this.Controls.Add(this.cmdTypePrestaTVAIntra);
      this.Controls.Add(this.cmdAdminRegleTVA);
      this.Controls.Add(this.cmdAdminDAF);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmAdminDAF";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmAdminDAF_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdAdminDAF;
    private MozartUC.apiButton cmdAdminRegleTVA;
    private MozartUC.apiButton cmdTypePrestaTVAIntra;
    private MozartUC.apiButton cmdAdminTvaFilliale;
  }
}