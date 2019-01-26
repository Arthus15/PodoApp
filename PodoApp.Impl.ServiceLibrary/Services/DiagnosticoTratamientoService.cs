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
    public class DiagnosticoTratamientoService : IDiagnosticoTratamientoService
    {
        private readonly IDiagnosticoRepository _diagnosticoRepository;
        private readonly ITratamientoRepository _tratamientoRepository;
        private readonly IMaterialSoportePlantarRepository _materialSoportePlantarRepository;

        public DiagnosticoTratamientoService(IDiagnosticoRepository diagnosticoRepository, ITratamientoRepository tratamientoRepository,
                                             IMaterialSoportePlantarRepository materialSoportePlantarRepository)
        {
            _diagnosticoRepository = diagnosticoRepository;
            _tratamientoRepository = tratamientoRepository;
            _materialSoportePlantarRepository = materialSoportePlantarRepository;
        }

        #region Public Methods
        public void Insert(DiagnosticoDto diagnostico, MaterialSoportePlantarDto materialSoportePlantar)
        {
            _diagnosticoRepository.Insert(diagnostico.DtoToModel());
            _materialSoportePlantarRepository.Insert(materialSoportePlantar.DtoToModel());
        }

        public List<object> Get(Guid idDiagnostico)
        {
            List<object> objects = new List<object>();
            var diagnostico = _diagnosticoRepository.GetByid(idDiagnostico).ModelToDto();
            var materialSoportePlantar = _materialSoportePlantarRepository.GetByIdTratamiento((Guid)diagnostico.id_tratamiento).ModelToDto();

            if(diagnostico != null && materialSoportePlantar != null)
            {
                objects.Add(diagnostico);
                objects.Add(materialSoportePlantar);
            }

            return objects;
        }

        public void Update(DiagnosticoDto diagnostico, MaterialSoportePlantarDto materialSoportePlantar)
        {            
            _diagnosticoRepository.Update(diagnostico.DtoToModel());
            _materialSoportePlantarRepository.Update(materialSoportePlantar.DtoToModel());
            _tratamientoRepository.Update(diagnostico.Tratamiento.DtoToModel());
        }



        #endregion
    }
}
