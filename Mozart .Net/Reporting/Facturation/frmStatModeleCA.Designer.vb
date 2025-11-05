<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatModeleCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatModeleCA))
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.GrpGraph = New System.Windows.Forms.GroupBox()
        Me.ChartGraph = New DevExpress.XtraCharts.ChartControl()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDateDeb = New System.Windows.Forms.Label()
        Me.BtnValid = New System.Windows.Forms.Button()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.GCStat = New DevExpress.XtraGrid.GridControl()
        Me.GVStat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GrpActions.SuspendLayout()
        Me.GrpGraph.SuspendLayout()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        Me.GrpActions.Name = "GrpActions"
        Me.GrpActions.TabStop = False
        '
        'BtnFermer
        '
        resources.ApplyResources(Me.BtnFermer, "BtnFermer")
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
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        '
        'GrpPeriode
        '
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.Controls.Add(Me.Label1)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.DTPFin)
        Me.GrpPeriode.Controls.Add(Me.DTPDebut)
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LblDateDeb
        '
        resources.ApplyResources(Me.LblDateDeb, "LblDateDeb")
        Me.LblDateDeb.Name = "LblDateDeb"
        '
        'BtnValid
        '
        resources.ApplyResources(Me.BtnValid, "BtnValid")
        Me.BtnValid.Name = "BtnValid"
        Me.BtnValid.UseVisualStyleBackColor = True
        '
        'DTPFin
        '
        resources.ApplyResources(Me.DTPFin, "DTPFin")
        Me.DTPFin.Name = "DTPFin"
        '
        'DTPDebut
        '
        resources.ApplyResources(Me.DTPDebut, "DTPDebut")
        Me.DTPDebut.Name = "DTPDebut"
        '
        'GCStat
        '
        resources.ApplyResources(Me.GCStat, "GCStat")
        '
        '
        '
        Me.GCStat.EmbeddedNavigator.AccessibleDescription = resources.GetString("GCStat.EmbeddedNavigator.AccessibleDescription")
        Me.GCStat.EmbeddedNavigator.AccessibleName = resources.GetString("GCStat.EmbeddedNavigator.AccessibleName")
        Me.GCStat.EmbeddedNavigator.AllowHtmlTextInToolTip = CType(resources.GetObject("GCStat.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean)
        Me.GCStat.EmbeddedNavigator.Anchor = CType(resources.GetObject("GCStat.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GCStat.EmbeddedNavigator.BackgroundImage = CType(resources.GetObject("GCStat.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image)
        Me.GCStat.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GCStat.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
        Me.GCStat.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GCStat.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GCStat.EmbeddedNavigator.MaximumSize = CType(resources.GetObject("GCStat.EmbeddedNavigator.MaximumSize"), System.Drawing.Size)
        Me.GCStat.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GCStat.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
        Me.GCStat.EmbeddedNavigator.ToolTip = resources.GetString("GCStat.EmbeddedNavigator.ToolTip")
        Me.GCStat.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GCStat.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
        Me.GCStat.EmbeddedNavigator.ToolTipTitle = resources.GetString("GCStat.EmbeddedNavigator.ToolTipTitle")
        Me.GCStat.MainView = Me.GVStat
        Me.GCStat.Name = "GCStat"
        Me.GCStat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStat})
        '
        'GVStat
        '
        Me.GVStat.Appearance.HeaderPanel.Font = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.GVStat.Appearance.HeaderPanel.FontSizeDelta = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.FontSizeDelta"), Integer)
        Me.GVStat.Appearance.HeaderPanel.FontStyleDelta = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.FontStyleDelta"), System.Drawing.FontStyle)
        Me.GVStat.Appearance.HeaderPanel.GradientMode = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode)
        Me.GVStat.Appearance.HeaderPanel.Image = CType(resources.GetObject("GVStat.Appearance.HeaderPanel.Image"), System.Drawing.Image)
        Me.GVStat.Appearance.HeaderPanel.Options.UseFont = True
        Me.GVStat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GVStat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GVStat.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        resources.ApplyResources(Me.GVStat, "GVStat")
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'frmStatModeleCA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpGraph)
        Me.Name = "frmStatModeleCA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpGraph.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GrpGraph As System.Windows.Forms.GroupBox
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents BtnValid As System.Windows.Forms.Button
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDateDeb As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
End Class
