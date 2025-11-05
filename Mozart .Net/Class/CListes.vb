Imports System.Data.SqlClient
Imports MozartLib
Public Class CListes

  Public Function GetListeClients() As DataTable

    Dim dtListeClients As New DataTable

    Dim sqlcmd As New SqlCommand("SELECT NCLINUM, VCLINOM FROM TCLI WITH (NOLOCK) WHERE VSOCIETE = App_Name() AND CCLIACTIF = 'O' ORDER BY VCLINOM", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
    dtListeClients.Load(sqlcmd.ExecuteReader())

    Return dtListeClients

  End Function

  Public Function GetListeFilialeWithAllInOutDroit() As DataTable

    Dim dtListeClients As New DataTable

    Dim sqlcmd As New SqlCommand("SELECT VSOCIETENOM FROM TSOCIETE WITH (NOLOCK) WHERE VSOCIETEACTIF = 'O' ORDER BY VSOCIETENOM", MozartDatabase.cnxMozart)
    sqlcmd.CommandType = CommandType.Text
        dtListeClients.Load(sqlcmd.ExecuteReader())

        Return dtListeClients

    End Function

End Class
