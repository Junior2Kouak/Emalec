<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDomaineTech
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDomaineTech))
        Me.GCDomaine = New DevExpress.XtraGrid.GridControl()
        Me.GVListeDomaine = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNCONTGESTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCONTDOMLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNORDERBY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepItemCboOrder = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GrpboxActions = New System.Windows.Forms.GroupBox()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpLangue = New System.Windows.Forms.GroupBox()
        Me.CboLangue = New System.Windows.Forms.ComboBox()
        Me.LblLangue = New System.Windows.Forms.Label()
        CType(Me.GCDomaine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeDomaine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpboxActions.SuspendLayout()
        Me.GrpLangue.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCDomaine
        '
        resources.ApplyResources(Me.GCDomaine, "GCDomaine")
        '
        '
        '
        Me.GCDomaine.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCDomaine.EmbeddedNavigator.AccessibleDescription")
        Me.GCDomaine.EmbeddedNavigator.AccessibleName = resources.GetString("GCDomaine.EmbeddedNavigator.AccessibleName")
        Me.GCDomaine.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCDomaine.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCDomaine.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCDomaine.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCDomaine.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCDomaine.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCDomaine.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCDomaine.EmbeddedNavigator.ToolTip = resources.GetString("GCDomaine.EmbeddedNavigator.ToolTip")
        Me.GCDomaine.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCDomaine.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCDomaine.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCDomaine.EmbeddedNavigator.ToolTipTitle")
        Me.GCDomaine.MainView = Me.GVListeDomaine
        Me.GCDomaine.Name = "GCDomaine"
        Me.GCDomaine.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepItemCboOrder})
        Me.GCDomaine.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeDomaine})
        '
        'GVListeDomaine
        '
        Me.GVListeDomaine.Appearance.Row.BackColor = CType(resources.GetObject("GVListeDomaine.Appearance.Row.BackColor"), System.Drawing.Color)
        Me.GVListeDomaine.Appearance.Row.FontSizeDelta = CType(resources.GetObject("GVListeDomaine.Appearance.Row.FontSizeDelta"), Integer)
        Me.GVListeDomaine.Appearance.Row.FontStyleDelta = CType(resources.GetObject("GVListeDomaine.Appearance.Row.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeDomaine.Appearance.Row.GradientMode = CType(resources.GetObject("GVListeDomaine.Appearance.Row.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeDomaine.Appearance.Row.Image = CType(resources.GetObject("GVListeDomaine.Appearance.Row.Image"), System.Drawing.Image)
        Me.GVListeDomaine.Appearance.Row.Options.UseBackColor = True
        Me.GVListeDomaine.Appearance.SelectedRow.BackColor = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.BackColor"), System.Drawing.Color)
        Me.GVListeDomaine.Appearance.SelectedRow.Font = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.Font"), System.Drawing.Font)
        Me.GVListeDomaine.Appearance.SelectedRow.FontSizeDelta = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.FontSizeDelta"), Integer)
        Me.GVListeDomaine.Appearance.SelectedRow.FontStyleDelta = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVListeDomaine.Appearance.SelectedRow.GradientMode = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVListeDomaine.Appearance.SelectedRow.Image = CType(resources.GetObject("GVListeDomaine.Appearance.SelectedRow.Image"), System.Drawing.Image)
        Me.GVListeDomaine.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVListeDomaine.Appearance.SelectedRow.Options.UseFont = True
        resources.ApplyResources(Me.GVListeDomaine, "GVListeDomaine")
        Me.GVListeDomaine.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColIDTMP, Me.GColNCONTGESTNUM, Me.GColVCONTDOMLIB, Me.GColNORDERBY})
        Me.GVListeDomaine.GridControl = Me.GCDomaine
        Me.GVListeDomaine.Name = "GVListeDomaine"
        Me.GVListeDomaine.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVListeDomaine.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVListeDomaine.OptionsBehavior.Editable = False
        Me.GVListeDomaine.OptionsBehavior.ReadOnly = True
        Me.GVListeDomaine.OptionsCustomization.AllowSort = False
        Me.GVListeDomaine.OptionsView.ShowAutoFilterRow = True
        Me.GVListeDomaine.OptionsView.ShowGroupPanel = False
        Me.GVListeDomaine.RowHeight = 30
        '
        'GColIDTMP
        '
        resources.ApplyResources(Me.GColIDTMP, "GColIDTMP")
        Me.GColIDTMP.FieldName = "IDTMP"
        Me.GColIDTMP.Name = "GColIDTMP"
        Me.GColIDTMP.OptionsColumn.ReadOnly = True
        '
        'GColNCONTGESTNUM
        '
        resources.ApplyResources(Me.GColNCONTGESTNUM, "GColNCONTGESTNUM")
        Me.GColNCONTGESTNUM.FieldName = "NCONTGESTNUM"
        Me.GColNCONTGESTNUM.Name = "GColNCONTGESTNUM"
        Me.GColNCONTGESTNUM.OptionsColumn.ReadOnly = True
        '
        'GColVCONTDOMLIB
        '
        Me.GColVCONTDOMLIB.AppearanceCell.Font = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColVCONTDOMLIB.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColVCONTDOMLIB.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCONTDOMLIB.AppearanceCell.GradientMode = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCONTDOMLIB.AppearanceCell.Image = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColVCONTDOMLIB.AppearanceCell.Options.UseFont = True
        Me.GColVCONTDOMLIB.AppearanceHeader.Font = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVCONTDOMLIB.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColVCONTDOMLIB.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColVCONTDOMLIB.AppearanceHeader.GradientMode = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColVCONTDOMLIB.AppearanceHeader.Image = CType(resources.GetObject("GColVCONTDOMLIB.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseFont = True
        Me.GColVCONTDOMLIB.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVCONTDOMLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVCONTDOMLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVCONTDOMLIB, "GColVCONTDOMLIB")
        Me.GColVCONTDOMLIB.FieldName = "VCONTDOMLIB"
        Me.GColVCONTDOMLIB.Name = "GColVCONTDOMLIB"
        Me.GColVCONTDOMLIB.OptionsColumn.AllowEdit = False
        Me.GColVCONTDOMLIB.OptionsColumn.ReadOnly = True
        Me.GColVCONTDOMLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GColNORDERBY
        '
        Me.GColNORDERBY.AppearanceCell.Font = CType(resources.GetObject("GColNORDERBY.AppearanceCell.Font"), System.Drawing.Font)
        Me.GColNORDERBY.AppearanceCell.FontSizeDelta = CType(resources.GetObject("GColNORDERBY.AppearanceCell.FontSizeDelta"), Integer)
        Me.GColNORDERBY.AppearanceCell.FontStyleDelta = CType(resources.GetObject("GColNORDERBY.AppearanceCell.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNORDERBY.AppearanceCell.GradientMode = CType(resources.GetObject("GColNORDERBY.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNORDERBY.AppearanceCell.Image = CType(resources.GetObject("GColNORDERBY.AppearanceCell.Image"), System.Drawing.Image)
        Me.GColNORDERBY.AppearanceCell.Options.UseFont = True
        Me.GColNORDERBY.AppearanceCell.Options.UseTextOptions = True
        Me.GColNORDERBY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNORDERBY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNORDERBY.AppearanceHeader.Font = CType(resources.GetObject("GColNORDERBY.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColNORDERBY.AppearanceHeader.FontSizeDelta = CType(resources.GetObject("GColNORDERBY.AppearanceHeader.FontSizeDelta"), Integer)
        Me.GColNORDERBY.AppearanceHeader.FontStyleDelta = CType(resources.GetObject("GColNORDERBY.AppearanceHeader.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GColNORDERBY.AppearanceHeader.GradientMode = CType(resources.GetObject("GColNORDERBY.AppearanceHeader.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GColNORDERBY.AppearanceHeader.Image = CType(resources.GetObject("GColNORDERBY.AppearanceHeader.Image"), System.Drawing.Image)
        Me.GColNORDERBY.AppearanceHeader.Options.UseFont = True
        Me.GColNORDERBY.AppearanceHeader.Options.UseTextOptions = True
        Me.GColNORDERBY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNORDERBY.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColNORDERBY, "GColNORDERBY")
        Me.GColNORDERBY.FieldName = "NORDERBY"
        Me.GColNORDERBY.Name = "GColNORDERBY"
        Me.GColNORDERBY.OptionsFilter.AllowAutoFilter = False
        Me.GColNORDERBY.OptionsFilter.AllowFilter = False
        Me.GColNORDERBY.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'RepItemCboOrder
        '
        resources.ApplyResources(Me.RepItemCboOrder, "RepItemCboOrder")
        Me.RepItemCboOrder.Appearance.Font = CType(resources.GetObject("RepItemCboOrder.Appearance.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.Appearance.FontSizeDelta = CType(resources.GetObject("RepItemCboOrder.Appearance.FontSizeDelta"), Integer)
        Me.RepItemCboOrder.Appearance.FontStyleDelta = CType(resources.GetObject("RepItemCboOrder.Appearance.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepItemCboOrder.Appearance.GradientMode = CType(resources.GetObject("RepItemCboOrder.Appearance.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepItemCboOrder.Appearance.Image = CType(resources.GetObject("RepItemCboOrder.Appearance.Image"), System.Drawing.Image)
        Me.RepItemCboOrder.Appearance.Options.UseFont = True
        Me.RepItemCboOrder.Appearance.Options.UseTextOptions = True
        Me.RepItemCboOrder.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemCboOrder.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepItemCboOrder.AppearanceDropDown.BackColor = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.BackColor"), System.Drawing.Color)
        Me.RepItemCboOrder.AppearanceDropDown.Font = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.Font"), System.Drawing.Font)
        Me.RepItemCboOrder.AppearanceDropDown.FontSizeDelta = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.FontSizeDelta"), Integer)
        Me.RepItemCboOrder.AppearanceDropDown.FontStyleDelta = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.FontStyleDelta"), System.Drawing.FontStyle)
        Me.RepItemCboOrder.AppearanceDropDown.GradientMode = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.RepItemCboOrder.AppearanceDropDown.Image = CType(resources.GetObject("RepItemCboOrder.AppearanceDropDown.Image"), System.Drawing.Image)
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseBackColor = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseFont = True
        Me.RepItemCboOrder.AppearanceDropDown.Options.UseTextOptions = True
        Me.RepItemCboOrder.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepItemCboOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepItemCboOrder.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepItemCboOrder.Name = "RepItemCboOrder"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GrpboxActions
        '
        resources.ApplyResources(Me.GrpboxActions, "GrpboxActions")
        Me.GrpboxActions.Controls.Add(Me.BtnUp)
        Me.GrpboxActions.Controls.Add(Me.BtnDown)
        Me.GrpboxActions.Controls.Add(Me.BtnNew)
        Me.GrpboxActions.Controls.Add(Me.BtnModif)
        Me.GrpboxActions.Controls.Add(Me.BtnPrint)
        Me.GrpboxActions.Controls.Add(Me.BtnClose)
        Me.GrpboxActions.Name = "GrpboxActions"
        Me.GrpboxActions.TabStop = False
        '
        'BtnUp
        '
        resources.ApplyResources(Me.BtnUp, "BtnUp")
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        resources.ApplyResources(Me.BtnDown, "BtnDown")
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        resources.ApplyResources(Me.BtnNew, "BtnNew")
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        resources.ApplyResources(Me.BtnModif, "BtnModif")
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GrpLangue
        '
        resources.ApplyResources(Me.GrpLangue, "GrpLangue")
        Me.GrpLangue.Controls.Add(Me.CboLangue)
        Me.GrpLangue.Controls.Add(Me.LblLangue)
        Me.GrpLangue.Name = "GrpLangue"
        Me.GrpLangue.TabStop = False
        '
        'CboLangue
        '
        resources.ApplyResources(Me.CboLangue, "CboLangue")
        Me.CboLangue.DisplayMember = "LANGUE"
        Me.CboLangue.FormattingEnabled = True
        Me.CboLangue.Name = "CboLangue"
        Me.CboLangue.ValueMember = "LANGUE"
        '
        'LblLangue
        '
        resources.ApplyResources(Me.LblLangue, "LblLangue")
        Me.LblLangue.Name = "LblLangue"
        '
        'frmGestionDomaineTech
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCDomaine)
        Me.Controls.Add(Me.GrpLangue)
        Me.Controls.Add(Me.GrpboxActions)
        Me.Name = "frmGestionDomaineTech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCDomaine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeDomaine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepItemCboOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpboxActions.ResumeLayout(False)
        Me.GrpLangue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents GrpboxActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnModif As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GrpLangue As System.Windows.Forms.GroupBox
    Friend WithEvents LblLangue As System.Windows.Forms.Label
    Friend WithEvents CboLangue As System.Windows.Forms.ComboBox
    Friend WithEvents BtnUp As System.Windows.Forms.Button
    Friend WithEvents BtnDown As System.Windows.Forms.Button
    Private WithEvents GCDomaine As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeDomaine As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNCONTGESTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCONTDOMLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNORDERBY As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents RepItemCboOrder As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
