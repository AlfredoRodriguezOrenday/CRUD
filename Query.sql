CREATE DATABASE dbExamenTI

USE dbExamenTI

CREATE TABLE Departamento(
Clave VARCHAR(50) PRIMARY KEY,
Nombre VARCHAR(50),
Estatus VARCHAR(50)
)

CREATE TABLE Trabajador(
IdTrabajador INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50), 
Apellidos VARCHAR(50),
FechaNacimiento DATE,
FechaContratacion DATE,
Estatus VARCHAR(50)
)

CREATE TABLE Relaciones(
FkDepartamento VARCHAR(50) FOREIGN KEY REFERENCES Departamento(Clave),
FkTrabajador INT FOREIGN KEY REFERENCES Trabajador(IdTrabajador)
)

Select * from Departamento
Select * from Trabajador
Select * from Relaciones


CREATE PROCEDURE Sp_TrabajadorEdad
AS
BEGIN

SELECT Nombre, DATEDIFF(YEAR,FechaNacimiento,GETDATE()) as Edad  FROM Trabajador Where Estatus = 'Activo'
END

EXEC Sp_TrabajadorEdad

CREATE PROCEDURE Sp_TrabajadorFechaInicio
AS
BEGIN

SELECT Nombre, DATEDIFF(DAY,FechaContratacion, GETDATE()) as DiasContratacion  FROM Trabajador Where Estatus = 'Activo'
END

EXEC Sp_TrabajadorFechaInicio

CREATE PROCEDURE SP_SaveTrabajadorWithDepartamento
@Nombre VARCHAR(50), 
@Apellidos VARCHAR(50),
@FechaNacimiento DATE,
@FechaContratacion DATE,
@Estatus VARCHAR(50),
@FkDepartamento VARCHAR(50)
AS
BEGIN
	INSERT INTO Trabajador VALUES(@Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus);
	DECLARE @ID INT;
	SET @ID = (SELECT TOP(1) IdTrabajador FROM Trabajador ORDER BY IdTrabajador DESC);
	INSERT INTO Relaciones VALUES(@FkDepartamento, @ID);
END

CREATE PROCEDURE SP_SaveTrabajadorWithOutDepartamento
@Nombre VARCHAR(50), 
@Apellidos VARCHAR(50),
@FechaNacimiento DATE,
@FechaContratacion DATE,
@Estatus VARCHAR(50)
AS
BEGIN
	INSERT INTO Trabajador VALUES(@Nombre, @Apellidos, @FechaNacimiento, @FechaContratacion, @Estatus);
END



CREATE PROCEDURE SP_UpdateTrabajadorWithDepartamento
@IdTrabajador int,
@Nombre VARCHAR(50), 
@Apellidos VARCHAR(50),
@FechaNacimiento DATE,
@FechaContratacion DATE,
@Estatus VARCHAR(50),
@FkDepartamento VARCHAR(50)
AS
BEGIN
	UPDATE Trabajador SET Nombre = @Nombre, Apellidos = @Apellidos, FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion, Estatus = @Estatus WHERE IdTrabajador = @IdTrabajador;
	IF EXISTS(SELECT FkTrabajador FROM Relaciones WHERE FkTrabajador = @IdTrabajador)
	BEGIN
		UPDATE Relaciones SET FkDepartamento = @FkDepartamento WHERE FkTrabajador = @IdTrabajador;
	END
	ELSE 
	BEGIN
		INSERT INTO Relaciones VALUES(@FkDepartamento, @IdTrabajador);
	END
END


CREATE PROCEDURE SP_UpdateTrabajadorWithOutDepartamento
@IdTrabajador int,
@Nombre VARCHAR(50), 
@Apellidos VARCHAR(50),
@FechaNacimiento DATE,
@FechaContratacion DATE,
@Estatus VARCHAR(50)
AS
BEGIN
	UPDATE Trabajador SET Nombre = @Nombre, Apellidos = @Apellidos, FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion, Estatus = @Estatus WHERE IdTrabajador = @IdTrabajador;
END

CREATE PROCEDURE SP_SaveDepartamento
@Clave VARCHAR(50),
@Nombre VARCHAR(50),
@Estatus VARCHAR(50)
AS
BEGIN
	IF NOT EXISTS( SELECT @Clave FROM Departamento WHERE Clave = @Clave)
	BEGIN
		INSERT INTO Departamento VALUES(@Clave, @Nombre, @Estatus)
	END
END

