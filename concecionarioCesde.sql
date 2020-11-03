create database concesionarioCesde

use concesionarioCesde

/*TABLA TIPO VEHICULO--------------------------------------------------------------------------*/
create table tipo_vehiculo
(
	id int primary key,
	nombre varchar(50),
)

/*INSERT*/
create proc registrarTipoVehiculos
(
	@id int, @nombre varchar(50)
)
as insert into tipo_vehiculo values(@id, @nombre)

select * from tipo_vehiculo;

/*UPDATE*/

create proc updateTipoVehiculo 
(
	@id int, @nombre varchar(50)
)
as update tipo_vehiculo set nombre = @nombre where id = @id;

/*DELETE*/
create proc deleteTipoVehiculo 
(
	@id int
)
as delete from tipo_vehiculo where id = @id;

/*TABLA VEHICULO--------------------------------------------------------------------------*/

create table vehiculo
(
	id int primary key,
	marca varchar(50),
	modelo varchar(50),
	matricula varchar(50),
	anio int,
	id_tipo_vehiculo int

	constraint fk_tipo_vehiculo foreign key (id_tipo_vehiculo) references tipo_vehiculo (id)
)

/*INSERT*/
create proc registrarVehiculo
(
	@id int, @marca varchar(50), @modelo varchar(50), @matricula varchar (50), @anio int, @id_tipo_vehiculo int
)
as insert into vehiculo values(@id, @marca, @modelo, @matricula, @anio, @id_tipo_vehiculo)

select * from vehiculo

/*TABLA TIPO CONDUCTOR--------------------------------------------------------------------------*/
create table tipo_conductor
(
	id int primary key,
	nombre varchar(50),
)

/*INSERT*/
create proc registrarTipoConductor
(
	@id int, @nombre varchar(50)
)
as insert into tipo_conductor values(@id, @nombre)


/*TABLA CONDUCTOR--------------------------------------------------------------------------*/

create table conductor
(
	id int NOT NULL,
	nombre varchar(50),
	tipo_licencia varchar(50),
	id_vehiculo int NOT NULL,
	id_tipo_conductor int NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT FK_idVehiculoC FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id),
	CONSTRAINT FK_idTipoConductorC FOREIGN KEY (id_tipo_conductor) REFERENCES tipo_conductor(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE
)

/*INSERT*/
create proc registrarConductor
(
	@id int, @nombre varchar(50), @tipo_licencia varchar(50), @id_vehiculo int, @id_tipo_conductor int
)
as insert into conductor values(@id, @nombre, @tipo_licencia, @id_vehiculo, @id_tipo_conductor)


/*TABLA TIPO CONTRATO--------------------------------------------------------------------------*/

create table contrato
(
	id_contrato int NOT NULL PRIMARY KEY,
	id_vehiculo int NOT NULL,
	id_tipo_conductor int NOT NULL,
	CONSTRAINT FK_contrato_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id),
	CONSTRAINT FK_contrato_conductor FOREIGN KEY (id_tipo_conductor) REFERENCES tipo_conductor(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE 
)

SELECT * from contrato

/*INSERT*/
create proc registrarContrato
(
	@id int, @id_vehiculo int, @id_tipo_conductor int
)
as insert into contrato values(@id, @id_vehiculo, @id_tipo_conductor)

/*TABLA TIPO RUTA--------------------------------------------------------------------------*/

create table ruta
(
	id int NOT NULL,
	estacion varchar(50),
	id_vehiculo int NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT FK_ruta_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE 
)

/*INSERT*/
create proc registrarRuta
(
	@id int, @estacion varchar(50), @id_vehiculo int
)
as insert into ruta values(@id, @estacion, @id_vehiculo)

SELECT * FROM Tipo_Vehiculo;