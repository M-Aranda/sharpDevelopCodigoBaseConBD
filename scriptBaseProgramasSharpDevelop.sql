CREATE DATABASE BDdePrueba
GO --DROP DATABASE BDdePrueba

CREATE TABLE nacionalidad(
id INT IDENTITY,
nombre VARCHAR (20),
PRIMARY KEY (id)
)
GO

INSERT INTO nacionalidad VALUES ('Chile')
GO

SELECT * FROM nacionalidad;

USE BDdePrueba
GO