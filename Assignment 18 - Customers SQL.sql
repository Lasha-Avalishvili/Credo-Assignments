CREATE TABLE customers (
   Id INT PRIMARY KEY,
   Name VARCHAR(255),
   City VARCHAR(255),
   Country VARCHAR(255)
);

INSERT INTO customers(Id, Name, City, Country)
VALUES (1, 'Alice', 'London', 'UK'),
       (2, 'Bob', 'New York', 'USA'),
       (3, 'Eve', 'Paris', 'France'),
       (4, 'Frank', 'Berlin', 'Germany'),
       (5, 'Grace', 'Mumbai', 'India');


SELECT Name FROM customers WHERE City IN ('London', 'Paris');

