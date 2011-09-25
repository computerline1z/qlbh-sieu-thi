
CREATE TRIGGER CAPNHATDVTINH_GIA_TO_DMHANGHOA
   ON CTPHIEUNHAP
   AFTER INSERT
AS 
BEGIN
	Declare @dvtinh nchar(15)
	Declare @gianhap nchar(15)
	Declare @tysuat float(4) 
	
	set @dvtinh =  (select dvtinh from inserted)
	set @gianhap = (select gianhap from inserted) 	
	set @tysuat =  (select tysuat from tysuatgiaca ts, dmhang dm where dm.nhomhang = ts.nhomhang)
	
	
	update dmhang 
	set giaban=(@gianhap*@tysuat)+@gianhap, dvtinh=@dvtinh
	where dmhang.mahang = (select mahang from inserted)

END
GO
