Public Class Login
    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        Hide()
        Dim createAccount As New WACDO

        createAccount.ShowDialog()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Dim main As New Forms_Manager
        main.Show()


    End Sub
End Class
