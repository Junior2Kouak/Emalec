namespace MozartCS
{
  partial class frmStockRetourTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockRetourTech));
      this.cmdRetourTech = new MozartUC.apiButton();
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.txtObjet = new MozartUC.apiTextBox();
      this.txtDateRetour = new MozartUC.apiTextBox();
      this.cmdDate = new MozartUC.apiButton();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cboTech = new System.Windows.Forms.ComboBox();
      this.cmdRechercher = new MozartUC.apiButton();
      this.txtHT = new MozartUC.apiTextBox();
      this.txtTVA = new MozartUC.apiTextBox();
      this.txtTTC = new MozartUC.apiTextBox();
      this.grdDataGrid = new MozartUC.apiTGrid();
      this.lblLabels7 = new MozartUC.apiLabel();
      this.lblLabels10 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.frameSearch = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.frameSearch.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdRetourTech
      // 
      this.cmdRetourTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdRetourTech.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRetourTech.HelpContextID = 0;
      resources.ApplyResources(this.cmdRetourTech, "cmdRetourTech");
      this.cmdRetourTech.Name = "cmdRetourTech";
      this.cmdRetourTech.Tag = "66";
      this.cmdRetourTech.UseVisualStyleBackColor = false;
      this.cmdRetourTech.Click += new System.EventHandler(this.cmdRetourTech_Click);
      // 
      // Cal
      // 
      this.Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Cal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Cal, "Cal");
      this.Cal.Name = "Cal";
      this.Cal.CloseUp += new System.EventHandler(this.Cal_CloseUp);
      this.Cal.ValueChanged += new System.EventHandler(this.Cal_ValueChanged);
      // 
      // cmdVisu
      // 
      this.cmdVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = false;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
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
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdImprimer
      // 
      this.cmdImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = false;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // txtObjet
      // 
      this.txtObjet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtObjet.HelpContextID = 0;
      resources.ApplyResources(this.txtObjet, "txtObjet");
      this.txtObjet.Name = "txtObjet";
      // 
      // txtDateRetour
      // 
      resources.ApplyResources(this.txtDateRetour, "txtDateRetour");
      this.txtDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateRetour.HelpContextID = 0;
      this.txtDateRetour.Name = "txtDateRetour";
      // 
      // cmdDate
      // 
      this.cmdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "5";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.cboTech);
      this.Frame1.Controls.Add(this.txtObjet);
      this.Frame1.Controls.Add(this.txtDateRetour);
      this.Frame1.Controls.Add(this.cmdDate);
      this.Frame1.Controls.Add(this.lblLabels2);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.Controls.Add(this.lblLabels1);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cboTech
      // 
      this.cboTech.FormattingEnabled = true;
      resources.ApplyResources(this.cboTech, "cboTech");
      this.cboTech.Name = "cboTech";
      // 
      // cmdRechercher
      // 
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRechercher.HelpContextID = 0;
      this.cmdRechercher.Image = global::MozartCS.Properties.Resources.Find;
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "26";
      this.cmdRechercher.UseVisualStyleBackColor = false;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
      // 
      // txtTVA
      // 
      resources.ApplyResources(this.txtTVA, "txtTVA");
      this.txtTVA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtTVA.HelpContextID = 0;
      this.txtTVA.Name = "txtTVA";
      // 
      // txtTTC
      // 
      resources.ApplyResources(this.txtTTC, "txtTTC");
      this.txtTTC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtTTC.HelpContextID = 0;
      this.txtTTC.Name = "txtTTC";
      // 
      // grdDataGrid
      // 
      resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
      this.grdDataGrid.FilterBar = true;
      this.grdDataGrid.FooterBar = true;
      this.grdDataGrid.ForeColor = System.Drawing.SystemColors.WindowText;
      this.grdDataGrid.Name = "grdDataGrid";
      // 
      // lblLabels7
      // 
      resources.ApplyResources(this.lblLabels7, "lblLabels7");
      this.lblLabels7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels7.HelpContextID = 0;
      this.lblLabels7.Name = "lblLabels7";
      // 
      // lblLabels10
      // 
      resources.ApplyResources(this.lblLabels10, "lblLabels10");
      this.lblLabels10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels10.HelpContextID = 0;
      this.lblLabels10.Name = "lblLabels10";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // frameSearch
      // 
      resources.ApplyResources(this.frameSearch, "frameSearch");
      this.frameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.frameSearch.Controls.Add(this.cmdRechercher);
      this.frameSearch.Controls.Add(this.txtHT);
      this.frameSearch.Controls.Add(this.txtTVA);
      this.frameSearch.Controls.Add(this.txtTTC);
      this.frameSearch.Controls.Add(this.grdDataGrid);
      this.frameSearch.Controls.Add(this.lblLabels7);
      this.frameSearch.Controls.Add(this.lblLabels10);
      this.frameSearch.Controls.Add(this.lblLabels11);
      this.frameSearch.Controls.Add(this.lblLabels12);
      this.frameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.frameSearch.FrameColor = System.Drawing.Color.Empty;
      this.frameSearch.HelpContextID = 0;
      this.frameSearch.Name = "frameSearch";
      this.frameSearch.TabStop = false;
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmStockRetourTech
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdRetourTech);
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.frameSearch);
      this.Controls.Add(this.Label1);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.Name = "frmStockRetourTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockRetourTech_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.frameSearch.ResumeLayout(false);
      this.frameSearch.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdRetourTech;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiTextBox txtObjet;
    private MozartUC.apiTextBox txtDateRetour;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiTextBox txtTVA;
    private MozartUC.apiTextBox txtTTC;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiLabel lblLabels7;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox frameSearch;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.ComboBox cboTech;
  }
}
