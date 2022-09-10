CREATE DATABASE QL_BSach
go
USE QL_BSach
go
drop  DATABASE QL_BSach
GO
----------PHAN QUYEN CHO BANG NHANVIEN-KHACHHANG-QUANLY
--dau tien cac nhom quyen VD: NV,KHACH HANG,QUAN LY
CREATE TABLE TBL_ROLE
(
	ID_ROLE INT NOT NULL,
	TEN_ROLE NVARCHAR(50),
	constraint PK_TBL_ROLE primary key (ID_ROLE),
)
-- neu nhom quyen bang 1 thi user do co quyen la quan ly
INSERT INTO TBL_ROLE
VALUES(1,N'Quan Ly')
INSERT INTO TBL_ROLE
VALUES(2,N'Nhan Vien')
select *from TBL_ROLE
--tao bang voi quyen cu thể
CREATE TABLE PHANQUYEN
(
	ID_PP INT NOT NULL IDENTITY (1,1),
	ID_ROLE INT,
	TEN_ACTION NVARCHAR(50),
	CODE_ACTION NVARCHAR(50),
	constraint PK_PHANQUYEN primary key (ID_PP),
	constraint FK_PHANQUYEN_TBL_ROLE foreign key (ID_ROLE) references TBL_ROLE(ID_ROLE),
)
INSERT INTO PHANQUYEN
VALUES(1,N'Them',N'INSERT')
INSERT INTO PHANQUYEN
VALUES(1,N'Xem',N'SELECT')
INSERT INTO PHANQUYEN
VALUES(1,N'Xoa',N'DELETE')
INSERT INTO PHANQUYEN
VALUES(2,N'Them',N'INSERT')
INSERT INTO PHANQUYEN
VALUES(2,N'Xem',N'SELECT')

select *from PHANQUYEN
---------------DỮ LIỆU CSDL
--=======================Thông tin khách hàng và nhân viên
CREATE TABLE NhanVien
(
	maNV nchar(10) not null,
	taiKhoan char(30),
	matKhau char(30),
	tenNV nvarchar(50),
	ngaySinh date,
	gioiTinh nvarchar(5),
	emailNV nvarchar(100),
	SoDT char(12),
	anhNV nvarchar(100) default N'\img\nv1_1.jpg',
	ID_ROLE INT ,
	constraint PK_NhanVien primary key (MaNV),
	constraint FK_NhanVien_TBL_ROLE foreign key (ID_ROLE) references TBL_ROLE(ID_ROLE),
	unique(taiKhoan,matKhau,emailNV)
)

CREATE TABLE KhachHang
(
	maKH char(10) not null,
	tenKH nvarchar(50),
	sdt char(11),
	email nvarchar(100),
	diaChi nvarchar(100),
	tinhTrang nvarchar(100) default N'Thành viên thường',
	constraint PK_KhachHang primary key (maKH)
)
--==================================Quản lí thông tin sách
CREATE TABLE THONGTINSACH
(
	maSach char(10) not null,
	tenSach nvarchar(100),
	tacGia nvarchar(100),
	nhaXB nvarchar(100),
	namXB int,
	theLoai nvarchar(100),
	giaBan int check(giaBan >= 0),
	anhSach nvarchar(100) default N'\img\nocontentyet.jpg',
	constraint PK_ThongTinSach primary key (maSach)
)

CREATE TABLE SachTonKho
(
	maSach char(10) not null,
	SoLuongTon int,
	constraint PK_SachTonKho primary key (maSach),
	constraint FK_SachTonKho_Sach foreign key (maSach) references ThongTinSach(maSach) on delete cascade
)

CREATE TABLE NhaCungCap
(
	maNCC char(10) not null,
	tenNCC nvarchar(100),
	sdt char(11),
	email nvarchar(100),
	diaChi nvarchar(100),
	constraint PK_NhaCungCap primary key (maNCC)
)

CREATE TABLE HoaDonNhapSach
(
	maDonNhap char(10) not null,
	maNV nchar(10),
	maNCC char(10),
	ngayNhap date,
	soLuong int,
	tongTienHD int,
	constraint PK_DonNhapHang primary key (maDonNhap),
	constraint FK_DonNhapHang_NhanVien foreign key (maNV) references NhanVien(maNV) on delete no action,
	constraint FK_DonNhapHang_NhaCungCap foreign key (maNCC) references NhaCungCap(maNCC) on delete no action,
)

