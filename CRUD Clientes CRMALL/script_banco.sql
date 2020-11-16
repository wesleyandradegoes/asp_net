create database ClientesDB;

CREATE TABLE ClientesDB.endereco (
  Id bigint NOT NULL,
  Bairro varchar(255) DEFAULT NULL,
  Cep varchar(255) DEFAULT NULL,
  Cidade varchar(255) DEFAULT NULL,
  Complemento varchar(255) DEFAULT NULL,
  Estado varchar(255) DEFAULT NULL,
  Logradouro varchar(255) DEFAULT NULL,
  Numero int DEFAULT NULL,
  PRIMARY KEY (Id)
);

CREATE TABLE ClientesDB.cliente (
  Id bigint NOT NULL,
  Nome varchar(255) NOT NULL,
  DataNascimento datetime NOT NULL,
  Sexo varchar(255) NOT NULL,
  Endereco_id bigint DEFAULT NULL,
  PRIMARY KEY (Id),
  KEY Endereco_id (Endereco_id),
  CONSTRAINT FK_3BCD77EA FOREIGN KEY (Endereco_id) REFERENCES endereco (Id)
);