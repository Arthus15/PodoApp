CREATE TABLE [dbo].[antecedentesPodologicos] (
    [idAPodologicos] UNIQUEIDENTIFIER NOT NULL,
    [haidoPodologo]  BIT              NOT NULL,
    [antecedentes]   NVARCHAR (50)    NULL,
    CONSTRAINT [PK_antecedentesPodologicos] PRIMARY KEY CLUSTERED ([idAPodologicos] ASC)
);

