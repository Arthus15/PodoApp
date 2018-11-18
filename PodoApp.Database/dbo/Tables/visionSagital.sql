CREATE TABLE [dbo].[visionSagital] (
    [idSagital] UNIQUEIDENTIFIER NOT NULL,
    [estatica]  NVARCHAR (MAX)   NULL,
    [dinamica]  NVARCHAR (MAX)   NULL,
    [otros]     NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_visionSagital] PRIMARY KEY CLUSTERED ([idSagital] ASC)
);

