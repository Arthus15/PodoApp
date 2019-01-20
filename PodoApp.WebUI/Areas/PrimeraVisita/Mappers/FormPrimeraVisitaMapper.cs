using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.PrimeraVisita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.PrimeraVisita.Mappers
{
    public static class FormPrimeraVisitaMapper
    {
        private static Guid idCalzado = Guid.Empty;
        private static Guid idPrimeraVisita = Guid.Empty;

        public static PrimeraVisitaDto FormToDTo(this FormPrimeraVisita form, bool newForm = true)
        {
            if (newForm)
            {
                idCalzado = Guid.NewGuid();
                idPrimeraVisita = Guid.NewGuid();
            }
            else
            {
                idCalzado = (Guid)form.IdCalzado;
                idPrimeraVisita = (Guid)form.IdPrimeraVisita;
            }

            return new PrimeraVisitaDto
            {
                idPrimeraVisita = idPrimeraVisita,
                id_calzado_habitual = form.IdCalzado,
                peso = form.Peso,
                talla = form.Altura,
                actividadDeportiva = form.ActividadDeportiva,
                diabetes = form.Diabetes,
                alergias = form.Alergias,
                tipoAlergias = form.TipoAlergia,
                motivoPrimeraConsulta = form.MotivoPrimeraConsulta,
                hayDolor = form.HayDolor,
                dolorSitio = form.ZonaDolor,
                dolorTipo = form.TipoDolor,
                fechaPrimeraConsulta = form.FechaPrimeraConsulta,
                id_paciente = form.IdPaciente,  
                id_podologo = form.IdPodologo,
                calzadoHabitual = new CalzadoHabitualDto
                {
                    idCalzado = idCalzado,
                    deportivos = form.Deportivos,
                    vestir = form.Vestir,
                    sandalias = form.Sandalias,
                    botines = form.Botines,
                    tacones = form.Tacones
                }
            };
        }

        public static FormPrimeraVisita PrimeraVisitaDtoToFormPrimeraVisita(this PrimeraVisitaDto visita)
        {
            return new FormPrimeraVisita
            {
                IdPrimeraVisita = visita.idPrimeraVisita,
                IdCalzado = visita.id_calzado_habitual,
                Peso = visita.peso,
                Altura = visita.talla,
                ActividadDeportiva = visita.actividadDeportiva,
                Diabetes = visita.diabetes,
                Alergias = visita.alergias,
                TipoAlergia = visita.tipoAlergias,
                MotivoPrimeraConsulta = visita.motivoPrimeraConsulta,
                HayDolor = visita.hayDolor,
                ZonaDolor = visita.dolorSitio,
                TipoDolor = visita.dolorTipo,
                IdPodologo = visita.id_podologo,
                FechaPrimeraConsulta = visita.fechaPrimeraConsulta,
                IdPaciente = (Guid)visita.id_paciente,
                Deportivos = (bool)visita.calzadoHabitual?.deportivos,
                Vestir = (bool)visita.calzadoHabitual?.vestir,
                Sandalias = (bool)visita.calzadoHabitual?.sandalias,
                Botines = (bool)visita.calzadoHabitual?.botines,
                Tacones = (bool)visita.calzadoHabitual?.tacones
            };
        }
    }
}