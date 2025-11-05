Imports System.Data.SqlClient
Imports MozartLib

Public Class frmModalStatRHTpsTravMultiJour

  Dim nIPLNUM As Int32
  Dim nACTNUM As Int32
  Dim PaveDateJour As DateTime

  Public Sub New(ByVal c_nIPLNUM As Int32, ByVal c_nACTNUM As Int32, ByVal c_DateJour As DateTime)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    nIPLNUM = c_nIPLNUM
    nACTNUM = c_nACTNUM
    PaveDateJour = c_DateJour

  End Sub

  Private Sub frmModalStatRHTpsTravMultiJour_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'cnx
    Me.Text = String.Concat(My.Resources.Reporting_RH_frmModalStatRHTpsTravMultiJour_HR, PaveDateJour.ToShortDateString)
    GrpBoxPaveJour.Text = String.Concat(My.Resources.Global_journée, PaveDateJour.ToShortDateString)

    Try

      Dim sqlCmdDetail As New SqlCommand("api_sp_StatRHTpsTravReturnMultiJourDetail", MozartDatabase.cnxMozart)
      sqlCmdDetail.CommandType = CommandType.StoredProcedure
      sqlCmdDetail.Parameters.Add("@p_iNIPLNUM", SqlDbType.Int)
      sqlCmdDetail.Parameters("@p_iNIPLNUM").Value = nIPLNUM
      sqlCmdDetail.Parameters.Add("@p_iNACTNUM", SqlDbType.Int)
      sqlCmdDetail.Parameters("@p_iNACTNUM").Value = nACTNUM
      sqlCmdDetail.Parameters.Add("@p_DIPLDATJ", SqlDbType.DateTime)
      sqlCmdDetail.Parameters("@p_DIPLDATJ").Value = PaveDateJour

      Dim sqlread As SqlDataReader = sqlCmdDetail.ExecuteReader

      If sqlread.HasRows = True Then

        sqlread.Read()
        TimeEditArr.EditValue = sqlread.Item("DIPLMULTIARR")
        TimeEditExe.EditValue = sqlread.Item("DIPLMULTIEXE")

      Else

        TimeEditArr.EditValue = PaveDateJour
        TimeEditExe.EditValue = PaveDateJour

      End If

      sqlread.Close()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmModalStatRHTpsTravMultiJour_sub + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub


  Private Sub BtnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValid.Click

    'cnx
    Try

      Dim sqlCmdSaveMulti As New SqlCommand("api_sp_StatRHTpsTravReturnMultiJourSave", MozartDatabase.cnxMozart)
      sqlCmdSaveMulti.CommandType = CommandType.StoredProcedure
      sqlCmdSaveMulti.Parameters.Add("@p_iNIPLNUM", SqlDbType.Int)
      sqlCmdSaveMulti.Parameters("@p_iNIPLNUM").Value = nIPLNUM
      sqlCmdSaveMulti.Parameters.Add("@p_iNACTNUM", SqlDbType.Int)
      sqlCmdSaveMulti.Parameters("@p_iNACTNUM").Value = nACTNUM
      sqlCmdSaveMulti.Parameters.Add("@p_DIPLDATJ", SqlDbType.DateTime)
      sqlCmdSaveMulti.Parameters("@p_DIPLDATJ").Value = PaveDateJour
      sqlCmdSaveMulti.Parameters.Add("@p_DIPLMULTIARR", SqlDbType.DateTime)
      sqlCmdSaveMulti.Parameters("@p_DIPLMULTIARR").Value = TimeEditArr.EditValue
      sqlCmdSaveMulti.Parameters.Add("@p_DIPLMULTIEXE", SqlDbType.DateTime)
      sqlCmdSaveMulti.Parameters("@p_DIPLMULTIEXE").Value = TimeEditExe.EditValue

      sqlCmdSaveMulti.ExecuteNonQuery()

      Me.Close()

    Catch ex As Exception
      MessageBox.Show(My.Resources.Reporting_RH_frmModalStatRHTpsTravMultiJour_sub2 + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

End Class