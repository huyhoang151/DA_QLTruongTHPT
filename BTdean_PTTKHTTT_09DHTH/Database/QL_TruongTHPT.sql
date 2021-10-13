CREATE DATABASE QL_TruongTHPT
GO
USE QL_TruongTHPT

--===================================================================================================================================================
CREATE TABLE LoaiNguoiDung
(
	MaLoaiND	VARCHAR(5)		NOT NULL	PRIMARY KEY,
	TenLoaiND	NVARCHAR(30)
)

INSERT INTO LoaiNguoiDung VALUES('LND01',N'Ban Giám Hiệu')
INSERT INTO LoaiNguoiDung VALUES('LND02',N'Giáo Viên')
INSERT INTO LoaiNguoiDung VALUES('LND03',N'Giáo Vụ')

--===================================================================================================================================================
CREATE TABLE ManHinh
(
	MaManHinh	VARCHAR(5)		NOT NULL	PRIMARY KEY,
	TenManHinh	NVARCHAR(MAX)
)
INSERT INTO ManHinh VALUES('MH001',N'Khối Học')
INSERT INTO ManHinh VALUES('MH002',N'Lớp Học')
INSERT INTO ManHinh VALUES('MH003',N'Năm Học')
INSERT INTO ManHinh VALUES('MH004',N'Học Kỳ')
INSERT INTO ManHinh VALUES('MH005',N'Môn Học')
INSERT INTO ManHinh VALUES('MH006',N'Điểm')
INSERT INTO ManHinh VALUES('MH007',N'Hạnh Kiểm')
INSERT INTO ManHinh VALUES('MH008',N'Học Lực')
INSERT INTO ManHinh VALUES('MH009',N'Kết Quả')
INSERT INTO ManHinh VALUES('MH010',N'Danh Hiệu')
INSERT INTO ManHinh VALUES('MH011',N'Học Sinh')
INSERT INTO ManHinh VALUES('MH012',N'Phân Lớp')
INSERT INTO ManHinh VALUES('MH013',N'Giáo Viên')
INSERT INTO ManHinh VALUES('MH014',N'Phân Công')
INSERT INTO ManHinh VALUES('MH015',N'Tra Cứu Học Sinh')
INSERT INTO ManHinh VALUES('MH016',N'Tra Cứu Giáo Viên')
INSERT INTO ManHinh VALUES('MH017',N'Hỗ Trợ Sử Dụng')
INSERT INTO ManHinh VALUES('MH018',N'Thông Tin Phần Mềm')
INSERT INTO ManHinh VALUES('MH019',N'Quản Lý Người Dùng')
INSERT INTO ManHinh VALUES('MH020',N'Màn Hình')
--===================================================================================================================================================
CREATE TABLE PhanQuyen
(
	MaLoaiND	VARCHAR(5)		NOT NULL,
	MaManHinh	VARCHAR(5)		NOT NULL,
	CoQuyen		BIT,

	PRIMARY KEY(MaLoaiND, MaManHinh),

	CONSTRAINT FK_PhanQuyen_LoaiNguoiDung	FOREIGN KEY(MaLoaiND)		REFERENCES LoaiNguoiDung(MaLoaiND),
	CONSTRAINT FK_PhanQuyen_ManHinh			FOREIGN KEY(MaManHinh)		REFERENCES ManHinh(MaManHinh)
)

--===================================================================================================================================================
CREATE TABLE DanToc
(
	MaDanToc	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenDanToc	NVARCHAR (30)
)
INSERT INTO DanToc VALUES('DT001',N'Kinh')
INSERT INTO DanToc VALUES('DT002',N'Hoa')
INSERT INTO DanToc VALUES('DT003',N'Khome')
INSERT INTO DanToc VALUES('DT004',N'Cham')
--===================================================================================================================================================
CREATE TABLE TonGiao
(
	MaTonGiao	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenTonGiao	NVARCHAR (30)
)

