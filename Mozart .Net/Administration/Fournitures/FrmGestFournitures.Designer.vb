<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestFournitures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestFournitures))
        Me.BtnConsultFoMag = New System.Windows.Forms.Button()
        Me.GCFournitures = New DevExpress.XtraGrid.GridControl()
        Me.GVFournitures = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GCFournitures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFournitures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConsultFoMag
        '
        resources.ApplyResources(Me.BtnConsultFoMag, "BtnConsultFoMag")
        Me.BtnConsultFoMag.Name = "BtnConsultFoMag"
        Me.BtnConsultFoMag.UseVisualStyleBackColor = True
        '
        'GCFournitures
        '
        resources.ApplyResources(Me.GCFournitures, "GCFournitures")
        '
        '
        '
        Me.GCFournitures.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCFournitures.EmbeddedNavigator.AccessibleDescription")
        Me.GCFournitures.EmbeddedNavigator.AccessibleName = resources.GetString("GCFournitures.EmbeddedNavigator.AccessibleName")
        Me.GCFournitures.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCFournitures.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCFournitures.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCFournitures.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCFournitures.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCFournitures.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCFournitures.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCFournitures.EmbeddedNavigator.ToolTip = resources.GetString("GCFournitures.EmbeddedNavigator.ToolTip")
        Me.GCFournitures.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCFournitures.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCFournitures.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCFournitures.EmbeddedNavigator.ToolTipTitle")
        Me.GCFournitures.MainView = Me.GVFournitures
        Me.GCFournitures.Name = "GCFournitures"
        Me.GCFournitures.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFournitures})
        '
        'GVFournitures
        '
        resources.ApplyResources(Me.GVFournitures, "GVFournitures")
        Me.GVFournitures.GridControl = Me.GCFournitures
        Me.GVFournitures.Name = "GVFournitures"
        '
        'FrmGestFournitures
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GCFournitures)
        Me.Controls.Add(Me.BtnConsultFoMag)
        Me.Name = "FrmGestFournitures"
        CType(Me.GCFournitures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFournitures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConsultFoMag As System.Windows.Forms.Button
    Private WithEvents GCFournitures As DevExpress.XtraGrid.GridControl
    Private WithEvents GVFournitures As DevExpress.XtraGrid.Views.Grid.GridView
End Class
