/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/09/2011 1:51:55 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDCTY') and o.name = 'FK_CTHDCTY_CUA3_HOADONCT')
alter table CTHDCTY
   drop constraint FK_CTHDCTY_CUA3_HOADONCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDCTY') and o.name = 'FK_CTHDCTY_LIENQUAN2_DMHANG')
alter table CTHDCTY
   drop constraint FK_CTHDCTY_LIENQUAN2_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDLE') and o.name = 'FK_CTHDLE_CUA2_HOADONLE')
alter table CTHDLE
   drop constraint FK_CTHDLE_CUA2_HOADONLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDLE') and o.name = 'FK_CTHDLE_LIENQUAN1_DMHANG')
alter table CTHDLE
   drop constraint FK_CTHDLE_LIENQUAN1_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUCHUYEN') and o.name = 'FK_CTPHIEUC_CUA4_PHIEUCHU')
alter table CTPHIEUCHUYEN
   drop constraint FK_CTPHIEUC_CUA4_PHIEUCHU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUCHUYEN') and o.name = 'FK_CTPHIEUC_LIENQUAN4_DMHANG')
alter table CTPHIEUCHUYEN
   drop constraint FK_CTPHIEUC_LIENQUAN4_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUNHAP') and o.name = 'FK_CTPHIEUN_CHUA1_DMHANG')
alter table CTPHIEUNHAP
   drop constraint FK_CTPHIEUN_CHUA1_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUNHAP') and o.name = 'FK_CTPHIEUN_CO3_PHIEUNHA')
alter table CTPHIEUNHAP
   drop constraint FK_CTPHIEUN_CO3_PHIEUNHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUXUAT') and o.name = 'FK_CTPHIEUX_CHUA_DMHANG')
alter table CTPHIEUXUAT
   drop constraint FK_CTPHIEUX_CHUA_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUXUAT') and o.name = 'FK_CTPHIEUX_CO2_PHIEUXUA')
alter table CTPHIEUXUAT
   drop constraint FK_CTPHIEUX_CO2_PHIEUXUA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUXUAT') and o.name = 'FK_CTPHIEUX_XUATCHO_HOADONCT')
alter table CTPHIEUXUAT
   drop constraint FK_CTPHIEUX_XUATCHO_HOADONCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DDH') and o.name = 'FK_CT_DDH_LIENQUAN_DONDATHA')
alter table CT_DDH
   drop constraint FK_CT_DDH_LIENQUAN_DONDATHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CT_DDH') and o.name = 'FK_CT_DDH_TRONG_DMHANG')
alter table CT_DDH
   drop constraint FK_CT_DDH_TRONG_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGCAP') and o.name = 'FK_CUNGCAP_DENGHI_NHACUNGC')
alter table CUNGCAP
   drop constraint FK_CUNGCAP_DENGHI_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNGCAP') and o.name = 'FK_CUNGCAP_LIENQUAN6_DMHANG')
alter table CUNGCAP
   drop constraint FK_CUNGCAP_LIENQUAN6_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DMHANG') and o.name = 'FK_DMHANG_THUOC_LOAIHANG')
alter table DMHANG
   drop constraint FK_DMHANG_THUOC_LOAIHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DMHANG') and o.name = 'FK_DMHANG_THUOC3_TYSUATGI')
alter table DMHANG
   drop constraint FK_DMHANG_THUOC3_TYSUATGI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DONDATHANG') and o.name = 'FK_DONDATHA_LAPDDH_NHANVIEN')
alter table DONDATHANG
   drop constraint FK_DONDATHA_LAPDDH_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DONDATHANG') and o.name = 'FK_DONDATHA_THAMKHAOD_NHACUNGC')
alter table DONDATHANG
   drop constraint FK_DONDATHA_THAMKHAOD_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HANG_KM') and o.name = 'FK_HANG_KM_AP_DUNG_KHUYENMA')
alter table HANG_KM
   drop constraint FK_HANG_KM_AP_DUNG_KHUYENMA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HANG_KM') and o.name = 'FK_HANG_KM_CO_DMHANG')
alter table HANG_KM
   drop constraint FK_HANG_KM_CO_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONCTY') and o.name = 'FK_HOADONCT_LAPHD1_NHANVIEN')
alter table HOADONCTY
   drop constraint FK_HOADONCT_LAPHD1_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONCTY') and o.name = 'FK_HOADONCT_LIENQUAN5_KHACH_CT')
