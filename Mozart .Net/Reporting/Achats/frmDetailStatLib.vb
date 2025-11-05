Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailStatLib

  Dim CnxAux As New CGestionSQL
  Dim strParam As String
  Dim ds As DataSet
  Dim bAllPer As Byte

  'constructeur de la classe avec 1 paramtres
  Public Sub New(ByVal p_Param As Object, ByVal c_AllPer As Object)
    InitializeComponent()
    strParam = p_Param
    bAllPer = c_AllPer
  End Sub

  Private Sub frmDetailStatLib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        LoadDataGridView()
      Else
        MessageBox.Show(My.Resources.Global_serveur_EMALEC, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmDetailStatlib_SubLoad + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Loadcolonne()
    Try

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmDetailStatlib_SubLoadData + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub LoadDataGridView()

    Try
      Me.Cursor = Cursors.WaitCursor
      ds = New DataSet

      Dim Param = Split(strParam, "/")

      Dim cmdLoadList As New SqlCommand("api_sp_StatDetailLibelleFou", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@iAnnee", SqlDbType.Int).Value = Param(0)
      cmdLoadList.Parameters.Add("@iMois", SqlDbType.Int).Value = Param(1)
      cmdLoadList.Parameters.Add("@all_per", SqlDbType.Bit).Value = bAllPer

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCFORMATION.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_achat_frmDetailStatlib_SubLoadData + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub
End Class

