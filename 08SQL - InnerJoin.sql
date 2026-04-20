USE sql_store;

SELECT * 
FROM customers
JOIN orders ON customers.customer_id = orders.customer_id;


--HW--JOINING TABLES
SELECT order_id , o.product_id  , o.unit_price , quantity
FROM order_items O
JOIN products P
ON o.product_id = p.product_id
ORDER BY product_id

--JOINING DATABASES--
USE sql_store;
SELECT *
FROM sql_inventory.dbo.products sp
JOIN order_items oi ON sp.product_id = oi.product_id;


--SELF JOIN--JOINING FROM THE SAME TABLE
USE sql_hr;--need name of reports_to instead of id

SELECT --e.reports_to , e.employee_id ,m.first_name
	e.employee_id,
	e.first_name,
	m.first_name AS Manager
FROM employees e
JOIN employees m
	ON e.reports_to = m.employee_id



--Joining Multiple Tables--
USE sql_invoicing;

SELECT 
	p.payment_id,
	p.amount,
	p.client_id,
	c.name,
	pm.name
FROM payments p
JOIN clients c
	ON p.client_id = c.client_id
JOIN payment_methods pm
	ON p.payment_method = pm.payment_method_id



