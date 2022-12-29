DROP TABLE Orders;

CREATE TABLE Orders (
Id INT PRIMARY KEY,
CustomerId INT,
ProductName VARCHAR(255),
Quantity INT
);

INSERT INTO Orders(Id, CustomerId, ProductName, Quantity)
VALUES (1, 1, 'Phone', 2),
       (2,1,'Tablet',1),
	   (3,2,'Laptop',3),
	   (4,3,'Smartwatch',1),
	   (5,4,'Headphones',2),
	   (6,5,'Speaker',1);

SELECT Customers.Name, SUM(Orders.Quantity) AS TotalProducts
FROM Customers
INNER JOIN Orders ON Customers.Id = Orders.CustomerId
GROUP BY Customers.Name