CREATE TABLE CT_HoaDonNhapSach
(
	maDonNhap char(10) not null,
	maSach char(10),
	soLuongNhap int,
	giaNhap int check(giaNhap >= 0),
	thanhtien int,
	constraint PK_CT_DonNhapHang primary key (maDonNhap, maSach),
	constraint FK_CT_DonNhapHang_DonNhapHang foreign key (maDonNhap) references HoaDonNhapSach(maDonNhap) on delete no action,
	constraint FK_CT_DonNhapHang_ThongTinSach foreign key (maSach) references ThongTinSach(maSach) on delete no action, 
)


--=======================Quản lí bán sách
CREATE TABLE DonBanHang
(
	maDonBan char(10) not null,
	maNV nchar(10),
	maKH char(10),
	ngayBan date,
	soLuong int,
	tongTien int check(tongTien >= 0),
	constraint PK_DonBanHang primary key (maDonBan),
	constraint FK_DonBanHang_KhachHang foreign key (maKH) references KhachHang(maKH) on delete no action,
	constraint FK_DonBanHang_NhanVien foreign key (maNV) references NhanVien(maNV) on delete no action,
)

CREATE TABLE CT_DonBanHang
(
	maDonBan char(10) not null,
	maSach char(10) ,
	soLuong int,
	DonGiaBan int check(DonGiaBan >= 0),
	TongTien int check(TongTien >= 0),
	constraint PK_CT_DonBanHang primary key (maDonBan,maSach),
	constraint FK_CT_DonBanHang_Sach foreign key (maSach) references ThongTinSach(maSach),
	constraint FK_CT_DonBanHang_DonBanHang foreign key (maDonBan) references DonBanHang(maDonBan)
)

--NHANVIEN
SET DATEFORMAT DMY
INSERT INTO NhanVien(maNV, taiKhoan, matKhau, tenNV, ngaySinh, gioiTinh, emailNV, SoDT, ID_ROLE,  anhNV)
VALUES 
('NV001', 'TuanDat', '321321', N'Phạm Tuấn Đạt', '16/07/2000', N'Nam', N'tuananh@gmail.com', '0937940673', 1, N'\img\nv1_1.jpg'),
('NV002', 'MyLinh', '111112', N'Trần Mỹ Linh', '01/09/1995', N'Nữ', N'mylinh112@gmail.com', '0908918390', 2, N'\img\nv1_1.jpg'),
('NV003', 'DuyMinh', '101010', N'Phạm Duy Minh', '26/03/1999', N'Nam', N'duyminh@gmail.com', '0912845307',2, N'\img\nv1_1.jpg'),
('NV004', 'HongAnh', '156789', N'Nguyễn Hồng Hoa', '07/08/1998', N'Nữ', N'honganh0101@gmail.com', '0371412546', 2, N'\img\nv1_1.jpg'),
('NV005', 'DucAnh', '000012', N'Nguyễn Đức Anh', '20/10/2001', N'Nam', N'dat16072001@gmail.com', '0920392050', 2, N'\img\nv1_1.jpg')

select * from NhanVien
--KHACHHANG		
insert into KhachHang(maKH, tenKH, diaChi, sdt, email)
values
('KH01', N'Pha Tu Da', N'140 Lê Trọng Tấn, Tây Thạnh', '0987456321', 'phatuda@gmail.com'),
('KH02', N'L Th Tha Bi', N'142 Lê Trọng Tấn, Tây Thạnh', '0326598741', 'lththabi@gmail.com'),
('KH03', N'Pha Tha Bi', N'144 Lê Trọng Tấn, Tây Thạnh', '0235687419', 'tudathabi@gmail.com'),
('KH04', N'Phe tu de', N'140 Lê Trọng Tấn, Tây Thạnh', '0235698741', 'phetude@gmail.com'),
('KH05', N'Nguyễn Bá Cây', N'140 Lê Trọng Tấn, Tây Thạnh', '0956321478', 'bacay123@gmail.com'),
('KH06','Le Hoai Thuong','227 Nguyen Van Cu, Q5, TpHCM','0321654789','hoaithuong@gmail.com'),
('KH07','Nguyen Van Tam','32/3 Tran Binh Trong, Q5, TpHCM','0123654789','vantam@gmail.com'),
('KH08','Phan Thi Thanh','45/2 An Duong Vuong, Q5, TpHCM','0598746213','thithanh@gmail.com'),
('KH09','Le Ha Vinh','873 Le Hong Phong, Q5, TpHCM','0987456321','having@gmail.com'),
('KH10','Ha Duy Lap','34/34B Nguyen Trai, Q1, TpHCM','0789546321','duylap@gmail.com')

