namespace MozartCS
{
  partial class frmDetailFicheTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailFicheTech));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cboSerie = new System.Windows.Forms.ComboBox();
      this.txtDateNorme = new MozartUC.apiTextBox();
      this.txtTitre = new MozartUC.apiTextBox();
      this.lblSerie = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdDate = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdFichier = new MozartUC.apiButton();
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.frameVisu = new MozartUC.apiGroupBox();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Frame1.SuspendLayout();
      this.frameVisu.SuspendLayout();
      this.SuspendLayout();
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // cboSerie
      // 
      this.cboSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboSerie, "cboSerie");
      this.cboSerie.Name = "cboSerie";
      this.cboSerie.Sorted = true;
      // 
      // txtDateNorme
      // 
      this.txtDateNorme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateNorme, "txtDateNorme");
      this.txtDateNorme.HelpContextID = 0;
      this.txtDateNorme.Name = "txtDateNorme";
      // 
      // txtTitre
      // 
      this.txtTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTitre, "txtTitre");
      this.txtTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTitre.HelpContextID = 0;
      this.txtTitre.Name = "txtTitre";
      // 
      // lblSerie
      // 
      resources.ApplyResources(this.lblSerie, "lblSerie");
      this.lblSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblSerie.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSerie.HelpContextID = 0;
      this.lblSerie.Name = "lblSerie";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.cmdSupp);
      this.Frame1.Controls.Add(this.cmdDate);
      this.Frame1.Controls.Add(this.cboSerie);
      this.Frame1.Controls.Add(this.txtDateNorme);
      this.Frame1.Controls.Add(this.txtTitre);
      this.Frame1.Controls.Add(this.lblSerie);
      this.Frame1.Controls.Add(this.lblLabels1);
      this.Frame1.Controls.Add(this.lblLabels2);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdSupp
      // 
      this.cmdSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "txtDateNaissance";
      this.cmdSupp.UseVisualStyleBackColor = false;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // cmdDate
      // 
      this.cmdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "txtDateNaissance";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
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
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // cmdFichier
      // 
      resources.ApplyResources(this.cmdFichier, "cmdFichier");
      this.cmdFichier.HelpContextID = 0;
      this.cmdFichier.Name = "cmdFichier";
      this.cmdFichier.Tag = "2";
      this.cmdFichier.UseVisualStyleBackColor = true;
      this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
      // 
      // WebBrowser1
      // 
      resources.ApplyResources(this.WebBrowser1, "WebBrowser1");
      this.WebBrowser1.Name = "WebBrowser1";
      // 
      // frameVisu
      // 
      resources.ApplyResources(this.frameVisu, "frameVisu");
      this.frameVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.frameVisu.Controls.Add(this.WebBrowser1);
      this.frameVisu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.frameVisu.FrameColor = System.Drawing.Color.Empty;
      this.frameVisu.HelpContextID = 0;
      this.frameVisu.Name = "frameVisu";
      this.frameVisu.TabStop = false;
      // 
      // frmDetailFicheTech
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdFichier);
      this.Controls.Add(this.frameVisu);
      this.Name = "frmDetailFicheTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDetailFicheTech_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.frameVisu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private System.Windows.Forms.ComboBox cboSerie;
    private MozartUC.apiTextBox txtDateNorme;
    private MozartUC.apiTextBox txtTitre;
    private MozartUC.apiLabel lblSerie;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdFichier;
    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiGroupBox frameVisu;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiButton cmdSupp;
  }
}
