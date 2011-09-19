/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     9/19/2011 9:15:30 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDCTY') and o.name = 'FK_CTHDCTY_RELATIONS_DMHANG')
alter table CTHDCTY
   drop constraint FK_CTHDCTY_RELATIONS_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDCTY') and o.name = 'FK_CTHDCTY_RELATIONS_HOADONCT')
alter table CTHDCTY
   drop constraint FK_CTHDCTY_RELATIONS_HOADONCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDLE') and o.name = 'FK_CTHDLE_RELATIONS_DMHANG')
alter table CTHDLE
   drop constraint FK_CTHDLE_RELATIONS_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTHDLE') and o.name = 'FK_CTHDLE_RELATIONS_HOADONLE')
alter table CTHDLE
   drop constraint FK_CTHDLE_RELATIONS_HOADONLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUNHAP') and o.name = 'FK_CTPHIEUN_C03_PHIEUNHA')
alter table CTPHIEUNHAP
   drop constraint FK_CTPHIEUN_C03_PHIEUNHA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CTPHIEUNHAP') and o.name = 'FK_CTPHIEUN_CHUA_TRON_DMHANG')
alter table CTPHIEUNHAP
   drop constraint FK_CTPHIEUN_CHUA_TRON_DMHANG
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
   where r.fkeyid = object_id('CUNG_CAP') and o.name = 'FK_CUNG_CAP_CUNG_CAP_NHACUNGC')
alter table CUNG_CAP
   drop constraint FK_CUNG_CAP_CUNG_CAP_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUNG_CAP') and o.name = 'FK_CUNG_CAP_CUNG_CAP2_DMHANG')
alter table CUNG_CAP
   drop constraint FK_CUNG_CAP_CUNG_CAP2_DMHANG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DMHANG') and o.name = 'FK_DMHANG_THUOC_LOAIHANG')
alter table DMHANG
   drop constraint FK_DMHANG_THUOC_LOAIHANG
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
   where r.fkeyid = object_id('HOADONCTY') and o.name = 'FK_HOADONCT_RELATIONS_KHACHHAN')
alter table HOADONCTY
   drop constraint FK_HOADONCT_RELATIONS_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONLE') and o.name = 'FK_HOADONLE_LAPHD2_NHANVIEN')
alter table HOADONLE
   drop constraint FK_HOADONLE_LAPHD2_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONLE') and o.name = 'FK_HOADONLE_RELATIONS_KHACHHAN')
alter table HOADONLE
   drop constraint FK_HOADONLE_RELATIONS_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACHCTY') and o.name = 'FK_KHACHCTY_GOM_KHACHHAN')
alter table KHACHCTY
   drop constraint FK_KHACHCTY_GOM_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHACHTT') and o.name = 'FK_KHACHTT_GOM2_KHACHHAN')
alter table KHACHTT
   drop constraint FK_KHACHTT_GOM2_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHO') and o.name = 'FK_KHO_TRONG_KHO_CTPHIEUN')
alter table KHO
   drop constraint FK_KHO_TRONG_KHO_CTPHIEUN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KHO') and o.name = 'FK_KHO_TRONG_KHO_CTPHIEUX')
alter table KHO
   drop constraint FK_KHO_TRONG_KHO_CTPHIEUX
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_CUA5_NHACUNGC')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_CUA5_NHACUNGC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUNHAP') and o.name = 'FK_PHIEUNHA_LAP_PN_NHANVIEN')
alter table PHIEUNHAP
   drop constraint FK_PHIEUNHA_LAP_PN_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUXUAT') and o.name = 'FK_PHIEUXUA_LAP_PX_NHANVIEN')
alter table PHIEUXUAT
   drop constraint FK_PHIEUXUA_LAP_PX_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAIKHOAN') and o.name = 'FK_TAIKHOAN_THUOC1_LOAITK')
alter table TAIKHOAN
   drop constraint FK_TAIKHOAN_THUOC1_LOAITK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TONKHO') and o.name = 'FK_TONKHO_TON_DMHANG')
