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


CREATE PROCEDURE SPListar_Producto
AS
	SELECT P.idproducto, P.codigo, P.nombre, P.descripcion, P.f_ingreso, P.f_vencimiento, P.precio_compra, P.precio_venta, P.stock, P.estado, P.id_categoria, C.descripcion 
	AS categoria
	FROM categoria C INNER JOIN producto P ON C.idcategoria = P.id_categoria




CREATE PROCEDURE SPBuscar_Producto_codigo
@codigo varchar(30)
AS
	SELECT P.idproducto, P.codigo, P.nombre, P.descripcion, 
	P.f_ingreso, P.f_vencimiento, P.precio_compra, 
	P.precio_venta, P.stock, P.estado, 
	P.id_categoria, C.descripcion AS categoria
	FROM categoria C INNER JOIN producto P ON C.idcategoria = P.id_categoria
	WHERE P.codigo LIKE @codigo
	ORDER BY P.idproducto




CREATE PROCEDURE SPBuscar_Producto_nombre
@nombre varchar(30)
AS
	SELECT P.idproducto, P.codigo, P.nombre, P.descripcion, 
	P.f_ingreso, P.f_vencimiento, P.precio_compra, 
	P.precio_venta, P.stock, P.estado, 
	P.id_categoria, C.descripcion AS categoria
	FROM categoria C INNER JOIN producto P ON C.idcategoria = P.id_categoria
	WHERE P.nombre LIKE @nombre + '%'
	ORDER BY P.idproducto


CREATE PROCEDURE SPGuardar_Producto
	@idproducto int output,
	@codigo varchar(30),
	@nombre varchar(30),
	@descripcion varchar(50),
	@f_ingreso date,
	@f_vencimiento date,
	@precio_compra decimal(8,2),
	@precio_venta decimal(8,2),
	@stock int,
	@estado varchar(10),
	@id_categoria int
AS
BEGIN
	INSERT INTO producto(codigo, nombre, descripcion,f_ingreso, f_vencimiento, precio_compra, precio_venta, stock, estado, id_categoria)
	VALUES(@codigo, @nombre, @descripcion, @f_ingreso, @f_vencimiento, @precio_compra, @precio_venta, @stock, @estado, @id_categoria)
	
	SET @idproducto = @@IDENTITY
END;
GO




CREATE PROCEDURE SPEditar_Producto
	@idproducto int output,
	@codigo varchar(30),
	@nombre varchar(30),
	@descripcion varchar(50),
	@f_ingreso date,
	@f_vencimiento date,
	@precio_compra decimal(8,2),
	@precio_venta decimal(8,2),
	@stock int,
	@estado varchar(10),
	@id_categoria int
AS
	UPDATE producto
		SET codigo = @codigo,
			nombre = @nombre,
			descripcion = @descripcion,
			f_ingreso = @f_ingreso,
			f_vencimiento = @f_vencimiento,
			precio_compra = @precio_compra,
			precio_venta = @precio_venta,
			stock = @stock,
			estado = @estado,
			id_categoria = @id_categoria
		WHERE idproducto = @idproducto



CREATE PROCEDURE SPEliminar_Producto
	@idproducto int
AS
	DELETE FROM producto WHERE idproducto = @idproducto
GO


SELECT * FROM producto