USE sql_store;


--from order_items table, for order 6 , total price >30
SELECT *
FROM order_items
WHERE order_id = 6 AND quantity * unit_price > 30;