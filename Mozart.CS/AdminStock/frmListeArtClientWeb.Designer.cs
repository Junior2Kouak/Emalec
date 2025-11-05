namespace MozartCS
{
  partial class frmListeArtClientWeb
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeArtClientWeb));
      this.cmdCommandes = new MozartUC.apiButton();
      this.cboTech = new MozartUC.apiCombo();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdMouvements = new MozartUC.apiButton();
      this.txtStockMaxi = new MozartUC.apiTextBox();
      this.txtStockMini = new MozartUC.apiTextBox();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdDate = new MozartUC.apiButton();
      this.txtDateEntree = new MozartUC.apiTextBox();
      this.txtQte = new MozartUC.apiTextBox();
      this.txtPrix = new MozartUC.apiTextBox();
      this.cboLieu = new System.Windows.Forms.ComboBox();
      this.txtArticle = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblStock = new MozartUC.apiLabel();
      this.lblDatePrix = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels9 = new MozartUC.apiLabel();
      this.lblLabels10 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.lblArticle = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdCommandes
      // 
      this.cmdCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdCommandes.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCommandes.HelpContextID = 0;
      resources.ApplyResources(this.cmdCommandes, "cmdCommandes");
      this.cmdCommandes.Name = "cmdCommandes";
      this.cmdCommandes.Tag = "91";
      this.cmdCommandes.UseVisualStyleBackColor = false;
      this.cmdCommandes.Click += new System.EventHandler(this.cmdCommandes_Click);
      // 
      // cboTech
      // 
      resources.ApplyResources(this.cboTech, "cboTech");
      this.cboTech.Name = "cboTech";
      this.cboTech.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboTech_TxtChanged);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // cmdMouvements
      // 
      this.cmdMouvements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdMouvements.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdMouvements.HelpContextID = 0;
      resources.ApplyResources(this.cmdMouvements, "cmdMouvements");
      this.cmdMouvements.Name = "cmdMouvements";
      this.cmdMouvements.Tag = "19";
      this.cmdMouvements.UseVisualStyleBackColor = false;
      // 
      // txtStockMaxi
      // 
      resources.ApplyResources(this.txtStockMaxi, "txtStockMaxi");
      this.txtStockMaxi.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtStockMaxi.HelpContextID = 0;
      this.txtStockMaxi.Name = "txtStockMaxi";
      // 
      // txtStockMini
      // 
      resources.ApplyResources(this.txtStockMini, "txtStockMini");
      this.txtStockMini.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtStockMini.HelpContextID = 0;
      this.txtStockMini.Name = "txtStockMini";
      // 
      // cmdSupp
      // 
      this.cmdSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "65";
      this.cmdSupp.UseVisualStyleBackColor = false;
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
      // 
      // txtDateEntree
      // 
      resources.ApplyResources(this.txtDateEntree, "txtDateEntree");
      this.txtDateEntree.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateEntree.HelpContextID = 0;
      this.txtDateEntree.Name = "txtDateEntree";
      // 
      // txtQte
      // 
      resources.ApplyResources(this.txtQte, "txtQte");
      this.txtQte.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtQte.HelpContextID = 0;
      this.txtQte.Name = "txtQte";
      // 
      // txtPrix
      // 
      resources.ApplyResources(this.txtPrix, "txtPrix");
      this.txtPrix.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtPrix.HelpContextID = 0;
      this.txtPrix.Name = "txtPrix";
      // 
      // cboLieu
      // 
      this.cboLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboLieu, "cboLieu");
      this.cboLieu.Name = "cboLieu";
      this.cboLieu.Sorted = true;
      // 
      // txtArticle
      // 
      resources.ApplyResources(this.txtArticle, "txtArticle");
      this.txtArticle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtArticle.HelpContextID = 0;
      this.txtArticle.Name = "txtArticle";
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
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels0
      // 
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblStock
      // 
      this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblStock, "lblStock");
      this.lblStock.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStock.HelpContextID = 0;
      this.lblStock.Name = "lblStock";
      // 
      // lblDatePrix
      // 
      this.lblDatePrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblDatePrix, "lblDatePrix");
      this.lblDatePrix.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDatePrix.HelpContextID = 0;
      this.lblDatePrix.Name = "lblDatePrix";
      // 
      // lblLabels8
      // 
      this.lblLabels8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels9
      // 
      this.lblLabels9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblLabels9, "lblLabels9");
      this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels9.HelpContextID = 0;
      this.lblLabels9.Name = "lblLabels9";
      // 
      // lblLabels10
      // 
      this.lblLabels10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblLabels10, "lblLabels10");
      this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels10.HelpContextID = 0;
      this.lblLabels10.Name = "lblLabels10";
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // lblArticle
      // 
      this.lblArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      resources.ApplyResources(this.lblArticle, "lblArticle");
      this.lblArticle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblArticle.HelpContextID = 0;
      this.lblArticle.Name = "lblArticle";
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(188)))), ((int)(((byte)(228)))));
      this.Frame3.Controls.Add(this.txtStockMaxi);
      this.Frame3.Controls.Add(this.txtStockMini);
      this.Frame3.Controls.Add(this.cmdSupp);
      this.Frame3.Controls.Add(this.cmdDate);
      this.Frame3.Controls.Add(this.txtDateEntree);
      this.Frame3.Controls.Add(this.txtQte);
      this.Frame3.Controls.Add(this.txtPrix);
      this.Frame3.Controls.Add(this.cboLieu);
      this.Frame3.Controls.Add(this.txtArticle);
      this.Frame3.Controls.Add(this.cmdValider);
      this.Frame3.Controls.Add(this.lblLabels1);
      this.Frame3.Controls.Add(this.lblLabels0);
      this.Frame3.Controls.Add(this.lblStock);
      this.Frame3.Controls.Add(this.lblDatePrix);
      this.Frame3.Controls.Add(this.lblLabels8);
      this.Frame3.Controls.Add(this.lblLabels9);
      this.Frame3.Controls.Add(this.lblLabels10);
      this.Frame3.Controls.Add(this.lblLabels11);
      this.Frame3.Controls.Add(this.lblArticle);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
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
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.lblLabels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmListeArtClientWeb
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdCommandes);
      this.Controls.Add(this.cboTech);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdMouvements);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblLabels2);
      this.Controls.Add(this.Label14);
      this.Name = "frmListeArtClientWeb";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeArtClientWeb_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdCommandes;
    private MozartUC.apiCombo cboTech;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdMouvements;
    private MozartUC.apiTextBox txtStockMaxi;
    private MozartUC.apiTextBox txtStockMini;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiTextBox txtDateEntree;
    private MozartUC.apiTextBox txtQte;
    private MozartUC.apiTextBox txtPrix;
    private System.Windows.Forms.ComboBox cboLieu;
    private MozartUC.apiTextBox txtArticle;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblStock;
    private MozartUC.apiLabel lblDatePrix;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblArticle;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdFermer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel Label14;

  }
}
