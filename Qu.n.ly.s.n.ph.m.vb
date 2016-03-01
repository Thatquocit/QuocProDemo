Imports System.Data
Imports System.Data.SqlClient
Public Class Quanlyhanghoa
    Dim ketnoidulieu As New SqlConnection("workstation id=itofmeqlbanhang.mssql.somee.com;packet size=4096;user id=spiderman94_SQLLogin_1;pwd=rghlt5qn4v;data source=itofmeqlbanhang.mssql.somee.com;persist security info=False;initial catalog=itofmeqlbanhang")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select ID_san_pham,Ten_san_pham,San_Pham.ID_Loai_san_pham,Ten_loai,San_pham.Mo_ta,Gia from San_Pham join Loai_san_pham on San_Pham.ID_Loai_san_pham=Loai_san_pham.ID_loai_san_pham", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstsanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstsanpham.Items.Add(hang("ID_san_pham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Ten_san_pham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("ID_Loai_san_pham").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Ten_loai").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Mo_ta").ToString())
            lstsanpham.Items(i).SubItems.Add(hang("Gia").ToString())
            i += 1
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub

    Private Sub lstsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstsanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstsanpham.SelectedItems
            txtidsanpham.Text = List.SubItems(0).Text
            Txttensanpham.Text = List.SubItems(1).Text
            Txtloaisanpham.Text = List.SubItems(2).Text
            Txtmota.Text = List.SubItems(4).Text
            txtgia.Text = List.SubItems(5).Text
        Next
    End Sub
    Private Function kiemtradulieu() As Boolean
        If Txttensanpham.Text = "" Then
            MessageBox.Show("Chưa nhập tên sản phẩm")
            Return False
        ElseIf Txtloaisanpham.Text = "" Then
            MessageBox.Show("Chưa nhập loại sản phẩm")
            Return False
        ElseIf txtgia.Text = "" Then
            MessageBox.Show("Chưa nhập giá sản phẩm")
            Return False
        End If
        Return True
    End Function
    Private Sub bthoadon_Click(sender As Object, e As EventArgs) Handles bthoadon.Click
        Quản_lý_hóa_đơn.ShowDialog()
    End Sub

    Private Sub btxoa_Click_1(sender As Object, e As EventArgs) Handles btxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtidsanpham.Text
            Dim truyvan1 As New SqlCommand("delete from San_pham where ID_san_pham = '" + ID + "'", ketnoidulieu)
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                truyvan1.ExecuteNonQuery()
                ketnoidulieu.Close()
            Else
                ketnoidulieu.Close()
            End If
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btsua_Click_1(sender As Object, e As EventArgs) Handles btsua.Click
        ketnoidulieu.Open()
        Dim ID As String = txtidsanpham.Text
        Dim Ten_san_pham As String = Txttensanpham.Text
        Dim ID_Loai_san_pham As String = Txtloaisanpham.Text
        Dim Mo_ta As String = Txtmota.Text
        Dim Gia As String = txtgia.Text
        Dim truyvan2 As New SqlCommand("Update San_pham set Ten_san_pham='" + Ten_san_pham + "',ID_Loai_san_pham='" + ID_Loai_san_pham + "',Mo_ta= N'" + Mo_ta + "',Gia='" + Gia + "' where ID_san_pham='" + ID + "'", ketnoidulieu)
        truyvan2.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()
    End Sub

    Private Sub Btthem_Click_1(sender As Object, e As EventArgs) Handles Btthem.Click
        If kiemtradulieu() = True Then
            Try
                ketnoidulieu.Open()
                Dim Ten_san_pham As String = Txttensanpham.Text
                Dim ID_Loai_san_pham As String = Txtloaisanpham.Text
                Dim Mo_ta As String = Txtmota.Text
                Dim Gia As String = txtgia.Text
                Dim truyvan1 As New SqlCommand("insert into San_pham (Ten_san_pham,ID_Loai_san_pham,Mo_ta,Gia) values (N'" + Ten_san_pham + "',N'" + ID_Loai_san_pham + "',N'" + Mo_ta + "','" + Gia + "')", ketnoidulieu)
                truyvan1.ExecuteNonQuery()
                ketnoidulieu.Close()
                MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loaddulieu()
            Catch ex As Exception
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btloaisanpham.Click
        fomloaisanpham.ShowDialog()
    End Sub
End Class
