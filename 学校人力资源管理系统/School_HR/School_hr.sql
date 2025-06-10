-- 创建数据库
CREATE DATABASE SchoolHR;


USE SchoolHR;


-- 创建表
-- 部门表 (Departments)
CREATE TABLE Departments (
    DepartmentID INT IDENTITY(10086,1) PRIMARY KEY,
    DepartmentName NVARCHAR(100) NOT NULL
);


-- 职位表 (Positions)
CREATE TABLE Positions (
    PositionID INT IDENTITY(110,1) PRIMARY KEY,
    PositionTitle NVARCHAR(100) NOT NULL
);


-- 员工表 (Employees)
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(2022000000,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age INT NOT NULL, -- 年龄，必填字段
    Gender NVARCHAR(10) NOT NULL, -- 性别，必填字段，建议使用 'Male'/'Female' 等
    DepartmentID INT,
    PositionID INT,
    HireDate DATE NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (PositionID) REFERENCES Positions(PositionID)
);


-- 工资表 (Salaries)
CREATE TABLE Salaries (
    SalaryID INT IDENTITY(100011,1) PRIMARY KEY,
    EmployeeID INT,
    SalaryAmount DECIMAL(10, 2) NOT NULL,
    SalaryDate DATE NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);


-- 管理员表 (Admins)
CREATE TABLE Admins (
    AdminID INT PRIMARY KEY,
    Password NVARCHAR(100) NOT NULL,
    FOREIGN KEY (AdminID) REFERENCES Employees(EmployeeID)
);


-- 插入示例数据
-- 插入部门数据
INSERT INTO Departments (DepartmentName) VALUES
('党政办公室'),
('财务处'),
('教务处'),
('学生处'),
('图书馆'),
('校工会');


-- 插入职位数据
INSERT INTO Positions (PositionTitle) VALUES
('校长'),
('院长'),
('党委书记'),
('纪委书记'),
('系主任'),
('科长'),
('辅导员');


-- 插入员工数据
INSERT INTO Employees (Name, Age, Gender, DepartmentID, PositionID, HireDate, Email) VALUES
('张三', 34, '男', 10086, 110, '2023-01-15', 'zhangsan@example.com'),
('李四', 56, '男', 10087, 111, '2023-02-20', 'lisi@example.com'),
('王五', 47, '女', 10088, 112, '2023-03-25', 'wangwu@example.com'),
('赵六', 39, '女', 10089, 113, '2023-04-10', 'zhaoliu@example.com'),
('徐七', 61, '男', 10090, 114, '2023-05-18', 'xuqi@example.com'),
('陈八', 23, '女', 10091, 115, '2023-06-22', 'chenba@example.com'),
('吴九', 51, '女', 10086, 116, '2023-07-30', 'wushijiu@example.com'),
('郑十', 43, '女', 10089, 114, '2023-08-14', 'zhengshi@example.com'),
('王十一', 28, '男', 10088, 115, '2023-09-19', 'wangshiyi@example.com'),
('李十二', 49, '女', 10090, 116, '2023-10-21', 'lishier@example.com');


-- 插入工资数据
INSERT INTO Salaries (EmployeeID, SalaryAmount, SalaryDate) VALUES
(2022000000, 5000.00, '2024-04-30'),
(2022000001, 4500.00, '2024-04-30'),
(2022000002, 6000.00, '2024-04-30'),
(2022000003, 5500.00, '2024-04-30'),
(2022000004, 4800.00, '2024-04-30'),
(2022000005, 5200.00, '2024-04-30'),
(2022000006, 5000.00, '2024-04-30'),
(2022000007, 5900.00, '2024-04-30'),
(2022000008, 4700.00, '2024-04-30'),
(2022000009, 5300.00, '2024-04-30');


-- 插入管理员数据
-- 请注意，此处的密码应使用适当的哈希函数在实际应用中进行哈希处理
INSERT INTO Admins (AdminID, Password) VALUES
(2022000000, 'admin123'),
(2022000002, 'admin456');


-- 创建触发器
CREATE TRIGGER trg_DeleteDepartment
ON Departments
INSTEAD OF DELETE
AS
BEGIN
    -- 将 Employees 表中对应的 DepartmentID 置空
    UPDATE Employees
    SET DepartmentID = NULL
    WHERE DepartmentID IN (SELECT DepartmentID FROM deleted);

    -- 删除 Departments 表中的记录
    DELETE FROM Departments
    WHERE DepartmentID IN (SELECT DepartmentID FROM deleted);
END;


CREATE TRIGGER trg_DeletePosition
ON Positions
INSTEAD OF DELETE
AS
BEGIN
    -- 将 Employees 表中对应的 PositionID 置空
    UPDATE Employees
    SET PositionID = NULL
    WHERE PositionID IN (SELECT PositionID FROM deleted);

    -- 删除 Positions 表中的记录
    DELETE FROM Positions
    WHERE PositionID IN (SELECT PositionID FROM deleted);
END;


-- 查看所有数据
SELECT * FROM Admins;
SELECT * FROM Departments;
SELECT * FROM Employees;
SELECT * FROM Positions;
SELECT * FROM Salaries;











--delete from Departments where DepartmentID=7; 
--delete  from Employees where EmployeeID=11;

--SET IDENTITY_INSERT positions ON;
--SET IDENTITY_INSERT salaries ON;
--SET IDENTITY_INSERT employees ON;
--SET IDENTITY_INSERT departments ON;








--SET IDENTITY_INSERT positions off;
--SET IDENTITY_INSERT salaries off;




--string sql = $"UPDATE salaries  SET " +
--$"employeeid = '{int.Parse(textupdateemployeeid.Text)}', " +
--$"salarymount={float.Parse(textupdatesalaryamount.Text)}," +
--$"salarydate={datesalaryupdate.Value} " +
--$"WHERE salaryid ='{int.Parse(Formsalarychange.salid.ToString())}'; ";