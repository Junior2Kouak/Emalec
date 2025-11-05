<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatFrais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatFrais))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel4 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.GrpActions = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ChartFrais = New DevExpress.XtraCharts.ChartControl()
        Me.GrpPeriode = New System.Windows.Forms.GroupBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDateDeb = New System.Windows.Forms.Label()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.DTPDebut = New System.Windows.Forms.DateTimePicker()
        Me.GrpBoxMoyAn = New System.Windows.Forms.GroupBox()
        Me.LblKmMoyAn = New System.Windows.Forms.Label()
        Me.lblDateJour = New System.Windows.Forms.Label()
        Me.GrpActions.SuspendLayout()
        CType(Me.ChartFrais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        Me.GrpBoxMoyAn.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnFermer)
        Me.GrpActions.Controls.Add(Me.BtnPrint)
        resources.ApplyResources(Me.GrpActions, "GrpActions")
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
        'ChartFrais
        '
        XyDiagram2.AxisX.Label.Angle = CType(resources.GetObject("resource.Angle"), Integer)
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartFrais.Diagram = XyDiagram2
        Me.ChartFrais.Legend.Name = "Default Legend"
        Me.ChartFrais.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Me.ChartFrais, "ChartFrais")
        Me.ChartFrais.Name = "ChartFrais"
        Series2.ArgumentDataMember = "TECH"
        Series2.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series2.Label = SideBySideBarSeriesLabel3
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        resources.ApplyResources(Series2, "Series2")
        Series2.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[False]
        Series2.ValueDataMembersSerializable = "KM"
        SideBySideBarSeriesView2.ColorEach = True
        Series2.View = SideBySideBarSeriesView2
        Me.ChartFrais.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        SideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartFrais.SeriesTemplate.Label = SideBySideBarSeriesLabel4
        Me.ChartFrais.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
		ChartTitle2.TextColor = System.Drawing.Color.Black
        Me.ChartFrais.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.BtnValider)
        Me.GrpPeriode.Controls.Add(Me.Label1)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        Me.GrpPeriode.Controls.Add(Me.DTPFin)
        Me.GrpPeriode.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
        Me.GrpPeriode.ForeColor = System.Drawing.Color.DarkRed
        Me.GrpPeriode.Name = "GrpPeriode"
        Me.GrpPeriode.TabStop = False
        '
        'BtnValider
        '
        resources.ApplyResources(Me.BtnValider, "BtnValider")
        Me.BtnValider.ForeColor = System.Drawing.Color.Black
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LblDateDeb
        '
        Me.LblDateDeb.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.LblDateDeb, "LblDateDeb")
        Me.LblDateDeb.Name = "LblDateDeb"
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
        'GrpBoxMoyAn
        '
        Me.GrpBoxMoyAn.Controls.Add(Me.LblKmMoyAn)
        resources.ApplyResources(Me.GrpBoxMoyAn, "GrpBoxMoyAn")
        Me.GrpBoxMoyAn.ForeColor = System.Drawing.Color.DarkRed
        Me.GrpBoxMoyAn.Name = "GrpBoxMoyAn"
        Me.GrpBoxMoyAn.TabStop = False
        '
        'LblKmMoyAn
        '
        Me.LblKmMoyAn.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.LblKmMoyAn, "LblKmMoyAn")
        Me.LblKmMoyAn.Name = "LblKmMoyAn"
        '
        'lblDateJour
        '
        resources.ApplyResources(Me.lblDateJour, "lblDateJour")
        Me.lblDateJour.Name = "lblDateJour"
        '
        'frmStatFrais
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.lblDateJour)
        Me.Controls.Add(Me.GrpBoxMoyAn)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.ChartFrais)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Name = "frmStatFrais"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartFrais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        Me.GrpBoxMoyAn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents GrpActions As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFermer As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents GrpPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDateDeb As System.Windows.Forms.Label
    Friend WithEvents DTPFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnValider As System.Windows.Forms.Button
    Friend WithEvents GrpBoxMoyAn As System.Windows.Forms.GroupBox
    Friend WithEvents LblKmMoyAn As System.Windows.Forms.Label
    Friend WithEvents lblDateJour As System.Windows.Forms.Label
    Private WithEvents ChartFrais As DevExpress.XtraCharts.ChartControl
End Class
