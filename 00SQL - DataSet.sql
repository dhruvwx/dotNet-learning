
-- =====================================================
-- ABSOLUTE FINAL VERSION - BULLETPROOF
-- This handles every possible scenario
-- =====================================================

USE master;
GO

-- =====================================================
-- PART 1: SAFELY DROP ALL 4 DATABASES (if they exist)
-- =====================================================

-- sql_invoicing
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'sql_invoicing')
BEGIN
    DECLARE @kill1 VARCHAR(8000) = '';
    SELECT @kill1 = @kill1 + 'kill ' + CAST(session_id AS VARCHAR) + ';'
    FROM sys.dm_exec_sessions WHERE database_id = DB_ID('sql_invoicing') AND session_id != @@SPID;
    IF LEN(@kill1) > 0 EXEC(@kill1);

    ALTER DATABASE sql_invoicing SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE sql_invoicing;
END
GO

-- sql_store
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'sql_store')
BEGIN
    DECLARE @kill2 VARCHAR(8000) = '';
    SELECT @kill2 = @kill2 + 'kill ' + CAST(session_id AS VARCHAR) + ';'
    FROM sys.dm_exec_sessions WHERE database_id = DB_ID('sql_store') AND session_id != @@SPID;
    IF LEN(@kill2) > 0 EXEC(@kill2);

    ALTER DATABASE sql_store SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE sql_store;
END
GO

-- sql_hr
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'sql_hr')
BEGIN
    DECLARE @kill3 VARCHAR(8000) = '';
    SELECT @kill3 = @kill3 + 'kill ' + CAST(session_id AS VARCHAR) + ';'
    FROM sys.dm_exec_sessions WHERE database_id = DB_ID('sql_hr') AND session_id != @@SPID;
    IF LEN(@kill3) > 0 EXEC(@kill3);

    ALTER DATABASE sql_hr SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE sql_hr;
END
GO

-- sql_inventory
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'sql_inventory')
BEGIN
    DECLARE @kill4 VARCHAR(8000) = '';
    SELECT @kill4 = @kill4 + 'kill ' + CAST(session_id AS VARCHAR) + ';'
    FROM sys.dm_exec_sessions WHERE database_id = DB_ID('sql_inventory') AND session_id != @@SPID;
    IF LEN(@kill4) > 0 EXEC(@kill4);

    ALTER DATABASE sql_inventory SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE sql_inventory;
END
GO

PRINT 'All existing databases dropped (if any existed)';
GO

-- =====================================================
-- PART 2: CREATE ALL 4 DATABASES
-- =====================================================

-- Create sql_invoicing
CREATE DATABASE sql_invoicing;
GO

USE sql_invoicing;
GO

CREATE TABLE payment_methods (
    payment_method_id TINYINT NOT NULL IDENTITY(1,1),
    name VARCHAR(50) NOT NULL,
    CONSTRAINT PK_payment_methods PRIMARY KEY (payment_method_id)
);

CREATE TABLE clients (
    client_id INT NOT NULL,
    name VARCHAR(50) NOT NULL,
    address VARCHAR(50) NOT NULL,
    city VARCHAR(50) NOT NULL,
    state CHAR(2) NOT NULL,
    phone VARCHAR(50) NULL,
    CONSTRAINT PK_clients PRIMARY KEY (client_id)
);

CREATE TABLE invoices (
    invoice_id INT NOT NULL,
    number VARCHAR(50) NOT NULL,
    client_id INT NOT NULL,
    invoice_total DECIMAL(9,2) NOT NULL,
    payment_total DECIMAL(9,2) NOT NULL DEFAULT 0.00,
    invoice_date DATE NOT NULL,
    due_date DATE NOT NULL,
    payment_date DATE NULL,
    CONSTRAINT PK_invoices PRIMARY KEY (invoice_id),
    CONSTRAINT FK_invoices_clients FOREIGN KEY (client_id) REFERENCES clients(client_id)
);

