CREATE TABLE [dbo].[sedestacionExploracionArticular] (
    [idEArticularPieIzdo]           UNIQUEIDENTIFIER NOT NULL,
    [idEArticularPieDcho]           UNIQUEIDENTIFIER NOT NULL,
    [anteversionFemoralNinosIzda]   FLOAT (53)       NULL,
    [anteversionFemoralNinosDcha]   FLOAT (53)       NULL,
    [anteversionFemoralAdultosIzda] FLOAT (53)       NULL,
    [anteversionFemoralAdultosDcha] FLOAT (53)       NULL,
    [anguloTorsionBimaleolarIzda]   FLOAT (53)       NULL,
    [anguloTorsionBimaleolarDcha]   FLOAT (53)       NULL,
    CONSTRAINT [PK_exploracionArticular] PRIMARY KEY CLUSTERED ([idEArticularPieIzdo] ASC, [idEArticularPieDcho] ASC)
);

