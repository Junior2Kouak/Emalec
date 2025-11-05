namespace MozartCS
{
  partial class frmChoixStatTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixStatTech));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdStatTechTs = new MozartUC.apiButton();
      this.CmdStatTechInd = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdStatTechTs
      // 
      this.cmdStatTechTs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdStatTechTs, "cmdStatTechTs");
      this.cmdStatTechTs.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdStatTechTs.HelpContextID = 0;
      this.cmdStatTechTs.Name = "cmdStatTechTs";
      this.cmdStatTechTs.UseVisualStyleBackColor = false;
      this.cmdStatTechTs.Click += new System.EventHandler(this.cmdStatTechTs_Click);
      // 
      // CmdStatTechInd
      // 
      this.CmdStatTechInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdStatTechInd, "CmdStatTechInd");
      this.CmdStatTechInd.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdStatTechInd.HelpContextID = 0;
      this.CmdStatTechInd.Name = "CmdStatTechInd";
      this.CmdStatTechInd.UseVisualStyleBackColor = false;
      this.CmdStatTechInd.Click += new System.EventHandler(this.CmdStatTechInd_Click);
      // 
      // frmChoixStatTech
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdStatTechTs);
      this.Controls.Add(this.CmdStatTechInd);
      this.Name = "frmChoixStatTech";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixStatTech_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdStatTechTs;
    private MozartUC.apiButton CmdStatTechInd;

  }
}
