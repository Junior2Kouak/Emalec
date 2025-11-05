namespace MozartCS
{
    partial class frmSelectionMultiSiteContratEquipement_Di_Inventaire
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
            this.GC_SELECTED = new DevExpress.XtraGrid.GridControl();
            this.GV_SELECTED = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.G_Col_L0_NIDEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_SIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VTYPECONTRAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VSITNOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_VLIBEQUIPEMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_NB_QUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.G_Col_L0_BSELECTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.G_Col_L0_NSITNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdQuitter = new MozartUC.apiButton();
            this.Label1 = new MozartUC.apiLabel();
            this.BtnValid = new MozartUC.apiButton();
            ((System.ComponentModel.ISupportInitialize)(this.GC_SELECTED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SELECTED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // GC_SELECTED
            // 
            this.GC_SELECTED.Location = new System.Drawing.Point(125, 52);
            this.GC_SELECTED.MainView = this.GV_SELECTED;
            this.GC_SELECTED.Name = "GC_SELECTED";
            this.GC_SELECTED.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.GC_SELECTED.Size = new System.Drawing.Size(985, 552);
            this.GC_SELECTED.TabIndex = 12;
            this.GC_SELECTED.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_SELECTED});
            // 
            // GV_SELECTED
            // 
            this.GV_SELECTED.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.G_Col_L0_NIDEQUIPEMENT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI,
            this.G_Col_L0_NID_EQUIPEMENT_SIT,
            this.G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT,
            this.G_Col_L0_NTYPECONTRAT,
            this.G_Col_L0_VTYPECONTRAT,
            this.G_Col_L0_VSITNOM,
            this.G_Col_L0_VLIBEQUIPEMENT,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE,
            this.G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT,
            this.G_Col_L0_NB_QUEST,
            this.G_Col_L0_BSELECTED,
            this.G_Col_L0_NSITNUM});
            this.GV_SELECTED.GridControl = this.GC_SELECTED;
            this.GV_SELECTED.Name = "GV_SELECTED";
            this.GV_SELECTED.OptionsView.ShowAutoFilterRow = true;
            this.GV_SELECTED.OptionsView.ShowFooter = true;
            this.GV_SELECTED.OptionsView.ShowGroupPanel = false;
            this.GV_SELECTED.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.GV_SELECTED_CustomDrawFooterCell);
            this.GV_SELECTED.CustomDrawFooter += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.GV_SELECTED_CustomDrawFooter);
            this.GV_SELECTED.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.GV_ACT_INV_LIST_PARENT_CustomSummaryCalculate);
            this.GV_SELECTED.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_SELECTED_MouseDown);
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
            this.G_Col_L0_VTYPECONTRAT.VisibleIndex = 1;
            // 
            // G_Col_L0_VSITNOM
            // 
            this.G_Col_L0_VSITNOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_VSITNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_VSITNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_VSITNOM.Caption = "Site";
            this.G_Col_L0_VSITNOM.FieldName = "VSITNOM";
            this.G_Col_L0_VSITNOM.Name = "G_Col_L0_VSITNOM";
            this.G_Col_L0_VSITNOM.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VSITNOM.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VSITNOM.Visible = true;
            this.G_Col_L0_VSITNOM.VisibleIndex = 0;
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
            this.G_Col_L0_VLIBEQUIPEMENT.Caption = "Equipements";
            this.G_Col_L0_VLIBEQUIPEMENT.FieldName = "VLIBEQUIPEMENT";
            this.G_Col_L0_VLIBEQUIPEMENT.Name = "G_Col_L0_VLIBEQUIPEMENT";
            this.G_Col_L0_VLIBEQUIPEMENT.OptionsColumn.AllowEdit = false;
            this.G_Col_L0_VLIBEQUIPEMENT.OptionsColumn.ReadOnly = true;
            this.G_Col_L0_VLIBEQUIPEMENT.Visible = true;
            this.G_Col_L0_VLIBEQUIPEMENT.VisibleIndex = 2;
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
            // G_Col_L0_BSELECTED
            // 
            this.G_Col_L0_BSELECTED.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.G_Col_L0_BSELECTED.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseFont = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseForeColor = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.Options.UseTextOptions = true;
            this.G_Col_L0_BSELECTED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.G_Col_L0_BSELECTED.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.G_Col_L0_BSELECTED.Caption = "Sélection";
            this.G_Col_L0_BSELECTED.ColumnEdit = this.repositoryItemCheckEdit1;
            this.G_Col_L0_BSELECTED.FieldName = "BSELECTED";
            this.G_Col_L0_BSELECTED.Name = "G_Col_L0_BSELECTED";
            this.G_Col_L0_BSELECTED.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "BSELECTED", "Total sélectionné = {0:n0}"),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.G_Col_L0_BSELECTED.Visible = true;
            this.G_Col_L0_BSELECTED.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // G_Col_L0_NSITNUM
            // 
            this.G_Col_L0_NSITNUM.Caption = "gridColumn1";
            this.G_Col_L0_NSITNUM.FieldName = "NSITNUM";
            this.G_Col_L0_NSITNUM.Name = "G_Col_L0_NSITNUM";
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
            this.cmdQuitter.Location = new System.Drawing.Point(12, 551);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(94, 53);
            this.cmdQuitter.TabIndex = 7;
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.Text = "Fermer";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Wheat;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.HelpContextID = 0;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(123, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(577, 24);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Séletion des équipements à inventorier par site et par contrat";
            // 
            // BtnValid
            // 
            this.BtnValid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnValid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnValid.HelpContextID = 0;
            this.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnValid.Location = new System.Drawing.Point(12, 52);
            this.BtnValid.Name = "BtnValid";
            this.BtnValid.Size = new System.Drawing.Size(94, 53);
            this.BtnValid.TabIndex = 11;
            this.BtnValid.Tag = "15";
            this.BtnValid.Text = "Valider";
            this.BtnValid.UseVisualStyleBackColor = false;
            this.BtnValid.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmSelectionMultiSiteContratEquipement_Di_Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1124, 616);
            this.Controls.Add(this.GC_SELECTED);
            this.Controls.Add(this.BtnValid);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.Label1);
            this.Name = "frmSelectionMultiSiteContratEquipement_Di_Inventaire";
            this.Text = "Séletion des équipements à inventorier par site et par contrat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelectionMultiSiteContratEquipement_Di_Inventaire_FormClosing);
            this.Load += new System.EventHandler(this.frmSelectionMultiSiteContratEquipement_Di_Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_SELECTED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_SELECTED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MozartUC.apiButton cmdQuitter;
        private MozartUC.apiLabel Label1;
        private MozartUC.apiButton BtnValid;
        private DevExpress.XtraGrid.GridControl GC_SELECTED;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_SELECTED;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NIDEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_SIT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NID_EQUIPEMENT_CLI_CONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VTYPECONTRAT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VSITNOM;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_VLIBEQUIPEMENT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_BSELECTED;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NB_QUEST;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_DUREE;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NEQUIPEMENT_SIT_CONTRAT_MONTANT;
        private DevExpress.XtraGrid.Columns.GridColumn G_Col_L0_NSITNUM;
    }
}