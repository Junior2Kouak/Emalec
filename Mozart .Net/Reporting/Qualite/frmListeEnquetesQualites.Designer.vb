<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeEnquetesQualites
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requise par le Concepteur Windows Form
  Private components As System.ComponentModel.IContainer

  'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
  'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
  'Ne la modifiez pas à l'aide de l'éditeur de code.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCListeFouEI = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Origine = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GColNum = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GColAction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Chaff = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BGCol_VCHEFGRP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Client = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GColSite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Intervenant = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Technicien = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GColDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DateCreation = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Auteur = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.PTB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PCOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PINF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.RTB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RCOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RINF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.OTB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.OCOR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.OINF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.VREM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.Contact = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Fonction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnSynthese = New System.Windows.Forms.Button()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.lblNbLignes = New System.Windows.Forms.Label()
        Me.lblNb = New System.Windows.Forms.Label()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpListe
        '
        Me.GrpListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpListe.Controls.Add(Me.GCListeFouEI)
        Me.GrpListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpListe.Location = New System.Drawing.Point(113, 77)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.Size = New System.Drawing.Size(1758, 761)
        Me.GrpListe.TabIndex = 10
        Me.GrpListe.TabStop = False
        '
        'GCListeFouEI
        '
        Me.GCListeFouEI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCListeFouEI.Location = New System.Drawing.Point(3, 18)
        Me.GCListeFouEI.MainView = Me.BandedGridView1
        Me.GCListeFouEI.Name = "GCListeFouEI"
        Me.GCListeFouEI.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GCListeFouEI.Size = New System.Drawing.Size(1752, 740)
        Me.GCListeFouEI.TabIndex = 1
        Me.GCListeFouEI.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.Empty.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.BandedGridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BandedGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.BandedGridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.BandedGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.Preview.Options.UseFont = True
        Me.BandedGridView1.Appearance.Preview.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.BandedGridView1.Appearance.Row.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.Row.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BandedGridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BandedGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.BandedGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.BandedGridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.BandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BandedGridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.GridBand1, Me.gridBand2, Me.GridBand3, Me.gridBand5, Me.gridBand6})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Origine, Me.GColNum, Me.GColAction, Me.Client, Me.GColSite, Me.Technicien, Me.Intervenant, Me.GColDate, Me.PTB, Me.PCOR, Me.PINF, Me.RTB, Me.RCOR, Me.RINF, Me.OTB, Me.OCOR, Me.OINF, Me.VREM, Me.Chaff, Me.Contact, Me.Fonction, Me.Auteur, Me.DateCreation, Me.BGCol_VCHEFGRP})
        Me.BandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1072, 596, 216, 208)
        Me.BandedGridView1.GridControl = Me.GCListeFouEI
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsBehavior.ReadOnly = True
        Me.BandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView1.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand4.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gridBand4.Caption = "Informations"
        Me.gridBand4.Columns.Add(Me.Origine)
        Me.gridBand4.Columns.Add(Me.GColNum)
        Me.gridBand4.Columns.Add(Me.GColAction)
        Me.gridBand4.Columns.Add(Me.Chaff)
        Me.gridBand4.Columns.Add(Me.BGCol_VCHEFGRP)
        Me.gridBand4.Columns.Add(Me.Client)
        Me.gridBand4.Columns.Add(Me.GColSite)
        Me.gridBand4.Columns.Add(Me.Intervenant)
        Me.gridBand4.Columns.Add(Me.Technicien)
        Me.gridBand4.Columns.Add(Me.GColDate)
        Me.gridBand4.Columns.Add(Me.DateCreation)
        Me.gridBand4.Columns.Add(Me.Auteur)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 0
        Me.gridBand4.Width = 989
        '
        'Origine
        '
        Me.Origine.AppearanceHeader.Options.UseTextOptions = True
        Me.Origine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Origine.Caption = "Origine"
        Me.Origine.FieldName = "ORIGINE"
        Me.Origine.Name = "Origine"
        Me.Origine.OptionsColumn.FixedWidth = True
        Me.Origine.Visible = True
        Me.Origine.Width = 58
        '
        'GColNum
        '
        Me.GColNum.AppearanceCell.Options.UseTextOptions = True
        Me.GColNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNum.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNum.Caption = "DI"
        Me.GColNum.FieldName = "NDINNUM"
        Me.GColNum.Name = "GColNum"
        Me.GColNum.OptionsColumn.AllowEdit = False
        Me.GColNum.OptionsColumn.FixedWidth = True
        Me.GColNum.OptionsColumn.ReadOnly = True
        Me.GColNum.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColNum.Visible = True
        Me.GColNum.Width = 50
        '
        'GColAction
        '
        Me.GColAction.AppearanceCell.Options.UseTextOptions = True
        Me.GColAction.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAction.AppearanceHeader.Options.UseTextOptions = True
        Me.GColAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColAction.Caption = "Action"
        Me.GColAction.FieldName = "NACTID"
        Me.GColAction.Name = "GColAction"
        Me.GColAction.OptionsColumn.FixedWidth = True
        Me.GColAction.Visible = True
        Me.GColAction.Width = 50
        '
        'Chaff
        '
        Me.Chaff.AppearanceHeader.Options.UseTextOptions = True
        Me.Chaff.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Chaff.Caption = "Chaff"
        Me.Chaff.FieldName = "VDINCHAFF"
        Me.Chaff.Name = "Chaff"
        Me.Chaff.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Chaff.Visible = True
        Me.Chaff.Width = 88
        '
        'BGCol_VCHEFGRP
        '
        Me.BGCol_VCHEFGRP.Caption = "Chef de groupe"
        Me.BGCol_VCHEFGRP.FieldName = "VCHEFGRP"
        Me.BGCol_VCHEFGRP.Name = "BGCol_VCHEFGRP"
        Me.BGCol_VCHEFGRP.Visible = True
        Me.BGCol_VCHEFGRP.Width = 95
        '
        'Client
        '
        Me.Client.AppearanceHeader.Options.UseTextOptions = True
        Me.Client.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Client.Caption = "Client"
        Me.Client.FieldName = "VCLINOM"
        Me.Client.Name = "Client"
        Me.Client.Visible = True
        Me.Client.Width = 119
        '
        'GColSite
        '
        Me.GColSite.AppearanceHeader.Options.UseTextOptions = True
        Me.GColSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColSite.Caption = "Site"
        Me.GColSite.FieldName = "VSITNOM"
        Me.GColSite.Name = "GColSite"
        Me.GColSite.Visible = True
        Me.GColSite.Width = 139
        '
        'Intervenant
        '
        Me.Intervenant.Caption = "Intervenant"
        Me.Intervenant.FieldName = "VINTER"
        Me.Intervenant.Name = "Intervenant"
        Me.Intervenant.Visible = True
        '
        'Technicien
        '
        Me.Technicien.Caption = "Technicien"
        Me.Technicien.FieldName = "VNOMTECH"
        Me.Technicien.Name = "Technicien"
        Me.Technicien.Visible = True
        '
        'GColDate
        '
        Me.GColDate.AppearanceCell.Options.UseTextOptions = True
        Me.GColDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDate.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDate.Caption = "Date ex"
        Me.GColDate.FieldName = "DACTDEX"
        Me.GColDate.Name = "GColDate"
        Me.GColDate.OptionsColumn.FixedWidth = True
        Me.GColDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColDate.Visible = True
        Me.GColDate.Width = 80
        '
        'DateCreation
        '
        Me.DateCreation.AppearanceCell.Options.UseTextOptions = True
        Me.DateCreation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DateCreation.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DateCreation.AppearanceHeader.Options.UseTextOptions = True
        Me.DateCreation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DateCreation.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DateCreation.Caption = "Date saisie"
        Me.DateCreation.FieldName = "DATESAISIE"
        Me.DateCreation.Name = "DateCreation"
        Me.DateCreation.Visible = True
        Me.DateCreation.Width = 80
        '
        'Auteur
        '
        Me.Auteur.AppearanceHeader.Options.UseTextOptions = True
        Me.Auteur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Auteur.Caption = "Auteur"
        Me.Auteur.FieldName = "VPERNOM"
        Me.Auteur.Name = "Auteur"
        Me.Auteur.Visible = True
        Me.Auteur.Width = 80
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridBand1.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Présentation"
        Me.GridBand1.Columns.Add(Me.PTB)
        Me.GridBand1.Columns.Add(Me.PCOR)
        Me.GridBand1.Columns.Add(Me.PINF)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.OptionsBand.FixedWidth = True
        Me.GridBand1.VisibleIndex = 1
        Me.GridBand1.Width = 180
        '
        'PTB
        '
        Me.PTB.AppearanceHeader.Options.UseTextOptions = True
        Me.PTB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PTB.Caption = "TB"
        Me.PTB.FieldName = "A1"
        Me.PTB.Name = "PTB"
        Me.PTB.OptionsColumn.FixedWidth = True
        Me.PTB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.PTB.Visible = True
        Me.PTB.Width = 60
        '
        'PCOR
        '
        Me.PCOR.AppearanceHeader.Options.UseTextOptions = True
        Me.PCOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PCOR.Caption = "Cor"
        Me.PCOR.FieldName = "B1"
        Me.PCOR.Name = "PCOR"
        Me.PCOR.OptionsColumn.FixedWidth = True
        Me.PCOR.Visible = True
        Me.PCOR.Width = 60
        '
        'PINF
        '
        Me.PINF.AppearanceHeader.Options.UseTextOptions = True
        Me.PINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PINF.Caption = "Insuf"
        Me.PINF.FieldName = "C1"
        Me.PINF.Name = "PINF"
        Me.PINF.OptionsColumn.FixedWidth = True
        Me.PINF.Visible = True
        Me.PINF.Width = 60
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Réalisation"
        Me.gridBand2.Columns.Add(Me.RTB)
        Me.gridBand2.Columns.Add(Me.RCOR)
        Me.gridBand2.Columns.Add(Me.RINF)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.OptionsBand.FixedWidth = True
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 180
        '
        'RTB
        '
        Me.RTB.AppearanceHeader.Options.UseTextOptions = True
        Me.RTB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RTB.Caption = "TB"
        Me.RTB.FieldName = "A2"
        Me.RTB.Name = "RTB"
        Me.RTB.OptionsColumn.FixedWidth = True
        Me.RTB.Visible = True
        Me.RTB.Width = 60
        '
        'RCOR
        '
        Me.RCOR.AppearanceHeader.Options.UseTextOptions = True
        Me.RCOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RCOR.Caption = "Cor"
        Me.RCOR.FieldName = "B2"
        Me.RCOR.Name = "RCOR"
        Me.RCOR.OptionsColumn.FixedWidth = True
        Me.RCOR.Visible = True
        Me.RCOR.Width = 60
        '
        'RINF
        '
        Me.RINF.AppearanceHeader.Options.UseTextOptions = True
        Me.RINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RINF.Caption = "Insuf"
        Me.RINF.FieldName = "C2"
        Me.RINF.Name = "RINF"
        Me.RINF.OptionsColumn.FixedWidth = True
        Me.RINF.Visible = True
        Me.RINF.Width = 60
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridBand3.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "Propreté"
        Me.GridBand3.Columns.Add(Me.OTB)
        Me.GridBand3.Columns.Add(Me.OCOR)
        Me.GridBand3.Columns.Add(Me.OINF)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.OptionsBand.FixedWidth = True
        Me.GridBand3.VisibleIndex = 3
        Me.GridBand3.Width = 180
        '
        'OTB
        '
        Me.OTB.AppearanceHeader.Options.UseTextOptions = True
        Me.OTB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OTB.Caption = "TB"
        Me.OTB.FieldName = "A3"
        Me.OTB.Name = "OTB"
        Me.OTB.OptionsColumn.FixedWidth = True
        Me.OTB.Visible = True
        Me.OTB.Width = 60
        '
        'OCOR
        '
        Me.OCOR.AppearanceHeader.Options.UseTextOptions = True
        Me.OCOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OCOR.Caption = "Cor"
        Me.OCOR.FieldName = "B3"
        Me.OCOR.Name = "OCOR"
        Me.OCOR.OptionsColumn.FixedWidth = True
        Me.OCOR.Visible = True
        Me.OCOR.Width = 60
        '
        'OINF
        '
        Me.OINF.AppearanceHeader.Options.UseTextOptions = True
        Me.OINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.OINF.Caption = "Insuf"
        Me.OINF.FieldName = "C3"
        Me.OINF.Name = "OINF"
        Me.OINF.OptionsColumn.FixedWidth = True
        Me.OINF.Visible = True
        Me.OINF.Width = 60
        '
        'gridBand5
        '
        Me.gridBand5.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand5.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand5.Caption = "Remarques"
        Me.gridBand5.Columns.Add(Me.VREM)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 4
        Me.gridBand5.Width = 155
        '
        'VREM
        '
        Me.VREM.AppearanceCell.Options.UseTextOptions = True
        Me.VREM.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VREM.AppearanceHeader.Options.UseTextOptions = True
        Me.VREM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VREM.Caption = "Remarques"
        Me.VREM.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.VREM.FieldName = "VREM"
        Me.VREM.Name = "VREM"
        Me.VREM.Visible = True
        Me.VREM.Width = 155
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'gridBand6
        '
        Me.gridBand6.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand6.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand6.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand6.Caption = "Contact"
        Me.gridBand6.Columns.Add(Me.Contact)
        Me.gridBand6.Columns.Add(Me.Fonction)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 5
        Me.gridBand6.Width = 217
        '
        'Contact
        '
        Me.Contact.AppearanceHeader.Options.UseTextOptions = True
        Me.Contact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Contact.Caption = "Contact"
        Me.Contact.FieldName = "VNOMLOG"
        Me.Contact.Name = "Contact"
        Me.Contact.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Contact.Visible = True
        Me.Contact.Width = 99
        '
        'Fonction
        '
        Me.Fonction.AppearanceHeader.Options.UseTextOptions = True
        Me.Fonction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Fonction.Caption = "Fonction"
        Me.Fonction.FieldName = "VFONCTION"
        Me.Fonction.Name = "Fonction"
        Me.Fonction.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Fonction.Visible = True
        Me.Fonction.Width = 118
        '
        'GrpActions
        '
        Me.GrpActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrpActions.Controls.Add(Me.btnSynthese)
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(11, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(96, 856)
        Me.GrpActions.TabIndex = 9
        Me.GrpActions.TabStop = False
        '
        'btnSynthese
        '
        Me.btnSynthese.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSynthese.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSynthese.Location = New System.Drawing.Point(5, 178)
        Me.btnSynthese.Name = "btnSynthese"
        Me.btnSynthese.Size = New System.Drawing.Size(84, 48)
        Me.btnSynthese.TabIndex = 48
        Me.btnSynthese.Text = "Synthèse"
        Me.btnSynthese.UseVisualStyleBackColor = True
        '
        'ButtonExporter
        '
        Me.ButtonExporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonExporter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonExporter.Location = New System.Drawing.Point(6, 111)
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.Size = New System.Drawing.Size(84, 48)
        Me.ButtonExporter.TabIndex = 47
        Me.ButtonExporter.Text = "Exporter liste (xls)"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(6, 44)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(83, 48)
        Me.BtnPrint.TabIndex = 46
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(7, 809)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(83, 41)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(119, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(1173, 26)
        Me.LblTitre.TabIndex = 13
        Me.LblTitre.Text = "Liste des enquêtes qualités"
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(812, 41)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(88, 31)
        Me.BtValider.TabIndex = 92
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(467, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 27)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Au"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(120, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 27)
        Me.Label26.TabIndex = 90
        Me.Label26.Text = "Du :"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(516, 47)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(278, 20)
        Me.DTPFin.TabIndex = 89
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(176, 47)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(278, 20)
        Me.DTPDebut.TabIndex = 88
        '
        'lblNbLignes
        '
        Me.lblNbLignes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNbLignes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbLignes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNbLignes.Location = New System.Drawing.Point(858, 841)
        Me.lblNbLignes.Name = "lblNbLignes"
        Me.lblNbLignes.Size = New System.Drawing.Size(285, 27)
        Me.lblNbLignes.TabIndex = 93
        Me.lblNbLignes.Text = "Nombre d'enquêtes de la sélection :"
        Me.lblNbLignes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNb
        '
        Me.lblNb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNb.Location = New System.Drawing.Point(1149, 841)
        Me.lblNb.Name = "lblNb"
        Me.lblNb.Size = New System.Drawing.Size(72, 27)
        Me.lblNb.TabIndex = 94
        Me.lblNb.Text = "Nombre"
        Me.lblNb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmListeEnquetesQualites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.ClientSize = New System.Drawing.Size(1883, 877)
        Me.Controls.Add(Me.lblNb)
        Me.Controls.Add(Me.lblNbLignes)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DTPFin)
        Me.Controls.Add(Me.DTPDebut)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpListe)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmListeEnquetesQualites"
        Me.Text = "Liste des enquêtes qualités"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCListeFouEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpListe As GroupBox
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents BtnFermer As Button
  Private WithEvents GCListeFouEI As DevExpress.XtraGrid.GridControl
  Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
  Friend WithEvents GColNum As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GColAction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GColSite As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents GColDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents PTB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents PCOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents PINF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents RTB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents RCOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents RINF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents OTB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents OCOR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents OINF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents Client As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents Origine As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents LblTitre As Label
  Friend WithEvents ButtonExporter As Button
  Friend WithEvents BtnPrint As Button
    Friend WithEvents VREM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Chaff As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Contact As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Fonction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DateCreation As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Auteur As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Intervenant As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSynthese As Button
    Friend WithEvents BGCol_VCHEFGRP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BtValider As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
    Friend WithEvents lblNbLignes As Label
    Friend WithEvents lblNb As Label
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Technicien As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
