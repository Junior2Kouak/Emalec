
namespace MozartCS.Menu
{
  partial class frmWorkFlowDelegation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkFlowDelegation));
      this.cmdDelegCmde = new MozartUC.apiButton();
      this.cmdDelegDevis = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdDelegCmde
      // 
      this.cmdDelegCmde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDelegCmde, "cmdDelegCmde");
      this.cmdDelegCmde.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDelegCmde.HelpContextID = 0;
      this.cmdDelegCmde.Name = "cmdDelegCmde";
      this.cmdDelegCmde.UseVisualStyleBackColor = false;
      this.cmdDelegCmde.Click += new System.EventHandler(this.cmdDelegCmde_Click);
      // 
      // cmdDelegDevis
      // 
      this.cmdDelegDevis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdDelegDevis, "cmdDelegDevis");
      this.cmdDelegDevis.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDelegDevis.HelpContextID = 705;
      this.cmdDelegDevis.Name = "cmdDelegDevis";
      this.cmdDelegDevis.UseVisualStyleBackColor = false;
      this.cmdDelegDevis.Click += new System.EventHandler(this.cmdDelegDevis_Click);
      // 
      // frmWorkFlowDelegation
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cmdDelegCmde);
      this.Controls.Add(this.cmdDelegDevis);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmWorkFlowDelegation";
      this.Load += new System.EventHandler(this.frmWorkFlowDelegation_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdDelegCmde;
    private MozartUC.apiButton cmdDelegDevis;
  }
}