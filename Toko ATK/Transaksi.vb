Imports System.Data.OleDb

Public Class Transaksi
    Dim HB, Bayar, total, harga, jumlah, stok As Integer

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call MunculCBidBarang()
        Call TampilTransaksi()
        'Call Hitungtotal()
        'Call Hitungkembalian()

        For i As Integer = 1 To 50
            cbjumlahbeli.Items.Add(i)
        Next

    End Sub





    Sub TampilTransaksi()

        da = New OleDbDataAdapter("Select * From Tabel_Transaksi", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tabel_Transaksi")
        Tabel_Transaksi.DataSource = ds.Tables("Tabel_Transaksi")

        Tabel_Transaksi.Refresh()

    End Sub

    Private Sub cbIdBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIdBarang.SelectedIndexChanged
        Call Connection()
        cmd = New OleDbCommand("Select * From Data_Barang where Id_Barang= '" & cbIdBarang.Text & "'", Conn)
        rd = cmd.ExecuteReader()
        rd.Read()

        If rd.HasRows Then
            lblnamabrg.Text = rd!Nama_Barang
            lblharga.Text = rd!Harga
            lblstok.Text = rd!Stock
        End If
    End Sub

    Sub MunculCBidBarang()
        Call Connection()
        cmd = New OleDbCommand("Select * From Data_Barang", Conn)
        rd = cmd.ExecuteReader()
        Do While rd.Read
            cbIdBarang.Items.Add(rd.Item(0))
        Loop


    End Sub



    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call Connection()


        If txtidtx.Text = "" And cbjumlahbeli.Text = "" And txtnama.Text = "" And txtbayar.Text = "" Then
            MsgBox("Silahkan Masukkan Data Yang Ingin Ditambah!", MsgBoxStyle.Information, "Information")
            txtidtx.Focus()
            Exit Sub

        Else
            Call Connection()
            cmd = New OleDbCommand("Select * From Tabel_Transaksi where ID_Transaksi= '" & txtidtx.Text & "'", Conn)
            rd = cmd.ExecuteReader()
            rd.Read()

            If Not rd.HasRows Then
                Call Connection()

                Dim Save As String = "insert into Tabel_Transaksi(ID_Transaksi, Nama_Pembeli, Id_Barang, Qty, Total_Bayar, Tanggal_Beli) values " &
                    "('" & txtidtx.Text & "','" & txtnama.Text & "','" & cbIdBarang.Text & "','" & cbjumlahbeli.Text & "','" & lbltotal.Text & "','" & tglTF.Text & "')"
                cmd = New OleDbCommand(Save, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!", MsgBoxStyle.Information, "Information")

                Dim editstok As String = "Update Data_Barang set Stock='" & lblstok.Text - cbjumlahbeli.Text & "' where Id_Barang='" & cbIdBarang.Text & "'"
                cmd = New OleDbCommand(editstok, Conn)
                cmd.ExecuteNonQuery()

                txtbayar.Text = ""
                txtidtx.Text = ""
                txtnama.Text = ""
                tglTF.Text = ""
                cbIdBarang.Text = ""
                cbjumlahbeli.Text = ""
                lblharga.Text = ""
                lblkembalian.Text = ""
                lblnamabrg.Text = ""
                lblstok.Text = ""
                lbltotal.Text = ""
                tglTF.ResetText()

            Else
                MsgBox("ID Sudah Digunakan. Gunakan ID lain!", MsgBoxStyle.Information, "Information")
                txtidtx.Text = ""

            End If

            Call TampilTransaksi()
        End If

    End Sub


    Private Sub cbjumlahbeli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjumlahbeli.SelectedIndexChanged
        harga = lblharga.Text
        jumlah = cbjumlahbeli.Text
        stok = lblstok.Text

        If jumlah > stok Then
            MsgBox("Stok Tidak Cukup!", MsgBoxStyle.Information, "Information")
            cbjumlahbeli.SelectedText = ""
        Else
            total = harga * jumlah
            lbltotal.Text = total
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnkembalian.Click

        Bayar = txtbayar.Text

        If Bayar < total Then
            MsgBox("Uang Tidak Cukup!", MsgBoxStyle.Information, "Information")
            txtbayar.Text = ""
        Else
            HB = Bayar - total
            lblkembalian.Text = HB
        End If

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        txtbayar.Text = ""
        txtidtx.Text = ""
        txtnama.Text = ""
        tglTF.Text = ""
        cbIdBarang.Text = ""
        cbjumlahbeli.Text = ""
        lblharga.Text = ""
        lblkembalian.Text = ""
        lblnamabrg.Text = ""
        lblstok.Text = ""
        lbltotal.Text = ""
        tglTF.ResetText()
    End Sub

End Class