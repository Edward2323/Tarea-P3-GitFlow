CREATE DATABASE Losquatrohermaos
	
use master
use Losquatrohermanos

CREATE TABLE Empleados (
Id_Empleado INT PRIMARY KEY,
Nom_Empleado VARCHAR(50),
);

CREATE TABLE Empleados_Usuarios (
Id_Empleado INT FOREIGN KEY  REFERENCES Empleados(Id_Empleado),
Usuario VARCHAR(30),
contra VARCHAR(50)
);

CREATE TABLE Puesto (
Id_Puesto INT PRIMARY KEY,
Puesto VARCHAR(50),
Sueldo INT
);

CREATE TABLE Producto_tipo( 
Id_Tipo INT IDENTITY PRIMARY KEY,
tipo VARCHAR(30)
);

CREATE TABLE Proveedor(
Id_proveedor INT PRIMARY KEY,
proveedor VARCHAR(30),
);

CREATE TABLE Productos (
Id_Producto INT PRIMARY KEY,
Nom_Producto VARCHAR(50),
Id_proveedor INT FOREIGN KEY REFERENCES Proveedor(Id_proveedor),
Id_Tipo INT FOREIGN KEY REFERENCES Producto_tipo(Id_Tipo)
);

CREATE TABLE Producto_coste(
Id_proveedor INT FOREIGN KEY REFERENCES Proveedor(Id_proveedor),
Id_producto INT FOREIGN KEY REFERENCES Productos(Id_producto),
Coste_docena FLOAT
);

CREATE TABLE Producto_Precio (
Id_Producto INT FOREIGN KEY REFERENCES Productos(Id_Producto),
Precio INT
);

CREATE TABLE Sucursal (
Id_Sucursal INT PRIMARY KEY,
Direccion VARCHAR(50)
);

CREATE TABLE Empleado_Puesto (
Id_Sucursal INT FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),
Id_Empleado INT FOREIGN KEY REFERENCES Empleados(Id_Empleado),
Id_Puesto INT FOREIGN KEY REFERENCES Puesto(Id_Puesto)
);

CREATE TABLE Inventario (
Id_Inventario INT PRIMARY KEY,
Id_Sucursal INT FOREIGN KEY REFERENCES Sucursal(Id_Sucursal),
);

CREATE TABLE stock_suc1 (
Id_Producto INT FOREIGN KEY REFERENCES Productos(Id_Producto),
Cantidad INT
);

CREATE TABLE stock_suc2 (
Id_Producto INT FOREIGN KEY REFERENCES Productos(Id_Producto),
Cantidad INT
);

CREATE TABLE stock_suc3 (
Id_Producto INT FOREIGN KEY REFERENCES Productos(Id_Producto),
Cantidad INT
);

Drop table Proveedor
Drop table Productos
Drop table stock_suc1
Drop table stock_suc2
Drop table stock_suc3
Drop table Producto_Precio
Drop table Producto_coste

--tabla de productos eliminados

CREATE TABLE pro_eliminados (Id_pro INT,
nom_pro varchar(30),
Id_proveedor INT,
Id_tipo INT,
fecha DATE)






INSERT INTO Empleados(Id_Empleado,Nom_Empleado)
VALUES
(1, 'Pedro'),
(2, 'Julio'),
(3, 'Marta'),
(4, 'Sofia'),
(5, 'Eduardo'),
(6, 'Colon'),
(7, 'Junior'),
(8, 'Tolentino'),
(9, 'Abstato'),
(10, 'Zael'),
(11, 'Andri'),
(12, 'Pinga'),
(13, 'Raul'),
(14, 'Katy')

INSERT INTO Puesto(Id_puesto, puesto, sueldo)
VALUES
(1, 'Supervisor', 30000),
(2, 'Cajero', 20000),
(3, 'Empacador', 4000),
(4, 'Conserje', 4000)

