-- Documentación del script SQL

-- Este comando indica que se va a trabajar con la base de datos "BD_I01"
USE BD_I01;

-- Esta es una sentencia SQL de inserción que agrega registros a la tabla "PERSONA".
-- Cada registro tiene tres valores: ID, NOMBRE y APELLIDO.

INSERT INTO PERSONA (ID, NOMBRE, APELLIDO)
VALUES 
    (1, 'Luke', 'Skywalker'),
    (2, 'Harry', 'Potter'),
    (3, 'Indiana', 'Jones'),
    (4, 'Ellen', 'Ripley'),
    (5, 'Marty', 'McFly'),
    (6, 'Hannibal', 'Lecter'),
    (7, 'Princess', 'Leia'),
    (8, 'James', 'Bond'),
    (9, 'Hermione', 'Granger'),
    (10, 'Tony', 'Stark');