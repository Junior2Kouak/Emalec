Public Class apiLabel
  Inherits Windows.Forms.Label

  Private _HelpContextID As Integer

  Property HelpContextID As Integer
    Get
      HelpContextID = _HelpContextID
    End Get
    Set(value As Integer)
      _HelpContextID = value
    End Set
  End Property

End Class
