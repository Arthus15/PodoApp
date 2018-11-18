CREATE TABLE [dbo].[calzadoHabitual] (
    [idCalzado]  UNIQUEIDENTIFIER NOT NULL,
    [deportivos] BIT              NOT NULL,
    [vestir]     BIT              NOT NULL,
    [sandalias]  BIT              NOT NULL,
    [botines]    BIT              NOT NULL,
    [tacones]    BIT              NOT NULL,
    CONSTRAINT [PK_calzadoHabitual] PRIMARY KEY CLUSTERED ([idCalzado] ASC)
);

