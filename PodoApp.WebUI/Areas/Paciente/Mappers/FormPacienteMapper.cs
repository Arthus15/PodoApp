using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.Paciente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.Paciente.Mappers
{
    public static class FormPacienteMapper
    {
        public static PacienteDto FormPacientToDto(this FormPaciente form)
        {
            var personaId = Guid.NewGuid();
            var nuevoIdHistorial = Guid.NewGuid();
            var nuevoIdPV = Guid.NewGuid();
            var nuevoIdPaciente = Guid.NewGuid();

            return new PacienteDto
            {
                idPaciente = nuevoIdPaciente,
                persona = new PersonaDto
                {
                    idPersona = personaId,
                    nombre = form.Nombre,
                    apellido1 = form.PrimerApellido,
                    apellido2 = form.SegundoApellido,
                    fechaNacimiento = form.FechaNacimiento,
                    edad = form.Edad,
                    profesion = form.Profesion,
                    calle = form.Direccion,
                    provincia = form.Provincia,
                    pais = form.Pais,
                    telefono = form.Telefono,
                    dni = form.Dni,
                    ciudad = form.Ciudad
                },
                historialClinico = new HistorialClinicoDto
                {
                    idHistorialClinico = nuevoIdHistorial,
                    numeroHistorialClinico = form.NumeroHistoriaClinica
                },
                medicacionHabitual = form.MedicacionHabitual,
                observacion = form.Observacion,
                id_podologo = form.IdPodologo,
                id_historial_clinico = nuevoIdHistorial,
                id_persona = personaId,
                primeraVisita = new List<PrimeraVisitaDto> {new PrimeraVisitaDto
                {
                    idPrimeraVisita = nuevoIdPV,
                    diabetes = false,
                    alergias = false,
                    hayDolor = false,
                    fechaPrimeraConsulta = DateTime.Now,
                    id_paciente = nuevoIdPaciente,
                    id_historial_clinico = nuevoIdHistorial
                }
                }
            };
        }

        public static FormPaciente PacienteDtoToFormPaciente(this PacienteDto paciente)
        {
            PersonaDto persona = paciente.persona;
            HistorialClinicoDto historial = paciente.historialClinico;

            return new FormPaciente
            {
                IdPaciente = paciente.idPaciente,
                MedicacionHabitual = paciente.medicacionHabitual,
                Observacion = paciente.observacion,
                NumeroHistoriaClinica = historial.numeroHistorialClinico,
                IdPodologo = paciente.id_podologo,

                Nombre = persona.nombre,
                PrimerApellido = persona.apellido1,
                SegundoApellido = persona.apellido2,
                FechaNacimiento = persona.fechaNacimiento,
                Edad = persona.edad,
                Profesion = persona.profesion,
                Direccion = persona.calle,
                Ciudad = persona.ciudad,
                Provincia = persona.provincia,
                Pais = persona.pais,
                Telefono = persona.telefono,
                Dni = persona.dni,
            };
        }      
    }
}