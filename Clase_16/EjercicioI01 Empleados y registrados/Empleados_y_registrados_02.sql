USE EMPRESA_DB;

-- Consulta 1: Empleados activos con salario superior a $300,000.00.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1 AND SALARIO > 300000;

-- Consulta 2: Empleados sin correo electr�nico o inactivos.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE EMAIL IS NULL OR ESTA_ACTIVO = 0;

-- Consulta 3: Empleados con correo electr�nico y cuyo nombre contiene la letra "a".
SELECT *
FROM EMPLEADOS
WHERE EMAIL IS NOT NULL AND NOMBRE LIKE '%a%';

-- Consulta 4: Empleados que ganen $250,000.00 o m�s y hayan ingresado despu�s del a�o 2000 inclusive,
-- o aquellos que ganen menos de $250,000.00 y hayan ingresado antes del a�o 2000 sin incluir.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE (SALARIO >= 250000 AND FECHA_ALTA >= '2000-01-01') OR (SALARIO < 250000 AND FECHA_ALTA <= '1999-12-31');

-- Consulta 5: Empleados cuyo salario est� entre $100,000.00 y $250,000.00.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO, SALARIO AS SALARIO_MENSUAL
FROM EMPLEADOS
WHERE SALARIO BETWEEN 100000 AND 250000;

-- Consulta 6: Empleados cuyo salario NO est� entre $100,000.00 y $250,000.00.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO, SALARIO AS SALARIO_MENSUAL
FROM EMPLEADOS
WHERE SALARIO NOT BETWEEN 100000 AND 250000;

-- Consulta 7: Puestos con nivel de autorizaci�n 0, 1 o 2.
SELECT *
FROM PUESTOS
WHERE NIVEL_AUTORIZACION IN (0, 1, 2);

-- Consulta 8: Puestos con nivel de autorizaci�n distinto a 0, 1 y 2.
SELECT *
FROM PUESTOS
WHERE NIVEL_AUTORIZACION NOT IN (0, 1, 2);