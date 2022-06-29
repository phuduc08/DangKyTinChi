CREATE DATABASE DKTC

use DKTC
CREATE TABLE hoc_phan
(
  MaHP INT PRIMARY KEY NOT NULL,
  TenHP NVARCHAR(100),
  SoTC INT, 
  SoLHP INT,
  MonTQ NVARCHAR (100),
  PL NVARCHAR(100),
  TT NVARCHAR (100),
  GV NVARCHAR(100),
)
GO 

INSERT INTO hoc_phan VALUES

('3948', N'An toàn và bảo mật thông tin', '3', '1', N'Nhập môn công nghệ thông tin', N'Thực hành', N'Bộ môn Công nghệ thông tin', N'Nguyễn Thị Bạch Tuyết'),
('9843', N'Các công nghệ ảo hóa', '3', '2', N'Mạng máy tính và truyền thông', N'Thực hành', N'Bộ môn Công nghệ thông tin', N'Trần Thanh Hải'),
('9646', N'Các hệ thống thông minh', '3', '1', N'Nhập môn công nghệ thông tin', N'Thực hành', N'Bộ môn Công nghệ thông tin', N'Vũ Hưng Hải'),
('4213', N'Công nghệ đa phương điện', '3', '2', N'Nhập môn công nghệ thông tin', N'Thực hành', N'Bộ môn Công nghệ thông tin', N'Lưu Minh Tuấn'),
('7576', N'Cơ sở lập trình', '3', '3', N'Nhập môn công nghệ thông tin', N'Thực hành', N'Bộ môn công nghệ thông tin', N'Nguyễn Văn Thư'),
('5465', N'Dữ liệu phi cấu trúc', '3', '1', N'Cấu trúc dữ liệu và giải thuật', N'Lý thuyết', N'Bộ môn công nghệ thông tin', N'Nguyễn Anh Phương');
  
CREATE TABLE lop_hp
(
  MaLHP INT PRIMARY KEY NOT NULL,   
  TenLHP NVARCHAR(100), 
  SoTC INT,
  GV NVARCHAR(100),
  LH NVARCHAR(100),
 )
 GO

 INSERT INTO lop_hp VALUES
('39481', N'An toàn và bảo mật thông tin', '3', N'Nguyễn Thị Bạch Tuyết', N'Thứ 2 tiết 56', '8-1-2022', '11-20-2022'),
('98431', N'Các công nghệ ảo hóa', '3', N'Trần Thanh Hải', N'Thứ 2 tiết 12', '8-1-2022', '11-20-2022'),
('98432', N'Các công nghệ ảo hóa', '3', N'Trần Thanh Hải', N'Thứ 2 tiết 34', '8-1-2022', '11-20-2022'),
('96461', N'Các hệ thống thông minh', '3', N'Vũ Hưng Hải', N'Thứ 3 tiết 45', '8-1-2022', '11-20-2022'),
('42131', N'Công nghệ đa phương điện', '3', N'Lưu Minh Tuấn', N'Thứ 4 tiết 12', '8-1-2022', '11-20-2022'),
('42132', N'Công nghệ đa phương điện', '3', N'Lưu Minh Tuấn', N'Thứ 4 tiết 34', '8-1-2022', '11-20-2022'),
('75761', N'Cơ sở lập trình', '3', N'Nguyễn Văn Thư', N'Thứ 5 tiết 12', '8-1-2022', '11-20-2022'),
('75762', N'Cơ sở lập trình', '3', N'Nguyễn Văn Thư', N'Thứ 5 tiết 34', '8-1-2022', '11-20-2022'),
('75763', N'Cơ sở lập trình', '3', N'Nguyễn Thị Bạch Tuyết', N'Thứ 6 tiết 34', '8-1-2022', '11-20-2022'),
('54651', N'Dữ liệu phi cấu trúc', '3', N'Nguyễn Anh Phương', N'Thứ 7 tiết 12', '8-1-2022', '11-20-2022');
  
 ALTER TABLE lop_hp ADD tungay DATE
 ALTER TABLE lop_hp ADD dengay DATE 

 CREATE TABLE sinhvien
 (
   MaSV INT PRIMARY KEY NOT NULL, 
   HotenSV NVARCHAR(100), 
 )

 INSERT INTO sinhvien VALUES
 ('11247349', N'Đoàn Thị Hồng Anh'),
 ('11982388', N'Đoàn Tuấn Anh'),
 ('11509942', N'La Thị Thùy Dương'),
 ('11605965', N'Đào Hà Vy'),
 ('17849575', N'Nguyễn Hải Linh'),
 ('15609868', N'Lương Lan Anh'),
 ('17905693', N'Nguyễn Ngọc Ánh'),
 ('19324490', N'Nguyễn Ngọc');

 SELECT * FROM hoc_phan 
 SELECT * FROM lop_hp
