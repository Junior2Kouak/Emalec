namespace MozartCS
{
  partial class frmTransfertSalaires
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfertSalaires));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdODPaies = new MozartUC.apiButton();
      this.cmdFile1 = new MozartUC.apiButton();
      this.txtFichier1 = new MozartUC.apiTextBox();
      this.Label4 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
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
      // cmdODPaies
      // 
      resources.ApplyResources(this.cmdODPaies, "cmdODPaies");
      this.cmdODPaies.ForeColor = System.Drawing.Color.Black;
      this.cmdODPaies.HelpContextID = 0;
      this.cmdODPaies.Name = "cmdODPaies";
      this.cmdODPaies.UseVisualStyleBackColor = true;
      this.cmdODPaies.Click += new System.EventHandler(this.cmdODPaies_Click);
      // 
      // cmdFile1
      // 
      resources.ApplyResources(this.cmdFile1, "cmdFile1");
      this.cmdFile1.ForeColor = System.Drawing.Color.Black;
      this.cmdFile1.HelpContextID = 0;
      this.cmdFile1.Name = "cmdFile1";
      this.cmdFile1.UseVisualStyleBackColor = true;
      this.cmdFile1.Click += new System.EventHandler(this.cmdFile1_Click);
      // 
      // txtFichier1
      // 
      this.txtFichier1.HelpContextID = 0;
      resources.ApplyResources(this.txtFichier1, "txtFichier1");
      this.txtFichier1.Name = "txtFichier1";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cmdODPaies);
      this.Frame2.Controls.Add(this.cmdFile1);
      this.Frame2.Controls.Add(this.txtFichier1);
      this.Frame2.Controls.Add(this.Label4);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // CommonDialog1
      // 
      this.CommonDialog1.ReadOnlyChecked = true;
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmTransfertSalaires
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Label1);
      this.Name = "frmTransfertSalaires";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmTransfertSalaires_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdODPaies;
    private MozartUC.apiButton cmdFile1;
    private MozartUC.apiTextBox txtFichier1;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiGroupBox Frame2;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiLabel Label1;

  }
}
