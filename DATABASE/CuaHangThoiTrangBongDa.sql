
CREATE DATABASE CuaHangDaBanhDB
GO
USE CuaHangDaBanhDB
GO
/*===================================================== Phân quyền linh động ============================================*/

-- Tạo bảng tài khoản
CREATE TABLE TaiKhoan
(
	MaTaiKhoan INT,
	MaNhomQuyen INT,
	TenTaiKhoan NVARCHAR(250),
	MatKhau NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng nhóm quyền
CREATE TABLE NhomQuyen
(
	MaNhomQuyen INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhomQuyen NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng chức năng
CREATE TABLE ChucNang
(
	MaChucNang INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenChucNang NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng chi tiết quyền hình thành từ quan hệ nhiều - nhiều giữa Chức năng và Nhóm quyền
CREATE TABLE ChiTietQuyen
(
	MaChiTietQuyen INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhomQuyen INT,
	MaChucNang INT,
	HanhDong NVARCHAR(250)
)
GO
--Bảng tài khoản thêm khóa ngoại tham chiếu tới khóa chính bảng Nhóm Quyền
ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_MaNhomQuyen 
FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)

GO
-- Bảng chi tiết quyền thêm khóa ngoại tham chiếu tới khóa chính bảng chức năng
ALTER TABLE ChiTietQuyen
ADD CONSTRAINT FK_ChiTietQuyen_MaChucNang
FOREIGN KEY (MaChucNang) REFERENCES ChucNang(MaChucNang)

GO
-- bảng chi tiết quyền thêm khóa ngoại tham chiếu tới khóa chính bảng nhóm quyền
ALTER TABLE ChiTietQuyen
ADD CONSTRAINT FK_ChiTietQuyen_MaNhomQuyen
FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)

insert into NhomQuyen 
values 
(N'Admin', 1),
(N'Quản Lý', 1),
(N'Thu Ngân', 1),
(N'Thủ Kho', 1)



insert into ChucNang 
values 
(N'Sản Phẩm', 1), 
(N'Thuộc Tính', 1), 
(N'Bán Hàng', 1),
(N'Nhà Cung Cấp', 1),
(N'Phiếu Nhập', 1),
(N'Nhân Viên', 1), 
(N'Tài Khoản', 1),
(N'Khách Hàng', 1), 
(N'Hóa Đơn', 1), 
(N'Phân Quyền', 1), 
(N'Thống Kê', 1)


/*
phân quyền cho admin
*/
insert into ChiTietQuyen values (1,6,N'Xem'),(1,6,N'Sửa'),(1,6,N'Xóa'),(1,6,N'Thêm')
insert into ChiTietQuyen values (1,7,N'Xem'),(1,7,N'Sửa'),(1,7,N'Xóa'),(1,7,N'Thêm')
insert into ChiTietQuyen values (1,10,N'Xem'),(1,10,N'Sửa'),(1,10,N'Xóa'),(1,10,N'Thêm')

/*



select * from chitietquyen
select * from nhomquyen
update nhomquyen set trangthai = 1 where manhomquyen = 7
update ChucNang SET tenchucnang = N'Tài Khoản' where machucnang = 7






*/

/* ===================================================================================================================================================================================================*/

GO


/*=======================================NHÂN VIÊN================================================================*/
-- Tạo bảng nhân viên
CREATE TABLE NhanVien
(
	MaNhanVien INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhanVien NVARCHAR(50),
	Tuoi INT,
	SoDienThoai VARCHAR(10),
	HinhAnh IMAGE,
	TrangThai INT,
)

GO

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_MaNhanVien 
FOREIGN KEY (MaTaiKhoan) REFERENCES NhanVien(MaNhanVien)


--tài khoản gốc, phải có khi chạy chương trình
insert into NhanVien values(N'Admin',20,'0907146115','',1)
insert into TaiKhoan values(1, 1, N'Admin', '1234',1)

/*===============================================================================================================*/
GO


/* ============================================ Thuộc tính sản phẩm ============================================*/


-- tạo bảng thể loại sản phẩm
CREATE TABLE TheLoai
(
	MaTheLoai INT IDENTITY PRIMARY KEY NOT NULL,
	TenTheLoai NVARCHAR(250),
	TrangThai INT
)

GO

/*
-- Chèn bản ghi "Bóng đá"
INSERT INTO TheLoai (TenTheLoai, TrangThai)
VALUES	(N'Bóng đá', 1),
		(N'Áo bóng đá', 1),
		(N'Quần bóng đá', 1),
		(N'Giày bóng đá', 1),
		(N'Phụ kiện bóng đá', 1),
		(N'Đồ tập gym', 1),
		(N'Đồng phục đội bóng đá', 1),
		(N'Đồ lưu niệm bóng đá', 1);

GO
*/


-- tạo bảng kích cở
CREATE TABLE KichCo
(
	MaKichCo INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenKichCo NVARCHAR(250),
	TrangThai INT
)


GO
/*

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES 
	('XS', 1),
	('S', 1),
	('M', 1),
	('L', 1),
	('XL', 1);

*/
GO
-- tạo bảng màu sắc
CREATE TABLE MauSac
(
	MaMauSac INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenMauSac NVARCHAR(250),
	TrangThai INT
)

/*
INSERT INTO MauSac (TenMauSac, TrangThai) VALUES (N'Đỏ', 1),
(N'Xanh', 1),
(N'Vàng', 1),
(N'Trắng', 1);
*/


GO

/*===================================================== Sản phẩm ============================================================*/

CREATE TABLE NhaCungCap
(
	MaNhaCungCap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhaCungCap NVARCHAR(250),
	DiaChi NVARCHAR(250),
	SoDienThoai NVARCHAR(50),
	TrangThai INT
)
GO

INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SoDienThoai, TrangThai)
VALUES
	(N'Công Ty TNHH MAY CTS', N'126 Hồ Quý Ly, Phường Hòa Minh, Quận Liên Chiểu, Tp. Đà Nẵng, Việt Nam', '0901234567', 1),
	(N'Công Ty May Mặc Diệu Khang', '453/70/13/28 Lê Văn Khương, P. Hiệp Thành, Q. 12, Tp. Hồ Chí Minh, Việt Nam', '0912345678', 1),
	(N'Công Ty CP Thể Thao Koji', 'Thôn Tri Thủy, X. Tri Thủy, H. Phú Xuyên, Hà Nội, Việt Nam', '0934567890', 1),
	(N'Công Ty TNHH Thương Mại Sản Xuất Meta', 'Đường Thuận Giao 6, KP. Bình Thuận 1, P. Thuận Giao, TP. Thuận An, Bình Dương,', '0945678901', 1);
