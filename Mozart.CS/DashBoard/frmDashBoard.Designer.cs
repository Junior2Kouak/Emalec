
namespace MozartCS
{
    partial class frmDashBoard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
			this.fraCriteres = new MozartUC.apiGroupBox();
			this.cbCritChaff = new MozartUC.apiCombo();
			this.cbCritClient = new MozartUC.apiCombo();
			this.txtCritcompte = new MozartUC.apiTextBox();
			this.cmdFind = new MozartUC.apiButton();
			this.Label29 = new MozartUC.apiLabel();
			this.Label13 = new MozartUC.apiLabel();
			this.lblNumSite = new MozartUC.apiLabel();
			this.GrpOpe = new System.Windows.Forms.GroupBox();
			this.cmdExcelOpe = new MozartUC.apiButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtObjOpe = new System.Windows.Forms.TextBox();
			this.GCOpe = new DevExpress.XtraGrid.GridControl();
			this.GVOPE = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.G_Col_Ope_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
			this.G_Col_Ope_CETACOD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.G_Col_Ope_NB = new DevExpress.XtraGrid.Columns.GridColumn();
			this.G_Col_Ope_DATE_OLD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.G_Col_Ope_Tendance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GrpFact = new System.Windows.Forms.GroupBox();
			this.cmdExcelFact = new MozartUC.apiButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtObjFact = new System.Windows.Forms.TextBox();
			this.GCFact = new DevExpress.XtraGrid.GridControl();
			this.GVFAC = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmdExcelRavel = new MozartUC.apiButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtObjRAVEL = new System.Windows.Forms.TextBox();
			this.GCRAVEL = new DevExpress.XtraGrid.GridControl();
			this.GVRAVEL = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cmdExcelQSE = new MozartUC.apiButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtObjQSE = new System.Windows.Forms.TextBox();
			this.GCQSE = new DevExpress.XtraGrid.GridControl();
			this.GVQSE = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BtnAide = new MozartUC.apiButton();
			this.cmdQuitter = new MozartUC.apiButton();
			this.sFD = new System.Windows.Forms.SaveFileDialog();
			this.cmdPrint = new MozartUC.apiButton();
			this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
			this.docToPrint = new System.Drawing.Printing.PrintDocument();
			this.fraCriteres.SuspendLayout();
			this.GrpOpe.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCOpe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GVOPE)).BeginInit();
			this.GrpFact.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCFact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GVFAC)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCRAVEL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GVRAVEL)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCQSE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GVQSE)).BeginInit();
			this.SuspendLayout();
			// 
			// fraCriteres
			// 
			this.fraCriteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
			this.fraCriteres.Controls.Add(this.cbCritChaff);
			this.fraCriteres.Controls.Add(this.cbCritClient);
			this.fraCriteres.Controls.Add(this.txtCritcompte);
			this.fraCriteres.Controls.Add(this.cmdFind);
			this.fraCriteres.Controls.Add(this.Label29);
			this.fraCriteres.Controls.Add(this.Label13);
			this.fraCriteres.Controls.Add(this.lblNumSite);
			this.fraCriteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.fraCriteres.FrameColor = System.Drawing.Color.Empty;
			this.fraCriteres.HelpContextID = 0;
			this.fraCriteres.Location = new System.Drawing.Point(12, 12);
			this.fraCriteres.Name = "fraCriteres";
			this.fraCriteres.Size = new System.Drawing.Size(842, 49);
			this.fraCriteres.TabIndex = 15;
			this.fraCriteres.TabStop = false;
			// 
			// cbCritChaff
			// 
			this.cbCritChaff.Location = new System.Drawing.Point(53, 13);
			this.cbCritChaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbCritChaff.Name = "cbCritChaff";
			this.cbCritChaff.NewValues = false;
			this.cbCritChaff.Size = new System.Drawing.Size(191, 25);
			this.cbCritChaff.TabIndex = 69;
			// 
			// cbCritClient
			// 
			this.cbCritClient.Location = new System.Drawing.Point(314, 13);
			this.cbCritClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbCritClient.Name = "cbCritClient";
			this.cbCritClient.NewValues = false;
			this.cbCritClient.Size = new System.Drawing.Size(281, 25);
			this.cbCritClient.TabIndex = 68;
			// 
			// txtCritcompte
			// 
			this.txtCritcompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.txtCritcompte.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCritcompte.HelpContextID = 0;
			this.txtCritcompte.Location = new System.Drawing.Point(689, 15);
			this.txtCritcompte.Name = "txtCritcompte";
			this.txtCritcompte.Size = new System.Drawing.Size(65, 20);
			this.txtCritcompte.TabIndex = 5;
			// 
			// cmdFind
			// 
			this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFind.HelpContextID = 0;
			this.cmdFind.Image = ((System.Drawing.Image)(resources.GetObject("cmdFind.Image")));
			this.cmdFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdFind.Location = new System.Drawing.Point(784, 10);
			this.cmdFind.Name = "cmdFind";
			this.cmdFind.Size = new System.Drawing.Size(52, 35);
			this.cmdFind.TabIndex = 8;
			this.cmdFind.Tag = "8";
			this.cmdFind.UseVisualStyleBackColor = true;
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
			// 
			// Label29
			// 
			this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.Label29.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label29.HelpContextID = 0;
			this.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label29.Location = new System.Drawing.Point(6, 18);
			this.Label29.Name = "Label29";
			this.Label29.Size = new System.Drawing.Size(40, 15);
			this.Label29.TabIndex = 67;
			this.Label29.Text = "Chaff";
			// 
			// Label13
			// 
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.HelpContextID = 0;
			this.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label13.Location = new System.Drawing.Point(265, 18);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(42, 18);
			this.Label13.TabIndex = 19;
			this.Label13.Text = "Client";
			// 
			// lblNumSite
			// 
			this.lblNumSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.lblNumSite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumSite.HelpContextID = 0;
			this.lblNumSite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblNumSite.Location = new System.Drawing.Point(631, 18);
			this.lblNumSite.Name = "lblNumSite";
			this.lblNumSite.Size = new System.Drawing.Size(52, 18);
			this.lblNumSite.TabIndex = 18;
			this.lblNumSite.Text = "Compte";
			// 
			// GrpOpe
			// 
			this.GrpOpe.BackColor = System.Drawing.Color.PeachPuff;
			this.GrpOpe.Controls.Add(this.cmdExcelOpe);
			this.GrpOpe.Controls.Add(this.groupBox1);
			this.GrpOpe.Controls.Add(this.GCOpe);
			this.GrpOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrpOpe.Location = new System.Drawing.Point(12, 67);
			this.GrpOpe.Name = "GrpOpe";
			this.GrpOpe.Size = new System.Drawing.Size(1264, 250);
			this.GrpOpe.TabIndex = 16;
			this.GrpOpe.TabStop = false;
			this.GrpOpe.Text = "Opérationnel :";
			// 
			// cmdExcelOpe
			// 
			this.cmdExcelOpe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcelOpe.BackgroundImage = global::MozartCS.Properties.Resources.xls;
			this.cmdExcelOpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdExcelOpe.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExcelOpe.HelpContextID = 0;
			this.cmdExcelOpe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdExcelOpe.Location = new System.Drawing.Point(760, 201);
			this.cmdExcelOpe.Name = "cmdExcelOpe";
			this.cmdExcelOpe.Size = new System.Drawing.Size(39, 39);
			this.cmdExcelOpe.TabIndex = 21;
			this.cmdExcelOpe.Tag = "1";
			this.cmdExcelOpe.UseVisualStyleBackColor = true;
			this.cmdExcelOpe.Click += new System.EventHandler(this.apiButton1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtObjOpe);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(810, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(446, 176);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Objectifs opérationnels :";
			// 
			// txtObjOpe
			// 
			this.txtObjOpe.BackColor = System.Drawing.Color.PeachPuff;
			this.txtObjOpe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtObjOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObjOpe.Location = new System.Drawing.Point(17, 19);
			this.txtObjOpe.Multiline = true;
			this.txtObjOpe.Name = "txtObjOpe";
			this.txtObjOpe.ReadOnly = true;
			this.txtObjOpe.Size = new System.Drawing.Size(423, 151);
			this.txtObjOpe.TabIndex = 0;
			// 
			// GCOpe
			// 
			this.GCOpe.Location = new System.Drawing.Point(9, 19);
			this.GCOpe.MainView = this.GVOPE;
			this.GCOpe.Name = "GCOpe";
			this.GCOpe.Size = new System.Drawing.Size(745, 221);
			this.GCOpe.TabIndex = 0;
			this.GCOpe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVOPE});
			// 
			// GVOPE
			// 
			this.GVOPE.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.GVOPE.Appearance.HeaderPanel.Options.UseFont = true;
			this.GVOPE.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.GVOPE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GVOPE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_Ope_LIB,
            this.G_Col_Ope_CETACOD,
            this.G_Col_Ope_NB,
            this.G_Col_Ope_DATE_OLD,
            this.G_Col_Ope_Tendance});
			this.GVOPE.GridControl = this.GCOpe;
			this.GVOPE.Name = "GVOPE";
			this.GVOPE.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.GVOPE.OptionsView.ShowGroupPanel = false;
			this.GVOPE.OptionsView.ShowIndicator = false;
			this.GVOPE.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GV_RowCellClick);
			this.GVOPE.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_CustomDrawCell);
			this.GVOPE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseMove);
			// 
			// G_Col_Ope_LIB
			// 
			this.G_Col_Ope_LIB.AppearanceHeader.BackColor = System.Drawing.Color.DarkOrange;
			this.G_Col_Ope_LIB.AppearanceHeader.Options.UseBackColor = true;
			this.G_Col_Ope_LIB.Caption = "Données";
			this.G_Col_Ope_LIB.FieldName = "LIB";
			this.G_Col_Ope_LIB.Name = "G_Col_Ope_LIB";
			this.G_Col_Ope_LIB.OptionsColumn.AllowEdit = false;
			this.G_Col_Ope_LIB.OptionsColumn.AllowFocus = false;
			this.G_Col_Ope_LIB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.G_Col_Ope_LIB.OptionsFilter.AllowFilter = false;
			this.G_Col_Ope_LIB.Visible = true;
			this.G_Col_Ope_LIB.VisibleIndex = 0;
			this.G_Col_Ope_LIB.Width = 300;
			// 
			// G_Col_Ope_CETACOD
			// 
			this.G_Col_Ope_CETACOD.AppearanceCell.Options.UseTextOptions = true;
			this.G_Col_Ope_CETACOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.G_Col_Ope_CETACOD.AppearanceHeader.BackColor = System.Drawing.Color.DarkOrange;
			this.G_Col_Ope_CETACOD.AppearanceHeader.Options.UseBackColor = true;
			this.G_Col_Ope_CETACOD.Caption = "Etat de l\'action";
			this.G_Col_Ope_CETACOD.FieldName = "PARA";
			this.G_Col_Ope_CETACOD.Name = "G_Col_Ope_CETACOD";
			this.G_Col_Ope_CETACOD.OptionsColumn.AllowEdit = false;
			this.G_Col_Ope_CETACOD.OptionsColumn.AllowFocus = false;
			this.G_Col_Ope_CETACOD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.G_Col_Ope_CETACOD.OptionsFilter.AllowFilter = false;
			this.G_Col_Ope_CETACOD.Visible = true;
			this.G_Col_Ope_CETACOD.VisibleIndex = 1;
			this.G_Col_Ope_CETACOD.Width = 110;
			// 
			// G_Col_Ope_NB
			// 
			this.G_Col_Ope_NB.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
			this.G_Col_Ope_NB.AppearanceCell.Options.UseForeColor = true;
			this.G_Col_Ope_NB.AppearanceCell.Options.UseTextOptions = true;
			this.G_Col_Ope_NB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.G_Col_Ope_NB.AppearanceHeader.BackColor = System.Drawing.Color.DarkOrange;
			this.G_Col_Ope_NB.AppearanceHeader.Options.UseBackColor = true;
			this.G_Col_Ope_NB.Caption = "Nombre";
			this.G_Col_Ope_NB.FieldName = "NB";
			this.G_Col_Ope_NB.Name = "G_Col_Ope_NB";
			this.G_Col_Ope_NB.OptionsColumn.AllowEdit = false;
			this.G_Col_Ope_NB.OptionsColumn.AllowFocus = false;
			this.G_Col_Ope_NB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.G_Col_Ope_NB.OptionsFilter.AllowFilter = false;
			this.G_Col_Ope_NB.Visible = true;
			this.G_Col_Ope_NB.VisibleIndex = 2;
			this.G_Col_Ope_NB.Width = 125;
			// 
			// G_Col_Ope_DATE_OLD
			// 
			this.G_Col_Ope_DATE_OLD.AppearanceCell.Options.UseTextOptions = true;
			this.G_Col_Ope_DATE_OLD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.G_Col_Ope_DATE_OLD.AppearanceHeader.BackColor = System.Drawing.Color.DarkOrange;
			this.G_Col_Ope_DATE_OLD.AppearanceHeader.Options.UseBackColor = true;
			this.G_Col_Ope_DATE_OLD.Caption = "Plus ancien";
			this.G_Col_Ope_DATE_OLD.FieldName = "DATEOLD";
			this.G_Col_Ope_DATE_OLD.Name = "G_Col_Ope_DATE_OLD";
			this.G_Col_Ope_DATE_OLD.OptionsColumn.AllowEdit = false;
			this.G_Col_Ope_DATE_OLD.OptionsColumn.AllowFocus = false;
			this.G_Col_Ope_DATE_OLD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.G_Col_Ope_DATE_OLD.OptionsFilter.AllowFilter = false;
			this.G_Col_Ope_DATE_OLD.Visible = true;
			this.G_Col_Ope_DATE_OLD.VisibleIndex = 3;
			this.G_Col_Ope_DATE_OLD.Width = 125;
			// 
			// G_Col_Ope_Tendance
			// 
			this.G_Col_Ope_Tendance.AppearanceCell.Options.UseTextOptions = true;
			this.G_Col_Ope_Tendance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.G_Col_Ope_Tendance.AppearanceHeader.BackColor = System.Drawing.Color.DarkOrange;
			this.G_Col_Ope_Tendance.AppearanceHeader.Options.UseBackColor = true;
			this.G_Col_Ope_Tendance.Caption = "Tendance";
			this.G_Col_Ope_Tendance.FieldName = "TENDANCE";
			this.G_Col_Ope_Tendance.Name = "G_Col_Ope_Tendance";
			this.G_Col_Ope_Tendance.OptionsColumn.AllowEdit = false;
			this.G_Col_Ope_Tendance.OptionsColumn.AllowFocus = false;
			this.G_Col_Ope_Tendance.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.G_Col_Ope_Tendance.OptionsFilter.AllowFilter = false;
			this.G_Col_Ope_Tendance.Visible = true;
			this.G_Col_Ope_Tendance.VisibleIndex = 4;
			this.G_Col_Ope_Tendance.Width = 83;
			// 
			// GrpFact
			// 
			this.GrpFact.BackColor = System.Drawing.Color.LightCyan;
			this.GrpFact.Controls.Add(this.cmdExcelFact);
			this.GrpFact.Controls.Add(this.groupBox2);
			this.GrpFact.Controls.Add(this.GCFact);
			this.GrpFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GrpFact.Location = new System.Drawing.Point(12, 323);
			this.GrpFact.Name = "GrpFact";
			this.GrpFact.Size = new System.Drawing.Size(1264, 228);
			this.GrpFact.TabIndex = 17;
			this.GrpFact.TabStop = false;
			this.GrpFact.Text = "Encours / Facturation :";
			// 
			// cmdExcelFact
			// 
			this.cmdExcelFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcelFact.BackgroundImage = global::MozartCS.Properties.Resources.xls;
			this.cmdExcelFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdExcelFact.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExcelFact.HelpContextID = 0;
			this.cmdExcelFact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdExcelFact.Location = new System.Drawing.Point(760, 180);
			this.cmdExcelFact.Name = "cmdExcelFact";
			this.cmdExcelFact.Size = new System.Drawing.Size(39, 39);
			this.cmdExcelFact.TabIndex = 22;
			this.cmdExcelFact.Tag = "2";
			this.cmdExcelFact.UseVisualStyleBackColor = true;
			this.cmdExcelFact.Click += new System.EventHandler(this.apiButton1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtObjFact);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(810, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(446, 154);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Objectifs facturation :";
			// 
			// txtObjFact
			// 
			this.txtObjFact.BackColor = System.Drawing.Color.LightCyan;
			this.txtObjFact.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtObjFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObjFact.Location = new System.Drawing.Point(17, 19);
			this.txtObjFact.Multiline = true;
			this.txtObjFact.Name = "txtObjFact";
			this.txtObjFact.ReadOnly = true;
			this.txtObjFact.Size = new System.Drawing.Size(423, 125);
			this.txtObjFact.TabIndex = 0;
			// 
			// GCFact
			// 
			this.GCFact.Location = new System.Drawing.Point(9, 18);
			this.GCFact.MainView = this.GVFAC;
			this.GCFact.Name = "GCFact";
			this.GCFact.Size = new System.Drawing.Size(745, 201);
			this.GCFact.TabIndex = 1;
			this.GCFact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVFAC});
			// 
			// GVFAC
			// 
			this.GVFAC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkOrange;
			this.GVFAC.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.GVFAC.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
			this.GVFAC.Appearance.HeaderPanel.Options.UseBackColor = true;
			this.GVFAC.Appearance.HeaderPanel.Options.UseFont = true;
			this.GVFAC.Appearance.HeaderPanel.Options.UseForeColor = true;
			this.GVFAC.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.GVFAC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GVFAC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GVFAC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn16,
            this.gridColumn4,
            this.gridColumn5});
			this.GVFAC.GridControl = this.GCFact;
			this.GVFAC.Name = "GVFAC";
			this.GVFAC.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.GVFAC.OptionsView.ShowGroupPanel = false;
			this.GVFAC.OptionsView.ShowIndicator = false;
			this.GVFAC.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GV_RowCellClick);
			this.GVFAC.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_CustomDrawCell);
			this.GVFAC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseMove);
			// 
			// gridColumn1
			// 
			this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn1.Caption = "Données";
			this.gridColumn1.FieldName = "LIB";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.AllowEdit = false;
			this.gridColumn1.OptionsColumn.AllowFocus = false;
			this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn1.OptionsFilter.AllowFilter = false;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 300;
			// 
			// gridColumn2
			// 
			this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn2.Caption = "Etat de l\'action";
			this.gridColumn2.FieldName = "PARA";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.OptionsColumn.AllowEdit = false;
			this.gridColumn2.OptionsColumn.AllowFocus = false;
			this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn2.OptionsFilter.AllowFilter = false;
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 110;
			// 
			// gridColumn3
			// 
			this.gridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
			this.gridColumn3.AppearanceCell.Options.UseForeColor = true;
			this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn3.Caption = "Nombre";
			this.gridColumn3.FieldName = "NB";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.OptionsColumn.AllowEdit = false;
			this.gridColumn3.OptionsColumn.AllowFocus = false;
			this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn3.OptionsFilter.AllowFilter = false;
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 80;
			// 
			// gridColumn16
			// 
			this.gridColumn16.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn16.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn16.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn16.Caption = "Montant";
			this.gridColumn16.FieldName = "MT";
			this.gridColumn16.Name = "gridColumn16";
			this.gridColumn16.OptionsColumn.AllowEdit = false;
			this.gridColumn16.OptionsColumn.AllowFocus = false;
			this.gridColumn16.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn16.OptionsFilter.AllowFilter = false;
			this.gridColumn16.Visible = true;
			this.gridColumn16.VisibleIndex = 3;
			this.gridColumn16.Width = 80;
			// 
			// gridColumn4
			// 
			this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn4.Caption = "Plus ancien";
			this.gridColumn4.FieldName = "DATEOLD";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.OptionsColumn.AllowEdit = false;
			this.gridColumn4.OptionsColumn.AllowFocus = false;
			this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn4.OptionsFilter.AllowFilter = false;
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 4;
			this.gridColumn4.Width = 90;
			// 
			// gridColumn5
			// 
			this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.DodgerBlue;
			this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn5.Caption = "Tendance";
			this.gridColumn5.FieldName = "TENDANCE";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.OptionsColumn.AllowEdit = false;
			this.gridColumn5.OptionsColumn.AllowFocus = false;
			this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn5.OptionsFilter.AllowFilter = false;
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 5;
			this.gridColumn5.Width = 83;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
			this.groupBox3.Controls.Add(this.cmdExcelRavel);
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.GCRAVEL);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 557);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1264, 119);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "RAVEL :";
			// 
			// cmdExcelRavel
			// 
			this.cmdExcelRavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcelRavel.BackgroundImage = global::MozartCS.Properties.Resources.xls;
			this.cmdExcelRavel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdExcelRavel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExcelRavel.HelpContextID = 0;
			this.cmdExcelRavel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdExcelRavel.Location = new System.Drawing.Point(760, 74);
			this.cmdExcelRavel.Name = "cmdExcelRavel";
			this.cmdExcelRavel.Size = new System.Drawing.Size(39, 39);
			this.cmdExcelRavel.TabIndex = 23;
			this.cmdExcelRavel.Tag = "3";
			this.cmdExcelRavel.UseVisualStyleBackColor = true;
			this.cmdExcelRavel.Click += new System.EventHandler(this.apiButton1_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtObjRAVEL);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(810, 19);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(446, 81);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Objectifs RAVEL :";
			// 
			// txtObjRAVEL
			// 
			this.txtObjRAVEL.BackColor = System.Drawing.Color.Gainsboro;
			this.txtObjRAVEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtObjRAVEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObjRAVEL.Location = new System.Drawing.Point(17, 19);
			this.txtObjRAVEL.Multiline = true;
			this.txtObjRAVEL.Name = "txtObjRAVEL";
			this.txtObjRAVEL.ReadOnly = true;
			this.txtObjRAVEL.Size = new System.Drawing.Size(423, 56);
			this.txtObjRAVEL.TabIndex = 0;
			// 
			// GCRAVEL
			// 
			this.GCRAVEL.Location = new System.Drawing.Point(9, 19);
			this.GCRAVEL.MainView = this.GVRAVEL;
			this.GCRAVEL.Name = "GCRAVEL";
			this.GCRAVEL.Size = new System.Drawing.Size(745, 94);
			this.GCRAVEL.TabIndex = 2;
			this.GCRAVEL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVRAVEL});
			// 
			// GVRAVEL
			// 
			this.GVRAVEL.ActiveFilterEnabled = false;
			this.GVRAVEL.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.GVRAVEL.Appearance.HeaderPanel.Options.UseFont = true;
			this.GVRAVEL.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.GVRAVEL.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GVRAVEL.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GVRAVEL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10});
			this.GVRAVEL.GridControl = this.GCRAVEL;
			this.GVRAVEL.Name = "GVRAVEL";
			this.GVRAVEL.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.GVRAVEL.OptionsView.ShowGroupPanel = false;
			this.GVRAVEL.OptionsView.ShowIndicator = false;
			this.GVRAVEL.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GV_RowCellClick);
			this.GVRAVEL.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_CustomDrawCell);
			this.GVRAVEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseMove);
			// 
			// gridColumn6
			// 
			this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
			this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn6.Caption = "Données";
			this.gridColumn6.FieldName = "LIB";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.OptionsColumn.AllowEdit = false;
			this.gridColumn6.OptionsColumn.AllowFocus = false;
			this.gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn6.OptionsFilter.AllowFilter = false;
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 0;
			this.gridColumn6.Width = 410;
			// 
			// gridColumn8
			// 
			this.gridColumn8.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
			this.gridColumn8.AppearanceCell.Options.UseForeColor = true;
			this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
			this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn8.Caption = "Nombre";
			this.gridColumn8.FieldName = "NB";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.OptionsColumn.AllowEdit = false;
			this.gridColumn8.OptionsColumn.AllowFocus = false;
			this.gridColumn8.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn8.OptionsFilter.AllowFilter = false;
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 1;
			this.gridColumn8.Width = 80;
			// 
			// gridColumn7
			// 
			this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
			this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn7.Caption = "Montant";
			this.gridColumn7.FieldName = "MT";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.OptionsColumn.AllowEdit = false;
			this.gridColumn7.OptionsColumn.AllowFocus = false;
			this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn7.OptionsFilter.AllowFilter = false;
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 2;
			this.gridColumn7.Width = 80;
			// 
			// gridColumn9
			// 
			this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn9.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
			this.gridColumn9.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn9.Caption = "Plus ancien";
			this.gridColumn9.FieldName = "DATEOLD";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.OptionsColumn.AllowEdit = false;
			this.gridColumn9.OptionsColumn.AllowFocus = false;
			this.gridColumn9.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn9.OptionsFilter.AllowFilter = false;
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 3;
			this.gridColumn9.Width = 90;
			// 
			// gridColumn10
			// 
			this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn10.AppearanceHeader.BackColor = System.Drawing.Color.DarkGray;
			this.gridColumn10.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn10.Caption = "Tendance";
			this.gridColumn10.FieldName = "TENDANCE";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.OptionsColumn.AllowEdit = false;
			this.gridColumn10.OptionsColumn.AllowFocus = false;
			this.gridColumn10.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn10.OptionsFilter.AllowFilter = false;
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 4;
			this.gridColumn10.Width = 83;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.LightGreen;
			this.groupBox4.Controls.Add(this.cmdExcelQSE);
			this.groupBox4.Controls.Add(this.groupBox6);
			this.groupBox4.Controls.Add(this.GCQSE);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 682);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1264, 106);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "QSE :";
			// 
			// cmdExcelQSE
			// 
			this.cmdExcelQSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcelQSE.BackgroundImage = global::MozartCS.Properties.Resources.xls;
			this.cmdExcelQSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdExcelQSE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExcelQSE.HelpContextID = 0;
			this.cmdExcelQSE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdExcelQSE.Location = new System.Drawing.Point(760, 55);
			this.cmdExcelQSE.Name = "cmdExcelQSE";
			this.cmdExcelQSE.Size = new System.Drawing.Size(39, 39);
			this.cmdExcelQSE.TabIndex = 23;
			this.cmdExcelQSE.Tag = "4";
			this.cmdExcelQSE.UseVisualStyleBackColor = true;
			this.cmdExcelQSE.Click += new System.EventHandler(this.apiButton1_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.txtObjQSE);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(810, 19);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(446, 81);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Objectifs QSE :";
			// 
			// txtObjQSE
			// 
			this.txtObjQSE.BackColor = System.Drawing.Color.LightGreen;
			this.txtObjQSE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtObjQSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObjQSE.Location = new System.Drawing.Point(17, 19);
			this.txtObjQSE.Multiline = true;
			this.txtObjQSE.Name = "txtObjQSE";
			this.txtObjQSE.ReadOnly = true;
			this.txtObjQSE.Size = new System.Drawing.Size(423, 56);
			this.txtObjQSE.TabIndex = 0;
			// 
			// GCQSE
			// 
			this.GCQSE.Location = new System.Drawing.Point(9, 19);
			this.GCQSE.MainView = this.GVQSE;
			this.GCQSE.Name = "GCQSE";
			this.GCQSE.Size = new System.Drawing.Size(745, 75);
			this.GCQSE.TabIndex = 2;
			this.GCQSE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVQSE});
			// 
			// GVQSE
			// 
			this.GVQSE.ActiveFilterEnabled = false;
			this.GVQSE.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.GVQSE.Appearance.HeaderPanel.Options.UseFont = true;
			this.GVQSE.Appearance.HeaderPanel.Options.UseTextOptions = true;
			this.GVQSE.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.GVQSE.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.GVQSE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
			this.GVQSE.GridControl = this.GCQSE;
			this.GVQSE.Name = "GVQSE";
			this.GVQSE.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.GVQSE.OptionsView.ShowGroupPanel = false;
			this.GVQSE.OptionsView.ShowIndicator = false;
			this.GVQSE.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GV_RowCellClick);
			this.GVQSE.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_CustomDrawCell);
			this.GVQSE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grid_MouseMove);
			// 
			// gridColumn11
			// 
			this.gridColumn11.AppearanceHeader.BackColor = System.Drawing.Color.LimeGreen;
			this.gridColumn11.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn11.Caption = "Données";
			this.gridColumn11.FieldName = "LIB";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.OptionsColumn.AllowEdit = false;
			this.gridColumn11.OptionsColumn.AllowFocus = false;
			this.gridColumn11.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn11.OptionsFilter.AllowFilter = false;
			this.gridColumn11.Visible = true;
			this.gridColumn11.VisibleIndex = 0;
			this.gridColumn11.Width = 410;
			// 
			// gridColumn13
			// 
			this.gridColumn13.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
			this.gridColumn13.AppearanceCell.Options.UseForeColor = true;
			this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn13.AppearanceHeader.BackColor = System.Drawing.Color.LimeGreen;
			this.gridColumn13.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn13.Caption = "Nombre";
			this.gridColumn13.FieldName = "NB";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.OptionsColumn.AllowEdit = false;
			this.gridColumn13.OptionsColumn.AllowFocus = false;
			this.gridColumn13.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn13.OptionsFilter.AllowFilter = false;
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 1;
			this.gridColumn13.Width = 125;
			// 
			// gridColumn14
			// 
			this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn14.AppearanceHeader.BackColor = System.Drawing.Color.LimeGreen;
			this.gridColumn14.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn14.Caption = "Plus ancien";
			this.gridColumn14.FieldName = "DATEOLD";
			this.gridColumn14.Name = "gridColumn14";
			this.gridColumn14.OptionsColumn.AllowEdit = false;
			this.gridColumn14.OptionsColumn.AllowFocus = false;
			this.gridColumn14.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn14.OptionsFilter.AllowFilter = false;
			this.gridColumn14.Visible = true;
			this.gridColumn14.VisibleIndex = 2;
			this.gridColumn14.Width = 125;
			// 
			// gridColumn15
			// 
			this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
			this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.gridColumn15.AppearanceHeader.BackColor = System.Drawing.Color.LimeGreen;
			this.gridColumn15.AppearanceHeader.Options.UseBackColor = true;
			this.gridColumn15.Caption = "Tendance";
			this.gridColumn15.FieldName = "TENDANCE";
			this.gridColumn15.Name = "gridColumn15";
			this.gridColumn15.OptionsColumn.AllowEdit = false;
			this.gridColumn15.OptionsColumn.AllowFocus = false;
			this.gridColumn15.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumn15.OptionsFilter.AllowFilter = false;
			this.gridColumn15.Visible = true;
			this.gridColumn15.VisibleIndex = 3;
			this.gridColumn15.Width = 83;
			// 
			// BtnAide
			// 
			this.BtnAide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAide.BackgroundImage")));
			this.BtnAide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnAide.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnAide.HelpContextID = 0;
			this.BtnAide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BtnAide.Location = new System.Drawing.Point(1032, 12);
			this.BtnAide.Name = "BtnAide";
			this.BtnAide.Size = new System.Drawing.Size(47, 41);
			this.BtnAide.TabIndex = 20;
			this.BtnAide.Tag = "8";
			this.BtnAide.UseVisualStyleBackColor = true;
			this.BtnAide.Click += new System.EventHandler(this.BtnAide_Click);
			// 
			// cmdQuitter
			// 
			this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdQuitter.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdQuitter.Location = new System.Drawing.Point(1191, 12);
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Size = new System.Drawing.Size(85, 40);
			this.cmdQuitter.TabIndex = 21;
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.Text = "Quitter";
			this.cmdQuitter.UseVisualStyleBackColor = false;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// sFD
			// 
			this.sFD.DefaultExt = "xlsx";
			this.sFD.Filter = "Fichiers XLSX |*.xlsx";
			// 
			// cmdPrint
			// 
			this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPrint.BackgroundImage = global::MozartCS.Properties.Resources.printer;
			this.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdPrint.HelpContextID = 0;
			this.cmdPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdPrint.Location = new System.Drawing.Point(1085, 11);
			this.cmdPrint.Name = "cmdPrint";
			this.cmdPrint.Size = new System.Drawing.Size(47, 41);
			this.cmdPrint.TabIndex = 23;
			this.cmdPrint.Tag = "8";
			this.cmdPrint.UseVisualStyleBackColor = true;
			this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
			// 
			// PrintDialog1
			// 
			this.PrintDialog1.UseEXDialog = true;
			// 
			// docToPrint
			// 
			this.docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// frmDashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1285, 802);
			this.Controls.Add(this.cmdPrint);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.BtnAide);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.GrpFact);
			this.Controls.Add(this.GrpOpe);
			this.Controls.Add(this.fraCriteres);
			this.Name = "frmDashBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBoard";
			this.Load += new System.EventHandler(this.frmDashBoard_Load);
			this.fraCriteres.ResumeLayout(false);
			this.fraCriteres.PerformLayout();
			this.GrpOpe.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCOpe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GVOPE)).EndInit();
			this.GrpFact.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCFact)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GVFAC)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCRAVEL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GVRAVEL)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GCQSE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GVQSE)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private MozartUC.apiGroupBox fraCriteres;
        private MozartUC.apiTextBox txtCritcompte;
        private MozartUC.apiButton cmdFind;
        private MozartUC.apiLabel Label29;
        private MozartUC.apiLabel Label13;
        private MozartUC.apiLabel lblNumSite;
        private System.Windows.Forms.GroupBox GrpOpe;
        private System.Windows.Forms.GroupBox GrpFact;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl GCOpe;
        private DevExpress.XtraGrid.Views.Grid.GridView GVOPE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_Ope_LIB;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_Ope_CETACOD;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_Ope_NB;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_Ope_DATE_OLD;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_Ope_Tendance;
        private DevExpress.XtraGrid.GridControl GCFact;
        private DevExpress.XtraGrid.Views.Grid.GridView GVFAC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private MozartUC.apiButton BtnAide;
        private DevExpress.XtraGrid.GridControl GCRAVEL;
        private DevExpress.XtraGrid.Views.Grid.GridView GVRAVEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.GridControl GCQSE;
        private DevExpress.XtraGrid.Views.Grid.GridView GVQSE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObjOpe;
        private MozartUC.apiCombo cbCritClient;
        private MozartUC.apiCombo cbCritChaff;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObjFact;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtObjRAVEL;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtObjQSE;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    private MozartUC.apiButton cmdQuitter;
		private MozartUC.apiButton cmdExcelOpe;
		private System.Windows.Forms.SaveFileDialog sFD;
		private MozartUC.apiButton cmdExcelFact;
		private MozartUC.apiButton cmdExcelRavel;
		private MozartUC.apiButton cmdExcelQSE;
		private MozartUC.apiButton cmdPrint;
		private System.Windows.Forms.PrintDialog PrintDialog1;
		private System.Drawing.Printing.PrintDocument docToPrint;
	}
}