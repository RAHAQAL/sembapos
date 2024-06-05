Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FTambahStok

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FrmListBarang.Show()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtBarang.Text = "" Then
            MsgBox("ID Barang masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            txtBarang.Focus()
            Exit Sub
        ElseIf nudQty.Value = 0 Then
            MsgBox("Qty masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            nudQty.Focus()
            Exit Sub
        Else
            Dim karakter As String = txtBarang.Text.Substring(0, 5)

            ' Query untuk memeriksa apakah id_barang ada dalam database
            Dim queryCheckIdBarang As String = "SELECT COUNT(*) FROM TBarang WHERE LEFT(id_barang, 5) = @karakter"
            cmd.CommandText = queryCheckIdBarang
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@karakter", karakter)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count = 0 Then
                MsgBox("ID Barang tidak ditemukan dalam database.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                Exit Sub
            End If

            ' Jika id_barang ditemukan dalam database, lanjutkan dengan menambahkan stok
            Dim queryUpdateStok As String = "UPDATE TBarang SET stok = stok + @qty WHERE LEFT(id_barang, 5) = @karakter"
            cmd.CommandText = queryUpdateStok
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(nudQty.Value))
            cmd.Parameters.AddWithValue("@karakter", karakter)
            cmd.ExecuteNonQuery()

            MsgBox("Stok barang berhasil diperbarui", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            txtBarang.Clear()
            nudQty.Value = 0
        End If
    End Sub

    Private Sub FTambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
    End Sub
End Class