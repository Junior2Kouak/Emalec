
namespace MozartCS.AdminCompta
{
  partial class frmBudget_Saison
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
      this.GrpActions = new System.Windows.Forms.GroupBox();
      this.BtnQuit = new System.Windows.Forms.Button();
      this.BtnSave = new System.Windows.Forms.Button();
      this.GrpCriteres = new System.Windows.Forms.GroupBox();
      this.BtnValid = new System.Windows.Forms.Button();
      this.DateEditAnnee = new DevExpress.XtraEditors.DateEdit();
      this.LblTitre = new System.Windows.Forms.Label();
      this.PVT_BudgetSaison = new DevExpress.XtraPivotGrid.PivotGridControl();
      this.PGF_NMOIS = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_NVAL = new DevExpress.XtraPivotGrid.PivotGridField();
      this.PGF_NANNEE = new DevExpress.XtraPivotGrid.PivotGridField();
      this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.GrpActions.SuspendLayout();
      this.GrpCriteres.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PVT_BudgetSaison)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
      this.SuspendLayout();
      // 
      // GrpActions
      // 
      this.GrpActions.Controls.Add(this.BtnQuit);
      this.GrpActions.Controls.Add(this.BtnSave);
      this.GrpActions.Location = new System.Drawing.Point(12, 12);
      this.GrpActions.Name = "GrpActions";
      this.GrpActions.Size = new System.Drawing.Size(181, 263);
      this.GrpActions.TabIndex = 7;
      this.GrpActions.TabStop = false;
      // 
      // BtnQuit
      // 
      this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnQuit.Location = new System.Drawing.Point(16, 209);
      this.BtnQuit.Name = "BtnQuit";
      this.BtnQuit.Size = new System.Drawing.Size(150, 45);
      this.BtnQuit.TabIndex = 1;
      this.BtnQuit.Text = "Fermer";
      this.BtnQuit.UseVisualStyleBackColor = true;
      this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
      // 
      // BtnSave
      // 
      this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnSave.Location = new System.Drawing.Point(16, 30);
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(150, 45);
      this.BtnSave.TabIndex = 0;
      this.BtnSave.Text = "Enregistrer";
      this.BtnSave.UseVisualStyleBackColor = true;
      this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // GrpCriteres
      // 
      this.GrpCriteres.Controls.Add(this.BtnValid);
      this.GrpCriteres.Controls.Add(this.DateEditAnnee);
      this.GrpCriteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.GrpCriteres.Location = new System.Drawing.Point(210, 53);
      this.GrpCriteres.Name = "GrpCriteres";
      this.GrpCriteres.Size = new System.Drawing.Size(1056, 73);
      this.GrpCriteres.TabIndex = 8;
      this.GrpCriteres.TabStop = false;
      this.GrpCriteres.Text = "Sélectionner l\'année";
      // 
      // BtnValid
      // 
      this.BtnValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnValid.Location = new System.Drawing.Point(306, 27);
      this.BtnValid.Name = "BtnValid";
      this.BtnValid.Size = new System.Drawing.Size(98, 29);
      this.BtnValid.TabIndex = 11;
      this.BtnValid.Text = "Valider";
      this.BtnValid.UseVisualStyleBackColor = true;
      this.BtnValid.Click += new System.EventHandler(this.BtnValid_Click);
      // 
      // DateEditAnnee
      // 
      this.DateEditAnnee.EditValue = null;
      this.DateEditAnnee.Location = new System.Drawing.Point(70, 32);
      this.DateEditAnnee.Name = "DateEditAnnee";
      this.DateEditAnnee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DateEditAnnee.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.DateEditAnnee.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
      this.DateEditAnnee.Properties.DisplayFormat.FormatString = "y";
      this.DateEditAnnee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.DateEditAnnee.Properties.EditFormat.FormatString = "y";
      this.DateEditAnnee.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.DateEditAnnee.Properties.Mask.EditMask = "yyyy";
      this.DateEditAnnee.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.DateEditAnnee.Properties.ShowMonthHeaders = false;
      this.DateEditAnnee.Properties.ShowToday = false;
      this.DateEditAnnee.Properties.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
      this.DateEditAnnee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.DateEditAnnee.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
      this.DateEditAnnee.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
      this.DateEditAnnee.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
      this.DateEditAnnee.Size = new System.Drawing.Size(230, 20);
      this.DateEditAnnee.TabIndex = 10;
      // 
      // LblTitre
      // 
      this.LblTitre.AutoSize = true;
      this.LblTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.LblTitre.Location = new System.Drawing.Point(205, 12);
      this.LblTitre.Name = "LblTitre";
      this.LblTitre.Size = new System.Drawing.Size(466, 29);
      this.LblTitre.TabIndex = 9;
      this.LblTitre.Text = "Saisie de la saisonnalité pour le budget";
      // 
      // PVT_BudgetSaison
      // 
      this.PVT_BudgetSaison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PVT_BudgetSaison.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PVT_BudgetSaison.Appearance.FieldHeader.Options.UseFont = true;
      this.PVT_BudgetSaison.Appearance.FieldHeader.Options.UseTextOptions = true;
      this.PVT_BudgetSaison.Appearance.FieldHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PVT_BudgetSaison.Appearance.FieldHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PVT_BudgetSaison.Appearance.FieldHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.PVT_BudgetSaison.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.PGF_NMOIS,
            this.PGF_NVAL,
            this.PGF_NANNEE});
      this.PVT_BudgetSaison.Location = new System.Drawing.Point(210, 132);
      this.PVT_BudgetSaison.Name = "PVT_BudgetSaison";
      this.PVT_BudgetSaison.OptionsView.ShowColumnGrandTotalHeader = false;
      this.PVT_BudgetSaison.OptionsView.ShowColumnGrandTotals = false;
      this.PVT_BudgetSaison.OptionsView.ShowColumnHeaders = false;
      this.PVT_BudgetSaison.OptionsView.ShowColumnTotals = false;
      this.PVT_BudgetSaison.OptionsView.ShowDataHeaders = false;
      this.PVT_BudgetSaison.OptionsView.ShowFilterHeaders = false;
      this.PVT_BudgetSaison.OptionsView.ShowFilterSeparatorBar = false;
      this.PVT_BudgetSaison.OptionsView.ShowRowGrandTotalHeader = false;
      this.PVT_BudgetSaison.OptionsView.ShowRowGrandTotals = false;
      this.PVT_BudgetSaison.OptionsView.ShowRowHeaders = false;
      this.PVT_BudgetSaison.OptionsView.ShowRowTotals = false;
      this.PVT_BudgetSaison.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
      this.PVT_BudgetSaison.Size = new System.Drawing.Size(1203, 143);
      this.PVT_BudgetSaison.TabIndex = 10;
      this.PVT_BudgetSaison.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.PVT_BudgetSaison_FieldValueDisplayText);
      this.PVT_BudgetSaison.EditValueChanged += new DevExpress.XtraPivotGrid.EditValueChangedEventHandler(this.PVT_BudgetSaison_EditValueChanged);
      // 
      // PGF_NMOIS
      // 
      this.PGF_NMOIS.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGF_NMOIS.Appearance.Cell.Options.UseFont = true;
      this.PGF_NMOIS.Appearance.Cell.Options.UseTextOptions = true;
      this.PGF_NMOIS.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_NMOIS.Appearance.Cell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PGF_NMOIS.Appearance.Cell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.PGF_NMOIS.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGF_NMOIS.Appearance.Header.Options.UseFont = true;
      this.PGF_NMOIS.Appearance.Header.Options.UseTextOptions = true;
      this.PGF_NMOIS.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_NMOIS.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PGF_NMOIS.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.PGF_NMOIS.Appearance.Value.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      this.PGF_NMOIS.Appearance.Value.Options.UseFont = true;
      this.PGF_NMOIS.Appearance.Value.Options.UseTextOptions = true;
      this.PGF_NMOIS.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.PGF_NMOIS.Appearance.Value.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.PGF_NMOIS.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.PGF_NMOIS.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
      this.PGF_NMOIS.AreaIndex = 0;
      this.PGF_NMOIS.FieldName = "NMOIS";
      this.PGF_NMOIS.Name = "PGF_NMOIS";
      this.PGF_NMOIS.Width = 75;
      // 
      // PGF_NVAL
      // 
      this.PGF_NVAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
      this.PGF_NVAL.AreaIndex = 0;
      this.PGF_NVAL.CellFormat.FormatString = "n2";
      this.PGF_NVAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.PGF_NVAL.FieldEdit = this.repositoryItemTextEdit1;
      this.PGF_NVAL.FieldName = "NVAL";
      this.PGF_NVAL.Name = "PGF_NVAL";
      this.PGF_NVAL.ValueFormat.FormatString = "n2";
      this.PGF_NVAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      // 
      // PGF_NANNEE
      // 
      this.PGF_NANNEE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
      this.PGF_NANNEE.AreaIndex = 0;
      this.PGF_NANNEE.Caption = "Année";
      this.PGF_NANNEE.FieldName = "NANNEE";
      this.PGF_NANNEE.Name = "PGF_NANNEE";
      // 
      // repositoryItemTextEdit1
      // 
      this.repositoryItemTextEdit1.AutoHeight = false;
      this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
      this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.repositoryItemTextEdit1.EditFormat.FormatString = "n2";
      this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.repositoryItemTextEdit1.Mask.EditMask = "n2";
      this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
      this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
      this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
      // 
      // frmBudget_Saison
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1425, 287);
      this.Controls.Add(this.PVT_BudgetSaison);
      this.Controls.Add(this.GrpActions);
      this.Controls.Add(this.GrpCriteres);
      this.Controls.Add(this.LblTitre);
      this.Name = "frmBudget_Saison";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Saisie de la saisonnalité pour le budget";
      this.Load += new System.EventHandler(this.frmBudget_Gestion_Load);
      this.GrpActions.ResumeLayout(false);
      this.GrpCriteres.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DateEditAnnee.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PVT_BudgetSaison)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.GroupBox GrpActions;
    internal System.Windows.Forms.Button BtnQuit;
    internal System.Windows.Forms.Button BtnSave;
    internal System.Windows.Forms.GroupBox GrpCriteres;
    internal System.Windows.Forms.Label LblTitre;
    private DevExpress.XtraEditors.DateEdit DateEditAnnee;
    internal System.Windows.Forms.Button BtnValid;
    private DevExpress.XtraPivotGrid.PivotGridControl PVT_BudgetSaison;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_NMOIS;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_NVAL;
    private DevExpress.XtraPivotGrid.PivotGridField PGF_NANNEE;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
  }
}