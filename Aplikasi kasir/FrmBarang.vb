Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmBarang

#Region "SUB"

    Sub btnAktif()
        btnTambah.Enabled = True
        btnTambah.Text = "&Tambah"
        btnUbah.Enabled = True
        btnUbah.Text = "&Ubah"
        btnHapus.Enabled = True
        btnHapus.Text = "&Hapus"
        btnSimpan.Enabled = True
        txtKode.Focus()
    End Sub

    Sub kodebarangotomatis()
        cmd = New SqlCommand("SELECT * FROM TBarang ORDER BY id_barang DESC", koneksi)
        rdr = cmd.ExecuteReader
        rdr.Read()

        If Not rdr.HasRows = True Then
            ' Jika tidak ada data, inisialisasi dengan B-001
            txtKode.Text = "B-001"
        Else
            ' Jika ada data, ambil nilai terakhir dan tambahkan 1
            Dim lastId As Integer = Val(Microsoft.VisualBasic.Mid(rdr.Item("id_barang").ToString, 3, 3)) + 1

            ' Format nilai menjadi B-XXX
            txtKode.Text = "B-" + lastId.ToString("D3")
        End If
    End Sub


    Sub listdata()

        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TBarang"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While rdr.Read

            Dim lv As ListViewItem
            lv = ListView1.Items.Add(rdr(0))
            lv.SubItems.Add(rdr(1))
            lv.SubItems.Add(rdr(2))
            lv.SubItems.Add(rdr(3))
            lv.SubItems.Add(rdr(4))

        Loop

        cmd.Dispose()
        rdr.Close()

    End Sub

    Sub aktif()
        txtKode.Focus()
        txtKode.Enabled = True
        txtNama.Enabled = True
        txtHJual.Enabled = True
        txtSatuan.Enabled = True
        txtStok.Enabled = True
    End Sub

    Sub aktif2()
        txtKode.Enabled = False
        txtNama.Enabled = True
        txtHJual.Enabled = True
        txtSatuan.Enabled = True
        txtStok.Enabled = True
    End Sub

    Sub nonaktif()
        txtKode.Enabled = False
        txtNama.Enabled = False
        txtHJual.Enabled = False
        txtSatuan.Enabled = False
        txtStok.Enabled = False


    End Sub

    Sub clear()
        txtKode.Clear()
        txtNama.Clear()
        txtHJual.Clear()
        txtSatuan.Clear()
        txtStok.Clear()
    End Sub

