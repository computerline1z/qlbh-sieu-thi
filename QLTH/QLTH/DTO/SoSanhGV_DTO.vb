Public Class SoSanhGV_DTO
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
         Implements IComparer.Compare
        Dim gvDTO1 As GiaoVien_DTO = x
        Dim gvDTO2 As GiaoVien_DTO = y
        Return New CaseInsensitiveComparer().Compare(gvDTO1.HoTenGiaoVien, gvDTO2.HoTenGiaoVien)
    End Function
End Class
