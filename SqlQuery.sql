SELECT p.ProductName, c.CategoryName
FROM Products AS p
LEFT JOIN ProductCategories AS pc
ON p.ProductId = pc.ProductId
JOIN Categories AS c
ON pc.CategoryId = c.CategoryId