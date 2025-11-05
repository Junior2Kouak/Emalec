<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCauserieDetailResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCauserieDetailResult))
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpBoxActions = New System.Windows.Forms.GroupBox()
        Me.BtnCTRL = New System.Windows.Forms.Button()
        Me.BtnSaveCorrect = New System.Windows.Forms.Button()
        Me.BtnEditRep = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GCCauseDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVCauseDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColDetailNIDFICQCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNIDQCMQUESTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVQCMQUESTIONLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVQCMREPONSELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEditReponse = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GColDetailBFICQCMREPTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailBQCMREPONSEVALID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNQCMQUESTIONORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVCORRECTCOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEditCorrect = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GColDetailDCORRECTVALIDTECH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailNIDREP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDetailVTYPEREP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemRichTextEditReponse = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
        Me.LblTech = New System.Windows.Forms.Label()
        Me.GrpBoxActions.SuspendLayout()
        CType(Me.GCCauseDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCauseDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEditReponse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEditCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEditReponse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpBoxActions
        '
        Me.GrpBoxActions.Controls.Add(Me.BtnCTRL)
        Me.GrpBoxActions.Controls.Add(Me.BtnSaveCorrect)
        Me.GrpBoxActions.Controls.Add(Me.BtnEditRep)
        Me.GrpBoxActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpBoxActions, "GrpBoxActions")
        Me.GrpBoxActions.Name = "GrpBoxActions"
        Me.GrpBoxActions.TabStop = False
        '
        'BtnCTRL
        '
        Me.BtnCTRL.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnCTRL, "BtnCTRL")
        Me.BtnCTRL.Name = "BtnCTRL"
        Me.BtnCTRL.Tag = "417"
        Me.BtnCTRL.UseVisualStyleBackColor = False
        '
        'BtnSaveCorrect
        '
        Me.BtnSaveCorrect.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnSaveCorrect, "BtnSaveCorrect")
        Me.BtnSaveCorrect.Name = "BtnSaveCorrect"
        Me.BtnSaveCorrect.UseVisualStyleBackColor = False
        '
        'BtnEditRep
        '
        Me.BtnEditRep.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnEditRep, "BtnEditRep")
        Me.BtnEditRep.Name = "BtnEditRep"
        Me.BtnEditRep.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'GCCauseDetail
        '
        resources.ApplyResources(Me.GCCauseDetail, "GCCauseDetail")
        Me.GCCauseDetail.MainView = Me.GVCauseDetail
        Me.GCCauseDetail.Name = "GCCauseDetail"
        Me.GCCauseDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRichTextEditReponse, Me.RepositoryItemMemoEditCorrect, Me.RepositoryItemMemoEditReponse})
        Me.GCCauseDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCauseDetail})
        '
        'GVCauseDetail
        '
        Me.GVCauseDetail.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightGreen
        Me.GVCauseDetail.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVCauseDetail.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightGreen
        Me.GVCauseDetail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVCauseDetail.Appearance.GroupRow.BackColor = System.Drawing.Color.LightGray
        Me.GVCauseDetail.Appearance.GroupRow.Font = CType(resources.GetObject("GVCauseDetail.Appearance.GroupRow.Font"), System.Drawing.Font)
        Me.GVCauseDetail.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVCauseDetail.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVCauseDetail.Appearance.GroupRow.Options.UseFont = True
        Me.GVCauseDetail.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVCauseDetail.Appearance.GroupRow.Options.UseTextOptions = True
        Me.GVCauseDetail.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVCauseDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColDetailNIDFICQCM, Me.GColDetailNIDQCMQUESTION, Me.GColDetailVQCMQUESTIONLIB, Me.GColDetailVQCMREPONSELIB, Me.GColDetailBFICQCMREPTECH, Me.GColDetailBQCMREPONSEVALID, Me.GColDetailNQCMQUESTIONORDER, Me.GColDetailNPERNUM, Me.GColDetailVCORRECTCOM, Me.GColDetailDCORRECTVALIDTECH, Me.GColDetailNIDREP, Me.GColDetailVTYPEREP})
        Me.GVCauseDetail.GridControl = Me.GCCauseDetail
        Me.GVCauseDetail.GroupCount = 1
        Me.GVCauseDetail.GroupRowHeight = 40
        Me.GVCauseDetail.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("GVCauseDetail.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("GVCauseDetail.GroupSummary1"), CType(resources.GetObject("GVCauseDetail.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("GVCauseDetail.GroupSummary3"))})
        Me.GVCauseDetail.Name = "GVCauseDetail"
        Me.GVCauseDetail.OptionsView.AutoCalcPreviewLineCount = True
        Me.GVCauseDetail.OptionsView.RowAutoHeight = True
        Me.GVCauseDetail.OptionsView.ShowGroupPanel = False
        Me.GVCauseDetail.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GColDetailVQCMQUESTIONLIB, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GColDetailNIDFICQCM
        '
        resources.ApplyResources(Me.GColDetailNIDFICQCM, "GColDetailNIDFICQCM")
        Me.GColDetailNIDFICQCM.FieldName = "NIDFICQCM"
        Me.GColDetailNIDFICQCM.Name = "GColDetailNIDFICQCM"
        '
        'GColDetailNIDQCMQUESTION
        '
        resources.ApplyResources(Me.GColDetailNIDQCMQUESTION, "GColDetailNIDQCMQUESTION")
        Me.GColDetailNIDQCMQUESTION.FieldName = "NIDQCMQUESTION"
        Me.GColDetailNIDQCMQUESTION.Name = "GColDetailNIDQCMQUESTION"
        '
        'GColDetailVQCMQUESTIONLIB
        '
        Me.GColDetailVQCMQUESTIONLIB.AppearanceCell.Options.UseFont = True
        resources.ApplyResources(Me.GColDetailVQCMQUESTIONLIB, "GColDetailVQCMQUESTIONLIB")
        Me.GColDetailVQCMQUESTIONLIB.FieldName = "VQCMQUESTIONLIB"
        Me.GColDetailVQCMQUESTIONLIB.FieldNameSortGroup = "NQCMQUESTIONORDER"
        Me.GColDetailVQCMQUESTIONLIB.Name = "GColDetailVQCMQUESTIONLIB"
        Me.GColDetailVQCMQUESTIONLIB.OptionsColumn.AllowEdit = False
        Me.GColDetailVQCMQUESTIONLIB.OptionsColumn.ReadOnly = True
        '
        'GColDetailVQCMREPONSELIB
        '
        Me.GColDetailVQCMREPONSELIB.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailVQCMREPONSELIB.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.Font = CType(resources.GetObject("GColDetailVQCMREPONSELIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.Options.UseFont = True
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailVQCMREPONSELIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailVQCMREPONSELIB, "GColDetailVQCMREPONSELIB")
        Me.GColDetailVQCMREPONSELIB.ColumnEdit = Me.RepositoryItemMemoEditReponse
        Me.GColDetailVQCMREPONSELIB.FieldName = "VQCMREPONSELIB"
        Me.GColDetailVQCMREPONSELIB.Name = "GColDetailVQCMREPONSELIB"
        Me.GColDetailVQCMREPONSELIB.OptionsColumn.AllowEdit = False
        Me.GColDetailVQCMREPONSELIB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GColDetailVQCMREPONSELIB.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemMemoEditReponse
        '
        Me.RepositoryItemMemoEditReponse.AllowFocused = False
        Me.RepositoryItemMemoEditReponse.Name = "RepositoryItemMemoEditReponse"
        Me.RepositoryItemMemoEditReponse.ReadOnly = True
        '
        'GColDetailBFICQCMREPTECH
        '
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.Font = CType(resources.GetObject("GColDetailBFICQCMREPTECH.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.Options.UseFont = True
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailBFICQCMREPTECH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailBFICQCMREPTECH, "GColDetailBFICQCMREPTECH")
        Me.GColDetailBFICQCMREPTECH.FieldName = "BFICQCMREPTECH"
        Me.GColDetailBFICQCMREPTECH.Name = "GColDetailBFICQCMREPTECH"
        Me.GColDetailBFICQCMREPTECH.OptionsColumn.AllowEdit = False
        Me.GColDetailBFICQCMREPTECH.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GColDetailBFICQCMREPTECH.OptionsColumn.ReadOnly = True
        '
        'GColDetailBQCMREPONSEVALID
        '
        resources.ApplyResources(Me.GColDetailBQCMREPONSEVALID, "GColDetailBQCMREPONSEVALID")
        Me.GColDetailBQCMREPONSEVALID.FieldName = "BQCMREPONSEVALID"
        Me.GColDetailBQCMREPONSEVALID.Name = "GColDetailBQCMREPONSEVALID"
        Me.GColDetailBQCMREPONSEVALID.OptionsColumn.AllowEdit = False
        Me.GColDetailBQCMREPONSEVALID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GColDetailBQCMREPONSEVALID.OptionsColumn.ReadOnly = True
        '
        'GColDetailNQCMQUESTIONORDER
        '
        resources.ApplyResources(Me.GColDetailNQCMQUESTIONORDER, "GColDetailNQCMQUESTIONORDER")
        Me.GColDetailNQCMQUESTIONORDER.FieldName = "NQCMQUESTIONORDER"
        Me.GColDetailNQCMQUESTIONORDER.Name = "GColDetailNQCMQUESTIONORDER"
        Me.GColDetailNQCMQUESTIONORDER.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GColDetailNPERNUM
        '
        resources.ApplyResources(Me.GColDetailNPERNUM, "GColDetailNPERNUM")
        Me.GColDetailNPERNUM.FieldName = "NPERNUM"
        Me.GColDetailNPERNUM.Name = "GColDetailNPERNUM"
        '
        'GColDetailVCORRECTCOM
        '
        Me.GColDetailVCORRECTCOM.AppearanceCell.BackColor = System.Drawing.Color.LightYellow
        Me.GColDetailVCORRECTCOM.AppearanceCell.Options.UseBackColor = True
        Me.GColDetailVCORRECTCOM.AppearanceCell.Options.UseTextOptions = True
        Me.GColDetailVCORRECTCOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailVCORRECTCOM.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDetailVCORRECTCOM.AppearanceHeader.Font = CType(resources.GetObject("GColDetailVCORRECTCOM.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColDetailVCORRECTCOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDetailVCORRECTCOM.AppearanceHeader.Options.UseFont = True
        Me.GColDetailVCORRECTCOM.AppearanceHeader.Options.UseForeColor = True
        Me.GColDetailVCORRECTCOM.AppearanceHeader.Options.UseTextOptions = True
        Me.GColDetailVCORRECTCOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDetailVCORRECTCOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColDetailVCORRECTCOM, "GColDetailVCORRECTCOM")
        Me.GColDetailVCORRECTCOM.ColumnEdit = Me.RepositoryItemMemoEditCorrect
        Me.GColDetailVCORRECTCOM.FieldName = "VCORRECTCOM"
        Me.GColDetailVCORRECTCOM.Name = "GColDetailVCORRECTCOM"
        '
        'RepositoryItemMemoEditCorrect
        '
        Me.RepositoryItemMemoEditCorrect.Appearance.BackColor = System.Drawing.Color.LightYellow
        Me.RepositoryItemMemoEditCorrect.Appearance.Options.UseBackColor = True
        Me.RepositoryItemMemoEditCorrect.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEditCorrect.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemMemoEditCorrect.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemMemoEditCorrect.Name = "RepositoryItemMemoEditCorrect"
        '
        'GColDetailDCORRECTVALIDTECH
        '
        resources.ApplyResources(Me.GColDetailDCORRECTVALIDTECH, "GColDetailDCORRECTVALIDTECH")
        Me.GColDetailDCORRECTVALIDTECH.FieldName = "DCORRECTVALIDTECH"
        Me.GColDetailDCORRECTVALIDTECH.Name = "GColDetailDCORRECTVALIDTECH"
        '
        'GColDetailNIDREP
        '
        resources.ApplyResources(Me.GColDetailNIDREP, "GColDetailNIDREP")
        Me.GColDetailNIDREP.FieldName = "NIDREP"
        Me.GColDetailNIDREP.Name = "GColDetailNIDREP"
        '
        'GColDetailVTYPEREP
        '
        resources.ApplyResources(Me.GColDetailVTYPEREP, "GColDetailVTYPEREP")
        Me.GColDetailVTYPEREP.FieldName = "VTYPEREP"
        Me.GColDetailVTYPEREP.Name = "GColDetailVTYPEREP"
        '
        'RepositoryItemRichTextEditReponse
        '
        Me.RepositoryItemRichTextEditReponse.AllowFocused = False
        Me.RepositoryItemRichTextEditReponse.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemRichTextEditReponse.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemRichTextEditReponse.AppearanceReadOnly.Options.UseTextOptions = True
        Me.RepositoryItemRichTextEditReponse.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepositoryItemRichTextEditReponse.Name = "RepositoryItemRichTextEditReponse"
        Me.RepositoryItemRichTextEditReponse.ReadOnly = True
        Me.RepositoryItemRichTextEditReponse.ShowCaretInReadOnly = False
        '
        'LblTech
        '
        resources.ApplyResources(Me.LblTech, "LblTech")
        Me.LblTech.Name = "LblTech"
        '
        'frmCauserieDetailResult
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTech)
        Me.Controls.Add(Me.GCCauseDetail)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpBoxActions)
        Me.Name = "frmCauserieDetailResult"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxActions.ResumeLayout(False)
        CType(Me.GCCauseDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCauseDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEditReponse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEditCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEditReponse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpBoxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEditRep As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTech As System.Windows.Forms.Label
    Friend WithEvents BtnSaveCorrect As System.Windows.Forms.Button
    Friend WithEvents BtnCTRL As System.Windows.Forms.Button
    Private WithEvents GCCauseDetail As DevExpress.XtraGrid.GridControl
    Private WithEvents GVCauseDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColDetailNIDFICQCM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailNIDQCMQUESTION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailVQCMQUESTIONLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailVQCMREPONSELIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailBFICQCMREPTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailBQCMREPONSEVALID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailNQCMQUESTIONORDER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemRichTextEditReponse As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Private WithEvents GColDetailNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailVCORRECTCOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailDCORRECTVALIDTECH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailNIDREP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDetailVTYPEREP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepositoryItemMemoEditCorrect As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents RepositoryItemMemoEditReponse As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
