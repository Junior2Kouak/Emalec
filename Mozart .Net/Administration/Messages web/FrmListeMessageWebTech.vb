Imports System.Data.SqlClient
Imports MozartLib

Public Class FrmListeMessageWebTech


  Dim oSqlConn As New CGestionSQL
  Dim dtListe As DataTable
  Dim sRequete As String = "api_sp_ListeMessWebTech"


  Public Sub New()

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

  End Sub

  Private Sub FrmListeMessageWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    If oSqlConn.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
      Initboutons(Me)
      LoadListe()
    End If
  End Sub

  Private Sub FrmListeMessageWeb_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    oSqlConn.CloseConnexionSQL()
  End Sub

  Private Sub LoadListe()

    Try
      dtListe = New DataTable
      dtListe = ModDataGridView.LoadList(sRequete, oSqlConn.CnxSQLOpen)
      GCListeMess.DataSource = dtListe

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub BtnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupprimer.Click

    Try

      If dtListe.Rows.Count = 0 Then
        Return
      End If

      If GVlisteMess.SelectedRowsCount < 0 Then
        MessageBox.Show(My.Resources.Global_selectionner_une_ligne, My.Resources.Global_suppresion_message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return
      End If

      ''mise à jour de la datatable
      If MessageBox.Show(My.Resources.Global_supression_ligne, My.Resources.Global_confirmation_suppression, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        ' suppression dans le tableau
        Dim IDligne As Integer = GVlisteMess.GetDataRow(GVlisteMess.GetSelectedRows(0)).Item("NPERNUM")
        dtListe.Select("NPERNUM=" + IDligne.ToString)(0).Delete()
        ' suppression dans la base
        Dim sqlcmdSupprLigne As New SqlCommand("delete from TPERMESSWEB where NPERNUM = " & IDligne, oSqlConn.CnxSQLOpen)
        sqlcmdSupprLigne.CommandType = CommandType.Text
        sqlcmdSupprLigne.ExecuteNonQuery()

      End If

    Catch ex As Exception

      MessageBox.Show(ex.Message)

    End Try

  End Sub

  Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
    Me.Close()
  End Sub

  Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click

    'Dim oFrmGestMessage As New FrmDetailMessageWebTech("C", GVlisteMess.GetDataRow(GVlisteMess.GetSelectedRows(0)).Item("NPERNUM"))
    'oFrmGestMessage.ShowDialog()

    Dim oFrmGestMessage As New FrmDetailMessageWeb("O", GVlisteMess.GetDataRow(GVlisteMess.GetSelectedRows(0)).Item("NPERNUM"))
    oFrmGestMessage.ShowDialog()

    dtListe.Clear()
    dtListe = ModDataGridView.LoadList(sRequete, oSqlConn.CnxSQLOpen)
    GCListeMess.DataSource = dtListe

  End Sub

End Class