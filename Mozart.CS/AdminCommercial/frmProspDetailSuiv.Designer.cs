namespace MozartCS
{
  partial class frmProspDetailSuiv
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspDetailSuiv));
      this.cmdValider = new MozartUC.apiButton();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cboDomCom = new System.Windows.Forms.ComboBox();
      this.chkRDVReal = new System.Windows.Forms.CheckBox();
      this.lblPropCom = new System.Windows.Forms.Label();
      this.chkRDVpris = new System.Windows.Forms.CheckBox();
      this.cmdTraduction = new MozartUC.apiButton();
      this.cmdSpell = new MozartUC.apiButton();
      this.txtDateA0 = new DevExpress.XtraEditors.DateEdit();
      this.txtDateRDV = new DevExpress.XtraEditors.DateEdit();
      this.label2 = new System.Windows.Forms.Label();
      this.lblLabels0 = new System.Windows.Forms.Label();
      this.txtAction = new MozartUC.apiTextBox();
      this.lblAuteur = new System.Windows.Forms.Label();
      this.lblLabels5 = new System.Windows.Forms.Label();
      this.lblLabels3 = new System.Windows.Forms.Label();
      this.lblLabels1 = new System.Windows.Forms.Label();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblTitre = new System.Windows.Forms.Label();
      this.lblQuiEtQuandRDVRealise = new System.Windows.Forms.Label();
      this.Frame2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateRDV.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateRDV.Properties.CalendarTimeProperties)).BeginInit();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.SystemColors.Control;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.lblQuiEtQuandRDVRealise);
      this.Frame2.Controls.Add(this.cboDomCom);
      this.Frame2.Controls.Add(this.chkRDVReal);
      this.Frame2.Controls.Add(this.lblPropCom);
      this.Frame2.Controls.Add(this.chkRDVpris);
      this.Frame2.Controls.Add(this.cmdTraduction);
      this.Frame2.Controls.Add(this.cmdSpell);
      this.Frame2.Controls.Add(this.txtDateA0);
      this.Frame2.Controls.Add(this.txtDateRDV);
      this.Frame2.Controls.Add(this.label2);
      this.Frame2.Controls.Add(this.lblLabels0);
      this.Frame2.Controls.Add(this.txtAction);
      this.Frame2.Controls.Add(this.lblAuteur);
      this.Frame2.Controls.Add(this.lblLabels5);
      this.Frame2.Controls.Add(this.lblLabels3);
      this.Frame2.Controls.Add(this.lblLabels1);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cboDomCom
      // 
      this.cboDomCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboDomCom.FormattingEnabled = true;
      resources.ApplyResources(this.cboDomCom, "cboDomCom");
      this.cboDomCom.Name = "cboDomCom";
      // 
      // chkRDVReal
      // 
      resources.ApplyResources(this.chkRDVReal, "chkRDVReal");
      this.chkRDVReal.ForeColor = System.Drawing.Color.Black;
      this.chkRDVReal.Name = "chkRDVReal";
      this.chkRDVReal.UseVisualStyleBackColor = true;
      this.chkRDVReal.CheckedChanged += new System.EventHandler(this.chkRDVReal_CheckedChanged);
      // 
      // lblPropCom
      // 
      resources.ApplyResources(this.lblPropCom, "lblPropCom");
      this.lblPropCom.BackColor = System.Drawing.Color.Wheat;
      this.lblPropCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblPropCom.Name = "lblPropCom";
      // 
      // chkRDVpris
      // 
      resources.ApplyResources(this.chkRDVpris, "chkRDVpris");
      this.chkRDVpris.BackColor = System.Drawing.Color.Wheat;
      this.chkRDVpris.ForeColor = System.Drawing.Color.Black;
      this.chkRDVpris.Name = "chkRDVpris";
      this.chkRDVpris.UseVisualStyleBackColor = false;
      this.chkRDVpris.CheckedChanged += new System.EventHandler(this.chkRDVpris_CheckedChanged);
      // 
      // cmdTraduction
      // 
      this.cmdTraduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdTraduction, "cmdTraduction");
      this.cmdTraduction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTraduction.HelpContextID = 643;
      this.cmdTraduction.Name = "cmdTraduction";
      this.cmdTraduction.UseVisualStyleBackColor = false;
      this.cmdTraduction.Click += new System.EventHandler(this.cmdTraduction_Click);
      // 
      // cmdSpell
      // 
      this.cmdSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.cmdSpell, "cmdSpell");
      this.cmdSpell.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSpell.HelpContextID = 644;
      this.cmdSpell.Name = "cmdSpell";
      this.cmdSpell.UseVisualStyleBackColor = false;
      this.cmdSpell.Click += new System.EventHandler(this.cmdSpell_Click);
      // 
      // txtDateA0
      // 
      resources.ApplyResources(this.txtDateA0, "txtDateA0");
      this.txtDateA0.Name = "txtDateA0";
      this.txtDateA0.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.txtDateA0.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA0.Properties.Buttons"))))});
      this.txtDateA0.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateA0.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // txtDateRDV
      // 
      resources.ApplyResources(this.txtDateRDV, "txtDateRDV");
      this.txtDateRDV.Name = "txtDateRDV";
      this.txtDateRDV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.txtDateRDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateRDV.Properties.Buttons"))))});
      this.txtDateRDV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateRDV.Properties.CalendarTimeProperties.Buttons"))))});
      this.txtDateRDV.EditValueChanged += new System.EventHandler(this.txtDateRDV_EditValueChanged);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.BackColor = System.Drawing.Color.Wheat;
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Name = "label2";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels0.ForeColor = System.Drawing.Color.Black;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // txtAction
      // 
      this.txtAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtAction, "txtAction");
      this.txtAction.HelpContextID = 0;
      this.txtAction.Name = "txtAction";
      // 
      // lblAuteur
      // 
      resources.ApplyResources(this.lblAuteur, "lblAuteur");
      this.lblAuteur.BackColor = System.Drawing.Color.Wheat;
      this.lblAuteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblAuteur.Name = "lblAuteur";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels5.ForeColor = System.Drawing.Color.Black;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels3.ForeColor = System.Drawing.Color.Black;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels1.ForeColor = System.Drawing.Color.Black;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // lblQuiEtQuandRDVRealise
      // 
      resources.ApplyResources(this.lblQuiEtQuandRDVRealise, "lblQuiEtQuandRDVRealise");
      this.lblQuiEtQuandRDVRealise.BackColor = System.Drawing.Color.Wheat;
      this.lblQuiEtQuandRDVRealise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblQuiEtQuandRDVRealise.Name = "lblQuiEtQuandRDVRealise";
      // 
      // frmProspDetailSuiv
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.Frame2);
      this.Name = "frmProspDetailSuiv";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmProspDetailSuiv_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateA0.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateRDV.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDateRDV.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Label lblLabels0;
    private System.Windows.Forms.Label lblAuteur;
    private System.Windows.Forms.Label lblLabels5;
    private System.Windows.Forms.Label lblLabels3;
    private System.Windows.Forms.Label lblLabels1;
    private MozartUC.apiTextBox txtAction;
    private System.Windows.Forms.Label label2;
    private DevExpress.XtraEditors.DateEdit txtDateRDV;
    private DevExpress.XtraEditors.DateEdit txtDateA0;
    private MozartUC.apiButton cmdTraduction;
    private MozartUC.apiButton cmdSpell;
    private System.Windows.Forms.CheckBox chkRDVpris;
    private System.Windows.Forms.CheckBox chkRDVReal;
    private System.Windows.Forms.Label lblPropCom;
    private System.Windows.Forms.ComboBox cboDomCom;
    private System.Windows.Forms.Label lblQuiEtQuandRDVRealise;
  }
}
