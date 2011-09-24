Imports DTO
Imports System.Data.OleDb

Public Class PhanCong_DAO
    Inherits DataProvider

    Public Function LayDSPhanCong(ByVal maGV As String, ByVal maMH As String) As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT MaPhanCong, MaLopHoc, SoTietHocTuan, SoTietHocLienTiepToiThieu, SoTietHocLienTiepToiDa, " & _
                        "SoBuoiHocToiThieu, SoBuoiHocToiDa FROM PHANCONG WHERE MaMonHoc=@MaMonHoc AND MaGiaoVien=@MaGiaoVien"
            Dim dsThS(1) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(0).Value = maMH
            dsThS(1) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(1).Value = maGV
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Dim pcDTO As PhanCong_DTO
                Do While reader.Read()
                    pcDTO = New PhanCong_DTO

                    pcDTO.MaGiaoVien = maGV
                    pcDTO.MaMonHoc = maMH
                    pcDTO.MaLopHoc = reader("MaLopHoc").ToString()
                    pcDTO.SoTietHocTuan = reader("SoTietHocTuan")
                    pcDTO.SoTietHocLienTiepToiThieu = reader("SoTietHocLienTiepToiThieu")
                    pcDTO.SoTietHocLienTiepToiDa = reader("SoTietHocLienTiepToiDa")
                    pcDTO.SoBuoiHocToiThieu = reader("SoBuoiHocToiThieu")
                    pcDTO.SoBuoiHocToiDa = reader("SoBuoiHocToiDa")
                    pcDTO.MaPhanCong = reader("MaPhanCong")
                    kq.Add(pcDTO)
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSPhanCongTheoLH(ByVal maLH As String) As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT MaPhanCong, MaMonHoc, MaGiaoVien, SoTietHocTuan, SoTietHocLienTiepToiThieu, SoTietHocLienTiepToiDa, " & _
                        "SoBuoiHocToiThieu, SoBuoiHocToiDa FROM PHANCONG WHERE MaLopHoc=@MaLopHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaLopHoc", DbType.String)
            dsThS(0).Value = maLH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Dim pcDTO As PhanCong_DTO
                Do While reader.Read()
                    pcDTO = New PhanCong_DTO

                    pcDTO.MaGiaoVien = reader("MaGiaoVien").ToString()
                    pcDTO.MaLopHoc = maLH
                    pcDTO.MaMonHoc = reader("MaMonHoc").ToString()
                    pcDTO.SoTietHocTuan = reader("SoTietHocTuan")
                    pcDTO.SoTietHocLienTiepToiThieu = reader("SoTietHocLienTiepToiThieu")
                    pcDTO.SoTietHocLienTiepToiDa = reader("SoTietHocLienTiepToiDa")
                    pcDTO.SoBuoiHocToiThieu = reader("SoBuoiHocToiThieu")
                    pcDTO.SoBuoiHocToiDa = reader("SoBuoiHocToiDa")
                    pcDTO.MaPhanCong = reader("MaPhanCong")
                    kq.Add(pcDTO)
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSPhanCongTheoGV(ByVal maGV As String) As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT MaPhanCong, MaMonHoc, MaLopHoc, SoTietHocTuan, SoTietHocLienTiepToiThieu, SoTietHocLienTiepToiDa, " & _
                        "SoBuoiHocToiThieu, SoBuoiHocToiDa FROM PHANCONG WHERE MaGiaoVien=@MaGiaoVien"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = maGV
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Dim pcDTO As PhanCong_DTO
                Do While reader.Read()
                    pcDTO = New PhanCong_DTO

                    pcDTO.MaLopHoc = reader("MaLopHoc").ToString()
                    pcDTO.MaGiaoVien = maGV
                    pcDTO.MaMonHoc = reader("MaMonHoc").ToString()
                    pcDTO.SoTietHocTuan = reader("SoTietHocTuan")
                    pcDTO.SoTietHocLienTiepToiThieu = reader("SoTietHocLienTiepToiThieu")
                    pcDTO.SoTietHocLienTiepToiDa = reader("SoTietHocLienTiepToiDa")
                    pcDTO.SoBuoiHocToiThieu = reader("SoBuoiHocToiThieu")
                    pcDTO.SoBuoiHocToiDa = reader("SoBuoiHocToiDa")
                    pcDTO.MaPhanCong = reader("MaPhanCong")
                    kq.Add(pcDTO)
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function CapNhatPhanCong(ByVal pcDTO As PhanCong_DTO) As Boolean
        Dim kq As Boolean = False
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "UPDATE PHANCONG SET SoTietHocTuan=@SoTietHocTuan, SoTietHocLienTiepToiThieu=@SoTietHocLienTiepToiThieu, " & _
                        "SoTietHocLienTiepToiDa=@SoTietHocLienTiepToiDa, MaGiaoVien=@MaGiaoVien, SoBuoiHocToiThieu=@SoBuoiHocToiThieu, " & _
                        "SoBuoiHocToiDa=@SoBuoiHocToiDa WHERE MaMonHoc=@MaMonHoc AND MaLopHoc=@MaLopHoc"
            Dim dsThS(7) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = pcDTO.MaGiaoVien
            dsThS(1) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(1).Value = pcDTO.MaMonHoc
            dsThS(2) = New OleDbParameter("@MaLopHoc", DbType.String)
            dsThS(2).Value = pcDTO.MaLopHoc
            dsThS(3) = New OleDbParameter("@SoTietHocTuan", DbType.Int32)
            dsThS(3).Value = pcDTO.SoTietHocTuan
            dsThS(4) = New OleDbParameter("@SoTietHocLienTiepToiThieu", DbType.Int32)
            dsThS(4).Value = pcDTO.SoTietHocLienTiepToiThieu
            dsThS(5) = New OleDbParameter("@SoTietHocLienTiepToiDa", DbType.Int32)
            dsThS(5).Value = pcDTO.SoTietHocLienTiepToiDa
            dsThS(6) = New OleDbParameter("@SoBuoiHocToiThieu", DbType.Int32)
            dsThS(6).Value = pcDTO.SoBuoiHocToiThieu
            dsThS(7) = New OleDbParameter("@SoBuoiHocToiDa", DbType.Int32)
            dsThS(7).Value = pcDTO.SoBuoiHocToiDa

            If (ExecuteNonQuery(SqlQuery, dsThS) > 0) Then
                kq = True
            End If
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub Xoa(ByVal MaLopHoc As String)
        Connect()
        Dim SqlQuery As String = "Delete from PhanCong where MaLopHoc = '" & MaLopHoc & "'"
        ExecuteNonQuery(SqlQuery)
        DisConnect()
    End Sub

    Public Function ThemVaoPhanCong(ByVal pcDTO As PhanCong_DTO) As Boolean
        Dim kq As Boolean = False
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "INSERT INTO PHANCONG(MaPhanCong, MaLopHoc, MaMonHoc, MaGiaoVien, " & _
                        "SoTietHocTuan, SoTietHocLienTiepToiThieu, SoTietHocLienTiepToiDa, " & _
                        "SoBuoiHocToiThieu, SoBuoiHocToiDa) " & _
                        "VALUES(@MaPhanCong, @MaLopHoc, @MaMonHoc, @MaGiaoVien, " & _
                        "@SoTietHocTuan, @SoTietHocLienTiepToiThieu, @SoTietHocLienTiepToiDa, " & _
                        "@SoBuoiHocToiThieu, @SoBuoiHocToiDa)"
            Dim dsThS(8) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = pcDTO.MaGiaoVien
            dsThS(1) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(1).Value = pcDTO.MaMonHoc
            dsThS(2) = New OleDbParameter("@MaLopHoc", DbType.String)
            dsThS(2).Value = pcDTO.MaLopHoc
            dsThS(3) = New OleDbParameter("@SoTietHocTuan", DbType.Int32)
            dsThS(3).Value = pcDTO.SoTietHocTuan
            dsThS(4) = New OleDbParameter("@SoTietHocLienTiepToiThieu", DbType.Int32)
            dsThS(4).Value = pcDTO.SoTietHocLienTiepToiThieu
            dsThS(5) = New OleDbParameter("@SoTietHocLienTiepToiDa", DbType.Int32)
            dsThS(5).Value = pcDTO.SoTietHocLienTiepToiDa
            dsThS(6) = New OleDbParameter("@SoBuoiHocToiThieu", DbType.Int32)
            dsThS(6).Value = pcDTO.SoBuoiHocToiThieu
            dsThS(7) = New OleDbParameter("@SoBuoiHocToiDa", DbType.Int32)
            dsThS(7).Value = pcDTO.SoBuoiHocToiDa
            dsThS(8) = New OleDbParameter("@MaPhanCong", DbType.String)
            dsThS(8).Value = pcDTO.MaPhanCong

            If (ExecuteNonQuery(SqlQuery, dsThS) > 0) Then
                kq = True
            End If
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub XoaPhanCong(ByVal maPC As String)
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "DELETE FROM PHANCONG WHERE MaPhanCong=@MaPhanCong"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaPhanCong", DbType.String)
            dsThS(0).Value = maPC

            ExecuteNonQuery(SqlQuery, dsThS)
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
    End Sub

    Public Function LayMaCuoiCungCuaPhanCong() As String
        Dim kq As String = ""
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT top 1 MaPhanCong From PHANCONG order by MaPhanCong DESC"

            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery)
                If (reader.Read()) Then
                    kq &= reader("MaPhanCong").ToString()
                End If
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function
End Class
