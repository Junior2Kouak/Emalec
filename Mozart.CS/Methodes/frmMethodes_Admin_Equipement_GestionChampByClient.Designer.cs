namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement_GestionChampByClient
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
            this.GCAdmin_Equipement_List_Client = new DevExpress.XtraGrid.GridControl();
            this.GVAdmin_Equipement_List_Client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_ID_UNIQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_NCLINUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_VCLINOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEquipFicheChapArch = new System.Windows.Forms.Button();
            this.BtnEquipFicheChapNew = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_List_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_List_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCAdmin_Equipement_List_Client
            // 
            this.GCAdmin_Equipement_List_Client.Location = new System.Drawing.Point(130, 50);
            this.GCAdmin_Equipement_List_Client.MainView = this.GVAdmin_Equipement_List_Client;
            this.GCAdmin_Equipement_List_Client.Name = "GCAdmin_Equipement_List_Client";
            this.GCAdmin_Equipement_List_Client.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.GCAdmin_Equipement_List_Client.Size = new System.Drawing.Size(1682, 920);
            this.GCAdmin_Equipement_List_Client.TabIndex = 29;
            this.GCAdmin_Equipement_List_Client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmin_Equipement_List_Client});
            // 
            // GVAdmin_Equipement_List_Client
            // 
            this.GVAdmin_Equipement_List_Client.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement_List_Client.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement_List_Client.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement_List_Client.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement_List_Client.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement_List_Client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_ID_UNIQUE,
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI,
            this.G_Col_NCLINUM,
            this.G_Col_VCLINOM});
            this.GVAdmin_Equipement_List_Client.GridControl = this.GCAdmin_Equipement_List_Client;
            this.GVAdmin_Equipement_List_Client.Name = "GVAdmin_Equipement_List_Client";
            this.GVAdmin_Equipement_List_Client.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement_List_Client.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement_List_Client.OptionsView.ShowAutoFilterRow = true;
            this.GVAdmin_Equipement_List_Client.OptionsView.ShowGroupPanel = false;
            this.GVAdmin_Equipement_List_Client.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.GVAdmin_Equipement_List_Client_CustomRowCellEdit);
            // 
            // G_Col_ID_UNIQUE
            // 
            this.G_Col_ID_UNIQUE.Caption = "ID_UNIQUE";
            this.G_Col_ID_UNIQUE.FieldName = "ID_UNIQUE";
            this.G_Col_ID_UNIQUE.Name = "G_Col_ID_UNIQUE";
            // 
            // G_Col_NEQUIPEMENT_FICHE_ITEM_CLI
            // 
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.Options.UseFont = true;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.Caption = "NEQUIPEMENT_FICHE_ITEM_CLI";
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.FieldName = "NEQUIPEMENT_FICHE_ITEM_CLI";
            this.G_Col_NEQUIPEMENT_FICHE_ITEM_CLI.Name = "G_Col_NEQUIPEMENT_FICHE_ITEM_CLI";
            // 
            // G_Col_NCLINUM
            // 
            this.G_Col_NCLINUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_NCLINUM.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_NCLINUM.Caption = "NCLINUM";
            this.G_Col_NCLINUM.FieldName = "NCLINUM";
            this.G_Col_NCLINUM.Name = "G_Col_NCLINUM";
            this.G_Col_NCLINUM.Width = 1241;
            // 
            // G_Col_VCLINOM
            // 
            this.G_Col_VCLINOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_VCLINOM.AppearanceHeader.Options.UseFont = true;
            this.G_Col_VCLINOM.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_VCLINOM.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_VCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_VCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_VCLINOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.G_Col_VCLINOM.Caption = "Client";
            this.G_Col_VCLINOM.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.G_Col_VCLINOM.FieldName = "VCLINOM";
            this.G_Col_VCLINOM.Name = "G_Col_VCLINOM";
            this.G_Col_VCLINOM.Visible = true;
            this.G_Col_VCLINOM.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "VCLINOM";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "VCLINOM";
            this.repositoryItemGridLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemGridLookUpEdit1_EditValueChanged);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "NCLINUM";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Client avec contrat inventaire";
            this.gridColumn1.FieldName = "VCLINOM";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnEquipFicheChapArch);
            this.GrpActions.Controls.Add(this.BtnEquipFicheChapNew);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 666);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 37);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 47);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEquipFicheChapArch
            // 
            this.BtnEquipFicheChapArch.Location = new System.Drawing.Point(6, 172);
            this.BtnEquipFicheChapArch.Name = "BtnEquipFicheChapArch";
            this.BtnEquipFicheChapArch.Size = new System.Drawing.Size(83, 53);
            this.BtnEquipFicheChapArch.TabIndex = 8;
            this.BtnEquipFicheChapArch.Text = "Supprimer un client";
            this.BtnEquipFicheChapArch.UseVisualStyleBackColor = true;
            this.BtnEquipFicheChapArch.Click += new System.EventHandler(this.BtnEquipFicheArch_Click);
            // 
            // BtnEquipFicheChapNew
            // 
            this.BtnEquipFicheChapNew.Location = new System.Drawing.Point(6, 107);
            this.BtnEquipFicheChapNew.Name = "BtnEquipFicheChapNew";
            this.BtnEquipFicheChapNew.Size = new System.Drawing.Size(83, 47);
            this.BtnEquipFicheChapNew.TabIndex = 7;
            this.BtnEquipFicheChapNew.Text = "Ajouter un client";
            this.BtnEquipFicheChapNew.UseVisualStyleBackColor = true;
            this.BtnEquipFicheChapNew.Click += new System.EventHandler(this.BtnEquipFicheNew_Click);
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
            this.LblTitre.Size = new System.Drawing.Size(510, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Liste des clients sans gestion de code barre EMALEC";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // frmMethodes_Admin_Equipement_GestionChampByClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.GCAdmin_Equipement_List_Client);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Admin_Equipement_GestionChampByClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des clients sans gestion de code barre EMALEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_GestionChampByClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_List_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_List_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCAdmin_Equipement_List_Client;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement_List_Client;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NEQUIPEMENT_FICHE_ITEM_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_NCLINUM;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnEquipFicheChapNew;
        private System.Windows.Forms.Button BtnEquipFicheChapArch;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_VCLINOM;
        private System.Windows.Forms.Button BtnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_ID_UNIQUE;
    }
}