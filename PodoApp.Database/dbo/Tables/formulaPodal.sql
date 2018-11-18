CREATE TABLE [dbo].[formulaPodal] (
    [idFormulaPodal] UNIQUEIDENTIFIER NOT NULL,
    [normolineo]     BIT              NOT NULL,
    [longilineo]     BIT              NOT NULL,
    [brevilineo]     BIT              NOT NULL,
    [otra]           NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_formulaPodal] PRIMARY KEY CLUSTERED ([idFormulaPodal] ASC)
);