--THONG TIN SACH
INSERT INTO ThongTinSach (maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan, anhSach)
VALUES ('S010', N'Sách tự nhiên', N'Pha Tu Da', N'Nhà Xuất Bản Gia đình', 2018, N'Sách nghiên cứu', 25000, N'\img\nocontentyet.jpg'),
	('S011',N'Toán a2', N'Đinh Xuân Ngoc',N'Nhà Xuất Bản Giáo Dục',2018,N'Sách Giáo Khoa', 23000, N'\img\nocontentyet.jpg'),
    ('S012',N'Hạt giống tội lỗi', N'Nguyễn Văn Vỵ',N'Kim Đồng',1999,N'Khoa Học Tự Nhiên', 21000, N'\img\nocontentyet.jpg'),
	('S013',N'Tom and Jerry', N'Trần Văn Tuấn',N'Nhà xuất bản Trẻ',1980,N'Truyện Tranh Thiếu Nhi', 28000, N'\img\nocontentyet.jpg'),
    ('S014',N'Truyện Doremon', N'Hồ Thị Anh',N'Nhà xuất bản Trẻ',1990,N'Truyện Tranh Thiếu Nhi', 27000, N'\img\nocontentyet.jpg'),
    ('S015',N'Tâm lý học ', N'Đoàn Thị Hoa',N'Nhà xuất bản lao động',2001,N'Tâm Lý', 23500, N'\img\nocontentyet.jpg'),
	('S016',N'Ngữ Pháp Tiếng Anh', N'Nguyễn Anh Đào',N'Từ điển Bách KHoa',2008,N'Sách Giáo Khoa', 24500, N'\img\nocontentyet.jpg'),
    ('S017',N'Bắt trẻ đồng xanh', N'Nguyễn Hoàng Nam',N' Khoa học và kỹ thuật',2013,N'Giáo Khoa', 20000, N'\img\nocontentyet.jpg'),
    ('S018',N'Tội ác trừ trị', N'Trần Văn Tuấn',N'Nhà xuất bản Tư pháp',2002,N'Chính Trị-Pháp Luật', 31000, N'\img\nocontentyet.jpg'),
	('S019', N'Hồi Xuân', N'Nguyễn Tiến Huy', N'Nhà xuất bản Trẻ', 2019, N'Sách Tiểu Thuyết', 25000, N'\img\nocontentyet.jpg')	
select *from ThongTinSach
delete from THONGTINSACH where maSach = 'ABC'

--NHA CUNG CAP
GO
insert into NhaCungCap
values
('NCC01', N'Nhà cung cấp Bình Dương', '0123684273', 'binhduong@gmail.com', N'Dĩ An, Thủ Dầu 1, Bình Dương'),
('NCC02',N'Nhà cung cấp TP.HCM', '0654321987', 'tphcm@gmail.com', N'Quận 11, TPHCM'),
('NCC03',N'Nhà cung cấp Bình Định','0232391209', 'binhdinh@gmail.com', N'Hòa Hải, Bình Định'),
('NCC04',N'Nhà cung cấp Hà Nội', '0823481910', 'hanoi@gmail.com', N'Quận 8, Hà Nội'),
('NCC05',N'Nhà cung cấp Ninh Thuận', '0123569874', 'ninhthuan@gmail.com', N'Nguyễn Thái Tông,Ninh Thuận'),
('NCC06',N'Nhà cung cấp Tây Ninh ', '0234731209', 'tayninh@gmail.com', N'11 Võ Thị Sáu,Tây Ninh'),
('NCC07',N'Nhà cung cấp Đồng Nai', '0523641789', 'dongnai@gmail.com', N'1123 Hoàng Hoa Thám ,Đồng Nai')

