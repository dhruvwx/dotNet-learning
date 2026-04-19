USE sql_store;

SELECT *
FROM products
WHERE quantity_in_stock IN (49,38,72); --IN 


SELECT *
FROM customers
--WHERE points  BETWEEN 1000 AND 3000;--(is same as)WHERE points >= 1000 AND points <=3000;

WHERE birth_date BETWEEN '1990-01-01' AND '2000-01-01'; --HW