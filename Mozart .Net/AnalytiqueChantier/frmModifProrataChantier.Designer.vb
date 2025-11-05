<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifProrataChantier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifProrataChantier))
        Me.SpinPRPRORATA = New DevExpress.XtraEditors.SpinEdit()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.SpinPRPRORATA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpinPRPRORATA
        '
        resources.ApplyResources(Me.SpinPRPRORATA, "SpinPRPRORATA")
        Me.SpinPRPRORATA.Name = "SpinPRPRORATA"
        '
        '
        '
        Me.SpinPRPRORATA.Properties.AccessibleDescription = resources.GetString("SpinPRPRORATA.Properties.AccessibleDescription")
        Me.SpinPRPRORATA.Properties.AccessibleName = resources.GetString("SpinPRPRORATA.Properties.AccessibleName")
        Me.SpinPRPRORATA.Properties.AllowFocused = False
        Me.SpinPRPRORATA.Properties.AutoHeight = CType(resources.GetObject("SpinPRPRORATA.Properties.AutoHeight"), Boolean)
        Me.SpinPRPRORATA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinPRPRORATA.Properties.DisplayFormat.FormatString = "p1"
        Me.SpinPRPRORATA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinPRPRORATA.Properties.EditFormat.FormatString = "p1"
        Me.SpinPRPRORATA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinPRPRORATA.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.SpinPRPRORATA.Properties.Mask.AutoComplete = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
        Me.SpinPRPRORATA.Properties.Mask.BeepOnError = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.BeepOnError"), Boolean)
        Me.SpinPRPRORATA.Properties.Mask.EditMask = resources.GetString("SpinPRPRORATA.Properties.Mask.EditMask")
        Me.SpinPRPRORATA.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.IgnoreMaskBlank"), Boolean)
        Me.SpinPRPRORATA.Properties.Mask.MaskType = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
        Me.SpinPRPRORATA.Properties.Mask.PlaceHolder = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.PlaceHolder"), Char)
        Me.SpinPRPRORATA.Properties.Mask.SaveLiteral = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.SaveLiteral"), Boolean)
        Me.SpinPRPRORATA.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.ShowPlaceHolders"), Boolean)
        Me.SpinPRPRORATA.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("SpinPRPRORATA.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
        Me.SpinPRPRORATA.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.SpinPRPRORATA.Properties.NullValuePrompt = resources.GetString("SpinPRPRORATA.Properties.NullValuePrompt")
        Me.SpinPRPRORATA.Properties.NullValuePromptShowForEmptyValue = CType(resources.GetObject("SpinPRPRORATA.Properties.NullValuePromptShowForEmptyValue"), Boolean)
        Me.SpinPRPRORATA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'BtnOK
        '
        resources.ApplyResources(Me.BtnOK, "BtnOK")
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'frmModifProrataChantier
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SpinPRPRORATA)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "frmModifProrataChantier"
        CType(Me.SpinPRPRORATA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Private WithEvents SpinPRPRORATA As DevExpress.XtraEditors.SpinEdit
End Class
