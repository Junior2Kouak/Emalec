namespace MozartCS
{
  partial class frmGESClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGESClient));
      this.apiGrid = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.lblTHTh = new MozartUC.apiLabel();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.DateEdit_Fin = new DevExpress.XtraEditors.DateEdit();
      this.DateEdit_Debut = new DevExpress.XtraEditors.DateEdit();
      this.cmdValider = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      this.apiGrid.ColumnFilterChanged += new MozartUC.apiTGrid.ColumnFilterChangedEventHandler(this.apiTGrid_ColumnFilterChanged);
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.lblTHTh);
      this.Frame1.Controls.Add(this.apiGrid);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // lblTHTh
      // 
      resources.ApplyResources(this.lblTHTh, "lblTHTh");
      this.lblTHTh.BackColor = System.Drawing.Color.Transparent;
      this.lblTHTh.ForeColor = System.Drawing.Color.Red;
      this.lblTHTh.HelpContextID = 0;
      this.lblTHTh.Name = "lblTHTh";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // apiLabel2
      // 
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // DateEdit_Fin
      // 
      resources.ApplyResources(this.DateEdit_Fin, "DateEdit_Fin");
      this.DateEdit_Fin.Name = "DateEdit_Fin";
      this.DateEdit_Fin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.Buttons"))))});
      this.DateEdit_Fin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Fin.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // DateEdit_Debut
      // 
      resources.ApplyResources(this.DateEdit_Debut, "DateEdit_Debut");
      this.DateEdit_Debut.Name = "DateEdit_Debut";
      this.DateEdit_Debut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.Buttons"))))});
      this.DateEdit_Debut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("DateEdit_Debut.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "15";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // frmGESClient
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiLabel2);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.DateEdit_Fin);
      this.Controls.Add(this.DateEdit_Debut);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Name = "frmGESClient";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGESClient_Load);
      this.Frame1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiButton cmdQuitter;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiLabel lblTHTh;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel apiLabel1;
    private DevExpress.XtraEditors.DateEdit DateEdit_Fin;
    private DevExpress.XtraEditors.DateEdit DateEdit_Debut;
    private MozartUC.apiButton cmdValider;
  }
}
