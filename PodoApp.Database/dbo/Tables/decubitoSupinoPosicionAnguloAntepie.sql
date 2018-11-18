CREATE TABLE [dbo].[decubitoSupinoPosicionAnguloAntepie] (
    [idPosicionAnguloAntepie] UNIQUEIDENTIFIER NOT NULL,
    [valgo]                   BIT              NOT NULL,
    [varo]                    BIT              NOT NULL,
    [supinado]                BIT              NOT NULL,
    [neutro]                  BIT              NOT NULL,
    CONSTRAINT [PK_decubitoSupinoPosicionAnguloAntepie] PRIMARY KEY CLUSTERED ([idPosicionAnguloAntepie] ASC)
);

