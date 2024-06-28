<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChartJB = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Top3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.ChartJB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.Top3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 46)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnLaporan)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnUser)
        Me.Panel2.Controls.Add(Me.btnKaryawan)
        Me.Panel2.Controls.Add(Me.btnBarang)
        Me.Panel2.Controls.Add(Me.btnPenjualan)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 699)
        Me.Panel2.TabIndex = 1
        '
        'btnLaporan
        '
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), System.Drawing.Image)
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(45, 227)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(132, 32)
        Me.btnLaporan.TabIndex = 7
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(45, 465)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(132, 32)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(20, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "_____________________________"
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(45, 390)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(132, 32)
        Me.btnUser.TabIndex = 4
        Me.btnUser.Text = "   User"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnKaryawan
        '
        Me.btnKaryawan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnKaryawan.Image = CType(resources.GetObject("btnKaryawan.Image"), System.Drawing.Image)
        Me.btnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.Location = New System.Drawing.Point(45, 335)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(132, 32)
        Me.btnKaryawan.TabIndex = 3
        Me.btnKaryawan.Text = "   Karyawan"
        Me.btnKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKaryawan.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBarang.Image = CType(resources.GetObject("btnBarang.Image"), System.Drawing.Image)
        Me.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Location = New System.Drawing.Point(45, 281)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(132, 32)
        Me.btnBarang.TabIndex = 2
        Me.btnBarang.Text = "   Barang"
        Me.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPenjualan.FlatAppearance.BorderSize = 0
        Me.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenjualan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnPenjualan.Image = CType(resources.GetObject("btnPenjualan.Image"), System.Drawing.Image)
        Me.btnPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPenjualan.Location = New System.Drawing.Point(45, 171)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(132, 32)
        Me.btnPenjualan.TabIndex = 1
        Me.btnPenjualan.Text = "   Penjualan"
        Me.btnPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.Location = New System.Drawing.Point(45, 114)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(132, 32)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(267, 149)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(214, 159)
        Me.Panel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(19, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Produk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 40)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "12"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(1004, 149)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(316, 159)
        Me.Panel6.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Completed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(29, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Plant for 2023"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.ChartJB)
        Me.Panel7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(267, 339)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(702, 332)
        Me.Panel7.TabIndex = 3
        '
        'ChartJB
        '
        Me.ChartJB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisX.Title = "Bulan"
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.AxisY.Title = "Total Penjualan"
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.Name = "ChartArea1"
        Me.ChartJB.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.ChartJB.Legends.Add(Legend3)
        Me.ChartJB.Location = New System.Drawing.Point(0, 15)
        Me.ChartJB.Name = "ChartJB"
        Me.ChartJB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ChartJB.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))}
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Penjualan"
        Me.ChartJB.Series.Add(Series3)
        Me.ChartJB.Size = New System.Drawing.Size(699, 314)
        Me.ChartJB.TabIndex = 0
        Me.ChartJB.Text = "Penjualan"
        Title3.BackColor = System.Drawing.Color.White
        Title3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "JumlahPenjualan"
        Title3.Text = "Grafik Penjualan"
        Me.ChartJB.Titles.Add(Title3)
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Top3)
        Me.Panel8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(1004, 339)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(316, 332)
        Me.Panel8.TabIndex = 4
        '
        'Top3
        '
        ChartArea4.AxisX.MajorGrid.Enabled = False
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.MajorGrid.Enabled = False
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.Name = "ChartArea1"
        Me.Top3.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Top3.Legends.Add(Legend4)
        Me.Top3.Location = New System.Drawing.Point(0, 15)
        Me.Top3.Name = "Top3"
        Me.Top3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Top3.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(175, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))}
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.LabelForeColor = System.Drawing.Color.White
        Series4.Legend = "Legend1"
        Series4.Name = "Produk"
        Series4.YValuesPerPoint = 4
        Me.Top3.Series.Add(Series4)
        Me.Top3.Size = New System.Drawing.Size(313, 314)
        Me.Top3.TabIndex = 0
        Me.Top3.Text = "Produk Terlaris"
        Title4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "ProdukTerlaris"
        Title4.Text = "Produk Terlaris"
        Me.Top3.Titles.Add(Title4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(265, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hi Fahri!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Welcome to SembaPOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1089, 64)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 31)
        Me.TextBox1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(1092, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "       Search"
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(1018, 67)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(22, 23)
        Me.Button7.TabIndex = 21
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1041, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(511, 149)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(214, 159)
        Me.Panel4.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(19, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Transaksi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 40)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "12"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(755, 149)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(214, 159)
        Me.Panel5.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(19, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Omset Penjualan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(19, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 28)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Rp124.000.000,00"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SembaPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.ChartJB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.Top3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnPenjualan As System.Windows.Forms.Button
    Friend WithEvents btnBarang As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnKaryawan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ChartJB As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Top3 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
