
namespace MozartCS
{
  partial class frmDetailVisite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailVisite));
      this.cmdAjouterVisite = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiGroupBox2 = new MozartUC.apiGroupBox();
      this.cboCiv = new System.Windows.Forms.ComboBox();
      this.txtServiceV = new MozartUC.apiTextBox();
      this.apiLabel4 = new MozartUC.apiLabel();
      this.txtRSV = new MozartUC.apiTextBox();
      this.apiLabel3 = new MozartUC.apiLabel();
      this.txtTelV = new MozartUC.apiTextBox();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.txtMailV = new MozartUC.apiTextBox();
      this.Label517 = new MozartUC.apiLabel();
      this.txtNomV = new MozartUC.apiTextBox();
      this.Label55 = new MozartUC.apiLabel();
      this.txtPrenomV = new MozartUC.apiTextBox();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.apiLabel5 = new MozartUC.apiLabel();
      this.txtNomC = new MozartUC.apiTextBox();
      this.txtPrenomC = new MozartUC.apiTextBox();
      this.apiLabel6 = new MozartUC.apiLabel();
      this.apiLabel7 = new MozartUC.apiLabel();
      this.txtComment = new MozartUC.apiTextBox();
      this.apiLabel8 = new MozartUC.apiLabel();
      this.dDateDepart = new DevExpress.XtraEditors.DateEdit();
      this.dHeureDepart = new DevExpress.XtraEditors.TimeEdit();
      this.dHeureArrivee = new DevExpress.XtraEditors.TimeEdit();
      this.dDateArrivee = new DevExpress.XtraEditors.DateEdit();
      this.apiGroupBox3 = new MozartUC.apiGroupBox();
      this.cboMotif = new MozartUC.apiCombo();
      this.apiGroupBox4 = new MozartUC.apiGroupBox();
      this.apiLabel9 = new MozartUC.apiLabel();
      this.lblSortie = new MozartUC.apiLabel();
      this.apiGroupBox2.SuspendLayout();
      this.apiGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dDateDepart.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateDepart.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dHeureDepart.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dHeureArrivee.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateArrivee.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateArrivee.Properties)).BeginInit();
      this.apiGroupBox3.SuspendLayout();
      this.apiGroupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdAjouterVisite
      // 
      resources.ApplyResources(this.cmdAjouterVisite, "cmdAjouterVisite");
      this.cmdAjouterVisite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouterVisite.HelpContextID = 22;
      this.cmdAjouterVisite.Name = "cmdAjouterVisite";
      this.cmdAjouterVisite.Tag = "2";
      this.cmdAjouterVisite.UseVisualStyleBackColor = true;
      this.cmdAjouterVisite.Click += new System.EventHandler(this.cmdAjouterVisite_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // apiGroupBox2
      // 
      this.apiGroupBox2.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox2.Controls.Add(this.cboCiv);
      this.apiGroupBox2.Controls.Add(this.txtServiceV);
      this.apiGroupBox2.Controls.Add(this.apiLabel4);
      this.apiGroupBox2.Controls.Add(this.txtRSV);
      this.apiGroupBox2.Controls.Add(this.apiLabel3);
      this.apiGroupBox2.Controls.Add(this.txtTelV);
      this.apiGroupBox2.Controls.Add(this.apiLabel2);
      this.apiGroupBox2.Controls.Add(this.apiLabel1);
      this.apiGroupBox2.Controls.Add(this.txtMailV);
      this.apiGroupBox2.Controls.Add(this.Label517);
      this.apiGroupBox2.Controls.Add(this.txtNomV);
      this.apiGroupBox2.Controls.Add(this.Label55);
      this.apiGroupBox2.Controls.Add(this.txtPrenomV);
      this.apiGroupBox2.Controls.Add(this.lblLabels8);
      resources.ApplyResources(this.apiGroupBox2, "apiGroupBox2");
      this.apiGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox2.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox2.HelpContextID = 0;
      this.apiGroupBox2.Name = "apiGroupBox2";
      this.apiGroupBox2.TabStop = false;
      // 
      // cboCiv
      // 
      this.cboCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCiv, "cboCiv");
      this.cboCiv.Items.AddRange(new object[] {
            resources.GetString("cboCiv.Items"),
            resources.GetString("cboCiv.Items1"),
            resources.GetString("cboCiv.Items2")});
      this.cboCiv.Name = "cboCiv";
      // 
      // txtServiceV
      // 
      this.txtServiceV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtServiceV, "txtServiceV");
      this.txtServiceV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtServiceV.HelpContextID = 0;
      this.txtServiceV.Name = "txtServiceV";
      // 
      // apiLabel4
      // 
      this.apiLabel4.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.apiLabel4, "apiLabel4");
      this.apiLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel4.HelpContextID = 0;
      this.apiLabel4.Name = "apiLabel4";
      // 
      // txtRSV
      // 
      this.txtRSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtRSV, "txtRSV");
      this.txtRSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtRSV.HelpContextID = 0;
      this.txtRSV.Name = "txtRSV";
      // 
      // apiLabel3
      // 
      this.apiLabel3.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.apiLabel3, "apiLabel3");
      this.apiLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel3.HelpContextID = 0;
      this.apiLabel3.Name = "apiLabel3";
      // 
      // txtTelV
      // 
      this.txtTelV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTelV, "txtTelV");
      this.txtTelV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTelV.HelpContextID = 0;
      this.txtTelV.Name = "txtTelV";
      // 
      // apiLabel2
      // 
      this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // txtMailV
      // 
      this.txtMailV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtMailV, "txtMailV");
      this.txtMailV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtMailV.HelpContextID = 0;
      this.txtMailV.Name = "txtMailV";
      // 
      // Label517
      // 
      resources.ApplyResources(this.Label517, "Label517");
      this.Label517.BackColor = System.Drawing.Color.Wheat;
      this.Label517.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label517.HelpContextID = 0;
      this.Label517.Name = "Label517";
      // 
      // txtNomV
      // 
      resources.ApplyResources(this.txtNomV, "txtNomV");
      this.txtNomV.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtNomV.HelpContextID = 0;
      this.txtNomV.Name = "txtNomV";
      // 
      // Label55
      // 
      resources.ApplyResources(this.Label55, "Label55");
      this.Label55.BackColor = System.Drawing.Color.Wheat;
      this.Label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label55.HelpContextID = 0;
      this.Label55.Name = "Label55";
      // 
      // txtPrenomV
      // 
      resources.ApplyResources(this.txtPrenomV, "txtPrenomV");
      this.txtPrenomV.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtPrenomV.HelpContextID = 0;
      this.txtPrenomV.Name = "txtPrenomV";
      // 
      // lblLabels8
      // 
      this.lblLabels8.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // apiGroupBox1
      // 
      this.apiGroupBox1.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox1.Controls.Add(this.apiLabel5);
      this.apiGroupBox1.Controls.Add(this.txtNomC);
      this.apiGroupBox1.Controls.Add(this.txtPrenomC);
      this.apiGroupBox1.Controls.Add(this.apiLabel6);
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox1.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // apiLabel5
      // 
      resources.ApplyResources(this.apiLabel5, "apiLabel5");
      this.apiLabel5.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel5.HelpContextID = 0;
      this.apiLabel5.Name = "apiLabel5";
      // 
      // txtNomC
      // 
      resources.ApplyResources(this.txtNomC, "txtNomC");
      this.txtNomC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtNomC.HelpContextID = 0;
      this.txtNomC.Name = "txtNomC";
      // 
      // txtPrenomC
      // 
      resources.ApplyResources(this.txtPrenomC, "txtPrenomC");
      this.txtPrenomC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtPrenomC.HelpContextID = 0;
      this.txtPrenomC.Name = "txtPrenomC";
      // 
      // apiLabel6
      // 
      resources.ApplyResources(this.apiLabel6, "apiLabel6");
      this.apiLabel6.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel6.HelpContextID = 0;
      this.apiLabel6.Name = "apiLabel6";
      // 
      // apiLabel7
      // 
      resources.ApplyResources(this.apiLabel7, "apiLabel7");
      this.apiLabel7.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel7.HelpContextID = 0;
      this.apiLabel7.Name = "apiLabel7";
      // 
      // txtComment
      // 
      resources.ApplyResources(this.txtComment, "txtComment");
      this.txtComment.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtComment.HelpContextID = 0;
      this.txtComment.Name = "txtComment";
      // 
      // apiLabel8
      // 
      resources.ApplyResources(this.apiLabel8, "apiLabel8");
      this.apiLabel8.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel8.HelpContextID = 0;
      this.apiLabel8.Name = "apiLabel8";
      // 
      // dDateDepart
      // 
      resources.ApplyResources(this.dDateDepart, "dDateDepart");
      this.dDateDepart.Name = "dDateDepart";
      this.dDateDepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
      this.dDateDepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dDateDepart.Properties.Buttons"))))});
      this.dDateDepart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dDateDepart.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // dHeureDepart
      // 
      resources.ApplyResources(this.dHeureDepart, "dHeureDepart");
      this.dHeureDepart.Name = "dHeureDepart";
      this.dHeureDepart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
      this.dHeureDepart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dHeureDepart.Properties.Buttons"))))});
      this.dHeureDepart.EditValueChanged += new System.EventHandler(this.dHeureDepart_EditValueChanged);
      // 
      // dHeureArrivee
      // 
      resources.ApplyResources(this.dHeureArrivee, "dHeureArrivee");
      this.dHeureArrivee.Name = "dHeureArrivee";
      this.dHeureArrivee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dHeureArrivee.Properties.Buttons"))))});
      this.dHeureArrivee.EditValueChanged += new System.EventHandler(this.dHeureArrivee_EditValueChanged);
      // 
      // dDateArrivee
      // 
      resources.ApplyResources(this.dDateArrivee, "dDateArrivee");
      this.dDateArrivee.Name = "dDateArrivee";
      this.dDateArrivee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dDateArrivee.Properties.Buttons"))))});
      this.dDateArrivee.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dDateArrivee.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // apiGroupBox3
      // 
      this.apiGroupBox3.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox3.Controls.Add(this.cboMotif);
      this.apiGroupBox3.Controls.Add(this.apiLabel7);
      this.apiGroupBox3.Controls.Add(this.apiLabel8);
      this.apiGroupBox3.Controls.Add(this.txtComment);
      resources.ApplyResources(this.apiGroupBox3, "apiGroupBox3");
      this.apiGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox3.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox3.HelpContextID = 0;
      this.apiGroupBox3.Name = "apiGroupBox3";
      this.apiGroupBox3.TabStop = false;
      // 
      // cboMotif
      // 
      resources.ApplyResources(this.cboMotif, "cboMotif");
      this.cboMotif.Name = "cboMotif";
      this.cboMotif.NewValues = false;
      // 
      // apiGroupBox4
      // 
      this.apiGroupBox4.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox4.Controls.Add(this.apiLabel9);
      this.apiGroupBox4.Controls.Add(this.dHeureDepart);
      this.apiGroupBox4.Controls.Add(this.dHeureArrivee);
      this.apiGroupBox4.Controls.Add(this.dDateDepart);
      this.apiGroupBox4.Controls.Add(this.dDateArrivee);
      this.apiGroupBox4.Controls.Add(this.lblSortie);
      resources.ApplyResources(this.apiGroupBox4, "apiGroupBox4");
      this.apiGroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox4.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox4.HelpContextID = 0;
      this.apiGroupBox4.Name = "apiGroupBox4";
      this.apiGroupBox4.TabStop = false;
      // 
      // apiLabel9
      // 
      resources.ApplyResources(this.apiLabel9, "apiLabel9");
      this.apiLabel9.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel9.HelpContextID = 0;
      this.apiLabel9.Name = "apiLabel9";
      // 
      // lblSortie
      // 
      this.lblSortie.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblSortie, "lblSortie");
      this.lblSortie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblSortie.HelpContextID = 0;
      this.lblSortie.Name = "lblSortie";
      // 
      // frmDetailVisite
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.apiGroupBox4);
      this.Controls.Add(this.apiGroupBox3);
      this.Controls.Add(this.apiGroupBox1);
      this.Controls.Add(this.apiGroupBox2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.cmdAjouterVisite);
      this.Controls.Add(this.cmdFermer);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmDetailVisite";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmDetailVisite_Load);
      this.apiGroupBox2.ResumeLayout(false);
      this.apiGroupBox2.PerformLayout();
      this.apiGroupBox1.ResumeLayout(false);
      this.apiGroupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dDateDepart.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateDepart.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dHeureDepart.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dHeureArrivee.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateArrivee.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dDateArrivee.Properties)).EndInit();
      this.apiGroupBox3.ResumeLayout(false);
      this.apiGroupBox3.PerformLayout();
      this.apiGroupBox4.ResumeLayout(false);
      this.apiGroupBox4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal MozartUC.apiButton cmdAjouterVisite;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox apiGroupBox2;
    private MozartUC.apiGroupBox apiGroupBox1;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiTextBox txtMailV;
    private MozartUC.apiLabel Label517;
    private MozartUC.apiTextBox txtNomV;
    private MozartUC.apiLabel Label55;
    private MozartUC.apiTextBox txtPrenomV;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiTextBox txtServiceV;
    private MozartUC.apiLabel apiLabel4;
    private MozartUC.apiTextBox txtRSV;
    private MozartUC.apiLabel apiLabel3;
    private MozartUC.apiTextBox txtTelV;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel apiLabel5;
    private MozartUC.apiTextBox txtNomC;
    private MozartUC.apiTextBox txtPrenomC;
    private MozartUC.apiLabel apiLabel6;
    private MozartUC.apiLabel apiLabel7;
    private MozartUC.apiTextBox txtComment;
    private MozartUC.apiLabel apiLabel8;
    private DevExpress.XtraEditors.DateEdit dDateDepart;
    private DevExpress.XtraEditors.TimeEdit dHeureDepart;
    private DevExpress.XtraEditors.TimeEdit dHeureArrivee;
    private DevExpress.XtraEditors.DateEdit dDateArrivee;
    private MozartUC.apiGroupBox apiGroupBox3;
    private MozartUC.apiGroupBox apiGroupBox4;
    private MozartUC.apiLabel apiLabel9;
    private MozartUC.apiLabel lblSortie;
    private MozartUC.apiCombo cboMotif;
    private System.Windows.Forms.ComboBox cboCiv;
  }
}