CREATE TABLE payments (
    payment_id INT NOT NULL IDENTITY(1,1),
    client_id INT NOT NULL,
    invoice_id INT NOT NULL,
    date DATE NOT NULL,
    amount DECIMAL(9,2) NOT NULL,
    payment_method TINYINT NOT NULL,
    CONSTRAINT PK_payments PRIMARY KEY (payment_id),
    CONSTRAINT FK_payments_clients FOREIGN KEY (client_id) REFERENCES clients(client_id),
    CONSTRAINT FK_payments_invoices FOREIGN KEY (invoice_id) REFERENCES invoices(invoice_id),
    CONSTRAINT FK_payments_payment_methods FOREIGN KEY (payment_method) REFERENCES payment_methods(payment_method_id)
);

-- Insert data
SET IDENTITY_INSERT payment_methods ON;
INSERT INTO payment_methods (payment_method_id, name) VALUES 
(1,'Credit Card'), (2,'Cash'), (3,'PayPal'), (4,'Wire Transfer');
SET IDENTITY_INSERT payment_methods OFF;

INSERT INTO clients VALUES 
(1,'Vinte','3 Nevada Parkway','Syracuse','NY','315-252-7305'),
(2,'Myworks','34267 Glendale Parkway','Huntington','WV','304-659-1170'),
(3,'Yadel','096 Pawling Parkway','San Francisco','CA','415-144-6037'),
(4,'Kwideo','81674 Westerfield Circle','Waco','TX','254-750-0784'),
(5,'Topiclounge','0863 Farmco Road','Portland','OR','971-888-9129');

INSERT INTO invoices VALUES 
(1,'91-953-3396',2,101.79,0.00,'2019-03-09','2019-03-29',NULL),
(2,'03-898-6735',5,175.32,8.18,'2019-06-11','2019-07-01','2019-02-12'),
(3,'20-228-0335',5,147.99,0.00,'2019-07-31','2019-08-20',NULL),
(4,'56-934-0748',3,152.21,0.00,'2019-03-08','2019-03-28',NULL),
(5,'87-052-3121',5,169.36,0.00,'2019-07-18','2019-08-07',NULL),
(6,'75-587-6626',1,157.78,74.55,'2019-01-29','2019-02-18','2019-01-03'),
(7,'68-093-9863',3,133.87,0.00,'2019-09-04','2019-09-24',NULL),
(8,'78-145-1093',1,189.12,0.00,'2019-05-20','2019-06-09',NULL),
(9,'77-593-0081',5,172.17,0.00,'2019-07-09','2019-07-29',NULL),
(10,'48-266-1517',1,159.50,0.00,'2019-06-30','2019-07-20',NULL),
(11,'20-848-0181',3,126.15,0.03,'2019-01-07','2019-01-27','2019-01-11'),
(13,'41-666-1035',5,135.01,87.44,'2019-06-25','2019-07-15','2019-01-26'),
(15,'55-105-9605',3,167.29,80.31,'2019-11-25','2019-12-15','2019-01-15'),
(16,'10-451-8824',1,162.02,0.00,'2019-03-30','2019-04-19',NULL),
(17,'33-615-4694',3,126.38,68.10,'2019-07-30','2019-08-19','2019-01-15'),
(18,'52-269-9803',5,180.17,42.77,'2019-05-23','2019-06-12','2019-01-08'),
(19,'83-559-4105',1,134.47,0.00,'2019-11-23','2019-12-13',NULL);

SET IDENTITY_INSERT payments ON;
INSERT INTO payments (payment_id, client_id, invoice_id, date, amount, payment_method) VALUES 
(1,5,2,'2019-02-12',8.18,1),
(2,1,6,'2019-01-03',74.55,1),
(3,3,11,'2019-01-11',0.03,1),
(4,5,13,'2019-01-26',87.44,1),
(5,3,15,'2019-01-15',80.31,1),
(6,3,17,'2019-01-15',68.10,1),
(7,5,18,'2019-01-08',32.77,1),
(8,5,18,'2019-01-08',10.00,2);
SET IDENTITY_INSERT payments OFF;

PRINT 'sql_invoicing created successfully';
GO

-- Create sql_store
USE master;
GO

CREATE DATABASE sql_store;
GO