INSERT INTO TonGiao VALUES('TG001',N'Không')
INSERT INTO TonGiao VALUES('TG002',N'Phật')
INSERT INTO TonGiao VALUES('TG003',N'Thiên Chúa')
INSERT INTO TonGiao VALUES('TG004',N'Tin Lành')

--===================================================================================================================================================
CREATE TABLE NamHoc
(
	MaNamHoc	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenNamHoc	VARCHAR (30)
)

INSERT INTO NamHoc VALUES('NH21','2020 - 2021')
INSERT INTO NamHoc VALUES('NH22','2021 - 2022')
--===================================================================================================================================================
CREATE TABLE HocKy
(
	MaHocKy		VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenHocKy	NVARCHAR (30)
)

INSERT INTO HocKy VALUES('HK1',N'Học Kỳ 1')
INSERT INTO HocKy VALUES('HK2',N'Học Kỳ 2')

--===================================================================================================================================================
CREATE TABLE KhoiHoc
(
	MaKhoiLop	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenKhoiLop	NVARCHAR (30)
)

INSERT INTO KhoiHoc VALUES('KH10',N'Khối 10')
INSERT INTO KhoiHoc VALUES('KH11',N'Khối 11')
INSERT INTO KhoiHoc VALUES('KH12',N'Khối 12')
--===================================================================================================================================================
CREATE TABLE MonHoc
(
	MaMonHoc	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenMonHoc	NVARCHAR (30),
	SoTiet		INT,
	HeSo		INT
)

INSERT INTO MonHoc VALUES('MH001',N'Toán Học',				90,	2)
INSERT INTO MonHoc VALUES('MH002',N'Vật Lý',				60,	1)
INSERT INTO MonHoc VALUES('MH003',N'Hóa Học',				60,	1)
INSERT INTO MonHoc VALUES('MH004',N'Sinh Học',				60,	1)
INSERT INTO MonHoc VALUES('MH005',N'Ngữ Văn',				90,	2)
INSERT INTO MonHoc VALUES('MH006',N'Lịch Sử',				45,	1)
INSERT INTO MonHoc VALUES('MH007',N'Địa Lý',				45,	1)
INSERT INTO MonHoc VALUES('MH008',N'Anh Văn',				45,	1)
INSERT INTO MonHoc VALUES('MH009',N'Giáo Dục Công Dân',	30,	1)
INSERT INTO MonHoc VALUES('MH010',N'Tin Học',				30,	1)
INSERT INTO MonHoc VALUES('MH011',N'Thể Dục',				30,	1)
INSERT INTO MonHoc VALUES('MH012',N'Quốc Phòng - An Ninh',	30,	1)
INSERT INTO MonHoc VALUES('MH013',N'Công Nghệ',			30,	1)
--===================================================================================================================================================
CREATE TABLE HocLuc
(
	MaHocLuc		VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenHocLuc		NVARCHAR (30),
	DiemCanDuoi		FLOAT,
	DiemCanTren		FLOAT,
	DiemKhongChe	FLOAT
)

INSERT INTO HocLuc VALUES('HL001',N'Giỏi',		8.0,	10.0,	6.5)
INSERT INTO HocLuc VALUES('HL002',N'Khá',		6.5,	7.9,	5.0)
INSERT INTO HocLuc VALUES('HL003',N'Trung bình',5.0,	6.4,	3.5)
INSERT INTO HocLuc VALUES('HL004',N'Yếu',		3.5,	4.9,	2.0)
INSERT INTO HocLuc VALUES('HL005',N'Kém',		0.0,	3.4,	0.0)
--===================================================================================================================================================
CREATE TABLE HanhKiem
(
	MaHanhKiem		VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenHanhKiem		NVARCHAR (30)
)