INSERT INTO Producto_tipo(id_tipo, tipo)
VALUES
(1, 'Embutidos'),
(2, 'Verduras'),
(3, 'Frutas'),
(4, 'Pro.Limpieza'),
(5, 'Higiene'),
(6, 'Bebidas'),
(7, 'Chips'),
(8, 'Snacks')

INSERT INTO Proveedor(Id_proveedor, proveedor)
VALUES
(7,'Rica'),
(8,'Induveca'),
(9,'Gillete'),
(10,'Colgate'),
(12,'Suplisol S.R.L')

INSERT INTO Productos(Id_Producto, Nom_Producto, Id_proveedor, Id_Tipo)
VALUES
(1, 'Salami', 8, 1),
(2, 'Salami Real de pavo', 8, 1),
(3, 'Salami Chips con Platanitos', 8, 7),
(4, 'Maquina de afeitar clasica', 9, 5),
(5, 'Gel de afeitar', 9, 5),
(6, 'Cepillo Dental Colgate 360', 10, 5),
(7, 'Pasta Dental Colgate Total 12', 10, 5),
(8, '100% Jugo de Naranja Rica', 7, 6),
(9, 'Queso Gouda Rica', 7, 1),
(10, 'Listamilk Rica', 7, 6),
(11, 'Desifectante Fabuloso', 12, 4),
(12, 'Fabuloso Aroma de Bebe', 12, 4),
(13, 'Limpiador Fabuloso Natural Essentials Eucalipto', 12, 4)

INSERT INTO Producto_coste(Id_proveedor, Id_producto, Coste_docena )
VALUES 
(7, 8, 648),
(7, 9, 1080),
(7, 10, 624),
(12, 11, 864),
(12, 12, 1056),
(12, 13, 1308),
(10, 6, 240),
(10, 7, 504),
(9, 4, 228),
(9, 5, 588),
(8, 1, 612),
(8, 2, 1068),
(8, 3, 264)

INSERT INTO Producto_Precio (Id_Producto ,Precio)
VALUES
(1, 60),
(2, 160),
(3, 30),
(4, 25),
(5, 50),
(6, 25),
(7, 50),
(8, 70),
(9, 155),
(10, 60),
(11, 80),
(12, 170),
(13, 180)

INSERT INTO Sucursal (Id_Sucursal, Direccion )
VALUES
(111, 'DN, AV.Mexico'),
(112, 'Santiago, Call.Duarte '),
(113, 'SD Este, AV.Las americas')

INSERT INTO Empleado_Puesto (Id_Sucursal , Id_Empleado, Id_Puesto)
VALUES
(111, 1, 1),
(111, 2, 2),
(111, 3, 2),
(111, 4, 3),
(111, 5, 4),
(112, 6, 1),
(112, 7, 2),
(112, 8, 3),
(112, 9, 4),
(113, 10, 1),
(113, 11, 2),
(113, 12, 2),
(113, 13, 3),
(113, 14, 4)

INSERT INTO Inventario (Id_Inventario, Id_Sucursal)
VALUES
(201, 111),
(202, 112),
(203, 113)

INSERT INTO Cantidad ( Id_Inventario, Id_Producto, Cantidad)
VALUES
(201, 1, 30),(201, 2, 23),(201, 3, 17),(201, 4, 3),(201, 5, 44),(201, 6, 47),
(201, 7, 60),(201, 8, 33),(201, 9, 41),(201, 10, 11),(201, 11, 15),
(201, 12, 54),(201, 13, 58),
(202, 1, 3),(202, 2, 56),(202, 3, 45),(202, 4, 30),(202, 5, 13),(202, 6, 65),
(202, 7, 51),(202, 8, 34),(202, 9, 43),(202, 10, 38),(202, 11, 4),
(202, 12, 14),(202, 13, 45),
(203, 1, 44),(203, 2, 34),(203, 3, 14),(203, 4, 54),(203, 5, 24),(203, 6, 26),
(203, 7, 60),(203, 8, 51),(203, 9, 38),(203, 10, 45),(203, 11, 15),
(203, 12, 56),(203, 13, 6)

