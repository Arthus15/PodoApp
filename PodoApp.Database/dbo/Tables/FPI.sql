CREATE TABLE [dbo].[FPI] (
    [idFPI]                       UNIQUEIDENTIFIER NOT NULL,
    [palpacionEstragaloIzda]      INT              NULL,
    [palpacionEstragaloDcha]      INT              NULL,
    [curvaturaMaleolarIzda]       INT              NULL,
    [curvaturaMaleolarDcha]       INT              NULL,
    [posicionCalcaneoIzda]        INT              NULL,
    [posicionCalcaneoDcha]        INT              NULL,
    [prominenciaArticulacionIzda] INT              NULL,
    [prominenciaArticulacionDcha] INT              NULL,
    [alturaYcongruenciaIzda]      INT              NULL,
    [alturaYcongruenciaDcha]      INT              NULL,
    [abduccionYaduccionIzda]      INT              NULL,
    [abduccionYaduccionDcha]      INT              NULL,
    CONSTRAINT [PK_FPI] PRIMARY KEY CLUSTERED ([idFPI] ASC)
);

