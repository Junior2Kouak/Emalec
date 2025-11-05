<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCompetenceByPers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompetenceByPers))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.LvlGColNCONTRATEXIST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemChkBAFFECTE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GVContrats = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LvlGColNCONTDOMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColNTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LvlGColVTYPECONTRAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCListCompetenceByPer = New DevExpress.XtraGrid.GridControl()
        Me.GVListCompetenceByPer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDCOMPETENCEPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNIDCOMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDOM_COMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VLIBCOMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColBAFFECTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCPERTYP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnGestCompetence = New System.Windows.Forms.Button()
        Me.BtnGestDomCompetence = New System.Windows.Forms.Button()
        Me.BtnParCompetence = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpBoxLstCompetence = New System.Windows.Forms.GroupBox()
        Me.GrpBoxPers = New System.Windows.Forms.GroupBox()
        Me.GCListPer = New DevExpress.XtraGrid.GridControl()
        Me.GVListPer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCListCompetenceByPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListCompetenceByPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.GrpBoxLstCompetence.SuspendLayout()
        Me.GrpBoxPers.SuspendLayout()
        CType(Me.GCListPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvlGColNCONTRATEXIST
        '
        resources.ApplyResources(Me.LvlGColNCONTRATEXIST, "LvlGColNCONTRATEXIST")
        Me.LvlGColNCONTRATEXIST.ColumnEdit = Me.RepItemChkBAFFECTE
        Me.LvlGColNCONTRATEXIST.FieldName = "NCONTRATEXIST"
        Me.LvlGColNCONTRATEXIST.Name = "LvlGColNCONTRATEXIST"
        '
        'RepItemChkBAFFECTE
        '
        resources.ApplyResources(Me.RepItemChkBAFFECTE, "RepItemChkBAFFECTE")
        Me.RepItemChkBAFFECTE.Name = "RepItemChkBAFFECTE"
        Me.RepItemChkBAFFECTE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepItemChkBAFFECTE.ValueGrayed = CType(2, Byte)
        '
        'GVContrats
        '
        Me.GVContrats.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LvlGColNCONTDOMNUM, Me.LvlGColNTYPECONTRAT, Me.LvlGColVTYPECONTRAT, Me.LvlGColNCONTRATEXIST})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.LvlGColNCONTRATEXIST
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Value1 = "1"
        Me.GVContrats.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVContrats.GridControl = Me.GCListCompetenceByPer
        Me.GVContrats.Name = "GVContrats"
        Me.GVContrats.OptionsView.ShowGroupPanel = False
        '
        'LvlGColNCONTDOMNUM
        '
        Me.LvlGColNCONTDOMNUM.FieldName = "NCONTDOMNUM"
        Me.LvlGColNCONTDOMNUM.Name = "LvlGColNCONTDOMNUM"
        Me.LvlGColNCONTDOMNUM.OptionsColumn.ReadOnly = True
        '
        'LvlGColNTYPECONTRAT
        '
        resources.ApplyResources(Me.LvlGColNTYPECONTRAT, "LvlGColNTYPECONTRAT")
        Me.LvlGColNTYPECONTRAT.FieldName = "NTYPECONTRAT"
        Me.LvlGColNTYPECONTRAT.Name = "LvlGColNTYPECONTRAT"
        Me.LvlGColNTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'LvlGColVTYPECONTRAT
        '
        resources.ApplyResources(Me.LvlGColVTYPECONTRAT, "LvlGColVTYPECONTRAT")
        Me.LvlGColVTYPECONTRAT.FieldName = "VTYPECONTRAT"
        Me.LvlGColVTYPECONTRAT.FieldNameSortGroup = "NCONTDOMNUM"
        Me.LvlGColVTYPECONTRAT.Name = "LvlGColVTYPECONTRAT"
        Me.LvlGColVTYPECONTRAT.OptionsColumn.AllowEdit = False
        Me.LvlGColVTYPECONTRAT.OptionsColumn.ReadOnly = True
        '
        'GCListCompetenceByPer
        '
        resources.ApplyResources(Me.GCListCompetenceByPer, "GCListCompetenceByPer")
        Me.GCListCompetenceByPer.MainView = Me.GVListCompetenceByPer
        Me.GCListCompetenceByPer.Name = "GCListCompetenceByPer"
        Me.GCListCompetenceByPer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemChkBAFFECTE})
        Me.GCListCompetenceByPer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListCompetenceByPer, Me.GVContrats})
        '
        'GVListCompetenceByPer
        '
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListCompetenceByPer.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListCompetenceByPer.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListCompetenceByPer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDCOMPETENCEPER, Me.GColNIDCOMPET, Me.GColVLIBDOM_COMPET, Me.VLIBCOMPET, Me.GColBAFFECTE})
        Me.GVListCompetenceByPer.GridControl = Me.GCListCompetenceByPer
        Me.GVListCompetenceByPer.Name = "GVListCompetenceByPer"
        Me.GVListCompetenceByPer.OptionsDetail.ShowDetailTabs = False
        Me.GVListCompetenceByPer.OptionsView.ShowGroupPanel = False
        '
        'GColNIDCOMPETENCEPER
        '
        resources.ApplyResources(Me.GColNIDCOMPETENCEPER, "GColNIDCOMPETENCEPER")
        Me.GColNIDCOMPETENCEPER.FieldName = "NIDCOMPETENCEPER"
        Me.GColNIDCOMPETENCEPER.Name = "GColNIDCOMPETENCEPER"
        Me.GColNIDCOMPETENCEPER.OptionsColumn.ReadOnly = True
        '
        'GColNIDCOMPET
        '
        resources.ApplyResources(Me.GColNIDCOMPET, "GColNIDCOMPET")
        Me.GColNIDCOMPET.FieldName = "NIDCOMPET"
        Me.GColNIDCOMPET.Name = "GColNIDCOMPET"
        '
        'GColVLIBDOM_COMPET
        '
        Me.GColVLIBDOM_COMPET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVLIBDOM_COMPET.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVLIBDOM_COMPET, "GColVLIBDOM_COMPET")
        Me.GColVLIBDOM_COMPET.FieldName = "VLIBDOM_COMPET"
        Me.GColVLIBDOM_COMPET.Name = "GColVLIBDOM_COMPET"
        Me.GColVLIBDOM_COMPET.OptionsColumn.AllowEdit = False
        Me.GColVLIBDOM_COMPET.OptionsColumn.ReadOnly = True
        '
        'VLIBCOMPET
        '
        Me.VLIBCOMPET.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VLIBCOMPET.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VLIBCOMPET, "VLIBCOMPET")
        Me.VLIBCOMPET.FieldName = "VLIBCOMPET"
        Me.VLIBCOMPET.Name = "VLIBCOMPET"
        Me.VLIBCOMPET.OptionsColumn.AllowEdit = False
        Me.VLIBCOMPET.OptionsColumn.ReadOnly = True
        '
        'GColBAFFECTE
        '
        Me.GColBAFFECTE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColBAFFECTE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColBAFFECTE, "GColBAFFECTE")
        Me.GColBAFFECTE.ColumnEdit = Me.RepItemChkBAFFECTE
        Me.GColBAFFECTE.FieldName = "BAFFECTE"
        Me.GColBAFFECTE.MinWidth = 105
        Me.GColBAFFECTE.Name = "GColBAFFECTE"
        '
        'GColCPERTYP
        '
        resources.ApplyResources(Me.GColCPERTYP, "GColCPERTYP")
        Me.GColCPERTYP.FieldName = "CPERTYP"
        Me.GColCPERTYP.Name = "GColCPERTYP"
        '
        'GrpboxActions
        '
        Me.GrpboxActions.Controls.Add(Me.BtnGestCompetence)
        Me.GrpboxActions.Controls.Add(Me.BtnGestDomCompetence)
        Me.GrpboxActions.Controls.Add(Me.BtnParCompetence)
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnGestCompetence
        '
        resources.ApplyResources(Me.BtnGestCompetence, "BtnGestCompetence")
        Me.BtnGestCompetence.Name = "BtnGestCompetence"
        Me.BtnGestCompetence.UseVisualStyleBackColor = True
        '
        'BtnGestDomCompetence
        '
        resources.ApplyResources(Me.BtnGestDomCompetence, "BtnGestDomCompetence")
        Me.BtnGestDomCompetence.Name = "BtnGestDomCompetence"
        Me.BtnGestDomCompetence.UseVisualStyleBackColor = True
        '
        'BtnParCompetence
        '
        resources.ApplyResources(Me.BtnParCompetence, "BtnParCompetence")
        Me.BtnParCompetence.Name = "BtnParCompetence"
        Me.BtnParCompetence.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GrpBoxLstCompetence
        '
        Me.GrpBoxLstCompetence.Controls.Add(Me.GCListCompetenceByPer)
        resources.ApplyResources(Me.GrpBoxLstCompetence, "GrpBoxLstCompetence")
        Me.GrpBoxLstCompetence.Name = "GrpBoxLstCompetence"
        Me.GrpBoxLstCompetence.TabStop = False
        '
        'GrpBoxPers
        '
        Me.GrpBoxPers.Controls.Add(Me.GCListPer)
        resources.ApplyResources(Me.GrpBoxPers, "GrpBoxPers")
        Me.GrpBoxPers.Name = "GrpBoxPers"
        Me.GrpBoxPers.TabStop = False
        '
        'GCListPer
        '
        resources.ApplyResources(Me.GCListPer, "GCListPer")
        Me.GCListPer.MainView = Me.GVListPer
        Me.GCListPer.Name = "GCListPer"
        Me.GCListPer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListPer})
        '
        'GVListPer
        '
        Me.GVListPer.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListPer.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListPer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListPer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListPer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListPer.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListPer.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListPer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNPERNUM, Me.GColVTYPELIB, Me.GColVTECH, Me.GColCPERTYP})
        Me.GVListPer.GridControl = Me.GCListPer
        Me.GVListPer.Name = "GVListPer"
        Me.GVListPer.OptionsView.ShowAutoFilterRow = True
        Me.GVListPer.OptionsView.ShowGroupPanel = False
        '
        'GColNPERNUM
        '
        resources.ApplyResources(Me.GColNPERNUM, "GColNPERNUM")
        Me.GColNPERNUM.Name = "GColNPERNUM"
        '
        'GColVTYPELIB
        '
        Me.GColVTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTYPELIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTYPELIB, "GColVTYPELIB")
        Me.GColVTYPELIB.FieldName = "VTYPELIB"
        Me.GColVTYPELIB.Name = "GColVTYPELIB"
        Me.GColVTYPELIB.OptionsColumn.AllowEdit = False
        Me.GColVTYPELIB.OptionsColumn.ReadOnly = True
        Me.GColVTYPELIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColVTECH
        '
        Me.GColVTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVTECH.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVTECH, "GColVTECH")
        Me.GColVTECH.FieldName = "NOM"
        Me.GColVTECH.Name = "GColVTECH"
        Me.GColVTECH.OptionsColumn.AllowEdit = False
        Me.GColVTECH.OptionsColumn.ReadOnly = True
        Me.GColVTECH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GridColumn1
        '
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.Name = "GridColumn2"
        '
        'frmGestCompetenceByPers
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpBoxPers)
        Me.Controls.Add(Me.GrpBoxLstCompetence)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestCompetenceByPers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepItemChkBAFFECTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContrats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCListCompetenceByPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListCompetenceByPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.GrpBoxLstCompetence.ResumeLayout(False)
        Me.GrpBoxPers.ResumeLayout(False)
        CType(Me.GCListPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpBoxLstCompetence As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxPers As System.Windows.Forms.GroupBox
    Friend WithEvents BtnParCompetence As System.Windows.Forms.Button
    Private WithEvents GCListCompetenceByPer As DevExpress.XtraGrid.GridControl
    Private WithEvents GCListPer As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListPer As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCPERTYP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVListCompetenceByPer As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNIDCOMPETENCEPER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBDOM_COMPET As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GVContrats As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents LvlGColNCONTDOMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColVTYPECONTRAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents LvlGColNCONTRATEXIST As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemChkBAFFECTE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents VLIBCOMPET As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColBAFFECTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnGestCompetence As System.Windows.Forms.Button
    Friend WithEvents BtnGestDomCompetence As System.Windows.Forms.Button
    Friend WithEvents GColNIDCOMPET As DevExpress.XtraGrid.Columns.GridColumn
End Class
