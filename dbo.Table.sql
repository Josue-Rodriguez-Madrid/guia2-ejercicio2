CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY (1, 1), 
    [Dui] VARCHAR(50) NOT NULL, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [Apellido] VARCHAR(50) NOT NULL, 
    [FechaNacimiento] DATETIME NOT NULL, 
    [Direccion] VARCHAR(50) NOT NULL, 
    [Correo] VARCHAR(50) NOT NULL
)
