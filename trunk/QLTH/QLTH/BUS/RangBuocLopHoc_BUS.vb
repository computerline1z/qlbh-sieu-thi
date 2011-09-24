Imports DAO
Imports DTO

Public Class RangBuocLopHoc_BUS
    Public Function LayLichRanh(ByVal MaLop As String) As ArrayList
        Dim rangBuocLopHocDAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        Return rangBuocLopHocDAO.LayLichRanh(MaLop)
    End Function

    Public Sub CapNhatLichRanh(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        Dim rangBuocLopHocDAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        rangBuocLopHocDAO.CapNhatLichRanh(RangBuocLopHoc)
    End Sub


    Public Sub Them(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        Dim rangBuocLopHocDAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        rangBuocLopHocDAO.Them(RangBuocLopHoc)
    End Sub
    Public Sub Them(ByVal arrLichRanh As ArrayList)
        For i As Integer = 0 To arrLichRanh.Count - 1
            Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO
            RangBuocLopHocDTO = arrLichRanh(i)
            Them(RangBuocLopHocDTO)
        Next
    End Sub
    Public Sub Xoa(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        Dim rangBuocLopHocDAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        rangBuocLopHocDAO.Xoa(RangBuocLopHoc)
    End Sub
    Public Sub Xoa(ByVal MaLopHoc As String)
        Dim RangBuocLopHocDAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        RangBuocLopHocDAO.Xoa(MaLopHoc)
    End Sub
    Public Sub CapNhatTrangThai(ByRef arrLichRanh As ArrayList, ByVal TietHoc As Integer, ByVal Thu As Integer, ByVal TrangThai As Integer)
        For i As Integer = 0 To arrLichRanh.Count - 1
            Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO = New RangBuocLopHoc_DTO()
            RangBuocLopHocDTO = arrLichRanh(i)
            If RangBuocLopHocDTO.Thu = Thu And RangBuocLopHocDTO.TietHoc = TietHoc Then
                RangBuocLopHocDTO.TrangThai = TrangThai
                arrLichRanh(i) = RangBuocLopHocDTO
                Return
            End If
        Next
    End Sub
    Public Sub CapNhatTrangThai(ByRef arrLichRanh As ArrayList, ByVal TrangThai As Integer)
        For i As Integer = 0 To arrLichRanh.Count - 1
            Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO = New RangBuocLopHoc_DTO()
            RangBuocLopHocDTO = arrLichRanh(i)
            RangBuocLopHocDTO.TrangThai = TrangThai
        Next
    End Sub
    Public Sub CapNhatTrangThaiVaoCSDL(ByVal arrLichRanh As ArrayList)

        For i As Integer = 0 To arrLichRanh.Count - 1
            Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO = New RangBuocLopHoc_DTO()
            RangBuocLopHocDTO = arrLichRanh(i)
            CapNhatLichRanh(RangBuocLopHocDTO)
        Next

    End Sub
    Public Function TaoRangBuocLopHocMacDinh(ByVal MaRangBuocLopHoc As String, ByVal MaLopHoc As String, ByVal Thu As Integer, ByVal TietHoc As Integer) As RangBuocLopHoc_DTO
        Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO = New RangBuocLopHoc_DTO()
        RangBuocLopHocDTO.MaRangBuocLopHoc = MaRangBuocLopHoc
        RangBuocLopHocDTO.MaLopHoc = MaLopHoc
        RangBuocLopHocDTO.Thu = Thu
        RangBuocLopHocDTO.TietHoc = TietHoc
        RangBuocLopHocDTO.TrangThai = 0
        Return RangBuocLopHocDTO
    End Function
    Public Function TaoBangLichRanh(ByVal MaLopHoc As String) As ArrayList
        Dim arrLichRanh As ArrayList = New ArrayList()
        Dim index As Integer = 1
        Dim RBLH_DAO As RangBuocLopHoc_DAO = New RangBuocLopHoc_DAO()
        Dim MaRBLHCuoi As String = RBLH_DAO.LayMaRangBuocLopHocCuoi()
        Dim strTemp As String = MaRBLHCuoi.Substring(4)
        Dim MaRBLHCuoiIndex As Integer = Integer.Parse(strTemp)
        While index <= 70
            For i As Integer = 2 To 8 'thứ
                For j As Integer = 1 To 10 ' tiết học
                    'Tạo mã ràng buộc ứng với 
                    Dim intTemp As Integer = MaRBLHCuoiIndex + index
                    Dim MaRBLHMoi As String = "RBLH" & intTemp.ToString()
                    Dim RBLH As RangBuocLopHoc_DTO = TaoRangBuocLopHocMacDinh(MaRBLHMoi, MaLopHoc, i, j)
                    arrLichRanh.Add(RBLH)
                    index = index + 1
                Next
            Next
        End While
        Return arrLichRanh
    End Function

    Public Function TimTrangThai(ByVal arrLichRanh As ArrayList, ByVal TietHoc As Integer, ByVal Thu As Integer) As Integer

        For i As Integer = 0 To arrLichRanh.Count - 1
            Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO
            RangBuocLopHocDTO = arrLichRanh(i)
            If (RangBuocLopHocDTO.Thu = Thu And RangBuocLopHocDTO.TietHoc = TietHoc) Then
                Return RangBuocLopHocDTO.TrangThai
            End If
        Next
        Return -1

    End Function
End Class
