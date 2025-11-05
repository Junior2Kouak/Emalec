namespace MozartCS
{
    partial class frmListeSitesAndEquipementInventaireSelectedByAction
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
            this.GV_ACT_INV_LIST_PARENT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_L0_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_SIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VSITNOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NB_QUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_BSELECTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_EQUIPEMENT_TO_DELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmdQuitter = new MozartUC.apiButton();
            this.Label1 = new MozartUC.apiLabel();
            this.BtnSave = new MozartUC.apiButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotalMontant = new System.Windows.Forms.Label();
            this.LblTotalHeures = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVisuTrameEquipement = new MozartUC.apiButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GC_ACT_INV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ACT_INV_LIST_PARENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_ACT_INV
            // 
            this.GC_ACT_INV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_ACT_INV.Location = new System.Drawing.Point(125, 58);
            this.GC_ACT_INV.MainView = this.GV_ACT_INV_LIST_PARENT;
            this.GC_ACT_INV.Name = "GC_ACT_INV";
            this.GC_ACT_INV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.GC_ACT_INV.Size = new System.Drawing.Size(985, 546);
            this.GC_ACT_INV.TabIndex = 12;
            this.GC_ACT_INV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_ACT_INV_LIST_PARENT});
            // 
            // GV_ACT_INV_LIST_PARENT
            // 
            this.GV_ACT_INV_LIST_PARENT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_L0_NIDEQUIPEMENT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI,
            this.G_Col_L0_NID_EQUIPEMENT_SIT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT,
            this.G_Col_L0_NTYPECONTRAT,
            this.G_Col_L0_VTYPECONTRAT,
            this.G_Col_L0_VSITNOM,
            this.G_Col_L0_VLIBEQUIPEMENT,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT,
            this.G_Col_L0_NB_QUEST,
            this.G_Col_L0_BSELECTED,
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB,
            this.G_Col_L0_NID_EQUIPEMENT_FICHE,
            this.G_Col_L0_EQUIPEMENT_TO_DELETE});
            this.GV_ACT_INV_LIST_PARENT.FooterPanelHeight = 90;
            this.GV_ACT_INV_LIST_PARENT.GridControl = this.GC_ACT_INV;
            this.GV_ACT_INV_LIST_PARENT.Name = "GV_ACT_INV_LIST_PARENT";
            this.GV_ACT_INV_LIST_PARENT.OptionsView.ShowAutoFilterRow = true;
            this.GV_ACT_INV_LIST_PARENT.OptionsView.ShowFooter = true;
            this.GV_ACT_INV_LIST_PARENT.OptionsView.ShowGroupPanel = false;
            this.GV_ACT_INV_LIST_PARENT.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomDrawCell);
            this.GV_ACT_INV_LIST_PARENT.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomDrawFooterCell);
            this.GV_ACT_INV_LIST_PARENT.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GV_ACT_INV_LIST_PARENT_RowCellStyle);
            this.GV_ACT_INV_LIST_PARENT.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GV_ACT_INV_LIST_PARENT_RowStyle);
            this.GV_ACT_INV_LIST_PARENT.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomRowCellEdit);
            this.GV_ACT_INV_LIST_PARENT.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomRowCellEditForEditing);
            this.GV_ACT_INV_LIST_PARENT.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomSummaryCalculate);
            this.GV_ACT_INV_LIST_PARENT.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.GV_ACT_INV_LIST_PARENT_ShowingEditor);
            this.GV_ACT_INV_LIST_PARENT.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GV_ACT_INV_LIST_PARENT_CellValueChanged);
            this.GV_ACT_INV_LIST_PARENT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_ACT_INV_LIST_PARENT_MouseDown);
            // 
            // G_Col_L0_NIDEQUIPEMENT
            // 
            this.G_Col_L0_NIDEQUIPEMENT.Caption = "NIDEQUIPEMENT";
            this.G_Col_L0_NIDEQUIPEMENT.FieldName = "NIDEQUIPEMENT";
            this.G_Col_L0_NIDEQUIPEMENT.Name = "G_Col_L0_NIDEQUIPEMENT";
            // 
            // G_Col_L0_NID_EQUIPEMENT_CLI
            // 
            this.G_Col_L0_NID_EQUIPEMENT_CLI.Caption = "NID_EQUIPEMENT_CLI";
            this.G_Col_L0_NID_EQUIPEMENT_CLI.FieldName = "NID_EQUIPEMENT_CLI";
            this.G_Col_L0_NID_EQUIPEMENT_CLI.Name = "G_Col_L0_NID_EQUIPEMENT_CLI";
            // 
            // G_Col_L0_NID_EQUIPEMENT_SIT
            // 
            this.G_Col_L0_NID_EQUIPEMENT_SIT.Caption = "NID_EQUIPEMENT_SIT";
            this.G_Col_L0_NID_EQUIPEMENT_SIT.FieldName = "NID_EQUIPEMENT_SIT";
            this.G_Col_L0_NID_EQUIPEMENT_SIT.Name = "G_Col_L0_NID_EQUIPEMENT_SIT";
            // 
            // G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT
            // 
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT.Caption = "NID_EQUIPEMENT_CLI_CONTRAT";
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT.FieldName = "NID_EQUIPEMENT_CLI_CONTRAT";
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT.Name = "G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT";
            // 
            // G_Col_L0_NTYPECONTRAT
            // 
            this.G_Col_L0_NTYPECONTRAT.Caption = "NTYPECONTRAT";
            this.G_Col_L0_NTYPECONTRAT.FieldName = "NTYPECONTRAT";
            this.G_Col_L0_NTYPECONTRAT.Name = "G_Col_L0_NTYPECONTRAT";
            // 
            // G_Col_L0_VTYPECONTRAT
            // 
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_VTYPECONTRAT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_VTYPECONTRAT.Caption = "Contrat";
            this.G_Col_L0_VTYPECONTRAT.FieldName = "VTYPECONTRAT";
            this.G_Col_L0_VTYPECONTRAT.Name = "G_Col_L0_VTYPECONTRAT";
            this.G_Col_L0_VTYPECONTRAT.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VTYPECONTRAT.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VTYPECONTRAT.Visible = true;
            this.G_Col_L0_VTYPECONTRAT.VisibleIndex = 0;
            // 
            // G_Col_L0_VSITNOM
            // 
            this.G_Col_L0_VSITNOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_VSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_VSITNOM.Caption = "Site";
            this.G_Col_L0_VSITNOM.FieldName = "VSITNOM";
            this.G_Col_L0_VSITNOM.Name = "G_Col_L0_VSITNOM";
            this.G_Col_L0_VSITNOM.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VSITNOM.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VSITNOM.Visible = true;
            this.G_Col_L0_VSITNOM.VisibleIndex = 1;
            // 
            // G_Col_L0_VLIBEQUIPEMENT
            // 
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_VLIBEQUIPEMENT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_VLIBEQUIPEMENT.Caption = "Equipement";
            this.G_Col_L0_VLIBEQUIPEMENT.FieldName = "VLIBEQUIPEMENT";
            this.G_Col_L0_VLIBEQUIPEMENT.Name = "G_Col_L0_VLIBEQUIPEMENT";
            this.G_Col_L0_VLIBEQUIPEMENT.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VLIBEQUIPEMENT.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VLIBEQUIPEMENT.Visible = true;
            this.G_Col_L0_VLIBEQUIPEMENT.VisibleIndex = 2;
            // 
            // G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE
            // 
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.Caption = "Nb heures";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.DisplayFormat.FormatString = "n2";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.FieldName = "NEQUIPEMENT_SIT_CONTRAT_DUREE";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.Name = "G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NEQUIPEMENT_SIT_CONTRAT_DUREE", "Total hr select={0:n2}")});
            // 
            // G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT
            // 
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.Caption = "Montant";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.DisplayFormat.FormatString = "c2";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.FieldName = "NEQUIPEMENT_SIT_CONTRAT_MONTANT";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.Name = "G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT";
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NEQUIPEMENT_SIT_CONTRAT_MONTANT", "Total mtt select={0:c2}")});
            // 
            // G_Col_L0_NB_QUEST
            // 
            this.G_Col_L0_NB_QUEST.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_NB_QUEST.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_NB_QUEST.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_NB_QUEST.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_NB_QUEST.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_NB_QUEST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_NB_QUEST.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_NB_QUEST.Caption = "Nb Champs à remplir";
            this.G_Col_L0_NB_QUEST.FieldName = "NB_QUEST";
            this.G_Col_L0_NB_QUEST.Name = "G_Col_L0_NB_QUEST";
            this.G_Col_L0_NB_QUEST.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_NB_QUEST.OptionsColumn.ReadOnly = true;
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
            this.G_Col_L0_BSELECTED.Caption = "Sélection";
            this.G_Col_L0_BSELECTED.FieldName = "BSELECTED";
            this.G_Col_L0_BSELECTED.Name = "G_Col_L0_BSELECTED";
            this.G_Col_L0_BSELECTED.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BSELECTED", "Total sélectionné = {0:n0}"),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.G_Col_L0_BSELECTED.Visible = true;
            this.G_Col_L0_BSELECTED.VisibleIndex = 4;
            // 
            // G_Col_L0_VEQUIPEMENT_FICHE_LIB
            // 
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.Caption = "N° Fiche";
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.FieldName = "VEQUIPEMENT_FICHE_LIB";
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.Name = "G_Col_L0_VEQUIPEMENT_FICHE_LIB";
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.Visible = true;
            this.G_Col_L0_VEQUIPEMENT_FICHE_LIB.VisibleIndex = 3;
            // 
            // G_Col_L0_NID_EQUIPEMENT_FICHE
            // 
            this.G_Col_L0_NID_EQUIPEMENT_FICHE.Caption = "NID_EQUIPEMENT_FICHE";
            this.G_Col_L0_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_Col_L0_NID_EQUIPEMENT_FICHE.Name = "G_Col_L0_NID_EQUIPEMENT_FICHE";
            // 
            // G_Col_L0_EQUIPEMENT_TO_DELETE
            // 
            this.G_Col_L0_EQUIPEMENT_TO_DELETE.Caption = "EQUIPEMENT_TO_DELETE";
            this.G_Col_L0_EQUIPEMENT_TO_DELETE.FieldName = "EQUIPEMENT_TO_DELETE";
            this.G_Col_L0_EQUIPEMENT_TO_DELETE.Name = "G_Col_L0_EQUIPEMENT_TO_DELETE";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemTextEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit1.AppearanceReadOnly.BackColor = System.Drawing.Color.Red;
            this.repositoryItemTextEdit1.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.repositoryItemTextEdit1.AppearanceReadOnly.Options.UseBackColor = true;
            this.repositoryItemTextEdit1.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemTextEdit1.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTextEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemTextEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
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
            this.cmdQuitter.Location = new System.Drawing.Point(12, 551);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 53);
            this.cmdQuitter.TabIndex = 7;
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
            this.Label1.Location = new System.Drawing.Point(123, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(792, 24);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Liste des équipements affectés avec une programmation des Hr et Montant du site :" +
    " ";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSave.HelpContextID = 0;
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(12, 58);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 53);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Tag = "15";
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LblTotalMontant);
            this.groupBox1.Controls.Add(this.LblTotalHeures);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1141, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total heures et montant";
            // 
            // LblTotalMontant
            // 
            this.LblTotalMontant.BackColor = System.Drawing.Color.White;
            this.LblTotalMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalMontant.Location = new System.Drawing.Point(114, 100);
            this.LblTotalMontant.Name = "LblTotalMontant";
            this.LblTotalMontant.Size = new System.Drawing.Size(85, 20);
            this.LblTotalMontant.TabIndex = 3;
            this.LblTotalMontant.Text = "0";
            this.LblTotalMontant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalHeures
            // 
            this.LblTotalHeures.BackColor = System.Drawing.Color.White;
            this.LblTotalHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalHeures.Location = new System.Drawing.Point(114, 36);
            this.LblTotalHeures.Name = "LblTotalHeures";
            this.LblTotalHeures.Size = new System.Drawing.Size(85, 20);
            this.LblTotalHeures.TabIndex = 2;
            this.LblTotalHeures.Text = "0";
            this.LblTotalHeures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nb Montant total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nb heures total :";
            // 
            // BtnVisuTrameEquipement
            // 
            this.BtnVisuTrameEquipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVisuTrameEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnVisuTrameEquipement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVisuTrameEquipement.HelpContextID = 0;
            this.BtnVisuTrameEquipement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnVisuTrameEquipement.Location = new System.Drawing.Point(12, 157);
            this.BtnVisuTrameEquipement.Name = "BtnVisuTrameEquipement";
            this.BtnVisuTrameEquipement.Size = new System.Drawing.Size(94, 53);
            this.BtnVisuTrameEquipement.TabIndex = 14;
            this.BtnVisuTrameEquipement.Tag = "15";
            this.BtnVisuTrameEquipement.Text = "Voir la trame";
            this.BtnVisuTrameEquipement.UseVisualStyleBackColor = false;
            this.BtnVisuTrameEquipement.Click += new System.EventHandler(this.BtnVisuTrameEquipement_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Equipement à supprimer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(922, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 43);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Légende";
            // 
            // frmListeSitesAndEquipementInventaireSelectedByAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(1476, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnVisuTrameEquipement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GC_ACT_INV);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.Label1);
            this.Name = "frmListeSitesAndEquipementInventaireSelectedByAction";
            this.Text = "Liste des équipements affectés avec une programmation des Hr et Montant du site :" +
    " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListeSitesAndEquipementInventaireSelectedByAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_ACT_INV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ACT_INV_LIST_PARENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MozartUC.apiButton cmdQuitter;
        private MozartUC.apiLabel Label1;
        private MozartUC.apiButton BtnSave;
        private DevExpress.XtraGrid.GridControl GC_ACT_INV;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_ACT_INV_LIST_PARENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_SIT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VSITNOM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VLIBEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_BSELECTED;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NB_QUEST;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTotalHeures;
        private System.Windows.Forms.Label LblTotalMontant;
        private MozartUC.apiButton BtnVisuTrameEquipement;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VEQUIPEMENT_FICHE_LIB;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_EQUIPEMENT_TO_DELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}