<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCompteAnaCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompteAnaCreate))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpDetailCompteAna = New System.Windows.Forms.GroupBox()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRFA = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridLookUpTypeCompteAna = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEditTypeCompteView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColCIDTYPECOMPTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBTYPECOMPTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNCANNUM = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtVCANLIB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        Me.GrpDetailCompteAna.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpTypeCompteAna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditTypeCompteView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCANNUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnQuit)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
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
        'GrpDetailCompteAna
        '
        Me.GrpDetailCompteAna.Controls.Add(Me.GridLookUpEdit1)
        Me.GrpDetailCompteAna.Controls.Add(Me.Label5)
        Me.GrpDetailCompteAna.Controls.Add(Me.txtRFA)
        Me.GrpDetailCompteAna.Controls.Add(Me.Label3)
        Me.GrpDetailCompteAna.Controls.Add(Me.GridLookUpTypeCompteAna)
        Me.GrpDetailCompteAna.Controls.Add(Me.txtNCANNUM)
        Me.GrpDetailCompteAna.Controls.Add(Me.Label4)
        Me.GrpDetailCompteAna.Controls.Add(Me.Label2)
        Me.GrpDetailCompteAna.Controls.Add(Me.TxtVCANLIB)
        Me.GrpDetailCompteAna.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GrpDetailCompteAna, "GrpDetailCompteAna")
        Me.GrpDetailCompteAna.Name = "GrpDetailCompteAna"
        Me.GrpDetailCompteAna.TabStop = False
        '
        'GridLookUpEdit1
        '
        resources.ApplyResources(Me.GridLookUpEdit1, "GridLookUpEdit1")
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridLookUpEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridLookUpEdit1.Properties.DisplayMember = "VLIBMBEHMBE"
        Me.GridLookUpEdit1.Properties.NullText = resources.GetString("GridLookUpEdit1.Properties.NullText")
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView1
        Me.GridLookUpEdit1.Properties.ValueMember = "VLIBMBEHMBE"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "VLIBMBEHMBE"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "VLIBMBEHMBE"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtRFA
        '
        resources.ApplyResources(Me.txtRFA, "txtRFA")
        Me.txtRFA.Name = "txtRFA"
        Me.txtRFA.Properties.Mask.EditMask = resources.GetString("txtRFA.Properties.Mask.EditMask")
        Me.txtRFA.Properties.Mask.MaskType = CType(resources.GetObject("txtRFA.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtRFA.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtRFA.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GridLookUpTypeCompteAna
        '
        resources.ApplyResources(Me.GridLookUpTypeCompteAna, "GridLookUpTypeCompteAna")
        Me.GridLookUpTypeCompteAna.Name = "GridLookUpTypeCompteAna"
        Me.GridLookUpTypeCompteAna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GridLookUpTypeCompteAna.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GridLookUpTypeCompteAna.Properties.DisplayMember = "VTYPECTE"
        Me.GridLookUpTypeCompteAna.Properties.NullText = resources.GetString("GridLookUpTypeCompteAna.Properties.NullText")
        Me.GridLookUpTypeCompteAna.Properties.PopupView = Me.GridLookUpEditTypeCompteView
        Me.GridLookUpTypeCompteAna.Properties.ValueMember = "CTYPECTE"
        '
        'GridLookUpEditTypeCompteView
        '
        Me.GridLookUpEditTypeCompteView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCIDTYPECOMPTE, Me.GColVLIBTYPECOMPTE})
        Me.GridLookUpEditTypeCompteView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEditTypeCompteView.Name = "GridLookUpEditTypeCompteView"
        Me.GridLookUpEditTypeCompteView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEditTypeCompteView.OptionsView.ShowGroupPanel = False
        '
        'GColCIDTYPECOMPTE
        '
        Me.GColCIDTYPECOMPTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColCIDTYPECOMPTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCIDTYPECOMPTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColCIDTYPECOMPTE, "GColCIDTYPECOMPTE")
        Me.GColCIDTYPECOMPTE.FieldName = "CTYPECTE"
        Me.GColCIDTYPECOMPTE.Name = "GColCIDTYPECOMPTE"
        Me.GColCIDTYPECOMPTE.OptionsColumn.AllowEdit = False
        Me.GColCIDTYPECOMPTE.OptionsColumn.ReadOnly = True
        '
        'GColVLIBTYPECOMPTE
        '
        Me.GColVLIBTYPECOMPTE.AppearanceHeader.Font = CType(resources.GetObject("GColVLIBTYPECOMPTE.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GColVLIBTYPECOMPTE.AppearanceHeader.Options.UseFont = True
        Me.GColVLIBTYPECOMPTE.AppearanceHeader.Options.UseTextOptions = True
        Me.GColVLIBTYPECOMPTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColVLIBTYPECOMPTE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GColVLIBTYPECOMPTE, "GColVLIBTYPECOMPTE")
        Me.GColVLIBTYPECOMPTE.FieldName = "VTYPECTE"
        Me.GColVLIBTYPECOMPTE.Name = "GColVLIBTYPECOMPTE"
        '
        'txtNCANNUM
        '
        resources.ApplyResources(Me.txtNCANNUM, "txtNCANNUM")
        Me.txtNCANNUM.Name = "txtNCANNUM"
        Me.txtNCANNUM.Properties.Mask.EditMask = resources.GetString("txtNCANNUM.Properties.Mask.EditMask")
        Me.txtNCANNUM.Properties.Mask.MaskType = CType(resources.GetObject("txtNCANNUM.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtNCANNUM.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtNCANNUM.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtVCANLIB
        '
        resources.ApplyResources(Me.TxtVCANLIB, "TxtVCANLIB")
        Me.TxtVCANLIB.Name = "TxtVCANLIB"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'frmGestCompteAnaCreate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpDetailCompteAna)
        Me.Name = "frmGestCompteAnaCreate"
        Me.GrpActions.ResumeLayout(False)
        Me.GrpDetailCompteAna.ResumeLayout(False)
        Me.GrpDetailCompteAna.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpTypeCompteAna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditTypeCompteView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCANNUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpDetailCompteAna As System.Windows.Forms.GroupBox
    Friend WithEvents TxtVCANLIB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtNCANNUM As DevExpress.XtraEditors.TextEdit
    Private WithEvents GridLookUpTypeCompteAna As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridLookUpEditTypeCompteView As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCIDTYPECOMPTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVLIBTYPECOMPTE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents txtRFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Private WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As Label
End Class
