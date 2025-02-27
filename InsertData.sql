
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
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('1023456789','Dijhons1023','Dijhons1023@SalesSystem.com','Dijh1023',1,1)--
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('9876543210','testing1','testing1@SalesSystem.com','test9876',2,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('1234567890','testing2','testing2@SalesSystem.com','test1234',3,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('2345678901','tech_guru','tech_guru@SalesSystem.com','tech2345',4,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('3456789012','code_wizard','code@SalesSystem.com','code3456',5,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('4567890123','admin_01','admin_01@SalesSystem.com','admi4567',6,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('5678901234','user_42','user_42@SalesSystem.com','user5678',7,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('6789012345','mr_programmer','mr_programmer@SalesSystem.com','mr_p6789',8,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('7890123456','tech_geek','tech_geek@SalesSystem.com','tech7890',9,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('8901234567','dev_ninja','dev_ninja@SalesSystem.com','dev_8901',10,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('9012345678','code_smith','code_smith@SalesSystem.com','code9012',11,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('1122334455','user_evergreen','user_evergreen@SalesSystem.com','user1122',12,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('2233445566','engineer_001','engineer_001@SalesSystem.com','engi2233',13,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('3344556677','script_warrior','script_warrior@SalesSystem.com','scri3344',14,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('4455667788','system_jedi','system_jedi@SalesSystem.com','syst4455',15,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('5566778899','tech_pro','tech_pro@SalesSystem.com','tech5566',16,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('6677889900','codex_hero','codex_hero@SalesSystem.com','code6677',17,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('7788990011','system_slayer','system_slayer@SalesSystem.com','syst7788',18,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('8899001122','software_king','@SalesSystem.com','soft8899',19,1)
INSERT INTO  USUARIO (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) VALUES ('9900112233','dev_master','@SalesSystem.com','dev_9900',20,1)
----
--Consultar USUARIO
----
SELECT * FROM USUARIO
GO

