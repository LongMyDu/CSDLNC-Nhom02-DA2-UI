USE DB_HOAYEUTHUONG
GO

INSERT INTO MAUSAC(TenMau)
VALUES	(N'Đỏ'),
		(N'Cam'),
		(N'Vàng'),
		(N'Lam'),
		(N'Tím'),
		(N'Xanh dương'),
		(N'Trắng'),
		(N'Hồng'),
		(N'Xanh lá')

GO

INSERT INTO CHINHANH (SdtCN, SoNhaCN, QuanCN,ThanhPhoCN)
VALUES	('0980665555', N'277 Bà Hom', N'Huyện Nhà Bè', N'TP.HCM'),
		('0399884800', N'483 Phan Ngữ', N'Q.4', N'TP.HCM'),
		('0765376320', N'417 Nguyễn Văn Cừ', N'Q.4', N'TP.HCM'),
		('0824273365', N'275 Lý Chiến Thắng', N'Q.8', N'TP.HCM'),
		('0357316025', N'135 Thi Sách', N'Q.Tân Bình', N'TP.HCM')

GO

INSERT INTO LOAINHANVIEN(TenLNV)
VALUES	
		(N'Nhân viên quản lý chi nhánh'),
		(N'Nhân viên giao hàng'),
		(N'Nhân viên bán hàng'),
		(N'Thợ cắm hoa'),
		(N'Nhân viên chăm sóc khách hàng'),
		(N'Nhân viên chăm sóc hoa')

GO
INSERT INTO VATLIEU (TenVL, GiaNhap)
VALUES	(N'Bình 1', 30000),
		(N'Bình 2', 50000),
		(N'Bình 3', 80000),
		(N'Bình 4', 100000),
		(N'Bình 5', 150000),
		(N'Lẵng 1', 100000),
		(N'Lẵng 2', 150000),
		(N'Lẵng 3', 180000),
		(N'Lẵng 4', 200000),
		(N'Lẵng 5', 250000),
		(N'Vòng 1', 100000),
		(N'Vòng 2', 150000),
		(N'Vòng 3', 200000),
		(N'Vòng 4', 250000),
		(N'Vòng 5', 300000),
		(N'Hộp 1', 80000),
		(N'Hộp 2', 150000),
		(N'Hộp 3', 200000),
		(N'Hộp 4', 250000),
		(N'Hộp 5', 300000),
		(N'Nơ nhỏ', 10000),
		(N'Nơ vừa', 20000),
		(N'Nơ lớn', 50000),
		(N'Bảng chữ nhỏ', 20000),
		(N'Bảng chữ vừa', 30000),
		(N'Bảng chữ lớn', 50000),
		(N'Xốp cắm', 10000)

GO

INSERT INTO CHUDE (TenCD)
VALUES(N'Sinh nhật')

INSERT INTO CHUDE (TenCD)
VALUES(N'8/3')

INSERT INTO CHUDE (TenCD)
VALUES(N'20/11')

INSERT INTO CHUDE (TenCD)
VALUES(N'Năm mới')

INSERT INTO CHUDE (TenCD)
VALUES(N'Giáng sinh')

INSERT INTO CHUDE (TenCD)
VALUES(N'Sự kiện')

INSERT INTO CHUDE (TenCD)
VALUES(N'Chia buồn')

INSERT INTO CHUDE (TenCD)
VALUES(N'Tặng mẹ')

INSERT INTO CHUDE (TenCD)
VALUES(N'Chúc sức khỏe')

INSERT INTO CHUDE (TenCD)
VALUES(N'Tết')

INSERT INTO CHUDE (TenCD)
VALUES(N'Mừng tốt nghiệp')

GO


INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'ABC Bakery', '0861942423', N'410 Nguyễn Huệ, Q.Bình Tân, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Đức phát Bakery', '0771474223', N'129 Đề Thám, Q.10, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Tour les jours', '0819636669', N'402 Đặng Dung, Q.Tân Phú, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Break Talk', '0864497140', N'420 Mạc Đĩnh Chi, Q.8, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Paris Gateaux', '0328300388', N'237 Bùi Thị Xuân, Q.5, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Paris Baguette', '0866989432', N'369 Lý Chính Thắng, Q.10, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Givral Bakery', '0924673053', N'316 Nguyễn Siêu, Q.Bình Thạnh, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Gia đình gấu bông', '0980907661', N'381 Huỳnh Thúc Kháng, Huyện Nhà Bè, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Sở thú gấu bông', '0895732171', N'53 Cô Giang, Q.6, TP.HCM ')

INSERT INTO DOITAC (TenDT, SdtDT, DiaChiDT)
VALUES(N'Totoro Việt Nam', '0842114274', N'434 Chu Mạnh Chinh, Q.2, TP.HCM ')

GO

-- Nhân viên quản lý cửa hàng
INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Long', N'Thành Hạnh', N'Nữ', '0894857925', '1959-04-24', N'132 Mặc Thị Bưởi, Q.11, TP.HCM ', '541154044896', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Trần', N'Nhật Phúc', N'Nữ', '0325861684', '1925-10-29', N'223 Tôn Thất Tùng, Q.Bình Thạnh, TP.HCM ', '225944470310', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Hoàng', N'Nhật Nhã', N'Nam', '0376704583', '1970-10-01', N'247 Huyền Quang, Q.12, TP.HCM ', '250499526589', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Phạm', N'Nhật Chi Ly', N'Nam', '0580567610', '1930-01-30', N'156 Mặc Thị Bưởi, Q.9, TP.HCM ', '742197470754', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Hồ', N'Ung Gia', N'Nữ', '0398657883', '1935-07-13', N'108 Nguyễn Thành Ý, Huyện Cần Giờ, TP.HCM ', '347884475435', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Ung', N'Thành Phượng', N'Nữ', '0880812936', '1922-07-15', N'213 Cống Quỳnh, Q.7, TP.HCM ', '301573436647', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Chung', N'Mỹ Huyền', N'Nam', '0336941748', '1936-03-30', N'253 Đặng Tất, Q.Tân Phú, TP.HCM ', '857220256453', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Bùi', N'Nguyệt Thương', N'Nam', '0352795035', '1977-11-15', N'178 Mặc Thị Bưởi, Huyện Củ Chi, TP.HCM ', '621150324817', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Chung', N'Mỹ Hùng Phúc', N'Nam', '0928384738', '1921-02-20', N'406 Lê Thị Hồng Gấm, Huyện Củ Chi, TP.HCM ', '042924476722', N'Đang hoạt động', 1)

INSERT INTO NHANVIEN (HoNV, TenNV, GioiTinhNV, SdtNV, NgaySinhNV, DiaChiNV, CmndNV, TthdNV, LOAINHANVIENMaLNV)
VALUES(N'Ung', N'Khánh Mẫn Anh', N'Nam', '0706012635', '1962-10-05', N'236 Nguyễn Văn Giai, Q.6, TP.HCM ', '402558994150', N'Đang hoạt động', 1)
