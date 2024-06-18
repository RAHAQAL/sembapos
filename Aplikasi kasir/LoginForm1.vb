Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient



Public Class LoginForm1

#Region "SUB"
    Sub login()
        Try
            ' Validasi input
            If txtuser.Text.Trim() = "" And txtPassword.Text.Trim() = "" Then
                MsgBox("Masukkan Username dan Password", MsgBoxStyle.OkOnly, "POS")
                txtuser.Focus()
                Return
            ElseIf txtuser.Text.Trim() = "" Then
                MsgBox("Masukkan Username", MsgBoxStyle.OkOnly, "POS")
                txtuser.Focus()
                Return
            ElseIf txtPassword.Text.Trim() = "" Then
                MsgBox("Masukkan Password", MsgBoxStyle.OkOnly, "POS")
                txtPassword.Focus()
                Return
            End If

            cekuser()

            ' Cek apakah username ada
            If rdr.HasRows = False Then
                MsgBox("Username tidak ada", MsgBoxStyle.OkOnly, "POS")
                cmd.Dispose()
                rdr.Close()
                txtuser.Clear()
                txtuser.Focus()
                Return
            End If

            cmd.Dispose()
            rdr.Close()

            ' Cek password
            Find_User()

            If mpassword <> Trim(txtPassword.Text) Then
                MsgBox("Password salah!", MsgBoxStyle.OkOnly, "POS")
                cmd.Dispose()
                rdr.Close()
                txtPassword.Clear()
                txtPassword.Focus()

                jumlahPercobaanGagal += 1
                If jumlahPercobaanGagal >= 3 Then
                    MsgBox("Anda sudah melebihi batas percobaan gagal. Program akan ditutup.", MsgBoxStyle.OkOnly, "POS")
                    Me.Close()
                End If

                Return
            End If

            ' Login berhasil, sesuaikan menu berdasarkan role
            loggedInUserName = mnama
            txtuser.Text = ""
            txtPassword.Text = ""

            Dashboard.Show()

            ' Beri tahu form utama bahwa login berhasil
            Dim Utama As Dashboard = DirectCast(Application.OpenForms("Dashboard"), Dashboard)
            If Utama IsNot Nothing Then
                UpdateMenuBasedOnRole()
            End If

            cmd.Dispose()
            rdr.Close()
            Me.Hide()

        Catch When Err.Number <> 0
            MsgBox("Tidak dapat melakukan proses" & vbCrLf & Err.Description)
            koneksi.Close()
        End Try
    End Sub



    Sub cekuser()
        cmd.Connection = koneksi
        cmd.CommandText = ("SELECT * FROM TUser WHERE [NIK] = '" & Trim(txtuser.Text) & "' ")
        rdr = cmd.ExecuteReader
    End Sub


    Sub Find_User()
        cmd.CommandText = ("Select TUser.NIK, TUser.[Password],TKaryawan.[nama], TUser.RoleID" & _
        " FROM TKaryawan INNER JOIN TUser ON TKaryawan.NIK = TUser.NIK where TUser.NIK='" & Trim(txtuser.Text) + "' ")
        rdr = cmd.ExecuteReader
        rdr.Read()
        If rdr.HasRows = True Then
            musername = rdr.Item("NIK")
            mpassword = rdr.Item("Password")
            mnama = rdr.Item("nama")
            mroleid = rdr.Item("RoleID")
        End If
    End Sub

#End Region


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        login()

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        Me.AcceptButton = OK
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub




    Private Sub txtuser_GotFocus(sender As Object, e As EventArgs) Handles txtuser.GotFocus
        Label5.Visible = False
    End Sub

    Private Sub txtuser_LostFocus(sender As Object, e As EventArgs) Handles txtuser.LostFocus
        If txtuser.Text = "" Then
            Label5.Visible = True
        End If
    End Sub


    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        Label4.Visible = False
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            Label4.Visible = True
        End If
    End Sub



    Private Sub OK_Paint(sender As Object, e As PaintEventArgs) Handles OK.Paint
        Dim buttonPath As GraphicsPath = New GraphicsPath()
        Dim cornerRadius As Integer = 20 ' Radius for the corners

        buttonPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        buttonPath.AddArc(OK.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        buttonPath.AddArc(OK.Width - cornerRadius, OK.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        buttonPath.AddArc(0, OK.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        buttonPath.CloseFigure()

        OK.Region = New Region(buttonPath)
    End Sub

    

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim panelPath As GraphicsPath = New GraphicsPath()
        Dim cornerRadius As Integer = 25 ' Ukuran radius sudut

        panelPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        panelPath.AddArc(Panel1.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        panelPath.AddArc(Panel1.Width - cornerRadius, Panel1.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        panelPath.AddArc(0, Panel1.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        panelPath.CloseFigure()

        Panel1.Region = New Region(panelPath)
    End Sub




End Class
