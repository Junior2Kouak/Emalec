namespace MozartCS
{
  partial class frmDetailDocAdminSTF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailDocAdminSTF));
      this.cboTypeDoc = new System.Windows.Forms.ComboBox();
      this.CmdFind = new MozartUC.apiButton();
      this.txtFic = new MozartUC.apiTextBox();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.DateValidite = new DevExpress.XtraEditors.DateEdit();
      this.Frame3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateValidite.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateValidite.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // cboTypeDoc
      // 
      this.cboTypeDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTypeDoc, "cboTypeDoc");
      this.cboTypeDoc.Name = "cboTypeDoc";
      // 
      // CmdFind
      // 
      this.CmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdFind.HelpContextID = 0;
      resources.ApplyResources(this.CmdFind, "CmdFind");
      this.CmdFind.Name = "CmdFind";
      this.CmdFind.UseVisualStyleBackColor = true;
      this.CmdFind.Click += new System.EventHandler(this.CmdFind_Click);
      // 
      // txtFic
      // 
      resources.ApplyResources(this.txtFic, "txtFic");
      this.txtFic.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFic.HelpContextID = 0;
      this.txtFic.Name = "txtFic";
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.DateValidite);
      this.Frame3.Controls.Add(this.cboTypeDoc);
      this.Frame3.Controls.Add(this.CmdFind);
      this.Frame3.Controls.Add(this.txtFic);
      this.Frame3.Controls.Add(this.WebBrowser1);
      this.Frame3.Controls.Add(this.lblLabels0);
      this.Frame3.Controls.Add(this.lblLabels1);
      this.Frame3.Controls.Add(this.lblLabels11);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // DateValidite
      // 
      resources.ApplyResources(this.DateValidite, "DateValidite");
      this.DateValidite.Name = "DateValidite";
      this.DateValidite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.Buttons"))))});
      this.DateValidite.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // frmDetailDocAdminSTF
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailDocAdminSTF";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDetailDocAdminSTF_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateValidite.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateValidite.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ComboBox cboTypeDoc;
    private MozartUC.apiButton CmdFind;
    private MozartUC.apiTextBox txtFic;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private DevExpress.XtraEditors.DateEdit DateValidite;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
