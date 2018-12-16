using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;

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
            return null;
            
        }
    }
}
