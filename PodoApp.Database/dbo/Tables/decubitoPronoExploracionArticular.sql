CREATE TABLE [dbo].[decubitoPronoExploracionArticular] (
    [idEArticularPieIzdo]       UNIQUEIDENTIFIER NOT NULL,
    [idEArticularPieDcho]       UNIQUEIDENTIFIER NOT NULL,
    [caderaRotInternaIzdo]      FLOAT (53)       NULL,
    [caderaRotInternaDcho]      FLOAT (53)       NULL,
    [caderaRotExternaIzdo]      FLOAT (53)       NULL,
    [caderaRotExternaDcho]      FLOAT (53)       NULL,
    [torsionFemoralInternaIzdo] FLOAT (53)       NULL,
    [torsionFemoralInternaDcho] FLOAT (53)       NULL,
    [torsionFemoralExternaIzdo] FLOAT (53)       NULL,
    [torsionFemoralExternaDcho] FLOAT (53)       NULL,
    [torsionTibialInternaIzdo]  FLOAT (53)       NULL,
    [torsionTibialInternaDcho]  FLOAT (53)       NULL,
    [torsionTibialExternaIzdo]  FLOAT (53)       NULL,
    [torsionTibialExternaDcho]  FLOAT (53)       NULL,
    CONSTRAINT [PK_decubitoPronoExploracionArticular_1] PRIMARY KEY CLUSTERED ([idEArticularPieIzdo] ASC, [idEArticularPieDcho] ASC)
);

