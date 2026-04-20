USE sql_store;

SELECT first_name , last_name , birth_date , points
FROM customers
ORDER BY points;

--hw

SELECT * , quantity * unit_price AS 'Total price'
FROM order_items
WHERE order_id = 2
--ORDER BY quantity * unit_price DESC;
ORDER BY 'Total price' DESC;