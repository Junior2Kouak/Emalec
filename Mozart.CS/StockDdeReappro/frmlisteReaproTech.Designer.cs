namespace MozartCS
{
  partial class frmlisteReaproTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlisteReaproTech));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdAffecter = new MozartUC.apiButton();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.apicboTech = new MozartUC.apiCombo();
      this.lblLabels1 = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdAffecter
      // 
      this.cmdAffecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdAffecter, "cmdAffecter");
      this.cmdAffecter.HelpContextID = 0;
      this.cmdAffecter.Name = "cmdAffecter";
      this.cmdAffecter.Tag = "66";
      this.cmdAffecter.UseVisualStyleBackColor = true;
      this.cmdAffecter.Click += new System.EventHandler(this.cmdAffecter_Click);
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      this.apiTGridH.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridH_RowCellStyle);
      // 
      // apicboTech
      // 
      resources.ApplyResources(this.apicboTech, "apicboTech");
      this.apicboTech.Name = "apicboTech";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels1.ForeColor = System.Drawing.Color.Yellow;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Transparent;
      this.Label14.ForeColor = System.Drawing.Color.Yellow;
      this.Label14.Name = "Label14";
      // 
      // frmlisteReaproTech
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdAffecter);
      this.Controls.Add(this.apiTGridH);
      this.Controls.Add(this.apicboTech);
      this.Controls.Add(this.lblLabels1);
      this.Controls.Add(this.Label14);
      this.Name = "frmlisteReaproTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmlisteReaproTech_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdAffecter;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiCombo apicboTech;
    private System.Windows.Forms.Label lblLabels1;
    private System.Windows.Forms.Label Label14;
  }
}