alter table HOADONCTY
   drop constraint FK_HOADONCT_LIENQUAN5_KHACH_CT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONLE') and o.name = 'FK_HOADONLE_LAPHD2_NHANVIEN')
alter table HOADONLE
   drop constraint FK_HOADONLE_LAPHD2_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUCHUYEN') and o.name = 'FK_PHIEUCHU_CHUYENTAI_KHO')
alter table PHIEUCHUYEN
   drop constraint FK_PHIEUCHU_CHUYENTAI_KHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUCHUYEN') and o.name = 'FK_PHIEUCHU_LAPPC_NHANVIEN')
alter table PHIEUCHUYEN
   drop constraint FK_PHIEUCHU_LAPPC_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_CUA5_NHACUNGC')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_CUA5_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_LAPPN_NHANVIEN')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_LAPPN_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_NHAPTAI_KHO')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_NHAPTAI_KHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUXUAT') and o.name = 'FK_PHIEUXUA_LAPPX_NHANVIEN')
alter table PHIEUXUAT
   drop constraint FK_PHIEUXUA_LAPPX_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUXUAT') and o.name = 'FK_PHIEUXUA_XUATTAI_KHO')
alter table PHIEUXUAT
   drop constraint FK_PHIEUXUA_XUATTAI_KHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAIKHOAN') and o.name = 'FK_TAIKHOAN_THUOC1_LOAITK')
alter table TAIKHOAN
   drop constraint FK_TAIKHOAN_THUOC1_LOAITK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('THEKHO') and o.name = 'FK_THEKHO_LAPTHE_KHO')
alter table THEKHO
   drop constraint FK_THEKHO_LAPTHE_KHO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('THEKHO') and o.name = 'FK_THEKHO_LIENQUAN3_DMHANG')