INSERT INTO Empleados_Usuarios values(1,'pedro','1234');
INSERT INTO Empleados_Usuarios values(1,'julio','12julio34');


select * from productos
select * from Cantidad
select * from Producto_tipo
select * from Producto_Precio
select * from Producto_coste
select * from Proveedor
select * from Inventario
select * from Sucursal
select * from Empleados_Usuarios
select * from Empleado_Puesto
select * from Puesto



update Producto_coste
SET id_Producto = 13
where Id_proveedor = 12 and Coste_docena= 1308

--1
SELECT Id_Producto, Nom_Producto
FROM Productos

--2
SELECT Nom_Producto
FROM Productos
WHERE Nom_Producto LIKE 'R%' OR  Nom_Producto LIKE 'M%'

--3
SELECT Id_Producto,Nom_Producto
FROM Productos
WHERE Id_Producto LIKE '%5%' OR  Id_Producto LIKE '%3%'

--4
SELECT Id_Tipo, tipo
FROM Producto_tipo

--5
SELECT Id_Producto, Nom_Producto, tipo
FROM Productos
JOIN Producto_tipo ON Productos.Id_Tipo = Producto_tipo.Id_Tipo

--6 
SELECT MIN(Sueldo)  AS SALARIO_MINIMO, MAX(Sueldo) AS SALARIO_MAXIMO
FROM Puesto

--7 
SELECT Producto_coste.Id_proveedor, Proveedor.proveedor, MAX(Coste_docena) AS Maximo, MIN(Coste_docena) AS Minimo
FROM Producto_coste
JOIN Proveedor ON Producto_coste.Id_proveedor = Proveedor.Id_proveedor
GROUP BY Producto_coste.Id_proveedor, Proveedor.proveedor

--8
SELECT Id_Producto, Nom_Producto
FROM Productos
WHERE Nom_Producto LIKE '%Fabuloso%'

--9
SELECT Id_proveedor, SUM(Producto_coste.Coste_docena) AS TOTAL
FROM Producto_coste
GROUP BY Id_proveedor

------------
--Vistas
------------
CREATE VIEW Vista_Proveedor 
AS
SELECT Id_proveedor, proveedor
FROM Proveedor;

SELECT * FROM Vista_Proveedor

---------------------------------------------------------
CREATE VIEW Precios_Encima_150 
WITH ENCRYPTION
AS
SELECT 
Productos.Id_Producto, 
Nom_Producto, 
Precio
FROM Productos
INNER JOIN Producto_Precio ON Productos.Id_Producto = Producto_Precio.Id_Producto
WHERE Precio > 150
GO

EXEC sp_helptext 'Precios_Encima_150';

SELECT * FROM Precios_Encima_150 
-------------------------------------

CREATE VIEW costes_y_ventas
WITH ENCRYPTION
AS
SELECT Producto_coste.Id_producto,
Coste_docena,
Precio*12 as precio_docena,
Precio*12-Coste_docena as beneficio
FROM Producto_coste
join Producto_Precio on Producto_coste.Id_producto=Producto_Precio.Id_Producto 


------------------------------------
TRIGGERS
------------------------------------
CREATE TRIGGER TR_PRODUCTOS ON productos
AFTER INSERT
AS
BEGIN
	print('Se insertaron datos en la tabla productos')
END;


INSERT INTO Productos(Id_Producto,	Nom_Producto) VALUES (100, 'MI pan')
---------------------------------------------------------------------------

CREATE TRIGGER TR_PRODUCTOSDL
ON productos
AFTER DELETE
AS
BEGIN
    INSERT INTO pro_eliminados(Id_pro, nom_pro, Id_proveedor, Id_tipo, fecha)
	SELECT Id_Producto, Nom_Producto, Id_proveedor, Id_tipo, GETDATE() FROM deleted

	print('SE ELIMINO UN DATO :O')
