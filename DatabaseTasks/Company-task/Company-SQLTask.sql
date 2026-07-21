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


-- 2. DEPARTMENT Table
CREATE TABLE DEPARTMENT (
    Dname VARCHAR(25) NOT NULL,
    Dnumber INT NOT NULL,
    Mgr_ssn CHAR(9) NOT NULL,
    Mgr_start_date DATE NULL DEFAULT GETDATE(),
    
    CONSTRAINT PK_DEPARTMENT PRIMARY KEY (Dnumber),
    CONSTRAINT UQ_Department_Dname UNIQUE (Dname)
);

-- 3. DEPT_LOCATIONS Table
CREATE TABLE DEPT_LOCATIONS (
    Dnumber INT NOT NULL,
    Dlocation VARCHAR(15) NOT NULL,
    
    CONSTRAINT PK_DEPT_LOCATIONS PRIMARY KEY (Dnumber, Dlocation)
);

-- 4. PROJECT Table
CREATE TABLE PROJECT (
    Pname VARCHAR(25) NOT NULL,
    Pnumber INT NOT NULL,
    Plocation VARCHAR(15) NULL,
    Dnum INT NOT NULL,
    
    CONSTRAINT PK_PROJECT PRIMARY KEY (Pnumber),
    CONSTRAINT UQ_Project_Pname UNIQUE (Pname)
);

-- 5. WORKS_ON Table
CREATE TABLE WORKS_ON (
    Essn CHAR(9) NOT NULL,
    Pno INT NOT NULL,
    Hours DECIMAL(4, 1) NULL,
    
    CONSTRAINT PK_WORKS_ON PRIMARY KEY (Essn, Pno),
    CONSTRAINT CHK_WorksOn_Hours CHECK (Hours >= 0.0)
);

-- 6. DEPENDENT Table 
CREATE TABLE DEPENDENT (
    Essn CHAR(9) NOT NULL,
    Dependent_name VARCHAR(15) NOT NULL,
    Sex CHAR(1) NULL,
    Bdate DATE NULL,
    Relationship VARCHAR(20) NULL,
    
    CONSTRAINT PK_DEPENDENT PRIMARY KEY (Essn, Dependent_name),
    CONSTRAINT CHK_Dependent_Sex CHECK (Sex IN ('M', 'F')) 
);
GO

-- FOREIGN KEYS
-- Employee foreign keys
ALTER TABLE EMPLOYEE ADD CONSTRAINT FK_EMPLOYEE_SUPERVISION 
    FOREIGN KEY (Super_ssn) REFERENCES EMPLOYEE(Ssn) 
    ON DELETE NO ACTION;

ALTER TABLE EMPLOYEE ADD CONSTRAINT FK_EMPLOYEE_WORKS_FOR 
    FOREIGN KEY (Dno) REFERENCES DEPARTMENT(Dnumber);

-- Department foreign keys
ALTER TABLE DEPARTMENT ADD CONSTRAINT FK_DEPARTMENT_MANAGES 
    FOREIGN KEY (Mgr_ssn) REFERENCES EMPLOYEE(Ssn);

-- Dept_Locations foreign keys
ALTER TABLE DEPT_LOCATIONS ADD CONSTRAINT FK_DEPT_LOCATIONS_DEPARTMENT 
    FOREIGN KEY (Dnumber) REFERENCES DEPARTMENT(Dnumber) 
    ON DELETE CASCADE;

-- Project foreign keys
ALTER TABLE PROJECT ADD CONSTRAINT FK_PROJECT_CONTROLS 
    FOREIGN KEY (Dnum) REFERENCES DEPARTMENT(Dnumber);

-- Works_On foreign keys
ALTER TABLE WORKS_ON ADD CONSTRAINT FK_WORKS_ON_EMPLOYEE 
    FOREIGN KEY (Essn) REFERENCES EMPLOYEE(Ssn) 
    ON DELETE CASCADE;
ALTER TABLE WORKS_ON ADD CONSTRAINT FK_WORKS_ON_PROJECT 
    FOREIGN KEY (Pno) REFERENCES PROJECT(Pnumber);

-- Dependent foreign keys
ALTER TABLE DEPENDENT ADD CONSTRAINT FK_DEPENDENT_DEPENDENTS_OF 
    FOREIGN KEY (Essn) REFERENCES EMPLOYEE(Ssn) 
    ON DELETE CASCADE;
GO

-- 5 INSERT STATEMENTS
-- 1. Insert a Manager Employee
INSERT INTO EMPLOYEE (Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno)
VALUES ('99998888', 'mohammed', 'E', 'alsiyabi', '1999-11-10', 'muscat', 'M', 60000.00, NULL, NULL);

-- 2. Insert the Department 
INSERT INTO DEPARTMENT (Dname, Dnumber, Mgr_ssn, Mgr_start_date)
VALUES ('Headquarters', 1, '99887766', '2026-01-01');

-- update Dno
UPDATE EMPLOYEE SET Dno = 1 WHERE Ssn = '99998888';

-- 3. Insert a normal Employee
INSERT INTO EMPLOYEE (Ssn, Fname, Minit, Lname, Bdate, Address, Sex, Salary, Super_ssn, Dno)
VALUES ('11223344', 'omar', 'T', 'alharthi', '2000-12-08', 'muscat', 'M', 40000.00, '987654321', 1);

-- 4. Insert Dependent
INSERT INTO DEPENDENT (Essn, Dependent_name, Sex, Bdate, Relationship)
VALUES ('44556677', 'ali', 'F', '2006-04-05', 'brother');

-- 5. Insert a Project and link it via Works_On hours log
INSERT INTO PROJECT (Pname, Pnumber, Plocation, Dnum)
VALUES ('product', 11, 'muscat', 1);

INSERT INTO WORKS_ON (Essn, Pno, Hours)
VALUES ('99998888', 11, 32.5);
GO

-- 5 UPDATE STATEMENTS
-- 1. Give an employee a raise
UPDATE EMPLOYEE
SET Salary = Salary + 5000.00
WHERE Ssn = '11223344';

-- 2. Reassign an employee to a new department
INSERT INTO EMPLOYEE (Ssn, Fname, Lname, Sex, Salary)
VALUES ('55667788', 'Ali', 'Alriyami', 'M', 25000);

INSERT INTO DEPARTMENT (Dname, Dnumber, Mgr_ssn)
VALUES ('Administration', 2, '55667788');

UPDATE EMPLOYEE
SET Dno = 2
WHERE Ssn = '11223344';

-- 3. Change a project's operational location
UPDATE PROJECT
SET Plocation = 'Seeb'
WHERE Pnumber = 11;

-- 4. Update logged hours on a project
UPDATE WORKS_ON
SET Hours = 40.0
WHERE Essn = '11223344' AND Pno = 11;