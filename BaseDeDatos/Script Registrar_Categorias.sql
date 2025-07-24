
USE dbSistema_Ventas
GO

-- =============================================
-- Script Registrar_Categorias
-- Descripción: Inserción de categorías
-- Proyecto: Sistema de Inventario
-- Propósito: Garantizar que la tabla 'Categorias' cuente con los datos mínimos requeridos para las IGU
-- Fecha: 24-Jul-2025
-- Autor: JhonFy
-- =============================================
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Aseo',1) 
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Carnes',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Pollos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Pescados',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Frutas',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Verduras',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Congelados',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Lacteos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Huevos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Panaderia',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Reposteria',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Jugos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Gaseosas',1)
INSERT INTO CATEGORIA (Descripcion ,Estado) VALUES ('CuidadoPersonal',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Cosmetica',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Despensa',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Especias',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('AceitesVinagresAderezos',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('HigieneFemenina',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Maternidad',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Escolares',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Mascotas',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('BebidasEnergeticas',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Cafe',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('BebidasAlcoholicas',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Enlatados',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Refrigerados',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Desechables',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Aromatizantes',1)
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Salud',1)


SELECT * FROM CATEGORIA
GO
