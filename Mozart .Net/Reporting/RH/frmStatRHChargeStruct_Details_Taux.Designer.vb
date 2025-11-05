<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatRHChargeStruct_Details_Taux
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatRHChargeStruct_Details_Taux))
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColTXEFFTOT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColTXCATOT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColTXCAINT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
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
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 60
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColTXEFFTOT, Me.GColTXCATOT, Me.GColTXCAINT})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'GColTXEFFTOT
        '
        Me.GColTXEFFTOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTXEFFTOT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColTXEFFTOT, "GColTXEFFTOT")
        Me.GColTXEFFTOT.DisplayFormat.FormatString = "p0"
        Me.GColTXEFFTOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColTXEFFTOT.FieldName = "TXEFFTOT"
        Me.GColTXEFFTOT.Name = "GColTXEFFTOT"
        '
        'GColTXCATOT
        '
        Me.GColTXCATOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTXCATOT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColTXCATOT, "GColTXCATOT")
        Me.GColTXCATOT.DisplayFormat.FormatString = "n2"
        Me.GColTXCATOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTXCATOT.FieldName = "TXCATOT"
        Me.GColTXCATOT.Name = "GColTXCATOT"
        '
        'GColTXCAINT
        '
        Me.GColTXCAINT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColTXCAINT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColTXCAINT, "GColTXCAINT")
        Me.GColTXCAINT.DisplayFormat.FormatString = "n2"
        Me.GColTXCAINT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GColTXCAINT.FieldName = "TXCAINT"
        Me.GColTXCAINT.Name = "GColTXCAINT"
        Me.GColTXCAINT.OptionsColumn.AllowEdit = False
        Me.GColTXCAINT.OptionsColumn.ReadOnly = True
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
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
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'frmStatRHChargeStruct_Details_Taux
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatRHChargeStruct_Details_Taux"
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitre As Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColTXEFFTOT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColTXCATOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents GColTXCAINT As DevExpress.XtraGrid.Columns.GridColumn
End Class