--HOA DON NHAP SACH
GO
SET DATEFORMAT DMY
INSERT INTO HoaDonNhapSach
VALUES 
('NH10', 'NV001', 'NCC05', '17/10/2020', 150, 69000),
('NH11', 'NV001', 'NCC06', '11/01/2021', 20, 77000),
('NH12', 'NV002', 'NCC05', '26/09/2018', 70, 54000),
('NH13', 'NV001', 'NCC04', '27/08/2019', 122, 102000),
('NH15', 'NV002', 'NCC02', '15/04/2020', 50, 56000),
('NH17', 'NV001', 'NCC05', '13/12/2021', 150,12000),
('NH16', 'NV002', 'NCC07', '01/06/2021', 50, 34000)
GO

INSERT INTO CT_HoaDonNhapSach
VALUES
('NH10', 'S014', 150, 14000, 150*1400),
('NH11', 'S012', 20, 11000, 20*11000),
('NH12', 'S010', 70, 55000, 70*55000),
('NH16', 'S011', 150, 15000, 150*15000),
('NH15', 'S013', 50, 10000, 50*10000),
('NH13', 'S015', 10, 21000, 10*21000),
('NH17', 'S016', 50, 30000, 50*30000),
('NH13', 'S017', 112, 75000, 112*75000)
GO
INSERT INTO SachTonKho
VALUES
	('S010',100),
	('S011',150),
	('S012',120),
	('S013',90),
	('S014',99),
	('S015',58),
	('S016',72),
	('S017',56)
GO

select *from THONGTINSACH
select *from SachTonKho
select *from HoaDonNhapSach
select *from CT_HoaDonNhapSach
select *from HoaDonNhapSach

SET DATEFORMAT DMY
INSERT INTO DonBanHang  VALUES('HD001','NV001','KH01','01/04/2021',2,200000)
INSERT INTO DonBanHang  VALUES('HD002','NV003','KH05','14/04/2021',5,1920000)
INSERT INTO DonBanHang  VALUES('HD003','NV002','KH01','15/05/2021',1,400000)
INSERT INTO DonBanHang  VALUES('HD004','NV001','KH07','03/06/2021',2,1000000)
INSERT INTO DonBanHang  VALUES('HD005','NV005','KH09','08/06/2021',3,600000)
INSERT INTO DonBanHang  VALUES('HD006','NV001','KH03','13/09/2021',5,2400000)
INSERT INTO DonBanHang  VALUES('HD007','NV004','KH08','14/06/2021',7,2100000)
INSERT INTO DonBanHang  VALUES('HD008','NV002','KH03','26/09/2021',2,200000)
INSERT INTO DonBanHang  VALUES('HD009','NV003','KH07','14/03/2021',3,1680000)

GO
INSERT INTO CT_DonBanHang VALUES('HD001','S015',2,100000,2*100000)
INSERT INTO CT_DonBanHang VALUES('HD002','S011',1,200000,1*200000)
INSERT INTO CT_DonBanHang VALUES('HD002','S012',2,300000,2*300000)
INSERT INTO CT_DonBanHang VALUES('HD002','S013',2,560000,2*560000)
INSERT INTO CT_DonBanHang VALUES('HD003','S019',1,400000,1*400000)
INSERT INTO CT_DonBanHang VALUES('HD004','S018',2,500000,2*500000)
INSERT INTO CT_DonBanHang VALUES('HD005','S014',3,200000,3*200000)
INSERT INTO CT_DonBanHang VALUES('HD006','S016',4,500000,4*500000)
INSERT INTO CT_DonBanHang VALUES('HD006','S012',1,400000,1*400000)
INSERT INTO CT_DonBanHang VALUES('HD007','S017',2,300000,2*300000)
INSERT INTO CT_DonBanHang VALUES('HD007','S015',5,300000,5*300000)
INSERT INTO CT_DonBanHang VALUES('HD008','S017',2,100000,2*100000)
INSERT INTO CT_DonBanHang VALUES('HD009','S019',3,560000,3*560000)		
GO
select *from DonBanHang 
select CT_DonBanHang.maDonBan, tenSach, soLuong, DonGiaBan, TongTien from CT_DonBanHang, THONGTINSACH where CT_DonBanHang.maSach = THONGTINSACH.maSach
select maDonNhap, tenSach, soLuongNhap, giaNhap, thanhtien from CT_HoaDonNhapSach, THONGTINSACH where CT_HoaDonNhapSach.maSach = THONGTINSACH.maSach
select *from SachTonKho
select *from KhachHang
delete from KhachHang where maKH = 'KH460'
select THONGTINSACH.maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan, SoLuongTon, anhSach
                            from THONGTINSACH, SachTonKho
                            where THONGTINSACH.maSach = SachTonKho.maSach
