<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailCompetencePer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailCompetencePer))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLibelleCompetence = New System.Windows.Forms.TextBox()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GLUEditDomaineCompetence = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEditViewDomCompetence = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNIDDOM_COMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVLIBDOM_COMPET = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GLUEditDomaineCompetence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEditViewDomCompetence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtLibelleCompetence
        '
        resources.ApplyResources(Me.TxtLibelleCompetence, "TxtLibelleCompetence")
        Me.TxtLibelleCompetence.Name = "TxtLibelleCompetence"
        '
        'BtnEnregistrer
        '
        resources.ApplyResources(Me.BtnEnregistrer, "BtnEnregistrer")
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'GLUEditDomaineCompetence
        '
        resources.ApplyResources(Me.GLUEditDomaineCompetence, "GLUEditDomaineCompetence")
        Me.GLUEditDomaineCompetence.Name = "GLUEditDomaineCompetence"
        Me.GLUEditDomaineCompetence.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GLUEditDomaineCompetence.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.GLUEditDomaineCompetence.Properties.DisplayMember = "VLIBDOM_COMPET"
        Me.GLUEditDomaineCompetence.Properties.NullText = resources.GetString("GLUEditDomaineCompetence.Properties.NullText")
        Me.GLUEditDomaineCompetence.Properties.ValueMember = "NIDDOM_COMPET"
        Me.GLUEditDomaineCompetence.Properties.View = Me.GridLookUpEditViewDomCompetence
        '
        'GridLookUpEditViewDomCompetence
        '
        Me.GridLookUpEditViewDomCompetence.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNIDDOM_COMPET, Me.GColVLIBDOM_COMPET})
        Me.GridLookUpEditViewDomCompetence.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEditViewDomCompetence.Name = "GridLookUpEditViewDomCompetence"
        Me.GridLookUpEditViewDomCompetence.OptionsBehavior.Editable = False
        Me.GridLookUpEditViewDomCompetence.OptionsBehavior.ReadOnly = True
        Me.GridLookUpEditViewDomCompetence.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEditViewDomCompetence.OptionsView.ShowGroupPanel = False
        '
        'GColNIDDOM_COMPET
        '
        resources.ApplyResources(Me.GColNIDDOM_COMPET, "GColNIDDOM_COMPET")
        Me.GColNIDDOM_COMPET.FieldName = "NIDDOM_COMPET"
        Me.GColNIDDOM_COMPET.Name = "GColNIDDOM_COMPET"
        '
        'GColVLIBDOM_COMPET
        '
        resources.ApplyResources(Me.GColVLIBDOM_COMPET, "GColVLIBDOM_COMPET")
        Me.GColVLIBDOM_COMPET.FieldName = "VLIBDOM_COMPET"
        Me.GColVLIBDOM_COMPET.Name = "GColVLIBDOM_COMPET"
        '
        'frmDetailCompetencePer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GLUEditDomaineCompetence)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLibelleCompetence)
        Me.Name = "frmDetailCompetencePer"
        CType(Me.GLUEditDomaineCompetence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEditViewDomCompetence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtLibelleCompetence As System.Windows.Forms.TextBox
    Friend WithEvents BtnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GLUEditDomaineCompetence As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEditViewDomCompetence As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNIDDOM_COMPET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColVLIBDOM_COMPET As DevExpress.XtraGrid.Columns.GridColumn
End Class
