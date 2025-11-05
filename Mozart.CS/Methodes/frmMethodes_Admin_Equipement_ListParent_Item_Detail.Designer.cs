namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement_ListParent_Item_Detail
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
            this.GCAdmin_Equipement_ListParent_Items = new DevExpress.XtraGrid.GridControl();
            this.GVAdmin_Equipement_ListParent_Items = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NID_EQUIPEMENT_LIST_PARENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.RepItemChapitre = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.RepItemChapitreView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemChapViewItem_Actif = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.RepItemTypeChamp = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.RepItemTypeChampView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepItemOrdreAffiche = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEquipFicheItemNew = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.txtNomListParent = new System.Windows.Forms.TextBox();
            this.LblNomFiche = new System.Windows.Forms.Label();
            this.ChkActif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_ListParent_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_ListParent_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapitreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapViewItem_Actif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemTypeChamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemTypeChampView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemOrdreAffiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCAdmin_Equipement_ListParent_Items
            // 
            this.GCAdmin_Equipement_ListParent_Items.Location = new System.Drawing.Point(130, 136);
            this.GCAdmin_Equipement_ListParent_Items.MainView = this.GVAdmin_Equipement_ListParent_Items;
            this.GCAdmin_Equipement_ListParent_Items.Name = "GCAdmin_Equipement_ListParent_Items";
            this.GCAdmin_Equipement_ListParent_Items.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepItemChapitre,
            this.RepItemTypeChamp,
            this.RepItemOrdreAffiche,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemCheckEdit1});
            this.GCAdmin_Equipement_ListParent_Items.Size = new System.Drawing.Size(1682, 834);
            this.GCAdmin_Equipement_ListParent_Items.TabIndex = 29;
            this.GCAdmin_Equipement_ListParent_Items.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmin_Equipement_ListParent_Items});
            // 
            // GVAdmin_Equipement_ListParent_Items
            // 
            this.GVAdmin_Equipement_ListParent_Items.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement_ListParent_Items.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement_ListParent_Items.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement_ListParent_Items.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement_ListParent_Items.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement_ListParent_Items.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM,
            this.G_Col_NID_EQUIPEMENT_LIST_PARENT,
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB,
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF});
            this.GVAdmin_Equipement_ListParent_Items.GridControl = this.GCAdmin_Equipement_ListParent_Items;
            this.GVAdmin_Equipement_ListParent_Items.Name = "GVAdmin_Equipement_ListParent_Items";
            this.GVAdmin_Equipement_ListParent_Items.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement_ListParent_Items.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement_ListParent_Items.OptionsView.ShowGroupPanel = false;
            // 
            // G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM
            // 
            this.G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM.Caption = "NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM";
            this.G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM.FieldName = "NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM";
            this.G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM.Name = "G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM";
            // 
            // G_Col_NID_EQUIPEMENT_LIST_PARENT
            // 
            this.G_Col_NID_EQUIPEMENT_LIST_PARENT.Caption = "NID_EQUIPEMENT_LIST_PARENT";
            this.G_Col_NID_EQUIPEMENT_LIST_PARENT.FieldName = "NID_EQUIPEMENT_LIST_PARENT";
            this.G_Col_NID_EQUIPEMENT_LIST_PARENT.Name = "G_Col_NID_EQUIPEMENT_LIST_PARENT";
            // 
            // G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB
            // 
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.Caption = "Données";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.FieldName = "VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.Name = "G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.Visible = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.VisibleIndex = 0;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB.Width = 362;
            // 
            // G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF
            // 
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.Caption = "Actif";
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.ColumnEdit = this.repositoryItemCheckEdit1;
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.FieldName = "BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF";
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.Name = "G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF";
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.Visible = true;
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.VisibleIndex = 1;
            this.G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF.Width = 68;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // RepItemChapitre
            // 
            this.RepItemChapitre.AutoHeight = false;
            this.RepItemChapitre.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepItemChapitre.DisplayMember = "VEQUIPEMENT_FICHE_CHAP_LIB";
            this.RepItemChapitre.Name = "RepItemChapitre";
            this.RepItemChapitre.NullText = "";
            this.RepItemChapitre.PopupView = this.RepItemChapitreView;
            this.RepItemChapitre.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepItemChapViewItem_Actif});
            this.RepItemChapitre.ValueMember = "NID_EQUIPEMENT_FICHE_CHAP";
            // 
            // RepItemChapitreView
            // 
            this.RepItemChapitreView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP,
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB,
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH,
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF});
            this.RepItemChapitreView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.RepItemChapitreView.Name = "RepItemChapitreView";
            this.RepItemChapitreView.OptionsBehavior.Editable = false;
            this.RepItemChapitreView.OptionsBehavior.ReadOnly = true;
            this.RepItemChapitreView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RepItemChapitreView.OptionsView.ShowGroupPanel = false;
            // 
            // RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP
            // 
            this.RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP.Caption = "NID_EQUIPEMENT_FICHE_CHAP";
            this.RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP.FieldName = "NID_EQUIPEMENT_FICHE_CHAP";
            this.RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP.Name = "RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP";
            // 
            // RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB
            // 
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.Options.UseFont = true;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.Options.UseTextOptions = true;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Caption = "Chapitre";
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.FieldName = "VEQUIPEMENT_FICHE_CHAP_LIB";
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Name = "RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB";
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Visible = true;
            this.RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB.VisibleIndex = 0;
            // 
            // RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH
            // 
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Options.UseFont = true;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Options.UseForeColor = true;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Options.UseTextOptions = true;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Caption = "Ordre affichage chapitre";
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.FieldName = "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Name = "RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Visible = true;
            this.RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.VisibleIndex = 1;
            // 
            // RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF
            // 
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.Options.UseFont = true;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.Options.UseForeColor = true;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.Options.UseTextOptions = true;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.Caption = "Actif";
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.ColumnEdit = this.RepItemChapViewItem_Actif;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.FieldName = "BEQUIPEMENT_FICHE_CHAP_ACTIF";
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.Name = "RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF";
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.Visible = true;
            this.RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF.VisibleIndex = 2;
            // 
            // RepItemChapViewItem_Actif
            // 
            this.RepItemChapViewItem_Actif.AutoHeight = false;
            this.RepItemChapViewItem_Actif.Name = "RepItemChapViewItem_Actif";
            this.RepItemChapViewItem_Actif.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // RepItemTypeChamp
            // 
            this.RepItemTypeChamp.AutoHeight = false;
            this.RepItemTypeChamp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepItemTypeChamp.DisplayMember = "VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB";
            this.RepItemTypeChamp.Name = "RepItemTypeChamp";
            this.RepItemTypeChamp.NullText = "";
            this.RepItemTypeChamp.PopupView = this.RepItemTypeChampView;
            this.RepItemTypeChamp.ValueMember = "NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            // 
            // RepItemTypeChampView
            // 
            this.RepItemTypeChampView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP,
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB});
            this.RepItemTypeChampView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.RepItemTypeChampView.Name = "RepItemTypeChampView";
            this.RepItemTypeChampView.OptionsBehavior.Editable = false;
            this.RepItemTypeChampView.OptionsBehavior.ReadOnly = true;
            this.RepItemTypeChampView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.RepItemTypeChampView.OptionsView.ShowGroupPanel = false;
            // 
            // RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP
            // 
            this.RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.Caption = "NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            this.RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.FieldName = "NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            this.RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP.Name = "RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP";
            // 
            // RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB
            // 
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.Options.UseFont = true;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.Options.UseTextOptions = true;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.Caption = "Type de champ";
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.FieldName = "VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB";
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.Name = "RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB";
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.Visible = true;
            this.RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB.VisibleIndex = 0;
            // 
            // RepItemOrdreAffiche
            // 
            this.RepItemOrdreAffiche.AutoHeight = false;
            this.RepItemOrdreAffiche.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepItemOrdreAffiche.DisplayFormat.FormatString = "n0";
            this.RepItemOrdreAffiche.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RepItemOrdreAffiche.EditFormat.FormatString = "n0";
            this.RepItemOrdreAffiche.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RepItemOrdreAffiche.IsFloatValue = false;
            this.RepItemOrdreAffiche.MaskSettings.Set("mask", "N00");
            this.RepItemOrdreAffiche.Name = "RepItemOrdreAffiche";
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.PopupView = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnSupprimer);
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnEquipFicheItemNew);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 666);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(8, 192);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(81, 35);
            this.BtnSupprimer.TabIndex = 12;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(8, 37);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 35);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEquipFicheItemNew
            // 
            this.BtnEquipFicheItemNew.Location = new System.Drawing.Point(6, 151);
            this.BtnEquipFicheItemNew.Name = "BtnEquipFicheItemNew";
            this.BtnEquipFicheItemNew.Size = new System.Drawing.Size(83, 35);
            this.BtnEquipFicheItemNew.TabIndex = 7;
            this.BtnEquipFicheItemNew.Text = "Ajouter";
            this.BtnEquipFicheItemNew.UseVisualStyleBackColor = true;
            this.BtnEquipFicheItemNew.Click += new System.EventHandler(this.BtnEquipFicheItemNew_Click);
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
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(126, 13);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(307, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Données de la liste déroulante :";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // txtNomListParent
            // 
            this.txtNomListParent.Location = new System.Drawing.Point(330, 59);
            this.txtNomListParent.Name = "txtNomListParent";
            this.txtNomListParent.Size = new System.Drawing.Size(450, 20);
            this.txtNomListParent.TabIndex = 36;
            // 
            // LblNomFiche
            // 
            this.LblNomFiche.AutoSize = true;
            this.LblNomFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomFiche.Location = new System.Drawing.Point(127, 59);
            this.LblNomFiche.Name = "LblNomFiche";
            this.LblNomFiche.Size = new System.Drawing.Size(197, 16);
            this.LblNomFiche.TabIndex = 35;
            this.LblNomFiche.Text = "Nom de la liste déroulante :";
            // 
            // ChkActif
            // 
            this.ChkActif.AutoSize = true;
            this.ChkActif.Checked = true;
            this.ChkActif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActif.Location = new System.Drawing.Point(130, 100);
            this.ChkActif.Name = "ChkActif";
            this.ChkActif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkActif.Size = new System.Drawing.Size(47, 17);
            this.ChkActif.TabIndex = 34;
            this.ChkActif.Text = "Actif";
            this.ChkActif.UseVisualStyleBackColor = true;
            // 
            // frmMethodes_Admin_Equipement_ListParent_Item_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.txtNomListParent);
            this.Controls.Add(this.LblNomFiche);
            this.Controls.Add(this.ChkActif);
            this.Controls.Add(this.GCAdmin_Equipement_ListParent_Items);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Admin_Equipement_ListParent_Item_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Données de la liste déroulante :";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Fiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_ListParent_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_ListParent_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapitreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemChapViewItem_Actif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemTypeChamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemTypeChampView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepItemOrdreAffiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCAdmin_Equipement_ListParent_Items;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement_ListParent_Items;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NIDEQUIPEMENT_FICHE_LIST_PARENT_ITEM;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_VEQUIPEMENT_FICHE_LIST_PARENT_ITEM_LIB;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnEquipFicheItemNew;
        private System.Windows.Forms.Button BtnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepItemChapitre;
        private DevExpress.XtraGrid.Views.Grid.GridView RepItemChapitreView;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepItemTypeChamp;
        private DevExpress.XtraGrid.Views.Grid.GridView RepItemTypeChampView;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepItemOrdreAffiche;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_BEQUIPEMENT_FICHE_LIST_PARENT_ITEM_ACTIF;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NID_EQUIPEMENT_LIST_PARENT;
        private DevExpress.XtraGrid.Columns.GridColumn RepItemChapV_Col_NID_EQUIPEMENT_FICHE_CHAP;
        private DevExpress.XtraGrid.Columns.GridColumn RepItemChapV_Col_VEQUIPEMENT_FICHE_CHAP_LIB;
        private DevExpress.XtraGrid.Columns.GridColumn RepItemChapV_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH;
        private DevExpress.XtraGrid.Columns.GridColumn RepItemChapV_Col_BEQUIPEMENT_FICHE_CHAP_ACTIF;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RepItemChapViewItem_Actif;
        private DevExpress.XtraGrid.Columns.GridColumn RepItem_TypeChampView_Col_NID_EQUIPEMENT_FICHE_TYPE_CHAMP;
        private DevExpress.XtraGrid.Columns.GridColumn RepItem_TypeChampView_Col_VEQUIPEMENT_FICHE_TYPE_CHAMP_LIB;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.TextBox txtNomListParent;
        private System.Windows.Forms.Label LblNomFiche;
        private System.Windows.Forms.CheckBox ChkActif;
    }
}