<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDuplicatePersonnel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDuplicatePersonnel))
    Me.GrpActions = New System.Windows.Forms.GroupBox()
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.BtnSave = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
    Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.TreeList2 = New DevExpress.XtraTreeList.TreeList()
    Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
    Me.GrpActions.SuspendLayout()
    CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GrpActions
    '
    resources.ApplyResources(Me.GrpActions, "GrpActions")
    Me.GrpActions.Controls.Add(Me.BtnQuit)
    Me.GrpActions.Controls.Add(Me.BtnSave)
    Me.GrpActions.Name = "GrpActions"
    Me.GrpActions.TabStop = False
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'BtnSave
    '
    resources.ApplyResources(Me.BtnSave, "BtnSave")
    Me.BtnSave.Name = "BtnSave"
    Me.BtnSave.UseVisualStyleBackColor = True
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'TreeList1
    '
    resources.ApplyResources(Me.TreeList1, "TreeList1")
    Me.TreeList1.Appearance.FocusedCell.Font = CType(resources.GetObject("TreeList1.Appearance.FocusedCell.Font"), System.Drawing.Font)
    Me.TreeList1.Appearance.FocusedCell.FontSizeDelta = CType(resources.GetObject("TreeList1.Appearance.FocusedCell.FontSizeDelta"), Integer)
    Me.TreeList1.Appearance.FocusedCell.FontStyleDelta = CType(resources.GetObject("TreeList1.Appearance.FocusedCell.FontStyleDelta"), System.Drawing.FontStyle)
    Me.TreeList1.Appearance.FocusedCell.GradientMode = CType(resources.GetObject("TreeList1.Appearance.FocusedCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
    Me.TreeList1.Appearance.FocusedCell.Image = CType(resources.GetObject("TreeList1.Appearance.FocusedCell.Image"), System.Drawing.Image)
    Me.TreeList1.Appearance.FocusedCell.Options.UseFont = True
    Me.TreeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
    Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2})
    Me.TreeList1.KeyFieldName = "NMENUNUM"
    Me.TreeList1.Name = "TreeList1"
    Me.TreeList1.OptionsBehavior.Editable = False
    Me.TreeList1.OptionsBehavior.ReadOnly = True
    Me.TreeList1.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended
    Me.TreeList1.OptionsView.ShowAutoFilterRow = True
    Me.TreeList1.OptionsView.ShowCaption = True
    Me.TreeList1.OptionsView.ShowColumns = False
    Me.TreeList1.OptionsView.ShowHorzLines = False
    Me.TreeList1.OptionsView.ShowVertLines = False
    Me.TreeList1.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
    Me.TreeList1.ParentFieldName = "NMENUPARENT"
    Me.TreeList1.PreviewFieldName = "VMENULIB"
    Me.TreeList1.SelectImageList = Me.ImageList1
    '
    'TreeListColumn1
    '
    resources.ApplyResources(Me.TreeListColumn1, "TreeListColumn1")
    Me.TreeListColumn1.FieldName = "VMENULIB"
    Me.TreeListColumn1.ImageOptions.ImageIndex = CType(resources.GetObject("TreeListColumn1.ImageOptions.ImageIndex"), Integer)
    Me.TreeListColumn1.Name = "TreeListColumn1"
    Me.TreeListColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains
    '
    'TreeListColumn2
    '
    resources.ApplyResources(Me.TreeListColumn2, "TreeListColumn2")
    Me.TreeListColumn2.FieldName = "NMENUNUM"
    Me.TreeListColumn2.ImageOptions.ImageIndex = CType(resources.GetObject("TreeListColumn2.ImageOptions.ImageIndex"), Integer)
    Me.TreeListColumn2.Name = "TreeListColumn2"
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "Folder.ico")
    '
    'TreeList2
    '
    resources.ApplyResources(Me.TreeList2, "TreeList2")
    Me.TreeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn3})
    Me.TreeList2.KeyFieldName = "ID_TEST"
    Me.TreeList2.Name = "TreeList2"
    Me.TreeList2.ParentFieldName = "NMENUPARENT"
    '
    'TreeListColumn3
    '
    resources.ApplyResources(Me.TreeListColumn3, "TreeListColumn3")
    Me.TreeListColumn3.FieldName = "VSOCIETE"
    Me.TreeListColumn3.ImageOptions.ImageIndex = CType(resources.GetObject("TreeListColumn3.ImageOptions.ImageIndex"), Integer)
    Me.TreeListColumn3.Name = "TreeListColumn3"
    '
    'frmDuplicatePersonnel
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.TreeList2)
    Me.Controls.Add(Me.TreeList1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GrpActions)
    Me.Name = "frmDuplicatePersonnel"
    Me.GrpActions.ResumeLayout(False)
    CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents GrpActions As GroupBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
