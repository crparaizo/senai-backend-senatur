CREATE DATABASE SENATUR_TARDE;

USE SENATUR_TARDE;

CREATE TABLE PACOTES (
	PacoteId INT IDENTITY PRIMARY KEY 
	,NomePacote VARCHAR (255) NOT NULL
	,Descricao TEXT NOT NULL
	,DataIda DATETIME NOT NULL
	,DataVolta DATETIME NOT NULL
	,Valor DECIMAL NOT NULL
	,Ativo CHAR(3) NOT NULL --Na API ser� um enum
	,NomeCidade VARCHAR (255) NOT NULL
);

CREATE TABLE USUARIOS (
	UsuarioId INT IDENTITY PRIMARY KEY
	,Email VARCHAR (255) NOT NULL
	,Senha VARCHAR (255) NOT NULL
	,TipoUsuario VARCHAR (255) NOT NULL
);