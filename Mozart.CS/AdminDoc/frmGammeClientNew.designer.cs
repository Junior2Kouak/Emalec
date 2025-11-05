namespace MozartCS
{
  partial class frmGammeClientNew
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGammeClientNew));
      this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
      this.frameVisu = new MozartUC.apiGroupBox();
      this.cmdFichier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.txtGamme = new MozartUC.apiTextBox();
      this.cmdRechercher = new MozartUC.apiButton();
      this.txtTitre = new MozartUC.apiTextBox();
      this.chkLiaisonStock = new MozartUC.apiCheckBox();
      this.cboContrat = new System.Windows.Forms.ComboBox();
      this.txtAE = new MozartUC.apiTextBox();
      this.txtDate = new MozartUC.apiTextBox();
      this.txtNum = new MozartUC.apiTextBox();
      this.Label8 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.Label14 = new MozartUC.apiLabel();
      this.cmdCocherTC = new MozartUC.apiButton();
      this.cmdDecocherTC = new MozartUC.apiButton();
      this.apicboClient = new MozartUC.apiCombo();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.GCGAMCLI = new DevExpress.XtraGrid.GridControl();
      this.GVGAMCLI = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.GCol_NTRAEMANUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_NGAMTRAMENUM = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_NCHECK = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepoNCHECK = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.GCol_VGAMPARA = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_VGAMLIB = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.GCol_BVALOBLIG = new DevExpress.XtraGrid.Columns.GridColumn();
      this.RepoBVALOBLIG = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.frameVisu.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.apiGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GCGAMCLI)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVGAMCLI)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepoNCHECK)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepoBVALOBLIG)).BeginInit();
      this.SuspendLayout();
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
      // cmdFichier
      // 
      resources.ApplyResources(this.cmdFichier, "cmdFichier");
      this.cmdFichier.HelpContextID = 0;
      this.cmdFichier.Name = "cmdFichier";
      this.cmdFichier.Tag = "2";
      this.cmdFichier.UseVisualStyleBackColor = true;
      this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
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
      // txtGamme
      // 
      this.txtGamme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtGamme, "txtGamme");
      this.txtGamme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtGamme.HelpContextID = 0;
      this.txtGamme.Name = "txtGamme";
      // 
      // cmdRechercher
      // 
      this.cmdRechercher.BackColor = System.Drawing.Color.Transparent;
      this.cmdRechercher.HelpContextID = 0;
      this.cmdRechercher.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "8";
      this.cmdRechercher.UseVisualStyleBackColor = false;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // txtTitre
      // 
      this.txtTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTitre, "txtTitre");
      this.txtTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTitre.HelpContextID = 0;
      this.txtTitre.Name = "txtTitre";
      // 
      // chkLiaisonStock
      // 
      this.chkLiaisonStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkLiaisonStock, "chkLiaisonStock");
      this.chkLiaisonStock.HelpContextID = 0;
      this.chkLiaisonStock.Name = "chkLiaisonStock";
      this.chkLiaisonStock.UseVisualStyleBackColor = false;
      // 
      // cboContrat
      // 
      this.cboContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboContrat, "cboContrat");
      this.cboContrat.Name = "cboContrat";
      // 
      // txtAE
      // 
      this.txtAE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtAE, "txtAE");
      this.txtAE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtAE.HelpContextID = 0;
      this.txtAE.Name = "txtAE";
      // 
      // txtDate
      // 
      this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDate, "txtDate");
      this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtDate.HelpContextID = 0;
      this.txtDate.Name = "txtDate";
      // 
      // txtNum
      // 
      this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNum, "txtNum");
      this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNum.HelpContextID = 0;
      this.txtNum.Name = "txtNum";
      // 
      // Label8
      // 
      this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.HelpContextID = 0;
      this.Label8.Name = "Label8";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // Label5
      // 
      this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.txtGamme);
      this.Frame4.Controls.Add(this.cmdRechercher);
      this.Frame4.Controls.Add(this.txtTitre);
      this.Frame4.Controls.Add(this.chkLiaisonStock);
      this.Frame4.Controls.Add(this.cboContrat);
      this.Frame4.Controls.Add(this.txtAE);
      this.Frame4.Controls.Add(this.txtDate);
      this.Frame4.Controls.Add(this.txtNum);
      this.Frame4.Controls.Add(this.Label8);
      this.Frame4.Controls.Add(this.Label6);
      this.Frame4.Controls.Add(this.Label5);
      this.Frame4.Controls.Add(this.Label2);
      this.Frame4.Controls.Add(this.Label4);
      this.Frame4.Controls.Add(this.Label3);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame4.FrameColor = System.Drawing.Color.Empty;
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // cmdCocherTC
      // 
      resources.ApplyResources(this.cmdCocherTC, "cmdCocherTC");
      this.cmdCocherTC.HelpContextID = 0;
      this.cmdCocherTC.Name = "cmdCocherTC";
      this.cmdCocherTC.UseVisualStyleBackColor = true;
      this.cmdCocherTC.Click += new System.EventHandler(this.cmdCocherTC_Click);
      // 
      // cmdDecocherTC
      // 
      resources.ApplyResources(this.cmdDecocherTC, "cmdDecocherTC");
      this.cmdDecocherTC.HelpContextID = 0;
      this.cmdDecocherTC.Name = "cmdDecocherTC";
      this.cmdDecocherTC.UseVisualStyleBackColor = true;
      this.cmdDecocherTC.Click += new System.EventHandler(this.cmdDecocherTC_Click);
      // 
      // apicboClient
      // 
      resources.ApplyResources(this.apicboClient, "apicboClient");
      this.apicboClient.Name = "apicboClient";
      this.apicboClient.NewValues = false;
      this.apicboClient.Leave += new System.EventHandler(this.apicboClient_Leave);
      // 
      // apiGroupBox1
      // 
      this.apiGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.apiGroupBox1.Controls.Add(this.GCGAMCLI);
      this.apiGroupBox1.Controls.Add(this.frameVisu);
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox1.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // GCGAMCLI
      // 
      resources.ApplyResources(this.GCGAMCLI, "GCGAMCLI");
      this.GCGAMCLI.MainView = this.GVGAMCLI;
      this.GCGAMCLI.Name = "GCGAMCLI";
      this.GCGAMCLI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepoNCHECK,
            this.RepoBVALOBLIG});
      this.GCGAMCLI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVGAMCLI});
      // 
      // GVGAMCLI
      // 
      this.GVGAMCLI.ColumnPanelRowHeight = 40;
      this.GVGAMCLI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_NTRAEMANUM,
            this.GCol_NGAMTRAMENUM,
            this.GCol_NCHECK,
            this.GCol_VGAMPARA,
            this.GCol_VGAMLIB,
            this.gridColumn4,
            this.GCol_BVALOBLIG});
      this.GVGAMCLI.GridControl = this.GCGAMCLI;
      this.GVGAMCLI.Name = "GVGAMCLI";
      this.GVGAMCLI.OptionsView.ShowFooter = true;
      this.GVGAMCLI.OptionsView.ShowGroupPanel = false;
      this.GVGAMCLI.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GVGAMCLI_CustomDrawFooter);
      this.GVGAMCLI.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.GVGAMCLI_ShowingEditor);
      // 
      // GCol_NTRAEMANUM
      // 
      resources.ApplyResources(this.GCol_NTRAEMANUM, "GCol_NTRAEMANUM");
      this.GCol_NTRAEMANUM.FieldName = "NTRAEMANUM";
      this.GCol_NTRAEMANUM.Name = "GCol_NTRAEMANUM";
      // 
      // GCol_NGAMTRAMENUM
      // 
      resources.ApplyResources(this.GCol_NGAMTRAMENUM, "GCol_NGAMTRAMENUM");
      this.GCol_NGAMTRAMENUM.FieldName = "NGAMTRAMENUM";
      this.GCol_NGAMTRAMENUM.Name = "GCol_NGAMTRAMENUM";
      // 
      // GCol_NCHECK
      // 
      this.GCol_NCHECK.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GCol_NCHECK.AppearanceHeader.Font")));
      this.GCol_NCHECK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_NCHECK.AppearanceHeader.Options.UseFont = true;
      this.GCol_NCHECK.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_NCHECK.AppearanceHeader.Options.UseTextOptions = true;
      this.GCol_NCHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GCol_NCHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GCol_NCHECK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GCol_NCHECK, "GCol_NCHECK");
      this.GCol_NCHECK.ColumnEdit = this.RepoNCHECK;
      this.GCol_NCHECK.FieldName = "NCHECK";
      this.GCol_NCHECK.Name = "GCol_NCHECK";
      // 
      // RepoNCHECK
      // 
      resources.ApplyResources(this.RepoNCHECK, "RepoNCHECK");
      this.RepoNCHECK.Name = "RepoNCHECK";
      this.RepoNCHECK.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
      this.RepoNCHECK.ValueChecked = 1;
      this.RepoNCHECK.ValueUnchecked = 0;
      this.RepoNCHECK.CheckedChanged += new System.EventHandler(this.RepoNCHECK_CheckedChanged);
      // 
      // GCol_VGAMPARA
      // 
      this.GCol_VGAMPARA.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GCol_VGAMPARA.AppearanceHeader.Font")));
      this.GCol_VGAMPARA.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_VGAMPARA.AppearanceHeader.Options.UseFont = true;
      this.GCol_VGAMPARA.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_VGAMPARA.AppearanceHeader.Options.UseTextOptions = true;
      this.GCol_VGAMPARA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GCol_VGAMPARA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GCol_VGAMPARA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GCol_VGAMPARA, "GCol_VGAMPARA");
      this.GCol_VGAMPARA.FieldName = "VGAMPARA";
      this.GCol_VGAMPARA.Name = "GCol_VGAMPARA";
      this.GCol_VGAMPARA.OptionsColumn.AllowEdit = false;
      this.GCol_VGAMPARA.OptionsColumn.ReadOnly = true;
      // 
      // GCol_VGAMLIB
      // 
      this.GCol_VGAMLIB.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GCol_VGAMLIB.AppearanceHeader.Font")));
      this.GCol_VGAMLIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_VGAMLIB.AppearanceHeader.Options.UseFont = true;
      this.GCol_VGAMLIB.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_VGAMLIB.AppearanceHeader.Options.UseTextOptions = true;
      this.GCol_VGAMLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GCol_VGAMLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GCol_VGAMLIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GCol_VGAMLIB, "GCol_VGAMLIB");
      this.GCol_VGAMLIB.FieldName = "VGAMLIB";
      this.GCol_VGAMLIB.Name = "GCol_VGAMLIB";
      this.GCol_VGAMLIB.OptionsColumn.AllowEdit = false;
      this.GCol_VGAMLIB.OptionsColumn.ReadOnly = true;
      // 
      // gridColumn4
      // 
      this.gridColumn4.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn4.AppearanceHeader.Font")));
      this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.gridColumn4.AppearanceHeader.Options.UseFont = true;
      this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
      this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
      this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.gridColumn4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.gridColumn4, "gridColumn4");
      this.gridColumn4.FieldName = "VTRACLIDET";
      this.gridColumn4.Name = "gridColumn4";
      // 
      // GCol_BVALOBLIG
      // 
      this.GCol_BVALOBLIG.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("GCol_BVALOBLIG.AppearanceHeader.Font")));
      this.GCol_BVALOBLIG.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
      this.GCol_BVALOBLIG.AppearanceHeader.Options.UseFont = true;
      this.GCol_BVALOBLIG.AppearanceHeader.Options.UseForeColor = true;
      this.GCol_BVALOBLIG.AppearanceHeader.Options.UseTextOptions = true;
      this.GCol_BVALOBLIG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.GCol_BVALOBLIG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.GCol_BVALOBLIG.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      resources.ApplyResources(this.GCol_BVALOBLIG, "GCol_BVALOBLIG");
      this.GCol_BVALOBLIG.ColumnEdit = this.RepoBVALOBLIG;
      this.GCol_BVALOBLIG.FieldName = "BVALOBLIG";
      this.GCol_BVALOBLIG.Name = "GCol_BVALOBLIG";
      // 
      // RepoBVALOBLIG
      // 
      resources.ApplyResources(this.RepoBVALOBLIG, "RepoBVALOBLIG");
      this.RepoBVALOBLIG.Name = "RepoBVALOBLIG";
      this.RepoBVALOBLIG.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
      this.RepoBVALOBLIG.CheckedChanged += new System.EventHandler(this.RepoBVALOBLIG_CheckedChanged);
      // 
      // frmGammeClientNew
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiGroupBox1);
      this.Controls.Add(this.apicboClient);
      this.Controls.Add(this.cmdDecocherTC);
      this.Controls.Add(this.cmdCocherTC);
      this.Controls.Add(this.cmdFichier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.Label14);
      this.Name = "frmGammeClientNew";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGammeClient_Load);
      this.frameVisu.ResumeLayout(false);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.apiGroupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.GCGAMCLI)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.GVGAMCLI)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepoNCHECK)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RepoBVALOBLIG)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.WebBrowser WebBrowser1;
    private MozartUC.apiGroupBox frameVisu;
    private MozartUC.apiButton cmdFichier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtGamme;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiTextBox txtTitre;
    private MozartUC.apiCheckBox chkLiaisonStock;
    private System.Windows.Forms.ComboBox cboContrat;
    private MozartUC.apiTextBox txtAE;
    private MozartUC.apiTextBox txtDate;
    private MozartUC.apiTextBox txtNum;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiGroupBox Frame4;
    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiLabel Label14;
    private MozartUC.apiButton cmdCocherTC;
    private MozartUC.apiButton cmdDecocherTC;
    private MozartUC.apiCombo apicboClient;
    private MozartUC.apiGroupBox apiGroupBox1;
    private DevExpress.XtraGrid.GridControl GCGAMCLI;
    private DevExpress.XtraGrid.Views.Grid.GridView GVGAMCLI;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NGAMTRAMENUM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_VGAMLIB;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NCHECK;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepoNCHECK;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_BVALOBLIG;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepoBVALOBLIG;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_NTRAEMANUM;
    private DevExpress.XtraGrid.Columns.GridColumn GCol_VGAMPARA;
  }
}
