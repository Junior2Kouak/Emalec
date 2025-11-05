namespace MozartCS
{
  partial class frmChiffrageNF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiffrageNF));
			this.Frame2 = new MozartUC.apiGroupBox();
			this.apiTGridActions = new MozartUC.apiTGrid();
			this.optFour0 = new System.Windows.Forms.RadioButton();
			this.optFour1 = new System.Windows.Forms.RadioButton();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.lblEuro = new MozartUC.apiLabel();
			this.lblLabels9 = new MozartUC.apiLabel();
			this.fraFour = new MozartUC.apiGroupBox();
			this.txtFour = new DevExpress.XtraEditors.TextEdit();
			this.cmdcmd = new MozartUC.apiButton();
			this.cmdRechercher = new MozartUC.apiButton();
			this.apiTGridB = new MozartUC.apiTGrid();
			this.lblLabels5 = new MozartUC.apiLabel();
			this.frameSearch = new MozartUC.apiGroupBox();
			this.txtHT = new DevExpress.XtraEditors.TextEdit();
			this.txtObserv = new MozartUC.apiTextBox();
			this.lblA1 = new MozartUC.apiLabel();
			this.lblA0 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels1 = new MozartUC.apiLabel();
			this.lblLabels10 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.txtNbrDep = new DevExpress.XtraEditors.TextEdit();
			this.txtNbrHeures = new DevExpress.XtraEditors.TextEdit();
			this.txtTauxDep = new DevExpress.XtraEditors.TextEdit();
			this.txtTauxHeures = new DevExpress.XtraEditors.TextEdit();
			this.txtForfait = new DevExpress.XtraEditors.TextEdit();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdEnregistrer = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.apiLabel3 = new MozartUC.apiLabel();
			this.apiLabel4 = new MozartUC.apiLabel();
			this.Frame2.SuspendLayout();
			this.fraFour.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFour.Properties)).BeginInit();
			this.frameSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtHT.Properties)).BeginInit();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNbrDep.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNbrHeures.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTauxDep.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTauxHeures.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForfait.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame2.Controls.Add(this.apiTGridActions);
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// apiTGridActions
			// 
			this.apiTGridActions.FilterBar = true;
			this.apiTGridActions.FooterBar = true;
			resources.ApplyResources(this.apiTGridActions, "apiTGridActions");
			this.apiTGridActions.Name = "apiTGridActions";
			this.apiTGridActions.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apigrid_ClickE);
			// 
			// optFour0
			// 
			this.optFour0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.optFour0.ForeColor = System.Drawing.SystemColors.ControlText;
			resources.ApplyResources(this.optFour0, "optFour0");
			this.optFour0.Name = "optFour0";
			this.optFour0.UseVisualStyleBackColor = false;
			this.optFour0.Click += new System.EventHandler(this.optFournitures_Forfait_Click);
			// 
			// optFour1
			// 
			this.optFour1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.optFour1.Checked = true;
			this.optFour1.ForeColor = System.Drawing.SystemColors.ControlText;
			resources.ApplyResources(this.optFour1, "optFour1");
			this.optFour1.Name = "optFour1";
			this.optFour1.TabStop = true;
			this.optFour1.UseVisualStyleBackColor = false;
			this.optFour1.Click += new System.EventHandler(this.optFournitures_Forfait_Click);
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
			// lblEuro
			// 
			resources.ApplyResources(this.lblEuro, "lblEuro");
			this.lblEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblEuro.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblEuro.HelpContextID = 0;
			this.lblEuro.Name = "lblEuro";
			// 
			// lblLabels9
			// 
			resources.ApplyResources(this.lblLabels9, "lblLabels9");
			this.lblLabels9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels9.HelpContextID = 0;
			this.lblLabels9.Name = "lblLabels9";
			// 
			// fraFour
			// 
			this.fraFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.fraFour.Controls.Add(this.txtFour);
			this.fraFour.Controls.Add(this.optFour0);
			this.fraFour.Controls.Add(this.optFour1);
			this.fraFour.Controls.Add(this.lblLabels2);
			this.fraFour.Controls.Add(this.lblLabels3);
			this.fraFour.Controls.Add(this.lblEuro);
			this.fraFour.Controls.Add(this.lblLabels9);
			this.fraFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fraFour.FrameColor = System.Drawing.Color.Empty;
			this.fraFour.HelpContextID = 0;
			resources.ApplyResources(this.fraFour, "fraFour");
			this.fraFour.Name = "fraFour";
			this.fraFour.TabStop = false;
			// 
			// txtFour
			// 
			resources.ApplyResources(this.txtFour, "txtFour");
			this.txtFour.Name = "txtFour";
			this.txtFour.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtFour.Properties.Appearance.Font")));
			this.txtFour.Properties.Appearance.Options.UseFont = true;
			this.txtFour.Properties.Appearance.Options.UseTextOptions = true;
			this.txtFour.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtFour.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtFour.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtFour.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtFour.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtFour.Properties.MaskSettings.Set("mask", "n2");
			// 
			// cmdcmd
			// 
			resources.ApplyResources(this.cmdcmd, "cmdcmd");
			this.cmdcmd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdcmd.HelpContextID = 0;
			this.cmdcmd.Name = "cmdcmd";
			this.cmdcmd.UseVisualStyleBackColor = true;
			this.cmdcmd.Click += new System.EventHandler(this.cmdcmd_Click);
			// 
			// cmdRechercher
			// 
			this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRechercher.HelpContextID = 0;
			this.cmdRechercher.Image = global::MozartCS.Properties.Resources.Find;
			resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
			this.cmdRechercher.Name = "cmdRechercher";
			this.cmdRechercher.Tag = "26";
			this.cmdRechercher.UseVisualStyleBackColor = true;
			this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
			// 
			// apiTGridB
			// 
			this.apiTGridB.FilterBar = true;
			this.apiTGridB.FooterBar = true;
			resources.ApplyResources(this.apiTGridB, "apiTGridB");
			this.apiTGridB.Name = "apiTGridB";
			this.apiTGridB.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridB_CellValueChanged);
			// 
			// lblLabels5
			// 
			this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels5.HelpContextID = 0;
			resources.ApplyResources(this.lblLabels5, "lblLabels5");
			this.lblLabels5.Name = "lblLabels5";
			// 
			// frameSearch
			// 
			this.frameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.frameSearch.Controls.Add(this.txtHT);
			this.frameSearch.Controls.Add(this.cmdcmd);
			this.frameSearch.Controls.Add(this.cmdRechercher);
			this.frameSearch.Controls.Add(this.apiTGridB);
			this.frameSearch.Controls.Add(this.lblLabels5);
			resources.ApplyResources(this.frameSearch, "frameSearch");
			this.frameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.frameSearch.FrameColor = System.Drawing.Color.Empty;
			this.frameSearch.HelpContextID = 0;
			this.frameSearch.Name = "frameSearch";
			this.frameSearch.TabStop = false;
			// 
			// txtHT
			// 
			resources.ApplyResources(this.txtHT, "txtHT");
			this.txtHT.Name = "txtHT";
			this.txtHT.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtHT.Properties.Appearance.Font")));
			this.txtHT.Properties.Appearance.Options.UseFont = true;
			this.txtHT.Properties.Appearance.Options.UseTextOptions = true;
			this.txtHT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtHT.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtHT.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtHT.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtHT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtHT.Properties.MaskSettings.Set("mask", "n2");
			// 
			// txtObserv
			// 
			this.txtObserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtObserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtObserv.HelpContextID = 0;
			resources.ApplyResources(this.txtObserv, "txtObserv");
			this.txtObserv.Name = "txtObserv";
			// 
			// lblA1
			// 
			resources.ApplyResources(this.lblA1, "lblA1");
			this.lblA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblA1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblA1.HelpContextID = 0;
			this.lblA1.Name = "lblA1";
			// 
			// lblA0
			// 
			resources.ApplyResources(this.lblA0, "lblA0");
			this.lblA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblA0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblA0.HelpContextID = 0;
			this.lblA0.Name = "lblA0";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels1
			// 
			resources.ApplyResources(this.lblLabels1, "lblLabels1");
			this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels1.HelpContextID = 0;
			this.lblLabels1.Name = "lblLabels1";
			// 
			// lblLabels10
			// 
			resources.ApplyResources(this.lblLabels10, "lblLabels10");
			this.lblLabels10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels10.HelpContextID = 0;
			this.lblLabels10.Name = "lblLabels10";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.apiLabel4);
			this.Frame1.Controls.Add(this.apiLabel3);
			this.Frame1.Controls.Add(this.apiLabel2);
			this.Frame1.Controls.Add(this.txtNbrDep);
			this.Frame1.Controls.Add(this.txtNbrHeures);
			this.Frame1.Controls.Add(this.txtTauxDep);
			this.Frame1.Controls.Add(this.txtTauxHeures);
			this.Frame1.Controls.Add(this.txtForfait);
			this.Frame1.Controls.Add(this.apiLabel1);
			this.Frame1.Controls.Add(this.fraFour);
			this.Frame1.Controls.Add(this.frameSearch);
			this.Frame1.Controls.Add(this.txtObserv);
			this.Frame1.Controls.Add(this.lblA1);
			this.Frame1.Controls.Add(this.lblA0);
			this.Frame1.Controls.Add(this.lblLabels0);
			this.Frame1.Controls.Add(this.lblLabels1);
			this.Frame1.Controls.Add(this.lblLabels10);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// txtNbrDep
			// 
			resources.ApplyResources(this.txtNbrDep, "txtNbrDep");
			this.txtNbrDep.Name = "txtNbrDep";
			this.txtNbrDep.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtNbrDep.Properties.Appearance.Font")));
			this.txtNbrDep.Properties.Appearance.Options.UseFont = true;
			this.txtNbrDep.Properties.Appearance.Options.UseTextOptions = true;
			this.txtNbrDep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtNbrDep.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtNbrDep.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtNbrDep.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtNbrDep.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtNbrDep.Properties.MaskSettings.Set("mask", "n0");
			// 
			// txtNbrHeures
			// 
			resources.ApplyResources(this.txtNbrHeures, "txtNbrHeures");
			this.txtNbrHeures.Name = "txtNbrHeures";
			this.txtNbrHeures.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtNbrHeures.Properties.Appearance.Font")));
			this.txtNbrHeures.Properties.Appearance.Options.UseFont = true;
			this.txtNbrHeures.Properties.Appearance.Options.UseTextOptions = true;
			this.txtNbrHeures.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtNbrHeures.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtNbrHeures.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtNbrHeures.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtNbrHeures.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtNbrHeures.Properties.MaskSettings.Set("mask", "n2");
			// 
			// txtTauxDep
			// 
			resources.ApplyResources(this.txtTauxDep, "txtTauxDep");
			this.txtTauxDep.Name = "txtTauxDep";
			this.txtTauxDep.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTauxDep.Properties.Appearance.Font")));
			this.txtTauxDep.Properties.Appearance.Options.UseFont = true;
			this.txtTauxDep.Properties.Appearance.Options.UseTextOptions = true;
			this.txtTauxDep.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtTauxDep.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtTauxDep.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTauxDep.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtTauxDep.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTauxDep.Properties.MaskSettings.Set("mask", "n2");
			// 
			// txtTauxHeures
			// 
			resources.ApplyResources(this.txtTauxHeures, "txtTauxHeures");
			this.txtTauxHeures.Name = "txtTauxHeures";
			this.txtTauxHeures.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTauxHeures.Properties.Appearance.Font")));
			this.txtTauxHeures.Properties.Appearance.Options.UseFont = true;
			this.txtTauxHeures.Properties.Appearance.Options.UseTextOptions = true;
			this.txtTauxHeures.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtTauxHeures.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtTauxHeures.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtTauxHeures.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtTauxHeures.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtTauxHeures.Properties.MaskSettings.Set("mask", "n2");
			// 
			// txtForfait
			// 
			resources.ApplyResources(this.txtForfait, "txtForfait");
			this.txtForfait.Name = "txtForfait";
			this.txtForfait.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtForfait.Properties.Appearance.Font")));
			this.txtForfait.Properties.Appearance.Options.UseFont = true;
			this.txtForfait.Properties.Appearance.Options.UseTextOptions = true;
			this.txtForfait.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtForfait.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.txtForfait.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("txtForfait.Properties.Mask.UseMaskAsDisplayFormat")));
			this.txtForfait.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtForfait.Properties.MaskSettings.Set("mask", "n2");
			// 
			// apiLabel1
			// 
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
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
			// cmdEnregistrer
			// 
			resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
			this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEnregistrer.HelpContextID = 0;
			this.cmdEnregistrer.Name = "cmdEnregistrer";
			this.cmdEnregistrer.Tag = "29";
			this.cmdEnregistrer.UseVisualStyleBackColor = true;
			this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// apiLabel2
			// 
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel2.HelpContextID = 0;
			this.apiLabel2.Name = "apiLabel2";
			// 
			// apiLabel3
			// 
			resources.ApplyResources(this.apiLabel3, "apiLabel3");
			this.apiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.apiLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel3.HelpContextID = 0;
			this.apiLabel3.Name = "apiLabel3";
			// 
			// apiLabel4
			// 
			resources.ApplyResources(this.apiLabel4, "apiLabel4");
			this.apiLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.apiLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel4.HelpContextID = 0;
			this.apiLabel4.Name = "apiLabel4";
			// 
			// frmChiffrageNF
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.cmdEnregistrer);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmChiffrageNF";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmChiffrageNF_Load);
			this.Frame2.ResumeLayout(false);
			this.fraFour.ResumeLayout(false);
			this.fraFour.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFour.Properties)).EndInit();
			this.frameSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtHT.Properties)).EndInit();
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtNbrDep.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNbrHeures.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTauxDep.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTauxHeures.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForfait.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private MozartUC.apiGroupBox Frame2;
    private System.Windows.Forms.RadioButton optFour0;
    private System.Windows.Forms.RadioButton optFour1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblEuro;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiGroupBox fraFour;
    private MozartUC.apiButton cmdcmd;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiGroupBox frameSearch;
    private MozartUC.apiTextBox txtObserv;
    private MozartUC.apiLabel lblA1;
    private MozartUC.apiLabel lblA0;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels10;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGridActions;
		private MozartUC.apiLabel apiLabel1;
		private DevExpress.XtraEditors.TextEdit txtForfait;
		private DevExpress.XtraEditors.TextEdit txtFour;
		private DevExpress.XtraEditors.TextEdit txtNbrDep;
		private DevExpress.XtraEditors.TextEdit txtNbrHeures;
		private DevExpress.XtraEditors.TextEdit txtTauxDep;
		private DevExpress.XtraEditors.TextEdit txtTauxHeures;
		private DevExpress.XtraEditors.TextEdit txtHT;
		private MozartUC.apiLabel apiLabel2;
		private MozartUC.apiLabel apiLabel4;
		private MozartUC.apiLabel apiLabel3;
		// TODO GetCodeDeclareControl cas non traité pour type VB.Line

	}
}
