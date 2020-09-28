DROP SCHEMA IF EXISTS gilgameshBeta;
CREATE SCHEMA gilgameshBeta;
USE gilgameshBeta;

CREATE TABLE usuario(
nm_nome_usuario 			VARCHAR(32),
cd_usuario 					INT,
nm_senha_usuario 			VARCHAR(50),

CONSTRAINT pk_usuario PRIMARY KEY (cd_usuario)

);
INSERT INTO usuario VALUES ('Rogério',0,'SenhaSegura');
INSERT INTO usuario VALUES ('Valter',1,'SenhaInsegura');
INSERT INTO usuario VALUES ('Rodrigo',2,'Sedex');
INSERT INTO usuario VALUES ('Roberto Soriano',3,'Calungada');

CREATE TABLE data_acesso(
dt_data_acesso 				DATE,
hr_data_acesso 				TIME,
cd_usuario 					INT,

CONSTRAINT pk_data_acesso PRIMARY KEY (cd_usuario,dt_data_acesso,hr_data_acesso),
CONSTRAINT fk_data_acesso FOREIGN KEY (cd_usuario) REFERENCES usuario (cd_usuario)

);
