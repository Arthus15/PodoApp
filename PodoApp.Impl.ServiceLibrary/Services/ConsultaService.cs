using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.Interfaces;
using PodoApp.Impl.ServiceLibrary.Mappers;
using PodoApp.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoApp.Impl.ServiceLibrary.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaService(IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        #region Public Methods

        public List<ConsultaDto> GetAllByPacienteId(Guid idPaciente)
        {
            return _consultaRepository.GetAllByPacienteId(idPaciente).Select(x => x.ModelToDto()).ToList();
        }

        public ConsultaDto Get(Guid idConsulta)
        {
            return _consultaRepository.Get(idConsulta).ModelToDto();
        }

        public void Insert(ConsultaDto consulta)
        {
            _consultaRepository.Insert(consulta.DtoToModel());
        }

        public void Update(ConsultaDto consulta)
        {
            _consultaRepository.Update(consulta.DtoToModel());
        }

        #endregion
    }
}
