Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class ListPenjualan

    Dim selectedPenjualanId As String

    Private Sub ListPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TJual"
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While rdr.Read

            Dim lv As ListViewItem
            lv = ListView1.Items.Add(rdr(0))
            lv.SubItems.Add(rdr(1))
            lv.SubItems.Add(rdr(2))
            lv.SubItems.Add(rdr(3))
            lv.SubItems.Add(rdr(4))
            lv.SubItems.Add(rdr(5))
            lv.SubItems.Add(rdr(6))

        Loop

        cmd.Dispose()
        rdr.Close()


        AddHandler ListView1.ItemSelectionChanged, AddressOf ListView1_ItemSelectionChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TJual where id_jual like '" & TextBox1.Text & "%'"
        rdr = cmd.ExecuteReader
        ListView1.Items.Clear()
        Do While rdr.Read

            Dim lv As ListViewItem
            lv = ListView1.Items.Add(rdr(0))
            lv.SubItems.Add(rdr(1))
            lv.SubItems.Add(rdr(2))
            lv.SubItems.Add(rdr(3))
            lv.SubItems.Add(rdr(4))
            lv.SubItems.Add(rdr(5))
            lv.SubItems.Add(rdr(6))

        Loop

        cmd.Dispose()
        rdr.Close()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        If e.IsSelected Then
            selectedPenjualanId = e.Item.Text
            PrintPreviewDialog2.Document = PrintDocument2
            PrintPreviewDialog2.ShowDialog()
        End If
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
        e.Graphics.DrawString("Laporan Penjualan Toko SembaPAS", fontTitle, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Jln. Rancapetir No. 6 Ciamis", fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("yyyy/MM/dd"), fontRegular, brush, leftMargin, yPos)
        yPos += 30

        ' Kolom ListView
        Dim columnSpacing As Integer = 120 ' jarak antar kolom
        e.Graphics.DrawString("Nomor Faktur", fontBold, brush, leftMargin, yPos)
        e.Graphics.DrawString("Tanggal", fontBold, brush, leftMargin + columnSpacing, yPos)
        e.Graphics.DrawString("Total Bayar", fontBold, brush, leftMargin + 2 * columnSpacing, yPos)
        e.Graphics.DrawString("Kasir", fontBold, brush, leftMargin + 3 * columnSpacing, yPos)
        e.Graphics.DrawString("Tunai", fontBold, brush, leftMargin + 4 * columnSpacing, yPos)
        e.Graphics.DrawString("Kembalian", fontBold, brush, leftMargin + 5 * columnSpacing, yPos)
        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10

        ' Isi ListView
        Dim totalBayar As Decimal = 0
        Dim totalTunai As Decimal = 0
        Dim totalKembalian As Decimal = 0

        For Each item As ListViewItem In ListView1.Items
            e.Graphics.DrawString(item.SubItems(0).Text, fontRegular, brush, leftMargin, yPos)
            e.Graphics.DrawString(item.SubItems(1).Text, fontRegular, brush, leftMargin + columnSpacing, yPos)
            e.Graphics.DrawString(FormatCurrency(item.SubItems(2).Text), fontRegular, brush, leftMargin + 2 * columnSpacing, yPos)
            e.Graphics.DrawString(item.SubItems(3).Text, fontRegular, brush, leftMargin + 3 * columnSpacing, yPos)
            e.Graphics.DrawString(FormatCurrency(item.SubItems(4).Text), fontRegular, brush, leftMargin + 4 * columnSpacing, yPos)
            e.Graphics.DrawString(FormatCurrency(item.SubItems(5).Text), fontRegular, brush, leftMargin + 5 * columnSpacing, yPos)
            yPos += 20

            ' Akumulasi total
            totalBayar += Convert.ToDecimal(item.SubItems(2).Text)
            totalTunai += Convert.ToDecimal(item.SubItems(4).Text)
            totalKembalian += Convert.ToDecimal(item.SubItems(5).Text)
        Next

        ' Tambahkan garis pemisah sebelum total
        yPos += 10
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10

        ' Tampilkan total
        e.Graphics.DrawString("Total Keseluruhan", fontBold, brush, leftMargin, yPos)
        e.Graphics.DrawString(FormatCurrency(totalBayar), fontBold, brush, leftMargin + 2 * columnSpacing, yPos)
        e.Graphics.DrawString(FormatCurrency(totalTunai), fontBold, brush, leftMargin + 4 * columnSpacing, yPos)
        e.Graphics.DrawString(FormatCurrency(totalKembalian), fontBold, brush, leftMargin + 5 * columnSpacing, yPos)
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

        ' Header Laporan
        e.Graphics.DrawString("Toko SembaPAS", fontTitle, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Jln. Rancapetir No. 6 Ciamis", fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Nomor Faktur: " & selectedPenjualanId, fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("yyyy/MM/dd"), fontRegular, brush, leftMargin, yPos)
        yPos += 20

        ' Ambil data dari TJual
        Dim kasir As String = ""
        Dim tunai As Decimal = 0
        Dim kembalian As Decimal = 0

        cmd.Connection = koneksi
        cmd.CommandText = "SELECT kasir, tunai, kembalian FROM TJual WHERE id_jual = @id_jual"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id_jual", selectedPenjualanId)
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        If rdr.Read() Then
            kasir = rdr("kasir").ToString()
            tunai = Convert.ToDecimal(rdr("tunai"))
            kembalian = Convert.ToDecimal(rdr("kembalian"))
        End If
        rdr.Close()

        e.Graphics.DrawString("Kasir: " & kasir, fontRegular, brush, leftMargin, yPos)
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

        ' Ambil detail penjualan dari database berdasarkan selectedPenjualanId
        cmd.CommandText = "SELECT TDetailJual.id_barang, TBarang.nama_barang, TDetailJual.harga_jual, TDetailJual.jumlah, TDetailJual.total_harga " & _
                          "FROM TDetailJual " & _
                          "INNER JOIN TBarang ON TDetailJual.id_barang = TBarang.id_barang " & _
                          "WHERE TDetailJual.id_jual = @id_jual"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id_jual", selectedPenjualanId)
        rdr = cmd.ExecuteReader
        Dim total As Decimal = 0

        Do While rdr.Read
            e.Graphics.DrawString(rdr("id_barang").ToString(), fontRegular, brush, leftMargin, yPos)
            e.Graphics.DrawString(rdr("nama_barang").ToString(), fontRegular, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString(FormatCurrency(rdr("harga_jual").ToString()), fontRegular, brush, leftMargin + 300, yPos)
            e.Graphics.DrawString(rdr("jumlah").ToString(), fontRegular, brush, leftMargin + 400, yPos)
            e.Graphics.DrawString(FormatCurrency(rdr("total_harga").ToString()), fontRegular, brush, leftMargin + 450, yPos)
            yPos += 20
            total += Convert.ToDecimal(rdr("total_harga"))
        Loop
        rdr.Close()

        ' Tambahkan garis pemisah sebelum total
        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10
        e.Graphics.DrawString("Total Bayar: " & FormatCurrency(total), fontBold, brush, leftMargin, yPos)
        yPos += 20

        Dim tunaiFormatted As String = tunai.ToString("C", New Globalization.CultureInfo("id-ID"))
        e.Graphics.DrawString("Tunai: " & tunaiFormatted, fontRegular, brush, leftMargin, yPos)
        yPos += 20

        e.Graphics.DrawString("Kembalian: " & FormatCurrency(kembalian), fontRegular, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Terima kasih telah berbelanja!", fontRegular, brush, leftMargin, yPos)
    End Sub




    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

End Class