select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien 
                from DonBanHang db, NhanVien nv, KhachHang kh where db.maNV = nv.maNV and db.maKH = kh.maKH
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------SẮP XẾP ĐƠN BÁN HÀNG THEO SỐ LƯỢNG
go 
create proc sap_xep_don_ban_hang_sl
as
begin
	select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien  
	from DonBanHang db, NhanVien nv, KhachHang kh 
	where db.maNV = nv.maNV and db.maKH = kh.maKH order by 5 DESC
end
exec sap_xep_don_ban_hang_sl	

-------SẮP XẾP ĐƠN BÁN HÀNG THEO TỔNG TIỀN
go 
create proc sap_xep_don_ban_hang_tong_tien
as
begin
	select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien  
	from DonBanHang db, NhanVien nv, KhachHang kh 
	where db.maNV = nv.maNV and db.maKH = kh.maKH order by 6 DESC
end
exec sap_xep_don_ban_hang_tong_tien

-------TÌM KIẾM ĐƠN BÁN THEO NGÀY
go
create proc tim_kiem_don_ban_ngay @ngay date
as
	begin
		set dateformat DMY
		select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien  
		from DonBanHang db, NhanVien nv, KhachHang kh 
		where db.maNV = nv.maNV and db.maKH = kh.maKH and db.ngayBan = @ngay
	end
go
exec tim_kiem_don_ban_ngay '12-11-2021'

-------TÌM KIẾM ĐƠN BÁN THEO MÃ NHÂN VIÊN & MÃ KHÁCH HÀNG
go
create proc tim_kiem_don_ban_manv_kh
as
	begin
		select maDonBan, nv.tenNV, kh.tenKH, ngayBan, soLuong, tongTien , db.maNV, db.maKH, SoDT, sdt
		from DonBanHang db, NhanVien nv, KhachHang kh 
		where db.maNV = nv.maNV and db.maKH = kh.maKH 
	end
go
exec tim_kiem_don_ban_manv_kh
 
-------SẮP XẾP ĐƠN NHẬP HÀNG THEO SỐ LƯỢNG
go 
create proc sap_xep_don_nhap_hang_sl
as
begin
	select maDonNhap, tenNV, tenNCC, ngayNhap, soLuong, tongTienHD 
	from HoaDonNhapSach, NhanVien, NhaCungCap 
	where HoaDonNhapSach.maNV = NhanVien.maNV and HoaDonNhapSach.maNCC = NhaCungCap.maNCC
	order by 5 DESC
end
exec sap_xep_don_nhap_hang_sl


-------SẮP XẾP ĐƠN NHẬP HÀNG THEO TỔNG TIỀN
go 
create proc sap_xep_don_nhap_hang_tong_tien
as
begin
	select maDonNhap, tenNV, tenNCC, ngayNhap, soLuong, tongTienHD 
	from HoaDonNhapSach, NhanVien, NhaCungCap 
	where HoaDonNhapSach.maNV = NhanVien.maNV and HoaDonNhapSach.maNCC = NhaCungCap.maNCC
	order by 6 DESC
end
exec sap_xep_don_nhap_hang_tong_tien

-------TÌM KIẾM ĐƠN NHẬP THEO NGÀY
go
create proc tim_kiem_don_nhap_ngay @ngay date
as
	begin
		select maDonNhap, tenNV, tenNCC, ngayNhap, soLuong, tongTienHD 
		from HoaDonNhapSach, NhanVien, NhaCungCap 
		where HoaDonNhapSach.maNV = NhanVien.maNV and HoaDonNhapSach.maNCC = NhaCungCap.maNCC and ngayNhap = @ngay
	end
go
set dateformat DMY exec tim_kiem_don_nhap_ngay '17-10-2020'

