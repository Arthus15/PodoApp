using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Mappers
{
    public static class PacienteMapper
    {
        public static PacienteDto ModelToDto(this PacienteModel paciente)
        {
            return new PacienteDto
            {
                idPaciente = paciente.idPaciente,
                medicacionHabitual = paciente.medicacionHabitual,
                observacion = paciente.observacion,
                id_podologo = paciente.id_podologo,
                id_historial_clinico = paciente.id_historial_clinico,
                id_persona = paciente.id_persona,
                historialClinico = paciente.historialClinico.ModelToDto(),
                persona = paciente.persona.ModelToDto(),
                primeraVisita = paciente.primeraVisita.Select(x => x.ModelToDto()).ToList()
            };
        }
    }
}
