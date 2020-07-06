--=====1.1 Creating a database ====

-- CREATE DATABASE Bryn;
-- USE Bryn;

-- CREATE TABLE film_table
-- (
--     Film_name VARCHAR(10)
--     ,Film_type VARCHAR(6)
-- );

--==Displays table in results
-- SP_HELP film_table;

--- ==Delete a table==
--DROP TABLE film_table;

--== Create a table ==
-- DROP TABLE film_table;

-- CREATE TABLE film_table
-- (
--     Film_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--     ,Film_name VARCHAR(50) NOT NULL
--     ,Film_type VARCHAR(30)
--     ,Date_of_release DATE
--     ,Director VARCHAR(30)
--     ,Writer VARCHAR(50)
--     ,Star VARCHAR(50)
--     ,Film_language VARCHAR(15)
--     ,Official_website VARCHAR(MAX)
--     ,plot_summary VARCHAR(MAX)
-- );

-- Populate a table
-- INSERT INTO film_table
-- (
-- Film_name
-- ,Film_type
-- ,Date_of_release
-- ,Director
-- ,Writer
-- ,Star
-- ,Film_language
-- ,Official_website
-- ,plot_summary
-- )
-- VALUES
-- (
-- 'Across the Universe',
-- 'Musical',
-- '2007-09-14',
-- 'Julie Taymor',
-- 'Dick Clement & Ian La Frenais',
-- 'Evan Rachel Wood',
-- 'English',
-- 'www.sonypictures.com',
-- 'The songs of the Beatles provide the sonic framework for this musical tale of romance, war and peace. When young British worker Jude (Jim Sturgess) sets sail for the United States in search of his father, he ends up meeting carefree college student Max (Joe Anderson) and his lovely sister, Lucy (Evan Rachel Wood), along with a cast of eccentric characters. As Jude and Lucy fall for each other, their relationship is threatened by the social upheaval that accompanies the Vietnam War.'
-- )
-- === Change all values with the same value to another value
-- UPDATE film_table
-- SET Film_type= "Romance"
-- Where Film_type= "Musical"

-- DROP TABLE Video_games
-- DROP TABLE Video_game_developers

-- CREATE TABLE Video_games
-- (
-- VideoGamesID INT IDENTITY (1,1) PRIMARY KEY NOT NULL
-- ,VideoGameName VARCHAR(30)
-- ,Rating INTEGER
-- )

-- CREATE TABLE Video_game_developers
-- (
--     DeveloperID INT IDENTITY (1,1) PRIMARY KEY NOT NULL
--     ,DeveloperName VARCHAR(30)
--     ,HQ VARCHAR (20)
-- )

-- ALTER TABLE Video_games
-- ADD DeveloperID INT,
-- FOREIGN KEY(DeveloperID) REFERENCES Video_game_developers(DeveloperID);

-- UPDATE Video_games
-- Set DeveloperID =1 
-- Where VideoGamesID =1 OR VideoGamesID = 2;

-- SELECT * FROM Customers
-- Where City = 'Paris'

--SELECT * FROM Products
--WHERE UnitPrice <5

--SELECT * FROM Categories
--WHERE CategoryName LIKE '[BS]%';

--SELECT COUNT(*) AS 'Number of Orders'
--FROM Orders
----WHERE EmployeeID = 5 OR EmployeeID = 7
--WHERE EmployeeID IN (5,7)

--SELECT * FROM Categories
--WHERE CategoryName LIKE '[A-P]%'

--SELECT CompanyName AS 'Company Name',
--	City +', ' + Country AS City
--FROM Customers

--SELECT FirstName + ' ' + LastName +': ' + HomePhone AS 'Employee Name and Contact Number'
--FROM Employees

--SELECT CompanyName AS 'Company Name', 
--City + ', ' + Country AS City
--FROM Customers
--Where Region IS NULL

--SELECT * FROM Customers
--WHERE Region IS NOT NULL

--SELECT DISTINCT Country
--FROM Customers
--WHERE Region IS NOT NULL

--SELECT UnitPrice, Quantity, Discount
--,UnitPrice * Quantity  AS 'Gross Total'
--,UnitPrice * Quantity * (1-Discount) AS 'Net Total'
--From [Order Details]
--ORDER BY 'Net Total', 'Gross Total' DESC

--SELECT TOP(2) UnitPrice, Quantity, Discount
--,UnitPrice * Quantity  AS 'Gross Total'
--,UnitPrice * Quantity * (1-Discount) AS 'Net Total'
--From [Order Details]
--ORDER BY 'Gross Total' DESC 

--SELECT SUBSTRING ('alex',2,3)

--SELECT CHARINDEX('ry', 'Harry')

--SELECT LEFT('Chen', 3)

--SELECT RIGHT ('Christian' , 3)

--SELECT LTRIM('                     Bruno')

--SELECT RTRIM('                     Bruno')

--SELECT REPLACE('Nishint', 'i', 'a')

--SELECT UPPER('leo')
--SELECT LOWER('LEO')

--SELECT LEN('Sparta')

--SELECT PostalCode AS "Post Code",
--LEFT(PostalCode, CHARINDEX(' ' , PostalCode)-1) AS 'Post Code Region'
--,CHARINDEX(' ', PostalCode) AS 'Space Found'
--, Country
--FROM Customers
--WHERE Country = 'UK'