USE sql_store;
GO

CREATE TABLE products (
    product_id INT NOT NULL IDENTITY(1,1),
    name VARCHAR(50) NOT NULL,
    quantity_in_stock INT NOT NULL,
    unit_price DECIMAL(4,2) NOT NULL,
    CONSTRAINT PK_products PRIMARY KEY (product_id)
);

CREATE TABLE shippers (
    shipper_id SMALLINT NOT NULL IDENTITY(1,1),
    name VARCHAR(50) NOT NULL,
    CONSTRAINT PK_shippers PRIMARY KEY (shipper_id)
);

CREATE TABLE customers (
    customer_id INT NOT NULL IDENTITY(1,1),
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    birth_date DATE NULL,
    phone VARCHAR(50) NULL,
    address VARCHAR(50) NOT NULL,
    city VARCHAR(50) NOT NULL,
    state CHAR(2) NOT NULL,
    points INT NOT NULL DEFAULT 0,
    CONSTRAINT PK_customers PRIMARY KEY (customer_id)
);

CREATE TABLE order_statuses (
    order_status_id TINYINT NOT NULL,
    name VARCHAR(50) NOT NULL,
    CONSTRAINT PK_order_statuses PRIMARY KEY (order_status_id)
);

CREATE TABLE orders (
    order_id INT NOT NULL IDENTITY(1,1),
    customer_id INT NOT NULL,
    order_date DATE NOT NULL,
    status TINYINT NOT NULL DEFAULT 1,
    comments VARCHAR(2000) NULL,
    shipped_date DATE NULL,
    shipper_id SMALLINT NULL,
    CONSTRAINT PK_orders PRIMARY KEY (order_id),
    CONSTRAINT FK_orders_customers FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    CONSTRAINT FK_orders_order_statuses FOREIGN KEY (status) REFERENCES order_statuses(order_status_id),
    CONSTRAINT FK_orders_shippers FOREIGN KEY (shipper_id) REFERENCES shippers(shipper_id)
);

