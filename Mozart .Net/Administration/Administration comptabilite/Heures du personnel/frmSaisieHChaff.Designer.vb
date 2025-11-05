<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieHChaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaisieHChaff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New DevExpress.XtraEditors.TextEdit()
        Me.txtHRSaisie = New DevExpress.XtraEditors.TextEdit()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GLEditNCANNUM = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GVNCANNUM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.TxtNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHRSaisie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLEditNCANNUM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVNCANNUM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtNom
        '
        resources.ApplyResources(Me.TxtNom, "TxtNom")
        Me.TxtNom.Name = "TxtNom"
        '
        '
        '
        Me.TxtNom.Properties.AccessibleDescription = resources.GetString("TxtNom.Properties.AccessibleDescription")
        Me.TxtNom.Properties.AccessibleName = resources.GetString("TxtNom.Properties.AccessibleName")
        Me.TxtNom.Properties.AllowFocused = False
        Me.TxtNom.Properties.AutoHeight = CType(resources.GetObject("TxtNom.Properties.AutoHeight"), Boolean)
        Me.TxtNom.Properties.Mask.AutoComplete = CType(resources.GetObject("TxtNom.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.TxtNom.Properties.Mask.BeepOnError = CType(resources.GetObject("TxtNom.Properties.Mask.BeepOnError"), Boolean)
        Me.TxtNom.Properties.Mask.EditMask = resources.GetString("TxtNom.Properties.Mask.EditMask")
        Me.TxtNom.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TxtNom.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.TxtNom.Properties.Mask.MaskType = CType(resources.GetObject("TxtNom.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.TxtNom.Properties.Mask.PlaceHolder = CType(resources.GetObject("TxtNom.Properties.Mask.PlaceHolder"), Char)
        Me.TxtNom.Properties.Mask.SaveLiteral = CType(resources.GetObject("TxtNom.Properties.Mask.SaveLiteral"), Boolean)
        Me.TxtNom.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TxtNom.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.TxtNom.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TxtNom.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.TxtNom.Properties.NullValuePrompt = resources.GetString("TxtNom.Properties.NullValuePrompt")
        Me.TxtNom.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("TxtNom.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.TxtNom.Properties.ReadOnly = True
        Me.TxtNom.TabStop = False
        '
        'txtHRSaisie
        '
        resources.ApplyResources(Me.txtHRSaisie, "txtHRSaisie")
        Me.txtHRSaisie.Name = "txtHRSaisie"
        '
        '
        '
        Me.txtHRSaisie.Properties.AccessibleDescription = resources.GetString("txtHRSaisie.Properties.AccessibleDescription")
        Me.txtHRSaisie.Properties.AccessibleName = resources.GetString("txtHRSaisie.Properties.AccessibleName")
        Me.txtHRSaisie.Properties.AutoHeight = CType(resources.GetObject("txtHRSaisie.Properties.AutoHeight"), Boolean)
        Me.txtHRSaisie.Properties.Mask.AutoComplete = CType(resources.GetObject("txtHRSaisie.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.txtHRSaisie.Properties.Mask.BeepOnError = CType(resources.GetObject("txtHRSaisie.Properties.Mask.BeepOnError"), Boolean)
        Me.txtHRSaisie.Properties.Mask.EditMask = resources.GetString("txtHRSaisie.Properties.Mask.EditMask")
        Me.txtHRSaisie.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtHRSaisie.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.txtHRSaisie.Properties.Mask.MaskType = CType(resources.GetObject("txtHRSaisie.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.txtHRSaisie.Properties.Mask.PlaceHolder = CType(resources.GetObject("txtHRSaisie.Properties.Mask.PlaceHolder"), Char)
        Me.txtHRSaisie.Properties.Mask.SaveLiteral = CType(resources.GetObject("txtHRSaisie.Properties.Mask.SaveLiteral"), Boolean)
        Me.txtHRSaisie.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("txtHRSaisie.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.txtHRSaisie.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("txtHRSaisie.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.txtHRSaisie.Properties.NullValuePrompt = resources.GetString("txtHRSaisie.Properties.NullValuePrompt")
        Me.txtHRSaisie.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("txtHRSaisie.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        resources.ApplyResources(Me.BtnOK, "BtnOK")
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'GLEditNCANNUM
        '
        resources.ApplyResources(Me.GLEditNCANNUM, "GLEditNCANNUM")
        Me.GLEditNCANNUM.Name = "GLEditNCANNUM"
        '
        '
        '
        Me.GLEditNCANNUM.Properties.AccessibleDescription = resources.GetString("GLEditNCANNUM.Properties.AccessibleDescription")
        Me.GLEditNCANNUM.Properties.AccessibleName = resources.GetString("GLEditNCANNUM.Properties.AccessibleName")
        Me.GLEditNCANNUM.Properties.AutoHeight = CType(resources.GetObject("GLEditNCANNUM.Properties.AutoHeight"), Boolean)
        Me.GLEditNCANNUM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GLEditNCANNUM.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GLEditNCANNUM.Properties.DisplayMember = "VCANLIB"
        Me.GLEditNCANNUM.Properties.NullText = resources.GetString("GLEditNCANNUM.Properties.NullText")
        Me.GLEditNCANNUM.Properties.NullValuePrompt = resources.GetString("GLEditNCANNUM.Properties.NullValuePrompt")
        Me.GLEditNCANNUM.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("GLEditNCANNUM.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.GLEditNCANNUM.Properties.ValueMember = "NCANNUM"
        Me.GLEditNCANNUM.Properties.View = Me.GVNCANNUM
        '
        'GVNCANNUM
        '
        resources.ApplyResources(Me.GVNCANNUM, "GVNCANNUM")
        Me.GVNCANNUM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCANNUM, Me.GColVCANLIB})
        Me.GVNCANNUM.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GVNCANNUM.Name = "GVNCANNUM"
        Me.GVNCANNUM.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GVNCANNUM.OptionsView.ShowAutoFilterRow = True
        Me.GVNCANNUM.OptionsView.ShowGroupPanel = False
        '
        'GColNCANNUM
        '
        resources.ApplyResources(Me.GColNCANNUM, "GColNCANNUM")
        Me.GColNCANNUM.Name = "GColNCANNUM"
        '
        'GColVCANLIB
        '
        resources.ApplyResources(Me.GColVCANLIB, "GColVCANLIB")
        Me.GColVCANLIB.FieldName = "VCANLIB"
        Me.GColVCANLIB.Name = "GColVCANLIB"
        Me.GColVCANLIB.OptionsColumn.AllowEdit = False
        Me.GColVCANLIB.OptionsColumn.ReadOnly = True
        Me.GColVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'frmSaisieHChaff
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GLEditNCANNUM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.txtHRSaisie)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaisieHChaff"
        CType(Me.TxtNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHRSaisie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLEditNCANNUM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVNCANNUM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents TxtNom As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtHRSaisie As DevExpress.XtraEditors.TextEdit
    Private WithEvents GLEditNCANNUM As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVNCANNUM As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
End Class
