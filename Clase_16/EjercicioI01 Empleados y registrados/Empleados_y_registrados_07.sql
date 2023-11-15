USE EMPRESA_DB;

-- Consulta 1: Agregar el mail 'mbrock@yahoo.com' a Maya Brock filtrando por su ID_EMPLEADO.
UPDATE EMPLEADOS
SET EMAIL = 'mbrock@yahoo.com'
WHERE ID_EMPLEADO = 4;

-- Consulta 2: Cambiar el puesto de Maya Brock a Administrativo y su salario a $210,000.00.
UPDATE EMPLEADOS
SET ID_PUESTO = 4, SALARIO = 210000.00
WHERE ID_EMPLEADO = 4;

-- Consulta 3: Mostrar todos los empleados después de realizar las actualizaciones anteriores.
SELECT * FROM EMPLEADOS;

-- Consulta 4: Dar un aumento del 25% a todos los empleados que ganen menos de $250,000.00.
UPDATE EMPLEADOS
SET SALARIO = SALARIO * 1.25
WHERE SALARIO < 250000.00;

-- Consulta 5: Hacer una baja lógica del empleado con ID = 2, cargando su fecha de baja.
UPDATE EMPLEADOS
SET ESTA_ACTIVO = 0, FECHA_BAJA = GETDATE()
WHERE ID_EMPLEADO = 2;

-- Consulta 6: Hacer una baja física de todos los empleados que no estén activos.
UPDATE EMPLEADOS
SET FECHA_BAJA = GETDATE()
WHERE ESTA_ACTIVO = 0;

-- Consulta 7: Mostrar todos los empleados después de realizar las actualizaciones anteriores.
SELECT * FROM EMPLEADOS;