GO



-- tạo bảng sản phẩm
CREATE TABLE SanPham
(
	MaSanPham INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaTheLoai INT NOT NULL,
	MaNhaCungCap INT NOT NULL,
	TenSanPham NVARCHAR(250),
	GiaBan FLOAT,
	GiaNhap FLOAT,
	SoLuongTon INT,
	TrangThai INT,
)

/*
select * from sanpham
update SanPham set trangthai = 1 where masanpham = 4
*/

select * from sanpham
GO

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_MaTheLoai
FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_MaNhaCungCap
FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)



/*============================================================================================================================*/

GO

/*========================================= CHI TIẾT SẢN PHẨM =============================================================== */

CREATE TABLE ChiTietSanPham
(
	MaChiTietSanPham INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaSanPham INT NOT NULL,
	MaMauSac INT NOT NULL,
	MaKichCo INT NOT NULL,
	HinhAnh IMAGE,
	SoLuongTon INT,
	TrangThai INT
)

GO

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaSanPham
FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

GO

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaMauSac
FOREIGN KEY (MaMauSac) REFERENCES MauSac(MaMauSac)

GO 

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaKichCo
FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo)


/* ============================================================================================================== */





/*=============================================== PHIẾU NHẬP =====================================================*/




CREATE TABLE PhieuNhap
(
	MaPhieuNhap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhaCungCap INT NOT NULL,
	MaNhanVien INT NOT NULL,
	NgayNhap DATETIME,
	TongTien FLOAT,
	TrangThai INT
)

