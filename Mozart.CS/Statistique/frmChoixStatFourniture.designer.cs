namespace MozartCS
{
  partial class frmMenuCommercial
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCommercial));
      this.Command1 = new MozartUC.apiButton();
      this.CmdStatCliCom = new MozartUC.apiButton();
      this.cmdProsp = new MozartUC.apiButton();
      this.cmdStatClient = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // Command1
      // 
      this.Command1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 293;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "68";
      this.Command1.UseVisualStyleBackColor = false;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // CmdStatCliCom
      // 
      this.CmdStatCliCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdStatCliCom, "CmdStatCliCom");
      this.CmdStatCliCom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdStatCliCom.HelpContextID = 438;
      this.CmdStatCliCom.Name = "CmdStatCliCom";
      this.CmdStatCliCom.Tag = "67";
      this.CmdStatCliCom.UseVisualStyleBackColor = false;
      this.CmdStatCliCom.Click += new System.EventHandler(this.CmdStatCliCom_Click);
      // 
      // cmdProsp
      // 
      this.cmdProsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdProsp, "cmdProsp");
      this.cmdProsp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdProsp.HelpContextID = 437;
      this.cmdProsp.Name = "cmdProsp";
      this.cmdProsp.Tag = "35";
      this.cmdProsp.UseVisualStyleBackColor = false;
      this.cmdProsp.Click += new System.EventHandler(this.cmdProsp_Click);
      // 
      // cmdStatClient
      // 
      this.cmdStatClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdStatClient, "cmdStatClient");
      this.cmdStatClient.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdStatClient.HelpContextID = 377;
      this.cmdStatClient.Name = "cmdStatClient";
      this.cmdStatClient.Tag = "68";
      this.cmdStatClient.UseVisualStyleBackColor = false;
      this.cmdStatClient.Click += new System.EventHandler(this.cmdStatClient_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmMenuCommercial
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.CmdStatCliCom);
      this.Controls.Add(this.cmdProsp);
      this.Controls.Add(this.cmdStatClient);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Name = "frmMenuCommercial";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMenuCommercial_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton Command1;
    private MozartUC.apiButton CmdStatCliCom;
    private MozartUC.apiButton cmdProsp;
    private MozartUC.apiButton cmdStatClient;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
