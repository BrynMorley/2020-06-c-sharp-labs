--SELECT COUNT(*) AS "Number Of Employees in London"
--FROM Employees 
--WHERE City = 'London'

--SELECT * FROM Employees
--WHERE TitleOfCourtesy = 'Dr.'

--SELECT COUNT(*) AS "Number of discontinued Products"
--FROM Products
--WHERE Discontinued = '1'

--SELECT CompanyName, City, Country, Region
--FROM Customers WHERE Region='BC'

--SELECT CompanyName, ContactName
--FROM Customers
--WHERE Country = 'France'
--ORDER BY CompanyName ASC

--SELECT Country, ContactName
--FROM Customers
--ORDER BY Country, ContactName ASC

--SELECT TOP 100 CompanyName, City FROM Customers
--Where Country ='France'

--SELECT productName, UnitPrice FROM Products
--WHERE CategoryID = 1 AND Discontinued = 0

--SELECT productName, UnitPrice FROM Products
--WHERE CategoryID = 1 OR Discontinued = 0

--SELECT ProductName, UnitPrice FROM Products
--Where UnitsInStock > 0 AND UnitPrice >29.99

--SELECT CompanyName, Contactname, Phone
--INTO French_customers
--From Customers
--WHERE Country = 'France'

--SELECT ProductName
--FROM Products WHERE ProductName LIKE 'Ch%'

--SELECT* 
--FROM Customers Where Region LIKE '_A'

--SELECT*
--FROM Customers Where Region IN ('WA','SP')

--SELECT*
--FROM Customers Where Region = 'WA' OR Region = 'SP'

SELECT* 
FROM EmployeeTerritories
WHERE TerritoryID BETWEEN 06800 AND 09999