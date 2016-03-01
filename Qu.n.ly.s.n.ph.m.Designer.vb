<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quanlyhanghoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quanlyhanghoa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidsanpham = New System.Windows.Forms.TextBox()
        Me.Txttensanpham = New System.Windows.Forms.TextBox()
        Me.Txtloaisanpham = New System.Windows.Forms.TextBox()
        Me.Txtmota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.lstsanpham = New System.Windows.Forms.ListView()
        Me.clID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltensanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clgia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bthoadon = New System.Windows.Forms.Button()
        Me.btloaisanpham = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.Btthem = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(13, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(13, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loại sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(13, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mô tả"
        '
        'txtidsanpham
        '
        Me.txtidsanpham.Location = New System.Drawing.Point(109, 76)
        Me.txtidsanpham.Name = "txtidsanpham"
        Me.txtidsanpham.Size = New System.Drawing.Size(195, 20)
        Me.txtidsanpham.TabIndex = 1
        '
        'Txttensanpham
        '
        Me.Txttensanpham.Location = New System.Drawing.Point(109, 121)
        Me.Txttensanpham.Name = "Txttensanpham"
        Me.Txttensanpham.Size = New System.Drawing.Size(195, 20)
        Me.Txttensanpham.TabIndex = 2
        '
        'Txtloaisanpham
        '
        Me.Txtloaisanpham.Location = New System.Drawing.Point(109, 162)
        Me.Txtloaisanpham.Name = "Txtloaisanpham"
        Me.Txtloaisanpham.Size = New System.Drawing.Size(195, 20)
        Me.Txtloaisanpham.TabIndex = 3
        '
        'Txtmota
        '
        Me.Txtmota.Location = New System.Drawing.Point(109, 207)
        Me.Txtmota.Name = "Txtmota"
        Me.Txtmota.Size = New System.Drawing.Size(195, 20)
        Me.Txtmota.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(13, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Giá"
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(109, 248)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(195, 20)
        Me.txtgia.TabIndex = 5
        '
        'lstsanpham
        '
        Me.lstsanpham.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clID, Me.cltensanpham, Me.clloaisanpham, Me.cltenloai, Me.clmota, Me.clgia})
        Me.lstsanpham.FullRowSelect = True
        Me.lstsanpham.GridLines = True
        Me.lstsanpham.Location = New System.Drawing.Point(341, 7)
        Me.lstsanpham.Name = "lstsanpham"
        Me.lstsanpham.Size = New System.Drawing.Size(538, 386)
        Me.lstsanpham.TabIndex = 4
        Me.lstsanpham.UseCompatibleStateImageBehavior = False
        Me.lstsanpham.View = System.Windows.Forms.View.Details
        '
        'clID
        '
        Me.clID.Text = "ID"
        Me.clID.Width = 36
        '
        'cltensanpham
        '
        Me.cltensanpham.Text = "Tên sản phẩm"
        Me.cltensanpham.Width = 116
        '
        'clloaisanpham
        '
        Me.clloaisanpham.Text = "ID loại"
        Me.clloaisanpham.Width = 79
        '
        'cltenloai
        '
        Me.cltenloai.Text = "Tên loại"
        Me.cltenloai.Width = 90
        '
        'clmota
        '
        Me.clmota.Text = "Mô tả"
        Me.clmota.Width = 106
        '
        'clgia
        '
        Me.clgia.Text = "Giá"
        Me.clgia.Width = 157
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btloaisanpham)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btxoa)
        Me.GroupBox1.Controls.Add(Me.btsua)
        Me.GroupBox1.Controls.Add(Me.Btthem)
        Me.GroupBox1.Controls.Add(Me.bthoadon)
        Me.GroupBox1.Controls.Add(Me.Txtmota)
        Me.GroupBox1.Controls.Add(Me.txtgia)
        Me.GroupBox1.Controls.Add(Me.Txttensanpham)
        Me.GroupBox1.Controls.Add(Me.Txtloaisanpham)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidsanpham)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 379)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP THÔNG TIN"
        '
        'bthoadon
        '
        Me.bthoadon.BackColor = System.Drawing.Color.Transparent
        Me.bthoadon.ForeColor = System.Drawing.Color.Black
        Me.bthoadon.Location = New System.Drawing.Point(134, 339)
        Me.bthoadon.Name = "bthoadon"
        Me.bthoadon.Size = New System.Drawing.Size(87, 33)
        Me.bthoadon.TabIndex = 9
        Me.bthoadon.Text = "Xem hóa đơn"
        Me.bthoadon.UseVisualStyleBackColor = False
        '
        'btloaisanpham
        '
        Me.btloaisanpham.Location = New System.Drawing.Point(16, 338)
        Me.btloaisanpham.Name = "btloaisanpham"
        Me.btloaisanpham.Size = New System.Drawing.Size(87, 34)
        Me.btloaisanpham.TabIndex = 12
        Me.btloaisanpham.Text = "Loại sản phẩm"
        Me.btloaisanpham.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lab7.My.Resources.Resources.Untitled_
        Me.PictureBox1.Location = New System.Drawing.Point(121, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btxoa
        '
        Me.btxoa.ForeColor = System.Drawing.Color.Black
        Me.btxoa.Image = CType(resources.GetObject("btxoa.Image"), System.Drawing.Image)
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(18, 287)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(70, 35)
        Me.btxoa.TabIndex = 10
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.ForeColor = System.Drawing.Color.Black
        Me.btsua.Image = CType(resources.GetObject("btsua.Image"), System.Drawing.Image)
        Me.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsua.Location = New System.Drawing.Point(121, 287)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(70, 35)
        Me.btsua.TabIndex = 10
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsua.UseVisualStyleBackColor = True
        '
        'Btthem
        '
        Me.Btthem.ForeColor = System.Drawing.Color.Black
        Me.Btthem.Image = Global.Lab7.My.Resources.Resources.iconbar_addmodule
        Me.Btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btthem.Location = New System.Drawing.Point(234, 287)
        Me.Btthem.Name = "Btthem"
        Me.Btthem.Size = New System.Drawing.Size(70, 35)
        Me.Btthem.TabIndex = 10
        Me.Btthem.Text = "Thêm"
        Me.Btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btthem.UseVisualStyleBackColor = True
        '
        'Quanlyhanghoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 398)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstsanpham)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Quanlyhanghoa"
        Me.Text = "QUẢN LÝ SẢN PHẨM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtidsanpham As System.Windows.Forms.TextBox
    Friend WithEvents Txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents Txtloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents Txtmota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents lstsanpham As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltensanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clloaisanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents clgia As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bthoadon As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents btsua As System.Windows.Forms.Button
    Friend WithEvents Btthem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btloaisanpham As System.Windows.Forms.Button

End Class
