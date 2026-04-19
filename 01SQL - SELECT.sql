USE sql_store;

SELECT 
	last_name,
	first_name,
	points,
	points * 10 + 100 AS 'heavy discount' --if space in name use'' else direct name will work too
FROM customers;

SELECT DISTINCT state --REMOVES DUPLICATE VALUES SHOWS ONLY ONE (VA)
FROM customers
ORDER BY state DESC;


--``````HOMEWORK``````````

USE sql_store ;

SELECT name , unit_price , unit_price * 1.1 AS 'new price'
FROM products;

