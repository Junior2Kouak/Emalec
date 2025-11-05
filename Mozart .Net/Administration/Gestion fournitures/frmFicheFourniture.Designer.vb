<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFicheFourniture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFicheFourniture))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GrpListe = New System.Windows.Forms.GroupBox()
        Me.GCFicheFou = New DevExpress.XtraGrid.GridControl()
        Me.GVFicheFou = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColIDTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUFICNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVFOUFICFILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNFOUFICDANGER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDDATECREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVQUICREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColFICTMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpApercu = New System.Windows.Forms.GroupBox()
        Me.WBApercu = New System.Windows.Forms.WebBrowser()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpListe.SuspendLayout()
        CType(Me.GCFicheFou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFicheFou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpApercu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnSupprimer)
        Me.GrpActions.Controls.Add(Me.BtnAjouter)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnSave)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnSupprimer, "BtnSupprimer")
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = False
        '
        'BtnAjouter
        '
        Me.BtnAjouter.BackColor = System.Drawing.Color.LightGreen
        resources.ApplyResources(Me.BtnAjouter, "BtnAjouter")
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.UseVisualStyleBackColor = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GrpListe
        '
        Me.GrpListe.Controls.Add(Me.GCFicheFou)
        resources.ApplyResources(Me.GrpListe, "GrpListe")
        Me.GrpListe.Name = "GrpListe"
        Me.GrpListe.TabStop = False
        '
        'GCFicheFou
        '
        resources.ApplyResources(Me.GCFicheFou, "GCFicheFou")
        Me.GCFicheFou.MainView = Me.GVFicheFou
        Me.GCFicheFou.Name = "GCFicheFou"
        Me.GCFicheFou.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFicheFou})
        '
        'GVFicheFou
        '
        Me.GVFicheFou.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColIDTMP, Me.GColNFOUFICNUM, Me.GColNFOUNUM, Me.GColVFOUFICFILE, Me.GColNFOUFICDANGER, Me.GColDDATECREE, Me.GColVQUICREE, Me.GColFICTMP})
        Me.GVFicheFou.GridControl = Me.GCFicheFou
        Me.GVFicheFou.Name = "GVFicheFou"
        Me.GVFicheFou.OptionsView.ShowGroupPanel = False
        '
        'GColIDTMP
        '
        resources.ApplyResources(Me.GColIDTMP, "GColIDTMP")
        Me.GColIDTMP.FieldName = "IDTMP"
        Me.GColIDTMP.Name = "GColIDTMP"
        '
        'GColNFOUFICNUM
        '
        resources.ApplyResources(Me.GColNFOUFICNUM, "GColNFOUFICNUM")
        Me.GColNFOUFICNUM.FieldName = "NFOUFICNUM"
        Me.GColNFOUFICNUM.Name = "GColNFOUFICNUM"
        '
        'GColNFOUNUM
        '
        resources.ApplyResources(Me.GColNFOUNUM, "GColNFOUNUM")
        Me.GColNFOUNUM.FieldName = "NFOUNUM"
        Me.GColNFOUNUM.Name = "GColNFOUNUM"
        '
        'GColVFOUFICFILE
        '
        Me.GColVFOUFICFILE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVFOUFICFILE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVFOUFICFILE, "GColVFOUFICFILE")
        Me.GColVFOUFICFILE.FieldName = "VFOUFICFILE"
        Me.GColVFOUFICFILE.Name = "GColVFOUFICFILE"
        Me.GColVFOUFICFILE.OptionsColumn.AllowEdit = False
        Me.GColVFOUFICFILE.OptionsColumn.ReadOnly = True
        '
        'GColNFOUFICDANGER
        '
        resources.ApplyResources(Me.GColNFOUFICDANGER, "GColNFOUFICDANGER")
        Me.GColNFOUFICDANGER.FieldName = "NFOUFICDANGER"
        Me.GColNFOUFICDANGER.Name = "GColNFOUFICDANGER"
        '
        'GColDDATECREE
        '
        Me.GColDDATECREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDDATECREE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColDDATECREE, "GColDDATECREE")
        Me.GColDDATECREE.FieldName = "DDATECREE"
        Me.GColDDATECREE.Name = "GColDDATECREE"
        Me.GColDDATECREE.OptionsColumn.AllowEdit = False
        Me.GColDDATECREE.OptionsColumn.ReadOnly = True
        '
        'GColVQUICREE
        '
        resources.ApplyResources(Me.GColVQUICREE, "GColVQUICREE")
        Me.GColVQUICREE.FieldName = "VQUICREE"
        Me.GColVQUICREE.Name = "GColVQUICREE"
        '
        'GColFICTMP
        '
        resources.ApplyResources(Me.GColFICTMP, "GColFICTMP")
        Me.GColFICTMP.FieldName = "FICTMP"
        Me.GColFICTMP.Name = "GColFICTMP"
        '
        'GrpApercu
        '
        Me.GrpApercu.Controls.Add(Me.WBApercu)
        resources.ApplyResources(Me.GrpApercu, "GrpApercu")
        Me.GrpApercu.Name = "GrpApercu"
        Me.GrpApercu.TabStop = False
        '
        'WBApercu
        '
        resources.ApplyResources(Me.WBApercu, "WBApercu")
        Me.WBApercu.Name = "WBApercu"
        '
        'frmFicheFourniture
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpApercu)
        Me.Controls.Add(Me.GrpListe)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmFicheFourniture"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpListe.ResumeLayout(False)
        CType(Me.GCFicheFou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFicheFou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpApercu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents GrpListe As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpApercu As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents WBApercu As System.Windows.Forms.WebBrowser
    Private WithEvents GCFicheFou As DevExpress.XtraGrid.GridControl
    Private WithEvents GVFicheFou As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNFOUFICNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVFOUFICFILE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNFOUFICDANGER As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDDATECREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVQUICREE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColIDTMP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColFICTMP As DevExpress.XtraGrid.Columns.GridColumn
End Class
