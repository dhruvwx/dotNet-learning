USE sql_store;

SELECT 
	p.product_id,
	p.name,
	o.quantity
FROM order_items o
RIGHT JOIN products p
	ON o.product_id = P.product_id;


SELECT * FROM products
SELECT * FROM order_items


--MULTIPLE Tables--

SELECT 
	order_date,
	order_id,
	c.first_name,
	sh.name AS shipper,
	os.name AS status
FROM orders o
LEFT JOIN shippers sh
	ON o.shipper_id = sh.shipper_id
LEFT JOIN order_statuses os
	ON o.status = os.order_status_id
JOIN customers c
	ON o.customer_id = c.customer_id  
ORDER BY status , order_id

--CROSS JOIN--joins all the columns

SELECT *	-- EXPLICIT
FROM shippers
CROSS JOIN products;


SELECT *	-- IMPLICIT
FROM shippers , products;