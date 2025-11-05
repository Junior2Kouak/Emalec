<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPrestations
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPrestations))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCPRESTA = New DevExpress.XtraGrid.GridControl()
        Me.GVPRESTA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColPrestaCOLORCAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPrestaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPrestaVCATEGORIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPrestaVACTIVITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColPrestaCOCHEETUDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHEETUDE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColPrestaCOCHEINSTALL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHEINSTALL = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColPrestaCOCHEPREV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHEPREV = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColPrestaCOCHEDEP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHEDEP = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GColPrestaCOCHEASTR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkCOCHEASTR = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.GCPRESTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPRESTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHEETUDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHEINSTALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHEPREV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHEDEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemChkCOCHEASTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.ForeColor = System.Drawing.Color.IndianRed
        Me.LblTitre.Name = "LblTitre"
        '
        'GCPRESTA
        '
        resources.ApplyResources(Me.GCPRESTA, "GCPRESTA")
        Me.GCPRESTA.MainView = Me.GVPRESTA
        Me.GCPRESTA.Name = "GCPRESTA"
        Me.GCPRESTA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkCOCHEETUDE, Me.RepItemChkCOCHEINSTALL, Me.RepItemChkCOCHEPREV, Me.RepItemChkCOCHEDEP, Me.RepItemChkCOCHEASTR})
        Me.GCPRESTA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPRESTA})
        '
        'GVPRESTA
        '
        Me.GVPRESTA.ColumnPanelRowHeight = 40
        Me.GVPRESTA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColPrestaCOLORCAT, Me.GColPrestaID, Me.GColPrestaVCATEGORIE, Me.GColPrestaVACTIVITE, Me.GColPrestaCOCHEETUDE, Me.GColPrestaCOCHEINSTALL, Me.GColPrestaCOCHEPREV, Me.GColPrestaCOCHEDEP, Me.GColPrestaCOCHEASTR})
        Me.GVPRESTA.GridControl = Me.GCPRESTA
        Me.GVPRESTA.Name = "GVPRESTA"
        Me.GVPRESTA.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVPRESTA.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GVPRESTA.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GVPRESTA.OptionsView.ShowGroupPanel = False
        '
        'GColPrestaCOLORCAT
        '
        resources.ApplyResources(Me.GColPrestaCOLORCAT, "GColPrestaCOLORCAT")
        Me.GColPrestaCOLORCAT.FieldName = "COLORCAT"
        Me.GColPrestaCOLORCAT.Name = "GColPrestaCOLORCAT"
        '
        'GColPrestaID
        '
        resources.ApplyResources(Me.GColPrestaID, "GColPrestaID")
        Me.GColPrestaID.Name = "GColPrestaID"
        '
        'GColPrestaVCATEGORIE
        '
        Me.GColPrestaVCATEGORIE.AppearanceCell.Font = CType(resources.GetObject("GColPrestaVCATEGORIE.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColPrestaVCATEGORIE.AppearanceCell.Options.UseFont = True
        Me.GColPrestaVCATEGORIE.AppearanceCell.Options.UseTextOptions = True
        Me.GColPrestaVCATEGORIE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaVCATEGORIE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaVCATEGORIE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColPrestaVCATEGORIE.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaVCATEGORIE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaVCATEGORIE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaVCATEGORIE.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaVCATEGORIE.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaVCATEGORIE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaVCATEGORIE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaVCATEGORIE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaVCATEGORIE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaVCATEGORIE, "GColPrestaVCATEGORIE")
        Me.GColPrestaVCATEGORIE.FieldName = "VCATEGORIE"
        Me.GColPrestaVCATEGORIE.Name = "GColPrestaVCATEGORIE"
        Me.GColPrestaVCATEGORIE.OptionsColumn.AllowEdit = False
        Me.GColPrestaVCATEGORIE.OptionsColumn.ReadOnly = True
        Me.GColPrestaVCATEGORIE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColPrestaVACTIVITE
        '
        Me.GColPrestaVACTIVITE.AppearanceCell.Font = CType(resources.GetObject("GColPrestaVACTIVITE.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColPrestaVACTIVITE.AppearanceCell.Options.UseFont = True
        Me.GColPrestaVACTIVITE.AppearanceCell.Options.UseTextOptions = True
        Me.GColPrestaVACTIVITE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaVACTIVITE.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColPrestaVACTIVITE.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaVACTIVITE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaVACTIVITE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaVACTIVITE.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaVACTIVITE.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaVACTIVITE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaVACTIVITE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaVACTIVITE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaVACTIVITE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        resources.ApplyResources(Me.GColPrestaVACTIVITE, "GColPrestaVACTIVITE")
        Me.GColPrestaVACTIVITE.FieldName = "VACTIVITE"
        Me.GColPrestaVACTIVITE.Name = "GColPrestaVACTIVITE"
        Me.GColPrestaVACTIVITE.OptionsColumn.AllowEdit = False
        Me.GColPrestaVACTIVITE.OptionsColumn.ReadOnly = True
        Me.GColPrestaVACTIVITE.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColPrestaCOCHEETUDE
        '
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaCOCHEETUDE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaCOCHEETUDE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaCOCHEETUDE, "GColPrestaCOCHEETUDE")
        Me.GColPrestaCOCHEETUDE.ColumnEdit = Me.RepItemChkCOCHEETUDE
        Me.GColPrestaCOCHEETUDE.FieldName = "COCHEETUDE"
        Me.GColPrestaCOCHEETUDE.Name = "GColPrestaCOCHEETUDE"
        '
        'RepItemChkCOCHEETUDE
        '
        resources.ApplyResources(Me.RepItemChkCOCHEETUDE, "RepItemChkCOCHEETUDE")
        Me.RepItemChkCOCHEETUDE.Name = "RepItemChkCOCHEETUDE"
        Me.RepItemChkCOCHEETUDE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHEETUDE.ValueChecked = 1
        Me.RepItemChkCOCHEETUDE.ValueUnchecked = 0
        '
        'GColPrestaCOCHEINSTALL
        '
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaCOCHEINSTALL.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaCOCHEINSTALL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaCOCHEINSTALL, "GColPrestaCOCHEINSTALL")
        Me.GColPrestaCOCHEINSTALL.ColumnEdit = Me.RepItemChkCOCHEINSTALL
        Me.GColPrestaCOCHEINSTALL.FieldName = "COCHEINSTALL"
        Me.GColPrestaCOCHEINSTALL.Name = "GColPrestaCOCHEINSTALL"
        '
        'RepItemChkCOCHEINSTALL
        '
        resources.ApplyResources(Me.RepItemChkCOCHEINSTALL, "RepItemChkCOCHEINSTALL")
        Me.RepItemChkCOCHEINSTALL.Name = "RepItemChkCOCHEINSTALL"
        Me.RepItemChkCOCHEINSTALL.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHEINSTALL.ValueChecked = 1
        Me.RepItemChkCOCHEINSTALL.ValueUnchecked = 0
        '
        'GColPrestaCOCHEPREV
        '
        Me.GColPrestaCOCHEPREV.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaCOCHEPREV.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaCOCHEPREV.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaCOCHEPREV.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaCOCHEPREV.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaCOCHEPREV.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaCOCHEPREV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaCOCHEPREV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaCOCHEPREV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaCOCHEPREV, "GColPrestaCOCHEPREV")
        Me.GColPrestaCOCHEPREV.ColumnEdit = Me.RepItemChkCOCHEPREV
        Me.GColPrestaCOCHEPREV.FieldName = "COCHEPREV"
        Me.GColPrestaCOCHEPREV.Name = "GColPrestaCOCHEPREV"
        '
        'RepItemChkCOCHEPREV
        '
        resources.ApplyResources(Me.RepItemChkCOCHEPREV, "RepItemChkCOCHEPREV")
        Me.RepItemChkCOCHEPREV.Name = "RepItemChkCOCHEPREV"
        Me.RepItemChkCOCHEPREV.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHEPREV.ValueChecked = 1
        Me.RepItemChkCOCHEPREV.ValueUnchecked = 0
        '
        'GColPrestaCOCHEDEP
        '
        Me.GColPrestaCOCHEDEP.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaCOCHEDEP.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaCOCHEDEP.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaCOCHEDEP.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaCOCHEDEP.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaCOCHEDEP.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaCOCHEDEP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaCOCHEDEP.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaCOCHEDEP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaCOCHEDEP, "GColPrestaCOCHEDEP")
        Me.GColPrestaCOCHEDEP.ColumnEdit = Me.RepItemChkCOCHEDEP
        Me.GColPrestaCOCHEDEP.FieldName = "COCHEDEP"
        Me.GColPrestaCOCHEDEP.Name = "GColPrestaCOCHEDEP"
        '
        'RepItemChkCOCHEDEP
        '
        resources.ApplyResources(Me.RepItemChkCOCHEDEP, "RepItemChkCOCHEDEP")
        Me.RepItemChkCOCHEDEP.Name = "RepItemChkCOCHEDEP"
        Me.RepItemChkCOCHEDEP.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHEDEP.ValueChecked = 1
        Me.RepItemChkCOCHEDEP.ValueUnchecked = 0
        '
        'GColPrestaCOCHEASTR
        '
        Me.GColPrestaCOCHEASTR.AppearanceHeader.Font = CType(resources.GetObject("GColPrestaCOCHEASTR.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColPrestaCOCHEASTR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColPrestaCOCHEASTR.AppearanceHeader.Options.UseFont = True
        Me.GColPrestaCOCHEASTR.AppearanceHeader.Options.UseForeColor = True
        Me.GColPrestaCOCHEASTR.AppearanceHeader.Options.UseTextOptions = True
        Me.GColPrestaCOCHEASTR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColPrestaCOCHEASTR.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColPrestaCOCHEASTR.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.GColPrestaCOCHEASTR, "GColPrestaCOCHEASTR")
        Me.GColPrestaCOCHEASTR.ColumnEdit = Me.RepItemChkCOCHEASTR
        Me.GColPrestaCOCHEASTR.FieldName = "COCHEASTR"
        Me.GColPrestaCOCHEASTR.Name = "GColPrestaCOCHEASTR"
        '
        'RepItemChkCOCHEASTR
        '
        resources.ApplyResources(Me.RepItemChkCOCHEASTR, "RepItemChkCOCHEASTR")
        Me.RepItemChkCOCHEASTR.Name = "RepItemChkCOCHEASTR"
        Me.RepItemChkCOCHEASTR.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkCOCHEASTR.ValueChecked = 1
        Me.RepItemChkCOCHEASTR.ValueUnchecked = 0
        '
        'UCPrestations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(Me.GCPRESTA)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "UCPrestations"
        CType(Me.GCPRESTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPRESTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHEETUDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHEINSTALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHEPREV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHEDEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemChkCOCHEASTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GCPRESTA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPRESTA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColPrestaCOLORCAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColPrestaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColPrestaVCATEGORIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColPrestaVACTIVITE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColPrestaCOCHEETUDE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHEETUDE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColPrestaCOCHEINSTALL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHEINSTALL As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColPrestaCOCHEPREV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHEPREV As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColPrestaCOCHEDEP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHEDEP As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GColPrestaCOCHEASTR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepItemChkCOCHEASTR As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
