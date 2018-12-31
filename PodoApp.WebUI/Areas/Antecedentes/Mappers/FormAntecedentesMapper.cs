using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.Antecedentes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Antecedentes.Mappers
{
    public static class FormAntecedentesMapper
    {
        private static Guid nuevoIdPodo = Guid.Empty;
        private static Guid nuevoIdFam = Guid.Empty;
        private static Guid nuevoIdFisio = Guid.Empty;
        private static Guid nuevoIdPato = Guid.Empty;

        public static HistorialClinicoDto FormToHistorialClinicoDto(this FormAntecedentes form, bool newForm = true)
        {
            if (newForm)
            {
                nuevoIdPodo = Guid.NewGuid();
                nuevoIdPato = Guid.NewGuid();
                nuevoIdFisio = Guid.NewGuid();
                nuevoIdFam = Guid.NewGuid();
            }
            else
            {
                nuevoIdFam = (Guid)form.IdAntFamiliares;
                nuevoIdFisio = (Guid)form.IdAntFisiologicos;
                nuevoIdPato = (Guid)form.IdAntPatologicos;
                nuevoIdPodo = (Guid)form.IdAntPodologicos;
            }

            return new HistorialClinicoDto
            {
                idHistorialClinico = form.IdHistorialClinico,
                id_ant_familiares = nuevoIdFam,
                id_ant_fisiologicos = nuevoIdFisio,
                id_ant_patologicos = nuevoIdPato,
                id_ant_podologicos = nuevoIdPodo,
                antecedentesPodologicos = new AntecedentesPodologicosDto
                {
                    idAPodologicos = nuevoIdPodo,
                    haidoPodologo = form.HaIdoPodologo,
                    antecedentes = form.Antecedentes
                },
                antecedentesPatologicos = new AntecedentesPatologicosDto
                {
                    idAPatologico = nuevoIdPato,
                    enfermedadInfantil = form.EnfermedadInfantil,
                    antecedentesTraumatico = form.AntecedentesTraumaticos,
                    bursitis = form.Bursitis,
                    capsulitis = form.Capsulitis,
                    enfermedadReumatica = form.EnfermedadReumatica,
                    ciatica = form.Ciatica,
                    otros = form.OtrosPatologico,
                    distension = form.Distension,
                    esguince = form.Esguince,
                    tendinitis = form.Tendinitis,
                    contracturas = form.Contracturas,
                    luxacion = form.Luxacion,
                    subluxacion = form.Subluxacion,
                    fisura = form.Fisura,
                    fractura = form.Fractura,
                    patologiaPrevia = form.PatologiaPrevia
                },
                antecedentesFamiliares = new AntecedentesFamiliaresDto
                {
                    idAFamiliares = nuevoIdFam,
                    dismetrias = form.Dismetrias,
                    escoliosis = form.Escoliosis,
                    tibiasVaras = form.TibiasVaras,
                    piesPlanos = form.PiesPlanos,
                    piesCavos = form.PiesCavos,
                    piesValgos = form.PiesValgos,
                    piesZambos = form.PiesZambos,
                    hallusValgus = form.HallusValgus,
                    dedosGarra = form.DedosGarra,
                    otros = form.OtrosFamiliares,
                    genuVaro = form.GenuVaro,
                    genuValgo = form.GenuValgo,
                    metaAductus = form.MetaAductus,
                    metaVarus = form.MetaVarus
                },
                antecedentesFisiologicos = new AntecedentesFisiologicosDto
                {
                    idAFisiologico = nuevoIdFisio,
                    andador = form.Andador,
                    tacata = form.Tacata,
                    inicioDeambulacion = form.InicioDeambulacion,
                    habitosPosturales = form.HabitosPosturales,
                    cambiosPonderales = form.CambiosPonderales,
                    zurdo = form.Zurdo,
                    diestro = form.Diestro,
                    ambidiestro = form.Ambidiestro,
                    otros = form.OtrosFisiologico,
                    partoCabeza = form.PartoCabeza,
                    partoNalgas = form.PartoNalgas
                }
            };
        }

        public static FormAntecedentes FillForm(this HistorialClinicoDto historial)
        {
            AntecedentesFamiliaresDto familiares = historial.antecedentesFamiliares;
            AntecedentesFisiologicosDto fisiologicos = historial.antecedentesFisiologicos;
            AntecedentesPatologicosDto patologicos = historial.antecedentesPatologicos;
            AntecedentesPodologicosDto podologicos = historial.antecedentesPodologicos;

            return new FormAntecedentes
            {
                // historial
                IdHistorialClinico = historial.idHistorialClinico,

                // podológicos
                IdAntPodologicos = historial.id_ant_podologicos,
                HaIdoPodologo = podologicos.haidoPodologo,
                Antecedentes = podologicos.antecedentes,

                // patológicos
                IdAntPatologicos = historial.id_ant_patologicos,
                PatologiaPrevia = patologicos.patologiaPrevia,
                EnfermedadInfantil = patologicos.enfermedadInfantil,
                AntecedentesTraumaticos = patologicos.antecedentesTraumatico,
                Bursitis = patologicos.bursitis,
                Capsulitis = patologicos.capsulitis,
                EnfermedadReumatica = patologicos.enfermedadReumatica,
                TipoEnfermedadReumatica = patologicos.tipoEnfermedadReumatica,
                Ciatica = patologicos.ciatica,
                Distension = patologicos.distension,
                Esguince = patologicos.esguince,
                Tendinitis = patologicos.tendinitis,
                Contracturas = patologicos.contracturas,
                Luxacion = patologicos.luxacion,
                Subluxacion = patologicos.subluxacion,
                Fisura = patologicos.fisura,
                Fractura = patologicos.fractura,
                OtrosPatologico = patologicos.otros,

                // fisiológicos
                IdAntFisiologicos = historial.id_ant_fisiologicos,
                Andador = fisiologicos.andador,
                Tacata = fisiologicos.tacata,
                InicioDeambulacion = fisiologicos.inicioDeambulacion,
                HabitosPosturales = fisiologicos.habitosPosturales,
                CambiosPonderales = fisiologicos.cambiosPonderales,
                Zurdo = fisiologicos.zurdo,
                Diestro = fisiologicos.diestro,
                Ambidiestro = fisiologicos.ambidiestro,
                PartoCabeza = fisiologicos.partoCabeza,
                PartoNalgas = fisiologicos.partoNalgas,
                OtrosFisiologico = fisiologicos.otros,

                // familiares
                IdAntFamiliares = historial.id_ant_familiares,
                Dismetrias = familiares.dismetrias,
                Escoliosis = familiares.escoliosis,
                TibiasVaras = familiares.tibiasVaras,
                PiesPlanos = familiares.piesPlanos,
                PiesCavos = familiares.piesCavos,
                PiesValgos = familiares.piesValgos,
                PiesZambos = familiares.piesZambos,
                HallusValgus = familiares.hallusValgus,
                DedosGarra = familiares.dedosGarra,
                GenuVaro = familiares.genuVaro,
                GenuValgo = familiares.genuValgo,
                MetaAductus = familiares.metaAductus,
                MetaVarus = familiares.metaVarus,
                OtrosFamiliares = familiares.otros
            };
        }
    }
}