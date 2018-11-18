CREATE TABLE [dbo].[persona] (
    [idPersona]       UNIQUEIDENTIFIER NOT NULL,
    [nombre]          NVARCHAR (MAX)   NULL,
    [apellido1]       NVARCHAR (MAX)   NULL,
    [apellido2]       NVARCHAR (MAX)   NULL,
    [fechaNacimiento] DATETIME         NULL,
    [edad]            INT              NULL,
    [profesion]       NVARCHAR (MAX)   NULL,
    [calle]           NVARCHAR (MAX)   NULL,
    [ciudad]          NVARCHAR (MAX)   NULL,
    [provincia]       NVARCHAR (MAX)   NULL,
    [pais]            NVARCHAR (MAX)   NULL,
    [telefono]        NVARCHAR (20)    NULL,
    [dni]             NVARCHAR (10)    NULL,
    CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED ([idPersona] ASC)
);

