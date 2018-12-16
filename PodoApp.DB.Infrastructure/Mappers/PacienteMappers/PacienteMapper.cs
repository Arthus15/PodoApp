using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers.PacienteMappers
{
    public static class PacienteMapper
    {
        public static PacienteModel EntityToModel(this Paciente paciente)
        {
            return new PacienteModel
            {
                idPaciente = paciente.idPaciente,
                medicacionHabitual = paciente.medicacionHabitual,
                observacion = paciente.observacion,
                id_podologo = paciente.id_podologo,
                id_historial_clinico = paciente.id_historial_clinico,
                id_persona = paciente.id_persona
            };
        }

        public static Paciente ModelToEntity(this PacienteModel paciente)
        {
            return new Paciente
            {
                idPaciente = paciente.idPaciente,
                medicacionHabitual = paciente.medicacionHabitual,
                observacion = paciente.observacion,
                id_podologo = paciente.id_podologo,
                id_historial_clinico = paciente.id_historial_clinico,
                id_persona = paciente.id_persona
            };
        }
    }
}
