CREATE TABLE [dbo].[visionFrontal] (
    [idFrontal]     UNIQUEIDENTIFIER NOT NULL,
    [anterior]      NVARCHAR (MAX)   NULL,
    [posterior]     NVARCHAR (MAX)   NULL,
    [id_anguloFick] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_visionFrontal] PRIMARY KEY CLUSTERED ([idFrontal] ASC),
    CONSTRAINT [FK_visionFrontal_anguloFick] FOREIGN KEY ([id_anguloFick]) REFERENCES [dbo].[anguloFick] ([idAngulo])
);

