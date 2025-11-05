namespace MozartCS.Inventaire_Equipement
{
    partial class frmInventaireEquipementNew_SelectTypeEquipement
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
            this.GC_LIST_EQUIP_SIT = new DevExpress.XtraGrid.GridControl();
            this.GV_LIST_EQUIP_SIT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_L0_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_SIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NB_QUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmdQuitter = new MozartUC.apiButton();
            this.BtnSelected = new MozartUC.apiButton();
            this.LblTitre = new MozartUC.apiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GC_LIST_EQUIP_SIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_LIST_EQUIP_SIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_LIST_EQUIP_SIT
            // 
            this.GC_LIST_EQUIP_SIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_LIST_EQUIP_SIT.Location = new System.Drawing.Point(125, 51);
            this.GC_LIST_EQUIP_SIT.MainView = this.GV_LIST_EQUIP_SIT;
            this.GC_LIST_EQUIP_SIT.Name = "GC_LIST_EQUIP_SIT";
            this.GC_LIST_EQUIP_SIT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.GC_LIST_EQUIP_SIT.Size = new System.Drawing.Size(1207, 602);
            this.GC_LIST_EQUIP_SIT.TabIndex = 16;
            this.GC_LIST_EQUIP_SIT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_LIST_EQUIP_SIT});
            // 
            // GV_LIST_EQUIP_SIT
            // 
            this.GV_LIST_EQUIP_SIT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_L0_NIDEQUIPEMENT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI,
            this.G_Col_L0_NID_EQUIPEMENT_SIT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT,
            this.G_Col_L0_NTYPECONTRAT,
            this.G_Col_L0_VTYPECONTRAT,
            this.G_Col_L0_VLIBEQUIPEMENT,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT,
            this.G_Col_L0_NB_QUEST});
            this.GV_LIST_EQUIP_SIT.GridControl = this.GC_LIST_EQUIP_SIT;
            this.GV_LIST_EQUIP_SIT.Name = "GV_LIST_EQUIP_SIT";
            this.GV_LIST_EQUIP_SIT.OptionsBehavior.Editable = false;
            this.GV_LIST_EQUIP_SIT.OptionsBehavior.ReadOnly = true;
            this.GV_LIST_EQUIP_SIT.OptionsView.ShowAutoFilterRow = true;
            this.GV_LIST_EQUIP_SIT.OptionsView.ShowFooter = true;
            this.GV_LIST_EQUIP_SIT.OptionsView.ShowGroupPanel = false;
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
            this.G_Col_L0_VLIBEQUIPEMENT.VisibleIndex = 1;
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
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
            this.cmdQuitter.Location = new System.Drawing.Point(12, 600);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 53);
            this.cmdQuitter.TabIndex = 13;
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.Text = "Fermer";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // BtnSelected
            // 
            this.BtnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSelected.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSelected.HelpContextID = 0;
            this.BtnSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelected.Location = new System.Drawing.Point(12, 51);
            this.BtnSelected.Name = "BtnSelected";
            this.BtnSelected.Size = new System.Drawing.Size(94, 53);
            this.BtnSelected.TabIndex = 17;
            this.BtnSelected.Tag = "15";
            this.BtnSelected.Text = "Sélectionner";
            this.BtnSelected.UseVisualStyleBackColor = false;
            this.BtnSelected.Click += new System.EventHandler(this.BtnSelected_Click);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.BackColor = System.Drawing.Color.Transparent;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTitre.HelpContextID = 0;
            this.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTitre.Location = new System.Drawing.Point(120, 9);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(743, 29);
            this.LblTitre.TabIndex = 23;
            this.LblTitre.Text = "Liste des equipements du site par contrat et type d\'équipement";
            // 
            // frmInventaireEquipementNew_SelectTypeEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 665);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.BtnSelected);
            this.Controls.Add(this.GC_LIST_EQUIP_SIT);
            this.Controls.Add(this.cmdQuitter);
            this.Name = "frmInventaireEquipementNew_SelectTypeEquipement";
            this.Text = "Liste des equipements du site par contrat et type d\'équipement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventaireEquipementNew_SelectTypeEquipement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_LIST_EQUIP_SIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_LIST_EQUIP_SIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GC_LIST_EQUIP_SIT;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_LIST_EQUIP_SIT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_SIT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VLIBEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NB_QUEST;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private MozartUC.apiButton cmdQuitter;
        private MozartUC.apiButton BtnSelected;
        private MozartUC.apiLabel LblTitre;
    }
}