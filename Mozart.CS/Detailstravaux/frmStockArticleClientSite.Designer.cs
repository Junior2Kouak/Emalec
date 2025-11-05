namespace MozartCS
{
  partial class frmStockArticleClientSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockArticleClientSite));
      this.txtInfoStock = new MozartUC.apiTextBox();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiToolTip1 = new MozartUC.apiTooltip();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.txtdExec = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.cboTech = new System.Windows.Forms.ComboBox();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.frameSearch = new MozartUC.apiGroupBox();
      this.cmdVisu = new MozartUC.apiButton();
      this.txtClient = new MozartUC.apiTextBox();
      this.txtSite = new MozartUC.apiTextBox();
      this.txtNumSite = new MozartUC.apiTextBox();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblLabels15 = new MozartUC.apiLabel();
      this.Image2 = new System.Windows.Forms.PictureBox();
      this.Frame6 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblInfo = new MozartUC.apiLabel();
      this.imgInfo = new System.Windows.Forms.PictureBox();
      this.lblTitre = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.frameSearch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
      this.Frame6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
      this.SuspendLayout();
      // 
      // txtInfoStock
      // 
      resources.ApplyResources(this.txtInfoStock, "txtInfoStock");
      this.txtInfoStock.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtInfoStock.HelpContextID = 0;
      this.txtInfoStock.Name = "txtInfoStock";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.txtInfoStock);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiToolTip1
      // 
      this.apiToolTip1.BackColor = System.Drawing.Color.SteelBlue;
      this.apiToolTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.apiToolTip1.hwnd = ((long)(0));
      resources.ApplyResources(this.apiToolTip1, "apiToolTip1");
      this.apiToolTip1.Name = "apiToolTip1";
      this.apiToolTip1.NbLignes = 0;
      this.apiToolTip1.Texte = "";
      this.apiToolTip1.TexteBox = "";
      this.apiToolTip1.Titre = null;
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
      // txtdExec
      // 
      this.txtdExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtdExec, "txtdExec");
      this.txtdExec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtdExec.HelpContextID = 0;
      this.txtdExec.Name = "txtdExec";
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // cboTech
      // 
      this.cboTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTech, "cboTech");
      this.cboTech.Name = "cboTech";
      // 
      // lblLabels6
      // 
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // lblLabels8
      // 
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.txtdExec);
      this.Frame1.Controls.Add(this.cmdDate1);
      this.Frame1.Controls.Add(this.cboTech);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.Controls.Add(this.lblLabels8);
      this.Frame1.Controls.Add(this.lblLabels4);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // apiTGrid1
      // 
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.ForeColor = System.Drawing.Color.Black;
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // frameSearch
      // 
      this.frameSearch.BackColor = System.Drawing.Color.Wheat;
      this.frameSearch.Controls.Add(this.apiTGrid1);
      resources.ApplyResources(this.frameSearch, "frameSearch");
      this.frameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.frameSearch.HelpContextID = 0;
      this.frameSearch.Name = "frameSearch";
      this.frameSearch.TabStop = false;
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // txtClient
      // 
      this.txtClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtClient, "txtClient");
      this.txtClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtClient.HelpContextID = 0;
      this.txtClient.Name = "txtClient";
      // 
      // txtSite
      // 
      this.txtSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtSite, "txtSite");
      this.txtSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtSite.HelpContextID = 0;
      this.txtSite.Name = "txtSite";
      // 
      // txtNumSite
      // 
      this.txtNumSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNumSite, "txtNumSite");
      this.txtNumSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNumSite.HelpContextID = 0;
      this.txtNumSite.Name = "txtNumSite";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblLabels15
      // 
      this.lblLabels15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels15, "lblLabels15");
      this.lblLabels15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels15.HelpContextID = 0;
      this.lblLabels15.Name = "lblLabels15";
      // 
      // Image2
      // 
      this.Image2.Image = global::MozartCS.Properties.Resources.carteFR32;
      resources.ApplyResources(this.Image2, "Image2");
      this.Image2.Name = "Image2";
      this.Image2.TabStop = false;
      this.Image2.Click += new System.EventHandler(this.Image2_Click);
      // 
      // Frame6
      // 
      this.Frame6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame6.Controls.Add(this.txtClient);
      this.Frame6.Controls.Add(this.txtSite);
      this.Frame6.Controls.Add(this.txtNumSite);
      this.Frame6.Controls.Add(this.lblLabels2);
      this.Frame6.Controls.Add(this.lblLabels3);
      this.Frame6.Controls.Add(this.lblLabels15);
      this.Frame6.Controls.Add(this.Image2);
      resources.ApplyResources(this.Frame6, "Frame6");
      this.Frame6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame6.HelpContextID = 0;
      this.Frame6.Name = "Frame6";
      this.Frame6.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
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
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblInfo, "lblInfo");
      this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblInfo.HelpContextID = 0;
      this.lblInfo.Name = "lblInfo";
      // 
      // imgInfo
      // 
      this.imgInfo.Image = global::MozartCS.Properties.Resources.infoImg;
      resources.ApplyResources(this.imgInfo, "imgInfo");
      this.imgInfo.Name = "imgInfo";
      this.imgInfo.TabStop = false;
      this.imgInfo.Click += new System.EventHandler(this.imgInfo_Click);
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmStockArticleClientSite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.apiToolTip1);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.frameSearch);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.Frame6);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.imgInfo);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmStockArticleClientSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockArticleClientSite_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.frameSearch.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
      this.Frame6.ResumeLayout(false);
      this.Frame6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtInfoStock;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTooltip apiToolTip1;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiTextBox txtdExec;
    private MozartUC.apiButton cmdDate1;
    private System.Windows.Forms.ComboBox cboTech;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiGroupBox frameSearch;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiTextBox txtClient;
    private MozartUC.apiTextBox txtSite;
    private MozartUC.apiTextBox txtNumSite;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels15;
    private System.Windows.Forms.PictureBox Image2;
    private MozartUC.apiGroupBox Frame6;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblInfo;
    private System.Windows.Forms.PictureBox imgInfo;
    private MozartUC.apiLabel lblTitre;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
