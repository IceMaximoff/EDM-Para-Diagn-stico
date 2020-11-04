USE [CapstoneDB]
GO 
CREATE TABLE Alumno(
 idAlumno int primary key IDENTITY(1,1),
 nombresAlumno varchar(100) not null,
 apellidosAlumno varchar(100) not null,
 edadAlumno int not null

);

INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Jose','Galvez',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Maria','Melgar',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Pedro','Castillo',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Francisco','Sanchez',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Kiara','Bazan',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Renata','Gomez',6);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Julio','Pajares',7);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Cristina','Aguilar',7);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Elvia','Mujica',7);
INSERT INTO Alumno (nombresAlumno,apellidosAlumno,edadAlumno) VALUES ('Enrique','Lazo',7);

