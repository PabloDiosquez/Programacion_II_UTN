USE EMPRESA_DB;

-- Consulta 1: Empleados activos ordenados alfabéticamente por apellido de manera ascendente.
SELECT ID_EMPLEADO, APELLIDO, NOMBRE, SALARIO
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1
ORDER BY APELLIDO ASC;

-- Consulta 2: Los tres empleados más antiguos.
SELECT TOP 3 ID_EMPLEADO, APELLIDO, NOMBRE, ESTA_ACTIVO, FECHA_ALTA
FROM EMPLEADOS
ORDER BY FECHA_ALTA ASC;

-- Consulta 3: Los tres empleados que más ganan.
SELECT TOP 3 ID_EMPLEADO, NOMBRE, APELLIDO, SALARIO
FROM EMPLEADOS
ORDER BY SALARIO DESC;

-- Consulta 4: Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
SELECT *
FROM EMPLEADOS
ORDER BY SALARIO DESC;

-- Consulta 5: Los distintos niveles de autorización de los puestos, sin repetir.
SELECT DISTINCT NIVEL_AUTORIZACION
FROM PUESTOS;