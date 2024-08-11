CREATE DATABASE proyectofinal
USE proyectofinal

CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) null,
	password VARCHAR(MAX) null,
	date_register DATE null
)

SELECT * FROM users

CREATE TABLE voluntarios
(
	id INT PRIMARY KEY IDENTITY(1,1),
	voluntario_id VARCHAR(MAX) NULL,
	nombre VARCHAR(MAX) NULL,
	genero VARCHAR(MAX) NULL,
	numero VARCHAR(MAX) NULL,
	imagen VARCHAR(MAX) NULL,
	insert_date DATE null,
	update_date DATE null,
	delete_date DATE null,
	clear_date DATE null
)

SELECT * FROM voluntarios

CREATE TABLE eventos
(
	id_evento INT PRIMARY KEY IDENTITY(1,1),
	evento VARCHAR(MAX) NULL,
	fecha VARCHAR(MAX) NULL,
	ubicacion DATE null,
	insert_date DATE null,
	update_date DATE null,
	delete_date DATE null
)

SELECT * FROM eventos

SELECT * FROM voluntarios WHERE delete_date IS NULL