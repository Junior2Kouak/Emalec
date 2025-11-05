Imports MozartLib

Public Class frmStatSyntContreMaitre

  Dim oGestCnx As CGestionSQL

  Dim DtTot As DataTable

  Dim datedebut As Date
  Dim datefin As Date

  Public Sub New(ByVal c_datedebut As Date, ByVal c_datefin As Date)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    datedebut = c_datedebut
    datefin = c_datefin

  End Sub

  Private Sub frmStatSyntContreMaitre_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oGestCnx.CloseConnexionSQL()
    Me.Cursor = Cursors.Default
  End Sub

  Private Sub frmStatSyntContreMaitre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    oGestCnx = New CGestionSQL

    'init
    ' fonction de recherche des heures de références
    LblHrRef.Text = My.Resources.Global_HeuresRef & RechercheHeureRef(datedebut, datefin)
    LblPeriode.Text = String.Format(My.Resources.Global_periode_0_1, datedebut.ToShortDateString, datefin.ToShortDateString)

    'on ouvre la connexion
    If oGestCnx.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      Me.Cursor = Cursors.WaitCursor
      LoadStatTot()
      Me.Cursor = Cursors.Default
    End If

  End Sub

  Private Sub LoadStatTot()

    DtTot = New DataTable

    DtTot = LoadList(String.Format("exec api_sp_StatistiqueContremaitre '{0}', '{1}'", datedebut, datefin), oGestCnx.CnxSQLOpen)

    GCStatTot.DataSource = DtTot

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
    Dim oScreenShot As New CSreenShot(Me, True)
    oScreenShot.Print_Form()
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

End Class