alter table TONKHO
   drop constraint FK_TONKHO_TON_DMHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDCTY')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDCTY.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDCTY')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDCTY.RELATIONSHIP_17_FK
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
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDLE.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTHDLE')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTHDLE.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CTHDLE')
            and   type = 'U')
   drop table CTHDLE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUNHAP')
            and   name  = 'CHUA_TRONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUNHAP.CHUA_TRONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CTPHIEUNHAP')
            and   name  = 'C03_FK'
            and   indid > 0
            and   indid < 255)
   drop index CTPHIEUNHAP.C03_FK
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
           where  id    = object_id('CUNG_CAP')
            and   name  = 'CUNG_CAP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNG_CAP.CUNG_CAP2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUNG_CAP')
            and   name  = 'CUNG_CAP_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUNG_CAP.CUNG_CAP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUNG_CAP')
            and   type = 'U')
   drop table CUNG_CAP
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
            and   name  = 'LAPHD1_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONCTY.LAPHD1_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOADONCTY')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONCTY.RELATIONSHIP_20_FK
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
            from  sysindexes
           where  id    = object_id('HOADONLE')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOADONLE.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONLE')
            and   type = 'U')
   drop table HOADONLE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHCTY')
            and   type = 'U')
   drop table KHACHCTY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHTT')
            and   type = 'U')
   drop table KHACHTT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KHO')
            and   name  = 'TRONG_KHO1_FK'
            and   indid > 0
            and   indid < 255)
   drop index KHO.TRONG_KHO1_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KHO')
            and   name  = 'TRONG_KHO_FK'
            and   indid > 0
            and   indid < 255)
   drop index KHO.TRONG_KHO_FK
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
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'CUA5_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.CUA5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEUNHAP')
            and   name  = 'LAP_PN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUNHAP.LAP_PN_FK
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
            and   name  = 'LAP_PX_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEUXUAT.LAP_PX_FK
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
            from  sysobjects
           where  id = object_id('TONKHO')
            and   type = 'U')
   drop table TONKHO
go

