USE sql_store;

SELECT *
FROM customers
WHERE points > 3000;


--HW ORDERS PLACED IN 2019--
SELECT *
FROM orders
WHERE order_date >= '2019-01-01';