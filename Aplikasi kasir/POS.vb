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



    Public Sub opendb()
        sql = "Data Source=DESKTOP-E16A8VK; Initial Catalog=SembaPOS;Integrated Security =True;"
        koneksi = New SqlConnection(sql)

        Try
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


End Module