/*==============================================================*/
/* Table: CTHDCTY                                               */
/*==============================================================*/
create table CTHDCTY (
   MAHANG               char(7)              not null,
   SOHDCTY              char(7)              not null,
   SOLUONG              int                  null,
   DONGIA               money                null,
   constraint PK_CTHDCTY primary key (MAHANG, SOHDCTY)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on CTHDCTY (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on CTHDCTY (
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
   DONGIA               money                null,
   constraint PK_CTHDLE primary key (MAHANG, SOHDLE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on CTHDLE (
MAHANG ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on CTHDLE (
SOHDLE ASC
)
go

/*==============================================================*/
/* Table: CTPHIEUNHAP                                           */
/*==============================================================*/
create table CTPHIEUNHAP (
   MAPHIEU              char(7)              not null,
   MAHANG               char(7)              not null,
   TENHANG              char(30)             null,
   LOAI1                char(7)              null,
   SOLUONG1             int                  null,
   GIANHAP              money                null,
   constraint PK_CTPHIEUNHAP primary key (MAPHIEU, MAHANG)
)
go

/*==============================================================*/
/* Index: C03_FK                                                */
/*==============================================================*/
create index C03_FK on CTPHIEUNHAP (
MAPHIEU ASC
)
go

/*==============================================================*/
/* Index: CHUA_TRONG_FK                                         */
/*==============================================================*/
create index CHUA_TRONG_FK on CTPHIEUNHAP (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: CTPHIEUXUAT                                           */
/*==============================================================*/
create table CTPHIEUXUAT (
   MAPHIEU1             char(7)              not null,
   MAHANG               char(7)              not null,
   SOLUONG1             int                  null,
   GIAXUAT              money                null,
   LOAI2                char(7)              null,
   constraint PK_CTPHIEUXUAT primary key (MAPHIEU1, MAHANG)
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
/* Table: CUNG_CAP                                              */
/*==============================================================*/
create table CUNG_CAP (
   MANCC                char(7)              not null,
   MAHANG               char(7)              not null,
   constraint PK_CUNG_CAP primary key (MANCC, MAHANG)
)
go

/*==============================================================*/
/* Index: CUNG_CAP_FK                                           */
/*==============================================================*/
create index CUNG_CAP_FK on CUNG_CAP (
MANCC ASC
)
go

/*==============================================================*/
/* Index: CUNG_CAP2_FK                                          */
/*==============================================================*/
create index CUNG_CAP2_FK on CUNG_CAP (
MAHANG ASC
)
go

/*==============================================================*/
/* Table: DMHANG                                                */
/*==============================================================*/
create table DMHANG (
   MAHANG               char(7)              not null,
   LOAI                 char(7)              not null,
   TENHANG              char(30)             null,
   GIABAN               money                null,
   DVTINH               char(10)             null,
   constraint PK_DMHANG primary key nonclustered (MAHANG)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on DMHANG (
LOAI ASC
)
go

/*==============================================================*/
/* Table: HANG_KM                                               */
/*==============================================================*/
create table HANG_KM (
   MAHANG               char(7)              not null,
   LOAIKM               int                  not null,
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
   PHUONGTHUCTT         char(30)             null,
   CHIETKHAU            float(2)             null,
   constraint PK_HOADONCTY primary key (SOHDCTY)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on HOADONCTY (
MAKH ASC
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
/* Table: HOADONLE                                              */
/*==============================================================*/
create table HOADONLE (
   SOHDLE               char(7)              not null,
   MANV1                char(7)              not null,
   MAKH                 char(7)              not null,
   NGAYHD               datetime             null,
   constraint PK_HOADONLE primary key (SOHDLE)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on HOADONLE (
MAKH ASC
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
/* Table: KHACHCTY                                              */
/*==============================================================*/
create table KHACHCTY (
   MAKH                 char(7)              not null,
   LOAI_                bit                  null,
   TENCTY               char(30)             null,
   DIACHI               char(30)             null,
   DIENTHOAI            char(12)             null,
   FAX                  char(12)             null,
   MATHUE               char(7)              null,
   SOTK                 char(7)              null,
   constraint PK_KHACHCTY primary key (MAKH)
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MAKH                 char(7)              not null,
   LOAI_                bit                  null,
   constraint PK_KHACHHANG primary key nonclustered (MAKH)
)
go

/*==============================================================*/
/* Table: KHACHTT                                               */
/*==============================================================*/
create table KHACHTT (
   MAKH                 char(7)              not null,
   LOAI_                bit                  null,
   DIACHI               char(30)             null,
   DIENTHOAI            char(12)             null,
   DIEMTL               int                  null,
   constraint PK_KHACHTT primary key (MAKH)
)
go

/*==============================================================*/
/* Table: KHO                                                   */
/*==============================================================*/
create table KHO (
   MAPHIEU1             char(7)              not null,
   MAHANG               char(7)              not null,
   MAPHIEU              char(7)              not null,
   CTP_MAHANG           char(7)              not null,
   MAKHO                char(7)              not null,
   TENKHO               char(30)             null,
   constraint PK_KHO primary key nonclustered (MAPHIEU1, MAHANG, MAPHIEU, CTP_MAHANG, MAKHO)
)
go

/*==============================================================*/
/* Index: TRONG_KHO_FK                                          */
/*==============================================================*/
create index TRONG_KHO_FK on KHO (
MAPHIEU ASC,
CTP_MAHANG ASC
)
go

/*==============================================================*/
/* Index: TRONG_KHO1_FK                                         */
/*==============================================================*/
create index TRONG_KHO1_FK on KHO (
MAPHIEU1 ASC,
MAHANG ASC
)
go

/*==============================================================*/
/* Table: KHUYENMAI                                             */
/*==============================================================*/
create table KHUYENMAI (
   LOAIKM               int                  not null,
   DIENGIAI             char(30)             null,
   constraint PK_KHUYENMAI primary key nonclustered (LOAIKM)
)
go

/*==============================================================*/
/* Table: LOAIHANG                                              */
/*==============================================================*/
create table LOAIHANG (
   LOAI                 char(7)              not null,
   TENLOAI              char(30)             null,
   constraint PK_LOAIHANG primary key nonclustered (LOAI)
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
   TENNCC               char(30)             null,
   DIACHI               char(30)             null,
   DIENTHOAI            char(12)             null,
   FAX                  char(12)             null,
   MATHUE               char(7)              null,
   SOTK                 char(7)              null,
   constraint PK_NHACUNGCAP primary key nonclustered (MANCC)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV1                char(7)              not null,
   TENNV                char(30)             null,
   DIACHI               char(30)             null,
   DIENTHOAI            char(12)             null,
   constraint PK_NHANVIEN primary key nonclustered (MANV1)
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   MAPHIEU              char(7)              not null,
   MANCC                char(7)              not null,
   MANV1                char(7)              not null,
   NGAYNHAP             datetime             null,
   constraint PK_PHIEUNHAP primary key nonclustered (MAPHIEU)
)
go

/*==============================================================*/
/* Index: LAP_PN_FK                                             */
/*==============================================================*/
create index LAP_PN_FK on PHIEUNHAP (
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
/* Table: PHIEUXUAT                                             */
/*==============================================================*/
create table PHIEUXUAT (
   MAPHIEU1             char(7)              not null,
   MANV1                char(7)              not null,
   NGAYXUAT             datetime             null,
   constraint PK_PHIEUXUAT primary key nonclustered (MAPHIEU1)
)
go

/*==============================================================*/
/* Index: LAP_PX_FK                                             */
/*==============================================================*/
create index LAP_PX_FK on PHIEUXUAT (
MANV1 ASC
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
/* Table: TONKHO                                                */
/*==============================================================*/
create table TONKHO (
   MAHANG               char(7)              not null,
   DAUKY                int                  null,
   NHAP                 int                  null,
   XUAT                 int                  null,
   SLTON                int                  null,
   constraint PK_TONKHO primary key (MAHANG)
)
go

alter table CTHDCTY
   add constraint FK_CTHDCTY_RELATIONS_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTHDCTY
   add constraint FK_CTHDCTY_RELATIONS_HOADONCT foreign key (SOHDCTY)
      references HOADONCTY (SOHDCTY)
go

alter table CTHDLE
   add constraint FK_CTHDLE_RELATIONS_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTHDLE
   add constraint FK_CTHDLE_RELATIONS_HOADONLE foreign key (SOHDLE)
      references HOADONLE (SOHDLE)
go

alter table CTPHIEUNHAP
   add constraint FK_CTPHIEUN_C03_PHIEUNHA foreign key (MAPHIEU)
      references PHIEUNHAP (MAPHIEU)
go

alter table CTPHIEUNHAP
   add constraint FK_CTPHIEUN_CHUA_TRON_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUXUAT
   add constraint FK_CTPHIEUX_CHUA_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table CTPHIEUXUAT
   add constraint FK_CTPHIEUX_CO2_PHIEUXUA foreign key (MAPHIEU1)
      references PHIEUXUAT (MAPHIEU1)
go

alter table CUNG_CAP
   add constraint FK_CUNG_CAP_CUNG_CAP_NHACUNGC foreign key (MANCC)
      references NHACUNGCAP (MANCC)
go

alter table CUNG_CAP
   add constraint FK_CUNG_CAP_CUNG_CAP2_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

alter table DMHANG
   add constraint FK_DMHANG_THUOC_LOAIHANG foreign key (LOAI)
      references LOAIHANG (LOAI)
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
   add constraint FK_HOADONCT_RELATIONS_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table HOADONLE
   add constraint FK_HOADONLE_LAPHD2_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table HOADONLE
   add constraint FK_HOADONLE_RELATIONS_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table KHACHCTY
   add constraint FK_KHACHCTY_GOM_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table KHACHTT
   add constraint FK_KHACHTT_GOM2_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table KHO
   add constraint FK_KHO_TRONG_KHO_CTPHIEUN foreign key (MAPHIEU, CTP_MAHANG)
      references CTPHIEUNHAP (MAPHIEU, MAHANG)
go

alter table KHO
   add constraint FK_KHO_TRONG_KHO_CTPHIEUX foreign key (MAPHIEU1, MAHANG)
      references CTPHIEUXUAT (MAPHIEU1, MAHANG)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_CUA5_NHACUNGC foreign key (MANCC)
      references NHACUNGCAP (MANCC)
go

alter table PHIEUNHAP
   add constraint FK_PHIEUNHA_LAP_PN_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table PHIEUXUAT
   add constraint FK_PHIEUXUA_LAP_PX_NHANVIEN foreign key (MANV1)
      references NHANVIEN (MANV1)
go

alter table TAIKHOAN
   add constraint FK_TAIKHOAN_THUOC1_LOAITK foreign key (LOAITK)
      references LOAITK (LOAITK)
go

alter table TONKHO
   add constraint FK_TONKHO_TON_DMHANG foreign key (MAHANG)
      references DMHANG (MAHANG)
go