#End Region



    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMenuBasedOnRole()
        opendb()
        listdata()
        Label7.Text = "Hi, " & loggedInUserName & "!"
    End Sub


    Public Sub New()
        InitializeComponent()
        btnTambah.Text = "&Tambah"  ' Atur status awal tombol "Tambah"
        btnAktif()  ' Atur status awal kontrol lainnya jika diperlukan
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If btnTambah.Text = "&Batal" Then
            If txtNama.Text = "" Then
                MsgBox("Nama Barang masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNama.Focus()
                Exit Sub
            ElseIf txtHJual.Text = "" Then
                MsgBox("Harga Jual masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtHJual.Focus()
                Exit Sub
            ElseIf txtSatuan.Text = "" Then
                MsgBox("Satuan masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtSatuan.Focus()
                Exit Sub
            ElseIf txtStok.Text = "" Then
                MsgBox("Stok masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtStok.Focus()
                Exit Sub
            Else

                cmd.Connection = koneksi

                ' Periksa apakah kodeanggota sudah ada sebelum melakukan insert
                cmd.CommandText = "SELECT COUNT(*) FROM TBarang  WHERE id_barang = '" & txtKode.Text & "'"
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    ' Kode anggota sudah ada, tampilkan pesan
                    MessageBox.Show("Data dengan Kode Barang sudah ini sudah terdaftar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                    kodebarangotomatis()
                    FrmBarang_Load(Nothing, Nothing)
                    aktif2()
                    txtNama.Focus()

                Else

                    cmd.Connection = koneksi
                    cmd.CommandText = "INSERT INTO TBarang VALUES ('" & Trim(txtKode.Text) & "', '" & Trim(txtNama.Text) & "', '" & Trim(txtHJual.Text) & "'," & _
                                        "'" & Trim(txtSatuan.Text) & "'," & _
                                        "'" & Trim(txtStok.Text) & "')"
                    Dim rdr As SqlDataReader = cmd.ExecuteReader
                    cmd.Dispose()
                    rdr.Close()
                    MsgBox("Data Barang Berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
                    clear()
                    btnTambah_Click(Nothing, Nothing)
                    FrmBarang_Load(Nothing, Nothing)
                    txtKode.Focus()
                    Exit Sub

                End If

            End If
            ListView1.Enabled = True


        ElseIf btnUbah.Text = "&Batal" Then

            If txtNama.Text = "" Then
                MsgBox("Nama Barang masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNama.Focus()
                Exit Sub
            ElseIf txtHJual.Text = "" Then
                MsgBox("Harga Jual masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtHJual.Focus()
                Exit Sub
            ElseIf txtSatuan.Text = "" Then
                MsgBox("Satuan masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtSatuan.Focus()
                Exit Sub
            ElseIf txtStok.Text = "" Then
                MsgBox("Stok masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtStok.Focus()
                Exit Sub
            Else

                cmd.Connection = koneksi
                cmd.CommandText = "UPDATE TBarang SET nama_barang = '" & txtNama.Text & "', hargajual = '" & txtHJual.Text & "',satuan='" & txtSatuan.Text & "' ,stok='" & txtStok.Text & "' WHERE id_barang = '" & txtKode.Text & "'"

                Dim iya As String
                iya = MsgBox("Apakah anda yakin ingin mengubah data barang tersebut?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING!!")
                If iya = vbYes Then
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    MessageBox.Show("Data barang telah diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Else

                End If


                cmd.Connection = koneksi
                cmd.CommandText = "SELECT * FROM TBarang"
                rdr = cmd.ExecuteReader

                ListView1.Items.Clear()
                Do While rdr.Read()
                    Dim lv As ListViewItem
                    lv = ListView1.Items.Add(rdr(0))
                    lv.SubItems.Add(rdr(1))
                    lv.SubItems.Add(rdr(2))
                    lv.SubItems.Add(rdr(3))
                    lv.SubItems.Add(rdr(4))

                Loop
                cmd.Dispose()
                rdr.Close()

            End If
            clear()
            btnAktif()
            aktif()
            txtKode.Focus()
            ListView1.Enabled = True



        ElseIf btnHapus.Text = "&Batal" Then

            If String.IsNullOrWhiteSpace(txtKode.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtHJual.Text) OrElse String.IsNullOrWhiteSpace(txtSatuan.Text) OrElse String.IsNullOrWhiteSpace(txtStok.Text) Then
                ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
                MessageBox.Show("Data barang yang akan dihapus tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                cmd.Connection = koneksi
                cmd.CommandText = "delete TBarang WHERE id_barang = '" & txtKode.Text & "'"
                Dim iya As String
                iya = MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING!!")
                If iya = vbYes Then
5:
                    : cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Data barang telah dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else


                End If

                cmd.Connection = koneksi
                cmd.CommandText = "SELECT * FROM TBarang"
                rdr = cmd.ExecuteReader

                ListView1.Items.Clear()
                Do While rdr.Read()
                    Dim lv As ListViewItem
                    lv = ListView1.Items.Add(rdr(0))
                    lv.SubItems.Add(rdr(1))
                    lv.SubItems.Add(rdr(2))
                    lv.SubItems.Add(rdr(3))
                    lv.SubItems.Add(rdr(4))
                Loop
                cmd.Dispose()
                rdr.Close()
            End If
            btnAktif()
            aktif()
            txtKode.Focus()
            clear()
            ListView1.Enabled = True




        Else
            MsgBox("Proses tidak bisa dilanjutkan", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

    End Sub






    Private Sub txtHBeli_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtHJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHJual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub







    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click


        If String.IsNullOrWhiteSpace(txtKode.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtHJual.Text) OrElse String.IsNullOrWhiteSpace(txtSatuan.Text) OrElse String.IsNullOrWhiteSpace(txtStok.Text) Then
            ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
            MessageBox.Show("Data barang yang akan diubah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtKode.Focus()

        Else

            If btnUbah.Text = "&Ubah" Then
                btnUbah.Text = "&Batal"
                btnTambah.Enabled = False
                btnHapus.Enabled = False
                btnSimpan.Enabled = True
                aktif2()
                txtNama.Focus()
                ListView1.Enabled = False
            Else
                btnUbah.Text = "&Ubah"
                'clear()
                nonaktif()
                'txtKode.Focus()
                FrmBarang_Load(Nothing, Nothing)
                btnTambah.Enabled = True
                btnHapus.Enabled = True
                ListView1.Enabled = True

            End If

        End If

    End Sub




    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        If ListView1.SelectedItems.Count > 0 Then
            ' Ambil item yang dipilih dari ListView
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Tampilkan data item yang dipilih di TextBox
            txtKode.Text = selectedItem.SubItems(0).Text
            txtNama.Text = selectedItem.SubItems(1).Text
            txtHJual.Text = selectedItem.SubItems(2).Text
            txtSatuan.Text = selectedItem.SubItems(3).Text
            txtStok.Text = selectedItem.SubItems(4).Text

            nonaktif()
        End If

    End Sub



    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "&Tambah" Then
            clear()
            kodebarangotomatis()
            btnTambah.Text = "&Batal"
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnSimpan.Enabled = True
            aktif2()
            txtNama.Focus()
            FrmBarang_Load(Nothing, Nothing)
            ListView1.Enabled = False

        Else
            btnTambah.Text = "&Tambah"
            btnUbah.Enabled = True
            btnHapus.Enabled = True
            aktif()
            clear()
            FrmBarang_Load(Nothing, Nothing)
            txtKode.Focus()
            ListView1.Enabled = True

        End If
    End Sub







    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click


        If String.IsNullOrWhiteSpace(txtKode.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtHJual.Text) OrElse String.IsNullOrWhiteSpace(txtSatuan.Text) OrElse String.IsNullOrWhiteSpace(txtStok.Text) Then ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
            MessageBox.Show("Data yang akan dihapus tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If btnHapus.Text = "&Hapus" Then
                btnHapus.Text = "&Batal"
                btnTambah.Enabled = False
                btnHapus.Enabled = True
                btnUbah.Enabled = False
                btnSimpan.Enabled = True
                ListView1.Enabled = False

            Else
                btnHapus.Text = "&Hapus"
                btnAktif()
                'clear()
                ListView1.Enabled = True
            End If

        End If

    End Sub


    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FSales.Show()
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmUser.Show()
    End Sub

  

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        'Me.Hide()
        ListPenjualan.Show()
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnPenjualan_Click_1(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Me.Hide()
        FSales.Show()
    End Sub

    Private Sub btnKaryawan_Click_1(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Me.Hide()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnUser_Click_1(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        FrmUser.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Tampilkan kotak dialog konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih Yes, maka tutup form dan kembali ke form login
        If result = DialogResult.Yes Then
            ' Buat instance form login jika belum ada
            Dim loginForm As New LoginForm1()

            ' Tampilkan form login
            loginForm.Show()

            ' Tutup form saat ini (form utama)
            Me.Close()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FrmListBarang.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBarang.Text = "" Then
            MsgBox("ID Barang masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            txtBarang.Focus()
            Exit Sub
        ElseIf nudQty.Value = 0 Then
            MsgBox("Qty masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            nudQty.Focus()
            Exit Sub
        Else
            Dim karakter As String = txtBarang.Text.Substring(0, 5)

            ' Query untuk memeriksa apakah id_barang ada dalam database
            Dim queryCheckIdBarang As String = "SELECT COUNT(*) FROM TBarang WHERE LEFT(id_barang, 5) = @karakter"
            cmd.CommandText = queryCheckIdBarang
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@karakter", karakter)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                MsgBox("ID Barang tidak ditemukan dalam database.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                Exit Sub
            End If

            ' Jika id_barang ditemukan dalam database, lanjutkan dengan menambahkan stok
            Dim queryUpdateStok As String = "UPDATE TBarang SET stok = stok + @qty WHERE LEFT(id_barang, 5) = @karakter"
            cmd.CommandText = queryUpdateStok
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(nudQty.Value))
            cmd.Parameters.AddWithValue("@karakter", karakter)
            cmd.ExecuteNonQuery()

            MsgBox("Stok barang berhasil diperbarui", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            txtBarang.Clear()
            nudQty.Value = 0
            FrmBarang_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class