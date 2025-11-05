namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement_Fiche
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
            this.GCAdmin_Equipement_Fiches = new DevExpress.XtraGrid.GridControl();
            this.GVAdmin_Equipement_Fiches = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_L0_Col_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_L0_Col_NB_EQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnEquipFicheArch = new System.Windows.Forms.Button();
            this.BtnEquipFicheNew = new System.Windows.Forms.Button();
            this.BtnExportXLSX = new System.Windows.Forms.Button();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ChkArchives = new System.Windows.Forms.CheckBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_Fiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Fiches)).BeginInit();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCAdmin_Equipement_Fiches
            // 
            this.GCAdmin_Equipement_Fiches.Location = new System.Drawing.Point(130, 50);
            this.GCAdmin_Equipement_Fiches.MainView = this.GVAdmin_Equipement_Fiches;
            this.GCAdmin_Equipement_Fiches.Name = "GCAdmin_Equipement_Fiches";
            this.GCAdmin_Equipement_Fiches.Size = new System.Drawing.Size(1682, 920);
            this.GCAdmin_Equipement_Fiches.TabIndex = 29;
            this.GCAdmin_Equipement_Fiches.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmin_Equipement_Fiches});
            // 
            // GVAdmin_Equipement_Fiches
            // 
            this.GVAdmin_Equipement_Fiches.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GVAdmin_Equipement_Fiches.Appearance.HeaderPanel.Options.UseFont = true;
            this.GVAdmin_Equipement_Fiches.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GVAdmin_Equipement_Fiches.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GVAdmin_Equipement_Fiches.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GVAdmin_Equipement_Fiches.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_L0_Col_NID_EQUIPEMENT_FICHE,
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB,
            this.G_L0_Col_NB_EQUIPEMENT});
            this.GVAdmin_Equipement_Fiches.GridControl = this.GCAdmin_Equipement_Fiches;
            this.GVAdmin_Equipement_Fiches.Name = "GVAdmin_Equipement_Fiches";
            this.GVAdmin_Equipement_Fiches.OptionsBehavior.Editable = false;
            this.GVAdmin_Equipement_Fiches.OptionsBehavior.ReadOnly = true;
            this.GVAdmin_Equipement_Fiches.OptionsPrint.ExpandAllDetails = true;
            this.GVAdmin_Equipement_Fiches.OptionsPrint.PrintDetails = true;
            this.GVAdmin_Equipement_Fiches.OptionsView.ShowAutoFilterRow = true;
            this.GVAdmin_Equipement_Fiches.OptionsView.ShowFooter = true;
            this.GVAdmin_Equipement_Fiches.OptionsView.ShowGroupPanel = false;
            // 
            // G_L0_Col_NID_EQUIPEMENT_FICHE
            // 
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseFont = true;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.Options.UseTextOptions = true;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Caption = "N°";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Name = "G_L0_Col_NID_EQUIPEMENT_FICHE";
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Visible = true;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.VisibleIndex = 0;
            this.G_L0_Col_NID_EQUIPEMENT_FICHE.Width = 116;
            // 
            // G_L0_Col_VEQUIPEMENT_FICHE_LIB
            // 
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.Caption = "Libellé fiche";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.FieldName = "VEQUIPEMENT_FICHE_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.Name = "G_L0_Col_VEQUIPEMENT_FICHE_LIB";
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "VEQUIPEMENT_FICHE_LIB", "Nombre total  de fiches : {0}")});
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.Visible = true;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.VisibleIndex = 1;
            this.G_L0_Col_VEQUIPEMENT_FICHE_LIB.Width = 1241;
            // 
            // G_L0_Col_NB_EQUIPEMENT
            // 
            this.G_L0_Col_NB_EQUIPEMENT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_L0_Col_NB_EQUIPEMENT.AppearanceHeader.Options.UseForeColor = true;
            this.G_L0_Col_NB_EQUIPEMENT.Caption = "Nombre équipements affectés à cette fiche";
            this.G_L0_Col_NB_EQUIPEMENT.FieldName = "NB_EQUIPEMENT";
            this.G_L0_Col_NB_EQUIPEMENT.Name = "G_L0_Col_NB_EQUIPEMENT";
            this.G_L0_Col_NB_EQUIPEMENT.Visible = true;
            this.G_L0_Col_NB_EQUIPEMENT.VisibleIndex = 2;
            this.G_L0_Col_NB_EQUIPEMENT.Width = 453;
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnCopy);
            this.GrpActions.Controls.Add(this.BtnEquipFicheArch);
            this.GrpActions.Controls.Add(this.BtnEquipFicheNew);
            this.GrpActions.Controls.Add(this.BtnExportXLSX);
            this.GrpActions.Controls.Add(this.BtnDetail);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 666);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnEquipFicheArch
            // 
            this.BtnEquipFicheArch.Location = new System.Drawing.Point(6, 137);
            this.BtnEquipFicheArch.Name = "BtnEquipFicheArch";
            this.BtnEquipFicheArch.Size = new System.Drawing.Size(83, 35);
            this.BtnEquipFicheArch.TabIndex = 8;
            this.BtnEquipFicheArch.Text = "Archiver";
            this.BtnEquipFicheArch.UseVisualStyleBackColor = true;
            this.BtnEquipFicheArch.Click += new System.EventHandler(this.BtnEquipFicheArch_Click);
            // 
            // BtnEquipFicheNew
            // 
            this.BtnEquipFicheNew.Location = new System.Drawing.Point(6, 37);
            this.BtnEquipFicheNew.Name = "BtnEquipFicheNew";
            this.BtnEquipFicheNew.Size = new System.Drawing.Size(83, 35);
            this.BtnEquipFicheNew.TabIndex = 7;
            this.BtnEquipFicheNew.Text = "Nouveau";
            this.BtnEquipFicheNew.UseVisualStyleBackColor = true;
            this.BtnEquipFicheNew.Click += new System.EventHandler(this.BtnEquipFicheNew_Click);
            // 
            // BtnExportXLSX
            // 
            this.BtnExportXLSX.Location = new System.Drawing.Point(6, 292);
            this.BtnExportXLSX.Name = "BtnExportXLSX";
            this.BtnExportXLSX.Size = new System.Drawing.Size(83, 35);
            this.BtnExportXLSX.TabIndex = 6;
            this.BtnExportXLSX.Text = "Export EXCEL";
            this.BtnExportXLSX.UseVisualStyleBackColor = true;
            this.BtnExportXLSX.Click += new System.EventHandler(this.BtnExportXLSX_Click);
            // 
            // BtnDetail
            // 
            this.BtnDetail.Location = new System.Drawing.Point(6, 87);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(83, 35);
            this.BtnDetail.TabIndex = 4;
            this.BtnDetail.Text = "Détail";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
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
            this.LblTitre.Size = new System.Drawing.Size(400, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Listes des fiches actives pour équipement";
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
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(6, 208);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(83, 35);
            this.BtnCopy.TabIndex = 9;
            this.BtnCopy.Text = "Dupliquer";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // frmMethodes_Admin_Equipement_Fiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.ChkArchives);
            this.Controls.Add(this.GCAdmin_Equipement_Fiches);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Admin_Equipement_Fiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listes des fiches actives pour équipement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Fiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmin_Equipement_Fiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmin_Equipement_Fiches)).EndInit();
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCAdmin_Equipement_Fiches;
        private DevExpress.XtraGrid.Views.Grid.GridView GVAdmin_Equipement_Fiches;
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_VEQUIPEMENT_FICHE_LIB;
        private DevExpress.XtraGrid.Columns.GridColumn G_L0_Col_NB_EQUIPEMENT;
        private System.Windows.Forms.Button BtnDetail;
        private System.Windows.Forms.Button BtnExportXLSX;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button BtnEquipFicheNew;
        private System.Windows.Forms.Button BtnEquipFicheArch;
        private System.Windows.Forms.CheckBox ChkArchives;
        private System.Windows.Forms.Button BtnCopy;
    }
}