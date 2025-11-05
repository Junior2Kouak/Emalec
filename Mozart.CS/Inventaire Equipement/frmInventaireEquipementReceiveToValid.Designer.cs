using DevExpress.XtraPivotGrid;

namespace MozartCS.Inventaire_Equipement
{
    partial class frmInventaireEquipementReceiveToValid
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.cmdQuitter = new MozartUC.apiButton();
            this.GCContratEquipement = new DevExpress.XtraGrid.GridControl();
            this.GVContratEquipement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PVTG_Details = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Data_OVALUE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH = new DevExpress.XtraPivotGrid.PivotGridField();
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.BtnSave = new MozartUC.apiButton();
            this.BtnValiderInventaire = new MozartUC.apiButton();
            this.LblTitre = new MozartUC.apiLabel();
            this.ChkVisuEquipExists = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GCContratEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVContratEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVTG_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
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
            this.cmdQuitter.Location = new System.Drawing.Point(12, 603);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 53);
            this.cmdQuitter.TabIndex = 8;
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.Text = "Fermer";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            // 
            // GCContratEquipement
            // 
            this.GCContratEquipement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCContratEquipement.Location = new System.Drawing.Point(122, 55);
            this.GCContratEquipement.MainView = this.GVContratEquipement;
            this.GCContratEquipement.Name = "GCContratEquipement";
            this.GCContratEquipement.Size = new System.Drawing.Size(1790, 280);
            this.GCContratEquipement.TabIndex = 9;
            this.GCContratEquipement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVContratEquipement});
            // 
            // GVContratEquipement
            // 
            this.GVContratEquipement.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVContratEquipement.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GVContratEquipement.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVContratEquipement.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GVContratEquipement.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVContratEquipement.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVContratEquipement.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVContratEquipement.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GVContratEquipement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.GVContratEquipement.GridControl = this.GCContratEquipement;
            this.GVContratEquipement.Name = "GVContratEquipement";
            this.GVContratEquipement.OptionsBehavior.Editable = false;
            this.GVContratEquipement.OptionsBehavior.ReadOnly = true;
            this.GVContratEquipement.OptionsView.ShowAutoFilterRow = true;
            this.GVContratEquipement.OptionsView.ShowFooter = true;
            this.GVContratEquipement.OptionsView.ShowGroupPanel = false;
            this.GVContratEquipement.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.GVContratEquipement_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NTYPECONTRAT";
            this.gridColumn1.FieldName = "NTYPECONTRAT";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Contrat";
            this.gridColumn2.FieldName = "VTYPECONTRAT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 357;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "NIDEQUIPEMENT";
            this.gridColumn3.FieldName = "NIDEQUIPEMENT";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Equipement";
            this.gridColumn4.FieldName = "VLIBEQUIPEMENT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 540;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "NID_EQUIPEMENT_FICHE";
            this.gridColumn5.FieldName = "NID_EQUIPEMENT_FICHE";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "N° Fiche";
            this.gridColumn6.FieldName = "VEQUIPEMENT_FICHE_LIB";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 583;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nombre équipement(s) reçu(s)";
            this.gridColumn7.FieldName = "NB_EQUIPEMENT_RECEIVE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NB_EQUIPEMENT_RECEIVE", "Total = {0:0.##}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 300;
            // 
            // PVTG_Details
            // 
            this.PVTG_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PVTG_Details.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PVTG_Details.Appearance.FieldHeader.Options.UseFont = true;
            this.PVTG_Details.Appearance.FieldHeader.Options.UseTextOptions = true;
            this.PVTG_Details.Appearance.FieldHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PVTG_Details.Appearance.FieldHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PVTG_Details.Appearance.FieldHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PVTG_Details.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PVTG_Details.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.PVTG_Details.Appearance.FieldValue.Options.UseFont = true;
            this.PVTG_Details.Appearance.FieldValue.Options.UseForeColor = true;
            this.PVTG_Details.Appearance.FieldValue.Options.UseTextOptions = true;
            this.PVTG_Details.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PVTG_Details.Appearance.FieldValue.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PVTG_Details.Appearance.FieldValue.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PVTG_Details.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID,
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB,
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP,
            this.PGF_Data_OVALUE,
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT,
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB,
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH,
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER,
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG});
            this.PVTG_Details.Location = new System.Drawing.Point(122, 341);
            this.PVTG_Details.Name = "PVTG_Details";
            this.PVTG_Details.OptionsBehavior.BestFitMode = DevExpress.XtraPivotGrid.PivotGridBestFitMode.FieldHeader;
            this.PVTG_Details.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.PVTG_Details.OptionsView.ShowColumnGrandTotalHeader = false;
            this.PVTG_Details.OptionsView.ShowColumnGrandTotals = false;
            this.PVTG_Details.OptionsView.ShowColumnHeaders = false;
            this.PVTG_Details.OptionsView.ShowColumnTotals = false;
            this.PVTG_Details.OptionsView.ShowDataHeaders = false;
            this.PVTG_Details.OptionsView.ShowFilterHeaders = false;
            this.PVTG_Details.OptionsView.ShowRowGrandTotalHeader = false;
            this.PVTG_Details.OptionsView.ShowRowGrandTotals = false;
            this.PVTG_Details.OptionsView.ShowRowHeaders = false;
            this.PVTG_Details.OptionsView.ShowRowTotals = false;
            this.PVTG_Details.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemCheckEdit2});
            this.PVTG_Details.Size = new System.Drawing.Size(1790, 628);
            this.PVTG_Details.TabIndex = 10;
            this.PVTG_Details.CellClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.PVTG_Details_CellClick);
            this.PVTG_Details.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.PVTG_Details_EditValueChanged);
            this.PVTG_Details.ShownEditor += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellEditEventArgs>(this.PVTG_Details_ShownEditor);
            this.PVTG_Details.CustomCellEdit += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCustomCellEditEventArgs>(this.PVTG_Details_CustomCellEdit);
            // 
            // PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID
            // 
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID.AreaIndex = 0;
            dataSourceColumnBinding1.ColumnName = "NACT_INV_EQUIPEMENT_RECEIVE_ID";
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID.DataBinding = dataSourceColumnBinding1;
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID.Name = "PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID";
            this.PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB
            // 
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.AreaIndex = 1;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.ColumnValueLineCount = 3;
            dataSourceColumnBinding2.ColumnName = "VEQUIPEMENT_FICHE_ITEM_LIB";
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.DataBinding = dataSourceColumnBinding2;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.Name = "PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB";
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.SortBySummaryInfo.Field = this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER
            // 
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.AreaIndex = 2;
            dataSourceColumnBinding3.ColumnName = "NEQUIPEMENT_FICHE_ITEM_ORDER";
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.DataBinding = dataSourceColumnBinding3;
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.Name = "PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER";
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER.Visible = false;
            // 
            // PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP
            // 
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.AreaIndex = 1;
            dataSourceColumnBinding4.ColumnName = "NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.DataBinding = dataSourceColumnBinding4;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.Name = "PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.Visible = false;
            // 
            // PGF_Data_OVALUE
            // 
            this.PGF_Data_OVALUE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.PGF_Data_OVALUE.AreaIndex = 0;
            dataSourceColumnBinding5.ColumnName = "OVALUE";
            this.PGF_Data_OVALUE.DataBinding = dataSourceColumnBinding5;
            this.PGF_Data_OVALUE.Name = "PGF_Data_OVALUE";
            this.PGF_Data_OVALUE.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Data_OVALUE.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT
            // 
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.AreaIndex = 1;
            dataSourceColumnBinding6.ColumnName = "NID_EQUIPEMENT_FICHE_LIST_PARENT";
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.DataBinding = dataSourceColumnBinding6;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.Name = "PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT";
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT.Visible = false;
            // 
            // PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB
            // 
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Cell.Options.UseTextOptions = true;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Cell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Cell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.Options.UseFont = true;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.Options.UseTextOptions = true;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AreaIndex = 0;
            dataSourceColumnBinding7.ColumnName = "VEQUIPEMENT_FICHE_CHAP_LIB";
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.DataBinding = dataSourceColumnBinding7;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Name = "PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB";
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.False;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.AllowEdit = false;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.ReadOnly = true;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.ShowCustomTotals = false;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.ShowGrandTotal = false;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Options.ShowTotals = false;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.SortBySummaryInfo.Field = this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH
            // 
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AreaIndex = 2;
            dataSourceColumnBinding8.ColumnName = "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.DataBinding = dataSourceColumnBinding8;
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Name = "PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value;
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Visible = false;
            // 
            // PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG
            // 
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.AreaIndex = 2;
            dataSourceColumnBinding9.ColumnName = "BEQUIPEMENT_FICHE_ITEM_OBLIG";
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.DataBinding = dataSourceColumnBinding9;
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.Name = "PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG";
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG.Visible = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AllowFocused = false;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.SingleClick = true;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = "1";
            this.repositoryItemCheckEdit2.ValueUnchecked = "0";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSave.HelpContextID = 0;
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(12, 341);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 53);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Tag = "15";
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnValiderInventaire
            // 
            this.BtnValiderInventaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnValiderInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnValiderInventaire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnValiderInventaire.HelpContextID = 0;
            this.BtnValiderInventaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnValiderInventaire.Location = new System.Drawing.Point(12, 55);
            this.BtnValiderInventaire.Name = "BtnValiderInventaire";
            this.BtnValiderInventaire.Size = new System.Drawing.Size(94, 53);
            this.BtnValiderInventaire.TabIndex = 12;
            this.BtnValiderInventaire.Tag = "15";
            this.BtnValiderInventaire.Text = "Valider l\'inventaire";
            this.BtnValiderInventaire.UseVisualStyleBackColor = false;
            this.BtnValiderInventaire.Click += new System.EventHandler(this.BtnValiderInventaire_Click);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.BackColor = System.Drawing.Color.Transparent;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitre.HelpContextID = 0;
            this.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTitre.Location = new System.Drawing.Point(117, 9);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(487, 29);
            this.LblTitre.TabIndex = 16;
            this.LblTitre.Text = "Inventaire - Etat : en attente de validation";
            // 
            // ChkVisuEquipExists
            // 
            this.ChkVisuEquipExists.AutoSize = true;
            this.ChkVisuEquipExists.Location = new System.Drawing.Point(1414, 21);
            this.ChkVisuEquipExists.Name = "ChkVisuEquipExists";
            this.ChkVisuEquipExists.Size = new System.Drawing.Size(209, 17);
            this.ChkVisuEquipExists.TabIndex = 17;
            this.ChkVisuEquipExists.Text = "voir uniquement les équipements reçus";
            this.ChkVisuEquipExists.UseVisualStyleBackColor = true;
            this.ChkVisuEquipExists.CheckedChanged += new System.EventHandler(this.ChkVisuEquipExists_CheckedChanged);
            // 
            // frmInventaireEquipementReceiveToValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 981);
            this.Controls.Add(this.ChkVisuEquipExists);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.BtnValiderInventaire);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.PVTG_Details);
            this.Controls.Add(this.GCContratEquipement);
            this.Controls.Add(this.cmdQuitter);
            this.Name = "frmInventaireEquipementReceiveToValid";
            this.Text = "Détail de l\'inventaire à valider";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventaireEquipementReceiveToValid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCContratEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVContratEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PVTG_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MozartUC.apiButton cmdQuitter;
        private DevExpress.XtraGrid.GridControl GCContratEquipement;
        private DevExpress.XtraGrid.Views.Grid.GridView GVContratEquipement;
        private DevExpress.XtraPivotGrid.PivotGridControl PVTG_Details;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraPivotGrid.PivotGridField PGF_Row_NACT_INV_EQUIPEMENT_RECEIVE_ID;
        private DevExpress.XtraPivotGrid.PivotGridField PGF_Col_VEQUIPEMENT_FICHE_ITEM_LIB;
        private DevExpress.XtraPivotGrid.PivotGridField PGF_Data_NID_EQUIPEMENT_FICHE_TYPE_CHAMP;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private PivotGridField PGF_Data_OVALUE;
        private PivotGridField PGF_Data_NID_EQUIPEMENT_FICHE_LIST_PARENT;
        private PivotGridField PGF_Col_VEQUIPEMENT_FICHE_CHAP_LIB;
        private PivotGridField PGF_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH;
        private PivotGridField PGF_Col_NEQUIPEMENT_FICHE_ITEM_ORDER;
        private PivotGridField PGF_Col_BEQUIPEMENT_FICHE_ITEM_OBLIG;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private MozartUC.apiButton BtnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private MozartUC.apiButton BtnValiderInventaire;
        private MozartUC.apiLabel LblTitre;
        private System.Windows.Forms.CheckBox ChkVisuEquipExists;
    }
}