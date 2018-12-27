using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using PodoApp.Impl.ServiceLibrary.Mappers;
using PodoApp.Library.Model;

namespace PodoApp.Impl.ServiceLibrary.Services
{
    public class ListaPacienteService : IListaPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public ListaPacienteService(IPacienteRepository pacienteRepository)
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
