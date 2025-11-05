namespace MozartCS.Inventaire_Equipement
{
    partial class frmInventaireEquipement_Export_SelectSite
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
            this.GCInvSites = new DevExpress.XtraGrid.GridControl();
            this.GVInvSites = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCol_CHECK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.GCol_NSITNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCol_VSITNOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCol_NSIT_INV_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.BtnDecocheAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GCInvSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVInvSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // GCInvSites
            // 
            this.GCInvSites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCInvSites.Location = new System.Drawing.Point(0, 0);
            this.GCInvSites.MainView = this.GVInvSites;
            this.GCInvSites.Name = "GCInvSites";
            this.GCInvSites.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.GCInvSites.Size = new System.Drawing.Size(800, 402);
            this.GCInvSites.TabIndex = 0;
            this.GCInvSites.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVInvSites});
            // 
            // GVInvSites
            // 
            this.GVInvSites.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCol_CHECK,
            this.GCol_NSITNUM,
            this.GCol_VSITNOM,
            this.GCol_NSIT_INV_ID});
            this.GVInvSites.GridControl = this.GCInvSites;
            this.GVInvSites.Name = "GVInvSites";
            this.GVInvSites.OptionsView.ShowAutoFilterRow = true;
            this.GVInvSites.OptionsView.ShowFooter = true;
            this.GVInvSites.OptionsView.ShowGroupPanel = false;
            this.GVInvSites.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GVInvSites_CustomDrawFooter);
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
            this.GCol_CHECK.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GCol_CHECK.Caption = "Sélectionner";
            this.GCol_CHECK.ColumnEdit = this.repositoryItemCheckEdit1;
            this.GCol_CHECK.FieldName = "CHECK";
            this.GCol_CHECK.Name = "GCol_CHECK";
            this.GCol_CHECK.Visible = true;
            this.GCol_CHECK.VisibleIndex = 0;
            this.GCol_CHECK.Width = 85;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // GCol_NSITNUM
            // 
            this.GCol_NSITNUM.Caption = "NSITNUM";
            this.GCol_NSITNUM.FieldName = "NSITNUM";
            this.GCol_NSITNUM.Name = "GCol_NSITNUM";
            // 
            // GCol_VSITNOM
            // 
            this.GCol_VSITNOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.GCol_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.GCol_VSITNOM.AppearanceHeader.Options.UseFont = true;
            this.GCol_VSITNOM.AppearanceHeader.Options.UseForeColor = true;
            this.GCol_VSITNOM.AppearanceHeader.Options.UseTextOptions = true;
            this.GCol_VSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GCol_VSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GCol_VSITNOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GCol_VSITNOM.Caption = "Site";
            this.GCol_VSITNOM.FieldName = "VSITNOM";
            this.GCol_VSITNOM.Name = "GCol_VSITNOM";
            this.GCol_VSITNOM.OptionsColumn.AllowEdit = false;
            this.GCol_VSITNOM.OptionsColumn.ReadOnly = true;
            this.GCol_VSITNOM.Visible = true;
            this.GCol_VSITNOM.VisibleIndex = 1;
            this.GCol_VSITNOM.Width = 690;
            // 
            // GCol_NSIT_INV_ID
            // 
            this.GCol_NSIT_INV_ID.Caption = "NSIT_INV_ID";
            this.GCol_NSIT_INV_ID.FieldName = "NSIT_INV_ID";
            this.GCol_NSIT_INV_ID.Name = "GCol_NSIT_INV_ID";
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Location = new System.Drawing.Point(708, 408);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(80, 30);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Suivant";
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
            // BtnSelectAll
            // 
            this.BtnSelectAll.Location = new System.Drawing.Point(12, 415);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(98, 23);
            this.BtnSelectAll.TabIndex = 3;
            this.BtnSelectAll.Text = "Cocher Tous";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // BtnDecocheAll
            // 
            this.BtnDecocheAll.Location = new System.Drawing.Point(116, 415);
            this.BtnDecocheAll.Name = "BtnDecocheAll";
            this.BtnDecocheAll.Size = new System.Drawing.Size(99, 23);
            this.BtnDecocheAll.TabIndex = 4;
            this.BtnDecocheAll.Text = "Décocher Tous";
            this.BtnDecocheAll.UseVisualStyleBackColor = true;
            this.BtnDecocheAll.Click += new System.EventHandler(this.BtnDecocheAll_Click);
            // 
            // frmInventaireEquipement_Export_SelectSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDecocheAll);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.GCInvSites);
            this.Name = "frmInventaireEquipement_Export_SelectSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sélectionner les sites à exporter";
            this.Load += new System.EventHandler(this.frmInventaireEquipement_Export_SelectSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GCInvSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVInvSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GCInvSites;
        private DevExpress.XtraGrid.Views.Grid.GridView GVInvSites;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_NSITNUM;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_VSITNOM;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_CHECK;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn GCol_NSIT_INV_ID;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.Button BtnDecocheAll;
    }
}