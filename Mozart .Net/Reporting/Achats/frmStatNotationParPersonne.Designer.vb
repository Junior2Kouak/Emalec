<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatNotationParPersonne
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
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.GCListe = New DevExpress.XtraGrid.GridControl()
    Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
    Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.Personnel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.Fonction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.NBNOTE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.B1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.B2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.B3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.B4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.B5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
    Me.A1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.A2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.A3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.A4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.A5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
    Me.GrpListe = New System.Windows.Forms.GroupBox()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.DTPFin = New System.Windows.Forms.DateTimePicker()
    Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.BtValider = New System.Windows.Forms.Button()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpListe.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTitre.Location = New System.Drawing.Point(113, 12)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(781, 26)
        Me.LblTitre.TabIndex = 16
        Me.LblTitre.Text = "Détail des notations par personne"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.ButtonExporter)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Location = New System.Drawing.Point(12, 12)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.Size = New System.Drawing.Size(94, 676)
        Me.GrpActions.TabIndex = 14
        Me.GrpActions.TabStop = False
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
        'GCListe
        '
        Me.GCListe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCListe.Location = New System.Drawing.Point(3, 18)
        Me.GCListe.MainView = Me.AdvBandedGridView1
        Me.GCListe.Name = "GCListe"
        Me.GCListe.Size = New System.Drawing.Size(1310, 593)
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
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand4, Me.GridBand1, Me.gridBand2})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.Personnel, Me.Fonction, Me.NBNOTE, Me.B1, Me.B2, Me.B3, Me.B4, Me.B5, Me.A1, Me.A2, Me.A3, Me.A4, Me.A5})
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
        Me.gridBand4.Columns.Add(Me.Personnel)
        Me.gridBand4.Columns.Add(Me.Fonction)
        Me.gridBand4.Columns.Add(Me.NBNOTE)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.OptionsBand.FixedWidth = True
        Me.gridBand4.VisibleIndex = 0
        Me.gridBand4.Width = 457
        '
        'Personnel
        '
        Me.Personnel.Caption = "Personnel"
        Me.Personnel.FieldName = "VPERNOM"
        Me.Personnel.Name = "Personnel"
        Me.Personnel.OptionsColumn.AllowEdit = False
        Me.Personnel.OptionsColumn.ReadOnly = True
        Me.Personnel.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.Personnel.Visible = True
        Me.Personnel.Width = 162
        '
        'Fonction
        '
        Me.Fonction.AppearanceHeader.Options.UseTextOptions = True
        Me.Fonction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Fonction.Caption = "Fonction"
        Me.Fonction.FieldName = "FONCTION"
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Visible = True
        Me.Fonction.Width = 117
        '
        'NBNOTE
        '
        Me.NBNOTE.AppearanceCell.Options.UseTextOptions = True
        Me.NBNOTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBNOTE.AppearanceHeader.Options.UseTextOptions = True
        Me.NBNOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NBNOTE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.NBNOTE.AutoFillDown = True
        Me.NBNOTE.Caption = "Nombre de notations effectuées"
        Me.NBNOTE.FieldName = "NBNOTE"
        Me.NBNOTE.Name = "NBNOTE"
        Me.NBNOTE.Visible = True
        Me.NBNOTE.Width = 178
        '
        'GridBand1
        '
        Me.GridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GridBand1.AppearanceHeader.Options.UseForeColor = True
        Me.GridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand1.Caption = "Nombre de notes attribuée sur fonctionnement avant intervention"
        Me.GridBand1.Columns.Add(Me.B1)
        Me.GridBand1.Columns.Add(Me.B2)
        Me.GridBand1.Columns.Add(Me.B3)
        Me.GridBand1.Columns.Add(Me.B4)
        Me.GridBand1.Columns.Add(Me.B5)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.OptionsBand.FixedWidth = True
        Me.GridBand1.VisibleIndex = 1
        Me.GridBand1.Width = 389
        '
        'B1
        '
        Me.B1.AppearanceCell.Options.UseTextOptions = True
        Me.B1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B1.AppearanceHeader.Options.UseTextOptions = True
        Me.B1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B1.Caption = "Excellent"
        Me.B1.FieldName = "B1"
        Me.B1.Name = "B1"
        Me.B1.Visible = True
        '
        'B2
        '
        Me.B2.AppearanceCell.Options.UseTextOptions = True
        Me.B2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B2.AppearanceHeader.Options.UseTextOptions = True
        Me.B2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B2.Caption = "Très satisfaisant"
        Me.B2.FieldName = "B2"
        Me.B2.Name = "B2"
        Me.B2.Visible = True
        Me.B2.Width = 89
        '
        'B3
        '
        Me.B3.AppearanceCell.Options.UseTextOptions = True
        Me.B3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B3.AppearanceHeader.Options.UseTextOptions = True
        Me.B3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B3.Caption = "Satisfaisant"
        Me.B3.FieldName = "B3"
        Me.B3.Name = "B3"
        Me.B3.Visible = True
        '
        'B4
        '
        Me.B4.AppearanceCell.Options.UseTextOptions = True
        Me.B4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B4.AppearanceHeader.Options.UseTextOptions = True
        Me.B4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B4.Caption = "Moyen"
        Me.B4.FieldName = "B4"
        Me.B4.Name = "B4"
        Me.B4.Visible = True
        '
        'B5
        '
        Me.B5.AppearanceCell.Options.UseTextOptions = True
        Me.B5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B5.AppearanceHeader.Options.UseTextOptions = True
        Me.B5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.B5.Caption = "Médiocre"
        Me.B5.FieldName = "B5"
        Me.B5.Name = "B5"
        Me.B5.Visible = True
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.gridBand2.AppearanceHeader.Options.UseForeColor = True
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Nombre de notes attribuée sur fonctionnement après l' intervention"
        Me.gridBand2.Columns.Add(Me.A1)
        Me.gridBand2.Columns.Add(Me.A2)
        Me.gridBand2.Columns.Add(Me.A3)
        Me.gridBand2.Columns.Add(Me.A4)
        Me.gridBand2.Columns.Add(Me.A5)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.OptionsBand.FixedWidth = True
        Me.gridBand2.VisibleIndex = 2
        Me.gridBand2.Width = 407
        '
        'A1
        '
        Me.A1.AppearanceCell.Options.UseTextOptions = True
        Me.A1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A1.AppearanceHeader.Options.UseTextOptions = True
        Me.A1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A1.Caption = "Excellent"
        Me.A1.FieldName = "A1"
        Me.A1.Name = "A1"
        Me.A1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.A1.Visible = True
        Me.A1.Width = 79
        '
        'A2
        '
        Me.A2.AppearanceCell.Options.UseTextOptions = True
        Me.A2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A2.AppearanceHeader.Options.UseTextOptions = True
        Me.A2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A2.Caption = "Très satisfaisant"
        Me.A2.FieldName = "A2"
        Me.A2.Name = "A2"
        Me.A2.Visible = True
        Me.A2.Width = 96
        '
        'A3
        '
        Me.A3.AppearanceCell.Options.UseTextOptions = True
        Me.A3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A3.AppearanceHeader.Options.UseTextOptions = True
        Me.A3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A3.Caption = "Satisfaisant"
        Me.A3.FieldName = "A3"
        Me.A3.Name = "A3"
        Me.A3.Visible = True
        Me.A3.Width = 71
        '
        'A4
        '
        Me.A4.AppearanceCell.Options.UseTextOptions = True
        Me.A4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A4.AppearanceHeader.Options.UseTextOptions = True
        Me.A4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A4.Caption = "Moyen"
        Me.A4.FieldName = "A4"
        Me.A4.Name = "A4"
        Me.A4.Visible = True
        Me.A4.Width = 61
        '
        'A5
        '
        Me.A5.AppearanceCell.Options.UseTextOptions = True
        Me.A5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A5.AppearanceHeader.Options.UseTextOptions = True
        Me.A5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.A5.Caption = "Médiocre"
        Me.A5.FieldName = "A5"
        Me.A5.Name = "A5"
        Me.A5.Visible = True
        Me.A5.Width = 100
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCListe)
        Me.GrpListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GrpListe.Location = New System.Drawing.Point(112, 74)
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.Size = New System.Drawing.Size(1316, 614)
        Me.GrpListe.TabIndex = 15
        Me.GrpListe.TabStop = False
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(114, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 27)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Du :"
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(510, 48)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(278, 20)
        Me.DTPFin.TabIndex = 18
        '
        'DTPDebut
        '
        Me.DTPDebut.Location = New System.Drawing.Point(170, 48)
        Me.DTPDebut.Name = "DTPDebut"
        Me.DTPDebut.Size = New System.Drawing.Size(278, 20)
        Me.DTPDebut.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(461, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 27)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Au"
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtValider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtValider.Location = New System.Drawing.Point(806, 42)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(88, 31)
        Me.BtValider.TabIndex = 87
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'frmStatNotationParPersonne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1533, 773)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.DTPFin)
        Me.Controls.Add(Me.DTPDebut)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpListe)
        Me.Name = "frmStatNotationParPersonne"
        Me.Text = "Notations par personne"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCListe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpListe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitre As Label
  Friend WithEvents GrpActions As GroupBox
  Friend WithEvents BtnFermer As Button
  Private WithEvents GCListe As DevExpress.XtraGrid.GridControl
  Friend WithEvents GrpListe As GroupBox
  Friend WithEvents ButtonExporter As Button
  Friend WithEvents BtnPrint As Button
  Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
  Friend WithEvents Personnel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents Fonction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents NBNOTE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents A1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents A2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents A3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents A4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents A5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents Label26 As Label
  Friend WithEvents DTPFin As DateTimePicker
  Friend WithEvents DTPDebut As DateTimePicker
  Friend WithEvents Label1 As Label
  Friend WithEvents BtValider As Button
  Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
  Friend WithEvents B1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents B2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents B3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents B4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents B5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
  Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
