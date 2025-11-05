<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNbTransDevisParChaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNbTransDevisParChaff))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTxTrans = New System.Windows.Forms.Label()
        Me.LblDteDebut = New System.Windows.Forms.Label()
        Me.LblEtLe = New System.Windows.Forms.Label()
        Me.LblDateFin = New System.Windows.Forms.Label()
        Me.LblPourChaff = New System.Windows.Forms.Label()
        Me.LblChaff = New System.Windows.Forms.Label()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NPERNUMCHAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCLINUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Chaff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontantDevisCrees = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NombreDevisExecutes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MontantDevisExec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TauxTransfNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TauxTransfMontant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LblExplic = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTxTrans
        '
        resources.ApplyResources(Me.LblTxTrans, "LblTxTrans")
        Me.LblTxTrans.Name = "LblTxTrans"
        '
        'LblDteDebut
        '
        resources.ApplyResources(Me.LblDteDebut, "LblDteDebut")
        Me.LblDteDebut.Name = "LblDteDebut"
        '
        'LblEtLe
        '
        resources.ApplyResources(Me.LblEtLe, "LblEtLe")
        Me.LblEtLe.Name = "LblEtLe"
        '
        'LblDateFin
        '
        resources.ApplyResources(Me.LblDateFin, "LblDateFin")
        Me.LblDateFin.Name = "LblDateFin"
        '
        'LblPourChaff
        '
        resources.ApplyResources(Me.LblPourChaff, "LblPourChaff")
        Me.LblPourChaff.Name = "LblPourChaff"
        '
        'LblChaff
        '
        resources.ApplyResources(Me.LblChaff, "LblChaff")
        Me.LblChaff.Name = "LblChaff"
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NPERNUMCHAFF, Me.NCLINUM, Me.Chaff, Me.VCLINOM, Me.DevisCrees, Me.MontantDevisCrees, Me.NombreDevisExecutes, Me.MontantDevisExec, Me.TauxTransfNombre, Me.TauxTransfMontant})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NPERNUMCHAFF
        '
        resources.ApplyResources(Me.NPERNUMCHAFF, "NPERNUMCHAFF")
        Me.NPERNUMCHAFF.FieldName = "npernumchaff"
        Me.NPERNUMCHAFF.Name = "NPERNUMCHAFF"
        '
        'NCLINUM
        '
        resources.ApplyResources(Me.NCLINUM, "NCLINUM")
        Me.NCLINUM.FieldName = "NCLINUM"
        Me.NCLINUM.Name = "NCLINUM"
        Me.NCLINUM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NCLINUM.Summary"), DevExpress.Data.SummaryItemType))})
        '
        'Chaff
        '
        resources.ApplyResources(Me.Chaff, "Chaff")
        Me.Chaff.FieldName = "chaff"
        Me.Chaff.Name = "Chaff"
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        Me.VCLINOM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("VCLINOM.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("VCLINOM.Summary1"), resources.GetString("VCLINOM.Summary2"))})
        '
        'DevisCrees
        '
        Me.DevisCrees.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.DevisCrees.AppearanceCell.Options.UseFont = True
        Me.DevisCrees.AppearanceCell.Options.UseForeColor = True
        Me.DevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DevisCrees, "DevisCrees")
        Me.DevisCrees.DisplayFormat.FormatString = "F0"
        Me.DevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DevisCrees.FieldName = "NBDevisCrees"
        Me.DevisCrees.Name = "DevisCrees"
        Me.DevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("DevisCrees.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("DevisCrees.Summary1"), resources.GetString("DevisCrees.Summary2"))})
        '
        'MontantDevisCrees
        '
        Me.MontantDevisCrees.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MontantDevisCrees.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MontantDevisCrees, "MontantDevisCrees")
        Me.MontantDevisCrees.DisplayFormat.FormatString = "{0:n0} €"
        Me.MontantDevisCrees.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontantDevisCrees.FieldName = "MTDevisCrees"
        Me.MontantDevisCrees.Name = "MontantDevisCrees"
        Me.MontantDevisCrees.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MontantDevisCrees.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("MontantDevisCrees.Summary1"), resources.GetString("MontantDevisCrees.Summary2"))})
        '
        'NombreDevisExecutes
        '
        Me.NombreDevisExecutes.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.NombreDevisExecutes.AppearanceCell.Options.UseFont = True
        Me.NombreDevisExecutes.AppearanceCell.Options.UseForeColor = True
        Me.NombreDevisExecutes.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NombreDevisExecutes.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.NombreDevisExecutes, "NombreDevisExecutes")
        Me.NombreDevisExecutes.DisplayFormat.FormatString = "F0"
        Me.NombreDevisExecutes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NombreDevisExecutes.FieldName = "NBDevisExec"
        Me.NombreDevisExecutes.Name = "NombreDevisExecutes"
        Me.NombreDevisExecutes.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("NombreDevisExecutes.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("NombreDevisExecutes.Summary1"), resources.GetString("NombreDevisExecutes.Summary2"))})
        '
        'MontantDevisExec
        '
        Me.MontantDevisExec.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.MontantDevisExec.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.MontantDevisExec, "MontantDevisExec")
        Me.MontantDevisExec.DisplayFormat.FormatString = "{0:n0} €"
        Me.MontantDevisExec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MontantDevisExec.FieldName = "MTDevisExec"
        Me.MontantDevisExec.Name = "MontantDevisExec"
        Me.MontantDevisExec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(CType(resources.GetObject("MontantDevisExec.Summary"), DevExpress.Data.SummaryItemType), resources.GetString("MontantDevisExec.Summary1"), resources.GetString("MontantDevisExec.Summary2"))})
        '
        'TauxTransfNombre
        '
        Me.TauxTransfNombre.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TauxTransfNombre.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TauxTransfNombre, "TauxTransfNombre")
        Me.TauxTransfNombre.DisplayFormat.FormatString = "{0} %"
        Me.TauxTransfNombre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TauxTransfNombre.FieldName = "TauxTransfNombre"
        Me.TauxTransfNombre.Name = "TauxTransfNombre"
        '
        'TauxTransfMontant
        '
        Me.TauxTransfMontant.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TauxTransfMontant.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.TauxTransfMontant, "TauxTransfMontant")
        Me.TauxTransfMontant.DisplayFormat.FormatString = "{0} %"
        Me.TauxTransfMontant.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TauxTransfMontant.FieldName = "TauxTransfMontant"
        Me.TauxTransfMontant.Name = "TauxTransfMontant"
        '
        'LblExplic
        '
        Me.LblExplic.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.LblExplic, "LblExplic")
        Me.LblExplic.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblExplic.Name = "LblExplic"
        '
        'frmNbTransDevisParChaff
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblExplic)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblChaff)
        Me.Controls.Add(Me.LblPourChaff)
        Me.Controls.Add(Me.LblDateFin)
        Me.Controls.Add(Me.LblEtLe)
        Me.Controls.Add(Me.LblDteDebut)
        Me.Controls.Add(Me.LblTxTrans)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmNbTransDevisParChaff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTxTrans As System.Windows.Forms.Label
    Friend WithEvents LblDteDebut As System.Windows.Forms.Label
    Friend WithEvents LblEtLe As System.Windows.Forms.Label
    Friend WithEvents LblDateFin As System.Windows.Forms.Label
    Friend WithEvents LblPourChaff As System.Windows.Forms.Label
    Friend WithEvents LblChaff As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TauxTransfMontant As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MontantDevisCrees As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents NombreDevisExecutes As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MontantDevisExec As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TauxTransfNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCLINUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LblExplic As System.Windows.Forms.Label
    Friend WithEvents Chaff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NPERNUMCHAFF As DevExpress.XtraGrid.Columns.GridColumn
End Class
