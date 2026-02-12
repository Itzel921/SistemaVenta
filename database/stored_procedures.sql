USE dbventas
GO

-- STORED PROCEDURE PARA LISTAR TODOS LOS CLIENTES
CREATE PROCEDURE splistar_cliente
AS
BEGIN
    SELECT idcliente, nombre, apellidos, dni, rfc, telefono, estado
    FROM cliente
    ORDER BY nombre;
END;
GO

-- STORED PROCEDURE PARA GUARDAR CLIENTE
CREATE PROCEDURE spguardar_cliente
    @nombre VARCHAR(20),
    @apellidos VARCHAR(50),
    @dni VARCHAR(10),
    @rfc VARCHAR(13),
    @telefono VARCHAR(15),
    @estado VARCHAR(20),
    @idcliente INT OUTPUT
AS
BEGIN
    INSERT INTO cliente (nombre, apellidos, dni, rfc, telefono, estado)
    VALUES (@nombre, @apellidos, @dni, @rfc, @telefono, @estado);
    
    SET @idcliente = @@IDENTITY;
END;
GO

-- STORED PROCEDURE PARA EDITAR CLIENTE
CREATE PROCEDURE speditar_cliente
    @idcliente INT,
    @nombre VARCHAR(20),
    @apellidos VARCHAR(50),
    @dni VARCHAR(10),
    @rfc VARCHAR(13),
    @telefono VARCHAR(15),
    @estado VARCHAR(20)
AS
BEGIN
    UPDATE cliente
    SET nombre = @nombre,
        apellidos = @apellidos,
        dni = @dni,
        rfc = @rfc,
        telefono = @telefono,
        estado = @estado
    WHERE idcliente = @idcliente;
END;
GO

-- STORED PROCEDURE PARA ELIMINAR CLIENTE
CREATE PROCEDURE speliminar_cliente
    @idcliente INT
AS
BEGIN
    DELETE FROM cliente
    WHERE idcliente = @idcliente;
END;
GO

-- STORED PROCEDURE PARA BUSCAR POR NOMBRE
CREATE PROCEDURE spbuscar_cliente_nombre
    @nombre VARCHAR(20)
AS
BEGIN
    SELECT idcliente, nombre, apellidos, dni, rfc, telefono, estado
    FROM cliente
    WHERE nombre LIKE '%' + @nombre + '%'
    ORDER BY nombre;
END;
GO

-- STORED PROCEDURE PARA BUSCAR POR DNI
CREATE PROCEDURE spbuscar_cliente_dni
    @dni VARCHAR(10)
AS
BEGIN
    SELECT idcliente, nombre, apellidos, dni, rfc, telefono, estado
    FROM cliente
    WHERE dni LIKE '%' + @dni + '%'
    ORDER BY nombre;
END;
GO

-- INSERTAR DATOS DE PRUEBA
INSERT INTO cliente (nombre, apellidos, dni, rfc, telefono, estado)
VALUES 
    ('Juan', 'Pérez García', '12345678', 'RFC001', '5551234567', 'ACTIVO');

GO