CREATE TABLE order_items (
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    unit_price DECIMAL(4,2) NOT NULL,
    CONSTRAINT PK_order_items PRIMARY KEY (order_id, product_id),
    CONSTRAINT FK_order_items_orders FOREIGN KEY (order_id) REFERENCES orders(order_id),
    CONSTRAINT FK_order_items_products FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE order_item_notes (
    note_id INT NOT NULL,
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    note VARCHAR(255) NOT NULL,
    CONSTRAINT PK_order_item_notes PRIMARY KEY (note_id)
);

-- Insert data
SET IDENTITY_INSERT products ON;
INSERT INTO products (product_id, name, quantity_in_stock, unit_price) VALUES 
(1,'Foam Dinner Plate',70,1.21),
(2,'Pork - Bacon,back Peameal',49,4.65),
(3,'Lettuce - Romaine, Heart',38,3.35),
(4,'Brocolinni - Gaylan, Chinese',90,4.53),
(5,'Sauce - Ranch Dressing',94,1.63),
(6,'Petit Baguette',14,2.39),
(7,'Sweet Pea Sprouts',98,3.29),
(8,'Island Oasis - Raspberry',26,0.74),
(9,'Longan',67,2.26),
(10,'Broom - Push',6,1.09);
SET IDENTITY_INSERT products OFF;

SET IDENTITY_INSERT shippers ON;
INSERT INTO shippers (shipper_id, name) VALUES 
(1,'Hettinger LLC'),
(2,'Schinner-Predovic'),
(3,'Satterfield LLC'),
(4,'Mraz, Renner and Nolan'),
(5,'Waters, Mayert and Prohaska');
SET IDENTITY_INSERT shippers OFF;

SET IDENTITY_INSERT customers ON;
INSERT INTO customers (customer_id, first_name, last_name, birth_date, phone, address, city, state, points) VALUES 
(1,'Babara','MacCaffrey','1986-03-28','781-932-9754','0 Sage Terrace','Waltham','MA',2273),
(2,'Ines','Brushfield','1986-04-13','804-427-9456','14187 Commercial Trail','Hampton','VA',947),
(3,'Freddi','Boagey','1985-02-07','719-724-7869','251 Springs Junction','Colorado Springs','CO',2967),
(4,'Ambur','Roseburgh','1974-04-14','407-231-8017','30 Arapahoe Terrace','Orlando','FL',457),
(5,'Clemmie','Betchley','1973-11-07',NULL,'5 Spohn Circle','Arlington','TX',3675),
(6,'Elka','Twiddell','1991-09-04','312-480-8498','7 Manley Drive','Chicago','IL',3073),
(7,'Ilene','Dowson','1964-08-30','615-641-4759','50 Lillian Crossing','Nashville','TN',1672),
(8,'Thacher','Naseby','1993-07-17','941-527-3977','538 Mosinee Center','Sarasota','FL',205),
(9,'Romola','Rumgay','1992-05-23','559-181-3744','3520 Ohio Trail','Visalia','CA',1486),
(10,'Levy','Mynett','1969-10-13','404-246-3370','68 Lawn Avenue','Atlanta','GA',796);
SET IDENTITY_INSERT customers OFF;

INSERT INTO order_statuses VALUES (1,'Processed'), (2,'Shipped'), (3,'Delivered');

SET IDENTITY_INSERT orders ON;
INSERT INTO orders (order_id, customer_id, order_date, status, comments, shipped_date, shipper_id) VALUES 
(1,6,'2019-01-30',1,NULL,NULL,NULL),
(2,7,'2018-08-02',2,NULL,'2018-08-03',4),
(3,8,'2017-12-01',1,NULL,NULL,NULL),
(4,2,'2017-01-22',1,NULL,NULL,NULL),
(5,5,'2017-08-25',2,'','2017-08-26',3),
(6,10,'2018-11-18',1,'Aliquam erat volutpat. In congue.',NULL,NULL),
(7,2,'2018-09-22',2,NULL,'2018-09-23',4),
(8,5,'2018-06-08',1,'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.',NULL,NULL),
(9,10,'2017-07-05',2,'Nulla mollis molestie lorem. Quisque ut erat.','2017-07-06',1),
(10,6,'2018-04-22',2,NULL,'2018-04-23',2);
SET IDENTITY_INSERT orders OFF;

INSERT INTO order_items VALUES 
(1,4,4,3.74),
(2,1,2,9.10),
(2,4,4,1.66),
(2,6,2,2.94),
(3,3,10,9.12),
(4,3,7,6.99),
(4,10,7,6.40),
(5,2,3,9.89),
(6,1,4,8.65),
(6,2,4,3.28),
(6,3,4,7.46),
(6,5,1,3.45),
(7,3,7,9.17),
(8,5,2,6.94),
(8,8,2,8.59),
(9,6,5,7.28),
(10,1,10,6.01),
(10,9,9,4.28);

INSERT INTO order_item_notes VALUES 
(1, 1, 2, 'first note'), 
(2, 1, 2, 'second note');

PRINT 'sql_store created successfully';
GO

-- Create sql_hr
USE master;
GO

CREATE DATABASE sql_hr;
GO

USE sql_hr;
GO

CREATE TABLE offices (
    office_id INT NOT NULL,
    address VARCHAR(50) NOT NULL,
    city VARCHAR(50) NOT NULL,
    state VARCHAR(50) NOT NULL,
    CONSTRAINT PK_offices PRIMARY KEY (office_id)
);

CREATE TABLE employees (
    employee_id INT NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    job_title VARCHAR(50) NOT NULL,
    salary INT NOT NULL,
    reports_to INT NULL,
    office_id INT NOT NULL,
    CONSTRAINT PK_employees PRIMARY KEY (employee_id),
    CONSTRAINT FK_employees_offices FOREIGN KEY (office_id) REFERENCES offices(office_id),
    CONSTRAINT FK_employees_managers FOREIGN KEY (reports_to) REFERENCES employees(employee_id)
);

INSERT INTO offices VALUES 
(1,'03 Reinke Trail','Cincinnati','OH'),
(2,'5507 Becker Terrace','New York City','NY'),
(3,'54 Northland Court','Richmond','VA'),
(4,'08 South Crossing','Cincinnati','OH'),
(5,'553 Maple Drive','Minneapolis','MN'),
(6,'23 North Plaza','Aurora','CO'),
(7,'9658 Wayridge Court','Boise','ID'),
(8,'9 Grayhawk Trail','New York City','NY'),
(9,'16862 Westend Hill','Knoxville','TN'),
(10,'4 Bluestem Parkway','Savannah','GA');

INSERT INTO employees VALUES 
(37270,'Yovonnda','Magrannell','Executive Secretary',63996,NULL,10),
(33391,'D''arcy','Nortunen','Account Executive',62871,37270,1),
(37851,'Sayer','Matterson','Statistician III',98926,37270,1),
(40448,'Mindy','Crissil','Staff Scientist',94860,37270,1),
(56274,'Keriann','Alloisi','VP Marketing',110150,37270,1),
(63196,'Alaster','Scutchin','Assistant Professor',32179,37270,2),
(67009,'North','de Clerc','VP Product Management',114257,37270,2),
(67370,'Elladine','Rising','Social Worker',96767,37270,2),
(68249,'Nisse','Voysey','Financial Advisor',52832,37270,2),
(72540,'Guthrey','Iacopetti','Office Assistant I',117690,37270,3),
(72913,'Kass','Hefferan','Computer Systems Analyst IV',96401,37270,3),
(75900,'Virge','Goodrum','Information Systems Manager',54578,37270,3),
(76196,'Mirilla','Janowski','Cost Accountant',119241,37270,3),
(80529,'Lynde','Aronson','Junior Executive',77182,37270,4),
(80679,'Mildrid','Sokale','Geologist II',67987,37270,4),
(84791,'Hazel','Tarbert','General Manager',93760,37270,4),
(95213,'Cole','Kesterton','Pharmacist',86119,37270,4),
(96513,'Theresa','Binney','Food Chemist',47354,37270,5),
(98374,'Estrellita','Daleman','Staff Accountant IV',70187,37270,5),
(115357,'Ivy','Fearey','Structural Engineer',92710,37270,5);

PRINT 'sql_hr created successfully';
GO

-- Create sql_inventory
USE master;
GO

CREATE DATABASE sql_inventory;
GO

USE sql_inventory;
GO

CREATE TABLE products (
    product_id INT NOT NULL IDENTITY(1,1),
    name VARCHAR(50) NOT NULL,
    quantity_in_stock INT NOT NULL,
    unit_price DECIMAL(4,2) NOT NULL,
    CONSTRAINT PK_products PRIMARY KEY (product_id)
);

SET IDENTITY_INSERT products ON;
INSERT INTO products (product_id, name, quantity_in_stock, unit_price) VALUES 
(1,'Foam Dinner Plate',70,1.21),
(2,'Pork - Bacon,back Peameal',49,4.65),
(3,'Lettuce - Romaine, Heart',38,3.35),
(4,'Brocolinni - Gaylan, Chinese',90,4.53),
(5,'Sauce - Ranch Dressing',94,1.63),
(6,'Petit Baguette',14,2.39),
(7,'Sweet Pea Sprouts',98,3.29),
(8,'Island Oasis - Raspberry',26,0.74),
(9,'Longan',67,2.26),
(10,'Broom - Push',6,1.09);
SET IDENTITY_INSERT products OFF;

PRINT 'sql_inventory created successfully';
GO

-- =====================================================
-- DONE!
-- =====================================================
USE master;
GO
PRINT '';
PRINT '========================================';
PRINT 'ALL 4 DATABASES CREATED SUCCESSFULLY!';
PRINT '========================================';
PRINT '';
PRINT '1. sql_invoicing - 4 tables, 34 rows';
PRINT '2. sql_store - 7 tables, 58 rows';
PRINT '3. sql_hr - 2 tables, 29 rows';
PRINT '4. sql_inventory - 1 table, 10 rows';
PRINT '';
PRINT 'Total: 131 rows of data ready for learning!';
PRINT '========================================';
GO