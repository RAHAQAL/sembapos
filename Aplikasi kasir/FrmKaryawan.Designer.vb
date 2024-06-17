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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKaryawan))
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(493, 180)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(92, 29)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(493, 84)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(92, 29)
        Me.btnUbah.TabIndex = 27
        Me.btnUbah.Text = "&Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(493, 33)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(92, 29)
        Me.btnTambah.TabIndex = 26
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No. Telp"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jabatan"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIK"
        Me.ColumnHeader1.Width = 140
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(493, 133)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(92, 29)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(38, 265)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(696, 217)
        Me.ListView1.TabIndex = 25
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.ForeColor = System.Drawing.Color.Black
        Me.lblAlamat.Location = New System.Drawing.Point(264, 94)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(48, 17)
        Me.lblAlamat.TabIndex = 24
        Me.lblAlamat.Text = "Alamat"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomor.ForeColor = System.Drawing.Color.Black
        Me.lblNomor.Location = New System.Drawing.Point(264, 33)
        Me.lblNomor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(57, 17)
        Me.lblNomor.TabIndex = 23
        Me.lblNomor.Text = "No. Telp"
        '
        'lblJabatan
        '
        Me.lblJabatan.AutoSize = True
        Me.lblJabatan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJabatan.ForeColor = System.Drawing.Color.Black
        Me.lblJabatan.Location = New System.Drawing.Point(35, 160)
        Me.lblJabatan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJabatan.Name = "lblJabatan"
        Me.lblJabatan.Size = New System.Drawing.Size(53, 17)
        Me.lblJabatan.TabIndex = 22
        Me.lblJabatan.Text = "Jabatan"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.Black
        Me.lblNama.Location = New System.Drawing.Point(35, 94)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(43, 17)
        Me.lblNama.TabIndex = 21
        Me.lblNama.Text = "Nama"
        '
        'txtAlamat
        '
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(267, 113)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlamat.MaxLength = 50
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(174, 96)
        Me.txtAlamat.TabIndex = 20
        '
        'txtTelp
        '
        Me.txtTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(267, 52)
        Me.txtTelp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelp.MaxLength = 12
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(174, 25)
        Me.txtTelp.TabIndex = 19
        '
        'txtJabatan
        '
        Me.txtJabatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJabatan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJabatan.Location = New System.Drawing.Point(38, 182)
        Me.txtJabatan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.Size = New System.Drawing.Size(174, 25)
        Me.txtJabatan.TabIndex = 18
        '
        'txtNama
        '
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(38, 113)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.MaxLength = 30
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(174, 25)
        Me.txtNama.TabIndex = 17
        '
        'txtNik
        '
        Me.txtNik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNik.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNik.Location = New System.Drawing.Point(38, 52)
        Me.txtNik.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNik.MaxLength = 5
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(174, 25)
        Me.txtNik.TabIndex = 16
        '
        'lblNik
        '
        Me.lblNik.AutoSize = True
        Me.lblNik.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNik.ForeColor = System.Drawing.Color.Black
        Me.lblNik.Location = New System.Drawing.Point(35, 33)
        Me.lblNik.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNik.Name = "lblNik"
        Me.lblNik.Size = New System.Drawing.Size(29, 17)
        Me.lblNik.TabIndex = 15
        Me.lblNik.Text = "NIK"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 40)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Welcome to SembaPOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(265, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Hi Fahri!"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnLaporan)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnUser)
        Me.Panel2.Controls.Add(Me.btnKaryawan)
        Me.Panel2.Controls.Add(Me.btnBarang)
        Me.Panel2.Controls.Add(Me.btnPenjualan)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 703)
        Me.Panel2.TabIndex = 32
        '
        'btnLaporan
        '
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), System.Drawing.Image)
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(45, 227)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(132, 32)
        Me.btnLaporan.TabIndex = 15
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(45, 465)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 32)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(20, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "_____________________________"
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(45, 390)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(132, 32)
        Me.btnUser.TabIndex = 12
        Me.btnUser.Text = "   User"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnKaryawan
        '
        Me.btnKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnKaryawan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnKaryawan.Image = CType(resources.GetObject("btnKaryawan.Image"), System.Drawing.Image)
        Me.btnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.Location = New System.Drawing.Point(45, 335)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(132, 32)
        Me.btnKaryawan.TabIndex = 11
        Me.btnKaryawan.Text = "   Karyawan"
        Me.btnKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKaryawan.UseVisualStyleBackColor = False
        '
        'btnBarang
        '
        Me.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBarang.Image = CType(resources.GetObject("btnBarang.Image"), System.Drawing.Image)
        Me.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Location = New System.Drawing.Point(45, 281)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(132, 32)
        Me.btnBarang.TabIndex = 10
        Me.btnBarang.Text = "   Barang"
        Me.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPenjualan.FlatAppearance.BorderSize = 0
        Me.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenjualan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnPenjualan.Image = CType(resources.GetObject("btnPenjualan.Image"), System.Drawing.Image)
        Me.btnPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPenjualan.Location = New System.Drawing.Point(45, 171)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(132, 32)
        Me.btnPenjualan.TabIndex = 9
        Me.btnPenjualan.Text = "   Penjualan"
        Me.btnPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.Location = New System.Drawing.Point(45, 114)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(132, 32)
        Me.btnDashboard.TabIndex = 8
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 46)
        Me.Panel1.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.ListView1)
        Me.Panel3.Controls.Add(Me.lblNik)
        Me.Panel3.Controls.Add(Me.txtNik)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Controls.Add(Me.txtJabatan)
        Me.Panel3.Controls.Add(Me.txtTelp)
        Me.Panel3.Controls.Add(Me.btnSimpan)
        Me.Panel3.Controls.Add(Me.txtAlamat)
        Me.Panel3.Controls.Add(Me.btnUbah)
        Me.Panel3.Controls.Add(Me.lblNama)
        Me.Panel3.Controls.Add(Me.btnTambah)
        Me.Panel3.Controls.Add(Me.lblJabatan)
        Me.Panel3.Controls.Add(Me.btnHapus)
        Me.Panel3.Controls.Add(Me.lblNomor)
        Me.Panel3.Controls.Add(Me.lblAlamat)
        Me.Panel3.Location = New System.Drawing.Point(269, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 531)
        Me.Panel3.TabIndex = 35
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(1085, 136)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 116)
        Me.Panel4.TabIndex = 36
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(1085, 287)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 380)
        Me.Panel5.TabIndex = 37
        '
        'FrmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmKaryawan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnKaryawan As System.Windows.Forms.Button
    Friend WithEvents btnBarang As System.Windows.Forms.Button
    Friend WithEvents btnPenjualan As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
