Imports System.Data.OleDb
Imports DTO

Public Class LopHoc_DAO
    Inherits DataProvider

    Public Function LayDsLop(ByVal makhoi As String) As ArrayList
        Dim toReturn As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT MaLopHoc, TenLopHoc, MaKhoi FROM LOPHOC"
            If (makhoi.ToLower() <> "all") Then
                SqlQuery &= " WHERE MaKhoi=@MaKhoi"
            End If
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaKhoi", DbType.String)
            dsThS(0).Value = makhoi
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Dim lopHocDTO As LopHoc_DTO
                Do While reader.Read()
                    lopHocDTO = New LopHoc_DTO
                    lopHocDTO.MaLopHoc = reader("MaLopHoc").ToString()
                    lopHocDTO.TenLopHoc = reader("TenLopHoc").ToString()
                    lopHocDTO.MaKhoi = reader("MaKhoi").ToString()
                    toReturn.Add(lopHocDTO)
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
        Return toReturn
    End Function

    Public Function LayDSTenLop() As ArrayList
        Dim toReturn As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT TenLopHoc FROM LOPHOC"
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery)
                Do While reader.Read()
                    toReturn.Add(reader("TenLopHoc"))
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try

        Return toReturn
    End Function

    Public Sub CapNhatLopHoc(ByVal lopHocDTO As LopHoc_DTO)
        Try
            'mo ket noi CSDL
            Connect()
            'chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "Update LOPHOC set TenLopHoc = '" & lopHocDTO.TenLopHoc & "', "
            SqlQuery &= " MaKhoi = '" & lopHocDTO.MaKhoi & "', "
            SqlQuery &= " Where MaLopHoc = '" & lopHocDTO.MaLopHoc & "'"
            'thuc thi cau truy van
            ExecuteNonQuery(SqlQuery)
            'dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try       
    End Sub

    Public Sub Them(ByVal lopHocDTO As LopHoc_DTO)
        Try
            'Mo ket noi CSDL
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "Insert into Lophoc (MaLopHoc, TenLopHoc, MaKhoi) "
            SqlQuery &= "Values ('" & lopHocDTO.MaLopHoc & "', '"
            SqlQuery &= lopHocDTO.TenLopHoc & "', '" & lopHocDTO.MaKhoi & "')"
            'Thuc thi cau truy van
            ExecuteNonQuery(SqlQuery)
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
    End Sub

    Public Sub Xoa(ByVal lopHocDTO As LopHoc_DTO)
        Try
            'mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "Delete from LopHoc where MaLopHoc = '" & lopHocDTO.MaLopHoc & "'"
            ExecuteNonQuery(SqlQuery)
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
    End Sub

    Public Sub Xoa(ByVal MaLopHoc As String)
        'mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Delete from LopHoc where MaLopHoc = '" & MaLopHoc & "'"
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi
        DisConnect()
    End Sub

    Public Function TimKiem(ByVal MaLopHoc As String) As LopHoc_DTO
        Dim toReturn As New LopHoc_DTO
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "Select MaLopHoc, TenLopHoc, MaKhoi from LopHoc where MaLopHoc=@MaLopHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaLopHoc", DbType.String)
            dsThS(0).Value = MaLopHoc
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return Nothing
                Else
                    reader.Read()
                    toReturn.MaLopHoc = reader("MaLopHoc").ToString()
                    toReturn.TenLopHoc = reader("TenLopHoc").ToString()
                    toReturn.MaKhoi = reader("MaKhoi").ToString()
                End If
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
        Return toReturn
    End Function

    Public Function LayMaLopHoc(ByVal tenLH As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaLopHoc FROM LOPHOC WHERE TenLopHoc=@TenLopHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@TenLopHoc", DbType.String)
            dsThS(0).Value = tenLH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("MaLopHoc").ToString()
                End If
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayTenLopHoc(ByVal maLH As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT TenLopHoc FROM LOPHOC WHERE MaLopHoc=@MaLopHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaLopHoc", DbType.String)
            dsThS(0).Value = maLH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("TenLopHoc").ToString()
                End If
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayMaLopHocCuoi() As String
        Dim toReturn As String
        'Mở kết nối
        Connect()
        'Chuẩn bị câu truy vấn
        Dim SqlQuery As String = "SELECT  top 1  MaLopHoc  From LOPHOC order by MaLopHoc DESC"
        'Thực thi câu truy vấn
        toReturn = ExecuteScalar(SqlQuery)
        'đóng kết nối
        DisConnect()
        Return toReturn
    End Function
End Class
