namespace MozartCS.Inventaire_Equipement
{
    partial class frmInventaireEquipement_Export_SelectFiche
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
            this.GCFiches = new DevExpress.XtraGrid.GridControl();
            this.GVFiches = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCol_CHECK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GCol_NID_EQUIPEMENT_FICHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCol_VEQUIPEMENT_FICHE_LIB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDecocheAll = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GCFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCFiches
            // 
            this.GCFiches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCFiches.Location = new System.Drawing.Point(0, 0);
            this.GCFiches.MainView = this.GVFiches;
            this.GCFiches.Name = "GCFiches";
            this.GCFiches.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.GCFiches.Size = new System.Drawing.Size(800, 402);
            this.GCFiches.TabIndex = 0;
            this.GCFiches.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVFiches});
            // 
            // GVFiches
            // 
            this.GVFiches.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_CHECK,
            this.GCol_NID_EQUIPEMENT_FICHE,
            this.GCol_VEQUIPEMENT_FICHE_LIB});
            this.GVFiches.GridControl = this.GCFiches;
            this.GVFiches.Name = "GVFiches";
            this.GVFiches.OptionsView.ShowAutoFilterRow = true;
            this.GVFiches.OptionsView.ShowFooter = true;
            this.GVFiches.OptionsView.ShowGroupPanel = false;
            this.GVFiches.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GVFiches_CustomDrawFooter);
            // 
            // GCol_CHECK
            // 
            this.GCol_CHECK.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GCol_CHECK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.GCol_CHECK.AppearanceHeader.Options.UseFont = true;
            this.GCol_CHECK.AppearanceHeader.Options.UseForeColor = true;
            this.GCol_CHECK.AppearanceHeader.Options.UseTextOptions = true;
            this.GCol_CHECK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCol_CHECK.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GCol_CHECK.Caption = "Sélectionner";
            this.GCol_CHECK.ColumnEdit = this.repositoryItemCheckEdit1;
            this.GCol_CHECK.FieldName = "CHECK";
            this.GCol_CHECK.Name = "GCol_CHECK";
            this.GCol_CHECK.Visible = true;
            this.GCol_CHECK.VisibleIndex = 0;
            this.GCol_CHECK.Width = 110;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // GCol_NID_EQUIPEMENT_FICHE
            // 
            this.GCol_NID_EQUIPEMENT_FICHE.Caption = "NID_EQUIPEMENT_FICHE";
            this.GCol_NID_EQUIPEMENT_FICHE.FieldName = "NID_EQUIPEMENT_FICHE";
            this.GCol_NID_EQUIPEMENT_FICHE.Name = "GCol_NID_EQUIPEMENT_FICHE";
            // 
            // GCol_VEQUIPEMENT_FICHE_LIB
            // 
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseFont = true;
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseForeColor = true;
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.Options.UseTextOptions = true;
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCol_VEQUIPEMENT_FICHE_LIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GCol_VEQUIPEMENT_FICHE_LIB.Caption = "N° Fiche";
            this.GCol_VEQUIPEMENT_FICHE_LIB.FieldName = "VEQUIPEMENT_FICHE_LIB";
            this.GCol_VEQUIPEMENT_FICHE_LIB.Name = "GCol_VEQUIPEMENT_FICHE_LIB";
            this.GCol_VEQUIPEMENT_FICHE_LIB.OptionsColumn.AllowEdit = false;
            this.GCol_VEQUIPEMENT_FICHE_LIB.OptionsColumn.ReadOnly = true;
            this.GCol_VEQUIPEMENT_FICHE_LIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.GCol_VEQUIPEMENT_FICHE_LIB.Visible = true;
            this.GCol_VEQUIPEMENT_FICHE_LIB.VisibleIndex = 1;
            this.GCol_VEQUIPEMENT_FICHE_LIB.Width = 665;
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Location = new System.Drawing.Point(708, 408);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(80, 30);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Valider";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(625, 408);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(77, 30);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDecocheAll
            // 
            this.BtnDecocheAll.Location = new System.Drawing.Point(116, 415);
            this.BtnDecocheAll.Name = "BtnDecocheAll";
            this.BtnDecocheAll.Size = new System.Drawing.Size(99, 23);
            this.BtnDecocheAll.TabIndex = 6;
            this.BtnDecocheAll.Text = "Décocher Tous";
            this.BtnDecocheAll.UseVisualStyleBackColor = true;
            this.BtnDecocheAll.Click += new System.EventHandler(this.BtnDecocheAll_Click);
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.Location = new System.Drawing.Point(12, 415);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(98, 23);
            this.BtnSelectAll.TabIndex = 5;
            this.BtnSelectAll.Text = "Cocher Tous";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // frmInventaireEquipement_Export_SelectFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDecocheAll);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.GCFiches);
            this.Name = "frmInventaireEquipement_Export_SelectFiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélectionner les fiches équipements à exporter";
            this.Load += new System.EventHandler(this.frmInventaireEquipement_Export_SelectFiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCFiches;
        private DevExpress.XtraGrid.Views.Grid.GridView GVFiches;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_NID_EQUIPEMENT_FICHE;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_VEQUIPEMENT_FICHE_LIB;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_CHECK;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Button BtnDecocheAll;
        private System.Windows.Forms.Button BtnSelectAll;
    }
}