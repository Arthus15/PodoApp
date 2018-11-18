CREATE TABLE [dbo].[paciente] (
    [idPaciente]           UNIQUEIDENTIFIER NOT NULL,
    [medicacionHabitual]   NVARCHAR (MAX)   NULL,
    [observacion]          NVARCHAR (MAX)   NULL,
    [id_podologo]          UNIQUEIDENTIFIER NULL,
    [id_historial_clinico] UNIQUEIDENTIFIER NULL,
    [id_persona]           UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_paciente] PRIMARY KEY CLUSTERED ([idPaciente] ASC),
    CONSTRAINT [FK_paciente_historialClinico] FOREIGN KEY ([id_historial_clinico]) REFERENCES [dbo].[historialClinico] ([idHistorialClinico]),
    CONSTRAINT [FK_paciente_persona] FOREIGN KEY ([id_persona]) REFERENCES [dbo].[persona] ([idPersona]),
    CONSTRAINT [FK_paciente_podologo] FOREIGN KEY ([id_podologo]) REFERENCES [dbo].[podologo] ([idPodologo]) ON DELETE CASCADE ON UPDATE CASCADE
);

