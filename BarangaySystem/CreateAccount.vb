Public Class CreateAccount
    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Hide()
        Dim Login As New Login
        Login.ShowDialog()

    End Sub
End Class