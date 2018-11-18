CREATE TABLE [dbo].[diagnostico] (
    [idDiagnostico]     UNIQUEIDENTIFIER NOT NULL,
    [anotaciones]       NVARCHAR (MAX)   NULL,
    [id_primera_visita] UNIQUEIDENTIFIER NULL,
    [id_tratamiento]    UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_diagnostico] PRIMARY KEY CLUSTERED ([idDiagnostico] ASC),
    CONSTRAINT [FK_diagnostico_primeraVisita] FOREIGN KEY ([id_primera_visita]) REFERENCES [dbo].[primeraVisita] ([idPrimeraVisita]),
    CONSTRAINT [FK_diagnostico_tratamiento] FOREIGN KEY ([id_tratamiento]) REFERENCES [dbo].[tratamiento] ([idTratamiento])
);