END


DELETE  FROM Productos WHERE Id_Producto = 100
SELECT * FROM pro_eliminados
--------------------------------------------------------------------------------------
CREATE TRIGGER AYUDA_PRODUCTOSDL
ON pro_eliminados
AFTER INSERT
AS
BEGIN
	IF EXISTS (
        SELECT 1
        FROM pro_eliminados AS t
        JOIN inserted AS i ON t.Id_pro = i.Id_pro
        GROUP BY t.Id_pro
        HAVING COUNT(*) > 1
    )
    BEGIN
        
        UPDATE t
        SET t.Id_pro = i.Id_pro
        FROM pro_eliminados AS t
        JOIN inserted AS i ON t.Id_pro = i.Id_pro
    END
END

-----------------------------------------------

CREATE TRIGGER TR_SUCURSAL
ON sucursal
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
		BEGIN
			PRINT('SE INSERTO UN REGISTRO')
		END
----------
	IF EXISTS (SELECT * FROM deleted) AND NOT EXISTS (SELECT * FROM inserted)
		BEGIN
			PRINT('SE ELIMINO UN REGISTRO')
		END
----------
	IF EXISTS(SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
		BEGIN
			PRINT('SE ACTUALIZO UN REGISTRO')
		END
END
------------------------------------------------------------------


INSERT INTO Sucursal VALUES(100, 'do equina pa lla')

UPDATE Sucursal
SET Direccion = 'no por ahi no compae'
WHERE Id_Sucursal = 100

DELETE FROM Sucursal WHERE Id_Sucursal = 100

--Activar triggers

ENABLE TRIGGER TR_PRODUCTOS on productos

ENABLE TRIGGER TR_PRODUCTOSDL on productos

ENABLE TRIGGER AYUDA_PRODUCTOSDL on pro_eliminados
---------------------------------------------------

--Desactivar triggers

DISABLE TRIGGER TR_PRODUCTOS on productos

DISABLE TRIGGER TR_PRODUCTOSDL on productos

DISABLE TRIGGER AYUDA_PRODUCTOSDL on pro_eliminados
---------------------------------------------------


---------------------------------------------------

--TABLAS TEMPORALES

--Table temporal Global
CREATE TABLE ##Productos_NoStock_Sucursal_Santiago_Call_Duarte_Y_DN_AV_Mexico(
Id_Producto INT PRIMARY KEY, 
Nombre_Producto VARCHAR(255),
Cantidad INT
);

--Tabla temporal Local
CREATE TABLE #Productos_SiStock_Sucursal_Santiago_Call_Duarte(
Id_Producto INT PRIMARY KEY, 
Nombre_Producto VARCHAR(255),
Cantidad INT
);

--Insertar valores de los productos sin stock
INSERT INTO ##Productos_NoStock_Sucursal_Santiago_Call_Duarte_Y_DN_AV_Mexico
SELECT Cantidad.Id_Producto, Productos.Nom_Producto, Cantidad
FROM Cantidad
INNER JOIN Productos ON Productos.Id_Producto = Cantidad.Id_Producto
WHERE Id_Inventario < 203 AND Cantidad < 15
ORDER BY Cantidad.Id_Producto

--Insertar valores de los productos con stock
INSERT INTO #Productos_SiStock_Sucursal_Santiago_Call_Duarte
SELECT Cantidad.Id_Producto, Productos.Nom_Producto, Cantidad
FROM Cantidad
INNER JOIN Productos ON Productos.Id_Producto = Cantidad.Id_Producto
WHERE Id_Inventario = 202 AND Cantidad > 15

--Mostrando el contenido de la tablas temporales
SELECT * FROM ##Productos_NoStock_Sucursal_Santiago_Call_Duarte_Y_DN_AV_Mexico
SELECT * FROM #Productos_SiStock_Sucursal_Santiago_Call_Duarte

-----INDICES-------

