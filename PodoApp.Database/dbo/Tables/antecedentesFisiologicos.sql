CREATE TABLE [dbo].[antecedentesFisiologicos] (
    [idAFisiologico]     UNIQUEIDENTIFIER NOT NULL,
    [andador]            BIT              NOT NULL,
    [tacata]             BIT              NOT NULL,
    [inicioDeambulacion] INT              NULL,
    [habitosPosturales]  NVARCHAR (MAX)   NULL,
    [cambiosPonderales]  INT              NULL,
    [zurdo]              BIT              NOT NULL,
    [diestro]            BIT              NOT NULL,
    [ambidiestro]        BIT              NOT NULL,
    [otros]              NVARCHAR (MAX)   NULL,
    [partoCabeza]        BIT              NOT NULL,
    [partoNalgas]        BIT              NOT NULL,
    CONSTRAINT [PK_antecedentesFisiologicos] PRIMARY KEY CLUSTERED ([idAFisiologico] ASC)
);

