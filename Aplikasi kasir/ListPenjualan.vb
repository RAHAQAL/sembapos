Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ListPenjualan

    Private Sub FrmListPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM Ttransaksi"
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
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM Ttransaksi where id_transaksi like '" & TextBox1.Text & "%'"
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
End Class