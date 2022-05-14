use taller

CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nombre] VARCHAR(50) NULL,
	[Usuario] VARCHAR(50) NULL,
	[Password] VARCHAR(50) NULL,
	[Tipo_Usuario] VARCHAR(50) NULL
)

select * from Usuarios

insert into Usuarios values	('Nick Fury','giganigga','nicknitro','Admin'),
							('Luisina is not Fury','slash777fortnite','trollingpass','Usuario');