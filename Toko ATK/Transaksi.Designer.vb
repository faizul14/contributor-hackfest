<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbjumlahbeli = New System.Windows.Forms.ComboBox()
        Me.btnkembalian = New System.Windows.Forms.Button()
        Me.lblstok = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblkembalian = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tglTF = New System.Windows.Forms.DateTimePicker()
        Me.cbIdBarang = New System.Windows.Forms.ComboBox()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Tabel_Transaksi = New System.Windows.Forms.DataGridView()
        Me.lblnamabrg = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtidtx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tabel_Transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data Transaksi TOKO ATK AGISTA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbjumlahbeli)
        Me.GroupBox1.Controls.Add(Me.btnkembalian)
        Me.GroupBox1.Controls.Add(Me.lblstok)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblkembalian)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tglTF)
        Me.GroupBox1.Controls.Add(Me.cbIdBarang)
        Me.GroupBox1.Controls.Add(Me.btnkembali)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.btnbatal)
        Me.GroupBox1.Controls.Add(Me.btnsimpan)
        Me.GroupBox1.Controls.Add(Me.Tabel_Transaksi)
        Me.GroupBox1.Controls.Add(Me.lblnamabrg)
        Me.GroupBox1.Controls.Add(Me.lblharga)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.txtbayar)
        Me.GroupBox1.Controls.Add(Me.txtidtx)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 421)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'cbjumlahbeli
        '
        Me.cbjumlahbeli.FormattingEnabled = True
        Me.cbjumlahbeli.Location = New System.Drawing.Point(342, 85)
        Me.cbjumlahbeli.Name = "cbjumlahbeli"
        Me.cbjumlahbeli.Size = New System.Drawing.Size(111, 21)
        Me.cbjumlahbeli.TabIndex = 40
        '
        'btnkembalian
        '
        Me.btnkembalian.Location = New System.Drawing.Point(487, 102)
        Me.btnkembalian.Name = "btnkembalian"
        Me.btnkembalian.Size = New System.Drawing.Size(75, 23)
        Me.btnkembalian.TabIndex = 39
        Me.btnkembalian.Text = "Kembalian"
        Me.btnkembalian.UseVisualStyleBackColor = True
        '
        'lblstok
        '
        Me.lblstok.AutoSize = True
        Me.lblstok.Location = New System.Drawing.Point(149, 195)
        Me.lblstok.Name = "lblstok"
        Me.lblstok.Size = New System.Drawing.Size(10, 13)
        Me.lblstok.TabIndex = 38
        Me.lblstok.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(40, 195)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Stock"
        '
        'lblkembalian
        '
        Me.lblkembalian.AutoSize = True
        Me.lblkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkembalian.Location = New System.Drawing.Point(605, 98)
        Me.lblkembalian.Name = "lblkembalian"
        Me.lblkembalian.Size = New System.Drawing.Size(23, 25)
        Me.lblkembalian.TabIndex = 36
        Me.lblkembalian.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(131, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Rp"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(384, 122)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(23, 25)
        Me.lbltotal.TabIndex = 34
        Me.lbltotal.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(574, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 25)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Rp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(354, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 25)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Rp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total Harga"
        '
        'tglTF
        '
        Me.tglTF.Location = New System.Drawing.Point(342, 48)
        Me.tglTF.Name = "tglTF"
        Me.tglTF.Size = New System.Drawing.Size(119, 20)
        Me.tglTF.TabIndex = 29
        '
        'cbIdBarang
        '
        Me.cbIdBarang.FormattingEnabled = True
        Me.cbIdBarang.Location = New System.Drawing.Point(134, 119)
        Me.cbIdBarang.Name = "cbIdBarang"
        Me.cbIdBarang.Size = New System.Drawing.Size(100, 21)
        Me.cbIdBarang.TabIndex = 28
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(631, 392)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(75, 23)
        Me.btnkembali.TabIndex = 27
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(43, 392)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Cetak Struk"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(583, 185)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(85, 33)
        Me.btnbatal.TabIndex = 25
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(487, 185)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(90, 33)
        Me.btnsimpan.TabIndex = 24
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Tabel_Transaksi
        '
        Me.Tabel_Transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel_Transaksi.Location = New System.Drawing.Point(28, 224)
        Me.Tabel_Transaksi.Name = "Tabel_Transaksi"
        Me.Tabel_Transaksi.Size = New System.Drawing.Size(647, 150)
        Me.Tabel_Transaksi.TabIndex = 21
        '
        'lblnamabrg
        '
        Me.lblnamabrg.AutoSize = True
        Me.lblnamabrg.Location = New System.Drawing.Point(142, 152)
        Me.lblnamabrg.Name = "lblnamabrg"
        Me.lblnamabrg.Size = New System.Drawing.Size(43, 13)
        Me.lblnamabrg.TabIndex = 20
        Me.lblnamabrg.Text = "______"
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.Location = New System.Drawing.Point(149, 175)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(13, 13)
        Me.lblharga.TabIndex = 19
        Me.lblharga.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Nama Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Harga"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(134, 82)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 11
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(550, 65)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(100, 20)
        Me.txtbayar.TabIndex = 9
        '
        'txtidtx
        '
        Me.txtidtx.Location = New System.Drawing.Point(134, 48)
        Me.txtidtx.Name = "txtidtx"
        Me.txtidtx.Size = New System.Drawing.Size(100, 20)
        Me.txtidtx.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ID Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(501, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Dibayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Beli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pembeli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Beli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Transaksi"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tabel_Transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txtidtx As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnamabrg As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Tabel_Transaksi As DataGridView
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents tglTF As DateTimePicker
    Friend WithEvents cbIdBarang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblkembalian As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblstok As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnkembalian As Button
    Friend WithEvents cbjumlahbeli As ComboBox
End Class