INSERT INTO HanhKiem VALUES('HK001',N'Tốt')
INSERT INTO HanhKiem VALUES('HK002',N'Khá')
INSERT INTO HanhKiem VALUES('HK003',N'Trung bình')
INSERT INTO HanhKiem VALUES('HK004',N'Yếu')
--===================================================================================================================================================
CREATE TABLE KetQua
(
	MaKetQua	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenKetQua	NVARCHAR (30)
)

INSERT INTO KetQua VALUES('KQ001',N'Lên lớp')
INSERT INTO KetQua VALUES('KQ002',N'Thi lại')
INSERT INTO KetQua VALUES('KQ003',N'Rèn luyện hè')
INSERT INTO KetQua VALUES('KQ004',N'Ở lại')
--===================================================================================================================================================
CREATE TABLE DanhHieu
(
	MaDanhHieu	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenDanhHieu	NVARCHAR (30)
)

INSERT INTO DanhHieu VALUES('DH001',N'Học sinh giỏi')
INSERT INTO DanhHieu VALUES('DH002',N'Học sinh tiên tiến')
--===================================================================================================================================================
CREATE TABLE GiaoVien
(
	MaGiaoVien	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenGiaoVien NVARCHAR (30),
	SoDienThoai	VARCHAR (11)	CHECK(SoDienThoai LIKE'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' 
				OR SoDienThoai LIKE'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') UNIQUE NOT NULL,
	DiaChi		NVARCHAR (50),
	MatKhau		VARCHAR(15)		NOT NULL,
	GhiChu		NVARCHAR(MAX),
	MaLoaiND	VARCHAR (5)	NOT NULL,	
	MaMonHoc	VARCHAR (5)	NOT NULL,
	
	CONSTRAINT FK_GV_LND FOREIGN KEY(MaLoaiND)	REFERENCES LoaiNguoiDung(MaLoaiND),
	CONSTRAINT FK_GV_MH FOREIGN KEY(MaMonHoc)	REFERENCES MONHOC(MaMonHoc)
)
INSERT INTO GiaoVien VALUES('GV001',N'Bùi Bích Phương','0967456324',N'Quảng Ninh','doanhdoanduoc','','LND01','MH005')
INSERT INTO GiaoVien VALUES('GV002',N'Nguyễn Hương Giang','0989410524',N'Hà Nội','adodda','','LND02','MH001')
INSERT INTO GiaoVien VALUES('GV003',N'Nguyễn Thị Thúy Loan','0985643876',N'TP.HCM','baothy','','LND02','MH002')
INSERT INTO GiaoVien VALUES('GV004',N'Lâm Á Hân','0984563719',N'Hải Phòng','hannie12','','LND02','MH003')
INSERT INTO GiaoVien VALUES('GV005',N'Trần Anh Dũng','0874332093',N'Đồng Tháp','ttt34','','LND02','MH004')
INSERT INTO GiaoVien VALUES('GV006',N'Phạm Thanh Hà','0943657321',N'Đồng Nai','iloveu','','LND02','MH006')
INSERT INTO GiaoVien VALUES('GV007',N'Huỳnh Ánh Nguyệt','0986544101',N'Huế','lunar','','LND02','MH008')
INSERT INTO GiaoVien VALUES('GV008',N'Lê Y Nàng Tấm','0967786453',N'Quảng Nam','tam898','','LND02','MH007')
INSERT INTO GiaoVien VALUES('GV009',N'Nguyễn Tuấn Anh','0967778420',N'Quảng Ninh','hello','','LND02','MH005')
INSERT INTO GiaoVien VALUES('GV010',N'Ngô Bá Khá','0906755412',N'Quảng Trị','tobe','','LND02','MH009')
INSERT INTO GiaoVien VALUES('GV011',N'Trần Quốc Hoàng','0988901964',N'Quảng Ninh','huppi','','LND02','MH010')
INSERT INTO GiaoVien VALUES('GV012',N'Võ Trung Nghĩa','0895676334',N'Đà Nẵng','112345','','LND02','MH011')
INSERT INTO GiaoVien VALUES('GV013',N'Lâm Tuấn Khải','0967459024',N'Lâm Đồng','thuy','','LND02','MH012')
INSERT INTO GiaoVien VALUES('GV014',N'Trần Duy Hưng','0967451224',N'TP.HCM','blackpink','','LND02','MH013')
INSERT INTO GiaoVien VALUES('GV015',N'Nguyễn Phương Hướng','0967090984',N'TP.HCM','hahaha','','LND02','MH004')
INSERT INTO GiaoVien VALUES('GV016',N'Mai Âm Nhạc','0966765432',N'TP.HCM','sml','','LND02','MH006')
INSERT INTO GiaoVien VALUES('GV017',N'Lâm Tuấn Phong','0967459454',N'Lâm Đồng','thuy2','','LND02','MH001')
INSERT INTO GiaoVien VALUES('GV018',N'Trần Duy Nhất','0967476224',N'TP.HCM','lisa','','LND02','MH003')
INSERT INTO GiaoVien VALUES('GV019',N'Nguyễn Hướng Dương','0967090894',N'TP.HCM','hahahaha','','LND02','MH004')
INSERT INTO GiaoVien VALUES('GV020',N'Phí Phương Anh','0966768932',N'TP.HCM','sml','','LND02','MH006')
--===================================================================================================================================================
CREATE TABLE LopHoc
(
	MaLopHoc	VARCHAR (5)	NOT NULL	PRIMARY KEY,
	TenLopHoc	NVARCHAR (30),
	SiSo		INT DEFAULT(0) CHECK (SiSo>=0 and SiSo<=40),
	MaKhoiLop	VARCHAR (5)	NOT NULL,
	MaNamHoc	VARCHAR (5)	NOT NULL,
	MaGiaoVien	VARCHAR (5)	NOT NULL,
	
	CONSTRAINT FK_LOP_KH FOREIGN KEY(MaKhoiLop)	REFERENCES KhoiHoc(MaKhoiLop),
	CONSTRAINT FK_LOP_NH FOREIGN KEY(MaNamHoc)	REFERENCES NamHoc(MaNamHoc),
	CONSTRAINT FK_LOP_GV FOREIGN KEY(MaGiaoVien)	REFERENCES GiaoVien(MaGiaoVien)
)
INSERT INTO LopHoc(MaLopHoc,TenLopHoc,MaKhoiLop,MaNamHoc,MaGiaoVien) VALUES('LH001','10A1','KH10','NH21','GV001')
INSERT INTO LopHoc VALUES('LH002','10A2',0,'KH10','NH21','GV003')
INSERT INTO LopHoc VALUES('LH003','10A3',0,'KH10','NH21','GV004')
INSERT INTO LopHoc VALUES('LH004','10A4',0,'KH10','NH21','GV005')
INSERT INTO LopHoc VALUES('LH005','10A5',0,'KH10','NH21','GV006')
INSERT INTO LopHoc VALUES('LH006','10A6',0,'KH10','NH21','GV010')
INSERT INTO LopHoc VALUES('LH007','11A1',0,'KH11','NH21','GV002')
INSERT INTO LopHoc VALUES('LH008','11A2',0,'KH11','NH21','GV009')
INSERT INTO LopHoc VALUES('LH009','11A3',0,'KH11','NH21','GV011')
INSERT INTO LopHoc VALUES('LH010','11A4',0,'KH11','NH21','GV012')
INSERT INTO LopHoc VALUES('LH011','11A5',0,'KH11','NH21','GV013')
INSERT INTO LopHoc VALUES('LH012','11A6',0,'KH11','NH21','GV014')
INSERT INTO LopHoc VALUES('LH013','12A1',0,'KH12','NH21','GV015')
INSERT INTO LopHoc VALUES('LH014','12A2',0,'KH12','NH21','GV016')
INSERT INTO LopHoc VALUES('LH015','12A3',0,'KH12','NH21','GV017')
INSERT INTO LopHoc VALUES('LH016','12A4',0,'KH12','NH21','GV018')
INSERT INTO LopHoc VALUES('LH017','12A5',0,'KH12','NH21','GV019')
INSERT INTO LopHoc VALUES('LH018','12A6',0,'KH12','NH21','GV020')

