CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

-- 1. EMPLOYEE Table
CREATE TABLE EMPLOYEE (
    Ssn CHAR(9) NOT NULL,
    Fname VARCHAR(15) NOT NULL,
    Minit CHAR(1) NULL,
    Lname VARCHAR(15) NOT NULL,
    Bdate DATE NULL,
    Address VARCHAR(30) NULL,
    Sex CHAR(1) NULL,
    Salary DECIMAL(10, 2) NULL,
    Super_ssn CHAR(9) NULL,
    Dno INT NULL,
    
    CONSTRAINT PK_EMPLOYEE PRIMARY KEY (Ssn),
    CONSTRAINT CHK_Employee_Salary CHECK (Salary > 0),
    CONSTRAINT CHK_Employee_Sex CHECK (Sex IN ('M', 'F'))
);

