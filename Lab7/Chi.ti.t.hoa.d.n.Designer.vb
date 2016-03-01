<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chi_tiết_hóa_đơn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chi_tiết_hóa_đơn))
        Me.lstchitiethoadon = New System.Windows.Forms.ListView()
        Me.clID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDsanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltensanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clngaytao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltonggia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtchitiethd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsanpham = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtdatetime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstchitiethoadon
        '
        Me.lstchitiethoadon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstchitiethoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clID, Me.IDsanpham, Me.cltensanpham, Me.clmota, Me.clngaytao, Me.clgia, Me.cltonggia})
        Me.lstchitiethoadon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lstchitiethoadon.FullRowSelect = True
        Me.lstchitiethoadon.GridLines = True
        Me.lstchitiethoadon.Location = New System.Drawing.Point(12, 203)
        Me.lstchitiethoadon.Name = "lstchitiethoadon"
        Me.lstchitiethoadon.Size = New System.Drawing.Size(739, 258)
        Me.lstchitiethoadon.TabIndex = 2
        Me.lstchitiethoadon.UseCompatibleStateImageBehavior = False
        Me.lstchitiethoadon.View = System.Windows.Forms.View.Details
        '
        'clID
        '
        Me.clID.Text = "ID"
        Me.clID.Width = 31
        '
        'IDsanpham
        '
        Me.IDsanpham.Text = "ID Sản phẩm"
        Me.IDsanpham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDsanpham.Width = 92
        '
        'cltensanpham
        '
        Me.cltensanpham.Text = "Tên sản phẩm"
        Me.cltensanpham.Width = 107
        '
        'clmota
        '
        Me.clmota.Text = "Mô tả"
        Me.clmota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmota.Width = 105
        '
        'clngaytao
        '
        Me.clngaytao.Text = "Ngày tạo"
        Me.clngaytao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clngaytao.Width = 112
        '
        'clgia
        '
        Me.clgia.Text = "Giá"
        Me.clgia.Width = 72
        '
        'cltonggia
        '
        Me.cltonggia.Text = "Tổng "
        Me.cltonggia.Width = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(235, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mô tả"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(235, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ngày tạo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(10, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sản phẩm"
        '
        'txtchitiethd
        '
        Me.txtchitiethd.Location = New System.Drawing.Point(105, 26)
        Me.txtchitiethd.Name = "txtchitiethd"
        Me.txtchitiethd.Size = New System.Drawing.Size(124, 20)
        Me.txtchitiethd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Chi Tiết HD"
        '
        'txtsanpham
        '
        Me.txtsanpham.Location = New System.Drawing.Point(105, 66)
        Me.txtsanpham.Name = "txtsanpham"
        Me.txtsanpham.Size = New System.Drawing.Size(124, 20)
        Me.txtsanpham.TabIndex = 2
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(292, 25)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(160, 20)
        Me.txtmota.TabIndex = 3
        '
        'txtdatetime
        '
        Me.txtdatetime.Location = New System.Drawing.Point(292, 71)
        Me.txtdatetime.Name = "txtdatetime"
        Me.txtdatetime.Size = New System.Drawing.Size(160, 20)
        Me.txtdatetime.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtdatetime)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btxoa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btsua)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btthem)
        Me.GroupBox1.Controls.Add(Me.txtmota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtsanpham)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtchitiethd)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 151)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(271, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CHI TIẾT HÓA ĐƠN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Lab7.My.Resources.Resources.Untitled_
        Me.PictureBox1.Location = New System.Drawing.Point(594, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btxoa
        '
        Me.btxoa.Image = CType(resources.GetObject("btxoa.Image"), System.Drawing.Image)
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(220, 112)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(64, 31)
        Me.btxoa.TabIndex = 7
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.Image = CType(resources.GetObject("btsua.Image"), System.Drawing.Image)
        Me.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsua.Location = New System.Drawing.Point(116, 112)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(64, 31)
        Me.btsua.TabIndex = 6
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Image = Global.Lab7.My.Resources.Resources.iconbar_addmodule
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(16, 112)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(64, 31)
        Me.btthem.TabIndex = 5
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = True
        '
        'Chi_tiết_hóa_đơn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 471)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstchitiethoadon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chi_tiết_hóa_đơn"
        Me.Text = "CHI TIẾT HÓA ĐƠN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstchitiethoadon As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    Friend WithEvents IDsanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents clngaytao As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltensanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clgia As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltonggia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtchitiethd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsanpham As System.Windows.Forms.TextBox
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents btsua As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtdatetime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
