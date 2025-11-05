Imports DevExpress.Utils
Imports MozartLib

Public Class frmStatHeureTech

  Dim oGestCnx As CGestionSQL

  Dim DtTot As DataTable
  Dim DtDet As DataTable
  Dim DtSem As DataTable
  Dim DtAnnee As DataTable

  Dim sType As String
  Dim datedebut As Date
  Dim datefin As Date

  Private toolTipController As New ToolTipController()

  Public Sub New(ByVal c_sType As String, ByVal c_datedebut As Date, ByVal c_datefin As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    sType = c_sType
    datedebut = c_datedebut
    datefin = c_datefin

  End Sub

  Private Sub frmStatHeureTech_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestCnx.CloseConnexionSQL()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmStatHeureTech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    oGestCnx = New CGestionSQL

    LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)

    If sType = "C" Then
      LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatHeureTech_moy
    Else
      LblTitre.Text = My.Resources.Reporting_RealisationMPT_frmStatHeureTech_heures
    End If


    ' fonction de recherche des heures de références
    LblHRRef.Text = My.Resources.Global_HeuresRef & RechercheHeureRef(datedebut, datefin)

    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then

      Me.Cursor = Cursors.WaitCursor

      LoadStatTot()

      Me.Cursor = Cursors.Default

    End If

  End Sub

  Private Sub LoadStatTot()

    Dim sSql As String

    DtTot = New DataTable

    sSql = String.Format("exec api_sp_StatistiqueHeureTech '{0}', '{1}', '{2}'", datedebut, datefin, sType)

    DtTot = LoadList(sSql, oGestCnx.CnxSQLOpen)

    GCStatTot.DataSource = DtTot

    ChartTot.DataSource = GCStatTot.DataSource

    ChartTot.Series(0).CrosshairLabelPattern = My.Resources.Global_techA & vbCrLf & My.Resources.Reporting_RealisationMPT_frmStatHeureTech_heuresV

  End Sub

  Private Sub LoadStatDetAndSemAndAnnee(ByVal p_NPERNUM As Int32)
    DtDet = New DataTable
    DtDet = LoadList(String.Format("exec api_sp_StatDetailHeureTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCDetail.DataSource = DtDet

    DtSem = New DataTable
    DtSem = LoadList(String.Format("exec api_sp_StatCumulHeureJourTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCSem.DataSource = DtSem

    DtAnnee = New DataTable
    DtAnnee = LoadList(String.Format("exec api_sp_StatCumulHeureSemaineTech {0}, '{1}', '{2}', '{3}'", p_NPERNUM, datedebut, datefin, sType), oGestCnx.CnxSQLOpen)
    GCAnnee.DataSource = DtAnnee

  End Sub

  Private Sub GVStatTot_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVStatTot.FocusedRowChanged

    'e.FocusedRowHandle
    Dim odr As DataRow = GVStatTot.GetDataRow(e.FocusedRowHandle)

    If Not odr Is Nothing Then

      LoadStatDetAndSemAndAnnee(odr.Item("NPERNUM"))

    End If

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim ofrmVisuFic As New frmVisuDoc(GenerateStat)
    ofrmVisuFic.ShowDialog()
  End Sub

  Private Function RechercheHeureRef(ByVal DateDeb As Date, ByVal DateFin As Date) As Int32

    Try

      Dim DateCourant As Date
      Dim iRechercheHeureRef As Int32 = 0

      ' initialisation
      DateCourant = DateDeb

      While DateCourant <= DateFin
        ' si ce n'est pas un weekend ou un jour fériée on ajout 8 heures
        If DateCourant.DayOfWeek <> 0 And DateCourant.DayOfWeek <> 6 Then
          If Not IsFeriee(DateCourant) Then
            If DateCourant.DayOfWeek = 5 Then
              iRechercheHeureRef = iRechercheHeureRef + 7
            Else
              iRechercheHeureRef = iRechercheHeureRef + 8
            End If
          End If
        End If
        DateCourant = DateAdd("d", 1, DateCourant)
      End While

      Return iRechercheHeureRef

    Catch ex As Exception

      Return 0

    End Try

  End Function

  '********************************************************************************************************************************************************************************
  'generation dun fichier html pour l impression
  '********************************************************************************************************************************************************************************
  Private Function GenerateStat() As String

    Try
      'gstrCheminUtilisateur & "\Mozart\s.html"

      Using sw As StreamWriter = New StreamWriter(MozartParams.CheminUtilisateurMozart & "tmp.html")

        If DtDet.Rows.Count = 0 Then

          sw.WriteLine(My.Resources.Reporting_RealisationMPT_frmStatHeureTech_stat)
          sw.WriteLine(My.Resources.Reporting_RealisationMPT_frmStatHeureTech_aucune_stat)

        Else

          sw.WriteLine(My.Resources.Reporting_RealisationMPT_frmStatHeureTech_stat_client & vbCrLf)
          ' nom du client
          sw.WriteLine("<table border=0 widht=100%><tr>")
          sw.WriteLine("<TD width=10%><b><font face=tahoma size=4>" & MozartParams.NomSociete & "</font></TD>")
          sw.WriteLine("<TD width=10%>&nbsp;</TD>")
          sw.WriteLine("<TD width=80% align=right><b><font face=tahoma size=3>Statistique des heures de " & " 5555" & "</Font></TD>")
          sw.WriteLine("</TR></table>")

          sw.WriteLine("<H3>Période du " & datedebut.ToShortDateString & " au " & datefin.ToShortDateString & " </H3><br>")

          'tableau avec deux tableaux interieur
          sw.WriteLine("<table border=0 cellpadding=0 cellspacing =0 widht=100%><tr>" & vbCrLf)
          sw.WriteLine("<td width=65%>" & vbCrLf)

          ' Tableau des numéros de semaine
          sw.WriteLine("<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>" & vbCrLf)
          sw.WriteLine("<td width=10% bgcolor=#FCFECF><font face=tahoma size=2><b>DI</b></FONT></td>")
          sw.WriteLine("<td width=15% bgcolor=#FCFECF><font face=tahoma size=2><b>Date Ex</b></FONT></td>")
          sw.WriteLine("<td width=15% bgcolor=#FCFECF><font face=tahoma size=2><b>Attach</b></FONT></td>")
          sw.WriteLine("<td width=20% bgcolor=#FCFECF><font face=tahoma size=2><b>Client</b></FONT></td>")
          sw.WriteLine("<td width=30% bgcolor=#FCFECF><font face=tahoma size=2><b>Site</b></FONT></td>")
          sw.WriteLine("<td width=10% bgcolor=#FCFECF><font face=tahoma size=2><b>H</b></FONT></td>")
          sw.WriteLine("</tr>" & vbCrLf)

          For Each dtrow As DataRow In DtDet.Rows

            sw.WriteLine("<tr><td bgcolor=white><font face=Arial size=1>" & dtrow.Item(0) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & dtrow.Item(1) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white><font face=Arial size=1>&nbsp;" & dtrow.Item(2) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & dtrow.Item(3) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & dtrow.Item(4) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white align=center><font face=Arial size=1>&nbsp;" & dtrow.Item(6) & "</FONT></td> ")
            sw.WriteLine("</tr>")

          Next

          sw.WriteLine("</table>")
          sw.WriteLine("</td>" & vbCrLf)

          '***********************************************************************************
          sw.WriteLine("<td width=2% valign=top></TD>" & vbCrLf)
          sw.WriteLine("<td width=20% valign=top>" & vbCrLf)

          ' Tableau des numéros de semaine
          sw.WriteLine("<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>" & vbCrLf)
          sw.WriteLine("<td width=40% bgcolor=#FCFECF><font face=tahoma size=2><b>Date</b></FONT></td>")
          sw.WriteLine("<td width=40% bgcolor=#FCFECF><font face=tahoma size=2><b>Jour</b></FONT></td>")
          sw.WriteLine("<td width=20% bgcolor=#FCFECF><font face=tahoma size=2><b>H</b></FONT></td>")
          sw.WriteLine("</tr>" & vbCrLf)

          For Each drRowSem As DataRow In DtSem.Rows

            ' Site client et planning de ce site
            sw.WriteLine("<tr><td bgcolor=white><font face=Arial size=1>" & drRowSem.Item(0) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white><font face=Arial size=1>" & drRowSem.Item(1) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white align=right><font face=Arial size=1>&nbsp;" & drRowSem.Item(2) & "&nbsp;</FONT></td> ")
            sw.WriteLine("</tr>")

          Next

          sw.WriteLine("</table>")
          sw.WriteLine("</td>" & vbCrLf)

          '***********************************************************************************
          sw.WriteLine("<td width=2% valign=top></TD>" & vbCrLf)
          sw.WriteLine("<td width=15% valign=top>" & vbCrLf)

          ' Tableau des numéros de semaine
          sw.WriteLine("<table border=1 cellpadding=2 cellspacing =0 widht=100%><tr>" & vbCrLf)
          sw.WriteLine("<td width=80% bgcolor=#FCFECF><font face=tahoma size=2><b>N° Sem</b></FONT></td>")
          sw.WriteLine("<td width=20% bgcolor=#FCFECF><font face=tahoma size=2><b>H</b></FONT></td>")

          sw.WriteLine("</tr>" & vbCrLf)

          For Each dtRowAnnee As DataRow In DtAnnee.Rows

            ' Site client et planning de ce site
            sw.WriteLine("<tr><td bgcolor=white><font face=Arial size=1>" & dtRowAnnee.Item(0) & "</FONT></td> ")
            sw.WriteLine("<td bgcolor=white align=right><font face=Arial size=1>&nbsp;" & dtRowAnnee.Item(1) & "&nbsp;</FONT></td> ")

            sw.WriteLine("</tr>")

          Next

          sw.WriteLine("</table>")

          sw.WriteLine("</td></tr></table>")

          sw.WriteLine("</body></html>")

        End If

        sw.Close()

      End Using

      Return MozartParams.CheminUtilisateurMozart & "tmp.html"

    Catch ex As Exception

      Return ""

    End Try

  End Function

  Private Sub BtnGraphTech_Click(sender As System.Object, e As System.EventArgs) Handles BtnGraphTech.Click

    If GVStatTot.SelectedRowsCount > 0 Then

      Dim odr As DataRow = GVStatTot.GetDataRow(GVStatTot.GetSelectedRows(0))

      If Not odr Is Nothing Then

        Dim oFrmGraphTech As New frmStatGraphTech(oGestCnx, odr.Item("NPERNUM"), odr.Item("VPERNOM"), datedebut, datefin, sType)
        oFrmGraphTech.ShowDialog()

      End If

    End If

  End Sub


End Class