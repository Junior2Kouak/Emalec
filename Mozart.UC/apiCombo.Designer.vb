<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class apiCombo
  Inherits System.Windows.Forms.UserControl

  'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apiCombo))
    Me.lookup1 = New MozartUC.apiLookupEdit()
        CType(Me.lookup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lookup1
        '
        resources.ApplyResources(Me.lookup1, "lookup1")
        Me.lookup1.Name = "lookup1"
        Me.lookup1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[False]
        Me.lookup1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lookup1.Properties.Appearance.Font = CType(resources.GetObject("lookup1.Properties.Appearance.Font"), System.Drawing.Font)
        Me.lookup1.Properties.Appearance.Options.UseFont = True
        Me.lookup1.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lookup1.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.lookup1.Properties.AppearanceDropDownHeader.BackColor = System.Drawing.Color.LightBlue
        Me.lookup1.Properties.AppearanceDropDownHeader.Font = CType(resources.GetObject("lookup1.Properties.AppearanceDropDownHeader.Font"), System.Drawing.Font)
        Me.lookup1.Properties.AppearanceDropDownHeader.Options.UseBackColor = True
        Me.lookup1.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.lookup1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("lookup1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.lookup1.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F10)
        Me.lookup1.Properties.DropDownRows = 15
        Me.lookup1.Properties.NullValuePrompt = resources.GetString("lookup1.Properties.NullValuePrompt")
        Me.lookup1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lookup1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'apiCombo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lookup1)
        Me.Name = "apiCombo"
        CType(Me.lookup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    '  Friend WithEvents lookup1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lookup1 As apiLookupEdit

End Class
