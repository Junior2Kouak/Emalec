namespace MozartCS
{
  partial class frmDocSTT
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocSTT));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.txtRem = new MozartUC.apiTextBox();
      this.TxtFic = new MozartUC.apiTextBox();
      this.cboTypeDoc = new System.Windows.Forms.ComboBox();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.txtDateDoc = new DevExpress.XtraEditors.DateEdit();
      this.Label1 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.cmdDocSTT = new MozartUC.apiButton();
      this.Frame3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateDoc.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateDoc.Properties.CalendarTimeProperties)).BeginInit();
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
      // txtRem
      // 
      this.txtRem.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtRem.HelpContextID = 0;
      resources.ApplyResources(this.txtRem, "txtRem");
      this.txtRem.Name = "txtRem";
      // 
      // TxtFic
      // 
      resources.ApplyResources(this.TxtFic, "TxtFic");
      this.TxtFic.ForeColor = System.Drawing.SystemColors.ControlText;
      this.TxtFic.HelpContextID = 0;
      this.TxtFic.Name = "TxtFic";
      // 
      // cboTypeDoc
      // 
      this.cboTypeDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTypeDoc, "cboTypeDoc");
      this.cboTypeDoc.Name = "cboTypeDoc";
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.txtDateDoc);
      this.Frame3.Controls.Add(this.txtRem);
      this.Frame3.Controls.Add(this.TxtFic);
      this.Frame3.Controls.Add(this.cboTypeDoc);
      this.Frame3.Controls.Add(this.WebBrowser1);
      this.Frame3.Controls.Add(this.lblLabels2);
      this.Frame3.Controls.Add(this.lblLabels11);
      this.Frame3.Controls.Add(this.lblLabels1);
      this.Frame3.Controls.Add(this.lblLabels0);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // txtDateDoc
      // 
      resources.ApplyResources(this.txtDateDoc, "txtDateDoc");
      this.txtDateDoc.Name = "txtDateDoc";
      this.txtDateDoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.txtDateDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDoc.Properties.Buttons"))))});
      this.txtDateDoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDoc.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // cmdDocSTT
      // 
      resources.ApplyResources(this.cmdDocSTT, "cmdDocSTT");
      this.cmdDocSTT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDocSTT.HelpContextID = 0;
      this.cmdDocSTT.Name = "cmdDocSTT";
      this.cmdDocSTT.Tag = "66";
      this.cmdDocSTT.UseVisualStyleBackColor = true;
      this.cmdDocSTT.Click += new System.EventHandler(this.cmdDocSTT_Click);
      // 
      // frmDocSTT
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDocSTT);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Label2);
      this.Name = "frmDocSTT";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDocSTT_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateDoc.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateDoc.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiTextBox txtRem;
    private MozartUC.apiTextBox TxtFic;
    private System.Windows.Forms.ComboBox cboTypeDoc;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame3;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel Label2;
    private DevExpress.XtraEditors.DateEdit txtDateDoc;
    private MozartUC.apiButton cmdDocSTT;
  }
}
