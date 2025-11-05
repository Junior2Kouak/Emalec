namespace MozartCS
{
  partial class frmProspContactDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspContactDetail));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.txtmail = new MozartUC.apiTextBox();
      this.ApiTelAuto4 = new MozartUC.ApiTelAuto();
      this.Label51 = new System.Windows.Forms.Label();
      this.txtQual = new MozartUC.apiTextBox();
      this.Label53 = new System.Windows.Forms.Label();
      this.ApiTelAuto3 = new MozartUC.ApiTelAuto();
      this.Label52 = new System.Windows.Forms.Label();
      this.txtprenom = new MozartUC.apiTextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.lblLabels5 = new System.Windows.Forms.Label();
      this.PicM = new System.Windows.Forms.PictureBox();
      this.txtNom = new MozartUC.apiTextBox();
      this.lblLabels7 = new System.Windows.Forms.Label();
      this.txtport = new MozartUC.apiTextBox();
      this.lblLabels8 = new System.Windows.Forms.Label();
      this.cboCiv = new System.Windows.Forms.ComboBox();
      this.txttel = new MozartUC.apiTextBox();
      this.Frame3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicM)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Name = "Label1";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.Wheat;
      this.Frame3.Controls.Add(this.txtmail);
      this.Frame3.Controls.Add(this.ApiTelAuto4);
      this.Frame3.Controls.Add(this.Label51);
      this.Frame3.Controls.Add(this.txtQual);
      this.Frame3.Controls.Add(this.Label53);
      this.Frame3.Controls.Add(this.ApiTelAuto3);
      this.Frame3.Controls.Add(this.Label52);
      this.Frame3.Controls.Add(this.txtprenom);
      this.Frame3.Controls.Add(this.Label9);
      this.Frame3.Controls.Add(this.lblLabels5);
      this.Frame3.Controls.Add(this.PicM);
      this.Frame3.Controls.Add(this.txtNom);
      this.Frame3.Controls.Add(this.lblLabels7);
      this.Frame3.Controls.Add(this.txtport);
      this.Frame3.Controls.Add(this.lblLabels8);
      this.Frame3.Controls.Add(this.cboCiv);
      this.Frame3.Controls.Add(this.txttel);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // txtmail
      // 
      this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtmail, "txtmail");
      this.txtmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtmail.HelpContextID = 0;
      this.txtmail.Name = "txtmail";
      // 
      // ApiTelAuto4
      // 
      resources.ApplyResources(this.ApiTelAuto4, "ApiTelAuto4");
      this.ApiTelAuto4.Name = "ApiTelAuto4";
      this.ApiTelAuto4.Tag = "txtTelDem";
      this.ApiTelAuto4.Click += new System.EventHandler(this.ApiTelAuto4_Click);
      // 
      // Label51
      // 
      resources.ApplyResources(this.Label51, "Label51");
      this.Label51.BackColor = System.Drawing.Color.Wheat;
      this.Label51.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label51.Name = "Label51";
      // 
      // txtQual
      // 
      resources.ApplyResources(this.txtQual, "txtQual");
      this.txtQual.HelpContextID = 0;
      this.txtQual.Name = "txtQual";
      // 
      // Label53
      // 
      resources.ApplyResources(this.Label53, "Label53");
      this.Label53.BackColor = System.Drawing.Color.Wheat;
      this.Label53.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label53.Name = "Label53";
      // 
      // ApiTelAuto3
      // 
      resources.ApplyResources(this.ApiTelAuto3, "ApiTelAuto3");
      this.ApiTelAuto3.Name = "ApiTelAuto3";
      this.ApiTelAuto3.Tag = "txtTelDem";
      this.ApiTelAuto3.Click += new System.EventHandler(this.ApiTelAuto3_Click);
      // 
      // Label52
      // 
      resources.ApplyResources(this.Label52, "Label52");
      this.Label52.BackColor = System.Drawing.Color.Wheat;
      this.Label52.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label52.Name = "Label52";
      // 
      // txtprenom
      // 
      resources.ApplyResources(this.txtprenom, "txtprenom");
      this.txtprenom.HelpContextID = 0;
      this.txtprenom.Name = "txtprenom";
      // 
      // Label9
      // 
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.BackColor = System.Drawing.Color.Wheat;
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.Name = "Label9";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // PicM
      // 
      this.PicM.BackColor = System.Drawing.Color.Transparent;
      this.PicM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.PicM, "PicM");
      this.PicM.Name = "PicM";
      this.PicM.TabStop = false;
      this.PicM.Click += new System.EventHandler(this.PicM_Click);
      // 
      // txtNom
      // 
      resources.ApplyResources(this.txtNom, "txtNom");
      this.txtNom.HelpContextID = 0;
      this.txtNom.Name = "txtNom";
      // 
      // lblLabels7
      // 
      resources.ApplyResources(this.lblLabels7, "lblLabels7");
      this.lblLabels7.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels7.Name = "lblLabels7";
      // 
      // txtport
      // 
      this.txtport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtport, "txtport");
      this.txtport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtport.HelpContextID = 0;
      this.txtport.Name = "txtport";
      // 
      // lblLabels8
      // 
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // cboCiv
      // 
      this.cboCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCiv, "cboCiv");
      this.cboCiv.Items.AddRange(new object[] {
            resources.GetString("cboCiv.Items"),
            resources.GetString("cboCiv.Items1")});
      this.cboCiv.Name = "cboCiv";
      // 
      // txttel
      // 
      this.txttel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txttel, "txttel");
      this.txttel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txttel.HelpContextID = 0;
      this.txttel.Name = "txttel";
      // 
      // frmProspContactDetail
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmProspContactDetail";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProspContactDetail_FormClosing);
      this.Load += new System.EventHandler(this.frmProspContactDetail_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicM)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiTextBox txtmail;
    private MozartUC.ApiTelAuto ApiTelAuto4;
    private System.Windows.Forms.Label Label51;
    private MozartUC.apiTextBox txtQual;
    private System.Windows.Forms.Label Label53;
    private MozartUC.ApiTelAuto ApiTelAuto3;
    private System.Windows.Forms.Label Label52;
    private MozartUC.apiTextBox txtprenom;
    private System.Windows.Forms.Label Label9;
    private System.Windows.Forms.Label lblLabels5;
    private System.Windows.Forms.PictureBox PicM;
    private MozartUC.apiTextBox txtNom;
    private System.Windows.Forms.Label lblLabels7;
    private MozartUC.apiTextBox txtport;
    private System.Windows.Forms.Label lblLabels8;
    private System.Windows.Forms.ComboBox cboCiv;
    private MozartUC.apiTextBox txttel;
  }
}
