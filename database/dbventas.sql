create database dbventas 
go
USE dbventas

CREATE TABLE cliente( 
	idcliente INT IDENTITY PRIMARY KEY, 
	nombre VARCHAR(20), 
	apellidos VARCHAR(50), 
	dni VARCHAR(10), 
	rfc VARCHAR(13), 
	telefono VARCHAR(15), 
	estado VARCHAR(20) 
)

CREATE TABLE proveedor( 
	idproveedor INT IDENTITY PRIMARY KEY, 
	razonsocial VARCHAR(30), 
	dni VARCHAR(10), 
	rfc VARCHAR(13), 
	telefono VARCHAR(15), 
	direccion VARCHAR(50), 
	estado VARCHAR(20) 
) 


CREATE TABLE categoria( 
	idcategoria INT IDENTITY PRIMARY KEY, 
	descripcion VARCHAR(50) 
) 

CREATE TABLE producto ( 
	idproducto INT IDENTITY PRIMARY KEY, 
	codigo VARCHAR(30), 
	nombre VARCHAR(30), 
	descripcion VARCHAR(50), 
	f_ingreso DATE, 
	f_vencimiento DATE, 
	precio_compra DECIMAL(8,2), 
	precio_venta DECIMAL(8,2), 
	stock INT, 
	estado VARCHAR(20), 
	id_categoria INT REFERENCES categoria (idcategoria) 
) 

CREATE TABLE empleado( 
	idempleado INT IDENTITY PRIMARY KEY, 
	nombre VARCHAR(30), 
	apellidos VARCHAR(50), 
	dni VARCHAR(10), 
	telefono VARCHAR(15), 
	direccion VARCHAR(50), 
	estado VARCHAR(20) 
)


CREATE TABLE usuario ( 
	idusuario INT IDENTITY PRIMARY KEY, 
	usuario VARCHAR(20), 
	pass VARCHAR(20), 
	acceso VARCHAR(20), 
	estado VARCHAR(20), 
	idempleado INT REFERENCES empleado(idempleado) 
) 

CREATE TABLE compra( 
	idcompra INT IDENTITY PRIMARY KEY, 
	fecha DATE, 
	num_documento VARCHAR(7),
	tipo_documento VARCHAR(7), subtotal DECIMAL(8,2), 
	iva DECIMAL(8,2), 
	total DECIMAL(8,2), 
	estado VARCHAR(20), 
	idusuario INT REFERENCES usuario(idusuario), 
	idproveedor INT REFERENCES proveedor(idproveedor) 
)


CREATE TABLE detallecompra ( 
	iddetallecompra INT IDENTITY PRIMARY KEY, 
	cantidad INT, 
	precio DECIMAL(8,2), 
	total DECIMAL(8,2), 
	idcompra INT REFERENCES compra(idcompra), 
	idproducto INT REFERENCES producto(idproducto) 
) 

CREATE TABLE venta ( 
	idventa INT IDENTITY PRIMARY KEY, 
	fecha DATE, serie VARCHAR(7), 
	num_documento VARCHAR(7), 
	tipo_documento VARCHAR(7), 
	subtotal DECIMAL(8,2), 
	iva DECIMAL(8,2), 
	total DECIMAL(8,2), 
	estado VARCHAR(20), 
	idusuario INT REFERENCES usuario(idusuario), 
	idcliente INT REFERENCES cliente(idcliente)	
) 

CREATE TABLE detalleventa( 
	iddetalleventa INT IDENTITY PRIMARY KEY, 
	cantidad INT, 
	precio DECIMAL(8,2), 
	total DECIMAL(8,2), 
	idventa INT REFERENCES venta(idventa), 
	idproducto INT REFERENCES producto(idproducto) 
)

SELECT * FROM usuario
SELECT * FROM cliente