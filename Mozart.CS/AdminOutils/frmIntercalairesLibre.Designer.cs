namespace MozartCS
{
  partial class frmIntercalairesLibre
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntercalairesLibre));
      this.cmdEdition = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.txtInter = new MozartUC.apiTextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdEdition
      // 
      resources.ApplyResources(this.cmdEdition, "cmdEdition");
      this.cmdEdition.HelpContextID = 0;
      this.cmdEdition.Name = "cmdEdition";
      this.cmdEdition.Tag = "17";
      this.cmdEdition.UseVisualStyleBackColor = true;
      this.cmdEdition.Click += new System.EventHandler(this.cmdEdition_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // txtInter
      // 
      resources.ApplyResources(this.txtInter, "txtInter");
      this.txtInter.HelpContextID = 0;
      this.txtInter.Name = "txtInter";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Name = "Label3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.txtInter);
      this.Frame4.Controls.Add(this.Label3);
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Name = "Label2";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.Name = "Label14";
      // 
      // frmIntercalairesLibre
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdEdition);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label14);
      this.Name = "frmIntercalairesLibre";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmIntercalairesLibre_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdEdition;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiTextBox txtInter;
    private System.Windows.Forms.Label Label3;
    private MozartUC.apiGroupBox Frame4;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label14;
  }
}
