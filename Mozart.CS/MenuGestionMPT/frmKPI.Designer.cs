
namespace MozartCS
{
  partial class frmKPI
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKPI));
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.DateEdit_Fin = new DevExpress.XtraEditors.DateEdit();
      this.DateEdit_Debut = new DevExpress.XtraEditors.DateEdit();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTBandedGrid();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).BeginInit();
      this.SuspendLayout();
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
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowCellStyle += new MozartUC.apiTBandedGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
      this.apiTGrid1.RowCellClick += new MozartUC.apiTBandedGrid.RowCellClickEventHandler(this.apiTGrid1_RowCellClick);
      // 
      // frmKPI
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.apiLabel2);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.DateEdit_Fin);
      this.Controls.Add(this.DateEdit_Debut);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdQuitter);
      this.Name = "frmKPI";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmKPI_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel apiLabel1;
    private DevExpress.XtraEditors.DateEdit DateEdit_Fin;
    private DevExpress.XtraEditors.DateEdit DateEdit_Debut;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTBandedGrid apiTGrid1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}