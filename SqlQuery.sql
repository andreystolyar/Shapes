/*
	В базе данных MS SQL Server есть продукты и категории.
	Одному продукту может соответствовать много категорий,
	в одной категории может быть много продуктов.
	Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
	Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

SELECT p.Name AS ProductName, c.Name AS CateroryName
FROM Products AS p
LEFT JOIN Categories AS c
ON p.CategoryID = c.CategoryID