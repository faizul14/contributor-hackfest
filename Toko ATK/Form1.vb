Imports System.Data.OleDb


Public Class login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If txtusername.Text = "" Then
            MsgBox("username tidak boleh kosong")
            txtusername.Focus()
            Exit Sub

        ElseIf txtpassword.Text = "" Then
            MsgBox("password tidak boleh kosong")
            txtpassword.Focus()
            Exit Sub

        End If

        Connection()

        Str = “Select * From Admin where username= '" & txtusername.Text & “' And password = '” & txtpassword.Text & "'"
        cmd = New OleDbCommand(Str, Conn)
        rd = cmd.ExecuteReader

        If rd.Read Then
            MsgBox(“Login berhasil”)
            Me.Hide()
            MainMenu.Show()

        Else
            MsgBox(“Password atau username yang anda masukkan salah”)
            txtpassword.Clear()
            txtusername.Clear()
            txtusername.Focus()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        txtpassword.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.Text = ""
        txtusername.Text = ""

    End Sub
End Class
