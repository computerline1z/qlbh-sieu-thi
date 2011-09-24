Imports System.Data.OleDb
Imports DTO
Public Class TKBToanTruong_DAO
    Inherits DataProvider
    Public Function LayThoiKhoaBieu() As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "Select LLH.MaLichLopHoc, LH.TenLopHoc, MH.TenMonHoc, GV.TenTat, LLH.Thu, LLH.TietHocBatDau, LLH.SoTietHoc  from GIAOVIEN GV, MONHOC MH, LICHLOPHOC LLH, PHANCONG PC, LOPHOC LH " & _
                        "where PC.MaLopHoc = LH.MaLopHoc and LLH.MaPhanCong = PC.MaPhanCong and PC.MaGiaoVien = GV.MaGiaoVien and PC.MaMonHoc = MH.MaMonHoc"

            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery)
                Dim ThoiKhoaBieuDTO As TKBToanTruong_DTO
                Do While reader.Read()
                    ThoiKhoaBieuDTO = New TKBToanTruong_DTO
                    ThoiKhoaBieuDTO.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    ThoiKhoaBieuDTO.TenLopHoc = reader("TenLopHoc").ToString()
                    ThoiKhoaBieuDTO.MonHoc = reader("TenMonHoc").ToString()
                    ThoiKhoaBieuDTO.TenGiaoVien = reader("TenTat").ToString()
                    ThoiKhoaBieuDTO.NgayHoc = reader("Thu").ToString()
                    ThoiKhoaBieuDTO.TietBatDau = reader("TietHocBatDau").ToString()
                    ThoiKhoaBieuDTO.SoTietHoc = reader("SoTietHoc").ToString()
                    toReturn.Add(ThoiKhoaBieuDTO)
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
    Public Function LayThoiKhoaBieuKhoi10() As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        Try
            Connect()
            Dim sqlQuery As String
            sqlQuery = "Select LLH.MaLichLopHoc, LH.TenLopHoc, MH.TenMonHoc, GV.TenTat, LLH.Thu, LLH.TietHocBatDau, LLH.SoTietHoc  from GIAOVIEN GV, MONHOC MH, LICHLOPHOC LLH, PHANCONG PC, LOPHOC LH " & _
                        "where PC.MaLopHoc = LH.MaLopHoc and LLH.MaPhanCong = PC.MaPhanCong and PC.MaGiaoVien = GV.MaGiaoVien and PC.MaMonHoc = MH.MaMonHoc and LH.MaKhoi='K10'"
            Using reader As OleDbDataReader = ExecuteQuery(sqlQuery)
                Dim ThoiKhoaBieuDTO As TKBToanTruong_DTO
                Do While reader.Read()
                    ThoiKhoaBieuDTO = New TKBToanTruong_DTO
                    ThoiKhoaBieuDTO.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    ThoiKhoaBieuDTO.TenLopHoc = reader("TenLopHoc").ToString()
                    ThoiKhoaBieuDTO.MonHoc = reader("TenMonHoc").ToString()
                    ThoiKhoaBieuDTO.TenGiaoVien = reader("TenTat").ToString()
                    ThoiKhoaBieuDTO.NgayHoc = reader("Thu").ToString()
                    ThoiKhoaBieuDTO.TietBatDau = reader("TietHocBatDau").ToString()
                    ThoiKhoaBieuDTO.SoTietHoc = reader("SoTietHoc").ToString()
                    toReturn.Add(ThoiKhoaBieuDTO)
                Loop
            End Using
            DisConnect()
        Catch ex As Exception
            DisConnect()
        End Try
        Return toReturn
    End Function
    Public Function LayThoiKhoaBieuKhoi11() As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        Try
            Connect()
            Dim sqlQuery As String
            sqlQuery = "Select LLH.MaLichLopHoc, LH.TenLopHoc, MH.TenMonHoc, GV.TenTat, LLH.Thu, LLH.TietHocBatDau, LLH.SoTietHoc  from GIAOVIEN GV, MONHOC MH, LICHLOPHOC LLH, PHANCONG PC, LOPHOC LH " & _
                        "where PC.MaLopHoc = LH.MaLopHoc and LLH.MaPhanCong = PC.MaPhanCong and PC.MaGiaoVien = GV.MaGiaoVien and PC.MaMonHoc = MH.MaMonHoc and LH.MaKhoi='K11'"
            Using reader As OleDbDataReader = ExecuteQuery(sqlQuery)
                Dim ThoiKhoaBieuDTO As TKBToanTruong_DTO
                Do While reader.Read()
                    ThoiKhoaBieuDTO = New TKBToanTruong_DTO
                    ThoiKhoaBieuDTO.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    ThoiKhoaBieuDTO.TenLopHoc = reader("TenLopHoc").ToString()
                    ThoiKhoaBieuDTO.MonHoc = reader("TenMonHoc").ToString()
                    ThoiKhoaBieuDTO.TenGiaoVien = reader("TenTat").ToString()
                    ThoiKhoaBieuDTO.NgayHoc = reader("Thu").ToString()
                    ThoiKhoaBieuDTO.TietBatDau = reader("TietHocBatDau").ToString()
                    ThoiKhoaBieuDTO.SoTietHoc = reader("SoTietHoc").ToString()
                    toReturn.Add(ThoiKhoaBieuDTO)
                Loop
            End Using
            DisConnect()
        Catch ex As Exception
            DisConnect()
        End Try
        Return toReturn
    End Function
    Public Function LayThoiKhoaBieuKhoi12() As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        Try
            Connect()
            Dim sqlQuery As String
            sqlQuery = "Select LLH.MaLichLopHoc, LH.TenLopHoc, MH.TenMonHoc, GV.TenTat, LLH.Thu, LLH.TietHocBatDau, LLH.SoTietHoc  from GIAOVIEN GV, MONHOC MH, LICHLOPHOC LLH, PHANCONG PC, LOPHOC LH " & _
                        "where PC.MaLopHoc = LH.MaLopHoc and LLH.MaPhanCong = PC.MaPhanCong and PC.MaGiaoVien = GV.MaGiaoVien and PC.MaMonHoc = MH.MaMonHoc and LH.MaKhoi='K12'"
            Using reader As OleDbDataReader = ExecuteQuery(sqlQuery)
                Dim ThoiKhoaBieuDTO As TKBToanTruong_DTO
                Do While reader.Read()
                    ThoiKhoaBieuDTO = New TKBToanTruong_DTO
                    ThoiKhoaBieuDTO.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    ThoiKhoaBieuDTO.TenLopHoc = reader("TenLopHoc").ToString()
                    ThoiKhoaBieuDTO.MonHoc = reader("TenMonHoc").ToString()
                    ThoiKhoaBieuDTO.TenGiaoVien = reader("TenTat").ToString()
                    ThoiKhoaBieuDTO.NgayHoc = reader("Thu").ToString()
                    ThoiKhoaBieuDTO.TietBatDau = reader("TietHocBatDau").ToString()
                    ThoiKhoaBieuDTO.SoTietHoc = reader("SoTietHoc").ToString()
                    toReturn.Add(ThoiKhoaBieuDTO)
                Loop
            End Using
            DisConnect()
        Catch ex As Exception
            DisConnect()
        End Try
        Return toReturn
    End Function
 
End Class
