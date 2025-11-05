<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatIndicGroupeFactByClient
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatIndicGroupeFactByClient))
    Me.GCIndicGroupFactCli = New DevExpress.XtraGrid.GridControl()
    Me.GVIndicGroupFactCli = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.ColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColVPERCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.ColTTOHT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.ButtonExporter = New System.Windows.Forms.Button()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.LabelTitre = New System.Windows.Forms.Label()
    Me.GrpFilter = New System.Windows.Forms.GroupBox()
    Me.GLP_ListeGroupe = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GridLkView_ListeGroupe = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCol_IDGROUPE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCol_LIBGROUPE = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCOL_VPERNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.BtnValider = New System.Windows.Forms.Button()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.DTPFin = New System.Windows.Forms.DateTimePicker()
    Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        CType(Me.GCIndicGroupFactCli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVIndicGroupFactCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrpFilter.SuspendLayout()
        CType(Me.GLP_ListeGroupe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLkView_ListeGroupe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCIndicGroupFactCli
        '
        resources.ApplyResources(Me.GCIndicGroupFactCli, "GCIndicGroupFactCli")
        Me.GCIndicGroupFactCli.MainView = Me.GVIndicGroupFactCli
        Me.GCIndicGroupFactCli.Name = "GCIndicGroupFactCli"
        Me.GCIndicGroupFactCli.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVIndicGroupFactCli})
        '
        'GVIndicGroupFactCli
        '
        Me.GVIndicGroupFactCli.ColumnPanelRowHeight = 50
        Me.GVIndicGroupFactCli.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColVCLINOM, Me.GColVPERCHAFF, Me.ColTTOHT})
        Me.GVIndicGroupFactCli.GridControl = Me.GCIndicGroupFactCli
        Me.GVIndicGroupFactCli.Name = "GVIndicGroupFactCli"
        Me.GVIndicGroupFactCli.OptionsBehavior.ReadOnly = True
        Me.GVIndicGroupFactCli.OptionsCustomization.AllowGroup = False
        Me.GVIndicGroupFactCli.OptionsPrint.PrintFilterInfo = True
        Me.GVIndicGroupFactCli.OptionsView.ShowAutoFilterRow = True
        Me.GVIndicGroupFactCli.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVIndicGroupFactCli.OptionsView.ShowFooter = True
        Me.GVIndicGroupFactCli.OptionsView.ShowGroupPanel = False
        '
        'ColVCLINOM
        '
        Me.ColVCLINOM.AppearanceCell.Font = CType(resources.GetObject("ColVCLINOM.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColVCLINOM.AppearanceCell.Options.UseFont = True
        Me.ColVCLINOM.AppearanceHeader.Font = CType(resources.GetObject("ColVCLINOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColVCLINOM.AppearanceHeader.Options.UseFont = True
        Me.ColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        Me.ColVCLINOM.AppearanceHeader.Options.UseTextOptions = True
        Me.ColVCLINOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColVCLINOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColVCLINOM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColVCLINOM, "ColVCLINOM")
        Me.ColVCLINOM.FieldName = "VCLINOM"
        Me.ColVCLINOM.MinWidth = 200
        Me.ColVCLINOM.Name = "ColVCLINOM"
        Me.ColVCLINOM.OptionsColumn.AllowEdit = False
        Me.ColVCLINOM.OptionsColumn.ReadOnly = True
        Me.ColVCLINOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVPERCHAFF
        '
        Me.GColVPERCHAFF.AppearanceCell.Options.UseTextOptions = True
        Me.GColVPERCHAFF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERCHAFF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVPERCHAFF.AppearanceHeader.Font = CType(resources.GetObject("GColVPERCHAFF.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVPERCHAFF.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVPERCHAFF.AppearanceHeader.Options.UseFont = True
        Me.GColVPERCHAFF.AppearanceHeader.Options.UseForeColor = True
        Me.GColVPERCHAFF.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVPERCHAFF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVPERCHAFF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColVPERCHAFF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColVPERCHAFF, "GColVPERCHAFF")
        Me.GColVPERCHAFF.FieldName = "VPERCHAFF"
        Me.GColVPERCHAFF.Name = "GColVPERCHAFF"
        Me.GColVPERCHAFF.OptionsColumn.AllowEdit = False
        Me.GColVPERCHAFF.OptionsColumn.ReadOnly = True
        '
        'ColTTOHT
        '
        Me.ColTTOHT.AppearanceCell.Font = CType(resources.GetObject("ColTTOHT.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColTTOHT.AppearanceCell.Options.UseFont = True
        Me.ColTTOHT.AppearanceCell.Options.UseTextOptions = True
        Me.ColTTOHT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTTOHT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColTTOHT.AppearanceHeader.Font = CType(resources.GetObject("ColTTOHT.AppearanceHeader.Font"), System.Drawing.Font)
        Me.ColTTOHT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ColTTOHT.AppearanceHeader.Options.UseFont = True
        Me.ColTTOHT.AppearanceHeader.Options.UseForeColor = True
        Me.ColTTOHT.AppearanceHeader.Options.UseTextOptions = True
        Me.ColTTOHT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColTTOHT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ColTTOHT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.ColTTOHT, "ColTTOHT")
        Me.ColTTOHT.DisplayFormat.FormatString = "c"
        Me.ColTTOHT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ColTTOHT.FieldName = "TTOHT"
        Me.ColTTOHT.MinWidth = 70
        Me.ColTTOHT.Name = "ColTTOHT"
        Me.ColTTOHT.OptionsColumn.AllowEdit = False
        Me.ColTTOHT.OptionsColumn.ReadOnly = True
        Me.ColTTOHT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.ColTTOHT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("ColTTOHT.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("ColTTOHT.Summary1"), resources.GetString("ColTTOHT.Summary2"))})
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
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GrpFilter
        '
        Me.GrpFilter.Controls.Add(Me.GLP_ListeGroupe)
        Me.GrpFilter.Controls.Add(Me.BtnValider)
        Me.GrpFilter.Controls.Add(Me.Label25)
        Me.GrpFilter.Controls.Add(Me.Label26)
        Me.GrpFilter.Controls.Add(Me.DTPFin)
        Me.GrpFilter.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpFilter, "GrpFilter")
        Me.GrpFilter.Name = "GrpFilter"
        Me.GrpFilter.TabStop = False
        '
        'GLP_ListeGroupe
        '
        resources.ApplyResources(Me.GLP_ListeGroupe, "GLP_ListeGroupe")
        Me.GLP_ListeGroupe.Name = "GLP_ListeGroupe"
        Me.GLP_ListeGroupe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GLP_ListeGroupe.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GLP_ListeGroupe.Properties.DisplayMember = "LIBGROUPE"
        Me.GLP_ListeGroupe.Properties.NullText = resources.GetString("GLP_ListeGroupe.Properties.NullText")
        Me.GLP_ListeGroupe.Properties.PopupView = Me.GridLkView_ListeGroupe
        Me.GLP_ListeGroupe.Properties.ShowNullValuePrompt = CType((DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.GLP_ListeGroupe.Properties.ValueMember = "IDGROUPE"
        Me.GLP_ListeGroupe.Tag = "606"
        '
        'GridLkView_ListeGroupe
        '
        Me.GridLkView_ListeGroupe.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_IDGROUPE, Me.GCol_LIBGROUPE, Me.GCOL_VPERNOM})
        Me.GridLkView_ListeGroupe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLkView_ListeGroupe.Name = "GridLkView_ListeGroupe"
        Me.GridLkView_ListeGroupe.OptionsBehavior.Editable = False
        Me.GridLkView_ListeGroupe.OptionsBehavior.ReadOnly = True
        Me.GridLkView_ListeGroupe.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLkView_ListeGroupe.OptionsView.ShowGroupPanel = False
        '
        'GCol_IDGROUPE
        '
        Me.GCol_IDGROUPE.FieldName = "IDGROUPE"
        Me.GCol_IDGROUPE.Name = "GCol_IDGROUPE"
        '
        'GCol_LIBGROUPE
        '
        resources.ApplyResources(Me.GCol_LIBGROUPE, "GCol_LIBGROUPE")
        Me.GCol_LIBGROUPE.FieldName = "LIBGROUPE"
        Me.GCol_LIBGROUPE.Name = "GCol_LIBGROUPE"
        '
        'GCOL_VPERNOM
        '
        resources.ApplyResources(Me.GCOL_VPERNOM, "GCOL_VPERNOM")
        Me.GCOL_VPERNOM.FieldName = "VPERNOM"
        Me.GCOL_VPERNOM.Name = "GCOL_VPERNOM"
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'DTPFin
        '
        resources.ApplyResources(Me.DTPFin, "DTPFin")
        Me.DTPFin.Name = "DTPFin"
        '
        'DTPDebut
        '
        resources.ApplyResources(Me.DTPDebut, "DTPDebut")
        Me.DTPDebut.Name = "DTPDebut"
        '
        'frmStatIndicGroupeFactByClient
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpFilter)
        Me.Controls.Add(Me.GCIndicGroupFactCli)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "frmStatIndicGroupeFactByClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCIndicGroupFactCli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVIndicGroupFactCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpFilter.ResumeLayout(False)
        CType(Me.GLP_ListeGroupe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLkView_ListeGroupe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCIndicGroupFactCli As DevExpress.XtraGrid.GridControl
    Private WithEvents GVIndicGroupFactCli As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVPERCHAFF As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColTTOHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonExporter As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GrpFilter As GroupBox
    Friend WithEvents GLP_ListeGroupe As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLkView_ListeGroupe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_IDGROUPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_LIBGROUPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCOL_VPERNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents DTPDebut As DateTimePicker
End Class
