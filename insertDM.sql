
CREATE TRIGGER themdm
   ON  CTPHIEUNHAP
   INSTEAD OF  INSERT
AS 
BEGIN
		Declare @maphieu char(7)
		Declare @mahang char(7)
		Declare @soluong int
		Declare @loai char(7)
		Declare @gianhap money
		Declare @giaban money
		Declare @tenhang char(30)
		
		set @maphieu = (select maphieu from inserted)
		set @mahang = (select mahang from inserted)
		set @soluong = (select soluong1 from inserted)
		set @loai = (select loai1 from inserted)
		set @gianhap = (select gianhap from inserted)
		set @giaban = @gianhap + (@gianhap*0.15)
		set @tenhang = (select tenhang from inserted)
		
		insert into DMHANG values(@mahang,@loai,@tenhang,@giaban); 
		insert into CTPHIEUNHAP values(@maphieu,@mahang,@tenhang,@loai,@soluong,@gianhap); 
		
END
GO
