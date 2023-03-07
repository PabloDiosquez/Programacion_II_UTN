USE EMPRESA_DB;

INSERT INTO PUESTOS (ID_PUESTO, NOMBRE, NIVEL_AUTORIZACION)
VALUES 
(1, 'Director', 3),
(2, 'Gerente', 3),
(5, 'Jefe de sector', 2),
(4, 'Administrativo', 1),
(3, 'Vendedor', 0),
(6, 'Secretario', 2);

INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_PUESTO, SALARIO, ESTA_ACTIVO, FECHA_ALTA, FECHA_BAJA, EMAIL)
VALUES 
('Leilani', 'Kinney', 1, 383946.80, 1, '1996-03-21', NULL, 'lkinney@gmail.com'),
('Igor', 'England', 5, 283558.85, 1, '2013-02-28', NULL, 'iengland@hotmail.com'),
('Maya', 'Brock', 3, 164546.09, 1, '1993-10-24', NULL, NULL),
('Hayden', 'Moss', 4, 212695.50, 0, '2012-06-07', '2015-02-10', 'hmoss@gmail.com'),
('Amal', 'Colon', 2, 388933.60, 1, '2019-09-03', NULL, NULL);

-- Consultas ✌

--Todos los empleados con todos sus datos.
SELECT * 
FROM EMPLEADOS;

--El nombre (y sólo eso) de todos los puestos.
SELECT NOMBRE 
FROM PUESTOS;

--Sólo los empleados que estén activos (ESTA_ACTIVO = 1).
SELECT *
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

--Los empleados cuyo salario sea mayor a $200.000,00.
SELECT * 
FROM EMPLEADOS
WHERE SALARIO > 200000;

--Los empleados cuya fecha de alta sea menor o igual al 07/06/2012.
SELECT * 
FROM EMPLEADOS
WHERE FECHA_ALTA <= '2012-06-07';

--Los empleados que no tengan mail cargado.
SELECT NOMBRE, APELLIDO
FROM EMPLEADOS
WHERE EMAIL IS NULL;

--Los empleados que tengan mail cargado.
SELECT NOMBRE, APELLIDO, EMAIL
FROM EMPLEADOS
WHERE EMAIL IS NOT NULL;

--Los empleados cuyo mail sea de gmail.
SELECT * 
FROM EMPLEADOS
WHERE EMAIL LIKE '%gmail%';

--Los empleados cuyo apellido empiece con la letra "B".
SELECT NOMBRE, APELLIDO, SALARIO
FROM EMPLEADOS
WHERE APELLIDO LIKE 'B%';

--Los empleados que estén activos y ganen más de $300.000,00.
SELECT *
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1 AND SALARIO > 300000;

--Los empleados que no tengan mail o no estén activos.
SELECT *
FROM EMPLEADOS
WHERE EMAIL IS NULL OR ESTA_ACTIVO = 0 ;

--Los empleados que tengan mail y su nombre contenga la letra "a".
SELECT * 
FROM EMPLEADOS
WHERE EMAIL IS NOT NULL AND NOMBRE LIKE '%a%';

--Los empleados que ganen $250.000,00 o más y hayan ingresado después del año 2000
--inclusive, o aquellos que ganen menos de $250.000,00 y hayan ingresado antes del
--año 2000 sin incluir.
SELECT *
FROM EMPLEADOS
WHERE (SALARIO >= 250000 AND FECHA_ALTA >= '2000-01-01') OR
(SALARIO < 250000 AND FECHA_ALTA < '2000-01-01');

--Los empleados cuyo salario esté entre $100.000,00 y $250.000,00.
SELECT *
FROM EMPLEADOS
WHERE SALARIO BETWEEN 100000 AND 250000;

--Los empleados cuyo salario NO esté entre $100.000,00 y $250.000,00.
SELECT *
FROM EMPLEADOS
WHERE SALARIO NOT BETWEEN 100000 AND 250000;

--Los puestos con nivel de autorización 0, 1 o 2.
SELECT * 
FROM PUESTOS WHERE NIVEL_AUTORIZACION IN (0,1,2);

--Los puestos con nivel de autorización distinto a 0, 1 y 2.
SELECT * 
FROM PUESTOS WHERE NIVEL_AUTORIZACION NOT IN (0,1,2);

--Los empleados activos ordenados alfabéticamente por su apellido de manera
--ascendente.
SELECT *
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1
ORDER BY APELLIDO ASC;

--Los tres empleados más viejos.
SELECT TOP(3) * 
FROM EMPLEADOS
ORDER BY FECHA_ALTA ASC;

--Los tres empleados que más ganan.
SELECT TOP(3) NOMBRE, APELLIDO, SALARIO
FROM EMPLEADOS
ORDER BY SALARIO DESC;

--Todos los datos de los empleados ordenados por el valor de sus salarios de manera descendente.
SELECT *
FROM EMPLEADOS
ORDER BY SALARIO DESC;

--Los distintos niveles de autorización de los puestos, sin repetir.
SELECT DISTINCT NIVEL_AUTORIZACION
FROM PUESTOS;

--El nombre y apellido de los empleados, junto al nombre de su puesto.
SELECT E.NOMBRE, E.APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P
ON E.ID_PUESTO = P.ID_PUESTO;

