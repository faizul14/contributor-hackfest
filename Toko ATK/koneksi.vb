Imports System.Data.OleDb

Module koneksi

    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public Str As String

    Public Sub Connection()
        Str = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\DatabaseATK.accdb"
        Conn = New OleDbConnection(Str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

    End Sub

End Module
