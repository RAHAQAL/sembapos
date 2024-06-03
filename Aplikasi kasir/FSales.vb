Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FSales

#Region "SUB"
    Sub nomorfakturotomatis()

        ' Mempersiapkan koneksi database 
        Dim koneksi As New SqlConnection(sql)
        ' Perintah untuk mendapatkan nilai terbesar dari field nomor 
        Dim cmd As New SqlCommand("select id_jual from TJual where id_jual in(select max(id_jual) from TJual) order by id_jual desc", koneksi)
        koneksi.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        rdr.Read()

        ' Variabel untuk menyimpan urutan faktur
        Dim urut As String

        ' Jika data ditemukan
        If rdr.HasRows Then
            ' Jika 8 karakter dari kiri pada field nomor tidak sama dengan Format(Now, "yyyyMMdd") 
            If Mid(rdr("id_jual").ToString(), 3, 8) <> Format(Now, "yyyyMMdd") Then
                ' Mengisi variable urut 
                urut = "SP" & Format(Now, "yyyyMMdd") & "0001"
            Else ' Menambahkan data dari field nomor 
                Dim hitung As Integer = Convert.ToInt32(rdr("id_jual").ToString().Substring(10)) + 1
                ' Mengisi variable urut
                urut = "SP" & Format(Now, "yyyyMMdd") & hitung.ToString("D4")
            End If
        Else ' Jika tidak ditemukan maka mengisi variable urut dengan format date yyyyMMdd+0001 
            urut = "SP" & Format(Now, "yyyyMMdd") & "0001"
        End If

        rdr.Close()
        koneksi.Close()
        Label6.Text = urut

    End Sub

    Sub HitungTotalBayar()
        Dim totalBayar As Double = 0.0
        For Each item As ListViewItem In ListView1.Items
            Dim totalItem As Double
            If Double.TryParse(item.SubItems(4).Text, totalItem) Then
                totalBayar += totalItem
            End If
        Next
        ' Tampilkan total bayar di label atau kontrol lainnya yang sesuai
        ' Misalnya, LabelTotalBayar.Text = totalBayar.ToString("C2")
        Label7.Text = totalBayar.ToString("C2")
    End Sub

