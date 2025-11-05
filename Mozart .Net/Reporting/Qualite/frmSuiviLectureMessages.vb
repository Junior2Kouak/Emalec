Imports MozartLib

Public Class frmSuiviLectureMessages

  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable
  Dim sType As String
  Dim sRequete As String


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub frmSuiviLectureMessages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      LoadListe()
    End If
  End Sub

  Private Sub LoadListe()

    Try

      dtListe = New DataTable
      dtListe = ModDataGridView.LoadList("api_sp_ListeSuiviMessagesEmalec", oSqlConn.CnxSQLOpen)
      GCListeFouEI.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub FrmListeMessageWeb_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    oSqlConn.CloseConnexionSQL()
  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

End Class