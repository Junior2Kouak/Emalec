<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportingGeographique
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportingGeographique))
    Me.Button1 = New System.Windows.Forms.Button()
    Me.ComboBoxTech = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.ComboBoxPrest = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblPourcCorse = New System.Windows.Forms.Label()
    Me.lblPourcProvence = New System.Windows.Forms.Label()
    Me.lblPourcAuvergne = New System.Windows.Forms.Label()
    Me.lblPourcLanguedoc = New System.Windows.Forms.Label()
    Me.lblPourcAquitaine = New System.Windows.Forms.Label()
    Me.lblPourcBourgogne = New System.Windows.Forms.Label()
    Me.lblPourcPaysLoire = New System.Windows.Forms.Label()
    Me.lblPourcAlsace = New System.Windows.Forms.Label()
    Me.lblPourcIDF = New System.Windows.Forms.Label()
    Me.lblPourcCentre = New System.Windows.Forms.Label()
    Me.lblPourcNord = New System.Windows.Forms.Label()
    Me.lblPourcNormandie = New System.Windows.Forms.Label()
    Me.lblPourcBretagne = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.GCRECEPTIONS = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColREGION = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.CA = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditGTPLot = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepIGLUpEditViewLot = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColLOTIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTNGTPLOTID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColLOTVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepItemGLUpEditUnite = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
    Me.RepItemGLUpEditViewUnite = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColUNITEIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITENGTPUNITEID = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColUNITEVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupBox1.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Button1
    '
    resources.ApplyResources(Me.Button1, "Button1")
    Me.Button1.Name = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'ComboBoxTech
    '
    Me.ComboBoxTech.DisplayMember = "VTECLIB"
    Me.ComboBoxTech.FormattingEnabled = True
    resources.ApplyResources(Me.ComboBoxTech, "ComboBoxTech")
    Me.ComboBoxTech.Name = "ComboBoxTech"
    Me.ComboBoxTech.ValueMember = "CTECCOD"
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.ButtonExporter)
    Me.GroupBox1.Controls.Add(Me.BtnFermer)
    Me.GroupBox1.Controls.Add(Me.BtnPrint)
    resources.ApplyResources(Me.GroupBox1, "GroupBox1")
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.TabStop = False
    '
    'ButtonExporter
    '
    resources.ApplyResources(Me.ButtonExporter, "ButtonExporter")
    Me.ButtonExporter.Name = "ButtonExporter"
    Me.ButtonExporter.UseVisualStyleBackColor = True
    '
    'BtnFermer
    '
    resources.ApplyResources(Me.BtnFermer, "BtnFermer")
    Me.BtnFermer.Name = "BtnFermer"
    Me.BtnFermer.UseVisualStyleBackColor = True
    '
    'BtnPrint
    '
    resources.ApplyResources(Me.BtnPrint, "BtnPrint")
    Me.BtnPrint.Name = "BtnPrint"
    Me.BtnPrint.UseVisualStyleBackColor = True
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'ComboBoxPrest
    '
    Me.ComboBoxPrest.DisplayMember = "VPRELIB"
    Me.ComboBoxPrest.FormattingEnabled = True
    resources.ApplyResources(Me.ComboBoxPrest, "ComboBoxPrest")
    Me.ComboBoxPrest.Name = "ComboBoxPrest"
    Me.ComboBoxPrest.ValueMember = "CPRECOD"
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'lblPourcCorse
    '
    Me.lblPourcCorse.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcCorse, "lblPourcCorse")
    Me.lblPourcCorse.Name = "lblPourcCorse"
    '
    'lblPourcProvence
    '
    Me.lblPourcProvence.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcProvence, "lblPourcProvence")
    Me.lblPourcProvence.Name = "lblPourcProvence"
    '
    'lblPourcAuvergne
    '
    Me.lblPourcAuvergne.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcAuvergne, "lblPourcAuvergne")
    Me.lblPourcAuvergne.Name = "lblPourcAuvergne"
    '
    'lblPourcLanguedoc
    '
    Me.lblPourcLanguedoc.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcLanguedoc, "lblPourcLanguedoc")
    Me.lblPourcLanguedoc.Name = "lblPourcLanguedoc"
    '
    'lblPourcAquitaine
    '
    Me.lblPourcAquitaine.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcAquitaine, "lblPourcAquitaine")
    Me.lblPourcAquitaine.Name = "lblPourcAquitaine"
    '
    'lblPourcBourgogne
    '
    Me.lblPourcBourgogne.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcBourgogne, "lblPourcBourgogne")
    Me.lblPourcBourgogne.Name = "lblPourcBourgogne"
    '
    'lblPourcPaysLoire
    '
    Me.lblPourcPaysLoire.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcPaysLoire, "lblPourcPaysLoire")
    Me.lblPourcPaysLoire.Name = "lblPourcPaysLoire"
    '
    'lblPourcAlsace
    '
    Me.lblPourcAlsace.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcAlsace, "lblPourcAlsace")
    Me.lblPourcAlsace.Name = "lblPourcAlsace"
    '
    'lblPourcIDF
    '
    Me.lblPourcIDF.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcIDF, "lblPourcIDF")
    Me.lblPourcIDF.Name = "lblPourcIDF"
    '
    'lblPourcCentre
    '
    Me.lblPourcCentre.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcCentre, "lblPourcCentre")
    Me.lblPourcCentre.Name = "lblPourcCentre"
    '
    'lblPourcNord
    '
    Me.lblPourcNord.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcNord, "lblPourcNord")
    Me.lblPourcNord.Name = "lblPourcNord"
    '
    'lblPourcNormandie
    '
    Me.lblPourcNormandie.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcNormandie, "lblPourcNormandie")
    Me.lblPourcNormandie.Name = "lblPourcNormandie"
    '
    'lblPourcBretagne
    '
    Me.lblPourcBretagne.BackColor = System.Drawing.Color.White
    resources.ApplyResources(Me.lblPourcBretagne, "lblPourcBretagne")
    Me.lblPourcBretagne.Name = "lblPourcBretagne"
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.MozartNet.My.Resources.Resources.CarteRegionsFrance
    resources.ApplyResources(Me.PictureBox1, "PictureBox1")
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.TabStop = False
    '
    'GCRECEPTIONS
    '
    Me.GCRECEPTIONS.EmbeddedNavigator.Margin = CType(resources.GetObject("GCRECEPTIONS.EmbeddedNavigator.Margin"), System.Windows.Forms.Padding)
    resources.ApplyResources(Me.GCRECEPTIONS, "GCRECEPTIONS")
    Me.GCRECEPTIONS.MainView = Me.GridView1
    Me.GCRECEPTIONS.Name = "GCRECEPTIONS"
    Me.GCRECEPTIONS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLUpEditGTPLot, Me.RepItemGLUpEditUnite})
    Me.GCRECEPTIONS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Appearance.ColumnFilterButton.BackColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButton.ForeColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButton.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
    Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
    Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
    Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = CType(resources.GetObject("GridView1.Appearance.ColumnFilterButtonActive.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
    Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
    Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
    Me.GridView1.Appearance.Empty.BackColor = CType(resources.GetObject("GridView1.Appearance.Empty.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.Empty.BackColor2 = CType(resources.GetObject("GridView1.Appearance.Empty.BackColor2"), System.Drawing.Color)
    Me.GridView1.Appearance.Empty.Options.UseBackColor = True
    Me.GridView1.Appearance.EvenRow.BackColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.EvenRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.EvenRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.EvenRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
    Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
    Me.GridView1.Appearance.FilterCloseButton.BackColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterCloseButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterCloseButton.ForeColor = CType(resources.GetObject("GridView1.Appearance.FilterCloseButton.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
    Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
    Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
    Me.GridView1.Appearance.FilterPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.FilterPanel.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.FilterPanel.BackColor2"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.FilterPanel.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
    Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
    Me.GridView1.Appearance.FixedLine.BackColor = CType(resources.GetObject("GridView1.Appearance.FixedLine.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
    Me.GridView1.Appearance.FocusedCell.BackColor = CType(resources.GetObject("GridView1.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FocusedCell.ForeColor = CType(resources.GetObject("GridView1.Appearance.FocusedCell.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
    Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
    Me.GridView1.Appearance.FocusedRow.BackColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FocusedRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FocusedRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.FocusedRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
    Me.GridView1.Appearance.FocusedRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
    Me.GridView1.Appearance.FooterPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FooterPanel.BorderColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FooterPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.FooterPanel.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
    Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
    Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
    Me.GridView1.Appearance.GroupButton.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupButton.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupButton.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupButton.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
    Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
    Me.GridView1.Appearance.GroupFooter.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupFooter.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupFooter.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupFooter.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
    Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
    Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
    Me.GridView1.Appearance.GroupPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupPanel.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupPanel.BackColor2 = CType(resources.GetObject("GridView1.Appearance.GroupPanel.BackColor2"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupPanel.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
    Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
    Me.GridView1.Appearance.GroupRow.BackColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.GroupRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
    Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
    Me.GridView1.Appearance.HeaderPanel.BackColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HeaderPanel.BorderColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HeaderPanel.Font = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.Font"), System.Drawing.Font)
    Me.GridView1.Appearance.HeaderPanel.ForeColor = CType(resources.GetObject("GridView1.Appearance.HeaderPanel.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
    Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
    Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
    Me.GridView1.Appearance.HideSelectionRow.BackColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HideSelectionRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HideSelectionRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.HideSelectionRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
    Me.GridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
    Me.GridView1.Appearance.HorzLine.BackColor = CType(resources.GetObject("GridView1.Appearance.HorzLine.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
    Me.GridView1.Appearance.OddRow.BackColor = CType(resources.GetObject("GridView1.Appearance.OddRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.OddRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.OddRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.OddRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.OddRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
    Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
    Me.GridView1.Appearance.Preview.BackColor = CType(resources.GetObject("GridView1.Appearance.Preview.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.Preview.Font = CType(resources.GetObject("GridView1.Appearance.Preview.Font"), System.Drawing.Font)
    Me.GridView1.Appearance.Preview.ForeColor = CType(resources.GetObject("GridView1.Appearance.Preview.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.Preview.Options.UseBackColor = True
    Me.GridView1.Appearance.Preview.Options.UseFont = True
    Me.GridView1.Appearance.Preview.Options.UseForeColor = True
    Me.GridView1.Appearance.Row.BackColor = CType(resources.GetObject("GridView1.Appearance.Row.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.Row.ForeColor = CType(resources.GetObject("GridView1.Appearance.Row.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.Row.Options.UseBackColor = True
    Me.GridView1.Appearance.Row.Options.UseForeColor = True
    Me.GridView1.Appearance.RowSeparator.BackColor = CType(resources.GetObject("GridView1.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.RowSeparator.BackColor2 = CType(resources.GetObject("GridView1.Appearance.RowSeparator.BackColor2"), System.Drawing.Color)
    Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
    Me.GridView1.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.SelectedRow.BorderColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.BorderColor"), System.Drawing.Color)
    Me.GridView1.Appearance.SelectedRow.ForeColor = CType(resources.GetObject("GridView1.Appearance.SelectedRow.ForeColor"), System.Drawing.Color)
    Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
    Me.GridView1.Appearance.SelectedRow.Options.UseBorderColor = True
    Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
    Me.GridView1.Appearance.TopNewRow.BackColor = CType(resources.GetObject("GridView1.Appearance.TopNewRow.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
    Me.GridView1.Appearance.VertLine.BackColor = CType(resources.GetObject("GridView1.Appearance.VertLine.BackColor"), System.Drawing.Color)
    Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
    Me.GridView1.ColumnPanelRowHeight = 30
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NCLINUM, Me.VCLINOM, Me.GColREGION, Me.CA})
    Me.GridView1.GridControl = Me.GCRECEPTIONS
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsBehavior.Editable = False
    Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
    Me.GridView1.OptionsView.EnableAppearanceOddRow = True
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowFooter = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    Me.GridView1.RowHeight = 20
    '
    'NCLINUM
    '
    resources.ApplyResources(Me.NCLINUM, "NCLINUM")
    Me.NCLINUM.FieldName = "NCLINUM"
    Me.NCLINUM.Name = "NCLINUM"
    '
    'VCLINOM
    '
    resources.ApplyResources(Me.VCLINOM, "VCLINOM")
    Me.VCLINOM.FieldName = "VCLINOM"
    Me.VCLINOM.Name = "VCLINOM"
    '
    'GColREGION
    '
    resources.ApplyResources(Me.GColREGION, "GColREGION")
    Me.GColREGION.FieldName = "REGION"
    Me.GColREGION.Name = "GColREGION"
    '
    'CA
    '
    Me.CA.AppearanceCell.Options.UseTextOptions = True
    Me.CA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    resources.ApplyResources(Me.CA, "CA")
    Me.CA.FieldName = "CA"
    Me.CA.Name = "CA"
    '
    'RepItemGLUpEditGTPLot
    '
    resources.ApplyResources(Me.RepItemGLUpEditGTPLot, "RepItemGLUpEditGTPLot")
    Me.RepItemGLUpEditGTPLot.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditGTPLot.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditGTPLot.DisplayMember = "VGTPLOTNOM"
    Me.RepItemGLUpEditGTPLot.Name = "RepItemGLUpEditGTPLot"
    Me.RepItemGLUpEditGTPLot.ValueMember = "NGTPLOTID"
    Me.RepItemGLUpEditGTPLot.View = Me.RepIGLUpEditViewLot
    '
    'RepIGLUpEditViewLot
    '
    Me.RepIGLUpEditViewLot.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColLOTIDTMP, Me.ColLOTNGTPLOTID, Me.ColLOTVGTPLOTNOM})
    Me.RepIGLUpEditViewLot.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepIGLUpEditViewLot.Name = "RepIGLUpEditViewLot"
    Me.RepIGLUpEditViewLot.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepIGLUpEditViewLot.OptionsView.ShowGroupPanel = False
    '
    'ColLOTIDTMP
    '
    resources.ApplyResources(Me.ColLOTIDTMP, "ColLOTIDTMP")
    Me.ColLOTIDTMP.FieldName = "IDTMP"
    Me.ColLOTIDTMP.Name = "ColLOTIDTMP"
    '
    'ColLOTNGTPLOTID
    '
    resources.ApplyResources(Me.ColLOTNGTPLOTID, "ColLOTNGTPLOTID")
    Me.ColLOTNGTPLOTID.FieldName = "NGTPLOTID"
    Me.ColLOTNGTPLOTID.Name = "ColLOTNGTPLOTID"
    '
    'ColLOTVGTPLOTNOM
    '
    resources.ApplyResources(Me.ColLOTVGTPLOTNOM, "ColLOTVGTPLOTNOM")
    Me.ColLOTVGTPLOTNOM.FieldName = "VGTPLOTNOM"
    Me.ColLOTVGTPLOTNOM.Name = "ColLOTVGTPLOTNOM"
    '
    'RepItemGLUpEditUnite
    '
    resources.ApplyResources(Me.RepItemGLUpEditUnite, "RepItemGLUpEditUnite")
    Me.RepItemGLUpEditUnite.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLUpEditUnite.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.RepItemGLUpEditUnite.DisplayMember = "VGTPUNITENOM"
    Me.RepItemGLUpEditUnite.Name = "RepItemGLUpEditUnite"
    Me.RepItemGLUpEditUnite.ValueMember = "NGTPUNITEID"
    Me.RepItemGLUpEditUnite.View = Me.RepItemGLUpEditViewUnite
    '
    'RepItemGLUpEditViewUnite
    '
    Me.RepItemGLUpEditViewUnite.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColUNITEIDTMP, Me.ColUNITENGTPUNITEID, Me.ColUNITEVGTPUNITENOM})
    Me.RepItemGLUpEditViewUnite.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.RepItemGLUpEditViewUnite.Name = "RepItemGLUpEditViewUnite"
    Me.RepItemGLUpEditViewUnite.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.RepItemGLUpEditViewUnite.OptionsView.ShowGroupPanel = False
    '
    'ColUNITEIDTMP
    '
    resources.ApplyResources(Me.ColUNITEIDTMP, "ColUNITEIDTMP")
    Me.ColUNITEIDTMP.FieldName = "IDTMP"
    Me.ColUNITEIDTMP.Name = "ColUNITEIDTMP"
    '
    'ColUNITENGTPUNITEID
    '
    resources.ApplyResources(Me.ColUNITENGTPUNITEID, "ColUNITENGTPUNITEID")
    Me.ColUNITENGTPUNITEID.FieldName = "NGTPUNITEID"
    Me.ColUNITENGTPUNITEID.Name = "ColUNITENGTPUNITEID"
    '
    'ColUNITEVGTPUNITENOM
    '
    resources.ApplyResources(Me.ColUNITEVGTPUNITENOM, "ColUNITEVGTPUNITENOM")
    Me.ColUNITEVGTPUNITENOM.FieldName = "VGTPUNITENOM"
    Me.ColUNITEVGTPUNITENOM.Name = "ColUNITEVGTPUNITENOM"
    '
    'frmReportingGeographique
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GCRECEPTIONS)
    Me.Controls.Add(Me.lblPourcCorse)
    Me.Controls.Add(Me.lblPourcProvence)
    Me.Controls.Add(Me.lblPourcAuvergne)
    Me.Controls.Add(Me.lblPourcLanguedoc)
    Me.Controls.Add(Me.lblPourcAquitaine)
    Me.Controls.Add(Me.lblPourcBourgogne)
    Me.Controls.Add(Me.lblPourcPaysLoire)
    Me.Controls.Add(Me.lblPourcAlsace)
    Me.Controls.Add(Me.lblPourcIDF)
    Me.Controls.Add(Me.lblPourcCentre)
    Me.Controls.Add(Me.lblPourcNord)
    Me.Controls.Add(Me.lblPourcNormandie)
    Me.Controls.Add(Me.lblPourcBretagne)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.ComboBoxPrest)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.ComboBoxTech)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmReportingGeographique"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GCRECEPTIONS, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditGTPLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepIGLUpEditViewLot, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditUnite, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepItemGLUpEditViewUnite, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTech As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonExporter As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPrest As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPourcCorse As System.Windows.Forms.Label
    Friend WithEvents lblPourcProvence As System.Windows.Forms.Label
    Friend WithEvents lblPourcAuvergne As System.Windows.Forms.Label
    Friend WithEvents lblPourcLanguedoc As System.Windows.Forms.Label
    Friend WithEvents lblPourcAquitaine As System.Windows.Forms.Label
    Friend WithEvents lblPourcBourgogne As System.Windows.Forms.Label
    Friend WithEvents lblPourcPaysLoire As System.Windows.Forms.Label
    Friend WithEvents lblPourcAlsace As System.Windows.Forms.Label
    Friend WithEvents lblPourcIDF As System.Windows.Forms.Label
    Friend WithEvents lblPourcCentre As System.Windows.Forms.Label
    Friend WithEvents lblPourcNord As System.Windows.Forms.Label
    Friend WithEvents lblPourcNormandie As System.Windows.Forms.Label
    Friend WithEvents lblPourcBretagne As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents GCRECEPTIONS As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColREGION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditGTPLot As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepIGLUpEditViewLot As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColLOTIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTNGTPLOTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColLOTVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemGLUpEditUnite As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLUpEditViewUnite As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColUNITEIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITENGTPUNITEID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColUNITEVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
