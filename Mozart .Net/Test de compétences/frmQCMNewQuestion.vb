Public Class frmQCMNewQuestion

    Dim sLibQuestion As String = ""

    Public Property p_sLibQuestion As String
        Get
            Return sLibQuestion
        End Get
        Set(ByVal value As String)
            If sLibQuestion = Value Then
                Return
            End If
            sLibQuestion = Value
        End Set
    End Property

    Private Sub frmQCMNewQuestion_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

        If sLibQuestion <> ""   Then
            GrpBxNewQuestion.Text = My.Resources.TestCompétance_QCMListeResultByQCMCandidat_modif
        End If
        
        TxtNewQuestion.Text = sLibQuestion

    End Sub

    Private Sub BtnEnregistrer_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnEnregistrer.Click

        If TxtNewQuestion.Text.Equals("")   Then
            MessageBox.Show(My.Resources.TestCompétance_QCMListeResultByQCMCandidat_saisr_quest, My.Resources.TestCompétance_QCMListeResultByQCMCandidat_erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            sLibQuestion = TxtNewQuestion.Text
            Me.Close
        End If

    End Sub
    
    Private Sub BtnCancel_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close 
    End Sub

End Class