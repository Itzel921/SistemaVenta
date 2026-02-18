USE dbventas

CREATE PROCEDURE SPListar_Categoria
AS
	SELECT * FROM categoria
GO

CREATE PROCEDURE SPBuscar_Categoria
	@Desc VarChar(20)
AS
	SELECT * FROM categoria c
	WHERE c.descripcion LIKE @Desc + '%'
GO

CREATE PROCEDURE SPGuardar_Categoria
	@idCategoria Int Output,
	@Descripcion VarChar(15)
AS
	INSERT INTO categoria(descripcion) VALUES(@Descripcion)
GO


CREATE PROCEDURE SPEditar_Categoria
	@idCategoria Int,
	@Descripcion VarChar(15)
AS
	UPDATE categoria
	SET descripcion = @Descripcion
	WHERE idCategoria = @idCategoria


CREATE PROCEDURE SPEliminar_Categoria
	@idCategoria Int
AS
	DELETE FROM categoria
	WHERE idCategoria = @idCategoria
GO

