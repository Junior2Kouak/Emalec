Public Class frmListeTechs

    Public NbTechsMax As Integer
    Dim AllTechs As New Collection

    Dim _returnTechs As Collection

    Public ReadOnly Property returnTechs As Collection
        Get
            returnTechs = _returnTechs
        End Get
    End Property

    Private Sub frmListeTechs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AllTechs = GetTechniciens(lstTechs, "Listbox", "LISTE")
        Label2.Text = Label2.Text.Replace("$Nb", NbTechsMax.ToString())

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        If lstTechs.SelectedItems.Count > 0 Then
            Try

                _returnTechs = New Collection

                For s As Integer = 0 To Math.Min(NbTechsMax, lstTechs.CheckedItems.Count - 1)
                    _returnTechs.Add(AllTechs(lstTechs.CheckedIndices(s) + 1))
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & vbCrLf & My.Resources.Global_dans & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End If

    End Sub


End Class