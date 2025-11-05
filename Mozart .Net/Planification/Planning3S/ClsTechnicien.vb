Public Class ClsTechnicien

    Public INDEX As Integer
    Public NPERNUM As Integer
    Public VPERNOM As String
    Public VSERLIB As String
    Public VPERPERMI As String
    Public VREGLIB As String
    Public NSERNUM As Integer
    Public NREGROUPREG As Integer
    Public CPERTYP As String
    Public NREGCOD As Integer
    Public NBH_SEM1 As Decimal
    Public NBH_SEM2 As Decimal
    Public NBH_SEM3 As Decimal
    Public bCalculDist As Boolean
    Public NKM_SEM1 As Integer
    Public NKM_SEM2 As Integer
    Public NKM_SEM3 As Integer
    Public TCOMPETENCES As String
    Public LAT As Double
    Public LON As Double
    Public VTUTEUR As String
    Public VTYPEDETAILLIB As String
    Public VPERTYPEPOSTE As String
    Public VSITNOM_POSTE As String
    Public VCLINOM_POSTE As String
    Public CPERTYPDETAIL As String

    Sub New(ByVal lIndex As Integer, ByVal Nom As String, ByVal num As Integer)
        INDEX = lIndex
        VPERNOM = Nom
        NPERNUM = num
    End Sub

    Public Overrides Function ToString() As String
        Return VPERNOM
    End Function

End Class
