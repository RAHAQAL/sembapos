Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmUser

#Region "SUB"

    Sub btnAktif()
        btnTambah.Enabled = True
        btnTambah.Text = "&Tambah"
        btnUbah.Enabled = True
        btnUbah.Text = "&Ubah"
        btnHapus.Enabled = True
        btnHapus.Text = "&Hapus"
        btnSimpan.Enabled = True
        btnCari.Enabled = True
        txtKode.Focus()
    End Sub

    Sub kodeuserotomatis()
        cmd = New SqlCommand("SELECT * FROM Tuser ORDER BY id_user DESC", koneksi)
        rdr = cmd.ExecuteReader
        rdr.Read()

        If Not rdr.HasRows = True Then
            ' Jika tidak ada data, inisialisasi dengan B-001
            txtKode.Text = "U-111"
        Else
            ' Jika ada data, ambil nilai terakhir dan tambahkan 1
            Dim lastId As Integer = Val(Microsoft.VisualBasic.Mid(rdr.Item("id_user").ToString, 3, 3)) + 1

            ' Format nilai menjadi B-XXX
            txtKode.Text = "U-" + lastId.ToString("D3")
        End If
    End Sub


    Sub listdata()

        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM Tuser"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While rdr.Read

            Dim lv As ListViewItem
            lv = ListView1.Items.Add(rdr(0))
            lv.SubItems.Add(rdr(1))
            lv.SubItems.Add(rdr(2))
            lv.SubItems.Add(rdr(3))

        Loop

        cmd.Dispose()
        rdr.Close()

    End Sub

    Sub aktif()
        txtKode.Focus()
        txtKode.Enabled = True
        txtNIK.Enabled = True
        txtPassword.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
    End Sub

    Sub aktif2()
        txtKode.Enabled = False
        txtNIK.Enabled = True
        txtPassword.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True

    End Sub

    Sub nonaktif()
        txtKode.Enabled = False
        txtNIK.Enabled = False
        txtPassword.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
    End Sub

    Sub clear()
        txtKode.Clear()
        txtNIK.Clear()
        txtPassword.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

