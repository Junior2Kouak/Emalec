namespace MozartCS
{
  partial class frmListeCourrierAction
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCourrierAction));
      this.ApiGridFou = new MozartUC.apiTGrid();
      this.fraSTFO = new MozartUC.apiGroupBox();
      this.optAR2 = new System.Windows.Forms.RadioButton();
      this.optAR1 = new System.Windows.Forms.RadioButton();
      this.optAR0 = new System.Windows.Forms.RadioButton();
      this.frameAR = new MozartUC.apiGroupBox();
      this.cboContact = new System.Windows.Forms.ComboBox();
      this.cboType = new System.Windows.Forms.ComboBox();
      this.lblContact = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.lstTypeCour = new System.Windows.Forms.CheckedListBox();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdCreer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdDetail = new MozartUC.apiButton();
      this.lblTitre = new MozartUC.apiLabel();
      this.fraSTFO.SuspendLayout();
      this.frameAR.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      // 
      // ApiGridFou
      // 
      this.ApiGridFou.FilterBar = true;
      resources.ApplyResources(this.ApiGridFou, "ApiGridFou");
      this.ApiGridFou.FooterBar = true;
      this.ApiGridFou.Name = "ApiGridFou";
      // 
      // fraSTFO
      // 
      this.fraSTFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.fraSTFO.Controls.Add(this.ApiGridFou);
      resources.ApplyResources(this.fraSTFO, "fraSTFO");
      this.fraSTFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.fraSTFO.FrameColor = System.Drawing.Color.Empty;
      this.fraSTFO.HelpContextID = 0;
      this.fraSTFO.Name = "fraSTFO";
      this.fraSTFO.TabStop = false;
      // 
      // optAR2
      // 
      this.optAR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optAR2, "optAR2");
      this.optAR2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optAR2.Name = "optAR2";
      this.optAR2.UseVisualStyleBackColor = false;
      // 
      // optAR1
      // 
      this.optAR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.optAR1, "optAR1");
      this.optAR1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optAR1.Name = "optAR1";
      this.optAR1.UseVisualStyleBackColor = false;
      // 
      // optAR0
      // 
      this.optAR0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.optAR0.Checked = true;
      resources.ApplyResources(this.optAR0, "optAR0");
      this.optAR0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optAR0.Name = "optAR0";
      this.optAR0.TabStop = true;
      this.optAR0.UseVisualStyleBackColor = false;
      // 
      // frameAR
      // 
      this.frameAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.frameAR.Controls.Add(this.optAR2);
      this.frameAR.Controls.Add(this.optAR1);
      this.frameAR.Controls.Add(this.optAR0);
      resources.ApplyResources(this.frameAR, "frameAR");
      this.frameAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.frameAR.FrameColor = System.Drawing.Color.Empty;
      this.frameAR.HelpContextID = 0;
      this.frameAR.Name = "frameAR";
      this.frameAR.TabStop = false;
      // 
      // cboContact
      // 
      this.cboContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboContact, "cboContact");
      this.cboContact.Name = "cboContact";
      // 
      // cboType
      // 
      this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboType, "cboType");
      this.cboType.Items.AddRange(new object[] {
            resources.GetString("cboType.Items"),
            resources.GetString("cboType.Items1"),
            resources.GetString("cboType.Items2"),
            resources.GetString("cboType.Items3"),
            resources.GetString("cboType.Items4")});
      this.cboType.Name = "cboType";
      this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
      // 
      // lblContact
      // 
      resources.ApplyResources(this.lblContact, "lblContact");
      this.lblContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblContact.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblContact.HelpContextID = 0;
      this.lblContact.Name = "lblContact";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.frameAR);
      this.Frame1.Controls.Add(this.cboContact);
      this.Frame1.Controls.Add(this.cboType);
      this.Frame1.Controls.Add(this.lblContact);
      this.Frame1.Controls.Add(this.lblLabels1);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // ApiGrid
      // 
      this.ApiGrid.FilterBar = true;
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // lstTypeCour
      // 
      resources.ApplyResources(this.lstTypeCour, "lstTypeCour");
      this.lstTypeCour.Name = "lstTypeCour";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.lstTypeCour);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.Frame4.FrameColor = System.Drawing.Color.Empty;
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.Frame4);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cmdCreer
      // 
      resources.ApplyResources(this.cmdCreer, "cmdCreer");
      this.cmdCreer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCreer.HelpContextID = 0;
      this.cmdCreer.Name = "cmdCreer";
      this.cmdCreer.Tag = "2";
      this.cmdCreer.UseVisualStyleBackColor = true;
      this.cmdCreer.Click += new System.EventHandler(this.cmdCreer_Click);
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
      // cmdDetail
      // 
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = true;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmListeCourrierAction
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.fraSTFO);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdCreer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmListeCourrierAction";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeCourrierAction_Load);
      this.fraSTFO.ResumeLayout(false);
      this.frameAR.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame4.ResumeLayout(false);
      this.Frame3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid ApiGridFou;
    private MozartUC.apiGroupBox fraSTFO;
    private System.Windows.Forms.RadioButton optAR2;
    private System.Windows.Forms.RadioButton optAR1;
    private System.Windows.Forms.RadioButton optAR0;
    private MozartUC.apiGroupBox frameAR;
    private System.Windows.Forms.ComboBox cboContact;
    private System.Windows.Forms.ComboBox cboType;
    private MozartUC.apiLabel lblContact;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdSupprimer;
    private System.Windows.Forms.CheckedListBox lstTypeCour;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdCreer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdDetail;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblTitre;

  }
}
