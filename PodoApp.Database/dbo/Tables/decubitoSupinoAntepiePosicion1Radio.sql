CREATE TABLE [dbo].[decubitoSupinoAntepiePosicion1Radio] (
    [idPosicion1radio] UNIQUEIDENTIFIER NOT NULL,
    [dorsalrFlex]      BIT              NOT NULL,
    [plantarFlex]      BIT              NOT NULL,
    [neutro]           BIT              NOT NULL,
    CONSTRAINT [PK_decubitoSupinoAntepiePosicion1Radio] PRIMARY KEY CLUSTERED ([idPosicion1radio] ASC)
);

