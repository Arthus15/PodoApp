CREATE TABLE [dbo].[retropie] (
    [idRetropie] UNIQUEIDENTIFIER NOT NULL,
    [varo]       BIT              NOT NULL,
    [valgo]      BIT              NOT NULL,
    [neutro]     BIT              NOT NULL,
    CONSTRAINT [PK_retropie] PRIMARY KEY CLUSTERED ([idRetropie] ASC)
);

