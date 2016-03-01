Imports System.Data
Imports System.Data.SqlClient
Public Class fomloaisanpham
    Dim ketnoidulieu As New SqlConnection("workstation id=itofmeqlbanhang.mssql.somee.com;packet size=4096;user id=spiderman94_SQLLogin_1;pwd=rghlt5qn4v;data source=itofmeqlbanhang.mssql.somee.com;persist security info=False;initial catalog=itofmeqlbanhang")
    Private Sub fomloaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from Loai_san_pham", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstloaisanpham.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstloaisanpham.Items.Add(hang("ID_loai_san_pham").ToString())
            lstloaisanpham.Items(i).SubItems.Add(hang("Ten_loai").ToString())
            lstloaisanpham.Items(i).SubItems.Add(hang("Mo_ta").ToString())
            i += 1
        Next
    End Sub

    Private Sub lstloaisanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstloaisanpham.SelectedIndexChanged
        For Each List As ListViewItem In lstloaisanpham.SelectedItems
            txtmaloai.Text = List.SubItems(0).Text
            txttenloai.Text = List.SubItems(1).Text
            txtmota.Text = List.SubItems(2).Text
        Next
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Try
            ketnoidulieu.Open()
            Dim ID As String = txtmaloai.Text
            Dim truyvan1 As New SqlCommand("delete from Loai_san_pham where ID_loai_san_pham = '" + ID + "'", ketnoidulieu)
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

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click

        ketnoidulieu.Open()
        Dim Tenloai As String = txttenloai.Text
        Dim mota As String = txtmota.Text
        Dim truyvan1 As New SqlCommand("insert into Loai_san_pham values (N'" + Tenloai + "',N'" + mota + "')", ketnoidulieu)
        truyvan1.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()

    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        ketnoidulieu.Open()
        Dim ID As String = txtmaloai.Text
        Dim Tenloai As String = txttenloai.Text
        Dim mota As String = txtmota.Text
        Dim truyvan2 As New SqlCommand("Update Loai_san_pham set Ten_loai=N'" + Tenloai + "',Mo_ta=N'" + mota + "'where ID_loai_san_pham='" + ID + "'", ketnoidulieu)
        truyvan2.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()
    End Sub
End Class