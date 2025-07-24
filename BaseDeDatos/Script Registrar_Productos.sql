USE dbSistema_Ventas
GO

-- =============================================
-- Script Registrar_Productos
-- Descripción: Inserción de Productos
-- Proyecto: Sistema de Inventario
-- Propósito: Garantizar que la tabla 'Productos' cuente con los datos mínimos requeridos para las IGU
-- Fecha: 24-Jul-2025
-- Autor: JhonFy
-- =============================================

--DBCC CHECKIDENT (PRODUCTO, RESEED, 0);

SELECT * FROM PRODUCTO
--🧼 1. Aseo
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_1','Clorox Cloro Tradicional Desinfectante','Limpieza profunda y eliminación de gérmenes',1,50,3000,4900,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_2','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_3','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_4','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_5','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_6','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_7','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_8','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_9','','',1,50,,,1)
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('C1_10','','',1,50,,,1)
	



 


