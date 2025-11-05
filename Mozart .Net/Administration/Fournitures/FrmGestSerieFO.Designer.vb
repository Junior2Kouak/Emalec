<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestSerieFO
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonRestaurer = New System.Windows.Forms.Button()
        Me.ButtonLstArchives = New System.Windows.Forms.Button()
        Me.ButtonArchiver = New System.Windows.Forms.Button()
        Me.ButtonDetails = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.GCListeSerieFO = New DevExpress.XtraGrid.GridControl()
        Me.GVListeSerieFO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNCFOCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCCFOCOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColLANGUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GCListeSerieFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeSerieFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitre.Location = New System.Drawing.Point(109, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(361, 29)
        Me.LabelTitre.TabIndex = 47
        Me.LabelTitre.Text = "Liste des séries de fournitures"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonRestaurer)
        Me.GroupBox1.Controls.Add(Me.ButtonLstArchives)
        Me.GroupBox1.Controls.Add(Me.ButtonArchiver)
        Me.GroupBox1.Controls.Add(Me.ButtonDetails)
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 824)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'ButtonRestaurer
        '
        Me.ButtonRestaurer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonRestaurer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRestaurer.Location = New System.Drawing.Point(5, 306)
        Me.ButtonRestaurer.Name = "ButtonRestaurer"
        Me.ButtonRestaurer.Size = New System.Drawing.Size(75, 48)
        Me.ButtonRestaurer.TabIndex = 40
        Me.ButtonRestaurer.Text = "Restaurer"
        Me.ButtonRestaurer.UseVisualStyleBackColor = True
        Me.ButtonRestaurer.Visible = False
        '
        'ButtonLstArchives
        '
        Me.ButtonLstArchives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonLstArchives.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLstArchives.Location = New System.Drawing.Point(5, 236)
        Me.ButtonLstArchives.Name = "ButtonLstArchives"
        Me.ButtonLstArchives.Size = New System.Drawing.Size(75, 48)
        Me.ButtonLstArchives.TabIndex = 39
        Me.ButtonLstArchives.Text = "Liste archives"
        Me.ButtonLstArchives.UseVisualStyleBackColor = True
        '
        'ButtonArchiver
        '
        Me.ButtonArchiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonArchiver.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonArchiver.Location = New System.Drawing.Point(5, 166)
        Me.ButtonArchiver.Name = "ButtonArchiver"
        Me.ButtonArchiver.Size = New System.Drawing.Size(75, 48)
        Me.ButtonArchiver.TabIndex = 38
        Me.ButtonArchiver.Text = "Archiver"
        Me.ButtonArchiver.UseVisualStyleBackColor = True
        '
        'ButtonDetails
        '
        Me.ButtonDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDetails.Location = New System.Drawing.Point(5, 93)
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.Size = New System.Drawing.Size(75, 48)
        Me.ButtonDetails.TabIndex = 37
        Me.ButtonDetails.Text = "Détails"
        Me.ButtonDetails.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        Me.BtnFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnFermer.Location = New System.Drawing.Point(5, 761)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(75, 48)
        Me.BtnFermer.TabIndex = 1
        Me.BtnFermer.Text = "Fermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnAjouter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnAjouter.Location = New System.Drawing.Point(5, 23)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(74, 48)
        Me.BtnAjouter.TabIndex = 0
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'GCListeSerieFO
        '
        Me.GCListeSerieFO.Location = New System.Drawing.Point(114, 63)
        Me.GCListeSerieFO.MainView = Me.GVListeSerieFO
        Me.GCListeSerieFO.Name = "GCListeSerieFO"
        Me.GCListeSerieFO.Size = New System.Drawing.Size(1076, 810)
        Me.GCListeSerieFO.TabIndex = 48
        Me.GCListeSerieFO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeSerieFO})
        '
        'GVListeSerieFO
        '
        Me.GVListeSerieFO.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GVListeSerieFO.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeSerieFO.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeSerieFO.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeSerieFO.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeSerieFO.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVListeSerieFO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNCFOCOD, Me.GColCCFOCOD, Me.GColLANGUE})
        Me.GVListeSerieFO.GridControl = Me.GCListeSerieFO
        Me.GVListeSerieFO.Name = "GVListeSerieFO"
        Me.GVListeSerieFO.OptionsView.ShowAutoFilterRow = True
        Me.GVListeSerieFO.OptionsView.ShowGroupPanel = False
        '
        'GColNCFOCOD
        '
        Me.GColNCFOCOD.Name = "GColNCFOCOD"
        '
        'GColCCFOCOD
        '
        Me.GColCCFOCOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCCFOCOD.AppearanceHeader.Options.UseForeColor = True
        Me.GColCCFOCOD.Caption = "Série"
        Me.GColCCFOCOD.FieldName = "CCFOCOD"
        Me.GColCCFOCOD.Name = "GColCCFOCOD"
        Me.GColCCFOCOD.OptionsColumn.AllowEdit = False
        Me.GColCCFOCOD.OptionsColumn.ReadOnly = True
        Me.GColCCFOCOD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GColCCFOCOD.Visible = True
        Me.GColCCFOCOD.VisibleIndex = 0
        '
        'GColLANGUE
        '
        Me.GColLANGUE.FieldName = "LANGUE"
        Me.GColLANGUE.Name = "GColLANGUE"
        '
        'FrmGestSerieFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1510, 943)
        Me.Controls.Add(Me.GCListeSerieFO)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmGestSerieFO"
        Me.Text = "Gestion des séries de fournitures"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GCListeSerieFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeSerieFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonRestaurer As Button
    Friend WithEvents ButtonLstArchives As Button
    Friend WithEvents ButtonArchiver As Button
    Friend WithEvents ButtonDetails As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents GCListeSerieFO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVListeSerieFO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GColNCFOCOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColCCFOCOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GColLANGUE As DevExpress.XtraGrid.Columns.GridColumn
End Class
