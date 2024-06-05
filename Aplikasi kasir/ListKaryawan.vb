Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class ListKaryawan

    Private Sub ListKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TKaryawan where nama like '" & TextBox1.Text & "%'"
        rdr = cmd.ExecuteReader
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

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontRegular As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Integer = 20
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim rightMargin As Integer = e.MarginBounds.Right

        ' Header Laporan
        e.Graphics.DrawString("Laporan Karyawan Toko SembaPAS", fontTitle, brush, leftMargin, yPos)
        yPos += 30
        e.Graphics.DrawString("Jln. Rancapetir No. 6 Ciamis", fontRegular, brush, leftMargin, yPos)
        yPos += 20
        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("yyyy/MM/dd"), fontRegular, brush, leftMargin, yPos)
        yPos += 30

        ' Kolom ListView
        e.Graphics.DrawString("NIK", fontBold, brush, leftMargin, yPos)
        e.Graphics.DrawString("Nama", fontBold, brush, leftMargin + 100, yPos)
        e.Graphics.DrawString("Jabatan", fontBold, brush, leftMargin + 200, yPos)
        e.Graphics.DrawString("Telepon", fontBold, brush, leftMargin + 320, yPos)
        e.Graphics.DrawString("Alamat", fontBold, brush, leftMargin + 450, yPos)
        yPos += 20
        e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos)
        yPos += 10

        ' Isi ListView
        For Each item As ListViewItem In ListView1.Items
            e.Graphics.DrawString(item.SubItems(0).Text, fontRegular, brush, leftMargin, yPos)
            e.Graphics.DrawString(item.SubItems(1).Text, fontRegular, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString(item.SubItems(2).Text, fontRegular, brush, leftMargin + 200, yPos)
            e.Graphics.DrawString(item.SubItems(3).Text, fontRegular, brush, leftMargin + 320, yPos)
            e.Graphics.DrawString(item.SubItems(4).Text, fontRegular, brush, leftMargin + 450, yPos)
            yPos += 20
        Next
    End Sub

    Private Function FormatCurrency(value As String) As String
        Dim amount As Decimal
        If Decimal.TryParse(value, amount) Then
            Return String.Format("Rp{0:N2}", amount)
        End If
        Return value
    End Function


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class