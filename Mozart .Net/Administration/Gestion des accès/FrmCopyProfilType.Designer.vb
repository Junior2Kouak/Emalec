<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCopyProfilType
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GLU_DEST = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLU_V_DEST = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_DEST_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DEST_VTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DEST_VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_DEST_NSERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GLU_Src = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GLU_V_SRC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCol_SRC_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOl_SRC_VTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_VTYPEDETAILLIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCol_SRC_NSERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GLU_DEST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_V_DEST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_Src.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GLU_V_SRC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GLU_DEST)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GLU_Src)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(93, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 294)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Copier un profil"
        '
        'GLU_DEST
        '
        Me.GLU_DEST.EditValue = ""
        Me.GLU_DEST.Location = New System.Drawing.Point(55, 191)
        Me.GLU_DEST.Name = "GLU_DEST"
        Me.GLU_DEST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_DEST.Properties.DisplayMember = "VTYPEDETAILLIB"
        Me.GLU_DEST.Properties.NullText = ""
        Me.GLU_DEST.Properties.ValueMember = "ID"
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
        Me.GLU_V_DEST.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_DEST_ID, Me.GCol_DEST_VTYPELIB, Me.GCol_DEST_VTYPEDETAILLIB, Me.GCol_DEST_NSERNUM})
        Me.GLU_V_DEST.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLU_V_DEST.Name = "GLU_V_DEST"
        Me.GLU_V_DEST.OptionsBehavior.ReadOnly = True
        Me.GLU_V_DEST.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLU_V_DEST.OptionsView.ShowAutoFilterRow = True
        Me.GLU_V_DEST.OptionsView.ShowGroupPanel = False
        '
        'GCol_DEST_ID
        '
        Me.GCol_DEST_ID.Caption = "ID"
        Me.GCol_DEST_ID.FieldName = "ID"
        Me.GCol_DEST_ID.Name = "GCol_DEST_ID"
        '
        'GCol_DEST_VTYPELIB
        '
        Me.GCol_DEST_VTYPELIB.Caption = "Type"
        Me.GCol_DEST_VTYPELIB.FieldName = "VTYPELIB"
        Me.GCol_DEST_VTYPELIB.Name = "GCol_DEST_VTYPELIB"
        Me.GCol_DEST_VTYPELIB.Visible = True
        Me.GCol_DEST_VTYPELIB.VisibleIndex = 0
        Me.GCol_DEST_VTYPELIB.Width = 140
        '
        'GCol_DEST_VTYPEDETAILLIB
        '
        Me.GCol_DEST_VTYPEDETAILLIB.Caption = "Poste"
        Me.GCol_DEST_VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
        Me.GCol_DEST_VTYPEDETAILLIB.Name = "GCol_DEST_VTYPEDETAILLIB"
        Me.GCol_DEST_VTYPEDETAILLIB.OptionsColumn.AllowEdit = False
        Me.GCol_DEST_VTYPEDETAILLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DEST_VTYPEDETAILLIB.Visible = True
        Me.GCol_DEST_VTYPEDETAILLIB.VisibleIndex = 1
        Me.GCol_DEST_VTYPEDETAILLIB.Width = 250
        '
        'GCol_DEST_NSERNUM
        '
        Me.GCol_DEST_NSERNUM.Caption = "NSERNUM"
        Me.GCol_DEST_NSERNUM.FieldName = "NSERNUM"
        Me.GCol_DEST_NSERNUM.Name = "GCol_DEST_NSERNUM"
        Me.GCol_DEST_NSERNUM.OptionsColumn.AllowEdit = False
        Me.GCol_DEST_NSERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_DEST_NSERNUM.Width = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Vers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "De "
        '
        'GLU_Src
        '
        Me.GLU_Src.EditValue = ""
        Me.GLU_Src.Location = New System.Drawing.Point(55, 110)
        Me.GLU_Src.Name = "GLU_Src"
        Me.GLU_Src.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GLU_Src.Properties.DisplayMember = "VTYPEDETAILLIB"
        Me.GLU_Src.Properties.NullText = ""
        Me.GLU_Src.Properties.ValueMember = "ID"
        Me.GLU_Src.Properties.View = Me.GLU_V_SRC
        Me.GLU_Src.Size = New System.Drawing.Size(290, 20)
        Me.GLU_Src.TabIndex = 5
        '
        'GLU_V_SRC
        '
        Me.GLU_V_SRC.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GLU_V_SRC.Appearance.HeaderPanel.Options.UseFont = True
        Me.GLU_V_SRC.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GLU_V_SRC.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GLU_V_SRC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCol_SRC_ID, Me.GCOl_SRC_VTYPELIB, Me.GCol_SRC_VTYPEDETAILLIB, Me.GCol_SRC_NSERNUM})
        Me.GLU_V_SRC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GLU_V_SRC.Name = "GLU_V_SRC"
        Me.GLU_V_SRC.OptionsBehavior.ReadOnly = True
        Me.GLU_V_SRC.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GLU_V_SRC.OptionsView.ShowAutoFilterRow = True
        Me.GLU_V_SRC.OptionsView.ShowGroupPanel = False
        '
        'GCol_SRC_ID
        '
        Me.GCol_SRC_ID.Caption = "ID"
        Me.GCol_SRC_ID.FieldName = "ID"
        Me.GCol_SRC_ID.Name = "GCol_SRC_ID"
        '
        'GCOl_SRC_VTYPELIB
        '
        Me.GCOl_SRC_VTYPELIB.Caption = "Type"
        Me.GCOl_SRC_VTYPELIB.FieldName = "VTYPELIB"
        Me.GCOl_SRC_VTYPELIB.Name = "GCOl_SRC_VTYPELIB"
        Me.GCOl_SRC_VTYPELIB.Visible = True
        Me.GCOl_SRC_VTYPELIB.VisibleIndex = 0
        Me.GCOl_SRC_VTYPELIB.Width = 140
        '
        'GCol_SRC_VTYPEDETAILLIB
        '
        Me.GCol_SRC_VTYPEDETAILLIB.Caption = "Poste"
        Me.GCol_SRC_VTYPEDETAILLIB.FieldName = "VTYPEDETAILLIB"
        Me.GCol_SRC_VTYPEDETAILLIB.Name = "GCol_SRC_VTYPEDETAILLIB"
        Me.GCol_SRC_VTYPEDETAILLIB.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_VTYPEDETAILLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_VTYPEDETAILLIB.Visible = True
        Me.GCol_SRC_VTYPEDETAILLIB.VisibleIndex = 0
        Me.GCol_SRC_VTYPEDETAILLIB.Width = 250
        '
        'GCol_SRC_NSERNUM
        '
        Me.GCol_SRC_NSERNUM.Caption = "NSERNUM"
        Me.GCol_SRC_NSERNUM.FieldName = "NSERNUM"
        Me.GCol_SRC_NSERNUM.Name = "GCol_SRC_NSERNUM"
        Me.GCol_SRC_NSERNUM.OptionsColumn.AllowEdit = False
        Me.GCol_SRC_NSERNUM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GCol_SRC_NSERNUM.Width = 134
        '
        'BtnValider
        '
        Me.BtnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValider.Location = New System.Drawing.Point(12, 22)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(75, 56)
        Me.BtnValider.TabIndex = 6
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFermer.Location = New System.Drawing.Point(12, 250)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 56)
        Me.BtnFermer.TabIndex = 7
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'FrmCopyProfilType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(501, 323)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCopyProfilType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copier un profil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GLU_DEST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_V_DEST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_Src.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GLU_V_SRC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GLU_Src As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLU_V_SRC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GCol_SRC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCOl_SRC_VTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_SRC_NSERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GLU_DEST As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GLU_V_DEST As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCol_DEST_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DEST_VTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DEST_VTYPEDETAILLIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCol_DEST_NSERNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
