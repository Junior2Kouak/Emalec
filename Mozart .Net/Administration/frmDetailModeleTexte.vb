Imports System.Data.SqlClient
Imports MozartLib

Public Class frmDetailModeleTexte

  Dim NIDMODELTEXT As Integer

  Public Sub New(ByVal c_NIDMODELTEXTFICQCMNUM As Integer)

    ' Cet appel est requis par le concepteur.
    InitializeComponent()

    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
    NIDMODELTEXT = c_NIDMODELTEXTFICQCMNUM

  End Sub

  Private Sub frmDetailModeleTexte_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    Try

      'load des donnees
      OuvertureEnModifcation()

    Catch ex As Exception

      MessageBox.Show(My.Resources.Admin_frmDetailModeleTexte_Load + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnFermer_Click(sender As System.Object, e As System.EventArgs) Handles BtnFermer.Click

    Me.Close()

  End Sub

  Private Sub OuvertureEnModifcation()
    Dim cmdLoadList As New SqlCommand("api_sp_ModeleTexteDetail", MozartDatabase.cnxMozart) With {
      .CommandType = CommandType.StoredProcedure
    }
    'sqlcmd
    cmdLoadList.Parameters.Add("@P_NIDMODELTEXT", SqlDbType.Int)
    cmdLoadList.Parameters("@P_NIDMODELTEXT").Value = NIDMODELTEXT

    Dim sqldr As SqlDataReader = cmdLoadList.ExecuteReader()

    If sqldr.HasRows Then

      sqldr.Read()
      TxtChapitre.Text = sqldr.Item("VCHAPITRE")
      TxtSSChapitre.Text = sqldr.Item("VSSCHAPITRE")
      TxtModelText.Text = sqldr.Item("VTEXTE")

    Else

      TxtChapitre.Text = ""
      TxtSSChapitre.Text = ""
      TxtModelText.Text = ""

    End If
    sqldr.Close()

  End Sub

  Private Sub SaveModelText(ByRef p_NIDMODELTEXT As Int32, ByVal p_VCHAPITRE As String, ByVal p_VSSCHAPITRE As String, ByVal p_VTEXTE As String, ByVal p_NomSociete As String)

    Try

      Dim sqlcmd As New SqlCommand("api_sp_ModeleTexteDetailSave", MozartDatabase.cnxMozart) With {
        .CommandType = CommandType.StoredProcedure
      }
      sqlcmd.Parameters.Add("@P_NIDMODELTEXT", SqlDbType.Int)
      sqlcmd.Parameters("@P_NIDMODELTEXT").Value = p_NIDMODELTEXT
      sqlcmd.Parameters.Add("@P_VCHAPITRE", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VCHAPITRE").Value = p_VCHAPITRE
      sqlcmd.Parameters.Add("@P_VSSCHAPITRE", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VSSCHAPITRE").Value = p_VSSCHAPITRE
      sqlcmd.Parameters.Add("@P_VTEXTE", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VTEXTE").Value = p_VTEXTE
      sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar)
      sqlcmd.Parameters("@P_VSOCIETE").Value = p_NomSociete

      p_NIDMODELTEXT = Convert.ToInt32(sqlcmd.ExecuteScalar)

    Catch ex As Exception

      MessageBox.Show(My.Resources.Admin_frmDetailModeleTexte_Save + ex.Message, My.Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try

  End Sub

  Private Sub BtnSaveCorrect_Click(sender As System.Object, e As System.EventArgs) Handles BtnSaveCorrect.Click

    SaveModelText(NIDMODELTEXT, TxtChapitre.Text, TxtSSChapitre.Text, TxtModelText.Text, MozartParams.NomSociete)

  End Sub

End Class
