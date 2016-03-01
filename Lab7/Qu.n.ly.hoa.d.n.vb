Imports System.Data
Imports System.Data.SqlClient
Public Class Quản_lý_hóa_đơn
    Dim ketnoidulieu As New SqlConnection("workstation id=itofmeqlbanhang.mssql.somee.com;packet size=4096;user id=spiderman94_SQLLogin_1;pwd=rghlt5qn4v;data source=itofmeqlbanhang.mssql.somee.com;persist security info=False;initial catalog=itofmeqlbanhang")
    Private Sub Quản_lý_hóa_đơn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select ID_Hoa_don,Hoa_don.ID_khach_hang,ID_chi_tiet_hd,Ngay,Ghi_chu,Ten_khach_hang from Hoa_Don join Khach_Hang on Hoa_Don.ID_khach_hang=Khach_Hang.ID_khach_hang", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstquanlyhoadon.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstquanlyhoadon.Items.Add(hang("ID_Hoa_don").ToString())
            lstquanlyhoadon.Items(i).SubItems.Add(hang("ID_khach_hang").ToString())
            lstquanlyhoadon.Items(i).SubItems.Add(hang("ID_chi_tiet_hd").ToString())
            lstquanlyhoadon.Items(i).SubItems.Add(hang("Ngay").ToString())
            lstquanlyhoadon.Items(i).SubItems.Add(hang("Ghi_chu").ToString())
            lstquanlyhoadon.Items(i).SubItems.Add(hang("Ten_khach_hang").ToString())
            i += 1
        Next
    End Sub

    Private Sub lstquanlyhoadon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstquanlyhoadon.SelectedIndexChanged
            For Each List As ListViewItem In lstquanlyhoadon.SelectedItems
                txtidhoadon.Text = List.SubItems(0).Text
                txtidkhachhang.Text = List.SubItems(1).Text
                txtchitiethoadon.Text = List.SubItems(2).Text
                txtngaytao.Text = List.SubItems(3).Text
                txtghichu.Text = List.SubItems(4).Text
                txttenkhachhang.Text = List.SubItems(5).Text
            Next
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click

        ketnoidulieu.Open()
        Dim ID_khach_hang As String = txtidkhachhang.Text
        Dim ID_chi_tiet_hd As String = txtchitiethoadon.Text
        Dim Ngay As DateTime = txtngaytao.Text
        Dim Ghi_chu As String = txtghichu.Text
        Dim truyvan1 As New SqlCommand("insert into Hoa_Don (ID_khach_hang,ID_chi_tiet_hd,Ngay,Ghi_chu) values ('" + ID_khach_hang + "','" + ID_chi_tiet_hd + "','" + Ngay + "',N'" + Ghi_chu + "')", ketnoidulieu)
        truyvan1.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()

    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtidhoadon.Text
            Dim truyvan1 As New SqlCommand("delete from Hoa_Don where ID_Hoa_don = '" + ID + "'", ketnoidulieu)
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

    Private Sub lstquanlyhoadon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstquanlyhoadon.MouseDoubleClick
        Chi_tiết_hóa_đơn.ShowDialog()
    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtidhoadon.Text
            Dim Id_khachhang As String = txtidkhachhang.Text
            Dim ID_chi_tiet_hd As String = txtchitiethoadon.Text
            Dim ngay As DateTime = txtngaytao.Text
            Dim ghi_chu As String = txtghichu.Text
            Dim truyvan2 As New SqlCommand("Update Hoa_Don set ID_khach_hang='" + Id_khachhang + "',ID_chi_tiet_hd='" + ID_chi_tiet_hd + "',Ngay='" + ngay + "',Ghi_chu='" + ghi_chu + "' where ID_Hoa_don='" + ID + "'", ketnoidulieu)
            truyvan2.ExecuteNonQuery()
            ketnoidulieu.Close()
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Loaddulieu()
        Catch ex As Exception
            MessageBox.Show("Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
       
    End Sub

    Private Sub btkhachhang_Click(sender As Object, e As EventArgs) Handles btkhachhang.Click
        Khách_hàng.ShowDialog()
    End Sub
End Class