CREATE INDEX IX_Productos_Id_Producto ON Productos (Id_Producto);

-- Crear un índice único 
CREATE UNIQUE INDEX UX_Empleado_Puesto_Id_Sucursal_Id_Empleado ON Empleado_Puesto (Id_Sucursal, Id_Empleado);

-- Crear un índice compuesto 
CREATE INDEX IX_Cantidad_Id_Inventario_Id_Producto ON Cantidad (Id_Inventario, Id_Producto);

-- Columnas indexadas en la tabla Cantidad
SELECT Id_Producto, Cantidad
FROM Cantidad
WHERE Id_Inventario = 201;








--CREACION PROCEDMIENTO ALMACENADO

CREATE PROCEDURE Obtener_Codigo_Precios_MAX
	@precio INT, 
	@Idproducto INT

AS
BEGIN
	SELECT *
	FROM Producto_Precio
	WHERE Precio >= @precio AND Id_Producto > @Idproducto;
END;

EXEC Obtener_Codigo_Precios_MAX @precio = 50, @Idproducto = 3
---------------------------------------------------


--MODIFICACION PROCEDMIENTO ALMACENADO
---------------------------------------------------
ALTER PROCEDURE Obtener_Codigo_Precios_MAX
	@precio INT, 
	@coste_docena INT
AS
BEGIN
    SELECT producto_precio.Id_Producto, Producto_Precio.Precio,
	Producto_coste.Coste_docena
	FROM Producto_Precio
	JOIN Producto_coste ON Producto_Precio.Id_Producto = Producto_coste.Id_producto
	WHERE Producto_Precio.Precio > @precio
	AND
	Producto_coste.Coste_docena > @coste_docena
END;

EXEC Obtener_Codigo_Precios_MAX @precio = 50, @coste_docena = 1001
------------------------------------------------------



--CREACION DE SEGUNDO PROCEDIMIENTO ALMACENADO
------------------------------------------------------

CREATE PROCEDURE PRODUCTO_DESCUENTO
	@idproducto INT,
	@DESCUENTO FLOAT,
	@OUTPUT1 FLOAT OUTPUT,
	@OUTPUT2 FLOAT OUTPUT,
	@OUTPUT3 VARCHAR(100) OUTPUT
AS
BEGIN
		--VARIABLES
		DECLARE @NOMBRE VARCHAR (100);
		DECLARE @RESULTADO1 FLOAT;
		DECLARE @PRECIO FLOAT;
		DECLARE @PRECIO_FINAL FLOAT;

		--PRECIO Y NOMBRE
		SELECT @PRECIO = precio FROM Producto_Precio
		WHERE Id_Producto = @idproducto;

		SELECT @NOMBRE = Nom_Producto FROM Productos
		WHERE Id_Producto = @idproducto;

		PRINT @NOMBRE

		--DESCUENTO
		SET @RESULTADO1 = @PRECIO * @DESCUENTO;

		--PRECIO FINAL RESTANDOLE EL DESCUENTO
		SET @PRECIO_FINAL = @PRECIO - @RESULTADO1

		--ASIGNACION DE RESULTADOS A LAS VARIABLES DE SALIDA
		SET @OUTPUT1 = @RESULTADO1
		SET @OUTPUT2 = @PRECIO_FINAL
		SET @OUTPUT3 = @NOMBRE

		--IMPRESION DE LOS RESULTADOS
		PRINT 'LA CANTIDAD DESCONTADA ES: ' + CAST(@OUTPUT1 AS VARCHAR);
		PRINT 'EL PRECIO FINAL DEL PRODUCTO ' + @OUTPUT3 + ' ES: ' + CAST(@OUTPUT2 AS VARCHAR)
END
--DECLARACION DE VARIABLES QUE TOMARAN LAS SALIDAS
DECLARE @NOM VARCHAR(100)
DECLARE @DESC FLOAT 
DECLARE @FINAL FLOAT

