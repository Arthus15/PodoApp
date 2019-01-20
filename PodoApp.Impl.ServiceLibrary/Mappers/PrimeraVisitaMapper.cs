using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class PrimeraVisitaMapper
    {
        public static PrimeraVisitaDto ModelToDto(this PrimeraVisitaModel primeraVisita)
        {
            return new PrimeraVisitaDto
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
                diagnostico = primeraVisita.diagnostico.Select(x => x.ModelToDto()).ToList(),
                calzadoHabitual = primeraVisita.calzadoHabitual?.ModelToDto()
            };
        }

        public static PrimeraVisitaModel DtoToModel(this PrimeraVisitaDto primeraVisita)
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
                talla = primeraVisita.talla,
                tipoAlergias = primeraVisita.tipoAlergias,                
                calzadoHabitual = primeraVisita.calzadoHabitual.DtoToModel()
            };
        }
    }
}
