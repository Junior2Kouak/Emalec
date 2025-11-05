<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableHDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableHDetail))
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnDetail = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GCDetailH = New DevExpress.XtraGrid.GridControl()
        Me.GVDetailH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GColNDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTPLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColDACTDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTATT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNACTDUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCout = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColCETACOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColVACTDES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GColNUM_NDINNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions.SuspendLayout()
        CType(Me.GCDetailH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetailH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnDetail)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnDetail
        '
        resources.ApplyResources(Me.BtnDetail, "BtnDetail")
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Tag = "136"
        Me.BtnDetail.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Tag = "136"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Tag = "Détail des heures pour "
        '
        'GCDetailH
        '
        resources.ApplyResources(Me.GCDetailH, "GCDetailH")
        Me.GCDetailH.MainView = Me.GVDetailH
        Me.GCDetailH.Name = "GCDetailH"
        Me.GCDetailH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetailH})
        '
        'GVDetailH
        '
        Me.GVDetailH.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVDetailH.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVDetailH.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVDetailH.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVDetailH.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVDetailH.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVDetailH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GColNDINNUM, Me.GColVCLINOM, Me.GColVSITNOM, Me.GColDACTPLA, Me.GColDACTDEX, Me.GColVACTATT, Me.GColNACTDUR, Me.GColCout, Me.GColCETACOD, Me.GColVACTDES, Me.GColNACTNUM, Me.GColNUM_NDINNUM})
        Me.GVDetailH.GridControl = Me.GCDetailH
        Me.GVDetailH.Name = "GVDetailH"
        Me.GVDetailH.OptionsBehavior.Editable = False
        Me.GVDetailH.OptionsBehavior.ReadOnly = True
        Me.GVDetailH.OptionsView.ShowGroupPanel = False
        '
        'GColNDINNUM
        '
        Me.GColNDINNUM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColNDINNUM.AppearanceCell.Options.UseForeColor = True
        Me.GColNDINNUM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNDINNUM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNDINNUM, "GColNDINNUM")
        Me.GColNDINNUM.FieldName = "NDINNUM"
        Me.GColNDINNUM.Name = "GColNDINNUM"
        '
        'GColVCLINOM
        '
        Me.GColVCLINOM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColVCLINOM.AppearanceCell.Options.UseForeColor = True
        Me.GColVCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVCLINOM, "GColVCLINOM")
        Me.GColVCLINOM.FieldName = "VCLINOM"
        Me.GColVCLINOM.Name = "GColVCLINOM"
        '
        'GColVSITNOM
        '
        Me.GColVSITNOM.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceCell.Options.UseForeColor = True
        Me.GColVSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVSITNOM, "GColVSITNOM")
        Me.GColVSITNOM.FieldName = "VSITNOM"
        Me.GColVSITNOM.Name = "GColVSITNOM"
        '
        'GColDACTPLA
        '
        Me.GColDACTPLA.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColDACTPLA.AppearanceCell.Options.UseForeColor = True
        Me.GColDACTPLA.AppearanceCell.Options.UseTextOptions = True
        Me.GColDACTPLA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDACTPLA.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDACTPLA.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDACTPLA.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColDACTPLA, "GColDACTPLA")
        Me.GColDACTPLA.FieldName = "DACTPLA"
        Me.GColDACTPLA.Name = "GColDACTPLA"
        '
        'GColDACTDEX
        '
        Me.GColDACTDEX.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColDACTDEX.AppearanceCell.Options.UseForeColor = True
        Me.GColDACTDEX.AppearanceCell.Options.UseTextOptions = True
        Me.GColDACTDEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColDACTDEX.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColDACTDEX.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColDACTDEX.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColDACTDEX, "GColDACTDEX")
        Me.GColDACTDEX.FieldName = "DACTDEX"
        Me.GColDACTDEX.Name = "GColDACTDEX"
        '
        'GColVACTATT
        '
        Me.GColVACTATT.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColVACTATT.AppearanceCell.Options.UseForeColor = True
        Me.GColVACTATT.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVACTATT.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVACTATT, "GColVACTATT")
        Me.GColVACTATT.FieldName = "VACTATT"
        Me.GColVACTATT.Name = "GColVACTATT"
        '
        'GColNACTDUR
        '
        Me.GColNACTDUR.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColNACTDUR.AppearanceCell.Options.UseForeColor = True
        Me.GColNACTDUR.AppearanceCell.Options.UseTextOptions = True
        Me.GColNACTDUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColNACTDUR.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColNACTDUR.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColNACTDUR.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColNACTDUR, "GColNACTDUR")
        Me.GColNACTDUR.FieldName = "NACTDUR"
        Me.GColNACTDUR.Name = "GColNACTDUR"
        '
        'GColCout
        '
        Me.GColCout.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColCout.AppearanceCell.Options.UseForeColor = True
        Me.GColCout.AppearanceCell.Options.UseTextOptions = True
        Me.GColCout.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCout.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCout.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCout.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColCout, "GColCout")
        Me.GColCout.FieldName = "Cout"
        Me.GColCout.Name = "GColCout"
        '
        'GColCETACOD
        '
        Me.GColCETACOD.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColCETACOD.AppearanceCell.Options.UseForeColor = True
        Me.GColCETACOD.AppearanceCell.Options.UseTextOptions = True
        Me.GColCETACOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GColCETACOD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GColCETACOD.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColCETACOD.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColCETACOD, "GColCETACOD")
        Me.GColCETACOD.FieldName = "CETACOD"
        Me.GColCETACOD.Name = "GColCETACOD"
        '
        'GColVACTDES
        '
        Me.GColVACTDES.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.GColVACTDES.AppearanceCell.Options.UseForeColor = True
        Me.GColVACTDES.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.GColVACTDES.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.GColVACTDES, "GColVACTDES")
        Me.GColVACTDES.FieldName = "VACTDES"
        Me.GColVACTDES.Name = "GColVACTDES"
        '
        'GColNACTNUM
        '
        resources.ApplyResources(Me.GColNACTNUM, "GColNACTNUM")
        Me.GColNACTNUM.FieldName = "NACTNUM"
        Me.GColNACTNUM.Name = "GColNACTNUM"
        '
        'GColNUM_NDINNUM
        '
        resources.ApplyResources(Me.GColNUM_NDINNUM, "GColNUM_NDINNUM")
        Me.GColNUM_NDINNUM.FieldName = "NUM_NDINNUM"
        Me.GColNUM_NDINNUM.Name = "GColNUM_NDINNUM"
        '
        'frmTableHDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.Controls.Add(Me.GCDetailH)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "frmTableHDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(Me.GCDetailH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetailH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Private WithEvents GCDetailH As DevExpress.XtraGrid.GridControl
    Private WithEvents GVDetailH As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GColNDINNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDACTPLA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColDACTDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVACTATT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNACTDUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCout As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColCETACOD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColVACTDES As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GColNUM_NDINNUM As DevExpress.XtraGrid.Columns.GridColumn
End Class
