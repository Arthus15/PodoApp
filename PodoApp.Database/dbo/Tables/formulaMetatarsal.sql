CREATE TABLE [dbo].[formulaMetatarsal] (
    [idFormulaMetatarsal] UNIQUEIDENTIFIER NOT NULL,
    [indexMinus]          BIT              NOT NULL,
    [indexPlus]           BIT              NOT NULL,
    [indexPlusMinus]      BIT              NOT NULL,
    [otra]                NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_formulaMetatarsal] PRIMARY KEY CLUSTERED ([idFormulaMetatarsal] ASC)
);

