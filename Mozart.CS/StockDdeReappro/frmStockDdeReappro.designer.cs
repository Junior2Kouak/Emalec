namespace MozartCS
{
  partial class frmStockDdeReappro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDdeReappro));
			this.CmdCommandeEMALEC = new MozartUC.apiButton();
			this.CmdOutEPI = new MozartUC.apiButton();
			this.Cal = new System.Windows.Forms.DateTimePicker();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdListeReap = new MozartUC.apiButton();
			this.cboLieu = new System.Windows.Forms.ComboBox();
			this.txtObjet = new MozartUC.apiTextBox();
			this.txtDateLivr = new MozartUC.apiTextBox();
			this.cmdDate = new MozartUC.apiButton();
			this.cboTech = new MozartUC.apiCombo();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.lblLabels1 = new MozartUC.apiLabel();
			this.lblLabels6 = new MozartUC.apiLabel();
			this.Frame6 = new MozartUC.apiGroupBox();
			this.CmdFouMultiServ = new MozartUC.apiButton();
			this.cmdFCrown = new MozartUC.apiButton();
			this.cmdFmulti = new MozartUC.apiButton();
			this.cmdFdirickx = new MozartUC.apiButton();
			this.cmdFcfaible = new MozartUC.apiButton();
			this.cmdFClim = new MozartUC.apiButton();
			this.cmdFplomb = new MozartUC.apiButton();
			this.cmdFcfort = new MozartUC.apiButton();
			this.cmdFVis = new MozartUC.apiButton();
			this.cmdFPhotoVolt = new MozartUC.apiButton();
			this.cmdMultiEI = new MozartUC.apiButton();
			this.cmdFEd = new MozartUC.apiButton();
			this.cmdFArgedis = new MozartUC.apiButton();
			this.cmdCFort = new MozartUC.apiButton();
			this.cmdPlomb = new MozartUC.apiButton();
			this.cmdDirickx = new MozartUC.apiButton();
			this.cmdCFaible = new MozartUC.apiButton();
			this.cmdClim = new MozartUC.apiButton();
			this.CmdMulti = new MozartUC.apiButton();
			this.cmdSupp = new MozartUC.apiButton();
			this.cmdRechercher = new MozartUC.apiButton();
			this.grdDataGrid = new MozartUC.apiTGrid();
			this.LblTotalHT = new MozartUC.apiLabel();
			this.frameSearch = new MozartUC.apiGroupBox();
			this.Label1 = new MozartUC.apiLabel();
			this.cmdMul = new MozartUC.apiButton();
			this.Frame6.SuspendLayout();
			this.frameSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// CmdCommandeEMALEC
			// 
			resources.ApplyResources(this.CmdCommandeEMALEC, "CmdCommandeEMALEC");
			this.CmdCommandeEMALEC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCommandeEMALEC.HelpContextID = 551;
			this.CmdCommandeEMALEC.Name = "CmdCommandeEMALEC";
			this.CmdCommandeEMALEC.Tag = "47";
			this.CmdCommandeEMALEC.UseVisualStyleBackColor = true;
			this.CmdCommandeEMALEC.Click += new System.EventHandler(this.CmdCommandeEMALEC_Click);
			// 
			// CmdOutEPI
			// 
			resources.ApplyResources(this.CmdOutEPI, "CmdOutEPI");
			this.CmdOutEPI.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOutEPI.HelpContextID = 0;
			this.CmdOutEPI.Name = "CmdOutEPI";
			this.CmdOutEPI.Tag = "EPI";
			this.CmdOutEPI.UseVisualStyleBackColor = true;
			this.CmdOutEPI.Click += new System.EventHandler(this.CmdOutillage_Click);
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
			// cmdListeReap
			// 
			resources.ApplyResources(this.cmdListeReap, "cmdListeReap");
			this.cmdListeReap.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdListeReap.HelpContextID = 0;
			this.cmdListeReap.Name = "cmdListeReap";
			this.cmdListeReap.Tag = "47";
			this.cmdListeReap.UseVisualStyleBackColor = true;
			this.cmdListeReap.Click += new System.EventHandler(this.cmdListeReap_Click);
			// 
			// cboLieu
			// 
			this.cboLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboLieu, "cboLieu");
			this.cboLieu.Items.AddRange(new object[] {
            resources.GetString("cboLieu.Items"),
            resources.GetString("cboLieu.Items1")});
			this.cboLieu.Name = "cboLieu";
			// 
			// txtObjet
			// 
			resources.ApplyResources(this.txtObjet, "txtObjet");
			this.txtObjet.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtObjet.HelpContextID = 0;
			this.txtObjet.Name = "txtObjet";
			// 
			// txtDateLivr
			// 
			resources.ApplyResources(this.txtDateLivr, "txtDateLivr");
			this.txtDateLivr.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtDateLivr.HelpContextID = 0;
			this.txtDateLivr.Name = "txtDateLivr";
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
			this.cmdDate.Click += new System.EventHandler(this.CmdDate_Click);
			// 
			// cboTech
			// 
			resources.ApplyResources(this.cboTech, "cboTech");
			this.cboTech.Name = "cboTech";
			this.cboTech.NewValues = false;
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels2
			// 
			resources.ApplyResources(this.lblLabels2, "lblLabels2");
			this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels2.HelpContextID = 0;
			this.lblLabels2.Name = "lblLabels2";
			// 
			// lblLabels1
			// 
			resources.ApplyResources(this.lblLabels1, "lblLabels1");
			this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels1.HelpContextID = 0;
			this.lblLabels1.Name = "lblLabels1";
			// 
			// lblLabels6
			// 
			resources.ApplyResources(this.lblLabels6, "lblLabels6");
			this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels6.HelpContextID = 0;
			this.lblLabels6.Name = "lblLabels6";
			// 
			// Frame6
			// 
			resources.ApplyResources(this.Frame6, "Frame6");
			this.Frame6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.Frame6.Controls.Add(this.Cal);
			this.Frame6.Controls.Add(this.cboLieu);
			this.Frame6.Controls.Add(this.txtObjet);
			this.Frame6.Controls.Add(this.txtDateLivr);
			this.Frame6.Controls.Add(this.cmdDate);
			this.Frame6.Controls.Add(this.lblLabels0);
			this.Frame6.Controls.Add(this.lblLabels2);
			this.Frame6.Controls.Add(this.lblLabels1);
			this.Frame6.Controls.Add(this.lblLabels6);
			this.Frame6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.Frame6.FrameColor = System.Drawing.Color.Empty;
			this.Frame6.HelpContextID = 0;
			this.Frame6.Name = "Frame6";
			this.Frame6.TabStop = false;
			// 
			// CmdFouMultiServ
			// 
			resources.ApplyResources(this.CmdFouMultiServ, "CmdFouMultiServ");
			this.CmdFouMultiServ.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdFouMultiServ.HelpContextID = 0;
			this.CmdFouMultiServ.Name = "CmdFouMultiServ";
			this.CmdFouMultiServ.Tag = "MULTISERV_FOU";
			this.CmdFouMultiServ.UseVisualStyleBackColor = true;
			this.CmdFouMultiServ.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdFCrown
			// 
			resources.ApplyResources(this.cmdFCrown, "cmdFCrown");
			this.cmdFCrown.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFCrown.HelpContextID = 0;
			this.cmdFCrown.Name = "cmdFCrown";
			this.cmdFCrown.Tag = "POSTE";
			this.cmdFCrown.UseVisualStyleBackColor = true;
			this.cmdFCrown.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdFmulti
			// 
			resources.ApplyResources(this.cmdFmulti, "cmdFmulti");
			this.cmdFmulti.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFmulti.HelpContextID = 0;
			this.cmdFmulti.Name = "cmdFmulti";
			this.cmdFmulti.Tag = "MULTI";
			this.cmdFmulti.UseVisualStyleBackColor = true;
			this.cmdFmulti.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFdirickx
			// 
			resources.ApplyResources(this.cmdFdirickx, "cmdFdirickx");
			this.cmdFdirickx.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFdirickx.HelpContextID = 0;
			this.cmdFdirickx.Name = "cmdFdirickx";
			this.cmdFdirickx.Tag = "DIRICKX";
			this.cmdFdirickx.UseVisualStyleBackColor = true;
			this.cmdFdirickx.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFcfaible
			// 
			resources.ApplyResources(this.cmdFcfaible, "cmdFcfaible");
			this.cmdFcfaible.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFcfaible.HelpContextID = 0;
			this.cmdFcfaible.Name = "cmdFcfaible";
			this.cmdFcfaible.Tag = "FAIBLE";
			this.cmdFcfaible.UseVisualStyleBackColor = true;
			this.cmdFcfaible.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFClim
			// 
			resources.ApplyResources(this.cmdFClim, "cmdFClim");
			this.cmdFClim.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFClim.HelpContextID = 0;
			this.cmdFClim.Name = "cmdFClim";
			this.cmdFClim.Tag = "CLIM";
			this.cmdFClim.UseVisualStyleBackColor = true;
			this.cmdFClim.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFplomb
			// 
			resources.ApplyResources(this.cmdFplomb, "cmdFplomb");
			this.cmdFplomb.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFplomb.HelpContextID = 0;
			this.cmdFplomb.Name = "cmdFplomb";
			this.cmdFplomb.Tag = "PLOMB";
			this.cmdFplomb.UseVisualStyleBackColor = true;
			this.cmdFplomb.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFcfort
			// 
			resources.ApplyResources(this.cmdFcfort, "cmdFcfort");
			this.cmdFcfort.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFcfort.HelpContextID = 0;
			this.cmdFcfort.Name = "cmdFcfort";
			this.cmdFcfort.Tag = "FORT";
			this.cmdFcfort.UseVisualStyleBackColor = true;
			this.cmdFcfort.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFVis
			// 
			resources.ApplyResources(this.cmdFVis, "cmdFVis");
			this.cmdFVis.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFVis.HelpContextID = 0;
			this.cmdFVis.Name = "cmdFVis";
			this.cmdFVis.Tag = "VIS";
			this.cmdFVis.UseVisualStyleBackColor = true;
			this.cmdFVis.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFPhotoVolt
			// 
			resources.ApplyResources(this.cmdFPhotoVolt, "cmdFPhotoVolt");
			this.cmdFPhotoVolt.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFPhotoVolt.HelpContextID = 0;
			this.cmdFPhotoVolt.Name = "cmdFPhotoVolt";
			this.cmdFPhotoVolt.Tag = "PHOTOVOLT";
			this.cmdFPhotoVolt.UseVisualStyleBackColor = true;
			this.cmdFPhotoVolt.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdMultiEI
			// 
			resources.ApplyResources(this.cmdMultiEI, "cmdMultiEI");
			this.cmdMultiEI.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdMultiEI.HelpContextID = 0;
			this.cmdMultiEI.Name = "cmdMultiEI";
			this.cmdMultiEI.Tag = "MULTIEI";
			this.cmdMultiEI.UseVisualStyleBackColor = true;
			this.cmdMultiEI.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdFEd
			// 
			resources.ApplyResources(this.cmdFEd, "cmdFEd");
			this.cmdFEd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFEd.HelpContextID = 0;
			this.cmdFEd.Name = "cmdFEd";
			this.cmdFEd.Tag = "ED";
			this.cmdFEd.UseVisualStyleBackColor = true;
			this.cmdFEd.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdFArgedis
			// 
			resources.ApplyResources(this.cmdFArgedis, "cmdFArgedis");
			this.cmdFArgedis.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFArgedis.HelpContextID = 0;
			this.cmdFArgedis.Name = "cmdFArgedis";
			this.cmdFArgedis.Tag = "ARGEDIS";
			this.cmdFArgedis.UseVisualStyleBackColor = true;
			this.cmdFArgedis.Click += new System.EventHandler(this.cmdFourniture_Click);
			// 
			// cmdCFort
			// 
			resources.ApplyResources(this.cmdCFort, "cmdCFort");
			this.cmdCFort.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCFort.HelpContextID = 0;
			this.cmdCFort.Name = "cmdCFort";
			this.cmdCFort.Tag = "FORT";
			this.cmdCFort.UseVisualStyleBackColor = true;
			this.cmdCFort.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdPlomb
			// 
			resources.ApplyResources(this.cmdPlomb, "cmdPlomb");
			this.cmdPlomb.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdPlomb.HelpContextID = 0;
			this.cmdPlomb.Name = "cmdPlomb";
			this.cmdPlomb.Tag = "PLOMB";
			this.cmdPlomb.UseVisualStyleBackColor = true;
			this.cmdPlomb.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdDirickx
			// 
			resources.ApplyResources(this.cmdDirickx, "cmdDirickx");
			this.cmdDirickx.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDirickx.HelpContextID = 0;
			this.cmdDirickx.Name = "cmdDirickx";
			this.cmdDirickx.Tag = "DIRICKX";
			this.cmdDirickx.UseVisualStyleBackColor = true;
			this.cmdDirickx.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdCFaible
			// 
			resources.ApplyResources(this.cmdCFaible, "cmdCFaible");
			this.cmdCFaible.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCFaible.HelpContextID = 0;
			this.cmdCFaible.Name = "cmdCFaible";
			this.cmdCFaible.Tag = "FAIBLE";
			this.cmdCFaible.UseVisualStyleBackColor = true;
			this.cmdCFaible.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdClim
			// 
			resources.ApplyResources(this.cmdClim, "cmdClim");
			this.cmdClim.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClim.HelpContextID = 0;
			this.cmdClim.Name = "cmdClim";
			this.cmdClim.Tag = "CLIM";
			this.cmdClim.UseVisualStyleBackColor = true;
			this.cmdClim.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// CmdMulti
			// 
			resources.ApplyResources(this.CmdMulti, "CmdMulti");
			this.CmdMulti.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdMulti.HelpContextID = 0;
			this.CmdMulti.Name = "CmdMulti";
			this.CmdMulti.Tag = "MULTI";
			this.CmdMulti.UseVisualStyleBackColor = true;
			this.CmdMulti.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// cmdSupp
			// 
			resources.ApplyResources(this.cmdSupp, "cmdSupp");
			this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupp.HelpContextID = 0;
			this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
			this.cmdSupp.Name = "cmdSupp";
			this.cmdSupp.Tag = "27";
			this.cmdSupp.UseVisualStyleBackColor = true;
			this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
			// 
			// cmdRechercher
			// 
			resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
			this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRechercher.HelpContextID = 0;
			this.cmdRechercher.Name = "cmdRechercher";
			this.cmdRechercher.UseVisualStyleBackColor = true;
			this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
			// 
			// grdDataGrid
			// 
			resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
			this.grdDataGrid.FilterBar = true;
			this.grdDataGrid.FooterBar = true;
			this.grdDataGrid.ForeColor = System.Drawing.SystemColors.MenuText;
			this.grdDataGrid.Name = "grdDataGrid";
			this.grdDataGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.grdDataGrid_CellValueChanged);
			// 
			// LblTotalHT
			// 
			resources.ApplyResources(this.LblTotalHT, "LblTotalHT");
			this.LblTotalHT.BackColor = System.Drawing.SystemColors.Window;
			this.LblTotalHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LblTotalHT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LblTotalHT.HelpContextID = 0;
			this.LblTotalHT.Name = "LblTotalHT";
			// 
			// frameSearch
			// 
			resources.ApplyResources(this.frameSearch, "frameSearch");
			this.frameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.frameSearch.Controls.Add(this.cmdMul);
			this.frameSearch.Controls.Add(this.LblTotalHT);
			this.frameSearch.Controls.Add(this.CmdOutEPI);
			this.frameSearch.Controls.Add(this.CmdFouMultiServ);
			this.frameSearch.Controls.Add(this.cmdFCrown);
			this.frameSearch.Controls.Add(this.cmdFmulti);
			this.frameSearch.Controls.Add(this.cmdFdirickx);
			this.frameSearch.Controls.Add(this.cmdFcfaible);
			this.frameSearch.Controls.Add(this.cmdFClim);
			this.frameSearch.Controls.Add(this.cmdFplomb);
			this.frameSearch.Controls.Add(this.cmdFcfort);
			this.frameSearch.Controls.Add(this.cmdFVis);
			this.frameSearch.Controls.Add(this.cmdFPhotoVolt);
			this.frameSearch.Controls.Add(this.cmdMultiEI);
			this.frameSearch.Controls.Add(this.cmdFEd);
			this.frameSearch.Controls.Add(this.cmdFArgedis);
			this.frameSearch.Controls.Add(this.cmdCFort);
			this.frameSearch.Controls.Add(this.cmdPlomb);
			this.frameSearch.Controls.Add(this.cmdDirickx);
			this.frameSearch.Controls.Add(this.cmdCFaible);
			this.frameSearch.Controls.Add(this.cmdClim);
			this.frameSearch.Controls.Add(this.CmdMulti);
			this.frameSearch.Controls.Add(this.cmdSupp);
			this.frameSearch.Controls.Add(this.cmdRechercher);
			this.frameSearch.Controls.Add(this.grdDataGrid);
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
			// cmdMul
			// 
			resources.ApplyResources(this.cmdMul, "cmdMul");
			this.cmdMul.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdMul.HelpContextID = 0;
			this.cmdMul.Name = "cmdMul";
			this.cmdMul.Tag = "CHAUFF";
			this.cmdMul.UseVisualStyleBackColor = true;
			this.cmdMul.Click += new System.EventHandler(this.CmdOutillage_Click);
			// 
			// frmStockDdeReappro
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.CmdCommandeEMALEC);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdListeReap);
			this.Controls.Add(this.cboTech);
			this.Controls.Add(this.Frame6);
			this.Controls.Add(this.frameSearch);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmStockDdeReappro";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmStockDdeReappro_Load);
			this.Frame6.ResumeLayout(false);
			this.Frame6.PerformLayout();
			this.frameSearch.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton CmdCommandeEMALEC;
    private MozartUC.apiButton CmdOutEPI;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdListeReap;
    private System.Windows.Forms.ComboBox cboLieu;
    private MozartUC.apiTextBox txtObjet;
    private MozartUC.apiTextBox txtDateLivr;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiCombo cboTech;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox Frame6;
    private MozartUC.apiButton CmdFouMultiServ;
    private MozartUC.apiButton cmdFCrown;
    private MozartUC.apiButton cmdFmulti;
    private MozartUC.apiButton cmdFdirickx;
    private MozartUC.apiButton cmdFcfaible;
    private MozartUC.apiButton cmdFClim;
    private MozartUC.apiButton cmdFplomb;
    private MozartUC.apiButton cmdFcfort;
    private MozartUC.apiButton cmdFVis;
    private MozartUC.apiButton cmdFPhotoVolt;
    private MozartUC.apiButton cmdMultiEI;
    private MozartUC.apiButton cmdFEd;
    private MozartUC.apiButton cmdFArgedis;
    private MozartUC.apiButton cmdCFort;
    private MozartUC.apiButton cmdPlomb;
    private MozartUC.apiButton cmdDirickx;
    private MozartUC.apiButton cmdCFaible;
    private MozartUC.apiButton cmdClim;
    private MozartUC.apiButton CmdMulti;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiLabel LblTotalHT;
    private MozartUC.apiGroupBox frameSearch;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
		private MozartUC.apiButton cmdMul;
	}
}
