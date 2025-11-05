namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.GVAdmin_Equipement_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L1_Col_ID_UNIQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemGLU_NID_EQUIPEMENT_FICHE = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.RepItem_V_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_V_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_Actions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RItem_Btn_Del_Equip = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.G_L1_Col_BEQUIPEMENTACTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L1_Col_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCAdmin_Equipement = new DevExpress.XtraGrid.GridControl();
            this.GVAdmin_Equipement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L0_Col_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NB_EQUIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnGestListeParent = new System.Windows.Forms.Button();
            this.BtnGestFiches = new System.Windows.Forms.Button();
            this.BtnExportXLSX = new System.Windows.Forms.Button();
            this.btnVisu = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddEquipement = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ChkOnlyContratWEquip = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemGLU_NID_EQUIPEMENT_FICHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItem_V_NID_EQUIPEMENT_FICHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_Btn_Del_Equip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVAdmin_Equipement_Detail
            // 
            this.GVAdmin_Equipement_Detail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement_Detail.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement_Detail.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement_Detail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement_Detail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L1_Col_ID_UNIQUE,
            this.G_L1_Col_NTYPECONTRAT,
            this.G_L1_Col_NIDEQUIPEMENT,
            this.G_L1_Col_VLIBEQUIPEMENT,
            this.G_L1_Col_NID_EQUIPEMENT_FICHE,
            this.G_L1_Col_Actions,
            this.G_L1_Col_BEQUIPEMENTACTIF,
            this.G_L1_Col_VTYPECONTRAT});
            this.GVAdmin_Equipement_Detail.GridControl = this.GCAdmin_Equipement;
            this.GVAdmin_Equipement_Detail.Name = "GVAdmin_Equipement_Detail";
            this.GVAdmin_Equipement_Detail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GVAdmin_Equipement_Detail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GVAdmin_Equipement_Detail.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement_Detail.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement_Detail.OptionsView.ShowFooter = true;
            this.GVAdmin_Equipement_Detail.OptionsView.ShowGroupPanel = false;
            // 
            // G_L1_Col_ID_UNIQUE
            // 
            this.G_L1_Col_ID_UNIQUE.Caption = "ID_UNIQUE";
            this.G_L1_Col_ID_UNIQUE.FieldName = "ID_UNIQUE";
            this.G_L1_Col_ID_UNIQUE.Name = "G_L1_Col_ID_UNIQUE";
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
            // G_L1_Col_VLIBEQUIPEMENT
            // 
            this.G_L1_Col_VLIBEQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L1_Col_VLIBEQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_L1_Col_VLIBEQUIPEMENT.Caption = "Type Equipement affecté au contrat";
            this.G_L1_Col_VLIBEQUIPEMENT.FieldName = "VLIBEQUIPEMENT";
            this.G_L1_Col_VLIBEQUIPEMENT.Name = "G_L1_Col_VLIBEQUIPEMENT";
            this.G_L1_Col_VLIBEQUIPEMENT.Visible = true;
            this.G_L1_Col_VLIBEQUIPEMENT.VisibleIndex = 0;
            this.G_L1_Col_VLIBEQUIPEMENT.Width = 1142;
            // 
            // G_L1_Col_NID_EQUIPEMENT_FICHE
            // 
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.AppearanceCell.Options.UseTextOptions = true;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseForeColor = true;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.Caption = "N° Fiche";
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.ColumnEdit = this.RepItemGLU_NID_EQUIPEMENT_FICHE;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.Name = "G_L1_Col_NID_EQUIPEMENT_FICHE";
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.Visible = true;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.VisibleIndex = 1;
            this.G_L1_Col_NID_EQUIPEMENT_FICHE.Width = 261;
            // 
            // RepItemGLU_NID_EQUIPEMENT_FICHE
            // 
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.AutoHeight = false;
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.DisplayMember = "NID_EQUIPEMENT_FICHE";
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.Name = "RepItemGLU_NID_EQUIPEMENT_FICHE";
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.NullText = "";
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.PopupView = this.RepItem_V_NID_EQUIPEMENT_FICHE;
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.ValueMember = "NID_EQUIPEMENT_FICHE";
            this.RepItemGLU_NID_EQUIPEMENT_FICHE.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.RepItemGLU_NID_EQUIPEMENT_FICHE_CustomDisplayText);
            // 
            // RepItem_V_NID_EQUIPEMENT_FICHE
            // 
            this.RepItem_V_NID_EQUIPEMENT_FICHE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_V_NID_EQUIPEMENT_FICHE,
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB});
            this.RepItem_V_NID_EQUIPEMENT_FICHE.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.RepItem_V_NID_EQUIPEMENT_FICHE.Name = "RepItem_V_NID_EQUIPEMENT_FICHE";
            this.RepItem_V_NID_EQUIPEMENT_FICHE.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RepItem_V_NID_EQUIPEMENT_FICHE.OptionsView.ShowGroupPanel = false;
            // 
            // G_Col_V_NID_EQUIPEMENT_FICHE
            // 
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseFont = true;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.Caption = "N° Fiche";
            this.G_Col_V_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_Col_V_NID_EQUIPEMENT_FICHE.Name = "G_Col_V_NID_EQUIPEMENT_FICHE";
            this.G_Col_V_NID_EQUIPEMENT_FICHE.Visible = true;
            this.G_Col_V_NID_EQUIPEMENT_FICHE.VisibleIndex = 0;
            // 
            // G_Col_V_VEQUIPEMENT_FICHE_LIB
            // 
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseFont = true;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.Caption = "Libellé Fiche";
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.FieldName = "VEQUIPEMENT_FICHE_LIB";
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.Name = "G_Col_V_VEQUIPEMENT_FICHE_LIB";
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.Visible = true;
            this.G_Col_V_VEQUIPEMENT_FICHE_LIB.VisibleIndex = 1;
            // 
            // G_L1_Col_Actions
            // 
            this.G_L1_Col_Actions.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L1_Col_Actions.AppearanceHeader.Options.UseForeColor = true;
            this.G_L1_Col_Actions.Caption = "Actions";
            this.G_L1_Col_Actions.ColumnEdit = this.RItem_Btn_Del_Equip;
            this.G_L1_Col_Actions.Name = "G_L1_Col_Actions";
            this.G_L1_Col_Actions.Visible = true;
            this.G_L1_Col_Actions.VisibleIndex = 2;
            this.G_L1_Col_Actions.Width = 114;
            // 
            // RItem_Btn_Del_Equip
            // 
            this.RItem_Btn_Del_Equip.AutoHeight = false;
            this.RItem_Btn_Del_Equip.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Supprimer", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.RItem_Btn_Del_Equip.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.RItem_Btn_Del_Equip.Name = "RItem_Btn_Del_Equip";
            this.RItem_Btn_Del_Equip.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RItem_Btn_Del_Equip.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RItem_Btn_Del_Equip_ButtonClick);
            // 
            // G_L1_Col_BEQUIPEMENTACTIF
            // 
            this.G_L1_Col_BEQUIPEMENTACTIF.Caption = "BEQUIPEMENTACTIF";
            this.G_L1_Col_BEQUIPEMENTACTIF.FieldName = "BEQUIPEMENTACTIF";
            this.G_L1_Col_BEQUIPEMENTACTIF.Name = "G_L1_Col_BEQUIPEMENTACTIF";
            // 
            // G_L1_Col_VTYPECONTRAT
            // 
            this.G_L1_Col_VTYPECONTRAT.Caption = "Type Contrat";
            this.G_L1_Col_VTYPECONTRAT.FieldName = "VTYPECONTRAT";
            this.G_L1_Col_VTYPECONTRAT.Name = "G_L1_Col_VTYPECONTRAT";
            // 
            // GCAdmin_Equipement
            // 
            gridLevelNode2.LevelTemplate = this.GVAdmin_Equipement_Detail;
            gridLevelNode2.RelationName = "Lvl_Equipement_Detail";
            this.GCAdmin_Equipement.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.GCAdmin_Equipement.Location = new System.Drawing.Point(130, 50);
            this.GCAdmin_Equipement.MainView = this.GVAdmin_Equipement;
            this.GCAdmin_Equipement.Name = "GCAdmin_Equipement";
            this.GCAdmin_Equipement.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RItem_Btn_Del_Equip,
            this.RepItemGLU_NID_EQUIPEMENT_FICHE});
            this.GCAdmin_Equipement.Size = new System.Drawing.Size(1542, 841);
            this.GCAdmin_Equipement.TabIndex = 29;
            this.GCAdmin_Equipement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmin_Equipement,
            this.GVAdmin_Equipement_Detail});
            // 
            // GVAdmin_Equipement
            // 
            this.GVAdmin_Equipement.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L0_Col_NTYPECONTRAT,
            this.G_L0_Col_VTYPECONTRAT,
            this.G_L0_Col_NB_EQUIP});
            this.GVAdmin_Equipement.GridControl = this.GCAdmin_Equipement;
            this.GVAdmin_Equipement.Name = "GVAdmin_Equipement";
            this.GVAdmin_Equipement.OptionsBehavior.Editable = false;
            this.GVAdmin_Equipement.OptionsBehavior.ReadOnly = true;
            this.GVAdmin_Equipement.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement.OptionsView.ShowAutoFilterRow = true;
            this.GVAdmin_Equipement.OptionsView.ShowFooter = true;
            this.GVAdmin_Equipement.OptionsView.ShowGroupPanel = false;
            this.GVAdmin_Equipement.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.GVAdmin_Equipement_MasterRowGetRelationDisplayCaption);
            this.GVAdmin_Equipement.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GVAdmin_Equipement_CustomSummaryCalculate);
            // 
            // G_L0_Col_NTYPECONTRAT
            // 
            this.G_L0_Col_NTYPECONTRAT.Caption = "NTYPECONTRAT";
            this.G_L0_Col_NTYPECONTRAT.FieldName = "NTYPECONTRAT";
            this.G_L0_Col_NTYPECONTRAT.Name = "G_L0_Col_NTYPECONTRAT";
            // 
            // G_L0_Col_VTYPECONTRAT
            // 
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_VTYPECONTRAT.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_VTYPECONTRAT.Caption = "Type contrat";
            this.G_L0_Col_VTYPECONTRAT.FieldName = "VTYPECONTRAT";
            this.G_L0_Col_VTYPECONTRAT.Name = "G_L0_Col_VTYPECONTRAT";
            this.G_L0_Col_VTYPECONTRAT.Visible = true;
            this.G_L0_Col_VTYPECONTRAT.VisibleIndex = 0;
            this.G_L0_Col_VTYPECONTRAT.Width = 1071;
            // 
            // G_L0_Col_NB_EQUIP
            // 
            this.G_L0_Col_NB_EQUIP.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_NB_EQUIP.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_NB_EQUIP.Caption = "Nombre équipements";
            this.G_L0_Col_NB_EQUIP.FieldName = "NB_EQUIP";
            this.G_L0_Col_NB_EQUIP.Name = "G_L0_Col_NB_EQUIP";
            this.G_L0_Col_NB_EQUIP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NB_EQUIP", "Nombre de contrats avec des équipements : {0}", "1")});
            this.G_L0_Col_NB_EQUIP.Visible = true;
            this.G_L0_Col_NB_EQUIP.VisibleIndex = 1;
            this.G_L0_Col_NB_EQUIP.Width = 453;
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnGestListeParent);
            this.GrpActions.Controls.Add(this.BtnGestFiches);
            this.GrpActions.Controls.Add(this.BtnExportXLSX);
            this.GrpActions.Controls.Add(this.btnVisu);
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 666);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnGestListeParent
            // 
            this.BtnGestListeParent.Location = new System.Drawing.Point(6, 366);
            this.BtnGestListeParent.Name = "BtnGestListeParent";
            this.BtnGestListeParent.Size = new System.Drawing.Size(83, 50);
            this.BtnGestListeParent.TabIndex = 12;
            this.BtnGestListeParent.Text = "Gestion des listes déroulantes";
            this.BtnGestListeParent.UseVisualStyleBackColor = true;
            this.BtnGestListeParent.Click += new System.EventHandler(this.BtnGestListeParent_Click);
            // 
            // BtnGestFiches
            // 
            this.BtnGestFiches.Location = new System.Drawing.Point(7, 316);
            this.BtnGestFiches.Name = "BtnGestFiches";
            this.BtnGestFiches.Size = new System.Drawing.Size(83, 44);
            this.BtnGestFiches.TabIndex = 7;
            this.BtnGestFiches.Text = "Gestion Fiches";
            this.BtnGestFiches.UseVisualStyleBackColor = true;
            this.BtnGestFiches.Click += new System.EventHandler(this.BtnGestFiches_Click);
            // 
            // BtnExportXLSX
            // 
            this.BtnExportXLSX.Location = new System.Drawing.Point(6, 159);
            this.BtnExportXLSX.Name = "BtnExportXLSX";
            this.BtnExportXLSX.Size = new System.Drawing.Size(83, 35);
            this.BtnExportXLSX.TabIndex = 6;
            this.BtnExportXLSX.Text = "Export EXCEL";
            this.BtnExportXLSX.UseVisualStyleBackColor = true;
            this.BtnExportXLSX.Click += new System.EventHandler(this.BtnExportXLSX_Click);
            // 
            // btnVisu
            // 
            this.btnVisu.Location = new System.Drawing.Point(6, 99);
            this.btnVisu.Name = "btnVisu";
            this.btnVisu.Size = new System.Drawing.Size(83, 35);
            this.btnVisu.TabIndex = 5;
            this.btnVisu.Text = "Visualiser";
            this.btnVisu.UseVisualStyleBackColor = true;
            this.btnVisu.Click += new System.EventHandler(this.btnVisu_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(6, 609);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Administration des équipements";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddEquipement);
            this.groupBox1.Location = new System.Drawing.Point(1692, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 560);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // BtnAddEquipement
            // 
            this.BtnAddEquipement.Location = new System.Drawing.Point(6, 37);
            this.BtnAddEquipement.Name = "BtnAddEquipement";
            this.BtnAddEquipement.Size = new System.Drawing.Size(83, 35);
            this.BtnAddEquipement.TabIndex = 4;
            this.BtnAddEquipement.Text = "Ajouter équipements";
            this.BtnAddEquipement.UseVisualStyleBackColor = true;
            this.BtnAddEquipement.Click += new System.EventHandler(this.BtnAddEquipement_Click);
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // ChkOnlyContratWEquip
            // 
            this.ChkOnlyContratWEquip.AutoSize = true;
            this.ChkOnlyContratWEquip.Location = new System.Drawing.Point(585, 20);
            this.ChkOnlyContratWEquip.Name = "ChkOnlyContratWEquip";
            this.ChkOnlyContratWEquip.Size = new System.Drawing.Size(267, 17);
            this.ChkOnlyContratWEquip.TabIndex = 32;
            this.ChkOnlyContratWEquip.Text = "Afficher uniquement les contrats avec équipements";
            this.ChkOnlyContratWEquip.UseVisualStyleBackColor = true;
            this.ChkOnlyContratWEquip.CheckedChanged += new System.EventHandler(this.ChkOnlyContratWEquip_CheckedChanged);
            // 
            // frmMethodes_Admin_Equipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.ChkOnlyContratWEquip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GCAdmin_Equipement);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.label2);
            this.Name = "frmMethodes_Admin_Equipement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration des équipements";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemGLU_NID_EQUIPEMENT_FICHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItem_V_NID_EQUIPEMENT_FICHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RItem_Btn_Del_Equip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCAdmin_Equipement;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement_Detail;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NB_EQUIP;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_VLIBEQUIPEMENT;
        private System.Windows.Forms.Button BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_Actions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RItem_Btn_Del_Equip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddEquipement;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_ID_UNIQUE;
        private System.Windows.Forms.Button BtnExportXLSX;
        private System.Windows.Forms.Button btnVisu;
        private System.Windows.Forms.SaveFileDialog SFD;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_BEQUIPEMENTACTIF;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_VTYPECONTRAT;
        private System.Windows.Forms.Button BtnGestFiches;
        private DevExpress.XtraGrid.Columns.GridColumn G_L1_Col_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepItemGLU_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Views.Grid.GridView RepItem_V_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_V_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_V_VEQUIPEMENT_FICHE_LIB;
        private System.Windows.Forms.Button BtnGestListeParent;
        private System.Windows.Forms.CheckBox ChkOnlyContratWEquip;
    }
}