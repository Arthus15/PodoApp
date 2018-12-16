using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using PodoApp.Impl.ServiceLibrary.Mappers.PacienteMappers;
using PodoApp.Library.Model;

namespace PodoApp.Impl.ServiceLibrary
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public IEnumerable<PacienteDto> GetAll()
        {
            List<PacienteModel> pacientes = _pacienteRepository.GetAll().ToList();

            return pacientes.Select(x => x.ModelToDto());            
        }
    }
}
