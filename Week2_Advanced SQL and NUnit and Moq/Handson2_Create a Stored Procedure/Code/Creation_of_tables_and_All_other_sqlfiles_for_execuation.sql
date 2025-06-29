CREATE TABLE Departments(
DepartmentID INT primary Key,
DepartmentName VARCHAR(100)
);

CREATE TABLE Employees(
EmployeeID INT primary key,
FirstName varchar(50),
LastName varchar(50),
DepartmentID INT,
Salary Decimal(10,2),
JoinDate Date,
FOREIGN KEY(DepartmentID) REFERENCES Departments(DepartmentID)
);


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');

EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

EXEC sp_InsertEmployee 
    @EmployeeID = 6,
    @FirstName = 'Uttaran',
    @LastName = 'Sarkar',
    @DepartmentID = 3,
    @Salary = 55000.00,
    @JoinDate = '2025-03-29';