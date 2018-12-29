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
        public static HistorialClinicoDto FormToHistorialClinicoDto(this FormAntecedentes form)
        {
            var nuevoIdPodo = Guid.NewGuid();
            var nuevoIdFam = Guid.NewGuid();
            var nuevoIdFisio = Guid.NewGuid();
            var nuevoIdPato = Guid.NewGuid();

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
                    fractura = form.Fractura
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
    }
}