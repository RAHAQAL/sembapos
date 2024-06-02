<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKaryawan
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
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.lblJabatan = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNik = New System.Windows.Forms.TextBox()
        Me.lblNik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Obadiah pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(1177, 396)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(123, 39)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnUbah.Font = New System.Drawing.Font("Obadiah pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(1177, 284)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(123, 39)
        Me.btnUbah.TabIndex = 27
        Me.btnUbah.Text = "&Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Obadiah pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(1177, 227)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(123, 39)
        Me.btnTambah.TabIndex = 26
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No. Telp"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jabatan"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIK"
        Me.ColumnHeader1.Width = 180
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Obadiah pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(1177, 341)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(123, 39)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(400, 555)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1158, 304)
        Me.ListView1.TabIndex = 25
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.ForeColor = System.Drawing.Color.White
        Me.lblAlamat.Location = New System.Drawing.Point(612, 381)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(83, 26)
        Me.lblAlamat.TabIndex = 24
        Me.lblAlamat.Text = "Alamat"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomor.ForeColor = System.Drawing.Color.White
        Me.lblNomor.Location = New System.Drawing.Point(612, 336)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(94, 26)
        Me.lblNomor.TabIndex = 23
        Me.lblNomor.Text = "No. Telp"
        '
        'lblJabatan
        '
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatan.ForeColor = System.Drawing.Color.White
        Me.lblJabatan.Location = New System.Drawing.Point(612, 286)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(94, 26)
        Me.lblJabatan.TabIndex = 22
        Me.lblJabatan.Text = "Jabatan"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(612, 236)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(72, 26)
        Me.lblNama.TabIndex = 21
        Me.lblNama.Text = "Nama"
        '
        'txtAlamat
        '
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlamat.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(752, 381)
        Me.txtAlamat.MaxLength = 50
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(231, 109)
        Me.txtAlamat.TabIndex = 20
        '
        'txtTelp
        '
        Me.txtTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelp.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(752, 334)
        Me.txtTelp.MaxLength = 12
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(231, 34)
        Me.txtTelp.TabIndex = 19
        '
        'txtJabatan
        '
        Me.txtJabatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJabatan.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJabatan.Location = New System.Drawing.Point(752, 284)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(231, 34)
        Me.txtJabatan.TabIndex = 18
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(752, 236)
        Me.txtNama.MaxLength = 30
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(231, 34)
        Me.txtNama.TabIndex = 17
        '
        'txtNik
        '
        Me.txtNik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNik.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNik.Location = New System.Drawing.Point(752, 185)
        Me.txtNik.MaxLength = 5
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(231, 34)
        Me.txtNik.TabIndex = 16
        '
        'lblNik
        '
        Me.lblNik.AutoSize = True
        Me.lblNik.Font = New System.Drawing.Font("Obadiah pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNik.ForeColor = System.Drawing.Color.White
        Me.lblNik.Location = New System.Drawing.Point(612, 187)
        Me.lblNik.Name = "lblNik"
        Me.lblNik.Size = New System.Drawing.Size(48, 26)
        Me.lblNik.TabIndex = 15
        Me.lblNik.Text = "NIK"
        '
        'FrmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblNomor)
        Me.Controls.Add(Me.lblJabatan)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtJabatan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.lblNik)
        Me.Name = "FrmKaryawan"
        Me.Text = "FrmKaryawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblNomor As System.Windows.Forms.Label
    Friend WithEvents lblJabatan As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents lblNik As System.Windows.Forms.Label
End Class
