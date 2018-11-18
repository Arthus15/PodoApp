CREATE TABLE [dbo].[tipoEstudio] (
    [idTipoEstudio]  UNIQUEIDENTIFIER NOT NULL,
    [ortopodologico] BIT              NOT NULL,
    CONSTRAINT [PK_tipoEstudio] PRIMARY KEY CLUSTERED ([idTipoEstudio] ASC)
);

