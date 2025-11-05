namespace MozartCS
{
  partial class frmAdminWeb
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminWeb));
			this.cmdMG = new MozartUC.apiButton();
			this.cmdMC = new MozartUC.apiButton();
			this.cmdTech = new MozartUC.apiButton();
			this.cmdCont = new MozartUC.apiButton();
			this.cmdTechs = new MozartUC.apiButton();
			this.cmdFermer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdMessageToutTech = new MozartUC.apiButton();
			this.SuspendLayout();
			// 
			// cmdMG
			// 
			this.cmdMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdMG, "cmdMG");
			this.cmdMG.HelpContextID = 117;
			this.cmdMG.Name = "cmdMG";
			this.cmdMG.UseVisualStyleBackColor = false;
			this.cmdMG.Click += new System.EventHandler(this.cmdMG_Click);
			// 
			// cmdMC
			// 
			this.cmdMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdMC, "cmdMC");
			this.cmdMC.HelpContextID = 116;
			this.cmdMC.Name = "cmdMC";
			this.cmdMC.UseVisualStyleBackColor = false;
			this.cmdMC.Click += new System.EventHandler(this.cmdMC_Click);
			// 
			// cmdTech
			// 
			this.cmdTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdTech, "cmdTech");
			this.cmdTech.HelpContextID = 0;
			this.cmdTech.Name = "cmdTech";
			this.cmdTech.UseVisualStyleBackColor = false;
			this.cmdTech.Click += new System.EventHandler(this.cmdTech_Click);
			// 
			// cmdCont
			// 
			this.cmdCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdCont, "cmdCont");
			this.cmdCont.HelpContextID = 0;
			this.cmdCont.Name = "cmdCont";
			this.cmdCont.Tag = "407";
			this.cmdCont.UseVisualStyleBackColor = false;
			this.cmdCont.Click += new System.EventHandler(this.cmdCont_Click);
			// 
			// cmdTechs
			// 
			this.cmdTechs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdTechs, "cmdTechs");
			this.cmdTechs.HelpContextID = 0;
			this.cmdTechs.Name = "cmdTechs";
			this.cmdTechs.Tag = "422";
			this.cmdTechs.UseVisualStyleBackColor = false;
			this.cmdTechs.Click += new System.EventHandler(this.cmdTechs_Click);
			// 
			// cmdFermer
			// 
			resources.ApplyResources(this.cmdFermer, "cmdFermer");
			this.cmdFermer.Name = "cmdFermer";
			this.cmdFermer.UseVisualStyleBackColor = true;
			this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// cmdMessageToutTech
			// 
			this.cmdMessageToutTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdMessageToutTech, "cmdMessageToutTech");
			this.cmdMessageToutTech.HelpContextID = 406;
			this.cmdMessageToutTech.Name = "cmdMessageToutTech";
			this.cmdMessageToutTech.UseVisualStyleBackColor = false;
			this.cmdMessageToutTech.Click += new System.EventHandler(this.cmdMessageToutTech_Click);
			// 
			// frmAdminWeb
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.cmdMessageToutTech);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdTechs);
			this.Controls.Add(this.cmdCont);
			this.Controls.Add(this.cmdTech);
			this.Controls.Add(this.cmdMC);
			this.Controls.Add(this.cmdMG);
			this.Name = "frmAdminWeb";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmAdminWeb_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdMG;
    private MozartUC.apiButton cmdMC;
    private MozartUC.apiButton cmdTech;
    private MozartUC.apiButton cmdCont;
    private MozartUC.apiButton cmdTechs;
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Label label1;
		private MozartUC.apiButton cmdMessageToutTech;
	}
}
