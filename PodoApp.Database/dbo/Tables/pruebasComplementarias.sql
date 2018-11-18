CREATE TABLE [dbo].[pruebasComplementarias] (
    [idPrueba]          UNIQUEIDENTIFIER NOT NULL,
    [pedigrafia]        VARBINARY (MAX)  NULL,
    [rayosX]            VARBINARY (MAX)  NULL,
    [analisisSanguineo] VARBINARY (MAX)  NULL,
    [cultivo]           VARBINARY (MAX)  NULL,
    [doppler]           VARBINARY (MAX)  NULL,
    [ecografia]         VARBINARY (MAX)  NULL,
    [fotos]             VARBINARY (MAX)  NULL,
    [fecha]             DATETIME         NULL,
    [id_primera_visita] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_pruebasComplementarias] PRIMARY KEY CLUSTERED ([idPrueba] ASC),
    CONSTRAINT [FK_pruebasComplementarias_primeraVisita] FOREIGN KEY ([id_primera_visita]) REFERENCES [dbo].[primeraVisita] ([idPrimeraVisita])
);

