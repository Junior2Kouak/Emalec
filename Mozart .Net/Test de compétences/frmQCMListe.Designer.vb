<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQCMListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQCMListe))
        Me.BtnCreerTest = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnArchiver = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.ChkListArchives = New System.Windows.Forms.CheckBox()
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.BtnResultatsByQCM = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnResultatsByQCMCandidat = New System.Windows.Forms.Button()
        Me.GCListeQCM = New DevExpress.XtraGrid.GridControl()
        Me.GVListeQCM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Col_NIDQCMNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_NQCMTYPEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VQCMTYPELIB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VQCMTITRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_DQCMCREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_BQCMRECRU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Col_BQCMACTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_VQCMCONSIGNE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Col_BQCMCORRECTAUTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnDupliqQCM = New System.Windows.Forms.Button()
        Me.BtnAnalyse = New System.Windows.Forms.Button()
        Me.BtnAffectPers = New System.Windows.Forms.Button()
        Me.BtnCopyToFiliale = New System.Windows.Forms.Button()
        Me.BtnResultSTF = New System.Windows.Forms.Button()
        CType(Me.GCListeQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVListeQCM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCreerTest
        '
        resources.ApplyResources(Me.BtnCreerTest, "BtnCreerTest")
        Me.BtnCreerTest.Name = "BtnCreerTest"
        Me.BtnCreerTest.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        resources.ApplyResources(Me.BtnModifier, "BtnModifier")
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnArchiver
        '
        resources.ApplyResources(Me.BtnArchiver, "BtnArchiver")
        Me.BtnArchiver.Name = "BtnArchiver"
        Me.BtnArchiver.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'ChkListArchives
        '
        Me.ChkListArchives.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ChkListArchives, "ChkListArchives")
        Me.ChkListArchives.Name = "ChkListArchives"
        Me.ChkListArchives.UseVisualStyleBackColor = False
        '
        'BtnRestore
        '
        resources.ApplyResources(Me.BtnRestore, "BtnRestore")
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.UseVisualStyleBackColor = True
        '
        'BtnResultatsByQCM
        '
        resources.ApplyResources(Me.BtnResultatsByQCM, "BtnResultatsByQCM")
        Me.BtnResultatsByQCM.Name = "BtnResultatsByQCM"
        Me.BtnResultatsByQCM.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        resources.ApplyResources(Me.BtnEdit, "BtnEdit")
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnResultatsByQCMCandidat
        '
        resources.ApplyResources(Me.BtnResultatsByQCMCandidat, "BtnResultatsByQCMCandidat")
        Me.BtnResultatsByQCMCandidat.Name = "BtnResultatsByQCMCandidat"
        Me.BtnResultatsByQCMCandidat.UseVisualStyleBackColor = True
        '
        'GCListeQCM
        '
        resources.ApplyResources(Me.GCListeQCM, "GCListeQCM")
        Me.GCListeQCM.MainView = Me.GVListeQCM
        Me.GCListeQCM.Name = "GCListeQCM"
        Me.GCListeQCM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCListeQCM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVListeQCM})
        '
        'GVListeQCM
        '
        Me.GVListeQCM.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVListeQCM.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVListeQCM.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVListeQCM.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVListeQCM.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVListeQCM.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVListeQCM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Col_NIDQCMNUM, Me.Col_NQCMTYPEID, Me.Col_VQCMTYPELIB, Me.Col_VQCMTITRE, Me.Col_DQCMCREE, Me.Col_BQCMRECRU, Me.Col_BQCMACTIF, Me.Col_VQCMCONSIGNE, Me.Col_BQCMCORRECTAUTO})
        Me.GVListeQCM.GridControl = Me.GCListeQCM
        Me.GVListeQCM.Name = "GVListeQCM"
        Me.GVListeQCM.OptionsBehavior.Editable = False
        Me.GVListeQCM.OptionsBehavior.ReadOnly = True
        Me.GVListeQCM.OptionsView.ShowAutoFilterRow = True
        Me.GVListeQCM.OptionsView.ShowFooter = True
        Me.GVListeQCM.OptionsView.ShowGroupPanel = False
        '
        'Col_NIDQCMNUM
        '
        resources.ApplyResources(Me.Col_NIDQCMNUM, "Col_NIDQCMNUM")
        Me.Col_NIDQCMNUM.FieldName = "NIDQCMNUM"
        Me.Col_NIDQCMNUM.Name = "Col_NIDQCMNUM"
        '
        'Col_NQCMTYPEID
        '
        resources.ApplyResources(Me.Col_NQCMTYPEID, "Col_NQCMTYPEID")
        Me.Col_NQCMTYPEID.FieldName = "NQCMTYPEID"
        Me.Col_NQCMTYPEID.Name = "Col_NQCMTYPEID"
        '
        'Col_VQCMTYPELIB
        '
        Me.Col_VQCMTYPELIB.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VQCMTYPELIB.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VQCMTYPELIB, "Col_VQCMTYPELIB")
        Me.Col_VQCMTYPELIB.FieldName = "VQCMTYPELIB"
        Me.Col_VQCMTYPELIB.Name = "Col_VQCMTYPELIB"
        '
        'Col_VQCMTITRE
        '
        Me.Col_VQCMTITRE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_VQCMTITRE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_VQCMTITRE, "Col_VQCMTITRE")
        Me.Col_VQCMTITRE.FieldName = "VQCMTITRE"
        Me.Col_VQCMTITRE.Name = "Col_VQCMTITRE"
        '
        'Col_DQCMCREE
        '
        Me.Col_DQCMCREE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_DQCMCREE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_DQCMCREE, "Col_DQCMCREE")
        Me.Col_DQCMCREE.FieldName = "DQCMCREE"
        Me.Col_DQCMCREE.Name = "Col_DQCMCREE"
        '
        'Col_BQCMRECRU
        '
        Me.Col_BQCMRECRU.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.Col_BQCMRECRU.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.Col_BQCMRECRU, "Col_BQCMRECRU")
        Me.Col_BQCMRECRU.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.Col_BQCMRECRU.FieldName = "BQCMRECRU"
        Me.Col_BQCMRECRU.Name = "Col_BQCMRECRU"
        '
        'RepositoryItemCheckEdit1
        '
        resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Col_BQCMACTIF
        '
        resources.ApplyResources(Me.Col_BQCMACTIF, "Col_BQCMACTIF")
        Me.Col_BQCMACTIF.FieldName = "BQCMACTIF"
        Me.Col_BQCMACTIF.Name = "Col_BQCMACTIF"
        '
        'Col_VQCMCONSIGNE
        '
        resources.ApplyResources(Me.Col_VQCMCONSIGNE, "Col_VQCMCONSIGNE")
        Me.Col_VQCMCONSIGNE.FieldName = "VQCMCONSIGNE"
        Me.Col_VQCMCONSIGNE.Name = "Col_VQCMCONSIGNE"
        '
        'Col_BQCMCORRECTAUTO
        '
        resources.ApplyResources(Me.Col_BQCMCORRECTAUTO, "Col_BQCMCORRECTAUTO")
        Me.Col_BQCMCORRECTAUTO.FieldName = "BQCMCORRECTAUTO"
        Me.Col_BQCMCORRECTAUTO.Name = "Col_BQCMCORRECTAUTO"
        '
        'BtnDupliqQCM
        '
        resources.ApplyResources(Me.BtnDupliqQCM, "BtnDupliqQCM")
        Me.BtnDupliqQCM.Name = "BtnDupliqQCM"
        Me.BtnDupliqQCM.UseVisualStyleBackColor = True
        '
        'BtnAnalyse
        '
        resources.ApplyResources(Me.BtnAnalyse, "BtnAnalyse")
        Me.BtnAnalyse.Name = "BtnAnalyse"
        Me.BtnAnalyse.UseVisualStyleBackColor = True
        '
        'BtnAffectPers
        '
        resources.ApplyResources(Me.BtnAffectPers, "BtnAffectPers")
        Me.BtnAffectPers.Name = "BtnAffectPers"
        Me.BtnAffectPers.Tag = "314"
        Me.BtnAffectPers.UseVisualStyleBackColor = True
        '
        'BtnCopyToFiliale
        '
        resources.ApplyResources(Me.BtnCopyToFiliale, "BtnCopyToFiliale")
        Me.BtnCopyToFiliale.Name = "BtnCopyToFiliale"
        Me.BtnCopyToFiliale.UseVisualStyleBackColor = True
        '
        'BtnResultSTF
        '
        resources.ApplyResources(Me.BtnResultSTF, "BtnResultSTF")
        Me.BtnResultSTF.Name = "BtnResultSTF"
        Me.BtnResultSTF.UseVisualStyleBackColor = True
        '
        'frmQCMListe
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.BtnResultSTF)
        Me.Controls.Add(Me.BtnCopyToFiliale)
        Me.Controls.Add(Me.BtnAffectPers)
        Me.Controls.Add(Me.BtnAnalyse)
        Me.Controls.Add(Me.BtnDupliqQCM)
        Me.Controls.Add(Me.GCListeQCM)
        Me.Controls.Add(Me.BtnResultatsByQCMCandidat)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnResultatsByQCM)
        Me.Controls.Add(Me.BtnRestore)
        Me.Controls.Add(Me.BtnFermer)
        Me.Controls.Add(Me.BtnArchiver)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnCreerTest)
        Me.Controls.Add(Me.ChkListArchives)
        Me.Name = "frmQCMListe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCListeQCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVListeQCM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCreerTest As System.Windows.Forms.Button
    Friend WithEvents BtnModifier As System.Windows.Forms.Button
    Friend WithEvents BtnArchiver As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents ChkListArchives As System.Windows.Forms.CheckBox
    Friend WithEvents BtnRestore As System.Windows.Forms.Button
    Friend WithEvents BtnResultatsByQCM As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnResultatsByQCMCandidat As System.Windows.Forms.Button
    Private WithEvents GCListeQCM As DevExpress.XtraGrid.GridControl
    Private WithEvents GVListeQCM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_NIDQCMNUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NQCMTYPEID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VQCMTYPELIB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_VQCMTITRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_DQCMCREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_BQCMRECRU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_BQCMACTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BtnDupliqQCM As Button
    Friend WithEvents BtnAnalyse As Button
    Friend WithEvents BtnAffectPers As Button
    Friend WithEvents Col_VQCMCONSIGNE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_BQCMCORRECTAUTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnCopyToFiliale As Button
    Friend WithEvents BtnResultSTF As Button
End Class
