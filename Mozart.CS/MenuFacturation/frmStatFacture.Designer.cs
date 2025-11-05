namespace MozartCS
{
  partial class frmStatFacture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatFacture));
			this.Cmd24m = new MozartUC.apiButton();
			this.cmdAn = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.lblLabels12 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.txtDateFin = new DevExpress.XtraEditors.DateEdit();
			this.txtDateDebut = new DevExpress.XtraEditors.DateEdit();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.apiTGrid2 = new MozartUC.apiTGrid();
			this.apiTGrid3 = new MozartUC.apiTGrid();
			this.Label7 = new MozartUC.apiLabel();
			this.Label6 = new MozartUC.apiLabel();
			this.Label5 = new MozartUC.apiLabel();
			this.Label4 = new MozartUC.apiLabel();
			this.Label3 = new MozartUC.apiLabel();
			this.Label2 = new MozartUC.apiLabel();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// Cmd24m
			// 
			resources.ApplyResources(this.Cmd24m, "Cmd24m");
			this.Cmd24m.HelpContextID = 0;
			this.Cmd24m.Name = "Cmd24m";
			this.Cmd24m.Tag = "37";
			this.Cmd24m.UseVisualStyleBackColor = true;
			this.Cmd24m.Click += new System.EventHandler(this.Cmd24m_Click);
			// 
			// cmdAn
			// 
			resources.ApplyResources(this.cmdAn, "cmdAn");
			this.cmdAn.HelpContextID = 0;
			this.cmdAn.Name = "cmdAn";
			this.cmdAn.Tag = "90";
			this.cmdAn.UseVisualStyleBackColor = true;
			this.cmdAn.Click += new System.EventHandler(this.cmdAn_Click);
			// 
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
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
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = false;
			this.apiSocieteAuto1.IdMenuParent = ((short)(86));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// lblLabels12
			// 
			resources.ApplyResources(this.lblLabels12, "lblLabels12");
			this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels12.HelpContextID = 0;
			this.lblLabels12.Name = "lblLabels12";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.Wheat;
			this.Frame1.Controls.Add(this.apiSocieteAuto1);
			this.Frame1.Controls.Add(this.txtDateFin);
			this.Frame1.Controls.Add(this.lblLabels12);
			this.Frame1.Controls.Add(this.lblLabels0);
			this.Frame1.Controls.Add(this.txtDateDebut);
			this.Frame1.ForeColor = System.Drawing.Color.Wheat;
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// txtDateFin
			// 
			resources.ApplyResources(this.txtDateFin, "txtDateFin");
			this.txtDateFin.Name = "txtDateFin";
			this.txtDateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.Buttons"))))});
			this.txtDateFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateFin.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// txtDateDebut
			// 
			resources.ApplyResources(this.txtDateDebut, "txtDateDebut");
			this.txtDateDebut.Name = "txtDateDebut";
			this.txtDateDebut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.Buttons"))))});
			this.txtDateDebut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDateDebut.Properties.CalendarTimeProperties.Buttons"))))});
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.CounterColumn = null;
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			// 
			// apiTGrid2
			// 
			this.apiTGrid2.CounterColumn = null;
			this.apiTGrid2.FilterBar = true;
			this.apiTGrid2.FooterBar = true;
			resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
			this.apiTGrid2.Name = "apiTGrid2";
			// 
			// apiTGrid3
			// 
			this.apiTGrid3.CounterColumn = null;
			this.apiTGrid3.FilterBar = true;
			this.apiTGrid3.FooterBar = true;
			resources.ApplyResources(this.apiTGrid3, "apiTGrid3");
			this.apiTGrid3.Name = "apiTGrid3";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.HelpContextID = 0;
			this.Label7.Name = "Label7";
			// 
			// Label6
			// 
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.BackColor = System.Drawing.Color.Wheat;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.HelpContextID = 0;
			this.Label6.Name = "Label6";
			// 
			// Label5
			// 
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.BackColor = System.Drawing.Color.Wheat;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.HelpContextID = 0;
			this.Label5.Name = "Label5";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.BackColor = System.Drawing.Color.Wheat;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.HelpContextID = 0;
			this.Label4.Name = "Label4";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.BackColor = System.Drawing.Color.Wheat;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmStatFacture
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Cmd24m);
			this.Controls.Add(this.cmdAn);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.apiTGrid2);
			this.Controls.Add(this.apiTGrid3);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "frmStatFacture";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStatFacture_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateFin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDateDebut.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton Cmd24m;
    private MozartUC.apiButton cmdAn;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiSocieteAuto apiSocieteAuto1;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiTGrid apiTGrid3;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private DevExpress.XtraEditors.DateEdit txtDateDebut;
    private DevExpress.XtraEditors.DateEdit txtDateFin;
  }
}
