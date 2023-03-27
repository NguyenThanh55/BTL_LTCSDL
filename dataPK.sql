create database QLPM
go

use QLPM
go

--drop table BacSi
--drop database QLPM


-- Set date format to day/month/year.
set dateformat dmy;
go

create table Account(
id int identity primary key,
Username nvarchar(50) not null,
Password nvarchar(50) not null,
Type int not null,
)

create table BacSi(
id int identity primary key,
Ten nvarchar(50) not null,
NgaySinh date not null,
QueQuan varchar(200) not null,
idAccount int not null foreign key (idAccount) references Account(id)
)

create table PhieuKham(
id int identity primary key,
NgayKham date not null,
TrieuChung varchar(500) not null,
ChuanDoanBenh varchar(500) not null,
idBS int not null foreign key (idBS) references BacSi(id),
)

create table BenhNhan(
id int identity primary key,
Ten nvarchar(50) not null,
GioiTinh bit not null,
NgaySinh date not null,
DiaChi varchar(200) not null
)

create table HoaDon(
id int identity primary key,
NgayKham date not null,
TienKham int not null,
TienDV int not null,
TienThuoc int,
TongTien int,
idBN int not null foreign key (idBN) references BenhNhan(id),
idPK int not null foreign key (idPK) references PhieuKham(id),

)

create table ToaThuoc(
id int identity primary key,
NgayLap date not null,
idHD int not null foreign key (idHD) references HoaDon(id) 
)

create table Thuoc(
id int identity primary key,
Ten nvarchar(100) not null,
DonVi nvarchar(50) not null,
CongDung nvarchar(50)not null,
SoLuong int not null,
NhaSX nvarchar(50)
)

create table ChiTietTT(
id int identity primary key,
LieuLuong int not null,
CachDung nvarchar(max) not null,
idTT int not null foreign key (idTT) references ToaThuoc(id),
idThuoc int not null foreign key (idThuoc) references Thuoc(id),

)

create table PhieuDV(
id int identity primary key,
NgayKhamDV date not null,
idHD int not null foreign key (idHD) references HoaDon(id) 
)

create table DichVu(
id int identity primary key,
tenDV nvarchar(100) not null,
giaDV int not null,
)

create table CTDV(
id int identity primary key,
idPDV int not null foreign key (idPDV) references PhieuDV(id),
idDV int not null foreign key (idDV) references DichVu(id) 
)
go

insert into BacSi(Ten,	NgaySinh, QueQuan)
values ('Nguyen Thi Thanh','12/12/2002','TP.HCM')
insert into BacSi(Ten,	NgaySinh, QueQuan)
values ('Nguyen Thi Ngoc Yen','22/12/2002','Tay Ninh')
insert into BacSi(Ten,	NgaySinh, QueQuan)
values ('Nguyen Hong Son','18/12/2002','Long An')
insert into BacSi(Ten,	NgaySinh, QueQuan)
values ('Phan Thi Yen Vi','20/12/2002','Gia Lai')

insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('1/1/2023','Dau dau, buon non, sot','Benh Phoi', 3)
insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('21/2/2023','Dau bung, nhuc dau','Benh Tieu Hoa', 4)
insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('12/3/2023','Ngua mat, mat do, mat xung','Benh Mat', 2)
insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('14/1/2023','Dau dau, buon non, dau tim, mau tang','Benh Tim', 1)
insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('1/3/2023','Dau dau, dau duong ruot','Benh Tieu Hoa', 4)
insert into PhieuKham(NgayKham, TrieuChung, ChuanDoanBenh, idBS)
values ('1/2/2023','Dau dau, kho mat, mat mo','Benh Mat', 2)

insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Thai Tan Phat',1, '23/4/2002', 'An Giang')
insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Huynh Minh Hoang',1, '23/7/2002', 'Gia Lai')
insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Nguyen Toan My',0, '12/4/2002', 'Tien Giang')
insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Nguyen Van Phuoc',1, '1/8/2002', 'An Giang')
insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Nguyen Thanh Thuyen',1, '2/12/2002', 'Soc Trang')
insert into BenhNhan(Ten, GioiTinh, NgaySinh, DiaChi)
values ('Le Anh Hoa',0, '7/5/2002', 'Nha Trang')

insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('1/1/2002', 100 , 50,1, 3) 
insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('21/2/2002', 100 , 50,2, 4) 
insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('12/3/2002', 100 , 50,6, 2) 
insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('14/1/2002', 100 , 50,3, 1) 
insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('1/3/2002', 100 , 50,5, 4) 
insert into HoaDon(NgayKham, TienKham,	TienDV, idBN,idPK)
values ('1/2/2002', 100 , 50,4, 3) 

insert into ToaThuoc(NgayLap, idHD)
values ('1/1/2002', 1)
insert into ToaThuoc(NgayLap, idHD)
values ('21/2/2002',2)
insert into ToaThuoc(NgayLap, idHD)
values ('12/3/2002',3)
insert into ToaThuoc(NgayLap, idHD)
values ('14/1/2002',4)
insert into ToaThuoc(NgayLap, idHD)
values ('1/3/2002',5)
insert into ToaThuoc(NgayLap, idHD)
values ('1/2/2002',6)

insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Vitamin D','chai','Tri benh mat',1,'Tan Binh')
insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Ticagrelor','vy','Tri Tieu Hoa',2,'Quan 12')
insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Folic Acid','vien','Tri Tim',10,'Quan Go Vap')
insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Memantine','chai','Tri benh Phoi',1,'Quan 1')
insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Levothyroxine','vy','Tri mat',3,'Quan 7')
insert into Thuoc(Ten, DonVi, CongDung, SoLuong, NhaSX)
values ('Zolpidem','vien','Tri Tim',5,'Quan 6')


insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (2, 'Uong sau khi an', 1, 3)
insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (1, 'Uong sau khi an', 5, 1)
insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (3, 'Uong sau khi an', 3, 2)
insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (1, 'Uong sau khi an', 2, 4)
insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (3, 'Uong sau khi an', 4, 5)
insert into ChiTietTT(LieuLuong, CachDung, idTT, idThuoc)
values (1, 'Uong sau khi an', 6, 6)


insert into PhieuDV(NgayKhamDV, idHD)
values ('1/1/2002', 1)
insert into PhieuDV(NgayKhamDV, idHD)
values ('14/1/2002', 1)
insert into PhieuDV(NgayKhamDV, idHD)
values ('12/2/2002', 1)
insert into PhieuDV(NgayKhamDV, idHD)
values ('1/2/2002', 1)


insert into DichVu(tenDV, giaDV)
values ('Do Duong', 150)
insert into DichVu(tenDV, giaDV)
values ('Do mau', 250)
insert into DichVu(tenDV, giaDV)
values ('Sieu am', 500)
insert into DichVu(tenDV, giaDV)
values ('Xet nghiem mau', 400)

insert into CTDV(idPDV,idDV)
values (2,3)
insert into CTDV(idPDV,idDV)
values (3,3)
insert into CTDV(idPDV,idDV)
values (1,2)
insert into CTDV(idPDV,idDV)
values (1,4)
insert into CTDV(idPDV,idDV)
values (2,1)


go 
create proc USP_GetAccount
@username nvarchar(100),
@password nvarchar(100)
as
begin
	select * from Account where UserName=@username and Password=@password
end
go 

exe





























 