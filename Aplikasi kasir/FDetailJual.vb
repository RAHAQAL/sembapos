Public Class FDetailJual

    Public Property IdJual As String
        Get
            Return _IdJual
        End Get
        Set(value As String)
            _IdJual = value
        End Set
    End Property

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
        Dim satuan As String = ""
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT nama_barang, hargajual, satuan FROM TBarang WHERE id_barang = LEFT('" & txtBarang.Text & "', 5)"
        rdr = cmd.ExecuteReader

        rdr.Read()
        If rdr.HasRows = True Then
            ' Mendapatkan data "Nama", "Harga", dan "Satuan" dari hasil query
            nama = rdr("nama_barang").ToString()
            harga = rdr("hargajual")
            satuan = rdr("satuan").ToString()
        Else
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            rdr.Close()
            cmd.Dispose()
            Exit Sub
        End If

        rdr.Close()
        cmd.Dispose()

        ' Buat item baru dalam ListView dengan data yang diambil dari database
        Dim idBarang As String = txtBarang.Text.Substring(0, Math.Min(5, txtBarang.Text.Length))
        Dim lvItem As New ListViewItem(idBarang)

        lvItem.SubItems.Add(nama)   ' Menambahkan Nama
        lvItem.SubItems.Add(harga)  ' Menambahkan Harga
        lvItem.SubItems.Add(nudQty.Value)  ' Menambahkan Qty
        lvItem.SubItems.Add(satuan) ' Menambahkan Satuan

        ' Tambahkan item ke ListView
        ListView1.Items.Add(lvItem)

        ' Bersihkan kontrol dan fokuskan kembali ke txtBarang
        txtBarang.Clear()
        nudQty.Value = 0
        txtBarang.Focus()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FrmListBarang.Show()
    End Sub

    Private Sub txtBarang_TextChanged(sender As Object, e As EventArgs) Handles txtBarang.TextChanged
        
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ListView1.Items.Count = 0 Then
            MsgBox("Tidak ada detail jual untuk disimpan!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

        cmd.Connection = koneksi

        For Each item As ListViewItem In ListView1.Items
            Dim idBarang As String = item.SubItems(0).Text
            Dim jumlah As Integer = Convert.ToInt32(item.SubItems(3).Text)
            Dim hargaJual As Integer = Convert.ToInt32(item.SubItems(2).Text)
            Dim satuan As String = item.SubItems(4).Text

            cmd.CommandText = "INSERT INTO TDetailJual (id_jual, id_barang, jumlah, harga_jual, satuan) VALUES (@IdJual, @IdBarang, @Jumlah, @HargaJual, @Satuan)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@IdJual", IdJual)
            cmd.Parameters.AddWithValue("@IdBarang", idBarang)
            cmd.Parameters.AddWithValue("@Jumlah", jumlah)
            cmd.Parameters.AddWithValue("@HargaJual", hargaJual)
            cmd.Parameters.AddWithValue("@Satuan", satuan)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Gagal menyimpan data: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                Exit Sub
            End Try
        Next

        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ListView1.Items.Clear()
        Me.Close()
        FPenjualan.Show()
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            selectedItem.SubItems(3).Text = nudQty.Value.ToString()

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

            txtBarang.Clear()
            txtBarang.Enabled = True
            nudQty.Value = 0
            txtBarang.Focus()
            btnTambah.Enabled = True

        Else
            MsgBox("Tidak ada item yang dipilih untuk dihapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub

    Private Sub nudQty_ValueChanged(sender As Object, e As EventArgs) Handles nudQty.ValueChanged

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        FPenjualan.Show()
    End Sub
End Class