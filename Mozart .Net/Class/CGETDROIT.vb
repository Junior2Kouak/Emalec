Public Class CGETDROIT

    Dim _bDroit As Boolean
    Dim _sMessageErreur As String

    Public Property bDroit As Boolean
        Get
            bDroit = _bDroit
        End Get
        Set(value As Boolean)
            _bDroit = value
        End Set
    End Property
    Public Property sMessageErreur As String
        Get
            sMessageErreur = _sMessageErreur
        End Get
        Set(value As String)
            _sMessageErreur = value
        End Set
    End Property


    Public Sub New(ByVal c_bDroit As Boolean, ByVal c_sMessageErreur As String)

        _bDroit = c_bDroit
        _sMessageErreur = c_sMessageErreur

    End Sub

End Class
