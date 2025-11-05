Imports System.Data.SqlClient
Imports MozartLib

Public Class CDictionnaries

  Dim _DictionnaryFile As String
  Dim _GrammarFile As String

  Public ReadOnly Property DictionnaryFile As String
    Get
      Return _DictionnaryFile
    End Get
  End Property

  Public ReadOnly Property GrammarFile As String
    Get
      Return _GrammarFile
    End Get
  End Property

  Public Sub New(ByVal c_Langue As String)

    Dim sPathDictonnary As String = RechercheParam("REP_DICTIONNARY", MozartParams.NomSociete)

    If sPathDictonnary = "" Then Exit Sub

    Select Case c_Langue.ToUpper

      Case "FR"

        _DictionnaryFile = sPathDictonnary & "fr-classique.dic"
        _GrammarFile = sPathDictonnary & "fr-classique.aff"

        If File.Exists(_DictionnaryFile) = False Then
          _DictionnaryFile = ""
        Else
          File.Copy(_DictionnaryFile, Application.StartupPath & "\fr-classique.dic", True)
          _DictionnaryFile = Application.StartupPath & "\fr-classique.dic"
        End If

        If File.Exists(_GrammarFile) = False Then
          _GrammarFile = ""
        Else
          File.Copy(_GrammarFile, Application.StartupPath & "\fr-classique.aff", True)
          _GrammarFile = Application.StartupPath & "\fr-classique.aff"
        End If

      Case Else

        _DictionnaryFile = sPathDictonnary & "fr-classique.dic"
        _GrammarFile = sPathDictonnary & "fr-classique.aff"

        If File.Exists(_DictionnaryFile) = False Then
          _DictionnaryFile = ""
        Else
          File.Copy(_DictionnaryFile, Application.StartupPath & "\fr-classique.dic", True)
          _DictionnaryFile = Application.StartupPath & "\fr-classique.dic"
        End If

        If File.Exists(_GrammarFile) = False Then
          _GrammarFile = ""
        Else
          File.Copy(_GrammarFile, Application.StartupPath & "\fr-classique.aff", True)
          _GrammarFile = Application.StartupPath & "\fr-classique.aff"
        End If

    End Select

  End Sub

End Class
