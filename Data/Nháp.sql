﻿Use DB_HOAYEUTHUONG

Select * from chude
Select count(*) from SANPHAMQUATANG
select * from VATLIEU
select * from HOATUOI
select * from LOAINHANVIEN
select * from NHANVIEN where LOAINHANVIENMaLNV = 6
select * from PHIEUXINNHAPHANG
select * from PHIEUNHANHANG
select * from Nhan_hoatuoi
select count(*) from dondathang
select * from PHIEUPHANPHOI
select * from SANPHAMQUATANG
select * from MUA_SPQT

select * from HOATUOI_SPQT
select * from VATLIEU_SPQT
INSERT INTO PHIEUNHANHANG (NgayNhan)
VALUES ('10-04-2020')

INSERT INTO HOATUOI (TenHT)
VALUES (N'Cúc')

INSERT INTO HOATUOI (TenHT)
VALUES (N'Hồng')

INSERT INTO [NHAN_HOATUOI] (PHIEUNHANHANGMaPNH,HOATUOIMaHT,DonGia,SoLuong)
VALUES
  (1,1,10,90)

INSERT INTO [NHAN_HOATUOI] (PHIEUNHANHANGMaPNH,HOATUOIMaHT,DonGia,SoLuong)
VALUES
  (1,2,30,100)


INSERT INTO MUA_SPQT (DONDATHANGMaDDH, SANPHAMQUATANGMaSPQT)
Values (2, 2)

INSERT INTO [NHAN_HOATUOI] (PHIEUNHANHANGMaPNH,HOATUOIMaHT,DonGia,SoLuong)
VALUES
  (367,2,2,7)