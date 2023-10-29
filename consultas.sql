-- CONSULTA 1
SELECT 
    o.ShipCountry AS Country, 
    od.ProductID, 
    p.ProductName, 
    MAX(od.UnitPrice * od.Quantity) AS Monto
FROM 
    orders o 
    JOIN orderdetails od ON o.OrderID = od.OrderID
    JOIN products p ON od.ProductID = p.ProductID
GROUP BY 
    o.ShipCountry, od.ProductID
HAVING 
    MAX(od.UnitPrice * od.Quantity) = 
        (SELECT MAX(od2.UnitPrice * od2.Quantity) 
         FROM orderdetails od2 
         WHERE od2.ProductID = od.ProductID)
ORDER BY 
    o.ShipCountry;

-- CONSULTA 2
SELECT 
    MONTH(o.OrderDate) AS Mes, 
    ROUND(AVG(sub.TotalPorPedido), 0) AS Promedio
FROM 
    orders o
    INNER JOIN (
        SELECT 
    od.OrderID, 
    ROUND(SUM(od.UnitPrice * od.Quantity) + o.Freight, 2) AS TotalPorPedido
FROM 
    orderdetails od 
    INNER JOIN orders o ON od.OrderID = o.OrderID
GROUP BY 
    od.OrderID
    ) AS sub
    ON o.OrderID = sub.OrderID
GROUP BY 
    MONTH(o.OrderDate)
ORDER BY 
    MONTH(o.OrderDate);

-- CONSULTA 3

SELECT 
    od.OrderID, 
    o.OrderDate, 
    o.ShippedDate,
    DATEDIFF(o.ShippedDate, o.OrderDate) AS Dias
FROM 
    orderdetails od 
    INNER JOIN orders o ON od.OrderID = o.OrderID
WHERE 
    o.ShippedDate IS NOT NULL
ORDER BY 
    Dias DESC
LIMIT 
    1;
