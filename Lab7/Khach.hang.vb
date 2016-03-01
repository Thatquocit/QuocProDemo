Imports System.Data
Imports System.Data.SqlClient
Public Class Khách_hàng
    Dim ketnoidulieu As New SqlConnection("workstation id=itofmeqlbanhang.mssql.somee.com;packet size=4096;user id=spiderman94_SQLLogin_1;pwd=rghlt5qn4v;data source=itofmeqlbanhang.mssql.somee.com;persist security info=False;initial catalog=itofmeqlbanhang")
    Private Sub Loaddulieu()
        ketnoidulieu.Open()
        Dim truyvan As New SqlCommand("select * from Khach_hang", ketnoidulieu)
        Dim ad As New SqlDataAdapter(truyvan)
        Dim table As New DataTable
        ad.Fill(table)
        ketnoidulieu.Close()
        lstvkhachhang.Items.Clear()
        Dim i As Integer
        For Each hang As DataRow In table.Rows
            lstvkhachhang.Items.Add(hang("ID_khach_hang").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("Ten_khach_hang").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("Dia_chi").ToString())
            lstvkhachhang.Items(i).SubItems.Add(hang("So_dien_thoai").ToString())
            i += 1
        Next
    End Sub
    Private Function kiemtradulieu() As Boolean
        If txttenkh.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng")
            Return False
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ")
            Return False
        ElseIf txtsodt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại")
            Return False
        End If
        Return True
    End Function
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        If kiemtradulieu() = True Then
            Try
                ketnoidulieu.Open()
                Dim Ten_khach_hang As String = txttenkh.Text
                Dim Dia_chi As String = txtdiachi.Text
                Dim So_dt As String = txtsodt.Text
                Dim truyvan1 As New SqlCommand("insert into Khach_hang values (N'" + Ten_khach_hang + "',N'" + Dia_chi + "',N'" + So_dt + "')", ketnoidulieu)
                truyvan1.ExecuteNonQuery()
                ketnoidulieu.Close()
                MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loaddulieu()
            Catch ex As Exception
                MessageBox.Show("Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Khách_hàng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddulieu()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click

        ketnoidulieu.Open()
        Dim ID_kh As String = txtmakh.Text
        Dim truyvan1 As New SqlCommand("delete from Khach_hang where ID_khach_hang = '" + ID_kh + "'", ketnoidulieu)
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            truyvan1.ExecuteNonQuery()
            ketnoidulieu.Close()
        Else
            ketnoidulieu.Close()
        End If
        Loaddulieu()
       
    End Sub

    Private Sub lstvkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvkhachhang.SelectedIndexChanged
        For Each List As ListViewItem In lstvkhachhang.SelectedItems
            txtmakh.Text = List.SubItems(0).Text
            txttenkh.Text = List.SubItems(1).Text
            txtdiachi.Text = List.SubItems(2).Text
            txtsodt.Text = List.SubItems(3).Text
        Next
    End Sub

    Private Sub btsua_Click(sender As Object, e As EventArgs) Handles btsua.Click
        ketnoidulieu.Open()
        Dim ID As String = txtmakh.Text
        Dim Ten_khach_hang As String = txttenkh.Text
        Dim Dia_chi As String = txtdiachi.Text
        Dim So_dt As String = txtsodt.Text

        Dim truyvan2 As New SqlCommand("Update Khach_hang set Ten_khach_hang=N'" + Ten_khach_hang + "',Dia_chi=N'" + Dia_chi + "',So_dien_thoai= '" + So_dt + "' where ID_khach_hang = '" + ID + "'", ketnoidulieu)
        truyvan2.ExecuteNonQuery()
        ketnoidulieu.Close()
        MessageBox.Show("Đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loaddulieu()
    End Sub
End Class