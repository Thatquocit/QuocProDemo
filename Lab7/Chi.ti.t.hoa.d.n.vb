Imports System.Data
Imports System.Data.SqlClient
Public Class Chi_tiết_hóa_đơn
    Dim ketnoidulieu As New SqlConnection("workstation id=itofmeqlbanhang.mssql.somee.com;packet size=4096;user id=spiderman94_SQLLogin_1;pwd=rghlt5qn4v;data source=itofmeqlbanhang.mssql.somee.com;persist security info=False;initial catalog=itofmeqlbanhang")
    Private Sub Chi_tiết_hóa_đơn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select ID_chi_tiet_hoa_don,San_pham.ID_san_pham,San_Pham.Ten_san_pham,Chi_Tiet_Hoa_Don.Mo_ta,Chi_Tiet_Hoa_Don.Ngay_tao,San_Pham.Gia from Chi_Tiet_Hoa_Don join San_Pham on Chi_Tiet_Hoa_Don.ID_san_pham=San_Pham.ID_san_pham", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstchitiethoadon.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstchitiethoadon.Items.Add(hang("ID_chi_tiet_hoa_don").ToString())
            lstchitiethoadon.Items(i).SubItems.Add(hang("ID_san_pham").ToString())
            lstchitiethoadon.Items(i).SubItems.Add(hang("Ten_san_pham").ToString())
            lstchitiethoadon.Items(i).SubItems.Add(hang("Mo_ta").ToString())
            lstchitiethoadon.Items(i).SubItems.Add(hang("Ngay_tao").ToString())
            lstchitiethoadon.Items(i).SubItems.Add(hang("Gia").ToString())
            i += 1
        Next
    End Sub

    Private Sub lstchitiethoadon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstchitiethoadon.SelectedIndexChanged
        For Each List As ListViewItem In lstchitiethoadon.SelectedItems
            txtchitiethd.Text = List.SubItems(0).Text
            txtsanpham.Text = List.SubItems(1).Text
            txtmota.Text = List.SubItems(3).Text
            txtdatetime.Text = List.SubItems(4).Text
        Next
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        ketnoidulieu.Open()
        Dim ID_san_pham As String = txtsanpham.Text
        Dim Mo_ta As String = txtmota.Text
        Dim Ngay_tao As DateTime = txtdatetime.Text
        Dim truyvan1 As New SqlCommand("insert into Chi_Tiet_Hoa_Don (ID_san_pham,Mo_ta,Ngay_tao) values ('" + ID_san_pham + "','" + Mo_ta + "','" + Ngay_tao + "')", ketnoidulieu)
        truyvan1.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()
    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        ketnoidulieu.Open()
        Dim ID As String = txtchitiethd.Text
        Dim ma_san_pham As String = txtsanpham.Text
        Dim Mota As String = txtmota.Text
        Dim ngaythang As String = txtdatetime.Text
        Dim truyvan2 As New SqlCommand("Update Chi_Tiet_Hoa_Don set ID_chi_tiet_hoa_don ='" + ID + "',ID_san_pham='" + ma_san_pham + "',Mo_ta='" + Mota + "',Ngay_tao='" + ngaythang + "' ", ketnoidulieu)
        truyvan2.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtchitiethd.Text
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
End Class