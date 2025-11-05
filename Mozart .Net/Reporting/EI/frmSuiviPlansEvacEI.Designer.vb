<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuiviPlansEvacEI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuiviPlansEvacEI))
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NACTNUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VCLINOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VSITNOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIAction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DDEMANDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DCONSTATSITE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DINTERVENTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRELEVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTRELEVE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOUR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTTECH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOURTECH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTRELEVE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOUR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTTECH2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOURTECH2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTTECH3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOUR3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTRELEVEFINAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRETOURTECHFINAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DTRANSFERTREALISATIONPLAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DRECEPTIONPLAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DENVOIPLAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.btnAccesDI = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnActif = New System.Windows.Forms.Button()
        Me.btnConsultArchives = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GVStat.ColumnPanelRowHeight = 90
        Me.GVStat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NACTNUM, Me.VCLINOM, Me.VSITNOM, Me.DIAction, Me.DDEMANDE, Me.DCONSTATSITE, Me.DINTERVENTION, Me.DRELEVE, Me.DTRANSFERTRELEVE1, Me.DRETOUR1, Me.DTRANSFERTTECH1, Me.DRETOURTECH1, Me.DTRANSFERTRELEVE2, Me.DRETOUR2, Me.DTRANSFERTTECH2, Me.DRETOURTECH2, Me.DTRANSFERTTECH3, Me.DRETOUR3, Me.DTRANSFERTRELEVEFINAL, Me.DRETOURTECHFINAL, Me.DTRANSFERTREALISATIONPLAN, Me.DRECEPTIONPLAN, Me.DENVOIPLAN})
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowAutoFilterRow = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'NACTNUM
        '
        Me.NACTNUM.FieldName = "NACTNUM"
        Me.NACTNUM.Name = "NACTNUM"
        '
        'VCLINOM
        '
        Me.VCLINOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VCLINOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VCLINOM, "VCLINOM")
        Me.VCLINOM.FieldName = "VCLINOM"
        Me.VCLINOM.Name = "VCLINOM"
        '
        'VSITNOM
        '
        Me.VSITNOM.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.VSITNOM.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.VSITNOM, "VSITNOM")
        Me.VSITNOM.FieldName = "VSITNOM"
        Me.VSITNOM.Name = "VSITNOM"
        '
        'DIAction
        '
        Me.DIAction.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DIAction.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DIAction, "DIAction")
        Me.DIAction.FieldName = "DIAction"
        Me.DIAction.Name = "DIAction"
        '
        'DDEMANDE
        '
        Me.DDEMANDE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DDEMANDE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DDEMANDE, "DDEMANDE")
        Me.DDEMANDE.FieldName = "DDEMANDE"
        Me.DDEMANDE.Name = "DDEMANDE"
        '
        'DCONSTATSITE
        '
        Me.DCONSTATSITE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DCONSTATSITE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DCONSTATSITE, "DCONSTATSITE")
        Me.DCONSTATSITE.FieldName = "DCONSTATSITE"
        Me.DCONSTATSITE.Name = "DCONSTATSITE"
        '
        'DINTERVENTION
        '
        Me.DINTERVENTION.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DINTERVENTION.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DINTERVENTION, "DINTERVENTION")
        Me.DINTERVENTION.FieldName = "DINTERVENTION"
        Me.DINTERVENTION.Name = "DINTERVENTION"
        '
        'DRELEVE
        '
        Me.DRELEVE.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRELEVE.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRELEVE, "DRELEVE")
        Me.DRELEVE.FieldName = "DRELEVE"
        Me.DRELEVE.Name = "DRELEVE"
        '
        'DTRANSFERTRELEVE1
        '
        Me.DTRANSFERTRELEVE1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTRELEVE1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTRELEVE1, "DTRANSFERTRELEVE1")
        Me.DTRANSFERTRELEVE1.FieldName = "DTRANSFERTRELEVE1"
        Me.DTRANSFERTRELEVE1.Name = "DTRANSFERTRELEVE1"
        '
        'DRETOUR1
        '
        Me.DRETOUR1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOUR1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOUR1, "DRETOUR1")
        Me.DRETOUR1.FieldName = "DRETOUR1"
        Me.DRETOUR1.Name = "DRETOUR1"
        '
        'DTRANSFERTTECH1
        '
        Me.DTRANSFERTTECH1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTTECH1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTTECH1, "DTRANSFERTTECH1")
        Me.DTRANSFERTTECH1.FieldName = "DTRANSFERTTECH1"
        Me.DTRANSFERTTECH1.Name = "DTRANSFERTTECH1"
        '
        'DRETOURTECH1
        '
        Me.DRETOURTECH1.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOURTECH1.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOURTECH1, "DRETOURTECH1")
        Me.DRETOURTECH1.FieldName = "DRETOURTECH1"
        Me.DRETOURTECH1.Name = "DRETOURTECH1"
        '
        'DTRANSFERTRELEVE2
        '
        Me.DTRANSFERTRELEVE2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTRELEVE2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTRELEVE2, "DTRANSFERTRELEVE2")
        Me.DTRANSFERTRELEVE2.FieldName = "DTRANSFERTRELEVE2"
        Me.DTRANSFERTRELEVE2.Name = "DTRANSFERTRELEVE2"
        '
        'DRETOUR2
        '
        Me.DRETOUR2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOUR2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOUR2, "DRETOUR2")
        Me.DRETOUR2.FieldName = "DRETOUR2"
        Me.DRETOUR2.Name = "DRETOUR2"
        '
        'DTRANSFERTTECH2
        '
        Me.DTRANSFERTTECH2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTTECH2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTTECH2, "DTRANSFERTTECH2")
        Me.DTRANSFERTTECH2.FieldName = "DTRANSFERTTECH2"
        Me.DTRANSFERTTECH2.Name = "DTRANSFERTTECH2"
        '
        'DRETOURTECH2
        '
        Me.DRETOURTECH2.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOURTECH2.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOURTECH2, "DRETOURTECH2")
        Me.DRETOURTECH2.FieldName = "DRETOURTECH2"
        Me.DRETOURTECH2.Name = "DRETOURTECH2"
        '
        'DTRANSFERTTECH3
        '
        Me.DTRANSFERTTECH3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTTECH3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTTECH3, "DTRANSFERTTECH3")
        Me.DTRANSFERTTECH3.FieldName = "DTRANSFERTTECH3"
        Me.DTRANSFERTTECH3.Name = "DTRANSFERTTECH3"
        '
        'DRETOUR3
        '
        Me.DRETOUR3.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOUR3.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOUR3, "DRETOUR3")
        Me.DRETOUR3.FieldName = "DRETOUR3"
        Me.DRETOUR3.Name = "DRETOUR3"
        '
        'DTRANSFERTRELEVEFINAL
        '
        Me.DTRANSFERTRELEVEFINAL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTRELEVEFINAL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTRELEVEFINAL, "DTRANSFERTRELEVEFINAL")
        Me.DTRANSFERTRELEVEFINAL.FieldName = "DTRANSFERTRELEVEFINAL"
        Me.DTRANSFERTRELEVEFINAL.Name = "DTRANSFERTRELEVEFINAL"
        '
        'DRETOURTECHFINAL
        '
        Me.DRETOURTECHFINAL.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRETOURTECHFINAL.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRETOURTECHFINAL, "DRETOURTECHFINAL")
        Me.DRETOURTECHFINAL.FieldName = "DRETOURTECHFINAL"
        Me.DRETOURTECHFINAL.Name = "DRETOURTECHFINAL"
        '
        'DTRANSFERTREALISATIONPLAN
        '
        Me.DTRANSFERTREALISATIONPLAN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DTRANSFERTREALISATIONPLAN.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DTRANSFERTREALISATIONPLAN, "DTRANSFERTREALISATIONPLAN")
        Me.DTRANSFERTREALISATIONPLAN.FieldName = "DTRANSFERTREALISATIONPLAN"
        Me.DTRANSFERTREALISATIONPLAN.Name = "DTRANSFERTREALISATIONPLAN"
        '
        'DRECEPTIONPLAN
        '
        Me.DRECEPTIONPLAN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DRECEPTIONPLAN.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DRECEPTIONPLAN, "DRECEPTIONPLAN")
        Me.DRECEPTIONPLAN.FieldName = "DRECEPTIONPLAN"
        Me.DRECEPTIONPLAN.Name = "DRECEPTIONPLAN"
        '
        'DENVOIPLAN
        '
        Me.DENVOIPLAN.AppearanceHeader.ForeColor = System.Drawing.Color.Black
        Me.DENVOIPLAN.AppearanceHeader.Options.UseForeColor = True
        resources.ApplyResources(Me.DENVOIPLAN, "DENVOIPLAN")
        Me.DENVOIPLAN.FieldName = "DENVOIPLAN"
        Me.DENVOIPLAN.Name = "DENVOIPLAN"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.btnAccesDI)
        Me.GrpActions.Controls.Add(Me.btnDetails)
        Me.GrpActions.Controls.Add(Me.btnActif)
        Me.GrpActions.Controls.Add(Me.btnConsultArchives)
        Me.GrpActions.Controls.Add(Me.Button1)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'btnAccesDI
        '
        resources.ApplyResources(Me.btnAccesDI, "btnAccesDI")
        Me.btnAccesDI.Name = "btnAccesDI"
        Me.btnAccesDI.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        resources.ApplyResources(Me.btnDetails, "btnDetails")
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnActif
        '
        resources.ApplyResources(Me.btnActif, "btnActif")
        Me.btnActif.Name = "btnActif"
        Me.btnActif.UseVisualStyleBackColor = True
        '
        'btnConsultArchives
        '
        resources.ApplyResources(Me.btnConsultArchives, "btnConsultArchives")
        Me.btnConsultArchives.Name = "btnConsultArchives"
        Me.btnConsultArchives.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
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
        '
        'frmSuiviPlansEvacEI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmSuiviPlansEvacEI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnConsultArchives As System.Windows.Forms.Button
    Friend WithEvents btnActif As System.Windows.Forms.Button
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents btnAccesDI As System.Windows.Forms.Button
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents NACTNUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VCLINOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents VSITNOM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DIAction As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DDEMANDE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DCONSTATSITE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DINTERVENTION As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRELEVE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTRELEVE1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOUR1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTTECH1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOURTECH1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTRELEVE2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOUR2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTTECH2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOURTECH2 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTTECH3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOUR3 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTRELEVEFINAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRETOURTECHFINAL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DTRANSFERTREALISATIONPLAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DRECEPTIONPLAN As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents DENVOIPLAN As DevExpress.XtraGrid.Columns.GridColumn
End Class
