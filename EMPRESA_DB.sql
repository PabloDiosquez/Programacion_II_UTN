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
--Los empleados que no tengan mail o no estén activos.
--Los empleados que tengan mail y su nombre contenga la letra "a".
--Los empleados que ganen $250.000,00 o más y hayan ingresado después del año 2000 inclusive, o aquellos que ganen menos de $250.000,00 y hayan ingresado antes del año 2000 sin incluir.
--Los empleados cuyo salario esté entre $100.000,00 y $250.000,00.
--Los empleados cuyo salario NO esté entre $100.000,00 y $250.000,00.
--Los puestos con nivel de autorización 0, 1 o 2.
--Los puestos con nivel de autorización distinto a 0, 1 y 2.

