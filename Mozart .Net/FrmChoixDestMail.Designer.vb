<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChoixDestMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChoixDestMail))
        Me.GrpDestinataires = New System.Windows.Forms.GroupBox()
        Me.TxtAdrMailSupp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GCDest = New DevExpress.XtraGrid.GridControl()
        Me.GVDest = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_NCOCHE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditNCOCHE = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Col_VCCLNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VCCLPRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VCCLMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VCCLFONC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDecocheAll = New System.Windows.Forms.Button()
        Me.BtnCocheAll = New System.Windows.Forms.Button()
        Me.GrpMail = New System.Windows.Forms.GroupBox()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSujet = New System.Windows.Forms.TextBox()
        Me.btnEnvoi = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpDestinataires.SuspendLayout()
        CType(Me.GCDest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditNCOCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMail.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpDestinataires
        '
        Me.GrpDestinataires.Controls.Add(Me.TxtAdrMailSupp)
        Me.GrpDestinataires.Controls.Add(Me.Label3)
        Me.GrpDestinataires.Controls.Add(Me.GCDest)
        Me.GrpDestinataires.Controls.Add(Me.BtnDecocheAll)
        Me.GrpDestinataires.Controls.Add(Me.BtnCocheAll)
        resources.ApplyResources(Me.GrpDestinataires, "GrpDestinataires")
        Me.GrpDestinataires.ForeColor = System.Drawing.Color.Red
        Me.GrpDestinataires.Name = "GrpDestinataires"
        Me.GrpDestinataires.TabStop = False
        '
        'TxtAdrMailSupp
        '
        resources.ApplyResources(Me.TxtAdrMailSupp, "TxtAdrMailSupp")
        Me.TxtAdrMailSupp.Name = "TxtAdrMailSupp"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'GCDest
        '
        resources.ApplyResources(Me.GCDest, "GCDest")
        Me.GCDest.MainView = Me.GVDest
        Me.GCDest.Name = "GCDest"
        Me.GCDest.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditNCOCHE})
        Me.GCDest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDest})
        '
        'GVDest
        '
        Me.GVDest.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDest.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDest.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDest.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDest.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_NCOCHE, Me.Col_VCCLNOM, Me.Col_VCCLPRE, Me.Col_VCCLMAIL, Me.Col_VCCLFONC})
        Me.GVDest.GridControl = Me.GCDest
        Me.GVDest.Name = "GVDest"
        Me.GVDest.OptionsView.ShowGroupPanel = False
        '
        'Col_NCOCHE
        '
        Me.Col_NCOCHE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_NCOCHE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_NCOCHE, "Col_NCOCHE")
        Me.Col_NCOCHE.ColumnEdit = Me.RepositoryItemCheckEditNCOCHE
        Me.Col_NCOCHE.FieldName = "NCOCHE"
        Me.Col_NCOCHE.Name = "Col_NCOCHE"
        '
        'RepositoryItemCheckEditNCOCHE
        '
        resources.ApplyResources(Me.RepositoryItemCheckEditNCOCHE, "RepositoryItemCheckEditNCOCHE")
        Me.RepositoryItemCheckEditNCOCHE.Name = "RepositoryItemCheckEditNCOCHE"
        Me.RepositoryItemCheckEditNCOCHE.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepositoryItemCheckEditNCOCHE.ValueChecked = 1
        Me.RepositoryItemCheckEditNCOCHE.ValueUnchecked = 0
        '
        'Col_VCCLNOM
        '
        Me.Col_VCCLNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VCCLNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VCCLNOM, "Col_VCCLNOM")
        Me.Col_VCCLNOM.FieldName = "VCCLNOM"
        Me.Col_VCCLNOM.Name = "Col_VCCLNOM"
        Me.Col_VCCLNOM.OptionsColumn.AllowEdit = False
        Me.Col_VCCLNOM.OptionsColumn.ReadOnly = True
        '
        'Col_VCCLPRE
        '
        Me.Col_VCCLPRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VCCLPRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VCCLPRE, "Col_VCCLPRE")
        Me.Col_VCCLPRE.FieldName = "VCCLPRE"
        Me.Col_VCCLPRE.Name = "Col_VCCLPRE"
        Me.Col_VCCLPRE.OptionsColumn.AllowEdit = False
        Me.Col_VCCLPRE.OptionsColumn.ReadOnly = True
        '
        'Col_VCCLMAIL
        '
        Me.Col_VCCLMAIL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VCCLMAIL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VCCLMAIL, "Col_VCCLMAIL")
        Me.Col_VCCLMAIL.FieldName = "VCCLMAIL"
        Me.Col_VCCLMAIL.Name = "Col_VCCLMAIL"
        Me.Col_VCCLMAIL.OptionsColumn.AllowEdit = False
        Me.Col_VCCLMAIL.OptionsColumn.ReadOnly = True
        '
        'Col_VCCLFONC
        '
        Me.Col_VCCLFONC.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VCCLFONC.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VCCLFONC, "Col_VCCLFONC")
        Me.Col_VCCLFONC.FieldName = "VCCLFONC"
        Me.Col_VCCLFONC.Name = "Col_VCCLFONC"
        Me.Col_VCCLFONC.OptionsColumn.AllowEdit = False
        Me.Col_VCCLFONC.OptionsColumn.ReadOnly = True
        '
        'BtnDecocheAll
        '
        Me.BtnDecocheAll.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.BtnDecocheAll, "BtnDecocheAll")
        Me.BtnDecocheAll.Name = "BtnDecocheAll"
        Me.BtnDecocheAll.UseVisualStyleBackColor = True
        '
        'BtnCocheAll
        '
        Me.BtnCocheAll.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.BtnCocheAll, "BtnCocheAll")
        Me.BtnCocheAll.Name = "BtnCocheAll"
        Me.BtnCocheAll.UseVisualStyleBackColor = True
        '
        'GrpMail
        '
        Me.GrpMail.Controls.Add(Me.TxtMessage)
        Me.GrpMail.Controls.Add(Me.Label2)
        Me.GrpMail.Controls.Add(Me.Label1)
        Me.GrpMail.Controls.Add(Me.TxtSujet)
        resources.ApplyResources(Me.GrpMail, "GrpMail")
        Me.GrpMail.ForeColor = System.Drawing.Color.Red
        Me.GrpMail.Name = "GrpMail"
        Me.GrpMail.TabStop = False
        '
        'TxtMessage
        '
        resources.ApplyResources(Me.TxtMessage, "TxtMessage")
        Me.TxtMessage.Name = "TxtMessage"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtSujet
        '
        resources.ApplyResources(Me.TxtSujet, "TxtSujet")
        Me.TxtSujet.Name = "TxtSujet"
        '
        'btnEnvoi
        '
        resources.ApplyResources(Me.btnEnvoi, "btnEnvoi")
        Me.btnEnvoi.Name = "btnEnvoi"
        Me.btnEnvoi.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        resources.ApplyResources(Me.BtnCancel, "BtnCancel")
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmChoixDestMail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnEnvoi)
        Me.Controls.Add(Me.GrpMail)
        Me.Controls.Add(Me.GrpDestinataires)
        Me.Name = "FrmChoixDestMail"
        Me.GrpDestinataires.ResumeLayout(False)
        Me.GrpDestinataires.PerformLayout()
        CType(Me.GCDest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditNCOCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMail.ResumeLayout(False)
        Me.GrpMail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpDestinataires As System.Windows.Forms.GroupBox
    Friend WithEvents GrpMail As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDecocheAll As System.Windows.Forms.Button
    Friend WithEvents BtnCocheAll As System.Windows.Forms.Button
    Friend WithEvents btnEnvoi As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtSujet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAdrMailSupp As System.Windows.Forms.TextBox
    Friend WithEvents TxtMessage As TextBox
    Private WithEvents GCDest As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDest As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents Col_NCOCHE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents Col_VCCLNOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VCCLPRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VCCLMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VCCLFONC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditNCOCHE As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