alter table THEKHO
   drop constraint FK_THEKHO_LIENQUAN3_DMHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDCTY')
            and   name  = 'CUA3_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDCTY.CUA3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDCTY')
            and   name  = 'LIENQUAN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDCTY.LIENQUAN2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTHDCTY')
            and   type = 'U')
   drop table CTHDCTY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDLE')
            and   name  = 'CUA2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDLE.CUA2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDLE')
            and   name  = 'LIENQUAN1_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDLE.LIENQUAN1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTHDLE')
            and   type = 'U')
   drop table CTHDLE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUCHUYEN')
            and   name  = 'LIENQUAN4_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUCHUYEN.LIENQUAN4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUCHUYEN')
            and   name  = 'CUA4_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUCHUYEN.CUA4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTPHIEUCHUYEN')
            and   type = 'U')
   drop table CTPHIEUCHUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUNHAP')
            and   name  = 'CHUA1_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUNHAP.CHUA1_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUNHAP')
            and   name  = 'CO3_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUNHAP.CO3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTPHIEUNHAP')
            and   type = 'U')
   drop table CTPHIEUNHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUXUAT')
            and   name  = 'XUATCHO_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUXUAT.XUATCHO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUXUAT')
            and   name  = 'CHUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUXUAT.CHUA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUXUAT')
            and   name  = 'CO2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUXUAT.CO2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTPHIEUXUAT')
            and   type = 'U')
   drop table CTPHIEUXUAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DDH')
            and   name  = 'TRONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_DDH.TRONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CT_DDH')
            and   name  = 'LIENQUAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index CT_DDH.LIENQUAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_DDH')
            and   type = 'U')
   drop table CT_DDH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGCAP')
            and   name  = 'LIENQUAN6_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGCAP.LIENQUAN6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNGCAP')
            and   name  = 'DENGHI_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNGCAP.DENGHI_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUNGCAP')
            and   type = 'U')
   drop table CUNGCAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DMHANG')
            and   name  = 'THUOC3_FK'
            and   indid > 0
            and   indid < 255)
   drop index DMHANG.THUOC3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DMHANG')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index DMHANG.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DMHANG')
            and   type = 'U')
   drop table DMHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DONDATHANG')
            and   name  = 'THAMKHAODEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index DONDATHANG.THAMKHAODEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DONDATHANG')
            and   name  = 'LAPDDH_FK'
            and   indid > 0
            and   indid < 255)
   drop index DONDATHANG.LAPDDH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DONDATHANG')
            and   type = 'U')
   drop table DONDATHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HANG_KM')
            and   name  = 'AP_DUNG_FK'
            and   indid > 0
            and   indid < 255)
   drop index HANG_KM.AP_DUNG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HANG_KM')
            and   name  = 'CO_FK'
            and   indid > 0
            and   indid < 255)
   drop index HANG_KM.CO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HANG_KM')
            and   type = 'U')
   drop table HANG_KM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONCTY')
            and   name  = 'LIENQUAN5_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONCTY.LIENQUAN5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONCTY')
            and   name  = 'LAPHD1_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONCTY.LAPHD1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONCTY')
            and   type = 'U')
   drop table HOADONCTY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONLE')
            and   name  = 'LAPHD2_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONLE.LAPHD2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONLE')
            and   type = 'U')
   drop table HOADONLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACH_CTY')
            and   type = 'U')
   drop table KHACH_CTY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHO')
            and   type = 'U')
   drop table KHO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHUYENMAI')
            and   type = 'U')
   drop table KHUYENMAI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAIHANG')
            and   type = 'U')
   drop table LOAIHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAITK')
            and   type = 'U')
   drop table LOAITK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHACUNGCAP')
            and   type = 'U')
   drop table NHACUNGCAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUCHUYEN')
            and   name  = 'CHUYENTAI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUCHUYEN.CHUYENTAI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUCHUYEN')
            and   name  = 'LAPPC_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUCHUYEN.LAPPC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUCHUYEN')
            and   type = 'U')
   drop table PHIEUCHUYEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'NHAPTAI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.NHAPTAI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'CUA5_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.CUA5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'LAPPN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.LAPPN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUNHAP')
            and   type = 'U')
   drop table PHIEUNHAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUXUAT')
            and   name  = 'XUATTAI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUXUAT.XUATTAI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUXUAT')
            and   name  = 'LAPPX_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUXUAT.LAPPX_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUXUAT')
            and   type = 'U')
   drop table PHIEUXUAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TAIKHOAN')
            and   name  = 'THUOC1_FK'
            and   indid > 0
            and   indid < 255)
   drop index TAIKHOAN.THUOC1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAIKHOAN')
            and   type = 'U')
   drop table TAIKHOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('THEKHO')
            and   name  = 'LAPTHE_FK'
            and   indid > 0
            and   indid < 255)
   drop index THEKHO.LAPTHE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('THEKHO')
            and   name  = 'LIENQUAN3_FK'
            and   indid > 0
            and   indid < 255)
   drop index THEKHO.LIENQUAN3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THEKHO')
            and   type = 'U')
   drop table THEKHO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYSUATGIACA')
            and   type = 'U')
   drop table TYSUATGIACA
go

/*==============================================================*/
/* Table: CTHDCTY                                               */
/*==============================================================*/
create table CTHDCTY (
   MAHANG               char(7)              not null,
   SOHDCTY              char(7)              not null,
   SOLUONG              int                  null,
   constraint PK_CTHDCTY primary key (MAHANG, SOHDCTY)
)
go