--EJECUCION Y ASIGNACION DE PARAMETROS
EXEC PRODUCTO_DESCUENTO @idproducto = 5, @DESCUENTO = 0.50, @OUTPUT1 = @DESC,
@OUTPUT2 = @FINAL, @OUTPUT3 = @NOM



--MODIFICACION DE SEGUNDO PROCEDIMIENTO ALMACENADO
-------------------------------------------------
ALTER PROCEDURE PRODUCTO_DESCUENTO
	@idproducto INT,
	@DESCUENTO FLOAT,
	@OUTPUT1 FLOAT OUTPUT,
	@OUTPUT2 FLOAT OUTPUT,
	@OUTPUT3 VARCHAR(100) OUTPUT,
	@OUTPUT4 FLOAT OUTPUT
AS
BEGIN
		--VARIABLES
		DECLARE @NOMBRE VARCHAR (100);
		DECLARE @RESULTADO1 FLOAT;
		DECLARE @PRECIO FLOAT;
		DECLARE @PRECIO_FINAL FLOAT;

		--PRECIO Y NOMBRE
		SELECT @PRECIO = precio FROM Producto_Precio
		WHERE Id_Producto = @idproducto;

		SELECT @NOMBRE = Nom_Producto FROM Productos
		WHERE Id_Producto = @idproducto;

		--DESCUENTO
		SET @RESULTADO1 = @PRECIO * @DESCUENTO;

		--PRECIO FINAL RESTANDOLE EL DESCUENTO
		SET @PRECIO_FINAL = @PRECIO - @RESULTADO1

		--ASIGNACION DE RESULTADOS A LAS VARIABLES DE SALIDA
		SET @OUTPUT1 = @RESULTADO1
		SET @OUTPUT2 = @PRECIO_FINAL
		SET @OUTPUT3 = @NOMBRE
		SET @OUTPUT4 = @PRECIO

		--IMPRESION DE LOS RESULTADOS
		PRINT 'EL PRECIO DEL PRODUCTO ' + @OUTPUT3 + ' ES ' +CAST(@OUTPUT4 AS VARCHAR)
		PRINT 'LA CANTIDAD DESCONTADA ES: ' + CAST(@OUTPUT1 AS VARCHAR);
		PRINT 'EL PRECIO FINAL DEL PRODUCTO ' + @OUTPUT3 + ' ES: ' + CAST(@OUTPUT2 AS VARCHAR)
END

DECLARE @NOM VARCHAR(100)
DECLARE @DESC FLOAT 
DECLARE @FINAL FLOAT
DECLARE @PREC FLOAT

--EJECUCION Y ASIGNACION DE PARAMETROS
EXEC PRODUCTO_DESCUENTO @idproducto = 7, @DESCUENTO = 0.30, @OUTPUT1 = @DESC,
@OUTPUT2 = @FINAL, @OUTPUT3 = @NOM, @OUTPUT4 = @PREC

------nuevos usuarios y sus roles-------

create login pollo with password = '1234'

create user pollo for login pollo
with DEFAULT_SCHEMA = dbo

alter role db_ddladmin
add member pollo

----------------------------------------------

create login mondongo with password = '4321'

create user mondongo for login mondongo
with DEFAULT_SCHEMA = dbo

alter role db_datawriter
add member mondongo


---------------prueba-de-permisos-----------------

create table emplea2(id int primary key, nombre varchar(50))

drop table emplea2

insert into emplea2(id,nombre)
values
(1,'pollo'),
(2,'mondongo'),
(3,'None')

update emplea2
set nombre='pavo'
where id = 3

delete from emplea2
where id = 2

select* from emplea2








delete from Productos where Id_Producto = 15



SELECT * FROM Productos
SELECT * FROM Producto_coste
SELECT * FROM Producto_Precio
SELECT * FROM pro_eliminados

DELETE FROM Cantidad 
DELETE FROM Producto_Precio
DELETE FROM Producto_coste

TRUNCATE TABLE productos
DELETE FROM Productos
