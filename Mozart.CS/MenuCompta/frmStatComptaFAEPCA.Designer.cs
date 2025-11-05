namespace MozartCS
{
  partial class frmStatComptaFAEPCA
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatComptaFAEPCA));
      this.Label3 = new MozartUC.apiLabel();
      this.lblDate = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.btnValid = new MozartUC.apiButton();
      this.dtDateRef = new DevExpress.XtraEditors.DateEdit();
      this.chkAfficherInactif = new MozartUC.apiCheckBox();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Frame3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtDateRef.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDateRef.Properties)).BeginInit();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // lblDate
      // 
      resources.ApplyResources(this.lblDate, "lblDate");
      this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDate.HelpContextID = 0;
      this.lblDate.Name = "lblDate";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame3.Controls.Add(this.btnValid);
      this.Frame3.Controls.Add(this.dtDateRef);
      this.Frame3.Controls.Add(this.chkAfficherInactif);
      this.Frame3.Controls.Add(this.Label3);
      this.Frame3.Controls.Add(this.lblDate);
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // btnValid
      // 
      resources.ApplyResources(this.btnValid, "btnValid");
      this.btnValid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnValid.HelpContextID = 0;
      this.btnValid.Name = "btnValid";
      this.btnValid.UseVisualStyleBackColor = true;
      this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
      // 
      // dtDateRef
      // 
      resources.ApplyResources(this.dtDateRef, "dtDateRef");
      this.dtDateRef.Name = "dtDateRef";
      this.dtDateRef.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtDateRef.Properties.Buttons"))))});
      this.dtDateRef.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtDateRef.Properties.CalendarTimeProperties.Buttons"))))});
      // 
      // chkAfficherInactif
      // 
      resources.ApplyResources(this.chkAfficherInactif, "chkAfficherInactif");
      this.chkAfficherInactif.HelpContextID = 0;
      this.chkAfficherInactif.Name = "chkAfficherInactif";
      this.chkAfficherInactif.UseVisualStyleBackColor = true;
      this.chkAfficherInactif.CheckedChanged += new System.EventHandler(this.chkAfficherInactif_CheckedChanged);
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = false;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      this.apiTGridH.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridH_RowCellStyle);
      this.apiTGridH.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridH_CellValueChanged);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.apiTGridH);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // frmStatComptaFAEPCA
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmStatComptaFAEPCA";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatComptaFAEPCA_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtDateRef.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDateRef.Properties)).EndInit();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel lblDate;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiCheckBox chkAfficherInactif;
    private MozartUC.apiButton btnValid;
    private DevExpress.XtraEditors.DateEdit dtDateRef;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
