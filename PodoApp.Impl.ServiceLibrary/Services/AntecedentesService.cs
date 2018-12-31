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
    public class AntecedentesService : IAntecedentesService
    {
        private readonly IHistorialClínicoRepository _historialClinicoRepository;
        private readonly IAntecedentesFamiliaresRepository _antecedentesFamiliaresRepository;
        private readonly IAntecedentesFisiologicosRepository _antecedentesFisiologicosRepository;
        private readonly IAntecedentesPatologicosRepository _antecedentesPatologicosRepository;
        private readonly IAntecedentesPodologicosRepository _antecedentesPodologicosRepository;

        public AntecedentesService(IHistorialClínicoRepository historialClínicoRepository,
            IAntecedentesFamiliaresRepository antecedentesFamiliaresRepository,
            IAntecedentesFisiologicosRepository antecedentesFisiologicosRepository,
            IAntecedentesPatologicosRepository antecedentesPatologicosRepository,
            IAntecedentesPodologicosRepository antecedentesPodologicosRepository)
        {
            _historialClinicoRepository = historialClínicoRepository;
            _antecedentesFamiliaresRepository = antecedentesFamiliaresRepository;
            _antecedentesFisiologicosRepository = antecedentesFisiologicosRepository;
            _antecedentesPatologicosRepository = antecedentesPatologicosRepository;
            _antecedentesPodologicosRepository = antecedentesPodologicosRepository;
        }

        public void Insert(HistorialClinicoDto historialClinico)
        {            
            _antecedentesFamiliaresRepository.Insert(historialClinico.antecedentesFamiliares.DtoToModel());
            _antecedentesFisiologicosRepository.Insert(historialClinico.antecedentesFisiologicos.DtoToModel());
            _antecedentesPatologicosRepository.Insert(historialClinico.antecedentesPatologicos.DtoToModel());
            _antecedentesPodologicosRepository.Insert(historialClinico.antecedentesPodologicos.DtoToModel());
            _historialClinicoRepository.Update(historialClinico.DtoToModel());
        }

        public void Update(HistorialClinicoDto historialClinico)
        {
            _antecedentesFamiliaresRepository.Update(historialClinico.antecedentesFamiliares.DtoToModel());
            _antecedentesFisiologicosRepository.Update(historialClinico.antecedentesFisiologicos.DtoToModel());
            _antecedentesPatologicosRepository.Update(historialClinico.antecedentesPatologicos.DtoToModel());
            _antecedentesPodologicosRepository.Update(historialClinico.antecedentesPodologicos.DtoToModel());
        }
    }
}
