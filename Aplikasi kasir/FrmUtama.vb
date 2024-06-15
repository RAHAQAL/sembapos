Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FrmUtama



#Region "SUB"
    'Sub UpdateMenuBasedOnRole()
    '    If mroleid = "1" Then
    '        MASTERToolStripMenuItem.Enabled = False
    '        TRANSAKSIToolStripMenuItem.Enabled = False
    '        LAPORANToolStripMenuItem.Enabled = True
    '        MAINTENANCEToolStripMenuItem.Enabled = True
    '    ElseIf mroleid = "2" Then
    '        MASTERToolStripMenuItem.Enabled = True
    '        TRANSAKSIToolStripMenuItem.Enabled = False
    '        LAPORANToolStripMenuItem.Enabled = False
    '        MAINTENANCEToolStripMenuItem.Enabled = False
    '    ElseIf mroleid = "3" Then
    '        MASTERToolStripMenuItem.Enabled = False
    '        TRANSAKSIToolStripMenuItem.Enabled = True
    '        LAPORANToolStripMenuItem.Enabled = False
    '        MAINTENANCEToolStripMenuItem.Enabled = False
    '    End If
    'End Sub


    'Sub OpenFormInTab(ByVal childForm As Form)
    '    ' Cek apakah formulir anak sudah terbuka
    '    For Each tabPage As TabPage In TabControl1.TabPages
    '        If tabPage.Controls.Contains(childForm) Then
    '            TabControl1.SelectedTab = tabPage
    '            Return
    '        End If
    '    Next

    '    ' Jika formulir anak belum terbuka, buka di dalam tab baru
    '    Dim newTab As New TabPage()
    '    newTab.Text = childForm.Text

    '    Dim closeButton As New Button()
    '    closeButton.Text = "Tutup"
    '    closeButton.Dock = DockStyle.Right
    '    AddHandler closeButton.Click, AddressOf CloseButton_Click
    '    newTab.Controls.Add(closeButton)

    '    childForm.TopLevel = False
    '    childForm.FormBorderStyle = FormBorderStyle.None
    '    childForm.Dock = DockStyle.Fill

    '    newTab.Controls.Add(childForm)
    '    TabControl1.TabPages.Add(newTab)
    '    TabControl1.SelectedTab = newTab

    '    TabControl1.SizeMode = TabSizeMode.Normal

    '    childForm.Show()
    'End Sub

    'Sub CloseTab(ByVal tab As TabPage)
    '    If tab IsNot Nothing Then
    '        tab.Dispose() ' Menutup dan menghapus tab
    '    End If
    'End Sub

#End Region

    Private Sub FrmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UpdateMenuBasedOnRole()
    End Sub

    'Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
    '    LoginForm1.MdiParent = Me
    '    LoginForm1.Show()
    'End Sub

    'Private Sub CloseButton_Click(sender As Object, e As EventArgs)
    '    Dim closeButton As Button = DirectCast(sender, Button)
    '    Dim tab As TabPage = DirectCast(closeButton.Parent, TabPage)

    '    CloseTab(tab)
    'End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        FrmKaryawan.MdiParent = Me
        FrmKaryawan.Show()
    End Sub


    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FSales.MdiParent = Me
        FSales.Show()
        'FPenjualan.MdiParent = Me
        'FPenjualan.Show()
    End Sub


    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        ' Tampilkan kotak dialog konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika pengguna memilih Yes, maka tutup form
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MANAGEUSERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANAGEUSERToolStripMenuItem.Click
        FrmUser.MdiParent = Me
        FrmUser.Show()
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        ListBarang.MdiParent = Me
        ListBarang.Show()
    End Sub

    Private Sub PENJUALANToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PENJUALANToolStripMenuItem1.Click
        ListPenjualan.MdiParent = Me
        ListPenjualan.Show()
    End Sub



    
    Private Sub KARYAWANToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KARYAWANToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles KARYAWANToolStripMenuItem1.Click
        ListKaryawan.MdiParent = Me
        ListKaryawan.Show()
    End Sub
End Class

