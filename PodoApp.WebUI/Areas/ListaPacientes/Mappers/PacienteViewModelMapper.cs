using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.WebUI.Areas.ListaPacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PodoApp.WebUI.Areas.ListaPacientes.Mappers
{
    public static class PacienteViewModelMapper
    {
        public static PacienteViewModel DtoToViewModel(this PacienteDto paciente)
        {
            return new PacienteViewModel
            {
                idPaciente = paciente.idPaciente,
                medicacionHabitual = paciente.medicacionHabitual,
                observacion = paciente.observacion,
                id_podologo = paciente.id_podologo,
                id_historial_clinico = paciente.id_historial_clinico,
                id_persona = paciente.id_persona,
                IdAntFamiliares = paciente.historialClinico.id_ant_familiares,
                idPrimeraVisita = paciente.primeraVisita.FirstOrDefault().idPrimeraVisita,
                idDiagnostico = paciente.primeraVisita.FirstOrDefault().diagnostico.FirstOrDefault()?.idDiagnostico,
                nombre = paciente.persona.nombre,
                dni = paciente.persona.dni,
                numeroHistorialClinico = paciente.historialClinico.numeroHistorialClinico

            };
        }
    }
}