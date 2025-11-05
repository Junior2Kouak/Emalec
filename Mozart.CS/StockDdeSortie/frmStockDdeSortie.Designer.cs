namespace MozartCS
{
  partial class frmStockDdeSortie
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockDdeSortie));
      this.cboFicChantierFO = new System.Windows.Forms.ComboBox();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.FrameFicChantier = new MozartUC.apiGroupBox();
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.CmdOutEPI = new MozartUC.apiButton();
      this.cmdOutMult = new MozartUC.apiButton();
      this.cmdClim = new MozartUC.apiButton();
      this.cmdCFaible = new MozartUC.apiButton();
      this.cmdDirickx = new MozartUC.apiButton();
      this.cmdListe = new MozartUC.apiButton();
      this.txtTTC = new MozartUC.apiTextBox();
      this.txtTVA = new MozartUC.apiTextBox();
      this.txtHT = new MozartUC.apiTextBox();
      this.cmdRechercher = new MozartUC.apiButton();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.lblLabels10 = new MozartUC.apiLabel();
      this.lblLabels7 = new MozartUC.apiLabel();
      this.frameSearch = new MozartUC.apiGroupBox();
      this.grdDataGrid = new MozartUC.apiTGrid();
      this.txtCli3 = new MozartUC.apiTextBox();
      this.txtCli2 = new MozartUC.apiTextBox();
      this.txtCli1 = new MozartUC.apiTextBox();
      this.txtCli0 = new MozartUC.apiTextBox();
      this.lblLabels9 = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cboLieu = new System.Windows.Forms.ComboBox();
      this.txtLivr = new MozartUC.apiTextBox();
      this.cmdDate = new MozartUC.apiButton();
      this.txtDateLivr = new MozartUC.apiTextBox();
      this.optDest0 = new System.Windows.Forms.RadioButton();
      this.optDest1 = new System.Windows.Forms.RadioButton();
      this.txtObjet = new MozartUC.apiTextBox();
      this.optDest2 = new System.Windows.Forms.RadioButton();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblDest = new MozartUC.apiLabel();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.Frame6 = new MozartUC.apiGroupBox();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.FrameFicChantier.SuspendLayout();
      this.frameSearch.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame4.SuspendLayout();
      this.Frame6.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboFicChantierFO
      // 
      this.cboFicChantierFO.DisplayMember = "VLIB";
      resources.ApplyResources(this.cboFicChantierFO, "cboFicChantierFO");
      this.cboFicChantierFO.Name = "cboFicChantierFO";
      this.cboFicChantierFO.ValueMember = "NIDFICHE";
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // FrameFicChantier
      // 
      resources.ApplyResources(this.FrameFicChantier, "FrameFicChantier");
      this.FrameFicChantier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.FrameFicChantier.Controls.Add(this.cboFicChantierFO);
      this.FrameFicChantier.Controls.Add(this.lblLabels1);
      this.FrameFicChantier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.FrameFicChantier.HelpContextID = 0;
      this.FrameFicChantier.Name = "FrameFicChantier";
      this.FrameFicChantier.TabStop = false;
      // 
      // Cal
      // 
      this.Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      resources.ApplyResources(this.Cal, "Cal");
      this.Cal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.Cal.Name = "Cal";
      this.Cal.CloseUp += new System.EventHandler(this.Cal_CloseUp);
      this.Cal.ValueChanged += new System.EventHandler(this.Cal_ValueChanged);
      // 
      // CmdOutEPI
      // 
      resources.ApplyResources(this.CmdOutEPI, "CmdOutEPI");
      this.CmdOutEPI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdOutEPI.HelpContextID = 228;
      this.CmdOutEPI.Name = "CmdOutEPI";
      this.CmdOutEPI.Tag = "EPI";
      this.CmdOutEPI.UseVisualStyleBackColor = true;
      this.CmdOutEPI.Click += new System.EventHandler(this.cmdOutillage_Click);
      // 
      // cmdOutMult
      // 
      resources.ApplyResources(this.cmdOutMult, "cmdOutMult");
      this.cmdOutMult.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOutMult.HelpContextID = 228;
      this.cmdOutMult.Name = "cmdOutMult";
      this.cmdOutMult.Tag = "MULTI";
      this.cmdOutMult.UseVisualStyleBackColor = true;
      this.cmdOutMult.Click += new System.EventHandler(this.cmdOutillage_Click);
      // 
      // cmdClim
      // 
      resources.ApplyResources(this.cmdClim, "cmdClim");
      this.cmdClim.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdClim.HelpContextID = 228;
      this.cmdClim.Name = "cmdClim";
      this.cmdClim.Tag = "CLIM";
      this.cmdClim.UseVisualStyleBackColor = true;
      this.cmdClim.Click += new System.EventHandler(this.cmdOutillage_Click);
      // 
      // cmdCFaible
      // 
      resources.ApplyResources(this.cmdCFaible, "cmdCFaible");
      this.cmdCFaible.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCFaible.HelpContextID = 228;
      this.cmdCFaible.Name = "cmdCFaible";
      this.cmdCFaible.Tag = "FAIBLE";
      this.cmdCFaible.UseVisualStyleBackColor = true;
      this.cmdCFaible.Click += new System.EventHandler(this.cmdOutillage_Click);
      // 
      // cmdDirickx
      // 
      resources.ApplyResources(this.cmdDirickx, "cmdDirickx");
      this.cmdDirickx.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDirickx.HelpContextID = 228;
      this.cmdDirickx.Name = "cmdDirickx";
      this.cmdDirickx.Tag = "DIRICKX";
      this.cmdDirickx.UseVisualStyleBackColor = true;
      this.cmdDirickx.Click += new System.EventHandler(this.cmdOutillage_Click);
      // 
      // cmdListe
      // 
      resources.ApplyResources(this.cmdListe, "cmdListe");
      this.cmdListe.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListe.HelpContextID = 228;
      this.cmdListe.Name = "cmdListe";
      this.cmdListe.UseVisualStyleBackColor = true;
      this.cmdListe.Click += new System.EventHandler(this.cmdListe_Click);
      // 
      // txtTTC
      // 
      resources.ApplyResources(this.txtTTC, "txtTTC");
      this.txtTTC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtTTC.HelpContextID = 0;
      this.txtTTC.Name = "txtTTC";
      // 
      // txtTVA
      // 
      resources.ApplyResources(this.txtTVA, "txtTVA");
      this.txtTVA.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtTVA.HelpContextID = 0;
      this.txtTVA.Name = "txtTVA";
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
      // 
      // cmdRechercher
      // 
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.BackColor = System.Drawing.SystemColors.Control;
      this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRechercher.HelpContextID = 0;
      this.cmdRechercher.Image = global::MozartCS.Properties.Resources.Find;
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "26";
      this.cmdRechercher.UseVisualStyleBackColor = false;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // lblLabels12
      // 
      resources.ApplyResources(this.lblLabels12, "lblLabels12");
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.Name = "lblLabels12";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // lblLabels10
      // 
      resources.ApplyResources(this.lblLabels10, "lblLabels10");
      this.lblLabels10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels10.HelpContextID = 0;
      this.lblLabels10.Name = "lblLabels10";
      // 
      // lblLabels7
      // 
      resources.ApplyResources(this.lblLabels7, "lblLabels7");
      this.lblLabels7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels7.HelpContextID = 0;
      this.lblLabels7.Name = "lblLabels7";
      // 
      // frameSearch
      // 
      resources.ApplyResources(this.frameSearch, "frameSearch");
      this.frameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.frameSearch.Controls.Add(this.grdDataGrid);
      this.frameSearch.Controls.Add(this.CmdOutEPI);
      this.frameSearch.Controls.Add(this.cmdOutMult);
      this.frameSearch.Controls.Add(this.cmdClim);
      this.frameSearch.Controls.Add(this.cmdCFaible);
      this.frameSearch.Controls.Add(this.cmdDirickx);
      this.frameSearch.Controls.Add(this.cmdListe);
      this.frameSearch.Controls.Add(this.txtTTC);
      this.frameSearch.Controls.Add(this.txtTVA);
      this.frameSearch.Controls.Add(this.txtHT);
      this.frameSearch.Controls.Add(this.cmdRechercher);
      this.frameSearch.Controls.Add(this.lblLabels12);
      this.frameSearch.Controls.Add(this.lblLabels11);
      this.frameSearch.Controls.Add(this.lblLabels10);
      this.frameSearch.Controls.Add(this.lblLabels7);
      this.frameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.frameSearch.HelpContextID = 0;
      this.frameSearch.Name = "frameSearch";
      this.frameSearch.TabStop = false;
      // 
      // grdDataGrid
      // 
      resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
      this.grdDataGrid.FilterBar = true;
      this.grdDataGrid.FooterBar = true;
      this.grdDataGrid.ForeColor = System.Drawing.SystemColors.WindowText;
      this.grdDataGrid.Name = "grdDataGrid";
      this.grdDataGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.grdDataGrid_CellValueChanged);
      // 
      // txtCli3
      // 
      resources.ApplyResources(this.txtCli3, "txtCli3");
      this.txtCli3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCli3.HelpContextID = 0;
      this.txtCli3.Name = "txtCli3";
      // 
      // txtCli2
      // 
      resources.ApplyResources(this.txtCli2, "txtCli2");
      this.txtCli2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCli2.HelpContextID = 0;
      this.txtCli2.Name = "txtCli2";
      // 
      // txtCli1
      // 
      resources.ApplyResources(this.txtCli1, "txtCli1");
      this.txtCli1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCli1.HelpContextID = 0;
      this.txtCli1.Name = "txtCli1";
      // 
      // txtCli0
      // 
      resources.ApplyResources(this.txtCli0, "txtCli0");
      this.txtCli0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCli0.HelpContextID = 0;
      this.txtCli0.Name = "txtCli0";
      // 
      // lblLabels9
      // 
      resources.ApplyResources(this.lblLabels9, "lblLabels9");
      this.lblLabels9.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels9.HelpContextID = 0;
      this.lblLabels9.Name = "lblLabels9";
      // 
      // lblLabels8
      // 
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.txtCli3);
      this.Frame1.Controls.Add(this.txtCli2);
      this.Frame1.Controls.Add(this.txtCli1);
      this.Frame1.Controls.Add(this.txtCli0);
      this.Frame1.Controls.Add(this.lblLabels9);
      this.Frame1.Controls.Add(this.lblLabels8);
      this.Frame1.Controls.Add(this.lblLabels3);
      this.Frame1.Controls.Add(this.lblLabels4);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cboLieu
      // 
      this.cboLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboLieu, "cboLieu");
      this.cboLieu.Items.AddRange(new object[] {
            resources.GetString("cboLieu.Items")});
      this.cboLieu.Name = "cboLieu";
      // 
      // txtLivr
      // 
      resources.ApplyResources(this.txtLivr, "txtLivr");
      this.txtLivr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtLivr.HelpContextID = 0;
      this.txtLivr.Name = "txtLivr";
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
      // txtDateLivr
      // 
      resources.ApplyResources(this.txtDateLivr, "txtDateLivr");
      this.txtDateLivr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateLivr.HelpContextID = 0;
      this.txtDateLivr.Name = "txtDateLivr";
      // 
      // optDest0
      // 
      this.optDest0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.optDest0, "optDest0");
      this.optDest0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optDest0.Name = "optDest0";
      this.optDest0.UseVisualStyleBackColor = false;
      this.optDest0.CheckedChanged += new System.EventHandler(this.optDest_CheckedChanged);
      // 
      // optDest1
      // 
      this.optDest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.optDest1, "optDest1");
      this.optDest1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optDest1.Name = "optDest1";
      this.optDest1.UseVisualStyleBackColor = false;
      this.optDest1.CheckedChanged += new System.EventHandler(this.optDest_CheckedChanged);
      // 
      // txtObjet
      // 
      resources.ApplyResources(this.txtObjet, "txtObjet");
      this.txtObjet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtObjet.HelpContextID = 0;
      this.txtObjet.Name = "txtObjet";
      // 
      // optDest2
      // 
      this.optDest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.optDest2, "optDest2");
      this.optDest2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.optDest2.Name = "optDest2";
      this.optDest2.UseVisualStyleBackColor = false;
      this.optDest2.CheckedChanged += new System.EventHandler(this.optDest_CheckedChanged);
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // lblDest
      // 
      this.lblDest.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.lblDest, "lblDest");
      this.lblDest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDest.HelpContextID = 0;
      this.lblDest.Name = "lblDest";
      // 
      // lblLabels2
      // 
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame4.Controls.Add(this.cboLieu);
      this.Frame4.Controls.Add(this.Cal);
      this.Frame4.Controls.Add(this.txtLivr);
      this.Frame4.Controls.Add(this.cmdDate);
      this.Frame4.Controls.Add(this.txtDateLivr);
      this.Frame4.Controls.Add(this.optDest0);
      this.Frame4.Controls.Add(this.optDest1);
      this.Frame4.Controls.Add(this.txtObjet);
      this.Frame4.Controls.Add(this.optDest2);
      this.Frame4.Controls.Add(this.lblLabels0);
      this.Frame4.Controls.Add(this.lblLabels6);
      this.Frame4.Controls.Add(this.lblDest);
      this.Frame4.Controls.Add(this.lblLabels2);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Frame6
      // 
      resources.ApplyResources(this.Frame6, "Frame6");
      this.Frame6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame6.Controls.Add(this.Frame4);
      this.Frame6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Frame6.HelpContextID = 0;
      this.Frame6.Name = "Frame6";
      this.Frame6.TabStop = false;
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
      // cmdVisu
      // 
      this.cmdVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmStockDdeSortie
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.FrameFicChantier);
      this.Controls.Add(this.frameSearch);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Frame6);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.Label1);
      this.Name = "frmStockDdeSortie";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockDdeSortie_Load);
      this.FrameFicChantier.ResumeLayout(false);
      this.frameSearch.ResumeLayout(false);
      this.frameSearch.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.Frame6.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboFicChantierFO;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox FrameFicChantier;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton CmdOutEPI;
    private MozartUC.apiButton cmdOutMult;
    private MozartUC.apiButton cmdClim;
    private MozartUC.apiButton cmdCFaible;
    private MozartUC.apiButton cmdDirickx;
    private MozartUC.apiButton cmdListe;
    private MozartUC.apiTextBox txtTTC;
    private MozartUC.apiTextBox txtTVA;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiLabel lblLabels7;
    private MozartUC.apiGroupBox frameSearch;
    private MozartUC.apiTextBox txtCli3;
    private MozartUC.apiTextBox txtCli2;
    private MozartUC.apiTextBox txtCli1;
    private MozartUC.apiTextBox txtCli0;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.ComboBox cboLieu;
    private MozartUC.apiTextBox txtLivr;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiTextBox txtDateLivr;
    private System.Windows.Forms.RadioButton optDest0;
    private System.Windows.Forms.RadioButton optDest1;
    private MozartUC.apiTextBox txtObjet;
    private System.Windows.Forms.RadioButton optDest2;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblDest;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiGroupBox Frame6;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid grdDataGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
