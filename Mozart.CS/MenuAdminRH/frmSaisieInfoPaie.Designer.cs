namespace MozartCS
{
  partial class frmSaisieInfoPaie
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieInfoPaie));
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.DateEdit_Fin = new DevExpress.XtraEditors.DateEdit();
      this.DateEdit_Debut = new DevExpress.XtraEditors.DateEdit();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).BeginInit();
      this.SuspendLayout();
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
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      this.Label1.Tag = "";
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
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // frmSaisieInfoPaie
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.DateEdit_Fin);
      this.Controls.Add(this.DateEdit_Debut);
      this.Controls.Add(this.lblLabels12);
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmSaisieInfoPaie";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSaisieInfoPaie_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Fin.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEdit_Debut.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel Label1;
    private DevExpress.XtraEditors.DateEdit DateEdit_Fin;
    private DevExpress.XtraEditors.DateEdit DateEdit_Debut;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel apiLabel1;
  }
}
