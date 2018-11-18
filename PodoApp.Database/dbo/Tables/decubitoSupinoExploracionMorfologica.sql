CREATE TABLE [dbo].[decubitoSupinoExploracionMorfologica] (
    [idEMorfologica]        UNIQUEIDENTIFIER NOT NULL,
    [antepieTriangular]     BIT              NOT NULL,
    [otros]                 NVARCHAR (MAX)   NULL,
    [id_formula_metatarsal] UNIQUEIDENTIFIER NULL,
    [id_formula_digital]    UNIQUEIDENTIFIER NULL,
    [id_formula_podal]      UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_decubitoSupinoExploracionMorfologica] PRIMARY KEY CLUSTERED ([idEMorfologica] ASC),
    CONSTRAINT [FK_decubitoSupinoExploracionMorfologica_formulaDigital] FOREIGN KEY ([id_formula_digital]) REFERENCES [dbo].[formulaDigital] ([idFormulaDigital]),
    CONSTRAINT [FK_decubitoSupinoExploracionMorfologica_formulaMetatarsal] FOREIGN KEY ([id_formula_metatarsal]) REFERENCES [dbo].[formulaMetatarsal] ([idFormulaMetatarsal]),
    CONSTRAINT [FK_decubitoSupinoExploracionMorfologica_formulaPodal] FOREIGN KEY ([id_formula_podal]) REFERENCES [dbo].[formulaPodal] ([idFormulaPodal])
);

