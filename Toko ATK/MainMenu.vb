Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Barang.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Transaksi.Show()
    End Sub
End Class