/*==============================================================*/
/* Index: LIENQUAN2_FK                                          */
/*==============================================================*/
create index LIENQUAN2_FK on CTHDCTY (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: CUA3_FK                                               */
/*==============================================================*/
create index CUA3_FK on CTHDCTY (
SOHDCTY ASC
)
go

/*==============================================================*/
/* Table: CTHDLE                                                */
/*==============================================================*/
create table CTHDLE (
   MAHANG               char(7)              not null,
   SOHDLE               char(7)              not null,
   SOLUONG              int                  null,
   constraint PK_CTHDLE primary key (MAHANG, SOHDLE)
)
go

/*==============================================================*/
/* Index: LIENQUAN1_FK                                          */
/*==============================================================*/
create index LIENQUAN1_FK on CTHDLE (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: CUA2_FK                                               */
/*==============================================================*/
create index CUA2_FK on CTHDLE (
SOHDLE ASC
)
go

/*==============================================================*/
/* Table: CTPHIEUCHUYEN                                         */
/*==============================================================*/
create table CTPHIEUCHUYEN (
   MAPHIEU3             char(7)              not null,
   MAHANG               char(7)              not null,
   SOLUONG              int                  null,
   DIENGIAI             nvarchar(30)         null,
   constraint PK_CTPHIEUCHUYEN primary key (MAPHIEU3, MAHANG)
)
go

/*==============================================================*/
/* Index: CUA4_FK                                               */
/*==============================================================*/
create index CUA4_FK on CTPHIEUCHUYEN (
MAPHIEU3 ASC
)
go

/*==============================================================*/
/* Index: LIENQUAN4_FK                                          */
/*==============================================================*/
create index LIENQUAN4_FK on CTPHIEUCHUYEN (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: CTPHIEUNHAP                                           */
/*==============================================================*/
create table CTPHIEUNHAP (
   MAPHIEU              char(7)              not null,
   MAHANG               char(7)              not null,
   SOLUONG1             int                  null,
   GIANHAP              money                null,
   constraint PK_CTPHIEUNHAP primary key (MAPHIEU, MAHANG)
)
go

/*==============================================================*/
/* Index: CO3_FK                                                */
/*==============================================================*/
create index CO3_FK on CTPHIEUNHAP (
MAPHIEU ASC
)
go

/*==============================================================*/
/* Index: CHUA1_FK                                              */
/*==============================================================*/
create index CHUA1_FK on CTPHIEUNHAP (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: CTPHIEUXUAT                                           */
/*==============================================================*/
create table CTPHIEUXUAT (
   MAPHIEU1             char(7)              not null,
   MAHANG               char(7)              not null,
   SOHDCTY              char(7)              not null,
   SOLUONG1             int                  null,
   constraint PK_CTPHIEUXUAT primary key (MAPHIEU1, MAHANG, SOHDCTY)
)
go

/*==============================================================*/
/* Index: CO2_FK                                                */
/*==============================================================*/
create index CO2_FK on CTPHIEUXUAT (
MAPHIEU1 ASC
)
go

/*==============================================================*/
/* Index: CHUA_FK                                               */
/*==============================================================*/
create index CHUA_FK on CTPHIEUXUAT (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: XUATCHO_FK                                            */
/*==============================================================*/
create index XUATCHO_FK on CTPHIEUXUAT (
SOHDCTY ASC
)
go

/*==============================================================*/
/* Table: CT_DDH                                                */
/*==============================================================*/
create table CT_DDH (
   SODDH                char(7)              not null,
   MAHANG               char(7)              not null,
   constraint PK_CT_DDH primary key (SODDH, MAHANG)
)
go

/*==============================================================*/
/* Index: LIENQUAN_FK                                           */
/*==============================================================*/
create index LIENQUAN_FK on CT_DDH (
SODDH ASC
)
go

/*==============================================================*/
/* Index: TRONG_FK                                              */
/*==============================================================*/
create index TRONG_FK on CT_DDH (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: CUNGCAP                                               */
/*==============================================================*/
create table CUNGCAP (
   MANCC                char(7)              not null,
   MAHANG               char(7)              not null,
   constraint PK_CUNGCAP primary key (MANCC, MAHANG)
)
go

/*==============================================================*/
/* Index: DENGHI_FK                                             */
/*==============================================================*/
create index DENGHI_FK on CUNGCAP (
MANCC ASC
)
go

/*==============================================================*/
/* Index: LIENQUAN6_FK                                          */
/*==============================================================*/
create index LIENQUAN6_FK on CUNGCAP (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: DMHANG                                                */
/*==============================================================*/
create table DMHANG (
   MAHANG               char(7)              not null,
   LOAI1                char(7)              not null,
   MANHOM               char(7)              not null,
   TENHANG              nvarchar(30)         null,
   DVTINH               nvarchar(15)         null,
   GIABAN               money                null,
   TRANGTHAI            bit                  null,
   constraint PK_DMHANG primary key nonclustered (MAHANG)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on DMHANG (
LOAI1 ASC
)
go

/*==============================================================*/
/* Index: THUOC3_FK                                             */
/*==============================================================*/
create index THUOC3_FK on DMHANG (
MANHOM ASC
)
go

/*==============================================================*/
/* Table: DONDATHANG                                            */
/*==============================================================*/
create table DONDATHANG (
   SODDH                char(7)              not null,
   MANCC                char(7)              not null,
   MANV1                char(7)              not null,
   NGAYLAP              datetime             null,
   PHUONGTHUCTT         nvarchar(30)         null,
   constraint PK_DONDATHANG primary key nonclustered (SODDH)
)
go

/*==============================================================*/
/* Index: LAPDDH_FK                                             */
/*==============================================================*/
create index LAPDDH_FK on DONDATHANG (
MANV1 ASC
)
go

/*==============================================================*/
/* Index: THAMKHAODEN_FK                                        */
/*==============================================================*/
create index THAMKHAODEN_FK on DONDATHANG (
MANCC ASC
)
go

/*==============================================================*/
/* Table: HANG_KM                                               */
/*==============================================================*/
create table HANG_KM (
   MAHANG               char(7)              not null,
   LOAIKM               char(7)              not null,
   TG_BATDAU            datetime             null,
   TG_KETTHUC           datetime             null,
   constraint PK_HANG_KM primary key (MAHANG, LOAIKM)
)
go

/*==============================================================*/
/* Index: CO_FK                                                 */
/*==============================================================*/
create index CO_FK on HANG_KM (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: AP_DUNG_FK                                            */
/*==============================================================*/
create index AP_DUNG_FK on HANG_KM (
LOAIKM ASC
)
go

/*==============================================================*/
/* Table: HOADONCTY                                             */
/*==============================================================*/
create table HOADONCTY (
   SOHDCTY              char(7)              not null,
   MANV1                char(7)              not null,
   MAKH                 char(7)              not null,
   NGAYHD               datetime             null,
   PHUONGTHUCTT         nvarchar(30)         null,
   CHIETKHAU            float(2)             null,
   constraint PK_HOADONCTY primary key nonclustered (SOHDCTY)
)
go

/*==============================================================*/
/* Index: LAPHD1_FK                                             */
/*==============================================================*/
create index LAPHD1_FK on HOADONCTY (
MANV1 ASC
)
go

/*==============================================================*/
/* Index: LIENQUAN5_FK                                          */
/*==============================================================*/
create index LIENQUAN5_FK on HOADONCTY (
MAKH ASC
)
go

/*==============================================================*/
/* Table: HOADONLE                                              */
/*==============================================================*/
create table HOADONLE (
   SOHDLE               char(7)              not null,
   MANV1                char(7)              not null,
   NGAYHD               datetime             null,
   constraint PK_HOADONLE primary key nonclustered (SOHDLE)
)
go

/*==============================================================*/
/* Index: LAPHD2_FK                                             */
/*==============================================================*/
create index LAPHD2_FK on HOADONLE (
MANV1 ASC
)
go

/*==============================================================*/
/* Table: KHACH_CTY                                             */
/*==============================================================*/
create table KHACH_CTY (
   MAKH                 char(7)              not null,
   TENKH                char(30)             null,
   DIACHI               nvarchar(30)         null,
   DIENTHOAI            nvarchar(12)         null,
   FAX                  nvarchar(12)         null,
   MATHUE               nvarchar(7)          null,
   SOTK                 nvarchar(7)          null,
   TRANGTHAI            bit                  null,
   constraint PK_KHACH_CTY primary key nonclustered (MAKH)
)
go

/*==============================================================*/
/* Table: KHO                                                   */
/*==============================================================*/
create table KHO (
   MAKHO                char(7)              not null,
   TENKHO               char(30)             null,
   DIACHIKHO            nvarchar(30)         null,
   constraint PK_KHO primary key nonclustered (MAKHO)
)
go

/*==============================================================*/
/* Table: KHUYENMAI                                             */
/*==============================================================*/
create table KHUYENMAI (
   LOAIKM               char(7)              not null,
   DIENGIAI             nvarchar(30)         null,
   constraint PK_KHUYENMAI primary key nonclustered (LOAIKM)
)
go

/*==============================================================*/
/* Table: LOAIHANG                                              */
/*==============================================================*/
create table LOAIHANG (
   LOAI1                char(7)              not null,
   TENLOAI              nvarchar(30)         null,
   constraint PK_LOAIHANG primary key nonclustered (LOAI1)
)
go

/*==============================================================*/
/* Table: LOAITK                                                */
/*==============================================================*/
create table LOAITK (
   LOAITK               int                  not null,
   MOTA                 char(30)             null,
   constraint PK_LOAITK primary key nonclustered (LOAITK)
)
go

/*==============================================================*/
/* Table: NHACUNGCAP                                            */
/*==============================================================*/
create table NHACUNGCAP (
   MANCC                char(7)              not null,
   TENNCC               nvarchar(30)         null,
   DIACHI               nvarchar(30)         null,
   DIENTHOAI            nvarchar(12)         null,
   FAX                  nvarchar(12)         null,
   MATHUE               nvarchar(7)          null,
   SOTK                 nvarchar(7)          null,
   constraint PK_NHACUNGCAP primary key nonclustered (MANCC)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV1                char(7)              not null,
   TENNV                char(30)             null,
   DIACHI               nvarchar(30)         null,
   DIENTHOAI            nvarchar(12)         null,
   TRANGTHAI            bit                  null,
   constraint PK_NHANVIEN primary key nonclustered (MANV1)
)
go

/*==============================================================*/
/* Table: PHIEUCHUYEN                                           */
/*==============================================================*/
create table PHIEUCHUYEN (
   MAPHIEU3             char(7)              not null,
   MAKHO                char(7)              not null,
   MANV1                char(7)              not null,
   NGAYCHUYEN           datetime             null,
   constraint PK_PHIEUCHUYEN primary key nonclustered (MAPHIEU3)
)
go

/*==============================================================*/
/* Index: LAPPC_FK                                              */
/*==============================================================*/
create index LAPPC_FK on PHIEUCHUYEN (
MANV1 ASC
)
go

/*==============================================================*/
/* Index: CHUYENTAI_FK                                          */
/*==============================================================*/
create index CHUYENTAI_FK on PHIEUCHUYEN (
MAKHO ASC
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   MAPHIEU              char(7)              not null,
   MANCC                char(7)              not null,
   MAKHO                char(7)              not null,
   MANV1                char(7)              not null,
   NGAYNHAP             datetime             null,
   constraint PK_PHIEUNHAP primary key nonclustered (MAPHIEU)
)
go

/*==============================================================*/
/* Index: LAPPN_FK                                              */
/*==============================================================*/
create index LAPPN_FK on PHIEUNHAP (
MANV1 ASC
)
go

/*==============================================================*/
/* Index: CUA5_FK                                               */
/*==============================================================*/
create index CUA5_FK on PHIEUNHAP (
MANCC ASC
)
go

/*==============================================================*/
/* Index: NHAPTAI_FK                                            */
/*==============================================================*/
create index NHAPTAI_FK on PHIEUNHAP (
MAKHO ASC
)
go

/*==============================================================*/
/* Table: PHIEUXUAT                                             */
/*==============================================================*/
create table PHIEUXUAT (
   MAPHIEU1             char(7)              not null,
   MAKHO                char(7)              not null,
   MANV1                char(7)              not null,
   NGAYXUAT             datetime             null,
   constraint PK_PHIEUXUAT primary key nonclustered (MAPHIEU1)
)
go

/*==============================================================*/
/* Index: LAPPX_FK                                              */
/*==============================================================*/
create index LAPPX_FK on PHIEUXUAT (
MANV1 ASC
)
go

/*==============================================================*/
/* Index: XUATTAI_FK                                            */
/*==============================================================*/
create index XUATTAI_FK on PHIEUXUAT (
MAKHO ASC
)
go

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN (
   USERNAME             char(30)             not null,
   LOAITK               int                  not null,
   PASSWORD             char(30)             null,
   constraint PK_TAIKHOAN primary key nonclustered (USERNAME)
)
go

/*==============================================================*/
/* Index: THUOC1_FK                                             */
/*==============================================================*/
create index THUOC1_FK on TAIKHOAN (
LOAITK ASC
)
go

/*==============================================================*/
/* Table: THEKHO                                                */
/*==============================================================*/
create table THEKHO (
   MACTU                char(7)              not null,
   MAHANG               char(7)              not null,
   MAKHO                char(7)              not null,
   NGAYCTU              datetime             null,
   DIENGIAI             nvarchar(30)         null,
   SOLUONG              int                  null,
   constraint PK_THEKHO primary key nonclustered (MACTU)
)
go

/*==============================================================*/
/* Index: LIENQUAN3_FK                                          */
/*==============================================================*/
create index LIENQUAN3_FK on THEKHO (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: LAPTHE_FK                                             */
/*==============================================================*/
create index LAPTHE_FK on THEKHO (
MAKHO ASC
)
go

/*==============================================================*/
/* Table: TYSUATGIACA                                           */
/*==============================================================*/
create table TYSUATGIACA (
   MANHOM               char(7)              not null,
   TYSUAT               float(4)             null,
   constraint PK_TYSUATGIACA primary key nonclustered (MANHOM)
)
go

alter table CTHDCTY
   add constraint FK_CTHDCTY_CUA3_HOADONCT foreign key (SOHDCTY)
      references HOADONCTY (SOHDCTY)
go

alter table CTHDCTY
   add constraint FK_CTHDCTY_LIENQUAN2_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTHDLE
   add constraint FK_CTHDLE_CUA2_HOADONLE foreign key (SOHDLE)
      references HOADONLE (SOHDLE)
go

alter table CTHDLE
   add constraint FK_CTHDLE_LIENQUAN1_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUCHUYEN
   add constraint FK_CTPHIEUC_CUA4_PHIEUCHU foreign key (MAPHIEU3)
      references PHIEUCHUYEN (MAPHIEU3)
go

alter table CTPHIEUCHUYEN
   add constraint FK_CTPHIEUC_LIENQUAN4_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUNHAP
   add constraint FK_CTPHIEUN_CHUA1_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUNHAP
   add constraint FK_CTPHIEUN_CO3_PHIEUNHA foreign key (MAPHIEU)
      references PHIEUNHAP (MAPHIEU)
go

alter table CTPHIEUXUAT
   add constraint FK_CTPHIEUX_CHUA_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUXUAT
   add constraint FK_CTPHIEUX_CO2_PHIEUXUA foreign key (MAPHIEU1)
      references PHIEUXUAT (MAPHIEU1)
go

alter table CTPHIEUXUAT
   add constraint FK_CTPHIEUX_XUATCHO_HOADONCT foreign key (SOHDCTY)
      references HOADONCTY (SOHDCTY)
go

alter table CT_DDH
   add constraint FK_CT_DDH_LIENQUAN_DONDATHA foreign key (SODDH)
      references DONDATHANG (SODDH)
go

alter table CT_DDH
   add constraint FK_CT_DDH_TRONG_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CUNGCAP
   add constraint FK_CUNGCAP_DENGHI_NHACUNGC foreign key (MANCC)
      references NHACUNGCAP (MANCC)
go

alter table CUNGCAP
   add constraint FK_CUNGCAP_LIENQUAN6_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table DMHANG
   add constraint FK_DMHANG_THUOC_LOAIHANG foreign key (LOAI1)
      references LOAIHANG (LOAI1)
go

alter table DMHANG
   add constraint FK_DMHANG_THUOC3_TYSUATGI foreign key (MANHOM)
      references TYSUATGIACA (MANHOM)
go

alter table DONDATHANG
   add constraint FK_DONDATHA_LAPDDH_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table DONDATHANG
   add constraint FK_DONDATHA_THAMKHAOD_NHACUNGC foreign key (MANCC)
      references NHACUNGCAP (MANCC)
go

alter table HANG_KM
   add constraint FK_HANG_KM_AP_DUNG_KHUYENMA foreign key (LOAIKM)
      references KHUYENMAI (LOAIKM)
go

alter table HANG_KM
   add constraint FK_HANG_KM_CO_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table HOADONCTY
   add constraint FK_HOADONCT_LAPHD1_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table HOADONCTY
   add constraint FK_HOADONCT_LIENQUAN5_KHACH_CT foreign key (MAKH)
      references KHACH_CTY (MAKH)
go

alter table HOADONLE
   add constraint FK_HOADONLE_LAPHD2_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table PHIEUCHUYEN
   add constraint FK_PHIEUCHU_CHUYENTAI_KHO foreign key (MAKHO)
      references KHO (MAKHO)
go

alter table PHIEUCHUYEN
   add constraint FK_PHIEUCHU_LAPPC_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_CUA5_NHACUNGC foreign key (MANCC)
      references NHACUNGCAP (MANCC)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_LAPPN_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_NHAPTAI_KHO foreign key (MAKHO)
      references KHO (MAKHO)
go

alter table PHIEUXUAT
   add constraint FK_PHIEUXUA_LAPPX_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table PHIEUXUAT
   add constraint FK_PHIEUXUA_XUATTAI_KHO foreign key (MAKHO)
      references KHO (MAKHO)
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_THUOC1_LOAITK foreign key (LOAITK)
      references LOAITK (LOAITK)
go

alter table THEKHO
   add constraint FK_THEKHO_LAPTHE_KHO foreign key (MAKHO)
      references KHO (MAKHO)
go

alter table THEKHO
   add constraint FK_THEKHO_LIENQUAN3_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

