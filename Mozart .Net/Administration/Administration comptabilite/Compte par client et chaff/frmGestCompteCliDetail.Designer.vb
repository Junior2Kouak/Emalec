<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestCompteCliDetail
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestCompteCliDetail))
    Me.BtnQuit = New System.Windows.Forms.Button()
    Me.BtnSave = New System.Windows.Forms.Button()
    Me.GrpDetailCompteAna = New System.Windows.Forms.GroupBox()
    Me.GlookUpASSCHAFF = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GlookUpFACT = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GVCboFact = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColCboFactNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColCboFactNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.GlookUpCOMPTE = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GVCboCompte = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColCboCompteNCANNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColCboCompteVCANLIB = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.GlookUpChaff = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GVCboChaff = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GCCboChaffNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GCCboChaffNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GlookUpASS = New DevExpress.XtraEditors.GridLookUpEdit()
    Me.GVCboAss = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.GColCboAssNPERNUM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.GColCboAssNOM = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.ChkArchives = New System.Windows.Forms.CheckBox()
    Me.GrpDetailCompteAna.SuspendLayout()
    CType(Me.GlookUpASSCHAFF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpFACT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVCboFact, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpCOMPTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVCboCompte, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpChaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVCboChaff, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GlookUpASS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GVCboAss, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BtnQuit
    '
    resources.ApplyResources(Me.BtnQuit, "BtnQuit")
    Me.BtnQuit.Name = "BtnQuit"
    Me.BtnQuit.UseVisualStyleBackColor = True
    '
    'BtnSave
    '
    resources.ApplyResources(Me.BtnSave, "BtnSave")
    Me.BtnSave.Name = "BtnSave"
    Me.BtnSave.UseVisualStyleBackColor = True
    '
    'GrpDetailCompteAna
    '
    Me.GrpDetailCompteAna.Controls.Add(Me.ChkArchives)
    Me.GrpDetailCompteAna.Controls.Add(Me.GlookUpASSCHAFF)
    Me.GrpDetailCompteAna.Controls.Add(Me.Label5)
    Me.GrpDetailCompteAna.Controls.Add(Me.BtnSave)
    Me.GrpDetailCompteAna.Controls.Add(Me.BtnQuit)
    Me.GrpDetailCompteAna.Controls.Add(Me.GlookUpFACT)
    Me.GrpDetailCompteAna.Controls.Add(Me.Label3)
    Me.GrpDetailCompteAna.Controls.Add(Me.GlookUpCOMPTE)
    Me.GrpDetailCompteAna.Controls.Add(Me.Label2)
    Me.GrpDetailCompteAna.Controls.Add(Me.GlookUpChaff)
    Me.GrpDetailCompteAna.Controls.Add(Me.Label1)
    Me.GrpDetailCompteAna.Controls.Add(Me.GlookUpASS)
    Me.GrpDetailCompteAna.Controls.Add(Me.Label4)
    resources.ApplyResources(Me.GrpDetailCompteAna, "GrpDetailCompteAna")
    Me.GrpDetailCompteAna.Name = "GrpDetailCompteAna"
    Me.GrpDetailCompteAna.TabStop = False
    '
    'GlookUpASSCHAFF
    '
    resources.ApplyResources(Me.GlookUpASSCHAFF, "GlookUpASSCHAFF")
    Me.GlookUpASSCHAFF.Name = "GlookUpASSCHAFF"
    Me.GlookUpASSCHAFF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpASSCHAFF.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpASSCHAFF.Properties.DisplayMember = "NOM"
    Me.GlookUpASSCHAFF.Properties.NullText = resources.GetString("GlookUpASSCHAFF.Properties.NullText")
    Me.GlookUpASSCHAFF.Properties.ValueMember = "NPERNUM"
    Me.GlookUpASSCHAFF.Properties.View = Me.GridView1
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
    Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GridView1.OptionsView.ShowAutoFilterRow = True
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'GridColumn1
    '
    Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GridColumn1.FieldName = "NPERNUM"
    Me.GridColumn1.Name = "GridColumn1"
    Me.GridColumn1.OptionsColumn.AllowEdit = False
    Me.GridColumn1.OptionsColumn.ReadOnly = True
    '
    'GridColumn2
    '
    Me.GridColumn2.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GridColumn2.AppearanceHeader.Options.UseFont = True
    Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
    Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GridColumn2, "GridColumn2")
    Me.GridColumn2.FieldName = "NOM"
    Me.GridColumn2.Name = "GridColumn2"
    Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label5
    '
    resources.ApplyResources(Me.Label5, "Label5")
    Me.Label5.Name = "Label5"
    '
    'GlookUpFACT
    '
    resources.ApplyResources(Me.GlookUpFACT, "GlookUpFACT")
    Me.GlookUpFACT.Name = "GlookUpFACT"
    Me.GlookUpFACT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpFACT.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpFACT.Properties.DisplayMember = "NOM"
    Me.GlookUpFACT.Properties.NullText = resources.GetString("GlookUpFACT.Properties.NullText")
    Me.GlookUpFACT.Properties.ValueMember = "NPERNUM"
    Me.GlookUpFACT.Properties.View = Me.GVCboFact
    '
    'GVCboFact
    '
    Me.GVCboFact.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboFactNPERNUM, Me.GColCboFactNOM})
    Me.GVCboFact.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboFact.Name = "GVCboFact"
    Me.GVCboFact.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboFact.OptionsView.ShowAutoFilterRow = True
    Me.GVCboFact.OptionsView.ShowGroupPanel = False
    '
    'GColCboFactNPERNUM
    '
    Me.GColCboFactNPERNUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboFactNPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboFactNPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GColCboFactNPERNUM.FieldName = "NPERNUM"
    Me.GColCboFactNPERNUM.Name = "GColCboFactNPERNUM"
    Me.GColCboFactNPERNUM.OptionsColumn.AllowEdit = False
    Me.GColCboFactNPERNUM.OptionsColumn.ReadOnly = True
    '
    'GColCboFactNOM
    '
    Me.GColCboFactNOM.AppearanceHeader.Font = CType(resources.GetObject("GColCboFactNOM.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GColCboFactNOM.AppearanceHeader.Options.UseFont = True
    Me.GColCboFactNOM.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboFactNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboFactNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GColCboFactNOM, "GColCboFactNOM")
    Me.GColCboFactNOM.FieldName = "NOM"
    Me.GColCboFactNOM.Name = "GColCboFactNOM"
    Me.GColCboFactNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label3
    '
    resources.ApplyResources(Me.Label3, "Label3")
    Me.Label3.Name = "Label3"
    '
    'GlookUpCOMPTE
    '
    resources.ApplyResources(Me.GlookUpCOMPTE, "GlookUpCOMPTE")
    Me.GlookUpCOMPTE.Name = "GlookUpCOMPTE"
    Me.GlookUpCOMPTE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpCOMPTE.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpCOMPTE.Properties.DisplayMember = "VCANLIB"
    Me.GlookUpCOMPTE.Properties.NullText = resources.GetString("GlookUpCOMPTE.Properties.NullText")
    Me.GlookUpCOMPTE.Properties.ValueMember = "NCANNUM"
    Me.GlookUpCOMPTE.Properties.View = Me.GVCboCompte
    '
    'GVCboCompte
    '
    Me.GVCboCompte.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboCompteNCANNUM, Me.GColCboCompteVCANLIB})
    Me.GVCboCompte.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboCompte.Name = "GVCboCompte"
    Me.GVCboCompte.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboCompte.OptionsView.ShowAutoFilterRow = True
    Me.GVCboCompte.OptionsView.ShowGroupPanel = False
    '
    'GColCboCompteNCANNUM
    '
    Me.GColCboCompteNCANNUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboCompteNCANNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboCompteNCANNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GColCboCompteNCANNUM.FieldName = "NCANNUM"
    Me.GColCboCompteNCANNUM.Name = "GColCboCompteNCANNUM"
    Me.GColCboCompteNCANNUM.OptionsColumn.AllowEdit = False
    Me.GColCboCompteNCANNUM.OptionsColumn.ReadOnly = True
    '
    'GColCboCompteVCANLIB
    '
    Me.GColCboCompteVCANLIB.AppearanceHeader.Font = CType(resources.GetObject("GColCboCompteVCANLIB.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GColCboCompteVCANLIB.AppearanceHeader.Options.UseFont = True
    Me.GColCboCompteVCANLIB.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboCompteVCANLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboCompteVCANLIB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GColCboCompteVCANLIB, "GColCboCompteVCANLIB")
    Me.GColCboCompteVCANLIB.FieldName = "VCANLIB"
    Me.GColCboCompteVCANLIB.Name = "GColCboCompteVCANLIB"
    Me.GColCboCompteVCANLIB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label2
    '
    resources.ApplyResources(Me.Label2, "Label2")
    Me.Label2.Name = "Label2"
    '
    'GlookUpChaff
    '
    resources.ApplyResources(Me.GlookUpChaff, "GlookUpChaff")
    Me.GlookUpChaff.Name = "GlookUpChaff"
    Me.GlookUpChaff.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpChaff.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpChaff.Properties.DisplayMember = "NOM"
    Me.GlookUpChaff.Properties.NullText = resources.GetString("GlookUpChaff.Properties.NullText")
    Me.GlookUpChaff.Properties.ValueMember = "NPERNUM"
    Me.GlookUpChaff.Properties.View = Me.GVCboChaff
    '
    'GVCboChaff
    '
    Me.GVCboChaff.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCCboChaffNPERNUM, Me.GCCboChaffNOM})
    Me.GVCboChaff.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboChaff.Name = "GVCboChaff"
    Me.GVCboChaff.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboChaff.OptionsView.ShowAutoFilterRow = True
    Me.GVCboChaff.OptionsView.ShowGroupPanel = False
    '
    'GCCboChaffNPERNUM
    '
    Me.GCCboChaffNPERNUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboChaffNPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboChaffNPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GCCboChaffNPERNUM.FieldName = "NPERNUM"
    Me.GCCboChaffNPERNUM.Name = "GCCboChaffNPERNUM"
    Me.GCCboChaffNPERNUM.OptionsColumn.AllowEdit = False
    Me.GCCboChaffNPERNUM.OptionsColumn.ReadOnly = True
    '
    'GCCboChaffNOM
    '
    Me.GCCboChaffNOM.AppearanceHeader.Font = CType(resources.GetObject("GCCboChaffNOM.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GCCboChaffNOM.AppearanceHeader.Options.UseFont = True
    Me.GCCboChaffNOM.AppearanceHeader.Options.UseTextOptions = True
    Me.GCCboChaffNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GCCboChaffNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GCCboChaffNOM, "GCCboChaffNOM")
    Me.GCCboChaffNOM.FieldName = "NOM"
    Me.GCCboChaffNOM.Name = "GCCboChaffNOM"
    Me.GCCboChaffNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label1
    '
    resources.ApplyResources(Me.Label1, "Label1")
    Me.Label1.Name = "Label1"
    '
    'GlookUpASS
    '
    resources.ApplyResources(Me.GlookUpASS, "GlookUpASS")
    Me.GlookUpASS.Name = "GlookUpASS"
    Me.GlookUpASS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("GlookUpASS.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
    Me.GlookUpASS.Properties.DisplayMember = "NOM"
    Me.GlookUpASS.Properties.NullText = resources.GetString("GlookUpASS.Properties.NullText")
    Me.GlookUpASS.Properties.ValueMember = "NPERNUM"
    Me.GlookUpASS.Properties.View = Me.GVCboAss
    '
    'GVCboAss
    '
    Me.GVCboAss.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColCboAssNPERNUM, Me.GColCboAssNOM})
    Me.GVCboAss.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
    Me.GVCboAss.Name = "GVCboAss"
    Me.GVCboAss.OptionsSelection.EnableAppearanceFocusedCell = False
    Me.GVCboAss.OptionsView.ShowAutoFilterRow = True
    Me.GVCboAss.OptionsView.ShowGroupPanel = False
    '
    'GColCboAssNPERNUM
    '
    Me.GColCboAssNPERNUM.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboAssNPERNUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboAssNPERNUM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.GColCboAssNPERNUM.FieldName = "NPERNUM"
    Me.GColCboAssNPERNUM.Name = "GColCboAssNPERNUM"
    Me.GColCboAssNPERNUM.OptionsColumn.AllowEdit = False
    Me.GColCboAssNPERNUM.OptionsColumn.ReadOnly = True
    '
    'GColCboAssNOM
    '
    Me.GColCboAssNOM.AppearanceHeader.Font = CType(resources.GetObject("GColCboAssNOM.AppearanceHeader.Font"), System.Drawing.Font)
    Me.GColCboAssNOM.AppearanceHeader.Options.UseFont = True
    Me.GColCboAssNOM.AppearanceHeader.Options.UseTextOptions = True
    Me.GColCboAssNOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.GColCboAssNOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    resources.ApplyResources(Me.GColCboAssNOM, "GColCboAssNOM")
    Me.GColCboAssNOM.FieldName = "NOM"
    Me.GColCboAssNOM.Name = "GColCboAssNOM"
    Me.GColCboAssNOM.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '
    'Label4
    '
    resources.ApplyResources(Me.Label4, "Label4")
    Me.Label4.Name = "Label4"
    '
    'ChkArchives
    '
    resources.ApplyResources(Me.ChkArchives, "ChkArchives")
    Me.ChkArchives.Name = "ChkArchives"
    Me.ChkArchives.UseVisualStyleBackColor = True
    '
    'frmGestCompteCliDetail
    '
    resources.ApplyResources(Me, "$this")
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Wheat
    Me.Controls.Add(Me.GrpDetailCompteAna)
    Me.Name = "frmGestCompteCliDetail"
    Me.GrpDetailCompteAna.ResumeLayout(False)
    CType(Me.GlookUpASSCHAFF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpFACT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVCboFact, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpCOMPTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVCboCompte, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpChaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVCboChaff, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GlookUpASS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GVCboAss, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GrpDetailCompteAna As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GlookUpFACT As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboFact As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboFactNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboFactNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GlookUpCOMPTE As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboCompte As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboCompteNCANNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboCompteVCANLIB As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GlookUpChaff As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboChaff As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GCCboChaffNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GCCboChaffNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GlookUpASS As DevExpress.XtraEditors.GridLookUpEdit
    Private WithEvents GVCboAss As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColCboAssNPERNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCboAssNOM As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GlookUpASSCHAFF As DevExpress.XtraEditors.GridLookUpEdit
  Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Private WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
  Private WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents Label5 As Label
  Friend WithEvents ChkArchives As CheckBox
End Class
