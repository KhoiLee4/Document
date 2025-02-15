# SQL SERVER

> Doc này sử dụng 

## 🤔Cơ sở dữ liệu quan hệ là gì?

**Cơ sở dữ liệu quan hệ (Relational Database Management System - RDBMS)** là một hệ quản trị cơ sở dữ liệu sử dụng mô hình quan hệ để lưu trữ và quản lý dữ liệu. Trong đó:

- Dữ liệu được tổ chức thành bảng (table) gồm hàng (record) và cột (field).
- Các bảng có thể liên kết với nhau thông qua khóa chính (Primary Key) và khóa ngoại (Foreign Key).
- Sử dụng SQL (Structured Query Language) để truy vấn, thao tác dữ liệu.

**Microsoft SQL Server** là một hệ quản trị cơ sở dữ liệu quan hệ (RDBMS) mạnh mẽ do Microsoft phát triển. Nó hỗ trợ nhiều tính năng như:

- Quản lý và lưu trữ dữ liệu hiệu quả.
- Hỗ trợ truy vấn SQL chuẩn và mở rộng với T-SQL.
- Hỗ trợ giao dịch (ACID), bảo mật và sao lưu dữ liệu.
- Tích hợp tốt với hệ sinh thái .NET (C#, WinForms, ASP.NET, ADO.NET, Entity Framework).


| Phiên bản  | Đặc điểm                                                                                      | Hạn chế                                          |
| ---------- | --------------------------------------------------------------------------------------------- | ------------------------------------------------ |
| Express    | Miễn phí, phù hợp học tập, cá nhân, ứng dụng nhỏ.                                             | Bị giới hạn CPU, RAM (chỉ 1 CPU, 10GB DB).       |
| Standard   | Dành cho doanh nghiệp vừa và nhỏ, hỗ trợ nhiều tính năng hơn.                                 | Không có một số tính năng cao cấp như Always On. |
| Enterprise | Phiên bản đầy đủ, dành cho doanh nghiệp lớn, hỗ trợ AI, Big Data, Always On, bảo mật cao cấp. | Giá đắt, yêu cầu cấu hình mạnh.                  |

## 🤔Cài đặt SQL Server và SQL Server Management Studio (SSMS).
Các công cụ quản lý khác như Azure Data Studio.

## 🤔Làm việc với SQL Server Management Studio (SSMS)
Kết nối SQL Server, tạo và quản lý cơ sở dữ liệu.
Cách sử dụng Query Editor trong SSMS.

## 📚CREATE DATABASE, DROP DATABASE

Lệnh `CREATE DATABASE` dùng để tạo một cơ sở dữ liệu mới trong SQL Server.

```SQL
CREATE DATABASE DatabaseName;
```

Lệnh `DROP DATABASE` dùng để xóa hoàn toàn một cơ sở dữ liệu (không thể khôi phục nếu chưa sao lưu).

```SQL
DROP DATABASE DatabaseName;
```

*❗Lưu ý:*

- Cơ sở dữ liệu không thể xóa nếu có kết nối đang sử dụng nó.

- Có thể kiểm tra phiên kết nối

```SQL
SELECT * FROM sys.sysprocesses WHERE dbid = DB_ID('LibraryDB');
```

- Nếu cần xóa ngay cả khi có kết nối, phải đặt cơ sở dữ liệu ở chế độ `single-user` trước khi xóa

```SQL
ALTER DATABASE LibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE LibraryDB;
```

## 📚CREATE TABLE, ALTER TABLE, DROP TABLE

Lệnh `CREATE TABLE` dùng để tạo một bảng mới trong cơ sở dữ liệu.

```SQL
CREATE TABLE TableName (
    Column1 DataType Constraints,
    Column2 DataType Constraints,
    ...
);
```

```SQL
CREATE TABLE Books (
    BookID INT PRIMARY KEY,       -- Mã sách (khóa chính)
    Title NVARCHAR(255) NOT NULL, -- Tiêu đề sách
    Author NVARCHAR(100),         -- Tác giả
    PublishedYear INT,            -- Năm xuất bản
    Price DECIMAL(10,2)           -- Giá sách
);
```

Lệnh `ALTER TABLE` dùng để thay đổi cấu trúc của bảng như thêm, sửa, hoặc xóa cột.

- Thêm cột (ADD COLUMN)

```SQL
ALTER TABLE Books ADD Publisher NVARCHAR(100);
```

- Sửa kiểu dữ liệu cột (ALTER COLUMN)

```SQL
ALTER TABLE Books ALTER COLUMN Price FLOAT;
```

- Xóa cột (DROP COLUMN)

```SQL
ALTER TABLE Books DROP COLUMN Publisher;
```

- Thêm khóa ngoại (ADD CONSTRAINT)

```SQL
ALTER TABLE Books ADD CONSTRAINT FK_Books_Categories FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID);
```

Lệnh `DROP TABLE` dùng để xóa hoàn toàn một bảng khỏi cơ sở dữ liệu.

```SQL
DROP TABLE TableName;
```

*❗Lưu ý:*
- Khi bảng bị xóa, toàn bộ dữ liệu trong bảng cũng bị mất.
- Nếu bảng có khóa ngoại liên kết với bảng khác, cần xóa khóa ngoại trước.

## 📚INSERT

Lệnh `INSERT INTO` được sử dụng để thêm dữ liệu vào bảng trong SQL Server.

Có hai cách sử dụng `INSERT INTO`:

- Chèn dữ liệu vào tất cả các cột

```SQL
INSERT INTO TableName
VALUES (value1, value2, value3, ...);
```

*❗Số lượng giá trị phải đúng với số cột trong bảng.*

*❗Giá trị phải đúng kiểu dữ liệu của từng cột.*

```SQL
INSERT INTO Books
VALUES (1, 'Clean Code', 'Robert C. Martin', 2008, 29.99);
```

- Chỉ định cột cụ thể khi chèn dữ liệu

```SQL
INSERT INTO TableName (Column1, Column2, ...)
VALUES (value1, value2, ...);
```

*❗Chỉ cần nhập dữ liệu cho những cột được chỉ định, những cột không khai báo sẽ nhận giá trị mặc định hoặc NULL.*

```SQL
INSERT INTO Books (BookID, Title, Author, PublishedYear)
VALUES (2, 'The Pragmatic Programmer', 'Andy Hunt', 1999);
```

- Chèn nhiều hàng cùng lúc

```SQL
INSERT INTO Books (BookID, Title, Author, PublishedYear, Price)
VALUES 
    (3, 'Design Patterns', 'Erich Gamma', 1994, 35.99),
    (4, 'Refactoring', 'Martin Fowler', 1999, 40.50);
```

*❗Lưu ý quan trọng khi sử dụng `INSERT INTO`*
- Đảm bảo kiểu dữ liệu đúng với định nghĩa cột trong bảng.
- Tránh lỗi khóa chính (`PRIMARY KEY`) trùng lặp.
- Nếu bảng có khóa ngoại (`FOREIGN KEY`), cần đảm bảo giá trị đã tồn tại ở bảng cha.

## 📚UPDATE

Lệnh `UPDATE` dùng để thay đổi dữ liệu của một hoặc nhiều hàng trong bảng.

```SQL
UPDATE TableName
SET Column1 = Value1, Column2 = Value2, ...
WHERE Condition;
```

*❗Lưu ý:*
- Bỏ `WHERE` sẽ cập nhật tất cả các hàng trong bảng!
- Giá trị phải đúng với kiểu dữ liệu của cột.

Ví dụ: Cập nhật giá sách có BookID = 1 lên 32.99

```SQL
UPDATE Books
SET Price = 32.99
WHERE BookID = 1;
```

## 📚DELETE

Lệnh `DELETE` dùng để xóa một hoặc nhiều dòng dữ liệu khỏi bảng.

```SQL
DELETE FROM TableName
WHERE Condition;
```

*❗Lưu ý:*
- Bỏ `WHERE` sẽ xóa toàn bộ bảng!
- Nếu bảng có khóa ngoại, cần kiểm tra ràng buộc trước khi xóa.

Ví dụ: Xóa sách có BookID = 3

```SQL
DELETE FROM Books
WHERE BookID = 3;
```

Lệnh `TRUNCATE` dùng để xoá toàn bộ dữ liệu trong bảng nhưng giữ nguyên cấu trúc bảng

```SQL
TRUNCATE TABLE TableName;
```

Ví dụ: Xóa toàn bộ dữ liệu trong bảng nhưng giữ cấu trúc

```SQL
TRUNCATE TABLE Books;
```

| Lệnh     | Chức năng                      | Có thể rollback?          | Tốc độ                              |
| -------- | ------------------------------ | ------------------------- | ----------------------------------- |
| DELETE   | Xóa từng dòng theo điều kiện   | Có (nếu dùng TRANSACTION) | Chậm hơn (ghi log từng dòng)        |
| TRUNCATE | Xóa toàn bộ dữ liệu trong bảng | Không thể rollback        | Nhanh hơn (reset bảng ngay lập tức) |

## 📚SELECT

Lệnh `SELECT` trong SQL Server được sử dụng để truy vấn dữ liệu từ một hoặc nhiều bảng trong cơ sở dữ liệu. Nó là một trong những câu lệnh quan trọng nhất trong SQL.

```SQL
SELECT column1, column2, ...
FROM table_name;
```

Lấy tất cả dữ liệu từ bảng: Dấu `*` có nghĩa là lấy tất cả các cột

```SQL
SELECT * 
FROM Products;
```

Lấy dữ liệu của một số cột cụ thể

```SQL
SELECT ProductID, ProductName, UnitPrice 
FROM Products;
```

Lấy dữ liệu không trùng lặp với `DISTINCT`

```SQL
SELECT DISTINCT ProductName 
FROM Products;
```

Giới hạn số lượng kết quả với `TOP`

```SQL
SELECT TOP 5 * 
FROM Customers;
```

```SQL
SELECT TOP 30 PERCENT * 
FROM Customers;
```

Đặt tên thay thế cho cột/bảng với AS (ALIAS)

```SQL
SELECT 
    NV.LastName AS [Họ nhân viên], 
    NV.FirstName AS "Tên nhân viên", 
    NV.BirthDate "Ngày sinh" 
FROM Emplosees AS [NV];
```

## 📚Nhóm hàm tổng hợp (Aggregate Functions)

**Nhóm hàm tổng hợp (Aggregate Functions)** được dùng để thực hiện các phép tính trên tập dữ liệu và trả về một giá trị duy nhất. Các hàm này thường được sử dụng trong mệnh đề `SELECT` kết hợp với `GROUP BY`.

Có thể sử dụng nhiều hàm tổng hợp cùng một lúc.

```SQL
SELECT 
    COUNT(*) AS TotalOrders, 
    SUM(OrderAmount) AS TotalSales, 
    AVG(OrderAmount) AS AverageOrderValue, 
    MAX(OrderAmount) AS LargestOrder, 
    MIN(OrderAmount) AS SmallestOrder
FROM Orders;
```

### 📙COUNT() – Đếm số dòng

Dùng để đếm số lượng dòng hoặc số giá trị khác `NULL` trong một cột.

Đếm tổng số khách hàng

```SQL
SELECT COUNT(*) AS TotalCustomers 
FROM Customers;
```

Đếm số lượng khách hàng có email

```SQL
SELECT COUNT(Email) AS CustomersWithEmail 
FROM Customers;
```

### 📙SUM() – Tính tổng

Dùng để tính tổng giá trị của một cột số.

Tính tổng giá trị đơn hàng

```SQL
SELECT SUM(OrderAmount) AS TotalSales 
FROM Orders;
```

Tính tổng tiền khách hàng có ID = 5 đã chi tiêu

```SQL
SELECT SUM(OrderAmount) AS TotalSpent 
FROM Orders 
WHERE CustomerID = 5;
```

### 📙AVG() – Tính trung bình

Dùng để tính giá trị trung bình của một cột số.

Tính giá trị trung bình của đơn hàng

```SQL
SELECT AVG(OrderAmount) AS AverageOrderValue 
FROM Orders;
```

Tính trung bình giá của sản phẩm trong danh mục "Electronics"

```SQL
SELECT AVG(Price) AS AvgPrice 
FROM Products 
WHERE Category = 'Electronics';
```

### 📙MAX() – Giá trị lớn nhất

Dùng để tìm giá trị lớn nhất trong một cột.

Tìm giá trị đơn hàng lớn nhất

```SQL
SELECT MAX(OrderAmount) AS HighestOrder 
FROM Orders;
```

Tìm sản phẩm có giá cao nhất

```SQL
SELECT MAX(Price) AS MostExpensiveProduct 
FROM Products;
```

### 📙MIN() – Giá trị nhỏ nhất

Dùng để tìm giá trị nhỏ nhất trong một cột.

Tìm giá trị đơn hàng nhỏ nhất

```SQL
SELECT MIN(OrderAmount) AS LowestOrder 
FROM Orders;
```

Tìm sản phẩm có giá thấp nhất

```SQL
SELECT MIN(Price) AS CheapestProduct 
FROM Products;
```

## 📚WHERE

Lệnh `WHERE` dùng để lọc dữ liệu trong các câu lệnh SQL như `SELECT`, `UPDATE`, `DELETE`.

```SQL
SELECT column1, column2, ...
FROM TableName
WHERE condition;
```

Các toán tử thường dùng trong `WHERE`

| Toán tử        | Ý nghĩa               | Ví dụ                            |
| -------------- | --------------------- | -------------------------------- |
| `=`            | Bằng                  | `Price = 50`                     |
| `<>` hoặc `!=` | Khác                  | `Price <> 50`                    |
| `>`            | Lớn hơn               | `Price > 50`                     |
| `<`            | Nhỏ hơn               | `Price < 50`                     |
| `>=`           | Lớn hơn hoặc bằng     | `Price >= 50`                    |
| `<=`           | Nhỏ hơn hoặc bằng     | `Price <= 50`                    |
| `BETWEEN`      | Trong khoảng          | `Price BETWEEN 30 AND 60`        |
| `IN`           | Nằm trong danh sách   | `Author IN ('Ayase', 'YOASOBI')` |
| `LIKE`         | Tìm kiếm theo mẫu     | `Title LIKE '%Code%'`            |
| `IS NULL`      | Kiểm tra giá trị rỗng | `Price IS NULL`                  |

Tìm sách có giá lớn hơn 30

```SQL
SELECT * FROM Books
WHERE Price > 30;
```

Tìm sách của tác giả "Robert C. Martin"

```SQL
SELECT * FROM Books
WHERE Author = 'Robert C. Martin';
```

Tìm sách xuất bản trong khoảng năm 2000 - 2010

```SQL
SELECT * FROM Books
WHERE PublishedYear BETWEEN 2000 AND 2010;
```

Tìm sách có chữ "Code" trong tiêu đề

```SQL
SELECT * FROM Books
WHERE Title LIKE '%Code%';
```

## 📚ORDER BY

## 📚GROUP BY

## 📚HAVING.

## 📚Các kiểu dữ liệu trong SQL Server

### 📙Kiểu số (Numeric Data Types)

Dùng để lưu trữ số nguyên hoặc số thực.

| Kiểu dữ liệu                         | Kích thước    | Phạm vi giá trị                                            |
| ------------------------------------ | ------------- | ---------------------------------------------------------- |
| `TINYINT`                            | 1 byte        | 0 đến 255                                                  |
| `SMALLINT`                           | 2 byte        | -32,768 đến 32,767                                         |
| `INT`                                | 4 byte        | -2,147,483,648 đến 2,147,483,647                           |
| `BIGINT`                             | 8 byte        | -9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807   |
| `DECIMAL(p, s)` hoặc `NUMERIC(p, s)` | Biến đổi      | Lưu số thập phân với `p` chữ số và `s` chữ số sau dấu chấm |
| `FLOAT`                              | 4 hoặc 8 byte | Lưu số thực dấu chấm động                                  |
| `REAL`                               | 4 byte        | Nhỏ hơn `FLOAT`, độ chính xác thấp hơn                     |


### 📙Kiểu chuỗi (Character Data Types)

Dùng để lưu trữ văn bản, tên, mô tả.

| Kiểu dữ liệu  | Độ dài tối đa   | Đặc điểm                                |
| ------------- | --------------- | --------------------------------------- |
| `CHAR(n)`     | 1 - 8,000 ký tự | Chuỗi có độ dài cố định                 |
| `VARCHAR(n)`  | 1 - 8,000 ký tự | Chuỗi có độ dài thay đổi                |
| `TEXT`        | 2GB             | Không còn được khuyến nghị (deprecated) |
| `NCHAR(n)`    | 1 - 4,000 ký tự | Lưu chuỗi Unicode (có dấu)              |
| `NVARCHAR(n)` | 1 - 4,000 ký tự | Lưu chuỗi Unicode thay đổi              |
| `NTEXT`       | 2GB             | Không còn được khuyến nghị (deprecated) |


### 📙Kiểu ngày giờ (Date and Time Data Types)

Dùng để lưu trữ ngày, giờ.

| Kiểu dữ liệu     | Kích thước | Phạm vi giá trị                                     |
| ---------------- | ---------- | --------------------------------------------------- |
| `DATE`           | 3 byte     | 0001-01-01 đến 9999-12-31                           |
| `TIME`           | 3-5 byte   | 00:00:00.0000000 đến 23:59:59.9999999               |
| `DATETIME`       | 8 byte     | 1753-01-01 đến 9999-12-31                           |
| `SMALLDATETIME`  | 4 byte     | 1900-01-01 đến 2079-06-06                           |
| `DATETIME2`      | 6-8 byte   | 0001-01-01 đến 9999-12-31, chính xác hơn `DATETIME` |
| `DATETIMEOFFSET` | 10 byte    | Giống `DATETIME2` nhưng có múi giờ                  |

### 📙Kiểu logic (Boolean - Bit Data Type)

Dùng để lưu TRUE / FALSE (1 / 0).

| Kiểu dữ liệu | Kích thước | Giá trị             |
| ------------ | ---------- | ------------------- |
| `BIT`        | 1 bit      | 0 (False), 1 (True) |


### 📙Kiểu nhị phân (Binary Data Types)

Dùng để lưu trữ dữ liệu nhị phân (hình ảnh, file, v.v.).

| Kiểu dữ liệu     | Kích thước tối đa | Đặc điểm                     |
| ---------------- | ----------------- | ---------------------------- |
| `BINARY(n)`      | 1 - 8,000 byte    | Chuỗi nhị phân cố định       |
| `VARBINARY(n)`   | 1 - 8,000 byte    | Chuỗi nhị phân thay đổi      |
| `VARBINARY(MAX)` | 2GB               | Lưu trữ file, hình ảnh, v.v. |

### 📙Kiểu dữ liệu đặc biệt

Ngoài các kiểu phổ biến, SQL Server còn có kiểu dữ liệu đặc biệt:

| Kiểu dữ liệu           | Mô tả                           |
| ---------------------- | ------------------------------- |
| `UNIQUEIDENTIFIER`     | Lưu UUID (GUID)                 |
| `XML`                  | Lưu trữ dữ liệu XML             |
| `JSON` (dùng NVARCHAR) | Lưu JSON dưới dạng chuỗi        |
| `CURSOR`               | Dùng để duyệt từng dòng dữ liệu |
| `TABLE`                | Dùng để lưu trữ bảng tạm thời   |

## 📚PRIMARY KEY
## 📚FOREIGN KEY
## 📚UNIQUE
## 📚CHECK
## 📚DEFAULT

## 📚Mối quan hệ 1-1, 1-n, n-n.

## 📚INNER JOIN
## 📚LEFT JOIN
## 📚RIGHT JOIN
## 📚FULL JOIN.
## 📚UNION
## 📚INTERSECT
## 📚EXCEPT.

## 📚CLUSTERED INDEX vs. NONCLUSTERED INDEX.
## 📚Khi nào nên sử dụng chỉ mục?

## 📚CREATE PROCEDURE, EXEC để tạo và gọi stored procedure.
## 📚CREATE FUNCTION, RETURNS TABLE để tạo function.
## 📚CREATE VIEW để tạo view và tối ưu truy vấn.

## 📚CREATE TRIGGER để tự động hóa nghiệp vụ.
## 📚BEGIN TRANSACTION, COMMIT, ROLLBACK để đảm bảo tính toàn vẹn dữ liệu.

## 📚GRANT, REVOKE, DENY.
## 📚Tạo tài khoản user, phân quyền truy cập dữ liệu.

## 📚Phân tích Execution Plan.
## 📚Indexing strategy để tăng tốc truy vấn.
## 📚Caching và tối ưu hóa bộ nhớ.

## 📚Cấu hình SQL Server, quản lý kết nối.
## 📚Sao lưu (BACKUP DATABASE) và khôi phục dữ liệu (RESTORE DATABASE).
## 📚Giám sát hiệu suất với SQL Profiler và Activity Monitor.

## 📚Kết nối SQL Server trong WinForms bằng ADO.NET hoặc Entity Framework.
## 📚Viết API để thao tác dữ liệu từ ứng dụng.
## 📚Thực hiện CRUD (Create, Read, Update, Delete) từ ứng dụng WinForms.















