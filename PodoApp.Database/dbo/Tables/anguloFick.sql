CREATE TABLE [dbo].[anguloFick] (
    [idAngulo] UNIQUEIDENTIFIER NOT NULL,
    [abierto]  BIT              NULL,
    [cerrado]  BIT              NULL,
    [neutro]   BIT              NULL,
    CONSTRAINT [PK_anguloFick] PRIMARY KEY CLUSTERED ([idAngulo] ASC)
);

