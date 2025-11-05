Imports System.Data.SqlClient
Imports MozartLib

' Charge en mémoire les droits d'accès pour l'utilisateur courant
Public Class CDroits

  Private mListeDroits As Hashtable

  Public Sub New()
    Dim sqlcmdaccess As SqlCommand
    Dim draccess As SqlDataReader
    Dim lVal As Int16
    Dim lStr As String

    Try
      mListeDroits = New Hashtable()

      lStr = $"SELECT CDROITVAL, NMENUNUM FROM TDROIT WHERE NPERNUM = {MozartParams.UID} AND VSOCIETE = '{MozartParams.NomSociete}'"
      sqlcmdaccess = New SqlCommand(lStr, MozartDatabase.cnxMozart)
      draccess = sqlcmdaccess.ExecuteReader

      While draccess.Read()
        If draccess.Item("CDROITVAL") = "O" Then
          lVal = 1
        Else
          lVal = 0
        End If

        mListeDroits.Add(draccess.Item("NMENUNUM").ToString(), lVal)
      End While

      sqlcmdaccess.Dispose()
      If draccess IsNot Nothing Then draccess.Close()
    Catch ex As Exception
    End Try
  End Sub

  ' Permet de savoir si la personne connectée a les droits sur le menu N° p_iNmenunum
  Public Function getRight(ByVal p_iNmenunum As String) As Int16
    Dim bAccessComponent As Int16

    If Not IsNumeric(p_iNmenunum) Then p_iNmenunum = 0

    If p_iNmenunum <> "" Then
      If mListeDroits.ContainsKey(p_iNmenunum) Then
        bAccessComponent = mListeDroits.Item(p_iNmenunum)
      Else
        bAccessComponent = 2
      End If
    Else
      bAccessComponent = -1
    End If

    Return bAccessComponent
  End Function

End Class
