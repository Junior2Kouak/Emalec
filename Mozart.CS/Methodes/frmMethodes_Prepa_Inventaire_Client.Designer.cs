namespace MozartCS
{
    partial class frmMethodes_Prepa_Inventaire_Client
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.GVEquipement_Prepa_Inv_Client_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L1_Col_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NID_EQUIPEMENT_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_BEQUIPEMENT_SELECTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RItem_BEQUIPEMENT_SELECTED = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.G_L1_Col_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NCLINUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCEquipement_Prepa_Inv_Client = new DevExpress.XtraGrid.GridControl();
            this.GVEquipement_Prepa_Inv_Client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L0_Col_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_BCONTRAT_EXISTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RItem_BCONTRAT_EXISTS = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.G_L0_Col_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NB_EQUIP_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_TreeView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GVEquipement_Prepa_Inv_Client_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_BEQUIPEMENT_SELECTED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCEquipement_Prepa_Inv_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEquipement_Prepa_Inv_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_BCONTRAT_EXISTS)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVEquipement_Prepa_Inv_Client_Detail
            // 
            this.GVEquipement_Prepa_Inv_Client_Detail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVEquipement_Prepa_Inv_Client_Detail.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVEquipement_Prepa_Inv_Client_Detail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVEquipement_Prepa_Inv_Client_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L1_Col_NTYPECONTRAT,
            this.G_L1_Col_NIDEQUIPEMENT,
            this.G_L1_Col_NID_EQUIPEMENT_CLI,
            this.G_L1_Col_BEQUIPEMENT_SELECTED,
            this.G_L1_Col_VLIBEQUIPEMENT,
            this.G_L1_Col_NCLINUM});
            this.GVEquipement_Prepa_Inv_Client_Detail.GridControl = this.GCEquipement_Prepa_Inv_Client;
            this.GVEquipement_Prepa_Inv_Client_Detail.Name = "GVEquipement_Prepa_Inv_Client_Detail";
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsPrint.ExpandAllDetails = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsPrint.PrintDetails = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsView.ShowAutoFilterRow = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsView.ShowFooter = true;
            this.GVEquipement_Prepa_Inv_Client_Detail.OptionsView.ShowGroupPanel = false;
            this.GVEquipement_Prepa_Inv_Client_Detail.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GVEquipement_Prepa_Inv_Client_Detail_CustomSummaryCalculate);
            // 
            // G_L1_Col_NTYPECONTRAT
            // 
            this.G_L1_Col_NTYPECONTRAT.Caption = "NTYPECONTRAT";
            this.G_L1_Col_NTYPECONTRAT.FieldName = "NTYPECONTRAT";
            this.G_L1_Col_NTYPECONTRAT.Name = "G_L1_Col_NTYPECONTRAT";
            // 
            // G_L1_Col_NIDEQUIPEMENT
            // 
            this.G_L1_Col_NIDEQUIPEMENT.Caption = "NIDEQUIPEMENT";
            this.G_L1_Col_NIDEQUIPEMENT.FieldName = "NIDEQUIPEMENT";
            this.G_L1_Col_NIDEQUIPEMENT.Name = "G_L1_Col_NIDEQUIPEMENT";
            // 
            // G_L1_Col_NID_EQUIPEMENT_CLI
            // 
            this.G_L1_Col_NID_EQUIPEMENT_CLI.Caption = "NID_EQUIPEMENT_CLI";
            this.G_L1_Col_NID_EQUIPEMENT_CLI.FieldName = "NID_EQUIPEMENT_CLI";
            this.G_L1_Col_NID_EQUIPEMENT_CLI.Name = "G_L1_Col_NID_EQUIPEMENT_CLI";
            // 
            // G_L1_Col_BEQUIPEMENT_SELECTED
            // 
            this.G_L1_Col_BEQUIPEMENT_SELECTED.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L1_Col_BEQUIPEMENT_SELECTED.AppearanceHeader.Options.UseForeColor = true;
            this.G_L1_Col_BEQUIPEMENT_SELECTED.Caption = "Sélection Equipement";
            this.G_L1_Col_BEQUIPEMENT_SELECTED.ColumnEdit = this.RItem_BEQUIPEMENT_SELECTED;
            this.G_L1_Col_BEQUIPEMENT_SELECTED.FieldName = "BEQUIPEMENT_SELECTED";
            this.G_L1_Col_BEQUIPEMENT_SELECTED.Name = "G_L1_Col_BEQUIPEMENT_SELECTED";
            this.G_L1_Col_BEQUIPEMENT_SELECTED.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BEQUIPEMENT_SELECTED", "Nombre d\'équipement(s) sélectionné(s) : {0}")});
            this.G_L1_Col_BEQUIPEMENT_SELECTED.Visible = true;
            this.G_L1_Col_BEQUIPEMENT_SELECTED.VisibleIndex = 1;
            this.G_L1_Col_BEQUIPEMENT_SELECTED.Width = 282;
            // 
            // RItem_BEQUIPEMENT_SELECTED
            // 
            this.RItem_BEQUIPEMENT_SELECTED.AllowFocused = false;
            this.RItem_BEQUIPEMENT_SELECTED.AutoHeight = false;
            this.RItem_BEQUIPEMENT_SELECTED.Name = "RItem_BEQUIPEMENT_SELECTED";
            this.RItem_BEQUIPEMENT_SELECTED.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.RItem_BEQUIPEMENT_SELECTED.ValueChecked = 1;
            this.RItem_BEQUIPEMENT_SELECTED.ValueUnchecked = 0;
            this.RItem_BEQUIPEMENT_SELECTED.CheckStateChanged += new System.EventHandler(this.RItem_BEQUIPEMENT_SELECTED_CheckStateChanged);
            // 
            // G_L1_Col_VLIBEQUIPEMENT
            // 
            this.G_L1_Col_VLIBEQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L1_Col_VLIBEQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_L1_Col_VLIBEQUIPEMENT.Caption = "Equipement affecté au contrat";
            this.G_L1_Col_VLIBEQUIPEMENT.FieldName = "VLIBEQUIPEMENT";
            this.G_L1_Col_VLIBEQUIPEMENT.Name = "G_L1_Col_VLIBEQUIPEMENT";
            this.G_L1_Col_VLIBEQUIPEMENT.Visible = true;
            this.G_L1_Col_VLIBEQUIPEMENT.VisibleIndex = 0;
            this.G_L1_Col_VLIBEQUIPEMENT.Width = 1366;
            // 
            // G_L1_Col_NCLINUM
            // 
            this.G_L1_Col_NCLINUM.Caption = "NCLINUM";
            this.G_L1_Col_NCLINUM.FieldName = "NCLINUM";
            this.G_L1_Col_NCLINUM.Name = "G_L1_Col_NCLINUM";
            // 
            // GCEquipement_Prepa_Inv_Client
            // 
            gridLevelNode1.LevelTemplate = this.GVEquipement_Prepa_Inv_Client_Detail;
            gridLevelNode1.RelationName = "Lvl_Equipement_Prepa_Inv_Client_Detail";
            this.GCEquipement_Prepa_Inv_Client.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GCEquipement_Prepa_Inv_Client.Location = new System.Drawing.Point(130, 50);
            this.GCEquipement_Prepa_Inv_Client.MainView = this.GVEquipement_Prepa_Inv_Client;
            this.GCEquipement_Prepa_Inv_Client.Name = "GCEquipement_Prepa_Inv_Client";
            this.GCEquipement_Prepa_Inv_Client.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RItem_BCONTRAT_EXISTS,
            this.RItem_BEQUIPEMENT_SELECTED});
            this.GCEquipement_Prepa_Inv_Client.Size = new System.Drawing.Size(1542, 841);
            this.GCEquipement_Prepa_Inv_Client.TabIndex = 29;
            this.GCEquipement_Prepa_Inv_Client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVEquipement_Prepa_Inv_Client,
            this.GVEquipement_Prepa_Inv_Client_Detail});
            // 
            // GVEquipement_Prepa_Inv_Client
            // 
            this.GVEquipement_Prepa_Inv_Client.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVEquipement_Prepa_Inv_Client.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVEquipement_Prepa_Inv_Client.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVEquipement_Prepa_Inv_Client.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVEquipement_Prepa_Inv_Client.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVEquipement_Prepa_Inv_Client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L0_Col_NTYPECONTRAT,
            this.G_L0_Col_BCONTRAT_EXISTS,
            this.G_L0_Col_VTYPECONTRAT,
            this.G_L0_Col_NB_EQUIP_CLI,
            this.G_L0_TreeView,
            this.G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT});
            this.GVEquipement_Prepa_Inv_Client.GridControl = this.GCEquipement_Prepa_Inv_Client;
            this.GVEquipement_Prepa_Inv_Client.Name = "GVEquipement_Prepa_Inv_Client";
            this.GVEquipement_Prepa_Inv_Client.OptionsPrint.ExpandAllDetails = true;
            this.GVEquipement_Prepa_Inv_Client.OptionsPrint.PrintDetails = true;
            this.GVEquipement_Prepa_Inv_Client.OptionsView.ShowAutoFilterRow = true;
            this.GVEquipement_Prepa_Inv_Client.OptionsView.ShowFooter = true;
            this.GVEquipement_Prepa_Inv_Client.OptionsView.ShowGroupPanel = false;
            this.GVEquipement_Prepa_Inv_Client.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.GVAdmin_Equipement_MasterRowGetRelationDisplayCaption);
            this.GVEquipement_Prepa_Inv_Client.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GVEquipement_Prepa_Inv_Client_CustomSummaryCalculate);
            // 
            // G_L0_Col_NTYPECONTRAT
            // 
            this.G_L0_Col_NTYPECONTRAT.Caption = "NTYPECONTRAT";
            this.G_L0_Col_NTYPECONTRAT.FieldName = "NTYPECONTRAT";
            this.G_L0_Col_NTYPECONTRAT.Name = "G_L0_Col_NTYPECONTRAT";
            // 
            // G_L0_Col_BCONTRAT_EXISTS
            // 
            this.G_L0_Col_BCONTRAT_EXISTS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_L0_Col_BCONTRAT_EXISTS.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_BCONTRAT_EXISTS.AppearanceHeader.Options.UseFont = true;
            this.G_L0_Col_BCONTRAT_EXISTS.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_BCONTRAT_EXISTS.Caption = "Sélection Contrat";
            this.G_L0_Col_BCONTRAT_EXISTS.ColumnEdit = this.RItem_BCONTRAT_EXISTS;
            this.G_L0_Col_BCONTRAT_EXISTS.FieldName = "BCONTRAT_EXISTS";
            this.G_L0_Col_BCONTRAT_EXISTS.Name = "G_L0_Col_BCONTRAT_EXISTS";
            this.G_L0_Col_BCONTRAT_EXISTS.Visible = true;
            this.G_L0_Col_BCONTRAT_EXISTS.VisibleIndex = 1;
            this.G_L0_Col_BCONTRAT_EXISTS.Width = 120;
            // 
            // RItem_BCONTRAT_EXISTS
            // 
            this.RItem_BCONTRAT_EXISTS.AutoHeight = false;
            this.RItem_BCONTRAT_EXISTS.Name = "RItem_BCONTRAT_EXISTS";
            this.RItem_BCONTRAT_EXISTS.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.RItem_BCONTRAT_EXISTS.ValueChecked = 1;
            this.RItem_BCONTRAT_EXISTS.ValueUnchecked = 0;
            this.RItem_BCONTRAT_EXISTS.CheckStateChanged += new System.EventHandler(this.RItem_BCONTRAT_EXISTS_CheckStateChanged);
            // 
            // G_L0_Col_VTYPECONTRAT
            // 
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.Options.UseFont = true;
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_VTYPECONTRAT.Caption = "Contrat / Lot technique";
            this.G_L0_Col_VTYPECONTRAT.FieldName = "VTYPECONTRAT";
            this.G_L0_Col_VTYPECONTRAT.Name = "G_L0_Col_VTYPECONTRAT";
            this.G_L0_Col_VTYPECONTRAT.OptionsColumn.AllowEdit = false;
            this.G_L0_Col_VTYPECONTRAT.OptionsColumn.ReadOnly = true;
            this.G_L0_Col_VTYPECONTRAT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "VTYPECONTRAT", "Nb contrat(s) sélectionné(s) : {0}")});
            this.G_L0_Col_VTYPECONTRAT.Visible = true;
            this.G_L0_Col_VTYPECONTRAT.VisibleIndex = 2;
            this.G_L0_Col_VTYPECONTRAT.Width = 1076;
            // 
            // G_L0_Col_NB_EQUIP_CLI
            // 
            this.G_L0_Col_NB_EQUIP_CLI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_L0_Col_NB_EQUIP_CLI.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_NB_EQUIP_CLI.AppearanceHeader.Options.UseFont = true;
            this.G_L0_Col_NB_EQUIP_CLI.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_NB_EQUIP_CLI.Caption = "Nombre équipements sélectionnés";
            this.G_L0_Col_NB_EQUIP_CLI.FieldName = "NB_EQUIP_CLI";
            this.G_L0_Col_NB_EQUIP_CLI.Name = "G_L0_Col_NB_EQUIP_CLI";
            this.G_L0_Col_NB_EQUIP_CLI.OptionsColumn.AllowEdit = false;
            this.G_L0_Col_NB_EQUIP_CLI.OptionsColumn.ReadOnly = true;
            this.G_L0_Col_NB_EQUIP_CLI.Visible = true;
            this.G_L0_Col_NB_EQUIP_CLI.VisibleIndex = 3;
            this.G_L0_Col_NB_EQUIP_CLI.Width = 279;
            // 
            // G_L0_TreeView
            // 
            this.G_L0_TreeView.Name = "G_L0_TreeView";
            this.G_L0_TreeView.OptionsColumn.AllowEdit = false;
            this.G_L0_TreeView.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.G_L0_TreeView.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.G_L0_TreeView.OptionsColumn.ReadOnly = true;
            this.G_L0_TreeView.Visible = true;
            this.G_L0_TreeView.VisibleIndex = 0;
            this.G_L0_TreeView.Width = 49;
            // 
            // G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT
            // 
            this.G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT.Caption = "NID_EQUIPEMENT_CLI_CONTRAT";
            this.G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT.FieldName = "NID_EQUIPEMENT_CLI_CONTRAT";
            this.G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT.Name = "G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT";
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 560);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 37);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 35);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(6, 443);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(126, 13);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(288, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Préparation inventaire client : ";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // frmMethodes_Prepa_Inventaire_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.GCEquipement_Prepa_Inv_Client);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Prepa_Inventaire_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration des équipements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVEquipement_Prepa_Inv_Client_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_BEQUIPEMENT_SELECTED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCEquipement_Prepa_Inv_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEquipement_Prepa_Inv_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_BCONTRAT_EXISTS)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCEquipement_Prepa_Inv_Client;
        private DevExpress.XtraGrid.Views.Grid.GridView GVEquipement_Prepa_Inv_Client_Detail;
        private DevExpress.XtraGrid.Views.Grid.GridView GVEquipement_Prepa_Inv_Client;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NB_EQUIP_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_VLIBEQUIPEMENT;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.SaveFileDialog SFD;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_BEQUIPEMENT_SELECTED;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RItem_BCONTRAT_EXISTS;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_BCONTRAT_EXISTS;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NID_EQUIPEMENT_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_TreeView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RItem_BEQUIPEMENT_SELECTED;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NID_EQUIPEMENT_CLI_CONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NCLINUM;
    }
}