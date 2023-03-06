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
('Leilani', 'Kinney', 'Director', 383946.80, 1, '1996-03-21', NULL, 'lkinney@gmail.com'),
('Igor', 'England', 'Jefe de Sector', 283558.85, 1, '2013-02-28', NULL, 'iengland@hotmail.com'),
('Maya', 'Brock', 'Vendedor', 164546.09, 1, '1993-10-24', NULL, NULL),
('Hayden', 'Moss', 'Administrativo', 212695.50, 0, '2012-06-07', '2015-02-10', 'hmoss@gmail.com'),
('Amal', 'Colon', 'Gerente', 388933.60, 1, '2019-09-03', NULL, NULL);