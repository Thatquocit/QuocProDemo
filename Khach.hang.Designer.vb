<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khách_hàng
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Khách_hàng))
        Me.lstvkhachhang = New System.Windows.Forms.ListView()
        Me.clmakh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cldiachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clsodt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstvkhachhang
        '
        Me.lstvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmakh, Me.cltenkh, Me.cldiachi, Me.clsodt})
        Me.lstvkhachhang.FullRowSelect = True
        Me.lstvkhachhang.GridLines = True
        Me.lstvkhachhang.Location = New System.Drawing.Point(12, 12)
        Me.lstvkhachhang.Name = "lstvkhachhang"
        Me.lstvkhachhang.Size = New System.Drawing.Size(350, 351)
        Me.lstvkhachhang.TabIndex = 1
        Me.lstvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lstvkhachhang.View = System.Windows.Forms.View.Details
        '
        'clmakh
        '
        Me.clmakh.Text = "Mã khách hàng"
        Me.clmakh.Width = 38
        '
        'cltenkh
        '
        Me.cltenkh.Text = "Tên khách hàng"
        Me.cltenkh.Width = 93
        '
        'cldiachi
        '
        Me.cldiachi.Text = "Địa chỉ"
        Me.cldiachi.Width = 99
        '
        'clsodt
        '
        Me.clsodt.Text = "Số điện thoại"
        Me.clsodt.Width = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtsodt)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.txttenkh)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Controls.Add(Me.btxoa)
        Me.GroupBox1.Controls.Add(Me.btsua)
        Me.GroupBox1.Controls.Add(Me.btthem)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 276)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(17, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Số điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(17, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(17, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã khách hàng"
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(149, 180)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(116, 20)
        Me.txtsodt.TabIndex = 4
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(149, 132)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(116, 20)
        Me.txtdiachi.TabIndex = 3
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(149, 88)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(116, 20)
        Me.txttenkh.TabIndex = 2
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(149, 45)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(116, 20)
        Me.txtmakh.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lab7.My.Resources.Resources.Untitled_
        Me.PictureBox1.Location = New System.Drawing.Point(453, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btxoa
        '
        Me.btxoa.Image = Global.Lab7.My.Resources.Resources._erase
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(191, 236)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 30)
        Me.btxoa.TabIndex = 7
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.Image = Global.Lab7.My.Resources.Resources.sua2
        Me.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsua.Location = New System.Drawing.Point(99, 236)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(75, 30)
        Me.btsua.TabIndex = 6
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Image = Global.Lab7.My.Resources.Resources.iconbar_addmodule1
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(7, 236)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 30)
        Me.btthem.TabIndex = 5
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = True
        '
        'Khách_hàng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 375)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstvkhachhang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Khách_hàng"
        Me.Text = "Khách hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents btsua As System.Windows.Forms.Button
    Friend WithEvents lstvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents clmakh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenkh As System.Windows.Forms.ColumnHeader
    Friend WithEvents cldiachi As System.Windows.Forms.ColumnHeader
    Friend WithEvents clsodt As System.Windows.Forms.ColumnHeader
End Class
