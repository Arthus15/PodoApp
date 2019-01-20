using PodoApp.Contracts.ServiceLibrary.Dto;
using PodoApp.Contracts.ServiceLibrary.HelpersDto;
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
    public class PrimeraVisitaService : IPrimeraVisitaService
    {
        private readonly IPrimeraVisitaRepository _primeraVisitaRepository;
        private readonly ICalzadoHabitualRepository _calzadoHabitualRepository;
        private readonly IPodologoRepository _podologoRepository;
        private readonly IPersonaRepository _personaRepository;

        public PrimeraVisitaService(IPrimeraVisitaRepository primeraVisitaRepository,ICalzadoHabitualRepository calzadoHabitualRepository,
                                    IPersonaRepository personaRepository, IPodologoRepository podologoRepository)
        {
            _primeraVisitaRepository = primeraVisitaRepository;
            _calzadoHabitualRepository = calzadoHabitualRepository;
            _personaRepository = personaRepository;
            _podologoRepository = podologoRepository;
        }

        #region Public Methods

        public void Insert(PrimeraVisitaDto primeraVisita)
        {
            if(primeraVisita.calzadoHabitual != null)
            {
                _calzadoHabitualRepository.Insert(primeraVisita.calzadoHabitual.DtoToModel());
            }

            _primeraVisitaRepository.Insert(primeraVisita.DtoToModel());
        }

        public List<PodologoHelperDto> GetPodologos()
        {
            List<PodologoDto> podologos = _podologoRepository.GetAllIds().Select(x => x.ModelToDto()).ToList();
            List<PersonaDto> personas = _personaRepository.GetByIdList(podologos.Select(x => (Guid)x.id_persona).ToList())
                                                          .Select(x => x.ModelToDto()).ToList();
            var result = from persona in personas
                         join podologo in podologos on persona.idPersona equals podologo.id_persona
                         select new PodologoHelperDto { IdPersona = persona.idPersona, IdPodologo = podologo.idPodologo, Nombre = persona.nombre };
            return result.ToList();
        }

        public PrimeraVisitaDto Get(Guid id)
        {
            return _primeraVisitaRepository.Get(id).ModelToDto();
        }

        public void Update(PrimeraVisitaDto primeraVisita)
        {
            _calzadoHabitualRepository.Update(primeraVisita.calzadoHabitual?.DtoToModel());
            _primeraVisitaRepository.Update(primeraVisita.DtoToModel());
        }

        #endregion
    }
}
