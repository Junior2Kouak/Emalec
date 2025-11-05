
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraCharts.Printing
Imports System.Data.SqlClient
Imports System.Reflection.MethodBase
Imports MozartLib

Public Class frmDetailReleveCompteur

  Private dtL As DataTable = New DataTable()
  Dim iNSITNUM As Int32
  Dim iNCOMPTNUM As Int32


  Public Sub New(ByVal c_iNSITNUM As Object, ByVal c_iNCOMPTNUM As Object)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    iNSITNUM = Convert.ToInt32(c_iNSITNUM)
    iNCOMPTNUM = Convert.ToInt32(c_iNCOMPTNUM)

  End Sub

  Private Sub frmDetailReleveCompteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    LblTitre.Text = RechercheInfosEntete()

    ModuleMain.Initboutons(Me)

    ChargerListeCompteurs()
    InitApigridSite()

  End Sub

  Private Sub InitApigridSite()

    apiGridSite.AddColumn("Date Relevé", "DINFODATE", 1200)
    apiGridSite.AddColumn("Relevé", "NINFODATA", 1200, "# ### ###")

    apiGridSite.InitColumnList()

  End Sub

  Private Sub ChargerListeCompteurs()

    ' Liste des liaisons de sites
    Dim sSQL As String = $"select	DINFODATE, NINFODATA from	TCOMPTEURDATA where	NCOMPTID={iNCOMPTNUM} order by	DINFODATE desc"

    apiGridSite.LoadData(dtL, MozartDatabase.cnxMozart, sSQL)
    apiGridSite.GridControl.DataSource = dtL

    ' graphique
    Dim oSeries As New Series("SeriesCAN", ViewType.Bar)
    'oSeries.ArgumentScaleType = ScaleType.Qualitative
    oSeries.ArgumentScaleType = ScaleType.DateTime


    oSeries.ArgumentDataMember = "DINFODATE"
    oSeries.ValueScaleType = ScaleType.Numerical
    oSeries.ValueDataMembers.AddRange(New String() {"NINFODATA"})
    oSeries.ShowInLegend = False
    oSeries.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
    oSeries.DataSource = dtL

    ChartGraph.Series.Clear()
    ChartGraph.Series.Add(oSeries)

    With CType(ChartGraph.Diagram, XYDiagram)
      .AxisX.Label.Angle = 30
      .AxisY.Label.TextPattern = "{V:N0}"
      .AxisX.Label.TextPattern = "{A:MM/yy}"
    End With


  End Sub

  Private Function RechercheInfosEntete() As String

    Dim sqlcmd As SqlCommand
    Dim dr As SqlDataReader

    Try
      RechercheInfosEntete = ""
      ' 
      ' recherche si le client est lié a un client pour cette société
      Dim SSQL As String = $"SELECT		VSITNOM, VCOMPTNOM, VINFOLIB 
	      FROM		TSIT INNER JOIN TCOMPTEURSITE S ON S.NSITNUM = TSIT.NSITNUM INNER JOIN
				TREF_INFOTECH R ON R.NINFONUM = S.NINFONUM WHERE	S.NCOMPTID = {iNCOMPTNUM}  AND	R.LANGUE = 'FR'"

      sqlcmd = New SqlCommand(SSQL, MozartDatabase.cnxMozart)
      sqlcmd.CommandType = CommandType.Text
      dr = sqlcmd.ExecuteReader()

      If dr.HasRows Then
        dr.Read()
        RechercheInfosEntete = dr("VINFOLIB") & " pour le site " & dr("VSITNOM") & vbCrLf & " Nom du compteur : " & dr("VCOMPTNOM")
      End If

      dr.Close()
      sqlcmd.Dispose()

    Catch ex As Exception
      RechercheInfosEntete = ""
      MessageBox.Show($"{My.Resources.Global_Erreur} : {ex.Message} {My.Resources.Global_dans} {GetCurrentMethod().Name} ({Me.GetType.Name})",
                          My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try
  End Function

  Private Sub cmdFermer_Click(sender As Object, e As EventArgs) Handles cmdFermer.Click
    Me.Close()
  End Sub



End Class