select * from LopHoc
--===================================================================================================================================================
CREATE TABLE HocSinh
(
	MaHocSinh		VARCHAR (5)		NOT NULL	PRIMARY KEY,
	TenHocSinh		NVARCHAR (50),
	NgaySinh		DATETIME			CHECK(YEAR(GETDATE())-YEAR(NgaySinh)>=15),
	GioiTinh		NVARCHAR (5)		DEFAULT(N'Nam'),
	NoiSinh			NVARCHAR (50),
	DiaChi			NVARCHAR (50),
	HoTenBo			NVARCHAR (50),
	HoTenMe			NVARCHAR (50),
	SDTLienHe		VARCHAR(11)	CHECK(SDTLienHe LIKE'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' 
					OR SDTLienHe LIKE'[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') UNIQUE ,
	MaDanToc		VARCHAR (5),
	MaTonGiao		VARCHAR (5),
	MaLopHoc		VARCHAR (5),
	GhiChu			NVARCHAR(MAX),
	
	CONSTRAINT FK_HS_DT		FOREIGN KEY(MaDanToc)		REFERENCES DanToc(MaDanToc),
	CONSTRAINT FK_HS_TG		FOREIGN KEY(MaTonGiao)		REFERENCES TonGiao(MaTonGiao),
	CONSTRAINT FK_HS_LH		FOREIGN KEY(MaLopHoc)		REFERENCES LopHoc(MaLopHoc)

)
select* from HocSinh
INSERT INTO HocSinh VALUES ('HS001',N'Huỳnh Hữu Thắng','10/13/2000',N'Nam',N'Đồng Tháp',N'Đồng Tháp',N'Huỳnh Hữu Ngãi',N'Triệu Bé Bảy','0943918205','DT001','TG001','LH001','')
INSERT INTO HocSinh VALUES ('HS002',N'Nguyễn Trọng Hiếu','05/19/2000',N'Nam',N'Dak Nông',N'Dak Nông',N'Nguyễn Trọng Béo',N'Trần Ngọc Híu','0943918890','DT001','TG001','LH001','')
INSERT INTO HocSinh VALUES ('HS003',N'Nguyễn Ngọc Thơ','12/13/2000',N'Nữ',N'TP.HCM',N'Đồng Tháp',N'Nguyễn Văn A ',N'Lâm Minh B','0943914897','DT001','TG002','LH003','')
INSERT INTO HocSinh VALUES ('HS004',N'Lê Minh Lực','07/06/2000',N'Nam',N'TP.HCM',N'Đồng Tháp',N'Lê Anh Hoàng',N'Lê Linh','09439182356','DT001','TG001','LH005','')
INSERT INTO HocSinh VALUES ('HS005',N'Nguyễn Minh An','08/30/2001',N'Nam',N'Đồng Tháp',N'Đồng Tháp',N'Nguyễn Minh Anh ',N'Trần Diệp Lạc','0943912890','DT001','TG001','LH005','')
INSERT INTO HocSinh VALUES ('HS006',N'Trần Tiến Mạnh','09/12/2002',N'Nam',N'Đồng Tháp',N'Đồng Tháp',N'Trần Trung Tiến ',N'Lâm Mị Châu ','0943914532','DT001','TG001','LH005','')
INSERT INTO HocSinh VALUES ('HS007',N'Lê Trung Thành','11/30/2002',N'Nam',N'TP.HCM',N'TP.HCM',N'Lê Văn Lợi',N'Lê Thị Mai ','09439182356','DT001','TG001','LH002','')
INSERT INTO HocSinh VALUES ('HS008',N'Nguyễn Vĩ Tấn','11/15/2001',N'Nam',N'Vũng Tàu',N'TP.HCM',N'Nguyễn Trí Tuấn ',N'Trần Ngọc My','0943918890','DT001','TG001','LH018','')
INSERT INTO HocSinh VALUES ('HS009',N'Trần An Nhi','12/18/2001',N'Nữ',N'Đồng Tháp',N'TP.HCM',N'Trần Tuấn Vũ',N'Lâm Ngọc Dung','0943914532','DT001','TG001','LH011','')
INSERT INTO HocSinh VALUES ('HS010',N'Lê Yến Phụng','09/05/2001',N'Nữ',N'ĐHà Nội',N'Đồng Tháp',N'Lê Anh',N'Lê Em','09439182356','DT001','TG001','LH012','')
INSERT INTO HocSinh VALUES ('HS011',N'Nguyễn Cao Cường','02/02/2002',N'Nam',N'Hà Tĩnh',N'TP.HCM',N'Nguyễn Hải Duy',N'Trần Vy Oanh','0943918890','DT001','TG001','LH013','')
INSERT INTO HocSinh VALUES ('HS012',N'Trần Bình Minh','02/13/2002',N'Nam',N'Đồng Tháp',N'TP.HCM',N'Trần Thái Huy',N'Lâm Kì Vĩ','0943914532','DT001','TG001','LH015','')
INSERT INTO HocSinh VALUES ('HS013',N'Lê Quý Khang','01/14/2003',N'Nam',N'Bến Tre',N'TP.HCM',N'Lê Minh Nhựt',N'Lê Thị Hoa','09439182356','DT001','TG001','LH015','')
INSERT INTO HocSinh VALUES ('HS014',N'Nguyễn Mạnh Cường','04/15/2001',N'Nam',N'Đồng Tháp',N'Đồng Tháp',N'Nguyễn Hoàng Ku ',N'Trần Bảo Ngọc','0943917890','DT001','TG001','LH003','')
INSERT INTO HocSinh VALUES ('HS015',N'Trần Diệu Ý','05/13/2000',N'Nữ',N'Bạc Liêu',N'TP.HCM',N'Trần Dũng',N'Lâm Hân ','0943914532','DT001','TG001','LH002','')
INSERT INTO HocSinh VALUES ('HS016',N'Lê Minh Hậu','06/13/2000',N'Nam',N'Quảng Trị',N'TP.HCM',N'Lê Dũng Sĩ ',N'Lê Ngọc Vy','09439182356','DT001','TG001','LH016','')
INSERT INTO HocSinh VALUES ('HS017',N'Nguyễn Cung Sư','09/13/2000',N'Nam',N'Đồng Tháp',N'Đồng Tháp',N'Nguyễn Tuấn An ',N'Trần Mỹ Lệ','0943918899','DT001','TG001','LH016','')
INSERT INTO HocSinh VALUES ('HS018',N'Trần Ngọc Ánh','10/13/2000',N'Nữ',N'Quảng Nam',N'TP.HCM',N'Trần Bách Khoa',N'Lâm Vy Ánh','0943914532','DT001','TG001','LH017','')
INSERT INTO HocSinh VALUES ('HS019',N'Lê Nguyệt Mị Ly','07/13/2000',N'Nữ',N'Đồng Tháp',N'Đồng Tháp',N'Lê Minh Công',N'Lê Xuân Khoát','09439182306','DT001','TG001','LH018','')
INSERT INTO HocSinh VALUES ('HS020',N'Nguyễn Hồng Ngọc','09/13/2000',N'Nữ',N'Đồng Tháp',N'TP.HCM',N'Nguyễn Cường Công ',N'Trần Mỹ Thụ','0943918890','DT001','TG001','LH007','')
INSERT INTO HocSinh VALUES ('HS021',N'Trần Thanh Vy','10/13/2000',N'Nữ',N'Lâm Đồng',N'TP.HCM',N'Trần Nhựt Cường ',N'Lâm Ly Ly ','0943914532','DT001','TG001','LH008','')
INSERT INTO HocSinh VALUES ('HS022',N'Lê Vỹ Phong','11/13/2000',N'Nam',N'Đồng Tháp',N'TP.HCM',N'Lê Chí Lưu',N'Lê Hoa Ánh','09439182356','DT001','TG001','LH009','')
INSERT INTO HocSinh VALUES ('HS023',N'Nguyễn Oanh Lý','12/13/2000',N'Nữ',N'Đồng Tháp',N'TP.HCM',N'Nguyễn Địa Chí',N'Trần Ngọc Hoa','0943918890','DT001','TG001','LH010','')
INSERT INTO HocSinh VALUES ('HS024',N'Trần Mỹ Linh','11/13/2000',N'Nữ',N'Đồng Tháp',N'TP.HCM',N'Trần Trường Hóa',N'Lâm Thiên Thần','0943914532','DT001','TG001','LH010','')
INSERT INTO HocSinh VALUES ('HS025',N'Lê Thành Thái','10/13/2000',N'Nam',N'Đồng Tháp',N'TP.HCM',N'Lê Vỹ Luân ',N'Lê Ánh Hoàng','09439182356','DT001','TG001','LH010','')
--===================================================================================================================================================
CREATE TABLE PhanCong
(
	MaLopHoc	VARCHAR (5)	NOT NULL,
	MaGiaoVien	VARCHAR (5)	NOT NULL,
	
	PRIMARY KEY(MaLopHoc, MaGiaoVien),
	
	CONSTRAINT FK_PC_LOP	FOREIGN KEY(MaLopHoc)	REFERENCES LopHoc(MaLopHoc),
	CONSTRAINT FK_PC_GV		FOREIGN KEY(MaGiaoVien)	REFERENCES GiaoVien(MaGiaoVien)
)
select * from GiaoVien
--===================================================================================================================================================
CREATE TABLE DiemMonHoc
(
	MaHocSinh		VARCHAR (5)	NOT NULL,
	MaMonHoc		VARCHAR (5)	NOT NULL,
	MaNamHoc		VARCHAR (5)	NOT NULL,
	MaHocKy			VARCHAR (5)	NOT NULL,
	DiemMieng		FLOAT			CHECK(DiemMieng>=0 AND DiemMieng<=10),
	Diem15Phut		FLOAT			CHECK(Diem15Phut>=0 AND Diem15Phut<=10),
	Diem45Phut		FLOAT			CHECK(Diem45Phut>=0 AND Diem45Phut<=10),
	DiemThi			FLOAT			CHECK(DiemThi>=0 AND DiemThi<=10),
	DiemTBMonHoc	FLOAT			CHECK(DiemTBMonHoc>=0 AND DiemTBMonHoc<=10),
	GhiChu			NVARCHAR(MAX),

	PRIMARY KEY(MaHocSinh, MaMonHoc,MaNamHoc,MaHocKy),

	CONSTRAINT FK_DMH_HS	FOREIGN KEY(MaHocSinh)		REFERENCES HocSinh(MaHocSinh),
	CONSTRAINT FK_DMH_MN	FOREIGN KEY(MaMonHoc)		REFERENCES MonHoc(MaMonHoc),
	CONSTRAINT FK_DMH_NH	FOREIGN KEY(MaNamHoc)		REFERENCES NamHoc(MaNamHoc),
	CONSTRAINT FK_DMH_HK	FOREIGN KEY(MaHocKy)		REFERENCES HocKy(MaHocKy)

)
--===================================================================================================================================================
CREATE TABLE DiemTBCaHocKy
(
	MaHocSinh		VARCHAR (5)	NOT NULL,
	MaNamHoc		VARCHAR (5)	NOT NULL,
	MaHocKy			VARCHAR (5)	NOT NULL,
	DiemTBCaHocKy	FLOAT			CHECK(DiemTBCaHocKy>=0 AND DiemTBCaHocKy<=10),
	MaHocLuc		VARCHAR(5),
	MaHanhKiem		VARCHAR(5),

	PRIMARY KEY(MaHocSinh,MaNamHoc,MaHocKy),

	CONSTRAINT FK_DTBCHK_HS		FOREIGN KEY(MaHocSinh)		REFERENCES HocSinh(MaHocSinh),
	CONSTRAINT FK_DTBCHK_NH		FOREIGN KEY(MaNamHoc)		REFERENCES NamHoc(MaNamHoc),
	CONSTRAINT FK_DTBCHK_HK		FOREIGN KEY(MaHocKy)		REFERENCES HocKy(MaHocKy),
	CONSTRAINT FK_DTBCHK_HL		FOREIGN KEY(MaHocLuc)		REFERENCES HocLuc(MaHocLuc),
	CONSTRAINT FK_DTBCHK_HKiem	FOREIGN KEY(MaHanhKiem)		REFERENCES HanhKiem(MaHanhKiem)
)
--===================================================================================================================================================
CREATE TABLE DiemTBCaNamHoc
(
	MaHocSinh		VARCHAR (5)	NOT NULL,
	MaNamHoc		VARCHAR (5)	NOT NULL,
	DiemTBCaNamHoc	FLOAT			CHECK(DiemTBCaNamHoc>=0 AND DiemTBCaNamHoc<=10),
	MaHocLuc		VARCHAR(5),
	MaHanhKiem		VARCHAR(5),
	MaKetQua		VARCHAR(5),
	MaDanhHieu		VARCHAR(5),

	PRIMARY KEY(MaHocSinh,MaNamHoc),

	CONSTRAINT FK_DTBCNH_HS		FOREIGN KEY(MaHocSinh)		REFERENCES HocSinh(MaHocSinh),
	CONSTRAINT FK_DTBCNH_NH		FOREIGN KEY(MaNamHoc)		REFERENCES NamHoc(MaNamHoc),
	CONSTRAINT FK_DTBCNH_HL		FOREIGN KEY(MaHocLuc)		REFERENCES HocLuc(MaHocLuc),
	CONSTRAINT FK_DTBCNH_HKiem	FOREIGN KEY(MaHanhKiem)		REFERENCES HanhKiem(MaHanhKiem),
	CONSTRAINT FK_DTBCNH_KQ		FOREIGN KEY(MaKetQua)		REFERENCES KetQua(MaKetQua),
	CONSTRAINT FK_DTBCNH_DH		FOREIGN KEY(MaDanhHieu)		REFERENCES DanhHieu(MaDanhHieu)
)
--===================================================================================================================================================
GO
CREATE TRIGGER CapNhatSiSoKhiThemHS ON HocSinh FOR INSERT, UPDATE 
AS
	DECLARE @MaLH VARCHAR(10),@MaHS VARCHAR(10)
	BEGIN
		SET @MaLH = (SELECT MaLopHoc FROM INSERTED)
		SET @MaHS = (SELECT MaHocSinh FROM INSERTED)
		IF UPDATE(MaLopHoc)
		BEGIN
			UPDATE LopHoc
			SET SiSo=SiSo+1
			WHERE MaLopHoc=@MaLH
		END
	END


GO
CREATE TRIGGER CapNhatSiSoKhiXoaHS ON HocSinh FOR DELETE 
AS
	DECLARE @MaLH VARCHAR(10),@MaHS VARCHAR(10)
	SET @MaLH = (SELECT MaLopHoc FROM DELETED)
	BEGIN
		UPDATE LopHoc
		SET SiSo=SiSo-1
		WHERE MaLopHoc=@MaLH
	END

GO

--===================================================================================================================================================

--===================================================================================================================================================