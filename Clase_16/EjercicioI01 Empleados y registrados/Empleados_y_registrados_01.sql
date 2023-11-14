USE EMPRESA_DB;

-- 1. Todos los empleados con todos sus datos.
SELECT * 
FROM EMPLEADOS;

-- 2. El nombre (y sólo eso) de todos los puestos.
SELECT NOMBRE
FROM PUESTOS;

-- 3. Sólo los empleados que estén activos (ESTA_ACTIVO = 1).
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

-- 4. Los empleados cuyo salario sea mayor a $200.000,00.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE SALARIO > 200000;

-- 5. Los empleados cuya fecha de alta sea menor o igual al 07/06/2012.
SELECT *
FROM EMPLEADOS
WHERE FECHA_ALTA <= '2012-07-06';

-- 6. Los empleados que no tengan mail cargado.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE EMAIL IS NULL;

-- 7.Los empleados que tengan mail cargado.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO, EMAIL
FROM EMPLEADOS
WHERE EMAIL IS NOT NULL;

-- 8. Los empleados cuyo mail sea de gmail.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO, EMAIL 
FROM EMPLEADOS
WHERE EMAIL LIKE '%@gmail.com';

-- 9. Los empleados cuyo apellido empiece con la letra "B".
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE APELLIDO LIKE 'B%';