CREATE TABLE [dbo].[materialSoportePlantar] (
    [idMaterialSoportePlantar] UNIQUEIDENTIFIER NOT NULL,
    [TAD]                      BIT              NOT NULL,
    [resinas]                  BIT              NOT NULL,
    [EVA]                      BIT              NOT NULL,
    [propileno]                BIT              NOT NULL,
    [componentes]              NVARCHAR (MAX)   NULL,
    [otros]                    NVARCHAR (MAX)   NULL,
    [id_tratamiento]           UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_materialSoportePlantar] PRIMARY KEY CLUSTERED ([idMaterialSoportePlantar] ASC),
    CONSTRAINT [FK_materialSoportePlantar_tratamiento] FOREIGN KEY ([id_tratamiento]) REFERENCES [dbo].[tratamiento] ([idTratamiento])
);

