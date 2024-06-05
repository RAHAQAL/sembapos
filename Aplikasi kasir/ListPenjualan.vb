Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ListPenjualan

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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class