GO
CREATE TABLE ChiTietPhieuNhap
(
	MaChiTietPhieuNhap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaPhieuNhap INT NOT NULL,
	MaChiTietSanPham INT NOT NULL,
	SoLuong INT,
	DonVi NVARCHAR(250),
	GiaNhap FLOAT,
	ThanhTien FLOAT
)
GO
ALTER TABLE PhieuNhap
ADD CONSTRAINT FK_PhieuNhap_MaNhaCungCap
FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
GO
ALTER TABLE PhieuNhap
ADD CONSTRAINT FK_PhieuNhap_MaNhanVien
FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO
ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT FK_ChiTietPhieuNhap_MaPhieuNhap
FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap)
GO
ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT FK_ChiTietPhieuNhap_MaChiTietSanPham
FOREIGN KEY (MaChiTietSanPham) REFERENCES ChiTietSanPham(MaChiTietSanPham)

/*
select * from chitietphieunhap where maphieunhap = 1
*/
/*=================================================================================================================*/
GO

/*=========================================== KHÁCH HÀNG ==========================================================*/

CREATE TABLE KhachHang
(
	MaKhachHang INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenKhachHang NVARCHAR(250),
	SoDienThoai NVARCHAR(250),
	TrangThai INT
)



/*================================================================================================================*/


GO 


/*========================================== HÓA ĐƠN ==============================================================*/



CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaKhachHang INT,
	MaNhanVien INT,
	NgayLap DATETIME,
	TongTien FLOAT,
	TrangThai INT
)
/*
select * from hoadon



SELECT NgayLap, SUM(TongTien) AS DoanhThu
FROM HoaDon
WHERE NgayLap >= '2024-02-14' AND NgayLap <= '2024-02-15 23:59:59'
GROUP BY NgayLap;

*/
GO

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_MaKhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)

GO

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_MaNhanVien
FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

GO



CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaHoaDon INT,
	MaChiTietSanPham INT,
	GiaSanPham FLOAT,
	SoLuong INT,
	ThanhTien FLOAT
)

GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_MaChiTietSanPham
FOREIGN KEY (MaChiTietSanPham) REFERENCES ChiTietSanPham(MaChiTietSanPham)

GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_MaHoaDon
FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)

/*
select * from phieunhap
select * from phieunhap where NgayNhap = '2024-02-17'
SELECT * FROM phieunhap WHERE NgayNhap >= CONVERT(date, GETDATE()) AND NgayNhap < DATEADD(day, 1, CONVERT(date, GETDATE()))

SELECT * FROM phieunhap 
WHERE NgayNhap >= DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0) 
AND NgayNhap < DATEADD(month, DATEDIFF(month, 0, GETDATE()) + 1, 0)


select * from hoadon
select * from hoadon where makhachhang = 2
*/



/*
USE CuaHangDaBanhDB 
DROP DATABASE CuaHangDaBanhDB
*/

