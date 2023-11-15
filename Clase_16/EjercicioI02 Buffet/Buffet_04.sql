-- 1. Utilizar la base de datos BUFFET_UTN
USE BUFFET_UTN;

-- 2. Agregar el producto número 4, llamado 'Chocolate', de tamaño chico y con un precio de 25,35.
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, NOMBRE, PRECIO, DIMENSIONES)
VALUES (4, 'Chocolate', 25.35, 'Chico');

-- 3. Insertar un nuevo proveedor (únicamente con los campos obligatorios).
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR)
VALUES (1001);

-- 4. Insertar un nuevo proveedor (107), donde el nombre y la localidad son 'Rosales' y 'La Plata'.
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR, NOMBRE, LOCALIDAD)
VALUES (107, 'Rosales', 'La Plata');

-- 5. Cambiar los precios de los productos de tamaño 'grande' a 97,50.
UPDATE PRODUCTOS
SET PRECIO = 97.50
WHERE DIMENSIONES = 'Grande';

-- 6. Cambiar el tamaño de 'Chico' a 'Mediano' de todos los productos cuyas cantidades sean mayores a 300 inclusive.
UPDATE PRODUCTOS
SET DIMENSIONES = 'Mediano'
WHERE CODIGO_PRODUCTO IN (
    SELECT DISTINCT P.CODIGO_PRODUCTO
    FROM PRODUCTOS P
    INNER JOIN ENVIOS E ON P.CODIGO_PRODUCTO = E.CODIGO_PRODUCTO
    WHERE P.DIMENSIONES = 'Chico' AND E.CANTIDAD >= 300
);

-- 7. Eliminar el producto número 1.
-- Eliminar registros en la tabla secundaria que hacen referencia al elemento principal
DELETE FROM ENVIOS 
WHERE CODIGO_PRODUCTO = 1;

-- Eliminar el elemento principal de la tabla principal
DELETE FROM PRODUCTOS
WHERE CODIGO_PRODUCTO = 1;

-- 8. Eliminar a todos los proveedores que no han enviado productos.
DELETE FROM PROVEEDORES
WHERE NUMERO_PROVEEDOR IN (
    SELECT P.NUMERO_PROVEEDOR
    FROM PROVEEDORES P
    LEFT JOIN ENVIOS E ON P.NUMERO_PROVEEDOR = E.NUMERO_PROVEEDOR
    WHERE E.NUMERO_PROVEEDOR IS NULL
);

-- De otra manera...
-- 9. Esta consulta utiliza NOT EXISTS para verificar si no hay registros en la tabla ENVIOS
-- que tengan el mismo NUMERO_PROVEEDOR que el proveedor en la tabla PROVEEDORES.
-- Si no hay coincidencias, el proveedor será eliminado.
DELETE FROM PROVEEDORES
WHERE NOT EXISTS (
    SELECT 1
    FROM ENVIOS E
    WHERE PROVEEDORES.NUMERO_PROVEEDOR = E.NUMERO_PROVEEDOR
);