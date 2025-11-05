namespace MozartCS
{
  partial class frmChoixDevisClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixDevisClient));
      this.cmdDevisPrest = new MozartUC.apiButton();
      this.cmdDevisFO = new MozartUC.apiButton();
      this.cmdDevisFOV2 = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdDevisPrest
      // 
      resources.ApplyResources(this.cmdDevisPrest, "cmdDevisPrest");
      this.cmdDevisPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDevisPrest.HelpContextID = 233;
      this.cmdDevisPrest.Name = "cmdDevisPrest";
      this.cmdDevisPrest.UseVisualStyleBackColor = true;
      this.cmdDevisPrest.Click += new System.EventHandler(this.cmdDevisPrest_Click);
      // 
      // cmdDevisFO
      // 
      resources.ApplyResources(this.cmdDevisFO, "cmdDevisFO");
      this.cmdDevisFO.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDevisFO.HelpContextID = 160;
      this.cmdDevisFO.Name = "cmdDevisFO";
      this.cmdDevisFO.UseVisualStyleBackColor = true;
      this.cmdDevisFO.Click += new System.EventHandler(this.cmdDevisFo_Click);
      // 
      // cmdDevisFOV2
      // 
      resources.ApplyResources(this.cmdDevisFOV2, "cmdDevisFOV2");
      this.cmdDevisFOV2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDevisFOV2.HelpContextID = 705;
      this.cmdDevisFOV2.Name = "cmdDevisFOV2";
      this.cmdDevisFOV2.UseVisualStyleBackColor = true;
      this.cmdDevisFOV2.Click += new System.EventHandler(this.apiButton1_Click);
      // 
      // frmChoixDevisClient
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDevisFOV2);
      this.Controls.Add(this.cmdDevisPrest);
      this.Controls.Add(this.cmdDevisFO);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmChoixDevisClient";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmChoixDevisClient_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdDevisPrest;
    private MozartUC.apiButton cmdDevisFO;
    private MozartUC.apiButton cmdDevisFOV2;
  }
}
