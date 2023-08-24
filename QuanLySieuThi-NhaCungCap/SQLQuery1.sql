use master
go
if exists (select name from sysdatabases where name='quanlyst1')
drop Database quanlyst1
go
CREATE DATABASE quanlyst1;
GO

USE quanlyst1;
GO

CREATE TABLE nhacungcap (
    mancc int IDENTITY(1,1),
    tenncc nvarchar(50) NULL,
    diachi nvarchar(50) NULL,
    sdt nvarchar(50) NULL,
    congno int NULL
);



CREATE TABLE taikhoan (
    username nvarchar(50) NOT NULL PRIMARY KEY,
    password nvarchar(50) NULL,
    fullname nvarchar(50) NULL,
    datecreate nvarchar(25) NULL,
	isAdmin int NULL

);


INSERT INTO nhacungcap (tenncc, diachi, sdt, congno) VALUES (N'VinFast', N'Hà Nội', N'01655888622', 0);
-- Thêm các dòng dữ liệu khác cho bảng nhacungcap

-- Thêm các dòng dữ liệu khác cho bảng sanpham
-- Vui lòng sửa lại ngày tháng và dữ liệu phù hợp

INSERT INTO taikhoan (username, password, fullname,datecreate,isAdmin) VALUES (N'admin', N'123', N'le sy thien',N'2023-8-30 10:55:52 PM',0);
-- Thêm các dòng dữ liệu khác cho bảng taikhoan

SET IDENTITY_INSERT nhacungcap OFF;

DROP TABLE taikhoan;

DROP TABLE nhacungcap;
select * from taikhoan

select * from nhacungcap