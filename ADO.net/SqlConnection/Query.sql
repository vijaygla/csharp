CREATE DATABASE SqlConnection;
GO
USE SqlConnection;

DROP TABLE if EXISTS Employees;
CREATE TABLE Employees
(
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100),
    Salary DECIMAL(10,2)
);
