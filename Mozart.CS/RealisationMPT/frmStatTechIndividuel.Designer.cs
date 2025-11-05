namespace MozartCS
{
  partial class frmStatTechIndividuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatTechIndividuel));
            this.cmdQuitter = new MozartUC.apiButton();
            this.Calendar1 = new System.Windows.Forms.DateTimePicker();
            this.txtEntretien = new MozartUC.apiTextBox();
            this.CmdValid = new MozartUC.apiButton();
            this.cmdDate1 = new MozartUC.apiButton();
            this.txtDateA0 = new MozartUC.apiTextBox();
            this.cmdDate2 = new MozartUC.apiButton();
            this.txtDateA1 = new MozartUC.apiTextBox();
            this.lblLabels12 = new MozartUC.apiLabel();
            this.lblLabels0 = new MozartUC.apiLabel();
            this.lblTech = new MozartUC.apiLabel();
            this.Frame1 = new MozartUC.apiGroupBox();
            this.Label1 = new MozartUC.apiLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboTech = new MozartUC.apiCombo();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.Frame1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdQuitter
            // 
            resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdQuitter.HelpContextID = 0;
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
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
            // txtEntretien
            // 
            resources.ApplyResources(this.txtEntretien, "txtEntretien");
            this.txtEntretien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEntretien.HelpContextID = 0;
            this.txtEntretien.Name = "txtEntretien";
            // 
            // CmdValid
            // 
            this.CmdValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.CmdValid, "CmdValid");
            this.CmdValid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdValid.HelpContextID = 0;
            this.CmdValid.Image = global::MozartCS.Properties.Resources.ok_32;
            this.CmdValid.Name = "CmdValid";
            this.CmdValid.Tag = "29";
            this.CmdValid.UseVisualStyleBackColor = false;
            this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
            // 
            // cmdDate1
            // 
            this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.cmdDate1, "cmdDate1");
            this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDate1.HelpContextID = 0;
            this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
            this.cmdDate1.Name = "cmdDate1";
            this.cmdDate1.Tag = "5";
            this.cmdDate1.UseVisualStyleBackColor = false;
            this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
            // 
            // txtDateA0
            // 
            this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtDateA0, "txtDateA0");
            this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDateA0.HelpContextID = 0;
            this.txtDateA0.Name = "txtDateA0";
            // 
            // cmdDate2
            // 
            this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.cmdDate2, "cmdDate2");
            this.cmdDate2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDate2.HelpContextID = 0;
            this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
            this.cmdDate2.Name = "cmdDate2";
            this.cmdDate2.Tag = "5";
            this.cmdDate2.UseVisualStyleBackColor = false;
            this.cmdDate2.Click += new System.EventHandler(this.CmdDate_Click);
            // 
            // txtDateA1
            // 
            this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtDateA1, "txtDateA1");
            this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDateA1.HelpContextID = 0;
            this.txtDateA1.Name = "txtDateA1";
            // 
            // lblLabels12
            // 
            this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.lblLabels12, "lblLabels12");
            this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabels12.HelpContextID = 0;
            this.lblLabels12.Name = "lblLabels12";
            // 
            // lblLabels0
            // 
            this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.lblLabels0, "lblLabels0");
            this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabels0.HelpContextID = 0;
            this.lblLabels0.Name = "lblLabels0";
            // 
            // lblTech
            // 
            this.lblTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.lblTech, "lblTech");
            this.lblTech.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTech.HelpContextID = 0;
            this.lblTech.Name = "lblTech";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Frame1.Controls.Add(this.CmdValid);
            this.Frame1.Controls.Add(this.cmdDate1);
            this.Frame1.Controls.Add(this.txtDateA0);
            this.Frame1.Controls.Add(this.cmdDate2);
            this.Frame1.Controls.Add(this.txtDateA1);
            this.Frame1.Controls.Add(this.lblLabels12);
            this.Frame1.Controls.Add(this.lblLabels0);
            this.Frame1.Controls.Add(this.lblTech);
            resources.ApplyResources(this.Frame1, "Frame1");
            this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Frame1.FrameColor = System.Drawing.Color.Empty;
            this.Frame1.HelpContextID = 0;
            this.Frame1.Name = "Frame1";
            this.Frame1.TabStop = false;
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BackColor = System.Drawing.Color.Wheat;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.HelpContextID = 0;
            this.Label1.Name = "Label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.txtEntretien, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // cboTech
            // 
            resources.ApplyResources(this.cboTech, "cboTech");
            this.cboTech.Name = "cboTech";
            this.cboTech.NewValues = false;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            resources.ApplyResources(this.webView21, "webView21");
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Name = "webView21";
            this.webView21.ZoomFactor = 1D;
            // 
            // frmStatTechIndividuel
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdQuitter;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cboTech);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.Calendar1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.webView21);
            this.Name = "frmStatTechIndividuel";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStatTechIndividuel_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiTextBox txtEntretien;
    private MozartUC.apiButton CmdValid;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblTech;
    private MozartUC.apiGroupBox Frame1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private MozartUC.apiCombo cboTech;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
