using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
{
    public static class PrimeraVisitaMapper
    {
        public static PrimeraVisitaModel EntityToModel(this PrimeraVisita primeraVisita)
        {
            return new PrimeraVisitaModel
            {
                idPrimeraVisita = primeraVisita.idPrimeraVisita,
                id_calzado_habitual = primeraVisita.id_calzado_habitual,
                id_estudio_ortopodologico = primeraVisita.id_estudio_ortopodologico,
                id_historial_clinico = primeraVisita.id_historial_clinico,
                id_paciente = primeraVisita.id_paciente,
                id_podologo = primeraVisita.id_podologo,
                id_tipo_estudio = primeraVisita.id_tipo_estudio,
                motivoPrimeraConsulta = primeraVisita.motivoPrimeraConsulta,
                actividadDeportiva = primeraVisita.actividadDeportiva,
                alergias = primeraVisita.alergias,
                diabetes = primeraVisita.diabetes,
                dolorSitio = primeraVisita.dolorSitio,
                dolorTipo = primeraVisita.dolorTipo,
                fechaPrimeraConsulta = primeraVisita.fechaPrimeraConsulta,
                hayDolor = primeraVisita.hayDolor,
                peso = primeraVisita.peso,
                tipoAlergias = primeraVisita.tipoAlergias,
                talla = primeraVisita.talla,
                diagnostico = primeraVisita.diagnostico.Select(x => x.EntityToModel()).ToList(),
                calzadoHabitual = primeraVisita.calzadoHabitual?.EntityToModel()
            };
        }

        public static PrimeraVisita ModelToEntity(this PrimeraVisitaModel primeraVisita)
        {
            return new PrimeraVisita
            {
                idPrimeraVisita = primeraVisita.idPrimeraVisita,
                id_calzado_habitual = primeraVisita.id_calzado_habitual,
                id_estudio_ortopodologico = primeraVisita.id_estudio_ortopodologico,
                id_historial_clinico = primeraVisita.id_historial_clinico,
                id_paciente = primeraVisita.id_paciente,
                id_podologo = primeraVisita.id_podologo,
                id_tipo_estudio = primeraVisita.id_tipo_estudio,
                motivoPrimeraConsulta = primeraVisita.motivoPrimeraConsulta,
                actividadDeportiva = primeraVisita.actividadDeportiva,
                alergias = primeraVisita.alergias,
                diabetes = primeraVisita.diabetes,
                dolorSitio = primeraVisita.dolorSitio,
                dolorTipo = primeraVisita.dolorTipo,
                fechaPrimeraConsulta = primeraVisita.fechaPrimeraConsulta,
                hayDolor = primeraVisita.hayDolor,
                peso = primeraVisita.peso,
                talla = primeraVisita.talla,
                tipoAlergias = primeraVisita.tipoAlergias,
                calzadoHabitual = primeraVisita.calzadoHabitual.ModelToEntity()
            };
        }

        public static void MapChanges(this PrimeraVisita newPrimeraVisita, ref PrimeraVisita oldPrimeraVisita)
        {
            oldPrimeraVisita.id_calzado_habitual = newPrimeraVisita.id_calzado_habitual;
            oldPrimeraVisita.id_estudio_ortopodologico = newPrimeraVisita.id_estudio_ortopodologico;
            oldPrimeraVisita.id_historial_clinico = newPrimeraVisita.id_historial_clinico;
            oldPrimeraVisita.id_paciente = newPrimeraVisita.id_paciente;
            oldPrimeraVisita.id_podologo = newPrimeraVisita.id_podologo;
            oldPrimeraVisita.id_tipo_estudio = newPrimeraVisita.id_tipo_estudio;
            oldPrimeraVisita.motivoPrimeraConsulta = newPrimeraVisita.motivoPrimeraConsulta;
            oldPrimeraVisita.actividadDeportiva = newPrimeraVisita.actividadDeportiva;
            oldPrimeraVisita.alergias = newPrimeraVisita.alergias;
            oldPrimeraVisita.diabetes = newPrimeraVisita.diabetes;
            oldPrimeraVisita.dolorSitio = newPrimeraVisita.dolorSitio;
            oldPrimeraVisita.dolorTipo = newPrimeraVisita.dolorTipo;
            oldPrimeraVisita.fechaPrimeraConsulta = newPrimeraVisita.fechaPrimeraConsulta;
            oldPrimeraVisita.hayDolor = newPrimeraVisita.hayDolor;
            oldPrimeraVisita.peso = newPrimeraVisita.peso;
            oldPrimeraVisita.tipoAlergias = newPrimeraVisita.tipoAlergias;
            oldPrimeraVisita.talla = newPrimeraVisita.talla;
        }
    }
}
