Imports System.Data.Sql
Imports System.Data.SqlClient

Module POS
    Public koneksi As SqlConnection
    Public cmd As New SqlCommand
    Public rdr As SqlDataReader
    Public sql As String
    Public txt As String
    Public musername As String
    Public mpassword As String
    Public mnama As String
    Public mroleid As String
    Public jumlahPercobaanGagal As Integer = 0
    Public ModeTambah As Boolean = False
    Public ModeUbah As Boolean = False
    Public ModeHapus As Boolean = False
    Public urut As String
    Public hitung As String
    Public ada As Boolean
    Public pilih As Boolean
    Public selectedIdJual As String
    Public _IdJual As String
    Public loggedInUserName As String



    Public Sub opendb()
        sql = "Data Source=LAB1PC14; Initial Catalog=SembaPOS;Integrated Security =True;"
        koneksi = New SqlConnection(sql)

        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub UpdateMenuBasedOnRole()
        If mroleid = "1" Then
            Dashboard.btnPenjualan.Enabled = False
            FrmBarang.btnPenjualan.Enabled = False
            FrmKaryawan.btnPenjualan.Enabled = False
            FrmUser.btnPenjualan.Enabled = False

            Dashboard.btnKaryawan.Enabled = False
            FrmBarang.btnKaryawan.Enabled = False
            FrmKaryawan.btnKaryawan.Enabled = False
            FrmUser.btnKaryawan.Enabled = False

            Dashboard.btnBarang.Enabled = False
            FrmBarang.btnBarang.Enabled = False
            FrmKaryawan.btnBarang.Enabled = False
            FrmUser.btnBarang.Enabled = False

            Dashboard.btnUser.Enabled = True
            FrmBarang.btnUser.Enabled = True
            FrmKaryawan.btnUser.Enabled = True
            FrmUser.btnUser.Enabled = True

            Dashboard.btnLaporan.Enabled = True
            FrmBarang.btnLaporan.Enabled = True
            FrmKaryawan.btnLaporan.Enabled = True
            FrmUser.btnLaporan.Enabled = True

        ElseIf mroleid = "2" Then
            Dashboard.btnPenjualan.Enabled = False
            FrmBarang.btnPenjualan.Enabled = False
            FrmKaryawan.btnPenjualan.Enabled = False
            FrmUser.btnPenjualan.Enabled = False

            Dashboard.btnKaryawan.Enabled = True
            FrmBarang.btnKaryawan.Enabled = True
            FrmKaryawan.btnKaryawan.Enabled = True
            FrmUser.btnKaryawan.Enabled = True

            Dashboard.btnBarang.Enabled = True
            FrmBarang.btnBarang.Enabled = True
            FrmKaryawan.btnBarang.Enabled = True
            FrmUser.btnBarang.Enabled = True

            Dashboard.btnUser.Enabled = False
            FrmBarang.btnUser.Enabled = False
            FrmKaryawan.btnUser.Enabled = False
            FrmUser.btnUser.Enabled = False

            Dashboard.btnLaporan.Enabled = False
            FrmBarang.btnLaporan.Enabled = False
            FrmKaryawan.btnLaporan.Enabled = False
            FrmUser.btnLaporan.Enabled = False

        ElseIf mroleid = "3" Then
            Dashboard.btnPenjualan.Enabled = True
            FrmBarang.btnPenjualan.Enabled = True
            FrmKaryawan.btnPenjualan.Enabled = True
            FrmUser.btnPenjualan.Enabled = True

            Dashboard.btnKaryawan.Enabled = False
            FrmBarang.btnKaryawan.Enabled = False
            FrmKaryawan.btnKaryawan.Enabled = False
            FrmUser.btnKaryawan.Enabled = False
            FSales.btnKaryawan.Enabled = False

            Dashboard.btnBarang.Enabled = False
            FrmBarang.btnBarang.Enabled = False
            FrmKaryawan.btnBarang.Enabled = False
            FrmUser.btnBarang.Enabled = False
            FSales.btnBarang.Enabled = False

            Dashboard.btnUser.Enabled = False
            FrmBarang.btnUser.Enabled = False
            FrmKaryawan.btnUser.Enabled = False
            FrmUser.btnUser.Enabled = False
            FSales.btnUser.Enabled = False

            Dashboard.btnLaporan.Enabled = False
            FrmBarang.btnLaporan.Enabled = False
            FrmKaryawan.btnLaporan.Enabled = False
            FrmUser.btnLaporan.Enabled = False
            FSales.btnLaporan.Enabled = False

        End If
    End Sub


End Module