--SELECT * FROM Products
-- WHERE (ProductName LIKE '%''%')

 --SELECT ProductName
 --FROM Products
 --WHERE CHARINDEX('''', Product) > 0

 --SELECT GETDATE()
 --SELECT SYSDATETIME();

 --DATEADD(dd,5,OrderDate) AS "DUE DATE"

 --SELECT DATEADD(dd,5,GETDATE())
 --SELECT DATEADD(mm,5,GETDATE())
 --SELECT DATEADD(yyyy,5,GETDATE())

 --SELECT DATEDIFF(dd,OrderDate, ShippedDate) AS "Ship time"

 --SELECT DATEDIFF(dd, '2021-05-05', '2020-05-06')
 
 --SELECT
 --OrderDate
 --, DAY (OrderDate)
 --, MONTH(OrderDate)
 --, YEAR(OrderDate)

 --FROM Orders;

 --SELECT
 --FORMAT(OrderDate, 'dd/MM/yyyy')

 --FROM Orders;

 --SELECT FORMAT(GETDATE(), 'dd/MM/yyyy')

--SELECT FirstName + ' ' + LastName  AS 'Employee Name'
--,FLOOR(DATEDIFF(dd, BirthDate,GETDATE()) / 365.25) AS 'Age'
--FROM Employees

--SELECT
--CASE
--WHEN DATEDIFF(d,OrderDate,ShippedDate) < 10 THEN 'On Time'
--ELSE 'Overdue'
--END 
--AS 'Status'
--FROM Orders

--SELECT
--CASE
--WHEN FLOOR(DATEDIFF(dd, BirthDate,GETDATE()) / 365.25) >= 65 THEN 'Retired'
--WHEN FLOOR(DATEDIFF(dd, BirthDate,GETDATE()) / 365.25) >= 60 THEN'Retirement Due'
--ELSE 'More than 5 years to go'
--END
--AS 'Status'
--FROM Employees

--SELECT SUM(UnitsOnOrder) AS "Total on Order",
--AVG(UnitsOnOrder) AS "Avg On Order",
--MIN(UnitsOnOrder) AS "Min On Order",
--MAX(UnitsOnOrder) AS "Max On Order"
--FROM Products

--SELECT SupplierID,
--SUM(UnitsOnOrder) AS 'Total On Order',
--AVG(UnitsOnOrder) AS 'Avg On Order',
--MAX(UnitsOnOrder) AS 'Max On Order'
--FROM Products
--GROUP BY SupplierID


--SELECT CategoryID,
--AVG(ReorderLevel) AS "Avg On Order"
--FROM Products
--GROUP BY CategoryID
--ORDER BY "Avg On Order" DESC

--SELECT SupplierID,
--SUM(UnitsOnOrder) AS "Total On Order",
--AVG(UnitsOnOrder) AS "Avg On Order"
--FROM Products
--GROUP BY SupplierID
--HAVING AVG(UnitsOnOrder)>5
 
--SELECT e.EmployeeID, e.FirstName, e.LastName,
--COUNT(TerritoryID) AS "Number of Territories covered"
--FROM EmployeeTerritories et
--INNER JOIN Employees e
--ON e.EmployeeID = et.EmployeeID
--GROUP BY e.EmployeeID, e.FirstName, E.LastName
--HAVING COUNT(TerritoryID) > 5

--SELECT s.SupplierID, s.CompanyName,
--AVG(p.UnitsOnOrder) AS "Avg On Order"
--FROM Products p
--INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--GROUP BY s.SupplierID, s.CompanyName
--HAVING AVG(p.UnitsOnOrder) >0
--ORDER BY "Avg On Order" DESC

--SELECT ProductName, UnitPrice, CompanyName AS 'Supplier',
--CategoryName As 'Category'
--FROM Products p
--INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--INNER JOIN Categories c ON p.CategoryID = c.CategoryID

--SELECT o.OrderID, o.OrderDate, o.Freight, c.CompanyName,
--e.FirstName + ' ' + e.LastName AS "Employee Name"
--FROM Orders o
--INNER JOIN Customers c ON c.CustomerID = o.CustomerID
--INNER JOIN Employees e ON e.EmployeeID = o.EmployeeID

--SELECT CompanyName AS "Customer"
--FROM Customers
--WHERE CustomerID NOT IN
--	(SELECT CustomerID FROM Orders)

--SELECT CompanyName AS "Customer", o.OrderID
--FROM Customers c
--LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
--WHERE o.OrderID IS NULL

--SELECT OrderID, ProductID, UnitPrice, Quantity, Discount,
--(SELECT MAX(UnitPrice) FROM [Order Details] od) AS "Max Price"
--FROM [Order Details]

--SELECT od.ProductID, sq1.totalamt AS "Total Sold for this Product", 
--UnitPrice, UnitPrice/totalamt*100 AS "% of Total"
--    FROM [Order Details] od
--    INNER JOIN 
--        (SELECT ProductID, SUM(UnitPrice*Quantity) AS totalamt
--        FROM [Order Details]
--        GROUP BY ProductID) sq1 ON sq1.ProductID=od.ProductID

--SELECT EmployeeID AS "Employee/Supplier"
--FROM Employees
--UNION ALL
--SELECT SupplierID
--FROM Suppliers

--select e.employeeid, e.FirstName from employees e
--union 
--select s.supplierid, s.CompanyName from suppliers s

--SELECT o.OrderID, o.ProductID, o.UnitPrice, o.Quantity, o.Discount
--FROM [Order Details] o
--WHERE o.ProductID IN (SELECT ProductID FROM Products WHERE Discontinued=1)

--SELECT o.OrderID, o.ProductID, o.UnitPrice, o.Quantity, o.Discount
--FROM  [Order Details] o
--INNER JOIN Products p ON p.ProductID = o.ProductID
--WHERE p.Discontinued = 1