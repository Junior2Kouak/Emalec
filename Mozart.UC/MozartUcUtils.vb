Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MozartLib

Public Module MozartUcUtils


  Public Function RechercheDroitMenu(ByVal cnx As SqlConnection, ByVal IdPer As Long, ByVal IdMenu As Long) As Boolean

    Try
      Dim cmd As New SqlCommand("Select count(*) from TDROIT WHERE CDROITVAL = 'O' AND NPERNUM=" & IdPer & " AND NMENUNUM=" & IdMenu, cnx)
      Return If(cmd.ExecuteScalar > 0, True, False)

    Catch ex As Exception
      MessageBox.Show(ex.Message & vbCrLf & vbCrLf & "dans : " & System.Reflection.MethodBase.GetCurrentMethod.Name)
      Return False
    End Try

  End Function

  Public Sub SpyLog(ByVal cnx As SqlConnection, sFormText As String, sButtonText As String, sAction As String, ParamArray Vars() As String)
    Dim element
    Dim iRev As Integer

    Dim strNomServeur As String = MozartParams.NomServeur
    Dim strNomSociete As String = MozartParams.NomSociete
    Dim intUID As Integer = MozartParams.UID
    Dim strCheminDeFer As String = MozartParams.CheminDeFer
    Dim longCurrentProcessId As Long = MozartParams.CurrentProcessId

    If sAction = "Entrée" Then
      strCheminDeFer = strCheminDeFer & "\" & Trim(sButtonText)
      strCheminDeFer = Trim(Replace(Replace(strCheminDeFer, strNomServeur, ""), strNomSociete, ""))
      strCheminDeFer = Replace(strCheminDeFer, "    -  ", "")
      If strCheminDeFer = "\" Then strCheminDeFer = "\MOZARIS"
    End If

    Dim sql As String = "Exec api_aa_AddSpyLog " & longCurrentProcessId & ", " & intUID & ", '" & Replace(strCheminDeFer, "'", "''") & "', '" + sAction + "'"
    For Each element In Vars
      sql = sql & ", '" & Replace(Replace(Replace(element, strNomServeur, ""), strNomSociete, ""), "'", "''") & "'"
    Next

    If sAction = "Sortie" Then
      iRev = InStrRev(strCheminDeFer, "\")
      If iRev > 0 Then
        sql += ", '" & Mid(strCheminDeFer, iRev) & "'"
        strCheminDeFer = Mid(strCheminDeFer, 1, iRev - 1)
      End If
    End If

    MozartParams.CheminDeFer = strCheminDeFer

    ' création d'une commande
    Dim cmd As New SqlCommand(sql, MozartDatabase.cnxMozart)
    cmd.ExecuteNonQuery()

  End Sub

End Module
