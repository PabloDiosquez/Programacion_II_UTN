-- Usar la base de datos BUFFET_UTN
USE BUFFET_UTN;

-- Insertar tuplas en la tabla Proveedores
-- Cada sentencia INSERT agrega un nuevo proveedor con su respectiva información
INSERT INTO Proveedores (Numero_Proveedor, Nombre, Domicilio, Localidad) VALUES (100, 'Perez', 'Perón 876', 'Quilmes');
INSERT INTO Proveedores (Numero_Proveedor, Nombre, Domicilio, Localidad) VALUES (101, 'Gimenez', 'Mitre 750', 'Avellaneda');
INSERT INTO Proveedores (Numero_Proveedor, Nombre, Domicilio, Localidad) VALUES (102, 'Aguirre', 'Boedo 634', 'Bernal');

-- Insertar tuplas en la tabla Productos
-- Cada sentencia INSERT agrega un nuevo producto con su respectiva información
INSERT INTO Productos (Codigo_Producto, Nombre, Precio, Dimensiones) VALUES (1, 'Caramelos', 1.5, 'Chico');
INSERT INTO Productos (Codigo_Producto, Nombre, Precio, Dimensiones) VALUES (2, 'Alfajores', 45.89, 'Mediano');
INSERT INTO Productos (Codigo_Producto, Nombre, Precio, Dimensiones) VALUES (3, 'Gaseosa', 15.80, 'Grande');

-- Insertar tuplas en la tabla Envios
-- Cada sentencia INSERT agrega un nuevo registro de envío con su respectiva información
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (100, 1, 500);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (100, 2, 1500);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (100, 3, 100);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (101, 2, 55);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (101, 3, 225);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (102, 1, 600);
INSERT INTO Envios (Numero_Proveedor, Codigo_Producto, Cantidad) VALUES (102, 3, 300);