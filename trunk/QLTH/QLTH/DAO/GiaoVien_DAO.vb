Imports System.Data.OleDb
Imports DTO


Public Class GiaoVien_DAO
    Inherits DataProvider
    Public Function LayDsLopDuocPhanCong(ByVal maGV As String) As IList
        Dim l As New ArrayList
        Dim dr As OleDbDataReader
        Dim str As String

        str = "SELECT LopHoc.TenLopHoc " & _
              "FROM LopHoc INNER JOIN (GiaoVien INNER JOIN PhanCong ON GiaoVien.MaGiaoVien = PhanCong.MaGiaoVien) ON LopHoc.MaLopHoc = PhanCong.MaLopHoc " & _
              "WHERE (((GiaoVien.MaGiaoVien)='" & maGV & "'));"
        Me.Connect()
        dr = Me.ExecuteQuery(str)

        While (dr.Read())
            l.Add(dr(0))
        End While

        Me.DisConnect()
        Return l
    End Function

    Public Function LayDsGiaoVien() As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "Select MaGiaoVien, HoTenGiaoVien, TenTat, DiaChi, DienThoai from GIAOVIEN"
            'If (makhoi.ToLower() <> "all") Then
            '//SqlQuery &= " Where MaKhoi = '" & makhoi & "'"
            'End If
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery)
                Dim GiaoVienDTO As GiaoVien_DTO
                Do While reader.Read()
                    GiaoVienDTO = New GiaoVien_DTO

                    GiaoVienDTO.MaGiaoVien = reader("MaGiaoVien").ToString()
                    GiaoVienDTO.HoTenGiaoVien = reader("HoTenGiaoVien").ToString()
                    GiaoVienDTO.TenTat = reader("TenTat").ToString()
                    GiaoVienDTO.DiaChi = reader("DiaChi").ToString()
                    GiaoVienDTO.DienThoai = reader("DienThoai").ToString()
                    toReturn.Add(GiaoVienDTO)
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

    Public Sub CapNhatGiaoVien(ByVal GiaoVienDTO As GiaoVien_DTO)
        Try
            'mo ket noi CSDL
            Connect()
            'chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "UPDATE GIAOVIEN SET HoTenGiaoVien=@HoTenGiaoVien , " & _
                        "TenTat=@TenTat , DiaChi=@DiaChi , DienThoai=@DienThoai WHERE " & _
                        "MaGiaoVien=@MaGiaoVien"
            Dim dsThS(4) As OleDbParameter
            dsThS(0) = New OleDbParameter("@HoTenGiaoVien", DbType.String)
            dsThS(0).Value = GiaoVienDTO.HoTenGiaoVien
            dsThS(1) = New OleDbParameter("@TenTat", DbType.String)
            dsThS(1).Value = GiaoVienDTO.TenTat
            dsThS(2) = New OleDbParameter("@DiaChi", DbType.String)
            dsThS(2).Value = GiaoVienDTO.DiaChi
            dsThS(3) = New OleDbParameter("@DienThoai", DbType.String)
            dsThS(3).Value = GiaoVienDTO.DienThoai
            dsThS(4) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(4).Value = GiaoVienDTO.MaGiaoVien
            'thuc thi cau truy van
            ExecuteNonQuery(SqlQuery, dsThS)
            'dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
    End Sub

    Public Sub Them(ByVal GiaoVienDTO As GiaoVien_DTO)
        Try
            'Mo ket noi CSDL
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "INSERT INTO GIAOVIEN(MaGiaoVien, HoTenGiaoVien, TenTat, DiaChi, DienThoai) " & _
                        "VALUES(@MaGiaoVien, @HoTenGiaoVien, @TenTat, @DiaChi, @DienThoai)"
            Dim dsThS(4) As OleDbParameter
            dsThS(0) = New OleDbParameter("@HoTenGiaoVien", DbType.String)
            dsThS(0).Value = GiaoVienDTO.HoTenGiaoVien
            dsThS(1) = New OleDbParameter("@TenTat", DbType.String)
            dsThS(1).Value = GiaoVienDTO.TenTat
            dsThS(2) = New OleDbParameter("@DiaChi", DbType.String)
            dsThS(2).Value = GiaoVienDTO.DiaChi
            dsThS(3) = New OleDbParameter("@DienThoai", DbType.String)
            dsThS(3).Value = GiaoVienDTO.DienThoai
            dsThS(4) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(4).Value = GiaoVienDTO.MaGiaoVien
            'Thuc thi cau truy van
            ExecuteNonQuery(SqlQuery, dsThS)
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
    End Sub

    Public Sub Xoa(ByVal GiaoVienDTO As GiaoVien_DTO)
        Try
            'mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "DELETE FROM GIAOVIEN WHERE MaGiaoVien=@MaGiaoVien"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = GiaoVienDTO.MaGiaoVien
            ExecuteNonQuery(SqlQuery, dsThS)
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        
    End Sub

    Public Function TimKiem(ByVal MaGiaoVien As String) As GiaoVien_DTO
        Dim toReturn As GiaoVien_DTO

        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaGiaoVien, HoTenGiaoVien, TenTat, DiaChi, DienThoai FROM GIAOVIEN WHERE MaGiaoVien=@MaGiaoVien"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = MaGiaoVien
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return Nothing
                Else
                    toReturn = New GiaoVien_DTO
                    reader.Read()
                    toReturn.MaGiaoVien = reader("MaGiaoVien").ToString()
                    toReturn.HoTenGiaoVien = reader("HoTenGiaoVien").ToString()
                    toReturn.TenTat = reader("TenTat").ToString()
                    toReturn.DiaChi = reader("DiaChi").ToString()
                    toReturn.DienThoai = reader("DienThoai").ToString()
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

    Public Function LayMaGiaoVien(ByVal tenGV As String, ByVal tenTat As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaGiaoVien " & _
                        "FROM GIAOVIEN WHERE HoTenGiaoVien=@HoTenGiaoVien AND TenTat=@TenTat"
            Dim dsThS(1) As OleDbParameter
            dsThS(0) = New OleDbParameter("@HoTenGiaoVien", DbType.String)
            dsThS(0).Value = tenGV
            dsThS(1) = New OleDbParameter("@TenTat", DbType.String)
            dsThS(1).Value = tenTat
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("MaGiaoVien").ToString()
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

    Public Function LayTenGiaoVien(ByVal maGV As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT HoTenGiaoVien " & _
                        "FROM GIAOVIEN WHERE MaGiaoVien=@MaGiaoVien"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = maGV
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("HoTenGiaoVien").ToString()
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
End Class
