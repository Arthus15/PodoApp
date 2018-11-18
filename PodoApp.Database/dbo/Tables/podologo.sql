CREATE TABLE [dbo].[podologo] (
    [idPodologo] UNIQUEIDENTIFIER NOT NULL,
    [idTitulo]   NVARCHAR (50)    NULL,
    [email]      NVARCHAR (MAX)   NULL,
    [id_persona] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_podologo] PRIMARY KEY CLUSTERED ([idPodologo] ASC),
    CONSTRAINT [FK_podologo_persona] FOREIGN KEY ([id_persona]) REFERENCES [dbo].[persona] ([idPersona]) ON DELETE CASCADE ON UPDATE CASCADE
);

