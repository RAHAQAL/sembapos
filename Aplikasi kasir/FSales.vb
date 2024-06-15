Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing

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

        ' Panggil HitungKembalian setiap kali total bayar berubah
        HitungKembalian()
    End Sub

    Sub HitungKembalian()
        Dim totalBayar As Double
        Dim tunai As Double
        Dim kembalian As Double

        ' Konversi total bayar dari string ke double
        If Double.TryParse(Label7.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("id-ID"), totalBayar) AndAlso Double.TryParse(txtTunai.Text, tunai) Then
            kembalian = tunai - totalBayar
            txtKembalian.Text = kembalian.ToString("C2", Globalization.CultureInfo.GetCultureInfo("id-ID"))
        Else
            txtKembalian.Text = "Rp0,00"
        End If
    End Sub


#End Region


    Private Sub FSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateMenuBasedOnRole()
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
            txtTunai.Clear()
            txtKembalian.Clear()
            txtNote.Clear()
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("Masukkan barang terlebih dahulu!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

        ' Menampilkan konfirmasi sebelum menyimpan
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menyimpan transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim koneksi As New SqlConnection(sql)
        Dim trans As SqlTransaction

        Try
            koneksi.Open()
            trans = koneksi.BeginTransaction()

            ' Insert into TJual
            Dim cmdJual As New SqlCommand("INSERT INTO TJual (id_jual, tanggal, total_bayar, kasir,tunai,kembalian,note) VALUES (@id_jual, @tanggal, @total_bayar, @kasir,@tunai,@kembalian,@note)", koneksi, trans)
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
            cmdJual.Parameters.AddWithValue("@tunai", txtTunai.Text)

            Dim kembalian As Double
            If Double.TryParse(txtKembalian.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.GetCultureInfo("id-ID"), kembalian) Then
                cmdJual.Parameters.AddWithValue("@kembalian", kembalian)
            Else
                Throw New Exception("Format total bayar tidak valid.")
            End If

            cmdJual.Parameters.AddWithValue("@note", txtNote.Text)
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

            PrintPreviewDialog1.Document = PrintDocument2
            PrintPreviewDialog1.ShowDialog()


            ' Reset form setelah berhasil menyimpan
            txtBarang.Clear()
            dtpTanggal.Value = DateTime.Now
            nudQty.Value = 0
            Label7.Text = "Rp0,00"
            txtTunai.Clear()
            txtKembalian.Clear()
            txtNote.Clear()
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



   

    Private Sub txtTunai_TextChanged(sender As Object, e As EventArgs) Handles txtTunai.TextChanged
        HitungKembalian()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
















    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage

        Dim paperWidth As Integer = 200 ' Lebar kertas dalam satuan piksel
        Dim paperHeight As Integer = 250 ' Tinggi kertas dalam satuan piksel
        e.PageSettings.PaperSize = New PaperSize("Custom", paperWidth, paperHeight)

        Dim fontRegular As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        Dim yPos As Integer = 20
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim rightMargin As Integer = e.MarginBounds.Right

        e.Graphics.DrawString("Toko SembaPAS", fontTitle, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Jln. Rancapetir No. 6 Ciamis", fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Nomor Faktur: " & Label6.Text, fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Tanggal: " & dtpTanggal.Value.ToString("yyyy/MM/dd"), fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Kasir: " & txtKasir.Text, fontRegular, brush, leftMargin, yPos)
        yPos += 30

        ' Kolom ListView
        e.Graphics.DrawString("ID Barang", fontBold, brush, leftMargin, yPos)
        e.Graphics.DrawString("Nama Barang", fontBold, brush, leftMargin + 100, yPos)
        e.Graphics.DrawString("Harga", fontBold, brush, leftMargin + 300, yPos)
        e.Graphics.DrawString("Qty", fontBold, brush, leftMargin + 400, yPos)
        e.Graphics.DrawString("Total", fontBold, brush, leftMargin + 450, yPos)
        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10

        For Each item As ListViewItem In ListView1.Items
            e.Graphics.DrawString(item.SubItems(0).Text, fontRegular, brush, leftMargin, yPos)
            e.Graphics.DrawString(item.SubItems(1).Text, fontRegular, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString(item.SubItems(2).Text, fontRegular, brush, leftMargin + 300, yPos)
            e.Graphics.DrawString(item.SubItems(3).Text, fontRegular, brush, leftMargin + 400, yPos)
            e.Graphics.DrawString(item.SubItems(4).Text, fontRegular, brush, leftMargin + 450, yPos)
            yPos += 20
        Next

        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10
        e.Graphics.DrawString("Total Bayar: " & Label7.Text, fontBold, brush, leftMargin, yPos)
        yPos += 20

        Dim tunaiFormatted As String = Double.Parse(txtTunai.Text).ToString("C", New Globalization.CultureInfo("id-ID"))
        e.Graphics.DrawString("Tunai: " & tunaiFormatted, fontRegular, brush, leftMargin, yPos)
        yPos += 20

        e.Graphics.DrawString("Kembalian: " & txtKembalian.Text, fontRegular, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Terima kasih telah berbelanja!", fontRegular, brush, leftMargin, yPos)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnBarang_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmBarang.Show()
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmUser.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        'Me.Hide()
        ListPenjualan.Show()
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Tampilkan kotak dialog konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih Yes, maka tutup form
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnUser_Click_1(sender As Object, e As EventArgs) Handles btnUser.Click
        Me.Hide()
        FrmUser.Show()
    End Sub

    Private Sub btnKaryawan_Click_1(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Me.Hide()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnBarang_Click_1(sender As Object, e As EventArgs) Handles btnBarang.Click
        Me.Hide()
        FrmBarang.Show()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub


    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class