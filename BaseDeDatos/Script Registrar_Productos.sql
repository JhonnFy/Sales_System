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


--🧼 1. Aseo
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO001', 'Clorox Cloro Tradicional Desinfectante', 'Presentación: 1000 ml', 1, 50, 3000, 4900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO002', 'Lysol Aerosol Lavanda Antibacterial', 'Presentación: 400 ml', 1, 50, 6800, 9900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO003', 'Elite Papel Higiénico Triple Hoja', 'Presentación: 24 und', 1, 50, 18000, 24900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO004', 'Mr. Músculo Limpiavidrios Antiempañante', 'Presentación: 500 ml', 1, 50, 5200, 7500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO005', 'Fab Detergente Líquido Floral para Ropa', 'Presentación: 2000 ml', 1, 50, 11500, 15900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO006', 'Suavitel Aromas de Primavera Suavizante', 'Presentación: 1800 ml', 1, 50, 8500, 12500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO007', 'Ajax Limón Limpiador Multiusos', 'Presentación: 1000 ml', 1, 50, 4200, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO008', 'Brasso Limpiador de Metales', 'Presentación: 200 ml', 1, 50, 6000, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO009', 'Scotch-Brite Esponja Multiuso Verde', 'Presentación: 2 und', 1, 50, 2200, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ASEO010', 'Harpic Active Fresh Floral Inodoro', 'Presentación: 750 ml', 1, 50, 4800, 7200, 1);
--🥩 2. Carnes
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES001', 'Ranchera Lomo de Res', 'Presentación 500 g', 2, 100, 18000, 22000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES002', 'Colanta Carne Molida', 'Presentación 1000 g', 2, 100, 14500, 18500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES003', 'Zenu Costilla de Cerdo', 'Presentación 700 g', 2, 100, 16000, 19900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES004', 'Supercerdo Chatas de Res', 'Presentación 600 g', 2, 100, 17000, 21000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES005', 'Campollo Chicharrón Carnudo', 'Presentación 500 g', 2, 100, 13000, 16500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES006', 'Carnes Frías Pietrán Lomo Ahumado', 'Presentación 400 g', 2, 100, 15800, 19900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES007', 'La Fazenda Entrecot de Res', 'Presentación 500 g', 2, 100, 19000, 23900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES008', 'Frisby Costillas BBQ', 'Presentación 600 g', 2, 100, 17500, 22000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES009', 'Zenu Lomo de Cerdo Adobado', 'Presentación 800 g', 2, 100, 15500, 19500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CARNES010', 'Resplandor Bistec de Res', 'Presentación 1000 g', 2, 100, 18500, 23000, 1);
--🍗 3. Pollo
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS001', 'Kokoriko Pechuga de Pollo', 'Presentación 1000 g', 3, 100, 13500, 16800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS002', 'Campollo Alas BBQ', 'Presentación 800 g', 3, 100, 12000, 15500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS003', 'Zenu Nuggets de Pollo', 'Presentación 500 g', 3, 100, 9800, 12400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS004', 'Avícola Nacional Pollo Entero', 'Presentación 2000 g', 3, 100, 16000, 19900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS005', 'Pimpollo Filete de Pechuga', 'Presentación 750 g', 3, 100, 12500, 15900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS006', 'Superpollo Hamburguesa de Pollo', 'Presentación 600 g', 3, 100, 8900, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS007', 'La Fazenda Muslos de Pollo', 'Presentación 1000 g', 3, 100, 11000, 14500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS008', 'Friko Alitas BBQ Picantes', 'Presentación 650 g', 3, 100, 12200, 15800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS009', 'Zenu Trocitos de Pollo Apanado', 'Presentación 450 g', 3, 100, 9700, 12800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('POLLOS010', 'Kokoriko Pechuga Marinada', 'Presentación 1000 g', 3, 100, 14000, 17500, 1);
--🦈4. Pescados
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS001', 'Pesquera del Mar Filete de Tilapia', 'Presentación 1000 g', 4, 100, 16500, 19800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS002', 'Marfrío Filete de Merluza', 'Presentación 800 g', 4, 100, 14900, 18500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS003', 'Blue Ocean Atún en Lomo Congelado', 'Presentación 500 g', 4, 100, 12700, 15800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS004', 'Pesquera del Mar Mojarra Entera', 'Presentación 1500 g', 4, 100, 19800, 23500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS005', 'Marina Azul Camarón Crudo Grande', 'Presentación 700 g', 4, 100, 22500, 27800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS006', 'Frigorífico Sur Trucha Arcoíris', 'Presentación 1000 g', 4, 100, 18200, 21500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS007', 'Ocean Catch Filete de Salmón', 'Presentación 600 g', 4, 100, 28900, 34900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS008', 'Blue Ocean Calamar en Anillos', 'Presentación 500 g', 4, 100, 13200, 16500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS009', 'Del Mar Langostinos Cocidos', 'Presentación 400 g', 4, 100, 24800, 29800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PESCADOS010', 'Pesquera Norte Pargo Rojo Fresco', 'Presentación 1000 g', 4, 100, 21000, 26000, 1);
--🍎 5. Frutas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS001', 'Frutalia Manzana Roja Importada', 'Presentación 1000 g', 5, 100, 5200, 6400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS002', 'Del Campo Banano Criollo', 'Presentación 1000 g', 5, 100, 2300, 2900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS003', 'Agrofrutas Uva Isabella', 'Presentación 500 g', 5, 100, 4800, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS004', 'Frutalia Pera Packham', 'Presentación 1000 g', 5, 100, 5600, 6900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS005', 'Agrosol Mango Tommy Maduro', 'Presentación 1000 g', 5, 100, 3900, 4900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS006', 'Fruges Piña Miel', 'Presentación 1500 g', 5, 100, 5800, 7100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS007', 'Del Campo Naranja Tangelo', 'Presentación 1000 g', 5, 100, 3600, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS008', 'Frutas y Vida Kiwi Importado', 'Presentación 500 g', 5, 100, 7200, 8800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS009', 'Frutalia Fresas Frescas', 'Presentación 500 g', 5, 100, 6700, 8200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('FRUTAS010', 'Del Campo Papaya Maradol', 'Presentación 1500 g', 5, 100, 4900, 6100, 1);
--🥕 6. Verduras
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS001', 'Agroverde Zanahoria Fresca', 'Presentación 1000 g', 6, 100, 2600, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS002', 'Campofresco Tomate Chonto', 'Presentación 1000 g', 6, 100, 3400, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS003', 'Del Campo Cebolla Cabezona', 'Presentación 1000 g', 6, 100, 2900, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS004', 'Verdevida Brócoli Fresco', 'Presentación 500 g', 6, 100, 4100, 5200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS005', 'Agroverde Lechuga Batavia', 'Presentación 300 g', 6, 100, 2200, 2800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS006', 'Verdecampo Pepino Cohombro', 'Presentación 1000 g', 6, 100, 2800, 3500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS007', 'Finca Natural Ajo Blanco', 'Presentación 250 g', 6, 100, 3100, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS008', 'CampoSur Pimentón Rojo', 'Presentación 500 g', 6, 100, 3700, 4600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS009', 'Verdefresco Habichuela Tierna', 'Presentación 500 g', 6, 100, 3900, 5000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('VERDURAS010', 'Campofresco Espinaca Limpia', 'Presentación 250 g', 6, 100, 2700, 3400, 1);
--🧊 7. Congelados
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS001', 'Zenú Hamburguesa de Res', 'Presentación 500 g', 7, 100, 7800, 9500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS002', 'RikoPollo Nuggets de Pollo', 'Presentación 400 g', 7, 100, 6900, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS003', 'Mr. Fish Filete de Tilapia', 'Presentación 600 g', 7, 100, 11200, 13400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS004', 'McCain Papas a la Francesa', 'Presentación 750 g', 7, 100, 7400, 9000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS005', 'Zenú Albóndigas de Res', 'Presentación 500 g', 7, 100, 8800, 10600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS006', 'RikoPollo Alas BBQ', 'Presentación 700 g', 7, 100, 9700, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS007', 'Fruandes Frutas Congeladas Mixtas', 'Presentación 1000 g', 7, 100, 8400, 10200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS008', 'Don Jacobo Arepas Precocidas', 'Presentación 400 g', 7, 100, 6200, 7700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS009', 'Zenú Chorizo Antioqueño Congelado', 'Presentación 500 g', 7, 100, 9500, 11400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CONGELADOS010', 'Mr. Fish Camarón Limpio Congelado', 'Presentación 500 g', 7, 100, 16800, 19600, 1);
--🧈 8. Lácteos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS001', 'Alpina Leche Entera', 'Presentación 1000 ml', 8, 100, 4200, 5000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS002', 'Colanta Yogur Fresa', 'Presentación 1500 ml', 8, 100, 6300, 7700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS003', 'Alquería Kumis Natural', 'Presentación 1000 ml', 8, 100, 5900, 7100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS004', 'Campi Mantequilla con Sal', 'Presentación 250 g', 8, 100, 4800, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS005', 'Colanta Queso Campesino', 'Presentación 500 g', 8, 100, 9700, 11400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS006', 'Alpina Yogurt Griego Natural', 'Presentación 500 g', 8, 100, 9200, 11000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS007', 'Colanta Quesito Antioqueño', 'Presentación 400 g', 8, 100, 8800, 10600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS008', 'Alquería Leche Deslactosada', 'Presentación 1000 ml', 8, 100, 4600, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS009', 'Danone Yogur Batido Durazno', 'Presentación 150 g', 8, 100, 2100, 3000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LACTEOS010', 'Lacthosa Crema de Leche', 'Presentación 250 ml', 8, 100, 3600, 4700, 1);
--🥚 9. Huevos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS001', 'Kikes Huevos AA', 'Presentación 30 und', 9, 100, 10800, 12500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS002', 'Santa Reyes Huevos Orgánicos', 'Presentación 12 und', 9, 100, 6800, 8000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS003', 'Colombina Huevos Rojos', 'Presentación 30 und', 9, 100, 10200, 11900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS004', 'Avícola Santa Anita Huevos A', 'Presentación 15 und', 9, 100, 5600, 6700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS005', 'Avinal Huevos de Codorniz', 'Presentación 24 und', 9, 100, 4900, 5900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS006', 'Huevos El Pinar AA', 'Presentación 12 und', 9, 100, 4600, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS007', 'Kikes Huevos XL', 'Presentación 15 und', 9, 100, 7200, 8700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS008', 'Santa Reyes Huevos Tipo A', 'Presentación 30 und', 9, 100, 9500, 11000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS009', 'Colombina Huevos Orgánicos', 'Presentación 6 und', 9, 100, 3400, 4300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HUEVOS010', 'Huevos El Pinar Codorniz', 'Presentación 18 und', 9, 100, 4200, 5200, 1);
--🥖 10. Panadería
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA001', 'Bimbo Pan Blanco Tradicional', 'Presentación 500 gr', 10, 100, 4500, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA002', 'Ramo Ponqué Gala', 'Presentación 250 gr', 10, 100, 3200, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA003', 'Bimbo Pan Integral', 'Presentación 550 gr', 10, 100, 4800, 5900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA004', 'Pan PaYa Pan Francés', 'Presentación 6 und', 10, 100, 3000, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA005', 'Ramo Galletas Festival Chocolate', 'Presentación 12 und', 10, 100, 2300, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA006', 'Bimbo Croissant con Queso', 'Presentación 2 und', 10, 100, 3100, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA007', 'Ramo Pan Tajado Tradicional', 'Presentación 400 gr', 10, 100, 4100, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA008', 'Pan PaYa Pan de Bono', 'Presentación 6 und', 10, 100, 3500, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA009', 'Bimbo Pan Dulce de Leche', 'Presentación 4 und', 10, 100, 3700, 4700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('PANADERIA010', 'Ramo Rollito de Canela', 'Presentación 2 und', 10, 100, 2800, 3700, 1);
--🍰 11. Reposteria
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA001', 'Ducales Galleta Tradicional', 'Presentación 6 und', 11, 100, 2800, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA002', 'Jet Chocolate con Mani', 'Presentación 120 gr', 11, 100, 4100, 5200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA003', 'Milo Galleta Energética', 'Presentación 180 gr', 11, 100, 3900, 4900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA004', 'Nestlé Leche Condensada', 'Presentación 395 gr', 11, 100, 4300, 5400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA005', 'Ramo Galleta Chocorramo Brownie', 'Presentación 1 und', 11, 100, 2800, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA006', 'Nestlé Cocoa en Polvo', 'Presentación 250 gr', 11, 100, 5200, 6400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA007', 'Ramo Rollito de Fresa', 'Presentación 2 und', 11, 100, 2900, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA008', 'Chocolisto Barras Energéticas', 'Presentación 5 und', 11, 100, 4700, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA009', 'Jet Chocolate Blanco', 'Presentación 100 gr', 11, 100, 3500, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REPOSTERIA010', 'Nestlé Topping de Chocolate', 'Presentación 200 ml', 11, 100, 3800, 4800, 1);
--🧃 12. Jugos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS001', 'Hit Néctar de Mango', 'Presentación 1000 ml', 12, 100, 3200, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS002', 'Del Valle Néctar de Durazno', 'Presentación 1000 ml', 12, 100, 3300, 4300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS003', 'Jumex Jugo de Manzana', 'Presentación 335 ml', 12, 100, 2200, 3000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS004', 'Cifrut Jugo Tropical', 'Presentación 600 ml', 12, 100, 2000, 2800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS005', 'Hit Néctar de Mora', 'Presentación 1000 ml', 12, 100, 3100, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS006', 'Del Valle Multifrutas', 'Presentación 1000 ml', 12, 100, 3300, 4300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS007', 'Jumex Jugo de Piña', 'Presentación 335 ml', 12, 100, 2200, 3000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS008', 'Cifrut Jugo de Naranja', 'Presentación 600 ml', 12, 100, 2000, 2800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS009', 'Hit Néctar de Guayaba', 'Presentación 1000 ml', 12, 100, 3200, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('JUGOS010', 'Del Valle Néctar de Manzana', 'Presentación 1000 ml', 12, 100, 3300, 4300, 1);
--🥤 13. Gaseosas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO001', 'Coca-Cola Original', 'Presentación 1500 ml', 13, 100, 4300, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO002', 'Pepsi Regular', 'Presentación 1500 ml', 13, 100, 4100, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO003', 'Postobón Manzana', 'Presentación 2000 ml', 13, 100, 4200, 5600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO004', 'Seven Up', 'Presentación 1500 ml', 13, 100, 4000, 5400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO005', 'Colombiana Postobón', 'Presentación 2000 ml', 13, 100, 4300, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO006', 'Sprite Original', 'Presentación 1500 ml', 13, 100, 4100, 5600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO007', 'Fanta Naranja', 'Presentación 1500 ml', 13, 100, 4200, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO008', 'Pepsi Light', 'Presentación 1500 ml', 13, 100, 4100, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO009', 'Coca-Cola Sin Azúcar', 'Presentación 1500 ml', 13, 100, 4300, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GASEO010', 'Bretaña Agua Tónica', 'Presentación 1000 ml', 13, 100, 3900, 5200, 1);
--🧴 14. CuidadoPersonal
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP001', 'Colgate Luminous White', 'Presentación 75 ml', 14, 100, 3800, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP002', 'Palmolive Naturals Shampoo', 'Presentación 350 ml', 14, 100, 6200, 8200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP003', 'Rexona Men Antitranspirante', 'Presentación 150 ml', 14, 100, 5600, 7300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP004', 'Nivea Crema Corporal', 'Presentación 400 ml', 14, 100, 9500, 12200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP005', 'Gillette Prestobarba 3', 'Presentación 2 und', 14, 100, 7800, 10300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP006', 'Listerine Enjuague Bucal', 'Presentación 250 ml', 14, 100, 4800, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP007', 'Head & Shoulders Anticaspa', 'Presentación 375 ml', 14, 100, 7700, 9900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP008', 'Sensodyne Rápido Alivio', 'Presentación 100 ml', 14, 100, 8900, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP009', 'Dove Jabón de Tocador', 'Presentación 90 gr', 14, 100, 2900, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CUIDP010', 'Oral-B Cepillo Dental Suave', 'Presentación 1 und', 14, 100, 3700, 5200, 1);
--💅 15. Cosmetica
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM001', 'Maybelline Fit Me Base Líquida', 'Presentación 30 ml', 15, 100, 21500, 28900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM002', 'L’Oréal Máscara Voluminous', 'Presentación 10 ml', 15, 100, 18600, 24900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM003', 'Revlon Labial Ultra HD', 'Presentación 3.5 gr', 15, 100, 14300, 19500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM004', 'Vogue Polvo Compacto Natural', 'Presentación 13 gr', 15, 100, 6700, 8900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM005', 'Essence Delineador Líquido', 'Presentación 3 ml', 15, 100, 5500, 7500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM006', 'Max Factor Rubor Compacto', 'Presentación 5 gr', 15, 100, 9200, 12900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM007', 'Avon Dúo de Sombras', 'Presentación 2.2 gr', 15, 100, 8300, 11300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM008', 'Mary Kay Primer Facial', 'Presentación 29 ml', 15, 100, 19800, 26500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM009', 'Natura Brillo Labial', 'Presentación 5.5 ml', 15, 100, 10700, 14500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('COSM010', 'Covergirl Corrector Líquido', 'Presentación 7 ml', 15, 100, 9900, 13200, 1);
--🍽️ 16. Despensa
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP001', 'Diana Arroz Premium', 'Presentación 1000 gr', 16, 100, 3200, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP002', 'Ramo Harina de Trigo', 'Presentación 1000 gr', 16, 100, 2800, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP003', 'Haz de Oros Pasta Spaghetti', 'Presentación 500 gr', 16, 100, 2600, 3400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP004', 'La Constancia Fríjol Bola Roja', 'Presentación 500 gr', 16, 100, 3300, 4300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP005', 'Doria Lentejas', 'Presentación 500 gr', 16, 100, 2900, 3850, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP006', 'El Rey Maicena Natural', 'Presentación 400 gr', 16, 100, 2500, 3300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP007', 'Colombina Azúcar Refinada', 'Presentación 1000 gr', 16, 100, 3100, 4100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP008', 'Doña Gallina Caldo en Cubos', 'Presentación 12 und', 16, 100, 1800, 2500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP009', 'El Dorado Sal Refinada', 'Presentación 1000 gr', 16, 100, 1200, 1800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DESP010', 'Costeñita Yuca Congelada', 'Presentación 1000 gr', 16, 100, 3900, 5200, 1);
--🧂 17. Especias
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE001', 'El Rey Comino Molido', 'Presentación 30 gr', 17, 100, 800, 1500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE002', 'La Constancia Pimienta Negra', 'Presentación 25 gr', 17, 100, 1200, 1800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE003', 'El Rey Color con Comino', 'Presentación 100 gr', 17, 100, 1600, 2400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE004', 'Badia Ajo en Polvo', 'Presentación 85 gr', 17, 100, 3100, 4100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE005', 'McCormick Oregano Molido', 'Presentación 20 gr', 17, 100, 1100, 1600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE006', 'El Rey Curry Amarillo', 'Presentación 50 gr', 17, 100, 1900, 2700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE007', 'La Constancia Paprika Dulce', 'Presentación 40 gr', 17, 100, 2000, 2900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE008', 'El Rey Clavos de Olor', 'Presentación 25 gr', 17, 100, 1500, 2300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE009', 'McCormick Albahaca Seca', 'Presentación 18 gr', 17, 100, 1300, 2000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESPE010', 'Badia Laurel Entero', 'Presentación 20 gr', 17, 100, 900, 1600, 1);
--🍯 18. AceitesVinagresAderezos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA001', 'Girasol Aceite Vegetal', 'Presentación 1000 ml', 18, 100, 6500, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA002', 'Olitalia Aceite de Oliva Extra Virgen', 'Presentación 500 ml', 18, 100, 13500, 17000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA003', 'La Constancia Vinagre Blanco', 'Presentación 1000 ml', 18, 100, 2300, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA004', 'Heinz Vinagre de Manzana', 'Presentación 473 ml', 18, 100, 2900, 4400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA005', 'Fruco Mayonesa Clásica', 'Presentación 400 gr', 18, 100, 4200, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA006', 'Hellmann’s Mayonesa Light', 'Presentación 390 gr', 18, 100, 4500, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA007', 'Fruco Salsa de Tomate', 'Presentación 400 gr', 18, 100, 3000, 4600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA008', 'La Constancia Mostaza', 'Presentación 300 gr', 18, 100, 2600, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA009', 'Bary Salsa BBQ', 'Presentación 500 gr', 18, 100, 4800, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('AVA010', 'La Constancia Salsa Rosada', 'Presentación 400 gr', 18, 100, 4100, 5700, 1);
--🧴 19. HigieneFemenina
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF001', 'Nosotras Toallas Higiénicas Invisible', 'Presentación 10 und', 19, 100, 3900, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF002', 'Kotex Toallas Nocturnas con Alas', 'Presentación 8 und', 19, 100, 4100, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF003', 'Always Toallas Higiénicas Ultrafinas', 'Presentación 12 und', 19, 100, 4700, 6400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF004', 'Nosotras Tampones Regulares', 'Presentación 10 und', 19, 100, 5200, 6900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF005', 'Tampax Tampones Super', 'Presentación 8 und', 19, 100, 5800, 7600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF006', 'Nosotras Jabón Íntimo Natural', 'Presentación 200 ml', 19, 100, 4300, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF007', 'Saba Toallas Higiénicas Suaves', 'Presentación 14 und', 19, 100, 4500, 6200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF008', 'Always Pantiprotectores Diarios', 'Presentación 40 und', 19, 100, 3900, 5300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF009', 'Nosotras Protectores Diarios Multiestilo', 'Presentación 30 und', 19, 100, 3500, 4900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('HF010', 'Saba Toallas Higiénicas Nocturnas', 'Presentación 10 und', 19, 100, 4400, 6000, 1);
--👶 20. Maternidad
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT001', 'Huggies Pañales Recién Nacido', 'Presentación 30 und', 20, 100, 11500, 14500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT002', 'Pampers Pañales Etapa 1', 'Presentación 40 und', 20, 100, 12300, 15500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT003', 'Johnsons Shampoo para Bebé', 'Presentación 400 ml', 20, 100, 7800, 9900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT004', 'Mustela Crema para Rozaduras', 'Presentación 100 ml', 20, 100, 9900, 12900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT005', 'Chicco Gel de Baño para Bebé', 'Presentación 200 ml', 20, 100, 8500, 11000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT006', 'Enfamil Fórmula Infantil Etapa 1', 'Presentación 400 gr', 20, 100, 28000, 34000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT007', 'Similac Fórmula Infantil Sensitive', 'Presentación 375 gr', 20, 100, 26000, 32000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT008', 'Munchkin Chupos Silicona 0-6m', 'Presentación 2 und', 20, 100, 6100, 8200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT009', 'Evenflo Biberón Boca Ancha', 'Presentación 250 ml', 20, 100, 7100, 9400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAT010', 'Johnsons Aceite para Bebé', 'Presentación 200 ml', 20, 100, 6200, 8400, 1);
--🧸 21. Escolares
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC001', 'Norma Cuaderno Cuadro Grande', 'Presentación 100 hojas', 21, 100, 2300, 3100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC002', 'Scribe Cuaderno Rayado', 'Presentación 80 hojas', 21, 100, 2100, 2900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC003', 'Faber-Castell Lápices de Colores', 'Presentación 12 und', 21, 100, 5800, 7900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC004', 'Bic Esferos Azul', 'Presentación 3 und', 21, 100, 1600, 2200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC005', 'Pelikan Pegante en Barra', 'Presentación 21 gr', 21, 100, 2400, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC006', 'Norma Cartuchera Escolar', 'Presentación 1 und', 21, 100, 6200, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC007', 'Maped Tijeras Escolares', 'Presentación 1 und', 21, 100, 3300, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC008', 'Sharp Calculadora Básica', 'Presentación 1 und', 21, 100, 9800, 12900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC009', 'Pelikan Temperas Escolares', 'Presentación 6 colores', 21, 100, 5600, 7500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ESC010', 'Faber-Castell Borradores Suaves', 'Presentación 2 und', 21, 100, 1400, 1900, 1);
--🐾 22. Mascotas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS001', 'Dog Chow Alimento Adulto', 'Presentación 2000 gr', 22, 100, 21500, 27500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS002', 'Cat Chow Alimento Gato', 'Presentación 1000 gr', 22, 100, 19800, 24900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS003', 'Chunky Alimento Cachorro', 'Presentación 3000 gr', 22, 100, 28900, 35900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS004', 'Pedigree Snacks Dentastix', 'Presentación 7 und', 22, 100, 7600, 9800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS005', 'Whiskas Alimento Húmedo Gato', 'Presentación 85 gr', 22, 100, 2400, 3300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS006', 'Hills Prescription Diet Perro', 'Presentación 3700 gr', 22, 100, 32500, 41800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS007', 'Petys Arena Sanitaria', 'Presentación 4500 gr', 22, 100, 8900, 11800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS008', 'Ringo Galletas para Perros', 'Presentación 500 gr', 22, 100, 5900, 7700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS009', 'Purina One Alimento Gato Esterilizado', 'Presentación 1200 gr', 22, 100, 21900, 28900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('MAS010', 'Kong Juguete Mascota Mediano', 'Presentación 1 und', 22, 100, 16500, 21500, 1);
--🧃 23. BebidasEnergeticas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN001', 'Red Bull Energy Drink', 'Presentación 250 ml', 23, 100, 4700, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN002', 'Monster Energy Original', 'Presentación 473 ml', 23, 100, 5200, 6900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN003', 'Vive 100 Bebida Energizante', 'Presentación 400 ml', 23, 100, 2300, 3000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN004', 'Volt Energy Drink Original', 'Presentación 400 ml', 23, 100, 2500, 3400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN005', 'Speed Max Energy', 'Presentación 473 ml', 23, 100, 4600, 6100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN006', 'Hype Energy Drink MFP', 'Presentación 250 ml', 23, 100, 4100, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN007', 'Burn Bebida Energizante', 'Presentación 355 ml', 23, 100, 3950, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN008', 'Lion Energy', 'Presentación 500 ml', 23, 100, 3300, 4400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN009', 'Rockstar Energy Original', 'Presentación 473 ml', 23, 100, 5400, 7000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BEN010', 'Xzoom Energy', 'Presentación 400 ml', 23, 100, 2200, 2900, 1);
--☕ 24. Cafe
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF001', 'Nescafé Tradición', 'Presentación 170 g', 24, 100, 7800, 10500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF002', 'Águila Roja Café Molido', 'Presentación 250 g', 24, 100, 7200, 9800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF003', 'Oma Café Molido', 'Presentación 250 g', 24, 100, 7500, 10000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF004', 'Sello Rojo Café', 'Presentación 500 g', 24, 100, 9600, 13000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF005', 'Juan Valdez Premium', 'Presentación 284 g', 24, 100, 11500, 15500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF006', 'Colcafé Clásico', 'Presentación 170 g', 24, 100, 7900, 10700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF007', 'Matiz Café Molido', 'Presentación 250 g', 24, 100, 8200, 11000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF008', 'La Bastilla Café Tradicional', 'Presentación 500 g', 24, 100, 8800, 11900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF009', 'Liofilizado Selecto', 'Presentación 95 g', 24, 100, 13200, 17000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CAF010', 'Gran Café Premium', 'Presentación 250 g', 24, 100, 9700, 12700, 1);
--🍷 25. BebidasAlcoholicas
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC001', 'Aguila Original', 'Presentación 330 ml', 25, 100, 1800, 2500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC002', 'Club Colombia Dorada', 'Presentación 330 ml', 25, 100, 2100, 2900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC003', 'Poker Cerveza', 'Presentación 330 ml', 25, 100, 1700, 2300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC004', 'Corona Extra', 'Presentación 355 ml', 25, 100, 4200, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC005', 'Heineken', 'Presentación 330 ml', 25, 100, 4000, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC006', 'Aguardiente Antioqueño', 'Presentación 750 ml', 25, 100, 29000, 37000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC007', 'Ron Medellín Añejo', 'Presentación 750 ml', 25, 100, 32000, 42000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC008', 'Baileys Irish Cream', 'Presentación 750 ml', 25, 100, 52000, 68000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC009', 'Whisky Old Parr', 'Presentación 750 ml', 25, 100, 78000, 99000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ALC010', 'Vino Gato Negro Cabernet Sauvignon', 'Presentación 750 ml', 25, 100, 25000, 33000, 1);
--📦 26. Enlatados
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL001', 'Van Camp’s Atún en Agua', 'Presentación 160 g', 26, 100, 3700, 4800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL002', 'Van Camp’s Sardinas en Salsa', 'Presentación 155 g', 26, 100, 3100, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL003', 'Del Monte Duraznos en Almíbar', 'Presentación 820 g', 26, 100, 8200, 10500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL004', 'La Constancia Fríjoles en Lata', 'Presentación 400 g', 26, 100, 4300, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL005', 'Zenú Salchichas Viena', 'Presentación 150 g', 26, 100, 2700, 3600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL006', 'La Fina Maíz Dulce', 'Presentación 300 g', 26, 100, 3400, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL007', 'Zenú Albóndigas en Salsa', 'Presentación 400 g', 26, 100, 6500, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL008', 'Zenú Garbanzos Cocidos', 'Presentación 300 g', 26, 100, 4100, 5600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL009', 'Zenú Lentejas en Lata', 'Presentación 300 g', 26, 100, 3900, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ENL010', 'La Constancia Champiñones Laminados', 'Presentación 185 g', 26, 100, 5200, 6900, 1);
--🧊 27. Refrigerados
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF001', 'Colanta Yogurt Fresa', 'Presentación 1000 ml', 27, 100, 4800, 6200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF002', 'Alquería Leche Deslactosada', 'Presentación 1100 ml', 27, 100, 4300, 5700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF003', 'Zenú Pechuga de Pollo Horneada', 'Presentación 250 g', 27, 100, 8700, 10900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF004', 'Ramo Ponqué Gala', 'Presentación 300 g', 27, 100, 5200, 6900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF005', 'Yogo Yogo Yogurt Infantil', 'Presentación 6 und', 27, 100, 4500, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF006', 'Zenú Jamón de Cerdo', 'Presentación 250 g', 27, 100, 8500, 11200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF007', 'Colanta Kumis Tradicional', 'Presentación 1000 ml', 27, 100, 4700, 6200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF008', 'Alpina Yogurt Griego Natural', 'Presentación 150 g', 27, 100, 4200, 5500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF009', 'Zenú Chorizo Antioqueño', 'Presentación 500 g', 27, 100, 10900, 13800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('REF010', 'Ramo Gansito Congelado', 'Presentación 80 g', 27, 100, 2900, 3900, 1);
--📌 28. Desechables
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES001', 'Rey Platos Desechables Blancos', 'Presentación 20 und', 28, 100, 2300, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES002', 'Zebra Vasos Plásticos Transparentes', 'Presentación 50 und', 28, 100, 4800, 6300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES003', 'Elite Servilletas Desechables', 'Presentación 100 und', 28, 100, 4500, 5900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES004', 'Rey Cucharas Plásticas Blancas', 'Presentación 50 und', 28, 100, 3900, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES005', 'Zebra Tenedores Desechables', 'Presentación 50 und', 28, 100, 3900, 5100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES006', 'Plastiempanadas Empaques Térmicos', 'Presentación 25 und', 28, 100, 5200, 6900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES007', 'Rey Bolsas Negras para Basura', 'Presentación 20 und', 28, 100, 6400, 7900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES008', 'Zebra Bandejas de Icopor', 'Presentación 25 und', 28, 100, 5600, 7200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES009', 'Elite Toallas de Cocina Desechables', 'Presentación 3 rollos', 28, 100, 8800, 10500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DES010', 'Rey Palillos de Madera', 'Presentación 200 und', 28, 100, 1900, 2700, 1);
--🕯️ 29. Aromatizantes
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO001', 'Glade Aerosol Manzana Canela', 'Presentación 360 ml', 29, 100, 6700, 8500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO002', 'Renuzit Gel Aromatizante Lavanda', 'Presentación 198 g', 29, 100, 4900, 6300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO003', 'Ambi Pur Ambientador Auto Vainilla', 'Presentación 7 ml', 29, 100, 10500, 12900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO004', 'Glade Toque Manzana Verde', 'Presentación 10 ml', 29, 100, 4600, 5900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO005', 'Renuzit Spray Automático Repuesto Cítrico', 'Presentación 250 ml', 29, 100, 7300, 9200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO006', 'Air Wick Ambientador Líquido Canela', 'Presentación 250 ml', 29, 100, 8600, 10500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO007', 'Ambi Pur Difusor Eléctrico Repuesto Lavanda', 'Presentación 20 ml', 29, 100, 9200, 11700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO008', 'Glade Velas Aromáticas Frutas Rojas', 'Presentación 96 g', 29, 100, 5400, 6800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO009', 'Renuzit Perlas Aromáticas Floral', 'Presentación 275 g', 29, 100, 7600, 9500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ARO010', 'Air Wick Aceite Esencial Repuesto Brisa', 'Presentación 21 ml', 29, 100, 9300, 11800, 1);
--🧪 30. Salud
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL001', 'Genfar Acetaminofén 500 mg', 'Presentación 10 tabletas', 30, 100, 1500, 2200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL002', 'Dolex Forte 500 mg', 'Presentación 16 tabletas', 30, 100, 6800, 8900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL003', 'Alka-Seltzer Tabletas Efervescentes', 'Presentación 8 und', 30, 100, 4500, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL004', 'Aspirina Bayer 500 mg', 'Presentación 20 tabletas', 30, 100, 8700, 10900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL005', 'Buscapina Compositum N', 'Presentación 10 cápsulas', 30, 100, 11900, 14500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL006', 'Sal de Frutas Lua', 'Presentación 5 sobres', 30, 100, 3100, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL007', 'Genfar Loratadina 10 mg', 'Presentación 10 tabletas', 30, 100, 2600, 3400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL008', 'Enterogermina 5 ml', 'Presentación 10 frascos', 30, 100, 17400, 21200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL009', 'Genfar Antigripal Día y Noche', 'Presentación 8 cápsulas', 30, 100, 4300, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SAL010', 'Vick VapoRub Ungüento', 'Presentación 50 g', 30, 100, 6900, 8500, 1);
--🧃 31. BebidasHidratantes
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI001', 'Gatorade Mandarina', 'Presentación 500 ml', 31, 100, 2300, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI002', 'Powerade Uva', 'Presentación 591 ml', 31, 100, 2500, 3400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI003', 'Vive100 Hidratante Frutos Rojos', 'Presentación 500 ml', 31, 100, 2700, 3600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI004', 'Aquarius Naranja', 'Presentación 400 ml', 31, 100, 1900, 2600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI005', 'Sporade Limón', 'Presentación 500 ml', 31, 100, 2100, 2800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI006', 'BonSport Original', 'Presentación 600 ml', 31, 100, 2300, 3100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI007', 'Gatorade Sin Azúcar Frutas Cítricas', 'Presentación 500 ml', 31, 100, 2600, 3500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI008', 'Powerade Azul', 'Presentación 1 litro', 31, 100, 4800, 6200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI009', 'Aquarius Manzana', 'Presentación 600 ml', 31, 100, 2200, 3000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('BHI010', 'BonSport Hidratante Piña', 'Presentación 500 ml', 31, 100, 2100, 2800, 1);
--🍚 32. Cereales
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER001', 'Kellogg’s Zucaritas', 'Presentación 500 g', 32, 100, 7800, 10400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER002', 'Nestlé Corn Flakes', 'Presentación 510 g', 32, 100, 7300, 9800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER003', 'Kellogg’s Froot Loops', 'Presentación 400 g', 32, 100, 7900, 10700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER004', 'Nestlé Fitness', 'Presentación 375 g', 32, 100, 8200, 10900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER005', 'Kellogg’s All Bran', 'Presentación 380 g', 32, 100, 8400, 11200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER006', 'Quaker Granola Tradicional', 'Presentación 500 g', 32, 100, 8500, 11300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER007', 'Nestlé Nesquik Cereal', 'Presentación 360 g', 32, 100, 7200, 9700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER008', 'Kellogg’s Choco Krispis', 'Presentación 500 g', 32, 100, 8000, 10600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER009', 'Avena Quaker Instantánea', 'Presentación 400 g', 32, 100, 4400, 5900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('CER010', 'Kellogg’s Special K', 'Presentación 400 g', 32, 100, 8700, 11500, 1);
--🍭 33. Dulces
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL001', 'Jet Chocolate', 'Presentación 12 g', 33, 100, 200, 400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL002', 'Bon Bon Bum Fresa', 'Presentación 24 und', 33, 100, 3700, 5400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL003', 'Chocorramo Ramo', 'Presentación 65 g', 33, 100, 1900, 2600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL004', 'Trululu Gomitas Ositos', 'Presentación 100 g', 33, 100, 2900, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL005', 'Nestlé Chocolatina Crunch', 'Presentación 32 g', 33, 100, 2300, 3400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL006', 'M&M’s Mani', 'Presentación 45 g', 33, 100, 3900, 5400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL007', 'Galleta Festival Vainilla', 'Presentación 6 und', 33, 100, 1200, 1800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL008', 'Supercoco Original', 'Presentación 24 und', 33, 100, 2800, 4100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL009', 'Chocolatina Jumbo Maní', 'Presentación 55 g', 33, 100, 2600, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('DUL010', 'Halls Mentho-Lyptus', 'Presentación 25 g', 33, 100, 1200, 1800, 1);
--🍟 34. Snacks
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA001', 'Margarita Natural', 'Presentación 105 g', 34, 100, 3300, 4600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA002', 'Tosh Integral Queso', 'Presentación 100 g', 34, 100, 4200, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA003', 'Cheesetos Queso', 'Presentación 90 g', 34, 100, 2700, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA004', 'De Todito Picante', 'Presentación 95 g', 34, 100, 3100, 4400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA005', 'Doritos Tex-Mex', 'Presentación 120 g', 34, 100, 3700, 5300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA006', 'Rizadas BBQ', 'Presentación 90 g', 34, 100, 2900, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA007', 'Maizitos Natural', 'Presentación 70 g', 34, 100, 1800, 2600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA008', 'Manimoto Yupi', 'Presentación 75 g', 34, 100, 2400, 3300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA009', 'Tostacos Yupi', 'Presentación 85 g', 34, 100, 2700, 3800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA010', 'Platanitos Naturales', 'Presentación 100 g', 34, 100, 3500, 4900, 1);
--🍯 35. Endulzantes
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA001', 'Margarita Natural', 'Presentación 105 g', 34, 100, 3300, 4600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA002', 'Tosh Integral Queso', 'Presentación 100 g', 34, 100, 4200, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA003', 'Cheesetos Queso', 'Presentación 90 g', 34, 100, 2700, 3900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA004', 'De Todito Picante', 'Presentación 95 g', 34, 100, 3100, 4400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA005', 'Doritos Tex-Mex', 'Presentación 120 g', 34, 100, 3700, 5300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA006', 'Rizadas BBQ', 'Presentación 90 g', 34, 100, 2900, 4000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA007', 'Maizitos Natural', 'Presentación 70 g', 34, 100, 1800, 2600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA008', 'Manimoto Yupi', 'Presentación 75 g', 34, 100, 2400, 3300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA009', 'Tostacos Yupi', 'Presentación 85 g', 34, 100, 2700, 3800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('SNA010', 'Platanitos Naturales', 'Presentación 100 g', 34, 100, 3500, 4900, 1);
--🥫 36. Aderezos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END001', 'Monk Fruit Healthy Brand', 'Presentación 200 g', 35, 100, 8200, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END002', 'Stevia Life', 'Presentación 100 g', 35, 100, 5100, 7100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END003', 'Splenda Clásico', 'Presentación 120 g', 35, 100, 6700, 9300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END004', 'Panela La Colina', 'Presentación 500 g', 35, 100, 2500, 3700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END005', 'Azúcar Manuelita', 'Presentación 1000 g', 35, 100, 3100, 4500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END006', 'Miel Natural Bee', 'Presentación 350 ml', 35, 100, 7200, 10200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END007', 'Fructosa NutriLife', 'Presentación 250 g', 35, 100, 4300, 6100, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END008', 'Tagatosa Dulzero', 'Presentación 200 g', 35, 100, 7500, 10400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END009', 'Sirope de Agave Organic Farms', 'Presentación 500 ml', 35, 100, 8800, 12400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('END010', 'Panela Pulverizada BioPanela', 'Presentación 300 g', 35, 100, 3100, 4400, 1);
--🧃 37. ProductosLight
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE001', 'Mayonesa Fruco', 'Presentación 400 g', 36, 100, 4600, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE002', 'Mostaza Heinz', 'Presentación 200 g', 36, 100, 3900, 5600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE003', 'Ketchup La Constancia', 'Presentación 400 g', 36, 100, 4700, 6800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE004', 'Salsa BBQ Hunt’s', 'Presentación 500 g', 36, 100, 6200, 8800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE005', 'Salsa Tartara McCormick', 'Presentación 250 g', 36, 100, 5600, 8000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE006', 'Salsa Ajo San Jorge', 'Presentación 180 g', 36, 100, 3300, 4700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE007', 'Salsa de Tomate Fruco', 'Presentación 400 g', 36, 100, 4600, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE008', 'Salsa Ranch La Constancia', 'Presentación 300 ml', 36, 100, 5200, 7500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE009', 'Vinagreta Balsámica Sibaris', 'Presentación 250 ml', 36, 100, 5800, 8400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ADE010', 'Salsa Sriracha Thai Dragon', 'Presentación 350 g', 36, 100, 7400, 10500, 1);
--🌱 38. ProductosOrganicos
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG001', 'Yogurt Alpina Light', 'Presentación 150 g', 37, 100, 2100, 3200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG002', 'Galletas Tosh Light', 'Presentación 180 g', 37, 100, 3800, 5400, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG003', 'Queso Bajo en Grasa Colanta', 'Presentación 250 g', 37, 100, 5600, 7900, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG004', 'Leche Deslactosada Alpina Light', 'Presentación 1000 ml', 37, 100, 4300, 6000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG005', 'Gelatina Light Dany', 'Presentación 6 und', 37, 100, 2900, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG006', 'Arequipe Light Alpina', 'Presentación 220 g', 37, 100, 4800, 6700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG007', 'Pan Integral Light Bimbo', 'Presentación 500 g', 37, 100, 5200, 7300, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG008', 'Refresco Light Clight', 'Presentación 9 g', 37, 100, 600, 1200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG009', 'Cereal Fitness Nestlé Light', 'Presentación 300 g', 37, 100, 7100, 9700, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('LIG010', 'Mermelada Light La Constancia', 'Presentación 250 g', 37, 100, 4900, 6800, 1);
--🚫 39. SinGluten
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG001', 'Manzana Orgánica La Huerta', 'Presentación 1 kg', 38, 100, 6500, 8800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG002', 'Zanahoria Orgánica Campo Vivo', 'Presentación 1 kg', 38, 100, 4200, 5800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG003', 'Lechuga Orgánica BioCampo', 'Presentación 500 g', 38, 100, 3300, 4600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG004', 'Tomate Orgánico Vida Verde', 'Presentación 1 kg', 38, 100, 5300, 7200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG005', 'Cebolla Orgánica NaturalFresh', 'Presentación 1 kg', 38, 100, 3800, 5200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG006', 'Aguacate Orgánico Del Campo', 'Presentación 1 kg', 38, 100, 7200, 9800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG007', 'Pepino Orgánico BioVida', 'Presentación 1 kg', 38, 100, 3500, 4800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG008', 'Brócoli Orgánico Campo Limpio', 'Presentación 500 g', 38, 100, 4600, 6200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG009', 'Apio Orgánico Vida Sana', 'Presentación 500 g', 38, 100, 3100, 4200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('ORG010', 'Calabacín Orgánico EcoFresh', 'Presentación 1 kg', 38, 100, 4000, 5500, 1);
--📚 40. Papeleria
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU001', 'Pan Libre de Gluten Schär', 'Presentación 300 g', 39, 100, 8600, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU002', 'Galletas Sin Gluten Santiveri', 'Presentación 200 g', 39, 100, 5400, 7200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU003', 'Harina de Almendra Bob’s Red Mill', 'Presentación 454 g', 39, 100, 12500, 16500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU004', 'Pasta Sin Gluten Barilla', 'Presentación 400 g', 39, 100, 8700, 11500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU005', 'Cereal Sin Gluten Nature’s Path', 'Presentación 300 g', 39, 100, 9800, 13000, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU006', 'Barra Energética Sin Gluten Clif', 'Presentación 68 g', 39, 100, 4900, 6500, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU007', 'Harina de Coco Bob’s Red Mill', 'Presentación 340 g', 39, 100, 11800, 15800, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU008', 'Galletas de Arroz Sin Gluten', 'Presentación 150 g', 39, 100, 4200, 5600, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU009', 'Panqueques Sin Gluten Betty Crocker', 'Presentación 300 g', 39, 100, 7600, 10200, 1);
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado) VALUES ('GLU010', 'Mix para Pasteles Sin Gluten', 'Presentación 400 g', 39, 100, 9100, 12200, 1);



SELECT * FROM PRODUCTO