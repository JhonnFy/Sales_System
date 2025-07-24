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




