USE EMPRESA_DB;

-- Consulta 1: Nombre y apellido de los empleados, junto al nombre de su puesto.
SELECT E.NOMBRE, E.APELLIDO, P.NOMBRE
FROM EMPLEADOS AS E INNER JOIN PUESTOS AS P 
ON E.ID_PUESTO = P.ID_PUESTO;

-- Consulta 2: Empleados que tengan un puesto con nivel de autorización igual a 3.
SELECT E.NOMBRE, E.APELLIDO
FROM EMPLEADOS AS E INNER JOIN PUESTOS AS P
ON E.ID_PUESTO = P.ID_PUESTO
WHERE P.NIVEL_AUTORIZACION = 3;

-- Consulta 3: Nombre y apellido de los empleados, junto al nombre de su puesto, ordenados alfabéticamente por apellido del empleado de manera ascendente.
SELECT E.NOMBRE, E.APELLIDO, P.NOMBRE
FROM EMPLEADOS AS E INNER JOIN PUESTOS AS P
ON E.ID_PUESTO = P.ID_PUESTO
ORDER BY E.APELLIDO ASC;

-- Consulta 4: Nombre y apellido de los empleados, junto al nombre de su puesto, ordenados alfabéticamente por nombre del puesto de manera ascendente.
SELECT E.NOMBRE, E.APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P
ON E.ID_PUESTO = P.ID_PUESTO
ORDER BY P.NOMBRE ASC;

-- Consulta 5: Nombre, apellido y nombre del puesto de los empleados que estén activos, ordenados por su nivel de autorización de forma ascendente.
SELECT E.NOMBRE, E.APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P
ON E.ID_PUESTO = P.ID_PUESTO
WHERE E.ESTA_ACTIVO = 1
ORDER BY P.NIVEL_AUTORIZACION ASC;

-- Consulta 6: Puestos que no tengan empleados asociados.
SELECT P.ID_PUESTO, P.NOMBRE
FROM PUESTOS P LEFT JOIN EMPLEADOS E
ON P.ID_PUESTO = E.ID_PUESTO
WHERE E.ID_EMPLEADO IS NULL;

-- Consulta 7: Puestos que tienen empleados asociados.
SELECT P.NOMBRE
FROM PUESTOS P INNER JOIN EMPLEADOS E
ON P.ID_PUESTO = E.ID_PUESTO;