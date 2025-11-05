Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmListeMessageMozart

  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable
  Dim sType As String
  Dim sRequete As String


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub FrmListeMessageMozart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      LoadListe()
    End If
  End Sub

  Private Sub LoadListe()

    Try
      GrpListe.Text = My.Resources.Admin_frmDetailMessageMozart
      Me.Text = My.Resources.Admin_frmDetailMessageMozart

      dtListe = New DataTable
      dtListe = ModDataGridView.LoadList("api_sp_ListeMessagesEmalec", oSqlConn.CnxSQLOpen)
      GCListeFouEI.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BntAjout_Click(sender As System.Object, e As System.EventArgs) Handles BntAjout.Click
    Dim oFrmGestMessage As New FrmDetailMessageMozart(0)
    oFrmGestMessage.ShowDialog()

    LoadListe()
  End Sub

  Private Sub BtnModif_Click(sender As System.Object, e As System.EventArgs) Handles BtnModif.Click

    If GVlisteFouEI.FocusedRowHandle < 0 Then Exit Sub
    Dim oFrmGestMessage As New FrmDetailMessageMozart(GVlisteFouEI.GetDataRow(GVlisteFouEI.GetSelectedRows(0)).Item("NINFONUM"))
    oFrmGestMessage.ShowDialog()

    LoadListe()
  End Sub

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListe.Rows.Count = 0 Then
        Return
      End If

      If GVlisteFouEI.FocusedRowHandle < 0 Then
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supression_ligne, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        ' suppression dans le tableau
        Dim IDligne As Int32 = GVlisteFouEI.GetDataRow(GVlisteFouEI.GetSelectedRows(0)).Item("NINFONUM")
        dtListe.Select("NINFONUM=" + IDligne.ToString)(0).Delete()
        ' suppression dans la base
        Dim sqlcmdSupprLigne As New SqlCommand("delete from TINFO where NINFONUM = " & IDligne, oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

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