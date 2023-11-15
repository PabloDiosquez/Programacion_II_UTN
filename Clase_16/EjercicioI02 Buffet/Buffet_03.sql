-- Utilizar la base de datos BUFFET_UTN
USE BUFFET_UTN;

-- 1. Obtener los detalles completos de todos los productos, ordenados alfabéticamente.
SELECT *
FROM PRODUCTOS
ORDER BY NOMBRE ASC;

-- 2. Obtener los detalles completos de todos los proveedores de 'Quilmes'.
SELECT *
FROM PROVEEDORES
WHERE LOCALIDAD = 'Quilmes';

-- 3. Obtener todos los envíos en los cuales la cantidad esté entre 200 y 300 inclusive.
SELECT *
FROM ENVIOS
WHERE CANTIDAD BETWEEN 200 AND 300;

-- 4. Obtener la cantidad total de todos los productos enviados.
SELECT SUM(E.CANTIDAD) AS TOTAL_PRODUCTOS_ENVIADOS
FROM PRODUCTOS P
INNER JOIN ENVIOS E ON P.CODIGO_PRODUCTO = E.CODIGO_PRODUCTO;

-- 5. Mostrar los primeros 3 números de productos que se han enviado.
SELECT TOP 3 P.CODIGO_PRODUCTO, P.NOMBRE, E.NUMERO_PROVEEDOR, E.CANTIDAD
FROM ENVIOS E
INNER JOIN PRODUCTOS P ON E.CODIGO_PRODUCTO = P.CODIGO_PRODUCTO;

-- 6. Mostrar los nombres de proveedores y los nombres de los productos enviados.
SELECT PROV.NOMBRE AS NOMBRE_PROVEEDOR, PROD.NOMBRE AS NOMBRE_PRODUCTO
FROM PROVEEDORES AS PROV
INNER JOIN ENVIOS AS E ON PROV.NUMERO_PROVEEDOR = E.NUMERO_PROVEEDOR
INNER JOIN PRODUCTOS AS PROD ON PROD.CODIGO_PRODUCTO = E.CODIGO_PRODUCTO;

-- 7. Indicar el monto (cantidad * precio) de todos los envíos.
SELECT E.CODIGO_PRODUCTO, E.NUMERO_PROVEEDOR, (CANTIDAD * PRECIO) AS MONTO
FROM ENVIOS AS E
INNER JOIN PRODUCTOS AS P ON E.CODIGO_PRODUCTO = P.CODIGO_PRODUCTO;

-- 8. Obtener la cantidad total del producto 1 enviado por el proveedor 102.
SELECT SUM(CANTIDAD) AS TOTAL_PROD1_PROV102
FROM ENVIOS
WHERE CODIGO_PRODUCTO = 1 AND NUMERO_PROVEEDOR = 102;

-- 9. Obtener todos los números de los productos suministrados por algún proveedor de 'Avellaneda'.
SELECT PROD.CODIGO_PRODUCTO, PROD.NOMBRE
FROM PRODUCTOS AS PROD
INNER JOIN ENVIOS AS E ON PROD.CODIGO_PRODUCTO = E.CODIGO_PRODUCTO
INNER JOIN PROVEEDORES AS PROV ON E.NUMERO_PROVEEDOR = PROV.NUMERO_PROVEEDOR
WHERE PROV.LOCALIDAD = 'Avellaneda';

-- 10. Obtener los domicilios y localidades de los proveedores cuyos nombres contengan la letra 'I'.
SELECT NOMBRE, DOMICILIO, LOCALIDAD
FROM PROVEEDORES
WHERE NOMBRE LIKE '%I%';