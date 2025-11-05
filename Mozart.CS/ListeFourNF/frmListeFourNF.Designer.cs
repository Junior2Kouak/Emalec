namespace MozartCS
{
  partial class frmListeFourNF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFourNF));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.CmdValid = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.apiTGridFouNF = new MozartUC.apiTGrid();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.txtHT = new MozartUC.apiTextBox();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // CmdValid
      // 
      this.CmdValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.CmdValid, "CmdValid");
      this.CmdValid.HelpContextID = 0;
      this.CmdValid.Name = "CmdValid";
      this.CmdValid.Tag = "5";
      this.CmdValid.UseVisualStyleBackColor = false;
      this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA1, "txtDateA1");
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Name = "txtDateA1";
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate2, "cmdDate2");
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Tag = "txtDateA1";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Name = "txtDateA0";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "txtDateA0";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // apiTGridFouNF
      // 
      resources.ApplyResources(this.apiTGridFouNF, "apiTGridFouNF");
      this.apiTGridFouNF.FilterBar = true;
      this.apiTGridFouNF.FooterBar = true;
      this.apiTGridFouNF.Name = "apiTGridFouNF";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // frmListeFourNF
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.txtHT);
      this.Controls.Add(this.lblLabels5);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.CmdValid);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.txtDateA1);
      this.Controls.Add(this.cmdDate2);
      this.Controls.Add(this.txtDateA0);
      this.Controls.Add(this.cmdDate1);
      this.Controls.Add(this.apiTGridFouNF);
      this.Controls.Add(this.lblLabels0);
      this.Controls.Add(this.lblLabels12);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmListeFourNF";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeFourNF_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton CmdValid;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTGrid apiTGridFouNF;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiLabel lblLabels5;
  }
}
