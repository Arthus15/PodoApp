﻿CREATE TABLE [dbo].[primeraVisita] (
    [idPrimeraVisita]           UNIQUEIDENTIFIER NOT NULL,
    [peso]                      FLOAT (53)       NULL,
    [talla]                     FLOAT (53)       NULL,
    [actividadDeportiva]        NVARCHAR (MAX)   NULL,
    [diabetes]                  BIT              NOT NULL,
    [alergias]                  BIT              NOT NULL,
    [tipoAlergias]              NVARCHAR (MAX)   NULL,
    [motivoPrimeraConsulta]     NVARCHAR (MAX)   NULL,
    [hayDolor]                  BIT              NOT NULL,
    [dolorSitio]                NVARCHAR (MAX)   NULL,
    [dolorTipo]                 NVARCHAR (MAX)   NULL,
    [fechaPrimeraConsulta]      DATETIME         NULL,
    [id_podologo]               UNIQUEIDENTIFIER NULL,
    [id_paciente]               UNIQUEIDENTIFIER NULL,
    [id_historial_clinico]      UNIQUEIDENTIFIER NULL,
    [id_tipo_estudio]           UNIQUEIDENTIFIER NULL,
    [id_estudio_ortopodologico] UNIQUEIDENTIFIER NULL,
    [id_calzado_habitual]       UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_primeraVisita] PRIMARY KEY CLUSTERED ([idPrimeraVisita] ASC),
    CONSTRAINT [FK_primeraVisita_calzadoHabitual] FOREIGN KEY ([id_calzado_habitual]) REFERENCES [dbo].[calzadoHabitual] ([idCalzado]),
    CONSTRAINT [FK_primeraVisita_estudioOrtopodologico] FOREIGN KEY ([id_estudio_ortopodologico]) REFERENCES [dbo].[estudioOrtopodologico] ([idEOrtopodologico]),
    CONSTRAINT [FK_primeraVisita_paciente] FOREIGN KEY ([id_paciente]) REFERENCES [dbo].[paciente] ([idPaciente]),
    CONSTRAINT [FK_primeraVisita_podologo] FOREIGN KEY ([id_podologo]) REFERENCES [dbo].[podologo] ([idPodologo]),
    CONSTRAINT [FK_primeraVisita_tipoEstudio] FOREIGN KEY ([id_tipo_estudio]) REFERENCES [dbo].[tipoEstudio] ([idTipoEstudio])
);

