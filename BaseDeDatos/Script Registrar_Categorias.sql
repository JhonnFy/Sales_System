
USE dbSistema_Ventas
GO

-- =============================================
-- Script Registrar_Categorias
-- Descripci�n: Inserci�n de categor�as
-- Proyecto: Sistema de Inventario
-- Prop�sito: Garantizar que la tabla 'Categorias' cuente con los datos m�nimos requeridos en entornos nuevos o de desarrollo
-- Fecha: 24-Jul-2025
-- Autor: JhonFy
-- =============================================
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Aseo',1) 
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Carnes',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Pollos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Pescados',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Frutas',1)

SELECT * FROM CATEGORIA
GO
