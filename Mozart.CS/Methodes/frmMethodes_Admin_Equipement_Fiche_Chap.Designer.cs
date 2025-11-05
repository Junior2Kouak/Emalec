namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement_Fiche_Chap
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
            this.GCAdmin_Equipement_Fiches_Chap = new DevExpress.XtraGrid.GridControl();
            this.GVAdmin_Equipement_Fiches_Chap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L0_Col_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRowDown = new System.Windows.Forms.Button();
            this.BtnRowUp = new System.Windows.Forms.Button();
            this.BtnEquipFicheChapArch = new System.Windows.Forms.Button();
            this.BtnEquipFicheChapNew = new System.Windows.Forms.Button();
            this.BtnExportXLSX = new System.Windows.Forms.Button();
            this.BtnDetailChap = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ChkArchives = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_Fiches_Chap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Fiches_Chap)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCAdmin_Equipement_Fiches_Chap
            // 
            this.GCAdmin_Equipement_Fiches_Chap.Location = new System.Drawing.Point(130, 50);
            this.GCAdmin_Equipement_Fiches_Chap.MainView = this.GVAdmin_Equipement_Fiches_Chap;
            this.GCAdmin_Equipement_Fiches_Chap.Name = "GCAdmin_Equipement_Fiches_Chap";
            this.GCAdmin_Equipement_Fiches_Chap.Size = new System.Drawing.Size(1682, 920);
            this.GCAdmin_Equipement_Fiches_Chap.TabIndex = 29;
            this.GCAdmin_Equipement_Fiches_Chap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmin_Equipement_Fiches_Chap});
            // 
            // GVAdmin_Equipement_Fiches_Chap
            // 
            this.GVAdmin_Equipement_Fiches_Chap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement_Fiches_Chap.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement_Fiches_Chap.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement_Fiches_Chap.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement_Fiches_Chap.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement_Fiches_Chap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L0_Col_NID_EQUIPEMENT_FICHE,
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH,
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB,
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP});
            this.GVAdmin_Equipement_Fiches_Chap.GridControl = this.GCAdmin_Equipement_Fiches_Chap;
            this.GVAdmin_Equipement_Fiches_Chap.Name = "GVAdmin_Equipement_Fiches_Chap";
            this.GVAdmin_Equipement_Fiches_Chap.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement_Fiches_Chap.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement_Fiches_Chap.OptionsView.ShowAutoFilterRow = true;
            this.GVAdmin_Equipement_Fiches_Chap.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.GVAdmin_Equipement_Fiches_Chap.OptionsView.ShowGroupPanel = false;
            // 
            // G_L0_Col_NID_EQUIPEMENT_FICHE
            // 
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Caption = "NID_EQUIPEMENT_FICHE";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Name = "G_L0_Col_NID_EQUIPEMENT_FICHE";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Width = 72;
            // 
            // G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH
            // 
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Options.UseFont = true;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Caption = "Ordre affichage";
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.FieldName = "NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Name = "G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH";
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.OptionsColumn.AllowEdit = false;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Visible = true;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.VisibleIndex = 0;
            this.G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH.Width = 130;
            // 
            // G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB
            // 
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Caption = "Libellé fiche";
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.FieldName = "VEQUIPEMENT_FICHE_CHAP_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Name = "G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.OptionsColumn.AllowEdit = false;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.OptionsColumn.ReadOnly = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Visible = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.VisibleIndex = 1;
            this.G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB.Width = 1201;
            // 
            // G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP
            // 
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP.Caption = "NID_EQUIPEMENT_FICHE_CHAP";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP.FieldName = "NID_EQUIPEMENT_FICHE_CHAP";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP.Name = "G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP.Width = 254;
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnRowDown);
            this.GrpActions.Controls.Add(this.BtnRowUp);
            this.GrpActions.Controls.Add(this.BtnEquipFicheChapArch);
            this.GrpActions.Controls.Add(this.BtnEquipFicheChapNew);
            this.GrpActions.Controls.Add(this.BtnExportXLSX);
            this.GrpActions.Controls.Add(this.BtnDetailChap);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 666);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(8, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRowDown
            // 
            this.BtnRowDown.Location = new System.Drawing.Point(6, 303);
            this.BtnRowDown.Name = "BtnRowDown";
            this.BtnRowDown.Size = new System.Drawing.Size(83, 42);
            this.BtnRowDown.TabIndex = 10;
            this.BtnRowDown.Text = "Down";
            this.BtnRowDown.UseVisualStyleBackColor = true;
            this.BtnRowDown.Click += new System.EventHandler(this.BtnRowDown_Click);
            // 
            // BtnRowUp
            // 
            this.BtnRowUp.Location = new System.Drawing.Point(6, 255);
            this.BtnRowUp.Name = "BtnRowUp";
            this.BtnRowUp.Size = new System.Drawing.Size(83, 42);
            this.BtnRowUp.TabIndex = 9;
            this.BtnRowUp.Text = "Up";
            this.BtnRowUp.UseVisualStyleBackColor = true;
            this.BtnRowUp.Click += new System.EventHandler(this.BtnRowUp_Click);
            // 
            // BtnEquipFicheChapArch
            // 
            this.BtnEquipFicheChapArch.Location = new System.Drawing.Point(6, 184);
            this.BtnEquipFicheChapArch.Name = "BtnEquipFicheChapArch";
            this.BtnEquipFicheChapArch.Size = new System.Drawing.Size(83, 35);
            this.BtnEquipFicheChapArch.TabIndex = 8;
            this.BtnEquipFicheChapArch.Text = "Archiver";
            this.BtnEquipFicheChapArch.UseVisualStyleBackColor = true;
            this.BtnEquipFicheChapArch.Click += new System.EventHandler(this.BtnEquipFicheArch_Click);
            // 
            // BtnEquipFicheChapNew
            // 
            this.BtnEquipFicheChapNew.Location = new System.Drawing.Point(6, 84);
            this.BtnEquipFicheChapNew.Name = "BtnEquipFicheChapNew";
            this.BtnEquipFicheChapNew.Size = new System.Drawing.Size(83, 35);
            this.BtnEquipFicheChapNew.TabIndex = 7;
            this.BtnEquipFicheChapNew.Text = "Ajouter";
            this.BtnEquipFicheChapNew.UseVisualStyleBackColor = true;
            this.BtnEquipFicheChapNew.Click += new System.EventHandler(this.BtnEquipFicheNew_Click);
            // 
            // BtnExportXLSX
            // 
            this.BtnExportXLSX.Location = new System.Drawing.Point(6, 379);
            this.BtnExportXLSX.Name = "BtnExportXLSX";
            this.BtnExportXLSX.Size = new System.Drawing.Size(83, 35);
            this.BtnExportXLSX.TabIndex = 6;
            this.BtnExportXLSX.Text = "Export EXCEL";
            this.BtnExportXLSX.UseVisualStyleBackColor = true;
            this.BtnExportXLSX.Click += new System.EventHandler(this.BtnExportXLSX_Click);
            // 
            // BtnDetailChap
            // 
            this.BtnDetailChap.Location = new System.Drawing.Point(6, 134);
            this.BtnDetailChap.Name = "BtnDetailChap";
            this.BtnDetailChap.Size = new System.Drawing.Size(83, 35);
            this.BtnDetailChap.TabIndex = 4;
            this.BtnDetailChap.Text = "Détail";
            this.BtnDetailChap.UseVisualStyleBackColor = true;
            this.BtnDetailChap.Click += new System.EventHandler(this.BtnDetail_Click);
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
            this.LblTitre.Size = new System.Drawing.Size(350, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Listes des chapitres actifs de la fiche";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // ChkArchives
            // 
            this.ChkArchives.AutoSize = true;
            this.ChkArchives.Location = new System.Drawing.Point(756, 20);
            this.ChkArchives.Name = "ChkArchives";
            this.ChkArchives.Size = new System.Drawing.Size(103, 17);
            this.ChkArchives.TabIndex = 31;
            this.ChkArchives.Text = "Voir les archives";
            this.ChkArchives.UseVisualStyleBackColor = true;
            this.ChkArchives.CheckedChanged += new System.EventHandler(this.ChkArchives_CheckedChanged);
            // 
            // frmMethodes_Admin_Equipement_Fiche_Chap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.ChkArchives);
            this.Controls.Add(this.GCAdmin_Equipement_Fiches_Chap);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Admin_Equipement_Fiche_Chap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listes des chapitres actifs de la fiche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Fiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_Fiches_Chap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Fiches_Chap)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCAdmin_Equipement_Fiches_Chap;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement_Fiches_Chap;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_VEQUIPEMENT_FICHE_CHAP_LIB;
        private System.Windows.Forms.Button BtnDetailChap;
        private System.Windows.Forms.Button BtnExportXLSX;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnEquipFicheChapNew;
        private System.Windows.Forms.Button BtnEquipFicheChapArch;
        private System.Windows.Forms.CheckBox ChkArchives;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NEQUIPEMENT_FICHE_CHAP_ORDER_AFFICH;
        private System.Windows.Forms.Button BtnRowDown;
        private System.Windows.Forms.Button BtnRowUp;
        private System.Windows.Forms.Button BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NID_EQUIPEMENT_FICHE_CHAP;
    }
}