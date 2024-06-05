Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmListBarang



    Private Sub FrmListBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        cmd.Connection = koneksi
        cmd.CommandText = "SELECT * FROM TBarang"
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
        cmd.CommandText = "SELECT * FROM TBarang where nama_barang like '" & TextBox1.Text & "%'"
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            FSales.txtBarang.Text = selectedItem.Text & " - " & selectedItem.SubItems(1).Text
            FTambahStok.txtBarang.Text = selectedItem.Text & " - " & selectedItem.SubItems(1).Text
            Me.Close()
        End If
    End Sub

End Class