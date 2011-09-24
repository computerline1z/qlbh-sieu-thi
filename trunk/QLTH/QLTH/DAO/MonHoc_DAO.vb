Imports DTO
Imports System.Data.OleDb

Public Class MonHoc_DAO
    Inherits DataProvider

    Public Function TimMonHoc(ByVal MaMH As String) As MonHoc_DTO
        Dim kq As New MonHoc_DTO
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT TenMonHoc , QuiDinhSoTietHocLienTiepToiThieu , QuiDinhSoTietHocLienTiepToiDa " & _
                        "FROM MONHOC WHERE MaMonHoc=@MaMonHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(0).Value = MaMH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return Nothing
                Else
                    reader.Read()
                    kq.MaMonHoc = MaMH
                    kq.TenMonHoc = reader("TenMonHoc").ToString()
                    kq.QuiDinhSoTietHocLienTiepToiDa = reader("QuiDinhSoTietHocLienTiepToiThieu").ToString()
                    kq.QuiDinhSoTietHocLienTiepToiDa = reader("QuiDinhSoTietHocLienTiepToiDa").ToString()
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

    Public Function LayMaMonHoc(ByVal TenMH As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaMonHoc " & _
                        "FROM MONHOC WHERE TenMonHoc=@TenMonHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@TenMonHoc", DbType.String)
            dsThS(0).Value = TenMH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("MaMonHoc").ToString()
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

    Public Function LayTenMonHoc(ByVal maMH As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT TenMonHoc " & _
                        "FROM MONHOC WHERE MaMonHoc=@MaMonHoc"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(0).Value = maMH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("TenMonHoc").ToString()
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

    Public Function LayDSTenMonHoc() As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT TenMonHoc FROM MONHOC"
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery)
                Do While reader.Read()
                    kq.Add(reader("TenMonHoc"))
                Loop
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub Them(ByVal mhDTO As MonHoc_DTO)
        Me.Connect()

        'Dim cmd As New OleDbCommand("INSERT INTO MONHOC VALUES(MaMonHoc=?, TenMonHoc=?, QuiDinhSoTietHocLienTiepToiThieu=?, QuiDinhSoTietHocLienTiepToiDa=?)", Me.connection)
        'cmd.Parameters.Add("@MaMonHoc", OleDbType.WChar)
        'cmd.Parameters.Add("@TenMonHoc", OleDbType.WChar)
        'cmd.Parameters.Add("@QuiDinhSoTietHocLienTiepToiThieu", OleDbType.Integer)
        'cmd.Parameters.Add("@QuiDinhSoTietHocLienTiepToiDa", OleDbType.Integer)

        'cmd.Parameters("@MaMonHoc").Value = mhDTO.MaMonHoc
        'cmd.Parameters("@TenMonHoc").Value = mhDTO.TenMonHoc
        'cmd.Parameters("@QuiDinhSoTietHocLienTiepToiThieu").Value = mhDTO.QuiDinhSoTietHocLienTiepToiThieu
        'cmd.Parameters("@QuiDinhSoTietHocLienTiepToiDa").Value = mhDTO.QuiDinhSoTietHocLienTiepToiDa

        Dim statement As String
        statement = "INSERT INTO MONHOC VALUES('" & mhDTO.MaMonHoc & "', '" & mhDTO.TenMonHoc & "', " & mhDTO.QuiDinhSoTietHocLienTiepToiThieu & ", " & mhDTO.QuiDinhSoTietHocLienTiepToiDa & ")"
        Dim cmd As New OleDbCommand(statement, Me.connection)

        Dim r As Int32
        r = cmd.ExecuteNonQuery()
        Me.DisConnect()

    End Sub
    Public Sub Xoa(ByVal maMonHoc As String)
        Me.Connect()
        Dim statement As String
        statement = "DELETE * FROM MONHOC WHERE MaMonHoc='" & maMonHoc & "'"
        Me.ExecuteNonQuery(statement)
        Me.DisConnect()
    End Sub
    Public Sub CapNhat(ByVal mhDTO As MonHoc_DTO)
        Me.Connect()
        'Dim cmd As New OleDbCommand("UPDATE MONHOC SET TenMonHoc=@TenMonHoc and QuiDinhSoTietHocLienTiepToiThieu=@QuiDinhSoTietHocLienTiepToiThieu and QuiDinhSoTietHocLienTiepToiDa=@QuiDinhSoTietHocLienTiepToiDa WHERE MaMonHoc=@MaMonHoc", Me.connection)
        'Dim cmd As New OleDbCommand("UPDATE MONHOC SET MONHOC.TenMonHoc=? , MONHOC.QuiDinhSoTietHocLienTiepToiThieu=? , MONHOC.QuiDinhSoTietHocLienTiepToiDa=? WHERE MONHOC.MaMonHoc=?", Me.connection)

        'cmd.Parameters.Add("@TenMonHoc", OleDbType.WChar)
        'cmd.Parameters.Add("@QuiDinhSoTietHocLienTiepToiThieu", OleDbType.Numeric)
        'cmd.Parameters.Add("@QuiDinhSoTietHocLienTiepToiDa", OleDbType.Numeric)
        'cmd.Parameters.Add("@MaMonHoc", OleDbType.WChar)

        'cmd.Parameters("@MaMonHoc").Value = mhDTO.MaMonHoc
        'cmd.Parameters("@TenMonHoc").Value = mhDTO.TenMonHoc
        'cmd.Parameters("@QuiDinhSoTietHocLienTiepToiThieu").Value = mhDTO.QuiDinhSoTietHocLienTiepToiThieu
        'cmd.Parameters("@QuiDinhSoTietHocLienTiepToiDa").Value = mhDTO.QuiDinhSoTietHocLienTiepToiDa

        Dim statement As String
        statement = "UPDATE MONHOC SET MONHOC.TenMonHoc='" & mhDTO.TenMonHoc & "' , MONHOC.QuiDinhSoTietHocLienTiepToiThieu='" & mhDTO.QuiDinhSoTietHocLienTiepToiThieu & "' , MONHOC.QuiDinhSoTietHocLienTiepToiDa='" & mhDTO.QuiDinhSoTietHocLienTiepToiDa & "' WHERE MONHOC.MaMonHoc='" & mhDTO.MaMonHoc & "'"
        Dim cmd As New OleDbCommand(statement, Me.connection)
        Dim r As Int32
        r = cmd.ExecuteNonQuery()
        Me.DisConnect()
    End Sub

    Public Function TimKiem(ByVal maMonHoc As String) As IList
        Dim dt As DataTable
        Dim l As New List(Of MonHoc_DTO)
        Dim mhDto As New MonHoc_DTO

        Me.Connect()
        dt = Me.ExecuteQueryToTable("SELECT * FROM MONHOC where MONHOC.MaMonHoc = '" & maMonHoc & "'")

        For Each row As DataRow In dt.Rows
            mhDto.MaMonHoc = row(0)
            mhDto.TenMonHoc = row(1)
            mhDto.QuiDinhSoTietHocLienTiepToiThieu = row(2)
            mhDto.QuiDinhSoTietHocLienTiepToiDa = row(3)

            l.Add(mhDto)
        Next

        Me.DisConnect()
        Return l
    End Function

    Public Function DemSoMonHoc() As Integer

    End Function

    Public Function LayBang() As DataTable
        Dim dt As DataTable
        Me.Connect()
        dt = Me.ExecuteQueryToTable("SELECT * FROM MONHOC")
        Me.DisConnect()
        Return dt
    End Function
    Public Function LayBangGiaoVienDay(ByVal monHoc As String) As DataTable
        Dim dt As DataTable
        Me.Connect()
        Dim str As String
        str = "select distinct MonHoc.MaMonHoc, GiaoVien.HoTenGiaoVien, GiaoVien.TenTat, GiaoVien.MaGiaoVien " & _
                "from ((Monhoc inner join phancong on Monhoc.mamonhoc = phancong.mamonhoc) inner join giaovien on phancong.magiaovien = giaovien.magiaovien) " & _
                "where monhoc.mamonhoc = '" & monHoc & "';"
        dt = Me.ExecuteQueryToTable(str)
        Me.DisConnect()
        Return dt
    End Function
    Public Function LayDanhSach() As IList
        Dim dr As OleDbDataReader
        Dim ds As New ArrayList

        Me.Connect()
        dr = Me.ExecuteQuery("SELECT * FROM MONHOC")

        While (dr.Read())
            Dim mhDto As New MonHoc_DTO
            mhDto.MaMonHoc = dr("MaMonHoc")
            mhDto.TenMonHoc = dr("TenMonHoc")
            mhDto.QuiDinhSoTietHocLienTiepToiThieu = dr("QuiDinhSoTietHocLienTiepToiThieu")
            mhDto.QuiDinhSoTietHocLienTiepToiDa = dr("QuiDinhSoTietHocLienTiepToiDa")

            ds.Add(mhDto)
        End While

        dr.Close()
        Me.DisConnect()
        Return ds

    End Function

End Class
