Imports System.Data.OleDb

Public Class Barang
    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblbarang.Refresh()

        Call Connection()
        Call Tampil()

        btnbatal.Enabled = False
        txtnamabarang.Enabled = False
        txtharga.Enabled = False
        txtstok.Enabled = False
        txtidbrg.Enabled = False
        btntambahbrg.Enabled = True
        btnhapus.Enabled = True
        btnedit.Enabled = True

    End Sub


    Sub Tampil()

        da = New OleDbDataAdapter("Select * From Data_Barang", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Data_Barang")
        tblbarang.DataSource = ds.Tables("Data_Barang")
        tblbarang.Columns(0).Width = 100
        tblbarang.Columns(0).DefaultCellStyle.Font = New Font("tahoma", 12)
        tblbarang.Columns(1).Width = 200
        tblbarang.Columns(1).DefaultCellStyle.Font = New Font("tahoma", 12)
        tblbarang.Columns(2).Width = 90
        tblbarang.Columns(2).DefaultCellStyle.Font = New Font("tahoma", 12)
        tblbarang.Columns(3).Width = 85
        tblbarang.Columns(3).DefaultCellStyle.Font = New Font("tahoma", 12)
        tblbarang.Refresh()

    End Sub

    Private Sub btntambahbrg_Click(sender As Object, e As EventArgs) Handles btntambahbrg.Click

        btnbatal.Enabled = True
        txtnamabarang.Enabled = True
        txtharga.Enabled = True
        txtstok.Enabled = True
        txtidbrg.Enabled = True
        txtidbrg.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnkembali.Enabled = False

        Call Connection()

        If txtnamabarang.Text = "" Or txtnamabarang.Text = "" Or txtharga.Text = "" Or txtstok.Text = "" Then
            MsgBox("Silahkan Masukkan Data Yang Ingin Ditambah!", MsgBoxStyle.Information, "Information")
            txtidbrg.Focus()
            Exit Sub

        Else
            Call Connection()
            cmd = New OleDbCommand("Select * From Data_Barang where Id_barang= '" & txtidbrg.Text & "'", Conn)
            rd = cmd.ExecuteReader()
            rd.Read()

            If Not rd.HasRows Then
                Call Connection()

                Dim Simpan As String = "insert into Data_Barang(Id_Barang, Nama_Barang, Harga, Stock) values " &
                    "('" & txtidbrg.Text & "','" & txtnamabarang.Text & "','" & txtharga.Text & "','" & txtstok.Text & "')"
                cmd = New OleDbCommand(Simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!", MsgBoxStyle.Information, "Information")

                txtnamabarang.Text = ""
                txtidbrg.Text = ""
                txtharga.Text = ""
                txtstok.Text = ""
                txtnamabarang.Enabled = False
                txtharga.Enabled = False
                txtstok.Enabled = False
                btnbatal.Enabled = False
                txtidbrg.Enabled = False
                btnhapus.Enabled = True
                btnedit.Enabled = True
                btnkembali.Enabled = True

            Else
                MsgBox("ID Sudah Digunakan", MsgBoxStyle.Information, "Information")
                txtnamabarang.Text = ""
                txtidbrg.Text = ""
                txtharga.Text = ""
                txtstok.Text = ""
                txtnamabarang.Enabled = False
                txtharga.Enabled = False
                txtstok.Enabled = False
                btnbatal.Enabled = False
                txtidbrg.Enabled = False
                btnhapus.Enabled = True
                btnedit.Enabled = True
            End If
            Call Tampil()
        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        btnhapus.Enabled = False
        btnbatal.Enabled = True
        btntambahbrg.Enabled = False
        txtnamabarang.Enabled = True
        txtharga.Enabled = True
        txtstok.Enabled = True
        txtidbrg.Enabled = True
        txtidbrg.Enabled = True
        btnkembali.Enabled = False

        Call Connection()

        If txtidbrg.Text = "" Or txtnamabarang.Text = "" Or txtharga.Text = "" Or txtstok.Text = "" Then
            MsgBox("Silahkan masukkan data yang ingin diubah", MsgBoxStyle.Information, "Information")
            txtidbrg.Focus()
            Exit Sub
        Else
            Call Connection()
            cmd = New OleDbCommand("Select * From Data_Barang where Id_barang= '" & txtidbrg.Text & "'", Conn)
            rd = cmd.ExecuteReader()
            rd.Read()

            If rd.HasRows Then
                Call Connection()

                Dim edit As String = "Update Data_Barang set Nama_Barang='" & txtnamabarang.Text & "',Harga='" & txtharga.Text & "',Stock='" & txtstok.Text & "' where Id_barang='" & txtidbrg.Text & "'"
                cmd = New OleDbCommand(edit, Conn)
                cmd.ExecuteNonQuery()

                MsgBox("Edit Data Sukses!", MsgBoxStyle.Information, "Information")

                txtnamabarang.Text = ""
                txtidbrg.Text = ""
                txtharga.Text = ""
                txtstok.Text = ""
                txtnamabarang.Enabled = False
                txtharga.Enabled = False
                txtstok.Enabled = False
                btnbatal.Enabled = False
                txtidbrg.Enabled = False
                btntambahbrg.Enabled = True
                btnhapus.Enabled = True
                btnkembali.Enabled = True
            Else

                MsgBox("ID Tidak Ditemukan!", MsgBoxStyle.Information, "Information")
                txtnamabarang.Text = ""
                txtidbrg.Text = ""
                txtharga.Text = ""
                txtstok.Text = ""
                txtnamabarang.Enabled = False
                txtharga.Enabled = False
                txtstok.Enabled = False
                btnbatal.Enabled = False
                txtidbrg.Enabled = False
                btnhapus.Enabled = True
                btnedit.Enabled = True
                btntambahbrg.Enabled = True
            End If

        End If
        Call Tampil()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        MainMenu.Show()
    End Sub


    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btntambahbrg.Enabled = True
        btnkembali.Enabled = True
        btnbatal.Enabled = False
        txtnamabarang.Enabled = False
        txtharga.Enabled = False
        txtstok.Enabled = False
        txtharga.Text = ""
        txtnamabarang.Text = ""
        txtstok.Text = ""
        txtidbrg.Text = ""
        txtidbrg.Enabled = False

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        txtidbrg.Enabled = True
        btnedit.Enabled = False
        btntambahbrg.Enabled = False
        btnkembali.Enabled = False
        btnbatal.Enabled = True


        If txtidbrg.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Memasukkan ID barang")
        Else
            Call Connection()
            Dim CMD As OleDbCommand
            Str = “Select * From Data_Barang where Id_barang= '" & txtidbrg.Text & "'"
            CMD = New OleDbCommand(Str, Conn)
            rd = CMD.ExecuteReader

            If rd.Read Then
                Dim hapus As String = "delete From Data_Barang where ID_Barang='" & txtidbrg.Text & "'"
                CMD = New OleDbCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                txtidbrg.Clear()
                txtidbrg.Enabled = False
                btntambahbrg.Enabled = True
                btnedit.Enabled = True
                btnkembali.Enabled = True

                Call Tampil()

            Else
                MsgBox(“Data Tidak Ada”)
                txtnamabarang.Text = ""
                txtidbrg.Text = ""
                txtharga.Text = ""
                txtstok.Text = ""
                txtnamabarang.Enabled = False
                txtharga.Enabled = False
                txtstok.Enabled = False
                btnbatal.Enabled = False
                txtidbrg.Enabled = False
                btntambahbrg.Enabled = True
                btnhapus.Enabled = True
                btnedit.Enabled = True
                btnkembali.Enabled = True
            End If

        End If

    End Sub


End Class