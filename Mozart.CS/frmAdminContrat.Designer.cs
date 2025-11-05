namespace MozartCS
{
  partial class frmAdminContrat
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminContrat));
      this.Label1 = new System.Windows.Forms.Label();
      this.cmdGestDomTech = new MozartUC.apiButton();
      this.cmdGestCont = new MozartUC.apiButton();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.Name = "Label1";
      // 
      // cmdGestDomTech
      // 
      this.cmdGestDomTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGestDomTech, "cmdGestDomTech");
      this.cmdGestDomTech.HelpContextID = 700;
      this.cmdGestDomTech.Name = "cmdGestDomTech";
      this.cmdGestDomTech.UseVisualStyleBackColor = false;
      this.cmdGestDomTech.Click += new System.EventHandler(this.cmdGestDomTech_Click);
      // 
      // cmdGestCont
      // 
      this.cmdGestCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdGestCont, "cmdGestCont");
      this.cmdGestCont.HelpContextID = 699;
      this.cmdGestCont.Name = "cmdGestCont";
      this.cmdGestCont.UseVisualStyleBackColor = false;
      this.cmdGestCont.Click += new System.EventHandler(this.cmdGestCont_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.SystemColors.Control;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmAdminContrat
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdGestCont);
      this.Controls.Add(this.cmdGestDomTech);
      this.Controls.Add(this.Label1);
      this.Name = "frmAdminContrat";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmAdminContrat_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Label1;
    private MozartUC.apiButton cmdGestDomTech;
    public MozartUC.apiButton cmdGestCont;
    private System.Windows.Forms.Button cmdFermer;
  }
}