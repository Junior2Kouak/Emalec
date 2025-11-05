namespace MozartCS
{
  partial class frmTransfertODBilan
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfertODBilan));
      this.cmdAAR = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.lstInfos = new System.Windows.Forms.ListBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.ChkSaveODBilan = new MozartUC.apiCheckBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.txtDateA = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdAAR
      // 
      resources.ApplyResources(this.cmdAAR, "cmdAAR");
      this.cmdAAR.HelpContextID = 0;
      this.cmdAAR.Name = "cmdAAR";
      this.cmdAAR.UseVisualStyleBackColor = true;
      this.cmdAAR.Click += new System.EventHandler(this.cmdAAR_Click);
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
      // lstInfos
      // 
      resources.ApplyResources(this.lstInfos, "lstInfos");
      this.lstInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lstInfos.Name = "lstInfos";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // ChkSaveODBilan
      // 
      this.ChkSaveODBilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.ChkSaveODBilan, "ChkSaveODBilan");
      this.ChkSaveODBilan.HelpContextID = 0;
      this.ChkSaveODBilan.Name = "ChkSaveODBilan";
      this.ChkSaveODBilan.UseVisualStyleBackColor = false;
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // txtDateA
      // 
      this.txtDateA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateA, "txtDateA");
      this.txtDateA.HelpContextID = 0;
      this.txtDateA.Name = "txtDateA";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame3.Controls.Add(this.ChkSaveODBilan);
      this.Frame3.Controls.Add(this.Calendar1);
      this.Frame3.Controls.Add(this.cmdDate1);
      this.Frame3.Controls.Add(this.txtDateA);
      this.Frame3.Controls.Add(this.cmdValider);
      this.Frame3.Controls.Add(this.lblLabels12);
      this.Frame3.Controls.Add(this.Label3);
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // frmTransfertODBilan
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdAAR);
      this.Controls.Add(this.lstInfos);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame3);
      this.Name = "frmTransfertODBilan";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmTransfertODBilan_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdAAR;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private System.Windows.Forms.ListBox lstInfos;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiCheckBox ChkSaveODBilan;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiGroupBox Frame3;

  }
}
