CREATE TABLE [dbo].[deambulacion] (
    [idDeambulacion] UNIQUEIDENTIFIER NOT NULL,
    [anotaciones]    NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_deambulacion] PRIMARY KEY CLUSTERED ([idDeambulacion] ASC)
);

