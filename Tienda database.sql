CREATE DATABASE tiendadb;
USE tiendadb;

--* CREACIÓN DE TABLA PRODUCTOS

CREATE TABLE Productos(
    idProducto INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(255),
    descripcion VARCHAR(255),
    precio DECIMAL(6,2)
);

--* PROCEDIMIENTOS ALMACENADOS

DROP PROCEDURE p_InsertarProducto;
CREATE PROCEDURE p_InsertarProducto(
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _precio DECIMAL(6,2)
)
BEGIN
    INSERT INTO Productos ( nombre, descripcion, precio ) VALUES(
         _nombre, _descripcion, _precio
    );
END;

DROP PROCEDURE p_ModiificarProducto;
CREATE PROCEDURE p_ModiificarProducto(
    IN _idProducto INT,
    IN _nombre VARCHAR(255),
    IN _descripcion VARCHAR(255),
    IN _precio DECIMAL(6,2)
)
BEGIN
    UPDATE Productos SET nombre = _nombre, descripcion = _descripcion, precio = _precio
    WHERE idProducto = _idProducto;
END;

DROP PROCEDURE p_EliminarProducto;
CREATE PROCEDURE p_EliminarProducto(
    IN _idProducto INT
)
BEGIN
    DELETE FROM Productos WHERE idProducto = _idProducto;
END;

SELECT * FROM Productos;