#End Region

    Dim roleid As String




    Public Sub New()
        InitializeComponent()
        btnTambah.Text = "&Tambah"  ' Atur status awal tombol "Tambah"
        btnAktif()  ' Atur status awal kontrol lainnya jika diperlukan
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If btnTambah.Text = "&Batal" Then
            If txtNIK.Text = "" Then
                MsgBox("NIK masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNIK.Focus()
                Exit Sub
            ElseIf txtPassword.Text = "" Then
                MsgBox("Password masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtPassword.Focus()
                Exit Sub
            ElseIf Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
                MsgBox("Pilih salah satu Role ID terlebih dahulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")

                Exit Sub
            Else
                ' Check if the NIK exists in TKaryawan table
                cmd.Connection = koneksi
                cmd.CommandText = "SELECT COUNT(*) FROM TKaryawan WHERE nik = '" & txtNIK.Text & "'"
                Dim countTKaryawan As Integer = CInt(cmd.ExecuteScalar())

                If countTKaryawan = 0 Then
                    ' NIK is not registered in TKaryawan
                    MessageBox.Show("NIK yang anda masukkan tidak terdaftar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    kodeuserotomatis()
                    FrmUser_Load(Nothing, Nothing)
                    aktif2()
                    txtNIK.Focus()
                    Exit Sub
                End If

                ' Check if the NIK is not already registered in Tuser
                cmd.CommandText = "SELECT COUNT(*) FROM Tuser WHERE nik = '" & txtNIK.Text & "'"
                Dim countTuser As Integer = CInt(cmd.ExecuteScalar())

                If countTuser > 0 Then
                    ' NIK is already registered in Tuser
                    MessageBox.Show("NIK yang anda masukkan sudah terdaftar sebagai user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    kodeuserotomatis()
                    FrmUser_Load(Nothing, Nothing)
                    aktif2()
                    txtNIK.Focus()
                    Exit Sub
                End If

                ' Continue with the insert operation
                If RadioButton1.Checked Then
                    roleid = RadioButton1.Text
                ElseIf RadioButton2.Checked Then
                    roleid = RadioButton2.Text
                ElseIf RadioButton3.Checked Then
                    roleid = RadioButton3.Text
                End If

                cmd.CommandText = "INSERT INTO Tuser VALUES ('" & Trim(txtKode.Text) & "', '" & Trim(txtNIK.Text) & "', '" & Trim(txtPassword.Text) & "'," & _
                                    "'" & Trim(roleid) & "')"

                Dim rdr As SqlDataReader = cmd.ExecuteReader
                cmd.Dispose()
                rdr.Close()
                MsgBox("Data User Berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
                clear()
                btnTambah_Click(Nothing, Nothing)
                FrmUser_Load(Nothing, Nothing)
                txtKode.Focus()
                Exit Sub
            End If
            ListView1.Enabled = True



        ElseIf btnUbah.Text = "&Batal" Then

            If txtNIK.Text = "" Then
                MsgBox("NIK masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtNIK.Focus()
                Exit Sub
            ElseIf txtPassword.Text = "" Then
                MsgBox("Password masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtPassword.Focus()
                Exit Sub
            Else
                ' Check if the NIK exists in TKaryawan table
                cmd.Connection = koneksi
                cmd.CommandText = "SELECT COUNT(*) FROM TKaryawan WHERE nik = '" & txtNIK.Text & "'"
                Dim countTKaryawan As Integer = CInt(cmd.ExecuteScalar())

                If countTKaryawan = 0 Then
                    ' NIK is not registered in TKaryawan
                    MessageBox.Show("NIK yang anda masukkan tidak terdaftar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    kodeuserotomatis()
                    FrmUser_Load(Nothing, Nothing)
                    aktif2()
                    txtNIK.Focus()
                    Exit Sub
                End If

                ' Continue with the insert operation
                If RadioButton1.Checked Then
                    roleid = RadioButton1.Text
                ElseIf RadioButton2.Checked Then
                    roleid = RadioButton2.Text
                ElseIf RadioButton3.Checked Then
                    roleid = RadioButton3.Text
                End If



                cmd.Connection = koneksi
                cmd.CommandText = "UPDATE Tuser SET nik = '" & Trim(txtNIK.Text) & "', password = '" & Trim(txtPassword.Text) & "',roleid = '" & Trim(roleid) & "' WHERE id_user = '" & txtKode.Text & "'"

                Dim iya As String
                iya = MsgBox("Apakah anda yakin ingin mengubah data user tersebut?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING!!")
                If iya = vbYes Then
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    MessageBox.Show("Data user telah diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Else

                End If


                cmd.Connection = koneksi
                cmd.CommandText = "SELECT * FROM Tuser"
                rdr = cmd.ExecuteReader

                ListView1.Items.Clear()
                Do While rdr.Read()
                    Dim lv As ListViewItem
                    lv = ListView1.Items.Add(rdr(0))
                    lv.SubItems.Add(rdr(1))
                    lv.SubItems.Add(rdr(2))
                    lv.SubItems.Add(rdr(3))

                Loop
                cmd.Dispose()
                rdr.Close()

            End If
            clear()
            FrmUser_Load(Nothing, Nothing)
            btnAktif()
            aktif()
            txtKode.Focus()
            ListView1.Enabled = True




        ElseIf btnHapus.Text = "&Batal" Then

            If txtNIK.Text = "" OrElse txtPassword.Text = "" OrElse Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
                MessageBox.Show("Data user yang akan diubah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else

                cmd.Connection = koneksi
                cmd.CommandText = "delete Tuser WHERE id_user = '" & txtKode.Text & "'"
                Dim iya As String
                iya = MsgBox("Apakah anda yakin ingin menghapus?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING!!")
                If iya = vbYes Then
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Data user telah dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else


                End If

                cmd.Connection = koneksi
                cmd.CommandText = "SELECT * FROM Tuser"
                rdr = cmd.ExecuteReader

                ListView1.Items.Clear()
                Do While rdr.Read()
                    Dim lv As ListViewItem
                    lv = ListView1.Items.Add(rdr(0))
                    lv.SubItems.Add(rdr(1))
                    lv.SubItems.Add(rdr(2))
                    lv.SubItems.Add(rdr(3))
                Loop
                cmd.Dispose()
                rdr.Close()
            End If
            btnAktif()
            aktif()
            clear()
            FrmUser_Load(Nothing, Nothing)
            txtKode.Focus()
            ListView1.Enabled = True




        Else
            MsgBox("Proses tidak bisa dilanjutkan", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

    End Sub


    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click



        If txtNIK.Text = "" OrElse txtPassword.Text = "" OrElse Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
            MessageBox.Show("Data yang akan diubah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        Else

            If btnUbah.Text = "&Ubah" Then
                btnUbah.Text = "&Batal"
                btnTambah.Enabled = False
                btnHapus.Enabled = False
                btnSimpan.Enabled = True
                aktif2()
                txtNIK.Enabled = False
                txtPassword.Focus()
                ListView1.Enabled = False
            Else
                btnUbah.Text = "&Ubah"
                'clear()
                nonaktif()
                'txtKode.Focus()
                opendb()
                listdata()
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

            ' Tampilkan data item yang dipilih di TextBox dan ComboBox
            txtKode.Text = selectedItem.SubItems(0).Text
            txtNIK.Text = selectedItem.SubItems(1).Text

            txtPassword.Text = selectedItem.SubItems(2).Text
            Dim selectedValue As String = ListView1.SelectedItems(0).SubItems(3).Text

            ' Tentukan logika untuk mengisi Radio Button berdasarkan nilai yang diambil
            If selectedValue = "1" Then
                RadioButton1.Checked = True
            ElseIf selectedValue = "2" Then
                RadioButton2.Checked = True
            ElseIf selectedValue = "3" Then
                RadioButton3.Checked = True
            End If
            nonaktif()
        End If

    End Sub



    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "&Tambah" Then
            clear()
            kodeuserotomatis()
            btnTambah.Text = "&Batal"
            btnUbah.Enabled = False
            btnHapus.Enabled = False
            btnSimpan.Enabled = True
            aktif2()
            txtNIK.Focus()
            opendb()
            listdata()
            ListView1.Enabled = False

        Else
            btnTambah.Text = "&Tambah"
            btnUbah.Enabled = True
            btnHapus.Enabled = True
            aktif()
            clear()
            FrmUser_Load(Nothing, Nothing)
            txtKode.Focus()
            ListView1.Enabled = True

        End If
    End Sub







    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click



        If txtNIK.Text = "" OrElse txtPassword.Text = "" OrElse Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
            MessageBox.Show("Data yang akan dihapus tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
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
                ListView1.Enabled = True

            End If

        End If

    End Sub

    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        listdata()
        Label6.Text = "Hi, " & loggedInUserName & "!"
        UpdateMenuBasedOnRole()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FrmListKaryawan.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FSales.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmBarang.Show()
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmKaryawan.Show()
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

    Private Sub btnBarang_Click_1(sender As Object, e As EventArgs) Handles btnBarang.Click
        Me.Hide()
        FrmBarang.Show()
    End Sub

    Private Sub btnKaryawan_Click_1(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Me.Hide()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

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
End Class