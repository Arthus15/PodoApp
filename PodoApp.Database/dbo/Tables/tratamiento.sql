CREATE TABLE [dbo].[tratamiento] (
    [idTratamiento]            UNIQUEIDENTIFIER NOT NULL,
    [fisico]                   BIT              NOT NULL,
    [ejerciciosPropioceptivos] NVARCHAR (MAX)   NULL,
    [farmacologico]            BIT              NOT NULL,
    [quiropodologico]          BIT              NOT NULL,
    [ortosisDigital]           BIT              NOT NULL,
    [ortosisDigitalTipo]       NVARCHAR (MAX)   NULL,
    [soportePlantar]           BIT              NOT NULL,
    [vendajeFuncional]         BIT              NOT NULL,
    [preventivo]               BIT              NOT NULL,
    [preventivoObservacion]    NVARCHAR (MAX)   NULL,
    [calzadoterapia]           BIT              NOT NULL,
    [otros]                    NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_tratamiento] PRIMARY KEY CLUSTERED ([idTratamiento] ASC)
);

