<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quản_lý_hóa_đơn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quản_lý_hóa_đơn))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btkhachhang = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtngaytao = New System.Windows.Forms.DateTimePicker()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtghichu = New System.Windows.Forms.TextBox()
        Me.txtchitiethoadon = New System.Windows.Forms.TextBox()
        Me.txtidkhachhang = New System.Windows.Forms.TextBox()
        Me.txtidhoadon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstquanlyhoadon = New System.Windows.Forms.ListView()
        Me.clIDhoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clIDkhachhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clctchoadon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngaytao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clghichu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenkhachhang = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btxoa)
        Me.GroupBox1.Controls.Add(Me.btthem)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtngaytao)
        Me.GroupBox1.Controls.Add(Me.txttimkiem)
        Me.GroupBox1.Controls.Add(Me.txttenkhachhang)
        Me.GroupBox1.Controls.Add(Me.txtghichu)
        Me.GroupBox1.Controls.Add(Me.txtchitiethoadon)
        Me.GroupBox1.Controls.Add(Me.txtidkhachhang)
        Me.GroupBox1.Controls.Add(Me.txtidhoadon)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bttimkiem)
        Me.GroupBox1.Controls.Add(Me.btsua)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP THÔNG TIN"
        '
        'btkhachhang
        '
        Me.btkhachhang.Location = New System.Drawing.Point(579, 107)
        Me.btkhachhang.Name = "btkhachhang"
        Me.btkhachhang.Size = New System.Drawing.Size(75, 23)
        Me.btkhachhang.TabIndex = 6
        Me.btkhachhang.Text = "Khách hàng"
        Me.btkhachhang.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(428, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tên khách hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(428, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày tạo"
        '
        'txtngaytao
        '
        Me.txtngaytao.Location = New System.Drawing.Point(490, 22)
        Me.txtngaytao.Name = "txtngaytao"
        Me.txtngaytao.Size = New System.Drawing.Size(164, 20)
        Me.txtngaytao.TabIndex = 3
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(430, 138)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(223, 20)
        Me.txttimkiem.TabIndex = 2
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(520, 83)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(134, 20)
        Me.txttenkhachhang.TabIndex = 2
        '
        'txtghichu
        '
        Me.txtghichu.Location = New System.Drawing.Point(314, 83)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(89, 20)
        Me.txtghichu.TabIndex = 2
        '
        'txtchitiethoadon
        '
        Me.txtchitiethoadon.Location = New System.Drawing.Point(314, 26)
        Me.txtchitiethoadon.Name = "txtchitiethoadon"
        Me.txtchitiethoadon.Size = New System.Drawing.Size(89, 20)
        Me.txtchitiethoadon.TabIndex = 2
        '
        'txtidkhachhang
        '
        Me.txtidkhachhang.Location = New System.Drawing.Point(109, 83)
        Me.txtidkhachhang.Name = "txtidkhachhang"
        Me.txtidkhachhang.Size = New System.Drawing.Size(92, 20)
        Me.txtidkhachhang.TabIndex = 2
        '
        'txtidhoadon
        '
        Me.txtidhoadon.Location = New System.Drawing.Point(109, 26)
        Me.txtidhoadon.Name = "txtidhoadon"
        Me.txtidhoadon.Size = New System.Drawing.Size(92, 20)
        Me.txtidhoadon.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(226, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Trạng thái"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(226, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Chi tiết HD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'lstquanlyhoadon
        '
        Me.lstquanlyhoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clIDhoadon, Me.clIDkhachhang, Me.clctchoadon, Me.clngaytao, Me.clghichu, Me.cltenkhachhang})
        Me.lstquanlyhoadon.FullRowSelect = True
        Me.lstquanlyhoadon.GridLines = True
        Me.lstquanlyhoadon.Location = New System.Drawing.Point(12, 242)
        Me.lstquanlyhoadon.Name = "lstquanlyhoadon"
        Me.lstquanlyhoadon.Size = New System.Drawing.Size(667, 236)
        Me.lstquanlyhoadon.TabIndex = 1
        Me.lstquanlyhoadon.UseCompatibleStateImageBehavior = False
        Me.lstquanlyhoadon.View = System.Windows.Forms.View.Details
        '
        'clIDhoadon
        '
        Me.clIDhoadon.Text = "ID"
        Me.clIDhoadon.Width = 27
        '
        'clIDkhachhang
        '
        Me.clIDkhachhang.Text = "ID Khách hàng"
        Me.clIDkhachhang.Width = 93
        '
        'clctchoadon
        '
        Me.clctchoadon.Text = "ID_CT Hóa đơn"
        Me.clctchoadon.Width = 92
        '
        'clngaytao
        '
        Me.clngaytao.Text = "Ngày tạo"
        Me.clngaytao.Width = 126
        '
        'clghichu
        '
        Me.clghichu.Text = "Trạng thái"
        Me.clghichu.Width = 121
        '
        'cltenkhachhang
        '
        Me.cltenkhachhang.Text = "Tên khách hàng"
        Me.cltenkhachhang.Width = 203
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(292, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "HÓA ĐƠN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lab7.My.Resources.Resources.Untitled_
        Me.PictureBox1.Location = New System.Drawing.Point(532, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btxoa
        '
        Me.btxoa.Image = CType(resources.GetObject("btxoa.Image"), System.Drawing.Image)
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(201, 131)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(69, 32)
        Me.btxoa.TabIndex = 0
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Image = Global.Lab7.My.Resources.Resources.iconbar_addmodule
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(19, 130)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(69, 32)
        Me.btthem.TabIndex = 0
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btthem.UseVisualStyleBackColor = True
        '
        'bttimkiem
        '
        Me.bttimkiem.Image = CType(resources.GetObject("bttimkiem.Image"), System.Drawing.Image)
        Me.bttimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttimkiem.Location = New System.Drawing.Point(314, 130)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(89, 33)
        Me.bttimkiem.TabIndex = 0
        Me.bttimkiem.Text = "Tìm kiếm"
        Me.bttimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.Image = CType(resources.GetObject("btsua.Image"), System.Drawing.Image)
        Me.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsua.Location = New System.Drawing.Point(108, 130)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(69, 32)
        Me.btsua.TabIndex = 0
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsua.UseVisualStyleBackColor = True
        '
        'Quản_lý_hóa_đơn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstquanlyhoadon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Quản_lý_hóa_đơn"
        Me.Text = "HÓA ĐƠN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtghichu As System.Windows.Forms.TextBox
    Friend WithEvents txtchitiethoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtidkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtidhoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttimkiem As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents btsua As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents lstquanlyhoadon As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtngaytao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents clIDhoadon As System.Windows.Forms.ColumnHeader
    Friend WithEvents clIDkhachhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents clctchoadon As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngaytao As System.Windows.Forms.ColumnHeader
    Friend WithEvents clghichu As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenkhachhang As System.Windows.Forms.ColumnHeader
    Friend WithEvents btkhachhang As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
