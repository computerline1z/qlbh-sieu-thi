CREATE TRIGGER CTPX_TO_THEKHO
   ON  CTPHIEUXUAT
   AFTER INSERT
AS 
BEGIN
	Declare @mahang Char(7)
	Declare @makho Char(7)
	Declare @mactu Char(7)
	Declare @ngayctu date
	Declare @soluong int
	
	set @mahang = (select mahang from inserted)
	set @mactu = (select maphieu from inserted)
	set @soluong = (select soluong from inserted)
	set @ngayctu = (select ngayxuat from inserted JOIN phieuxuat px ON px.maphieu = inserted.maphieu)
	set @makho = (SELECT makho FROM inserted  JOIN phieuxuat px ON px.maphieu  = inserted.maphieu)

	insert into thekho(mahang, makho, mactu,ngayctu,diengiai,soluong) values(@mahang, @makho,@mactu,@ngayctu,'X',@soluong)
	
END
GO
