-- Selecciona la base de datos
USE EMPRESA_DB;

-- Inserta datos en la tabla de empleados
INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_PUESTO, SALARIO, ESTA_ACTIVO, FECHA_ALTA, FECHA_BAJA, EMAIL)
VALUES 
    -- Empleado 1
    ('Leilani', 'Kinney', 1, 383946.80, 1, '1996-03-21', NULL, 'lkinney@gmail.com'),

    -- Empleado 2
    ('Igor', 'England', 5, 283558.85, 1, '2013-03-28', NULL, 'iengland@hotmail.com'),

    -- Empleado 3
    ('Maya', 'Brock', 3, 164546.09, 1, '1993-10-24', NULL, NULL),

    -- Empleado 4
    ('Hayden', 'Moss', 4, 211695.50, 0, '2012-06-07', '2015-02-19', 'hmoss@gmail.com'),

    -- Empleado 5
    ('Amal', 'Colon', 2, 388933.60, 0, '2019-09-23', NULL, NULL);

-- Inserta datos en la tabla de puestos
INSERT INTO PUESTOS (ID_PUESTO, NOMBRE, NIVEL_AUTORIZACION)
VALUES 
    -- Puesto 1
    (1, 'Director', 3),

    -- Puesto 2
    (2, 'Gerente', 3),

    -- Puesto 3
    (5, 'Jefe de sector', 2),

    -- Puesto 4
    (4, 'Administrativo', 1),

    -- Puesto 5
    (3, 'Vendedor', 0),

    -- Puesto 6
    (6, 'Secretario', 2);