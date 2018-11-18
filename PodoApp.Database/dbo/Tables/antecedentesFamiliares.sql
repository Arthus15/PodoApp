CREATE TABLE [dbo].[antecedentesFamiliares] (
    [idAFamiliares] UNIQUEIDENTIFIER NOT NULL,
    [dismetrias]    BIT              NOT NULL,
    [escoliosis]    BIT              NOT NULL,
    [tibiasVaras]   BIT              NOT NULL,
    [piesPlanos]    BIT              NOT NULL,
    [piesCavos]     BIT              NOT NULL,
    [piesValgos]    BIT              NOT NULL,
    [piesZambos]    BIT              NOT NULL,
    [hallusValgus]  BIT              NOT NULL,
    [dedosGarra]    BIT              NOT NULL,
    [otros]         NVARCHAR (MAX)   NULL,
    [genuVaro]      BIT              NOT NULL,
    [genuValgo]     BIT              NOT NULL,
    [metaAductus]   BIT              NOT NULL,
    [metaVarus]     BIT              NOT NULL,
    CONSTRAINT [PK_antecedentesFamiliares] PRIMARY KEY CLUSTERED ([idAFamiliares] ASC)
);

