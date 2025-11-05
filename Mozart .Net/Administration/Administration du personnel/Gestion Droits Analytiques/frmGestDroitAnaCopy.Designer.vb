<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestDroitAnaCopy
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
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GLU_DEST = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLU_V_DEST = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_DEST_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DEST_NOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_NOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_NPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLU_V_SRC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GLU_Src = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.GLU_DEST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_V_DEST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_V_SRC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_Src.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFermer.Location = New System.Drawing.Point(14, 250)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 56)
        Me.BtnFermer.TabIndex = 10
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'GLU_DEST
        '
        Me.GLU_DEST.EditValue = ""
        Me.GLU_DEST.Location = New System.Drawing.Point(55, 206)
        Me.GLU_DEST.Name = "GLU_DEST"
        Me.GLU_DEST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_DEST.Properties.DisplayMember = "NOM"
        Me.GLU_DEST.Properties.NullText = ""
        Me.GLU_DEST.Properties.ValueMember = "NPERNUM"
        Me.GLU_DEST.Properties.View = Me.GLU_V_DEST
        Me.GLU_DEST.Size = New System.Drawing.Size(290, 20)
        Me.GLU_DEST.TabIndex = 9
        '
        'GLU_V_DEST
        '
        Me.GLU_V_DEST.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GLU_V_DEST.Appearance.HeaderPanel.Options.UseFont = True
        Me.GLU_V_DEST.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GLU_V_DEST.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GLU_V_DEST.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GLU_V_DEST.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GLU_V_DEST.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_DEST_NPERNUM, Me.GCol_DEST_NOM})
        Me.GLU_V_DEST.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLU_V_DEST.Name = "GLU_V_DEST"
        Me.GLU_V_DEST.OptionsBehavior.ReadOnly = True
        Me.GLU_V_DEST.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLU_V_DEST.OptionsView.ShowAutoFilterRow = True
        Me.GLU_V_DEST.OptionsView.ShowGroupPanel = False
        '
        'GCol_DEST_NPERNUM
        '
        Me.GCol_DEST_NPERNUM.Caption = "NPERNUM"
        Me.GCol_DEST_NPERNUM.FieldName = "NPERNUM"
        Me.GCol_DEST_NPERNUM.Name = "GCol_DEST_NPERNUM"
        '
        'GCol_DEST_NOM
        '
        Me.GCol_DEST_NOM.Caption = "NOM"
        Me.GCol_DEST_NOM.FieldName = "NOM"
        Me.GCol_DEST_NOM.Name = "GCol_DEST_NOM"
        Me.GCol_DEST_NOM.OptionsColumn.AllowEdit = False
        Me.GCol_DEST_NOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DEST_NOM.Visible = True
        Me.GCol_DEST_NOM.VisibleIndex = 0
        Me.GCol_DEST_NOM.Width = 250
        '
        'GCol_SRC_NOM
        '
        Me.GCol_SRC_NOM.Caption = "NOM"
        Me.GCol_SRC_NOM.FieldName = "NOM"
        Me.GCol_SRC_NOM.Name = "GCol_SRC_NOM"
        Me.GCol_SRC_NOM.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_NOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_NOM.Visible = True
        Me.GCol_SRC_NOM.VisibleIndex = 0
        Me.GCol_SRC_NOM.Width = 250
        '
        'GCol_SRC_NPERNUM
        '
        Me.GCol_SRC_NPERNUM.Caption = "NPERNUM"
        Me.GCol_SRC_NPERNUM.FieldName = "NPERNUM"
        Me.GCol_SRC_NPERNUM.Name = "GCol_SRC_NPERNUM"
        '
        'GLU_V_SRC
        '
        Me.GLU_V_SRC.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GLU_V_SRC.Appearance.HeaderPanel.Options.UseFont = True
        Me.GLU_V_SRC.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GLU_V_SRC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_SRC_NPERNUM, Me.GCol_SRC_NOM})
        Me.GLU_V_SRC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLU_V_SRC.Name = "GLU_V_SRC"
        Me.GLU_V_SRC.OptionsBehavior.ReadOnly = True
        Me.GLU_V_SRC.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLU_V_SRC.OptionsView.ShowAutoFilterRow = True
        Me.GLU_V_SRC.OptionsView.ShowGroupPanel = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "De "
        '
        'GLU_Src
        '
        Me.GLU_Src.EditValue = ""
        Me.GLU_Src.Location = New System.Drawing.Point(55, 76)
        Me.GLU_Src.Name = "GLU_Src"
        Me.GLU_Src.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_Src.Properties.DisplayMember = "NOM"
        Me.GLU_Src.Properties.NullText = ""
        Me.GLU_Src.Properties.ValueMember = "NPERNUM"
        Me.GLU_Src.Properties.View = Me.GLU_V_SRC
        Me.GLU_Src.Size = New System.Drawing.Size(290, 20)
        Me.GLU_Src.TabIndex = 5
        '
        'BtnValider
        '
        Me.BtnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(14, 22)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(75, 56)
        Me.BtnValider.TabIndex = 9
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GLU_DEST)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GLU_Src)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(95, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 294)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Copier un profil"
        '
        'frmGestDroitAnaCopy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(501, 317)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGestDroitAnaCopy"
        Me.Text = "Copie des droits analytiques"
        CType(Me.GLU_DEST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_V_DEST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_V_SRC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_Src.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnFermer As Button
    Friend WithEvents GLU_DEST As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLU_V_DEST As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_DEST_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DEST_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_NOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_NPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GLU_V_SRC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GLU_Src As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BtnValider As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
