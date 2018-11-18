CREATE TABLE [dbo].[antecedentesPatologicos] (
    [idAPatologico]           UNIQUEIDENTIFIER NOT NULL,
    [patologiaPrevia]         NVARCHAR (MAX)   NULL,
    [enfermedadInfantil]      NVARCHAR (MAX)   NULL,
    [antecedentesTraumatico]  NVARCHAR (MAX)   NULL,
    [bursitis]                BIT              NOT NULL,
    [capsulitis]              BIT              NOT NULL,
    [enfermedadReumatica]     BIT              NOT NULL,
    [tipoEnfermedadReumatica] NVARCHAR (MAX)   NULL,
    [ciatica]                 BIT              NOT NULL,
    [otros]                   NVARCHAR (MAX)   NULL,
    [distension]              BIT              NOT NULL,
    [esguince]                BIT              NOT NULL,
    [tendinitis]              BIT              NOT NULL,
    [contracturas]            BIT              NOT NULL,
    [luxacion]                BIT              NOT NULL,
    [subluxacion]             BIT              NOT NULL,
    [fisura]                  BIT              NOT NULL,
    [fractura]                BIT              NOT NULL,
    CONSTRAINT [PK_antecedentesPatologicos] PRIMARY KEY CLUSTERED ([idAPatologico] ASC)
);

