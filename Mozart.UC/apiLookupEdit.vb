Public Class apiLookupEdit
  Inherits DevExpress.XtraEditors.LookUpEdit

  Public autocomplete As Boolean = True

  Protected Overrides Function FindItem(ByVal text As String, ByVal partialSearch As Boolean, ByVal startIndex As Integer) As Integer
    If autocomplete Then Return MyBase.FindItem(text, partialSearch, startIndex)
    Return -1
  End Function

End Class
