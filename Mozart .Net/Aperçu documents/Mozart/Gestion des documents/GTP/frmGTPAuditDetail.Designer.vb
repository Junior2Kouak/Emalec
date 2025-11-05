<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGTPAuditDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGTPAuditDetail))
        Me.GrpAction = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.GrpInfoEquipement = New System.Windows.Forms.GroupBox()
        Me.GCInfoEquipement = New DevExpress.XtraGrid.GridControl()
        Me.CVInfoEquipement = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.ColEquipNGTPSITID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipNSITNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipNGTPMAINID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPZONENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPLOTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPEQUIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPPRECIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPSITOBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipNGTPDURVIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipNGTPSITQTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipVGTPUNITENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEquipNGTPCOUTUNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpBudget = New System.Windows.Forms.GroupBox()
        Me.VGDAuditL = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.RepItemGLEditNGTPTYPDEPID = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepGVGTPTYPDEP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColGVCboNGTPTYPDEPID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColGVCboVGTPTYPDEPNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemMemoVGTPORIGNOM = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepItemMemoVJUSTIF = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.RepItemGLNGTPETAGESTID = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepItemGLVETAGESTDEP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColGVNGTPETAGESTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColGVVGTPETAGESTNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CatBudg = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.RowVGTPORIGNOM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPCOUTFORFAIT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPANNEETHEO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPANNEETECH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowVGTPJUSTIF = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPTYPDEPID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPETAGESTID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPORIGID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.RowNGTPAUDITBUDGID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpAction.SuspendLayout()
        Me.GrpInfoEquipement.SuspendLayout()
        CType(Me.GCInfoEquipement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CVInfoEquipement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBudget.SuspendLayout()
        CType(Me.VGDAuditL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLEditNGTPTYPDEPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepGVGTPTYPDEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemMemoVGTPORIGNOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemMemoVJUSTIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLNGTPETAGESTID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemGLVETAGESTDEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpAction
        '
        resources.ApplyResources(Me.GrpAction, "GrpAction")
        Me.GrpAction.Controls.Add(Me.BtnQuit)
        Me.GrpAction.Name = "GrpAction"
        Me.GrpAction.TabStop = False
        '
        'BtnQuit
        '
        resources.ApplyResources(Me.BtnQuit, "BtnQuit")
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'GrpInfoEquipement
        '
        resources.ApplyResources(Me.GrpInfoEquipement, "GrpInfoEquipement")
        Me.GrpInfoEquipement.Controls.Add(Me.GCInfoEquipement)
        Me.GrpInfoEquipement.Name = "GrpInfoEquipement"
        Me.GrpInfoEquipement.TabStop = False
        '
        'GCInfoEquipement
        '
        resources.ApplyResources(Me.GCInfoEquipement, "GCInfoEquipement")
        '
        '
        '
        Me.GCInfoEquipement.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCInfoEquipement.EmbeddedNavigator.AccessibleDescription")
        Me.GCInfoEquipement.EmbeddedNavigator.AccessibleName = resources.GetString("GCInfoEquipement.EmbeddedNavigator.AccessibleName")
        Me.GCInfoEquipement.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCInfoEquipement.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCInfoEquipement.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCInfoEquipement.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCInfoEquipement.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCInfoEquipement.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCInfoEquipement.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCInfoEquipement.EmbeddedNavigator.ToolTip = resources.GetString("GCInfoEquipement.EmbeddedNavigator.ToolTip")
        Me.GCInfoEquipement.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCInfoEquipement.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCInfoEquipement.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCInfoEquipement.EmbeddedNavigator.ToolTipTitle")
        Me.GCInfoEquipement.MainView = Me.CVInfoEquipement
        Me.GCInfoEquipement.Name = "GCInfoEquipement"
        Me.GCInfoEquipement.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CVInfoEquipement})
        '
        'CVInfoEquipement
        '
        Me.CVInfoEquipement.Appearance.CardCaption.Font = CType(resources.GetObject("CVInfoEquipement.Appearance.CardCaption.Font"), System.Drawing.Font)
        Me.CVInfoEquipement.Appearance.CardCaption.FontSizeDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.CardCaption.FontSizeDelta"), Integer)
        Me.CVInfoEquipement.Appearance.CardCaption.FontStyleDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.CardCaption.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CVInfoEquipement.Appearance.CardCaption.GradientMode = CType(resources.GetObject("CVInfoEquipement.Appearance.CardCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.CVInfoEquipement.Appearance.CardCaption.Image = CType(resources.GetObject("CVInfoEquipement.Appearance.CardCaption.Image"), System.Drawing.Image)
        Me.CVInfoEquipement.Appearance.CardCaption.Options.UseFont = True
        Me.CVInfoEquipement.Appearance.FieldCaption.Font = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldCaption.Font"), System.Drawing.Font)
        Me.CVInfoEquipement.Appearance.FieldCaption.FontSizeDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldCaption.FontSizeDelta"), Integer)
        Me.CVInfoEquipement.Appearance.FieldCaption.FontStyleDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldCaption.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CVInfoEquipement.Appearance.FieldCaption.GradientMode = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.CVInfoEquipement.Appearance.FieldCaption.Image = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldCaption.Image"), System.Drawing.Image)
        Me.CVInfoEquipement.Appearance.FieldCaption.Options.UseFont = True
        Me.CVInfoEquipement.Appearance.FieldValue.Font = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldValue.Font"), System.Drawing.Font)
        Me.CVInfoEquipement.Appearance.FieldValue.FontSizeDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldValue.FontSizeDelta"), Integer)
        Me.CVInfoEquipement.Appearance.FieldValue.FontStyleDelta = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldValue.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CVInfoEquipement.Appearance.FieldValue.GradientMode = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldValue.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.CVInfoEquipement.Appearance.FieldValue.Image = CType(resources.GetObject("CVInfoEquipement.Appearance.FieldValue.Image"), System.Drawing.Image)
        Me.CVInfoEquipement.Appearance.FieldValue.Options.UseFont = True
        resources.ApplyResources(Me.CVInfoEquipement, "CVInfoEquipement")
        Me.CVInfoEquipement.CardWidth = 800
        Me.CVInfoEquipement.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColEquipNGTPSITID, Me.ColEquipNSITNUM, Me.ColEquipNGTPMAINID, Me.ColEquipVGTPZONENOM, Me.ColEquipVGTPLOTNOM, Me.ColEquipVGTPEQUIP, Me.ColEquipVGTPPRECIS, Me.ColEquipVGTPSITOBS, Me.ColEquipNGTPDURVIE, Me.ColEquipNGTPSITQTE, Me.ColEquipVGTPUNITENOM, Me.ColEquipNGTPCOUTUNIT})
        Me.CVInfoEquipement.FocusedCardTopFieldIndex = 0
        Me.CVInfoEquipement.GridControl = Me.GCInfoEquipement
        Me.CVInfoEquipement.Name = "CVInfoEquipement"
        Me.CVInfoEquipement.OptionsBehavior.Editable = False
        Me.CVInfoEquipement.OptionsBehavior.ReadOnly = True
        Me.CVInfoEquipement.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.CVInfoEquipement.OptionsView.ShowQuickCustomizeButton = False
        Me.CVInfoEquipement.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'ColEquipNGTPSITID
        '
        resources.ApplyResources(Me.ColEquipNGTPSITID, "ColEquipNGTPSITID")
        Me.ColEquipNGTPSITID.FieldName = "NGTPSITID"
        Me.ColEquipNGTPSITID.Name = "ColEquipNGTPSITID"
        '
        'ColEquipNSITNUM
        '
        resources.ApplyResources(Me.ColEquipNSITNUM, "ColEquipNSITNUM")
        Me.ColEquipNSITNUM.FieldName = "NSITNUM"
        Me.ColEquipNSITNUM.Name = "ColEquipNSITNUM"
        '
        'ColEquipNGTPMAINID
        '
        resources.ApplyResources(Me.ColEquipNGTPMAINID, "ColEquipNGTPMAINID")
        Me.ColEquipNGTPMAINID.FieldName = "NGTPMAINID"
        Me.ColEquipNGTPMAINID.Name = "ColEquipNGTPMAINID"
        '
        'ColEquipVGTPZONENOM
        '
        Me.ColEquipVGTPZONENOM.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPZONENOM.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPZONENOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPZONENOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPZONENOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPZONENOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPZONENOM.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPZONENOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPZONENOM.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPZONENOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPZONENOM.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPZONENOM, "ColEquipVGTPZONENOM")
        Me.ColEquipVGTPZONENOM.FieldName = "VGTPZONENOM"
        Me.ColEquipVGTPZONENOM.Name = "ColEquipVGTPZONENOM"
        '
        'ColEquipVGTPLOTNOM
        '
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPLOTNOM.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPLOTNOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPLOTNOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPLOTNOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPLOTNOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPLOTNOM.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPLOTNOM, "ColEquipVGTPLOTNOM")
        Me.ColEquipVGTPLOTNOM.FieldName = "VGTPLOTNOM"
        Me.ColEquipVGTPLOTNOM.Name = "ColEquipVGTPLOTNOM"
        '
        'ColEquipVGTPEQUIP
        '
        Me.ColEquipVGTPEQUIP.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPEQUIP.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPEQUIP.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPEQUIP.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPEQUIP.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPEQUIP.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPEQUIP.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPEQUIP.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPEQUIP.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPEQUIP.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPEQUIP.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPEQUIP, "ColEquipVGTPEQUIP")
        Me.ColEquipVGTPEQUIP.FieldName = "VGTPEQUIP"
        Me.ColEquipVGTPEQUIP.Name = "ColEquipVGTPEQUIP"
        '
        'ColEquipVGTPPRECIS
        '
        Me.ColEquipVGTPPRECIS.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPPRECIS.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPPRECIS.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPPRECIS.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPPRECIS.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPPRECIS.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPPRECIS.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPPRECIS.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPPRECIS.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPPRECIS.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPPRECIS.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPPRECIS, "ColEquipVGTPPRECIS")
        Me.ColEquipVGTPPRECIS.FieldName = "VGTPPRECIS"
        Me.ColEquipVGTPPRECIS.Name = "ColEquipVGTPPRECIS"
        '
        'ColEquipVGTPSITOBS
        '
        Me.ColEquipVGTPSITOBS.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPSITOBS.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPSITOBS.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPSITOBS.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPSITOBS.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPSITOBS.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPSITOBS.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPSITOBS.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPSITOBS.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPSITOBS.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPSITOBS.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPSITOBS, "ColEquipVGTPSITOBS")
        Me.ColEquipVGTPSITOBS.FieldName = "VGTPSITOBS"
        Me.ColEquipVGTPSITOBS.Name = "ColEquipVGTPSITOBS"
        '
        'ColEquipNGTPDURVIE
        '
        Me.ColEquipNGTPDURVIE.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipNGTPDURVIE.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipNGTPDURVIE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipNGTPDURVIE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipNGTPDURVIE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipNGTPDURVIE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipNGTPDURVIE.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipNGTPDURVIE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipNGTPDURVIE.AppearanceHeader.Image = CType(resources.GetObject("ColEquipNGTPDURVIE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipNGTPDURVIE.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipNGTPDURVIE, "ColEquipNGTPDURVIE")
        Me.ColEquipNGTPDURVIE.FieldName = "NGTPDURVIE"
        Me.ColEquipNGTPDURVIE.Name = "ColEquipNGTPDURVIE"
        '
        'ColEquipNGTPSITQTE
        '
        Me.ColEquipNGTPSITQTE.AppearanceCell.Font = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceCell.Font"), System.Drawing.Font)
        Me.ColEquipNGTPSITQTE.AppearanceCell.FontSizeDelta = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceCell.FontSizeDelta"), Integer)
        Me.ColEquipNGTPSITQTE.AppearanceCell.FontStyleDelta = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipNGTPSITQTE.AppearanceCell.GradientMode = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipNGTPSITQTE.AppearanceCell.Image = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceCell.Image"), System.Drawing.Image)
        Me.ColEquipNGTPSITQTE.AppearanceCell.Options.UseFont = True
        Me.ColEquipNGTPSITQTE.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipNGTPSITQTE.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipNGTPSITQTE.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipNGTPSITQTE.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipNGTPSITQTE.AppearanceHeader.Image = CType(resources.GetObject("ColEquipNGTPSITQTE.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipNGTPSITQTE.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipNGTPSITQTE, "ColEquipNGTPSITQTE")
        Me.ColEquipNGTPSITQTE.FieldName = "NGTPSITQTE"
        Me.ColEquipNGTPSITQTE.Name = "ColEquipNGTPSITQTE"
        '
        'ColEquipVGTPUNITENOM
        '
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipVGTPUNITENOM.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipVGTPUNITENOM.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipVGTPUNITENOM.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipVGTPUNITENOM.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.Image = CType(resources.GetObject("ColEquipVGTPUNITENOM.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipVGTPUNITENOM.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipVGTPUNITENOM, "ColEquipVGTPUNITENOM")
        Me.ColEquipVGTPUNITENOM.FieldName = "VGTPUNITENOM"
        Me.ColEquipVGTPUNITENOM.Name = "ColEquipVGTPUNITENOM"
        '
        'ColEquipNGTPCOUTUNIT
        '
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.BackColor = CType(resources.GetObject("ColEquipNGTPCOUTUNIT.AppearanceHeader.BackColor"), System.Drawing.Color)
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("ColEquipNGTPCOUTUNIT.AppearanceHeader.FontSizeDelta"), Integer)
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("ColEquipNGTPCOUTUNIT.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.GradientMode = CType(resources.GetObject("ColEquipNGTPCOUTUNIT.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.Image = CType(resources.GetObject("ColEquipNGTPCOUTUNIT.AppearanceHeader.Image"), System.Drawing.Image)
        Me.ColEquipNGTPCOUTUNIT.AppearanceHeader.Options.UseBackColor = True
        resources.ApplyResources(Me.ColEquipNGTPCOUTUNIT, "ColEquipNGTPCOUTUNIT")
        Me.ColEquipNGTPCOUTUNIT.FieldName = "NGTPCOUTUNIT"
        Me.ColEquipNGTPCOUTUNIT.Name = "ColEquipNGTPCOUTUNIT"
        '
        'GrpBudget
        '
        resources.ApplyResources(Me.GrpBudget, "GrpBudget")
        Me.GrpBudget.Controls.Add(Me.VGDAuditL)
        Me.GrpBudget.Name = "GrpBudget"
        Me.GrpBudget.TabStop = False
        '
        'VGDAuditL
        '
        resources.ApplyResources(Me.VGDAuditL, "VGDAuditL")
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.FontSizeDelta = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRecordValue.FontSizeDelta"), Integer)
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.FontStyleDelta = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRecordValue.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.ForeColor = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRecordValue.ForeColor"), System.Drawing.Color)
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.GradientMode = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRecordValue.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.Image = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRecordValue.Image"), System.Drawing.Image)
        Me.VGDAuditL.Appearance.ReadOnlyRecordValue.Options.UseForeColor = True
        Me.VGDAuditL.Appearance.ReadOnlyRow.FontSizeDelta = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRow.FontSizeDelta"), Integer)
        Me.VGDAuditL.Appearance.ReadOnlyRow.FontStyleDelta = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VGDAuditL.Appearance.ReadOnlyRow.ForeColor = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRow.ForeColor"), System.Drawing.Color)
        Me.VGDAuditL.Appearance.ReadOnlyRow.GradientMode = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VGDAuditL.Appearance.ReadOnlyRow.Image = CType(resources.GetObject("VGDAuditL.Appearance.ReadOnlyRow.Image"), System.Drawing.Image)
        Me.VGDAuditL.Appearance.ReadOnlyRow.Options.UseForeColor = True
        Me.VGDAuditL.Appearance.RecordValue.Font = CType(resources.GetObject("VGDAuditL.Appearance.RecordValue.Font"), System.Drawing.Font)
        Me.VGDAuditL.Appearance.RecordValue.FontSizeDelta = CType(resources.GetObject("VGDAuditL.Appearance.RecordValue.FontSizeDelta"), Integer)
        Me.VGDAuditL.Appearance.RecordValue.FontStyleDelta = CType(resources.GetObject("VGDAuditL.Appearance.RecordValue.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VGDAuditL.Appearance.RecordValue.GradientMode = CType(resources.GetObject("VGDAuditL.Appearance.RecordValue.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VGDAuditL.Appearance.RecordValue.Image = CType(resources.GetObject("VGDAuditL.Appearance.RecordValue.Image"), System.Drawing.Image)
        Me.VGDAuditL.Appearance.RecordValue.Options.UseFont = True
        Me.VGDAuditL.Appearance.RowHeaderPanel.Font = CType(resources.GetObject("VGDAuditL.Appearance.RowHeaderPanel.Font"), System.Drawing.Font)
        Me.VGDAuditL.Appearance.RowHeaderPanel.FontSizeDelta = CType(resources.GetObject("VGDAuditL.Appearance.RowHeaderPanel.FontSizeDelta"), Integer)
        Me.VGDAuditL.Appearance.RowHeaderPanel.FontStyleDelta = CType(resources.GetObject("VGDAuditL.Appearance.RowHeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.VGDAuditL.Appearance.RowHeaderPanel.GradientMode = CType(resources.GetObject("VGDAuditL.Appearance.RowHeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.VGDAuditL.Appearance.RowHeaderPanel.Image = CType(resources.GetObject("VGDAuditL.Appearance.RowHeaderPanel.Image"), System.Drawing.Image)
        Me.VGDAuditL.Appearance.RowHeaderPanel.Options.UseFont = True
        Me.VGDAuditL.Appearance.RowHeaderPanel.Options.UseTextOptions = True
        Me.VGDAuditL.Appearance.RowHeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.VGDAuditL.Appearance.RowHeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.VGDAuditL.Appearance.RowHeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VGDAuditL.Name = "VGDAuditL"
        Me.VGDAuditL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemGLEditNGTPTYPDEPID, Me.RepItemMemoVGTPORIGNOM, Me.RepItemMemoVJUSTIF, Me.RepItemGLNGTPETAGESTID})
        Me.VGDAuditL.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.CatBudg, Me.RowVGTPORIGNOM, Me.RowNGTPCOUTFORFAIT, Me.RowNGTPANNEETHEO, Me.RowNGTPANNEETECH, Me.RowVGTPJUSTIF, Me.RowNGTPTYPDEPID, Me.RowNGTPETAGESTID, Me.RowNGTPORIGID, Me.RowNGTPAUDITBUDGID})
        '
        'RepItemGLEditNGTPTYPDEPID
        '
        resources.ApplyResources(Me.RepItemGLEditNGTPTYPDEPID, "RepItemGLEditNGTPTYPDEPID")
        Me.RepItemGLEditNGTPTYPDEPID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLEditNGTPTYPDEPID.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLEditNGTPTYPDEPID.DisplayMember = "VGTPTYPDEPNOM"
        Me.RepItemGLEditNGTPTYPDEPID.Name = "RepItemGLEditNGTPTYPDEPID"
        Me.RepItemGLEditNGTPTYPDEPID.ValueMember = "NGTPTYPDEPID"
        Me.RepItemGLEditNGTPTYPDEPID.View = Me.RepGVGTPTYPDEP
        '
        'RepGVGTPTYPDEP
        '
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.Font = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.Image = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.RepGVGTPTYPDEP.Appearance.HeaderPanel.Options.UseFont = True
        Me.RepGVGTPTYPDEP.Appearance.Row.BackColor = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.RepGVGTPTYPDEP.Appearance.Row.Font = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.Font"), System.Drawing.Font)
        Me.RepGVGTPTYPDEP.Appearance.Row.FontSizeDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.FontSizeDelta"), Integer)
        Me.RepGVGTPTYPDEP.Appearance.Row.FontStyleDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepGVGTPTYPDEP.Appearance.Row.GradientMode = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepGVGTPTYPDEP.Appearance.Row.Image = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.Row.Image"), System.Drawing.Image)
        Me.RepGVGTPTYPDEP.Appearance.Row.Options.UseBackColor = True
        Me.RepGVGTPTYPDEP.Appearance.Row.Options.UseFont = True
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.BackColor = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.RowSeparator.BackColor"), System.Drawing.Color)
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.FontSizeDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.RowSeparator.FontSizeDelta"), Integer)
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.FontStyleDelta = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.RowSeparator.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.GradientMode = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.RowSeparator.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.Image = CType(resources.GetObject("RepGVGTPTYPDEP.Appearance.RowSeparator.Image"), System.Drawing.Image)
        Me.RepGVGTPTYPDEP.Appearance.RowSeparator.Options.UseBackColor = True
        resources.ApplyResources(Me.RepGVGTPTYPDEP, "RepGVGTPTYPDEP")
        Me.RepGVGTPTYPDEP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColGVCboNGTPTYPDEPID, Me.ColGVCboVGTPTYPDEPNOM})
        Me.RepGVGTPTYPDEP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepGVGTPTYPDEP.Name = "RepGVGTPTYPDEP"
        Me.RepGVGTPTYPDEP.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepGVGTPTYPDEP.OptionsView.ShowGroupPanel = False
        Me.RepGVGTPTYPDEP.RowHeight = 30
        '
        'ColGVCboNGTPTYPDEPID
        '
        resources.ApplyResources(Me.ColGVCboNGTPTYPDEPID, "ColGVCboNGTPTYPDEPID")
        Me.ColGVCboNGTPTYPDEPID.FieldName = "NGTPTYPDEPID"
        Me.ColGVCboNGTPTYPDEPID.Name = "ColGVCboNGTPTYPDEPID"
        '
        'ColGVCboVGTPTYPDEPNOM
        '
        resources.ApplyResources(Me.ColGVCboVGTPTYPDEPNOM, "ColGVCboVGTPTYPDEPNOM")
        Me.ColGVCboVGTPTYPDEPNOM.FieldName = "VGTPTYPDEPNOM"
        Me.ColGVCboVGTPTYPDEPNOM.Name = "ColGVCboVGTPTYPDEPNOM"
        '
        'RepItemMemoVGTPORIGNOM
        '
        resources.ApplyResources(Me.RepItemMemoVGTPORIGNOM, "RepItemMemoVGTPORIGNOM")
        Me.RepItemMemoVGTPORIGNOM.Appearance.BackColor = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.BackColor"), System.Drawing.Color)
        Me.RepItemMemoVGTPORIGNOM.Appearance.Font = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.Font"), System.Drawing.Font)
        Me.RepItemMemoVGTPORIGNOM.Appearance.FontSizeDelta = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.FontSizeDelta"), Integer)
        Me.RepItemMemoVGTPORIGNOM.Appearance.FontStyleDelta = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepItemMemoVGTPORIGNOM.Appearance.GradientMode = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepItemMemoVGTPORIGNOM.Appearance.Image = CType(resources.GetObject("RepItemMemoVGTPORIGNOM.Appearance.Image"), System.Drawing.Image)
        Me.RepItemMemoVGTPORIGNOM.Appearance.Options.UseBackColor = True
        Me.RepItemMemoVGTPORIGNOM.Appearance.Options.UseFont = True
        Me.RepItemMemoVGTPORIGNOM.Appearance.Options.UseTextOptions = True
        Me.RepItemMemoVGTPORIGNOM.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemMemoVGTPORIGNOM.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemMemoVGTPORIGNOM.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepItemMemoVGTPORIGNOM.Name = "RepItemMemoVGTPORIGNOM"
        '
        'RepItemMemoVJUSTIF
        '
        resources.ApplyResources(Me.RepItemMemoVJUSTIF, "RepItemMemoVJUSTIF")
        Me.RepItemMemoVJUSTIF.Appearance.FontSizeDelta = CType(resources.GetObject("RepItemMemoVJUSTIF.Appearance.FontSizeDelta"), Integer)
        Me.RepItemMemoVJUSTIF.Appearance.FontStyleDelta = CType(resources.GetObject("RepItemMemoVJUSTIF.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepItemMemoVJUSTIF.Appearance.GradientMode = CType(resources.GetObject("RepItemMemoVJUSTIF.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepItemMemoVJUSTIF.Appearance.Image = CType(resources.GetObject("RepItemMemoVJUSTIF.Appearance.Image"), System.Drawing.Image)
        Me.RepItemMemoVJUSTIF.Appearance.Options.UseTextOptions = True
        Me.RepItemMemoVJUSTIF.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemMemoVJUSTIF.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemMemoVJUSTIF.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RepItemMemoVJUSTIF.Name = "RepItemMemoVJUSTIF"
        '
        'RepItemGLNGTPETAGESTID
        '
        resources.ApplyResources(Me.RepItemGLNGTPETAGESTID, "RepItemGLNGTPETAGESTID")
        Me.RepItemGLNGTPETAGESTID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemGLNGTPETAGESTID.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemGLNGTPETAGESTID.Name = "RepItemGLNGTPETAGESTID"
        Me.RepItemGLNGTPETAGESTID.View = Me.RepItemGLVETAGESTDEP
        '
        'RepItemGLVETAGESTDEP
        '
        resources.ApplyResources(Me.RepItemGLVETAGESTDEP, "RepItemGLVETAGESTDEP")
        Me.RepItemGLVETAGESTDEP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColGVNGTPETAGESTID, Me.ColGVVGTPETAGESTNOM})
        Me.RepItemGLVETAGESTDEP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepItemGLVETAGESTDEP.Name = "RepItemGLVETAGESTDEP"
        Me.RepItemGLVETAGESTDEP.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepItemGLVETAGESTDEP.OptionsView.ShowGroupPanel = False
        '
        'ColGVNGTPETAGESTID
        '
        resources.ApplyResources(Me.ColGVNGTPETAGESTID, "ColGVNGTPETAGESTID")
        Me.ColGVNGTPETAGESTID.FieldName = "NGTPETAGESTID"
        Me.ColGVNGTPETAGESTID.Name = "ColGVNGTPETAGESTID"
        '
        'ColGVVGTPETAGESTNOM
        '
        resources.ApplyResources(Me.ColGVVGTPETAGESTNOM, "ColGVVGTPETAGESTNOM")
        Me.ColGVVGTPETAGESTNOM.FieldName = "VGTPETAGESTNOM"
        Me.ColGVVGTPETAGESTNOM.Name = "ColGVVGTPETAGESTNOM"
        '
        'CatBudg
        '
        Me.CatBudg.Appearance.BackColor = CType(resources.GetObject("CatBudg.Appearance.BackColor"), System.Drawing.Color)
        Me.CatBudg.Appearance.Font = CType(resources.GetObject("CatBudg.Appearance.Font"), System.Drawing.Font)
        Me.CatBudg.Appearance.FontSizeDelta = CType(resources.GetObject("CatBudg.Appearance.FontSizeDelta"), Integer)
        Me.CatBudg.Appearance.FontStyleDelta = CType(resources.GetObject("CatBudg.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.CatBudg.Appearance.ForeColor = CType(resources.GetObject("CatBudg.Appearance.ForeColor"), System.Drawing.Color)
        Me.CatBudg.Appearance.GradientMode = CType(resources.GetObject("CatBudg.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.CatBudg.Appearance.Image = CType(resources.GetObject("CatBudg.Appearance.Image"), System.Drawing.Image)
        Me.CatBudg.Appearance.Options.UseBackColor = True
        Me.CatBudg.Appearance.Options.UseFont = True
        Me.CatBudg.Appearance.Options.UseForeColor = True
        Me.CatBudg.Appearance.Options.UseTextOptions = True
        Me.CatBudg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CatBudg.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.CatBudg, "CatBudg")
        Me.CatBudg.Name = "CatBudg"
        Me.CatBudg.Properties.Caption = resources.GetString("CatBudg.Properties.Caption")
        Me.CatBudg.Properties.CustomizationCaption = resources.GetString("CatBudg.Properties.CustomizationCaption")
        Me.CatBudg.Properties.ImageIndex = CType(resources.GetObject("CatBudg.Properties.ImageIndex"), Integer)
        Me.CatBudg.Properties.RowEdit = CType(resources.GetObject("CatBudg.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.CatBudg.Properties.ToolTip = resources.GetString("CatBudg.Properties.ToolTip")
        Me.CatBudg.Properties.Value = CType(resources.GetObject("CatBudg.Properties.Value"), Object)
        '
        'RowVGTPORIGNOM
        '
        Me.RowVGTPORIGNOM.Appearance.BackColor = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.BackColor"), System.Drawing.Color)
        Me.RowVGTPORIGNOM.Appearance.Font = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.Font"), System.Drawing.Font)
        Me.RowVGTPORIGNOM.Appearance.FontSizeDelta = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.FontSizeDelta"), Integer)
        Me.RowVGTPORIGNOM.Appearance.FontStyleDelta = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RowVGTPORIGNOM.Appearance.ForeColor = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.ForeColor"), System.Drawing.Color)
        Me.RowVGTPORIGNOM.Appearance.GradientMode = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RowVGTPORIGNOM.Appearance.Image = CType(resources.GetObject("RowVGTPORIGNOM.Appearance.Image"), System.Drawing.Image)
        Me.RowVGTPORIGNOM.Appearance.Options.UseBackColor = True
        Me.RowVGTPORIGNOM.Appearance.Options.UseFont = True
        Me.RowVGTPORIGNOM.Appearance.Options.UseForeColor = True
        Me.RowVGTPORIGNOM.Appearance.Options.UseTextOptions = True
        Me.RowVGTPORIGNOM.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RowVGTPORIGNOM.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RowVGTPORIGNOM.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        resources.ApplyResources(Me.RowVGTPORIGNOM, "RowVGTPORIGNOM")
        Me.RowVGTPORIGNOM.Name = "RowVGTPORIGNOM"
        Me.RowVGTPORIGNOM.OptionsRow.AllowFocus = False
        Me.RowVGTPORIGNOM.Properties.Caption = resources.GetString("RowVGTPORIGNOM.Properties.Caption")
        Me.RowVGTPORIGNOM.Properties.CustomizationCaption = resources.GetString("RowVGTPORIGNOM.Properties.CustomizationCaption")
        Me.RowVGTPORIGNOM.Properties.FieldName = "VGTPORIGNOM"
        Me.RowVGTPORIGNOM.Properties.ImageIndex = CType(resources.GetObject("RowVGTPORIGNOM.Properties.ImageIndex"), Integer)
        Me.RowVGTPORIGNOM.Properties.ReadOnly = True
        Me.RowVGTPORIGNOM.Properties.RowEdit = Me.RepItemMemoVGTPORIGNOM
        Me.RowVGTPORIGNOM.Properties.ToolTip = resources.GetString("RowVGTPORIGNOM.Properties.ToolTip")
        Me.RowVGTPORIGNOM.Properties.Value = CType(resources.GetObject("RowVGTPORIGNOM.Properties.Value"), Object)
        '
        'RowNGTPCOUTFORFAIT
        '
        resources.ApplyResources(Me.RowNGTPCOUTFORFAIT, "RowNGTPCOUTFORFAIT")
        Me.RowNGTPCOUTFORFAIT.Name = "RowNGTPCOUTFORFAIT"
        Me.RowNGTPCOUTFORFAIT.Properties.Caption = resources.GetString("RowNGTPCOUTFORFAIT.Properties.Caption")
        Me.RowNGTPCOUTFORFAIT.Properties.CustomizationCaption = resources.GetString("RowNGTPCOUTFORFAIT.Properties.CustomizationCaption")
        Me.RowNGTPCOUTFORFAIT.Properties.FieldName = "NGTPCOUTFOR"
        Me.RowNGTPCOUTFORFAIT.Properties.ImageIndex = CType(resources.GetObject("RowNGTPCOUTFORFAIT.Properties.ImageIndex"), Integer)
        Me.RowNGTPCOUTFORFAIT.Properties.ReadOnly = True
        Me.RowNGTPCOUTFORFAIT.Properties.RowEdit = CType(resources.GetObject("RowNGTPCOUTFORFAIT.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.RowNGTPCOUTFORFAIT.Properties.ToolTip = resources.GetString("RowNGTPCOUTFORFAIT.Properties.ToolTip")
        Me.RowNGTPCOUTFORFAIT.Properties.Value = CType(resources.GetObject("RowNGTPCOUTFORFAIT.Properties.Value"), Object)
        '
        'RowNGTPANNEETHEO
        '
        resources.ApplyResources(Me.RowNGTPANNEETHEO, "RowNGTPANNEETHEO")
        Me.RowNGTPANNEETHEO.Name = "RowNGTPANNEETHEO"
        Me.RowNGTPANNEETHEO.Properties.Caption = resources.GetString("RowNGTPANNEETHEO.Properties.Caption")
        Me.RowNGTPANNEETHEO.Properties.CustomizationCaption = resources.GetString("RowNGTPANNEETHEO.Properties.CustomizationCaption")
        Me.RowNGTPANNEETHEO.Properties.FieldName = "NGTPANNEETHEO"
        Me.RowNGTPANNEETHEO.Properties.ImageIndex = CType(resources.GetObject("RowNGTPANNEETHEO.Properties.ImageIndex"), Integer)
        Me.RowNGTPANNEETHEO.Properties.ReadOnly = True
        Me.RowNGTPANNEETHEO.Properties.RowEdit = CType(resources.GetObject("RowNGTPANNEETHEO.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.RowNGTPANNEETHEO.Properties.ToolTip = resources.GetString("RowNGTPANNEETHEO.Properties.ToolTip")
        Me.RowNGTPANNEETHEO.Properties.Value = CType(resources.GetObject("RowNGTPANNEETHEO.Properties.Value"), Object)
        '
        'RowNGTPANNEETECH
        '
        resources.ApplyResources(Me.RowNGTPANNEETECH, "RowNGTPANNEETECH")
        Me.RowNGTPANNEETECH.Name = "RowNGTPANNEETECH"
        Me.RowNGTPANNEETECH.Properties.Caption = resources.GetString("RowNGTPANNEETECH.Properties.Caption")
        Me.RowNGTPANNEETECH.Properties.CustomizationCaption = resources.GetString("RowNGTPANNEETECH.Properties.CustomizationCaption")
        Me.RowNGTPANNEETECH.Properties.FieldName = "NGTPANNEETECH"
        Me.RowNGTPANNEETECH.Properties.ImageIndex = CType(resources.GetObject("RowNGTPANNEETECH.Properties.ImageIndex"), Integer)
        Me.RowNGTPANNEETECH.Properties.ReadOnly = True
        Me.RowNGTPANNEETECH.Properties.RowEdit = CType(resources.GetObject("RowNGTPANNEETECH.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.RowNGTPANNEETECH.Properties.ToolTip = resources.GetString("RowNGTPANNEETECH.Properties.ToolTip")
        Me.RowNGTPANNEETECH.Properties.Value = CType(resources.GetObject("RowNGTPANNEETECH.Properties.Value"), Object)
        '
        'RowVGTPJUSTIF
        '
        resources.ApplyResources(Me.RowVGTPJUSTIF, "RowVGTPJUSTIF")
        Me.RowVGTPJUSTIF.Name = "RowVGTPJUSTIF"
        Me.RowVGTPJUSTIF.Properties.Caption = resources.GetString("RowVGTPJUSTIF.Properties.Caption")
        Me.RowVGTPJUSTIF.Properties.CustomizationCaption = resources.GetString("RowVGTPJUSTIF.Properties.CustomizationCaption")
        Me.RowVGTPJUSTIF.Properties.FieldName = "VGTPJUSTIF"
        Me.RowVGTPJUSTIF.Properties.ImageIndex = CType(resources.GetObject("RowVGTPJUSTIF.Properties.ImageIndex"), Integer)
        Me.RowVGTPJUSTIF.Properties.ReadOnly = True
        Me.RowVGTPJUSTIF.Properties.RowEdit = Me.RepItemMemoVJUSTIF
        Me.RowVGTPJUSTIF.Properties.ToolTip = resources.GetString("RowVGTPJUSTIF.Properties.ToolTip")
        Me.RowVGTPJUSTIF.Properties.Value = CType(resources.GetObject("RowVGTPJUSTIF.Properties.Value"), Object)
        '
        'RowNGTPTYPDEPID
        '
        resources.ApplyResources(Me.RowNGTPTYPDEPID, "RowNGTPTYPDEPID")
        Me.RowNGTPTYPDEPID.Name = "RowNGTPTYPDEPID"
        Me.RowNGTPTYPDEPID.Properties.Caption = resources.GetString("RowNGTPTYPDEPID.Properties.Caption")
        Me.RowNGTPTYPDEPID.Properties.CustomizationCaption = resources.GetString("RowNGTPTYPDEPID.Properties.CustomizationCaption")
        Me.RowNGTPTYPDEPID.Properties.FieldName = "NGTPTYPDEPID"
        Me.RowNGTPTYPDEPID.Properties.ImageIndex = CType(resources.GetObject("RowNGTPTYPDEPID.Properties.ImageIndex"), Integer)
        Me.RowNGTPTYPDEPID.Properties.ReadOnly = True
        Me.RowNGTPTYPDEPID.Properties.RowEdit = Me.RepItemGLEditNGTPTYPDEPID
        Me.RowNGTPTYPDEPID.Properties.ToolTip = resources.GetString("RowNGTPTYPDEPID.Properties.ToolTip")
        Me.RowNGTPTYPDEPID.Properties.Value = CType(resources.GetObject("RowNGTPTYPDEPID.Properties.Value"), Object)
        '
        'RowNGTPETAGESTID
        '
        resources.ApplyResources(Me.RowNGTPETAGESTID, "RowNGTPETAGESTID")
        Me.RowNGTPETAGESTID.Name = "RowNGTPETAGESTID"
        Me.RowNGTPETAGESTID.Properties.Caption = resources.GetString("RowNGTPETAGESTID.Properties.Caption")
        Me.RowNGTPETAGESTID.Properties.CustomizationCaption = resources.GetString("RowNGTPETAGESTID.Properties.CustomizationCaption")
        Me.RowNGTPETAGESTID.Properties.FieldName = "NGTPETAGESTID"
        Me.RowNGTPETAGESTID.Properties.ImageIndex = CType(resources.GetObject("RowNGTPETAGESTID.Properties.ImageIndex"), Integer)
        Me.RowNGTPETAGESTID.Properties.ReadOnly = True
        Me.RowNGTPETAGESTID.Properties.RowEdit = Me.RepItemGLNGTPETAGESTID
        Me.RowNGTPETAGESTID.Properties.ToolTip = resources.GetString("RowNGTPETAGESTID.Properties.ToolTip")
        Me.RowNGTPETAGESTID.Properties.Value = CType(resources.GetObject("RowNGTPETAGESTID.Properties.Value"), Object)
        '
        'RowNGTPORIGID
        '
        resources.ApplyResources(Me.RowNGTPORIGID, "RowNGTPORIGID")
        Me.RowNGTPORIGID.Name = "RowNGTPORIGID"
        Me.RowNGTPORIGID.Properties.Caption = resources.GetString("RowNGTPORIGID.Properties.Caption")
        Me.RowNGTPORIGID.Properties.CustomizationCaption = resources.GetString("RowNGTPORIGID.Properties.CustomizationCaption")
        Me.RowNGTPORIGID.Properties.FieldName = "NGTPORIGID"
        Me.RowNGTPORIGID.Properties.ImageIndex = CType(resources.GetObject("RowNGTPORIGID.Properties.ImageIndex"), Integer)
        Me.RowNGTPORIGID.Properties.RowEdit = CType(resources.GetObject("RowNGTPORIGID.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.RowNGTPORIGID.Properties.ToolTip = resources.GetString("RowNGTPORIGID.Properties.ToolTip")
        Me.RowNGTPORIGID.Properties.Value = CType(resources.GetObject("RowNGTPORIGID.Properties.Value"), Object)
        '
        'RowNGTPAUDITBUDGID
        '
        resources.ApplyResources(Me.RowNGTPAUDITBUDGID, "RowNGTPAUDITBUDGID")
        Me.RowNGTPAUDITBUDGID.Name = "RowNGTPAUDITBUDGID"
        Me.RowNGTPAUDITBUDGID.Properties.Caption = resources.GetString("RowNGTPAUDITBUDGID.Properties.Caption")
        Me.RowNGTPAUDITBUDGID.Properties.CustomizationCaption = resources.GetString("RowNGTPAUDITBUDGID.Properties.CustomizationCaption")
        Me.RowNGTPAUDITBUDGID.Properties.FieldName = "NGTPAUDITBUDGID"
        Me.RowNGTPAUDITBUDGID.Properties.ImageIndex = CType(resources.GetObject("RowNGTPAUDITBUDGID.Properties.ImageIndex"), Integer)
        Me.RowNGTPAUDITBUDGID.Properties.RowEdit = CType(resources.GetObject("RowNGTPAUDITBUDGID.Properties.RowEdit"), DevExpress.XtraEditors.Repository.RepositoryItem)
        Me.RowNGTPAUDITBUDGID.Properties.ToolTip = resources.GetString("RowNGTPAUDITBUDGID.Properties.ToolTip")
        Me.RowNGTPAUDITBUDGID.Properties.Value = CType(resources.GetObject("RowNGTPAUDITBUDGID.Properties.Value"), Object)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGTPAuditDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpBudget)
        Me.Controls.Add(Me.GrpInfoEquipement)
        Me.Controls.Add(Me.GrpAction)
        Me.Name = "frmGTPAuditDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpAction.ResumeLayout(False)
        Me.GrpInfoEquipement.ResumeLayout(False)
        CType(Me.GCInfoEquipement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CVInfoEquipement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBudget.ResumeLayout(False)
        CType(Me.VGDAuditL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLEditNGTPTYPDEPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepGVGTPTYPDEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemMemoVGTPORIGNOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemMemoVJUSTIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLNGTPETAGESTID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemGLVETAGESTDEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpAction As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents GrpInfoEquipement As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBudget As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CatBudg As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents RowVGTPORIGNOM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPCOUTFORFAIT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPANNEETHEO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPANNEETECH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowVGTPJUSTIF As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPTYPDEPID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPETAGESTID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPORIGID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RowNGTPAUDITBUDGID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Private WithEvents GCInfoEquipement As DevExpress.XtraGrid.GridControl
    Private WithEvents CVInfoEquipement As DevExpress.XtraGrid.Views.Card.CardView
    Private WithEvents ColEquipNGTPSITID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipNSITNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipNGTPMAINID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPZONENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPLOTNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPEQUIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPPRECIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPSITOBS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipNGTPDURVIE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipNGTPSITQTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipVGTPUNITENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColEquipNGTPCOUTUNIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VGDAuditL As DevExpress.XtraVerticalGrid.VGridControl
    Private WithEvents RepItemGLEditNGTPTYPDEPID As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepGVGTPTYPDEP As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColGVCboNGTPTYPDEPID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColGVCboVGTPTYPDEPNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemMemoVGTPORIGNOM As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents RepItemMemoVJUSTIF As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Private WithEvents RepItemGLNGTPETAGESTID As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Private WithEvents RepItemGLVETAGESTDEP As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ColGVNGTPETAGESTID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ColGVVGTPETAGESTNOM As DevExpress.XtraGrid.Columns.GridColumn
End Class
