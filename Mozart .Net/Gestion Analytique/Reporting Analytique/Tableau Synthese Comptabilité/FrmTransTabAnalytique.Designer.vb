<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransTabAnalytique
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransTabAnalytique))
        Me.bgwDesign = New System.ComponentModel.BackgroundWorker()
        Me.GrpSyntheseAna = New System.Windows.Forms.GroupBox()
        Me.GrpDepenseAna = New System.Windows.Forms.GroupBox()
        Me.GrpProgressBarDep = New System.Windows.Forms.GroupBox()
        Me.pgbStateDep = New System.Windows.Forms.ProgressBar()
        Me.GrpInfoDep = New System.Windows.Forms.GroupBox()
        Me.LblInfoDep = New System.Windows.Forms.Label()
        Me.BtnValidDep = New System.Windows.Forms.Button()
        Me.GrpBoxTableauAna = New System.Windows.Forms.GroupBox()
        Me.ChkRecalcEncours = New System.Windows.Forms.CheckBox()
        Me.GrpProgressBarTab = New System.Windows.Forms.GroupBox()
        Me.pgbStateTab = New System.Windows.Forms.ProgressBar()
        Me.GrpInfoTab = New System.Windows.Forms.GroupBox()
        Me.LblInfoTab = New System.Windows.Forms.Label()
        Me.BtnValidTab = New System.Windows.Forms.Button()
        Me.lblTitreTab = New System.Windows.Forms.Label()
        Me.DTPButoireAna = New System.Windows.Forms.DateTimePicker()
        Me.GrpSyntheseAna.SuspendLayout()
        Me.GrpDepenseAna.SuspendLayout()
        Me.GrpProgressBarDep.SuspendLayout()
        Me.GrpInfoDep.SuspendLayout()
        Me.GrpBoxTableauAna.SuspendLayout()
        Me.GrpProgressBarTab.SuspendLayout()
        Me.GrpInfoTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgwDesign
        '
        Me.bgwDesign.WorkerReportsProgress = True
        Me.bgwDesign.WorkerSupportsCancellation = True
        '
        'GrpSyntheseAna
        '
        resources.ApplyResources(Me.GrpSyntheseAna, "GrpSyntheseAna")
        Me.GrpSyntheseAna.BackColor = System.Drawing.Color.PeachPuff
        Me.GrpSyntheseAna.Controls.Add(Me.GrpDepenseAna)
        Me.GrpSyntheseAna.Controls.Add(Me.GrpBoxTableauAna)
        Me.GrpSyntheseAna.Controls.Add(Me.lblTitreTab)
        Me.GrpSyntheseAna.Controls.Add(Me.DTPButoireAna)
        Me.GrpSyntheseAna.Name = "GrpSyntheseAna"
        Me.GrpSyntheseAna.TabStop = False
        '
        'GrpDepenseAna
        '
        resources.ApplyResources(Me.GrpDepenseAna, "GrpDepenseAna")
        Me.GrpDepenseAna.Controls.Add(Me.GrpProgressBarDep)
        Me.GrpDepenseAna.Controls.Add(Me.GrpInfoDep)
        Me.GrpDepenseAna.Controls.Add(Me.BtnValidDep)
        Me.GrpDepenseAna.Name = "GrpDepenseAna"
        Me.GrpDepenseAna.TabStop = False
        '
        'GrpProgressBarDep
        '
        resources.ApplyResources(Me.GrpProgressBarDep, "GrpProgressBarDep")
        Me.GrpProgressBarDep.Controls.Add(Me.pgbStateDep)
        Me.GrpProgressBarDep.Name = "GrpProgressBarDep"
        Me.GrpProgressBarDep.TabStop = False
        '
        'pgbStateDep
        '
        resources.ApplyResources(Me.pgbStateDep, "pgbStateDep")
        Me.pgbStateDep.Name = "pgbStateDep"
        '
        'GrpInfoDep
        '
        resources.ApplyResources(Me.GrpInfoDep, "GrpInfoDep")
        Me.GrpInfoDep.Controls.Add(Me.LblInfoDep)
        Me.GrpInfoDep.Name = "GrpInfoDep"
        Me.GrpInfoDep.TabStop = False
        '
        'LblInfoDep
        '
        resources.ApplyResources(Me.LblInfoDep, "LblInfoDep")
        Me.LblInfoDep.Name = "LblInfoDep"
        '
        'BtnValidDep
        '
        resources.ApplyResources(Me.BtnValidDep, "BtnValidDep")
        Me.BtnValidDep.Name = "BtnValidDep"
        Me.BtnValidDep.UseVisualStyleBackColor = True
        '
        'GrpBoxTableauAna
        '
        resources.ApplyResources(Me.GrpBoxTableauAna, "GrpBoxTableauAna")
        Me.GrpBoxTableauAna.Controls.Add(Me.ChkRecalcEncours)
        Me.GrpBoxTableauAna.Controls.Add(Me.GrpProgressBarTab)
        Me.GrpBoxTableauAna.Controls.Add(Me.GrpInfoTab)
        Me.GrpBoxTableauAna.Controls.Add(Me.BtnValidTab)
        Me.GrpBoxTableauAna.Name = "GrpBoxTableauAna"
        Me.GrpBoxTableauAna.TabStop = False
        '
        'ChkRecalcEncours
        '
        resources.ApplyResources(Me.ChkRecalcEncours, "ChkRecalcEncours")
        Me.ChkRecalcEncours.Name = "ChkRecalcEncours"
        Me.ChkRecalcEncours.UseVisualStyleBackColor = True
        '
        'GrpProgressBarTab
        '
        resources.ApplyResources(Me.GrpProgressBarTab, "GrpProgressBarTab")
        Me.GrpProgressBarTab.Controls.Add(Me.pgbStateTab)
        Me.GrpProgressBarTab.Name = "GrpProgressBarTab"
        Me.GrpProgressBarTab.TabStop = False
        '
        'pgbStateTab
        '
        resources.ApplyResources(Me.pgbStateTab, "pgbStateTab")
        Me.pgbStateTab.Name = "pgbStateTab"
        '
        'GrpInfoTab
        '
        resources.ApplyResources(Me.GrpInfoTab, "GrpInfoTab")
        Me.GrpInfoTab.Controls.Add(Me.LblInfoTab)
        Me.GrpInfoTab.Name = "GrpInfoTab"
        Me.GrpInfoTab.TabStop = False
        '
        'LblInfoTab
        '
        resources.ApplyResources(Me.LblInfoTab, "LblInfoTab")
        Me.LblInfoTab.Name = "LblInfoTab"
        '
        'BtnValidTab
        '
        resources.ApplyResources(Me.BtnValidTab, "BtnValidTab")
        Me.BtnValidTab.Name = "BtnValidTab"
        Me.BtnValidTab.UseVisualStyleBackColor = True
        '
        'lblTitreTab
        '
        resources.ApplyResources(Me.lblTitreTab, "lblTitreTab")
        Me.lblTitreTab.Name = "lblTitreTab"
        '
        'DTPButoireAna
        '
        resources.ApplyResources(Me.DTPButoireAna, "DTPButoireAna")
        Me.DTPButoireAna.Name = "DTPButoireAna"
        '
        'FrmTransTabAnalytique
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.GrpSyntheseAna)
        Me.Name = "FrmTransTabAnalytique"
        Me.GrpSyntheseAna.ResumeLayout(False)
        Me.GrpDepenseAna.ResumeLayout(False)
        Me.GrpProgressBarDep.ResumeLayout(False)
        Me.GrpInfoDep.ResumeLayout(False)
        Me.GrpBoxTableauAna.ResumeLayout(False)
        Me.GrpBoxTableauAna.PerformLayout()
        Me.GrpProgressBarTab.ResumeLayout(False)
        Me.GrpInfoTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents bgwDesign As System.ComponentModel.BackgroundWorker
    Friend WithEvents GrpSyntheseAna As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitreTab As System.Windows.Forms.Label
    Friend WithEvents DTPButoireAna As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpBoxTableauAna As System.Windows.Forms.GroupBox
    Public WithEvents GrpProgressBarTab As System.Windows.Forms.GroupBox
    Private WithEvents pgbStateTab As System.Windows.Forms.ProgressBar
    Friend WithEvents GrpInfoTab As System.Windows.Forms.GroupBox
    Friend WithEvents LblInfoTab As System.Windows.Forms.Label
    Friend WithEvents BtnValidTab As System.Windows.Forms.Button
    Friend WithEvents GrpDepenseAna As System.Windows.Forms.GroupBox
    Public WithEvents GrpProgressBarDep As System.Windows.Forms.GroupBox
    Private WithEvents pgbStateDep As System.Windows.Forms.ProgressBar
    Friend WithEvents GrpInfoDep As System.Windows.Forms.GroupBox
    Friend WithEvents LblInfoDep As System.Windows.Forms.Label
    Friend WithEvents BtnValidDep As System.Windows.Forms.Button
    Friend WithEvents ChkRecalcEncours As System.Windows.Forms.CheckBox
End Class
