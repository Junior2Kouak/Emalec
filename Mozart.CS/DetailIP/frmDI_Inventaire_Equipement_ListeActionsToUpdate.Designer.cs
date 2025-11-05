namespace MozartCS.DetailIP
{
    partial class frmDI_Inventaire_Equipement_ListeActionsToUpdate
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
            this.GC_ACT_INV = new DevExpress.XtraGrid.GridControl();
            this.GV_ACT_INV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_NACT_INV_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NCLINUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NSITNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NACTNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NACTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_VSITNOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_CETACOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_DACTPLA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_ETAT_EQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_BSELECTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.BtnSave = new MozartUC.apiButton();
            this.cmdQuitter = new MozartUC.apiButton();
            this.Label1 = new MozartUC.apiLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ACT_INV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ACT_INV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_ACT_INV
            // 
            this.GC_ACT_INV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_ACT_INV.Location = new System.Drawing.Point(123, 61);
            this.GC_ACT_INV.MainView = this.GV_ACT_INV;
            this.GC_ACT_INV.Name = "GC_ACT_INV";
            this.GC_ACT_INV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.GC_ACT_INV.Size = new System.Drawing.Size(1290, 538);
            this.GC_ACT_INV.TabIndex = 16;
            this.GC_ACT_INV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_ACT_INV});
            // 
            // GV_ACT_INV
            // 
            this.GV_ACT_INV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_NACT_INV_ID,
            this.G_Col_NCLINUM,
            this.G_Col_NSITNUM,
            this.G_Col_NACTNUM,
            this.G_Col_NACTID,
            this.G_Col_VSITNOM,
            this.G_Col_CETACOD,
            this.G_Col_DACTPLA,
            this.G_Col_VTYPECONTRAT,
            this.G_Col_NTYPECONTRAT,
            this.G_Col_NIDEQUIPEMENT,
            this.G_Col_VLIBEQUIPEMENT,
            this.G_Col_NID_EQUIPEMENT_FICHE,
            this.G_Col_ETAT_EQUIPEMENT,
            this.G_Col_L0_BSELECTED});
            this.GV_ACT_INV.GridControl = this.GC_ACT_INV;
            this.GV_ACT_INV.GroupCount = 1;
            this.GV_ACT_INV.Name = "GV_ACT_INV";
            this.GV_ACT_INV.OptionsView.ShowAutoFilterRow = true;
            this.GV_ACT_INV.OptionsView.ShowFooter = true;
            this.GV_ACT_INV.OptionsView.ShowGroupedColumns = true;
            this.GV_ACT_INV.OptionsView.ShowGroupPanel = false;
            this.GV_ACT_INV.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.G_Col_NACTID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.G_Col_DACTPLA, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.G_Col_CETACOD, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.G_Col_VSITNOM, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.GV_ACT_INV.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_ACT_INV_CustomDrawCell);
            this.GV_ACT_INV.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.GV_ACT_INV_CustomDrawFooterCell);
            this.GV_ACT_INV.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GV_ACT_INV_CustomDrawGroupRow);
            this.GV_ACT_INV.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GV_ACT_INV_RowCellStyle);
            this.GV_ACT_INV.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GV_ACT_INV_CustomSummaryCalculate);
            this.GV_ACT_INV.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.GV_ACT_INV_CustomColumnDisplayText);
            this.GV_ACT_INV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_ACT_INV_MouseDown);
            // 
            // G_Col_NACT_INV_ID
            // 
            this.G_Col_NACT_INV_ID.Caption = "NACT_INV_ID";
            this.G_Col_NACT_INV_ID.FieldName = "NACT_INV_ID";
            this.G_Col_NACT_INV_ID.Name = "G_Col_NACT_INV_ID";
            // 
            // G_Col_NCLINUM
            // 
            this.G_Col_NCLINUM.Caption = "NCLINUM";
            this.G_Col_NCLINUM.FieldName = "NCLINUM";
            this.G_Col_NCLINUM.Name = "G_Col_NCLINUM";
            // 
            // G_Col_NSITNUM
            // 
            this.G_Col_NSITNUM.Caption = "NSITNUM";
            this.G_Col_NSITNUM.FieldName = "NSITNUM";
            this.G_Col_NSITNUM.Name = "G_Col_NSITNUM";
            // 
            // G_Col_NACTNUM
            // 
            this.G_Col_NACTNUM.Caption = "NACTNUM";
            this.G_Col_NACTNUM.FieldName = "NACTNUM";
            this.G_Col_NACTNUM.Name = "G_Col_NACTNUM";
            // 
            // G_Col_NACTID
            // 
            this.G_Col_NACTID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_NACTID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_NACTID.AppearanceHeader.Options.UseFont = true;
            this.G_Col_NACTID.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_NACTID.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_NACTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_NACTID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_NACTID.Caption = "N°";
            this.G_Col_NACTID.FieldName = "NACTID";
            this.G_Col_NACTID.Name = "G_Col_NACTID";
            this.G_Col_NACTID.OptionsColumn.AllowEdit = false;
            this.G_Col_NACTID.OptionsColumn.ReadOnly = true;
            this.G_Col_NACTID.Visible = true;
            this.G_Col_NACTID.VisibleIndex = 0;
            this.G_Col_NACTID.Width = 83;
            // 
            // G_Col_VSITNOM
            // 
            this.G_Col_VSITNOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_VSITNOM.AppearanceHeader.Options.UseFont = true;
            this.G_Col_VSITNOM.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_VSITNOM.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_VSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_VSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_VSITNOM.Caption = "Site";
            this.G_Col_VSITNOM.FieldName = "VSITNOM";
            this.G_Col_VSITNOM.Name = "G_Col_VSITNOM";
            this.G_Col_VSITNOM.OptionsColumn.AllowEdit = false;
            this.G_Col_VSITNOM.OptionsColumn.ReadOnly = true;
            this.G_Col_VSITNOM.Visible = true;
            this.G_Col_VSITNOM.VisibleIndex = 1;
            this.G_Col_VSITNOM.Width = 324;
            // 
            // G_Col_CETACOD
            // 
            this.G_Col_CETACOD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_CETACOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_CETACOD.AppearanceHeader.Options.UseFont = true;
            this.G_Col_CETACOD.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_CETACOD.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_CETACOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_CETACOD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_CETACOD.Caption = "Etat action";
            this.G_Col_CETACOD.FieldName = "CETACOD";
            this.G_Col_CETACOD.Name = "G_Col_CETACOD";
            this.G_Col_CETACOD.OptionsColumn.AllowEdit = false;
            this.G_Col_CETACOD.OptionsColumn.ReadOnly = true;
            this.G_Col_CETACOD.Width = 76;
            // 
            // G_Col_DACTPLA
            // 
            this.G_Col_DACTPLA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_DACTPLA.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_DACTPLA.AppearanceHeader.Options.UseFont = true;
            this.G_Col_DACTPLA.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_DACTPLA.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_DACTPLA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_DACTPLA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_DACTPLA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_DACTPLA.Caption = "Date planification";
            this.G_Col_DACTPLA.FieldName = "DACTPLA";
            this.G_Col_DACTPLA.Name = "G_Col_DACTPLA";
            this.G_Col_DACTPLA.Width = 115;
            // 
            // G_Col_VTYPECONTRAT
            // 
            this.G_Col_VTYPECONTRAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_VTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_VTYPECONTRAT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_VTYPECONTRAT.Caption = "Contrat";
            this.G_Col_VTYPECONTRAT.FieldName = "VTYPECONTRAT";
            this.G_Col_VTYPECONTRAT.Name = "G_Col_VTYPECONTRAT";
            this.G_Col_VTYPECONTRAT.Visible = true;
            this.G_Col_VTYPECONTRAT.VisibleIndex = 2;
            this.G_Col_VTYPECONTRAT.Width = 238;
            // 
            // G_Col_NTYPECONTRAT
            // 
            this.G_Col_NTYPECONTRAT.Caption = "NTYPECONTRAT";
            this.G_Col_NTYPECONTRAT.FieldName = "NTYPECONTRAT";
            this.G_Col_NTYPECONTRAT.Name = "G_Col_NTYPECONTRAT";
            // 
            // G_Col_NIDEQUIPEMENT
            // 
            this.G_Col_NIDEQUIPEMENT.Caption = "NIDEQUIPEMENT";
            this.G_Col_NIDEQUIPEMENT.FieldName = "NIDEQUIPEMENT";
            this.G_Col_NIDEQUIPEMENT.Name = "G_Col_NIDEQUIPEMENT";
            // 
            // G_Col_VLIBEQUIPEMENT
            // 
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_VLIBEQUIPEMENT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_VLIBEQUIPEMENT.Caption = "Equipement";
            this.G_Col_VLIBEQUIPEMENT.FieldName = "VLIBEQUIPEMENT";
            this.G_Col_VLIBEQUIPEMENT.Name = "G_Col_VLIBEQUIPEMENT";
            this.G_Col_VLIBEQUIPEMENT.Visible = true;
            this.G_Col_VLIBEQUIPEMENT.VisibleIndex = 3;
            this.G_Col_VLIBEQUIPEMENT.Width = 277;
            // 
            // G_Col_NID_EQUIPEMENT_FICHE
            // 
            this.G_Col_NID_EQUIPEMENT_FICHE.Caption = "NID_EQUIPEMENT_FICHE";
            this.G_Col_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_Col_NID_EQUIPEMENT_FICHE.Name = "G_Col_NID_EQUIPEMENT_FICHE";
            // 
            // G_Col_ETAT_EQUIPEMENT
            // 
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_ETAT_EQUIPEMENT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_ETAT_EQUIPEMENT.Caption = "Etat de l\'équipement";
            this.G_Col_ETAT_EQUIPEMENT.FieldName = "ETAT_EQUIPEMENT";
            this.G_Col_ETAT_EQUIPEMENT.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.G_Col_ETAT_EQUIPEMENT.Name = "G_Col_ETAT_EQUIPEMENT";
            this.G_Col_ETAT_EQUIPEMENT.OptionsColumn.AllowEdit = false;
            this.G_Col_ETAT_EQUIPEMENT.OptionsColumn.ReadOnly = true;
            this.G_Col_ETAT_EQUIPEMENT.Visible = true;
            this.G_Col_ETAT_EQUIPEMENT.VisibleIndex = 4;
            this.G_Col_ETAT_EQUIPEMENT.Width = 133;
            // 
            // G_Col_L0_BSELECTED
            // 
            this.G_Col_L0_BSELECTED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_BSELECTED.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_BSELECTED.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_BSELECTED.Caption = "A traiter";
            this.G_Col_L0_BSELECTED.ColumnEdit = this.repositoryItemCheckEdit1;
            this.G_Col_L0_BSELECTED.FieldName = "BSELECTED";
            this.G_Col_L0_BSELECTED.Name = "G_Col_L0_BSELECTED";
            this.G_Col_L0_BSELECTED.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BSELECTED", "{0}"),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.G_Col_L0_BSELECTED.Visible = true;
            this.G_Col_L0_BSELECTED.VisibleIndex = 5;
            this.G_Col_L0_BSELECTED.Width = 210;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSave.HelpContextID = 0;
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(12, 61);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 53);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Tag = "15";
            this.BtnSave.Text = "Valider";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdQuitter.HelpContextID = 0;
            this.cmdQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdQuitter.Location = new System.Drawing.Point(10, 546);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 53);
            this.cmdQuitter.TabIndex = 13;
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.Text = "Fermer";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Wheat;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.HelpContextID = 0;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(121, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(754, 24);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Liste des actions avec un inventaire en attente ou planifié (> J+3) à mettre à jo" +
    "ur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(995, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 43);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Légende";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(206, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Equipement à ajouter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Equipement à supprimer";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 0;
            // 
            // frmDI_Inventaire_Equipement_ListeActionsToUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1425, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GC_ACT_INV);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.Label1);
            this.Name = "frmDI_Inventaire_Equipement_ListeActionsToUpdate";
            this.Text = "Liste des actions avec un inventaire en attente ou planifié à mettre à jour";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDI_Inventaire_Equipement_ListeActionsToUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_ACT_INV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ACT_INV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_ACT_INV;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_ACT_INV;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NACTNUM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NACTID;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_VSITNOM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_CETACOD;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_BSELECTED;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private MozartUC.apiButton BtnSave;
        private MozartUC.apiButton cmdQuitter;
        private MozartUC.apiLabel Label1;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NACT_INV_ID;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_DACTPLA;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NCLINUM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NSITNUM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_VLIBEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_ETAT_EQUIPEMENT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}