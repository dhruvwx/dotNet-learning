USE sql_store;

SELECT *
FROM customers
WHERE address LIKE '%trail%' OR
	address LIKE '%avenue%'; 
--WHERE phone LIKE '%9';


----------------------------------------------------------
--NULL OPERATOR--
--HW ORDERS NOT SHIPPED

SELECT *
FROM orders
WHERE shipped_date IS NULL OR shipper_id IS NULL;

