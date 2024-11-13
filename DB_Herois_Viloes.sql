create database DB_Herois_viloes3

use DB_Herois_viloes3

create table Herois
(
	idHeroi int not null  primary key identity,
	nome	varchar(50) not null,
	anoNasc int,
	idade int, 
	email varchar (50),
	caminhoImagem varchar (100),
	nomeHeroi varchar(50) not null,
	planetaOrigem varchar(50) not null,
	atividadeProfissional varchar(50),
	parceiro varchar (50),
	superPoder varchar(50),
	grupo varchar (50),
	pontoFraco varchar(50)
)
go

create table Viloes
(
	idVilao int not null  primary key identity,
	nome	varchar(50) not null,
	anoNasc int,
	idade int, 
	email varchar (50),
	caminhoImagem varchar (100),
	nomeVilao varchar(50) not null,
	planetaOrigem varchar(20) not null,
	parceiro varchar(50),
	superPoder varchar(30)
)
go

create table AmigosHeroi
(
	idAmigo int not null  primary key identity,
	nome	varchar(50) not null,
	anoNasc int,
	idade int, 
	email varchar (50),
	caminhoImagem varchar(100),
	hobby varchar(30),
	atividadeProfissional varchar(50)
)
go