using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodoApp.Impl.ServiceLibrary.Mappers;

namespace PodoApp.Impl.ServiceLibrary.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public void InsertPacient(PacienteDto paciente)
        {
            _pacienteRepository.Insert(paciente.DtoToModel());
        }
    }
}
