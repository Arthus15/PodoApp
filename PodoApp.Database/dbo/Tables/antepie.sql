CREATE TABLE [dbo].[antepie] (
    [idAntepie] UNIQUEIDENTIFIER NOT NULL,
    [varo]      BIT              NOT NULL,
    [supinado]  BIT              NOT NULL,
    [valgo]     BIT              NOT NULL,
    [neutro]    BIT              NOT NULL,
    CONSTRAINT [PK_antepie] PRIMARY KEY CLUSTERED ([idAntepie] ASC)
);

