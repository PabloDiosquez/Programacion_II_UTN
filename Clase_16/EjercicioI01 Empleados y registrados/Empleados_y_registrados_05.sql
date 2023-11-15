USE EMPRESA_DB;

-- Consulta 1: El promedio de los salarios de todos los empleados que est�n activos.
SELECT AVG(SALARIO) AS PROMEDIO_SALARIO_ACTIVOS
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

-- Consulta 2: La suma de los salarios de todos los empleados que est�n activos.
SELECT SUM(SALARIO) AS SUMA_SALARIOS_ACTIVOS
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

-- Consulta 3: La cantidad de empleados que ganan m�s de $250.000,00.
SELECT COUNT(ID_EMPLEADO) AS CANTIDAD_EMPLEADOS_SUELDO_MEDIO
FROM EMPLEADOS
WHERE SALARIO > 250000;

-- Consulta 4: La cantidad de empleados que ingresaron antes del a�o 2010.
SELECT COUNT(ID_EMPLEADO) AS NRO_EMPLEADOS_INGRESO_ANTES_2010
FROM EMPLEADOS
WHERE FECHA_ALTA < '2010-01-01';

-- Consulta 5: El salario m�s alto.
SELECT MAX(SALARIO) AS SALARIO_M�S_ALTO
FROM EMPLEADOS;

-- Consulta 6: Empleado con el salario m�s alto.
SELECT ID_EMPLEADO, NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE SALARIO = (SELECT MAX(SALARIO) AS SALARIO_M�S_ALTO FROM EMPLEADOS);

-- Consulta 7: Los puestos con el nivel de autorizaci�n m�s bajo.
SELECT ID_PUESTO, NOMBRE
FROM PUESTOS
WHERE NIVEL_AUTORIZACION = (SELECT MIN(NIVEL_AUTORIZACION) AS NIVEL_AUT_M�S_BAJO FROM PUESTOS);

-- Consulta 8: El nombre completo de todos los empleados (concatenado).
SELECT CONCAT(NOMBRE, ' - ', APELLIDO) AS NOMBRE_COMPLETO
FROM EMPLEADOS;

-- Consulta 9: El nombre completo de todos los empleados (concatenado), el nombre de su puesto y su nivel de autorizaci�n.
SELECT CONCAT(E.NOMBRE, ' ', E.APELLIDO) AS NOMBRE_COMPLETO, P.NOMBRE AS PUESTO, P.NIVEL_AUTORIZACION 
FROM EMPLEADOS E
INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO;

-- Consulta 10: El nombre completo de todos los empleados (concatenado), el nombre de su puesto y su nivel de autorizaci�n. 
-- Y los puestos con su nivel de autorizaci�n que no tengan empleados asociados. Todo en una misma consulta.
SELECT CONCAT(E.NOMBRE, ' ', E.APELLIDO) AS NOMBRE_COMPLETO, P.NOMBRE AS PUESTO, P.NIVEL_AUTORIZACION 
FROM EMPLEADOS E
INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO

UNION

SELECT NULL AS NOMBRE_COMPLETO, P.NOMBRE, P.NIVEL_AUTORIZACION
FROM PUESTOS P
LEFT JOIN EMPLEADOS E ON P.ID_PUESTO = E.ID_PUESTO
WHERE E.ID_EMPLEADO IS NULL;