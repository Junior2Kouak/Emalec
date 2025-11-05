<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFacturationCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFacturationCA))
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.cmdCA = New System.Windows.Forms.Button()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpGraph = New System.Windows.Forms.GroupBox()
        Me.ChartGraph = New DevExpress.XtraCharts.ChartControl()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LblDateDeb = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtValider = New System.Windows.Forms.Button()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.apiSocieteAuto1 = New MozartUC.apiSocieteAuto()
        Me.GrpActions.SuspendLayout()
        Me.GrpGraph.SuspendLayout()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        resources.ApplyResources(Me.GrpActions, "GrpActions")
        Me.GrpActions.Controls.Add(Me.cmdCA)
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'cmdCA
        '
        resources.ApplyResources(Me.cmdCA, "cmdCA")
        Me.cmdCA.Name = "cmdCA"
        Me.cmdCA.UseVisualStyleBackColor = True
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
        Me.BtnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        resources.ApplyResources(Me.BtnPrint, "BtnPrint")
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'GrpGraph
        '
        resources.ApplyResources(Me.GrpGraph, "GrpGraph")
        Me.GrpGraph.Controls.Add(Me.ChartGraph)
        Me.GrpGraph.Name = "GrpGraph"
        Me.GrpGraph.TabStop = False
        '
        'ChartGraph
        '
        resources.ApplyResources(Me.ChartGraph, "ChartGraph")
        Me.ChartGraph.Legend.Name = "Default Legend"
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = SideBySideBarSeriesLabel1
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
        Me.GVStat.DetailHeight = 284
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'LblDateDeb
        '
        resources.ApplyResources(Me.LblDateDeb, "LblDateDeb")
        Me.LblDateDeb.Name = "LblDateDeb"
        '
        'lblTotal
        '
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.Name = "lblTotal"
        '
        'GrpPeriode
        '
        Me.GrpPeriode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GrpPeriode.Controls.Add(Me.lblTotal)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'BtValider
        '
        resources.ApplyResources(Me.BtValider, "BtValider")
        Me.BtValider.Name = "BtValider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'apiSocieteAuto1
        '
        Me.apiSocieteAuto1.CacheOneSoc = False
        resources.ApplyResources(Me.apiSocieteAuto1, "apiSocieteAuto1")
        Me.apiSocieteAuto1.IdMenuParent = CType(87, Short)
        Me.apiSocieteAuto1.ListIndex = CType(-1, Short)
        Me.apiSocieteAuto1.Name = "apiSocieteAuto1"
        '
        'frmStatFacturationCA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.CancelButton = Me.BtnFermer
        Me.Controls.Add(Me.apiSocieteAuto1)
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.BtValider)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpGraph)
        Me.Name = "frmStatFacturationCA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpGraph.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
  Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
  Friend WithEvents BtnFermer As System.Windows.Forms.Button
  Friend WithEvents BtnPrint As System.Windows.Forms.Button
  Friend WithEvents GrpGraph As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCA As System.Windows.Forms.Button
    Friend WithEvents LblDateDeb As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
    Friend WithEvents apiSocieteAuto1 As MozartUC.apiSocieteAuto
End Class
