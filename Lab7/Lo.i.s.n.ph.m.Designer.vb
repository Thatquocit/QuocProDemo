<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fomloaisanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fomloaisanpham))
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btsua = New System.Windows.Forms.Button()
        Me.lstloaisanpham = New System.Windows.Forms.ListView()
        Me.clmaloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btthem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btxoa
        '
        Me.btxoa.Image = Global.Lab7.My.Resources.Resources._erase
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(336, 101)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 39)
        Me.btxoa.TabIndex = 6
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btsua
        '
        Me.btsua.Image = Global.Lab7.My.Resources.Resources.sua2
        Me.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsua.Location = New System.Drawing.Point(336, 55)
        Me.btsua.Name = "btsua"
        Me.btsua.Size = New System.Drawing.Size(75, 39)
        Me.btsua.TabIndex = 5
        Me.btsua.Text = "Sửa"
        Me.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btsua.UseVisualStyleBackColor = True
        '
        'lstloaisanpham
        '
        Me.lstloaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmaloai, Me.cltenloai, Me.clmota})
        Me.lstloaisanpham.FullRowSelect = True
        Me.lstloaisanpham.GridLines = True
        Me.lstloaisanpham.Location = New System.Drawing.Point(12, 12)
        Me.lstloaisanpham.Name = "lstloaisanpham"
        Me.lstloaisanpham.Size = New System.Drawing.Size(318, 128)
        Me.lstloaisanpham.TabIndex = 1
        Me.lstloaisanpham.UseCompatibleStateImageBehavior = False
        Me.lstloaisanpham.View = System.Windows.Forms.View.Details
        '
        'clmaloai
        '
        Me.clmaloai.Text = "Mã loại"
        '
        'cltenloai
        '
        Me.cltenloai.Text = "Tên loại"
        Me.cltenloai.Width = 123
        '
        'clmota
        '
        Me.clmota.Text = "Mô tả"
        Me.clmota.Width = 125
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(479, 20)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(94, 20)
        Me.txtmaloai.TabIndex = 1
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(479, 63)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(94, 20)
        Me.txttenloai.TabIndex = 2
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(479, 101)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(94, 20)
        Me.txtmota.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mô tả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên loại"
        '
        'btthem
        '
        Me.btthem.Image = Global.Lab7.My.Resources.Resources.iconbar_addmodule1
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(336, 10)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 39)
        Me.btthem.TabIndex = 4
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btthem.UseVisualStyleBackColor = True
        '
        'fomloaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 143)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txttenloai)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.lstloaisanpham)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.btsua)
        Me.Controls.Add(Me.btxoa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fomloaisanpham"
        Me.Text = "Loại sản phẩm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents btsua As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents lstloaisanpham As System.Windows.Forms.ListView
    Friend WithEvents clmaloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
