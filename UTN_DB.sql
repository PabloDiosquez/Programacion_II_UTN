USE UTN_DB;

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (1, 'Matemática I', 1);

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (2, 'Programación I', 1);

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (3, 'Base de Datos', 2);

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (4, 'Organización de Computadoras', 2);

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (5, 'Matemática II', 3);

INSERT INTO MATERIA (ID_MATERIA, DESCRIPCION, CUATRIMESTRE)
VALUES (6, 'Programación II', 3);

INSERT INTO ALUMNO (NOMBRE, APELLIDO, PROMEDIO, ESTA_ACTIVO, FECHA_INSCRIPCION, FECHA_GRADUACION, TELEFONO, ESTA_GRADUADO, ID_MATERIA)
VALUES
('Lio', 'Messi', 9.8, 1, '1990-12-21', null, '1234 5678', 0, 2),
('Julián', 'Álvarez', 9.2, 1, '1990-12-21', null, '1111 2222', 0, 1),
('Emiliano', 'Martínez', 7.4, 1, '1990-12-21', '1990-12-21', '3333 4444', 1, NULL),
('Marcelo', 'Gallardo', 7.8, 1, '1990-12-21', '1990-12-21', '1234 5677', 1, NULL),
('Juan', 'Riquelme', 7.7, 1, '1990-12-21', null, '8888 4442', 0, 4),
('Javier', 'Saviola', 6.3, 1, '1990-12-21', null, '1234 2272', 0, 6);

-- Consultas 👉🏼 SELECT

SELECT * FROM ALUMNO;

SELECT NOMBRE, APELLIDO, FECHA_INSCRIPCION FROM ALUMNO;

SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE ID_ALUMNO = 18;

-- Alumnos cuyo promedio es mayor a 8.5
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE PROMEDIO > 8.5;

-- Alumnos que NO cursen materias.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE ID_MATERIA IS NULL;

-- Alumnos que tienen teléfono.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE TELEFONO IS NOT NULL;

-- Cláusula LIKE
-- Alumnos cuyo nombre contenga un e.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE NOMBRE LIKE '%e%';

-- Alumnos cuyo nombre empiece con L.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE NOMBRE LIKE 'L%';

-- Alumnos cuyo nombre empiece con E y contenga iano.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE NOMBRE LIKE 'E%iano%';

-- Alumnos cuyo nombre tenga la tercera letra igual a l.
SELECT NOMBRE, APELLIDO 
FROM ALUMNO
WHERE NOMBRE LIKE '__l%'; -- 👉🏼 __ = _ _

-- Alumnos con teléfono y promedio mayor a 7.
SELECT *
FROM ALUMNO
WHERE TELEFONO IS NOT NULL AND PROMEDIO > 7;

-- Alumnos que se hayan graduado o que no estén activos.
SELECT NOMBRE, APELLIDO
FROM ALUMNO
WHERE ESTA_GRADUADO = 1 OR ESTA_ACTIVO = 0;

-- Alumnos que estén activos y que se no hayan recibido o su promedio sea menor a 7.
SELECT * 
FROM ALUMNO
WHERE ESTA_ACTIVO = 1 AND (ESTA_GRADUADO = 0 OR PROMEDIO < 7);

-- Alumnos cuyo promedio esté entre 4 y 7.
SELECT *
FROM ALUMNO
WHERE PROMEDIO BETWEEN 4 AND 7;

-- Alumnos cuyo promedio no esté entre 4 y 7.
SELECT *
FROM ALUMNO
WHERE PROMEDIO NOT BETWEEN 4 AND 7;

-- Materias que sean del 2° o 3° cuatrimestre.
SELECT * 
FROM MATERIA
WHERE CUATRIMESTRE IN (2,3);

-- Ordenar los alumnos por su promedio de manera descendente.
SELECT * 
FROM ALUMNO
ORDER BY PROMEDIO DESC;

-- Ordenar los alumnos por su promedio de manera ascendente.
SELECT * 
FROM ALUMNO
ORDER BY PROMEDIO ASC;

-- Top 3 de los mejores alumnos
SELECT TOP (3) *
FROM ALUMNO
ORDER BY PROMEDIO DESC;

-- ¿Qué curso está tomando cada alumno?
SELECT ID_ALUMNO, APELLIDO, DESCRIPCION
FROM ALUMNO AS A INNER JOIN MATERIA AS M 
ON A.ID_MATERIA = M.ID_MATERIA;

--Todos los alumnos, estén cursando o no, y la materia que están cursando.
SELECT NOMBRE, APELLIDO, DESCRIPCION
FROM ALUMNO A LEFT JOIN MATERIA M
ON A.ID_MATERIA = M.ID_MATERIA;

--Todas las materias y aquellos alumnos que cursan.
SELECT DESCRIPCION, ID_ALUMNO
FROM ALUMNO A RIGHT JOIN MATERIA M
ON A.ID_MATERIA = M.ID_MATERIA;




