Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class FPenjualan

#Region "SUB"

    Sub listdata()

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

        Loop

        cmd.Dispose()
        rdr.Close()

    End Sub


    Sub aktif()
        txtIdJual.Focus()
        txtIdJual.Enabled = True
        dtpTanggal.Enabled = True
    End Sub

    Sub aktif2()
        txtIdJual.Enabled = False
        dtpTanggal.Enabled = True
    End Sub

#End Region

    Private Sub FPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        listdata()
    End Sub

    Sub GenerateNomorFakturRandom()
        Dim random As New Random()
        Dim randomPart As String = random.Next(1000, 9999).ToString()
        Dim datePart As String = Format(Now, "yyyyMMdd")
        Dim nomorFaktur As String = datePart & randomPart

        txtIdJual.Text = nomorFaktur
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "&Tambah" Then
            btnTambah.Text = "&Batal"
            txtIdJual.Clear()
            GenerateNomorFakturRandom()
            aktif2()
            FPenjualan_Load(Nothing, Nothing)

            ListView1.Enabled = False

        Else
            btnTambah.Text = "&Tambah"
            txtIdJual.Clear()
            FPenjualan_Load(Nothing, Nothing)
            aktif()
            txtIdJual.Focus()
            ListView1.Enabled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtIdJual.Text = "" Then
            MsgBox("ID Jual masih kosong, silahkan diisi dulu...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            txtIdJual.Focus()
            Exit Sub
        Else
            cmd.Connection = koneksi
            cmd.CommandText = "INSERT INTO TJual VALUES ('" & Trim(txtIdJual.Text) & "', '" & Trim(dtpTanggal.Value.ToString("dd/MM/yyyy")) & "', '', 'Tunai')"
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            cmd.Dispose()
            rdr.Close()
            MsgBox("Data Jual Berhasil disimpan", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            txtIdJual.Clear()
            btnTambah_Click(Nothing, Nothing)
            FPenjualan_Load(Nothing, Nothing)
            txtIdJual.Focus()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            selectedIdJual = ListView1.SelectedItems(0).SubItems(0).Text

            ' Buka form FDetailJual
            Dim detailForm As New FDetailJual()
            FDetailJual.IdJual = selectedIdJual
            Me.Hide()
            FDetailJual.Show()

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class