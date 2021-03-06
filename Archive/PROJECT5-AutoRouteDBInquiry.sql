DROP DATABASE IF EXISTS AutoRoute

CREATE DATABASE AutoRoute

USE AutoRoute;

DROP TABLE IF EXISTS [USER]

CREATE TABLE [USER]
(
DODID INT Identity Primary Key, UIC VARCHAR(10), COC VARCHAR(80)  
, MEMBER BIT, RO BIT, AO BIT, [ADMIN] BIT, SUB BIT, PRIME BIT
, EMAIL VARCHAR (80), PHONE VARCHAR(12), Serial VARCHAR (8),
[Rank] VARCHAR (10), FirstName VARCHAR (80), MI VARCHAR(3), LastName VARCHAR (80))

INSERT into [USER] (UIC, COC, MEMBER, RO, AO, [ADMIN], SUB, PRIME, EMAIL, PHONE, Serial, [Rank], FirstName, MI, LastName)
VALUES 
('45908','CNAFR', 1, 1, 1, 1, 0, 0, 'johnathan.soward@navy.smo','619-545-8712', 'N01/001', 'E6', 'Johnathan', 'C', 'Soward') 

DROP TABLE IF EXISTS REQUEST 

CREATE TABLE REQUEST
( 
Serial VARCHAR (8), Special BIT, Regular BIT, [DATE IN] date NOT Null)

Insert into REQUEST 
VALUES
('N01/001', 1, 0, '2021-02-05')

SELECT *
FROM [USER]

SELECT *
FROM REQUEST