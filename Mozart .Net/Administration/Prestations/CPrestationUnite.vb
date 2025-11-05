Public Class CPrestationUnite

    Dim _DtListeUnite As DataTable

    Public ReadOnly Property DtListeUnite As DataTable
        Get
            Return _DtListeUnite
        End Get

    End Property

    Public Sub New()

        LoadData()

    End Sub

    Private Sub LoadData()

        _DtListeUnite = New DataTable

        _DtListeUnite.Columns.Add("VUNITE", GetType(String))

        Dim oLstUnite As String() = {"ENS", "KG", "M2", "M3", "ML", "U", "M²/JOUR"}

        For Each oUnite As String In oLstUnite

            Dim oNewRow As DataRow = _DtListeUnite.NewRow()
            oNewRow.Item("VUNITE") = oUnite
            _DtListeUnite.Rows.Add(oNewRow)

        Next

        'Dim sqlcmd As New SqlCommand("SELECT NPREST_TYPE_ID, VPREST_TYPE_LIB FROM TREF_PREST_TYPE WITH (NOLOCK) WHERE BPREST_ACTIF = 1 ORDER BY VPREST_TYPE_LIB", cnx)
        'sqlcmd.CommandType = CommandType.Text
        '_DtListeType.Load(sqlcmd.ExecuteReader())

    End Sub

End Class
