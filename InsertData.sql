
USE  dbSistema_Ventas
GO

--DBCC CHECKIDENT ('ROL', RESEED, 0);
--DBCC CHECKIDENT ('PERMISOS', RESEED, 0);
--DBCC CHECKIDENT ('USUARIO', RESEED, 0);


----
---Insertar Los Roles
----
INSERT INTO ROL (Descripcion) VALUES ('Software Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Systems Architect');
INSERT INTO ROL (Descripcion) VALUES ('DevOps Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Data Scientist');
INSERT INTO ROL (Descripcion) VALUES ('Front-End Developer');
INSERT INTO ROL (Descripcion) VALUES ('Back-End Developer');
INSERT INTO ROL (Descripcion) VALUES ('Full Stack Developer');
INSERT INTO ROL (Descripcion) VALUES ('Cloud Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Database Administrator (DBA)');
INSERT INTO ROL (Descripcion) VALUES ('Network Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Security Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Quality Assurance Engineer (QA)');
INSERT INTO ROL (Descripcion) VALUES ('IT Support Specialist');
INSERT INTO ROL (Descripcion) VALUES ('Machine Learning Engineer');
INSERT INTO ROL (Descripcion) VALUES ('Product Manager (Tech)');
INSERT INTO ROL (Descripcion) VALUES ('Site Reliability Engineer (SRE)');
INSERT INTO ROL (Descripcion) VALUES ('IT Consultant');
INSERT INTO ROL (Descripcion) VALUES ('Business Intelligence Analyst');
INSERT INTO ROL (Descripcion) VALUES ('Systems Administrator');
INSERT INTO ROL (Descripcion) VALUES ('IT Project Manager');
----
--Consultar ROL
----
SELECT * FROM ROL
GO

----
---Insertar Los PERMISOS
----(Rol 1)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (1,'menuGitHub')
----(Rol 2)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (2,'menuGitHub')
----(Rol 3)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (3,'menuGitHub')
----(Rol 4)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (4,'menuGitHub')
----(Rol 5)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (5,'menuGitHub')
----(Rol 6)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (6,'menuGitHub')
----(Rol 7)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (7,'menuGitHub')
----(Rol 8)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (8,'menuGitHub')
----(Rol 9)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (9,'menuGitHub')
----(Rol 10)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuAdministrator')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuSales')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuShopping')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuClients')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuSuppliers')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuReports')
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (10,'menuGitHub')
----(Rol 11)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (11,'menuUser');
----(Rol 12)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (12,'menuAdministrator');
----(Rol 13)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (13,'menuSales');
----(Rol 14)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (14,'menuShopping');
----(Rol 15)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (15,'menuClients');
----(Rol 16)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (16,'menuSuppliers');
----(Rol 17)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (17,'menuReports');
----(Rol 18)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (18,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (18,'menuReports');
----(Rol 19)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (19,'menuUser');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (19,'menuReports');
----(Rol 20)
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (20,'menuClients');
INSERT INTO PERMISOS (IdRol, NombreMenu) VALUES (20,'menuSales');
----
--Consultar PERMISOS
----
SELECT * FROM PERMISOS
GO


----
---Insertar Los Usuarios
----

SELECT * FROM USUARIO
GO
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('1023456789','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',1,1)--
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('9876543210','software_king','software_king@SalesSystem.com','so9876',2,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',3,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',4,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',5,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',6,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',7,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',8,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',9,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',10,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',11,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',12,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',13,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',14,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',15,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',16,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',17,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',18,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',19,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('','Dijhons1023','Dijhons1023@SalesSystem.com','Di1023',20,1)


