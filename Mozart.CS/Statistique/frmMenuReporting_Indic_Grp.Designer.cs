namespace MozartCS
{
  partial class frmMenuReporting_Indic_Grp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReporting_Indic_Grp));
			this.label1 = new System.Windows.Forms.Label();
			this.cmdQuitter = new System.Windows.Forms.Button();
			this.cmdIndicChaff = new MozartUC.apiButton();
			this.cmdIndicAss = new MozartUC.apiButton();
			this.CmdFactClient = new MozartUC.apiButton();
			this.btnRavel = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.UseVisualStyleBackColor = true;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// cmdIndicChaff
			// 
			this.cmdIndicChaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdIndicChaff, "cmdIndicChaff");
			this.cmdIndicChaff.HelpContextID = 601;
			this.cmdIndicChaff.Name = "cmdIndicChaff";
			this.cmdIndicChaff.UseVisualStyleBackColor = false;
			this.cmdIndicChaff.Click += new System.EventHandler(this.cmdIndicChaff_Click);
			// 
			// cmdIndicAss
			// 
			this.cmdIndicAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdIndicAss, "cmdIndicAss");
			this.cmdIndicAss.HelpContextID = 602;
			this.cmdIndicAss.Name = "cmdIndicAss";
			this.cmdIndicAss.UseVisualStyleBackColor = false;
			this.cmdIndicAss.Click += new System.EventHandler(this.cmdIndicAss_Click);
			// 
			// CmdFactClient
			// 
			this.CmdFactClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.CmdFactClient, "CmdFactClient");
			this.CmdFactClient.HelpContextID = 605;
			this.CmdFactClient.Name = "CmdFactClient";
			this.CmdFactClient.UseVisualStyleBackColor = false;
			this.CmdFactClient.Click += new System.EventHandler(this.CmdFactClient_Click);
			// 
			// btnRavel
			// 
			this.btnRavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.btnRavel, "btnRavel");
			this.btnRavel.HelpContextID = 0;
			this.btnRavel.Name = "btnRavel";
			this.btnRavel.UseVisualStyleBackColor = false;
			this.btnRavel.Click += new System.EventHandler(this.btnRavel_Click);
			// 
			// frmMenuReporting_Indic_Grp
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.CmdFactClient);
			this.Controls.Add(this.cmdIndicAss);
			this.Controls.Add(this.cmdIndicChaff);
			this.Controls.Add(this.btnRavel);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.label1);
			this.Name = "frmMenuReporting_Indic_Grp";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cmdQuitter;
    private MozartUC.apiButton cmdIndicChaff;
    private MozartUC.apiButton cmdIndicAss;
    private MozartUC.apiButton CmdFactClient;
	private MozartUC.apiButton btnRavel;
  }
}