CREATE TABLE [dbo].[sedestacionExploracionMuscular] (
    [idEMuscularPieIzdo]        UNIQUEIDENTIFIER NOT NULL,
    [idEMuscularPieDcho]        UNIQUEIDENTIFIER NOT NULL,
    [hiperlaxitudArticularIzdo] BIT              NOT NULL,
    [hiperlaxitudArticularDcho] BIT              NOT NULL,
    CONSTRAINT [PK_exploracionMuscular] PRIMARY KEY CLUSTERED ([idEMuscularPieIzdo] ASC, [idEMuscularPieDcho] ASC)
);

