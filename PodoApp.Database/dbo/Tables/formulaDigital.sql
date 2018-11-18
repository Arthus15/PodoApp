CREATE TABLE [dbo].[formulaDigital] (
    [idFormulaDigital] UNIQUEIDENTIFIER NOT NULL,
    [egipcia]          BIT              NOT NULL,
    [griega]           BIT              NOT NULL,
    [cuadrada]         BIT              NOT NULL,
    [otra]             NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_formulaDigital] PRIMARY KEY CLUSTERED ([idFormulaDigital] ASC)
);

