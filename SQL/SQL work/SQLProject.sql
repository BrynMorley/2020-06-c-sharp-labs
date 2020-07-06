--1.1
--SELECT CustomerID, CompanyName, Address + ', ' + City + ', ' + PostalCode + ', ' + Country AS "Address"
--FROM Customers
--WHERE City = 'Paris' OR  City ='London'

--1.2 & 1.3
--SELECT p.ProductName, s.CompanyName, s.Country
--FROM Products p
--INNER JOIN Suppliers s ON s.SupplierID = p.SupplierID
--WHERE QuantityPerUnit LIKE '%bottle'

--1.4
--SELECT c.CategoryName, COUNT(*) AS "Products in Category"
--FROM Products p
--JOIN Categories c ON p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName
--ORDER BY "Products in Category" DESC

--1.5
--SELECT  TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS "Full Name"
--, City
--FROM Employees
--WHERE Country = 'UK'

--1.6
--SELECT FORMAT(SUM(od.Quantity* od.UnitPrice *(1-Discount)),'C','GB-GB') AS "SALES"
--, r.RegionDescription
--FROM [Order Details] od
--INNER JOIN Orders o ON o.OrderID = od.OrderID
--INNER JOIN EmployeeTerritories et ON o.EmployeeID = et.EmployeeID
--INNER JOIN Territories t ON t.TerritoryID = et.TerritoryID
--INNER JOIN Region r ON r.regionID = t.regionID
--GROUP BY r.RegionDescription
--HAVING SUM((UnitPrice * Quantity) * (1-Discount)) > 1000000
--ORDER BY "SALES" A

--1.7
--SELECT COUNT(*)
--FROM Orders
--WHERE Freight > 100 AND (ShipCountry = 'USA' OR ShipCountry = 'UK')

--1.8
--SELECT TOP 1 od.OrderID, SUM(od.UnitPrice*od.Quantity*od.Discount) AS "Discount Amount"
--FROM [Order Details] od
--GROUP BY od.OrderID
--ORDER BY SUM(od.UnitPrice*od.Quantity*od.Discount) DESC

--2.1

--CREATE TABLE Spartans
--(
--	Spartan_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--	,Title VARCHAR (5)
--	,First_Name VARCHAR (15) NOT NULL
--	,Last_Name VARCHAR (15) NOT NULL
--	,University VARCHAR (15)
--	,Course VARCHAR (30)
--	,MarkAcheived VARCHAR (5)
--)


--INSERT INTO Spartans
--(
--  Title,First_Name,Last_Name,University,Course,MarkAcheived
--)
--VALUES
--(
--  'Mr','Bryn','Morley','South Wales','Game Dev','HND'
--);

--SELECT * FROM Spartans


--3.1
--SELECT e.FirstName + ' ' + e.LastName AS "Employee Name", m.FirstName + ' ' + m.LastName AS "Reports To"
--FROM Employees e
--LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID
--ORDER BY "Reports To","Employee Name"

--3.2
--SELECT s.CompanyName,SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) As "Supplier Total"
--FROM [Order Details] od
--INNER JOIN Products p ON od.ProductID=p.ProductID
--INNER JOIN Suppliers s ON p.SupplierID=s.SupplierID
--GROUP BY s.CompanyName
--HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>10000
--ORDER BY SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) DESC;

----3.3
--SELECT TOP 10 c.CustomerID AS "Customer ID", c.CompanyName As "Company",
--FORMAT(SUM(UnitPrice * Quantity * (1-Discount)),'C') 
--AS "YTD Sales"
--FROM Customers c
-- 		INNER JOIN Orders o ON o.CustomerID=c.CustomerID
-- 		INNER JOIN [Order Details] od ON od.OrderID=o.OrderID
--	WHERE YEAR(OrderDate)=(SELECT MAX(YEAR(OrderDate)) From Orders)
-- 	--WHERE YEAR(OrderDate)=1998 --WHERE YEAR(OrderDate)='1998'
--AND o.ShippedDate IS NOT NULL
--	GROUP BY c.CustomerID, c.CompanyName
-- 	ORDER BY SUM(UnitPrice * Quantity * (1-Discount)) DESC;

--3.4
--SELECT MONTH(OrderDate) Month, YEAR(OrderDate) Year, AVG(CAST(DATEDIFF(d, OrderDate, ShippedDate) As DECIMAL(10,2))) As ShipTime
--	FROM orders 
--	WHERE ShippedDate IS NOT NULL
--	GROUP BY YEAR(OrderDate),MONTH(OrderDate)
--	ORDER BY Year ASC, Month ASC
