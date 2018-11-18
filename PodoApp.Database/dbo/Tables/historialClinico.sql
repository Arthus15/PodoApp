CREATE TABLE [dbo].[historialClinico] (
    [idHistorialClinico]     UNIQUEIDENTIFIER NOT NULL,
    [numeroHistorialClinico] NCHAR (10)       NULL,
    [id_ant_podologicos]     UNIQUEIDENTIFIER NULL,
    [id_ant_patologicos]     UNIQUEIDENTIFIER NULL,
    [id_ant_fisiologicos]    UNIQUEIDENTIFIER NULL,
    [id_ant_familiares]      UNIQUEIDENTIFIER NULL,
    [id_estudio]             UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_historialClinico] PRIMARY KEY CLUSTERED ([idHistorialClinico] ASC),
    CONSTRAINT [FK_historialClinico_antecedentesFamiliares] FOREIGN KEY ([id_ant_familiares]) REFERENCES [dbo].[antecedentesFamiliares] ([idAFamiliares]),
    CONSTRAINT [FK_historialClinico_antecedentesFisiologicos] FOREIGN KEY ([id_ant_fisiologicos]) REFERENCES [dbo].[antecedentesFisiologicos] ([idAFisiologico]),
    CONSTRAINT [FK_historialClinico_antecedentesPatologicos] FOREIGN KEY ([id_ant_patologicos]) REFERENCES [dbo].[antecedentesPatologicos] ([idAPatologico]),
    CONSTRAINT [FK_historialClinico_antecedentesPodologicos] FOREIGN KEY ([id_ant_podologicos]) REFERENCES [dbo].[antecedentesPodologicos] ([idAPodologicos])
);

