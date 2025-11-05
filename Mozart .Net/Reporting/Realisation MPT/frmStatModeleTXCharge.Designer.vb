<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatModeleTXCharge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatModeleTXCharge))
        Dim SideBySideBarSeriesLabel5 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel6 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
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
        Me.GrpChartPourc = New System.Windows.Forms.GroupBox()
        Me.ChartPourc = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblObj = New System.Windows.Forms.Label()
        Me.lblPerim = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoy12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPerimHaut = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnExportXLS = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GrpActions.SuspendLayout()
        Me.GrpGraph.SuspendLayout()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriode.SuspendLayout()
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpChartPourc.SuspendLayout()
        CType(Me.ChartPourc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        resources.ApplyResources(Me.LblTitre, "LblTitre")
        Me.LblTitre.Name = "LblTitre"
        '
        'GrpActions
        '
        Me.GrpActions.Controls.Add(Me.BtnExportXLS)
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
        'GrpGraph
        '
        Me.GrpGraph.Controls.Add(Me.ChartGraph)
        resources.ApplyResources(Me.GrpGraph, "GrpGraph")
        Me.GrpGraph.Name = "GrpGraph"
        Me.GrpGraph.TabStop = False
        '
        'ChartGraph
        '
        resources.ApplyResources(Me.ChartGraph, "ChartGraph")
        Me.ChartGraph.Legend.Name = "Default Legend"
        Me.ChartGraph.Name = "ChartGraph"
        Me.ChartGraph.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel5.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartGraph.SeriesTemplate.Label = SideBySideBarSeriesLabel5
        '
        'GrpPeriode
        '
        Me.GrpPeriode.Controls.Add(Me.Label1)
        Me.GrpPeriode.Controls.Add(Me.LblDateDeb)
        Me.GrpPeriode.Controls.Add(Me.BtnValid)
        Me.GrpPeriode.Controls.Add(Me.DTPFin)
        Me.GrpPeriode.Controls.Add(Me.DTPDebut)
        resources.ApplyResources(Me.GrpPeriode, "GrpPeriode")
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
        Me.GVStat.GridControl = Me.GCStat
        Me.GVStat.Name = "GVStat"
        Me.GVStat.OptionsBehavior.Editable = False
        Me.GVStat.OptionsBehavior.ReadOnly = True
        Me.GVStat.OptionsView.ShowFooter = True
        Me.GVStat.OptionsView.ShowGroupPanel = False
        '
        'GrpChartPourc
        '
        Me.GrpChartPourc.Controls.Add(Me.ChartPourc)
        resources.ApplyResources(Me.GrpChartPourc, "GrpChartPourc")
        Me.GrpChartPourc.Name = "GrpChartPourc"
        Me.GrpChartPourc.TabStop = False
        '
        'ChartPourc
        '
        resources.ApplyResources(Me.ChartPourc, "ChartPourc")
        Me.ChartPourc.Legend.Name = "Default Legend"
        Me.ChartPourc.Name = "ChartPourc"
        Me.ChartPourc.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        SideBySideBarSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartPourc.SeriesTemplate.Label = SideBySideBarSeriesLabel6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblObj)
        Me.GroupBox3.Controls.Add(Me.lblPerim)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblMoy12)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'lblObj
        '
        Me.lblObj.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblObj, "lblObj")
        Me.lblObj.Name = "lblObj"
        '
        'lblPerim
        '
        Me.lblPerim.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerim, "lblPerim")
        Me.lblPerim.ForeColor = System.Drawing.Color.Black
        Me.lblPerim.Name = "lblPerim"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lblMoy12
        '
        Me.lblMoy12.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblMoy12, "lblMoy12")
        Me.lblMoy12.ForeColor = System.Drawing.Color.Black
        Me.lblMoy12.Name = "lblMoy12"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblPerimHaut)
        Me.GroupBox1.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.IndianRed
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'lblPerimHaut
        '
        Me.lblPerimHaut.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.lblPerimHaut, "lblPerimHaut")
        Me.lblPerimHaut.ForeColor = System.Drawing.Color.Black
        Me.lblPerimHaut.Name = "lblPerimHaut"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'BtnExportXLS
        '
        resources.ApplyResources(Me.BtnExportXLS, "BtnExportXLS")
        Me.BtnExportXLS.Name = "BtnExportXLS"
        Me.BtnExportXLS.UseVisualStyleBackColor = True
        '
        'frmStatModeleTXCharge
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpChartPourc)
        Me.Controls.Add(Me.GCStat)
        Me.Controls.Add(Me.GrpPeriode)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.GrpActions)
        Me.Controls.Add(Me.GrpGraph)
        Me.Name = "frmStatModeleTXCharge"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpActions.ResumeLayout(False)
        Me.GrpGraph.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriode.ResumeLayout(False)
        CType(Me.GCStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpChartPourc.ResumeLayout(False)
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPourc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GrpChartPourc As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblObj As System.Windows.Forms.Label
    Friend WithEvents lblPerim As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMoy12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPerimHaut As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents GCStat As DevExpress.XtraGrid.GridControl
    Private WithEvents GVStat As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents ChartGraph As DevExpress.XtraCharts.ChartControl
    Private WithEvents ChartPourc As DevExpress.XtraCharts.ChartControl
    Friend WithEvents BtnExportXLS As Button
    Friend WithEvents SFD As SaveFileDialog
End Class
