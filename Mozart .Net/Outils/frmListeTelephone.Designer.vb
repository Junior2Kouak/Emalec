<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeTelephone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeTelephone))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GCLISTETEL = New DevExpress.XtraGrid.GridControl()
        Me.GVLISTETEL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PRENOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ABREGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        CType(Me.GCLISTETEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLISTETEL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCLISTETEL
        '
        resources.ApplyResources(Me.GCLISTETEL, "GCLISTETEL")
        Me.GCLISTETEL.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCLISTETEL.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCLISTETEL.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCLISTETEL.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCLISTETEL.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCLISTETEL.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCLISTETEL.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCLISTETEL.MainView = Me.GVLISTETEL
        Me.GCLISTETEL.Name = "GCLISTETEL"
        Me.GCLISTETEL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLISTETEL})
        '
        'GVLISTETEL
        '
        Me.GVLISTETEL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NOM, Me.PRENOM, Me.TYPE, Me.ABREGE, Me.TEL})
        Me.GVLISTETEL.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GVLISTETEL.GridControl = Me.GCLISTETEL
        Me.GVLISTETEL.Name = "GVLISTETEL"
        Me.GVLISTETEL.OptionsBehavior.Editable = False
        Me.GVLISTETEL.OptionsCustomization.AllowColumnMoving = False
        Me.GVLISTETEL.OptionsCustomization.AllowGroup = False
        Me.GVLISTETEL.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVLISTETEL.OptionsView.ShowAutoFilterRow = True
        Me.GVLISTETEL.OptionsView.ShowGroupPanel = False
        '
        'NOM
        '
        Me.NOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.NOM.AppearanceHeader.Options.UseForeColor = True
        Me.NOM.AppearanceHeader.Options.UseTextOptions = True
        Me.NOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.NOM, "NOM")
        Me.NOM.FieldName = "VPERNOM"
        Me.NOM.Name = "NOM"
        '
        'PRENOM
        '
        Me.PRENOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.PRENOM.AppearanceHeader.Options.UseForeColor = True
        Me.PRENOM.AppearanceHeader.Options.UseTextOptions = True
        Me.PRENOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PRENOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.PRENOM, "PRENOM")
        Me.PRENOM.FieldName = "VPERPRE"
        Me.PRENOM.Name = "PRENOM"
        '
        'TYPE
        '
        Me.TYPE.AppearanceCell.Options.UseTextOptions = True
        Me.TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TYPE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TYPE.AppearanceHeader.Options.UseForeColor = True
        Me.TYPE.AppearanceHeader.Options.UseTextOptions = True
        Me.TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.TYPE, "TYPE")
        Me.TYPE.FieldName = "CPERTYP"
        Me.TYPE.Name = "TYPE"
        '
        'ABREGE
        '
        Me.ABREGE.AppearanceCell.Options.UseTextOptions = True
        Me.ABREGE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABREGE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ABREGE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.ABREGE.AppearanceHeader.Options.UseForeColor = True
        Me.ABREGE.AppearanceHeader.Options.UseTextOptions = True
        Me.ABREGE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ABREGE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.ABREGE, "ABREGE")
        Me.ABREGE.FieldName = "VTELCODE"
        Me.ABREGE.Name = "ABREGE"
        '
        'TEL
        '
        Me.TEL.AppearanceCell.Options.UseTextOptions = True
        Me.TEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TEL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.TEL.AppearanceHeader.Options.UseForeColor = True
        Me.TEL.AppearanceHeader.Options.UseTextOptions = True
        Me.TEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.TEL, "TEL")
        Me.TEL.FieldName = "VTELNUM"
        Me.TEL.Name = "TEL"
        '
        'LabelTitre
        '
        resources.ApplyResources(Me.LabelTitre, "LabelTitre")
        Me.LabelTitre.Name = "LabelTitre"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'frmListeTelephone
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CausesValidation = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GCLISTETEL)
        Me.Name = "frmListeTelephone"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCLISTETEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLISTETEL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents GCLISTETEL As DevExpress.XtraGrid.GridControl
    Private WithEvents GVLISTETEL As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents PRENOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ABREGE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents TEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
End Class
