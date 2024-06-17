Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Dashboard

#Region "SUB"
    Sub UpdateJumlahBarang()
        Try
            cmd = New SqlCommand("SELECT COUNT(*) FROM TBarang", koneksi)
            Dim jumlahBarang As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label7.Text = jumlahBarang
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghitung jumlah barang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub UpdateJumlahPenjualan()
        Try
            cmd = New SqlCommand("SELECT COUNT(*) FROM TJual", koneksi)
            Dim jumlahPenjualan As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label10.Text = jumlahPenjualan
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghitung jumlah barang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub UpdateTotalOmset()
        Try
            cmd = New SqlCommand("SELECT SUM(total_bayar) FROM TJual", koneksi)
            Dim totalOmset As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            ' Format uang Indonesia
            Dim culture As CultureInfo = New CultureInfo("id-ID")
            Label12.Text = totalOmset.ToString("C", culture)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghitung total omset: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub Chart()

        cmd.Connection = koneksi
        cmd.CommandText = "select sum(total_bayar) as penjualan, MONTH(tanggal) as bulan from TJual where Year(tanggal) = Year(GETDATE()) group by MONTH(tanggal)"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        While rdr.Read
            ChartJB.Series("Penjualan").Points.AddXY(rdr.Item("bulan"), rdr.Item("penjualan"))
        End While
        cmd.Dispose()
        rdr.Close()
    End Sub

    Sub ChartTop3()

        Dim cmd As New SqlCommand()
        cmd.Connection = koneksi

        ' Adapt the query based on your database system
        cmd.CommandText = "SELECT TOP 3 b.nama_barang AS Nama_Barang, SUM(dj.jumlah) AS Total_Terjual " & _
                           "FROM TDetailJual dj " & _
                           "INNER JOIN TBarang b ON b.id_barang = dj.id_barang " & _
                           "GROUP BY b.nama_barang " & _
                           "ORDER BY Total_Terjual DESC"

        Dim rdr As SqlDataReader = cmd.ExecuteReader()

        ' Populate your chart with retrieved data
        While rdr.Read()
            Top3.Series("Produk").Points.AddXY(rdr.Item("Nama_Barang"), rdr.Item("Total_Terjual"))
        End While
        cmd.Dispose()
        rdr.Close()
    End Sub


#End Region


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Label6.Visible = False
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            Label6.Visible = True
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        Chart()
        ChartTop3()
        UpdateMenuBasedOnRole()
        Label1.Text = "Hi, " & loggedInUserName & "!"
        UpdateJumlahBarang()
        UpdateJumlahPenjualan()
        UpdateTotalOmset()
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Me.Close()
        FSales.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        Me.Close()
        FrmBarang.Show()
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        Me.Close()
        FrmKaryawan.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
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


    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ListPenjualan.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class