-------TÌM KIẾM ĐƠN NHẬP THEO MÃ NHÂN VIÊN & MÃ NCC
go
create proc tim_kiem_don_nhap_manv_ncc
as
	begin
		select maDonNhap, tenNV, tenNCC, ngayNhap, soLuong, tongTienHD, HoaDonNhapSach.maNV, HoaDonNhapSach.maNCC, SoDT, sdt 
		from HoaDonNhapSach, NhanVien, NhaCungCap 
		where HoaDonNhapSach.maNV = NhanVien.maNV and HoaDonNhapSach.maNCC = NhaCungCap.maNCC
	end
go
exec tim_kiem_don_nhap_manv_ncc

-------TÌM SÁCH THEO TÊN SÁCH - TÁC GIẢ - NHÀ XUẤT BẢN - NĂM XUẤT BẢN - THỂ LOẠI -
go 
create proc tim_kiem_sach @dieukien nvarchar(100)
as
begin
	select maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan from THONGTINSACH
	where (tenSach LIKE '%' + @dieukien + '%' or tacGia LIKE '%' + @dieukien + '%' or nhaXB LIKE '%' + @dieukien + '%'
	or theLoai LIKE '%' + @dieukien + '%')
end
exec tim_kiem_sach N'trị'

-------TÌM KIẾM SÁCH THEO NĂM XUẤT BẢN
go 
create proc tim_kiem_sach_theo_namxb @dieukien int
as
begin
	select maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan from THONGTINSACH
	where namXB = @dieukien
end
exec tim_kiem_sach_theo_namxb 2018

-------TÌM SÁCH THEO TÊN SÁCH - TÁC GIẢ - NHÀ XUẤT BẢN - NĂM XUẤT BẢN - THỂ LOẠI - GIÁ BÁN
go 
create proc tim_kiem_sach_giaban @dieukien nvarchar(100), @giabanmin int, @giabanmax int
as
begin
	select maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan from THONGTINSACH
	where (tenSach LIKE '%' + @dieukien + '%' or tacGia LIKE '%' + @dieukien + '%' or nhaXB LIKE '%' + @dieukien + '%'
	or theLoai LIKE '%' + @dieukien + '%') and (giaBan BETWEEN @giabanmin and @giabanmax )
end
exec tim_kiem_sach_giaban N'Sách', 20000, 100000

-------TÌM SÁCH THEO NĂM XUẤT BẢN - GIÁ BÁN
go 
create proc tim_kiem_sach_namxb_giaban @dieukien int, @giabanmin int, @giabanmax int
as
begin
	select maSach, tenSach, tacGia, nhaXB, namXB, theLoai, giaBan from THONGTINSACH
	where namXB = @dieukien and (giaBan BETWEEN @giabanmin and @giabanmax )
end
exec tim_kiem_sach_namxb_giaban 2018, 20000, 100000


-------BÁO CÁO THEO NGÀY
go
create proc show_DB @ngay DateTime
as
	begin
		set dateformat DMY
		select s.tenSach, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.giaBan) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.giaBan) - AVG(ctn.giaNhap)) as doanhThu
		from THONGTINSACH s, CT_HoaDonNhapSach ctn, CT_DonBanHang ctb, DonBanHang dbh, HoaDonNhapSach dnh, NhaCungCap ncc
		where s.maSach = ctn.maSach and dnh.maDonNhap = ctn.maDonNhap and dnh.maNCC = ncc.maNCC
		and s.maSach = ctb.maSach and ctb.maDonBan = dbh.maDonBan and dbh.ngayBan = @ngay
		group by s.tenSach, ncc.tenNCC
	end
go
set dateformat DMY
exec show_DB '14/06/2021 12:00:00 AM'

------BÁO CÁO THEO THÁNG
go
create proc show_DB_Thang @thang int
as
	begin
		set dateformat DMY
		select s.tenSach, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.giaBan) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.giaBan) - AVG(ctn.giaNhap)) as doanhThu
		from THONGTINSACH s, CT_HoaDonNhapSach ctn, CT_DonBanHang ctb, DonBanHang dbh, HoaDonNhapSach dnh, NhaCungCap ncc
		where s.maSach = ctn.maSach and dnh.maDonNhap = ctn.maDonNhap and dnh.maNCC = ncc.maNCC
		and s.maSach = ctb.maSach and ctb.maDonBan = dbh.maDonBan and MONTH(dbh.ngayBan) = @thang
		group by s.tenSach, ncc.tenNCC
	end
go
exec show_DB_Thang 4

