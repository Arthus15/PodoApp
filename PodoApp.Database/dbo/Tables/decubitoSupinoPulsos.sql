CREATE TABLE [dbo].[decubitoSupinoPulsos] (
    [idPulsos]             UNIQUEIDENTIFIER NOT NULL,
    [pulsoPedio]           NVARCHAR (MAX)   NULL,
    [pulsoTibialPosterior] NVARCHAR (MAX)   NULL,
    [id_pulsos_tipo]       UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_decubitoSupinoPulsos] PRIMARY KEY CLUSTERED ([idPulsos] ASC),
    CONSTRAINT [FK_decubitoSupinoPulsos_decubitoSupinoPulsosTipo] FOREIGN KEY ([id_pulsos_tipo]) REFERENCES [dbo].[decubitoSupinoPulsosTipo] ([idPulsosTipo])
);

