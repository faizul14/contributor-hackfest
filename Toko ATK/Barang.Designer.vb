<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambahbrg = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtidbrg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabeldatabarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataBarangBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblbarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TabeldatabarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBarangBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(653, 450)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(75, 23)
        Me.btnkembali.TabIndex = 13
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(493, 412)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(95, 46)
        Me.btnhapus.TabIndex = 12
        Me.btnhapus.Text = "Hapus Barang"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(493, 340)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 46)
        Me.btnedit.TabIndex = 11
        Me.btnedit.Text = "Edit Barang"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambahbrg
        '
        Me.btntambahbrg.Location = New System.Drawing.Point(493, 266)
        Me.btntambahbrg.Name = "btntambahbrg"
        Me.btntambahbrg.Size = New System.Drawing.Size(95, 46)
        Me.btntambahbrg.TabIndex = 10
        Me.btntambahbrg.Text = "Tambah Barang"
        Me.btntambahbrg.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtidbrg)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnbatal)
        Me.GroupBox2.Controls.Add(Me.txtstok)
        Me.GroupBox2.Controls.Add(Me.txtharga)
        Me.GroupBox2.Controls.Add(Me.txtnamabarang)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 209)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "input data barang "
        '
        'txtidbrg
        '
        Me.txtidbrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidbrg.Location = New System.Drawing.Point(137, 25)
        Me.txtidbrg.Name = "txtidbrg"
        Me.txtidbrg.Size = New System.Drawing.Size(74, 23)
        Me.txtidbrg.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Id Barang"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(102, 162)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(92, 32)
        Me.btnbatal.TabIndex = 7
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'txtstok
        '
        Me.txtstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstok.Location = New System.Drawing.Point(137, 117)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(57, 23)
        Me.txtstok.TabIndex = 5
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(137, 88)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(74, 23)
        Me.txtharga.TabIndex = 4
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamabarang.Location = New System.Drawing.Point(137, 59)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(143, 23)
        Me.txtnamabarang.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = " Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(445, 31)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Data Barang di TOKO ATK AGISTA"
        '
        'tblbarang
        '
        Me.tblbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblbarang.Location = New System.Drawing.Point(99, 80)
        Me.tblbarang.Name = "tblbarang"
        Me.tblbarang.Size = New System.Drawing.Size(525, 150)
        Me.tblbarang.TabIndex = 14
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 485)
        Me.Controls.Add(Me.tblbarang)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambahbrg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TabeldatabarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBarangBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnkembali As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambahbrg As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnbatal As Button
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tabelbarang As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TabeldatabarangBindingSource As BindingSource
    Friend WithEvents DataBarangBindingSource As BindingSource
    Friend WithEvents DataBarangBindingSource1 As BindingSource
    Friend WithEvents txtidbrg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tblbarang As DataGridView
End Class
