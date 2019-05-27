CREATE TABLE [dbo].[Audit] (
    [Id]        INT           NOT NULL IDENTITY(1,1),
    [UserName]  VARCHAR (50)  NULL,
    [TableName] VARCHAR (50)  NULL,
    [Operation] VARCHAR (20)  NULL,
    [NewValue]  VARCHAR (MAX) NULL,
    [DateTime]  DATETIME      NULL, 
    CONSTRAINT [PK_Audit] PRIMARY KEY ([Id])
);

