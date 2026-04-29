USE sql_store;

SELECT * 
FROM products;

INSERT INTO products(name, quantity_in_stock, unit_price)
VALUES (
		'NAME1',
		10,
		1),
		(
		'NAME2',
		20,
		2),
		(
		'NAME3',
		30,
		3)