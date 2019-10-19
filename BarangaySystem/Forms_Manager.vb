Public Class Forms_Manager
    Private Sub btn_Barangay_Click(sender As Object, e As EventArgs) Handles btn_Barangay.Click
        UC_Barangay1.BringToFront()
    End Sub

    Private Sub btn_VAWC_Click(sender As Object, e As EventArgs) Handles btn_VAWC.Click
        UC_VAWC1.BringToFront()

    End Sub

    Private Sub btn_Health_Click(sender As Object, e As EventArgs) Handles btn_Health.Click
        UC_Health1.BringToFront()
    End Sub

    Private Sub btn_SK_Click(sender As Object, e As EventArgs) Handles btn_SK.Click
        UC_Sk1.BringToFront()

    End Sub

    Private Sub btn_Lupon_Click(sender As Object, e As EventArgs) Handles btn_Lupon.Click
        UC_LT1.BringToFront()
    End Sub

    Private Sub btn_Treasury_Click(sender As Object, e As EventArgs) Handles btn_Treasury.Click
        UC_Treasury1.BringToFront()

    End Sub

    Private Sub btn_Senior_Click(sender As Object, e As EventArgs) Handles btn_Senior.Click
        UC_Senior1.BringToFront()

    End Sub
End Class