CREATE TABLE [dbo].[decubitoSupinoPulsosTipo] (
    [idPulsosTipo] UNIQUEIDENTIFIER NOT NULL,
    [presente]     BIT              NOT NULL,
    [ausente]      BIT              NOT NULL,
    [debil]        NCHAR (10)       NULL,
    CONSTRAINT [PK_decubitoSupinoPulsosTipo] PRIMARY KEY CLUSTERED ([idPulsosTipo] ASC)
);

