Imports System.Drawing.Drawing2D



Public Class LoginForm1

#Region "SUB"
    Sub login()
        Try
            'Mencari data user berdasarkan NIK yang dimasukkan pada txtuser
            'CekUser()
            'tidak boleh mengkosongkan username & password

            If txtuser.Text.Trim() = "" And _
                   txtPassword.Text.Trim() = "" Then
                MsgBox("Masukan Username dan Password", MsgBoxStyle.OkOnly, "POS")
                txtuser.Focus()
            ElseIf txtuser.Text = "" Then
                MsgBox("Masukan Username ", MsgBoxStyle.OkOnly, "POS")
                txtuser.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("Masukan password ", MsgBoxStyle.OkOnly, "POS")
                txtPassword.Focus()
            Else
                cekuser()

                'jika username dan password tidak kosong, maka program akan mengecek
                'apakah data yang dicari tersedia pada objDataTable.
                'Jika Tidak (baris data = 0 ) maka akan keluar pesan 
                'bahwa username tidak ada

                If rdr.HasRows = False Then
                    MsgBox("Username tidak ada ", MsgBoxStyle.OkOnly, "POS")
                    cmd.Dispose() : rdr.Close()
                    txtuser.Clear() : txtuser.Focus()
                Else
                    cmd.Dispose() : rdr.Close()
                    'jika data yang di cari ada, maka program akan mencari password
                    'berdasarkan username (NIK) yang dimasukkan.
                    Find_User()
                    'jika password yang di masukkan salah atau tidak sama
                    ' dengan yang ada pada tabel, maka akan keluar pesan dari program
                    If mpassword <> Trim(txtPassword.Text) Then
                        MsgBox("Password salah!", MsgBoxStyle.OkOnly, "POS")
                        cmd.Dispose() : rdr.Close()
                        txtPassword.Clear() : txtPassword.Focus()

                        jumlahPercobaanGagal += 1
                        If jumlahPercobaanGagal >= 3 Then
                            MsgBox("Anda sudah melebihi batas percobaan gagal. Program akan ditutup.", MsgBoxStyle.OkOnly, "POS")
                            Me.Close()
                        End If


                        Exit Sub
                    ElseIf mroleid = "1" Then
                        'Jika benar program akan menampilkan pada form utama
                        txtuser.Text = ""
                        txtPassword.Text = ""

                        FrmUtama.Show()


                        ' Beri tahu form utama bahwa login berhasil
                        Dim Utama As FrmUtama = DirectCast(Application.OpenForms("FrmUtama"), FrmUtama)
                        If Utama IsNot Nothing Then
                            FrmUtama.UpdateMenuBasedOnRole()
                        End If

                        cmd.Dispose()
                        rdr.Close()
                        Me.Hide()

                    Else
                        txtuser.Text = ""
                        txtPassword.Text = ""

                        FrmUtama.Show()

                        Dim Utama As FrmUtama = DirectCast(Application.OpenForms("FrmUtama"), FrmUtama)
                        If Utama IsNot Nothing Then
                            FrmUtama.UpdateMenuBasedOnRole()
                        End If

                        cmd.Dispose()
                        rdr.Close()
                        Me.Hide()
                    End If
                End If
            End If
        Catch When Err.Number <> 0
            MsgBox("Tidak dapat melakukan proses" _
            & vbCrLf & Err.Description)
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
        txtuser.Focus()

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_TextChanged_1(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class
