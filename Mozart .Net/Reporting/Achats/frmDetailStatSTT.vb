Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailStatSTT

  Dim CnxAux As New CGestionSQL
  Dim strParam As String
  Dim ds As DataSet
  Dim bAllPer As Byte

  'constructeur de la classe avec 1 paramtres
  Public Sub New(ByVal p_Param As Object, ByVal c_AllPer As Object)
    InitializeComponent()
    strParam = p_Param
    bAllPer = Convert.ToByte(c_AllPer)
  End Sub

  Private Sub frmDetailStatSTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If CnxAux.ConnexionSQL(MozartParams.NomServeur, MozartParams.NomSociete) = True Then
        LoadDataGridView()
      Else
        MessageBox.Show("Connexion au serveur impossible, contactez le service informatique EMALEC", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show("Sub frmDetailStatSTT_Load dans frmDetailStatSTT : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Loadcolonne()
    Try

    Catch ex As Exception
      MessageBox.Show("Sub LoadDataGridView dans frmDetailStatSTT : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub LoadDataGridView()

    Try

      Me.Cursor = Cursors.WaitCursor
      ds = New DataSet

      Dim Param = Split(strParam, "/")
      Dim cmdLoadList As New SqlCommand("api_sp_StatDetailPrixSTT", CnxAux.CnxSQLOpen)
      cmdLoadList.CommandType = CommandType.StoredProcedure
      cmdLoadList.Parameters.Add("@iAnnee", SqlDbType.Int).Value = Param(0)
      cmdLoadList.Parameters.Add("@iMois", SqlDbType.Int).Value = Param(1)
      cmdLoadList.Parameters.Add("@Type", SqlDbType.VarChar).Value = Param(2)
      cmdLoadList.Parameters.Add("@all_per", SqlDbType.Bit).Value = bAllPer

      Dim sqlAdpat As SqlDataAdapter = New SqlDataAdapter(cmdLoadList)
      sqlAdpat.Fill(ds)

      GCFORMATION.DataSource = ds.Tables(0)

    Catch ex As Exception
      MessageBox.Show("Sub LoadDataGridView dans frmDetailStatSTT : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.Cursor = Cursors.Default
    End Try
  End Sub

  Private Sub GVFORMATION_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GVFORMATION.CustomUnboundColumnData
    Dim view = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
    If e.Column.FieldName = "ColSum" And e.IsGetData Then
      e.Value = getTotalValue(view, e.ListSourceRowIndex)
    End If
  End Sub

  ' Returns the total amount for a specific row.
  Private Function getTotalValue(view As DevExpress.XtraGrid.Views.Grid.GridView, listSourceRowIndex As Integer) As Decimal
    Dim row As System.Data.DataRow = view.GetDataRow(listSourceRowIndex)
    If row.Item(6) <> 0 And Not IsNothing(row.Item(6)) Then
      Return CInt(row.Item(5)) * row.Item(6)
    Else
      Return 0
    End If
  End Function

  Private Sub BtnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuit.Click
    Me.Close()
  End Sub

End Class
