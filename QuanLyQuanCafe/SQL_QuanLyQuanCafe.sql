CREATE DATABASE QuanLyQuanCafe
GO
USE QuanLyQuanCafe
GO

--Food, table, foodCategory, Acount, Bill, Billinfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (20) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(30) NOT NULL DEFAULT N'Trống' , --có người/không có người
)
GO

CREATE TABLE Account
(
    UserName NVARCHAR(30) PRIMARY KEY,
	DisplayName NVARCHAR(30) NOT NULL DEFAULT N'VinhToan',
	Password NVARCHAR(20) NOT NULL DEFAULT 0,
	Type INT  NOT NULL DEFAULT 0, --1: admin, 0: user
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (20) NOT NULL,
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (50) NOT NULL,
	idCategory  INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,

	FOREIGN KEY (idCategory) REFERENCES FoodCategory(id) 
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckin DATE NOT NULL DEFAULT GETDATE(),
	DateCheckout DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 0: chua thanh toan, 1: Da thanh toan,

	FOREIGN KEY (idTable) REFERENCES TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES Food(id) 
)
INSERT INTO Account VALUES (N'vt','VinhToan','123','1')
INSERT INTO Account VALUES	(N'st','Staff','456','0')

select * from Account
select *from Account where UserName = N'vt' AND Password='123'

GO

DECLARE @i INT =0
WHILE @i <=10
BEGIN	
	INSERT TableFood (name) VALUES ( N'Bàn ' + CAST(@i AS nvarchar(30)))
	SET @i= @i + 1
END

SELECT * FROM TableFood

GO
delete from TableFood where id = '18'

CREATE PROC USP_GetTableList
AS SELECT * FROM TableFood

GO
EXEC USP_GetTableList

UPDATE TableFood SET status = N'Trống' WHERE id = 3  --bàn 2
UPDATE TableFood SET status = N' Có Người' WHERE id = 2  --bàn 1
UPDATE TableFood SET status = N' Có Người' WHERE id = 5  --bàn 4

select * from TableFood

GO

--Thêm Danh mục món ăn
INSERT INTO FoodCategory VALUES (N'Thức Ăn')
INSERT INTO FoodCategory VALUES (N'Thức Uống')

select * from FoodCategory

--Thêm Thức Ăn
INSERT INTO Food VALUES (N' Cơm Hải Sản','8','35000')
INSERT INTO Food VALUES (N' Cơm Gà','8','30000')
INSERT INTO Food VALUES (N' Cơm Sườn','8','35000')
INSERT INTO Food VALUES (N' Cơm Chiên','8','35000')
GO
--Thêm Thức Uống
INSERT INTO Food VALUES (N' Pepsi','9','35000')
INSERT INTO Food VALUES (N' Cocacola','9','30000')
INSERT INTO Food VALUES (N' 7up','9','35000')
INSERT INTO Food VALUES (N' Cà Phê Đen','9','25000')
INSERT INTO Food VALUES (N' Cà phê Sữa','9','25000')
INSERT INTO Food VALUES (N' Trà Đá','9','5000')

GO
select * from Food

--Thêm Bill
INSERT INTO Bill VALUES(GETDATE(),NULL,'2','0')
INSERT INTO Bill VALUES(GETDATE(),NULL,'5','0')
INSERT INTO Bill VALUES(GETDATE(),GETDATE(),'4','1')
INSERT INTO Bill VALUES(GETDATE(),NULL,'3','0')

GO
select * from Bill
select * from TableFood
delete from TableFood where id = 3
delete from Bill where id = 4
--Thêm Bill Info

INSERT INTO BillInfo VALUES('1','2','2')
INSERT INTO BillInfo VALUES('2','4','1')
INSERT INTO BillInfo VALUES('3','19','2')

UPDATE BillInfo SET idFood =17 where idFood=2

delete from BillInfo where idBill = 3
select * from FoodCategory
SELECT * FROM Food
SELECT * FROM BillInfo
SELECT * FROM Bill
delete from BillInfo where id =11

--SELECT * FROM Bill WHERE idTable = 2 AND status=0

--SELECT * FROM BillInfo WHERE idBill= 4

SELECT f.name,bi.count,f.price,f.price*bi.count as TotalPrice FROM BillInfo as bi, Bill as b, Food as f 
WHERE bi.idBill= b.id AND bi.idFood = f.id AND b.idTable = 2 AND b.status=0

--select * from Food where idCategory= 9
--SELECT MAX(id) FROM Bill


CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN INSERT Bill VALUES (GETDATE(), NULL, @idTable,0)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN 
	DECLARE @isExitBillInfo INT
	DECLARE @foodCount INT =1

	SELECT @isExitBillInfo = id, @foodCount = b.count 
	FROM BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	if(@isExitBillInfo >0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount >0)
		UPDATE BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
		DELETE BillInfo WHERE idBill=@idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
	INSERT BillInfo VALUES (@idBill,@idFood,@count)
	END	
END
	
GO

--select * from Food where idCategory=9

--UPDATE Bill SET status =0 WHERE id =1

DELETE Bill
DELETE BillInfo

CREATE TRIGGER UGT_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill  FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status =0

	UPDATE TableFood SET status = N'Có Người' WHERE id =@idTable

END
GO

CREATE TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = id FROM inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM Bill WHERE id = @idBill 

	DECLARE @count int =0

	SELECT @count = COUNT (*) FROM Bill WHERE  idTable =@idTable AND status =0
	
	IF(@count =0)
		UPDATE TableFood SET status= N' Trống' WHERE id = @idTable

END
GO

select * from Account where UserName = 'vt'