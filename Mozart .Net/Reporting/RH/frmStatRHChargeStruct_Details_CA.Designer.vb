<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatRHChargeStruct_Details_CA
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatRHChargeStruct_Details_CA))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnFermer = New System.Windows.Forms.Button()
    Me.BtnPrint = New System.Windows.Forms.Button()
    Me.LblTitre = New System.Windows.Forms.Label()
    Me.GCStat = New DevExpress.XtraGrid.GridControl()
    Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColNCAINT = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNCAST = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColNCATOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCAINT, Me.GColNCAST, Me.GColNCATOT})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'GColNCAINT
        '
        Me.GColNCAINT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCAINT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCAINT, "GColNCAINT")
        Me.GColNCAINT.DisplayFormat.FormatString = "c0"
        Me.GColNCAINT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColNCAINT.FieldName = "NCAINT"
        Me.GColNCAINT.Name = "GColNCAINT"
        '
        'GColNCAST
        '
        Me.GColNCAST.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCAST.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCAST, "GColNCAST")
        Me.GColNCAST.DisplayFormat.FormatString = "c0"
        Me.GColNCAST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColNCAST.FieldName = "NCAST"
        Me.GColNCAST.Name = "GColNCAST"
        '
        'GColNCATOT
        '
        Me.GColNCATOT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNCATOT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNCATOT, "GColNCATOT")
        Me.GColNCATOT.DisplayFormat.FormatString = "c0"
        Me.GColNCATOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GColNCATOT.FieldName = "NCATOT"
        Me.GColNCATOT.Name = "GColNCATOT"
        '
        'frmStatRHChargeStruct_Details_CA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmStatRHChargeStruct_Details_CA"
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LblTitre As Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCAINT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCAST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCATOT As DevExpress.XtraGrid.Columns.GridColumn
End Class
