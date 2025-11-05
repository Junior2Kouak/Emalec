Imports System.Data.SqlClient
Imports MozartLib

Public Class CCompteAna

  Dim _dtCptAna As DataTable
  Dim _dtCptAnaAffect As DataTable

  Dim _nomsociete As String

  Public Property dtCptAna As DataTable
    Get
      dtCptAna = _dtCptAna
    End Get
    Set(value As DataTable)
      _dtCptAna = value
    End Set
  End Property

  Public ReadOnly Property dtCptAnaAffect As DataTable
    Get
      dtCptAnaAffect = _dtCptAnaAffect
    End Get
  End Property

  Public Sub New(ByVal c_nomsociete As String)

    _dtCptAna = New DataTable
    _nomsociete = c_nomsociete

  End Sub

  Public Sub LoadComptesAna(ByVal p_NCANNUM_Actif As String)
    _dtCptAna = New DataTable

    Dim lStrReq As String = "SELECT NCANNUM, VCANLIB, VTYPECTE, NRFAPOURC, VSOCIETE, VTYPEMBE, TREF_TYPECTE.CTYPECTE AS CTYPECTE, DDATCREE FROM TREF_CTEANA WITH (NOLOCK) INNER JOIN "
    lStrReq += " TREF_TYPECTE WITH (NOLOCK) ON TREF_CTEANA.CTYPECTE=TREF_TYPECTE.CTYPECTE "
    lStrReq += String.Format("WHERE VSOCIETE = '{0}' AND CCTEANAACTIF = '{1}' ORDER BY NCANNUM", _nomsociete, p_NCANNUM_Actif)

    Dim sqlcmd As New SqlCommand(lStrReq, MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text

    _dtCptAna.Load(sqlcmd.ExecuteReader())
  End Sub

  Public Function LoadComptesAnaAffect(ByVal p_NCANNUM As Int32) As DataTable

        _dtCptAnaAffect = New DataTable

    Dim sqlcmd As New SqlCommand("api_sp_ListeAffectationPersByCompteAnalytique", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = p_NCANNUM
        sqlcmd.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = _nomsociete

        _dtCptAnaAffect.Load(sqlcmd.ExecuteReader())
        _dtCptAnaAffect.Columns("CHECK").ReadOnly = False

        Return _dtCptAnaAffect

    End Function

  Public Sub SaveCompteAna(ByVal p_iMode As Byte, ByVal p_NCANNUM As Int32, ByVal p_VCANLIB As String, ByVal p_CTypeCpt As String, ByVal p_NFRAPOURC As String, ByVal p_VTYPEMBE As String)

    If p_iMode = 0 And IsDoublonNCANNUM(p_NCANNUM) > 0 Then
      MessageBox.Show(String.Format("Enregistrement du compte {0} - {1} impossible !" & vbCrLf & "Ce N° de compte existe déjà.", p_NCANNUM, p_VCANLIB), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
    End If


    Dim sqlcmdCreate As New SqlCommand("api_sp_CreationCompteAnalytique", MozartDatabase.cnxMozart)
    sqlcmdCreate.CommandType = CommandType.StoredProcedure

    sqlcmdCreate.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = p_NCANNUM
    sqlcmdCreate.Parameters.Add("@P_VCANLIB", SqlDbType.VarChar).Value = p_VCANLIB
    sqlcmdCreate.Parameters.Add("@P_CTYPECTE", SqlDbType.Char).Value = p_CTypeCpt
    sqlcmdCreate.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = _nomsociete
    sqlcmdCreate.Parameters.Add("@P_NRFAPOURC", SqlDbType.Decimal).Value = If(p_NFRAPOURC = "", DBNull.Value, p_NFRAPOURC.Replace(".", ","))
    sqlcmdCreate.Parameters.Add("@P_VTYPEMBE", SqlDbType.VarChar).Value = p_VTYPEMBE

    sqlcmdCreate.ExecuteNonQuery()

  End Sub

  Public Sub ModifEtatCompteAna(ByVal p_NCANNUM As Int32, ByVal p_EtatCpte As String)

    Dim sqlcmdCreate As New SqlCommand("api_sp_EtatCompteAnalytique", MozartDatabase.cnxMozart)
    sqlcmdCreate.CommandType = CommandType.StoredProcedure

        sqlcmdCreate.Parameters.Add("@P_NCANNUM", SqlDbType.Int).Value = p_NCANNUM
        sqlcmdCreate.Parameters.Add("@P_CCTEANAACTIF", SqlDbType.Char).Value = p_EtatCpte
        sqlcmdCreate.Parameters.Add("@P_VSOCIETE", SqlDbType.VarChar).Value = _nomsociete

        sqlcmdCreate.ExecuteNonQuery()

    End Sub

    Private Function IsDoublonNCANNUM(ByVal p_NCANNUM As Int32) As Int32

        Try

      Dim sqlcmdVerif As New SqlCommand(String.Format("SELECT COUNT(NCANNUM) AS NBCPT FROM TREF_CTEANA WITH (NOLOCK) WHERE NCANNUM = {0} AND VSOCIETE = '{1}'", p_NCANNUM, _nomsociete), MozartDatabase.cnxMozart)
      sqlcmdVerif.CommandType = CommandType.Text
            Return sqlcmdVerif.ExecuteScalar

        Catch ex As Exception

            MessageBox.Show("CCompteAna dans IsDoublonNCANNUM() : " + ex.Message)
            Return 1

        End Try

    End Function

    Public Sub SaveListPersByComtpeAna(ByVal p_NCANNUM As Int32)

        Try

            If Not _dtCptAnaAffect Is Nothing AndAlso Not _dtCptAnaAffect.GetChanges(DataRowState.Modified) Is Nothing Then

                For Each oDtrSave As DataRow In _dtCptAnaAffect.GetChanges(DataRowState.Modified).Rows

                    Dim dtQCMInit As DataTable = LoadComptesAnaAffect(p_NCANNUM)

                    If oDtrSave.Item("CHECK") = 1 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NPERNUM = {0}", oDtrSave.Item("NPERNUM")))(0).Item("CHECK") Then

                        AffecterCompteAna(oDtrSave.Item("NPERNUM"), p_NCANNUM)

                    ElseIf oDtrSave.Item("CHECK") = 0 And oDtrSave.Item("CHECK") <> dtQCMInit.Select(String.Format("NPERNUM = {0}", oDtrSave.Item("NPERNUM")))(0).Item("CHECK") Then

                        NotAffecterCompteAna(oDtrSave.Item("NPERNUM"), p_NCANNUM)

                    End If

                Next

            End If

        Catch ex As Exception

            MessageBox.Show("CCompteAna dans SaveListPersByComtpeAna : " + ex.Message)

        End Try

    End Sub

    Private Sub AffecterCompteAna(ByVal P_NPERNUM As Int32, ByVal P_NCANNUM As Int32)

        Try

            Dim sqlcmdAffectCptAna As New SqlCommand("api_sp_CompteAnalytiqueAffectPers", MozartDatabase.cnxMozart)
            sqlcmdAffectCptAna.CommandType = CommandType.StoredProcedure

            sqlcmdAffectCptAna.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
            sqlcmdAffectCptAna.Parameters("@P_NPERNUM").Value = P_NPERNUM

            sqlcmdAffectCptAna.Parameters.Add("@P_NCANNUM", SqlDbType.Int)
            sqlcmdAffectCptAna.Parameters("@P_NCANNUM").Value = P_NCANNUM

            sqlcmdAffectCptAna.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("CCompteAna dans AffecterCompteAna : " + ex.Message)

        End Try

    End Sub

    Private Sub NotAffecterCompteAna(ByVal P_NPERNUM As Int32, ByVal P_NCANNUM As Int32)

        Try

            Dim sqlcmdNotAffectCptAna As New SqlCommand("api_sp_CompteAnalytiqueNotAffectPers", MozartDatabase.cnxMozart)
            sqlcmdNotAffectCptAna.CommandType = CommandType.StoredProcedure

            sqlcmdNotAffectCptAna.Parameters.Add("@P_NPERNUM", SqlDbType.Int)
            sqlcmdNotAffectCptAna.Parameters("@P_NPERNUM").Value = P_NPERNUM

            sqlcmdNotAffectCptAna.Parameters.Add("@P_NCANNUM", SqlDbType.Int)
            sqlcmdNotAffectCptAna.Parameters("@P_NCANNUM").Value = P_NCANNUM

            sqlcmdNotAffectCptAna.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("CCompteAna dans NotAffecterCompteAna : " + ex.Message)

        End Try

    End Sub

End Class
