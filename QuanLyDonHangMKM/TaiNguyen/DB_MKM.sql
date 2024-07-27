-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyDonDatHang
GO

USE QuanLyDonDatHang
GO

-- Tạo bảng CongTy
CREATE TABLE CongTy (
    MaCongTy INT IDENTITY(1,1) PRIMARY KEY,
    TenCongTy NVARCHAR(100) NOT NULL,
    MaSoThue VARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL
)

-- Tạo bảng Trai
CREATE TABLE Trai (
    MaTrai INT IDENTITY(1,1) PRIMARY KEY,
    TenTrai NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    MaCongTy INT,
    FOREIGN KEY (MaCongTy) REFERENCES CongTy(MaCongTy)
)

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    MaSanPham INT IDENTITY(1,1) PRIMARY KEY,
    TenSanPham NVARCHAR(100) NOT NULL,
    Mau NVARCHAR(50) NOT NULL,
    Gia DECIMAL(18,2) NOT NULL
)

-- Tạo bảng DonDatHang
CREATE TABLE DonDatHang (
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
    MaCongTy INT,
    MaTrai INT,
    NgayDat DATE NOT NULL,
    NgayGiao DATE NOT NULL,
    TongSoLuong INT NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (MaCongTy) REFERENCES CongTy(MaCongTy),
    FOREIGN KEY (MaTrai) REFERENCES Trai(MaTrai)
)

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaChiTietDonHang INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT,
    MaSanPham INT,
    SoLuong INT NOT NULL,
    FOREIGN KEY (MaDonHang) REFERENCES DonDatHang(MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
)