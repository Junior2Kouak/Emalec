<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatNotationParSTT
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.DTPFin = New System.Windows.Forms.DateTimePicker()
    Me.GrpListe = New System.Windows.Forms.GroupBox()
    Me.GCListe = New DevExpress.XtraGrid.GridControl()
    Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
    Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.Prestataire = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.NBCONTRAT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.CA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.AD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.AF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.MB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.MA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.MOY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.ButtonExporter = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(456, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Au"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(109, 44)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 27)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Du :"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(505, 44)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(278, 20)
        Me.DTPFin.TabIndex = 26
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListe)
        Me.GrpListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpListe.Location = New System.Drawing.Point(107, 70)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.Size = New System.Drawing.Size(1376, 680)
        Me.GrpListe.TabIndex = 23
        Me.GrpListe.TabStop = False
        '
        'GCListe
        '
        Me.GCListe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCListe.Location = New System.Drawing.Point(3, 18)
        Me.GCListe.MainView = Me.AdvBandedGridView1
        Me.GCListe.Name = "GCListe"
        Me.GCListe.Size = New System.Drawing.Size(1370, 659)
        Me.GCListe.TabIndex = 1
        Me.GCListe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView1})
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.Empty.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.AdvBandedGridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.AdvBandedGridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.Preview.Options.UseFont = True
        Me.AdvBandedGridView1.Appearance.Preview.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.AdvBandedGridView1.Appearance.Row.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.Row.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.AdvBandedGridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.AdvBandedGridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.AdvBandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AdvBandedGridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.GridBand1, Me.gridBand2, Me.GridBand3})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Prestataire, Me.NBCONTRAT, Me.CA, Me.CC, Me.AD, Me.AF, Me.MB, Me.MA, Me.MOY})
        Me.AdvBandedGridView1.GridControl = Me.GCListe
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsBehavior.Editable = False
        Me.AdvBandedGridView1.OptionsBehavior.ReadOnly = True
        Me.AdvBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.AdvBandedGridView1.OptionsView.EnableAppearanceOddRow = True
        Me.AdvBandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'gridBand4
        '
        Me.gridBand4.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand4.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand4.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand4.Caption = "Informations"
        Me.gridBand4.Columns.Add(Me.Prestataire)
        Me.gridBand4.Columns.Add(Me.NBCONTRAT)
        Me.gridBand4.Columns.Add(Me.CA)
        Me.gridBand4.Columns.Add(Me.CC)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.OptionsBand.FixedWidth = True
        Me.gridBand4.VisibleIndex = 0
        Me.gridBand4.Width = 432
        '
        'Prestataire
        '
        Me.Prestataire.Caption = "Prestataire"
        Me.Prestataire.FieldName = "VSTFGRPNOM"
        Me.Prestataire.Name = "Prestataire"
        Me.Prestataire.OptionsColumn.AllowEdit = False
        Me.Prestataire.OptionsColumn.ReadOnly = True
        Me.Prestataire.Visible = True
        Me.Prestataire.Width = 189
        '
        'NBCONTRAT
        '
        Me.NBCONTRAT.AppearanceCell.Options.UseTextOptions = True
        Me.NBCONTRAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBCONTRAT.AppearanceHeader.Options.UseTextOptions = True
        Me.NBCONTRAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBCONTRAT.Caption = "Nb contrats"
        Me.NBCONTRAT.FieldName = "NBCONTRAT"
        Me.NBCONTRAT.Name = "NBCONTRAT"
        Me.NBCONTRAT.Visible = True
        Me.NBCONTRAT.Width = 81
        '
        'CA
        '
        Me.CA.AppearanceCell.Options.UseTextOptions = True
        Me.CA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CA.AppearanceHeader.Options.UseTextOptions = True
        Me.CA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CA.Caption = "Total CA HT"
        Me.CA.DisplayFormat.FormatString = "c0"
        Me.CA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CA.FieldName = "CA"
        Me.CA.Name = "CA"
        Me.CA.Visible = True
        Me.CA.Width = 77
        '
        'CC
        '
        Me.CC.AppearanceCell.Options.UseTextOptions = True
        Me.CC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CC.AppearanceHeader.Options.UseTextOptions = True
        Me.CC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CC.Caption = "Contrat Cadre"
        Me.CC.FieldName = "CONTRATCADRE"
        Me.CC.Name = "CC"
        Me.CC.Visible = True
        Me.CC.Width = 85
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridBand1.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Moyennes des notes automatiques"
        Me.GridBand1.Columns.Add(Me.AD)
        Me.GridBand1.Columns.Add(Me.AF)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.OptionsBand.FixedWidth = True
        Me.GridBand1.VisibleIndex = 1
        Me.GridBand1.Width = 319
        '
        'AD
        '
        Me.AD.AppearanceCell.Options.UseTextOptions = True
        Me.AD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AD.AppearanceHeader.Options.UseTextOptions = True
        Me.AD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AD.Caption = "Délai réception devis"
        Me.AD.FieldName = "AD"
        Me.AD.Name = "AD"
        Me.AD.Visible = True
        Me.AD.Width = 158
        '
        'AF
        '
        Me.AF.AppearanceCell.Options.UseTextOptions = True
        Me.AF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AF.AppearanceHeader.Options.UseTextOptions = True
        Me.AF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AF.Caption = "Délai réception factures"
        Me.AF.FieldName = "AF"
        Me.AF.Name = "AF"
        Me.AF.Visible = True
        Me.AF.Width = 161
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Moyennes des notes manuelles"
        Me.gridBand2.Columns.Add(Me.MB)
        Me.gridBand2.Columns.Add(Me.MA)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.OptionsBand.FixedWidth = True
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 385
        '
        'MB
        '
        Me.MB.AppearanceCell.Options.UseTextOptions = True
        Me.MB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MB.AppearanceHeader.Options.UseTextOptions = True
        Me.MB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MB.Caption = "Fonctionnement avant intervention"
        Me.MB.FieldName = "MB"
        Me.MB.Name = "MB"
        Me.MB.Visible = True
        Me.MB.Width = 196
        '
        'MA
        '
        Me.MA.AppearanceCell.Options.UseTextOptions = True
        Me.MA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MA.AppearanceHeader.Options.UseTextOptions = True
        Me.MA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MA.Caption = "Fonctionnement après intervention"
        Me.MA.FieldName = "MA"
        Me.MA.Name = "MA"
        Me.MA.Visible = True
        Me.MA.Width = 189
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Columns.Add(Me.MOY)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.OptionsBand.FixedWidth = True
        Me.GridBand3.VisibleIndex = 3
        Me.GridBand3.Width = 164
        '
        'MOY
        '
        Me.MOY.AppearanceCell.Options.UseTextOptions = True
        Me.MOY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MOY.AppearanceHeader.Options.UseTextOptions = True
        Me.MOY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MOY.Caption = "Note totale moyenne du sst"
        Me.MOY.FieldName = "MOY"
        Me.MOY.Name = "MOY"
        Me.MOY.Visible = True
        Me.MOY.Width = 164
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(165, 44)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(278, 20)
        Me.DTPDebut.TabIndex = 25
        '
        'ButtonExporter
        '
        Me.ButtonExporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonExporter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonExporter.Location = New System.Drawing.Point(5, 108)
        Me.ButtonExporter.Name = "ButtonExporter"
        Me.ButtonExporter.Size = New System.Drawing.Size(84, 48)
        Me.ButtonExporter.TabIndex = 45
        Me.ButtonExporter.Text = "Exporter liste (xls)"
        Me.ButtonExporter.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrint.Location = New System.Drawing.Point(5, 41)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(83, 48)
        Me.BtnPrint.TabIndex = 44
        Me.BtnPrint.Text = "Imprimer"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(6, 629)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(83, 41)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(7, 8)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(94, 676)
        Me.GrpActions.TabIndex = 22
        Me.GrpActions.TabStop = False
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(105, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(744, 26)
        Me.LblTitre.TabIndex = 24
        Me.LblTitre.Text = "Détail des notations par prestataire"
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(812, 38)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(88, 31)
        Me.BtValider.TabIndex = 87
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'frmStatNotationParSTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1495, 762)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DTPFin)
        Me.Controls.Add(Me.GrpListe)
        Me.Controls.Add(Me.DTPDebut)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatNotationParSTT"
        Me.Text = "Notations par prestataire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents Label26 As Label
  Friend WithEvents DTPFin As DateTimePicker
  Friend WithEvents GrpListe As GroupBox
  Private WithEvents GCListe As DevExpress.XtraGrid.GridControl
  Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
  Friend WithEvents NBCONTRAT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents Prestataire As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents CA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents AD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents AF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents MB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents MA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents MOY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents DTPDebut As DateTimePicker
  Friend WithEvents ButtonExporter As Button
  Friend WithEvents BtnPrint As Button
  Friend WithEvents BtnFermer As Button
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents LblTitre As Label
  Friend WithEvents BtValider As Button
  Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents CC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
