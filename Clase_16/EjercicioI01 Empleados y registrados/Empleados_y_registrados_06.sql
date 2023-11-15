USE EMPRESA_DB;

-- Consulta 1: La cantidad de empleados por puesto.
SELECT P.ID_PUESTO, COUNT(E.ID_EMPLEADO) AS CANTIDAD_EMPLEADOS_POR_PUESTO
FROM EMPLEADOS E
INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
GROUP BY P.ID_PUESTO;

-- Consulta 2: El promedio del salario por puesto.
SELECT P.ID_PUESTO, AVG(E.SALARIO) AS SALARIO_PROMEDIO
FROM EMPLEADOS E
INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
GROUP BY P.ID_PUESTO;

-- Consulta 3: Nombre, apellido y salario del empleado que m�s gana.
SELECT NOMBRE, APELLIDO, SALARIO
FROM EMPLEADOS
WHERE SALARIO = (SELECT MAX(SALARIO) FROM EMPLEADOS);

-- Consulta 4: Los empleados con el nivel de autorizaci�n m�s alto.
SELECT E.ID_EMPLEADO, E.NOMBRE, E.APELLIDO, P.NIVEL_AUTORIZACION
FROM EMPLEADOS E
INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
WHERE P.NIVEL_AUTORIZACION = (SELECT MAX(NIVEL_AUTORIZACION) FROM PUESTOS);

-- Consulta 5: Los datos del empleado m�s viejo.
SELECT *
FROM EMPLEADOS
WHERE FECHA_ALTA = (SELECT MIN(FECHA_ALTA) FROM EMPLEADOS);

-- Consulta 6: Los salarios por encima del promedio.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO, SALARIO
FROM EMPLEADOS
WHERE SALARIO > (SELECT AVG(SALARIO) FROM EMPLEADOS);

-- Consulta 7: La cantidad de empleados que ganan por encima del promedio.
SELECT COUNT(ID_EMPLEADO) AS NRO_EMPLEADOS_POR_ARRIBA_SALARIO_PROMEDIO
FROM EMPLEADOS
WHERE SALARIO > (SELECT AVG(SALARIO) FROM EMPLEADOS);