--Los empleados que tengan un puesto con nivel de autorización igual a 3.
SELECT E.NOMBRE, APELLIDO, NIVEL_AUTORIZACION
FROM EMPLEADOS E INNER JOIN PUESTOS P
ON E.ID_PUESTO = P.ID_PUESTO
WHERE P.NIVEL_AUTORIZACION = 3;

--El nombre y apellido de los empleados, junto al nombre de su puesto,
--ordenados alfabéticamente por apellido del empleado de manera ascendente.
SELECT E.NOMBRE, APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
ORDER BY APELLIDO ASC;

--El nombre y apellido de los empleados, junto al nombre de su puesto, 
--ordenados alfabéticamente por nombre del puesto de manera ascendente.
SELECT E.NOMBRE, APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
ORDER BY P.NOMBRE ASC;

--Nombre, apellido y nombre del puesto de los empleados que estén activos,
--ordenados por su nivel de autorización de forma ascendente.
SELECT E.NOMBRE, APELLIDO, P.NOMBRE
FROM EMPLEADOS E INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO
WHERE ESTA_ACTIVO = 1
ORDER BY NIVEL_AUTORIZACION ASC;

--Los puestos que no tengan empleados asociados.
SELECT P.*
FROM PUESTOS P LEFT JOIN EMPLEADOS E ON P.ID_PUESTO = E.ID_PUESTO
WHERE ID_EMPLEADO IS NULL;

--Los puestos que tienen empleados asociados.
SELECT DISTINCT P.*
FROM EMPLEADOS E INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO;

--El promedio de los salarios de todos los empleados que estén activos.
SELECT AVG(SALARIO) AS SALARIO_PROMEDIO_EMPLEADOS_ACTIVOS
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

--La suma de los salarios de todos los empleados que estén activos.
SELECT SUM(SALARIO) AS SUMA_SALARIO_EMPLEADOS_ACTIVOS
FROM EMPLEADOS
WHERE ESTA_ACTIVO = 1;

--La cantidad de empleados que ganan más de $250.000,00.
SELECT COUNT(ID_EMPLEADO)
FROM EMPLEADOS
WHERE SALARIO > 250000;

--La cantidad de empleados que ingresaron antes del año 2010.
--El salario más alto.
SELECT MAX(SALARIO) AS SALARIO_MAXIMO
FROM EMPLEADOS;

--Los puestos con el nivel de autorización más bajo.
SELECT P.*
FROM PUESTOS P
WHERE NIVEL_AUTORIZACION IN (SELECT MIN(NIVEL_AUTORIZACION)
							 FROM PUESTOS);

--El nombre completo de todos los empleados (concatenado).
SELECT CONCAT(NOMBRE, ' ', APELLIDO) AS NOMBRE_COMPLETO
FROM EMPLEADOS;

--El nombre completo de todos los empleados (concatenado), el nombre de su puesto
--y su nivel de autorización.
SELECT CONCAT(E.NOMBRE, ' ', APELLIDO) AS NOMBRE_COMPLETO, P.NOMBRE AS PUESTO, NIVEL_AUTORIZACION
FROM EMPLEADOS E INNER JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO;

--El nombre completo de todos los empleados (concatenado), el nombre de su puesto
--y su nivel de autorización. Y los puestos con su nivel de autorización que no 
--tengan empleados asociados. Todo en una misma consulta.
SELECT P.ID_PUESTO, P.NOMBRE AS PUESTO, CONCAT(E.NOMBRE, ' ', APELLIDO) AS NOMBRE_COMPLETO, NIVEL_AUTORIZACION
FROM EMPLEADOS E RIGHT JOIN PUESTOS P ON E.ID_PUESTO = P.ID_PUESTO;

--La cantidad de empleados por puesto.
--El promedio del salario por puesto.
--Nombre, apellido y salario del empleado que más gana.
--Los empleados con el nivel de autorización más alto.
--Los datos del empleado más viejo.
--Los salarios por encima del promedio.
----La cantidad de empleados que ganan por encima del promedio.

--Agregar el mail mbrock@yahoo.com a Maya Brock filtrando por su ID_EMPLEADO. Verificar con una consulta la correcta ejecución del comando.
UPDATE EMPLEADOS
SET EMAIL = 'mbrock@yahoo.com'
WHERE ID_EMPLEADO = 3;

--Cambiar el puesto de Maya Brock a Administrativo y su salario a $210.000,00.
UPDATE EMPLEADOS
SET ID_PUESTO = 4, SALARIO = 210000
WHERE ID_EMPLEADO = 3;

--Dar un aumento del 25% a todos los empleados que ganen menos de $250.000,00.
UPDATE EMPLEADOS
SET SALARIO = 1.25*SALARIO
WHERE SALARIO < 250000;

--Exportar la base de datos.

--Hacer una baja lógica del empleado con ID = 1, sin olvidar cargar su fecha de baja.
--Verificar con una consulta la correcta ejecución del comando.
UPDATE EMPLEADOS
SET ESTA_ACTIVO = 0, FECHA_BAJA = GETDATE()
WHERE ID_EMPLEADO = 1;

SELECT * 
FROM EMPLEADOS
WHERE ID_EMPLEADO = 1;

--Hacer una baja física a todos los empleados que no estén activos. Verificar con una consulta la correcta ejecución del comando.
DELETE EMPLEADOS
WHERE ESTA_ACTIVO = 0;

--Eliminar la base de datos y volverla a crear a partir del archivo generado en el punto 8.