namespace MozartCS
{
  partial class frmListeTramesGamme
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeTramesGamme));
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cboPays = new System.Windows.Forms.ComboBox();
      this.txtType = new MozartUC.apiTextBox();
      this.txtNum = new MozartUC.apiTextBox();
      this.txtDate = new MozartUC.apiTextBox();
      this.Label3 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGridArt = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.cmdAjouter = new MozartUC.apiButton();
      this.Frame4.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cboPays
      // 
      resources.ApplyResources(this.cboPays, "cboPays");
      this.cboPays.Name = "cboPays";
      // 
      // txtType
      // 
      this.txtType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtType, "txtType");
      this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtType.HelpContextID = 0;
      this.txtType.Name = "txtType";
      // 
      // txtNum
      // 
      this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNum, "txtNum");
      this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNum.HelpContextID = 0;
      this.txtNum.Name = "txtNum";
      // 
      // txtDate
      // 
      this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtDate.HelpContextID = 0;
      this.txtDate.Name = "txtDate";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Frame4
      // 
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.cboPays);
      this.Frame4.Controls.Add(this.txtType);
      this.Frame4.Controls.Add(this.txtNum);
      this.Frame4.Controls.Add(this.txtDate);
      this.Frame4.Controls.Add(this.Label3);
      this.Frame4.Controls.Add(this.Label4);
      this.Frame4.Controls.Add(this.Label2);
      this.Frame4.Controls.Add(this.Label5);
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiTGridArt
      // 
      resources.ApplyResources(this.apiTGridArt, "apiTGridArt");
      this.apiTGridArt.FilterBar = true;
      this.apiTGridArt.FooterBar = true;
      this.apiTGridArt.Name = "apiTGridArt";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // cmdAjouter
      // 
      this.cmdAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.UseVisualStyleBackColor = false;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // frmListeTramesGamme
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGridArt);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeTramesGamme";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeTramesGamme_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.ComboBox cboPays;
    private MozartUC.apiTextBox txtType;
    private MozartUC.apiTextBox txtNum;
    private MozartUC.apiTextBox txtDate;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGridArt;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdAjouter;
  }
}
