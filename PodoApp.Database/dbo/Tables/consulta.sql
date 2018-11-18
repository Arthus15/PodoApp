CREATE TABLE [dbo].[consulta] (
    [idConsulta]  UNIQUEIDENTIFIER NOT NULL,
    [fecha]       DATETIME         NULL,
    [descripcion] NVARCHAR (MAX)   NULL,
    [id_paciente] UNIQUEIDENTIFIER NULL,
    [id_podologo] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_consulta] PRIMARY KEY CLUSTERED ([idConsulta] ASC),
    CONSTRAINT [FK_consulta_paciente] FOREIGN KEY ([id_paciente]) REFERENCES [dbo].[paciente] ([idPaciente]),
    CONSTRAINT [FK_consulta_podologo] FOREIGN KEY ([id_podologo]) REFERENCES [dbo].[podologo] ([idPodologo])
);

