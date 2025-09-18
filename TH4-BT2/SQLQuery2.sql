CREATE DATABASE QL_NHANVIEN;
GO

USE QL_NHANVIEN;
GO

CREATE TABLE phongban (
    mapb CHAR(5) PRIMARY KEY,
    tenpb NVARCHAR(50) NOT NULL
);

CREATE TABLE chucvu (
    macv CHAR(5) PRIMARY KEY,
    tencv NVARCHAR(50) NOT NULL,
    hsphucap DECIMAL(5,2)
);

CREATE TABLE nhanvien (
    manv CHAR(5) PRIMARY KEY,
    holot NVARCHAR(30),
    ten NVARCHAR(20) NOT NULL,
    ngaysinh DATE,
    gioitinh NVARCHAR(5),
    macv CHAR(5),
    mapb CHAR(5),
    FOREIGN KEY (macv) REFERENCES chucvu(macv),
    FOREIGN KEY (mapb) REFERENCES phongban(mapb)
);

CREATE TABLE quatrinhluong (
    manv CHAR(5),
    ngaybd DATE,
    hsluong DECIMAL(5,2),
    ghichu NVARCHAR(100),
    PRIMARY KEY (manv, ngaybd),
    FOREIGN KEY (manv) REFERENCES nhanvien(manv)
);

-- =========================
-- DỮ LIỆU MẪU
-- =========================

-- Bảng Phòng ban
INSERT INTO phongban (mapb, tenpb) VALUES
('PB01', N'Phòng Kế Toán'),
('PB02', N'Phòng Nhân Sự'),
('PB03', N'Phòng IT'),
('PB04', N'Phòng Kinh Doanh'),
('PB05', N'Phòng Marketing');

-- Bảng Chức vụ
INSERT INTO chucvu (macv, tencv, hsphucap) VALUES
('CV01', N'Giám Đốc', 3.5),
('CV02', N'Trưởng Phòng', 2.0),
('CV03', N'Phó Phòng', 1.5),
('CV04', N'Nhân Viên', 1.0),
('CV05', N'Thực Tập Sinh', 0.5);

-- Bảng Nhân viên
INSERT INTO nhanvien (manv, holot, ten, ngaysinh, gioitinh, macv, mapb) VALUES
('NV01', N'Nguyễn Văn', N'An', '1990-05-12', N'Nam', 'CV01', 'PB01'),
('NV02', N'Trần Thị', N'Bích', '1995-08-20', N'Nữ', 'CV02', 'PB02'),
('NV03', N'Lê Văn', N'Cường', '1992-01-15', N'Nam', 'CV04', 'PB03'),
('NV04', N'Phạm Thị', N'Dung', '1998-07-10', N'Nữ', 'CV05', 'PB04'),
('NV05', N'Hoàng Văn', N'Em', '1993-03-25', N'Nam', 'CV03', 'PB05');

-- Bảng Quá trình lương
INSERT INTO quatrinhluong (manv, ngaybd, hsluong, ghichu) VALUES
('NV01', '2020-01-01', 4.5, N'Lương khởi điểm'),
('NV01', '2022-01-01', 5.0, N'Tăng lương định kỳ'),
('NV02', '2021-06-15', 3.2, N'Lương thử việc'),
('NV03', '2022-03-01', 2.8, N'Lương cơ bản'),
('NV04', '2023-01-10', 1.5, N'Lương thực tập'),
('NV05', '2021-09-01', 3.0, N'Lương ban đầu');