/*
select * from HoaDon
select * from PhieuNhap

select * from HoaDon where NgayLap between '2024-02-13' and '2024-02-16' and MaNhanVien = 2
select * from PhieuNhap 
SELECT * FROM HoaDon WHERE (NgayLap >= '2024-02-14' AND NgayLap <= '2024-02-15 23:59:59')


SELECT Ngay, SUM(DoanhThu) AS TongDoanhThu, SUM(ChiPhi) AS TongChiPhi, SUM(DoanhThu - ChiPhi) AS LoiNhuan
FROM (
    SELECT NgayLap AS Ngay, TongTien AS DoanhThu, 0 AS ChiPhi
    FROM HoaDon
    WHERE NgayLap >= '2024-02-14' AND NgayLap <= '2024-02-15 23:59:59'
    
    UNION ALL
    
    SELECT NgayNhap AS Ngay, 0 AS DoanhThu, TongTien AS ChiPhi
    FROM PhieuNhap
    WHERE NgayNhap >= '2024-02-14' AND NgayNhap <= '2024-02-15 23:59:59'
) AS T
GROUP BY Ngay;



SELECT CAST(Ngay AS DATE) AS Ngay, SUM(DoanhThu) AS TongDoanhThu, SUM(ChiPhi) AS TongChiPhi, SUM(DoanhThu - ChiPhi) AS LoiNhuan
FROM (
    SELECT CAST(NgayLap AS DATE) AS Ngay, TongTien AS DoanhThu, 0 AS ChiPhi
    FROM HoaDon
    WHERE CAST(NgayLap AS DATE) >= '2024-02-14' AND CAST(NgayLap AS DATE) <= '2024-02-19'
    
    UNION ALL
    
    SELECT CAST(NgayNhap AS DATE) AS Ngay, 0 AS DoanhThu, TongTien AS ChiPhi
    FROM PhieuNhap
    WHERE CAST(NgayNhap AS DATE) >= '2024-02-14' AND CAST(NgayNhap AS DATE) <= '2024-02-19'
) AS T GROUP BY CAST(Ngay AS DATE);



SELECT SUM(TongDoanhThu) AS TongDoanhThu, SUM(TongChiPhi) AS TongChiPhi, SUM(LoiNhuan) AS TongLoiNhuan
FROM (
    SELECT SUM(TongTien) AS TongDoanhThu, 0 AS TongChiPhi, SUM(TongTien) AS LoiNhuan
    FROM HoaDon
    WHERE CAST(NgayLap AS DATE) >= '2024-02-14' AND CAST(NgayLap AS DATE) <= '2024-02-19'
    
    UNION ALL
    
    SELECT 0 AS TongDoanhThu, SUM(TongTien) AS TongChiPhi, -SUM(TongTien) AS LoiNhuan
    FROM PhieuNhap
    WHERE CAST(NgayNhap AS DATE) >= '2024-02-14' AND CAST(NgayNhap AS DATE) <= '2024-02-19'
) AS T;


WITH Months AS (
    SELECT 1 AS Thang
    UNION ALL
    SELECT Thang + 1
    FROM Months
    WHERE Thang < 12
)
SELECT
    M.Thang,
    ISNULL(PN.TongChiPhi, 0) AS TongChiPhi,
    ISNULL(HD.TongDoanhThu, 0) AS TongDoanhThu,
    ISNULL(HD.TongDoanhThu, 0) - ISNULL(PN.TongChiPhi, 0) AS LoiNhuan
FROM
    Months M
LEFT JOIN (
    SELECT
        MONTH(NgayNhap) AS Thang,
        SUM(TongTien) AS TongChiPhi
    FROM
        PhieuNhap
    WHERE
        YEAR(NgayNhap) = 2024 -- Thay <NamBatKy> bằng năm bạn muốn thống kê
    GROUP BY
        MONTH(NgayNhap)
) PN ON M.Thang = PN.Thang
LEFT JOIN (
    SELECT
        MONTH(NgayLap) AS Thang,
        SUM(TongTien) AS TongDoanhThu
    FROM
        HoaDon
    WHERE
        YEAR(NgayLap) = 2024 -- Thay <NamBatKy> bằng năm bạn muốn thống kê
    GROUP BY
        MONTH(NgayLap)
) HD ON M.Thang = HD.Thang
ORDER BY
    M.Thang


select * from chitietsanpham order by soluongton




SELECT TOP 10
    CTS.MaSanPham,
    SP.TenSanPham,
    SUM(CHD.SoLuong) AS TongSoLuongBan
FROM
    ChiTietSanPham CTS
JOIN
    ChiTietHoaDon CHD ON CTS.MaChiTietSanPham = CHD.MaChiTietSanPham
JOIN
    SanPham SP ON CTS.MaSanPham = SP.MaSanPham
GROUP BY
    SP.TenSanPham, CTS.MaSanPham
ORDER BY
    TongSoLuongBan DESC




	SELECT
    CTS.MaChiTietSanPham,
    SP.TenSanPham,
    MS.TenMauSac,
    KC.TenKichCo,
    CTS.SoLuongTon
FROM
    ChiTietSanPham CTS
JOIN
    SanPham SP ON CTS.MaSanPham = SP.MaSanPham
JOIN
    MauSac MS ON CTS.MaMauSac = MS.MaMauSac
JOIN
    KichCo KC ON CTS.MaKichCo = KC.MaKichCo
where   CTS.SoLuongTon = 0
*/

select * from nhacungcap where trangthai = 1
