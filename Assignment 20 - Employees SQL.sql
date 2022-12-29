CREATE TABLE Employees (
   Id INT PRIMARY KEY,
   Name VARCHAR(255),
   Salary INT,
   Department VARCHAR(255)
);

INSERT INTO Employees (Id, Name, Salary, Department)
VALUES (1, 'John', 1000, 'Sales'),
       (2, 'Jane', 1200, 'Marketing'),
       (3, 'Bill', 1500, 'Engineering'),
       (4, 'Rachel', 1200, 'Marketing'),
       (5, 'Steve', 1000, 'Sales');


SELECT Department, AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY Department;