#End Region

    Private Sub FSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpTanggal.Format = DateTimePickerFormat.Custom
        dtpTanggal.CustomFormat = "yyyy/MM/dd"
        opendb()
        txtKasir.Text = loggedInUserName
        nomorfakturotomatis()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FrmListBarang.Show()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtBarang.Text = "" Then
            MsgBox("Silahkan isi barang terlebih dahulu!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            txtBarang.Focus()
            Exit Sub
        ElseIf nudQty.Value = 0 Then
            MsgBox("Qty masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            nudQty.Focus()
            Exit Sub
        End If

        ' Query ke database untuk mendapatkan data "Nama", "Harga", dan "Satuan" dari tabel TBarang
        Dim nama As String = ""
        Dim harga As String = ""
        Dim idBarang As String = txtBarang.Text.Substring(0, Math.Min(5, txtBarang.Text.Length))

        ' Memeriksa apakah barang dengan ID yang sama sudah ada dalam ListView1
        For Each item As ListViewItem In ListView1.Items
            If item.SubItems(0).Text = idBarang Then
                MsgBox("Barang sudah ada, silahkan edit untuk menambah qty", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                txtBarang.Clear()
                nudQty.Value = 0
                txtBarang.Focus()
                Exit Sub
            End If
        Next

        ' Jika barang belum ada dalam ListView1, tambahkan barang baru
        ' Query ke database untuk mendapatkan data "Nama", "Harga", dan "Satuan" dari tabel TBarang
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT nama_barang, hargajual FROM TBarang WHERE id_barang = '" & idBarang & "'"
        rdr = cmd.ExecuteReader

        rdr.Read()
        If rdr.HasRows = True Then
            ' Mendapatkan data "Nama", "Harga", dan "Satuan" dari hasil query
            nama = rdr("nama_barang").ToString()
            harga = rdr("hargajual")
        Else
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            rdr.Close()
            cmd.Dispose()
            Exit Sub
        End If

        rdr.Close()
        cmd.Dispose()

        ' Buat item baru dalam ListView dengan data yang diambil dari database
        Dim lvItem As New ListViewItem(idBarang)

        lvItem.SubItems.Add(nama)   ' Menambahkan Nama
        lvItem.SubItems.Add(harga)  ' Menambahkan Harga
        lvItem.SubItems.Add(nudQty.Value)  ' Menambahkan Qty

        Dim totalItem As Double = harga * nudQty.Value

        ' Tambahkan item baru ke ListView dengan subitem total harga
        lvItem.SubItems.Add(totalItem.ToString()) ' Menambahkan Total Harga

        ' Tambahkan item ke ListView
        ListView1.Items.Add(lvItem)

        HitungTotalBayar()

        ' Bersihkan kontrol dan fokuskan kembali ke txtBarang
        txtBarang.Clear()
        nudQty.Value = 0
        txtBarang.Focus()
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Simpan nilai qty sebelum diedit
            Dim qtySebelumnya As Integer = Convert.ToInt32(selectedItem.SubItems(3).Text)

            ' Perbarui qty dengan nilai baru
            selectedItem.SubItems(3).Text = nudQty.Value.ToString()

            ' Ambil harga dari kolom ke-2 (indeks 1)
            Dim harga As Double = Convert.ToDouble(selectedItem.SubItems(2).Text)

            ' Hitung total harga untuk item yang diedit
            Dim totalItem As Double = harga * nudQty.Value

            ' Perbarui total harga pada kolom ke-4 (indeks 3)
            selectedItem.SubItems(4).Text = totalItem.ToString()

            ' Hitung total harga secara keseluruhan
            HitungTotalBayar()

            txtBarang.Clear()
            txtBarang.Enabled = True
            nudQty.Value = 0
            txtBarang.Focus()
            btnTambah.Enabled = True
        Else
            MsgBox("Tidak ada item yang dipilih untuk diedit", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If ListView1.SelectedItems.Count > 0 And txtBarang.Text <> "" Then
            ListView1.SelectedItems(0).Remove()

            HitungTotalBayar()

            txtBarang.Clear()
            txtBarang.Enabled = True
            nudQty.Value = 0
            txtBarang.Focus()
            btnTambah.Enabled = True

        Else
            MsgBox("Tidak ada item yang dipilih untuk dihapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            txtBarang.Text = selectedItem.SubItems(0).Text
            nudQty.Value = selectedItem.SubItems(3).Text

            txtBarang.Enabled = False
            nudQty.Focus()
            btnTambah.Enabled = False
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan pembelian?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Clear textbox
            txtBarang.Clear()
            dtpTanggal.Value = DateTime.Now
            nudQty.Value = 0
            Label7.Text = "Rp0,00"
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("Masukkan barang terlebih dahulu!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

        Dim koneksi As New SqlConnection(sql)
        Dim trans As SqlTransaction

        Try
            koneksi.Open()
            trans = koneksi.BeginTransaction()

            ' Insert into TJual
            Dim cmdJual As New SqlCommand("INSERT INTO TJual (id_jual, tanggal, total_bayar, kasir) VALUES (@id_jual, @tanggal, @total_bayar, @kasir)", koneksi, trans)
            cmdJual.Parameters.AddWithValue("@id_jual", Label6.Text)
            cmdJual.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy/MM/dd"))

            ' Konversi total bayar dari string ke double menggunakan TryParse
            Dim totalBayar As Double
            If Double.TryParse(Label7.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("id-ID"), totalBayar) Then
                cmdJual.Parameters.AddWithValue("@total_bayar", totalBayar)
            Else
                Throw New Exception("Format total bayar tidak valid.")
            End If

            cmdJual.Parameters.AddWithValue("@kasir", txtKasir.Text)
            cmdJual.ExecuteNonQuery()

            ' Insert into TDetailJual
            For Each item As ListViewItem In ListView1.Items
                Dim cmdDetailJual As New SqlCommand("INSERT INTO TDetailJual (id_jual, id_barang, harga_jual, jumlah, total_harga) VALUES (@id_jual, @id_barang, @harga_jual, @jumlah, @total_harga)", koneksi, trans)
                cmdDetailJual.Parameters.AddWithValue("@id_jual", Label6.Text)
                cmdDetailJual.Parameters.AddWithValue("@id_barang", item.SubItems(0).Text)

                ' Konversi harga jual dari string ke double menggunakan TryParse
                Dim hargaJual As Double
                If Double.TryParse(item.SubItems(2).Text, hargaJual) Then
                    cmdDetailJual.Parameters.AddWithValue("@harga_jual", hargaJual)
                Else
                    Throw New Exception("Format harga jual tidak valid.")
                End If

                ' Konversi jumlah dari string ke integer menggunakan TryParse
                Dim jumlah As Integer
                If Integer.TryParse(item.SubItems(3).Text, jumlah) Then
                    cmdDetailJual.Parameters.AddWithValue("@jumlah", jumlah)
                Else
                    Throw New Exception("Format jumlah tidak valid.")
                End If

                ' Konversi total harga dari string ke double menggunakan TryParse
                Dim totalHarga As Double
                If Double.TryParse(item.SubItems(4).Text, totalHarga) Then
                    cmdDetailJual.Parameters.AddWithValue("@total_harga", totalHarga)
                Else
                    Throw New Exception("Format total harga tidak valid.")
                End If

                cmdDetailJual.ExecuteNonQuery()
            Next

            trans.Commit()

            ' Tampilkan pesan informasi
            MsgBox("Transaksi berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

            ' Reset form setelah berhasil menyimpan
            txtBarang.Clear()
            dtpTanggal.Value = DateTime.Now
            nudQty.Value = 0
            Label7.Text = "Rp0,00"
            ListView1.Items.Clear()
            nomorfakturotomatis()

        Catch ex As Exception
            If Not IsNothing(trans) Then
                trans.Rollback()
            End If
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kesalahan")
        Finally
            koneksi.Close()
        End Try
    End Sub

End Class