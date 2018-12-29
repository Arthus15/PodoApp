using PodoApp.DB.Infrastructure.Entities;
using PodoApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.DB.Infrastructure.Mappers
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
                id_persona = paciente.id_persona,
                persona = paciente.persona.EntityToModel(),
                historialClinico = paciente.historialClinico.EntityToModel(),
                primeraVisita = paciente.primeraVisita.Select(x => x.EntityToModel()).ToList()
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
                id_persona = paciente.id_persona,
                persona = paciente.persona.ModelToEntity(),
                historialClinico = paciente.historialClinico.ModelToEntity(),
                primeraVisita = paciente.primeraVisita.Select(x => x.ModelToEntity()).ToList()
            };
        }

        public static void MapChanges(this Paciente source, ref Paciente dest)
        {
            dest.consulta = source.consulta; 
            dest.medicacionHabitual = source.medicacionHabitual;
            dest.observacion = source.observacion;

            //Map HistorialClinico
            dest.historialClinico.numeroHistorialClinico = source.historialClinico.numeroHistorialClinico;

            //Map Persona
            dest.persona.apellido1 = source.persona.apellido1;
            dest.persona.apellido2 = source.persona.apellido2;
            dest.persona.calle = source.persona.calle;
            dest.persona.ciudad = source.persona.ciudad;
            dest.persona.dni = source.persona.dni;
            dest.persona.edad = source.persona.edad;
            dest.persona.nombre = source.persona.nombre;
            dest.persona.fechaNacimiento = source.persona.fechaNacimiento;
            dest.persona.profesion = source.persona.profesion;
            dest.persona.provincia = source.persona.provincia;
            dest.persona.telefono = source.persona.telefono;

        }
    }
}
