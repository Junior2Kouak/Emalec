Imports MozartLib

Public Class CPiecesJointes

  Dim _DtPJ As DataTable

  Public ReadOnly Property DtPJ As DataTable
    Get
      Return _DtPJ
    End Get
  End Property

  Public Sub New()

    _DtPJ = New DataTable

    _DtPJ.Columns.Add("VFILENAME", GetType(String))
    _DtPJ.Columns.Add("VPATHFILE", GetType(String))

  End Sub

  Public Sub AddPJ(ByVal p_FileName As String, ByVal p_pathFile As String)

    'on recherche si ily a deja le meme path file

    'on recherche si le fichier existe

    Dim DrNew As DataRow = _DtPJ.NewRow

    DrNew.Item("VFILENAME") = p_FileName
    DrNew.Item("VPATHFILE") = p_pathFile

    _DtPJ.Rows.Add(DrNew)

  End Sub

  Public Sub DelPJ()

    '_DtPJ.Rows.Remove()

  End Sub

  Public Function DtPJToString() As String

    Dim ListePJ As String = ""

    If Not _DtPJ Is Nothing Then

      For Each drPJ As DataRow In _DtPJ.Rows

        If File.Exists(drPJ.Item("VPATHFILE")) Then
          File.Copy(drPJ.Item("VPATHFILE"), "\\" & MozartParams.NomServeur & "\PJMAIL\" & drPJ.Item("VFILENAME"), True)
        End If
        ListePJ = ListePJ & "\\" & MozartParams.NomServeur & "\PJMAIL\" & drPJ.Item("VFILENAME") & ";"

      Next

    End If

    'on retire le dernier ;
    If ListePJ.Substring(ListePJ.Length - 1, 1) = ";" Then ListePJ = ListePJ.Substring(0, ListePJ.Length - 1)

    Return ListePJ

  End Function

End Class
