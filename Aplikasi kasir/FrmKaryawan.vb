Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FrmKaryawan

#Region "SUB"



    Sub aktif()
        txtNik.Enabled = True
        txtNama.Enabled = True
        txtJabatan.Enabled = True
        txtTelp.Enabled = True
        txtAlamat.Enabled = True
    End Sub

    Sub aktif2()
        txtNik.Enabled = False
        txtNama.Enabled = True
        txtJabatan.Enabled = True
        txtTelp.Enabled = True
        txtAlamat.Enabled = True
    End Sub


    Sub nonaktif()
        txtNik.Enabled = False
        txtNama.Enabled = False
        txtJabatan.Enabled = False
        txtTelp.Enabled = False
        txtAlamat.Enabled = False
    End Sub

    Sub clear()
        txtNik.Clear()
        txtNama.Clear()
        txtJabatan.Clear()
        txtTelp.Clear()
        txtAlamat.Clear()
    End Sub

    Sub btnAktif()
        btnTambah.Enabled = True
        btnTambah.Text = "&Tambah"
        btnUbah.Enabled = True
        btnUbah.Text = "&Ubah"
        btnHapus.Enabled = True
        btnHapus.Text = "&Hapus"
        btnSimpan.Enabled = True
    End Sub

    Sub listdata()

        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TKaryawan"
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

    Sub nikotomatis()
        cmd = New SqlCommand("SELECT TOP 1 nik FROM TKaryawan ORDER BY nik DESC", koneksi)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            rdr.Read()
            Dim lastId As Integer = 0
            If Integer.TryParse(rdr("nik").ToString(), lastId) Then
                lastId += 1
            End If
            txtNik.Text = lastId.ToString()
        Else
            ' Jika tidak ada data, inisialisasi dengan nilai awal
            txtNik.Text = "11111"
        End If
        rdr.Close()
        cmd.Dispose()
    End Sub

    Sub HitungTotalKaryawan()
        Try
            cmd = New SqlCommand("SELECT COUNT(*) FROM TKaryawan", koneksi)
            Dim jumlahKaryawan As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label10.Text = jumlahKaryawan
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghitung jumlah karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub FrmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMenuBasedOnRole()
        opendb()
        HitungTotalKaryawan()
        listdata()
        Label1.Text = "Hi, " & loggedInUserName & "!"

    End Sub



    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If btnTambah.Text = "&Tambah" Then
            btnTambah.Text = "&Batal"
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnSimpan.Enabled = True
            btnSimpan.Text = "&Simpan"

            aktif()
            clear()
            txtNik.Enabled = False
            txtNama.Focus()
            nikotomatis()
            ListView1.Enabled = False

        Else

            btnTambah.Text = "&Tambah"
            btnUbah.Enabled = True
            btnHapus.Enabled = True
            btnSimpan.Text = "&Simpan"

            FrmKaryawan_Load(Nothing, Nothing)
            clear()
            txtNik.Enabled = True
            txtNik.Focus()

            ListView1.Enabled = True
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If btnTambah.Text = "&Batal" Then

            If txtNik.Text = "" Then
                MsgBox("NIK masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNik.Focus()
                Exit Sub
            ElseIf txtNama.Text = "" Then
                MsgBox("Nama masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNama.Focus()
                Exit Sub
            ElseIf txtJabatan.Text = "" Then
                MsgBox("Jabatan masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtJabatan.Focus()
                Exit Sub
            ElseIf txtTelp.Text = "" Then
                MsgBox("Nomor telepon masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtTelp.Focus()
                Exit Sub
            ElseIf txtAlamat.Text = "" Then
                MsgBox("Alamat masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtAlamat.Focus()
                Exit Sub

            Else

                cmd.Connection = koneksi

                ' Periksa apakah kodeanggota sudah ada sebelum melakukan insert
                cmd.CommandText = "SELECT COUNT(*) FROM TKaryawan  WHERE nik = '" & txtNik.Text & "'"
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    ' Kode anggota sudah ada, tampilkan pesan
                    MessageBox.Show("NIK sudah terdaftar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNik.Focus()
                Else
                    ' Kode anggota belum ada, lakukan insert
                    cmd.CommandText = "INSERT INTO TKaryawan VALUES('" & txtNik.Text & "','" & txtNama.Text & "','" & txtJabatan.Text & "','" & txtTelp.Text & "', '" & txtAlamat.Text & "')"
                    cmd.ExecuteNonQuery()

                    ' Tambahkan data ke ListView
                    Dim lv As ListViewItem
                    lv = ListView1.Items.Add(txtNik.Text)
                    lv.SubItems.Add(txtNama.Text)
                    lv.SubItems.Add(txtJabatan.Text)
                    lv.SubItems.Add(txtTelp.Text)
                    lv.SubItems.Add(txtAlamat.Text)


                    MessageBox.Show("Data telah ditambahkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                    FrmKaryawan_Load(Nothing, Nothing)
                    txtNik.Focus()
                    btnAktif()

                    ListView1.Enabled = True

                End If


            End If

        ElseIf btnUbah.Text = "&Batal" Then

            If txtNik.Text = "" Then
                MsgBox("NIK masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNik.Focus()
                Exit Sub
            ElseIf txtNama.Text = "" Then
                MsgBox("Nama masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNama.Focus()
                Exit Sub
            ElseIf txtJabatan.Text = "" Then
                MsgBox("Jabatan masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtJabatan.Focus()
                Exit Sub
            ElseIf txtTelp.Text = "" Then
                MsgBox("Nomor telepon masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtTelp.Focus()
                Exit Sub
            ElseIf txtAlamat.Text = "" Then
                MsgBox("Alamat masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtAlamat.Focus()
                Exit Sub

            Else
                cmd.Connection = koneksi
                cmd.CommandText = "UPDATE Tkaryawan SET nama = '" & txtNama.Text & "', jabatan='" & txtJabatan.Text & "', no_telp = '" & txtTelp.Text & "',alamat='" & txtAlamat.Text & "' WHERE nik = '" & txtNik.Text & "'"

                Dim iya As String
                iya = MsgBox("Apakah anda yakin ingin mengubah data tersebut?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING!!")
                If iya = vbYes Then
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    MessageBox.Show("Data telah diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                End If


                cmd.Connection = koneksi
                cmd.CommandText = "SELECT * FROM Tkaryawan"
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
            aktif()
            btnAktif()
            clear()
            FrmKaryawan_Load(Nothing, Nothing)
            txtNik.Focus()

            ListView1.Enabled = True

        ElseIf btnHapus.Text = "&Batal" Then

            If String.IsNullOrWhiteSpace(txtNik.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtJabatan.Text) OrElse String.IsNullOrWhiteSpace(txtTelp.Text) OrElse String.IsNullOrWhiteSpace(txtAlamat.Text) Then
                ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
                MessageBox.Show("Data yang akan dihapus tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ModeHapus = False
            Else
                ' Check if the NIK is used in the Tuser table
                Dim cmdCheck As New SqlCommand()
                cmdCheck.Connection = koneksi
                cmdCheck.CommandText = "SELECT COUNT(*) FROM Tuser WHERE nik = @nik"
                cmdCheck.Parameters.AddWithValue("@nik", txtNik.Text)
                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                If count > 0 Then
                    ' NIK is used in Tuser, show a message and prevent deletion
                    MessageBox.Show("Karyawan tidak bisa dihapus karena NIK digunakan di Tuser.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' NIK is not used in Tuser, proceed with deletion
                    cmd.Connection = koneksi
                    cmd.CommandText = "DELETE FROM TKaryawan WHERE nik = @nik"
                    cmd.Parameters.AddWithValue("@nik", txtNik.Text)

                    Dim iya As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?", "WARNING!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If iya = DialogResult.Yes Then
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        MessageBox.Show("Data telah dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    ' Refresh the ListView
                    cmd.Connection = koneksi
                    cmd.CommandText = "SELECT * FROM TKaryawan"
                    rdr = cmd.ExecuteReader()

                    ListView1.Items.Clear()
                    Do While rdr.Read()
                        Dim lv As ListViewItem
                        lv = ListView1.Items.Add(rdr(0).ToString())
                        lv.SubItems.Add(rdr(1).ToString())
                        lv.SubItems.Add(rdr(2).ToString())
                        lv.SubItems.Add(rdr(3).ToString())
                        lv.SubItems.Add(rdr(4).ToString())
                    Loop
                    cmd.Dispose()
                    rdr.Close()
                End If

                clear()
                aktif()
                btnAktif()
                FrmKaryawan_Load(Nothing, Nothing)
                txtNik.Focus()

                ListView1.Enabled = True
            End If


        Else
            MessageBox.Show("Proses tidak bisa dilanjutkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cmd.Dispose()






    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        If String.IsNullOrWhiteSpace(txtNik.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtJabatan.Text) OrElse String.IsNullOrWhiteSpace(txtTelp.Text) OrElse String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
            MessageBox.Show("Data yang akan diubah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If btnUbah.Text = "&Ubah" Then
                btnUbah.Text = "&Batal"
                btnTambah.Enabled = False
                btnHapus.Enabled = False
                btnSimpan.Enabled = True
                aktif2()
                txtNik.Enabled = False
                txtNama.Focus()

                ListView1.Enabled = False
            Else
                btnUbah.Text = "&Ubah"
                FrmKaryawan_Load(Nothing, Nothing)
                nonaktif()
                'txtKode.Focus()
                FrmKaryawan_Load(Nothing, Nothing)
                btnTambah.Enabled = True
                btnHapus.Enabled = True
                ListView1.Enabled = True
            End If
        End If


    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If String.IsNullOrWhiteSpace(txtNik.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtJabatan.Text) OrElse String.IsNullOrWhiteSpace(txtTelp.Text) OrElse String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            ' Salah satu atau lebih bidang kosong, tampilkan pesan kesalahan
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
                btnTambah.Enabled = True
                btnHapus.Enabled = True
                btnUbah.Enabled = True

                ListView1.Enabled = True
            End If
        End If




    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        If ListView1.SelectedItems.Count > 0 Then
            ' Ambil item yang dipilih dari ListView
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Tampilkan data item yang dipilih di TextBox
            txtNik.Text = selectedItem.SubItems(0).Text
            txtNama.Text = selectedItem.SubItems(1).Text
            txtJabatan.Text = selectedItem.SubItems(2).Text
            txtTelp.Text = selectedItem.SubItems(3).Text
            txtAlamat.Text = selectedItem.SubItems(4).Text

            nonaktif()

        End If
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub


    Private Sub txtTelp_LostFocus(sender As Object, e As EventArgs) Handles txtTelp.LostFocus
        Dim angka As Double
        angka = Len((txtTelp.Text))
        If angka <> 12 Then
            MessageBox.Show("No telepon harus 12 karakter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTelp.Focus()
        End If
    End Sub

    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub




    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        'Me.Hide()
        ListPenjualan.Show()
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btnPenjualan_Click_1(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Me.Close()
        FSales.Show()
    End Sub

    Private Sub btnBarang_Click_1(sender As Object, e As EventArgs) Handles btnBarang.Click
        Me.Close()
        FrmBarang.Show()
    End Sub

    Private Sub btnUser_Click_1(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Close()
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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontRegular As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Integer = 20
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim rightMargin As Integer = e.MarginBounds.Right

        ' Header Laporan
        e.Graphics.DrawString("Laporan Data Karyawan Toko SembaPAS", fontTitle, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Jln. Rancapetir No. 6 Ciamis", fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("yyyy/MM/dd"), fontRegular, brush, leftMargin, yPos)
        yPos += 30

        ' Kolom ListView
        Dim columnSpacing As Integer = 120 ' jarak antar kolom
        e.Graphics.DrawString("Nomor Induk", fontBold, brush, leftMargin, yPos)
        e.Graphics.DrawString("Nama", fontBold, brush, leftMargin + columnSpacing, yPos)
        e.Graphics.DrawString("Jabatan", fontBold, brush, leftMargin + 2 * columnSpacing, yPos)
        e.Graphics.DrawString("Telepon", fontBold, brush, leftMargin + 3 * columnSpacing, yPos)
        e.Graphics.DrawString("Alamat", fontBold, brush, leftMargin + 4 * columnSpacing, yPos)
        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10

        ' Isi ListView

        For Each item As ListViewItem In ListView1.Items
            e.Graphics.DrawString(item.SubItems(0).Text, fontRegular, brush, leftMargin, yPos)
            e.Graphics.DrawString(item.SubItems(1).Text, fontRegular, brush, leftMargin + columnSpacing, yPos)
            e.Graphics.DrawString(item.SubItems(2).Text, fontRegular, brush, leftMargin + 2 * columnSpacing, yPos)
            e.Graphics.DrawString(item.SubItems(3).Text, fontRegular, brush, leftMargin + 3 * columnSpacing, yPos)
            e.Graphics.DrawString(item.SubItems(4).Text, fontRegular, brush, leftMargin + 4 * columnSpacing, yPos)
            yPos += 20

        Next

        ' Tambahkan garis pemisah sebelum total
        yPos += 10
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
    End Sub
End Class