------BÁO CÁO THEO QUÝ 1
go
create proc show_DB_Quy_1
as
	begin
		set dateformat DMY
		select s.tenSach, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.giaBan) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.giaBan) - AVG(ctn.giaNhap)) as doanhThu
		from THONGTINSACH s, CT_HoaDonNhapSach ctn, CT_DonBanHang ctb, DonBanHang dbh, HoaDonNhapSach dnh, NhaCungCap ncc
		where s.maSach = ctn.maSach and dnh.maDonNhap = ctn.maDonNhap and dnh.maNCC = ncc.maNCC
		and s.maSach = ctb.maSach and ctb.maDonBan = dbh.maDonBan and (MONTH(dbh.ngayBan) between 1 and 6)
		group by s.tenSach, ncc.tenNCC
	end
go
exec show_DB_Quy_1

------BÁO CÁO THEO QUÝ 2
go
create proc show_DB_Quy_2
as
	begin
		set dateformat DMY
		select s.tenSach, ncc.tenNCC, SUM(ctb.soLuong) as tongSLBan, AVG(s.giaBan) as trungBinhGiaBan,
					 AVG(ctn.giaNhap) trungBinhGiaNhap, (AVG(s.giaBan) - AVG(ctn.giaNhap)) as doanhThu
		from THONGTINSACH s, CT_HoaDonNhapSach ctn, CT_DonBanHang ctb, DonBanHang dbh, HoaDonNhapSach dnh, NhaCungCap ncc
		where s.maSach = ctn.maSach and dnh.maDonNhap = ctn.maDonNhap and dnh.maNCC = ncc.maNCC
		and s.maSach = ctb.maSach and ctb.maDonBan = dbh.maDonBan and (MONTH(dbh.ngayBan) between 7 and 12)
		group by s.tenSach, ncc.tenNCC
	end
go
exec show_DB_Quy_2
--IN HÓA ĐƠN BÁN HÀNG
go
create proc show_thanhtoan @mahoadon char(20)
as
	begin
		select CT_DonBanHang.maDonBan,tenKH,TenNV,ngayBan,TenSach,CT_DonBanHang.soLuong,CT_DonBanHang.DonGiaBan,CT_DonBanHang.TongTien, DonBanHang.tongTien
		from CT_DonBanHang,DonBanHang,KhachHang,NhanVien,ThongTinSach
		WHERE CT_DonBanHang.maDonBan=DonBanHang.maDonBan AND DonBanHang.maKH=KhachHang.maKH AND DonBanHang.maNV=NhanVien.maNV AND CT_DonBanHang.maSach=ThongTinSach.maSach
		  AND CT_DonBanHang.maDonBan=@mahoadon
	end
go
exec show_thanhtoan 'HD007'



--IN HÓA ĐƠN NHẬP HÀNG
go
create proc show_hoadonnhaphang @mahoadon char(20)
as
	begin
		select CT_HoaDonNhapSach.maDonNhap,HoaDonNhapSach.maNV,tenNV,tenNCC,ngayNhap,tenSach,CT_HoaDonNhapSach.soLuongNhap,CT_HoaDonNhapSach.giaNhap,CT_HoaDonNhapSach.thanhtien
		from CT_HoaDonNhapSach,HoaDonNhapSach,NhanVien,ThongTinSach,NhaCungCap
		WHERE CT_HoaDonNhapSach.maDonNhap=HoaDonNhapSach.maDonNhap AND HoaDonNhapSach.maNV=NhanVien.maNV AND HoaDonNhapSach.maNCC=NhaCungCap.maNCC
		 AND CT_HoaDonNhapSach.maSach=ThongTinSach.maSach
		  AND CT_HoaDonNhapSach.maDonNhap=@mahoadon
	end
go
exec show_hoadonnhaphang 'NH15'
select * from CT_HoaDonNhapSach
select * from NhanVien
update NhanVien set anhNV = N'\img\nv5.jpg' where maNV = 'NV446'



delete from CT_HoaDonNhapSach
delete from HoaDonNhapSach
delete from CT_DonBanHang
delete from DonBanHang
delete from SachTonKho
delete from THONGTINSACH
delete from NhanVien

drop table CT_DonBanhang
drop table DonBanHang
drop table CT_HoaDonNhapSach
drop table HoaDonNhapSach
drop table SachTonKho
drop table THONGTINSACH
drop table NhanVien


